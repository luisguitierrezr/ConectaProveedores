namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML05A_CFDIRelacionados : VarsBag {
public object inParamXMLNode;
/// <summary>
/// Variable <code>AuxCount</code> that represents the Service Studio Integer <code>AuxCount</code>
///  <p>Description: </p>
/// </summary>
public int varLcAuxCount = 0;

public string resGetUUID_outParamAttributeValue = "";

public string resGetTipoRelacion_outParamAttributeValue = "";

public object resXMLElement_SelectSingleNode_outParamXMLNode = null;

public int resXMLNodeList_Count_outParamCount = 0;

public object resXMLElement_SelectNodes_outParamXMLNodeList = null;

public object resXMLNodeList_Item_outParamXMLNode = null;

public lcvXML05A_CFDIRelacionados(object inParamXMLNode) {
this.inParamXMLNode = inParamXMLNode;
}
}
public class lcoXML05A_CFDIRelacionados : VarsBag {
public RL_1801d41568a41cf6282486c389726e17 outParamInvoiceExtendedRelationsList = new RL_1801d41568a41cf6282486c389726e17();

public lcoXML05A_CFDIRelacionados() {
}
}
/// <summary>
/// Action <code>XML05A_CFDIRelacionados</code> that represents the Service Studio action
///  <code>XML05A_CFDIRelacionados</code> <p> Description: </p>
/// </summary>
public static async Task<RL_1801d41568a41cf6282486c389726e17> ActionXML05A_CFDIRelacionados(IRequestContext requestContext,object inParamXMLNode,CancellationToken cancellationToken) {
RL_1801d41568a41cf6282486c389726e17 outParamInvoiceExtendedRelationsList = default;
lcoXML05A_CFDIRelacionados result = new lcoXML05A_CFDIRelacionados();
lcvXML05A_CFDIRelacionados localVars = new lcvXML05A_CFDIRelacionados(inParamXMLNode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML05A_CFDIRelacionados", "dc1de214-b386-4ba4-9db8-1385475d2f7a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML05A_CFDIRelacionados", "dc1de214-b386-4ba4-9db8-1385475d2f7a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// XMLElement_SelectSingleNode
localVars.resXMLElement_SelectSingleNode_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLNode,".//*[local-name()='CfdiRelacionados']",cancellationToken);

// null object
if((!((localVars.resXMLElement_SelectSingleNode_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// GetTipoRelacion
localVars.resGetTipoRelacion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.resXMLElement_SelectSingleNode_outParamXMLNode,"TipoRelacion",cancellationToken);

// XMLElement_SelectNodes
localVars.resXMLElement_SelectNodes_outParamXMLNodeList = await Actions.ActionXMLElement_SelectNodes(requestContext,localVars.resXMLElement_SelectSingleNode_outParamXMLNode,".//*[local-name()='CfdiRelacionado']",cancellationToken);

// null object
if((!((localVars.resXMLElement_SelectNodes_outParamXMLNodeList==BuiltInFunction.NullObject ())))) {
// XMLNodeList_Count
localVars.resXMLNodeList_Count_outParamCount = await Actions.ActionXMLNodeList_Count(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,cancellationToken);

// for each
while (((localVars.varLcAuxCount<localVars.resXMLNodeList_Count_outParamCount))) {
// XMLNodeList_Item
localVars.resXMLNodeList_Item_outParamXMLNode = await Actions.ActionXMLNodeList_Item(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,localVars.varLcAuxCount,cancellationToken);

// GetUUID
localVars.resGetUUID_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.resXMLNodeList_Item_outParamXMLNode,"UUID",cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamInvoiceExtendedRelationsList,new EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTipoRelacion = localVars.resGetTipoRelacion_outParamAttributeValue, ssUUIDRelacionado = localVars.resGetUUID_outParamAttributeValue },cancellationToken);

// AuxCount = AuxCount + 1
localVars.varLcAuxCount=(localVars.varLcAuxCount+1);
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceExtendedRelationsList = result.outParamInvoiceExtendedRelationsList;
} // inner-finally
RETURN_STATEMENT:
return outParamInvoiceExtendedRelationsList;
}

public static class FuncActionXML05A_CFDIRelacionados {



}


}
