namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetReqNextApprov : VarsBag {
public string inParami_UserId;
public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition;
public long inParami_ApprovalProcessId;
public bool inParami_HasStartedAccounting;
/// <summary>
/// Variable <code>l_CurrentEmail</code> that represents the Service Studio Text
///  <code>l_CurrentEmail</code> <p>Description: CurrentEmail</p>
/// </summary>
public string varLcl_CurrentEmail = "";

public Actions.lcoGetUserRole resGetUserRole =  new Actions.lcoGetUserRole();
public ST_346a76e47f982dbf41625f8a893affccStructure resServiceEntraRoleCreate_outParamo_output = new ST_346a76e47f982dbf41625f8a893affccStructure();
public bool resServiceEntraRoleCreate_outParamHasBeenCreated = false;
public long resServiceEntraRoleCreate_outParamEntraRoleId = 0L;

public Actions.lcoReqRoleIsNeeded resReqRoleIsNeeded =  new Actions.lcoReqRoleIsNeeded();
public Actions.lcoHasActiveSubstitution resHasActiveSubstitution2 =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoGetGerenteCxPandDirReg resGetGerenteCxPandDirReg =  new Actions.lcoGetGerenteCxPandDirReg();
public RL_83566cec88e769363a30dc5e5b6a86f1 queryResFindUserByEmail_outParamList = new RL_83566cec88e769363a30dc5e5b6a86f1();
public long queryResFindUserByEmail_outParamCount = 0L;

public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserManager_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManager_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoGetAppRoleFromEntraJobTitle resGetAppRoleFromEntraJobTitle =  new Actions.lcoGetAppRoleFromEntraJobTitle();
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserById_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserById_outParamCount = 0L;

public lcvGetReqNextApprov(string inParami_UserId, EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition, long inParami_ApprovalProcessId, bool inParami_HasStartedAccounting) {
this.inParami_UserId = inParami_UserId;
this.inParami_Requisition = inParami_Requisition;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_HasStartedAccounting = inParami_HasStartedAccounting;
}
}
public class lcoGetReqNextApprov : VarsBag {
public bool outParamo_IsFinishApproval = false;

public string outParamo_AssignTo = "";

public long outParamo_ApplicationRoleId = 0L;

public RL_75b7c1c818327cb126543d6d6a18a3c3 outParamo_RequisitionApprovalLevels = new RL_75b7c1c818327cb126543d6d6a18a3c3();

public string outParamo_IsSubstituteFor = "";

public lcoGetReqNextApprov() {
}
}
/// <summary>
/// Action <code>GetReqNextApprov</code> that represents the Service Studio action
///  <code>GetReqNextApprov</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string,long,RL_75b7c1c818327cb126543d6d6a18a3c3,string)> ActionGetReqNextApprov(IRequestContext requestContext,string inParami_UserId,EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition,long inParami_ApprovalProcessId,bool inParami_HasStartedAccounting,CancellationToken cancellationToken) {
bool outParamo_IsFinishApproval = default;
string outParamo_AssignTo = default;
long outParamo_ApplicationRoleId = default;
RL_75b7c1c818327cb126543d6d6a18a3c3 outParamo_RequisitionApprovalLevels = default;
string outParamo_IsSubstituteFor = default;
lcoGetReqNextApprov result = new lcoGetReqNextApprov();
lcvGetReqNextApprov localVars = new lcvGetReqNextApprov(inParami_UserId, inParami_Requisition, inParami_ApprovalProcessId, inParami_HasStartedAccounting);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetReqNextApprov", "b1c4bb86-afd9-4680-855b-73e5ecb223ca"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetReqNextApprov", "b1c4bb86-afd9-4680-855b-73e5ecb223ca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionGetReqNextApprov.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// l_CurrentEmail = If
localVars.varLcl_CurrentEmail=(((localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssEmail));
while (true) {
// GetUserManager
(localVars.resGetUserManager_outParamResponse,localVars.resGetUserManager_outParamResult) = await Actions.ActionGetUserManager(requestContext,localVars.varLcl_CurrentEmail,cancellationToken);

// not IsSuccess?
if(((!localVars.resGetUserManager_outParamResult.ssIsSuccess))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("q0BdjWQr8062OpD2StU6gw#Message.510739596.1", "Error getting info from Entra."));

} else {
// Query QueryFindUserByEmail
cancellationToken.ThrowIfCancellationRequested();
int QueryFindUserByEmail_maxRecords = 0;
int QueryFindUserByEmail_startIndex = 0;(localVars.queryResFindUserByEmail_outParamList,localVars.queryResFindUserByEmail_outParamCount) = await FuncActionGetReqNextApprov.QueryFindUserByEmail(requestContext,QueryFindUserByEmail_maxRecords,QueryFindUserByEmail_startIndex,IterationMultiplicity.Never,localVars.resGetUserManager_outParamResponse.ssMail,cancellationToken);

// Reports to himself?
if(((((localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail==localVars.varLcl_CurrentEmail)||(localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail==localVars.varLcl_CurrentEmail))||(localVars.resGetUserManager_outParamResponse.ssMail==localVars.varLcl_CurrentEmail)))) {
if(((!localVars.inParami_HasStartedAccounting))) {
// ReqApprovalProcess found?
if(((localVars.inParami_ApprovalProcessId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// GetGerenteCxPandDirReg
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels = await Actions.ActionGetGerenteCxPandDirReg(requestContext,localVars.inParami_Requisition,localVars.inParami_ApprovalProcessId,cancellationToken);

// Empty?
if((localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.Empty)) {
// o_IsFinishApproval = True
result.outParamo_IsFinishApproval=true;
goto RETURN_STATEMENT;

} else {
// Foreach GetGerenteCxPandDirReg.l_RequisitionApprovalLevels
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.StartIteration();
try {while (!((localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.Eof))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.CurrentRec.ssAssignedTo,cancellationToken);

// GetGerenteCxPandDirReg.l_RequisitionApprovalLevels.Current.AssignedTo = If
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.CurrentRec.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.CurrentRec.ssAssignedTo) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// GetGerenteCxPandDirReg.l_RequisitionApprovalLevels.Current.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.CurrentRec.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_RequisitionApprovalLevels,localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.CurrentRec,cancellationToken);

localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.Advance();
}

} finally {
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.EndIteration();
}

goto RETURN_STATEMENT;

}

}

}

// o_IsFinishApproval = True
result.outParamo_IsFinishApproval=true;
goto RETURN_STATEMENT;

} else {
// ServiceEntraRoleCreate
(localVars.resServiceEntraRoleCreate_outParamo_output,localVars.resServiceEntraRoleCreate_outParamHasBeenCreated,localVars.resServiceEntraRoleCreate_outParamEntraRoleId) = await ServiceAPIs.ServiceAPIServiceEntraRoleCreate(requestContext,localVars.resGetUserManager_outParamResponse.ssJobTitle,cancellationToken);

// not IsSuccess?
if(((!localVars.resServiceEntraRoleCreate_outParamo_output.ssIsSuccess))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("kgliWpmBMk6ZDO00OCjvUQ#Message.-709613.1", "New Job Title from Entra detected. Error creating new record."));

} else {
// Manager not found?
if((localVars.queryResFindUserByEmail_outParamList.Empty)) {
// GetAppRoleFromEntraJobTitle
(localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId,localVars.resGetAppRoleFromEntraJobTitle.outParamo_RoleName) = await Actions.ActionGetAppRoleFromEntraJobTitle(requestContext,localVars.resGetUserManager_outParamResponse.ssJobTitle,3,(!localVars.inParami_HasStartedAccounting),localVars.inParami_HasStartedAccounting,cancellationToken);

// LogMessage2
await ExtendedActions.LogMessage(requestContext,("GetAppRoleFromEntraJobTitle: "+BuiltInFunction.LongIntegerToText(localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId)),"REQ",cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (((AppUtils.GetStringResource("54V4nJcIq0CMS3GrqcRPYA#Message.1701097408.1", "Next approver's role is not yet mapped to an application role.")+" ")+localVars.resGetUserManager_outParamResponse.ssJobTitle));

} else {
// o_ApplicationRoleId = GetAppRoleFromEntraJobTitle.o_ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId;
}

} else {
// GetUserRole
localVars.resGetUserRole.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserId,3,(!localVars.inParami_HasStartedAccounting),localVars.inParami_HasStartedAccounting,cancellationToken);

// LogMessage
await ExtendedActions.LogMessage(requestContext,((("GetUserRole: "+BuiltInFunction.LongIntegerToText(localVars.resGetUserRole.outParamo_ApplicationRoleId))+" | ")+localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail),"REQ",cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetUserRole.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (((AppUtils.GetStringResource("NXfqM2T4iEmfmD2xJ4rI+Q#Message.1701097408.1", "Next approver's role is not yet mapped to an application role.")+" ")+localVars.resGetUserManager_outParamResponse.ssJobTitle));

} else {
// o_ApplicationRoleId = GetUserRole.o_ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.resGetUserRole.outParamo_ApplicationRoleId;
}

}

// ReqRoleIsNeeded
(localVars.resReqRoleIsNeeded.outParamo_IsNeeded,localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel) = await Actions.ActionReqRoleIsNeeded(requestContext,localVars.inParami_Requisition,localVars.inParami_ApprovalProcessId,result.outParamo_ApplicationRoleId,localVars.inParami_HasStartedAccounting,false,cancellationToken);

// o_IsNeeded?
if((localVars.resReqRoleIsNeeded.outParamo_IsNeeded)) {
// Manager not found?
if((localVars.queryResFindUserByEmail_outParamList.Empty)) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (((((AppUtils.GetStringResource("eWrFmK3WE0ahS5ZSS6zwVA#Message.1259981447.1", "Next approver not found.")+" '")+localVars.resGetUserManager_outParamResponse.ssMail)+"' ")+AppUtils.GetStringResource("eWrFmK3WE0ahS5ZSS6zwVA#Message.1926925690.1", "has not yet logged into the application.")));

} else {
// HasActiveSubstitution2
(localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserId,cancellationToken);

// o_AssignTo = If
result.outParamo_AssignTo=(((localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserId) : (localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId));

// o_IsSubstituteFor = HasActiveSubstitution2.o_IsSubstituteFor
result.outParamo_IsSubstituteFor=localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor;
goto RETURN_STATEMENT;

}

} else {
// l_CurrentEmail = If
localVars.varLcl_CurrentEmail=((localVars.queryResFindUserByEmail_outParamList.Empty) ? (localVars.resGetUserManager_outParamResponse.ssMail) : ((((localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail!="")) ? (localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail) : (localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail))));
// ALIGN
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
outParamo_RequisitionApprovalLevels = result.outParamo_RequisitionApprovalLevels;
outParamo_IsSubstituteFor = result.outParamo_IsSubstituteFor;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_IsFinishApproval,outParamo_AssignTo,outParamo_ApplicationRoleId,outParamo_RequisitionApprovalLevels,outParamo_IsSubstituteFor);
}

public static class FuncActionGetReqNextApprov {

// Query Function "FindUserByEmail" FrgMmbPxU0K3GtdZGlKy+A of Action "GetReqNextApprov"
public static async Task<(RL_83566cec88e769363a30dc5e5b6a86f1,long)> QueryFindUserByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptei_Email,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetReqNextApprov.FindUserByEmail", "990cb816-f1b3-4253-b71a-d7591a52b2f8");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetReqNextApprov.FindUserByEmail", "990cb816-f1b3-4253-b71a-d7591a52b2f8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityUserExtension = AppUtils.Instance.RuntimeEntityReplace("UserExtension");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qptei_Email", DbType.String, qptei_Email);
string sql = "";
string advSql = "SELECT \n    u.\"id\" AS UserId, \n    u.\"email\" AS UserEmail, \n    ue.\"correspondentexternalemail\" AS ExtensionEmail \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserExtension,"") + " ue \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " u ON u.\"id\" = ue.\"id\" \nWHERE ue.\"correspondentexternalemail\" = @qptei_Email \n \nUNION ALL \n \nSELECT \n    u.\"id\" AS UserId, \n    u.\"email\" AS UserEmail, \n    NULL AS ExtensionEmail \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " u \nWHERE u.\"email\" = @qptei_Email \n \nLIMIT 1;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_83566cec88e769363a30dc5e5b6a86f1 outParamList = new RL_83566cec88e769363a30dc5e5b6a86f1();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqNextApprov.FindUserByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_83566cec88e769363a30dc5e5b6a86f1 _tmp = new RL_83566cec88e769363a30dc5e5b6a86f1();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqNextApprov.FindUserByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_83566cec88e769363a30dc5e5b6a86f1)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("FindUserByEmail in GetReqNextApprov in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("FindUserByEmail in GetReqNextApprov in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("FindUserByEmail in GetReqNextApprov in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message));
}
}
}

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserByIdReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" hOGX15n9O06yodWRl_mJ+g of Action "GetReqNextApprov"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqNextApprov.GetUserById", "d797e184-fd99-4e3b-b2a1-d59197f989fa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqNextApprov.GetUserById", "d797e184-fd99-4e3b-b2a1-d59197f989fa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hrvEsdmvgEaFW3Pl7LIjyg/NodesNotShownInESpaceTree.hOGX15n9O06yodWRl_mJ+g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuser100\".\"email\" o2, NULL o3, NULL o4, NULL o5, \"enuserextension46\".\"correspondentexternalemail\" o6, NULL o7");
fromBuilder.Append(" FROM ({User} \"enuser100\" Left JOIN {UserExtension} \"enuserextension46\" ON (\"enuser100\".\"id\" = \"enuserextension46\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser100\".\"id\" = @qpusUser_Id) AND (\"enuser100\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser100\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqNextApprov.GetUserById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqNextApprov.GetUserById.List", cancellationToken: cancellationToken);
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
