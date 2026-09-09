namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML01_ComprobanteTK195 : VarsBag {
public object inParamXMLDocument;
public string inParamLugarExpedicionSupplier;
public string inParamLimitAmount;
public bool inParamIsOnly1Invoice;
public decimal inParamInvoicesSum;
public long inParamOrderAccConceptsID;
public string inParamUUID;
public int inParamOffsetUtc;
public bool inParamIsConstruction;
public int inParamFolioAmount;
/// <summary>
/// Variable <code>Base64</code> that represents the Service Studio Text <code>Base64</code>
///  <p>Description: </p>
/// </summary>
public string varLcBase64 = "";

/// <summary>
/// Variable <code>Binary</code> that represents the Service Studio BinaryData <code>Binary</code>
///  <p>Description: </p>
/// </summary>
public byte[] varLcBinary = new byte[] {};

/// <summary>
/// Variable <code>Trasladados</code> that represents the Service Studio Text <code>Trasladados</code>
///  <p>Description: </p>
/// </summary>
public string varLcTrasladados = "";

/// <summary>
/// Variable <code>Retenidos</code> that represents the Service Studio Text <code>Retenidos</code>
///  <p>Description: </p>
/// </summary>
public string varLcRetenidos = "";

/// <summary>
/// Variable <code>l_IsPaymentOptionsError</code> that represents the Service Studio Boolean
///  <code>l_IsPaymentOptionsError</code> <p>Description: Is Payment Options Error.</p>
/// </summary>
public bool varLcl_IsPaymentOptionsError = false;

public string resGetFolio_outParamAttributeValue = "";

public string resGetMoneda_outParamAttributeValue = "";

public string resGetSello_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoValidateInvoiceYear resValidateInvoiceYear =  new Actions.lcoValidateInvoiceYear();
public string resGetDescuento_outParamAttributeValue = "";

public object resSelectSingleNode_Impuestos_outParamXMLNode = null;

public string resGetSubTotal_outParamAttributeValue = "";

public string resGetTotal_outParamAttributeValue = "";

public string resGetTotalImpuestosRetenidos_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate3 =  new Actions.lcoLogsAccountingCreate();
public RL_03472b0ba33e12fef4eae9e97dce9a76 queryResGetCustomSettingValues_outParamList = new RL_03472b0ba33e12fef4eae9e97dce9a76();
public long queryResGetCustomSettingValues_outParamCount = 0L;

public string resGetTotalImpuestosTrasladados_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate8 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate13 =  new Actions.lcoLogsAccountingCreate();
public string resGetTipoDeComprobante_outParamAttributeValue = "";

public string resGetFecha_outParamAttributeValue = "";

public string resGetExportacion_outParamAttributeValue = "";

public string resGetMetodoPago_outParamAttributeValue = "";

public string resGetSerie_outParamAttributeValue = "";

public string resGetLugarExpedicion_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate5 =  new Actions.lcoLogsAccountingCreate();
public RL_d98dc7eec8c631266895b622203a6db3 queryResGetPaymentWaysByCode_outParamList = new RL_d98dc7eec8c631266895b622203a6db3();
public long queryResGetPaymentWaysByCode_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate11 =  new Actions.lcoLogsAccountingCreate();
public string resGetTipoCambio_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate =  new Actions.lcoLogsAccountingCreate();
public object resSelectSingleNode_Comprobante_outParamXMLNode = null;

public byte[] resBase64ToBinary_outParamBinary = new byte[] {};

public string resGetVersion_outParamAttributeValue = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate6 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate9 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate12 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate7 =  new Actions.lcoLogsAccountingCreate();
public string resGetFormaPago_outParamAttributeValue = "";

public RL_251acb2daece433ee402c9709ec88356 queryResGetPaymentOptionsByCode_outParamList = new RL_251acb2daece433ee402c9709ec88356();
public long queryResGetPaymentOptionsByCode_outParamCount = 0L;

public lcvXML01_ComprobanteTK195(object inParamXMLDocument, string inParamLugarExpedicionSupplier, string inParamLimitAmount, bool inParamIsOnly1Invoice, decimal inParamInvoicesSum, long inParamOrderAccConceptsID, string inParamUUID, int inParamOffsetUtc, bool inParamIsConstruction, int inParamFolioAmount) {
this.inParamXMLDocument = inParamXMLDocument;
this.inParamLugarExpedicionSupplier = inParamLugarExpedicionSupplier;
this.inParamLimitAmount = inParamLimitAmount;
this.inParamIsOnly1Invoice = inParamIsOnly1Invoice;
this.inParamInvoicesSum = inParamInvoicesSum;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamUUID = inParamUUID;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParamIsConstruction = inParamIsConstruction;
this.inParamFolioAmount = inParamFolioAmount;
}
}
public class lcoXML01_ComprobanteTK195 : VarsBag {
public EN_f81a3d226103fd013068b8763798067aEntityRecord outParamInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();

public object outParamXMLNode = null;

public string outParamErrorMsg = "";

public byte[] outParamSelloDigital = new byte[] {};

public lcoXML01_ComprobanteTK195() {
}
}
/// <summary>
/// Action <code>XML01_ComprobanteTK195</code> that represents the Service Studio action
///  <code>XML01_ComprobanteTK195</code> <p> Description: DO NOT USE</p>
/// </summary>
public static async Task<(EN_f81a3d226103fd013068b8763798067aEntityRecord,object,string,byte[])> ActionXML01_ComprobanteTK195(IRequestContext requestContext,object inParamXMLDocument,string inParamLugarExpedicionSupplier,string inParamLimitAmount,bool inParamIsOnly1Invoice,decimal inParamInvoicesSum,long inParamOrderAccConceptsID,string inParamUUID,int inParamOffsetUtc,bool inParamIsConstruction,int inParamFolioAmount,CancellationToken cancellationToken) {
EN_f81a3d226103fd013068b8763798067aEntityRecord outParamInvoiceExtended = default;
object outParamXMLNode = default;
string outParamErrorMsg = default;
byte[] outParamSelloDigital = default;
lcoXML01_ComprobanteTK195 result = new lcoXML01_ComprobanteTK195();
lcvXML01_ComprobanteTK195 localVars = new lcvXML01_ComprobanteTK195(inParamXMLDocument, inParamLugarExpedicionSupplier, inParamLimitAmount, inParamIsOnly1Invoice, inParamInvoicesSum, inParamOrderAccConceptsID, inParamUUID, inParamOffsetUtc, inParamIsConstruction, inParamFolioAmount);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML01_ComprobanteTK195", "e7f244c1-6170-4b08-9ad1-b40a41e1d26b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML01_ComprobanteTK195", "e7f244c1-6170-4b08-9ad1-b40a41e1d26b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SelectSingleNode_Comprobante
localVars.resSelectSingleNode_Comprobante_outParamXMLNode = await Actions.ActionXMLDocument_SelectSingleNode(requestContext,localVars.inParamXMLDocument,"//*[local-name()='Comprobante']",cancellationToken);

// XMLNode = SelectSingleNode_Comprobante.XMLNode
result.outParamXMLNode=localVars.resSelectSingleNode_Comprobante_outParamXMLNode;
// GetVersion
localVars.resGetVersion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Version",cancellationToken);

// error?
if(((localVars.resGetVersion_outParamAttributeValue!="4.0"))) {
// ErrorMsg = "Error in Version field"
result.outParamErrorMsg=AppUtils.GetStringResource("l7zdWani8E6Jy5hgaM9upA#Value.840746767.1", "Error in Version field");
// LogsXMLValidationCreate11
localVars.resLogsXMLValidationCreate11.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Version field", ssDescription = (localVars.resGetVersion_outParamAttributeValue+" <> 4.0"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetSerie
localVars.resGetSerie_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Serie",cancellationToken);

// GetFolio
localVars.resGetFolio_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Folio",cancellationToken);

// GetTipoDeComprobante
localVars.resGetTipoDeComprobante_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"TipoDeComprobante",cancellationToken);

// error?
if((((localVars.resGetTipoDeComprobante_outParamAttributeValue!="I")&&(localVars.resGetTipoDeComprobante_outParamAttributeValue!="E")))) {
// ErrorMsg = "Error in Tipo de Comprobante field"
result.outParamErrorMsg=AppUtils.GetStringResource("CC3WHZU5Q0WtwE38VJYITw#Value.-1707586088.1", "Error in Tipo de Comprobante field");
// LogsXMLValidationCreate3
localVars.resLogsXMLValidationCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("iFnCPe_rHkCjnfGWDATBbg#Value.-1707586088.1", "Error in Tipo de Comprobante field"), ssDescription = (localVars.resGetTipoDeComprobante_outParamAttributeValue+"<> I and <> E"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetFecha
localVars.resGetFecha_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Fecha",cancellationToken);

// ValidateInvoiceYear
localVars.resValidateInvoiceYear.outParamIsValid = await Actions.ActionValidateInvoiceYear(requestContext,BuiltInFunction.Year (BuiltInFunction.TextToDateTime (localVars.resGetFecha_outParamAttributeValue)),localVars.resGetFolio_outParamAttributeValue,localVars.inParamUUID,localVars.inParamOffsetUtc,cancellationToken);

// error?
if(((!localVars.resValidateInvoiceYear.outParamIsValid))) {
// ErrorMsg = "Error in Fecha field"
result.outParamErrorMsg=AppUtils.GetStringResource("iE4O8C308ECmbs9Z5groAA#Value.890328372.1", "Error in Fecha field");
// LogsXMLValidationCreate9
localVars.resLogsXMLValidationCreate9.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Fecha field", ssDescription = (localVars.resGetFecha_outParamAttributeValue+" <>  ano corrente"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetFormaPago
localVars.resGetFormaPago_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"FormaPago",cancellationToken);

// Query datasetGetPaymentWaysByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentWaysByCode_maxRecords = 1;
if (datasetGetPaymentWaysByCode_maxRecords < 1) datasetGetPaymentWaysByCode_maxRecords = 1;
int datasetGetPaymentWaysByCode_startIndex = 0;(localVars.queryResGetPaymentWaysByCode_outParamList,localVars.queryResGetPaymentWaysByCode_outParamCount) = await FuncActionXML01_ComprobanteTK195.datasetGetPaymentWaysByCode(requestContext,datasetGetPaymentWaysByCode_maxRecords,datasetGetPaymentWaysByCode_startIndex,IterationMultiplicity.Never,localVars.resGetFormaPago_outParamAttributeValue,cancellationToken);

// error?
if((localVars.queryResGetPaymentWaysByCode_outParamList.Empty)) {
// ErrorMsg = "Error in Forma de Pago field"
result.outParamErrorMsg=AppUtils.GetStringResource("VkBjT0bhkUW7WmG+_WlZrA#Value.-1612512084.1", "Error in Forma de Pago field");
// LogsXMLValidationCreate8
localVars.resLogsXMLValidationCreate8.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Forma de Pago field", ssDescription = (localVars.resGetFormaPago_outParamAttributeValue+" no esta en el catalogo"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetMetodoPago
localVars.resGetMetodoPago_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"MetodoPago",cancellationToken);

// Query datasetGetPaymentOptionsByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentOptionsByCode_maxRecords = 1;
if (datasetGetPaymentOptionsByCode_maxRecords < 1) datasetGetPaymentOptionsByCode_maxRecords = 1;
int datasetGetPaymentOptionsByCode_startIndex = 0;(localVars.queryResGetPaymentOptionsByCode_outParamList,localVars.queryResGetPaymentOptionsByCode_outParamCount) = await FuncActionXML01_ComprobanteTK195.datasetGetPaymentOptionsByCode(requestContext,datasetGetPaymentOptionsByCode_maxRecords,datasetGetPaymentOptionsByCode_startIndex,IterationMultiplicity.Never,localVars.resGetMetodoPago_outParamAttributeValue,cancellationToken);

// l_IsPaymentOptionsError = GetPaymentOptionsByCode.List.Empty
localVars.varLcl_IsPaymentOptionsError=localVars.queryResGetPaymentOptionsByCode_outParamList.Empty;
// error?
if((localVars.varLcl_IsPaymentOptionsError)) {
// ErrorMsg = "Error in Metodo de Pago field"
result.outParamErrorMsg=AppUtils.GetStringResource("5lPn+q5h00OE5Wt9Y4+WVA#Value.1470428435.1", "Error in Metodo de Pago field");
// LogsXMLValidationCreate7
localVars.resLogsXMLValidationCreate7.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Metodo de Pago field", ssDescription = (localVars.resGetMetodoPago_outParamAttributeValue+" no esta en el catalogo"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetLugarExpedicion
localVars.resGetLugarExpedicion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"LugarExpedicion",cancellationToken);

// error?
if((((BuiltInFunction.LengthSC (localVars.resGetLugarExpedicion_outParamAttributeValue)!=5)||((localVars.resGetLugarExpedicion_outParamAttributeValue!=localVars.inParamLugarExpedicionSupplier)&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipExpedicionFiscal])))))))) {
// ErrorMsg = "Error in Lugar de Expedicion field" + If
result.outParamErrorMsg=(AppUtils.GetStringResource("o5_sj6S4WEWwrId35HQ5JA#Value.1301246679.1", "Error in Lugar de Expedicion field")+((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLErrorDetail])))) ? ((((("[req:"+localVars.inParamLugarExpedicionSupplier)+"/xml:")+localVars.resGetLugarExpedicion_outParamAttributeValue)+"]")) : ("")));
// LogsXMLValidationCreate6
localVars.resLogsXMLValidationCreate6.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Lugar de Expedicion field", ssDescription = ((((("Length("+localVars.resGetLugarExpedicion_outParamAttributeValue)+") <> 5 or ")+localVars.resGetLugarExpedicion_outParamAttributeValue)+" <> ")+localVars.inParamLugarExpedicionSupplier), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetSubTotal
localVars.resGetSubTotal_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"SubTotal",cancellationToken);

