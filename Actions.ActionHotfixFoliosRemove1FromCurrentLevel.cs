namespace ssConectaProveedores;

public partial class Actions {
public class lcvHotfixFoliosRemove1FromCurrentLevel : VarsBag {
public RL_f2334acea7cfd80330b429c488fa4f97 queryResGetFolios_outParamList = new RL_f2334acea7cfd80330b429c488fa4f97();
public long queryResGetFolios_outParamCount = 0L;

public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public lcvHotfixFoliosRemove1FromCurrentLevel() {
}
}
/// <summary>
/// Action <code>HotfixFoliosRemove1FromCurrentLevel</code> that represents the Service Studio action
///  <code>HotfixFoliosRemove1FromCurrentLevel</code> <p> Description: </p>
/// </summary>
public static async Task ActionHotfixFoliosRemove1FromCurrentLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvHotfixFoliosRemove1FromCurrentLevel localVars = new lcvHotfixFoliosRemove1FromCurrentLevel();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("HotfixFoliosRemove1FromCurrentLevel", "c95fbcea-e75d-4d40-98b3-9c0068b43d2f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("HotfixFoliosRemove1FromCurrentLevel", "c95fbcea-e75d-4d40-98b3-9c0068b43d2f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolios
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolios_maxRecords = 0;
int datasetGetFolios_startIndex = 0;(localVars.queryResGetFolios_outParamList,localVars.queryResGetFolios_outParamCount) = await FuncActionHotfixFoliosRemove1FromCurrentLevel.datasetGetFolios(requestContext,datasetGetFolios_maxRecords,datasetGetFolios_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetFolios.List
localVars.queryResGetFolios_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolios_outParamList.Eof))) {
// GetFolios.List.Current.FolioApproval.CurrentLevel = GetFolios.List.Current.FolioApproval.CurrentLevel - 1
localVars.queryResGetFolios_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel = (localVars.queryResGetFolios_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel-1);
// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.queryResGetFolios_outParamList.CurrentRec.ssENFolioApproval,cancellationToken);

localVars.queryResGetFolios_outParamList.Advance();
}

} finally {
localVars.queryResGetFolios_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionHotfixFoliosRemove1FromCurrentLevel {

private static async Task<RC_d62ad7391a87381616a77aeae304e183> datasetGetFoliosReadDbAsync(RC_d62ad7391a87381616a77aeae304e183 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
return rec;
}
// Query Function "GetFolios" NSbnhv46lkCGA6EgDp4UXA of Action "HotfixFoliosRemove1FromCurrentLevel"
public static async Task<(RL_f2334acea7cfd80330b429c488fa4f97,long)> datasetGetFolios(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixFoliosRemove1FromCurrentLevel.GetFolios", "86e72635-3afe-4096-8603-a1200e9e145c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixFoliosRemove1FromCurrentLevel.GetFolios", "86e72635-3afe-4096-8603-a1200e9e145c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.6rxfyV3nQE2Ys5wAaLQ9Lw/NodesNotShownInESpaceTree.NSbnhv46lkCGA6EgDp4UXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enfolioapproval27\".\"id\" o20, \"enfolioapproval27\".\"folioid\" o21, \"enfolioapproval27\".\"approvalprocessid\" o22, \"enfolioapproval27\".\"processtypecode\" o23, \"enfolioapproval27\".\"approvalprocessversion\" o24, \"enfolioapproval27\".\"currentlevel\" o25, \"enfolioapproval27\".\"maxlevel\" o26, \"enfolioapproval27\".\"startedon\" o27, \"enfolioapproval27\".\"finishedon\" o28, \"enfolioapproval27\".\"regionid\" o29");
fromBuilder.Append(" FROM ({Folio} \"enfolio49\" Inner JOIN {FolioApproval} \"enfolioapproval27\" ON (\"enfolio49\".\"id\" = \"enfolioapproval27\".\"folioid\")) ");
whereBuilder.Append(" WHERE (\"enfolio49\".\"approvalprocesstypeid\" = ");
whereBuilder.Append(4
);
whereBuilder.Append(")");
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
RL_f2334acea7cfd80330b429c488fa4f97 outParamList = new RL_f2334acea7cfd80330b429c488fa4f97();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixFoliosRemove1FromCurrentLevel.GetFolios.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f2334acea7cfd80330b429c488fa4f97 _tmp = new RL_f2334acea7cfd80330b429c488fa4f97();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixFoliosRemove1FromCurrentLevel.GetFolios.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f2334acea7cfd80330b429c488fa4f97)_tmp;
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
