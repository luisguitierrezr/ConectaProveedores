namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioReassignFromReject : VarsBag {
public long inParami_FolioId;
public string inParami_AssignUserId;
public long inParami_AssignApprovalProcessId;
public string inParami_Comment;
/// <summary>
/// Variable <code>l_CurrentEmail</code> that represents the Service Studio Text
///  <code>l_CurrentEmail</code> <p>Description: Current Email.</p>
/// </summary>
public string varLcl_CurrentEmail = "";

/// <summary>
/// Variable <code>l_FolioApproval</code> that represents the Service Studio FolioApproval
///  <code>l_FolioApproval</code> <p>Description: FolioApproval</p>
/// </summary>
public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord varLcl_FolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();

/// <summary>
/// Variable <code>l_FolioApprovalLevel</code> that represents the Service Studio FolioApprovalLevel
///  <code>l_FolioApprovalLevel</code> <p>Description: FolioApprovalLevel</p>
/// </summary>
public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord varLcl_FolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();

/// <summary>
/// Variable <code>l_HasStarted</code> that represents the Service Studio Boolean
///  <code>l_HasStarted</code> <p>Description: Has Started.</p>
/// </summary>
public bool varLcl_HasStarted = false;

/// <summary>
/// Variable <code>l_FolioApprovalLevelsList</code> that represents the Service Studio
///  FolioApprovalLevelList <code>l_FolioApprovalLevelsList</code> <p>Description: FolioApprovalLeve
/// l List</p>
/// </summary>
public RL_4391d3239f28e5f33772aaade6de0b0d varLcl_FolioApprovalLevelsList = new RL_4391d3239f28e5f33772aaade6de0b0d();

/// <summary>
/// Variable <code>l_UserNameAssigned</code> that represents the Service Studio Text
///  <code>l_UserNameAssigned</code> <p>Description: </p>
/// </summary>
public string varLcl_UserNameAssigned = "";

public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcessById_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public Actions.lcoGetApprovalProcessDef resGetApprovalProcessDef =  new Actions.lcoGetApprovalProcessDef();
public Actions.lcoInitFolioWF_FromApprovProcId resInitFolioWF_FromApprovProcId =  new Actions.lcoInitFolioWF_FromApprovProcId();
public RL_57593cd225237ead1eaddf28b138c8a4 queryResGetFolioById_outParamList = new RL_57593cd225237ead1eaddf28b138c8a4();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public RL_9c381d2572dc5728206299b483871a2e queryResGetFirstApproverUserData_outParamList = new RL_9c381d2572dc5728206299b483871a2e();
public long queryResGetFirstApproverUserData_outParamCount = 0L;

public Actions.lcoGetUserRole resGetUserRole =  new Actions.lcoGetUserRole();
public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public lcvFolioReassignFromReject(long inParami_FolioId, string inParami_AssignUserId, long inParami_AssignApprovalProcessId, string inParami_Comment) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_AssignUserId = inParami_AssignUserId;
this.inParami_AssignApprovalProcessId = inParami_AssignApprovalProcessId;
this.inParami_Comment = inParami_Comment;
}
}
public class lcoFolioReassignFromReject : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioReassignFromReject() {
}
}
/// <summary>
/// Action <code>FolioReassignFromReject</code> that represents the Service Studio action
///  <code>FolioReassignFromReject</code> <p> Description: Action to Reassign Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioReassignFromReject(IRequestContext requestContext,long inParami_FolioId,string inParami_AssignUserId,long inParami_AssignApprovalProcessId,string inParami_Comment,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioReassignFromReject result = new lcoFolioReassignFromReject();
lcvFolioReassignFromReject localVars = new lcvFolioReassignFromReject(inParami_FolioId, inParami_AssignUserId, inParami_AssignApprovalProcessId, inParami_Comment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioReassignFromReject", "41d98836-dd6b-489a-a814-7c7b04a78163"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioReassignFromReject", "41d98836-dd6b-489a-a814-7c7b04a78163", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioReassignFromReject.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("A7Yw308GZkadgU+wNTwT7A#Value.1482511939.1", "Folio not found!");
} else {
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("EiZgcCAn4UGEW6ZxqMNDhQ#Value.1911675613.1", "Folio cannot be updated!");
} else {
// FolioApprovalDelete
await Actions.ActionFolioApprovalDelete(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId,cancellationToken);

if(((localVars.inParami_AssignUserId!=BuiltInFunction.NullTextIdentifier ()))) {
// GetFolioById.List.Current.Folio.FirstApproverUserId = i_AssignUserId
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFirstApproverUserId = localVars.inParami_AssignUserId;

// GetFolioById.List.Current.Folio.ApprovalProcessTypeId = Normal
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId = 4;
// Query datasetGetFirstApproverUserData
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFirstApproverUserData_maxRecords = 1;
if (datasetGetFirstApproverUserData_maxRecords < 1) datasetGetFirstApproverUserData_maxRecords = 1;
int datasetGetFirstApproverUserData_startIndex = 0;(localVars.queryResGetFirstApproverUserData_outParamList,localVars.queryResGetFirstApproverUserData_outParamCount) = await FuncActionFolioReassignFromReject.datasetGetFirstApproverUserData(requestContext,datasetGetFirstApproverUserData_maxRecords,datasetGetFirstApproverUserData_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFirstApproverUserId,cancellationToken);

// Not found?
if((localVars.queryResGetFirstApproverUserData_outParamList.Empty)) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("l8LGh_i1wkCOhmDlP9lYKg#Message.1545252646.1", "First approver selected not found!"));

} else {
// GetApprovalProcessDef
(localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess,localVars.resGetApprovalProcessDef.outParamo_Output) = await Actions.ActionGetApprovalProcessDef(requestContext,AppUtils.GetStringResource("OQRjas+L+EWEJ1p5YHEgGQ#Value.363639310.1", "FolioSAE"),localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssRegionId,localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENDepartment.ssName,localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENTelcelDirection.ssName,localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId,localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENUser_Extended_Internal.ssDepartmentId,false,false,4,false,0L,cancellationToken);

// IsSuccess
if((localVars.resGetApprovalProcessDef.outParamo_Output.ssIsSuccess)) {
// l_CurrentEmail = If
localVars.varLcl_CurrentEmail=(((localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENUser.ssEmail));

// l_UserNameAssigned = GetFirstApproverUserData.List.Current.User.Name
localVars.varLcl_UserNameAssigned=localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENUser.ssName;
// l_FolioApproval
// l_FolioApproval.Id = NullIdentifier
localVars.varLcl_FolioApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_FolioApproval.FolioId = i_FolioId
localVars.varLcl_FolioApproval.ssFolioId = localVars.inParami_FolioId;

// l_FolioApproval.ProcessTypeCode = GetApprovalProcessDef.o_ApprovalProcess.ProcessTypeCode
localVars.varLcl_FolioApproval.ssProcessTypeCode = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssProcessTypeCode;

// l_FolioApproval.ApprovalProcessVersion = GetApprovalProcessDef.o_ApprovalProcess.Version
localVars.varLcl_FolioApproval.ssApprovalProcessVersion = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssVersion;

// l_FolioApproval.CurrentLevel = 1
localVars.varLcl_FolioApproval.ssCurrentLevel = 1;

// l_FolioApproval.StartedOn = CurrDateTime
localVars.varLcl_FolioApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_FolioApproval.ApprovalProcessId = GetApprovalProcessDef.o_ApprovalProcess.ApprovalProcessId
localVars.varLcl_FolioApproval.ssApprovalProcessId = localVars.resGetApprovalProcessDef.outParamo_ApprovalProcess.ssApprovalProcessId;

// l_FolioApproval.RegionId = NullIdentifier
localVars.varLcl_FolioApproval.ssRegionId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
// GetUserRole
localVars.resGetUserRole.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFirstApproverUserId,2,true,false,cancellationToken);

// l_FolioApprovalLevel
// l_FolioApprovalLevel.Id = NullIdentifier
localVars.varLcl_FolioApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_FolioApprovalLevel.LevelNumber = 1
localVars.varLcl_FolioApprovalLevel.ssLevelNumber = 1;

// l_FolioApprovalLevel.ApplicationRoleId = GetUserRole.o_ApplicationRoleId
localVars.varLcl_FolioApprovalLevel.ssApplicationRoleId = localVars.resGetUserRole.outParamo_ApplicationRoleId;

// l_FolioApprovalLevel.AssignedTo = GetFolioById.List.Current.Folio.FirstApproverUserId
localVars.varLcl_FolioApprovalLevel.ssAssignedTo = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFirstApproverUserId;

// l_FolioApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_FolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_FolioApprovalLevel.EntraJobTitle = GetFirstApproverUserData.List.Current.EntraRole.RoleName
localVars.varLcl_FolioApprovalLevel.ssEntraJobTitle = localVars.queryResGetFirstApproverUserData_outParamList.CurrentRec.ssENEntraRole.ssRoleName;
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_FolioApprovalLevelsList,localVars.varLcl_FolioApprovalLevel,cancellationToken);

// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.varLcl_FolioApproval,cancellationToken);

// Foreach l_FolioApprovalLevelsList
localVars.varLcl_FolioApprovalLevelsList.StartIteration();
try {while (!((localVars.varLcl_FolioApprovalLevelsList.Eof))) {
// l_FolioApprovalLevelsList.Current.FolioApprovalId = FolioApprovalCreateOrUpdate.Id
localVars.varLcl_FolioApprovalLevelsList.CurrentRec.ssFolioApprovalId = localVars.resFolioApprovalCreateOrUpdate.outParamId;

// l_FolioApprovalLevelsList.Current.ApprovalStatusId = If
localVars.varLcl_FolioApprovalLevelsList.CurrentRec.ssApprovalStatusId = (((!localVars.varLcl_HasStarted)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId));
if(((!localVars.varLcl_HasStarted))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.varLcl_FolioApprovalLevelsList.CurrentRec.ssAssignedTo,cancellationToken);

// l_FolioApprovalLevelsList.Current.AssignedTo = If
localVars.varLcl_FolioApprovalLevelsList.CurrentRec.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.varLcl_FolioApprovalLevelsList.CurrentRec.ssAssignedTo) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// l_FolioApprovalLevelsList.Current.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.varLcl_FolioApprovalLevelsList.CurrentRec.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
}

// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_FolioApprovalLevelsList.CurrentRec,cancellationToken);

// l_HasStarted = True
localVars.varLcl_HasStarted=true;
localVars.varLcl_FolioApprovalLevelsList.Advance();
}

} finally {
localVars.varLcl_FolioApprovalLevelsList.EndIteration();
}

} else {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (localVars.resGetApprovalProcessDef.outParamo_Output.ssMessage);

}

}

} else {
// InitFolioWF_FromApprovProcId
localVars.resInitFolioWF_FromApprovProcId.outParamo_Output = await Actions.ActionInitFolioWF_FromApprovProcId(requestContext,localVars.inParami_FolioId,localVars.inParami_AssignApprovalProcessId,(((localVars.inParami_AssignApprovalProcessId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (3) : (BuiltInFunction.NullIdentifier ())),AppUtils.GetStringResource("bD3TIPE0YEuDaxOHw7+W9w#Value.363639310.1", "FolioSAE"),cancellationToken);

// IsSuccess?
if((localVars.resInitFolioWF_FromApprovProcId.outParamo_Output.ssIsSuccess)) {
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 1;
if (datasetGetApprovalProcessById_maxRecords < 1) datasetGetApprovalProcessById_maxRecords = 1;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionFolioReassignFromReject.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Never,localVars.inParami_AssignApprovalProcessId,cancellationToken);

// GetFolioById.List.Current.Folio.ApprovalProcessTypeId = GetApprovalProcessById.List.Current.ApprovalProcess.ApprovalProcessTypeId
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId = localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcess.ssApprovalProcessTypeId;
} else {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (localVars.resInitFolioWF_FromApprovProcId.outParamo_Output.ssMessage);

}

}

// Status
// GetFolioById.List.Current.Folio.FolioStatusId = PendingApproval
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId;

// GetFolioById.List.Current.Folio.CanProveedorCancel = True
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = true;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((((((AppUtils.GetStringResource("YbJMDPRI1EqDwcp2Wn6RMw#Value.2195684.1", "Form")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("YbJMDPRI1EqDwcp2Wn6RMw#Value.801981423.1", "has been reassigned"))+(((localVars.inParami_AssignUserId!=BuiltInFunction.NullTextIdentifier ())) ? (((((" "+AppUtils.GetStringResource("YbJMDPRI1EqDwcp2Wn6RMw#Value.3707.1", "to"))+" ")+localVars.varLcl_UserNameAssigned)+".")) : (".")))+" ")+AppUtils.GetStringResource("YbJMDPRI1EqDwcp2Wn6RMw#Value.-1679915457.1", "Comment"))+": ")+localVars.inParami_Comment), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioNextApproverEmail", "de0d8fec-1183-4b44-8cd3-551f2d0f0980"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioNextApproverEmail", "de0d8fec-1183-4b44-8cd3-551f2d0f0980", "a3d02dd1-e313-409d-837e-fd413ba4d509", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload() {inParami_FolioId = localVars.inParami_FolioId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

}

}

} //close CreateActionActivity using block
} // try

