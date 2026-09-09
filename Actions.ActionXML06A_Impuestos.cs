namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML06A_Impuestos : VarsBag {
public object inParamXMLNode_In;
public object inParamXMLDocument;
public bool inParamIsItem;
/// <summary>
/// Variable <code>XMLNode</code> that represents the Service Studio Object <code>XMLNode</code>
///  <p>Description: </p>
/// </summary>
public object varLcXMLNode = null;

/// <summary>
/// Variable <code>AuxCount</code> that represents the Service Studio Integer <code>AuxCount</code>
///  <p>Description: </p>
/// </summary>
public int varLcAuxCount = 0;

/// <summary>
/// Variable <code>RetentionsNode</code> that represents the Service Studio Object
///  <code>RetentionsNode</code> <p>Description: </p>
/// </summary>
public object varLcRetentionsNode = null;

/// <summary>
/// Variable <code>TrasladosNode</code> that represents the Service Studio Object
///  <code>TrasladosNode</code> <p>Description: </p>
/// </summary>
public object varLcTrasladosNode = null;

public int resXMLNodeList_CountRetencion_outParamCount = 0;

public string resGetTasaOCuota2_outParamAttributeValue = "";

public object resXMLElement_SelectNodes_outParamXMLNodeList = null;

public object resSelectSingleNode_Traslados2_outParamXMLNode = null;

public string resGetTasaOCuota_outParamAttributeValue = "";

public string resGetImporte2_outParamAttributeValue = "";

public object resSelectSingleNode_Retenciones_outParamXMLNode = null;

public string resGetTipoFactor2_outParamAttributeValue = "";

public object resXMLNodeList_Item_outParamXMLNode = null;

public int resXMLNodeList_CountTraslado_outParamCount = 0;

public Actions.lcoXML06A1_ImpuestosVerify resXML06A1_ImpuestosVerify2 =  new Actions.lcoXML06A1_ImpuestosVerify();
public object resSelectSingleNode_Traslados_outParamXMLNode = null;

public object resSelectSingleNode_Retenciones2_outParamXMLNode = null;

public string resGetBase_outParamAttributeValue = "";

public string resGetImporte_outParamAttributeValue = "";

public object resXMLElement_SelectNodes2_outParamXMLNodeList = null;

public string resGetImpuesto2_outParamAttributeValue = "";

public string resGetTipoFactor_outParamAttributeValue = "";

public string resGetImpuesto_outParamAttributeValue = "";

public object resSelectSingleNode_Impuestos_outParamXMLNode = null;

public string resGetBase2_outParamAttributeValue = "";

public Actions.lcoXML06A1_ImpuestosVerify resXML06A1_ImpuestosVerify =  new Actions.lcoXML06A1_ImpuestosVerify();
public object resXMLNodeList_Item2_outParamXMLNode = null;

public lcvXML06A_Impuestos(object inParamXMLNode_In, object inParamXMLDocument, bool inParamIsItem) {
this.inParamXMLNode_In = inParamXMLNode_In;
this.inParamXMLDocument = inParamXMLDocument;
this.inParamIsItem = inParamIsItem;
}
}
public class lcoXML06A_Impuestos : VarsBag {
public RL_18908f1ccb5f6631454d810d9be77594 outParamInvoiceExtendedTaxList = new RL_18908f1ccb5f6631454d810d9be77594();

public string outParamErrorMsg = "";

public lcoXML06A_Impuestos() {
}
}
/// <summary>
/// Action <code>XML06A_Impuestos</code> that represents the Service Studio action
///  <code>XML06A_Impuestos</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_18908f1ccb5f6631454d810d9be77594,string)> ActionXML06A_Impuestos(IRequestContext requestContext,object inParamXMLNode_In,object inParamXMLDocument,bool inParamIsItem,CancellationToken cancellationToken) {
RL_18908f1ccb5f6631454d810d9be77594 outParamInvoiceExtendedTaxList = default;
string outParamErrorMsg = default;
lcoXML06A_Impuestos result = new lcoXML06A_Impuestos();
lcvXML06A_Impuestos localVars = new lcvXML06A_Impuestos(inParamXMLNode_In, inParamXMLDocument, inParamIsItem);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML06A_Impuestos", "b3efc912-0e1f-475c-bf71-958c31d3476c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML06A_Impuestos", "b3efc912-0e1f-475c-bf71-958c31d3476c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SelectSingleNode_Impuestos
localVars.resSelectSingleNode_Impuestos_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLNode_In,"./*[local-name()='Impuestos']",cancellationToken);

