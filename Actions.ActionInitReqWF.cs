namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitReqWF : VarsBag {
public long inParami_RequisitionId;
public string inParami_CreateForUser;
public long inParamApprovalProcessId;
/// <summary>
/// Variable <code>l_CurrentEmail</code> that represents the Service Studio Text
///  <code>l_CurrentEmail</code> <p>Description: CurrentEmail</p>
/// </summary>
public string varLcl_CurrentEmail = "";

/// <summary>
/// Variable <code>l_RequisitionApproval</code> that represents the Service Studio RequisitionApproval
///  <code>l_RequisitionApproval</code> <p>Description: RequisitionApproval</p>
/// </summary>
public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord varLcl_RequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();

/// <summary>
/// Variable <code>l_RequisitionApprovalLevel</code> that represents the Service Studio
///  RequisitionApprovalLevel <code>l_RequisitionApprovalLevel</code> <p>Description
/// : RequisitionApprovalLevel</p>
/// </summary>
public EN_27b1469f497d364a764a1359956ef9adEntityRecord varLcl_RequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();

/// <summary>
/// Variable <code>l_HasStarted</code> that represents the Service Studio Boolean
///  <code>l_HasStarted</code> <p>Description: HasStarted</p>
/// </summary>
public bool varLcl_HasStarted = false;

/// <summary>
/// Variable <code>l_RequisitionApprovalLevels</code> that represents the Service Studio
///  RequisitionApprovalLevelList <code>l_RequisitionApprovalLevels</code> <p>Description
/// : RequisitionApprovalLevel List</p>
/// </summary>
public RL_75b7c1c818327cb126543d6d6a18a3c3 varLcl_RequisitionApprovalLevels = new RL_75b7c1c818327cb126543d6d6a18a3c3();

/// <summary>
/// Variable <code>l_ApplicationRoleId</code> that represents the Service Studio
///  ApplicationRoleIdentifier <code>l_ApplicationRoleId</code> <p>Description: ApplicationRol
/// e Identifier</p>
/// </summary>
public long varLcl_ApplicationRoleId = 0L;

public Actions.lcoGetUserRole resGetUserRole2 =  new Actions.lcoGetUserRole();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resEntraGetUserdata_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
public ST_d32097d2629a99529d77b865dae9fb0cStructure resEntraGetUserdata_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();

public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resEntraGetUserdata2_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
public ST_d32097d2629a99529d77b865dae9fb0cStructure resEntraGetUserdata2_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();

public Actions.lcoReqRoleIsNeeded resReqRoleIsNeeded =  new Actions.lcoReqRoleIsNeeded();
public RL_2fd4ee9249069fb78258eb73022e4cb9 queryResGetANALISTA_CXP_outParamList = new RL_2fd4ee9249069fb78258eb73022e4cb9();
public long queryResGetANALISTA_CXP_outParamCount = 0L;

public RL_83566cec88e769363a30dc5e5b6a86f1 queryResFindUserByEmail_outParamList = new RL_83566cec88e769363a30dc5e5b6a86f1();
public long queryResFindUserByEmail_outParamCount = 0L;

public Actions.lcoInitReqWF_Special resInitReqWF_Special2 =  new Actions.lcoInitReqWF_Special();
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetApplicantUserById_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetApplicantUserById_outParamCount = 0L;

public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoGetAppRoleFromEntraJobTitle resGetAppRoleFromEntraJobTitle =  new Actions.lcoGetAppRoleFromEntraJobTitle();
public Actions.lcoGetGerenteCxPandDirReg resGetGerenteCxPandDirReg =  new Actions.lcoGetGerenteCxPandDirReg();
public Actions.lcoGetApprovalProcessDef resGetApprovalProcessDef =  new Actions.lcoGetApprovalProcessDef();
public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoInitReqWF_Special resInitReqWF_Special =  new Actions.lcoInitReqWF_Special();
public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserManager_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManager_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public RL_b9a4d89a3154e989f9ae297e352963c3 queryResGetRequisitionById_outParamList = new RL_b9a4d89a3154e989f9ae297e352963c3();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoGetUserRole resGetUserRole =  new Actions.lcoGetUserRole();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public RL_324fa1265a392847ccc93fec110b2400 queryResGetUserExtendedInternalJobTitle_outParamList = new RL_324fa1265a392847ccc93fec110b2400();
public long queryResGetUserExtendedInternalJobTitle_outParamCount = 0L;

public ST_346a76e47f982dbf41625f8a893affccStructure resServiceEntraRoleCreate_outParamo_output = new ST_346a76e47f982dbf41625f8a893affccStructure();
public bool resServiceEntraRoleCreate_outParamHasBeenCreated = false;
public long resServiceEntraRoleCreate_outParamEntraRoleId = 0L;

public lcvInitReqWF(long inParami_RequisitionId, string inParami_CreateForUser, long inParamApprovalProcessId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_CreateForUser = inParami_CreateForUser;
this.inParamApprovalProcessId = inParamApprovalProcessId;
}
}
public class lcoInitReqWF : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitReqWF() {
}
}
/// <summary>
/// Action <code>InitReqWF</code> that represents the Service Studio action <code>InitReqWF</code> <p>
///  Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitReqWF(IRequestContext requestContext,long inParami_RequisitionId,string inParami_CreateForUser,long inParamApprovalProcessId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitReqWF result = new lcoInitReqWF();
lcvInitReqWF localVars = new lcvInitReqWF(inParami_RequisitionId, inParami_CreateForUser, inParamApprovalProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitReqWF", "95fdbf32-c0d0-463d-9bee-74b443bcb442"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitReqWF", "95fdbf32-c0d0-463d-9bee-74b443bcb442", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInitReqWF.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// not found?
if((localVars.queryResGetRequisitionById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Requisition not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("6ScuuOuAb0610paUVpQBaA#Value.50351344.1", "Requisition not found!");
} else {
// ApprovalProcess selected?
if(((localVars.inParamApprovalProcessId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// InitReqWF_Special2
localVars.resInitReqWF_Special2.outParamo_Output = await Actions.ActionInitReqWF_Special(requestContext,localVars.inParami_RequisitionId,localVars.inParamApprovalProcessId,localVars.inParami_CreateForUser,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// Query datasetGetUserExtendedInternalJobTitle
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
if (datasetGetUserExtendedInternalJobTitle_maxRecords < 1) datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
int datasetGetUserExtendedInternalJobTitle_startIndex = 0;(localVars.queryResGetUserExtendedInternalJobTitle_outParamList,localVars.queryResGetUserExtendedInternalJobTitle_outParamCount) = await FuncActionInitReqWF.datasetGetUserExtendedInternalJobTitle(requestContext,datasetGetUserExtendedInternalJobTitle_maxRecords,datasetGetUserExtendedInternalJobTitle_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// GetApprovalProcessDef
(localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess,localVars.resGetApprovalProcessDef.outParamo_Output) = await Actions.ActionGetApprovalProcessDef(requestContext,"REQ",localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRegionId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENDepartment.ssName,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENTelcelDirection.ssName,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssDepartmentId,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssIsDonation,true,0,false,0L,cancellationToken);

// IsSuccess
if((localVars.resGetApprovalProcessDef.outParamo_Output.ssIsSuccess)) {
// IsSpecial?
if((localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssIsSpecial)) {
// InitReqWF_Special
localVars.resInitReqWF_Special.outParamo_Output = await Actions.ActionInitReqWF_Special(requestContext,localVars.inParami_RequisitionId,localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId,"",cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
bool block2 = false;
do {
block2 = false;
bool block4 = false;
do {
block4 = false;
// Query datasetGetApplicantUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApplicantUserById_maxRecords = 1;
if (datasetGetApplicantUserById_maxRecords < 1) datasetGetApplicantUserById_maxRecords = 1;
int datasetGetApplicantUserById_startIndex = 0;(localVars.queryResGetApplicantUserById_outParamList,localVars.queryResGetApplicantUserById_outParamCount) = await FuncActionInitReqWF.datasetGetApplicantUserById(requestContext,datasetGetApplicantUserById_maxRecords,datasetGetApplicantUserById_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssApplicantId,localVars.inParami_CreateForUser,cancellationToken);

// i_CreateForUser?
if(((localVars.inParami_CreateForUser!=BuiltInFunction.NullTextIdentifier ()))) {
// Empty?
if((localVars.queryResGetApplicantUserById_outParamList.Empty)) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("+JLP6jj1kU66Z97BN956xg#Message.-302847931.1", "User selected to start the approval process not found."));

} else {
// EntraGetUserdata2
(localVars.resEntraGetUserdata2_outParamResult,localVars.resEntraGetUserdata2_outParamResponse) = await Actions.ActionGetUserByIdOrEmail(requestContext,(((localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssEmail)),cancellationToken);

// not IsSuccess?
if(((!localVars.resEntraGetUserdata2_outParamResult.ssIsSuccess))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("miyf0lnum0+FaeK6QGQ1Qw#Message.510739596.1", "Error getting info from Entra."));

} else {
// GetUserRole2
localVars.resGetUserRole2.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssId,3,true,false,cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetUserRole2.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException ((AppUtils.GetStringResource("TGb5R7+BRU2MsdCBsZmrrw#Message.-1506492575.1", "Select appover's role is not yet mapped to an application role.")+localVars.resEntraGetUserdata2_outParamResponse.ssJobTitle));

} else {
// l_RequisitionApproval
// l_RequisitionApproval.Id = NullIdentifier
localVars.varLcl_RequisitionApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApproval.RequisitionId = i_RequisitionId
localVars.varLcl_RequisitionApproval.ssRequisitionId = localVars.inParami_RequisitionId;

// l_RequisitionApproval.ProcessTypeCode = GetApprovalProcessDef.o_ApprovalProcess.ProcessTypeCode
localVars.varLcl_RequisitionApproval.ssProcessTypeCode = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssProcessTypeCode;

// l_RequisitionApproval.ApprovalProcessVersion = GetApprovalProcessDef.o_ApprovalProcess.Version
localVars.varLcl_RequisitionApproval.ssApprovalProcessVersion = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssVersion;

// l_RequisitionApproval.CurrentLevel = 0
localVars.varLcl_RequisitionApproval.ssCurrentLevel = 0;

// l_RequisitionApproval.StartedOn = CurrDateTime
localVars.varLcl_RequisitionApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_RequisitionApproval.HasStartedAccounting = False
localVars.varLcl_RequisitionApproval.ssHasStartedAccounting = false;

// l_RequisitionApproval.AprovalProcessId = GetApprovalProcessDef.o_ApprovalProcess.ApprovalProcessId
localVars.varLcl_RequisitionApproval.ssAprovalProcessId = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId;
// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel.Id = NullIdentifier
localVars.varLcl_RequisitionApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApprovalLevel.LevelNumber = 0
localVars.varLcl_RequisitionApprovalLevel.ssLevelNumber = 0;

// l_RequisitionApprovalLevel.ApplicationRoleId = GetUserRole2.o_ApplicationRoleId
localVars.varLcl_RequisitionApprovalLevel.ssApplicationRoleId = localVars.resGetUserRole2.outParamo_ApplicationRoleId;

// l_RequisitionApprovalLevel.AssignedTo = GetApplicantUserById.List.Current.User.Id
localVars.varLcl_RequisitionApprovalLevel.ssAssignedTo = localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssId;

// l_RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_RequisitionApprovalLevel.IsAccounting = False
localVars.varLcl_RequisitionApprovalLevel.ssIsAccounting = false;

// l_RequisitionApprovalLevel.IsStartAccounting = False
localVars.varLcl_RequisitionApprovalLevel.ssIsStartAccounting = false;
}

}

}

} else {
// l_CurrentEmail = If
localVars.varLcl_CurrentEmail=(((localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssEmail));
bool flagContinueTo_forEach = false;
while (true) {
flagContinueTo_forEach = false;
// GetUserManager
(localVars.resGetUserManager_outParamResponse,localVars.resGetUserManager_outParamResult) = await Actions.ActionGetUserManager(requestContext,localVars.varLcl_CurrentEmail,cancellationToken);

// not IsSuccess?
if(((!localVars.resGetUserManager_outParamResult.ssIsSuccess))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("pPvuIyQpDUmXEkFk0FsyqA#Message.510739596.1", "Error getting info from Entra."));

} else {
bool block3 = false;
do {
block3 = false;
bool block1 = false;
do {
block1 = false;
do {
// Query QueryFindUserByEmail
cancellationToken.ThrowIfCancellationRequested();
int QueryFindUserByEmail_maxRecords = 0;
int QueryFindUserByEmail_startIndex = 0;(localVars.queryResFindUserByEmail_outParamList,localVars.queryResFindUserByEmail_outParamCount) = await FuncActionInitReqWF.QueryFindUserByEmail(requestContext,QueryFindUserByEmail_maxRecords,QueryFindUserByEmail_startIndex,IterationMultiplicity.Never,localVars.resGetUserManager_outParamResponse.ssMail,cancellationToken);

// First Manager not found?
if((localVars.queryResFindUserByEmail_outParamList.Empty)) {
// EntraGetUserdata
(localVars.resEntraGetUserdata_outParamResult,localVars.resEntraGetUserdata_outParamResponse) = await Actions.ActionGetUserByIdOrEmail(requestContext,localVars.resGetUserManager_outParamResponse.ssMail,cancellationToken);

// not IsSuccess?
if(((!localVars.resEntraGetUserdata_outParamResult.ssIsSuccess))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("NXP6dxSBl0OZTYkopv5xMA#Message.510739596.1", "Error getting info from Entra."));

} else {
// Reports to himself?
if(((localVars.resEntraGetUserdata_outParamResponse.ssMail==localVars.varLcl_CurrentEmail))) {
break;
}

}

} else {
// ServiceEntraRoleCreate
(localVars.resServiceEntraRoleCreate_outParamo_output,localVars.resServiceEntraRoleCreate_outParamHasBeenCreated,localVars.resServiceEntraRoleCreate_outParamEntraRoleId) = await ServiceAPIs.ServiceAPIServiceEntraRoleCreate(requestContext,localVars.resGetUserManager_outParamResponse.ssJobTitle,cancellationToken);

// not IsSuccess?
if(((!localVars.resServiceEntraRoleCreate_outParamo_output.ssIsSuccess))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("W1xdtnE_dEqFwBjjK64HRQ#Message.-709613.1", "New Job Title from Entra detected. Error creating new record."));

} else {
// Reports to himself?
if(((((localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail==localVars.varLcl_CurrentEmail)||(localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail==localVars.varLcl_CurrentEmail))||(localVars.resGetUserManager_outParamResponse.ssMail==localVars.varLcl_CurrentEmail)))) {
break;
} else {
// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

// LogMessage3
await ExtendedActions.LogMessage(requestContext,((((((localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserId+" | ")+localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail)+" | ")+localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserId)+" | ")+localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail),"REQ",cancellationToken);

}

}

}

// Manager not found?
if((localVars.queryResFindUserByEmail_outParamList.Empty)) {
// GetAppRoleFromEntraJobTitle
(localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId,localVars.resGetAppRoleFromEntraJobTitle.outParamo_RoleName) = await Actions.ActionGetAppRoleFromEntraJobTitle(requestContext,localVars.resGetUserManager_outParamResponse.ssJobTitle,3,true,false,cancellationToken);

// LogMessage2
await ExtendedActions.LogMessage(requestContext,("GetAppRoleFromEntraJobTitle: "+BuiltInFunction.LongIntegerToText(localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId)),"REQ",cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (((AppUtils.GetStringResource("4HJJ8zZLfEWKpSEhQz6x2w#Message.1701097408.1", "Next approver's role is not yet mapped to an application role.")+" ")+localVars.resGetUserManager_outParamResponse.ssJobTitle));

} else {
// l_ApplicationRoleId = GetAppRoleFromEntraJobTitle.o_ApplicationRoleId
localVars.varLcl_ApplicationRoleId=localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId;
// jump to block1
block1 = true;
break;
}

} else {
// GetUserRole
localVars.resGetUserRole.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserId,3,true,false,cancellationToken);

// LogMessage
await ExtendedActions.LogMessage(requestContext,((("GetUserRole: "+BuiltInFunction.LongIntegerToText(localVars.resGetUserRole.outParamo_ApplicationRoleId))+" | ")+localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail),"REQ",cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetUserRole.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (((AppUtils.GetStringResource("jdOBgiuEaEWiQooC4+GrdA#Message.1701097408.1", "Next approver's role is not yet mapped to an application role.")+" ")+localVars.resGetUserManager_outParamResponse.ssJobTitle));

} else {
// l_ApplicationRoleId = GetUserRole.o_ApplicationRoleId
localVars.varLcl_ApplicationRoleId=localVars.resGetUserRole.outParamo_ApplicationRoleId;
// jump to block1
block1 = true;
break;
}

}

} while(false)
;
if(block1) {
break;
}

// ReqApprovalProcess found?
if(((localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// GetGerenteCxPandDirReg
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels = await Actions.ActionGetGerenteCxPandDirReg(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition,localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId,cancellationToken);

// Empty?
if((localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.Empty)) {
// jump to block3
block3 = true;
break;
} else {
// Foreach GetGerenteCxPandDirReg.l_RequisitionApprovalLevels
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.StartIteration();
try {while (!((localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.Eof))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_RequisitionApprovalLevels,localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.CurrentRec,cancellationToken);

localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.Advance();
}

} finally {
localVars.resGetGerenteCxPandDirReg.outParaml_RequisitionApprovalLevels.EndIteration();
}

// l_RequisitionApproval
// l_RequisitionApproval.Id = NullIdentifier
localVars.varLcl_RequisitionApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApproval.RequisitionId = i_RequisitionId
localVars.varLcl_RequisitionApproval.ssRequisitionId = localVars.inParami_RequisitionId;

// l_RequisitionApproval.ProcessTypeCode = GetApprovalProcessDef.o_ApprovalProcess.ProcessTypeCode
localVars.varLcl_RequisitionApproval.ssProcessTypeCode = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssProcessTypeCode;

// l_RequisitionApproval.ApprovalProcessVersion = GetApprovalProcessDef.o_ApprovalProcess.Version
localVars.varLcl_RequisitionApproval.ssApprovalProcessVersion = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssVersion;

// l_RequisitionApproval.CurrentLevel = 0
localVars.varLcl_RequisitionApproval.ssCurrentLevel = 0;

// l_RequisitionApproval.StartedOn = CurrDateTime
localVars.varLcl_RequisitionApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_RequisitionApproval.HasStartedAccounting = False
localVars.varLcl_RequisitionApproval.ssHasStartedAccounting = false;

// l_RequisitionApproval.AprovalProcessId = IdentifierToLongInteger
localVars.varLcl_RequisitionApproval.ssAprovalProcessId = BuiltInFunction.IdentifierToLongInteger (localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId);
// jump to block2
block2 = true;
break;
}

} else {
// jump to block3
block3 = true;
break;
}

} while(false)
;
if((block2 || block3)) {
break;
}

// ReqRoleIsNeeded
(localVars.resReqRoleIsNeeded.outParamo_IsNeeded,localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel) = await Actions.ActionReqRoleIsNeeded(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition,localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId,localVars.varLcl_ApplicationRoleId,false,false,cancellationToken);

// o_IsNeeded?
if((localVars.resReqRoleIsNeeded.outParamo_IsNeeded)) {
// Manager not found?
if((localVars.queryResFindUserByEmail_outParamList.Empty)) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (((((AppUtils.GetStringResource("j3qHlyJFhEOSIMrfvTxEMQ#Message.1259981447.1", "Next approver not found.")+" '")+localVars.resGetUserManager_outParamResponse.ssMail)+"' ")+AppUtils.GetStringResource("j3qHlyJFhEOSIMrfvTxEMQ#Message.1926925690.1", "has not yet logged into the application.")));

} else {
// l_RequisitionApproval
// l_RequisitionApproval.Id = NullIdentifier
localVars.varLcl_RequisitionApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApproval.RequisitionId = i_RequisitionId
localVars.varLcl_RequisitionApproval.ssRequisitionId = localVars.inParami_RequisitionId;

// l_RequisitionApproval.ProcessTypeCode = GetApprovalProcessDef.o_ApprovalProcess.ProcessTypeCode
localVars.varLcl_RequisitionApproval.ssProcessTypeCode = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssProcessTypeCode;

// l_RequisitionApproval.ApprovalProcessVersion = GetApprovalProcessDef.o_ApprovalProcess.Version
localVars.varLcl_RequisitionApproval.ssApprovalProcessVersion = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssVersion;

// l_RequisitionApproval.CurrentLevel = 0
localVars.varLcl_RequisitionApproval.ssCurrentLevel = 0;

// l_RequisitionApproval.StartedOn = CurrDateTime
localVars.varLcl_RequisitionApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_RequisitionApproval.HasStartedAccounting = False
localVars.varLcl_RequisitionApproval.ssHasStartedAccounting = false;

// l_RequisitionApproval.AprovalProcessId = IdentifierToLongInteger
localVars.varLcl_RequisitionApproval.ssAprovalProcessId = BuiltInFunction.IdentifierToLongInteger (localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId);
// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel.Id = NullIdentifier
localVars.varLcl_RequisitionApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApprovalLevel.LevelNumber = 0
localVars.varLcl_RequisitionApprovalLevel.ssLevelNumber = 0;

// l_RequisitionApprovalLevel.ApplicationRoleId = l_ApplicationRoleId
localVars.varLcl_RequisitionApprovalLevel.ssApplicationRoleId = localVars.varLcl_ApplicationRoleId;

// l_RequisitionApprovalLevel.AssignedTo = FindUserByEmail.List.Current.FindUserByEmail.UserId
localVars.varLcl_RequisitionApprovalLevel.ssAssignedTo = localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserId;

// l_RequisitionApprovalLevel.NeedsContract = ReqRoleIsNeeded.o_ApprovalProcessLevel.NeedsContract
localVars.varLcl_RequisitionApprovalLevel.ssNeedsContract = localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel.ssNeedsContract;

// l_RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_RequisitionApprovalLevel.IsAccounting = False
localVars.varLcl_RequisitionApprovalLevel.ssIsAccounting = false;

// l_RequisitionApprovalLevel.IsStartAccounting = False
localVars.varLcl_RequisitionApprovalLevel.ssIsStartAccounting = false;

// l_RequisitionApprovalLevel.ApproveAsAreaUsuaria = ReqRoleIsNeeded.o_ApprovalProcessLevel.NeedsContract or ReqRoleIsNeeded.o_ApprovalProcessLevel.NeedsProofOfForeignResidence and notReqRoleIsNeeded.o_ApprovalProcessLevel.IsAccounting_DEPREC
localVars.varLcl_RequisitionApprovalLevel.ssApproveAsAreaUsuaria = (localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel.ssNeedsContract||(localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel.ssNeedsProofOfForeignResidence&&(!localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel.ssIsAccounting_DEPREC)));
// jump to block4
block4 = true;
break;
}

} else {
// l_CurrentEmail = If
localVars.varLcl_CurrentEmail=((localVars.queryResFindUserByEmail_outParamList.Empty) ? (localVars.resGetUserManager_outParamResponse.ssMail) : ((((localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail!="")) ? (localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail) : (localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail))));
// ALIGN
// continue to flagContinueTo_forEach
flagContinueTo_forEach = true;
break;
}

} while(false)
;
if((block2 || block4)) {
break;
}

if(flagContinueTo_forEach) {
continue;
}

// l_RequisitionApproval
// l_RequisitionApproval.Id = NullIdentifier
localVars.varLcl_RequisitionApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApproval.RequisitionId = i_RequisitionId
localVars.varLcl_RequisitionApproval.ssRequisitionId = localVars.inParami_RequisitionId;

// l_RequisitionApproval.ProcessTypeCode = GetApprovalProcessDef.o_ApprovalProcess.ProcessTypeCode
localVars.varLcl_RequisitionApproval.ssProcessTypeCode = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssProcessTypeCode;

// l_RequisitionApproval.ApprovalProcessVersion = GetApprovalProcessDef.o_ApprovalProcess.Version
localVars.varLcl_RequisitionApproval.ssApprovalProcessVersion = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssVersion;

// l_RequisitionApproval.CurrentLevel = 0
localVars.varLcl_RequisitionApproval.ssCurrentLevel = 0;

// l_RequisitionApproval.StartedOn = CurrDateTime
localVars.varLcl_RequisitionApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_RequisitionApproval.HasStartedAccounting = True
localVars.varLcl_RequisitionApproval.ssHasStartedAccounting = true;

// l_RequisitionApproval.AprovalProcessId = IdentifierToLongInteger
localVars.varLcl_RequisitionApproval.ssAprovalProcessId = BuiltInFunction.IdentifierToLongInteger (localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId);
// Query datasetGetANALISTA_CXP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetANALISTA_CXP_maxRecords = 1;
if (datasetGetANALISTA_CXP_maxRecords < 1) datasetGetANALISTA_CXP_maxRecords = 1;
int datasetGetANALISTA_CXP_startIndex = 0;(localVars.queryResGetANALISTA_CXP_outParamList,localVars.queryResGetANALISTA_CXP_outParamCount) = await FuncActionInitReqWF.datasetGetANALISTA_CXP(requestContext,datasetGetANALISTA_CXP_maxRecords,datasetGetANALISTA_CXP_startIndex,IterationMultiplicity.Never,cancellationToken);

// Empty?
if((localVars.queryResGetANALISTA_CXP_outParamList.Empty)) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("UVJRhVsfnUGDa7_lZgkQmA#Message.2138269536.1", "ANALISTA_CXP - Analista CxP/Egresos role has not yet been created."));

} else {
// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel.Id = NullIdentifier
localVars.varLcl_RequisitionApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApprovalLevel.LevelNumber = 0
localVars.varLcl_RequisitionApprovalLevel.ssLevelNumber = 0;

// l_RequisitionApprovalLevel.ApplicationRoleId = GetANALISTA_CXP.List.Current.ApplicationRole.Id
localVars.varLcl_RequisitionApprovalLevel.ssApplicationRoleId = localVars.queryResGetANALISTA_CXP_outParamList.CurrentRec.ssENApplicationRole.ssId;

// l_RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_RequisitionApprovalLevel.IsAccounting = True
localVars.varLcl_RequisitionApprovalLevel.ssIsAccounting = true;

// l_RequisitionApprovalLevel.IsStartAccounting = True
localVars.varLcl_RequisitionApprovalLevel.ssIsStartAccounting = true;
// InitReqWF_CxP
await Actions.ActionInitReqWF_CxP(requestContext,localVars.inParami_RequisitionId,cancellationToken);

// jump to block4
block4 = true;
break;
}

}

}

if((block2 || block4)) {
break;
}

goto RETURN_STATEMENT;

}

} while(false)
;
if(block2) {
break;
}

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_RequisitionApprovalLevels,localVars.varLcl_RequisitionApprovalLevel,cancellationToken);

} while(false)
;
// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.varLcl_RequisitionApproval,cancellationToken);

// Foreach l_RequisitionApprovalLevels
localVars.varLcl_RequisitionApprovalLevels.StartIteration();
try {while (!((localVars.varLcl_RequisitionApprovalLevels.Eof))) {
// l_RequisitionApprovalLevels.Current.RequisitionApprovalId = RequisitionApprovalCreateOrUpdate.Id
localVars.varLcl_RequisitionApprovalLevels.CurrentRec.ssRequisitionApprovalId = localVars.resRequisitionApprovalCreateOrUpdate.outParamId;

// l_RequisitionApprovalLevels.Current.ApprovalStatusId = If
localVars.varLcl_RequisitionApprovalLevels.CurrentRec.ssApprovalStatusId = (((!localVars.varLcl_HasStarted)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId));
if(((!localVars.varLcl_HasStarted))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.varLcl_RequisitionApprovalLevels.CurrentRec.ssAssignedTo,cancellationToken);

// l_RequisitionApprovalLevels.Current.AssignedTo = If
localVars.varLcl_RequisitionApprovalLevels.CurrentRec.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.varLcl_RequisitionApprovalLevels.CurrentRec.ssAssignedTo) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// l_RequisitionApprovalLevels.Current.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.varLcl_RequisitionApprovalLevels.CurrentRec.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
}

// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_RequisitionApprovalLevels.CurrentRec,cancellationToken);

// l_HasStarted = True
localVars.varLcl_HasStarted=true;
localVars.varLcl_RequisitionApprovalLevels.Advance();
}

} finally {
localVars.varLcl_RequisitionApprovalLevels.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} else {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (localVars.resGetApprovalProcessDef.outParamo_Output.ssMessage);

}

}

}

} //close CreateActionActivity using block
} // try

