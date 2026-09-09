namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrder_SAPNewEntry : VarsBag {
public ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest;
public bool inParamIsCancel;
public long inParamOrderMainId;
/// <summary>
/// Variable <code>IsRejectFolio</code> that represents the Service Studio Boolean
///  <code>IsRejectFolio</code> <p>Description: </p>
/// </summary>
public bool varLcIsRejectFolio = false;

public RL_361bfb1983e170050cb9d371d001b386 queryResGetOrderItemsByOrderId_outParamList = new RL_361bfb1983e170050cb9d371d001b386();
public long queryResGetOrderItemsByOrderId_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoOrder_SAPNewEntryChange resOrder_SAPNewEntryChange =  new Actions.lcoOrder_SAPNewEntryChange();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public lcvOrder_SAPNewEntry(ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest, bool inParamIsCancel, long inParamOrderMainId) {
this.inParamRequest = inParamRequest;
this.inParamIsCancel = inParamIsCancel;
this.inParamOrderMainId = inParamOrderMainId;
}
}
public class lcoOrder_SAPNewEntry : VarsBag {
public string outParamMsg = "";

public lcoOrder_SAPNewEntry() {
}
}
/// <summary>
/// Action <code>Order_SAPNewEntry</code> that represents the Service Studio action
///  <code>Order_SAPNewEntry</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionOrder_SAPNewEntry(IRequestContext requestContext,ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest,bool inParamIsCancel,long inParamOrderMainId,CancellationToken cancellationToken) {
string outParamMsg = default;
lcoOrder_SAPNewEntry result = new lcoOrder_SAPNewEntry();
lcvOrder_SAPNewEntry localVars = new lcvOrder_SAPNewEntry(inParamRequest, inParamIsCancel, inParamOrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Order_SAPNewEntry", "1b275dd4-7bdc-44d7-8c4b-57f4a8fb68f7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Order_SAPNewEntry", "1b275dd4-7bdc-44d7-8c4b-57f4a8fb68f7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderItemsByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderItemsByOrderId_maxRecords = 0;
int datasetGetOrderItemsByOrderId_startIndex = 0;(localVars.queryResGetOrderItemsByOrderId_outParamList,localVars.queryResGetOrderItemsByOrderId_outParamCount) = await FuncActionOrder_SAPNewEntry.datasetGetOrderItemsByOrderId(requestContext,datasetGetOrderItemsByOrderId_maxRecords,datasetGetOrderItemsByOrderId_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrderMainId,cancellationToken);

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "API Update Rows - Antes", ssDescription = ((((((("OrderItems: "+Convert.ToString(localVars.queryResGetOrderItemsByOrderId_outParamList.Length))+" // 1st Pos: ")+Convert.ToString(localVars.queryResGetOrderItemsByOrderId_outParamList.CurrentRec.ssENOrderMainItem.ssPosition))+" // Rows: ")+Convert.ToString(localVars.inParamRequest.ssRows.Length))+" // 1st Row: ")+BuiltInFunction.LongIntegerToText(localVars.inParamRequest.ssRows.CurrentRec.ssRowNumber)), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

// Foreach Request.Rows
localVars.inParamRequest.ssRows.StartIteration();
try {while (!((localVars.inParamRequest.ssRows.Eof))) {
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "API Update Rows", ssDescription = (((("for Row "+Convert.ToString(localVars.inParamRequest.ssRows.CurrentRowNumber))+Convert.ToString(1))+": Pos ")+BuiltInFunction.LongIntegerToText(localVars.inParamRequest.ssRows.CurrentRec.ssRowNumber)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

// Order_SAPNewEntryChange
(localVars.resOrder_SAPNewEntryChange.outParamIsSuccess,localVars.resOrder_SAPNewEntryChange.outParamo_IsRejectFolio) = await Actions.ActionOrder_SAPNewEntryChange(requestContext,localVars.inParamRequest.ssRows.CurrentRec,localVars.inParamIsCancel,localVars.inParamOrderMainId,(await RL_36053b0a011ac5d2d2fe088489de85e6.ConvertAsync(localVars.queryResGetOrderItemsByOrderId_outParamList, new RL_36053b0a011ac5d2d2fe088489de85e6(), async (RC_c4cc207f9017de4e013fabcf1e8ebeaf source, EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),localVars.inParamRequest.ssEntryNumber,localVars.inParamRequest.ssEntryNumberEM,localVars.inParamRequest.ssEntryYearEM,localVars.inParamRequest.ssUUID,localVars.varLcIsRejectFolio,cancellationToken);

// Msg = If
result.outParamMsg=((localVars.resOrder_SAPNewEntryChange.outParamIsSuccess) ? (((result.outParamMsg+(((result.outParamMsg=="")) ? ("") : (", ")))+BuiltInFunction.LongIntegerToText(localVars.inParamRequest.ssRows.CurrentRec.ssRowNumber))) : (result.outParamMsg));

// IsRejectFolio = Order_SAPNewEntryChange.o_IsRejectFolio
localVars.varLcIsRejectFolio=localVars.resOrder_SAPNewEntryChange.outParamo_IsRejectFolio;
localVars.inParamRequest.ssRows.Advance();
}

} finally {
localVars.inParamRequest.ssRows.EndIteration();
}

// Msg = If
result.outParamMsg=(((result.outParamMsg=="")) ? (AppUtils.GetStringResource("xPwixSgEpU2_0Bb8VzTSNQ#Value.1332024438.1", "No changes were made.")) : (((AppUtils.GetStringResource("xPwixSgEpU2_0Bb8VzTSNQ#Value.-920462058.1", "Positions ")+result.outParamMsg)+AppUtils.GetStringResource("xPwixSgEpU2_0Bb8VzTSNQ#Value.-571550694.1", " changed."))));
} //close CreateActionActivity using block
} // try

finally {
outParamMsg = result.outParamMsg;
} // inner-finally
RETURN_STATEMENT:
return outParamMsg;
}

public static class FuncActionOrder_SAPNewEntry {

// Query Function "GetOrderItemsByOrderId" suLmEQiUlUKRyEe6XBL0hA of Action "Order_SAPNewEntry"
public static async Task<(RL_361bfb1983e170050cb9d371d001b386,long)> datasetGetOrderItemsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPNewEntry.GetOrderItemsByOrderId", "11e6e2b2-9408-4295-91c8-47ba5c12f484");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPNewEntry.GetOrderItemsByOrderId", "11e6e2b2-9408-4295-91c8-47ba5c12f484", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.1F0nG9x710SMS1f0qPto9w/NodesNotShownInESpaceTree.suLmEQiUlUKRyEe6XBL0hA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermainitem1\".\"id\" o0, \"enordermainitem1\".\"ordermainid\" o1, \"enordermainitem1\".\"position\" o2, \"enordermainitem1\".\"materialcode\" o3, \"enordermainitem1\".\"materialdescription\" o4, \"enordermainitem1\".\"assigmnentcode\" o5, \"enordermainitem1\".\"documentclassid\" o6, \"enordermainitem1\".\"deliverydate\" o7, trim_scale(\"enordermainitem1\".\"quantity\"::numeric) o8, \"enordermainitem1\".\"unittype\" o9, trim_scale(\"enordermainitem1\".\"unitprice\"::numeric) o10, \"enordermainitem1\".\"basequantity\" o11, \"enordermainitem1\".\"isdeleted\" o12, \"enordermainitem1\".\"isblocked\" o13, \"enordermainitem1\".\"isfinaldelivery\" o14, \"enordermainitem1\".\"glaccountid\" o15, \"enordermainitem1\".\"costcenterid\" o16, \"enordermainitem1\".\"fundscenter\" o17, \"enordermainitem1\".\"fund\" o18, \"enordermainitem1\".\"commitmentitem\" o19, \"enordermainitem1\".\"vatindicator\" o20, \"enordermainitem1\".\"vatprocedure\" o21, trim_scale(\"enordermainitem1\".\"vatrate\"::numeric) o22, \"enordermainitem1\".\"purchaserequisitionnumber\" o23, \"enordermainitem1\".\"purchaserequisitionitemnr\" o24, \"enordermainitem1\".\"regionid\" o25, \"enordermainitem1\".\"center\" o26, \"enordermainitem1\".\"pepelement\" o27, trim_scale(\"enordermainitem1\".\"quantitydelivered\"::numeric) o28, \"enordermainitem1\".\"orderunitofmeasure\" o29, \"enordermainitem1\".\"applicant\" o30, \"enordermainitem1\".\"direction\" o31, \"enordermainitem1\".\"contractnumber\" o32, \"enordermainitem1\".\"contractposition\" o33, \"enordermainitem1\".\"contractstartdate\" o34, \"enordermainitem1\".\"contractenddate\" o35, trim_scale(\"enordermainitem1\".\"contractplannedvalue\"::numeric) o36, \"enordermainitem1\".\"positiontype\" o37, \"enordermainitem1\".\"serialnumberprofile\" o38, \"enordermainitem1\".\"batchmanaged\" o39, \"enordermainitem1\".\"materialtype\" o40, \"enordermainitem1\".\"itemgroup\" o41, \"enordermainitem1\".\"orderrequestcreatorsapnumber\" o42, \"enordermainitem1\".\"ismultipleimputation\" o43, \"enordermainitem1\".\"invoiceusageid\" o44, \"enordermainitem1\".\"ordermainitemstatusid\" o45, \"enordermainitem1\".\"divisionid\" o46, \"enordermainitem1\".\"createdby\" o47, \"enordermainitem1\".\"createdon\" o48, \"enordermainitem1\".\"updatedby\" o49, \"enordermainitem1\".\"updatedon\" o50");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem1\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem1\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem1\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem1\".\"ordermainid\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPNewEntry.GetOrderItemsByOrderId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPNewEntry.GetOrderItemsByOrderId.List", cancellationToken: cancellationToken);
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
