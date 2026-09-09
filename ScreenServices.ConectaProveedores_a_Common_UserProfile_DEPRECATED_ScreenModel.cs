using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel).Namespace);

    public string varLcOldName;
public string varLcOldEmail;
public string varLcOldPhotoURL;
public bool varLcIsExternal;
public string varLcVerificationCode;
public bool varLcShowVerificationCode;
public bool varLcShowGetCodeButton;
public int varLcCountdownValue;
public object varLcTimerIntervalHandle;
public bool varLcIsButtonEnabled;
public int varLcIntervalDuration;
public bool varLcIsExecuting;
public bool varLcIsExecuting_GetCode;
public AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserDetails;
public AggregateRecord<RL_6baa91071578818b75d38b8795012b73> ScreenDataSetGetApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel() {
}



    public ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel(string varLcOldName, string varLcOldEmail, string varLcOldPhotoURL, bool varLcIsExternal, string varLcVerificationCode, bool varLcShowVerificationCode, bool varLcShowGetCodeButton, int varLcCountdownValue, object varLcTimerIntervalHandle, bool varLcIsButtonEnabled, int varLcIntervalDuration, bool varLcIsExecuting, bool varLcIsExecuting_GetCode, AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserDetails, AggregateRecord<RL_6baa91071578818b75d38b8795012b73> ScreenDataSetGetApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OldName", "OldEmail", "OldPhotoURL", "IsExternal", "VerificationCode", "ShowVerificationCode", "ShowGetCodeButton", "CountdownValue", "TimerIntervalHandle", "IsButtonEnabled", "IntervalDuration", "IsExecuting", "IsExecuting_GetCode", "GetUserDetails", "GetApplicationRoles", "ClientVars"}, new string[] {"varLcOldName", "varLcOldEmail", "varLcOldPhotoURL", "varLcIsExternal", "varLcVerificationCode", "varLcShowVerificationCode", "varLcShowGetCodeButton", "varLcCountdownValue", "varLcTimerIntervalHandle", "varLcIsButtonEnabled", "varLcIntervalDuration", "varLcIsExecuting", "varLcIsExecuting_GetCode", "ScreenDataSetGetUserDetails", "ScreenDataSetGetApplicationRoles", "clientVariables"});
this.varLcOldName = varLcOldName;
this.varLcOldEmail = varLcOldEmail;
this.varLcOldPhotoURL = varLcOldPhotoURL;
this.varLcIsExternal = varLcIsExternal;
this.varLcVerificationCode = varLcVerificationCode;
this.varLcShowVerificationCode = varLcShowVerificationCode;
this.varLcShowGetCodeButton = varLcShowGetCodeButton;
this.varLcCountdownValue = varLcCountdownValue;
this.varLcTimerIntervalHandle = varLcTimerIntervalHandle;
this.varLcIsButtonEnabled = varLcIsButtonEnabled;
this.varLcIntervalDuration = varLcIntervalDuration;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcIsExecuting_GetCode = varLcIsExecuting_GetCode;
this.ScreenDataSetGetUserDetails = ScreenDataSetGetUserDetails;
this.ScreenDataSetGetApplicationRoles = ScreenDataSetGetApplicationRoles;
this.clientVariables = clientVariables;
}



    
// Query Function "GetUserDetails" fxBfD0k600aRKN02yY_0+Q of Action "UserProfile_DEPRECATED"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserDetails(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.UserProfile_DEPRECATED.GetUserDetails", "0f5f107f-3a49-46d3-9128-dd36c98ff4f9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UserProfile_DEPRECATED","a_Common.UserProfile_DEPRECATED.GetUserDetails");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.IeRwRl_1SkSq5kf1rZwRjQ/ScreenDataSets.fxBfD0k600aRKN02yY_0+Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser156\".\"name\" o1, \"enuser156\".\"email\" o2, \"enuser156\".\"photourl\" o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser156\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser156\".\"id\" = @qpusId) AND (\"enuser156\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser156\".\"id\" IS NULL)");
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.UserProfile_DEPRECATED.GetUserDetails.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.UserProfile_DEPRECATED.GetUserDetails.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
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

private static async Task<RC_c2921a936d592680b8275006015423c4> datasetGetApplicationRolesReadDbAsync(RC_c2921a936d592680b8275006015423c4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetApplicationRoles" R4VxZDQgfkWKRlyzn_Px7Q of Action "UserProfile_DEPRECATED"
public static async Task<(RL_6baa91071578818b75d38b8795012b73,long)> datasetGetApplicationRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRole_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.UserProfile_DEPRECATED.GetApplicationRoles", "64718547-2034-457e-8a46-5cb39ff3f1ed");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UserProfile_DEPRECATED","a_Common.UserProfile_DEPRECATED.GetApplicationRoles");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.IeRwRl_1SkSq5kf1rZwRjQ/ScreenDataSets.R4VxZDQgfkWKRlyzn_Px7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM ({UserApplicationRole} \"enuserapplicationrole21\" Left JOIN {ApplicationRole} \"enapplicationrole47\" ON (\"enuserapplicationrole21\".\"applicationroleid\" = \"enapplicationrole47\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRole_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationrole21\".\"userid\" = @qpusUserApplicationRole_UserId) AND (\"enuserapplicationrole21\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRole_UserId", DbType.String, qpusUserApplicationRole_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationrole21\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole21\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (((caseaccent_normalize(\"enapplicationrole47\".\"code\" collate \"default\") like caseaccent_normalize('DIRECTOR_REGIONAL' collate \"default\")) OR (caseaccent_normalize(\"enapplicationrole47\".\"code\" collate \"default\") like caseaccent_normalize('GERENTE_FINANZAS' collate \"default\"))) OR (caseaccent_normalize(\"enapplicationrole47\".\"code\" collate \"default\") like caseaccent_normalize('GERENTE_OPERACIONES' collate \"default\")))");
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
RL_6baa91071578818b75d38b8795012b73 outParamList = new RL_6baa91071578818b75d38b8795012b73();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApplicationRolesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.UserProfile_DEPRECATED.GetApplicationRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6baa91071578818b75d38b8795012b73 _tmp = new RL_6baa91071578818b75d38b8795012b73();
_tmp.AlternateReadDbMethodAsync = datasetGetApplicationRolesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.UserProfile_DEPRECATED.GetApplicationRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6baa91071578818b75d38b8795012b73)_tmp;
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
