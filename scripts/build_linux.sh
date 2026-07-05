#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DEPS_DIR="${ROOT_DIR}/.deps"
THEOS_DIR="${THEOS:-${DEPS_DIR}/theos}"
SDK_REPO="${DEPS_DIR}/theos-sdks"
BIN_DIR="${DEPS_DIR}/bin"

TARGET_BUNDLE_ID="${TARGET_BUNDLE_ID:-}"
SDK_VERSION="${IOS_SDK_VERSION:-16.5}"
SWIFT_TOOLCHAIN_ARCHIVE="${DEPS_DIR}/swift-5.8-ubuntu20.04.tar.xz"

log() {
  printf '[build] %s\n' "$*"
}

need_cmd() {
  command -v "$1" >/dev/null 2>&1
}

install_host_deps() {
  if need_cmd apt-get; then
    log "Installing Linux host dependencies with apt-get"
    sudo apt-get update
    sudo apt-get install -y \
      bash ca-certificates clang coreutils curl fakeroot git make perl \
      rsync unzip xz-utils zip
  elif need_cmd pacman; then
    log "Installing Linux host dependencies with pacman"
    sudo pacman -Sy --needed --noconfirm \
      bash ca-certificates clang curl fakeroot git make perl rsync unzip xz zip
    sudo pacman -Sy --needed --noconfirm ldid || true
  elif need_cmd dnf; then
    log "Installing Linux host dependencies with dnf"
    sudo dnf install -y \
      bash ca-certificates clang curl fakeroot git make perl rsync unzip xz zip
    sudo dnf install -y ldid || true
  else
    log "No supported package manager found; install clang, make, git, curl, fakeroot, ldid, perl, rsync, unzip, xz, and zip manually"
  fi
}

install_ldid() {
  if need_cmd ldid; then
    log "Using existing ldid: $(command -v ldid)"
    return
  fi

  local arch asset url out
  arch="$(uname -m)"
  case "${arch}" in
    x86_64|amd64)
      asset="ldid_linux_x86_64"
      ;;
    aarch64|arm64)
      asset="ldid_linux_arm64"
      ;;
    *)
      log "Unsupported host architecture for automatic ldid download: ${arch}"
      log "Install ldid manually, then rerun this script"
      exit 1
      ;;
  esac

  mkdir -p "${BIN_DIR}"
  out="${BIN_DIR}/ldid"
  url="https://github.com/ProcursusTeam/ldid/releases/download/v2.1.5-procursus7/${asset}"

  log "Downloading ${asset}"
  curl -fsSL "${url}" -o "${out}"
  chmod +x "${out}"
  export PATH="${BIN_DIR}:${PATH}"

  if ! need_cmd ldid; then
    log "ldid download completed but the binary is not executable from PATH"
    exit 1
  fi
}

clone_or_update() {
  local url="$1"
  local dir="$2"
  if [ -d "${dir}/.git" ]; then
    log "Updating ${dir}"
    git -C "${dir}" pull --ff-only
  else
    log "Cloning ${url}"
    git clone --recursive "${url}" "${dir}"
  fi
}

install_swift_toolchain() {
  local marker="${THEOS_DIR}/toolchain/.swift-5.8-ready"
  if [ -f "${marker}" ] && [ -x "${THEOS_DIR}/toolchain/linux/iphone/bin/clang" ]; then
    log "Using existing Swift 5.8 iOS toolchain"
    return
  fi

  mkdir -p "${DEPS_DIR}" "${THEOS_DIR}/toolchain"
  if [ ! -f "${SWIFT_TOOLCHAIN_ARCHIVE}" ]; then
    log "Downloading Swift 5.8 iOS toolchain"
    curl -fL --retry 5 \
      "https://github.com/kabiroberai/swift-toolchain-linux/releases/download/v2.3.0/swift-5.8-ubuntu20.04.tar.xz" \
      -o "${SWIFT_TOOLCHAIN_ARCHIVE}"
  fi

  rm -rf "${THEOS_DIR}/toolchain/linux"
  tar -xJf "${SWIFT_TOOLCHAIN_ARCHIVE}" -C "${THEOS_DIR}/toolchain"
  touch "${marker}"
}

select_sdk() {
  local sdk_name
  if [ "${SDK_VERSION}" = "latest" ]; then
    sdk_name="$(find "${SDK_REPO}" -maxdepth 1 -type d -name 'iPhoneOS*.sdk' \
      -printf '%f\n' | sort -V | tail -n 1)"
  else
    sdk_name="iPhoneOS${SDK_VERSION}.sdk"
  fi

  if [ -z "${sdk_name}" ] || [ ! -d "${SDK_REPO}/${sdk_name}" ]; then
    log "Requested SDK was not found in ${SDK_REPO}"
    exit 1
  fi

  mkdir -p "${THEOS_DIR}/sdks"
  rm -f "${THEOS_DIR}/sdks/${sdk_name}"
  ln -sfn "${SDK_REPO}/${sdk_name}" "${THEOS_DIR}/sdks/${sdk_name}"
  log "Using ${sdk_name}"
}

patch_bundle_filter() {
  if [ -n "${TARGET_BUNDLE_ID}" ]; then
    perl -0pi -e "s/com\\.example\\.unitygame/${TARGET_BUNDLE_ID}/g" \
      "${ROOT_DIR}/IL2CPPDumper.plist"
    log "Set tweak bundle filter to ${TARGET_BUNDLE_ID}"
  else
    log "TARGET_BUNDLE_ID is not set; IL2CPPDumper.plist still contains the placeholder bundle id"
  fi
}

install_host_deps
mkdir -p "${DEPS_DIR}"
install_ldid
clone_or_update "https://github.com/theos/theos.git" "${THEOS_DIR}"
git -C "${THEOS_DIR}" submodule update --init --recursive
install_swift_toolchain
clone_or_update "https://github.com/theos/sdks.git" "${SDK_REPO}"
select_sdk
patch_bundle_filter

export THEOS="${THEOS_DIR}"

log "Building tweak package"
make -C "${ROOT_DIR}" clean package FINALPACKAGE=1

log "Done. Packages are in ${ROOT_DIR}/packages"