// GetTotal
localVars.resGetTotal_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Total",cancellationToken);

// NoOrderAccConcept
if((((localVars.inParamOrderAccConceptsID==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&(localVars.resGetTipoDeComprobante_outParamAttributeValue=="I")))) {
// error?
if(((((localVars.inParamIsOnly1Invoice) ? ((BuiltInFunction.TextToDecimal (localVars.resGetTotal_outParamAttributeValue)!=BuiltInFunction.TextToDecimal (localVars.inParamLimitAmount))) : (((BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue)+localVars.inParamInvoicesSum)>BuiltInFunction.TextToDecimal (localVars.inParamLimitAmount))))&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Amount])))))) {
// ErrorMsg = If + If
result.outParamErrorMsg=(((localVars.inParamIsOnly1Invoice) ? (AppUtils.GetStringResource("2zrM72fL90eKmR8yiPMl6Q#Value.282699900.1", "El subtotal de la factura no puede ser diferente del total de la operacion")) : (AppUtils.GetStringResource("2zrM72fL90eKmR8yiPMl6Q#Value.561591491.1", "El subtotal de la factura no puede ser superior al total de la operacion")))+((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLErrorDetail])))) ? ((((((" // (SubTotal:"+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue)))+" + ")+BuiltInFunction.DecimalToText(localVars.inParamInvoicesSum))+") > Limit:")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.inParamLimitAmount)))) : ("")));
// LogsXMLValidationCreate5
localVars.resLogsXMLValidationCreate5.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Total field", ssDescription = ((((localVars.resGetSubTotal_outParamAttributeValue+" + ")+BuiltInFunction.DecimalToText(localVars.inParamInvoicesSum))+" > ")+localVars.inParamLimitAmount), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

