namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovModifReq : VarsBag {
public long inParami_RequisitionId;
public long inParami_RequisitionApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>l_RequisitionApprovalLevel</code> that represents the Service Studio
///  RequisitionApprovalLevel <code>l_RequisitionApprovalLevel</code> <p>Description
/// : RequisitionApprovalLevel</p>
/// </summary>
public EN_27b1469f497d364a764a1359956ef9adEntityRecord varLcl_RequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();

/// <summary>
/// Variable <code>l_LastApprover</code> that represents the Service Studio UserIdentifier
///  <code>l_LastApprover</code> <p>Description: LastApprover</p>
/// </summary>
public string varLcl_LastApprover = "";

public RL_2fd4ee9249069fb78258eb73022e4cb9 queryResGetANALISTA_CXP_outParamList = new RL_2fd4ee9249069fb78258eb73022e4cb9();
public long queryResGetANALISTA_CXP_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAddApprove =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate2 =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate3 =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoFindNextApproverSpecial resFindNextApproverSpecial =  new Actions.lcoFindNextApproverSpecial();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate6 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcess_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcess_outParamCount = 0L;

public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAddApprove2 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate5 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitionCommentCreateOrUpdate resRequisitionCommentCreateOrUpdate =  new Actions.lcoRequisitionCommentCreateOrUpdate();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate2 =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAddModify =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionApprovalLevel_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionApprovalLevel_outParamCount = 0L;

public RL_e87aa4fcc2debbce04977171112902a4 queryResGetNextRequisitionApprovalLevel_outParamList = new RL_e87aa4fcc2debbce04977171112902a4();
public long queryResGetNextRequisitionApprovalLevel_outParamCount = 0L;

public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate4 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoGetReqNextApprov resGetReqNextApprov =  new Actions.lcoGetReqNextApprov();
public lcvApprovModifReq(long inParami_RequisitionId, long inParami_RequisitionApprovalLevelId, bool inParami_IsApprove, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoApprovModifReq : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApprovModifReq() {
}
}
/// <summary>
/// Action <code>ApprovModifReq</code> that represents the Service Studio action
///  <code>ApprovModifReq</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApprovModifReq(IRequestContext requestContext,long inParami_RequisitionId,long inParami_RequisitionApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoApprovModifReq result = new lcoApprovModifReq();
lcvApprovModifReq localVars = new lcvApprovModifReq(inParami_RequisitionId, inParami_RequisitionApprovalLevelId, inParami_IsApprove, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovModifReq", "d9c5608c-7e94-4e74-aa02-418c0dbd29bb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovModifReq", "d9c5608c-7e94-4e74-aa02-418c0dbd29bb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetRequisitionApprovalLevel_maxRecords < 1) datasetGetRequisitionApprovalLevel_maxRecords = 1;
int datasetGetRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevel_outParamList,localVars.queryResGetRequisitionApprovalLevel_outParamCount) = await FuncActionApprovModifReq.datasetGetRequisitionApprovalLevel(requestContext,datasetGetRequisitionApprovalLevel_maxRecords,datasetGetRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionApprovalLevelId,cancellationToken);