catch (Ex_InitializeWFUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = InitializeWF.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInitReqWF {

// Query Function "GetANALISTA_CXP" 4N8XQrQtCkyvOqbYe9DAXQ of Action "InitReqWF"
public static async Task<(RL_2fd4ee9249069fb78258eb73022e4cb9,long)> datasetGetANALISTA_CXP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF.GetANALISTA_CXP", "4217dfe0-2db4-4c0a-af3a-a6d87bd0c05d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF.GetANALISTA_CXP", "4217dfe0-2db4-4c0a-af3a-a6d87bd0c05d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mr_9ldDAPUab7nS0Q7y0Qg/NodesNotShownInESpaceTree.4N8XQrQtCkyvOqbYe9DAXQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole18\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {ApplicationRole} \"enapplicationrole18\"");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper(\"enapplicationrole18\".\"code\")) collate \"default\") like caseaccent_normalize('ANALISTA_CXP' collate \"default\"))");
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
RL_2fd4ee9249069fb78258eb73022e4cb9 outParamList = new RL_2fd4ee9249069fb78258eb73022e4cb9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2fd4ee9249069fb78258eb73022e4cb9 _tmp = new RL_2fd4ee9249069fb78258eb73022e4cb9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2fd4ee9249069fb78258eb73022e4cb9)_tmp;
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

