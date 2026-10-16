# GF2 Skin Pack

Character appearance pack for SPT 4.1.6. Release preparation is in progress.

## Source status

This source was recovered from the original development chat, including the
later loader-priority correction. It successfully compiled in a local check
against SPT 4.1.0 and WTT CommonLib 3.0.5 references, with four nullability warnings.
That check used a separate build project. Equivalence with the existing gameplay-tested
distribution DLL has not yet been established. The portable project in this
repository still needs a fresh build check with the reference files below.

## Build

1. Install the .NET 10 SDK.
2. Create a `refs` folder alongside `src`.
3. Copy these reference assemblies from the versions used to develop/test the mod:
   - SPTarkov.Server.Core.dll
   - SPTarkov.DI.dll
   - SPTarkov.Common.dll
   - SemanticVersioning.dll
   - WTTServerCommonLib.dll
4. Run `dotnet build src/GF2.SkinPack.csproj -c Release`.
5. The output is `src/bin/Release/net10.0/GF2.SkinPack.dll`.

The original development environment used an assembly named WTTServerCommonLib.dll.
The NuGet package may instead supply WTT-ServerCommonLib.dll; when using that
package, update the reference Include/HintPath to its actual assembly name/path.
Use the runtime-compatible assembly and test the resulting DLL before distribution.
Reference binaries are not included here. The game bundles and configuration data
are also not included in this source-only upload.

## Runtime dependency

WTT - CommonLib. Recovered metadata declares `~3.0.0`; the precise version used
in gameplay testing is still being confirmed. SPT compatibility metadata declares
`~4.1.0`, while gameplay testing reported by the author was on SPT 4.1.6.

## Credits and asset rights

MICA Team / Sunborn — Girls' Frontline and Girls' Frontline 2 characters and assets,
according to the author's source information. Local original-model documentation
also credits DesmondChan for rigging/fixes; per-model attribution is being checked.

Model redistribution terms remain under review. The `MIT` string in recovered
code metadata is not a license grant for third-party models, textures, or voices.
No third-party asset license is granted by this repository. Final code and asset
license documentation will be added after verification.
