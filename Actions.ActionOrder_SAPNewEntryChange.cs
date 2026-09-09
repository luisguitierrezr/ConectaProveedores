namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrder_SAPNewEntryChange : VarsBag {
public ST_3fd667dc2513888f6027df59e05def3fStructure inParamRow;
public bool inParamIsCancel;
public long inParamOrderMainId;
public RL_36053b0a011ac5d2d2fe088489de85e6 inParamOrderItems;
public string inParamEntryDoc;
public string inParamEntryNumberEM;
public string inParamEntryYear;
public string inParamUUID;
public bool inParami_IsRejectFolio;
/// <summary>
/// Variable <code>OrderItemEntries</code> that represents the Service Studio OrderItemEntries
///  <code>OrderItemEntries</code> <p>Description: </p>
/// </summary>
public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord varLcOrderItemEntries = new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord();

/// <summary>
/// Variable <code>OrderItemsPos</code> that represents the Service Studio Text
///  <code>OrderItemsPos</code> <p>Description: </p>
/// </summary>
public string varLcOrderItemsPos = "";

/// <summary>
/// Variable <code>QtEntriesSAP</code> that represents the Service Studio Decimal
///  <code>QtEntriesSAP</code> <p>Description: </p>
/// </summary>
public decimal varLcQtEntriesSAP = 0.0M;

/// <summary>
/// Variable <code>QtEntriesConecta</code> that represents the Service Studio Decimal
///  <code>QtEntriesConecta</code> <p>Description: </p>
/// </summary>
public decimal varLcQtEntriesConecta = 0.0M;

/// <summary>
/// Variable <code>QtEntriesTotal</code> that represents the Service Studio Decimal
///  <code>QtEntriesTotal</code> <p>Description: </p>
/// </summary>
public decimal varLcQtEntriesTotal = 0.0M;

/// <summary>
/// Variable <code>QtEntriesConectaInApproval</code> that represents the Service Studio Decimal
///  <code>QtEntriesConectaInApproval</code> <p>Description: </p>
/// </summary>
public decimal varLcQtEntriesConectaInApproval = 0.0M;

/// <summary>
/// Variable <code>QtOrderItem</code> that represents the Service Studio Decimal
///  <code>QtOrderItem</code> <p>Description: </p>
/// </summary>
public decimal varLcQtOrderItem = 0.0M;

/// <summary>
/// Variable <code>FolioIdToCancel</code> that represents the Service Studio FolioIdentifier
///  <code>FolioIdToCancel</code> <p>Description: </p>
/// </summary>
public long varLcFolioIdToCancel = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public RL_2b1ecd74439b838f80b83dd2e3b4dd2a resListFilter2_outParamFilteredList = new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();

public Actions.lcoOrderItemEntriesCreate resOrderItemEntriesCreate =  new Actions.lcoOrderItemEntriesCreate();
public RL_2b1ecd74439b838f80b83dd2e3b4dd2a queryResGetFolioItemsByItemId2_outParamList = new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();
public long queryResGetFolioItemsByItemId2_outParamCount = 0L;

public RL_36053b0a011ac5d2d2fe088489de85e6 resListFilter_outParamFilteredList = new RL_36053b0a011ac5d2d2fe088489de85e6();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public RL_f09a54b116410a7027db4eb30998df1e queryResGetFolioItemsByItemIdApproved_outParamList = new RL_f09a54b116410a7027db4eb30998df1e();
public long queryResGetFolioItemsByItemIdApproved_outParamCount = 0L;

public RL_f09a54b116410a7027db4eb30998df1e queryResGetFolioItemsByItemId_outParamList = new RL_f09a54b116410a7027db4eb30998df1e();
public long queryResGetFolioItemsByItemId_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoOrder_SAPNewEntryChangeCancel resOrder_SAPNewEntryChangeCancel =  new Actions.lcoOrder_SAPNewEntryChangeCancel();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoFolioCancelFromEntry resFolioCancelFromEntry =  new Actions.lcoFolioCancelFromEntry();
public RL_d8fbadd9d27fdb0e62381fbcaf364158 queryResGetOrderItemEntriesByItemId_outParamList = new RL_d8fbadd9d27fdb0e62381fbcaf364158();
public long queryResGetOrderItemEntriesByItemId_outParamCount = 0L;

public lcvOrder_SAPNewEntryChange(ST_3fd667dc2513888f6027df59e05def3fStructure inParamRow, bool inParamIsCancel, long inParamOrderMainId, RL_36053b0a011ac5d2d2fe088489de85e6 inParamOrderItems, string inParamEntryDoc, string inParamEntryNumberEM, string inParamEntryYear, string inParamUUID, bool inParami_IsRejectFolio) {
this.inParamRow = inParamRow;
this.inParamIsCancel = inParamIsCancel;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamOrderItems = inParamOrderItems;
this.inParamEntryDoc = inParamEntryDoc;
this.inParamEntryNumberEM = inParamEntryNumberEM;
this.inParamEntryYear = inParamEntryYear;
this.inParamUUID = inParamUUID;
this.inParami_IsRejectFolio = inParami_IsRejectFolio;
}
}
public class lcoOrder_SAPNewEntryChange : VarsBag {
public bool outParamIsSuccess = false;

public bool outParamo_IsRejectFolio = false;

public lcoOrder_SAPNewEntryChange() {
}
}
/// <summary>
/// Action <code>Order_SAPNewEntryChange</code> that represents the Service Studio action
///  <code>Order_SAPNewEntryChange</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,bool)> ActionOrder_SAPNewEntryChange(IRequestContext requestContext,ST_3fd667dc2513888f6027df59e05def3fStructure inParamRow,bool inParamIsCancel,long inParamOrderMainId,RL_36053b0a011ac5d2d2fe088489de85e6 inParamOrderItems,string inParamEntryDoc,string inParamEntryNumberEM,string inParamEntryYear,string inParamUUID,bool inParami_IsRejectFolio,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
bool outParamo_IsRejectFolio = default;
lcoOrder_SAPNewEntryChange result = new lcoOrder_SAPNewEntryChange();
lcvOrder_SAPNewEntryChange localVars = new lcvOrder_SAPNewEntryChange(inParamRow, inParamIsCancel, inParamOrderMainId, inParamOrderItems, inParamEntryDoc, inParamEntryNumberEM, inParamEntryYear, inParamUUID, inParami_IsRejectFolio);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Order_SAPNewEntryChange", "b1813586-86e5-4ec4-953e-1a6648925284"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Order_SAPNewEntryChange", "b1813586-86e5-4ec4-953e-1a6648925284", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach OrderItems
localVars.inParamOrderItems.StartIteration();
try {while (!((localVars.inParamOrderItems.Eof))) {
// OrderItemsPos = OrderItemsPos + ", " + OrderItems.Current.Position
localVars.varLcOrderItemsPos=((localVars.varLcOrderItemsPos+", ")+Convert.ToString(localVars.inParamOrderItems.CurrentRec.ssPosition));
localVars.inParamOrderItems.Advance();
}

} finally {
localVars.inParamOrderItems.EndIteration();
}

// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_36053b0a011ac5d2d2fe088489de85e6)await  localVars.inParamOrderItems.FilterAsync(async (p, cancellationToken) => (Convert.ToInt64(p.ssPosition)==localVars.inParamRow.ssRowNumber), cancellationToken)));

// does not match?
if((localVars.resListFilter_outParamFilteredList.Empty)) {
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call Update API", ssDescription = ((("Haven't found any Row: "+BuiltInFunction.LongIntegerToText(localVars.inParamRow.ssRowNumber))+" // Pedido Posiciones: ")+localVars.varLcOrderItemsPos), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

} else {
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call Update API", ssDescription = ((((("Row: "+BuiltInFunction.LongIntegerToText(localVars.inParamRow.ssRowNumber))+" // Qt: ")+BuiltInFunction.DecimalToText(localVars.inParamRow.ssQuantity))+" // Pedido Posiciones: ")+localVars.varLcOrderItemsPos), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

// OrderItemEntries.Quantity_ = If
localVars.varLcOrderItemEntries.ssQuantity_ = ((localVars.inParamIsCancel) ? ((BuiltInFunction.TextToDecimal (BuiltInFunction.DecimalToText(localVars.inParamRow.ssQuantity))*(((decimal)(-1))))) : (BuiltInFunction.TextToDecimal (BuiltInFunction.DecimalToText(localVars.inParamRow.ssQuantity))));

// OrderItemEntries.OrderMainItemid = ListFilter.FilteredList.Current.Id
localVars.varLcOrderItemEntries.ssOrderMainItemid = localVars.resListFilter_outParamFilteredList.CurrentRec.ssId;

// IsSuccess = True
result.outParamIsSuccess=true;

// OrderItemEntries.EntryDocument = EntryDoc
localVars.varLcOrderItemEntries.ssEntryDocument = localVars.inParamEntryDoc;
// OrderItemEntriesCreate
localVars.resOrderItemEntriesCreate.outParamId = await Actions.ActionOrderItemEntriesCreate(requestContext,localVars.varLcOrderItemEntries,cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParamOrderMainId, ssMessage = (((localVars.inParamIsCancel) ? ((AppUtils.GetStringResource("MxMXuNSpu0myeehgteUeTg#Value.29829170.1", "Entries were sent as canceled for position")+" ")) : ((AppUtils.GetStringResource("MxMXuNSpu0myeehgteUeTg#Value.-333466447.1", "Entries were sent as delivered for position")+" ")))+Convert.ToString(localVars.inParamOrderItems.CurrentRec.ssPosition)), ssIsError = false },cancellationToken);

