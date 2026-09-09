namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML03_Receptor : VarsBag {
public object inParamXMLDocument;
public BasicTypeList<string> inParamInvoiceUsageKeyList;
public bool inParamIsNC;
/// <summary>
/// Variable <code>XMLNode</code> that represents the Service Studio Object <code>XMLNode</code>
///  <p>Description: </p>
/// </summary>
public object varLcXMLNode = null;

public string resGetUsoCFDI_outParamAttributeValue = "";

public string resGetRfc_outParamAttributeValue = "";

public string resGetRegimenFiscalReceptor_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate13 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate11 =  new Actions.lcoLogsAccountingCreate();
public object resSelectSingleNode_Receptor_outParamXMLNode = null;

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate12 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate16 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate14 =  new Actions.lcoLogsAccountingCreate();
public string resGetNombre_outParamAttributeValue = "";

public string resGetDomicilioFiscalReceptor_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate15 =  new Actions.lcoLogsAccountingCreate();
public BasicTypeList<string> resListFilter_outParamFilteredList = new BasicTypeList<string>();

public lcvXML03_Receptor(object inParamXMLDocument, BasicTypeList<string> inParamInvoiceUsageKeyList, bool inParamIsNC) {
this.inParamXMLDocument = inParamXMLDocument;
this.inParamInvoiceUsageKeyList = inParamInvoiceUsageKeyList;
this.inParamIsNC = inParamIsNC;
}
}
public class lcoXML03_Receptor : VarsBag {
public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord outParamInvoiceExtendedReceiver = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();

public string outParamUsoCFDI = "";

public string outParamErrorMsg = "";

public lcoXML03_Receptor() {
}
}
/// <summary>
/// Action <code>XML03_Receptor</code> that represents the Service Studio action
///  <code>XML03_Receptor</code> <p> Description: </p>
/// </summary>
public static async Task<(EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord,string,string)> ActionXML03_Receptor(IRequestContext requestContext,object inParamXMLDocument,BasicTypeList<string> inParamInvoiceUsageKeyList,bool inParamIsNC,CancellationToken cancellationToken) {
EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord outParamInvoiceExtendedReceiver = default;
string outParamUsoCFDI = default;
string outParamErrorMsg = default;
lcoXML03_Receptor result = new lcoXML03_Receptor();
lcvXML03_Receptor localVars = new lcvXML03_Receptor(inParamXMLDocument, inParamInvoiceUsageKeyList, inParamIsNC);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML03_Receptor", "eb74153c-47d3-42a7-bf38-816d13e6e84a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML03_Receptor", "eb74153c-47d3-42a7-bf38-816d13e6e84a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SelectSingleNode_Receptor
localVars.resSelectSingleNode_Receptor_outParamXMLNode = await Actions.ActionXMLDocument_SelectSingleNode(requestContext,localVars.inParamXMLDocument,"//*[local-name()='Receptor']",cancellationToken);

// XMLNode = SelectSingleNode_Receptor.XMLNode
localVars.varLcXMLNode=localVars.resSelectSingleNode_Receptor_outParamXMLNode;
// GetRfc
localVars.resGetRfc_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Rfc",cancellationToken);

// error?
if((((((((localVars.resGetRfc_outParamAttributeValue!="RDI841003QJ4")&&(localVars.resGetRfc_outParamAttributeValue!="SER9112312A3"))&&(localVars.resGetRfc_outParamAttributeValue!="AMO000925Q31"))&&(localVars.resGetRfc_outParamAttributeValue!="ITR000922C12"))&&(localVars.resGetRfc_outParamAttributeValue!="IRE000922RK1"))&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Supplier])))))) {
// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resGetRfc_outParamAttributeValue=="")) ? ("El RFC del receptor no tiene un formato válido.") : ("El RFC del receptor no está autorizado para este proceso."));
// LogsXMLValidationCreate11
localVars.resLogsXMLValidationCreate11.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = (((localVars.resGetRfc_outParamAttributeValue=="")) ? ("El RFC del receptor no tiene un formato válido.") : ("El RFC del receptor no está autorizado para este proceso.")), ssDescription = (localVars.resGetRfc_outParamAttributeValue+" <> RDI841003QJ4,SER9112312A3,AMO000925Q31,ITR000922C12,IRE000922RK1"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetNombre
localVars.resGetNombre_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Nombre",cancellationToken);

// error?
if(((localVars.resGetNombre_outParamAttributeValue==""))) {
// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resGetNombre_outParamAttributeValue=="")) ? ("El nombre del receptor no puede estar vacío.") : ("El nombre del receptor no coincide con el CFDI."));
// LogsXMLValidationCreate12
localVars.resLogsXMLValidationCreate12.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = (((localVars.resGetNombre_outParamAttributeValue=="")) ? ("El nombre del receptor no puede estar vacío.") : ("El nombre del receptor no coincide con el CFDI.")), ssDescription = (localVars.resGetNombre_outParamAttributeValue+"= vacio"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetDomicilioFiscalReceptor
localVars.resGetDomicilioFiscalReceptor_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"DomicilioFiscalReceptor",cancellationToken);

// error?
if(((BuiltInFunction.LengthSC (localVars.resGetDomicilioFiscalReceptor_outParamAttributeValue)!=5))) {
// ErrorMsg = If
result.outParamErrorMsg=(((BuiltInFunction.LengthSC (localVars.resGetDomicilioFiscalReceptor_outParamAttributeValue)!=5)) ? ("El Código Postal del receptor es inválido.") : ("El Código Postal del receptor no coincide con el CFDI."));
// LogsXMLValidationCreate13
localVars.resLogsXMLValidationCreate13.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = (((BuiltInFunction.LengthSC (localVars.resGetDomicilioFiscalReceptor_outParamAttributeValue)!=5)) ? ("El Código Postal del receptor es inválido.") : ("El Código Postal del receptor no coincide con el CFDI.")), ssDescription = (("Length("+localVars.resGetDomicilioFiscalReceptor_outParamAttributeValue)+") <> 5"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetRegimenFiscalReceptor
localVars.resGetRegimenFiscalReceptor_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"RegimenFiscalReceptor",cancellationToken);

// error?
if(((localVars.resGetRegimenFiscalReceptor_outParamAttributeValue==""))) {
// ErrorMsg = "El Régimen Fiscal del receptor no es válido según el catálogo SAT."
result.outParamErrorMsg="El Régimen Fiscal del receptor no es válido según el catálogo SAT.";
// LogsXMLValidationCreate14
localVars.resLogsXMLValidationCreate14.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "El Régimen Fiscal del receptor no es válido según el catálogo SAT.", ssDescription = (localVars.resGetRegimenFiscalReceptor_outParamAttributeValue+"= vacio"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetUsoCFDI
localVars.resGetUsoCFDI_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"UsoCFDI",cancellationToken);

// nc and g02
if(((localVars.inParamIsNC&&(localVars.resGetUsoCFDI_outParamAttributeValue!="G02")))) {
// ErrorMsg = "El Uso CFDI no corresponde a uno de los posibles."
result.outParamErrorMsg=AppUtils.GetStringResource("QleUe60KUU+Jgn6P8wmjWQ#Value.-582966252.1", "El Uso CFDI no corresponde a uno de los posibles.");
// LogsXMLValidationCreate16
localVars.resLogsXMLValidationCreate16.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("oDcnhrJebU+RmBreRynunw#Value.-582966252.1", "El Uso CFDI no corresponde a uno de los posibles."), ssDescription = (localVars.resGetUsoCFDI_outParamAttributeValue+" no corresponde a uno de los posibles. // NC: G02"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// compare usocfdi
if((((!localVars.inParamInvoiceUsageKeyList.Empty)&&(!localVars.inParamIsNC)))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((BasicTypeList<string>)await  localVars.inParamInvoiceUsageKeyList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p)==BuiltInFunction.ToUpper (localVars.resGetUsoCFDI_outParamAttributeValue)), cancellationToken)));

// error?
if(((localVars.resListFilter_outParamFilteredList.Empty&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Supplier])))))) {
// ErrorMsg = "El Uso CFDI no corresponde a uno de los posibles."
result.outParamErrorMsg=AppUtils.GetStringResource("cWt16JbotUGF+F_yozgFww#Value.-582966252.1", "El Uso CFDI no corresponde a uno de los posibles.");
// LogsXMLValidationCreate15
localVars.resLogsXMLValidationCreate15.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("JfOC7N2ogkyZEAZl06OJyA#Value.-582966252.1", "El Uso CFDI no corresponde a uno de los posibles."), ssDescription = ((localVars.resGetUsoCFDI_outParamAttributeValue+" no corresponde a uno de los posibles. // 1º:")+localVars.inParamInvoiceUsageKeyList.CurrentRec), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

goto RETURN_STATEMENT;

}

}

