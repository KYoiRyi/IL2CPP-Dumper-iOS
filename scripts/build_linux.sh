#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DEPS_DIR="${ROOT_DIR}/.deps"
THEOS_DIR="${THEOS:-${DEPS_DIR}/theos}"
SDK_REPO="${DEPS_DIR}/theos-sdks"

TARGET_BUNDLE_ID="${TARGET_BUNDLE_ID:-}"
SDK_VERSION="${IOS_SDK_VERSION:-latest}"

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
      bash ca-certificates clang coreutils curl fakeroot git ldid make perl \
      rsync unzip xz-utils zip
  elif need_cmd pacman; then
    log "Installing Linux host dependencies with pacman"
    sudo pacman -Sy --needed --noconfirm \
      bash ca-certificates clang curl fakeroot git ldid make perl rsync unzip xz zip
  elif need_cmd dnf; then
    log "Installing Linux host dependencies with dnf"
    sudo dnf install -y \
      bash ca-certificates clang curl fakeroot git ldid make perl rsync unzip xz zip
  else
    log "No supported package manager found; install clang, make, git, curl, fakeroot, ldid, perl, rsync, unzip, xz, and zip manually"
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
clone_or_update "https://github.com/theos/theos.git" "${THEOS_DIR}"
git -C "${THEOS_DIR}" submodule update --init --recursive
clone_or_update "https://github.com/theos/sdks.git" "${SDK_REPO}"
select_sdk
patch_bundle_filter

export THEOS="${THEOS_DIR}"

log "Building tweak package"
make -C "${ROOT_DIR}" clean package FINALPACKAGE=1

log "Done. Packages are in ${ROOT_DIR}/packages"
