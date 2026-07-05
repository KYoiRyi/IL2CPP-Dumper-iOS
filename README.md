# IL2CPP Dumper iOS Tweak

Runtime metadata dumper for Unity IL2CPP games packaged as a Theos iOS tweak.

This fork is packaged for MobileSubstrate/Substitute and starts from a tweak
constructor inside the target app process.

## What It Does

- Waits for the IL2CPP runtime to become available in the target app.
- Resolves IL2CPP exports with `dlsym` from the current process.
- Attaches the worker thread with `il2cpp_thread_attach` when available.
- Writes static C#-shaped metadata dumps and AI-friendly line-tagged dumps.
- Can optionally write live scene, camera, mesh collider, and targeted class
  scan dumps.

## Output

By default, files are written to:

```text
/var/mobile/Documents/IL2CPP-Dumper
```

Set `IL2CPP_DUMPER_OUTPUT` in the target process environment to override it.

Static outputs:

- `IL2CPP_Dump_Normal/<assembly>.cs`
- `IL2CPP_Dump_AI/<assembly>.cs`
- `IL2CPP_Dump_Strings.txt`
- `IL2CPPDump_Log.txt`

Optional live outputs:

- `IL2CPP_World_Dump_<timestamp>.txt`
- `IL2CPP_Camera_<timestamp>.txt`
- `IL2CPP_MeshColliders_<timestamp>.txt`
- `IL2CPP_MeshColliders_<timestamp>.bin`
- `IL2CPP_Scan_<timestamp>.txt`

## Configure Injection

Edit `IL2CPPDumper.plist` and replace:

```text
com.example.unitygame
```

with the target app bundle identifier.

The Linux build helper can do this automatically:

```bash
TARGET_BUNDLE_ID=com.company.game ./scripts/build_linux.sh
```

## Build On Linux

Run:

```bash
./scripts/build_linux.sh
```

The script installs host build tools when it recognizes the package manager,
clones Theos, downloads Theos iPhoneOS SDKs, links the selected SDK into Theos,
and runs:

```bash
make clean package FINALPACKAGE=1
```

Environment variables:

- `TARGET_BUNDLE_ID`: replaces the placeholder filter bundle id.
- `IOS_SDK_VERSION`: selects a specific SDK, for example `16.5`. Defaults to
  the latest SDK found in the downloaded SDK repository.
- `THEOS`: uses an existing Theos checkout instead of `.deps/theos`.

The resulting Debian package is written under `packages/`.

## Runtime Options

Static dumping runs automatically after IL2CPP is ready.

Set these environment variables in the target process to enable extra runtime
passes:

- `IL2CPP_DUMPER_SCENE=1`: run camera, scene, and mesh collider dumps once.
- `IL2CPP_DUMPER_DEEP_SCENE=1`: include MonoBehaviour field values during the
  scene pass.

For targeted class scans, place `IL2CPP_ScanList.txt` in the output directory
with one fully-qualified class name per line.

## iOS Notes

- The old Windows structured exception handling was removed. The compatibility
  wrappers compile as normal C++ `try/catch`, but invalid raw IL2CPP pointers can
  still crash the target process on iOS.
- The tweak expects exported IL2CPP symbols. If a game strips or hides them, a
  symbol-offset resolver must be added for that title.
- Keep the tweak filter narrow. Injecting into unrelated apps is noisy and may
  crash them.

## License

MIT.
