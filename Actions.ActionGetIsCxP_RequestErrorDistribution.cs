namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetIsCxP_RequestErrorDistribution : VarsBag {
public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetIsAllowed_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetIsAllowed_outParamCount = 0L;

public lcvGetIsCxP_RequestErrorDistribution() {
}
}
public class lcoGetIsCxP_RequestErrorDistribution : VarsBag {
public bool outParamo_IsAllowed = false;

public lcoGetIsCxP_RequestErrorDistribution() {
}
}
/// <summary>
/// Action <code>GetIsCxP_RequestErrorDistribution</code> that represents the Service Studio action
///  <code>GetIsCxP_RequestErrorDistribution</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionGetIsCxP_RequestErrorDistribution(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsAllowed = default;
lcoGetIsCxP_RequestErrorDistribution result = new lcoGetIsCxP_RequestErrorDistribution();
lcvGetIsCxP_RequestErrorDistribution localVars = new lcvGetIsCxP_RequestErrorDistribution();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetIsCxP_RequestErrorDistribution", "df02fae1-a7d5-44cc-a42f-3568a3195be2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetIsCxP_RequestErrorDistribution", "df02fae1-a7d5-44cc-a42f-3568a3195be2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetIsAllowed
cancellationToken.ThrowIfCancellationRequested();
int datasetGetIsAllowed_maxRecords = 1;
if (datasetGetIsAllowed_maxRecords < 1) datasetGetIsAllowed_maxRecords = 1;
int datasetGetIsAllowed_startIndex = 0;(localVars.queryResGetIsAllowed_outParamList,localVars.queryResGetIsAllowed_outParamCount) = await FuncActionGetIsCxP_RequestErrorDistribution.datasetGetIsAllowed(requestContext,datasetGetIsAllowed_maxRecords,datasetGetIsAllowed_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// o_IsAllowed = notGetIsAllowed.List.Empty and Index = -1 and GetIsAllowed.List.Current.EntraRole.IsAreaCxP
result.outParamo_IsAllowed=(((!localVars.queryResGetIsAllowed_outParamList.Empty)&&(BuiltInFunction.IndexSC (localVars.queryResGetIsAllowed_outParamList.CurrentRec.ssENEntraRole.ssRoleName, "analista", 0, false, true)==(-1)))&&localVars.queryResGetIsAllowed_outParamList.CurrentRec.ssENEntraRole.ssIsAreaCxP);
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsAllowed = result.outParamo_IsAllowed;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsAllowed;
}

public static class FuncActionGetIsCxP_RequestErrorDistribution {

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetIsAllowedReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetIsAllowed" 43VAmhwF5UGh8_9C+en4Yw of Action "GetIsCxP_RequestErrorDistribution"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetIsAllowed(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsCxP_RequestErrorDistribution.GetIsAllowed", "9a4075e3-051c-41e5-a1f3-ff42f9e9f863");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsCxP_RequestErrorDistribution.GetIsAllowed", "9a4075e3-051c-41e5-a1f3-ff42f9e9f863", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.4foC39WnzESkLzVooxlb4g/NodesNotShownInESpaceTree.43VAmhwF5UGh8_9C+en4Yw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole35\".\"rolename\" o1, NULL o2, \"enentrarole35\".\"isareacxp\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User} \"enuser123\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal74\" ON (\"enuser123\".\"id\" = \"enuser_extended_internal74\".\"id\"))  Left JOIN {EntraRole} \"enentrarole35\" ON (\"enuser_extended_internal74\".\"entraroleid\" = \"enentrarole35\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser123\".\"id\" = @qpusUser_Id) AND (\"enuser123\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser123\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetIsAllowedReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, false, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsCxP_RequestErrorDistribution.GetIsAllowed.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetIsAllowedReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsCxP_RequestErrorDistribution.GetIsAllowed.List", cancellationToken: cancellationToken);
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
