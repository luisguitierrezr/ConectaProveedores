namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_OrderUpdateCompare : VarsBag {
public long inParamOrderMainId;
public ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequestNew;
/// <summary>
/// Variable <code>TotalAmount</code> that represents the Service Studio Currency
///  <code>TotalAmount</code> <p>Description: </p>
/// </summary>
public decimal varLcTotalAmount = 0.0M;

/// <summary>
/// Variable <code>RecPositionToCancelFolioEmpty</code> that represents the Service Studio
///  UpdateIsToCancelFoliosPositionRecord <code>RecPositionToCancelFolioEmpty</code> <p>Description
/// : RecPositionToCancelFolioEmpty</p>
/// </summary>
public RC_7906bb6b983a6dbe393ae00113e19275 varLcRecPositionToCancelFolioEmpty = new RC_7906bb6b983a6dbe393ae00113e19275();

/// <summary>
/// Variable <code>RecPositionToCancelFolio</code> that represents the Service Studio
///  UpdateIsToCancelFoliosPositionRecord <code>RecPositionToCancelFolio</code> <p>Description
/// : RecPositionToCancelFolio</p>
/// </summary>
public RC_7906bb6b983a6dbe393ae00113e19275 varLcRecPositionToCancelFolio = new RC_7906bb6b983a6dbe393ae00113e19275();

public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainById_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainById_outParamCount = 0L;

public int resListIndexOf_outParamPosition = 0;

public RL_361bfb1983e170050cb9d371d001b386 queryResGetOrderMainItems_outParamList = new RL_361bfb1983e170050cb9d371d001b386();
public long queryResGetOrderMainItems_outParamCount = 0L;

public lcvOrdersImport_OrderUpdateCompare(long inParamOrderMainId, ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequestNew) {
this.inParamOrderMainId = inParamOrderMainId;
this.inParamOrdersRequestNew = inParamOrdersRequestNew;
}
}
public class lcoOrdersImport_OrderUpdateCompare : VarsBag {
public bool outParamIsReturnToOrderComplement = false;

public RL_0db625824c10f393ed4c09b71230571f outParamListOfPositionsToCancelFolios = new RL_0db625824c10f393ed4c09b71230571f();

public bool outParamIsCancelAllFolios = false;

public string outParamGeneralCancelReason = "";

public lcoOrdersImport_OrderUpdateCompare() {
}
}
/// <summary>
/// Action <code>OrdersImport_OrderUpdateCompare</code> that represents the Service Studio action
///  <code>OrdersImport_OrderUpdateCompare</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,RL_0db625824c10f393ed4c09b71230571f,bool,string)> ActionOrdersImport_OrderUpdateCompare(IRequestContext requestContext,long inParamOrderMainId,ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequestNew,CancellationToken cancellationToken) {
bool outParamIsReturnToOrderComplement = default;
RL_0db625824c10f393ed4c09b71230571f outParamListOfPositionsToCancelFolios = default;
bool outParamIsCancelAllFolios = default;
string outParamGeneralCancelReason = default;
lcoOrdersImport_OrderUpdateCompare result = new lcoOrdersImport_OrderUpdateCompare();
lcvOrdersImport_OrderUpdateCompare localVars = new lcvOrdersImport_OrderUpdateCompare(inParamOrderMainId, inParamOrdersRequestNew);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_OrderUpdateCompare", "3a71e998-132c-4a9d-85bf-36757b1b940e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_OrderUpdateCompare", "3a71e998-132c-4a9d-85bf-36757b1b940e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 1;
if (datasetGetOrderMainById_maxRecords < 1) datasetGetOrderMainById_maxRecords = 1;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncActionOrdersImport_OrderUpdateCompare.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMainId,cancellationToken);

