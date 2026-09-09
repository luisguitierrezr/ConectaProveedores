// Proxy for reference ExternalLibrary with name DataExportUtilities and key kuTfU0a6NUmPvS9TiEVMMg
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExternalLibraryDataExportUtilities
/// </summary>
public partial class RssExternalLibraryDataExportUtilities {
/// <summary>
/// Extension Variable: issDataExportUtilities
/// </summary>
protected static OutSystems.NssDataExportUtilities.IssDataExportUtilities issDataExportUtilities =(OutSystems.NssDataExportUtilities.IssDataExportUtilities)ServiceLocator.GetService<OutSystems.NssDataExportUtilities.CssDataExportUtilities>();
protected static readonly string extensionVersion = typeof(OutSystems.NssDataExportUtilities.CssDataExportUtilities).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExternalLibraryDataExportUtilities");
public static async Task<byte[]> MssConvertExcelBinaryToCsvBinary(IRequestContext requestContext,byte[] inParamexcelBytes,CancellationToken cancellationToken) {
byte[] outParamConvertExcelBinaryToCsvBinary = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExternalLibraryActionMetric("ConvertExcelBinaryToCsvBinary", "95aa30de-784a-447c-940f-c007b2c847e4"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("ConvertExcelBinaryToCsvBinary", "95aa30de-784a-447c-940f-c007b2c847e4", "DataExportUtilities", "53dfe492-ba46-4935-8fbd-2f5388454c32", extensionVersion) : null){
outParamConvertExcelBinaryToCsvBinary = await issDataExportUtilities.MssConvertExcelBinaryToCsvBinary(inParamexcelBytes,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamConvertExcelBinaryToCsvBinary;
}


public static async Task<byte[]> MssConvertJsonToCsvFile(IRequestContext requestContext,string inParamjsonString,CancellationToken cancellationToken) {
byte[] outParamConvertJsonToCsvFile = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExternalLibraryActionMetric("ConvertJsonToCsvFile", "2b8a1036-e0b6-4851-90e9-2e906b7b05a8"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("ConvertJsonToCsvFile", "2b8a1036-e0b6-4851-90e9-2e906b7b05a8", "DataExportUtilities", "53dfe492-ba46-4935-8fbd-2f5388454c32", extensionVersion) : null){
outParamConvertJsonToCsvFile = await issDataExportUtilities.MssConvertJsonToCsvFile(inParamjsonString,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamConvertJsonToCsvFile;
}



public class DefaultValues {
}
}
}
