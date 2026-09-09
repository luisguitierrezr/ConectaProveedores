namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetAlmacenCodeByRegionId : VarsBag {
public long inParamRegionId;
public RL_f6ff3859377cc9c3ed97710b330e3b95 queryResGetVirtualStoreByRegionId_outParamList = new RL_f6ff3859377cc9c3ed97710b330e3b95();
public long queryResGetVirtualStoreByRegionId_outParamCount = 0L;

public lcvGetAlmacenCodeByRegionId(long inParamRegionId) {
this.inParamRegionId = inParamRegionId;
}
}
public class lcoGetAlmacenCodeByRegionId : VarsBag {
public string outParamStoreCode = "";

public lcoGetAlmacenCodeByRegionId() {
}
}
/// <summary>
/// Action <code>GetAlmacenCodeByRegionId</code> that represents the Service Studio action
///  <code>GetAlmacenCodeByRegionId</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetAlmacenCodeByRegionId(IRequestContext requestContext,long inParamRegionId,CancellationToken cancellationToken) {
string outParamStoreCode = default;
lcoGetAlmacenCodeByRegionId result = new lcoGetAlmacenCodeByRegionId();
lcvGetAlmacenCodeByRegionId localVars = new lcvGetAlmacenCodeByRegionId(inParamRegionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetAlmacenCodeByRegionId", "5478a59e-0f31-4b9f-ba20-3bdc0d33efd5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetAlmacenCodeByRegionId", "5478a59e-0f31-4b9f-ba20-3bdc0d33efd5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetVirtualStoreByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetVirtualStoreByRegionId_maxRecords = 0;
int datasetGetVirtualStoreByRegionId_startIndex = 0;(localVars.queryResGetVirtualStoreByRegionId_outParamList,localVars.queryResGetVirtualStoreByRegionId_outParamCount) = await FuncActionGetAlmacenCodeByRegionId.datasetGetVirtualStoreByRegionId(requestContext,datasetGetVirtualStoreByRegionId_maxRecords,datasetGetVirtualStoreByRegionId_startIndex,IterationMultiplicity.Never,localVars.inParamRegionId,cancellationToken);

// StoreCode = GetVirtualStoreByRegionId.List.Current.VirtualStore.Name
result.outParamStoreCode=localVars.queryResGetVirtualStoreByRegionId_outParamList.CurrentRec.ssENVirtualStore.ssName;
} //close CreateActionActivity using block
} // try

finally {
outParamStoreCode = result.outParamStoreCode;
} // inner-finally
RETURN_STATEMENT:
return outParamStoreCode;
}

public static class FuncActionGetAlmacenCodeByRegionId {

// Query Function "GetVirtualStoreByRegionId" NI54m4WR00ax8oZr1XYLRw of Action "GetAlmacenCodeByRegionId"
public static async Task<(RL_f6ff3859377cc9c3ed97710b330e3b95,long)> datasetGetVirtualStoreByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetAlmacenCodeByRegionId.GetVirtualStoreByRegionId", "9b788e34-9185-46d3-b1f2-866bd5760b47");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetAlmacenCodeByRegionId.GetVirtualStoreByRegionId", "9b788e34-9185-46d3-b1f2-866bd5760b47", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.nqV4VDEPn0u6IDvcDTPv1Q/NodesNotShownInESpaceTree.NI54m4WR00ax8oZr1XYLRw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"envirtualstore\".\"name\" o1, NULL o2");
fromBuilder.Append(" FROM {VirtualStore} \"envirtualstore\"");
whereBuilder.Append(" WHERE ");
if (qpreRegionId != 0) {
whereBuilder.Append("((\"envirtualstore\".\"regionid\" = @qpreRegionId) AND (\"envirtualstore\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"envirtualstore\".\"regionid\" IS NULL)");
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
RL_f6ff3859377cc9c3ed97710b330e3b95 outParamList = new RL_f6ff3859377cc9c3ed97710b330e3b95();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetAlmacenCodeByRegionId.GetVirtualStoreByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f6ff3859377cc9c3ed97710b330e3b95 _tmp = new RL_f6ff3859377cc9c3ed97710b330e3b95();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetAlmacenCodeByRegionId.GetVirtualStoreByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f6ff3859377cc9c3ed97710b330e3b95)_tmp;
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