if(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Requisition cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("DXTEwANm8kifPylg1n8i9w#Value.1333646474.1", "Requisition cannot be updated!");
} else {
if((localVars.inParami_IsApprove)) {
bool block1 = false;
do {
block1 = false;
bool block2 = false;
do {
block2 = false;
// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionApprovModifReq.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssAprovalProcessId,cancellationToken);

// IsSpecial?
if((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial)) {
// ClearOtherApproversFromSameLevel
await Actions.ActionClearOtherApproversFromSameLevel(requestContext,localVars.inParami_RequisitionId,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber,localVars.inParami_RequisitionApprovalLevelId,cancellationToken);

}

// Query datasetGetNextRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetNextRequisitionApprovalLevel_maxRecords < 1) datasetGetNextRequisitionApprovalLevel_maxRecords = 1;
int datasetGetNextRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetNextRequisitionApprovalLevel_outParamList,localVars.queryResGetNextRequisitionApprovalLevel_outParamCount) = await FuncActionApprovModifReq.datasetGetNextRequisitionApprovalLevel(requestContext,datasetGetNextRequisitionApprovalLevel_maxRecords,datasetGetNextRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssId,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber,cancellationToken);

// Empty?
if((localVars.queryResGetNextRequisitionApprovalLevel_outParamList.Empty)) {
// IsSpecial?
do {
// IsSpecial?
if((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial)) {
// HasStartedAccounting?
if((!(localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting))) {
break;
}

} else {
// IsReassigned?
if((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsReassigned)) {
// l_LastApprover = If
localVars.varLcl_LastApprover=(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor) : (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssApplicantId));
}

}

// GetReqNextApprov
(localVars.resGetReqNextApprov.outParamo_IsFinishApproval,localVars.resGetReqNextApprov.outParamo_AssignTo,localVars.resGetReqNextApprov.outParamo_ApplicationRoleId,localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels,localVars.resGetReqNextApprov.outParamo_IsSubstituteFor) = await Actions.ActionGetReqNextApprov(requestContext,((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsReassigned) ? (localVars.varLcl_LastApprover) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())))),localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition,localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting,cancellationToken);

// o_IsFinishApproval?
if((localVars.resGetReqNextApprov.outParamo_IsFinishApproval)) {
// HasStartedAccounting?
if((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting)) {
if((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssAdvWithoutInvoice)) {
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveContabilizationServices]))))) {
// InvoiceAccountingProcess_Create
await Actions.ActionInvoiceAccountingProcess_Create(requestContext,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),"",false,localVars.inParami_RequisitionId,localVars.inParamOffsetUtc,cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
goto RETURN_STATEMENT;

}

}

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedBy = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.AssignedTo = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = (((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));

// GetRequisitionApprovalLevel.List.Current.Requisition.AccountingDate = CurrDate
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssAccountingDate = BuiltInFunction.CurrDate ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.EntraJobTitle = GetUserEntraRoleName()
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssEntraJobTitle = (await Functions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken));
// RequisitionApprovalLevelCreateOrUpdate2
localVars.resRequisitionApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionLogAddApprove
localVars.resRequisitionLogAddApprove.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("RlC4GVlEXUOn+PI2llp8hQ#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("RlC4GVlEXUOn+PI2llp8hQ#Value.1185244855.1", "approved"))+(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("RlC4GVlEXUOn+PI2llp8hQ#Value.182414732.1", "by a substitute."))) : ("."))) },cancellationToken);

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.FinishedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.Requisition.RequisitionStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.MaxLevel = GetRequisitionApprovalLevel.List.Current.RequisitionApproval.CurrentLevel
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssMaxLevel = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssCurrentLevel;
// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval,cancellationToken);

// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("UXgloa8bBEKZbM2P5xQtOQ#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("UXgloa8bBEKZbM2P5xQtOQ#Value.-1625364909.1", "updated to Approved status.")) },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// SendReqApprovedEmail
await Actions.ActionSendReqApprovedEmail(requestContext,localVars.inParami_RequisitionId,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
goto RETURN_STATEMENT;

}

} else {
// l_RequisitionApprovalLevels empty?
if((localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.Empty)) {
// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel.Id = NullIdentifier
localVars.varLcl_RequisitionApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApprovalLevel.RequisitionApprovalId = GetRequisitionApprovalLevel.List.Current.RequisitionApproval.Id
localVars.varLcl_RequisitionApprovalLevel.ssRequisitionApprovalId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssId;

// l_RequisitionApprovalLevel.LevelNumber = GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber + 1
localVars.varLcl_RequisitionApprovalLevel.ssLevelNumber = (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber+1);

// l_RequisitionApprovalLevel.ApplicationRoleId = GetReqNextApprov.o_ApplicationRoleId
localVars.varLcl_RequisitionApprovalLevel.ssApplicationRoleId = localVars.resGetReqNextApprov.outParamo_ApplicationRoleId;

// l_RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_RequisitionApprovalLevel.IsAccounting = GetRequisitionApprovalLevel.List.Current.RequisitionApproval.HasStartedAccounting
localVars.varLcl_RequisitionApprovalLevel.ssIsAccounting = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting;

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.CurrentLevel = GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber + 1
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssCurrentLevel = (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber+1);

// l_RequisitionApprovalLevel.AssignedTo = GetReqNextApprov.o_AssignTo
localVars.varLcl_RequisitionApprovalLevel.ssAssignedTo = localVars.resGetReqNextApprov.outParamo_AssignTo;

// l_RequisitionApprovalLevel.IsSubstituteFor = GetReqNextApprov.o_IsSubstituteFor
localVars.varLcl_RequisitionApprovalLevel.ssIsSubstituteFor = localVars.resGetReqNextApprov.outParamo_IsSubstituteFor;
// jump to block2
block2 = true;
break;
} else {
// o_RequisitionApprovalLevels
// Foreach GetReqNextApprov.o_RequisitionApprovalLevels
localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.StartIteration();
try {while (!((localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.Eof))) {
// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel.Id = NullIdentifier
localVars.varLcl_RequisitionApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApprovalLevel.RequisitionApprovalId = GetRequisitionApprovalLevel.List.Current.RequisitionApproval.Id
localVars.varLcl_RequisitionApprovalLevel.ssRequisitionApprovalId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssId;

// l_RequisitionApprovalLevel.LevelNumber = GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber + GetReqNextApprov.o_RequisitionApprovalLevels.CurrentRowNumber + 1
localVars.varLcl_RequisitionApprovalLevel.ssLevelNumber = ((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber+localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.CurrentRowNumber)+1);

// l_RequisitionApprovalLevel.ApplicationRoleId = GetReqNextApprov.o_RequisitionApprovalLevels.Current.ApplicationRoleId
localVars.varLcl_RequisitionApprovalLevel.ssApplicationRoleId = localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.CurrentRec.ssApplicationRoleId;

// l_RequisitionApprovalLevel.ApprovalStatusId = If
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (((localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.CurrentRowNumber==0)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId));

// l_RequisitionApprovalLevel.IsAccounting = GetReqNextApprov.o_RequisitionApprovalLevels.Current.IsAccounting
localVars.varLcl_RequisitionApprovalLevel.ssIsAccounting = localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.CurrentRec.ssIsAccounting;

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.CurrentLevel = GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber + 1
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssCurrentLevel = (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber+1);

// l_RequisitionApprovalLevel.AssignedTo = GetReqNextApprov.o_RequisitionApprovalLevels.Current.AssignedTo
localVars.varLcl_RequisitionApprovalLevel.ssAssignedTo = localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.CurrentRec.ssAssignedTo;

// l_RequisitionApprovalLevel.ApproveAsAreaUsuaria = GetReqNextApprov.o_RequisitionApprovalLevels.Current.ApproveAsAreaUsuaria
localVars.varLcl_RequisitionApprovalLevel.ssApproveAsAreaUsuaria = localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.CurrentRec.ssApproveAsAreaUsuaria;

// l_RequisitionApprovalLevel.IsMandatory = GetReqNextApprov.o_RequisitionApprovalLevels.Current.IsMandatory
localVars.varLcl_RequisitionApprovalLevel.ssIsMandatory = localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.CurrentRec.ssIsMandatory;
// RequisitionApprovalLevelCreateOrUpdate5
localVars.resRequisitionApprovalLevelCreateOrUpdate5.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_RequisitionApprovalLevel,cancellationToken);

localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.Advance();
}

} finally {
localVars.resGetReqNextApprov.outParamo_RequisitionApprovalLevels.EndIteration();
}

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedBy = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.AssignedTo = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = (((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));
// jump to block1
block1 = true;
break;
}

}

} while(false)
;
if((block1 || block2)) {
break;
}

