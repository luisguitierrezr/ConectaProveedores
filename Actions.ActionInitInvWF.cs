namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitInvWF : VarsBag {
public long inParami_InvoiceId;
public string inParami_CreateForUser;
/// <summary>
/// Variable <code>l_CurrentEmail</code> that represents the Service Studio Text
///  <code>l_CurrentEmail</code> <p>Description: CurrentEmail</p>
/// </summary>
public string varLcl_CurrentEmail = "";

/// <summary>
/// Variable <code>l_InvoiceApproval</code> that represents the Service Studio InvoiceApproval
///  <code>l_InvoiceApproval</code> <p>Description: InvoiceApproval</p>
/// </summary>
public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord varLcl_InvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();

/// <summary>
/// Variable <code>l_InvoiceApprovalLevel</code> that represents the Service Studio
///  InvoiceApprovalLevel <code>l_InvoiceApprovalLevel</code> <p>Description: InvoiceApprovalLevel</p>
/// </summary>
public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord varLcl_InvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();

/// <summary>
/// Variable <code>l_HasStarted</code> that represents the Service Studio Boolean
///  <code>l_HasStarted</code> <p>Description: HasStarted</p>
/// </summary>
public bool varLcl_HasStarted = false;

/// <summary>
/// Variable <code>l_InvoiceApprovalLevels</code> that represents the Service Studio
///  InvoiceApprovalLevelList <code>l_InvoiceApprovalLevels</code> <p>Description: InvoiceApprovalLeve
/// l List</p>
/// </summary>
public RL_ceb6b480297e13460f270b15b86cd978 varLcl_InvoiceApprovalLevels = new RL_ceb6b480297e13460f270b15b86cd978();

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd2 =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInitInvWF_Special resInitInvWF_Special =  new Actions.lcoInitInvWF_Special();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoGetApprovalProcessDef resGetApprovalProcessDef =  new Actions.lcoGetApprovalProcessDef();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public Actions.lcoCheckApplicantApprovalIsNeeded resCheckApplicantApprovalIsNeeded =  new Actions.lcoCheckApplicantApprovalIsNeeded();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resEntraGetUserdata2_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
public ST_d32097d2629a99529d77b865dae9fb0cStructure resEntraGetUserdata2_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();

public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public RL_324fa1265a392847ccc93fec110b2400 queryResGetUserExtendedInternalJobTitle_outParamList = new RL_324fa1265a392847ccc93fec110b2400();
public long queryResGetUserExtendedInternalJobTitle_outParamCount = 0L;

public Actions.lcoGetUserRole resGetUserRole2 =  new Actions.lcoGetUserRole();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate2 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public RL_c851528f2bd72df8d6fa01fc1d7dda59 queryResGetInvoiceById_outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate2 =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetApplicantUserById_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetApplicantUserById_outParamCount = 0L;

public RL_eb30c26c3067f3944a588d50f5676332 queryResGetRequisitionApprovalIsSpecial_outParamList = new RL_eb30c26c3067f3944a588d50f5676332();
public long queryResGetRequisitionApprovalIsSpecial_outParamCount = 0L;

public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public lcvInitInvWF(long inParami_InvoiceId, string inParami_CreateForUser) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_CreateForUser = inParami_CreateForUser;
}
}
public class lcoInitInvWF : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitInvWF() {
}
}
/// <summary>
/// Action <code>InitInvWF</code> that represents the Service Studio action <code>InitInvWF</code> <p>
///  Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitInvWF(IRequestContext requestContext,long inParami_InvoiceId,string inParami_CreateForUser,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitInvWF result = new lcoInitInvWF();
lcvInitInvWF localVars = new lcvInitInvWF(inParami_InvoiceId, inParami_CreateForUser);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitInvWF", "e8feae7c-f34a-448a-8e97-d7d530e79c6d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitInvWF", "e8feae7c-f34a-448a-8e97-d7d530e79c6d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInitInvWF.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// not found?
if((localVars.queryResGetInvoiceById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Invoice not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("GQW7loUqVEKwZWKqhRAMnA#Value.-793651777.1", "Invoice not found!");
} else {
// ClearInvoiceApproval
await Actions.ActionClearInvoiceApproval(requestContext,localVars.inParami_InvoiceId,cancellationToken);

// Query datasetGetUserExtendedInternalJobTitle
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
if (datasetGetUserExtendedInternalJobTitle_maxRecords < 1) datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
int datasetGetUserExtendedInternalJobTitle_startIndex = 0;(localVars.queryResGetUserExtendedInternalJobTitle_outParamList,localVars.queryResGetUserExtendedInternalJobTitle_outParamCount) = await FuncActionInitInvWF.datasetGetUserExtendedInternalJobTitle(requestContext,datasetGetUserExtendedInternalJobTitle_maxRecords,datasetGetUserExtendedInternalJobTitle_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssApplicantId,cancellationToken);

// Query datasetGetRequisitionApprovalIsSpecial
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalIsSpecial_maxRecords = 1;
if (datasetGetRequisitionApprovalIsSpecial_maxRecords < 1) datasetGetRequisitionApprovalIsSpecial_maxRecords = 1;
int datasetGetRequisitionApprovalIsSpecial_startIndex = 0;(localVars.queryResGetRequisitionApprovalIsSpecial_outParamList,localVars.queryResGetRequisitionApprovalIsSpecial_outParamCount) = await FuncActionInitInvWF.datasetGetRequisitionApprovalIsSpecial(requestContext,datasetGetRequisitionApprovalIsSpecial_maxRecords,datasetGetRequisitionApprovalIsSpecial_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId,cancellationToken);

// GetApprovalProcessDef
(localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess,localVars.resGetApprovalProcessDef.outParamo_Output) = await Actions.ActionGetApprovalProcessDef(requestContext,"FSP",localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssRegionId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENDepartment.ssName,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENTelcelDirection.ssName,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssDepartmentId,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsDonation,false,0,localVars.queryResGetRequisitionApprovalIsSpecial_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial,localVars.queryResGetRequisitionApprovalIsSpecial_outParamList.CurrentRec.ssENApprovalProcess.ssSpecialWorkflowId,cancellationToken);

// IsSuccess
if((localVars.resGetApprovalProcessDef.outParamo_Output.ssIsSuccess)) {
// IsSpecial?
if((localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssIsSpecial)) {
// InitInvWF_Special
localVars.resInitInvWF_Special.outParamo_Output = await Actions.ActionInitInvWF_Special(requestContext,localVars.inParami_InvoiceId,localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// Query datasetGetApplicantUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApplicantUserById_maxRecords = 1;
if (datasetGetApplicantUserById_maxRecords < 1) datasetGetApplicantUserById_maxRecords = 1;
int datasetGetApplicantUserById_startIndex = 0;(localVars.queryResGetApplicantUserById_outParamList,localVars.queryResGetApplicantUserById_outParamCount) = await FuncActionInitInvWF.datasetGetApplicantUserById(requestContext,datasetGetApplicantUserById_maxRecords,datasetGetApplicantUserById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssApplicantId,localVars.inParami_CreateForUser,cancellationToken);

// i_CreateForUser?
if(((localVars.inParami_CreateForUser!=BuiltInFunction.NullTextIdentifier ()))) {
// Empty?
if((localVars.queryResGetApplicantUserById_outParamList.Empty)) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("DGMn33aLeUGWVvnDPYfZLA#Message.-302847931.1", "User selected to start the approval process not found."));

} else {
// EntraGetUserdata2
(localVars.resEntraGetUserdata2_outParamResult,localVars.resEntraGetUserdata2_outParamResponse) = await Actions.ActionGetUserByIdOrEmail(requestContext,(((localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssEmail)),cancellationToken);

// not IsSuccess?
if(((!localVars.resEntraGetUserdata2_outParamResult.ssIsSuccess))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("dClDwohUoUi+YgNOP_fUmw#Message.510739596.1", "Error getting info from Entra."));

} else {
// GetUserRole2
localVars.resGetUserRole2.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssId,3,true,false,cancellationToken);

// Next approver role not mapped?
if(((localVars.resGetUserRole2.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException ((AppUtils.GetStringResource("IMqtVB_olkKFp+PozcWeow#Message.-1506492575.1", "Select appover's role is not yet mapped to an application role.")+localVars.resEntraGetUserdata2_outParamResponse.ssJobTitle));

} else {
// l_InvoiceApproval
// l_InvoiceApproval.Id = NullIdentifier
localVars.varLcl_InvoiceApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_InvoiceApproval.InvoiceId = i_InvoiceId
localVars.varLcl_InvoiceApproval.ssInvoiceId = localVars.inParami_InvoiceId;

// l_InvoiceApproval.ProcessTypeCode = GetApprovalProcessDef.o_ApprovalProcess.ProcessTypeCode
localVars.varLcl_InvoiceApproval.ssProcessTypeCode = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssProcessTypeCode;

// l_InvoiceApproval.ApprovalProcessVersion = GetApprovalProcessDef.o_ApprovalProcess.Version
localVars.varLcl_InvoiceApproval.ssApprovalProcessVersion = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssVersion;

// l_InvoiceApproval.CurrentLevel = 0
localVars.varLcl_InvoiceApproval.ssCurrentLevel = 0;

// l_InvoiceApproval.StartedOn = CurrDateTime
localVars.varLcl_InvoiceApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_InvoiceApproval.HasStartedAccounting = False
localVars.varLcl_InvoiceApproval.ssHasStartedAccounting = false;

// l_InvoiceApproval.AprovalProcessId = GetApprovalProcessDef.o_ApprovalProcess.ApprovalProcessId
localVars.varLcl_InvoiceApproval.ssAprovalProcessId = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId;
// l_InvoiceApprovalLevel
// l_InvoiceApprovalLevel.Id = NullIdentifier
localVars.varLcl_InvoiceApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_InvoiceApprovalLevel.LevelNumber = 0
localVars.varLcl_InvoiceApprovalLevel.ssLevelNumber = 0;

// l_InvoiceApprovalLevel.ApplicationRoleId = GetUserRole2.o_ApplicationRoleId
localVars.varLcl_InvoiceApprovalLevel.ssApplicationRoleId = localVars.resGetUserRole2.outParamo_ApplicationRoleId;

// l_InvoiceApprovalLevel.AssignedTo = i_CreateForUser
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = localVars.inParami_CreateForUser;

// l_InvoiceApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_InvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_InvoiceApprovalLevel.IsAccounting = False
localVars.varLcl_InvoiceApprovalLevel.ssIsAccounting = false;

// l_InvoiceApprovalLevel.IsStartAccounting = False
localVars.varLcl_InvoiceApprovalLevel.ssIsStartAccounting = false;
}

}

}

} else {
// l_CurrentEmail = If
localVars.varLcl_CurrentEmail=(((localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssEmail));
// CheckApplicantApprovalIsNeeded
(localVars.resCheckApplicantApprovalIsNeeded.outParamo_ApprovalProcessLevel,localVars.resCheckApplicantApprovalIsNeeded.outParamo_IsNeeded) = await Actions.ActionCheckApplicantApprovalIsNeeded(requestContext,localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssId,localVars.inParami_InvoiceId,localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId,3,false,cancellationToken);

// l_InvoiceApproval
// l_InvoiceApproval.Id = NullIdentifier
localVars.varLcl_InvoiceApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_InvoiceApproval.InvoiceId = i_InvoiceId
localVars.varLcl_InvoiceApproval.ssInvoiceId = localVars.inParami_InvoiceId;

// l_InvoiceApproval.ProcessTypeCode = GetApprovalProcessDef.o_ApprovalProcess.ProcessTypeCode
localVars.varLcl_InvoiceApproval.ssProcessTypeCode = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssProcessTypeCode;

// l_InvoiceApproval.ApprovalProcessVersion = GetApprovalProcessDef.o_ApprovalProcess.Version
localVars.varLcl_InvoiceApproval.ssApprovalProcessVersion = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssVersion;

// l_InvoiceApproval.CurrentLevel = 0
localVars.varLcl_InvoiceApproval.ssCurrentLevel = 0;

// l_InvoiceApproval.StartedOn = CurrDateTime
localVars.varLcl_InvoiceApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_InvoiceApproval.HasStartedAccounting = False
localVars.varLcl_InvoiceApproval.ssHasStartedAccounting = false;

// l_InvoiceApproval.AprovalProcessId = GetApprovalProcessDef.o_ApprovalProcess.ApprovalProcessId
localVars.varLcl_InvoiceApproval.ssAprovalProcessId = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId;
// l_InvoiceApprovalLevel
// l_InvoiceApprovalLevel.Id = NullIdentifier
localVars.varLcl_InvoiceApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_InvoiceApprovalLevel.LevelNumber = 0
localVars.varLcl_InvoiceApprovalLevel.ssLevelNumber = 0;

// l_InvoiceApprovalLevel.ApplicationRoleId = GetInvoiceById.List.Current.Requisition.CreatedByApplicationRole
localVars.varLcl_InvoiceApprovalLevel.ssApplicationRoleId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssCreatedByApplicationRole;

// l_InvoiceApprovalLevel.AssignedTo = GetApplicantUserById.List.Current.User.Id
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = localVars.queryResGetApplicantUserById_outParamList.CurrentRec.ssENUser.ssId;

// l_InvoiceApprovalLevel.ApprovalStatusId = If
localVars.varLcl_InvoiceApprovalLevel.ssApprovalStatusId = (((localVars.resCheckApplicantApprovalIsNeeded.outParamo_ApprovalProcessLevel.ssSelectsNextApprover||localVars.resCheckApplicantApprovalIsNeeded.outParamo_ApprovalProcessLevel.ssSelectsFirstApprover)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId));

// l_InvoiceApprovalLevel.IsAccounting = False
localVars.varLcl_InvoiceApprovalLevel.ssIsAccounting = false;

// l_InvoiceApprovalLevel.IsStartAccounting = False
localVars.varLcl_InvoiceApprovalLevel.ssIsStartAccounting = false;

// l_InvoiceApprovalLevel.SelectsFirstApprover = CheckApplicantApprovalIsNeeded.o_ApprovalProcessLevel.SelectsFirstApprover
localVars.varLcl_InvoiceApprovalLevel.ssSelectsFirstApprover = localVars.resCheckApplicantApprovalIsNeeded.outParamo_ApprovalProcessLevel.ssSelectsFirstApprover;

// l_InvoiceApprovalLevel.SelectsNextApprover = CheckApplicantApprovalIsNeeded.o_ApprovalProcessLevel.SelectsNextApprover
localVars.varLcl_InvoiceApprovalLevel.ssSelectsNextApprover = localVars.resCheckApplicantApprovalIsNeeded.outParamo_ApprovalProcessLevel.ssSelectsNextApprover;
}

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_InvoiceApprovalLevels,localVars.varLcl_InvoiceApprovalLevel,cancellationToken);

// InvoiceApprovalCreateOrUpdate
localVars.resInvoiceApprovalCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.varLcl_InvoiceApproval,cancellationToken);

// Foreach l_InvoiceApprovalLevels
localVars.varLcl_InvoiceApprovalLevels.StartIteration();
try {while (!((localVars.varLcl_InvoiceApprovalLevels.Eof))) {
// l_InvoiceApprovalLevels.Current.InvoiceApprovalId = InvoiceApprovalCreateOrUpdate.Id
localVars.varLcl_InvoiceApprovalLevels.CurrentRec.ssInvoiceApprovalId = localVars.resInvoiceApprovalCreateOrUpdate.outParamId;

// l_InvoiceApprovalLevels.Current.ApprovalStatusId = If
localVars.varLcl_InvoiceApprovalLevels.CurrentRec.ssApprovalStatusId = (((!localVars.varLcl_HasStarted)) ? ((((localVars.varLcl_InvoiceApprovalLevel.ssSelectsFirstApprover||localVars.varLcl_InvoiceApprovalLevel.ssSelectsNextApprover)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId));
if(((!localVars.varLcl_HasStarted))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.varLcl_InvoiceApprovalLevels.CurrentRec.ssAssignedTo,cancellationToken);

// l_InvoiceApprovalLevels.Current.AssignedTo = If
localVars.varLcl_InvoiceApprovalLevels.CurrentRec.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.varLcl_InvoiceApprovalLevels.CurrentRec.ssAssignedTo) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// l_InvoiceApprovalLevels.Current.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.varLcl_InvoiceApprovalLevels.CurrentRec.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
}

// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_InvoiceApprovalLevels.CurrentRec,cancellationToken);

// l_HasStarted = True
localVars.varLcl_HasStarted=true;
localVars.varLcl_InvoiceApprovalLevels.Advance();
}

} finally {
localVars.varLcl_InvoiceApprovalLevels.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
if((localVars.varLcl_InvoiceApprovalLevels[0].ssSelectsFirstApprover)) {
// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = AssignInitialApprover
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("MCsBYwvZFUCwVOmkbA9eBw"))).ssId;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = ((((AppUtils.GetStringResource("WixwVsx99U+O2Fzw8GQeKg#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("WixwVsx99U+O2Fzw8GQeKg#Value.-350243954.1", "updated to Assign Initial Approver status.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate
localVars.resInvoiceStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = If
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = ((localVars.varLcl_InvoiceApproval.ssHasStartedAccounting) ? ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"))).ssId) : ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId));

// GetInvoiceById.List.Current.Invoice.SubmittedOn = CurrDateTime
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssSubmittedOn = BuiltInFunction.CurrDateTime ();
// InvoiceCreateOrUpdate2
localVars.resInvoiceCreateOrUpdate2.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceLogAdd2
localVars.resInvoiceLogAdd2.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = ((((AppUtils.GetStringResource("ttGr98IrXUqqwbxRCZLiZg#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("ttGr98IrXUqqwbxRCZLiZg#Value.476391.1", "initiated approval process.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate2
localVars.resInvoiceStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// GetInvoiceById.List.Current.Requisition.AdvWithoutInvoice = False
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssAdvWithoutInvoice = false;
// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId, ssRequisitionStatusId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("kvgteRs4t0+DA9dMia_kkw#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("kvgteRs4t0+DA9dMia_kkw#Value.-2013041359.1", "changed from requisition without invoice since a invoice has been uploaded.")) },cancellationToken);

// Result
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// InvEmailFirstApprov_ToApprove
await Actions.ActionInvEmailFirstApprov_ToApprove(requestContext,localVars.inParami_InvoiceId,cancellationToken);

}

}

} else {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (localVars.resGetApprovalProcessDef.outParamo_Output.ssMessage);

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

public static class FuncActionInitInvWF {

private static async Task<RC_e7c96643ac320a01471372d3fdec9c1e> datasetGetUserExtendedInternalJobTitleReadDbAsync(RC_e7c96643ac320a01471372d3fdec9c1e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDepartment.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalJobTitle" l3kSX+1+mEejXzgNrK9H1w of Action "InitInvWF"
public static async Task<(RL_324fa1265a392847ccc93fec110b2400,long)> datasetGetUserExtendedInternalJobTitle(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF.GetUserExtendedInternalJobTitle", "5f127997-7eed-4798-a35f-380dacaf47d7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF.GetUserExtendedInternalJobTitle", "5f127997-7eed-4798-a35f-380dacaf47d7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fK7+6ErzikSOl9fVMOecbQ/NodesNotShownInESpaceTree.l3kSX+1+mEejXzgNrK9H1w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"endepartment7\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"entelceldirection10\".\"name\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enuser_extended_internal77\".\"departmentid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enuser_extended_internal77\".\"entraroleid\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal77\" Inner JOIN {User} \"enuser129\" ON (\"enuser_extended_internal77\".\"id\" = \"enuser129\".\"id\"))  Left JOIN {Department} \"endepartment7\" ON (\"enuser_extended_internal77\".\"departmentid\" = \"endepartment7\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection10\" ON (\"enuser_extended_internal77\".\"telceldirectionid\" = \"entelceldirection10\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser129\".\"id\" = @qpusUser_Id) AND (\"enuser129\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser129\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuser129\".\"name\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
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

private static async Task<RC_3336d2630e2646e00d0c2f5c3e5a01ea> datasetGetInvoiceByIdReadDbAsync(RC_3336d2630e2646e00d0c2f5c3e5a01ea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" jrErtVWHqEirQE8vIknqrA of Action "InitInvWF"
public static async Task<(RL_c851528f2bd72df8d6fa01fc1d7dda59,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF.GetInvoiceById", "b52bb18e-8755-48a8-ab40-4f2f2249eaac");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF.GetInvoiceById", "b52bb18e-8755-48a8-ab40-4f2f2249eaac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fK7+6ErzikSOl9fVMOecbQ/NodesNotShownInESpaceTree.jrErtVWHqEirQE8vIknqrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice71\".\"id\" o0, \"eninvoice71\".\"name\" o1, \"eninvoice71\".\"requisitionid\" o2, \"eninvoice71\".\"folioid\" o3, \"eninvoice71\".\"ordermainid\" o4, \"eninvoice71\".\"cfditypeid\" o5, trim_scale(\"eninvoice71\".\"totalamount\"::numeric) o6, \"eninvoice71\".\"currency\" o7, \"eninvoice71\".\"invoicestatusid\" o8, \"eninvoice71\".\"accountingdatetime\" o9, \"eninvoice71\".\"paymentdatetime\" o10, \"eninvoice71\".\"createdon\" o11, \"eninvoice71\".\"createdby\" o12, \"eninvoice71\".\"updatedon\" o13, \"eninvoice71\".\"updatedby\" o14, \"eninvoice71\".\"submittedon\" o15, \"eninvoice71\".\"isnewversion\" o16, \"eninvoice71\".\"id_poliza\" o17, \"eninvoice71\".\"id_poliza_sap\" o18, \"eninvoice71\".\"doc51\" o19, \"eninvoice71\".\"accountingerror\" o20, \"eninvoice71\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice71\".\"amortization\"::numeric) o22, \"eninvoice71\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enrequisition68\".\"id\" o37, \"enrequisition68\".\"name\" o38, \"enrequisition68\".\"counter\" o39, \"enrequisition68\".\"requisitionstatusid\" o40, \"enrequisition68\".\"supplierid\" o41, \"enrequisition68\".\"regionid\" o42, \"enrequisition68\".\"accountingregionid\" o43, \"enrequisition68\".\"applicantid\" o44, \"enrequisition68\".\"maxdatefinishcapture\" o45, \"enrequisition68\".\"projectassetserviceid\" o46, \"enrequisition68\".\"projectassetservice\" o47, \"enrequisition68\".\"projectdescription\" o48, \"enrequisition68\".\"frequencyid\" o49, \"enrequisition68\".\"issustainability\" o50, \"enrequisition68\".\"sustainabilityid\" o51, \"enrequisition68\".\"businessvaluecategoryid\" o52, \"enrequisition68\".\"businessvaluesubcategoryid\" o53, trim_scale(\"enrequisition68\".\"totalamount\"::numeric) o54, \"enrequisition68\".\"currencyid\" o55, \"enrequisition68\".\"distributionid\" o56, \"enrequisition68\".\"costcenterid\" o57, \"enrequisition68\".\"hascontract\" o58, \"enrequisition68\".\"iscontractpending\" o59, \"enrequisition68\".\"hasdeposit\" o60, \"enrequisition68\".\"hasinsurance\" o61, \"enrequisition68\".\"hasadvancepayment\" o62, \"enrequisition68\".\"accountingservicetypeid_depr\" o63, \"enrequisition68\".\"servicedescription_deprec\" o64, \"enrequisition68\".\"invoiceusageid_deprec\" o65, \"enrequisition68\".\"serviceformatid\" o66, \"enrequisition68\".\"companyid\" o67, trim_scale(\"enrequisition68\".\"retentionrate\"::numeric) o68, trim_scale(\"enrequisition68\".\"negotiatedexchangerate\"::numeric) o69, \"enrequisition68\".\"paymentmethodid\" o70, \"enrequisition68\".\"paymenttermsid\" o71, \"enrequisition68\".\"isautomaticaccounting\" o72, \"enrequisition68\".\"createdby\" o73, \"enrequisition68\".\"createdon\" o74, \"enrequisition68\".\"updatedon\" o75, \"enrequisition68\".\"updatedby\" o76, \"enrequisition68\".\"createdbyapplicationrole\" o77, \"enrequisition68\".\"dateofcommitment\" o78, \"enrequisition68\".\"hascontractfileuploaded\" o79, \"enrequisition68\".\"hasupdateddateofcommitment\" o80, \"enrequisition68\".\"submittedon\" o81, \"enrequisition68\".\"isdonation\" o82, \"enrequisition68\".\"advwithoutinvoice\" o83, \"enrequisition68\".\"wasadvwithoutinvoice\" o84, \"enrequisition68\".\"isadvanced\" o85, \"enrequisition68\".\"documenttypeid\" o86, \"enrequisition68\".\"iscreatedbyanassistente\" o87, \"enrequisition68\".\"telceldirectionid\" o88, \"enrequisition68\".\"hasmultiupload\" o89, \"enrequisition68\".\"accountingdate\" o90, \"enrequisition68\".\"paymentoptionsid\" o91, \"enrequisition68\".\"paymentwaysid\" o92, \"enrequisition68\".\"buydocnumber\" o93, \"enrequisition68\".\"buydocposition\" o94");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice71\" Left JOIN {Requisition} \"enrequisition68\" ON (\"enrequisition68\".\"id\" = \"eninvoice71\".\"requisitionid\"))  Left JOIN {Region} \"enregion59\" ON (\"enrequisition68\".\"regionid\" = \"enregion59\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice71\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice71\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice71\".\"id\" IS NULL)");
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
RL_c851528f2bd72df8d6fa01fc1d7dda59 outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c851528f2bd72df8d6fa01fc1d7dda59 _tmp = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c851528f2bd72df8d6fa01fc1d7dda59)_tmp;
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetApplicantUserByIdReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetApplicantUserById" NLDs0TVyVk68yxlYxVUDLA of Action "InitInvWF"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetApplicantUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,string qpusUser_Id1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF.GetApplicantUserById", "d1ecb034-7235-4e56-bccb-1958c555032c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF.GetApplicantUserById", "d1ecb034-7235-4e56-bccb-1958c555032c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fK7+6ErzikSOl9fVMOecbQ/NodesNotShownInESpaceTree.NLDs0TVyVk68yxlYxVUDLA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser130\".\"id\" o0, NULL o1, \"enuser130\".\"email\" o2, NULL o3, NULL o4, NULL o5, \"enuserextension60\".\"correspondentexternalemail\" o6, NULL o7");
fromBuilder.Append(" FROM ({User} \"enuser130\" Left JOIN {UserExtension} \"enuserextension60\" ON (\"enuser130\".\"id\" = \"enuserextension60\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpusUser_Id <> '') THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id1);
if ((qpusUser_Id1.Trim()!="")) {
whereBuilder.Append("((\"enuser130\".\"id\" = @qpusUser_Id) AND (\"enuser130\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id1);
} else {
whereBuilder.Append("(\"enuser130\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser130\".\"id\" = @qpusUser_Id1) AND (\"enuser130\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id1", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser130\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF.GetApplicantUserById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF.GetApplicantUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_98120f161aa796efec5482157f929b99> datasetGetRequisitionApprovalIsSpecialReadDbAsync(RC_98120f161aa796efec5482157f929b99 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalIsSpecial" hyzx6Rr1AEqSdh46viLbmQ of Action "InitInvWF"
public static async Task<(RL_eb30c26c3067f3944a588d50f5676332,long)> datasetGetRequisitionApprovalIsSpecial(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF.GetRequisitionApprovalIsSpecial", "e9f12c87-f51a-4a00-9276-1e3abe22db99");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF.GetRequisitionApprovalIsSpecial", "e9f12c87-f51a-4a00-9276-1e3abe22db99", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fK7+6ErzikSOl9fVMOecbQ/NodesNotShownInESpaceTree.hyzx6Rr1AEqSdh46viLbmQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapprovalprocess36\".\"specialworkflowid\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enapprovalprocess36\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM ({RequisitionApproval} \"enrequisitionapproval23\" Inner JOIN {ApprovalProcess} \"enapprovalprocess36\" ON (\"enrequisitionapproval23\".\"aprovalprocessid\" = \"enapprovalprocess36\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval23\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval23\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval23\".\"requisitionid\" IS NULL)");
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
RL_eb30c26c3067f3944a588d50f5676332 outParamList = new RL_eb30c26c3067f3944a588d50f5676332();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalIsSpecialReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF.GetRequisitionApprovalIsSpecial.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_eb30c26c3067f3944a588d50f5676332 _tmp = new RL_eb30c26c3067f3944a588d50f5676332();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalIsSpecialReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF.GetRequisitionApprovalIsSpecial.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb30c26c3067f3944a588d50f5676332)_tmp;
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
