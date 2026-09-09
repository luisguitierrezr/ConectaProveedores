namespace ssConectaProveedores;

public partial class Actions {
public class lcvApproveModifyRequisition : VarsBag {
public long inParami_RequisitionId;
public long inParami_RequisitionApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public Actions.lcoRequisitionLogAdd resRequisitionLogAddApprove2 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate2 =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionApprovalLevel_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionApprovalLevel_outParamCount = 0L;

public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate3 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitionCommentCreateOrUpdate resRequisitionCommentCreateOrUpdate =  new Actions.lcoRequisitionCommentCreateOrUpdate();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate2 =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public RL_87311ea350338b4dcd53388d23fa3f86 queryResGetUserApplicationRolesByUserId_outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
public long queryResGetUserApplicationRolesByUserId_outParamCount = 0L;

public Actions.lcoRequisitionLogAdd resRequisitionLogAddModify =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd5 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoGetReqNextApprover resGetReqNextApprover =  new Actions.lcoGetReqNextApprover();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAddApprove =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public lcvApproveModifyRequisition(long inParami_RequisitionId, long inParami_RequisitionApprovalLevelId, bool inParami_IsApprove, string inParami_Comment) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
}
}
public class lcoApproveModifyRequisition : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApproveModifyRequisition() {
}
}
/// <summary>
/// Action <code>ApproveModifyRequisition</code> that represents the Service Studio action
///  <code>ApproveModifyRequisition</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApproveModifyRequisition(IRequestContext requestContext,long inParami_RequisitionId,long inParami_RequisitionApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoApproveModifyRequisition result = new lcoApproveModifyRequisition();
lcvApproveModifyRequisition localVars = new lcvApproveModifyRequisition(inParami_RequisitionId, inParami_RequisitionApprovalLevelId, inParami_IsApprove, inParami_Comment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApproveModifyRequisition", "6f288c61-39ed-40cb-a64c-63475d621c99"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApproveModifyRequisition", "6f288c61-39ed-40cb-a64c-63475d621c99", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetRequisitionApprovalLevel_maxRecords < 1) datasetGetRequisitionApprovalLevel_maxRecords = 1;
int datasetGetRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevel_outParamList,localVars.queryResGetRequisitionApprovalLevel_outParamCount) = await FuncActionApproveModifyRequisition.datasetGetRequisitionApprovalLevel(requestContext,datasetGetRequisitionApprovalLevel_maxRecords,datasetGetRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionApprovalLevelId,cancellationToken);

