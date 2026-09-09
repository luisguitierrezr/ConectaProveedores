// Proxy for reference Extension with name Xml and key QHSpmI8unkifpseiIwyDlg
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExtensionXml
/// </summary>
public partial class RssExtensionXml {
/// <summary>
/// Extension Variable: issXml
/// </summary>
protected static OutSystems.NssXml.IssXml issXml =(OutSystems.NssXml.IssXml)ServiceLocator.GetService<OutSystems.NssXml.CssXml>();
protected static readonly string extensionVersion = typeof(OutSystems.NssXml.CssXml).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExtensionXml");
public static async Task<int> MssXMLNodeList_Count(IRequestContext requestContext,object inParamXMLNodeList,CancellationToken cancellationToken) {
int outParamCount = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("XMLNodeList_Count", "e2692403-9a32-4ad2-a1cf-e9584b07b955"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("XMLNodeList_Count", "e2692403-9a32-4ad2-a1cf-e9584b07b955", "Xml", "98a97440-2e8f-489e-9fa6-c7a2230c8396", extensionVersion) : null){
issXml.MssXMLNodeList_Count(inParamXMLNodeList,out outParamCount);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamCount;
}


public static async Task<object> MssXMLElement_SelectSingleNode(IRequestContext requestContext,object inParamXMLElement,string inParamXPathString,CancellationToken cancellationToken) {
object outParamXMLNode = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("XMLElement_SelectSingleNode", "f2a1cbde-1ddf-4400-bc44-f8bbef439124"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("XMLElement_SelectSingleNode", "f2a1cbde-1ddf-4400-bc44-f8bbef439124", "Xml", "98a97440-2e8f-489e-9fa6-c7a2230c8396", extensionVersion) : null){
issXml.MssXMLElement_SelectSingleNode(inParamXMLElement,inParamXPathString,out outParamXMLNode);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamXMLNode;
}


public static async Task<object> MssXMLElement_SelectNodes(IRequestContext requestContext,object inParamXMLElement,string inParamXPathString,CancellationToken cancellationToken) {
object outParamXMLNodeList = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("XMLElement_SelectNodes", "d805bd7c-2774-4fb8-9e4f-95883392e714"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("XMLElement_SelectNodes", "d805bd7c-2774-4fb8-9e4f-95883392e714", "Xml", "98a97440-2e8f-489e-9fa6-c7a2230c8396", extensionVersion) : null){
issXml.MssXMLElement_SelectNodes(inParamXMLElement,inParamXPathString,out outParamXMLNodeList);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamXMLNodeList;
}


public static async Task<string> MssXMLElement_GetAttributeValue(IRequestContext requestContext,object inParamXMLElement,string inParamAttributeName,CancellationToken cancellationToken) {
string outParamAttributeValue = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("XMLElement_GetAttributeValue", "52e1afbb-35bb-4d25-8263-98e6c31c493e"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("XMLElement_GetAttributeValue", "52e1afbb-35bb-4d25-8263-98e6c31c493e", "Xml", "98a97440-2e8f-489e-9fa6-c7a2230c8396", extensionVersion) : null){
issXml.MssXMLElement_GetAttributeValue(inParamXMLElement,inParamAttributeName,out outParamAttributeValue);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamAttributeValue;
}


public static async Task<object> MssXMLNodeList_Item(IRequestContext requestContext,object inParamXMLNodeList,int inParamIndex,CancellationToken cancellationToken) {
object outParamXMLNode = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("XMLNodeList_Item", "db211fcd-5bcd-45d7-9f06-31713ebcb7fc"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("XMLNodeList_Item", "db211fcd-5bcd-45d7-9f06-31713ebcb7fc", "Xml", "98a97440-2e8f-489e-9fa6-c7a2230c8396", extensionVersion) : null){
issXml.MssXMLNodeList_Item(inParamXMLNodeList,inParamIndex,out outParamXMLNode);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamXMLNode;
}


public static async Task<(object,bool,OutSystems.Application.Extensibility.DataTypes.IRecordList)> MssXMLDocument_Load<ToutParamErrors>(IRequestContext requestContext,string inParamXML,string inParamXSD,CancellationToken cancellationToken) where ToutParamErrors : OutSystems.Application.Extensibility.DataTypes.IRecordList,new() {
object outParamXMLDocument = default;
bool outParamIsValid = default;
OutSystems.Application.Extensibility.DataTypes.IRecordList outParamErrors = default;
outParamErrors = new ToutParamErrors();;
OutSystems.NssXml.RLXmlErrorRecordList _proxyoutParamErrors = new OutSystems.NssXml.RLXmlErrorRecordList();
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("XMLDocument_Load", "ad870372-ba63-434e-a099-c743fb6d5aa2"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("XMLDocument_Load", "ad870372-ba63-434e-a099-c743fb6d5aa2", "Xml", "98a97440-2e8f-489e-9fa6-c7a2230c8396", extensionVersion) : null){
issXml.MssXMLDocument_Load(inParamXML,inParamXSD,out outParamXMLDocument,out outParamIsValid,out _proxyoutParamErrors);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamErrors.CopyFrom(_proxyoutParamErrors);await Task.Yield();
return (outParamXMLDocument,outParamIsValid,outParamErrors);
}


public static async Task<object> MssXMLDocument_SelectSingleNode(IRequestContext requestContext,object inParamXMLDocument,string inParamXPathString,CancellationToken cancellationToken) {
object outParamXMLNode = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("XMLDocument_SelectSingleNode", "c5fac85c-818a-4aa4-829b-b77d1fd1d887"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("XMLDocument_SelectSingleNode", "c5fac85c-818a-4aa4-829b-b77d1fd1d887", "Xml", "98a97440-2e8f-489e-9fa6-c7a2230c8396", extensionVersion) : null){
issXml.MssXMLDocument_SelectSingleNode(inParamXMLDocument,inParamXPathString,out outParamXMLNode);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamXMLNode;
}



public class DefaultValues {
}
}
}
