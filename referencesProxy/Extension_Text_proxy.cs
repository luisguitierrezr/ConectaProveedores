// Proxy for reference Extension with name Text and key crJqsOYeg0SOhXNYSUQzkg
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExtensionText
/// </summary>
public partial class RssExtensionText {
/// <summary>
/// Extension Variable: issText
/// </summary>
protected static OutSystems.NssText.IssText issText =(OutSystems.NssText.IssText)ServiceLocator.GetService<OutSystems.NssText.CssText>();
protected static readonly string extensionVersion = typeof(OutSystems.NssText.CssText).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExtensionText");
public static async Task<string> MssRegex_Replace(IRequestContext requestContext,string inParamText,string inParamRegexPattern,string inParamNewString,bool inParamIgnoreCase,bool inParamMultiLine,bool inParamSingleLine,CancellationToken cancellationToken) {
string outParamResult = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("Regex_Replace", "e7222b03-4cb7-4227-82d0-66251b672ea7"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("Regex_Replace", "e7222b03-4cb7-4227-82d0-66251b672ea7", "Text", "b06ab272-1ee6-4483-8e85-735849443392", extensionVersion) : null){
issText.MssRegex_Replace(inParamText,inParamRegexPattern,inParamNewString,inParamIgnoreCase,inParamMultiLine,inParamSingleLine,out outParamResult);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamResult;
}


public static async Task<OutSystems.Application.Extensibility.DataTypes.IRecordList> MssString_Split<ToutParamList>(IRequestContext requestContext,string inParamText,string inParamDelimiters,CancellationToken cancellationToken) where ToutParamList : OutSystems.Application.Extensibility.DataTypes.IRecordList,new() {
OutSystems.Application.Extensibility.DataTypes.IRecordList outParamList = default;
outParamList = new ToutParamList();;
OutSystems.NssText.RLTextRecordList _proxyoutParamList = new OutSystems.NssText.RLTextRecordList();
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("String_Split", "1bfff05e-3ca7-47bc-ab04-18bfb301a55f"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("String_Split", "1bfff05e-3ca7-47bc-ab04-18bfb301a55f", "Text", "b06ab272-1ee6-4483-8e85-735849443392", extensionVersion) : null){
issText.MssString_Split(inParamText,inParamDelimiters,out _proxyoutParamList);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamList.CopyFrom(_proxyoutParamList);await Task.Yield();
return outParamList;
}


public static async Task<(bool,string,int)> MssRegex_Search(IRequestContext requestContext,string inParamText,string inParamRegexPattern,bool inParamIgnoreCase,bool inParamMultiLine,bool inParamSingleLine,CancellationToken cancellationToken) {
bool outParamFound = default;
string outParamPatternResult = default;
int outParamFirstIndex = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("Regex_Search", "8494954b-2c53-4ae1-8d94-e300f15a170f"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("Regex_Search", "8494954b-2c53-4ae1-8d94-e300f15a170f", "Text", "b06ab272-1ee6-4483-8e85-735849443392", extensionVersion) : null){
issText.MssRegex_Search(inParamText,inParamRegexPattern,inParamIgnoreCase,inParamMultiLine,inParamSingleLine,out outParamFound,out outParamPatternResult,out outParamFirstIndex);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return (outParamFound,outParamPatternResult,outParamFirstIndex);
}


public static async Task<string> MssString_Join(IRequestContext requestContext,OutSystems.Application.Extensibility.DataTypes.IRecordList inParamList,string inParamSeparator,CancellationToken cancellationToken) {
string outParamText = default;
var _proxyinParamList = new OutSystems.NssText.RLTextRecordList();
_proxyinParamList.CopyFrom(inParamList);cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("String_Join", "1cf751c0-0149-42cb-a39f-8982dd6393b3"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("String_Join", "1cf751c0-0149-42cb-a39f-8982dd6393b3", "Text", "b06ab272-1ee6-4483-8e85-735849443392", extensionVersion) : null){
issText.MssString_Join(_proxyinParamList,inParamSeparator,out outParamText);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamText;
}



public class DefaultValues {
}
}
}
