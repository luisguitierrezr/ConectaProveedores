namespace ssConectaProveedores;

public partial class Actions {
public class lcvClearOtherPossibleApprovers : VarsBag {
public long inParami_FolioApprovalId;
public long inParami_FolioApprovalLevelId;
public int inParami_LevelNumber;
public RL_ecaf6a267327a661b83be973ba99d46b queryResGetFolioApprovalLevelsPossibleApprovers_outParamList = new RL_ecaf6a267327a661b83be973ba99d46b();
public long queryResGetFolioApprovalLevelsPossibleApprovers_outParamCount = 0L;

public lcvClearOtherPossibleApprovers(long inParami_FolioApprovalId, long inParami_FolioApprovalLevelId, int inParami_LevelNumber) {
this.inParami_FolioApprovalId = inParami_FolioApprovalId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.inParami_LevelNumber = inParami_LevelNumber;
}
}
/// <summary>
/// Action <code>ClearOtherPossibleApprovers</code> that represents the Service Studio action
///  <code>ClearOtherPossibleApprovers</code> <p> Description: </p>
/// </summary>
public static async Task ActionClearOtherPossibleApprovers(IRequestContext requestContext,long inParami_FolioApprovalId,long inParami_FolioApprovalLevelId,int inParami_LevelNumber,CancellationToken cancellationToken) {
lcvClearOtherPossibleApprovers localVars = new lcvClearOtherPossibleApprovers(inParami_FolioApprovalId, inParami_FolioApprovalLevelId, inParami_LevelNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ClearOtherPossibleApprovers", "d79e4540-d743-445c-a577-37672407d396"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ClearOtherPossibleApprovers", "d79e4540-d743-445c-a577-37672407d396", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioApprovalLevelsPossibleApprovers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevelsPossibleApprovers_maxRecords = 0;
int datasetGetFolioApprovalLevelsPossibleApprovers_startIndex = 0;(localVars.queryResGetFolioApprovalLevelsPossibleApprovers_outParamList,localVars.queryResGetFolioApprovalLevelsPossibleApprovers_outParamCount) = await FuncActionClearOtherPossibleApprovers.datasetGetFolioApprovalLevelsPossibleApprovers(requestContext,datasetGetFolioApprovalLevelsPossibleApprovers_maxRecords,datasetGetFolioApprovalLevelsPossibleApprovers_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioApprovalId,localVars.inParami_FolioApprovalLevelId,localVars.inParami_LevelNumber,cancellationToken);

// Foreach GetFolioApprovalLevelsPossibleApprovers.List
localVars.queryResGetFolioApprovalLevelsPossibleApprovers_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioApprovalLevelsPossibleApprovers_outParamList.Eof))) {
// FolioApprovalLevelDelete
await Actions.ActionFolioApprovalLevelDelete(requestContext,localVars.queryResGetFolioApprovalLevelsPossibleApprovers_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId,cancellationToken);

localVars.queryResGetFolioApprovalLevelsPossibleApprovers_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioApprovalLevelsPossibleApprovers_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionClearOtherPossibleApprovers {

// Query Function "GetFolioApprovalLevelsPossibleApprovers" tqr1ZOdKZkCthYIqBFkzOA of Action "ClearOtherPossibleApprovers"
public static async Task<(RL_ecaf6a267327a661b83be973ba99d46b,long)> datasetGetFolioApprovalLevelsPossibleApprovers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalId,long qpfoId,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearOtherPossibleApprovers.GetFolioApprovalLevelsPossibleApprovers", "64f5aab6-4ae7-4066-ad85-822a04593338");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearOtherPossibleApprovers.GetFolioApprovalLevelsPossibleApprovers", "64f5aab6-4ae7-4066-ad85-822a04593338", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.QEWe10PXXESldzdnJAfTlg/NodesNotShownInESpaceTree.tqr1ZOdKZkCthYIqBFkzOA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolioapprovallevel28\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {FolioApprovalLevel} \"enfolioapprovallevel28\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApprovalId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel28\".\"folioapprovalid\" = @qpfoFolioApprovalId) AND (\"enfolioapprovallevel28\".\"folioapprovalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalId", DbType.Int64, qpfoFolioApprovalId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel28\".\"folioapprovalid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel28\".\"id\" <> @qpfoId) OR (\"enfolioapprovallevel28\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel28\".\"id\" IS NOT NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel28\".\"levelnumber\" = @qpinLevelNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpinLevelNumber", DbType.Int32, qpinLevelNumber);
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
RL_ecaf6a267327a661b83be973ba99d46b outParamList = new RL_ecaf6a267327a661b83be973ba99d46b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearOtherPossibleApprovers.GetFolioApprovalLevelsPossibleApprovers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ecaf6a267327a661b83be973ba99d46b _tmp = new RL_ecaf6a267327a661b83be973ba99d46b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearOtherPossibleApprovers.GetFolioApprovalLevelsPossibleApprovers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ecaf6a267327a661b83be973ba99d46b)_tmp;
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
