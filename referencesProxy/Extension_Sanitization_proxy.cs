// Proxy for reference Extension with name Sanitization and key _JJU+h_V0kGlisiHEUD5zw
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExtensionSanitization
/// </summary>
public partial class RssExtensionSanitization {
/// <summary>
/// Extension Variable: issSanitization
/// </summary>
protected static OutSystems.NssSanitization.IssSanitization issSanitization =(OutSystems.NssSanitization.IssSanitization)ServiceLocator.GetService<OutSystems.NssSanitization.CssSanitization>();
protected static readonly string extensionVersion = typeof(OutSystems.NssSanitization.CssSanitization).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExtensionSanitization");
public static async Task<string> MssBuildSafe_InClauseTextList(IRequestContext requestContext,OutSystems.Application.Extensibility.DataTypes.IRecordList inParamValueList,CancellationToken cancellationToken) {
string outParamOutput = default;
var _proxyinParamValueList = new OutSystems.NssSanitization.RLTextLiteralRecordList();
_proxyinParamValueList.CopyFrom(inParamValueList);cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("BuildSafe_InClauseTextList", "8f0a1b23-e7d5-4a4a-95d4-96230048f861"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("BuildSafe_InClauseTextList", "8f0a1b23-e7d5-4a4a-95d4-96230048f861", "Sanitization", "fa5492fc-d51f-41d2-a58a-c8871140f9cf", extensionVersion) : null){
issSanitization.MssBuildSafe_InClauseTextList(_proxyinParamValueList,out outParamOutput);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamOutput;
}



public class DefaultValues {
}
}
}