if(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Requisition cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("PT8aoL7dokiwk_JZYTyLWw#Value.1333646474.1", "Requisition cannot be updated!");
} else {
// Query datasetGetUserApplicationRolesByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRolesByUserId_maxRecords = 1;
if (datasetGetUserApplicationRolesByUserId_maxRecords < 1) datasetGetUserApplicationRolesByUserId_maxRecords = 1;
int datasetGetUserApplicationRolesByUserId_startIndex = 0;(localVars.queryResGetUserApplicationRolesByUserId_outParamList,localVars.queryResGetUserApplicationRolesByUserId_outParamCount) = await FuncActionApproveModifyRequisition.datasetGetUserApplicationRolesByUserId(requestContext,datasetGetUserApplicationRolesByUserId_maxRecords,datasetGetUserApplicationRolesByUserId_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApplicationRoleId,BuiltInFunction.GetUserId (),cancellationToken);

if((localVars.inParami_IsApprove)) {
// Are there more levels?
if(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber<localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssMaxLevel))) {
// GetReqNextApprover
(localVars.resGetReqNextApprover.outParamo_Output,localVars.resGetReqNextApprover.outParamo_UserId) = await Actions.ActionGetReqNextApprover(requestContext,localVars.inParami_RequisitionId,BuiltInFunction.GetUserId (),false,cancellationToken);

// IsSuccess
if((localVars.resGetReqNextApprover.outParamo_Output.ssIsSuccess)) {
// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedBy = GetUserId
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;
// RequisitionApprovalLevelCreateOrUpdate3
localVars.resRequisitionApprovalLevelCreateOrUpdate3.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionLogAddApprove2
localVars.resRequisitionLogAddApprove2.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("qh9yfwCz50aDr4YjduJq_Q#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("qh9yfwCz50aDr4YjduJq_Q#Value.1185244855.1", "approved"))+(((!localVars.queryResGetUserApplicationRolesByUserId_outParamList.Empty)) ? ((" "+AppUtils.GetStringResource("qh9yfwCz50aDr4YjduJq_Q#Value.182414732.1", "by a substitute."))) : ("."))) },cancellationToken);

// GetReqNextApprovalProcessLevel
await Actions.ActionGetReqNextApprovalProcessLevel(requestContext,localVars.inParami_RequisitionId,localVars.queryResGetUserApplicationRolesByUserId_outParamList.Empty,localVars.resGetReqNextApprover.outParamo_UserId,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// RequisitionLogAdd5
localVars.resRequisitionLogAdd5.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((AppUtils.GetStringResource("JNharfOP1kuflFDNI9yyHw#Value.754280301.1", "Approval failed due to:")+" ")+localVars.resGetReqNextApprover.outParamo_Output.ssMessage) },cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Approval failed due to:" + " " + GetReqNextApprover.o_Output.Message
result.outParamo_Output.ssMessage = ((AppUtils.GetStringResource("q8guy0h2KU2FYWBAeKXQkA#Value.754280301.1", "Approval failed due to:")+" ")+localVars.resGetReqNextApprover.outParamo_Output.ssMessage);
}

} else {
// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedBy = GetUserId
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;
// RequisitionApprovalLevelCreateOrUpdate2
localVars.resRequisitionApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionLogAddApprove
localVars.resRequisitionLogAddApprove.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("VEsE1LHOEkm9MotW4AVfYg#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("VEsE1LHOEkm9MotW4AVfYg#Value.1185244855.1", "approved"))+(((!localVars.queryResGetUserApplicationRolesByUserId_outParamList.Empty)) ? ((" "+AppUtils.GetStringResource("VEsE1LHOEkm9MotW4AVfYg#Value.182414732.1", "by a substitute."))) : ("."))) },cancellationToken);

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.FinishedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.Requisition.RequisitionStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId;
// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval,cancellationToken);

// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("LxFjpvj3u02XdFD0wjeGXQ#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("LxFjpvj3u02XdFD0wjeGXQ#Value.-1625364909.1", "updated to Approved status.")) },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// SendReqApprovedEmail
await Actions.ActionSendReqApprovedEmail(requestContext,localVars.inParami_RequisitionId,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} else {
// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.RequestToModifyBy = GetUserId
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssRequestToModifyBy = BuiltInFunction.GetUserId ();

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
localVars.resRequisitionCommentCreateOrUpdate.outParamId = await Actions.ActionRequisitionCommentCreateOrUpdate(requestContext,new EN_cbeb601b681344342c8de0161d058f87EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("Q+rGOvxr0UWakrrNEZeW8g"))).ssId, ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionApprovalLevelId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId, ssApplicationRoleId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApplicationRoleId, ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = localVars.inParami_Comment },cancellationToken);

// RequisitionLogAddModify
localVars.resRequisitionLogAddModify.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((((((AppUtils.GetStringResource("wB6W9AmUD0O7SJ4Wv43AYQ#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("wB6W9AmUD0O7SJ4Wv43AYQ#Value.587526867.1", "requested to be modified"))+(((!localVars.queryResGetUserApplicationRolesByUserId_outParamList.Empty)) ? (((" "+AppUtils.GetStringResource("wB6W9AmUD0O7SJ4Wv43AYQ#Value.1391357666.1", "by a substitute"))+" ")) : (" ")))+AppUtils.GetStringResource("wB6W9AmUD0O7SJ4Wv43AYQ#Value.448016147.1", "with the following comment:"))+" ")+localVars.inParami_Comment) },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate2
localVars.resRequisitonStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionStatusId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// SendReqRequestToModifyEmails
await Actions.ActionSendReqRequestToModifyEmails(requestContext,localVars.inParami_RequisitionId,localVars.inParami_Comment,BuiltInFunction.GetUserId (),cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionApproveModifyRequisition {

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionApprovalLevelReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalLevel" fHB4KlSDvkC1a9gm_qF0tg of Action "ApproveModifyRequisition"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApproveModifyRequisition.GetRequisitionApprovalLevel", "2a78707c-8354-40be-b56b-d826fea174b6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApproveModifyRequisition.GetRequisitionApprovalLevel", "2a78707c-8354-40be-b56b-d826fea174b6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.YYwob+05y0CmTGNHXWIcmQ/NodesNotShownInESpaceTree.fHB4KlSDvkC1a9gm_qF0tg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition32\".\"id\" o0, \"enrequisition32\".\"name\" o1, \"enrequisition32\".\"counter\" o2, \"enrequisition32\".\"requisitionstatusid\" o3, \"enrequisition32\".\"supplierid\" o4, \"enrequisition32\".\"regionid\" o5, \"enrequisition32\".\"accountingregionid\" o6, \"enrequisition32\".\"applicantid\" o7, \"enrequisition32\".\"maxdatefinishcapture\" o8, \"enrequisition32\".\"projectassetserviceid\" o9, \"enrequisition32\".\"projectassetservice\" o10, \"enrequisition32\".\"projectdescription\" o11, \"enrequisition32\".\"frequencyid\" o12, \"enrequisition32\".\"issustainability\" o13, \"enrequisition32\".\"sustainabilityid\" o14, \"enrequisition32\".\"businessvaluecategoryid\" o15, \"enrequisition32\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition32\".\"totalamount\"::numeric) o17, \"enrequisition32\".\"currencyid\" o18, \"enrequisition32\".\"distributionid\" o19, \"enrequisition32\".\"costcenterid\" o20, \"enrequisition32\".\"hascontract\" o21, \"enrequisition32\".\"iscontractpending\" o22, \"enrequisition32\".\"hasdeposit\" o23, \"enrequisition32\".\"hasinsurance\" o24, \"enrequisition32\".\"hasadvancepayment\" o25, \"enrequisition32\".\"accountingservicetypeid_depr\" o26, \"enrequisition32\".\"servicedescription_deprec\" o27, \"enrequisition32\".\"invoiceusageid_deprec\" o28, \"enrequisition32\".\"serviceformatid\" o29, \"enrequisition32\".\"companyid\" o30, trim_scale(\"enrequisition32\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition32\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition32\".\"paymentmethodid\" o33, \"enrequisition32\".\"paymenttermsid\" o34, \"enrequisition32\".\"isautomaticaccounting\" o35, \"enrequisition32\".\"createdby\" o36, \"enrequisition32\".\"createdon\" o37, \"enrequisition32\".\"updatedon\" o38, \"enrequisition32\".\"updatedby\" o39, \"enrequisition32\".\"createdbyapplicationrole\" o40, \"enrequisition32\".\"dateofcommitment\" o41, \"enrequisition32\".\"hascontractfileuploaded\" o42, \"enrequisition32\".\"hasupdateddateofcommitment\" o43, \"enrequisition32\".\"submittedon\" o44, \"enrequisition32\".\"isdonation\" o45, \"enrequisition32\".\"advwithoutinvoice\" o46, \"enrequisition32\".\"wasadvwithoutinvoice\" o47, \"enrequisition32\".\"isadvanced\" o48, \"enrequisition32\".\"documenttypeid\" o49, \"enrequisition32\".\"iscreatedbyanassistente\" o50, \"enrequisition32\".\"telceldirectionid\" o51, \"enrequisition32\".\"hasmultiupload\" o52, \"enrequisition32\".\"accountingdate\" o53, \"enrequisition32\".\"paymentoptionsid\" o54, \"enrequisition32\".\"paymentwaysid\" o55, \"enrequisition32\".\"buydocnumber\" o56, \"enrequisition32\".\"buydocposition\" o57, \"enrequisitionapproval10\".\"id\" o58, \"enrequisitionapproval10\".\"requisitionid\" o59, \"enrequisitionapproval10\".\"aprovalprocessid\" o60, \"enrequisitionapproval10\".\"processtypecode\" o61, \"enrequisitionapproval10\".\"approvalprocessversion\" o62, \"enrequisitionapproval10\".\"currentlevel\" o63, \"enrequisitionapproval10\".\"maxlevel\" o64, \"enrequisitionapproval10\".\"startedon\" o65, \"enrequisitionapproval10\".\"finishedon\" o66, \"enrequisitionapproval10\".\"hasstartedaccounting\" o67, \"enrequisitionapprovallevel9\".\"id\" o68, \"enrequisitionapprovallevel9\".\"requisitionapprovalid\" o69, \"enrequisitionapprovallevel9\".\"levelnumber\" o70, \"enrequisitionapprovallevel9\".\"applicationroleid\" o71, \"enrequisitionapprovallevel9\".\"entrajobtitle\" o72, \"enrequisitionapprovallevel9\".\"departmentid\" o73, \"enrequisitionapprovallevel9\".\"managementid\" o74, \"enrequisitionapprovallevel9\".\"subdirectionid\" o75, \"enrequisitionapprovallevel9\".\"entraroleid\" o76, \"enrequisitionapprovallevel9\".\"entrausername\" o77, \"enrequisitionapprovallevel9\".\"assignedto\" o78, \"enrequisitionapprovallevel9\".\"needscontract\" o79, \"enrequisitionapprovallevel9\".\"approvalstatusid\" o80, \"enrequisitionapprovallevel9\".\"approvedby\" o81, \"enrequisitionapprovallevel9\".\"approvedon\" o82, \"enrequisitionapprovallevel9\".\"requesttomodifyby\" o83, \"enrequisitionapprovallevel9\".\"requesttomodifyon\" o84, \"enrequisitionapprovallevel9\".\"canceledby\" o85, \"enrequisitionapprovallevel9\".\"canceledon_deprec\" o86, \"enrequisitionapprovallevel9\".\"isaccounting\" o87, \"enrequisitionapprovallevel9\".\"isstartaccounting\" o88, \"enrequisitionapprovallevel9\".\"canceledon_\" o89, \"enrequisitionapprovallevel9\".\"approveasareausuaria\" o90, \"enrequisitionapprovallevel9\".\"ismandatory\" o91, \"enrequisitionapprovallevel9\".\"isreassigned\" o92, \"enrequisitionapprovallevel9\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition32\" Left JOIN {RequisitionApproval} \"enrequisitionapproval10\" ON (\"enrequisition32\".\"id\" = \"enrequisitionapproval10\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel9\" ON (\"enrequisitionapproval10\".\"id\" = \"enrequisitionapprovallevel9\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel9\".\"id\" = @qpreRequisitionApprovalLevel_Id) AND (\"enrequisitionapprovallevel9\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalLevel_Id", DbType.Int64, qpreRequisitionApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel9\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApproveModifyRequisition.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApproveModifyRequisition.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
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

// Query Function "GetUserApplicationRolesByUserId" 4Cu8h7VGMUOJhSlc_8RtmA of Action "ApproveModifyRequisition"
public static async Task<(RL_87311ea350338b4dcd53388d23fa3f86,long)> datasetGetUserApplicationRolesByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApplicationRoleId,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApproveModifyRequisition.GetUserApplicationRolesByUserId", "87bc2be0-46b5-4331-8985-295cffc46d98");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApproveModifyRequisition.GetUserApplicationRolesByUserId", "87bc2be0-46b5-4331-8985-295cffc46d98", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.YYwob+05y0CmTGNHXWIcmQ/NodesNotShownInESpaceTree.4Cu8h7VGMUOJhSlc_8RtmA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {UserApplicationRoleTemp} \"enuserapplicationroletemp2\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp2\".\"userid\" = @qpusUserId) AND (\"enuserapplicationroletemp2\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp2\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp2\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND ");
if (qpapApplicationRoleId != 0) {
whereBuilder.Append("((\"enuserapplicationroletemp2\".\"applicationroleid\" = @qpapApplicationRoleId) AND (\"enuserapplicationroletemp2\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRoleId", DbType.Int64, qpapApplicationRoleId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp2\".\"applicationroleid\" IS NULL)");
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
RL_87311ea350338b4dcd53388d23fa3f86 outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApproveModifyRequisition.GetUserApplicationRolesByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_87311ea350338b4dcd53388d23fa3f86 _tmp = new RL_87311ea350338b4dcd53388d23fa3f86();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApproveModifyRequisition.GetUserApplicationRolesByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_87311ea350338b4dcd53388d23fa3f86)_tmp;
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
