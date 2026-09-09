namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserApplicationRoleCyA : VarsBag {
public RL_d22dbb34ff25b8803ae17b65f615d2c8 queryResGetUserApplicationRolesByUserId_outParamList = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
public long queryResGetUserApplicationRolesByUserId_outParamCount = 0L;

public lcvGetUserApplicationRoleCyA() {
}
}
public class lcoGetUserApplicationRoleCyA : VarsBag {
public long outParamo_ApplicationRoleId = 0L;

public lcoGetUserApplicationRoleCyA() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoleCyA</code> that represents the Service Studio action
///  <code>GetUserApplicationRoleCyA</code> <p> Description: Action to get ApplicationRoleId from logge
/// d user</p>
/// </summary>
public static async Task<long> ActionGetUserApplicationRoleCyA(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamo_ApplicationRoleId = default;
lcoGetUserApplicationRoleCyA result = new lcoGetUserApplicationRoleCyA();
lcvGetUserApplicationRoleCyA localVars = new lcvGetUserApplicationRoleCyA();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserApplicationRoleCyA", "332a8684-02fe-4b77-b5da-2cddc3fd1a43"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserApplicationRoleCyA", "332a8684-02fe-4b77-b5da-2cddc3fd1a43", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserApplicationRolesByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRolesByUserId_maxRecords = 1;
if (datasetGetUserApplicationRolesByUserId_maxRecords < 1) datasetGetUserApplicationRolesByUserId_maxRecords = 1;
int datasetGetUserApplicationRolesByUserId_startIndex = 0;(localVars.queryResGetUserApplicationRolesByUserId_outParamList,localVars.queryResGetUserApplicationRolesByUserId_outParamCount) = await FuncActionGetUserApplicationRoleCyA.datasetGetUserApplicationRolesByUserId(requestContext,datasetGetUserApplicationRolesByUserId_maxRecords,datasetGetUserApplicationRolesByUserId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// o_ApplicationRoleId = GetUserApplicationRolesByUserId.List.Current.UserApplicationRole.ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.queryResGetUserApplicationRolesByUserId_outParamList.CurrentRec.ssENUserApplicationRole.ssApplicationRoleId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_ApplicationRoleId = result.outParamo_ApplicationRoleId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ApplicationRoleId;
}

public static class FuncActionGetUserApplicationRoleCyA {

// Query Function "GetUserApplicationRolesByUserId" a0VOQ_blk0mgoPOdpJp41w of Action "GetUserApplicationRoleCyA"
public static async Task<(RL_d22dbb34ff25b8803ae17b65f615d2c8,long)> datasetGetUserApplicationRolesByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserApplicationRoleCyA.GetUserApplicationRolesByUserId", "434e456b-e5f6-4993-a0a0-f39da49a78d7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserApplicationRoleCyA.GetUserApplicationRolesByUserId", "434e456b-e5f6-4993-a0a0-f39da49a78d7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hIYqM_4Cd0u12izdw_0aQw/NodesNotShownInESpaceTree.a0VOQ_blk0mgoPOdpJp41w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuserapplicationrole5\".\"applicationroleid\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {UserApplicationRole} \"enuserapplicationrole5\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationrole5\".\"userid\" = @qpusUserId) AND (\"enuserapplicationrole5\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationrole5\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole5\".\"rolestatusid\" = ");
whereBuilder.Append(2
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
RL_d22dbb34ff25b8803ae17b65f615d2c8 outParamList = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserApplicationRoleCyA.GetUserApplicationRolesByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d22dbb34ff25b8803ae17b65f615d2c8 _tmp = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserApplicationRoleCyA.GetUserApplicationRolesByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d22dbb34ff25b8803ae17b65f615d2c8)_tmp;
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
