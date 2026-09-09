namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovRejectFolio : VarsBag {
public long inParami_FolioId;
public long inParami_FolioApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>l_NewFolioApprovalLevel</code> that represents the Service Studio FolioApprovalLevel
///  <code>l_NewFolioApprovalLevel</code> <p>Description: Folio Approval Level.</p>
/// </summary>
public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord varLcl_NewFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();

/// <summary>
/// Variable <code>l_LastApprover</code> that represents the Service Studio UserIdentifier
///  <code>l_LastApprover</code> <p>Description: LastApprover</p>
/// </summary>
public string varLcl_LastApprover = "";

public RL_acd66b694d90eb775616e6c6e3f83477 queryResGetApprovalProcess_outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
public long queryResGetApprovalProcess_outParamCount = 0L;

public Actions.lcoGetUserEntraRoleNameById resGetUserEntraRoleNameById =  new Actions.lcoGetUserEntraRoleNameById();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate2 =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAddApprove =  new Actions.lcoFolioLogAdd();
public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioApprovalLevel_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioApprovalLevel_outParamCount = 0L;

public Actions.lcoCallEntryAccountingFolio resCallEntryAccountingFolio =  new Actions.lcoCallEntryAccountingFolio();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdateNext =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoGetUserEntraRoleName resGetUserEntraRoleName =  new Actions.lcoGetUserEntraRoleName();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate2 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoGetFolio_NextApprov resGetFolio_NextApprov =  new Actions.lcoGetFolio_NextApprov();
public RL_8ba9481252bc5c90efb1f40f454c1643 queryResGetNextFolioApprovalLevel_outParamList = new RL_8ba9481252bc5c90efb1f40f454c1643();
public long queryResGetNextFolioApprovalLevel_outParamCount = 0L;

public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdateCurrent =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoApprovRejectFolio_IsFinishApproval resApprovRejectFolio_IsFinishApproval =  new Actions.lcoApprovRejectFolio_IsFinishApproval();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoApprovRejectFolio_NotApproved resApprovRejectFolio_NotApproved =  new Actions.lcoApprovRejectFolio_NotApproved();
public lcvApprovRejectFolio(long inParami_FolioId, long inParami_FolioApprovalLevelId, bool inParami_IsApprove, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoApprovRejectFolio : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApprovRejectFolio() {
}
}
/// <summary>
/// Action <code>ApprovRejectFolio</code> that represents the Service Studio action
///  <code>ApprovRejectFolio</code> <p> Description: Action that Approves, Reject Folios.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApprovRejectFolio(IRequestContext requestContext,long inParami_FolioId,long inParami_FolioApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoApprovRejectFolio result = new lcoApprovRejectFolio();
lcvApprovRejectFolio localVars = new lcvApprovRejectFolio(inParami_FolioId, inParami_FolioApprovalLevelId, inParami_IsApprove, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovRejectFolio", "2b037169-b232-4efd-bcf0-327a5aae73e6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovRejectFolio", "2b037169-b232-4efd-bcf0-327a5aae73e6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevel_maxRecords = 1;
if (datasetGetFolioApprovalLevel_maxRecords < 1) datasetGetFolioApprovalLevel_maxRecords = 1;
int datasetGetFolioApprovalLevel_startIndex = 0;(localVars.queryResGetFolioApprovalLevel_outParamList,localVars.queryResGetFolioApprovalLevel_outParamCount) = await FuncActionApprovRejectFolio.datasetGetFolioApprovalLevel(requestContext,datasetGetFolioApprovalLevel_maxRecords,datasetGetFolioApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioApprovalLevelId,cancellationToken);

// dif than not approved
if((((((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId))&&(localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioStatusId!=(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId))&&(localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioStatusId!=(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId)))) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("QcCqqtvqkE+sVbN0GZm5oA#Value.1911675613.1", "Folio cannot be updated!");
} else {
// CanProveedorCancel?
if((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel)) {
// GetFolioApprovalLevel.List.Current.Folio.CanProveedorCancel = False
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = false;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio,cancellationToken);

}

// GetUserEntraRoleName
localVars.resGetUserEntraRoleName.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken);

// EntraJobTitle
// GetFolioApprovalLevel.List.Current.FolioApprovalLevel.EntraJobTitle = GetUserEntraRoleName.o_EntraRoleName
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle = localVars.resGetUserEntraRoleName.outParamo_EntraRoleName;
// EvidenceReview?
if(((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioStatusId==(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId))) {
// GetFolioApprovalLevel.List.Current.Folio.FolioStatusId = PendingApproval
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId;
// FolioCreateOrUpdate2
localVars.resFolioCreateOrUpdate2.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("3u_co3PMWkeAkNyNG7kTag#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("3u_co3PMWkeAkNyNG7kTag#Value.456572020.1", "has been updated to Pending Approval status"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = false },cancellationToken);

}

if((localVars.inParami_IsApprove)) {
// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionApprovRejectFolio.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssApprovalProcessId,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssApprovalProcessVersion,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssProcessTypeCode,cancellationToken);

// Query datasetGetNextFolioApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextFolioApprovalLevel_maxRecords = 1;
if (datasetGetNextFolioApprovalLevel_maxRecords < 1) datasetGetNextFolioApprovalLevel_maxRecords = 1;
int datasetGetNextFolioApprovalLevel_startIndex = 0;(localVars.queryResGetNextFolioApprovalLevel_outParamList,localVars.queryResGetNextFolioApprovalLevel_outParamCount) = await FuncActionApprovRejectFolio.datasetGetNextFolioApprovalLevel(requestContext,datasetGetNextFolioApprovalLevel_maxRecords,datasetGetNextFolioApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// CurrentFolioApprovalLevel
// GetFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovedBy = If
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovalStatusId = If
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId));

// GetFolioApprovalLevel.List.Current.FolioApprovalLevel.AssignedTo = If
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = (((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));

// GetFolioApprovalLevel.List.Current.FolioApprovalLevel.RejectReason = ""
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectReason = "";

// l_NewFolioApprovalLevel.RejectedBy = NullTextIdentifier
localVars.varLcl_NewFolioApprovalLevel.ssRejectedBy = BuiltInFunction.NullTextIdentifier ();

// l_NewFolioApprovalLevel.RejectedOn = NullDate
localVars.varLcl_NewFolioApprovalLevel.ssRejectedOn = BuiltInFunction.NullDate ();
if(((localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId))) {
// GetNextFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetNextFolioApprovalLevel.List.Current.FolioApprovalLevel.RejectedBy = NullTextIdentifier
localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedBy = BuiltInFunction.NullTextIdentifier ();

// GetNextFolioApprovalLevel.List.Current.FolioApprovalLevel.RejectedOn = NullDate
localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedOn = BuiltInFunction.NullDate ();

// GetNextFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetNextFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetNextFolioApprovalLevel.List.Current.FolioApprovalLevel.RejectReason = ""
localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectReason = "";

// GetFolioApprovalLevel.List.Current.FolioApproval.CurrentLevel = GetFolioApprovalLevel.List.Current.FolioApproval.CurrentLevel + 1
localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel = (localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel+1);
// FolioApprovalLevelCreateOrUpdateCurrent
localVars.resFolioApprovalLevelCreateOrUpdateCurrent.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioLogAddApprove
localVars.resFolioLogAddApprove.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("uez7PZ3Zb0uJp+FGOYtd9Q#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("uez7PZ3Zb0uJp+FGOYtd9Q#Value.1185244855.1", "approved"))+(((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("uez7PZ3Zb0uJp+FGOYtd9Q#Value.182414732.1", "by a substitute."))) : ("."))), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = false },cancellationToken);

// FolioApprovalLevelCreateOrUpdateNext
localVars.resFolioApprovalLevelCreateOrUpdateNext.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioNextApproverEmail4", "93f6a9c7-de1e-4a34-a5f7-6448f64600f2"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioNextApproverEmail4", "93f6a9c7-de1e-4a34-a5f7-6448f64600f2", "a3d02dd1-e313-409d-837e-fd413ba4d509", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload() {inParami_FolioId = localVars.inParami_FolioId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

} else {
// more levels?
if(((!localVars.queryResGetNextFolioApprovalLevel_outParamList.Empty))) {
// FolioApprovalLevelCreateOrUpdate2
localVars.resFolioApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// ApprovRejectFolio_InApproval
await Actions.ActionApprovRejectFolio_InApproval(requestContext,localVars.varLcl_NewFolioApprovalLevel,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("Lxi7XX0wTESCa43N8A_vqg#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("Lxi7XX0wTESCa43N8A_vqg#Value.1185244855.1", "approved"))+(((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("Lxi7XX0wTESCa43N8A_vqg#Value.182414732.1", "by a substitute."))) : ("."))), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = false },localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval,localVars.inParami_FolioId,localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// ClearOtherPossibleApprovers
await Actions.ActionClearOtherPossibleApprovers(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.inParami_FolioApprovalLevelId,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// CommitTransaction2
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioNextApproverEmail", "2049a6c8-ba55-49a0-a5db-76a69044760c"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioNextApproverEmail", "2049a6c8-ba55-49a0-a5db-76a69044760c", "a3d02dd1-e313-409d-837e-fd413ba4d509", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload() {inParami_FolioId = localVars.inParami_FolioId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

} else {
// Is by EntraRole?
if((!((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// is reassigned or from substitute?
if(((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsReassigned||(localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())))) {
// l_LastApprover = If
localVars.varLcl_LastApprover=(((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor) : (localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFirstApproverUserId));
}

// GetFolio_NextApprov
(localVars.resGetFolio_NextApprov.outParamo_IsFinishApproval,localVars.resGetFolio_NextApprov.outParamo_AssignTo,localVars.resGetFolio_NextApprov.outParamo_ApplicationRoleId,localVars.resGetFolio_NextApprov.outParamo_IsSubstituteFor) = await Actions.ActionGetFolio_NextApprov(requestContext,(((localVars.varLcl_LastApprover!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.varLcl_LastApprover) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())))),localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio,localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId,cancellationToken);

// o_IsFinishApproval?
if((!(localVars.resGetFolio_NextApprov.outParamo_IsFinishApproval))) {
// GetUserEntraRoleNameById
localVars.resGetUserEntraRoleNameById.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleNameById(requestContext,localVars.resGetFolio_NextApprov.outParamo_AssignTo,cancellationToken);

// l_NewFolioApprovalLevel
// l_NewFolioApprovalLevel.Id = NullIdentifier
localVars.varLcl_NewFolioApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_NewFolioApprovalLevel.FolioApprovalId = GetFolioApprovalLevel.List.Current.FolioApproval.Id
localVars.varLcl_NewFolioApprovalLevel.ssFolioApprovalId = localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssId;

// l_NewFolioApprovalLevel.LevelNumber = GetFolioApprovalLevel.List.Current.FolioApprovalLevel.LevelNumber + 1
localVars.varLcl_NewFolioApprovalLevel.ssLevelNumber = (localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber+1);

// l_NewFolioApprovalLevel.ApplicationRoleId = GetFolio_NextApprov.o_ApplicationRoleId
localVars.varLcl_NewFolioApprovalLevel.ssApplicationRoleId = localVars.resGetFolio_NextApprov.outParamo_ApplicationRoleId;

// l_NewFolioApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_NewFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_NewFolioApprovalLevel.AssignedTo = GetFolio_NextApprov.o_AssignTo
localVars.varLcl_NewFolioApprovalLevel.ssAssignedTo = localVars.resGetFolio_NextApprov.outParamo_AssignTo;

// l_NewFolioApprovalLevel.IsSubstituteFor = GetFolio_NextApprov.o_IsSubstituteFor
localVars.varLcl_NewFolioApprovalLevel.ssIsSubstituteFor = localVars.resGetFolio_NextApprov.outParamo_IsSubstituteFor;

// l_NewFolioApprovalLevel.EntraJobTitle = GetUserEntraRoleNameById.o_EntraRoleName
localVars.varLcl_NewFolioApprovalLevel.ssEntraJobTitle = localVars.resGetUserEntraRoleNameById.outParamo_EntraRoleName;
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// ApprovRejectFolio_InApproval2
await Actions.ActionApprovRejectFolio_InApproval(requestContext,localVars.varLcl_NewFolioApprovalLevel,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("WvoEJCeYM0aF7W01rtxUSQ#Value.2195684.1", "Form")+" ")+localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("WvoEJCeYM0aF7W01rtxUSQ#Value.1185244855.1", "approved"))+(((localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("WvoEJCeYM0aF7W01rtxUSQ#Value.182414732.1", "by a substitute."))) : ("."))), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = false },localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval,localVars.inParami_FolioId,0,cancellationToken);

// ClearOtherPossibleApprovers2
await Actions.ActionClearOtherPossibleApprovers(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.inParami_FolioApprovalLevelId,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// CommitTransaction3
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioNextApproverEmail2", "e4deb318-65d6-4708-83c0-c0bbbdcdc916"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioNextApproverEmail2", "e4deb318-65d6-4708-83c0-c0bbbdcdc916", "a3d02dd1-e313-409d-837e-fd413ba4d509", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload() {inParami_FolioId = localVars.inParami_FolioId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

goto RETURN_STATEMENT;

}

}

// ApprovRejectFolio_IsFinishApproval
(localVars.resApprovRejectFolio_IsFinishApproval.outParamo_Output,localVars.resApprovRejectFolio_IsFinishApproval.outParamo_StillHasApprovals) = await Actions.ActionApprovRejectFolio_IsFinishApproval(requestContext,localVars.queryResGetNextFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId,(!localVars.queryResGetNextFolioApprovalLevel_outParamList.Empty),localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio,localVars.inParami_FolioId,cancellationToken);

// IsSuccess?
if((localVars.resApprovRejectFolio_IsFinishApproval.outParamo_Output.ssIsSuccess)) {
// o_StillHasApprovals?
if((localVars.resApprovRejectFolio_IsFinishApproval.outParamo_StillHasApprovals)) {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// CommitTransaction4
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioNextApproverEmail3", "479e7a82-1932-4ee5-b4df-27f9fa8c849e"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioNextApproverEmail3", "479e7a82-1932-4ee5-b4df-27f9fa8c849e", "a3d02dd1-e313-409d-837e-fd413ba4d509", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload() {inParami_FolioId = localVars.inParami_FolioId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

} else {
// CallEntryAccountingFolio
localVars.resCallEntryAccountingFolio.outParamo_Output = await Actions.ActionCallEntryAccountingFolio(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio,false,localVars.inParamOffsetUtc,cancellationToken);

// o_Output.IsSuccess = CallEntryAccountingFolio.o_Output.IsSuccess
result.outParamo_Output.ssIsSuccess = localVars.resCallEntryAccountingFolio.outParamo_Output.ssIsSuccess;

// o_Output.Message = CallEntryAccountingFolio.o_Output.Message
result.outParamo_Output.ssMessage = localVars.resCallEntryAccountingFolio.outParamo_Output.ssMessage;
}

} else {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (localVars.resApprovRejectFolio_IsFinishApproval.outParamo_Output.ssMessage);

}

}

}

} else {
// ApprovRejectFolio_NotApproved
localVars.resApprovRejectFolio_NotApproved.outParamo_Output = await Actions.ActionApprovRejectFolio_NotApproved(requestContext,localVars.inParami_FolioId,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,localVars.inParami_Comment,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolio,(((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())),cancellationToken);

// IsSuccess?
if((localVars.resApprovRejectFolio_NotApproved.outParamo_Output.ssIsSuccess)) {
// ClearOtherPossibleApprovers3
await Actions.ActionClearOtherPossibleApprovers(requestContext,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.inParami_FolioApprovalLevelId,localVars.queryResGetFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (localVars.resApprovRejectFolio_NotApproved.outParamo_Output.ssMessage);

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

public static class FuncActionApprovRejectFolio {

private static async Task<RC_9c2c2f8777df5db915ea9753325ce8dd> datasetGetApprovalProcessReadDbAsync(RC_9c2c2f8777df5db915ea9753325ce8dd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcess" DogsCMyciU+rNXjyJCcl0w of Action "ApprovRejectFolio"
public static async Task<(RL_acd66b694d90eb775616e6c6e3f83477,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploApprovalProcess_Id,string qpteApprovalProcess_Version,string qpteProcessType_Code,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectFolio.GetApprovalProcess", "082c880e-9ccc-4f89-ab35-78f2242725d3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectFolio.GetApprovalProcess", "082c880e-9ccc-4f89-ab35-78f2242725d3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aXEDKzKy_U688DJ6Wq5z5g/NodesNotShownInESpaceTree.DogsCMyciU+rNXjyJCcl0w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess3\" Left JOIN {ProcessType} \"enprocesstype1\" ON (\"enapprovalprocess3\".\"processtypeid\" = \"enprocesstype1\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qploApprovalProcess_Id IS NOT NULL) THEN (CASE WHEN (\"enapprovalprocess3\".\"id\" = (@qploApprovalProcess_Id)) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((\"enprocesstype1\".\"code\" = @qpteProcessType_Code) AND (cast(\"enapprovalprocess3\".\"version\" as text) = @qpteApprovalProcess_Version)) THEN 1 ELSE 0 END) END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qploApprovalProcess_Id", DbType.Int64, qploApprovalProcess_Id);
sqlCmd.CreateParameterWithoutReplacements("@qpteProcessType_Code", DbType.String, qpteProcessType_Code);
sqlCmd.CreateParameterWithoutReplacements("@qpteApprovalProcess_Version", DbType.String, qpteApprovalProcess_Version);
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
RL_acd66b694d90eb775616e6c6e3f83477 outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectFolio.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_acd66b694d90eb775616e6c6e3f83477 _tmp = new RL_acd66b694d90eb775616e6c6e3f83477();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectFolio.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_acd66b694d90eb775616e6c6e3f83477)_tmp;
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

private static async Task<RC_1b390f8e281aa018cfe8a81d34cdb757> datasetGetFolioApprovalLevelReadDbAsync(RC_1b390f8e281aa018cfe8a81d34cdb757 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevel" yGdOdvZ8MUqbIRCQsg0Zmg of Action "ApprovRejectFolio"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectFolio.GetFolioApprovalLevel", "764e67c8-7cf6-4a31-9b21-1090b20d199a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectFolio.GetFolioApprovalLevel", "764e67c8-7cf6-4a31-9b21-1090b20d199a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aXEDKzKy_U688DJ6Wq5z5g/NodesNotShownInESpaceTree.yGdOdvZ8MUqbIRCQsg0Zmg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio6\".\"id\" o0, \"enfolio6\".\"isdraft\" o1, \"enfolio6\".\"folionumber\" o2, \"enfolio6\".\"canproveedorcancel\" o3, \"enfolio6\".\"orderid\" o4, \"enfolio6\".\"supplierid\" o5, \"enfolio6\".\"companyid\" o6, \"enfolio6\".\"foliostatusid\" o7, trim_scale(\"enfolio6\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio6\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio6\".\"partialamount\"::numeric) o10, \"enfolio6\".\"currencyid\" o11, \"enfolio6\".\"firstapproveruserid\" o12, \"enfolio6\".\"approvalprocesstypeid\" o13, \"enfolio6\".\"sapentryerror\" o14, \"enfolio6\".\"createdby\" o15, \"enfolio6\".\"createdon\" o16, \"enfolio6\".\"updatedby\" o17, \"enfolio6\".\"updatedon\" o18, \"enfolio6\".\"minuteselected\" o19, \"enfolioapproval5\".\"id\" o20, \"enfolioapproval5\".\"folioid\" o21, \"enfolioapproval5\".\"approvalprocessid\" o22, \"enfolioapproval5\".\"processtypecode\" o23, \"enfolioapproval5\".\"approvalprocessversion\" o24, \"enfolioapproval5\".\"currentlevel\" o25, \"enfolioapproval5\".\"maxlevel\" o26, \"enfolioapproval5\".\"startedon\" o27, \"enfolioapproval5\".\"finishedon\" o28, \"enfolioapproval5\".\"regionid\" o29, \"enfolioapprovallevel4\".\"id\" o30, \"enfolioapprovallevel4\".\"folioapprovalid\" o31, \"enfolioapprovallevel4\".\"levelnumber\" o32, \"enfolioapprovallevel4\".\"applicationroleid\" o33, \"enfolioapprovallevel4\".\"entrajobtitle\" o34, \"enfolioapprovallevel4\".\"entraroleid\" o35, \"enfolioapprovallevel4\".\"departmentid\" o36, \"enfolioapprovallevel4\".\"assignedto\" o37, \"enfolioapprovallevel4\".\"approvalstatusid\" o38, \"enfolioapprovallevel4\".\"ismandatory\" o39, \"enfolioapprovallevel4\".\"isreassigned\" o40, \"enfolioapprovallevel4\".\"approvedby\" o41, \"enfolioapprovallevel4\".\"approvedon\" o42, \"enfolioapprovallevel4\".\"canceledby\" o43, \"enfolioapprovallevel4\".\"canceledon\" o44, \"enfolioapprovallevel4\".\"rejectedby\" o45, \"enfolioapprovallevel4\".\"rejectedon\" o46, \"enfolioapprovallevel4\".\"issubstitutefor\" o47, \"enfolioapprovallevel4\".\"rejectreason\" o48, \"enfolioapprovallevel4\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({Folio} \"enfolio6\" Left JOIN {FolioApproval} \"enfolioapproval5\" ON (\"enfolio6\".\"id\" = \"enfolioapproval5\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel4\" ON (\"enfolioapproval5\".\"id\" = \"enfolioapprovallevel4\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enfolioapprovallevel4\".\"id\" = @qpfoFolioApprovalLevel_Id) AND (\"enfolioapprovallevel4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalLevel_Id", DbType.Int64, qpfoFolioApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enfolioapprovallevel4\".\"id\" IS NULL)");
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
RL_ae9182bb38290e8d92b0cbd2d4f71569 outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectFolio.GetFolioApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae9182bb38290e8d92b0cbd2d4f71569 _tmp = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectFolio.GetFolioApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ae9182bb38290e8d92b0cbd2d4f71569)_tmp;
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

private static async Task<RC_c4212a2ad9aed3b4ecb882ed30f5e868> datasetGetNextFolioApprovalLevelReadDbAsync(RC_c4212a2ad9aed3b4ecb882ed30f5e868 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetNextFolioApprovalLevel" A7j2qEC7u0SibIO9VR40tQ of Action "ApprovRejectFolio"
public static async Task<(RL_8ba9481252bc5c90efb1f40f454c1643,long)> datasetGetNextFolioApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_Id,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectFolio.GetNextFolioApprovalLevel", "a8f6b803-bb40-44bb-a26c-83bd551e34b5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectFolio.GetNextFolioApprovalLevel", "a8f6b803-bb40-44bb-a26c-83bd551e34b5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aXEDKzKy_U688DJ6Wq5z5g/NodesNotShownInESpaceTree.A7j2qEC7u0SibIO9VR40tQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enfolioapprovallevel5\".\"id\" o37, \"enfolioapprovallevel5\".\"folioapprovalid\" o38, \"enfolioapprovallevel5\".\"levelnumber\" o39, \"enfolioapprovallevel5\".\"applicationroleid\" o40, \"enfolioapprovallevel5\".\"entrajobtitle\" o41, \"enfolioapprovallevel5\".\"entraroleid\" o42, \"enfolioapprovallevel5\".\"departmentid\" o43, \"enfolioapprovallevel5\".\"assignedto\" o44, \"enfolioapprovallevel5\".\"approvalstatusid\" o45, \"enfolioapprovallevel5\".\"ismandatory\" o46, \"enfolioapprovallevel5\".\"isreassigned\" o47, \"enfolioapprovallevel5\".\"approvedby\" o48, \"enfolioapprovallevel5\".\"approvedon\" o49, \"enfolioapprovallevel5\".\"canceledby\" o50, \"enfolioapprovallevel5\".\"canceledon\" o51, \"enfolioapprovallevel5\".\"rejectedby\" o52, \"enfolioapprovallevel5\".\"rejectedon\" o53, \"enfolioapprovallevel5\".\"issubstitutefor\" o54, \"enfolioapprovallevel5\".\"rejectreason\" o55, \"enfolioapprovallevel5\".\"isinvoiceapproval\" o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85");
fromBuilder.Append(" FROM (((({Folio} \"enfolio7\" Left JOIN {FolioApproval} \"enfolioapproval6\" ON (\"enfolio7\".\"id\" = \"enfolioapproval6\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel5\" ON (\"enfolioapproval6\".\"id\" = \"enfolioapprovallevel5\".\"folioapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole3\" ON (\"enfolioapprovallevel5\".\"applicationroleid\" = \"enapplicationrole3\".\"id\"))  Left JOIN {OrderMain} \"enordermain10\" ON (\"enfolio7\".\"orderid\" = \"enordermain10\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_Id != 0) {
whereBuilder.Append("((\"enfolioapproval6\".\"id\" = @qpfoFolioApproval_Id) AND (\"enfolioapproval6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_Id", DbType.Int64, qpfoFolioApproval_Id);
} else {
whereBuilder.Append("(\"enfolioapproval6\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel5\".\"levelnumber\" > @qpinLevelNumber)");
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel5\".\"levelnumber\" ASC ");
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
RL_8ba9481252bc5c90efb1f40f454c1643 outParamList = new RL_8ba9481252bc5c90efb1f40f454c1643();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextFolioApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectFolio.GetNextFolioApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8ba9481252bc5c90efb1f40f454c1643 _tmp = new RL_8ba9481252bc5c90efb1f40f454c1643();
_tmp.AlternateReadDbMethodAsync = datasetGetNextFolioApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectFolio.GetNextFolioApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8ba9481252bc5c90efb1f40f454c1643)_tmp;
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
