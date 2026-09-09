namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserById : VarsBag {
public string inParamUserId;
public RL_752c66ffcb633a1081093541635464e7 queryResGetUserById_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserById_outParamCount = 0L;

public lcvGetUserById(string inParamUserId) {
this.inParamUserId = inParamUserId;
}
}
public class lcoGetUserById : VarsBag {
public RC_34272dae45b4de5e1332f46c6e8700b9 outParamResult = new RC_34272dae45b4de5e1332f46c6e8700b9();

public lcoGetUserById() {
}
}
/// <summary>
/// Action <code>GetUserById</code> that represents the Service Studio action <code>GetUserById</code>
///  <p> Description: </p>
/// </summary>
public static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> ActionGetUserById(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
RC_34272dae45b4de5e1332f46c6e8700b9 outParamResult = default;
lcoGetUserById result = new lcoGetUserById();
lcvGetUserById localVars = new lcvGetUserById(inParamUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserById", "9aeb72b5-e177-4f1e-89db-8d45c1b7b96b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserById", "9aeb72b5-e177-4f1e-89db-8d45c1b7b96b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 0;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionGetUserById.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParamUserId,cancellationToken);

// Result.User = GetUserById.List.Current.User
result.outParamResult.ssENUser = localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser;

// Result.User_Extended_Internal = GetUserById.List.Current.User_Extended_Internal
result.outParamResult.ssENUser_Extended_Internal = localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser_Extended_Internal;
} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionGetUserById {

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserByIdReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" kTBCsGEzrkeqUbZnyclKuw of Action "GetUserById"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserById.GetUserById", "b0423091-3361-47ae-aa51-b667c9c94abb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserById.GetUserById", "b0423091-3361-47ae-aa51-b667c9c94abb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.tXLrmnfhHk+J241Fwbe5aw/NodesNotShownInESpaceTree.kTBCsGEzrkeqUbZnyclKuw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser94\".\"id\" o0, \"enuser94\".\"name\" o1, \"enuser94\".\"email\" o2, \"enuser94\".\"photourl\" o3, \"enuser94\".\"username\" o4, \"enuser_extended_internal58\".\"id\" o5, \"enuser_extended_internal58\".\"employeenumber\" o6, \"enuser_extended_internal58\".\"managedby\" o7, \"enuser_extended_internal58\".\"regionid\" o8, \"enuser_extended_internal58\".\"departmentid\" o9, \"enuser_extended_internal58\".\"managementid\" o10, \"enuser_extended_internal58\".\"subdirectionid\" o11, \"enuser_extended_internal58\".\"telceldirectionid\" o12, \"enuser_extended_internal58\".\"city\" o13, \"enuser_extended_internal58\".\"jobtitle\" o14, \"enuser_extended_internal58\".\"entraroleid\" o15, \"enuser_extended_internal58\".\"onpremisesdistinguishedname\" o16, \"enuser_extended_internal58\".\"hasrolesassigned\" o17, \"enuser_extended_internal58\".\"lastsync\" o18, \"enuser_extended_internal58\".\"createdby\" o19, \"enuser_extended_internal58\".\"createdon\" o20, \"enuser_extended_internal58\".\"updatedby\" o21, \"enuser_extended_internal58\".\"updatedon\" o22, \"enuser_extended_internal58\".\"entraid\" o23, \"enuser_extended_internal58\".\"telceldireccion\" o24");
fromBuilder.Append(" FROM ({User} \"enuser94\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal58\" ON (\"enuser94\".\"id\" = \"enuser_extended_internal58\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser94\".\"id\" = @qpusUser_Id) AND (\"enuser94\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser94\".\"id\" IS NULL)");
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserById.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserById.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_752c66ffcb633a1081093541635464e7)_tmp;
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
