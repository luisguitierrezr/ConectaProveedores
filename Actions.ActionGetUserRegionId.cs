namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserRegionId : VarsBag {
public string inParami_GetUserId;
public RL_216ae81da35dfe5cfaaa600823fb4c79 queryResGetUserExtendedInternalById_outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
public long queryResGetUserExtendedInternalById_outParamCount = 0L;

public lcvGetUserRegionId(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoGetUserRegionId : VarsBag {
public long outParamo_RegionId = 0L;

public lcoGetUserRegionId() {
}
}
/// <summary>
/// Action <code>GetUserRegionId</code> that represents the Service Studio action
///  <code>GetUserRegionId</code> <p> Description: Get logged User Region id</p>
/// </summary>
public static async Task<long> ActionGetUserRegionId(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_RegionId = default;
lcoGetUserRegionId result = new lcoGetUserRegionId();
lcvGetUserRegionId localVars = new lcvGetUserRegionId(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserRegionId", "1361cbfb-8120-4b0d-848b-a7005a0f511b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserRegionId", "1361cbfb-8120-4b0d-848b-a7005a0f511b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalById_maxRecords = 0;
int datasetGetUserExtendedInternalById_startIndex = 0;(localVars.queryResGetUserExtendedInternalById_outParamList,localVars.queryResGetUserExtendedInternalById_outParamCount) = await FuncActionGetUserRegionId.datasetGetUserExtendedInternalById(requestContext,datasetGetUserExtendedInternalById_maxRecords,datasetGetUserExtendedInternalById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParami_GetUserId,cancellationToken);

// o_RegionId = GetUserExtendedInternalById.List.Current.User_Extended_Internal.RegionId
result.outParamo_RegionId=localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssRegionId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_RegionId = result.outParamo_RegionId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_RegionId;
}

public static class FuncActionGetUserRegionId {

// Query Function "GetUserExtendedInternalById" 0bNgDQg1AE6_pC78Zkk9qA of Action "GetUserRegionId"
public static async Task<(RL_216ae81da35dfe5cfaaa600823fb4c79,long)> datasetGetUserExtendedInternalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,string qpusi_GetUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserRegionId.GetUserExtendedInternalById", "0d60b3d1-3508-4e00-bfa4-2efc66493da8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserRegionId.GetUserExtendedInternalById", "0d60b3d1-3508-4e00-bfa4-2efc66493da8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.+8thEyCBDUuEi6cAWg9RGw/NodesNotShownInESpaceTree.0bNgDQg1AE6_pC78Zkk9qA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enuser_extended_internal7\".\"regionid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {User_Extended_Internal} \"enuser_extended_internal7\"");
whereBuilder.Append(" WHERE (\"enuser_extended_internal7\".\"id\" = (CASE WHEN (@qpusi_GetUserId <> '') THEN @qpusi_GetUserId ELSE @qpusGetUserId END))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
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
RL_216ae81da35dfe5cfaaa600823fb4c79 outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserRegionId.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_216ae81da35dfe5cfaaa600823fb4c79 _tmp = new RL_216ae81da35dfe5cfaaa600823fb4c79();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserRegionId.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_216ae81da35dfe5cfaaa600823fb4c79)_tmp;
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
