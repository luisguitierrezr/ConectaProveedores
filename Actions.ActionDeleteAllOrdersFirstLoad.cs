namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteAllOrdersFirstLoad : VarsBag {
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMains_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMains_outParamCount = 0L;

public lcvDeleteAllOrdersFirstLoad() {
}
}
/// <summary>
/// Action <code>DeleteAllOrdersFirstLoad</code> that represents the Service Studio action
///  <code>DeleteAllOrdersFirstLoad</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeleteAllOrdersFirstLoad(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvDeleteAllOrdersFirstLoad localVars = new lcvDeleteAllOrdersFirstLoad();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteAllOrdersFirstLoad", "6cf9061c-43c0-4a92-a5bc-908ee2f95a4d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteAllOrdersFirstLoad", "6cf9061c-43c0-4a92-a5bc-908ee2f95a4d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderMains
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMains_maxRecords = 0;
int datasetGetOrderMains_startIndex = 0;(localVars.queryResGetOrderMains_outParamList,localVars.queryResGetOrderMains_outParamCount) = await FuncActionDeleteAllOrdersFirstLoad.datasetGetOrderMains(requestContext,datasetGetOrderMains_maxRecords,datasetGetOrderMains_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetOrderMains.List
localVars.queryResGetOrderMains_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderMains_outParamList.Eof))) {
// DeleteOrderMain
await ExtendedActions.DeleteOrderMain(requestContext,localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

localVars.queryResGetOrderMains_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderMains_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteAllOrdersFirstLoad {

// Query Function "GetOrderMains" pLOXUx9aDEGvu2rnr6Pd6g of Action "DeleteAllOrdersFirstLoad"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMains(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteAllOrdersFirstLoad.GetOrderMains", "5397b3a4-5a1f-410c-afbb-6ae7afa3ddea");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteAllOrdersFirstLoad.GetOrderMains", "5397b3a4-5a1f-410c-afbb-6ae7afa3ddea", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.HAb5bMBDkkqlvJCO4vlaTQ/NodesNotShownInESpaceTree.pLOXUx9aDEGvu2rnr6Pd6g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain32\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain32\"");
whereBuilder.Append(" WHERE (\"enordermain32\".\"fromcosmoz\" = 1)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteAllOrdersFirstLoad.GetOrderMains.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteAllOrdersFirstLoad.GetOrderMains.List", cancellationToken: cancellationToken);
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



}


}