// Query datasetGetANALISTA_CXP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetANALISTA_CXP_maxRecords = 1;
if (datasetGetANALISTA_CXP_maxRecords < 1) datasetGetANALISTA_CXP_maxRecords = 1;
int datasetGetANALISTA_CXP_startIndex = 0;(localVars.queryResGetANALISTA_CXP_outParamList,localVars.queryResGetANALISTA_CXP_outParamCount) = await FuncActionApprovModifReq.datasetGetANALISTA_CXP(requestContext,datasetGetANALISTA_CXP_maxRecords,datasetGetANALISTA_CXP_startIndex,IterationMultiplicity.Never,cancellationToken);

// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel.Id = NullIdentifier
localVars.varLcl_RequisitionApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApprovalLevel.RequisitionApprovalId = GetRequisitionApprovalLevel.List.Current.RequisitionApproval.Id
localVars.varLcl_RequisitionApprovalLevel.ssRequisitionApprovalId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssId;

// l_RequisitionApprovalLevel.LevelNumber = GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber + 1
localVars.varLcl_RequisitionApprovalLevel.ssLevelNumber = (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber+1);

// l_RequisitionApprovalLevel.ApplicationRoleId = GetANALISTA_CXP.List.Current.ApplicationRole.Id
localVars.varLcl_RequisitionApprovalLevel.ssApplicationRoleId = localVars.queryResGetANALISTA_CXP_outParamList.CurrentRec.ssENApplicationRole.ssId;

