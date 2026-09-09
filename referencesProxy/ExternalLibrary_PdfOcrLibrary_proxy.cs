// Proxy for reference ExternalLibrary with name PdfOcrLibrary and key wK_XNNmrhUOPptlW9ez+DQ
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RssExternalLibraryPdfOcrLibrary
/// </summary>
public partial class RssExternalLibraryPdfOcrLibrary {
/// <summary>
/// Extension Variable: issPdfOcrLibrary
/// </summary>
protected static OutSystems.NssPdfOcrLibrary.IssPdfOcrLibrary issPdfOcrLibrary =(OutSystems.NssPdfOcrLibrary.IssPdfOcrLibrary)ServiceLocator.GetService<OutSystems.NssPdfOcrLibrary.CssPdfOcrLibrary>();
protected static readonly string extensionVersion = typeof(OutSystems.NssPdfOcrLibrary.CssPdfOcrLibrary).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
private static readonly ActivitySource source = new("ssConectaProveedores.RssExternalLibraryPdfOcrLibrary");
public static async Task<OutSystems.Application.Extensibility.DataTypes.IRecord> MssExtractTextOrOcr<ToutParamExtractTextOrOcr>(IRequestContext requestContext,byte[] inParampdfBytes,string inParamlanguages,int inParamdpi,CancellationToken cancellationToken) where ToutParamExtractTextOrOcr : OutSystems.Application.Extensibility.DataTypes.IRecord,new() {
OutSystems.Application.Extensibility.DataTypes.IRecord outParamExtractTextOrOcr = default;
outParamExtractTextOrOcr = new ToutParamExtractTextOrOcr();;
OutSystems.NssPdfOcrLibrary.ST_ce06f43cf108d98e4f79c0106fcfd0acStructure _proxyoutParamExtractTextOrOcr = new OutSystems.NssPdfOcrLibrary.ST_ce06f43cf108d98e4f79c0106fcfd0acStructure();
cancellationToken.ThrowIfCancellationRequested();
try {
using (AppHealthProvider.CreateExternalLibraryActionMetric("ExtractTextOrOcr", "ac7efda9-225f-4a75-aa56-e5fc00e21d97"))
using (RuntimePlatformSettings.OpenTelemetry.ExtensionActionIsEnabled.GetValue() ? source.CreateExternalLibraryActivity("ExtractTextOrOcr", "ac7efda9-225f-4a75-aa56-e5fc00e21d97", "PdfOcrLibrary", "34d7afc0-abd9-4385-8fa6-d956f5ecfe0d", extensionVersion) : null){
_proxyoutParamExtractTextOrOcr = await issPdfOcrLibrary.MssExtractTextOrOcr(inParampdfBytes,inParamlanguages,inParamdpi,cancellationToken);
}
} catch (Exception ex) {
throw ExtensionErrorsHelper.DefaultError(ex);
}
outParamExtractTextOrOcr.CopyFrom(_proxyoutParamExtractTextOrOcr);await Task.Yield();
return outParamExtractTextOrOcr;
}



public class DefaultValues {
}
}
}