if((localVars.inParamIsCancel)) {
// Order_SAPNewEntryChangeCancel
localVars.resOrder_SAPNewEntryChangeCancel.outParamo_IsRejectFolio = await Actions.ActionOrder_SAPNewEntryChangeCancel(requestContext,localVars.inParamUUID,localVars.inParami_IsRejectFolio,localVars.inParamEntryDoc,localVars.inParamEntryNumberEM,localVars.inParamEntryYear,localVars.resOrderItemEntriesCreate.outParamId,cancellationToken);

// o_IsRejectFolio = Order_SAPNewEntryChangeCancel.o_IsRejectFolio
result.outParamo_IsRejectFolio=localVars.resOrder_SAPNewEntryChangeCancel.outParamo_IsRejectFolio;
} else {
// o_IsRejectFolio = False
result.outParamo_IsRejectFolio=false;
// Query datasetGetOrderItemEntriesByItemId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderItemEntriesByItemId_maxRecords = 0;
int datasetGetOrderItemEntriesByItemId_startIndex = 0;(localVars.queryResGetOrderItemEntriesByItemId_outParamList,localVars.queryResGetOrderItemEntriesByItemId_outParamCount) = await FuncActionOrder_SAPNewEntryChange.datasetGetOrderItemEntriesByItemId(requestContext,datasetGetOrderItemEntriesByItemId_maxRecords,datasetGetOrderItemEntriesByItemId_startIndex,IterationMultiplicity.Never,localVars.resListFilter_outParamFilteredList.CurrentRec.ssId,cancellationToken);

// Query datasetGetFolioItemsByItemIdApproved
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByItemIdApproved_maxRecords = 0;
int datasetGetFolioItemsByItemIdApproved_startIndex = 0;(localVars.queryResGetFolioItemsByItemIdApproved_outParamList,localVars.queryResGetFolioItemsByItemIdApproved_outParamCount) = await FuncActionOrder_SAPNewEntryChange.datasetGetFolioItemsByItemIdApproved(requestContext,datasetGetFolioItemsByItemIdApproved_maxRecords,datasetGetFolioItemsByItemIdApproved_startIndex,IterationMultiplicity.Never,localVars.resListFilter_outParamFilteredList.CurrentRec.ssId,cancellationToken);

// QtEntriesTotal = GetOrderItemEntriesByItemId.List.Current.Quantity_Sum + GetFolioItemsByItemIdApproved.List.Current.InvoiceQttSum
localVars.varLcQtEntriesTotal=(localVars.queryResGetOrderItemEntriesByItemId_outParamList.CurrentRec.ssQuantity_Sum+localVars.queryResGetFolioItemsByItemIdApproved_outParamList.CurrentRec.ssInvoiceQttSum);

// QtEntriesSAP = GetOrderItemEntriesByItemId.List.Current.Quantity_Sum
localVars.varLcQtEntriesSAP=localVars.queryResGetOrderItemEntriesByItemId_outParamList.CurrentRec.ssQuantity_Sum;

// QtEntriesConecta = GetFolioItemsByItemIdApproved.List.Current.InvoiceQttSum
localVars.varLcQtEntriesConecta=localVars.queryResGetFolioItemsByItemIdApproved_outParamList.CurrentRec.ssInvoiceQttSum;

// QtOrderItem = ListFilter.FilteredList.Current.Quantity
localVars.varLcQtOrderItem=localVars.resListFilter_outParamFilteredList.CurrentRec.ssQuantity;
while (true) {
// Query datasetGetFolioItemsByItemId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByItemId_maxRecords = 0;
int datasetGetFolioItemsByItemId_startIndex = 0;(localVars.queryResGetFolioItemsByItemId_outParamList,localVars.queryResGetFolioItemsByItemId_outParamCount) = await FuncActionOrder_SAPNewEntryChange.datasetGetFolioItemsByItemId(requestContext,datasetGetFolioItemsByItemId_maxRecords,datasetGetFolioItemsByItemId_startIndex,IterationMultiplicity.Never,localVars.resListFilter_outParamFilteredList.CurrentRec.ssId,cancellationToken);

// QtEntriesConectaInApproval = GetFolioItemsByItemId.List.Current.InvoiceQttSum
localVars.varLcQtEntriesConectaInApproval=localVars.queryResGetFolioItemsByItemId_outParamList.CurrentRec.ssInvoiceQttSum;
// quantities not ok
if(((((localVars.varLcQtEntriesSAP+localVars.varLcQtEntriesConectaInApproval)>localVars.varLcQtOrderItem)&&(!localVars.queryResGetFolioItemsByItemId_outParamList.Empty)))) {
// Query datasetGetFolioItemsByItemId2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByItemId2_maxRecords = 0;
int datasetGetFolioItemsByItemId2_startIndex = 0;(localVars.queryResGetFolioItemsByItemId2_outParamList,localVars.queryResGetFolioItemsByItemId2_outParamCount) = await FuncActionOrder_SAPNewEntryChange.datasetGetFolioItemsByItemId2(requestContext,datasetGetFolioItemsByItemId2_maxRecords,datasetGetFolioItemsByItemId2_startIndex,IterationMultiplicity.Single,localVars.resListFilter_outParamFilteredList.CurrentRec.ssId,cancellationToken);

// not empty
if(((!localVars.queryResGetFolioItemsByItemId2_outParamList.Empty))) {
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_2b1ecd74439b838f80b83dd2e3b4dd2a)await  localVars.queryResGetFolioItemsByItemId2_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENFolioItems.ssInvoiceQtt+localVars.varLcQtEntriesTotal)>localVars.varLcQtOrderItem), cancellationToken)));

