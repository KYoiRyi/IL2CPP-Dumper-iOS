param(
    [string]$WorkspaceRoot = "D:\xuesongTest1",
    [string]$UnpackedAppDir = "",
    [string]$DylibPath = "",
    [string]$RunId = "",
    [string]$OutputIpa = "",
    [string]$WorkDir = "",
    [switch]$SkipDownload,
    [switch]$Plain,
    [switch]$PatchedNoReceiver
)

$ErrorActionPreference = "Stop"

function Resolve-FullPath([string]$Path) {
    return [System.IO.Path]::GetFullPath($Path)
}

function Invoke-Step([string]$Name, [scriptblock]$Body) {
    Write-Host "==> $Name"
    & $Body
}

$RepoRoot = Resolve-FullPath (Join-Path $PSScriptRoot "..")
$WorkspaceRoot = Resolve-FullPath $WorkspaceRoot

if (-not $UnpackedAppDir) {
    $UnpackedAppDir = Join-Path $WorkspaceRoot "com.kedrgame.xuesong_1.0.1_und3fined"
}
$UnpackedAppDir = Resolve-FullPath $UnpackedAppDir

if (-not $OutputIpa) {
    if ($PatchedNoReceiver) {
        $OutputIpa = Join-Path $WorkspaceRoot "xuesong_1.0.1_patched_no_receiver_unsigned.ipa"
    }
    elseif ($Plain) {
        $OutputIpa = Join-Path $WorkspaceRoot "xuesong_1.0.1_plain_repacked_unsigned.ipa"
    }
    else {
        $OutputIpa = Join-Path $WorkspaceRoot "xuesong_1.0.1_static_probe_logging_unsigned.ipa"
    }
}
$OutputIpa = Resolve-FullPath $OutputIpa

if (-not $WorkDir) {
    $WorkDir = Join-Path $WorkspaceRoot "patched_ipa_work"
}
$WorkDir = Resolve-FullPath $WorkDir

$OriginalUnityFramework = Join-Path $UnpackedAppDir "Payload\ProductName.app\Frameworks\UnityFramework.framework\UnityFramework"
$PatchedUnityFramework = Join-Path $WorkspaceRoot "UnityFramework.xuesong.patched"
$PatchReport = Join-Path $WorkspaceRoot "xuesong_patch_report.json"
$ArtifactsDir = Join-Path $WorkspaceRoot "artifacts"

if (-not (Test-Path $OriginalUnityFramework)) {
    throw "UnityFramework not found: $OriginalUnityFramework"
}