// l_RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_RequisitionApprovalLevel.IsAccounting = True
localVars.varLcl_RequisitionApprovalLevel.ssIsAccounting = true;

// l_RequisitionApprovalLevel.IsStartAccounting = True
localVars.varLcl_RequisitionApprovalLevel.ssIsStartAccounting = true;

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.CurrentLevel = GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber + 1
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssCurrentLevel = (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber+1);

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.HasStartedAccounting = True
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting = true;
// Empty?
if((localVars.queryResGetANALISTA_CXP_outParamList.Empty)) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("U9QsPFFfEkmZgOAfNa3w5w#Message.2138269536.1", "ANALISTA_CXP - Analista CxP/Egresos role has not yet been created."));

} else {
// InitReqWF_CxP2
await Actions.ActionInitReqWF_CxP(requestContext,localVars.inParami_RequisitionId,cancellationToken);

// ALIGN
}

} else {
// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel = GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel
localVars.varLcl_RequisitionApprovalLevel=localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel;

// l_RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.CurrentLevel = GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssCurrentLevel = localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber;
// AssignedTo?
if(((localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ()))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo,cancellationToken);

// l_RequisitionApprovalLevel.AssignedTo = If
localVars.varLcl_RequisitionApprovalLevel.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// l_RequisitionApprovalLevel.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.varLcl_RequisitionApprovalLevel.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
} else {
// FindNextApproverSpecial
(localVars.resFindNextApproverSpecial.outParamo_Output,localVars.resFindNextApproverSpecial.outParamo_UserId,localVars.resFindNextApproverSpecial.outParamo_IsSubstituteFor) = await Actions.ActionFindNextApproverSpecial(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssEntraRoleId,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRegionId,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssDepartmentId,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssManagementId,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssSubdirectionId,cancellationToken);

// IsSuccess
if((localVars.resFindNextApproverSpecial.outParamo_Output.ssIsSuccess)) {
// AssignedTo
// l_RequisitionApprovalLevel.AssignedTo = FindNextApproverSpecial.o_UserId
localVars.varLcl_RequisitionApprovalLevel.ssAssignedTo = localVars.resFindNextApproverSpecial.outParamo_UserId;

// l_RequisitionApprovalLevel.IsSubstituteFor = FindNextApproverSpecial.o_IsSubstituteFor
localVars.varLcl_RequisitionApprovalLevel.ssIsSubstituteFor = localVars.resFindNextApproverSpecial.outParamo_IsSubstituteFor;
} else {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (localVars.resFindNextApproverSpecial.outParamo_Output.ssMessage);

}

}