// FolioIdToCancel = If
localVars.varLcFolioIdToCancel=(((!localVars.resListFilter2_outParamFilteredList.Empty)) ? (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssENFolio.ssId) : (localVars.queryResGetFolioItemsByItemId2_outParamList.CurrentRec.ssENFolio.ssId));
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Entry Change", ssDescription = ((((((((("(("+BuiltInFunction.DecimalToText(localVars.varLcQtEntriesSAP))+" + ")+BuiltInFunction.DecimalToText(localVars.varLcQtEntriesConectaInApproval))+") <= ")+BuiltInFunction.DecimalToText(localVars.varLcQtOrderItem))+") or ")+(localVars.queryResGetFolioItemsByItemId_outParamList.Empty ? "True" : "False"))+"//\r\nQtApproved = ")+BuiltInFunction.DecimalToText(localVars.varLcQtEntriesTotal)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

// FolioCancelFromEntry
localVars.resFolioCancelFromEntry.outParamo_Output = await Actions.ActionFolioCancelFromEntry(requestContext,localVars.varLcFolioIdToCancel,localVars.inParamEntryDoc,cancellationToken);

} else {
goto RETURN_STATEMENT;

}

} else {
goto RETURN_STATEMENT;

}

}

}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// IsSuccess = False
result.outParamIsSuccess=false;
// LogMessage
await ExtendedActions.LogMessage(requestContext,ex.Message,ex.Message,cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamo_IsRejectFolio = result.outParamo_IsRejectFolio;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamo_IsRejectFolio);
}