// null object
if((!((localVars.resSelectSingleNode_Impuestos_outParamXMLNode==BuiltInFunction.NullObject ())))) {
if((localVars.inParamIsItem)) {
// SelectSingleNode_Traslados2
localVars.resSelectSingleNode_Traslados2_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Impuestos_outParamXMLNode,"./*[local-name()='Traslados']",cancellationToken);

// TrasladosNode = SelectSingleNode_Traslados2.XMLNode
localVars.varLcTrasladosNode=localVars.resSelectSingleNode_Traslados2_outParamXMLNode;
} else {
// SelectSingleNode_Traslados
localVars.resSelectSingleNode_Traslados_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLDocument,"//*[local-name()='Comprobante']/*[local-name()='Impuestos']/*[local-name()='Traslados']",cancellationToken);

// TrasladosNode = SelectSingleNode_Traslados.XMLNode
localVars.varLcTrasladosNode=localVars.resSelectSingleNode_Traslados_outParamXMLNode;
}

// null object
if((!((localVars.varLcTrasladosNode==BuiltInFunction.NullObject ())))) {
// XMLElement_SelectNodes
localVars.resXMLElement_SelectNodes_outParamXMLNodeList = await Actions.ActionXMLElement_SelectNodes(requestContext,localVars.varLcTrasladosNode,"./*[local-name()='Traslado']",cancellationToken);

// null object
if((!((localVars.resXMLElement_SelectNodes_outParamXMLNodeList==BuiltInFunction.NullObject ())))) {
// XMLNodeList_CountTraslado
localVars.resXMLNodeList_CountTraslado_outParamCount = await Actions.ActionXMLNodeList_Count(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,cancellationToken);

// for each
while (((localVars.varLcAuxCount<localVars.resXMLNodeList_CountTraslado_outParamCount))) {
// XMLNodeList_Item
localVars.resXMLNodeList_Item_outParamXMLNode = await Actions.ActionXMLNodeList_Item(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,localVars.varLcAuxCount,cancellationToken);

// XMLNode = XMLNodeList_Item.XMLNode
localVars.varLcXMLNode=localVars.resXMLNodeList_Item_outParamXMLNode;
// GetBase
localVars.resGetBase_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Base",cancellationToken);

// GetImpuesto
localVars.resGetImpuesto_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Impuesto",cancellationToken);

// GetTasaOCuota
localVars.resGetTasaOCuota_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"TasaOCuota",cancellationToken);

// GetTipoFactor
localVars.resGetTipoFactor_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"TipoFactor",cancellationToken);

// GetImporte
localVars.resGetImporte_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Importe",cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamInvoiceExtendedTaxList,new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceTaxTypeId = (ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId, ssImpuesto = localVars.resGetImpuesto_outParamAttributeValue, ssBase = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetBase_outParamAttributeValue), 2), ssTasaOCuota = BuiltInFunction.TextToDecimal (localVars.resGetTasaOCuota_outParamAttributeValue), ssImporte = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetImporte_outParamAttributeValue), 2), ssTipoFactor = localVars.resGetTipoFactor_outParamAttributeValue },cancellationToken);

// XML06A1_ImpuestosVerify
localVars.resXML06A1_ImpuestosVerify.outParamErrorMsg = await Actions.ActionXML06A1_ImpuestosVerify(requestContext,localVars.resGetImpuesto_outParamAttributeValue,cancellationToken);

// AuxCount = If
localVars.varLcAuxCount=(((localVars.resXML06A1_ImpuestosVerify.outParamErrorMsg=="")) ? ((localVars.varLcAuxCount+1)) : (localVars.resXMLNodeList_CountTraslado_outParamCount));

// ErrorMsg = XML06A1_ImpuestosVerify.ErrorMsg
result.outParamErrorMsg=localVars.resXML06A1_ImpuestosVerify.outParamErrorMsg;
}

