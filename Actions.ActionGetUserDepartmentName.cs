namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserDepartmentName : VarsBag {
public string inParami_GetUserId;
public RL_e209cbb546a647ab2dbb42567bb25d19 queryResGetUserExtendedInternalById_outParamList = new RL_e209cbb546a647ab2dbb42567bb25d19();
public long queryResGetUserExtendedInternalById_outParamCount = 0L;

public lcvGetUserDepartmentName(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoGetUserDepartmentName : VarsBag {
public string outParamo_Department = "";

public lcoGetUserDepartmentName() {
}
}
/// <summary>
/// Action <code>GetUserDepartmentName</code> that represents the Service Studio action
///  <code>GetUserDepartmentName</code> <p> Description: Get logged User Department name</p>
/// </summary>
public static async Task<string> ActionGetUserDepartmentName(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
string outParamo_Department = default;
lcoGetUserDepartmentName result = new lcoGetUserDepartmentName();
lcvGetUserDepartmentName localVars = new lcvGetUserDepartmentName(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserDepartmentName", "1afbb6a9-b517-4c83-a05c-5fcc184d42d4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserDepartmentName", "1afbb6a9-b517-4c83-a05c-5fcc184d42d4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalById_maxRecords = 0;
int datasetGetUserExtendedInternalById_startIndex = 0;(localVars.queryResGetUserExtendedInternalById_outParamList,localVars.queryResGetUserExtendedInternalById_outParamCount) = await FuncActionGetUserDepartmentName.datasetGetUserExtendedInternalById(requestContext,datasetGetUserExtendedInternalById_maxRecords,datasetGetUserExtendedInternalById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParami_GetUserId,cancellationToken);

// o_Department = GetUserExtendedInternalById.List.Current.Department.Name
result.outParamo_Department=localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENDepartment.ssName;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Department = result.outParamo_Department;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Department;
}

public static class FuncActionGetUserDepartmentName {

private static async Task<RC_b29687471c7561fc031c1c100f2316ce> datasetGetUserExtendedInternalByIdReadDbAsync(RC_b29687471c7561fc031c1c100f2316ce rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDepartment.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalById" VgggFEEQmkylLiBCEN56Hw of Action "GetUserDepartmentName"
public static async Task<(RL_e209cbb546a647ab2dbb42567bb25d19,long)> datasetGetUserExtendedInternalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,string qpusi_GetUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserDepartmentName.GetUserExtendedInternalById", "14200856-1041-4c9a-a52e-204210de7a1f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserDepartmentName.GetUserExtendedInternalById", "14200856-1041-4c9a-a52e-204210de7a1f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.qbb7Ghe1g0ygXF_MGE1C1A/NodesNotShownInESpaceTree.VgggFEEQmkylLiBCEN56Hw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"endepartment1\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal10\" Inner JOIN {Department} \"endepartment1\" ON (\"enuser_extended_internal10\".\"departmentid\" = \"endepartment1\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal10\".\"id\" = (CASE WHEN (@qpusi_GetUserId <> '') THEN @qpusi_GetUserId ELSE @qpusGetUserId END))");
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
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserDepartmentName.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserDepartmentName.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
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
