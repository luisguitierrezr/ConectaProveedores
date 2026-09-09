namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoice_OCRValidations : VarsBag {
public ST_6f620840109ac6f721328b723ec0152cStructure inParamExtractForeignInvoiceDataForUs2;
public string inParamRequisitionCurrency;
public decimal inParamRequisitionAmount;
public int inParamOffsetUtc;
public Actions.lcoValidateInvoiceYear resValidateInvoiceYear =  new Actions.lcoValidateInvoiceYear();
public lcvInvoice_OCRValidations(ST_6f620840109ac6f721328b723ec0152cStructure inParamExtractForeignInvoiceDataForUs2, string inParamRequisitionCurrency, decimal inParamRequisitionAmount, int inParamOffsetUtc) {
this.inParamExtractForeignInvoiceDataForUs2 = inParamExtractForeignInvoiceDataForUs2;
this.inParamRequisitionCurrency = inParamRequisitionCurrency;
this.inParamRequisitionAmount = inParamRequisitionAmount;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoInvoice_OCRValidations : VarsBag {
public string outParamErrorMsg = "";

public lcoInvoice_OCRValidations() {
}
}
/// <summary>
/// Action <code>Invoice_OCRValidations</code> that represents the Service Studio action
///  <code>Invoice_OCRValidations</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionInvoice_OCRValidations(IRequestContext requestContext,ST_6f620840109ac6f721328b723ec0152cStructure inParamExtractForeignInvoiceDataForUs2,string inParamRequisitionCurrency,decimal inParamRequisitionAmount,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoInvoice_OCRValidations result = new lcoInvoice_OCRValidations();
lcvInvoice_OCRValidations localVars = new lcvInvoice_OCRValidations(inParamExtractForeignInvoiceDataForUs2, inParamRequisitionCurrency, inParamRequisitionAmount, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Invoice_OCRValidations", "e8ab420d-bc85-41e4-8d8e-88e90b618a4e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Invoice_OCRValidations", "e8ab420d-bc85-41e4-8d8e-88e90b618a4e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// tax id error?
if((((BuiltInFunction.LengthSC (localVars.inParamExtractForeignInvoiceDataForUs2.ssSupplierTaxId)<9)||((BuiltInFunction.LengthSC (localVars.inParamExtractForeignInvoiceDataForUs2.ssSupplierTaxId)>12)&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Supplier]))))))) {
// ErrorMsg = "Tax Id should have between 9 and 12 characters of length"
result.outParamErrorMsg=AppUtils.GetStringResource("IRZ9Mcbb_0qe20nYia6lPQ#Value.1958488213.1", "Tax Id should have between 9 and 12 characters of length");
} else {
// ValidateInvoiceYear
localVars.resValidateInvoiceYear.outParamIsValid = await Actions.ActionValidateInvoiceYear(requestContext,BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.inParamExtractForeignInvoiceDataForUs2.ssInvoiceDate)),localVars.inParamExtractForeignInvoiceDataForUs2.ssInvoiceNumber,"",localVars.inParamOffsetUtc,cancellationToken);

// date error?
if((((!localVars.resValidateInvoiceYear.outParamIsValid)||(BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.inParamExtractForeignInvoiceDataForUs2.ssInvoiceDate))==1900)))) {
// ErrorMsg = "Date's year shouldn't be empty and in the format yyyy/mm/dd"
result.outParamErrorMsg=AppUtils.GetStringResource("ZGCDhlTYEkOCLPwVVYuPkA#Value.2085597027.1", "Date's year shouldn't be empty and in the format yyyy/mm/dd");
} else {
// currency error?
if(((localVars.inParamExtractForeignInvoiceDataForUs2.ssCurrency!=localVars.inParamRequisitionCurrency))) {
// ErrorMsg = "Currency doesn't match with the Requisition currency"
result.outParamErrorMsg=AppUtils.GetStringResource("D7xPb5uBm0eq4Bv1nAjMTQ#Value.337773302.1", "Currency doesn't match with the Requisition currency");
} else {
// amount error?
if((((BuiltInFunction.TextToDecimal (localVars.inParamExtractForeignInvoiceDataForUs2.ssTotalAmount)>localVars.inParamRequisitionAmount)&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Amount])))))) {
// ErrorMsg = "Amount is bigger than the Requisition Amount"
result.outParamErrorMsg=AppUtils.GetStringResource("iSVbPfz1zUKsDt5yY659eQ#Value.-256168116.1", "Amount is bigger than the Requisition Amount");
} else {
// recept rfc error?
if((((((((localVars.inParamExtractForeignInvoiceDataForUs2.ssCustomerTaxIdDetected!="RDI841003QJ4")&&(localVars.inParamExtractForeignInvoiceDataForUs2.ssCustomerTaxIdDetected!="SER9112312A3"))&&(localVars.inParamExtractForeignInvoiceDataForUs2.ssCustomerTaxIdDetected!="AMO000925Q31"))&&(localVars.inParamExtractForeignInvoiceDataForUs2.ssCustomerTaxIdDetected!="ITR000922C12"))&&(localVars.inParamExtractForeignInvoiceDataForUs2.ssCustomerTaxIdDetected!="IRE000922RK1"))&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Supplier])))))) {
// ErrorMsg = "El RFC del receptor no está autorizado para este proceso."
result.outParamErrorMsg=AppUtils.GetStringResource("bCUKK8nDx0ye0zYHob61HQ#Value.-144359871.1", "El RFC del receptor no está autorizado para este proceso.");
} else {
// recept name error?
if((false)) {
// ErrorMsg = "El RFC del receptor no está autorizado para este proceso."
result.outParamErrorMsg=AppUtils.GetStringResource("xo4nQPCdnESQZYv1PXKvEQ#Value.-144359871.1", "El RFC del receptor no está autorizado para este proceso.");
}

}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionInvoice_OCRValidations {



}


}