public static class FuncActionOrder_SAPNewEntryChange {

private static async Task<RC_88067cef1566b3e5511988d0eaf88bc3> datasetGetFolioItemsByItemId2ReadDbAsync(RC_88067cef1566b3e5511988d0eaf88bc3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByItemId2" 8nR3Q+7ASUCmgrKwbF1cwA of Action "Order_SAPNewEntryChange"
public static async Task<(RL_2b1ecd74439b838f80b83dd2e3b4dd2a,long)> datasetGetFolioItemsByItemId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPNewEntryChange.GetFolioItemsByItemId2", "437774f2-c0ee-4049-a682-b2b06c5d5cc0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPNewEntryChange.GetFolioItemsByItemId2", "437774f2-c0ee-4049-a682-b2b06c5d5cc0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.hjWBseWGxE6VPhpmSJJShA/NodesNotShownInESpaceTree.8nR3Q+7ASUCmgrKwbF1cwA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio43\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, trim_scale(\"enfolioitems6\".\"invoiceqtt\"::numeric) o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103");
fromBuilder.Append(" FROM ((({OrderMainItem} \"enordermainitem8\" Left JOIN {FolioItems} \"enfolioitems6\" ON (\"enordermainitem8\".\"id\" = \"enfolioitems6\".\"ordermainitemid\"))  Left JOIN {Folio} \"enfolio43\" ON (\"enfolioitems6\".\"folioid\" = \"enfolio43\".\"id\"))  Left JOIN {FolioSAPData} \"enfoliosapdata8\" ON (\"enfolio43\".\"id\" = \"enfoliosapdata8\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_Id != 0) {
whereBuilder.Append("((\"enordermainitem8\".\"id\" = @qporOrderMainItem_Id) AND (\"enordermainitem8\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_Id", DbType.Int64, qporOrderMainItem_Id);
} else {
whereBuilder.Append("(\"enordermainitem8\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfoliosapdata8\".\"po_documento_material_em\" IS NULL) AND (((\"enfolio43\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio43\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append(")) AND (\"enfolio43\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"enordermainitem8\".\"id\" ASC ");
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
RL_2b1ecd74439b838f80b83dd2e3b4dd2a outParamList = new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByItemId2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPNewEntryChange.GetFolioItemsByItemId2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b1ecd74439b838f80b83dd2e3b4dd2a _tmp = new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByItemId2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPNewEntryChange.GetFolioItemsByItemId2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2b1ecd74439b838f80b83dd2e3b4dd2a)_tmp;
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

// Query Function "GetFolioItemsByItemIdApproved" taJ0WieP2EuF1j4hV3o6oA of Action "Order_SAPNewEntryChange"
public static async Task<(RL_f09a54b116410a7027db4eb30998df1e,long)> datasetGetFolioItemsByItemIdApproved(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPNewEntryChange.GetFolioItemsByItemIdApproved", "5a74a2b5-8f27-4bd8-85d6-3e21577a3aa0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPNewEntryChange.GetFolioItemsByItemIdApproved", "5a74a2b5-8f27-4bd8-85d6-3e21577a3aa0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hjWBseWGxE6VPhpmSJJShA/NodesNotShownInESpaceTree.taJ0WieP2EuF1j4hV3o6oA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems7\".\"invoiceqtt\") \"invoiceqttsum\"");
fromBuilder.Append(" FROM ((({OrderMainItem} \"enordermainitem9\" Left JOIN {FolioItems} \"enfolioitems7\" ON (\"enordermainitem9\".\"id\" = \"enfolioitems7\".\"ordermainitemid\"))  Left JOIN {Folio} \"enfolio44\" ON (\"enfolioitems7\".\"folioid\" = \"enfolio44\".\"id\"))  Left JOIN {FolioSAPData} \"enfoliosapdata9\" ON (\"enfolio44\".\"id\" = \"enfoliosapdata9\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_Id != 0) {
whereBuilder.Append("((\"enordermainitem9\".\"id\" = @qporOrderMainItem_Id) AND (\"enordermainitem9\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_Id", DbType.Int64, qporOrderMainItem_Id);
} else {
whereBuilder.Append("(\"enordermainitem9\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfoliosapdata9\".\"po_documento_material_em\" <> '') OR (\"enfolio44\".\"foliostatusid\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId);
whereBuilder.Append("))");
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
RL_f09a54b116410a7027db4eb30998df1e outParamList = new RL_f09a54b116410a7027db4eb30998df1e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPNewEntryChange.GetFolioItemsByItemIdApproved.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f09a54b116410a7027db4eb30998df1e _tmp = new RL_f09a54b116410a7027db4eb30998df1e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPNewEntryChange.GetFolioItemsByItemIdApproved.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f09a54b116410a7027db4eb30998df1e)_tmp;
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

// Query Function "GetFolioItemsByItemId" p_54Zikz3Ue3JHWnxRWexA of Action "Order_SAPNewEntryChange"
public static async Task<(RL_f09a54b116410a7027db4eb30998df1e,long)> datasetGetFolioItemsByItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPNewEntryChange.GetFolioItemsByItemId", "6678fea7-3329-47dd-b724-75a7c5159ec4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPNewEntryChange.GetFolioItemsByItemId", "6678fea7-3329-47dd-b724-75a7c5159ec4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hjWBseWGxE6VPhpmSJJShA/NodesNotShownInESpaceTree.p_54Zikz3Ue3JHWnxRWexA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems8\".\"invoiceqtt\") \"invoiceqttsum\"");
fromBuilder.Append(" FROM (({Folio} \"enfolio45\" Left JOIN {FolioItems} \"enfolioitems8\" ON (\"enfolioitems8\".\"folioid\" = \"enfolio45\".\"id\"))  Left JOIN {OrderMainItem} \"enordermainitem10\" ON (\"enordermainitem10\".\"id\" = \"enfolioitems8\".\"ordermainitemid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_Id != 0) {
whereBuilder.Append("((\"enordermainitem10\".\"id\" = @qporOrderMainItem_Id) AND (\"enordermainitem10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_Id", DbType.Int64, qporOrderMainItem_Id);
} else {
whereBuilder.Append("(\"enordermainitem10\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolio45\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio45\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append("))");
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
RL_f09a54b116410a7027db4eb30998df1e outParamList = new RL_f09a54b116410a7027db4eb30998df1e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPNewEntryChange.GetFolioItemsByItemId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f09a54b116410a7027db4eb30998df1e _tmp = new RL_f09a54b116410a7027db4eb30998df1e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPNewEntryChange.GetFolioItemsByItemId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f09a54b116410a7027db4eb30998df1e)_tmp;
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

