namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionExtractForeignInvoiceDataForUs</code> that represents the Service Studio
///  reference action <code>ExtractForeignInvoiceDataForUs</code> <p> Description: Extracts invoice dat
/// a from OCR text</p>
/// </summary>
public static async Task<ST_6f620840109ac6f721328b723ec0152cStructure> ActionExtractForeignInvoiceDataForUs(IRequestContext requestContext,string inParamrawText,CancellationToken cancellationToken) {
ST_6f620840109ac6f721328b723ec0152cStructure outParamExtractForeignInvoiceDataForUs = default;
OutSystems.Application.Extensibility.DataTypes.IRecord proxy_ExtractForeignInvoiceDataForUs;
proxy_ExtractForeignInvoiceDataForUs = await RssExternalLibraryForeignInvoiceTextParserService.MssExtractForeignInvoiceDataForUs<ST_6f620840109ac6f721328b723ec0152cStructure>(requestContext,inParamrawText,cancellationToken);
outParamExtractForeignInvoiceDataForUs = (ST_6f620840109ac6f721328b723ec0152cStructure) proxy_ExtractForeignInvoiceDataForUs;
return outParamExtractForeignInvoiceDataForUs;
}

}