goto RETURN_STATEMENT;

}

}

// isConstruction
if((localVars.inParamIsConstruction)) {
// Query datasetGetCustomSettingValues
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCustomSettingValues_maxRecords = 0;
int datasetGetCustomSettingValues_startIndex = 0;(localVars.queryResGetCustomSettingValues_outParamList,localVars.queryResGetCustomSettingValues_outParamCount) = await FuncActionXML01_ComprobanteTK195.datasetGetCustomSettingValues(requestContext,datasetGetCustomSettingValues_maxRecords,datasetGetCustomSettingValues_startIndex,IterationMultiplicity.Never,cancellationToken);

// isBetweenLimitation?
if((!((BuiltInFunction.Abs ((BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue)-BuiltInFunction.TextToDecimal (Convert.ToString(localVars.inParamFolioAmount))))<=BuiltInFunction.TextToDecimal (localVars.queryResGetCustomSettingValues_outParamList.CurrentRec.ssENCustomSettingValue.ssValue))))) {
// ErrorMsg
// ErrorMsg = "La diferencia entre el monto del documento y el monto del folio supera el límite establecido."
result.outParamErrorMsg="La diferencia entre el monto del documento y el monto del folio supera el límite establecido.";
// LogsXMLValidationCreate13
localVars.resLogsXMLValidationCreate13.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Total field", ssDescription = (((((((((((("La diferencia entre el monto del documento y el monto del folio supera el límite establecido."+"\r\n")+"Monto del folio: ")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (Convert.ToString(localVars.inParamFolioAmount))))+"\r\n")+"Monto de la factura: ")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue)))+"\r\n")+"Diferencia: ")+BuiltInFunction.DecimalToText(BuiltInFunction.Abs ((BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue)-BuiltInFunction.TextToDecimal (Convert.ToString(localVars.inParamFolioAmount))))))+"\r\n")+"Límite de diferencia establecido: ")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.queryResGetCustomSettingValues_outParamList.CurrentRec.ssENCustomSettingValue.ssValue))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

goto RETURN_STATEMENT;

}

}

