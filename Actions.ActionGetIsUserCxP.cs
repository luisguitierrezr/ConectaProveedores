namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetIsUserCxP : VarsBag {
public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetUserById_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetUserById_outParamCount = 0L;

public lcvGetIsUserCxP() {
}
}
public class lcoGetIsUserCxP : VarsBag {
public bool outParamo_Value = false;

public lcoGetIsUserCxP() {
}
}
/// <summary>
/// Action <code>GetIsUserCxP</code> that represents the Service Studio action
///  <code>GetIsUserCxP</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionGetIsUserCxP(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_Value = default;
lcoGetIsUserCxP result = new lcoGetIsUserCxP();
lcvGetIsUserCxP localVars = new lcvGetIsUserCxP();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetIsUserCxP", "7e96f822-fed7-41be-8321-3332ee6ef119"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetIsUserCxP", "7e96f822-fed7-41be-8321-3332ee6ef119", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionGetIsUserCxP.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// o_Value = notGetUserById.List.Empty
result.outParamo_Value=(!localVars.queryResGetUserById_outParamList.Empty);
} //close CreateActionActivity using block
} // try

finally {
outParamo_Value = result.outParamo_Value;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Value;
}

public static class FuncActionGetIsUserCxP {

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetUserByIdReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" rRu79+zeqEWMXl3AdSLlvw of Action "GetIsUserCxP"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsUserCxP.GetUserById", "f7bb1bad-deec-45a8-8c5e-5dc07522e5bf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsUserCxP.GetUserById", "f7bb1bad-deec-45a8-8c5e-5dc07522e5bf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.IviWftf+vkGDITMy7m7xGQ/NodesNotShownInESpaceTree.rRu79+zeqEWMXl3AdSLlvw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User} \"enuser79\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal48\" ON (\"enuser79\".\"id\" = \"enuser_extended_internal48\".\"id\"))  Left JOIN {EntraRole} \"enentrarole22\" ON (\"enuser_extended_internal48\".\"entraroleid\" = \"enentrarole22\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser79\".\"id\" = @qpusUser_Id) AND (\"enuser79\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser79\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enentrarole22\".\"isareacxp\" = 1)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsUserCxP.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsUserCxP.GetUserById.List", cancellationToken: cancellationToken);
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
