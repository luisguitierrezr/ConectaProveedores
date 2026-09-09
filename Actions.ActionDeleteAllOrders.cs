namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteAllOrders : VarsBag {
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoices_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoices_outParamCount = 0L;

public lcvDeleteAllOrders() {
}
}
/// <summary>
/// Action <code>DeleteAllOrders</code> that represents the Service Studio action
///  <code>DeleteAllOrders</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeleteAllOrders(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvDeleteAllOrders localVars = new lcvDeleteAllOrders();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteAllOrders", "99d6bc79-bf8f-44b6-bdcb-80a92e7e5719"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteAllOrders", "99d6bc79-bf8f-44b6-bdcb-80a92e7e5719", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoices
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoices_maxRecords = 0;
int datasetGetInvoices_startIndex = 0;(localVars.queryResGetInvoices_outParamList,localVars.queryResGetInvoices_outParamCount) = await FuncActionDeleteAllOrders.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetInvoices.List
localVars.queryResGetInvoices_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoices_outParamList.Eof))) {
// DeleteInvoice
await ExtendedActions.DeleteInvoice(requestContext,localVars.queryResGetInvoices_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

localVars.queryResGetInvoices_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoices_outParamList.EndIteration();
}

// DeleteAllInvoice
await ExtendedActions.DeleteAllInvoice(requestContext,cancellationToken);

// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

// DeleteAllFolio
await ExtendedActions.DeleteAllFolio(requestContext,cancellationToken);

// DeleteAllOrderMain
await ExtendedActions.DeleteAllOrderMain(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteAllOrders {

// Query Function "GetInvoices" lV4_0ZmBV0Oh+ITVeJPiNA of Action "DeleteAllOrders"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteAllOrders.GetInvoices", "d13f5e95-8199-4357-a1f8-84d57893e234");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteAllOrders.GetInvoices", "d13f5e95-8199-4357-a1f8-84d57893e234", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ebzWmY+_tkS9y4CpLn5XGQ/NodesNotShownInESpaceTree.lV4_0ZmBV0Oh+ITVeJPiNA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice42\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice42\"");
whereBuilder.Append(" WHERE (\"eninvoice42\".\"creditnoteinvoiceid\" IS NOT NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteAllOrders.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteAllOrders.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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
