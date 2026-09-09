namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoice_OCR : VarsBag {
public byte[] inParamPDFBinaryData;
public ST_6f620840109ac6f721328b723ec0152cStructure resExtractForeignInvoiceDataForUs_outParamExtractForeignInvoiceDataForUs = new ST_6f620840109ac6f721328b723ec0152cStructure();

public ST_ce06f43cf108d98e4f79c0106fcfd0acStructure resExtractTextOrOcr_outParamExtractTextOrOcr = new ST_ce06f43cf108d98e4f79c0106fcfd0acStructure();

public lcvInvoice_OCR(byte[] inParamPDFBinaryData) {
this.inParamPDFBinaryData = inParamPDFBinaryData;
}
}
public class lcoInvoice_OCR : VarsBag {
public ST_ce06f43cf108d98e4f79c0106fcfd0acStructure outParamExtractTextOrOcr2 = new ST_ce06f43cf108d98e4f79c0106fcfd0acStructure();

public ST_6f620840109ac6f721328b723ec0152cStructure outParamExtractForeignInvoiceDataForUs2 = new ST_6f620840109ac6f721328b723ec0152cStructure();

public lcoInvoice_OCR() {
}
}
/// <summary>
/// Action <code>Invoice_OCR</code> that represents the Service Studio action <code>Invoice_OCR</code>
///  <p> Description: </p>
/// </summary>
public static async Task<(ST_ce06f43cf108d98e4f79c0106fcfd0acStructure,ST_6f620840109ac6f721328b723ec0152cStructure)> ActionInvoice_OCR(IRequestContext requestContext,byte[] inParamPDFBinaryData,CancellationToken cancellationToken) {
ST_ce06f43cf108d98e4f79c0106fcfd0acStructure outParamExtractTextOrOcr2 = default;
ST_6f620840109ac6f721328b723ec0152cStructure outParamExtractForeignInvoiceDataForUs2 = default;
lcoInvoice_OCR result = new lcoInvoice_OCR();
lcvInvoice_OCR localVars = new lcvInvoice_OCR(inParamPDFBinaryData);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Invoice_OCR", "7fbd75e8-2e1f-438e-aa4f-698c13c4361a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Invoice_OCR", "7fbd75e8-2e1f-438e-aa4f-698c13c4361a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ExtractTextOrOcr
localVars.resExtractTextOrOcr_outParamExtractTextOrOcr = await Actions.ActionExtractTextOrOcr(requestContext,localVars.inParamPDFBinaryData,"eng,pt,es",200,cancellationToken);

// ExtractTextOrOcr2 = ExtractTextOrOcr.ExtractTextOrOcr
result.outParamExtractTextOrOcr2=localVars.resExtractTextOrOcr_outParamExtractTextOrOcr;
// ExtractForeignInvoiceDataForUs
localVars.resExtractForeignInvoiceDataForUs_outParamExtractForeignInvoiceDataForUs = await Actions.ActionExtractForeignInvoiceDataForUs(requestContext,localVars.resExtractTextOrOcr_outParamExtractTextOrOcr.ssExtractedText,cancellationToken);

// ExtractForeignInvoiceDataForUs2 = ExtractForeignInvoiceDataForUs.ExtractForeignInvoiceDataForUs
result.outParamExtractForeignInvoiceDataForUs2=localVars.resExtractForeignInvoiceDataForUs_outParamExtractForeignInvoiceDataForUs;

// ExtractForeignInvoiceDataForUs2.InvoiceDate = TextToDate
result.outParamExtractForeignInvoiceDataForUs2.ssInvoiceDate = BuiltInFunction.DateToText(BuiltInFunction.TextToDate (localVars.resExtractForeignInvoiceDataForUs_outParamExtractForeignInvoiceDataForUs.ssInvoiceDate));

// ExtractForeignInvoiceDataForUs2.TotalAmount = TextToDecimal
result.outParamExtractForeignInvoiceDataForUs2.ssTotalAmount = BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (result.outParamExtractForeignInvoiceDataForUs2.ssTotalAmount));
} //close CreateActionActivity using block
} // try

finally {
outParamExtractTextOrOcr2 = result.outParamExtractTextOrOcr2;
outParamExtractForeignInvoiceDataForUs2 = result.outParamExtractForeignInvoiceDataForUs2;
} // inner-finally
RETURN_STATEMENT:
return (outParamExtractTextOrOcr2,outParamExtractForeignInvoiceDataForUs2);
}

public static class FuncActionInvoice_OCR {



}


}