catch (Ex_InitializeWFUserException ex) {
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

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

public static class FuncActionFolioReassignFromReject {

// Query Function "GetApprovalProcessById" dqh8VyZSZUmqKp4vjphVfg of Action "FolioReassignFromReject"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignFromReject.GetApprovalProcessById", "577ca876-5226-4965-aa2a-9e2f8e98557e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignFromReject.GetApprovalProcessById", "577ca876-5226-4965-aa2a-9e2f8e98557e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.NojZQWvdmkioFHx7BKeBYw/NodesNotShownInESpaceTree.dqh8VyZSZUmqKp4vjphVfg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enapprovalprocess5\".\"approvalprocesstypeid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess5\"");
whereBuilder.Append(" WHERE ");
if (qpapId != 0) {
whereBuilder.Append("((\"enapprovalprocess5\".\"id\" = @qpapId) AND (\"enapprovalprocess5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapId", DbType.Int64, qpapId);
} else {
whereBuilder.Append("(\"enapprovalprocess5\".\"id\" IS NULL)");
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignFromReject.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignFromReject.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_497f735a522829d94999357ea05280c6> datasetGetFolioByIdReadDbAsync(RC_497f735a522829d94999357ea05280c6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" XgqgdhanYE2_FO2kaJ8iCg of Action "FolioReassignFromReject"
public static async Task<(RL_57593cd225237ead1eaddf28b138c8a4,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignFromReject.GetFolioById", "76a00a5e-a716-4d60-bf14-eda4689f220a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignFromReject.GetFolioById", "76a00a5e-a716-4d60-bf14-eda4689f220a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.NojZQWvdmkioFHx7BKeBYw/NodesNotShownInESpaceTree.XgqgdhanYE2_FO2kaJ8iCg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio9\".\"id\" o0, \"enfolio9\".\"isdraft\" o1, \"enfolio9\".\"folionumber\" o2, \"enfolio9\".\"canproveedorcancel\" o3, \"enfolio9\".\"orderid\" o4, \"enfolio9\".\"supplierid\" o5, \"enfolio9\".\"companyid\" o6, \"enfolio9\".\"foliostatusid\" o7, trim_scale(\"enfolio9\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio9\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio9\".\"partialamount\"::numeric) o10, \"enfolio9\".\"currencyid\" o11, \"enfolio9\".\"firstapproveruserid\" o12, \"enfolio9\".\"approvalprocesstypeid\" o13, \"enfolio9\".\"sapentryerror\" o14, \"enfolio9\".\"createdby\" o15, \"enfolio9\".\"createdon\" o16, \"enfolio9\".\"updatedby\" o17, \"enfolio9\".\"updatedon\" o18, \"enfolio9\".\"minuteselected\" o19, \"enfolioapproval8\".\"id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enfolioapprovallevel7\".\"id\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, \"enordermain19\".\"regionid\" o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78");
fromBuilder.Append(" FROM ((({Folio} \"enfolio9\" Left JOIN {FolioApproval} \"enfolioapproval8\" ON (\"enfolio9\".\"id\" = \"enfolioapproval8\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel7\" ON (((\"enfolioapproval8\".\"id\" = \"enfolioapprovallevel7\".\"folioapprovalid\") AND (\"enfolioapprovallevel7\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(")) AND (\"enfolioapprovallevel7\".\"rejectreason\" <> '')))  Left JOIN {OrderMain} \"enordermain19\" ON (\"enfolio9\".\"orderid\" = \"enordermain19\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio9\".\"id\" = @qpfoFolio_Id) AND (\"enfolio9\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio9\".\"id\" IS NULL)");
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
RL_57593cd225237ead1eaddf28b138c8a4 outParamList = new RL_57593cd225237ead1eaddf28b138c8a4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignFromReject.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_57593cd225237ead1eaddf28b138c8a4 _tmp = new RL_57593cd225237ead1eaddf28b138c8a4();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignFromReject.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_57593cd225237ead1eaddf28b138c8a4)_tmp;
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

private static async Task<RC_334fa46a307bf0dfedbddfd14d3375f8> datasetGetFirstApproverUserDataReadDbAsync(RC_334fa46a307bf0dfedbddfd14d3375f8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDepartment.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetFirstApproverUserData" PxFXlt8arE+1Jvhk3J0r7A of Action "FolioReassignFromReject"
public static async Task<(RL_9c381d2572dc5728206299b483871a2e,long)> datasetGetFirstApproverUserData(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignFromReject.GetFirstApproverUserData", "9657113f-1adf-4fac-b526-f864dc9d2bec");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignFromReject.GetFirstApproverUserData", "9657113f-1adf-4fac-b526-f864dc9d2bec", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.NojZQWvdmkioFHx7BKeBYw/NodesNotShownInESpaceTree.PxFXlt8arE+1Jvhk3J0r7A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"endepartment2\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enentrarole5\".\"rolename\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"entelceldirection3\".\"name\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enuser43\".\"name\" o21, \"enuser43\".\"email\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enuser_extended_internal27\".\"departmentid\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enuser_extended_internal27\".\"entraroleid\" o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"enuserextension24\".\"correspondentexternalemail\" o46, NULL o47");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal27\" Inner JOIN {User} \"enuser43\" ON (\"enuser_extended_internal27\".\"id\" = \"enuser43\".\"id\"))  Left JOIN {Department} \"endepartment2\" ON (\"enuser_extended_internal27\".\"departmentid\" = \"endepartment2\".\"id\"))  Left JOIN {UserExtension} \"enuserextension24\" ON (\"enuser43\".\"id\" = \"enuserextension24\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection3\" ON (\"enuser_extended_internal27\".\"telceldirectionid\" = \"entelceldirection3\".\"id\"))  Left JOIN {EntraRole} \"enentrarole5\" ON (\"enuser_extended_internal27\".\"entraroleid\" = \"enentrarole5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser43\".\"id\" = @qpusUser_Id) AND (\"enuser43\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser43\".\"id\" IS NULL)");
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
RL_9c381d2572dc5728206299b483871a2e outParamList = new RL_9c381d2572dc5728206299b483871a2e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFirstApproverUserDataReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignFromReject.GetFirstApproverUserData.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9c381d2572dc5728206299b483871a2e _tmp = new RL_9c381d2572dc5728206299b483871a2e();
_tmp.AlternateReadDbMethodAsync = datasetGetFirstApproverUserDataReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignFromReject.GetFirstApproverUserData.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9c381d2572dc5728206299b483871a2e)_tmp;
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
