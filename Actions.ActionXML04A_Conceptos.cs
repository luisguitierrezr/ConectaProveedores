namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML04A_Conceptos : VarsBag {
public object inParamXMLNode;
public object inParamXMLDocument;
/// <summary>
/// Variable <code>AuxCount</code> that represents the Service Studio Integer <code>AuxCount</code>
///  <p>Description: </p>
/// </summary>
public int varLcAuxCount = 0;

/// <summary>
/// Variable <code>InvoiceExtendedItemTaxList</code> that represents the Service Studio
///  InvoiceExtendedItemTaxList <code>InvoiceExtendedItemTaxList</code> <p>Description: </p>
/// </summary>
public RL_052a618537841aabfe590fb1dffa78ab varLcInvoiceExtendedItemTaxList = new RL_052a618537841aabfe590fb1dffa78ab();

public Actions.lcoXML06A_Impuestos resXML04A2_Impuestos =  new Actions.lcoXML06A_Impuestos();
public int resXMLNodeList_Count_outParamCount = 0;

public object resXMLNodeList_Item_outParamXMLNode = null;

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate11 =  new Actions.lcoLogsAccountingCreate();
public object resXMLElement_SelectSingleNode_outParamXMLNode = null;

public Actions.lcoXML04A1_ItemConcepto resXML04A1_ItemConcepto =  new Actions.lcoXML04A1_ItemConcepto();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate12 =  new Actions.lcoLogsAccountingCreate();
public object resXMLElement_SelectNodes_outParamXMLNodeList = null;

public lcvXML04A_Conceptos(object inParamXMLNode, object inParamXMLDocument) {
this.inParamXMLNode = inParamXMLNode;
this.inParamXMLDocument = inParamXMLDocument;
}
}
public class lcoXML04A_Conceptos : VarsBag {
public RL_698fc6adea2f9e4df8f68df6dcd5ea9d outParamInvoiceExtendedItemList = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();

public string outParamErrorMsg = "";

public lcoXML04A_Conceptos() {
}
}
/// <summary>
/// Action <code>XML04A_Conceptos</code> that represents the Service Studio action
///  <code>XML04A_Conceptos</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_698fc6adea2f9e4df8f68df6dcd5ea9d,string)> ActionXML04A_Conceptos(IRequestContext requestContext,object inParamXMLNode,object inParamXMLDocument,CancellationToken cancellationToken) {
RL_698fc6adea2f9e4df8f68df6dcd5ea9d outParamInvoiceExtendedItemList = default;
string outParamErrorMsg = default;
lcoXML04A_Conceptos result = new lcoXML04A_Conceptos();
lcvXML04A_Conceptos localVars = new lcvXML04A_Conceptos(inParamXMLNode, inParamXMLDocument);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML04A_Conceptos", "6310321a-1cae-4e0c-88b6-f5ae4a14ed12"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML04A_Conceptos", "6310321a-1cae-4e0c-88b6-f5ae4a14ed12", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// XMLElement_SelectSingleNode
localVars.resXMLElement_SelectSingleNode_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.inParamXMLNode,"./*[local-name()='Conceptos']",cancellationToken);

