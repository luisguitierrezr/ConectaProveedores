namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetMR00RegionId : VarsBag {
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegions_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegions_outParamCount = 0L;

public lcvGetMR00RegionId() {
}
}
public class lcoGetMR00RegionId : VarsBag {
public long outParamRegionId = 0L;

public lcoGetMR00RegionId() {
}
}
/// <summary>
/// Action <code>GetMR00RegionId</code> that represents the Service Studio action
///  <code>GetMR00RegionId</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionGetMR00RegionId(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamRegionId = default;
lcoGetMR00RegionId result = new lcoGetMR00RegionId();
lcvGetMR00RegionId localVars = new lcvGetMR00RegionId();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetMR00RegionId", "f5fd812b-4271-4671-979a-d35cd9e1aca0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetMR00RegionId", "f5fd812b-4271-4671-979a-d35cd9e1aca0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRegions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegions_maxRecords = 1;
if (datasetGetRegions_maxRecords < 1) datasetGetRegions_maxRecords = 1;
int datasetGetRegions_startIndex = 0;(localVars.queryResGetRegions_outParamList,localVars.queryResGetRegions_outParamCount) = await FuncActionGetMR00RegionId.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Never,cancellationToken);

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

public static class FuncActionGetMR00RegionId {

// Query Function "GetRegions" JKgwGxViXUWKghLhgVOdiA of Action "GetMR00RegionId"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetMR00RegionId.GetRegions", "1b30a824-6215-455d-8a82-12e181539d88");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetMR00RegionId.GetRegions", "1b30a824-6215-455d-8a82-12e181539d88", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.K4H99XFCcUaXmtNc2eGsoA/NodesNotShownInESpaceTree.JKgwGxViXUWKghLhgVOdiA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion62\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion62\"");
whereBuilder.Append(" WHERE (\"enregion62\".\"divisionfi\" = 'MR00')");
orderByBuilder.Append(" ORDER BY \"enregion62\".\"code\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetMR00RegionId.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetMR00RegionId.GetRegions.List", cancellationToken: cancellationToken);
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
