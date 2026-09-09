namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserEntraRoleId : VarsBag {
public string inParami_UserId;
public RL_ea7d18baeeefa57d5c86706d7efb98e9 queryResGetUserExtendedInternalEntraRoleId_outParamList = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
public long queryResGetUserExtendedInternalEntraRoleId_outParamCount = 0L;

public lcvGetUserEntraRoleId(string inParami_UserId) {
this.inParami_UserId = inParami_UserId;
}
}
public class lcoGetUserEntraRoleId : VarsBag {
public long outParamo_EntraRoleId = 0L;

public lcoGetUserEntraRoleId() {
}
}
/// <summary>
/// Action <code>GetUserEntraRoleId</code> that represents the Service Studio action
///  <code>GetUserEntraRoleId</code> <p> Description: Get Entra Role id from user.</p>
/// </summary>
public static async Task<long> ActionGetUserEntraRoleId(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
long outParamo_EntraRoleId = default;
lcoGetUserEntraRoleId result = new lcoGetUserEntraRoleId();
lcvGetUserEntraRoleId localVars = new lcvGetUserEntraRoleId(inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserEntraRoleId", "f4fdb169-fea7-460a-b50d-7744ff798fcf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserEntraRoleId", "f4fdb169-fea7-460a-b50d-7744ff798fcf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalEntraRoleId_maxRecords = 1;
if (datasetGetUserExtendedInternalEntraRoleId_maxRecords < 1) datasetGetUserExtendedInternalEntraRoleId_maxRecords = 1;
int datasetGetUserExtendedInternalEntraRoleId_startIndex = 0;(localVars.queryResGetUserExtendedInternalEntraRoleId_outParamList,localVars.queryResGetUserExtendedInternalEntraRoleId_outParamCount) = await FuncActionGetUserEntraRoleId.datasetGetUserExtendedInternalEntraRoleId(requestContext,datasetGetUserExtendedInternalEntraRoleId_maxRecords,datasetGetUserExtendedInternalEntraRoleId_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// o_EntraRoleId = GetUserExtendedInternalEntraRoleId.List.Current.User_Extended_Internal.EntraRoleId
result.outParamo_EntraRoleId=localVars.queryResGetUserExtendedInternalEntraRoleId_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_EntraRoleId = result.outParamo_EntraRoleId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_EntraRoleId;
}

public static class FuncActionGetUserEntraRoleId {

private static async Task<RC_2d026dc77741fad17a11f0df63aa3b4b> datasetGetUserExtendedInternalEntraRoleIdReadDbAsync(RC_2d026dc77741fad17a11f0df63aa3b4b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalEntraRoleId" QUrnklhauk2PcXQBIYvxMw of Action "GetUserEntraRoleId"
public static async Task<(RL_ea7d18baeeefa57d5c86706d7efb98e9,long)> datasetGetUserExtendedInternalEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserEntraRoleId.GetUserExtendedInternalEntraRoleId", "92e74a41-5a58-4dba-8f71-7401218bf133");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserEntraRoleId.GetUserExtendedInternalEntraRoleId", "92e74a41-5a58-4dba-8f71-7401218bf133", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.abH99Kf+Cka1DXdE_3mPzw/NodesNotShownInESpaceTree.QUrnklhauk2PcXQBIYvxMw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enuser_extended_internal83\".\"entraroleid\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal83\" Left JOIN {EntraRole} \"enentrarole40\" ON (\"enuser_extended_internal83\".\"entraroleid\" = \"enentrarole40\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal83\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal83\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal83\".\"id\" IS NULL)");
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
RL_ea7d18baeeefa57d5c86706d7efb98e9 outParamList = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalEntraRoleIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserEntraRoleId.GetUserExtendedInternalEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ea7d18baeeefa57d5c86706d7efb98e9 _tmp = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalEntraRoleIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserEntraRoleId.GetUserExtendedInternalEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ea7d18baeeefa57d5c86706d7efb98e9)_tmp;
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
