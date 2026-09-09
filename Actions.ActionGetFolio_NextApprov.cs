namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFolio_NextApprov : VarsBag {
public string inParami_UserId;
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio;
public long inParami_ApprovalProcessId;
/// <summary>
/// Variable <code>l_CurrentEmail</code> that represents the Service Studio Text
///  <code>l_CurrentEmail</code> <p>Description: CurrentEmail</p>
/// </summary>
public string varLcl_CurrentEmail = "";

/// <summary>
/// Variable <code>l_UserFoundWithManagerEmail</code> that represents the Service Studio UserIdentifier
///  <code>l_UserFoundWithManagerEmail</code> <p>Description: </p>
/// </summary>
public string varLcl_UserFoundWithManagerEmail = "";

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtensionByEmail_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtensionByEmail_outParamCount = 0L;

public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserManager_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManager_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserByEmail_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserByEmail_outParamCount = 0L;

public Actions.lcoGetUserRole resGetUserRole =  new Actions.lcoGetUserRole();
public ST_346a76e47f982dbf41625f8a893affccStructure resServiceEntraRoleCreate_outParamo_output = new ST_346a76e47f982dbf41625f8a893affccStructure();
public bool resServiceEntraRoleCreate_outParamHasBeenCreated = false;
public long resServiceEntraRoleCreate_outParamEntraRoleId = 0L;

public Actions.lcoGetAppRoleFromEntraJobTitle resGetAppRoleFromEntraJobTitle =  new Actions.lcoGetAppRoleFromEntraJobTitle();
public Actions.lcoFolioRoleIsNeeded resFolioRoleIsNeeded =  new Actions.lcoFolioRoleIsNeeded();
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserById_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserById_outParamCount = 0L;

public lcvGetFolio_NextApprov(string inParami_UserId, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio, long inParami_ApprovalProcessId) {
this.inParami_UserId = inParami_UserId;
this.inParami_Folio = inParami_Folio;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
}
}
public class lcoGetFolio_NextApprov : VarsBag {
public bool outParamo_IsFinishApproval = false;

public string outParamo_AssignTo = "";

public long outParamo_ApplicationRoleId = 0L;

public string outParamo_IsSubstituteFor = "";

public lcoGetFolio_NextApprov() {
}
}
/// <summary>
/// Action <code>GetFolio_NextApprov</code> that represents the Service Studio action
///  <code>GetFolio_NextApprov</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string,long,string)> ActionGetFolio_NextApprov(IRequestContext requestContext,string inParami_UserId,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio,long inParami_ApprovalProcessId,CancellationToken cancellationToken) {
bool outParamo_IsFinishApproval = default;
string outParamo_AssignTo = default;
long outParamo_ApplicationRoleId = default;
string outParamo_IsSubstituteFor = default;
lcoGetFolio_NextApprov result = new lcoGetFolio_NextApprov();
lcvGetFolio_NextApprov localVars = new lcvGetFolio_NextApprov(inParami_UserId, inParami_Folio, inParami_ApprovalProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFolio_NextApprov", "49db5f57-b6a3-4730-bb27-3dd604f4bc1a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFolio_NextApprov", "49db5f57-b6a3-4730-bb27-3dd604f4bc1a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionGetFolio_NextApprov.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// l_CurrentEmail = If
localVars.varLcl_CurrentEmail=(((localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssEmail));
while (true) {
// GetUserManager
(localVars.resGetUserManager_outParamResponse,localVars.resGetUserManager_outParamResult) = await Actions.ActionGetUserManager(requestContext,localVars.varLcl_CurrentEmail,cancellationToken);

// not IsSuccess?
if(((!localVars.resGetUserManager_outParamResult.ssIsSuccess))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("iqV+trW7ykaTAEtlwj0gzA#Message.510739596.1", "Error getting info from Entra."));

} else {
// l_UserFoundWithManagerEmail = NullTextIdentifier
localVars.varLcl_UserFoundWithManagerEmail=BuiltInFunction.NullTextIdentifier ();
// Query datasetGetUserExtensionByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtensionByEmail_maxRecords = 1;
if (datasetGetUserExtensionByEmail_maxRecords < 1) datasetGetUserExtensionByEmail_maxRecords = 1;
int datasetGetUserExtensionByEmail_startIndex = 0;(localVars.queryResGetUserExtensionByEmail_outParamList,localVars.queryResGetUserExtensionByEmail_outParamCount) = await FuncActionGetFolio_NextApprov.datasetGetUserExtensionByEmail(requestContext,datasetGetUserExtensionByEmail_maxRecords,datasetGetUserExtensionByEmail_startIndex,IterationMultiplicity.Never,localVars.resGetUserManager_outParamResponse.ssMail,cancellationToken);

// Empty?
if((localVars.queryResGetUserExtensionByEmail_outParamList.Empty)) {
// Query datasetGetUserByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserByEmail_maxRecords = 1;
if (datasetGetUserByEmail_maxRecords < 1) datasetGetUserByEmail_maxRecords = 1;
int datasetGetUserByEmail_startIndex = 0;(localVars.queryResGetUserByEmail_outParamList,localVars.queryResGetUserByEmail_outParamCount) = await FuncActionGetFolio_NextApprov.datasetGetUserByEmail(requestContext,datasetGetUserByEmail_maxRecords,datasetGetUserByEmail_startIndex,IterationMultiplicity.Never,localVars.resGetUserManager_outParamResponse.ssMail,cancellationToken);

// l_UserFoundWithManagerEmail = GetUserByEmail.List.Current.User.Id
localVars.varLcl_UserFoundWithManagerEmail=localVars.queryResGetUserByEmail_outParamList.CurrentRec.ssENUser.ssId;
} else {
// l_UserFoundWithManagerEmail = GetUserExtensionByEmail.List.Current.User.Id
localVars.varLcl_UserFoundWithManagerEmail=localVars.queryResGetUserExtensionByEmail_outParamList.CurrentRec.ssENUser.ssId;
}

// Reports to himself?
if(((localVars.resGetUserManager_outParamResponse.ssMail==localVars.varLcl_CurrentEmail))) {
// o_IsFinishApproval = True
result.outParamo_IsFinishApproval=true;
goto RETURN_STATEMENT;

} else {
// ServiceEntraRoleCreate
(localVars.resServiceEntraRoleCreate_outParamo_output,localVars.resServiceEntraRoleCreate_outParamHasBeenCreated,localVars.resServiceEntraRoleCreate_outParamEntraRoleId) = await ServiceAPIs.ServiceAPIServiceEntraRoleCreate(requestContext,localVars.resGetUserManager_outParamResponse.ssJobTitle,cancellationToken);

// not IsSuccess?
if(((!localVars.resServiceEntraRoleCreate_outParamo_output.ssIsSuccess))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("0EQvDWuESEqxqfcQ6IQptg#Message.-709613.1", "New Job Title from Entra detected. Error creating new record."));

} else {
// Manager not found?
if(((localVars.varLcl_UserFoundWithManagerEmail==BuiltInFunction.NullTextIdentifier ()))) {
// GetAppRoleFromEntraJobTitle
(localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId,localVars.resGetAppRoleFromEntraJobTitle.outParamo_RoleName) = await Actions.ActionGetAppRoleFromEntraJobTitle(requestContext,localVars.resGetUserManager_outParamResponse.ssJobTitle,2,true,false,cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (((AppUtils.GetStringResource("Vqkz602AIkeAIZvKaOHYtA#Message.1701097408.1", "Next approver's role is not yet mapped to an application role.")+" ")+localVars.resGetUserManager_outParamResponse.ssJobTitle));

} else {
// o_ApplicationRoleId = GetAppRoleFromEntraJobTitle.o_ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId;
}

} else {
// GetUserRole
localVars.resGetUserRole.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.varLcl_UserFoundWithManagerEmail,2,true,false,cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetUserRole.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (((AppUtils.GetStringResource("6el1XtoB7ku9f2zfl3bMMQ#Message.1701097408.1", "Next approver's role is not yet mapped to an application role.")+" ")+localVars.resGetUserManager_outParamResponse.ssJobTitle));

} else {
// o_ApplicationRoleId = GetUserRole.o_ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.resGetUserRole.outParamo_ApplicationRoleId;
}

}

// FolioRoleIsNeeded
(localVars.resFolioRoleIsNeeded.outParamo_IsNeeded,localVars.resFolioRoleIsNeeded.outParamo_ApprovalProcessLevel) = await Actions.ActionFolioRoleIsNeeded(requestContext,localVars.inParami_Folio,localVars.inParami_ApprovalProcessId,result.outParamo_ApplicationRoleId,false,cancellationToken);

// o_IsNeeded?
if((localVars.resFolioRoleIsNeeded.outParamo_IsNeeded)) {
// Manager not found?
if(((localVars.varLcl_UserFoundWithManagerEmail==BuiltInFunction.NullTextIdentifier ()))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (((((AppUtils.GetStringResource("WcXCW66suU+DSk4QkwbSOQ#Message.1259981447.1", "Next approver not found.")+" '")+localVars.resGetUserManager_outParamResponse.ssMail)+"' ")+AppUtils.GetStringResource("WcXCW66suU+DSk4QkwbSOQ#Message.1926925690.1", "has not yet logged into the application.")));

} else {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.varLcl_UserFoundWithManagerEmail,cancellationToken);

// o_AssignTo = If
result.outParamo_AssignTo=(((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.varLcl_UserFoundWithManagerEmail) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// o_IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
result.outParamo_IsSubstituteFor=localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
goto RETURN_STATEMENT;

}

} else {
// l_CurrentEmail = GetUserManager.Response.Mail
localVars.varLcl_CurrentEmail=localVars.resGetUserManager_outParamResponse.ssMail;
}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_IsFinishApproval = result.outParamo_IsFinishApproval;
outParamo_AssignTo = result.outParamo_AssignTo;
outParamo_ApplicationRoleId = result.outParamo_ApplicationRoleId;
outParamo_IsSubstituteFor = result.outParamo_IsSubstituteFor;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_IsFinishApproval,outParamo_AssignTo,outParamo_ApplicationRoleId,outParamo_IsSubstituteFor);
}

public static class FuncActionGetFolio_NextApprov {

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserExtensionByEmailReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtensionByEmail" FTG8M9ehU0ixSCp6wsJjtg of Action "GetFolio_NextApprov"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtensionByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteUserExtension_CorrespondentExternalEmail,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolio_NextApprov.GetUserExtensionByEmail", "33bc3115-a1d7-4853-b148-2a7ac2c263b6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolio_NextApprov.GetUserExtensionByEmail", "33bc3115-a1d7-4853-b148-2a7ac2c263b6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.V1_bSaO2MEe7Jz3WBPS8Gg/NodesNotShownInESpaceTree.FTG8M9ehU0ixSCp6wsJjtg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser49\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM ({UserExtension} \"enuserextension28\" Inner JOIN {User} \"enuser49\" ON (\"enuserextension28\".\"id\" = \"enuser49\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuserextension28\".\"correspondentexternalemail\" = @qpteUserExtension_CorrespondentExternalEmail)");
sqlCmd.CreateParameterWithoutReplacements("@qpteUserExtension_CorrespondentExternalEmail", DbType.String, qpteUserExtension_CorrespondentExternalEmail);
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
RL_c5c32c91f72d14efd2c0ccca15008afa outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtensionByEmailReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolio_NextApprov.GetUserExtensionByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtensionByEmailReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolio_NextApprov.GetUserExtensionByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5c32c91f72d14efd2c0ccca15008afa)_tmp;
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

// Query Function "GetUserByEmail" 0uk_fUffMEmurhq1eBsdig of Action "GetFolio_NextApprov"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteEmail,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolio_NextApprov.GetUserByEmail", "7d3fe9d2-df47-4930-aeae-1ab5781b1d8a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolio_NextApprov.GetUserByEmail", "7d3fe9d2-df47-4930-aeae-1ab5781b1d8a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.V1_bSaO2MEe7Jz3WBPS8Gg/NodesNotShownInESpaceTree.0uk_fUffMEmurhq1eBsdig, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser50\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser50\"");
whereBuilder.Append(" WHERE (\"enuser50\".\"email\" = @qpteEmail)");
sqlCmd.CreateParameterWithoutReplacements("@qpteEmail", DbType.String, qpteEmail);
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolio_NextApprov.GetUserByEmail.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolio_NextApprov.GetUserByEmail.List", cancellationToken: cancellationToken);
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserByIdReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" 1Hg2y9Hr3EyBdRtxFPF32g of Action "GetFolio_NextApprov"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolio_NextApprov.GetUserById", "cb3678d4-ebd1-4cdc-8175-1b7114f177da");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolio_NextApprov.GetUserById", "cb3678d4-ebd1-4cdc-8175-1b7114f177da", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.V1_bSaO2MEe7Jz3WBPS8Gg/NodesNotShownInESpaceTree.1Hg2y9Hr3EyBdRtxFPF32g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuser51\".\"email\" o2, NULL o3, NULL o4, NULL o5, \"enuserextension29\".\"correspondentexternalemail\" o6, NULL o7");
fromBuilder.Append(" FROM ({User} \"enuser51\" Left JOIN {UserExtension} \"enuserextension29\" ON (\"enuser51\".\"id\" = \"enuserextension29\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser51\".\"id\" = @qpusUser_Id) AND (\"enuser51\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser51\".\"id\" IS NULL)");
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
RL_c5c32c91f72d14efd2c0ccca15008afa outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolio_NextApprov.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolio_NextApprov.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5c32c91f72d14efd2c0ccca15008afa)_tmp;
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
