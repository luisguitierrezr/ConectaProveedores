// Proxy for reference Extension with name Zip and key csSPiuhwREqh9uFFICG9gA
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExtensionZip
/// </summary>
public partial class RssExtensionZip {
/// <summary>
/// Extension Variable: issZip
/// </summary>
protected static OutSystems.NssZip.IssZip issZip =(OutSystems.NssZip.IssZip)ServiceLocator.GetService<OutSystems.NssZip.CssZip>();
protected static readonly string extensionVersion = typeof(OutSystems.NssZip.CssZip).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExtensionZip");
public static async Task<byte[]> MssGetZIPBinary(IRequestContext requestContext,object inParamZIPHandle,CancellationToken cancellationToken) {
byte[] outParamZIPBinary = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("GetZIPBinary", "7d06f5fe-b9aa-4ac7-b04e-6e2169f09c2c"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("GetZIPBinary", "7d06f5fe-b9aa-4ac7-b04e-6e2169f09c2c", "Zip", "8a8fc472-70e8-4a44-a1f6-e1452021bd80", extensionVersion) : null){
issZip.MssGetZIPBinary(inParamZIPHandle,out outParamZIPBinary);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamZIPBinary;
}


public static async Task<object> MssCreateZIP(IRequestContext requestContext,int inParamCompressionLevel,CancellationToken cancellationToken) {
object outParamZIPHandle = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("CreateZIP", "cda7e846-deab-4b35-971b-7e3f22e72000"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("CreateZIP", "cda7e846-deab-4b35-971b-7e3f22e72000", "Zip", "8a8fc472-70e8-4a44-a1f6-e1452021bd80", extensionVersion) : null){
issZip.MssCreateZIP(out outParamZIPHandle,inParamCompressionLevel);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamZIPHandle;
}


public static async Task<object> MssLoadZIP(IRequestContext requestContext,byte[] inParamZIPBinary,string inParamPassword,CancellationToken cancellationToken) {
object outParamZIPHandle = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("LoadZIP", "1f9ad577-7448-4988-b9c9-3f3efe0c6292"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("LoadZIP", "1f9ad577-7448-4988-b9c9-3f3efe0c6292", "Zip", "8a8fc472-70e8-4a44-a1f6-e1452021bd80", extensionVersion) : null){
issZip.MssLoadZIP(inParamZIPBinary,inParamPassword,out outParamZIPHandle);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamZIPHandle;
}


public static async Task MssCommitChanges(IRequestContext requestContext,object inParamZIPHandle,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("CommitChanges", "79368d79-8cc6-4d19-9556-91684f821f53"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("CommitChanges", "79368d79-8cc6-4d19-9556-91684f821f53", "Zip", "8a8fc472-70e8-4a44-a1f6-e1452021bd80", extensionVersion) : null){
issZip.MssCommitChanges(inParamZIPHandle);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return;
}


public static async Task<OutSystems.Application.Extensibility.DataTypes.IRecordList> MssGetFiles<ToutParamFileList>(IRequestContext requestContext,object inParamZIPHandle,CancellationToken cancellationToken) where ToutParamFileList : OutSystems.Application.Extensibility.DataTypes.IRecordList,new() {
OutSystems.Application.Extensibility.DataTypes.IRecordList outParamFileList = default;
outParamFileList = new ToutParamFileList();;
OutSystems.NssZip.RLFileRecordList _proxyoutParamFileList = new OutSystems.NssZip.RLFileRecordList();
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("GetFiles", "03eeb04d-42d8-4e7a-8bc2-f708a5ba158c"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("GetFiles", "03eeb04d-42d8-4e7a-8bc2-f708a5ba158c", "Zip", "8a8fc472-70e8-4a44-a1f6-e1452021bd80", extensionVersion) : null){
issZip.MssGetFiles(inParamZIPHandle,out _proxyoutParamFileList);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamFileList.CopyFrom(_proxyoutParamFileList);await Task.Yield();
return outParamFileList;
}


public static async Task MssAddFile(IRequestContext requestContext,object inParamZIPHandle,string inParamFileName,DateTime inParamDateTime,byte[] inParamFileContent,CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExtensionActionMetric("AddFile", "c43d7317-ed3e-40cc-a0f9-ff9172a56fe0"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExtensionActivity("AddFile", "c43d7317-ed3e-40cc-a0f9-ff9172a56fe0", "Zip", "8a8fc472-70e8-4a44-a1f6-e1452021bd80", extensionVersion) : null){
issZip.MssAddFile(inParamZIPHandle,inParamFileName,inParamDateTime,inParamFileContent);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return;
}



public class DefaultValues {
}
}
}