// null object
if(((localVars.resXMLElement_SelectSingleNode_outParamXMLNode==BuiltInFunction.NullObject ()))) {
// ErrorMsg = "Problem in the Concepts field"
result.outParamErrorMsg="Problem in the Concepts field";
// LogsXMLValidationCreate11
localVars.resLogsXMLValidationCreate11.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Problem in the Concepts field", ssDescription = ".//*[local-name()='Conceptos'] object doesnt exist", ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// XMLElement_SelectNodes
localVars.resXMLElement_SelectNodes_outParamXMLNodeList = await Actions.ActionXMLElement_SelectNodes(requestContext,localVars.resXMLElement_SelectSingleNode_outParamXMLNode,"./*[local-name()='Concepto']",cancellationToken);

// null object
if(((localVars.resXMLElement_SelectNodes_outParamXMLNodeList==BuiltInFunction.NullObject ()))) {
// ErrorMsg = "Problem in the Concepts field"
result.outParamErrorMsg="Problem in the Concepts field";
// LogsXMLValidationCreate12
localVars.resLogsXMLValidationCreate12.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Problem in the Concept field", ssDescription = ".//*[local-name()='Concepto'] object doesnt exist", ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// XMLNodeList_Count
localVars.resXMLNodeList_Count_outParamCount = await Actions.ActionXMLNodeList_Count(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,cancellationToken);

// for each
while (((localVars.varLcAuxCount<localVars.resXMLNodeList_Count_outParamCount))) {
// XMLNodeList_Item
localVars.resXMLNodeList_Item_outParamXMLNode = await Actions.ActionXMLNodeList_Item(requestContext,localVars.resXMLElement_SelectNodes_outParamXMLNodeList,localVars.varLcAuxCount,cancellationToken);

// XML04A1_ItemConcepto
localVars.resXML04A1_ItemConcepto.outParamInvoiceExtendedItem = await Actions.ActionXML04A1_ItemConcepto(requestContext,localVars.resXMLNodeList_Item_outParamXMLNode,cancellationToken);

// XML04A2_Impuestos
(localVars.resXML04A2_Impuestos.outParamInvoiceExtendedTaxList,localVars.resXML04A2_Impuestos.outParamErrorMsg) = await Actions.ActionXML06A_Impuestos(requestContext,localVars.resXMLNodeList_Item_outParamXMLNode,localVars.inParamXMLDocument,true,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcInvoiceExtendedItemTaxList,(await RL_052a618537841aabfe590fb1dffa78ab.ConvertAsync(localVars.resXML04A2_Impuestos.outParamInvoiceExtendedTaxList, new RL_052a618537841aabfe590fb1dffa78ab(), async (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord source, EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord target, CancellationToken cancellationToken) => {
target.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssInvoiceExtendedItemId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssInvoiceTaxTypeId = source.ssInvoiceTaxTypeId;
target.ssImpuesto = source.ssImpuesto;
target.ssBase = source.ssBase;
target.ssTasaOCuota = source.ssTasaOCuota;
target.ssImporte = source.ssImporte;
target.ssTipoFactor = source.ssTipoFactor;
return target;
}, cancellationToken)),cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamInvoiceExtendedItemList,(await RecordUtils.ConvertAsync(localVars.resXML04A1_ItemConcepto.outParamInvoiceExtendedItem, new RC_ce1213db14f29aa4f95120ea7ad7d0b7(), async (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord source, RC_ce1213db14f29aa4f95120ea7ad7d0b7 target, CancellationToken cancellationToken) => {
target.ssENInvoiceExtendedItem.ssId = source.ssId;
target.ssENInvoiceExtendedItem.ssInvoiceId = source.ssInvoiceId;
target.ssENInvoiceExtendedItem.ssProductNumber = source.ssProductNumber;
target.ssENInvoiceExtendedItem.ssDescription = source.ssDescription;
target.ssENInvoiceExtendedItem.ssMaterialCode = source.ssMaterialCode;
target.ssENInvoiceExtendedItem.ssQuantity = source.ssQuantity;
target.ssENInvoiceExtendedItem.ssUnityPrice = source.ssUnityPrice;
target.ssENInvoiceExtendedItem.ssCurrency = source.ssCurrency;
target.ssRLInvoiceExtendedItemTaxList = localVars.varLcInvoiceExtendedItemTaxList;
return target;
}, cancellationToken)),cancellationToken);

// AuxCount = If
localVars.varLcAuxCount=(((localVars.resXML04A2_Impuestos.outParamErrorMsg=="")) ? ((localVars.varLcAuxCount+1)) : (localVars.resXMLNodeList_Count_outParamCount));

// ErrorMsg = XML04A2_Impuestos.ErrorMsg
result.outParamErrorMsg=localVars.resXML04A2_Impuestos.outParamErrorMsg;
// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcInvoiceExtendedItemTaxList,cancellationToken);

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceExtendedItemList = result.outParamInvoiceExtendedItemList;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceExtendedItemList,outParamErrorMsg);
}

public static class FuncActionXML04A_Conceptos {



}


}
