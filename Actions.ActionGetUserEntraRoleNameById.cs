namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserEntraRoleNameById : VarsBag {
public string inParami_UserId;
public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetUserExtendedInternalEntraRoleId_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetUserExtendedInternalEntraRoleId_outParamCount = 0L;

public lcvGetUserEntraRoleNameById(string inParami_UserId) {
this.inParami_UserId = inParami_UserId;
}
}
public class lcoGetUserEntraRoleNameById : VarsBag {
public string outParamo_EntraRoleName = "";

public lcoGetUserEntraRoleNameById() {
}
}
/// <summary>
/// Action <code>GetUserEntraRoleNameById</code> that represents the Service Studio action
///  <code>GetUserEntraRoleNameById</code> <p> Description: Get Entra Role name from user.</p>
/// </summary>
public static async Task<string> ActionGetUserEntraRoleNameById(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
string outParamo_EntraRoleName = default;
lcoGetUserEntraRoleNameById result = new lcoGetUserEntraRoleNameById();
lcvGetUserEntraRoleNameById localVars = new lcvGetUserEntraRoleNameById(inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserEntraRoleNameById", "5e428485-1d60-4efa-aa60-87eab2663806"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserEntraRoleNameById", "5e428485-1d60-4efa-aa60-87eab2663806", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalEntraRoleId_maxRecords = 1;
if (datasetGetUserExtendedInternalEntraRoleId_maxRecords < 1) datasetGetUserExtendedInternalEntraRoleId_maxRecords = 1;
int datasetGetUserExtendedInternalEntraRoleId_startIndex = 0;(localVars.queryResGetUserExtendedInternalEntraRoleId_outParamList,localVars.queryResGetUserExtendedInternalEntraRoleId_outParamCount) = await FuncActionGetUserEntraRoleNameById.datasetGetUserExtendedInternalEntraRoleId(requestContext,datasetGetUserExtendedInternalEntraRoleId_maxRecords,datasetGetUserExtendedInternalEntraRoleId_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// o_EntraRoleName = GetUserExtendedInternalEntraRoleId.List.Current.User_Extended_Internal.JobTitle
result.outParamo_EntraRoleName=localVars.queryResGetUserExtendedInternalEntraRoleId_outParamList.CurrentRec.ssENUser_Extended_Internal.ssJobTitle;
} //close CreateActionActivity using block
} // try

finally {
outParamo_EntraRoleName = result.outParamo_EntraRoleName;
} // inner-finally
RETURN_STATEMENT:
return outParamo_EntraRoleName;
}

public static class FuncActionGetUserEntraRoleNameById {

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetUserExtendedInternalEntraRoleIdReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalEntraRoleId" dZuJkzSni0STRx0TdaiBMg of Action "GetUserEntraRoleNameById"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetUserExtendedInternalEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserEntraRoleNameById.GetUserExtendedInternalEntraRoleId", "93899b75-a734-448b-9347-1d1375a88132");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserEntraRoleNameById.GetUserExtendedInternalEntraRoleId", "93899b75-a734-448b-9347-1d1375a88132", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hYRCXmAd+k6qYIfqsmY4Bg/NodesNotShownInESpaceTree.dZuJkzSni0STRx0TdaiBMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enuser_extended_internal37\".\"jobtitle\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal37\" Inner JOIN {User} \"enuser60\" ON (\"enuser_extended_internal37\".\"id\" = \"enuser60\".\"id\"))  Left JOIN {EntraRole} \"enentrarole13\" ON (\"enuser_extended_internal37\".\"entraroleid\" = \"enentrarole13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser60\".\"id\" = @qpusUser_Id) AND (\"enuser60\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser60\".\"id\" IS NULL)");
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
RL_a37f5f153582e24adaea3ae8b54b3101 outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalEntraRoleIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserEntraRoleNameById.GetUserExtendedInternalEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalEntraRoleIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserEntraRoleNameById.GetUserExtendedInternalEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a37f5f153582e24adaea3ae8b54b3101)_tmp;
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