// GetDescuento
localVars.resGetDescuento_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Descuento",cancellationToken);

// SelectSingleNode_Impuestos
localVars.resSelectSingleNode_Impuestos_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Comprobante_outParamXMLNode,"./*[local-name()='Impuestos']",cancellationToken);

// null object?
if(((localVars.resSelectSingleNode_Impuestos_outParamXMLNode==BuiltInFunction.NullObject ()))) {
// bypass
} else {
// GetTotalImpuestosTrasladados
localVars.resGetTotalImpuestosTrasladados_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.resSelectSingleNode_Impuestos_outParamXMLNode,"TotalImpuestosTrasladados",cancellationToken);

// GetTotalImpuestosRetenidos
localVars.resGetTotalImpuestosRetenidos_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.resSelectSingleNode_Impuestos_outParamXMLNode,"TotalImpuestosRetenidos",cancellationToken);

// Trasladados = GetTotalImpuestosTrasladados.AttributeValue
localVars.varLcTrasladados=localVars.resGetTotalImpuestosTrasladados_outParamAttributeValue;

// Retenidos = GetTotalImpuestosRetenidos.AttributeValue
localVars.varLcRetenidos=localVars.resGetTotalImpuestosRetenidos_outParamAttributeValue;
}

// error?
if((((BuiltInFunction.TextToDecimal (localVars.resGetTotal_outParamAttributeValue)!=(((BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue)-BuiltInFunction.TextToDecimal (localVars.resGetDescuento_outParamAttributeValue))+BuiltInFunction.TextToDecimal (localVars.varLcTrasladados))-BuiltInFunction.TextToDecimal (localVars.varLcRetenidos)))&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Amount])))))) {
// ErrorMsg = "Error in Aritmetica de Total field"
result.outParamErrorMsg=AppUtils.GetStringResource("geexwh0SZ02e5ghNCA4oHQ#Value.524360117.1", "Error in Aritmetica de Total field");
// LogsXMLValidationCreate12
localVars.resLogsXMLValidationCreate12.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Aritmetica de Total field", ssDescription = (((((((((BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.resGetTotal_outParamAttributeValue))+" <> (")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue)))+" - ")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.resGetDescuento_outParamAttributeValue)))+" + ")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.varLcTrasladados)))+" - ")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.varLcRetenidos)))+")"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetMoneda
localVars.resGetMoneda_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Moneda",cancellationToken);

// error?
if((((((localVars.resGetMoneda_outParamAttributeValue!="MXN")&&(localVars.resGetMoneda_outParamAttributeValue!="USD"))&&(localVars.resGetMoneda_outParamAttributeValue!="EUR"))&&(localVars.resGetMoneda_outParamAttributeValue!="LBS")))) {
// ErrorMsg = "Error in Moneda field"
result.outParamErrorMsg=AppUtils.GetStringResource("7kNJGRaIK0Sm05qbiAgUSQ#Value.1689987699.1", "Error in Moneda field");
// LogsXMLValidationCreate2
localVars.resLogsXMLValidationCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Moneda field", ssDescription = (localVars.resGetMoneda_outParamAttributeValue+" <> MXN,USD,EUR,LBS"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetTipoCambio
localVars.resGetTipoCambio_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"TipoCambio",cancellationToken);

// GetExportacion
localVars.resGetExportacion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Exportacion",cancellationToken);

// error?
if((((((localVars.resGetExportacion_outParamAttributeValue!="01")&&(localVars.resGetExportacion_outParamAttributeValue!="02"))&&(localVars.resGetExportacion_outParamAttributeValue!="03"))&&(localVars.resGetExportacion_outParamAttributeValue!="04")))) {
// ErrorMsg = "Error in Exportacion field"
result.outParamErrorMsg=AppUtils.GetStringResource("gIxoKVJSwE+HSDzuzmMZ+Q#Value.1342895529.1", "Error in Exportacion field");
// LogsXMLValidationCreate
localVars.resLogsXMLValidationCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Exportacion field", ssDescription = (((((localVars.resGetExportacion_outParamAttributeValue!="01")&&(localVars.resGetExportacion_outParamAttributeValue!="02"))&&(localVars.resGetExportacion_outParamAttributeValue!="03"))&&(localVars.resGetExportacion_outParamAttributeValue!="04")) ? "True" : "False"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// GetSello
localVars.resGetSello_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,result.outParamXMLNode,"Sello",cancellationToken);

// Base64 = Replace
localVars.varLcBase64=BuiltInFunction.Replace (BuiltInFunction.Replace (BuiltInFunction.Replace (BuiltInFunction.Replace (BuiltInFunction.Replace (BuiltInFunction.Replace (localVars.resGetSello_outParamAttributeValue, " ", ""), "\\n", ""), "\\r", ""), "\\t", ""), "\\u00A0", ""), "&#xA;", "");
// sello ok?
if((((BuiltInFunction.Mod ((((decimal)BuiltInFunction.LengthSC (localVars.varLcBase64))), (((decimal)4)))==(((decimal)0)))&&(BuiltInFunction.IndexSC (localVars.varLcBase64, " ", 0, false, false)==(-1))))) {
// Base64ToBinary
localVars.resBase64ToBinary_outParamBinary = await Actions.ActionBase64ToBinary(requestContext,localVars.varLcBase64,cancellationToken);

// Binary = Base64ToBinary.Binary
localVars.varLcBinary=localVars.resBase64ToBinary_outParamBinary;
}

// InvoiceExtended.Version = GetVersion.AttributeValue
result.outParamInvoiceExtended.ssVersion = localVars.resGetVersion_outParamAttributeValue;

// InvoiceExtended.Serie = GetSerie.AttributeValue
result.outParamInvoiceExtended.ssSerie = localVars.resGetSerie_outParamAttributeValue;

// InvoiceExtended.Folio = GetFolio.AttributeValue
result.outParamInvoiceExtended.ssFolio = localVars.resGetFolio_outParamAttributeValue;

// InvoiceExtended.FechaEmision = GetFecha.AttributeValue
result.outParamInvoiceExtended.ssFechaEmision = localVars.resGetFecha_outParamAttributeValue;

// SelloDigital = Binary
result.outParamSelloDigital=localVars.varLcBinary;

// InvoiceExtended.FormaPago = GetFormaPago.AttributeValue
result.outParamInvoiceExtended.ssFormaPago = localVars.resGetFormaPago_outParamAttributeValue;

// InvoiceExtended.MetodoPago = GetMetodoPago.AttributeValue
result.outParamInvoiceExtended.ssMetodoPago = localVars.resGetMetodoPago_outParamAttributeValue;

// InvoiceExtended.LugarExpedicion = GetLugarExpedicion.AttributeValue
result.outParamInvoiceExtended.ssLugarExpedicion = localVars.resGetLugarExpedicion_outParamAttributeValue;

// InvoiceExtended.Subtotal = Round
result.outParamInvoiceExtended.ssSubtotal = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetSubTotal_outParamAttributeValue), 2);