// Query datasetGetOrderMainItems
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItems_maxRecords = 0;
int datasetGetOrderMainItems_startIndex = 0;(localVars.queryResGetOrderMainItems_outParamList,localVars.queryResGetOrderMainItems_outParamCount) = await FuncActionOrdersImport_OrderUpdateCompare.datasetGetOrderMainItems(requestContext,datasetGetOrderMainItems_maxRecords,datasetGetOrderMainItems_startIndex,IterationMultiplicity.Single,localVars.inParamOrderMainId,cancellationToken);

// Foreach GetOrderMainItems.List
localVars.queryResGetOrderMainItems_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderMainItems_outParamList.Eof))) {
// RecPositionToCancelFolio = RecPositionToCancelFolioEmpty
localVars.varLcRecPositionToCancelFolio=localVars.varLcRecPositionToCancelFolioEmpty;
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.inParamOrdersRequestNew.ssOrderItems,async (p, cancellationToken) => (p.ssPosition==localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssPosition),cancellationToken);

// Found?
if(((localVars.resListIndexOf_outParamPosition!=(-1)))) {
// TotalAmount = TotalAmount + If
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+(((localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssChangeIndicator=="L")) ? ((((decimal)0))) : ((localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssQuantity*((decimal)localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssUnitPrice/
(decimal)(((decimal)localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssBaseQuantity)))))));
// AnyRelevantChanges?
if(((((((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity!=localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssQuantity)||(localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssUnitPrice!=localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssUnitPrice))||(localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssIsDeleted!=(localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssChangeIndicator=="L")))||(localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssIsBlocked!=(localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssChangeIndicator=="S")))||(localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssBaseQuantity!=localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssBaseQuantity)))) {
// IsReturnToOrderComplement = True
result.outParamIsReturnToOrderComplement=true;

// RecPositionToCancelFolio.Update = If + If + If + If + If
localVars.varLcRecPositionToCancelFolio.ssUpdate = (((((((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity!=localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssQuantity)) ? ((((((AppUtils.GetStringResource("2wD1jf_EuEaf83isKBvufg#Value.-1220360021.1", "Quantity")+"(")+BuiltInFunction.DecimalToText(localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity))+" -> ")+BuiltInFunction.DecimalToText(localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssQuantity))+"). ")) : (""))+(((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssUnitPrice!=localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssUnitPrice)) ? ((((((AppUtils.GetStringResource("2wD1jf_EuEaf83isKBvufg#Value.-1569503283.1", "Unit price")+"(")+BuiltInFunction.FormatCurrency (localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssUnitPrice, "", 2, ".", ","))+" -> ")+BuiltInFunction.FormatCurrency (localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssUnitPrice, "", 2, ".", ","))+"). ")) : ("")))+(((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssIsDeleted!=(localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssChangeIndicator=="L"))) ? (((((localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssChangeIndicator=="L")) ? (AppUtils.GetStringResource("2wD1jf_EuEaf83isKBvufg#Value.-1079851015.1", "Deleted")) : (AppUtils.GetStringResource("2wD1jf_EuEaf83isKBvufg#Value.1270065833.1", "Available")))+". ")) : ("")))+(((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssIsBlocked!=(localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssChangeIndicator=="S"))) ? (((((localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssChangeIndicator=="S")) ? (AppUtils.GetStringResource("2wD1jf_EuEaf83isKBvufg#Value.1643215308.1", "Blocked")) : (AppUtils.GetStringResource("2wD1jf_EuEaf83isKBvufg#Value.1270065833.2", "Available")))+". ")) : ("")))+(((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssBaseQuantity!=localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssBaseQuantity)) ? ((((((AppUtils.GetStringResource("2wD1jf_EuEaf83isKBvufg#Value.-341971718.1", "Base Quantity")+"(")+Convert.ToString(localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssBaseQuantity))+" -> ")+Convert.ToString(localVars.inParamOrdersRequestNew.ssOrderItems.CurrentRec.ssBaseQuantity))+"). ")) : ("")));

// RecPositionToCancelFolio.Position = OrdersRequestNew.OrderItems[ListIndexOf.Position].Position
localVars.varLcRecPositionToCancelFolio.ssPosition = localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssPosition;

// RecPositionToCancelFolio.IsToCancelFolios = True
localVars.varLcRecPositionToCancelFolio.ssIsToCancelFolios = true;
} else {
// Activate final delivery?
if((((localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssFinalDelivery=="X")&&(!localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssIsFinalDelivery)))) {
// IsReturnToOrderComplement = If
result.outParamIsReturnToOrderComplement=((result.outParamIsReturnToOrderComplement) ? (true) : (false));

// RecPositionToCancelFolio.IsToCancelFolios = True
localVars.varLcRecPositionToCancelFolio.ssIsToCancelFolios = true;

// RecPositionToCancelFolio.Update = "Final delivery activated"
localVars.varLcRecPositionToCancelFolio.ssUpdate = AppUtils.GetStringResource("EPi7gi0JpE2vPp5wADBb1w#Value.-1865845841.1", "Final delivery activated");

// RecPositionToCancelFolio.Position = OrdersRequestNew.OrderItems[ListIndexOf.Position].Position
localVars.varLcRecPositionToCancelFolio.ssPosition = localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssPosition;
} else {
// Deactivate final delivery?
if((((localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssFinalDelivery=="")&&localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssIsFinalDelivery))) {
// IsReturnToOrderComplement = True
result.outParamIsReturnToOrderComplement=true;

// RecPositionToCancelFolio.IsToCancelFolios = True
localVars.varLcRecPositionToCancelFolio.ssIsToCancelFolios = true;

// RecPositionToCancelFolio.Update = "Final delivery deactivated"
localVars.varLcRecPositionToCancelFolio.ssUpdate = AppUtils.GetStringResource("eE6uN+8E3EGZIu_m5CvR1w#Value.1595271374.1", "Final delivery deactivated");

// RecPositionToCancelFolio.Position = OrdersRequestNew.OrderItems[ListIndexOf.Position].Position
localVars.varLcRecPositionToCancelFolio.ssPosition = localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssPosition;
} else {
// IsReturnToOrderComplement = If
result.outParamIsReturnToOrderComplement=((result.outParamIsReturnToOrderComplement) ? (true) : (false));

// RecPositionToCancelFolio.IsToCancelFolios = False
localVars.varLcRecPositionToCancelFolio.ssIsToCancelFolios = false;

// RecPositionToCancelFolio.Position = OrdersRequestNew.OrderItems[ListIndexOf.Position].Position
localVars.varLcRecPositionToCancelFolio.ssPosition = localVars.inParamOrdersRequestNew.ssOrderItems[localVars.resListIndexOf_outParamPosition].ssPosition;
}

}

// ALIGN
}

