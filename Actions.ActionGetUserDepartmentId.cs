namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserDepartmentId : VarsBag {
public string inParami_GetUserId;
public RL_e209cbb546a647ab2dbb42567bb25d19 queryResGetUserExtendedInternalById_outParamList = new RL_e209cbb546a647ab2dbb42567bb25d19();
public long queryResGetUserExtendedInternalById_outParamCount = 0L;

public lcvGetUserDepartmentId(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoGetUserDepartmentId : VarsBag {
public long outParamo_DepartmentId = 0L;

public lcoGetUserDepartmentId() {
}
}
/// <summary>
/// Action <code>GetUserDepartmentId</code> that represents the Service Studio action
///  <code>GetUserDepartmentId</code> <p> Description: Get logged User Department id</p>
/// </summary>
public static async Task<long> ActionGetUserDepartmentId(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_DepartmentId = default;
lcoGetUserDepartmentId result = new lcoGetUserDepartmentId();
lcvGetUserDepartmentId localVars = new lcvGetUserDepartmentId(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserDepartmentId", "5ded1e32-2cf8-425c-9425-1b19e3fbb790"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserDepartmentId", "5ded1e32-2cf8-425c-9425-1b19e3fbb790", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalById_maxRecords = 0;
int datasetGetUserExtendedInternalById_startIndex = 0;(localVars.queryResGetUserExtendedInternalById_outParamList,localVars.queryResGetUserExtendedInternalById_outParamCount) = await FuncActionGetUserDepartmentId.datasetGetUserExtendedInternalById(requestContext,datasetGetUserExtendedInternalById_maxRecords,datasetGetUserExtendedInternalById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParami_GetUserId,cancellationToken);

// o_DepartmentId = GetUserExtendedInternalById.List.Current.Department.Id
result.outParamo_DepartmentId=localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENDepartment.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_DepartmentId = result.outParamo_DepartmentId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_DepartmentId;
}

public static class FuncActionGetUserDepartmentId {

private static async Task<RC_b29687471c7561fc031c1c100f2316ce> datasetGetUserExtendedInternalByIdReadDbAsync(RC_b29687471c7561fc031c1c100f2316ce rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDepartment.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalById" w_rgAxd2gU+WGC8eASYGYQ of Action "GetUserDepartmentId"
public static async Task<(RL_e209cbb546a647ab2dbb42567bb25d19,long)> datasetGetUserExtendedInternalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,string qpusi_GetUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserDepartmentId.GetUserExtendedInternalById", "03e0fac3-7617-4f81-9618-2f1e01260661");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserDepartmentId.GetUserExtendedInternalById", "03e0fac3-7617-4f81-9618-2f1e01260661", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mh7tXfgsXEKUJRsZ4_u3kA/NodesNotShownInESpaceTree.w_rgAxd2gU+WGC8eASYGYQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endepartment3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal36\" Inner JOIN {Department} \"endepartment3\" ON (\"enuser_extended_internal36\".\"departmentid\" = \"endepartment3\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal36\".\"id\" = (CASE WHEN (@qpusi_GetUserId <> '') THEN @qpusi_GetUserId ELSE @qpusGetUserId END))");
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
RL_e209cbb546a647ab2dbb42567bb25d19 outParamList = new RL_e209cbb546a647ab2dbb42567bb25d19();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserDepartmentId.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e209cbb546a647ab2dbb42567bb25d19 _tmp = new RL_e209cbb546a647ab2dbb42567bb25d19();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserDepartmentId.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e209cbb546a647ab2dbb42567bb25d19)_tmp;
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