// InvoiceExtended.TotalIVA = Round
result.outParamInvoiceExtended.ssTotalIVA = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.varLcTrasladados), 2);

// InvoiceExtended.Retenciones = Round
result.outParamInvoiceExtended.ssRetenciones = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.varLcRetenidos), 2);

// InvoiceExtended.Total = Round
result.outParamInvoiceExtended.ssTotal = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetTotal_outParamAttributeValue), 2);

// InvoiceExtended.TipoComprobante = GetTipoDeComprobante.AttributeValue
result.outParamInvoiceExtended.ssTipoComprobante = localVars.resGetTipoDeComprobante_outParamAttributeValue;

// InvoiceExtended.Moneda = GetMoneda.AttributeValue
result.outParamInvoiceExtended.ssMoneda = localVars.resGetMoneda_outParamAttributeValue;

// InvoiceExtended.TipoCambio = Round
result.outParamInvoiceExtended.ssTipoCambio = BuiltInFunction.Round (BuiltInFunction.TextToDecimal ((((localVars.resGetTipoCambio_outParamAttributeValue!="")) ? (localVars.resGetTipoCambio_outParamAttributeValue) : ("1"))), 2);

// InvoiceExtended.Exportacion = GetExportacion.AttributeValue
result.outParamInvoiceExtended.ssExportacion = localVars.resGetExportacion_outParamAttributeValue;