if((localVars.varLcRecPositionToCancelFolio.ssIsToCancelFolios)) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamListOfPositionsToCancelFolios,localVars.varLcRecPositionToCancelFolio,cancellationToken);

}

} else {
// TotalAmount = TotalAmount + If
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssIsDeleted) ? ((((decimal)0))) : ((localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity*((decimal)localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssUnitPrice/
(decimal)(((decimal)localVars.queryResGetOrderMainItems_outParamList.CurrentRec.ssENOrderMainItem.ssBaseQuantity)))))));
}

localVars.queryResGetOrderMainItems_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderMainItems_outParamList.EndIteration();
}

// Pedido desliberado o monto total cambió?
if((((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssIsReleased!=(localVars.inParamOrdersRequestNew.ssReleased=="S"))||(localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount!=localVars.varLcTotalAmount)))) {
// IsReturnToOrderComplement = True
result.outParamIsReturnToOrderComplement=true;

// IsCancelAllFolios = True
result.outParamIsCancelAllFolios=true;

// GeneralCancelReason = If + If
result.outParamGeneralCancelReason=((((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssIsReleased!=(localVars.inParamOrdersRequestNew.ssReleased=="S"))) ? (((((localVars.inParamOrdersRequestNew.ssReleased=="S")) ? (AppUtils.GetStringResource("FAZarClMHUmx1R5qZ98xKw#Value.-486654627.1", "Released")) : (AppUtils.GetStringResource("FAZarClMHUmx1R5qZ98xKw#Value.-1326572810.1", "Unreleased")))+". ")) : (""))+(((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount!=localVars.varLcTotalAmount)) ? ((AppUtils.GetStringResource("FAZarClMHUmx1R5qZ98xKw#Value.-662427935.1", "Total price changed")+". ")) : ("")));
}

