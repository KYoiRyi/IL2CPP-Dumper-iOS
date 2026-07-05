#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DEPS_DIR="${ROOT_DIR}/.deps"
THEOS_DIR="${DEPS_DIR}/theos"
SDK_REPO="${DEPS_DIR}/theos-sdks"
BIN_DIR="${DEPS_DIR}/bin"
LOG_DIR="${ROOT_DIR}/build_logs"
LOG_FILE="${LOG_DIR}/build_$(date +%Y%m%d_%H%M%S).log"
SDK_VERSION="${IOS_SDK_VERSION:-16.5}"
SDK_NAME="iPhoneOS${SDK_VERSION}.sdk"
SWIFT_TOOLCHAIN_ARCHIVE="${DEPS_DIR}/swift-5.8-ubuntu20.04.tar.xz"
SWIFT_TOOLCHAIN_MARKER="${THEOS_DIR}/toolchain/.swift-5.8-ready"

mkdir -p "${LOG_DIR}"
exec > >(tee -a "${LOG_FILE}") 2>&1
echo "Build log: ${LOG_FILE}"

if [ ! -d "${THEOS_DIR}" ]; then
  echo "Missing ${THEOS_DIR}. Prepare dependencies from Windows first."
  exit 1
fi

if [ ! -d "${SDK_REPO}/${SDK_NAME}" ]; then
  echo "Missing ${SDK_REPO}/${SDK_NAME}."
  exit 1
fi

if [ -f "${SWIFT_TOOLCHAIN_ARCHIVE}" ] && [ ! -f "${SWIFT_TOOLCHAIN_MARKER}" ]; then
  echo "Installing prepared Swift 5.8 iOS toolchain..."
  rm -rf "${THEOS_DIR}/toolchain/linux"
  tar -xJf "${SWIFT_TOOLCHAIN_ARCHIVE}" -C "${THEOS_DIR}/toolchain"
  touch "${SWIFT_TOOLCHAIN_MARKER}"
fi

if [ ! -x "${THEOS_DIR}/toolchain/linux/iphone/bin/clang" ]; then
  chmod -R u+rwX "${THEOS_DIR}/toolchain" || true
  find "${THEOS_DIR}/toolchain/linux/iphone/bin" -type f -exec chmod u+x {} +
fi

if [ -f "${BIN_DIR}/ldid" ]; then
  chmod u+x "${BIN_DIR}/ldid"
fi

repair_pseudo_symlinks() {
  local root="$1"
  local file target target_path

  while IFS= read -r -d '' file; do
    target="$(tr -d '\r\n' < "${file}")"
    case "${target}" in
      ""|/*|*' '*|*$'\t'*)
        continue
        ;;
    esac

    target_path="$(dirname "${file}")/${target}"
    if [ ! -e "${target_path}" ]; then
      continue
    fi

    rm -f "${file}"
    if ! ln -s "${target}" "${file}" 2>/dev/null; then
      cp -a "${target_path}" "${file}"
    fi
  done < <(find "${root}" -type f -size -256c -print0)
}

repair_pseudo_symlinks "${SDK_REPO}/${SDK_NAME}"
repair_pseudo_symlinks "${THEOS_DIR}/toolchain/linux/iphone"

mkdir -p "${THEOS_DIR}/sdks"
rm -rf "${THEOS_DIR}/sdks/${SDK_NAME}"
ln -sfn "../../theos-sdks/${SDK_NAME}" "${THEOS_DIR}/sdks/${SDK_NAME}"

export THEOS="${THEOS_DIR}"
export PATH="${BIN_DIR}:${PATH}"

make -C "${ROOT_DIR}" clean package FINALPACKAGE=1
