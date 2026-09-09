namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML02_Emisor : VarsBag {
public object inParamXMLDocument;
public string inParamCodigoPostal;
public string inParamSupplierRFC;
/// <summary>
/// Variable <code>XMLNode</code> that represents the Service Studio Object <code>XMLNode</code>
///  <p>Description: </p>
/// </summary>
public object varLcXMLNode = null;

public string resGetNombre_outParamAttributeValue = "";

public object resSelectSingleNode_Emisor_outParamXMLNode = null;

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate11 =  new Actions.lcoLogsAccountingCreate();
public string resGetRfc_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate12 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate13 =  new Actions.lcoLogsAccountingCreate();
public string resGetRegimenFiscal_outParamAttributeValue = "";

public lcvXML02_Emisor(object inParamXMLDocument, string inParamCodigoPostal, string inParamSupplierRFC) {
this.inParamXMLDocument = inParamXMLDocument;
this.inParamCodigoPostal = inParamCodigoPostal;
this.inParamSupplierRFC = inParamSupplierRFC;
}
}
public class lcoXML02_Emisor : VarsBag {
public string outParamErrorMsg = "";

public EN_1ca446167f1a5fee035306f622895668EntityRecord outParamInvoiceExtendedIssuer = new EN_1ca446167f1a5fee035306f622895668EntityRecord();

public lcoXML02_Emisor() {
}
}
/// <summary>
/// Action <code>XML02_Emisor</code> that represents the Service Studio action
///  <code>XML02_Emisor</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_1ca446167f1a5fee035306f622895668EntityRecord)> ActionXML02_Emisor(IRequestContext requestContext,object inParamXMLDocument,string inParamCodigoPostal,string inParamSupplierRFC,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
EN_1ca446167f1a5fee035306f622895668EntityRecord outParamInvoiceExtendedIssuer = default;
lcoXML02_Emisor result = new lcoXML02_Emisor();
lcvXML02_Emisor localVars = new lcvXML02_Emisor(inParamXMLDocument, inParamCodigoPostal, inParamSupplierRFC);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML02_Emisor", "d66c8472-c1e6-458c-a0cd-ee1d4e196ad8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML02_Emisor", "d66c8472-c1e6-458c-a0cd-ee1d4e196ad8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SelectSingleNode_Emisor
localVars.resSelectSingleNode_Emisor_outParamXMLNode = await Actions.ActionXMLDocument_SelectSingleNode(requestContext,localVars.inParamXMLDocument,"//*[local-name()='Emisor']",cancellationToken);

// XMLNode = SelectSingleNode_Emisor.XMLNode
localVars.varLcXMLNode=localVars.resSelectSingleNode_Emisor_outParamXMLNode;
// GetRfc
localVars.resGetRfc_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Rfc",cancellationToken);

// error?
if((((localVars.resGetRfc_outParamAttributeValue!=localVars.inParamSupplierRFC)&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Supplier])))))) {
// ErrorMsg = "Error in Rfc field of Issuer"
result.outParamErrorMsg=AppUtils.GetStringResource("P0HozkSiXE6hDHwJ0E5n_g#Value.2085523912.1", "Error in Rfc field of Issuer");
// LogsXMLValidationCreate11
localVars.resLogsXMLValidationCreate11.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Rfc field of Issuer", ssDescription = ((localVars.resGetRfc_outParamAttributeValue+" <> ")+localVars.inParamSupplierRFC), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetNombre
localVars.resGetNombre_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Nombre",cancellationToken);

// error?
if(((localVars.resGetNombre_outParamAttributeValue==""))) {
// ErrorMsg = "Error in Nombre field of Issuer"
result.outParamErrorMsg=AppUtils.GetStringResource("mtt31orw3kSSdtyGemE0gg#Value.-301500280.1", "Error in Nombre field of Issuer");
// LogsXMLValidationCreate12
localVars.resLogsXMLValidationCreate12.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Nombre field of Issuer", ssDescription = (localVars.resGetNombre_outParamAttributeValue+" = vacio "), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetRegimenFiscal
localVars.resGetRegimenFiscal_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"RegimenFiscal",cancellationToken);

// error?
if(((localVars.resGetRegimenFiscal_outParamAttributeValue==""))) {
// ErrorMsg = "Error in RegimenFiscal field of Issuer"
result.outParamErrorMsg=AppUtils.GetStringResource("2qDDZL2tt0m7LZTJIQ4I5g#Value.1742152024.1", "Error in RegimenFiscal field of Issuer");
// LogsXMLValidationCreate13
localVars.resLogsXMLValidationCreate13.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in RegimenFiscal field of Issuer", ssDescription = (localVars.resGetRegimenFiscal_outParamAttributeValue+"= vacio"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// InvoiceExtendedIssuer.RFC = GetRfc.AttributeValue
result.outParamInvoiceExtendedIssuer.ssRFC = localVars.resGetRfc_outParamAttributeValue;

// InvoiceExtendedIssuer.Nombre = GetNombre.AttributeValue
result.outParamInvoiceExtendedIssuer.ssNombre = localVars.resGetNombre_outParamAttributeValue;

// InvoiceExtendedIssuer.RegimenFiscal = GetRegimenFiscal.AttributeValue
result.outParamInvoiceExtendedIssuer.ssRegimenFiscal = localVars.resGetRegimenFiscal_outParamAttributeValue;

// InvoiceExtendedIssuer.CodigoPostal = CodigoPostal
result.outParamInvoiceExtendedIssuer.ssCodigoPostal = localVars.inParamCodigoPostal;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamInvoiceExtendedIssuer = result.outParamInvoiceExtendedIssuer;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamInvoiceExtendedIssuer);
}

public static class FuncActionXML02_Emisor {



}


}