// ControledLogMessage5
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrdersImport_OrderUpdateCompare » "+((((result.outParamIsReturnToOrderComplement||result.outParamIsCancelAllFolios)||(!result.outParamListOfPositionsToCancelFolios.Empty))) ? ("There are relevant changes.") : ("No relevant changes."))),"OrdersImport_OrderUpdateCompare",cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamIsReturnToOrderComplement = result.outParamIsReturnToOrderComplement;
outParamListOfPositionsToCancelFolios = result.outParamListOfPositionsToCancelFolios;
outParamIsCancelAllFolios = result.outParamIsCancelAllFolios;
outParamGeneralCancelReason = result.outParamGeneralCancelReason;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsReturnToOrderComplement,outParamListOfPositionsToCancelFolios,outParamIsCancelAllFolios,outParamGeneralCancelReason);
}

public static class FuncActionOrdersImport_OrderUpdateCompare {

// Query Function "GetOrderMainById" 26uhbJl9B0WUmGsLE187gA of Action "OrdersImport_OrderUpdateCompare"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersImport_OrderUpdateCompare.GetOrderMainById", "6ca1abdb-7d99-4507-9498-6b0b135f3b80");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersImport_OrderUpdateCompare.GetOrderMainById", "6ca1abdb-7d99-4507-9498-6b0b135f3b80", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mOlxOiwTnUqFvzZ1exuUDg/NodesNotShownInESpaceTree.26uhbJl9B0WUmGsLE187gA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enordermain17\".\"isreleased\" o16, NULL o17, NULL o18, NULL o19, trim_scale(\"enordermain17\".\"totalamount\"::numeric) o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain17\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain17\".\"id\" = @qporId) AND (\"enordermain17\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain17\".\"id\" IS NULL)");
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_OrderUpdateCompare.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_OrderUpdateCompare.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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

// Query Function "GetOrderMainItems" 784q6vkbH0eT5pWN_FuU5A of Action "OrdersImport_OrderUpdateCompare"
public static async Task<(RL_361bfb1983e170050cb9d371d001b386,long)> datasetGetOrderMainItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersImport_OrderUpdateCompare.GetOrderMainItems", "ea2aceef-1bf9-471f-93e6-958dfc5b94e4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersImport_OrderUpdateCompare.GetOrderMainItems", "ea2aceef-1bf9-471f-93e6-958dfc5b94e4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mOlxOiwTnUqFvzZ1exuUDg/NodesNotShownInESpaceTree.784q6vkbH0eT5pWN_FuU5A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enordermainitem3\".\"position\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, trim_scale(\"enordermainitem3\".\"quantity\"::numeric) o8, NULL o9, trim_scale(\"enordermainitem3\".\"unitprice\"::numeric) o10, \"enordermainitem3\".\"basequantity\" o11, \"enordermainitem3\".\"isdeleted\" o12, \"enordermainitem3\".\"isblocked\" o13, \"enordermainitem3\".\"isfinaldelivery\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem3\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem3\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem3\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem3\".\"ordermainid\" IS NULL)");
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
RL_361bfb1983e170050cb9d371d001b386 outParamList = new RL_361bfb1983e170050cb9d371d001b386();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, false, true, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_OrderUpdateCompare.GetOrderMainItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_361bfb1983e170050cb9d371d001b386 _tmp = new RL_361bfb1983e170050cb9d371d001b386();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_OrderUpdateCompare.GetOrderMainItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_361bfb1983e170050cb9d371d001b386)_tmp;
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
