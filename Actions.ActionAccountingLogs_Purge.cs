namespace ssConectaProveedores;

public partial class Actions {
public class lcvAccountingLogs_Purge : VarsBag {
public RL_cc0d70d0b18881d11cf5321352207bb5 queryResGetLogsAccountings_outParamList = new RL_cc0d70d0b18881d11cf5321352207bb5();
public long queryResGetLogsAccountings_outParamCount = 0L;

public lcvAccountingLogs_Purge() {
}
}
/// <summary>
/// Action <code>AccountingLogs_Purge</code> that represents the Service Studio action
///  <code>AccountingLogs_Purge</code> <p> Description: </p>
/// </summary>
public static async Task ActionAccountingLogs_Purge(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvAccountingLogs_Purge localVars = new lcvAccountingLogs_Purge();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AccountingLogs_Purge", "ecbf379f-ca4d-4307-894a-d97827276f3d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AccountingLogs_Purge", "ecbf379f-ca4d-4307-894a-d97827276f3d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetLogsAccountings
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLogsAccountings_maxRecords = 0;
int datasetGetLogsAccountings_startIndex = 0;(localVars.queryResGetLogsAccountings_outParamList,localVars.queryResGetLogsAccountings_outParamCount) = await FuncActionAccountingLogs_Purge.datasetGetLogsAccountings(requestContext,datasetGetLogsAccountings_maxRecords,datasetGetLogsAccountings_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetLogsAccountings.List
localVars.queryResGetLogsAccountings_outParamList.StartIteration();
try {while (!((localVars.queryResGetLogsAccountings_outParamList.Eof))) {
// DeleteLogsAccounting
await ExtendedActions.DeleteLogsAccounting(requestContext,localVars.queryResGetLogsAccountings_outParamList.CurrentRec.ssENLogsAccounting.ssId,cancellationToken);

localVars.queryResGetLogsAccountings_outParamList.Advance();
}

} finally {
localVars.queryResGetLogsAccountings_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionAccountingLogs_Purge {

// Query Function "GetLogsAccountings" BwbJu29KCUyPxVnHyU4fUw of Action "AccountingLogs_Purge"
public static async Task<(RL_cc0d70d0b18881d11cf5321352207bb5,long)> datasetGetLogsAccountings(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("AccountingLogs_Purge.GetLogsAccountings", "bbc90607-4a6f-4c09-8fc5-59c7c94e1f53");
using var queryActivity = activitySource.CreateAggregateQueryActivity("AccountingLogs_Purge.GetLogsAccountings", "bbc90607-4a6f-4c09-8fc5-59c7c94e1f53", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.nze_7E3KB0OJStl4JydvPQ/NodesNotShownInESpaceTree.BwbJu29KCUyPxVnHyU4fUw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enlogsaccounting\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {LogsAccounting} \"enlogsaccounting\"");
whereBuilder.Append(" WHERE ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enlogsaccounting\".\"createdon\" as date)::timestamptz)) > 15)");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
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
RL_cc0d70d0b18881d11cf5321352207bb5 outParamList = new RL_cc0d70d0b18881d11cf5321352207bb5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query AccountingLogs_Purge.GetLogsAccountings.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cc0d70d0b18881d11cf5321352207bb5 _tmp = new RL_cc0d70d0b18881d11cf5321352207bb5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query AccountingLogs_Purge.GetLogsAccountings.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cc0d70d0b18881d11cf5321352207bb5)_tmp;
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
