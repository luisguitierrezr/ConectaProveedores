// Proxy for reference ExternalLibrary with name TimeZone and key fhiiq094kUeH4iegEnTI2g
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExternalLibraryTimeZone
/// </summary>
public partial class RssExternalLibraryTimeZone {
/// <summary>
/// Extension Variable: issTimeZone
/// </summary>
protected static OutSystems.NssTimeZone.IssTimeZone issTimeZone =(OutSystems.NssTimeZone.IssTimeZone)ServiceLocator.GetService<OutSystems.NssTimeZone.CssTimeZone>();
protected static readonly string extensionVersion = typeof(OutSystems.NssTimeZone.CssTimeZone).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExternalLibraryTimeZone");
public static async Task<OutSystems.Application.Extensibility.DataTypes.IRecord> MssGetTimeZone<ToutParamTimeZone>(IRequestContext requestContext,string inParamIdentifier,CancellationToken cancellationToken) where ToutParamTimeZone : OutSystems.Application.Extensibility.DataTypes.IRecord,new() {
OutSystems.Application.Extensibility.DataTypes.IRecord outParamTimeZone = default;
outParamTimeZone = new ToutParamTimeZone();;
OutSystems.NssTimeZone.ST_98371f99cd7bfeee4fab07e43606a1b5Structure _proxyoutParamTimeZone = new OutSystems.NssTimeZone.ST_98371f99cd7bfeee4fab07e43606a1b5Structure();
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExternalLibraryActionMetric("GetTimeZone", "e35e0bf4-b996-4e7a-b057-115158ea5f38"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("GetTimeZone", "e35e0bf4-b996-4e7a-b057-115158ea5f38", "TimeZone", "aba2187e-784f-4791-87e2-27a01274c8da", extensionVersion) : null){
_proxyoutParamTimeZone = await issTimeZone.MssGetTimeZone(inParamIdentifier,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamTimeZone.CopyFrom(_proxyoutParamTimeZone);await Task.Yield();
return outParamTimeZone;
}


public static async Task<DateTime> MssConvertFromTimeZone(IRequestContext requestContext,DateTime inParamSourceDateTime,string inParamSourceTimeZone,string inParamDestinationTimeZone,CancellationToken cancellationToken) {
DateTime outParamConvertFromTimeZone = default;
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExternalLibraryActionMetric("ConvertFromTimeZone", "84c49c5e-a010-4969-ba16-382acad4d5c7"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("ConvertFromTimeZone", "84c49c5e-a010-4969-ba16-382acad4d5c7", "TimeZone", "aba2187e-784f-4791-87e2-27a01274c8da", extensionVersion) : null){
outParamConvertFromTimeZone = await issTimeZone.MssConvertFromTimeZone(inParamSourceDateTime,inParamSourceTimeZone,inParamDestinationTimeZone,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
await Task.Yield();
return outParamConvertFromTimeZone;
}



public class DefaultValues {
}
}
}