// InvoiceExtendedReceiver.RFC = GetRfc.AttributeValue
result.outParamInvoiceExtendedReceiver.ssRFC = localVars.resGetRfc_outParamAttributeValue;

// InvoiceExtendedReceiver.Nombre = GetNombre.AttributeValue
result.outParamInvoiceExtendedReceiver.ssNombre = localVars.resGetNombre_outParamAttributeValue;

// InvoiceExtendedReceiver.RegimenFiscal = GetRegimenFiscalReceptor.AttributeValue
result.outParamInvoiceExtendedReceiver.ssRegimenFiscal = localVars.resGetRegimenFiscalReceptor_outParamAttributeValue;

// InvoiceExtendedReceiver.CodigoPostal = GetDomicilioFiscalReceptor.AttributeValue
result.outParamInvoiceExtendedReceiver.ssCodigoPostal = localVars.resGetDomicilioFiscalReceptor_outParamAttributeValue;

// UsoCFDI = GetUsoCFDI.AttributeValue
result.outParamUsoCFDI=localVars.resGetUsoCFDI_outParamAttributeValue;
}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceExtendedReceiver = result.outParamInvoiceExtendedReceiver;
outParamUsoCFDI = result.outParamUsoCFDI;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceExtendedReceiver,outParamUsoCFDI,outParamErrorMsg);
}

public static class FuncActionXML03_Receptor {



}


}