// ALIGN
}

} while(false)
;
if(block1) {
break;
}

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedBy = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.AssignedTo = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = (((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.EntraJobTitle = GetUserEntraRoleName()
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssEntraJobTitle = (await Functions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken));
// RequisitionApprovalLevelCreateOrUpdate4
localVars.resRequisitionApprovalLevelCreateOrUpdate4.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_RequisitionApprovalLevel,cancellationToken);

} while(false)
;
// RequisitionApprovalLevelCreateOrUpdate6
localVars.resRequisitionApprovalLevelCreateOrUpdate6.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionLogAddApprove2
localVars.resRequisitionLogAddApprove2.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("+dX+jxWCVU+_+hihZ3wOIQ#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("+dX+jxWCVU+_+hihZ3wOIQ#Value.1185244855.1", "approved"))+(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("+dX+jxWCVU+_+hihZ3wOIQ#Value.182414732.1", "by a substitute."))) : ("."))) },cancellationToken);

// RequisitionApprovalCreateOrUpdate3
localVars.resRequisitionApprovalCreateOrUpdate3.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval,cancellationToken);

// SendReqNextApproverEmail
await Actions.ActionSendReqNextApproverEmail(requestContext,localVars.inParami_RequisitionId,cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.RequestToModifyBy = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssRequestToModifyBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.RequestToModifyOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssRequestToModifyOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Modify
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.FinishedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.Requisition.RequisitionStatusId = Modify
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("5K2SyCJmtU+vkuFEbRmA_g"))).ssId;
// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionApprovalCreateOrUpdate2
localVars.resRequisitionApprovalCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval,cancellationToken);

// RequisitionCreateOrUpdate2
localVars.resRequisitionCreateOrUpdate2.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitionCommentCreateOrUpdate
localVars.resRequisitionCommentCreateOrUpdate.outParamId = await Actions.ActionRequisitionCommentCreateOrUpdate(requestContext,new EN_cbeb601b681344342c8de0161d058f87EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("Q+rGOvxr0UWakrrNEZeW8g"))).ssId, ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionApprovalLevelId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId, ssApplicationRoleId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApplicationRoleId, ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssMessage = localVars.inParami_Comment },cancellationToken);

