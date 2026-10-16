using System.Reflection;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;

namespace GF2.SkinPack;

public sealed class GF2SkinPackMod : IModMetadata
{
    public string ModGuid { get; init; } = "com.gf2.skinpack";
    public string Name { get; init; } = "GF2 Skin Pack";
    public string Author { get; init; } = "GF2 Skin Pack";
    public List<string> Contributors { get; init; } = [];
    public SemanticVersioning.Version Version { get; init; } = new("1.0.0");
    public Range SptVersion { get; init; } = new("~4.1.0");
    public bool HasPrepatcher { get; init; } = false;
    public List<string> Incompatibilities { get; init; } = [];
    public Dictionary<string, Range> ModDependencies { get; init; } = new() { ["com.wtt.commonlib"] = new Range("~3.0.0") };
    public string Url { get; init; } = "";
    public string License { get; init; } = "MIT";
}

[Injectable(TypePriority = OnLoadOrder.Preload + 10)]
public sealed class GF2SkinPackLoader(WTTServerCommonLib.WTTServerCommonLib commonLib) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        var assembly = Assembly.GetExecutingAssembly();
        await commonLib.CustomClothingService.CreateCustomClothing(assembly);
        await commonLib.CustomHeadService.CreateCustomHeads(assembly);
    }
}