// Query Function "FindUserByEmail" obFjR6b8QU+WKcgs_qDSVA of Action "InitReqWF"
public static async Task<(RL_83566cec88e769363a30dc5e5b6a86f1,long)> QueryFindUserByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptei_Email,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("InitReqWF.FindUserByEmail", "4763b1a1-fca6-4f41-9629-c82cfea0d254");
using var queryActivity = activitySource.CreateSqlQueryActivity("InitReqWF.FindUserByEmail", "4763b1a1-fca6-4f41-9629-c82cfea0d254", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF.FindUserByEmail.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF.FindUserByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_83566cec88e769363a30dc5e5b6a86f1)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("FindUserByEmail in InitReqWF in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("FindUserByEmail in InitReqWF in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("FindUserByEmail in InitReqWF in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message));
}
}
}

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetApplicantUserByIdReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetApplicantUserById" 5Q+NbwEiIEWvg1cKG9QlcQ of Action "InitReqWF"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetApplicantUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,string qpusUser_Id1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF.GetApplicantUserById", "6f8d0fe5-2201-4520-af83-570a1bd42571");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF.GetApplicantUserById", "6f8d0fe5-2201-4520-af83-570a1bd42571", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mr_9ldDAPUab7nS0Q7y0Qg/NodesNotShownInESpaceTree.5Q+NbwEiIEWvg1cKG9QlcQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser92\".\"id\" o0, NULL o1, \"enuser92\".\"email\" o2, NULL o3, NULL o4, NULL o5, \"enuserextension44\".\"correspondentexternalemail\" o6, NULL o7");
fromBuilder.Append(" FROM ({User} \"enuser92\" Left JOIN {UserExtension} \"enuserextension44\" ON (\"enuser92\".\"id\" = \"enuserextension44\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpusUser_Id <> '') THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id1);
if ((qpusUser_Id1.Trim()!="")) {
whereBuilder.Append("((\"enuser92\".\"id\" = @qpusUser_Id) AND (\"enuser92\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id1);
} else {
whereBuilder.Append("(\"enuser92\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser92\".\"id\" = @qpusUser_Id1) AND (\"enuser92\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id1", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser92\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetApplicantUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF.GetApplicantUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetApplicantUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF.GetApplicantUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_4b3e229d9fe6ec886da8c5cf0d4be972> datasetGetRequisitionByIdReadDbAsync(RC_4b3e229d9fe6ec886da8c5cf0d4be972 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" iFfs07rrvkiCYdSZWgLz7Q of Action "InitReqWF"
public static async Task<(RL_b9a4d89a3154e989f9ae297e352963c3,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF.GetRequisitionById", "d3ec5788-ebba-48be-8261-d4995a02f3ed");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF.GetRequisitionById", "d3ec5788-ebba-48be-8261-d4995a02f3ed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mr_9ldDAPUab7nS0Q7y0Qg/NodesNotShownInESpaceTree.iFfs07rrvkiCYdSZWgLz7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enrequisition39\".\"id\" o13, \"enrequisition39\".\"name\" o14, \"enrequisition39\".\"counter\" o15, \"enrequisition39\".\"requisitionstatusid\" o16, \"enrequisition39\".\"supplierid\" o17, \"enrequisition39\".\"regionid\" o18, \"enrequisition39\".\"accountingregionid\" o19, \"enrequisition39\".\"applicantid\" o20, \"enrequisition39\".\"maxdatefinishcapture\" o21, \"enrequisition39\".\"projectassetserviceid\" o22, \"enrequisition39\".\"projectassetservice\" o23, \"enrequisition39\".\"projectdescription\" o24, \"enrequisition39\".\"frequencyid\" o25, \"enrequisition39\".\"issustainability\" o26, \"enrequisition39\".\"sustainabilityid\" o27, \"enrequisition39\".\"businessvaluecategoryid\" o28, \"enrequisition39\".\"businessvaluesubcategoryid\" o29, trim_scale(\"enrequisition39\".\"totalamount\"::numeric) o30, \"enrequisition39\".\"currencyid\" o31, \"enrequisition39\".\"distributionid\" o32, \"enrequisition39\".\"costcenterid\" o33, \"enrequisition39\".\"hascontract\" o34, \"enrequisition39\".\"iscontractpending\" o35, \"enrequisition39\".\"hasdeposit\" o36, \"enrequisition39\".\"hasinsurance\" o37, \"enrequisition39\".\"hasadvancepayment\" o38, \"enrequisition39\".\"accountingservicetypeid_depr\" o39, \"enrequisition39\".\"servicedescription_deprec\" o40, \"enrequisition39\".\"invoiceusageid_deprec\" o41, \"enrequisition39\".\"serviceformatid\" o42, \"enrequisition39\".\"companyid\" o43, trim_scale(\"enrequisition39\".\"retentionrate\"::numeric) o44, trim_scale(\"enrequisition39\".\"negotiatedexchangerate\"::numeric) o45, \"enrequisition39\".\"paymentmethodid\" o46, \"enrequisition39\".\"paymenttermsid\" o47, \"enrequisition39\".\"isautomaticaccounting\" o48, \"enrequisition39\".\"createdby\" o49, \"enrequisition39\".\"createdon\" o50, \"enrequisition39\".\"updatedon\" o51, \"enrequisition39\".\"updatedby\" o52, \"enrequisition39\".\"createdbyapplicationrole\" o53, \"enrequisition39\".\"dateofcommitment\" o54, \"enrequisition39\".\"hascontractfileuploaded\" o55, \"enrequisition39\".\"hasupdateddateofcommitment\" o56, \"enrequisition39\".\"submittedon\" o57, \"enrequisition39\".\"isdonation\" o58, \"enrequisition39\".\"advwithoutinvoice\" o59, \"enrequisition39\".\"wasadvwithoutinvoice\" o60, \"enrequisition39\".\"isadvanced\" o61, \"enrequisition39\".\"documenttypeid\" o62, \"enrequisition39\".\"iscreatedbyanassistente\" o63, \"enrequisition39\".\"telceldirectionid\" o64, \"enrequisition39\".\"hasmultiupload\" o65, \"enrequisition39\".\"accountingdate\" o66, \"enrequisition39\".\"paymentoptionsid\" o67, \"enrequisition39\".\"paymentwaysid\" o68, \"enrequisition39\".\"buydocnumber\" o69, \"enrequisition39\".\"buydocposition\" o70");
fromBuilder.Append(" FROM ({Requisition} \"enrequisition39\" Left JOIN {Region} \"enregion39\" ON (\"enrequisition39\".\"regionid\" = \"enregion39\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition39\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition39\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition39\".\"id\" IS NULL)");
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
RL_b9a4d89a3154e989f9ae297e352963c3 outParamList = new RL_b9a4d89a3154e989f9ae297e352963c3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b9a4d89a3154e989f9ae297e352963c3 _tmp = new RL_b9a4d89a3154e989f9ae297e352963c3();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b9a4d89a3154e989f9ae297e352963c3)_tmp;
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

private static async Task<RC_e7c96643ac320a01471372d3fdec9c1e> datasetGetUserExtendedInternalJobTitleReadDbAsync(RC_e7c96643ac320a01471372d3fdec9c1e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDepartment.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalJobTitle" JZum+E2DwEeO7uNquLJbPQ of Action "InitReqWF"
public static async Task<(RL_324fa1265a392847ccc93fec110b2400,long)> datasetGetUserExtendedInternalJobTitle(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF.GetUserExtendedInternalJobTitle", "f8a69b25-834d-47c0-8eee-e36ab8b25b3d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF.GetUserExtendedInternalJobTitle", "f8a69b25-834d-47c0-8eee-e36ab8b25b3d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mr_9ldDAPUab7nS0Q7y0Qg/NodesNotShownInESpaceTree.JZum+E2DwEeO7uNquLJbPQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"endepartment6\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"entelceldirection9\".\"name\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enuser_extended_internal57\".\"departmentid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enuser_extended_internal57\".\"entraroleid\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal57\" Inner JOIN {User} \"enuser93\" ON (\"enuser_extended_internal57\".\"id\" = \"enuser93\".\"id\"))  Left JOIN {Department} \"endepartment6\" ON (\"enuser_extended_internal57\".\"departmentid\" = \"endepartment6\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection9\" ON (\"enuser_extended_internal57\".\"telceldirectionid\" = \"entelceldirection9\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser93\".\"id\" = @qpusUser_Id) AND (\"enuser93\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser93\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuser93\".\"name\" ASC ");
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
RL_324fa1265a392847ccc93fec110b2400 outParamList = new RL_324fa1265a392847ccc93fec110b2400();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_324fa1265a392847ccc93fec110b2400 _tmp = new RL_324fa1265a392847ccc93fec110b2400();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_324fa1265a392847ccc93fec110b2400)_tmp;
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
