namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeletelogsFromProposalId : VarsBag {
public long inParamProposalId;
public RLAIItemRecordList queryResSQL1_outParamList = new RLAIItemRecordList();
public long queryResSQL1_outParamCount = 0L;

public lcvDeletelogsFromProposalId(long inParamProposalId) {
this.inParamProposalId = inParamProposalId;
}
}
/// <summary>
/// Action <code>DeletelogsFromProposalId</code> that represents the Service Studio action
///  <code>DeletelogsFromProposalId</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeletelogsFromProposalId(IRequestContext requestContext,long inParamProposalId,CancellationToken cancellationToken) {
lcvDeletelogsFromProposalId localVars = new lcvDeletelogsFromProposalId(inParamProposalId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeletelogsFromProposalId", "e2e297c5-004d-4715-8212-893aaf8931e3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeletelogsFromProposalId", "e2e297c5-004d-4715-8212-893aaf8931e3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query QuerySQL1
cancellationToken.ThrowIfCancellationRequested();
int QuerySQL1_maxRecords = 0;
int QuerySQL1_startIndex = 0;(localVars.queryResSQL1_outParamList,localVars.queryResSQL1_outParamCount) = await FuncActionDeletelogsFromProposalId.QuerySQL1(requestContext,QuerySQL1_maxRecords,QuerySQL1_startIndex,IterationMultiplicity.Never,localVars.inParamProposalId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeletelogsFromProposalId {

// Query Function "SQL1" e5rLU9EXIUKGJloyzB3jQQ of Action "DeletelogsFromProposalId"
public static async Task<(RLAIItemRecordList,long)> QuerySQL1(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("DeletelogsFromProposalId.SQL1", "53cb9a7b-17d1-4221-8626-5a32cc1de341");
using var queryActivity = activitySource.CreateSqlQueryActivity("DeletelogsFromProposalId.SQL1", "53cb9a7b-17d1-4221-8626-5a32cc1de341", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposalLogs = AppUtils.Instance.RuntimeEntityReplace("ProposalLogs");
sqlCmd.CreateParameter("@qpprProposalId", DbType.Int64, qpprProposalId);
string sql = "";
string advSql = "delete from  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLogs,"") + " where  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLogs,".\"proposalid\"") + " = @qpprProposalId";
string[] entitiesToCheck = new[] {"ProposalLogs"};
AppUtils.Instance.RuntimeCheckReadOnlyEntity(entitiesToCheck);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RLAIItemRecordList outParamList = new RLAIItemRecordList();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeletelogsFromProposalId.SQL1.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RLAIItemRecordList _tmp = new RLAIItemRecordList();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeletelogsFromProposalId.SQL1.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RLAIItemRecordList)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("SQL1 in DeletelogsFromProposalId in ConectaProveedores (delete from {ProposalLogs} where {ProposalLogs}.[ProposalId] = @ProposalId): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SQL1 in DeletelogsFromProposalId in ConectaProveedores (delete from {ProposalLogs} where {ProposalLogs}.[ProposalId] = @ProposalId): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SQL1 in DeletelogsFromProposalId in ConectaProveedores (delete from {ProposalLogs} where {ProposalLogs}.[ProposalId] = @ProposalId): " + aqExcep.Message));
}
}
}



}


}
