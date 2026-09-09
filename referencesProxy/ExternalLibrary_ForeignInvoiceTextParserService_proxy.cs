// Proxy for reference ExternalLibrary with name ForeignInvoiceTextParserService and key Wtqb1jWJ4UqrscDY+mZgxg
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExternalLibraryForeignInvoiceTextParserService
/// </summary>
public partial class RssExternalLibraryForeignInvoiceTextParserService {
/// <summary>
/// Extension Variable: issForeignInvoiceTextParserService
/// </summary>
protected static OutSystems.NssForeignInvoiceTextParserService.IssForeignInvoiceTextParserService issForeignInvoiceTextParserService =(OutSystems.NssForeignInvoiceTextParserService.IssForeignInvoiceTextParserService)ServiceLocator.GetService<OutSystems.NssForeignInvoiceTextParserService.CssForeignInvoiceTextParserService>();
protected static readonly string extensionVersion = typeof(OutSystems.NssForeignInvoiceTextParserService.CssForeignInvoiceTextParserService).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExternalLibraryForeignInvoiceTextParserService");
public static async Task<OutSystems.Application.Extensibility.DataTypes.IRecord> MssExtractForeignInvoiceDataForUs<ToutParamExtractForeignInvoiceDataForUs>(IRequestContext requestContext,string inParamrawText,CancellationToken cancellationToken) where ToutParamExtractForeignInvoiceDataForUs : OutSystems.Application.Extensibility.DataTypes.IRecord,new() {
OutSystems.Application.Extensibility.DataTypes.IRecord outParamExtractForeignInvoiceDataForUs = default;
outParamExtractForeignInvoiceDataForUs = new ToutParamExtractForeignInvoiceDataForUs();;
OutSystems.NssForeignInvoiceTextParserService.ST_6f620840109ac6f721328b723ec0152cStructure _proxyoutParamExtractForeignInvoiceDataForUs = new OutSystems.NssForeignInvoiceTextParserService.ST_6f620840109ac6f721328b723ec0152cStructure();
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExternalLibraryActionMetric("ExtractForeignInvoiceDataForUs", "5832cae8-ebe5-43ea-b99a-edf7ad987bde"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("ExtractForeignInvoiceDataForUs", "5832cae8-ebe5-43ea-b99a-edf7ad987bde", "ForeignInvoiceTextParserService", "d69bda5a-8935-4ae1-abb1-c0d8fa6660c6", extensionVersion) : null){
_proxyoutParamExtractForeignInvoiceDataForUs = await issForeignInvoiceTextParserService.MssExtractForeignInvoiceDataForUs(inParamrawText,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamExtractForeignInvoiceDataForUs.CopyFrom(_proxyoutParamExtractForeignInvoiceDataForUs);await Task.Yield();
return outParamExtractForeignInvoiceDataForUs;
}



public class DefaultValues {
}
}
}