if ($PatchedNoReceiver) {
    Invoke-Step "Patch UnityFramework without receiver load command" {
        python (Join-Path $RepoRoot "scripts\patch_unityframework.py") `
            $OriginalUnityFramework `
            $PatchedUnityFramework `
            --report $PatchReport `
            --no-load-dylib
    }
}
elseif (-not $Plain) {
    Invoke-Step "Patch UnityFramework" {
        python (Join-Path $RepoRoot "scripts\patch_unityframework.py") `
            $OriginalUnityFramework `
            $PatchedUnityFramework `
            --report $PatchReport
    }

    if (-not $DylibPath) {
        $DylibPath = Join-Path $ArtifactsDir "libXueSongProbe.dylib"
    }
    $DylibPath = Resolve-FullPath $DylibPath

    if (-not $SkipDownload) {
        Invoke-Step "Download latest successful dylib artifact" {
            if (Test-Path $ArtifactsDir) {
                Remove-Item -Recurse -Force $ArtifactsDir
            }
            New-Item -ItemType Directory -Path $ArtifactsDir | Out-Null

            if (-not $RunId) {
                $RunId = (& gh run list --branch xuesong-unityframework-probe --workflow "macOS Theos Build" --status success --limit 1 --json databaseId --jq '.[0].databaseId').Trim()
            }
            if (-not $RunId) {
                throw "Could not find a successful GitHub Actions run. Pass -RunId or -SkipDownload -DylibPath."
            }
            gh run download $RunId -n XueSongProbe-ios-dylib -D $ArtifactsDir
        }
    }

    if (-not (Test-Path $DylibPath)) {
        throw "Probe dylib not found: $DylibPath"
    }
}

Invoke-Step "Stage app" {
    if (Test-Path $WorkDir) {
        Remove-Item -Recurse -Force $WorkDir
    }
    New-Item -ItemType Directory -Path $WorkDir | Out-Null

    Copy-Item -Recurse -Force (Join-Path $UnpackedAppDir "Payload") $WorkDir

    if ($PatchedNoReceiver) {
        $TargetUnityFramework = Join-Path $WorkDir "Payload\ProductName.app\Frameworks\UnityFramework.framework\UnityFramework"
        Copy-Item -Force $PatchedUnityFramework $TargetUnityFramework
    }
    elseif (-not $Plain) {
        $TargetUnityFramework = Join-Path $WorkDir "Payload\ProductName.app\Frameworks\UnityFramework.framework\UnityFramework"
        $TargetDylib = Join-Path $WorkDir "Payload\ProductName.app\Frameworks\libXueSongProbe.dylib"

        Copy-Item -Force $PatchedUnityFramework $TargetUnityFramework
        Copy-Item -Force $DylibPath $TargetDylib
    }
}

if ($PatchedNoReceiver) {
    Invoke-Step "Verify patched UnityFramework has no receiver load command" {
        $TargetUnityFramework = Join-Path $WorkDir "Payload\ProductName.app\Frameworks\UnityFramework.framework\UnityFramework"
        $verify = @"
import lief
p = r'''$TargetUnityFramework'''
b = lief.parse(p)
ok = not bool(b.find_library('@executable_path/Frameworks/libXueSongProbe.dylib'))
print(ok)
raise SystemExit(0 if ok else 1)
"@
        $verify | python -
    }
}
elseif (-not $Plain) {
    Invoke-Step "Verify patched UnityFramework load command" {
    $TargetUnityFramework = Join-Path $WorkDir "Payload\ProductName.app\Frameworks\UnityFramework.framework\UnityFramework"
    $verify = @"
import lief
p = r'''$TargetUnityFramework'''
b = lief.parse(p)
ok = bool(b.find_library('@executable_path/Frameworks/libXueSongProbe.dylib'))
print(ok)
raise SystemExit(0 if ok else 1)
"@
        $verify | python -
    }
}

Invoke-Step "Package IPA" {
    $pack = @"
from pathlib import Path
import stat
import zipfile

root = Path(r'''$WorkDir''')
out = Path(r'''$OutputIpa''')
if out.exists():
    out.unlink()

exec_names = {
    'Payload/ProductName.app/ProductName',
    'Payload/ProductName.app/Frameworks/UnityFramework.framework/UnityFramework',
    'Payload/ProductName.app/Frameworks/libXueSongProbe.dylib',
}

with zipfile.ZipFile(out, 'w', compression=zipfile.ZIP_DEFLATED, compresslevel=9) as zf:
    for path in sorted(root.rglob('*')):
        rel = path.relative_to(root).as_posix()
        if path.is_dir():
            info = zipfile.ZipInfo(rel.rstrip('/') + '/')
            info.external_attr = (0o755 | stat.S_IFDIR) << 16
            zf.writestr(info, b'')
            continue
        info = zipfile.ZipInfo(rel)
        mode = 0o755 if rel in exec_names else 0o644
        info.external_attr = (mode | stat.S_IFREG) << 16
        zf.writestr(info, path.read_bytes(), compress_type=zipfile.ZIP_DEFLATED, compresslevel=9)
"@
    $pack | python -
}

Invoke-Step "Verify IPA contents" {
    Add-Type -AssemblyName System.IO.Compression.FileSystem
    $zip = [System.IO.Compression.ZipFile]::OpenRead($OutputIpa)
    try {
        if ($Plain) {
            $needed = @(
                "Payload/ProductName.app/Frameworks/UnityFramework.framework/UnityFramework",
                "Payload/ProductName.app/ProductName"
            )
        }
        elseif ($PatchedNoReceiver) {
            $needed = @(
                "Payload/ProductName.app/Frameworks/UnityFramework.framework/UnityFramework",
                "Payload/ProductName.app/ProductName"
            )
        }
        else {
            $needed = @(
                "Payload/ProductName.app/Frameworks/libXueSongProbe.dylib",
                "Payload/ProductName.app/Frameworks/UnityFramework.framework/UnityFramework"
            )
        }
        foreach ($entryName in $needed) {
            $entry = $zip.Entries | Where-Object { $_.FullName -eq $entryName } | Select-Object -First 1
            if (-not $entry) {
                throw "Missing IPA entry: $entryName"
            }
            Write-Host "    $($entry.FullName) $($entry.Length)"
        }
    }
    finally {
        $zip.Dispose()
    }
}

$hash = Get-FileHash $OutputIpa -Algorithm SHA256
Write-Host "==> Done"
Write-Host "IPA:    $OutputIpa"
Write-Host "SHA256: $($hash.Hash)"
Write-Host "Note: this IPA is unsigned after binary modification; re-sign before installing."
