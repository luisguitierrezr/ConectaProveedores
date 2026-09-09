namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML07_Otros : VarsBag {
public object inParamXMLNode;
/// <summary>
/// Variable <code>AuxCount</code> that represents the Service Studio Integer <code>AuxCount</code>
///  <p>Description: </p>
/// </summary>
public int varLcAuxCount = 0;

public string resGetNombrecon_outParamAttributeValue = "";

public int resXMLNodeList_Count_outParamCount = 0;

public object resSelectSingleNode_PAGOS_TERCEROS_outParamXMLNode = null;

public string resGetSalidacon_outParamAttributeValue = "";

public object resXMLNodeList_Item_outParamXMLNode = null;

public string resGettotalPC_outParamAttributeValue = "";

public object resXMLElement_SelectNodes_outParamXMLNodeList = null;

public object resSelectSingleNode_DOC_NOT_IN4MEX_outParamXMLNode = null;

public object resSelectSingleNode_Addenda_outParamXMLNode = null;

public lcvXML07_Otros(object inParamXMLNode) {
this.inParamXMLNode = inParamXMLNode;
}
}
public class lcoXML07_Otros : VarsBag {
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f outParamInvoiceExtendedMoreChargesList = new RL_4d4dc9b85c4a7d6bf03b676c2530ea4f();

public string outParamErrorMsg = "";

public lcoXML07_Otros() {
}
}
/// <summary>
/// Action <code>XML07_Otros</code> that represents the Service Studio action <code>XML07_Otros</code>
///  <p> Description: </p>
/// </summary>
public static async Task<(RL_4d4dc9b85c4a7d6bf03b676c2530ea4f,string)> ActionXML07_Otros(IRequestContext requestContext,object inParamXMLNode,CancellationToken cancellationToken) {
RL_4d4dc9b85c4a7d6bf03b676c2530ea4f outParamInvoiceExtendedMoreChargesList = default;
string outParamErrorMsg = default;
lcoXML07_Otros result = new lcoXML07_Otros();
lcvXML07_Otros localVars = new lcvXML07_Otros(inParamXMLNode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML07_Otros", "c398990b-aa52-43e2-afb4-e73a9de004a7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML07_Otros", "c398990b-aa52-43e2-afb4-e73a9de004a7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SelectSingleNode_Addenda
localVars.resSelectSingleNode_Addenda_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLNode,"//*[local-name()='Addenda']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_Addenda_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// SelectSingleNode_DOC_NOT_IN4MEX
localVars.resSelectSingleNode_DOC_NOT_IN4MEX_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLNode,"//*[local-name()='DOC_NOT_IN4MEX']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_DOC_NOT_IN4MEX_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// SelectSingleNode_PAGOS_TERCEROS
localVars.resSelectSingleNode_PAGOS_TERCEROS_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLNode,"//*[local-name()='PAGOS_TERCEROS']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_PAGOS_TERCEROS_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// GettotalPC
localVars.resGettotalPC_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.resSelectSingleNode_PAGOS_TERCEROS_outParamXMLNode,"totalPC",cancellationToken);

if((((localVars.resGettotalPC_outParamAttributeValue=="")||(localVars.resGettotalPC_outParamAttributeValue==Convert.ToString(0))))) {
// ErrorMsg = "Esta factura tiene una addenda. Sin embargo, no fue posible encontrar el campo totalPC en el archivo XML adjunto."
result.outParamErrorMsg="Esta factura tiene una addenda. Sin embargo, no fue posible encontrar el campo totalPC en el archivo XML adjunto.";
} else {
// XMLElement_SelectNodes
localVars.resXMLElement_SelectNodes_outParamXMLNodeList = await Actions.ActionXMLElement_SelectNodes(requestContext,localVars.resSelectSingleNode_PAGOS_TERCEROS_outParamXMLNode,"//*[local-name()='CONCEPTOS']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_PAGOS_TERCEROS_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// XMLNodeList_Count
localVars.resXMLNodeList_Count_outParamCount = await Actions.ActionXMLNodeList_Count(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,cancellationToken);

while (((localVars.varLcAuxCount<localVars.resXMLNodeList_Count_outParamCount))) {
// XMLNodeList_Item
localVars.resXMLNodeList_Item_outParamXMLNode = await Actions.ActionXMLNodeList_Item(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,localVars.varLcAuxCount,cancellationToken);

// GetNombrecon
localVars.resGetNombrecon_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.resXMLNodeList_Item_outParamXMLNode,"nombrecon",cancellationToken);

// GetSalidacon
localVars.resGetSalidacon_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.resXMLNodeList_Item_outParamXMLNode,"salidacon",cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamInvoiceExtendedMoreChargesList,new EN_a9440c310249b67518f0615139b4c690EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssNombreConcepto = localVars.resGetNombrecon_outParamAttributeValue, ssValue = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetSalidacon_outParamAttributeValue), 2) },cancellationToken);

// AuxCount = AuxCount + 1
localVars.varLcAuxCount=(localVars.varLcAuxCount+1);
}

}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceExtendedMoreChargesList = result.outParamInvoiceExtendedMoreChargesList;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceExtendedMoreChargesList,outParamErrorMsg);
}

public static class FuncActionXML07_Otros {



}


}
