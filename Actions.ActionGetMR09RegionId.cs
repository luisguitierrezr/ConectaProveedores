namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetMR09RegionId : VarsBag {
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegions_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegions_outParamCount = 0L;

public lcvGetMR09RegionId() {
}
}
public class lcoGetMR09RegionId : VarsBag {
public long outParamRegionId = 0L;

public lcoGetMR09RegionId() {
}
}
/// <summary>
/// Action <code>GetMR09RegionId</code> that represents the Service Studio action
///  <code>GetMR09RegionId</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionGetMR09RegionId(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamRegionId = default;
lcoGetMR09RegionId result = new lcoGetMR09RegionId();
lcvGetMR09RegionId localVars = new lcvGetMR09RegionId();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetMR09RegionId", "e7a649ee-4a17-4b1c-a9d0-17d74cd2465d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetMR09RegionId", "e7a649ee-4a17-4b1c-a9d0-17d74cd2465d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRegions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegions_maxRecords = 0;
int datasetGetRegions_startIndex = 0;(localVars.queryResGetRegions_outParamList,localVars.queryResGetRegions_outParamCount) = await FuncActionGetMR09RegionId.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Never,cancellationToken);

// RegionId = GetRegions.List.Current.Region.Id
result.outParamRegionId=localVars.queryResGetRegions_outParamList.CurrentRec.ssENRegion.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamRegionId = result.outParamRegionId;
} // inner-finally
RETURN_STATEMENT:
return outParamRegionId;
}

public static class FuncActionGetMR09RegionId {

// Query Function "GetRegions" cF2x5ySgO0avRvdgw3OFTA of Action "GetMR09RegionId"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetMR09RegionId.GetRegions", "e7b15d70-a024-463b-af46-f760c373854c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetMR09RegionId.GetRegions", "e7b15d70-a024-463b-af46-f760c373854c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7kmm5xdKHEup0BfXTNJGXQ/NodesNotShownInESpaceTree.cF2x5ySgO0avRvdgw3OFTA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion58\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion58\"");
whereBuilder.Append(" WHERE (\"enregion58\".\"divisionfi\" = 'MR09')");
orderByBuilder.Append(" ORDER BY \"enregion58\".\"code\" ASC ");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetMR09RegionId.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetMR09RegionId.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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
