namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetIsShowAssignFirstApproverPopup : VarsBag {
public string inParamUserId;
public RL_137ca0bd922b82f91f39dd017e999a51 queryResGetUserById_outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
public long queryResGetUserById_outParamCount = 0L;

public lcvGetIsShowAssignFirstApproverPopup(string inParamUserId) {
this.inParamUserId = inParamUserId;
}
}
public class lcoGetIsShowAssignFirstApproverPopup : VarsBag {
public bool outParamIsShow = false;

public lcoGetIsShowAssignFirstApproverPopup() {
}
}
/// <summary>
/// Action <code>GetIsShowAssignFirstApproverPopup</code> that represents the Service Studio action
///  <code>GetIsShowAssignFirstApproverPopup</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionGetIsShowAssignFirstApproverPopup(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamIsShow = default;
lcoGetIsShowAssignFirstApproverPopup result = new lcoGetIsShowAssignFirstApproverPopup();
lcvGetIsShowAssignFirstApproverPopup localVars = new lcvGetIsShowAssignFirstApproverPopup(inParamUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetIsShowAssignFirstApproverPopup", "b72e8b36-bae5-400f-b611-fa4fe08ed6c4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetIsShowAssignFirstApproverPopup", "b72e8b36-bae5-400f-b611-fa4fe08ed6c4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionGetIsShowAssignFirstApproverPopup.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParamUserId,cancellationToken);

// IsShow = GetUserById.List.Current.ApplicationRole.Code = "ASSISTENTE" or GetUserById.List.Current.EntraRole.IsAssistant
result.outParamIsShow=((localVars.queryResGetUserById_outParamList.CurrentRec.ssENApplicationRole.ssCode=="ASSISTENTE")||localVars.queryResGetUserById_outParamList.CurrentRec.ssENEntraRole.ssIsAssistant);
} //close CreateActionActivity using block
} // try

finally {
outParamIsShow = result.outParamIsShow;
} // inner-finally
RETURN_STATEMENT:
return outParamIsShow;
}

public static class FuncActionGetIsShowAssignFirstApproverPopup {

private static async Task<RC_7b8200225d1e3acafed4d42f9fce9055> datasetGetUserByIdReadDbAsync(RC_7b8200225d1e3acafed4d42f9fce9055 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" A58yjKUSEkeEGk4K76_v8A of Action "GetIsShowAssignFirstApproverPopup"
public static async Task<(RL_137ca0bd922b82f91f39dd017e999a51,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsShowAssignFirstApproverPopup.GetUserById", "8c329f03-12a5-4712-841a-4e0aefafeff0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsShowAssignFirstApproverPopup.GetUserById", "8c329f03-12a5-4712-841a-4e0aefafeff0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Nosut+W6D0C2EfpP4I7WxA/NodesNotShownInESpaceTree.A58yjKUSEkeEGk4K76_v8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole23\".\"code\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enentrarole30\".\"isassistant\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM (((({User} \"enuser105\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal61\" ON (\"enuser105\".\"id\" = \"enuser_extended_internal61\".\"id\"))  Left JOIN {EntraRole} \"enentrarole30\" ON (\"enuser_extended_internal61\".\"entraroleid\" = \"enentrarole30\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept10\" ON (\"enentrarole30\".\"id\" = \"enroleconcept10\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole23\" ON (\"enroleconcept10\".\"applicationroleid\" = \"enapplicationrole23\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser105\".\"id\" = @qpusUser_Id) AND (\"enuser105\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser105\".\"id\" IS NULL)");
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
RL_137ca0bd922b82f91f39dd017e999a51 outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsShowAssignFirstApproverPopup.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_137ca0bd922b82f91f39dd017e999a51 _tmp = new RL_137ca0bd922b82f91f39dd017e999a51();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsShowAssignFirstApproverPopup.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_137ca0bd922b82f91f39dd017e999a51)_tmp;
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
