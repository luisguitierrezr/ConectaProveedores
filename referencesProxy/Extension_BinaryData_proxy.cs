// Proxy for reference Extension with name BinaryData and key kOY2fJgjVUSOXIrq_IW1+A
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExtensionBinaryData
/// </summary>
public partial class RssExtensionBinaryData {
/// <summary>
/// Extension Variable: issBinaryData
/// </summary>
protected static OutSystems.NssBinaryData.IssBinaryData issBinaryData =(OutSystems.NssBinaryData.IssBinaryData)ServiceLocator.GetService<OutSystems.NssBinaryData.CssBinaryData>();
protected static readonly string extensionVersion = typeof(OutSystems.NssBinaryData.CssBinaryData).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExtensionBinaryData");
public static async Task<string> MssBinaryToBase64(IRequestContext requestContext,byte[] inParamBinaryData,CancellationToken cancellationToken) {
string outParamBase64 = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("BinaryToBase64", "4cf49915-7967-493f-8f0d-4f14b0dfe37e"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("BinaryToBase64", "4cf49915-7967-493f-8f0d-4f14b0dfe37e", "BinaryData", "7c36e690-2398-4455-8e5c-8aeafc85b5f8", extensionVersion) : null){
issBinaryData.MssBinaryToBase64(inParamBinaryData,out outParamBase64);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBase64;
}


public static async Task<int> MssBinaryDataSize(IRequestContext requestContext,byte[] inParamBinaryData,CancellationToken cancellationToken) {
int outParamSize = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("BinaryDataSize", "3714eded-3a54-4e3c-a78c-5beecafede62"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("BinaryDataSize", "3714eded-3a54-4e3c-a78c-5beecafede62", "BinaryData", "7c36e690-2398-4455-8e5c-8aeafc85b5f8", extensionVersion) : null){
issBinaryData.MssBinaryDataSize(inParamBinaryData,out outParamSize);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamSize;
}


public static async Task<byte[]> MssBase64ToBinary(IRequestContext requestContext,string inParamBase64,CancellationToken cancellationToken) {
byte[] outParamBinary = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("Base64ToBinary", "8cd56088-76cf-4e02-ad37-80b6d0f7b2c3"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("Base64ToBinary", "8cd56088-76cf-4e02-ad37-80b6d0f7b2c3", "BinaryData", "7c36e690-2398-4455-8e5c-8aeafc85b5f8", extensionVersion) : null){
issBinaryData.MssBase64ToBinary(inParamBase64,out outParamBinary);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBinary;
}


public static async Task<byte[]> MssTextToBinaryData(IRequestContext requestContext,string inParamText,string inParamEncoding,CancellationToken cancellationToken) {
byte[] outParamBinaryData = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("TextToBinaryData", "f9de645e-e449-4eec-8709-be7cbcfd7325"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("TextToBinaryData", "f9de645e-e449-4eec-8709-be7cbcfd7325", "BinaryData", "7c36e690-2398-4455-8e5c-8aeafc85b5f8", extensionVersion) : null){
issBinaryData.MssTextToBinaryData(inParamText,inParamEncoding,out outParamBinaryData);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamBinaryData;
}


public static async Task<string> MssBinaryDataToText(IRequestContext requestContext,byte[] inParamBinaryData,string inParamEncoding,CancellationToken cancellationToken) {
string outParamText = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("BinaryDataToText", "5c278fc1-2bcf-4081-9556-31d67f8c4c30"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("BinaryDataToText", "5c278fc1-2bcf-4081-9556-31d67f8c4c30", "BinaryData", "7c36e690-2398-4455-8e5c-8aeafc85b5f8", extensionVersion) : null){
issBinaryData.MssBinaryDataToText(inParamBinaryData,inParamEncoding,out outParamText);
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