// Query Function "GetOrderItemEntriesByItemId" wesm9Z5QjEyzbevLcRaKDg of Action "Order_SAPNewEntryChange"
public static async Task<(RL_d8fbadd9d27fdb0e62381fbcaf364158,long)> datasetGetOrderItemEntriesByItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItemid,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPNewEntryChange.GetOrderItemEntriesByItemId", "f526ebc1-509e-4c8c-b36d-ebcb71168a0e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPNewEntryChange.GetOrderItemEntriesByItemId", "f526ebc1-509e-4c8c-b36d-ebcb71168a0e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hjWBseWGxE6VPhpmSJJShA/NodesNotShownInESpaceTree.wesm9Z5QjEyzbevLcRaKDg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enorderitementries1\".\"quantity_\") \"quantity_sum\"");
fromBuilder.Append(" FROM {OrderItemEntries} \"enorderitementries1\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItemid != 0) {
whereBuilder.Append("((\"enorderitementries1\".\"ordermainitemid\" = @qporOrderMainItemid) AND (\"enorderitementries1\".\"ordermainitemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItemid", DbType.Int64, qporOrderMainItemid);
} else {
whereBuilder.Append("(\"enorderitementries1\".\"ordermainitemid\" IS NULL)");
}
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
RL_d8fbadd9d27fdb0e62381fbcaf364158 outParamList = new RL_d8fbadd9d27fdb0e62381fbcaf364158();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPNewEntryChange.GetOrderItemEntriesByItemId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d8fbadd9d27fdb0e62381fbcaf364158 _tmp = new RL_d8fbadd9d27fdb0e62381fbcaf364158();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPNewEntryChange.GetOrderItemEntriesByItemId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d8fbadd9d27fdb0e62381fbcaf364158)_tmp;
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