// error?
if((!((result.outParamErrorMsg!="")))) {
// reset aux
// AuxCount = 0
localVars.varLcAuxCount=0;
if((localVars.inParamIsItem)) {
// SelectSingleNode_Retenciones2
localVars.resSelectSingleNode_Retenciones2_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Impuestos_outParamXMLNode,"./*[local-name()='Retenciones']",cancellationToken);

// RetentionsNode = SelectSingleNode_Retenciones2.XMLNode
localVars.varLcRetentionsNode=localVars.resSelectSingleNode_Retenciones2_outParamXMLNode;
} else {
// SelectSingleNode_Retenciones
localVars.resSelectSingleNode_Retenciones_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLDocument,"//*[local-name()='Comprobante']/*[local-name()='Impuestos']/*[local-name()='Retenciones']",cancellationToken);

// RetentionsNode = SelectSingleNode_Retenciones.XMLNode
localVars.varLcRetentionsNode=localVars.resSelectSingleNode_Retenciones_outParamXMLNode;
}

// null object
if((!((localVars.varLcRetentionsNode==BuiltInFunction.NullObject ())))) {
// XMLElement_SelectNodes2
localVars.resXMLElement_SelectNodes2_outParamXMLNodeList = await Actions.ActionXMLElement_SelectNodes(requestContext,localVars.varLcRetentionsNode,"./*[local-name()='Retencion']",cancellationToken);

// null object
if((!((localVars.resXMLElement_SelectNodes2_outParamXMLNodeList==BuiltInFunction.NullObject ())))) {
// XMLNodeList_CountRetencion
localVars.resXMLNodeList_CountRetencion_outParamCount = await Actions.ActionXMLNodeList_Count(requestContext,localVars.resXMLElement_SelectNodes2_outParamXMLNodeList,cancellationToken);

// for each
while (((localVars.varLcAuxCount<localVars.resXMLNodeList_CountRetencion_outParamCount))) {
// XMLNodeList_Item2
localVars.resXMLNodeList_Item2_outParamXMLNode = await Actions.ActionXMLNodeList_Item(requestContext,localVars.resXMLElement_SelectNodes2_outParamXMLNodeList,localVars.varLcAuxCount,cancellationToken);

// XMLNode = XMLNodeList_Item2.XMLNode
localVars.varLcXMLNode=localVars.resXMLNodeList_Item2_outParamXMLNode;
// GetBase2
localVars.resGetBase2_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Base",cancellationToken);

// GetImpuesto2
localVars.resGetImpuesto2_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Impuesto",cancellationToken);

// GetTasaOCuota2
localVars.resGetTasaOCuota2_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"TasaOCuota",cancellationToken);

// GetTipoFactor2
localVars.resGetTipoFactor2_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"TipoFactor",cancellationToken);

// GetImporte2
localVars.resGetImporte2_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Importe",cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamInvoiceExtendedTaxList,new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceTaxTypeId = (ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId, ssImpuesto = localVars.resGetImpuesto2_outParamAttributeValue, ssBase = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetBase2_outParamAttributeValue), 2), ssTasaOCuota = BuiltInFunction.TextToDecimal (localVars.resGetTasaOCuota2_outParamAttributeValue), ssImporte = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetImporte2_outParamAttributeValue), 2), ssTipoFactor = localVars.resGetTipoFactor2_outParamAttributeValue },cancellationToken);

// XML06A1_ImpuestosVerify2
localVars.resXML06A1_ImpuestosVerify2.outParamErrorMsg = await Actions.ActionXML06A1_ImpuestosVerify(requestContext,localVars.resGetImpuesto2_outParamAttributeValue,cancellationToken);

// AuxCount = If
localVars.varLcAuxCount=(((localVars.resXML06A1_ImpuestosVerify2.outParamErrorMsg=="")) ? ((localVars.varLcAuxCount+1)) : (localVars.resXMLNodeList_CountRetencion_outParamCount));

// ErrorMsg = XML06A1_ImpuestosVerify2.ErrorMsg
result.outParamErrorMsg=localVars.resXML06A1_ImpuestosVerify2.outParamErrorMsg;
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
outParamInvoiceExtendedTaxList = result.outParamInvoiceExtendedTaxList;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceExtendedTaxList,outParamErrorMsg);
}

public static class FuncActionXML06A_Impuestos {



}


}