// RequisitionLogAddModify
localVars.resRequisitionLogAddModify.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((((((AppUtils.GetStringResource("03YAvr4p3km20v3b4jbo9A#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("03YAvr4p3km20v3b4jbo9A#Value.587526867.1", "requested to be modified"))+(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (((" "+AppUtils.GetStringResource("03YAvr4p3km20v3b4jbo9A#Value.1391357666.1", "by a substitute"))+" ")) : (" ")))+AppUtils.GetStringResource("03YAvr4p3km20v3b4jbo9A#Value.448016147.1", "with the following comment:"))+" ")+localVars.inParami_Comment) },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate2
localVars.resRequisitonStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionStatusId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// SendReqRequestToModifyEmails
await Actions.ActionSendReqRequestToModifyEmails(requestContext,localVars.inParami_RequisitionId,localVars.inParami_Comment,(((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())),cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
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
catch (Ex_AccountingErrorUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = AccountingError.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
catch (Ex_GetNextApproverUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = GetNextApprover.ExceptionMessage
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

public static class FuncActionApprovModifReq {

// Query Function "GetANALISTA_CXP" BKPSCGKp+E+GXMDUu6_Ktg of Action "ApprovModifReq"
public static async Task<(RL_2fd4ee9249069fb78258eb73022e4cb9,long)> datasetGetANALISTA_CXP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifReq.GetANALISTA_CXP", "08d2a304-a962-4ff8-865c-c0d4bbafcab6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifReq.GetANALISTA_CXP", "08d2a304-a962-4ff8-865c-c0d4bbafcab6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jGDF2ZR+dE6qAkGMDb0puw/NodesNotShownInESpaceTree.BKPSCGKp+E+GXMDUu6_Ktg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole30\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {ApplicationRole} \"enapplicationrole30\"");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper(\"enapplicationrole30\".\"code\")) collate \"default\") like caseaccent_normalize('ANALISTA_CXP' collate \"default\"))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifReq.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifReq.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
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

// Query Function "GetApprovalProcess" OrkjQENgQUW2_FDXYSc22w of Action "ApprovModifReq"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifReq.GetApprovalProcess", "4023b93a-6043-4541-b6fc-50d7612736db");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifReq.GetApprovalProcess", "4023b93a-6043-4541-b6fc-50d7612736db", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jGDF2ZR+dE6qAkGMDb0puw/NodesNotShownInESpaceTree.OrkjQENgQUW2_FDXYSc22w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess31\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enapprovalprocess31\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess31\"");
whereBuilder.Append(" WHERE (\"enapprovalprocess31\".\"id\" = (@qploId))");
sqlCmd.CreateParameterWithoutReplacements("@qploId", DbType.Int64, qploId);
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifReq.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf _tmp = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifReq.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5e0ca6ca9da3af4b1d8149758c39c2cf)_tmp;
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

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionApprovalLevelReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalLevel" FjO6u3yFCEa0VQIg9anblQ of Action "ApprovModifReq"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifReq.GetRequisitionApprovalLevel", "bbba3316-857c-4608-b455-0220f5a9db95");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifReq.GetRequisitionApprovalLevel", "bbba3316-857c-4608-b455-0220f5a9db95", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jGDF2ZR+dE6qAkGMDb0puw/NodesNotShownInESpaceTree.FjO6u3yFCEa0VQIg9anblQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition62\".\"id\" o0, \"enrequisition62\".\"name\" o1, \"enrequisition62\".\"counter\" o2, \"enrequisition62\".\"requisitionstatusid\" o3, \"enrequisition62\".\"supplierid\" o4, \"enrequisition62\".\"regionid\" o5, \"enrequisition62\".\"accountingregionid\" o6, \"enrequisition62\".\"applicantid\" o7, \"enrequisition62\".\"maxdatefinishcapture\" o8, \"enrequisition62\".\"projectassetserviceid\" o9, \"enrequisition62\".\"projectassetservice\" o10, \"enrequisition62\".\"projectdescription\" o11, \"enrequisition62\".\"frequencyid\" o12, \"enrequisition62\".\"issustainability\" o13, \"enrequisition62\".\"sustainabilityid\" o14, \"enrequisition62\".\"businessvaluecategoryid\" o15, \"enrequisition62\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition62\".\"totalamount\"::numeric) o17, \"enrequisition62\".\"currencyid\" o18, \"enrequisition62\".\"distributionid\" o19, \"enrequisition62\".\"costcenterid\" o20, \"enrequisition62\".\"hascontract\" o21, \"enrequisition62\".\"iscontractpending\" o22, \"enrequisition62\".\"hasdeposit\" o23, \"enrequisition62\".\"hasinsurance\" o24, \"enrequisition62\".\"hasadvancepayment\" o25, \"enrequisition62\".\"accountingservicetypeid_depr\" o26, \"enrequisition62\".\"servicedescription_deprec\" o27, \"enrequisition62\".\"invoiceusageid_deprec\" o28, \"enrequisition62\".\"serviceformatid\" o29, \"enrequisition62\".\"companyid\" o30, trim_scale(\"enrequisition62\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition62\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition62\".\"paymentmethodid\" o33, \"enrequisition62\".\"paymenttermsid\" o34, \"enrequisition62\".\"isautomaticaccounting\" o35, \"enrequisition62\".\"createdby\" o36, \"enrequisition62\".\"createdon\" o37, \"enrequisition62\".\"updatedon\" o38, \"enrequisition62\".\"updatedby\" o39, \"enrequisition62\".\"createdbyapplicationrole\" o40, \"enrequisition62\".\"dateofcommitment\" o41, \"enrequisition62\".\"hascontractfileuploaded\" o42, \"enrequisition62\".\"hasupdateddateofcommitment\" o43, \"enrequisition62\".\"submittedon\" o44, \"enrequisition62\".\"isdonation\" o45, \"enrequisition62\".\"advwithoutinvoice\" o46, \"enrequisition62\".\"wasadvwithoutinvoice\" o47, \"enrequisition62\".\"isadvanced\" o48, \"enrequisition62\".\"documenttypeid\" o49, \"enrequisition62\".\"iscreatedbyanassistente\" o50, \"enrequisition62\".\"telceldirectionid\" o51, \"enrequisition62\".\"hasmultiupload\" o52, \"enrequisition62\".\"accountingdate\" o53, \"enrequisition62\".\"paymentoptionsid\" o54, \"enrequisition62\".\"paymentwaysid\" o55, \"enrequisition62\".\"buydocnumber\" o56, \"enrequisition62\".\"buydocposition\" o57, \"enrequisitionapproval19\".\"id\" o58, \"enrequisitionapproval19\".\"requisitionid\" o59, \"enrequisitionapproval19\".\"aprovalprocessid\" o60, \"enrequisitionapproval19\".\"processtypecode\" o61, \"enrequisitionapproval19\".\"approvalprocessversion\" o62, \"enrequisitionapproval19\".\"currentlevel\" o63, \"enrequisitionapproval19\".\"maxlevel\" o64, \"enrequisitionapproval19\".\"startedon\" o65, \"enrequisitionapproval19\".\"finishedon\" o66, \"enrequisitionapproval19\".\"hasstartedaccounting\" o67, \"enrequisitionapprovallevel17\".\"id\" o68, \"enrequisitionapprovallevel17\".\"requisitionapprovalid\" o69, \"enrequisitionapprovallevel17\".\"levelnumber\" o70, \"enrequisitionapprovallevel17\".\"applicationroleid\" o71, \"enrequisitionapprovallevel17\".\"entrajobtitle\" o72, \"enrequisitionapprovallevel17\".\"departmentid\" o73, \"enrequisitionapprovallevel17\".\"managementid\" o74, \"enrequisitionapprovallevel17\".\"subdirectionid\" o75, \"enrequisitionapprovallevel17\".\"entraroleid\" o76, \"enrequisitionapprovallevel17\".\"entrausername\" o77, \"enrequisitionapprovallevel17\".\"assignedto\" o78, \"enrequisitionapprovallevel17\".\"needscontract\" o79, \"enrequisitionapprovallevel17\".\"approvalstatusid\" o80, \"enrequisitionapprovallevel17\".\"approvedby\" o81, \"enrequisitionapprovallevel17\".\"approvedon\" o82, \"enrequisitionapprovallevel17\".\"requesttomodifyby\" o83, \"enrequisitionapprovallevel17\".\"requesttomodifyon\" o84, \"enrequisitionapprovallevel17\".\"canceledby\" o85, \"enrequisitionapprovallevel17\".\"canceledon_deprec\" o86, \"enrequisitionapprovallevel17\".\"isaccounting\" o87, \"enrequisitionapprovallevel17\".\"isstartaccounting\" o88, \"enrequisitionapprovallevel17\".\"canceledon_\" o89, \"enrequisitionapprovallevel17\".\"approveasareausuaria\" o90, \"enrequisitionapprovallevel17\".\"ismandatory\" o91, \"enrequisitionapprovallevel17\".\"isreassigned\" o92, \"enrequisitionapprovallevel17\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition62\" Left JOIN {RequisitionApproval} \"enrequisitionapproval19\" ON (\"enrequisition62\".\"id\" = \"enrequisitionapproval19\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel17\" ON (\"enrequisitionapproval19\".\"id\" = \"enrequisitionapprovallevel17\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel17\".\"id\" = @qpreRequisitionApprovalLevel_Id) AND (\"enrequisitionapprovallevel17\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalLevel_Id", DbType.Int64, qpreRequisitionApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel17\".\"id\" IS NULL)");
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifReq.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifReq.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f3e9ea72dc7b010c56ee9146ee277c5)_tmp;
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

private static async Task<RC_3010654f80c827b760b6758b9f15acbb> datasetGetNextRequisitionApprovalLevelReadDbAsync(RC_3010654f80c827b760b6758b9f15acbb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetNextRequisitionApprovalLevel" mqIn48cbtk+TssoTxXG3Eg of Action "ApprovModifReq"
public static async Task<(RL_e87aa4fcc2debbce04977171112902a4,long)> datasetGetNextRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_Id,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifReq.GetNextRequisitionApprovalLevel", "e327a29a-1bc7-4fb6-93b2-ca13c571b712");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifReq.GetNextRequisitionApprovalLevel", "e327a29a-1bc7-4fb6-93b2-ca13c571b712", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jGDF2ZR+dE6qAkGMDb0puw/NodesNotShownInESpaceTree.mqIn48cbtk+TssoTxXG3Eg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enrequisition63\".\"regionid\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, \"enrequisitionapprovallevel18\".\"id\" o75, \"enrequisitionapprovallevel18\".\"requisitionapprovalid\" o76, \"enrequisitionapprovallevel18\".\"levelnumber\" o77, \"enrequisitionapprovallevel18\".\"applicationroleid\" o78, \"enrequisitionapprovallevel18\".\"entrajobtitle\" o79, \"enrequisitionapprovallevel18\".\"departmentid\" o80, \"enrequisitionapprovallevel18\".\"managementid\" o81, \"enrequisitionapprovallevel18\".\"subdirectionid\" o82, \"enrequisitionapprovallevel18\".\"entraroleid\" o83, \"enrequisitionapprovallevel18\".\"entrausername\" o84, \"enrequisitionapprovallevel18\".\"assignedto\" o85, \"enrequisitionapprovallevel18\".\"needscontract\" o86, NULL o87, \"enrequisitionapprovallevel18\".\"approvedby\" o88, \"enrequisitionapprovallevel18\".\"approvedon\" o89, \"enrequisitionapprovallevel18\".\"requesttomodifyby\" o90, \"enrequisitionapprovallevel18\".\"requesttomodifyon\" o91, \"enrequisitionapprovallevel18\".\"canceledby\" o92, \"enrequisitionapprovallevel18\".\"canceledon_deprec\" o93, \"enrequisitionapprovallevel18\".\"isaccounting\" o94, \"enrequisitionapprovallevel18\".\"isstartaccounting\" o95, \"enrequisitionapprovallevel18\".\"canceledon_\" o96, \"enrequisitionapprovallevel18\".\"approveasareausuaria\" o97, \"enrequisitionapprovallevel18\".\"ismandatory\" o98, \"enrequisitionapprovallevel18\".\"isreassigned\" o99, NULL o100");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition63\" Left JOIN {RequisitionApproval} \"enrequisitionapproval20\" ON (\"enrequisition63\".\"id\" = \"enrequisitionapproval20\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel18\" ON (\"enrequisitionapproval20\".\"id\" = \"enrequisitionapprovallevel18\".\"requisitionapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole31\" ON (\"enrequisitionapprovallevel18\".\"applicationroleid\" = \"enapplicationrole31\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_Id != 0) {
whereBuilder.Append("((\"enrequisitionapproval20\".\"id\" = @qpreRequisitionApproval_Id) AND (\"enrequisitionapproval20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_Id", DbType.Int64, qpreRequisitionApproval_Id);
} else {
whereBuilder.Append("(\"enrequisitionapproval20\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel18\".\"levelnumber\" > @qpinLevelNumber)");
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel18\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpinLevelNumber", DbType.Int32, qpinLevelNumber);
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
RL_e87aa4fcc2debbce04977171112902a4 outParamList = new RL_e87aa4fcc2debbce04977171112902a4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextRequisitionApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifReq.GetNextRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e87aa4fcc2debbce04977171112902a4 _tmp = new RL_e87aa4fcc2debbce04977171112902a4();
_tmp.AlternateReadDbMethodAsync = datasetGetNextRequisitionApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifReq.GetNextRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e87aa4fcc2debbce04977171112902a4)_tmp;
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