// InvoiceExtended.Descuento = Round
result.outParamInvoiceExtended.ssDescuento = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetDescuento_outParamAttributeValue), 2);
}

}

}

}

}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceExtended = result.outParamInvoiceExtended;
outParamXMLNode = result.outParamXMLNode;
outParamErrorMsg = result.outParamErrorMsg;
outParamSelloDigital = result.outParamSelloDigital;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceExtended,outParamXMLNode,outParamErrorMsg,outParamSelloDigital);
}

public static class FuncActionXML01_ComprobanteTK195 {

private static async Task<RC_65a6cd6541355f3cc5923c05ddee6119> datasetGetCustomSettingValuesReadDbAsync(RC_65a6cd6541355f3cc5923c05ddee6119 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCustomSettings.Read( r, ref index);
rec.ssENCustomSettingValue.Read( r, ref index);
return rec;
}
// Query Function "GetCustomSettingValues" NXdIRhaRM0GXaJY4pNl2ng of Action "XML01_ComprobanteTK195"
public static async Task<(RL_03472b0ba33e12fef4eae9e97dce9a76,long)> datasetGetCustomSettingValues(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("XML01_ComprobanteTK195.GetCustomSettingValues", "46487735-9116-4133-9768-9638a4d9769e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("XML01_ComprobanteTK195.GetCustomSettingValues", "46487735-9116-4133-9768-9638a4d9769e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.wUTy53BhCEua0bQKQeHSaw/NodesNotShownInESpaceTree.NXdIRhaRM0GXaJY4pNl2ng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"encustomsettingvalue4\".\"value\" o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM ({CustomSettingValue} \"encustomsettingvalue4\" Left JOIN {CustomSettings} \"encustomsettings\" ON (\"encustomsettingvalue4\".\"customsettingid\" = \"encustomsettings\".\"id\")) ");
whereBuilder.Append(" WHERE (\"encustomsettingvalue4\".\"customsettingid\" = ");
whereBuilder.Append(6
);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_03472b0ba33e12fef4eae9e97dce9a76 outParamList = new RL_03472b0ba33e12fef4eae9e97dce9a76();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCustomSettingValuesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query XML01_ComprobanteTK195.GetCustomSettingValues.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_03472b0ba33e12fef4eae9e97dce9a76 _tmp = new RL_03472b0ba33e12fef4eae9e97dce9a76();
_tmp.AlternateReadDbMethodAsync = datasetGetCustomSettingValuesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query XML01_ComprobanteTK195.GetCustomSettingValues.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_03472b0ba33e12fef4eae9e97dce9a76)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetPaymentWaysByCode" nJz0i_4nMk6IuanV_uvszw of Action "XML01_ComprobanteTK195"
public static async Task<(RL_d98dc7eec8c631266895b622203a6db3,long)> datasetGetPaymentWaysByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("XML01_ComprobanteTK195.GetPaymentWaysByCode", "8bf49c9c-27fe-4e32-88b9-a9d5feebeccf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("XML01_ComprobanteTK195.GetPaymentWaysByCode", "8bf49c9c-27fe-4e32-88b9-a9d5feebeccf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.wUTy53BhCEua0bQKQeHSaw/NodesNotShownInESpaceTree.nJz0i_4nMk6IuanV_uvszw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentWays} \"enpaymentways1\"");
whereBuilder.Append(" WHERE (\"enpaymentways1\".\"code\" = @qpteCode)");
sqlCmd.CreateParameterWithoutReplacements("@qpteCode", DbType.String, qpteCode);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d98dc7eec8c631266895b622203a6db3 outParamList = new RL_d98dc7eec8c631266895b622203a6db3();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query XML01_ComprobanteTK195.GetPaymentWaysByCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d98dc7eec8c631266895b622203a6db3 _tmp = new RL_d98dc7eec8c631266895b622203a6db3();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query XML01_ComprobanteTK195.GetPaymentWaysByCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d98dc7eec8c631266895b622203a6db3)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetPaymentOptionsByCode" 5sXW_2F2BUuD2xW+atrONQ of Action "XML01_ComprobanteTK195"
public static async Task<(RL_251acb2daece433ee402c9709ec88356,long)> datasetGetPaymentOptionsByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("XML01_ComprobanteTK195.GetPaymentOptionsByCode", "ffd6c5e6-7661-4b05-83db-15be6adace35");
using var queryActivity = activitySource.CreateAggregateQueryActivity("XML01_ComprobanteTK195.GetPaymentOptionsByCode", "ffd6c5e6-7661-4b05-83db-15be6adace35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.wUTy53BhCEua0bQKQeHSaw/NodesNotShownInESpaceTree.5sXW_2F2BUuD2xW+atrONQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentOptions} \"enpaymentoptions1\"");
whereBuilder.Append(" WHERE (\"enpaymentoptions1\".\"code\" = @qpteCode)");
sqlCmd.CreateParameterWithoutReplacements("@qpteCode", DbType.String, qpteCode);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_251acb2daece433ee402c9709ec88356 outParamList = new RL_251acb2daece433ee402c9709ec88356();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query XML01_ComprobanteTK195.GetPaymentOptionsByCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_251acb2daece433ee402c9709ec88356 _tmp = new RL_251acb2daece433ee402c9709ec88356();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query XML01_ComprobanteTK195.GetPaymentOptionsByCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_251acb2daece433ee402c9709ec88356)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
