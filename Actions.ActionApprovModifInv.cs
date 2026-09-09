namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovModifInv : VarsBag {
public long inParami_InvoiceId;
public long inParami_InvoiceApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>l_InvoiceApprovalLevel</code> that represents the Service Studio
///  InvoiceApprovalLevel <code>l_InvoiceApprovalLevel</code> <p>Description: InvoiceApprovalLevel</p>
/// </summary>
public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord varLcl_InvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();

/// <summary>
/// Variable <code>l_LastApprover</code> that represents the Service Studio UserIdentifier
///  <code>l_LastApprover</code> <p>Description: LastApprover</p>
/// </summary>
public string varLcl_LastApprover = "";

public RL_b2132c93db5fd1f839353b7412eed8f5 queryResGetInvoiceApprovalLevelsRestAcc2_outParamList = new RL_b2132c93db5fd1f839353b7412eed8f5();
public long queryResGetInvoiceApprovalLevelsRestAcc2_outParamCount = 0L;

public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate3 =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public RL_0c0399bc671f4e1ad26ddefe7a74d7a8 queryResGetNextInvoiceApprovalLevel_outParamList = new RL_0c0399bc671f4e1ad26ddefe7a74d7a8();
public long queryResGetNextInvoiceApprovalLevel_outParamCount = 0L;

public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate4 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoGetStartAccounting resGetStartAccounting =  new Actions.lcoGetStartAccounting();
public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public Actions.lcoInvoiceLogAdd resInvoiceLogAddApprove2 =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInvoiceCommentCreateOrUpdate resInvoiceCommentCreateOrUpdate =  new Actions.lcoInvoiceCommentCreateOrUpdate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate3 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate2 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoGetApproverSpecialFromRequisition resGetApproverSpecialFromRequisition =  new Actions.lcoGetApproverSpecialFromRequisition();
public Actions.lcoFindNextApproverSpecial resFindNextApproverSpecial =  new Actions.lcoFindNextApproverSpecial();
public Actions.lcoInvoiceLogAdd resInvoiceLogAddApprove =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInvoiceCommentCreateOrUpdate resInvoiceCommentCreateOrUpdate3 =  new Actions.lcoInvoiceCommentCreateOrUpdate();
public RL_2fd4ee9249069fb78258eb73022e4cb9 queryResGetANALISTA_CXP_outParamList = new RL_2fd4ee9249069fb78258eb73022e4cb9();
public long queryResGetANALISTA_CXP_outParamCount = 0L;

public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate7 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate2 =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public Actions.lcoGetInvNextApprov resGetInvNextApprov =  new Actions.lcoGetInvNextApprov();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate6 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoInvoiceCommentCreateOrUpdate resInvoiceCommentCreateOrUpdate4 =  new Actions.lcoInvoiceCommentCreateOrUpdate();
public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate3 =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate3 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_c851528f2bd72df8d6fa01fc1d7dda59 queryResGetInvoiceById_outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate4 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public RL_c7dc90026b82e43b2c9200700d23fd68 queryResGetApprovalProcess_outParamList = new RL_c7dc90026b82e43b2c9200700d23fd68();
public long queryResGetApprovalProcess_outParamCount = 0L;

public Actions.lcoInvoiceLogAdd resInvoiceLogAddModify =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInvoiceAccountingCreateOrUpdate resInvoiceAccountingCreateOrUpdate =  new Actions.lcoInvoiceAccountingCreateOrUpdate();
public RL_55207d74c9fa548c4383dfca6f13831e queryResGetInvoiceApprovalLevel_outParamList = new RL_55207d74c9fa548c4383dfca6f13831e();
public long queryResGetInvoiceApprovalLevel_outParamCount = 0L;

public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate4 =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public RL_6dc54c806e79e3021c958eb2cb6d90be queryResGetInvoiceApprovalLevelContab_outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
public long queryResGetInvoiceApprovalLevelContab_outParamCount = 0L;

public lcvApprovModifInv(long inParami_InvoiceId, long inParami_InvoiceApprovalLevelId, bool inParami_IsApprove, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoApprovModifInv : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public bool outParamIsFinish = false;

public lcoApprovModifInv() {
}
}
/// <summary>
/// Action <code>ApprovModifInv</code> that represents the Service Studio action
///  <code>ApprovModifInv</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,bool)> ActionApprovModifInv(IRequestContext requestContext,long inParami_InvoiceId,long inParami_InvoiceApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
bool outParamIsFinish = default;
lcoApprovModifInv result = new lcoApprovModifInv();
lcvApprovModifInv localVars = new lcvApprovModifInv(inParami_InvoiceId, inParami_InvoiceApprovalLevelId, inParami_IsApprove, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovModifInv", "37d4e485-7021-4ad2-a8f4-0305ae61b29a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovModifInv", "37d4e485-7021-4ad2-a8f4-0305ae61b29a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevel_maxRecords = 1;
if (datasetGetInvoiceApprovalLevel_maxRecords < 1) datasetGetInvoiceApprovalLevel_maxRecords = 1;
int datasetGetInvoiceApprovalLevel_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevel_outParamList,localVars.queryResGetInvoiceApprovalLevel_outParamCount) = await FuncActionApprovModifInv.datasetGetInvoiceApprovalLevel(requestContext,datasetGetInvoiceApprovalLevel_maxRecords,datasetGetInvoiceApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceApprovalLevelId,cancellationToken);

if((((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId)))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Invoice cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("iZYmkQ8eqESKx4hdVazk3A#Value.444407385.1", "Invoice cannot be updated!");
} else {
// not accounting or accounting done
if((((!localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting)||(localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceAccounting.ssSubmissionBy!=BuiltInFunction.NullTextIdentifier ())))) {
// Is invoice in Modify status?
if(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId))) {
// InApproval_CxP
// GetInvoiceApprovalLevel.List.Current.Invoice.InvoiceStatusId = InApproval_CxP
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"))).ssId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.FinishedOn = NullDate
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssFinishedOn = BuiltInFunction.NullDate ();
// InvoiceCreateOrUpdate4
localVars.resInvoiceCreateOrUpdate4.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate4
localVars.resInvoiceStatusHistoryCreateOrUpdate4.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// HasStartedAccounting?
if((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting)) {
// Query datasetGetInvoiceApprovalLevelsRestAcc2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevelsRestAcc2_maxRecords = 0;
int datasetGetInvoiceApprovalLevelsRestAcc2_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevelsRestAcc2_outParamList,localVars.queryResGetInvoiceApprovalLevelsRestAcc2_outParamCount) = await FuncActionApprovModifInv.datasetGetInvoiceApprovalLevelsRestAcc2(requestContext,datasetGetInvoiceApprovalLevelsRestAcc2_maxRecords,datasetGetInvoiceApprovalLevelsRestAcc2_startIndex,IterationMultiplicity.Single,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssId,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssId,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber,cancellationToken);

// Foreach GetInvoiceApprovalLevelsRestAcc2.List
localVars.queryResGetInvoiceApprovalLevelsRestAcc2_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceApprovalLevelsRestAcc2_outParamList.Eof))) {
// InvoiceApprovalLevelDelete2
await Actions.ActionInvoiceApprovalLevelDelete(requestContext,localVars.queryResGetInvoiceApprovalLevelsRestAcc2_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssId,cancellationToken);

localVars.queryResGetInvoiceApprovalLevelsRestAcc2_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceApprovalLevelsRestAcc2_outParamList.EndIteration();
}

}

}

if((localVars.inParami_IsApprove)) {
bool block3 = false;
do {
block3 = false;
// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionApprovModifInv.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssAprovalProcessId,cancellationToken);

// Query datasetGetNextInvoiceApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextInvoiceApprovalLevel_maxRecords = 1;
if (datasetGetNextInvoiceApprovalLevel_maxRecords < 1) datasetGetNextInvoiceApprovalLevel_maxRecords = 1;
int datasetGetNextInvoiceApprovalLevel_startIndex = 0;(localVars.queryResGetNextInvoiceApprovalLevel_outParamList,localVars.queryResGetNextInvoiceApprovalLevel_outParamCount) = await FuncActionApprovModifInv.datasetGetNextInvoiceApprovalLevel(requestContext,datasetGetNextInvoiceApprovalLevel_maxRecords,datasetGetNextInvoiceApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssId,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber,cancellationToken);

// Empty?
if((localVars.queryResGetNextInvoiceApprovalLevel_outParamList.Empty)) {
// IsSpecial?
do {
// IsSpecial?
if((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial)) {
// HasStartedAccounting?
if((!(localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting))) {
break;
}

}

// IsReassigned?
if((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsReassigned)) {
// l_LastApprover = If
localVars.varLcl_LastApprover=(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsSubstituteFor) : (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssApplicantId));
}

// GetInvNextApprov
(localVars.resGetInvNextApprov.outParamo_IsFinishApproval,localVars.resGetInvNextApprov.outParamo_AssignTo,localVars.resGetInvNextApprov.outParamo_ApplicationRoleId,localVars.resGetInvNextApprov.outParamo_IsSubstituteFor) = await Actions.ActionGetInvNextApprov(requestContext,((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsReassigned) ? (localVars.varLcl_LastApprover) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())))),localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice,localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting,cancellationToken);

// o_IsFinishApproval?
if((localVars.resGetInvNextApprov.outParamo_IsFinishApproval)) {
// HasStartedAccounting?
if((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting)) {
// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedBy = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovalStatusId = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId));

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.AssignedTo = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo = (((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.FinishedOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.MaxLevel = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel + 1
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssMaxLevel = (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel+1);
// InvoiceApprovalLevelCreateOrUpdate3
localVars.resInvoiceApprovalLevelCreateOrUpdate3.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceLogAddApprove2
localVars.resInvoiceLogAddApprove2.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = (((((AppUtils.GetStringResource("r7accE9l7k6sQ1pc2fxctA#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("r7accE9l7k6sQ1pc2fxctA#Value.1185244855.1", "approved"))+(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("r7accE9l7k6sQ1pc2fxctA#Value.182414732.1", "by a substitute."))) : ("."))), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

if(((localVars.inParami_Comment!=""))) {
// InvoiceCommentCreateOrUpdate4
localVars.resInvoiceCommentCreateOrUpdate4.outParamId = await Actions.ActionInvoiceCommentCreateOrUpdate(requestContext,new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceApprovalLevelId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssId, ssApplicationRoleId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApplicationRoleId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssMessage = localVars.inParami_Comment, ssIsPublic = true },cancellationToken);

}

// InvoiceApprovalCreateOrUpdate2
localVars.resInvoiceApprovalCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

// IsFinish = True
result.outParamIsFinish=true;
// InvoiceAccountingProcess_Create
await Actions.ActionInvoiceAccountingProcess_Create(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssId,localVars.inParami_Comment,false,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamOffsetUtc,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
goto RETURN_STATEMENT;

}

} else {
// l_InvoiceApprovalLevel
// l_InvoiceApprovalLevel.Id = NullIdentifier
localVars.varLcl_InvoiceApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_InvoiceApprovalLevel.InvoiceApprovalId = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.Id
localVars.varLcl_InvoiceApprovalLevel.ssInvoiceApprovalId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssId;

// l_InvoiceApprovalLevel.LevelNumber = GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.LevelNumber + 1
localVars.varLcl_InvoiceApprovalLevel.ssLevelNumber = (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber+1);

// l_InvoiceApprovalLevel.ApplicationRoleId = GetInvNextApprov.o_ApplicationRoleId
localVars.varLcl_InvoiceApprovalLevel.ssApplicationRoleId = localVars.resGetInvNextApprov.outParamo_ApplicationRoleId;

// l_InvoiceApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_InvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_InvoiceApprovalLevel.IsAccounting = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.HasStartedAccounting
localVars.varLcl_InvoiceApprovalLevel.ssIsAccounting = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting;

// l_InvoiceApprovalLevel.AssignedTo = GetInvNextApprov.o_AssignTo
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = localVars.resGetInvNextApprov.outParamo_AssignTo;

// l_InvoiceApprovalLevel.IsSubstituteFor = GetInvNextApprov.o_IsSubstituteFor
localVars.varLcl_InvoiceApprovalLevel.ssIsSubstituteFor = localVars.resGetInvNextApprov.outParamo_IsSubstituteFor;
// jump to block3
block3 = true;
break;
}

} while(false)
;
if(block3) {
break;
}

// ReqApprovalProcess found?
if(((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionApprovModifInv.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// GetStartAccounting
(localVars.resGetStartAccounting.outParami_AssignTo,localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel) = await Actions.ActionGetStartAccounting(requestContext,localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId,(((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssAccountingRegionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENAccountingRegion.ssCommissionRegion) : (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRegion.ssCommissionRegion)),(((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssAccountingRegionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssAccountingRegionId) : (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssRegionId)),cancellationToken);

// Empty?
if(((localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("EKE95aK_MUa0djBt1QqmiA#Message.-136829869.1", "No role in the workflow indicates where accounting starts."));

} else {
// l_InvoiceApprovalLevel
// l_InvoiceApprovalLevel.Id = NullIdentifier
localVars.varLcl_InvoiceApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_InvoiceApprovalLevel.InvoiceApprovalId = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.Id
localVars.varLcl_InvoiceApprovalLevel.ssInvoiceApprovalId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssId;

// l_InvoiceApprovalLevel.LevelNumber = GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.LevelNumber + 1
localVars.varLcl_InvoiceApprovalLevel.ssLevelNumber = (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber+1);

// l_InvoiceApprovalLevel.SelectsNextApprover = GetStartAccounting.o_ApprovalProcessLevel.SelectsNextApprover
localVars.varLcl_InvoiceApprovalLevel.ssSelectsNextApprover = localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssSelectsNextApprover;

// l_InvoiceApprovalLevel.ApprovalStatusId = If
localVars.varLcl_InvoiceApprovalLevel.ssApprovalStatusId = ((localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssSelectsNextApprover) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId));

// l_InvoiceApprovalLevel.IsStartAccounting = True
localVars.varLcl_InvoiceApprovalLevel.ssIsStartAccounting = true;

// l_InvoiceApprovalLevel.IsAccounting = True
localVars.varLcl_InvoiceApprovalLevel.ssIsAccounting = true;

// l_InvoiceApprovalLevel.AssignedTo = GetStartAccounting.i_AssignTo
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = localVars.resGetStartAccounting.outParami_AssignTo;

// l_InvoiceApprovalLevel.ApplicationRoleId = GetStartAccounting.o_ApprovalProcessLevel.ApplicationRoleId
localVars.varLcl_InvoiceApprovalLevel.ssApplicationRoleId = localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssApplicationRoleId;
}

} else {
// Query datasetGetANALISTA_CXP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetANALISTA_CXP_maxRecords = 1;
if (datasetGetANALISTA_CXP_maxRecords < 1) datasetGetANALISTA_CXP_maxRecords = 1;
int datasetGetANALISTA_CXP_startIndex = 0;(localVars.queryResGetANALISTA_CXP_outParamList,localVars.queryResGetANALISTA_CXP_outParamCount) = await FuncActionApprovModifInv.datasetGetANALISTA_CXP(requestContext,datasetGetANALISTA_CXP_maxRecords,datasetGetANALISTA_CXP_startIndex,IterationMultiplicity.Never,cancellationToken);

// Empty?
if((localVars.queryResGetANALISTA_CXP_outParamList.Empty)) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("TiItws3n_keG81SFn+7pYQ#Message.2138269536.1", "ANALISTA_CXP - Analista CxP/Egresos role has not yet been created."));

} else {
// l_InvoiceApprovalLevel
// l_InvoiceApprovalLevel.Id = NullIdentifier
localVars.varLcl_InvoiceApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_InvoiceApprovalLevel.InvoiceApprovalId = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.Id
localVars.varLcl_InvoiceApprovalLevel.ssInvoiceApprovalId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssId;

// l_InvoiceApprovalLevel.LevelNumber = GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.LevelNumber + 1
localVars.varLcl_InvoiceApprovalLevel.ssLevelNumber = (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber+1);

// l_InvoiceApprovalLevel.ApplicationRoleId = GetANALISTA_CXP.List.Current.ApplicationRole.Id
localVars.varLcl_InvoiceApprovalLevel.ssApplicationRoleId = localVars.queryResGetANALISTA_CXP_outParamList.CurrentRec.ssENApplicationRole.ssId;

// l_InvoiceApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_InvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_InvoiceApprovalLevel.IsAccounting = True
localVars.varLcl_InvoiceApprovalLevel.ssIsAccounting = true;

// l_InvoiceApprovalLevel.IsStartAccounting = True
localVars.varLcl_InvoiceApprovalLevel.ssIsStartAccounting = true;
}

}

// InApproval_CxP
// GetInvoiceApprovalLevel.List.Current.Invoice.InvoiceStatusId = InApproval_CxP
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"))).ssId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.HasStartedAccounting = True
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting = true;
// InvoiceCreateOrUpdate3
localVars.resInvoiceCreateOrUpdate3.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate3
localVars.resInvoiceStatusHistoryCreateOrUpdate3.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

} else {
// l_RequisitionApprovalLevel
do {
// l_RequisitionApprovalLevel
// l_InvoiceApprovalLevel = GetNextInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel
localVars.varLcl_InvoiceApprovalLevel=localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel;

// l_InvoiceApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_InvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel = GetNextInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.LevelNumber
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel = localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber;
// AssignedTo?
if(((localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ()))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo,cancellationToken);

// l_InvoiceApprovalLevel.AssignedTo = If
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// l_InvoiceApprovalLevel.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.varLcl_InvoiceApprovalLevel.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
} else {
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_FlujoRRHH]))))) {
// GetApproverSpecialFromRequisition
(localVars.resGetApproverSpecialFromRequisition.outParamo_Output,localVars.resGetApproverSpecialFromRequisition.outParamo_UserId,localVars.resGetApproverSpecialFromRequisition.outParamo_IsSubstituteFor) = await Actions.ActionGetApproverSpecialFromRequisition(requestContext,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssEntraRoleId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRegionId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssDepartmentId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssManagementId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssSubdirectionId,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssId,cancellationToken);

// IsSuccess?
if((localVars.resGetApproverSpecialFromRequisition.outParamo_Output.ssIsSuccess)) {
// AssignedTo
// l_InvoiceApprovalLevel.AssignedTo = GetApproverSpecialFromRequisition.o_UserId
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = localVars.resGetApproverSpecialFromRequisition.outParamo_UserId;

// l_InvoiceApprovalLevel.IsSubstituteFor = GetApproverSpecialFromRequisition.o_IsSubstituteFor
localVars.varLcl_InvoiceApprovalLevel.ssIsSubstituteFor = localVars.resGetApproverSpecialFromRequisition.outParamo_IsSubstituteFor;
break;
}

}

// FindNextApproverSpecial
(localVars.resFindNextApproverSpecial.outParamo_Output,localVars.resFindNextApproverSpecial.outParamo_UserId,localVars.resFindNextApproverSpecial.outParamo_IsSubstituteFor) = await Actions.ActionFindNextApproverSpecial(requestContext,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssEntraRoleId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRegionId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssDepartmentId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssManagementId,localVars.queryResGetNextInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssSubdirectionId,cancellationToken);

// IsSuccess?
if((localVars.resFindNextApproverSpecial.outParamo_Output.ssIsSuccess)) {
// AssignedTo
// l_InvoiceApprovalLevel.AssignedTo = FindNextApproverSpecial.o_UserId
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = localVars.resFindNextApproverSpecial.outParamo_UserId;

// l_InvoiceApprovalLevel.IsSubstituteFor = FindNextApproverSpecial.o_IsSubstituteFor
localVars.varLcl_InvoiceApprovalLevel.ssIsSubstituteFor = localVars.resFindNextApproverSpecial.outParamo_IsSubstituteFor;
} else {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (localVars.resFindNextApproverSpecial.outParamo_Output.ssMessage);

}

}

} while(false)
;
// ALIGN
}

} while(false)
;
// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedBy = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovalStatusId = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId));

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.AssignedTo = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo = (((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel = GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.LevelNumber + 1
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel = (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber+1);
// InvoiceApprovalLevelCreateOrUpdate2
localVars.resInvoiceApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_InvoiceApprovalLevel,cancellationToken);

// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceLogAddApprove
localVars.resInvoiceLogAddApprove.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = (((((AppUtils.GetStringResource("DN_nSiU35kG3MBHkNIozrg#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("DN_nSiU35kG3MBHkNIozrg#Value.1185244855.1", "approved"))+(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("DN_nSiU35kG3MBHkNIozrg#Value.182414732.1", "by a substitute."))) : ("."))), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

if(((localVars.inParami_Comment!=""))) {
// InvoiceCommentCreateOrUpdate3
localVars.resInvoiceCommentCreateOrUpdate3.outParamId = await Actions.ActionInvoiceCommentCreateOrUpdate(requestContext,new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceApprovalLevelId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssId, ssApplicationRoleId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApplicationRoleId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssMessage = localVars.inParami_Comment, ssIsPublic = true },cancellationToken);

}

// InvoiceApprovalCreateOrUpdate
localVars.resInvoiceApprovalCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// InvEmailNextApprov_ToApprove
await Actions.ActionInvEmailNextApprov_ToApprove(requestContext,localVars.inParami_InvoiceId,cancellationToken);

} else {
// InApproval_UserArea?
if(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId))) {
// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.RequestToModifyBy = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssRequestToModifyBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.RequestToModifyOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssRequestToModifyOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovalStatusId = Modify
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId;

// GetInvoiceApprovalLevel.List.Current.Invoice.InvoiceStatusId = Modify
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.FinishedOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();
// InvoiceApprovalLevelCreateOrUpdate4
localVars.resInvoiceApprovalLevelCreateOrUpdate4.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

} else {
// Query datasetGetInvoiceApprovalLevelContab
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevelContab_maxRecords = 1;
if (datasetGetInvoiceApprovalLevelContab_maxRecords < 1) datasetGetInvoiceApprovalLevelContab_maxRecords = 1;
int datasetGetInvoiceApprovalLevelContab_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevelContab_outParamList,localVars.queryResGetInvoiceApprovalLevelContab_outParamCount) = await FuncActionApprovModifInv.datasetGetInvoiceApprovalLevelContab(requestContext,datasetGetInvoiceApprovalLevelContab_maxRecords,datasetGetInvoiceApprovalLevelContab_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// GetInvoiceApprovalLevel.List.Current.InvoiceAccounting.SubmissionBy = NullTextIdentifier
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceAccounting.ssSubmissionBy = BuiltInFunction.NullTextIdentifier ();

// GetInvoiceApprovalLevel.List.Current.InvoiceAccounting.SubmissionOn = NullDate
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceAccounting.ssSubmissionOn = BuiltInFunction.NullDate ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel = GetInvoiceApprovalLevelContab.List.Current.InvoiceApprovalLevel.LevelNumber
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel = localVars.queryResGetInvoiceApprovalLevelContab_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber;

// GetInvoiceApprovalLevelContab.List.Current.InvoiceApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetInvoiceApprovalLevelContab_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetInvoiceApprovalLevelContab.List.Current.InvoiceApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetInvoiceApprovalLevelContab_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetInvoiceApprovalLevelContab.List.Current.InvoiceApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetInvoiceApprovalLevelContab_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetInvoiceApprovalLevelContab.List.Current.InvoiceApprovalLevel.CanceledBy = NullTextIdentifier
localVars.queryResGetInvoiceApprovalLevelContab_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssCanceledBy = BuiltInFunction.NullTextIdentifier ();

// GetInvoiceApprovalLevelContab.List.Current.InvoiceApprovalLevel.CanceledOn = NullDate
localVars.queryResGetInvoiceApprovalLevelContab_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssCanceledOn = BuiltInFunction.NullDate ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.RequestToModifyBy = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssRequestToModifyBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.RequestToModifyOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssRequestToModifyOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovalStatusId = Modify
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.AssignedTo = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo = (((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));

// GetInvoiceApprovalLevel.List.Current.Invoice.InvoiceStatusId = Modify
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.FinishedOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();
// InvoiceApprovalLevelCreateOrUpdate6
localVars.resInvoiceApprovalLevelCreateOrUpdate6.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevelContab_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceApprovalLevelCreateOrUpdate7
localVars.resInvoiceApprovalLevelCreateOrUpdate7.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceAccountingCreateOrUpdate
localVars.resInvoiceAccountingCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceAccounting,cancellationToken);

}

// InvoiceApprovalCreateOrUpdate3
localVars.resInvoiceApprovalCreateOrUpdate3.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

// InvoiceCreateOrUpdate2
localVars.resInvoiceCreateOrUpdate2.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

if(((localVars.inParami_Comment!=""))) {
// InvoiceCommentCreateOrUpdate
localVars.resInvoiceCommentCreateOrUpdate.outParamId = await Actions.ActionInvoiceCommentCreateOrUpdate(requestContext,new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceApprovalLevelId = localVars.varLcl_InvoiceApprovalLevel.ssId, ssApplicationRoleId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApplicationRoleId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssMessage = localVars.inParami_Comment, ssIsPublic = true },cancellationToken);

}

// InvoiceLogAddModify
localVars.resInvoiceLogAddModify.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = ((((((AppUtils.GetStringResource("92KTBCjXvESFEas4TM+JDg#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("92KTBCjXvESFEas4TM+JDg#Value.587526867.1", "requested to be modified"))+(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("92KTBCjXvESFEas4TM+JDg#Value.1391357666.1", "by a substitute"))) : (" ")))+(((localVars.inParami_Comment!="")) ? ((((" "+AppUtils.GetStringResource("92KTBCjXvESFEas4TM+JDg#Value.448016147.1", "with the following comment:"))+" ")+localVars.inParami_Comment)) : ("."))), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate2
localVars.resInvoiceStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// InApproval_UserArea?
if(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId))) {
// InvEmailFirstApprov_Modify
await Actions.ActionInvEmailFirstApprov_Modify(requestContext,localVars.inParami_InvoiceId,localVars.inParami_Comment,(((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())),cancellationToken);

} else {
// InvEmailFirstCxP_ModifyAccounting
await Actions.ActionInvEmailFirstCxP_ModifyAccounting(requestContext,localVars.inParami_InvoiceId,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceAccounting.ssSubmissionBy,localVars.inParami_Comment,(((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())),cancellationToken);

}

}

} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Accounting should be submitted before proceeding."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("k+o6sO0ZN0iRNp74uv5AVw#Value.-2135299463.1", "Accounting should be submitted before proceeding.");
}

}

} //close CreateActionActivity using block
} // try

catch (Ex_AccountingErrorUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = AccountingError.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
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
catch (Ex_AccountingServiceErrorUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = AccountingServiceError.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
outParamIsFinish = result.outParamIsFinish;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamIsFinish);
}

public static class FuncActionApprovModifInv {

// Query Function "GetInvoiceApprovalLevelsRestAcc2" LQs_DKiWWk2K5vzttedksw of Action "ApprovModifInv"
public static async Task<(RL_b2132c93db5fd1f839353b7412eed8f5,long)> datasetGetInvoiceApprovalLevelsRestAcc2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalId,long qpinId,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifInv.GetInvoiceApprovalLevelsRestAcc2", "0c3f0b2d-96a8-4d5a-8ae6-fcedb5e764b3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifInv.GetInvoiceApprovalLevelsRestAcc2", "0c3f0b2d-96a8-4d5a-8ae6-fcedb5e764b3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.heTUNyFw0kqo9AMFrmGymg/NodesNotShownInESpaceTree.LQs_DKiWWk2K5vzttedksw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceapprovallevel3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM {InvoiceApprovalLevel} \"eninvoiceapprovallevel3\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApprovalId != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel3\".\"invoiceapprovalid\" = @qpinInvoiceApprovalId) AND (\"eninvoiceapprovallevel3\".\"invoiceapprovalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalId", DbType.Int64, qpinInvoiceApprovalId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel3\".\"invoiceapprovalid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel3\".\"id\" <> @qpinId) OR (\"eninvoiceapprovallevel3\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel3\".\"id\" IS NOT NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel3\".\"isaccounting\" = 1) AND (\"eninvoiceapprovallevel3\".\"levelnumber\" >= @qpinLevelNumber)");
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
RL_b2132c93db5fd1f839353b7412eed8f5 outParamList = new RL_b2132c93db5fd1f839353b7412eed8f5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifInv.GetInvoiceApprovalLevelsRestAcc2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b2132c93db5fd1f839353b7412eed8f5 _tmp = new RL_b2132c93db5fd1f839353b7412eed8f5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifInv.GetInvoiceApprovalLevelsRestAcc2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b2132c93db5fd1f839353b7412eed8f5)_tmp;
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

private static async Task<RC_c29b3326c29f006183b22af7b25050ff> datasetGetNextInvoiceApprovalLevelReadDbAsync(RC_c29b3326c29f006183b22af7b25050ff rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetNextInvoiceApprovalLevel" +DNrFDs1yEWnBWr+QPj1Hw of Action "ApprovModifInv"
public static async Task<(RL_0c0399bc671f4e1ad26ddefe7a74d7a8,long)> datasetGetNextInvoiceApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_Id,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifInv.GetNextInvoiceApprovalLevel", "146b33f8-353b-45c8-a705-6afe40f8f51f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifInv.GetNextInvoiceApprovalLevel", "146b33f8-353b-45c8-a705-6afe40f8f51f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.heTUNyFw0kqo9AMFrmGymg/NodesNotShownInESpaceTree.+DNrFDs1yEWnBWr+QPj1Hw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, \"eninvoiceapprovallevel4\".\"id\" o41, \"eninvoiceapprovallevel4\".\"invoiceapprovalid\" o42, \"eninvoiceapprovallevel4\".\"levelnumber\" o43, \"eninvoiceapprovallevel4\".\"assignedto\" o44, \"eninvoiceapprovallevel4\".\"applicationroleid\" o45, \"eninvoiceapprovallevel4\".\"entrajobtitle\" o46, \"eninvoiceapprovallevel4\".\"departmentid\" o47, \"eninvoiceapprovallevel4\".\"managementid\" o48, \"eninvoiceapprovallevel4\".\"subdirectionid\" o49, \"eninvoiceapprovallevel4\".\"entraroleid\" o50, NULL o51, \"eninvoiceapprovallevel4\".\"canbefirstapprover\" o52, \"eninvoiceapprovallevel4\".\"selectsnextapprover\" o53, \"eninvoiceapprovallevel4\".\"selectsfirstapprover\" o54, \"eninvoiceapprovallevel4\".\"isaccounting\" o55, \"eninvoiceapprovallevel4\".\"isstartaccounting\" o56, \"eninvoiceapprovallevel4\".\"approvedby\" o57, \"eninvoiceapprovallevel4\".\"approvedon\" o58, \"eninvoiceapprovallevel4\".\"requesttomodifyby\" o59, \"eninvoiceapprovallevel4\".\"requesttomodifyon\" o60, \"eninvoiceapprovallevel4\".\"canceledby\" o61, \"eninvoiceapprovallevel4\".\"canceledon\" o62, \"eninvoiceapprovallevel4\".\"needscontract_deprec\" o63, \"eninvoiceapprovallevel4\".\"isreassigned\" o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, \"enrequisition14\".\"regionid\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136");
fromBuilder.Append(" FROM ((((({Invoice} \"eninvoice10\" Left JOIN {InvoiceApproval} \"eninvoiceapproval3\" ON (\"eninvoice10\".\"id\" = \"eninvoiceapproval3\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel4\" ON (\"eninvoiceapproval3\".\"id\" = \"eninvoiceapprovallevel4\".\"invoiceapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole6\" ON (\"eninvoiceapprovallevel4\".\"applicationroleid\" = \"enapplicationrole6\".\"id\"))  Left JOIN {Requisition} \"enrequisition14\" ON (\"eninvoice10\".\"requisitionid\" = \"enrequisition14\".\"id\"))  Left JOIN {Region} \"enregion11\" ON (\"enrequisition14\".\"regionid\" = \"enregion11\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_Id != 0) {
whereBuilder.Append("((\"eninvoiceapproval3\".\"id\" = @qpinInvoiceApproval_Id) AND (\"eninvoiceapproval3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_Id", DbType.Int64, qpinInvoiceApproval_Id);
} else {
whereBuilder.Append("(\"eninvoiceapproval3\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel4\".\"levelnumber\" > @qpinLevelNumber)");
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
RL_0c0399bc671f4e1ad26ddefe7a74d7a8 outParamList = new RL_0c0399bc671f4e1ad26ddefe7a74d7a8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextInvoiceApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifInv.GetNextInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0c0399bc671f4e1ad26ddefe7a74d7a8 _tmp = new RL_0c0399bc671f4e1ad26ddefe7a74d7a8();
_tmp.AlternateReadDbMethodAsync = datasetGetNextInvoiceApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifInv.GetNextInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0c0399bc671f4e1ad26ddefe7a74d7a8)_tmp;
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

// Query Function "GetANALISTA_CXP" mht+W6wJqU6ZkY3hyurb3A of Action "ApprovModifInv"
public static async Task<(RL_2fd4ee9249069fb78258eb73022e4cb9,long)> datasetGetANALISTA_CXP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifInv.GetANALISTA_CXP", "5b7e1b9a-09ac-4ea9-9991-8de1caeadbdc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifInv.GetANALISTA_CXP", "5b7e1b9a-09ac-4ea9-9991-8de1caeadbdc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.heTUNyFw0kqo9AMFrmGymg/NodesNotShownInESpaceTree.mht+W6wJqU6ZkY3hyurb3A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole7\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {ApplicationRole} \"enapplicationrole7\"");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper(\"enapplicationrole7\".\"code\")) collate \"default\") like caseaccent_normalize('ANALISTA_CXP' collate \"default\"))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifInv.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifInv.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
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

private static async Task<RC_3336d2630e2646e00d0c2f5c3e5a01ea> datasetGetInvoiceByIdReadDbAsync(RC_3336d2630e2646e00d0c2f5c3e5a01ea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" MsTUxmXVXUiKnMWKmRsmXA of Action "ApprovModifInv"
public static async Task<(RL_c851528f2bd72df8d6fa01fc1d7dda59,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifInv.GetInvoiceById", "c6d4c432-d565-485d-8a9c-c58a991b265c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifInv.GetInvoiceById", "c6d4c432-d565-485d-8a9c-c58a991b265c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.heTUNyFw0kqo9AMFrmGymg/NodesNotShownInESpaceTree.MsTUxmXVXUiKnMWKmRsmXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enregion12\".\"commissionregion\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enrequisition15\".\"regionid\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice11\" Left JOIN {Requisition} \"enrequisition15\" ON (\"enrequisition15\".\"id\" = \"eninvoice11\".\"requisitionid\"))  Left JOIN {Region} \"enregion12\" ON (\"enrequisition15\".\"regionid\" = \"enregion12\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice11\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice11\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice11\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifInv.GetInvoiceById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifInv.GetInvoiceById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_65930e54edca87f73a766a2aa044190e> datasetGetApprovalProcessReadDbAsync(RC_65930e54edca87f73a766a2aa044190e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingRegion.Read( r, ref index);
rec.ssENApprovalProcess.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcess" N6Qw1x3GTESoumeahEp+Cw of Action "ApprovModifInv"
public static async Task<(RL_c7dc90026b82e43b2c9200700d23fd68,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifInv.GetApprovalProcess", "d730a437-c61d-444c-a8ba-679a844a7e0b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifInv.GetApprovalProcess", "d730a437-c61d-444c-a8ba-679a844a7e0b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.heTUNyFw0kqo9AMFrmGymg/NodesNotShownInESpaceTree.N6Qw1x3GTESoumeahEp+Cw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enaccountingregion\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enapprovalprocess4\".\"id\" o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enapprovalprocess4\".\"accountingregionid\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enapprovalprocess4\".\"isspecial\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess4\" Left JOIN {Region} \"enaccountingregion\" ON (\"enapprovalprocess4\".\"accountingregionid\" = \"enaccountingregion\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enapprovalprocess4\".\"id\" = (@qploApprovalProcess_Id))");
sqlCmd.CreateParameterWithoutReplacements("@qploApprovalProcess_Id", DbType.Int64, qploApprovalProcess_Id);
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
RL_c7dc90026b82e43b2c9200700d23fd68 outParamList = new RL_c7dc90026b82e43b2c9200700d23fd68();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, false, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifInv.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c7dc90026b82e43b2c9200700d23fd68 _tmp = new RL_c7dc90026b82e43b2c9200700d23fd68();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifInv.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c7dc90026b82e43b2c9200700d23fd68)_tmp;
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

private static async Task<RC_85b2b46688ffbcbb7cd7720bbbe251ba> datasetGetInvoiceApprovalLevelReadDbAsync(RC_85b2b46688ffbcbb7cd7720bbbe251ba rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalLevel" Hf3r2XE6R0ynBdJWTCQuzA of Action "ApprovModifInv"
public static async Task<(RL_55207d74c9fa548c4383dfca6f13831e,long)> datasetGetInvoiceApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifInv.GetInvoiceApprovalLevel", "d9ebfd1d-3a71-4c47-a705-d2564c242ecc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifInv.GetInvoiceApprovalLevel", "d9ebfd1d-3a71-4c47-a705-d2564c242ecc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.heTUNyFw0kqo9AMFrmGymg/NodesNotShownInESpaceTree.Hf3r2XE6R0ynBdJWTCQuzA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"eninvoice12\".\"id\" o11, \"eninvoice12\".\"name\" o12, \"eninvoice12\".\"requisitionid\" o13, \"eninvoice12\".\"folioid\" o14, \"eninvoice12\".\"ordermainid\" o15, \"eninvoice12\".\"cfditypeid\" o16, trim_scale(\"eninvoice12\".\"totalamount\"::numeric) o17, \"eninvoice12\".\"currency\" o18, \"eninvoice12\".\"invoicestatusid\" o19, \"eninvoice12\".\"accountingdatetime\" o20, \"eninvoice12\".\"paymentdatetime\" o21, \"eninvoice12\".\"createdon\" o22, \"eninvoice12\".\"createdby\" o23, \"eninvoice12\".\"updatedon\" o24, \"eninvoice12\".\"updatedby\" o25, \"eninvoice12\".\"submittedon\" o26, \"eninvoice12\".\"isnewversion\" o27, \"eninvoice12\".\"id_poliza\" o28, \"eninvoice12\".\"id_poliza_sap\" o29, \"eninvoice12\".\"doc51\" o30, \"eninvoice12\".\"accountingerror\" o31, \"eninvoice12\".\"orderaccconceptsid\" o32, trim_scale(\"eninvoice12\".\"amortization\"::numeric) o33, \"eninvoice12\".\"creditnoteinvoiceid\" o34, \"eninvoiceaccounting3\".\"id\" o35, \"eninvoiceaccounting3\".\"invoiceid\" o36, \"eninvoiceaccounting3\".\"suppliernumber\" o37, \"eninvoiceaccounting3\".\"servicetypeid\" o38, \"eninvoiceaccounting3\".\"freetext\" o39, \"eninvoiceaccounting3\".\"division\" o40, trim_scale(\"eninvoiceaccounting3\".\"ivaamount\"::numeric) o41, \"eninvoiceaccounting3\".\"iva_old\" o42, \"eninvoiceaccounting3\".\"ivaindicatorid\" o43, trim_scale(\"eninvoiceaccounting3\".\"totalamount\"::numeric) o44, \"eninvoiceaccounting3\".\"paymentmethodid\" o45, \"eninvoiceaccounting3\".\"paymenttermsid\" o46, \"eninvoiceaccounting3\".\"icmeindicator\" o47, \"eninvoiceaccounting3\".\"createdby\" o48, \"eninvoiceaccounting3\".\"createdon\" o49, \"eninvoiceaccounting3\".\"submissionby\" o50, \"eninvoiceaccounting3\".\"submissionon\" o51, \"eninvoiceaccounting3\".\"servicecalledby\" o52, \"eninvoiceaccounting3\".\"servicecalledon\" o53, \"eninvoiceaccounting3\".\"buydocnumber\" o54, \"eninvoiceaccounting3\".\"buydocposition\" o55, \"eninvoiceapproval4\".\"id\" o56, \"eninvoiceapproval4\".\"invoiceid\" o57, \"eninvoiceapproval4\".\"aprovalprocessid\" o58, \"eninvoiceapproval4\".\"processtypecode\" o59, \"eninvoiceapproval4\".\"approvalprocessversion\" o60, \"eninvoiceapproval4\".\"currentlevel\" o61, \"eninvoiceapproval4\".\"maxlevel\" o62, \"eninvoiceapproval4\".\"startedon\" o63, \"eninvoiceapproval4\".\"finishedon\" o64, \"eninvoiceapproval4\".\"hasstartedaccounting\" o65, \"eninvoiceapprovallevel5\".\"id\" o66, \"eninvoiceapprovallevel5\".\"invoiceapprovalid\" o67, \"eninvoiceapprovallevel5\".\"levelnumber\" o68, \"eninvoiceapprovallevel5\".\"assignedto\" o69, \"eninvoiceapprovallevel5\".\"applicationroleid\" o70, \"eninvoiceapprovallevel5\".\"entrajobtitle\" o71, \"eninvoiceapprovallevel5\".\"departmentid\" o72, \"eninvoiceapprovallevel5\".\"managementid\" o73, \"eninvoiceapprovallevel5\".\"subdirectionid\" o74, \"eninvoiceapprovallevel5\".\"entraroleid\" o75, \"eninvoiceapprovallevel5\".\"approvalstatusid\" o76, \"eninvoiceapprovallevel5\".\"canbefirstapprover\" o77, \"eninvoiceapprovallevel5\".\"selectsnextapprover\" o78, \"eninvoiceapprovallevel5\".\"selectsfirstapprover\" o79, \"eninvoiceapprovallevel5\".\"isaccounting\" o80, \"eninvoiceapprovallevel5\".\"isstartaccounting\" o81, \"eninvoiceapprovallevel5\".\"approvedby\" o82, \"eninvoiceapprovallevel5\".\"approvedon\" o83, \"eninvoiceapprovallevel5\".\"requesttomodifyby\" o84, \"eninvoiceapprovallevel5\".\"requesttomodifyon\" o85, \"eninvoiceapprovallevel5\".\"canceledby\" o86, \"eninvoiceapprovallevel5\".\"canceledon\" o87, \"eninvoiceapprovallevel5\".\"needscontract_deprec\" o88, \"eninvoiceapprovallevel5\".\"isreassigned\" o89, \"eninvoiceapprovallevel5\".\"issubstitutefor\" o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, \"enrequisition16\".\"id\" o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, \"enrequisition16\".\"applicantid\" o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208");
fromBuilder.Append(" FROM (((((((({Invoice} \"eninvoice12\" Left JOIN {InvoiceApproval} \"eninvoiceapproval4\" ON (\"eninvoice12\".\"id\" = \"eninvoiceapproval4\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel5\" ON (\"eninvoiceapproval4\".\"id\" = \"eninvoiceapprovallevel5\".\"invoiceapprovalid\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting3\" ON (\"eninvoice12\".\"id\" = \"eninvoiceaccounting3\".\"invoiceid\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended3\" ON (\"eninvoice12\".\"id\" = \"eninvoiceextended3\".\"id\"))  Left JOIN {Requisition} \"enrequisition16\" ON (\"eninvoice12\".\"requisitionid\" = \"enrequisition16\".\"id\"))  Left JOIN {Region} \"enregion13\" ON (\"enrequisition16\".\"regionid\" = \"enregion13\".\"id\"))  Left JOIN {Company} \"encompany3\" ON (\"enrequisition16\".\"companyid\" = \"encompany3\".\"id\"))  Left JOIN {Supplier} \"ensupplier7\" ON (\"enrequisition16\".\"supplierid\" = \"ensupplier7\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApprovalLevel_Id != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel5\".\"id\" = @qpinInvoiceApprovalLevel_Id) AND (\"eninvoiceapprovallevel5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalLevel_Id", DbType.Int64, qpinInvoiceApprovalLevel_Id);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel5\".\"id\" IS NULL)");
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
RL_55207d74c9fa548c4383dfca6f13831e outParamList = new RL_55207d74c9fa548c4383dfca6f13831e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifInv.GetInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_55207d74c9fa548c4383dfca6f13831e _tmp = new RL_55207d74c9fa548c4383dfca6f13831e();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifInv.GetInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_55207d74c9fa548c4383dfca6f13831e)_tmp;
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

private static async Task<RC_bdad25a559cd2f146ec69d1aec036546> datasetGetInvoiceApprovalLevelContabReadDbAsync(RC_bdad25a559cd2f146ec69d1aec036546 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalLevelContab" Y6HG9r1aT0KAG9ZmPbcMtw of Action "ApprovModifInv"
public static async Task<(RL_6dc54c806e79e3021c958eb2cb6d90be,long)> datasetGetInvoiceApprovalLevelContab(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovModifInv.GetInvoiceApprovalLevelContab", "f6c6a163-5abd-424f-801b-d6663db70cb7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovModifInv.GetInvoiceApprovalLevelContab", "f6c6a163-5abd-424f-801b-d6663db70cb7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.heTUNyFw0kqo9AMFrmGymg/NodesNotShownInESpaceTree.Y6HG9r1aT0KAG9ZmPbcMtw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"eninvoiceapprovallevel6\".\"id\" o10, \"eninvoiceapprovallevel6\".\"invoiceapprovalid\" o11, \"eninvoiceapprovallevel6\".\"levelnumber\" o12, \"eninvoiceapprovallevel6\".\"assignedto\" o13, \"eninvoiceapprovallevel6\".\"applicationroleid\" o14, \"eninvoiceapprovallevel6\".\"entrajobtitle\" o15, \"eninvoiceapprovallevel6\".\"departmentid\" o16, \"eninvoiceapprovallevel6\".\"managementid\" o17, \"eninvoiceapprovallevel6\".\"subdirectionid\" o18, \"eninvoiceapprovallevel6\".\"entraroleid\" o19, \"eninvoiceapprovallevel6\".\"approvalstatusid\" o20, \"eninvoiceapprovallevel6\".\"canbefirstapprover\" o21, \"eninvoiceapprovallevel6\".\"selectsnextapprover\" o22, \"eninvoiceapprovallevel6\".\"selectsfirstapprover\" o23, \"eninvoiceapprovallevel6\".\"isaccounting\" o24, \"eninvoiceapprovallevel6\".\"isstartaccounting\" o25, \"eninvoiceapprovallevel6\".\"approvedby\" o26, \"eninvoiceapprovallevel6\".\"approvedon\" o27, \"eninvoiceapprovallevel6\".\"requesttomodifyby\" o28, \"eninvoiceapprovallevel6\".\"requesttomodifyon\" o29, \"eninvoiceapprovallevel6\".\"canceledby\" o30, \"eninvoiceapprovallevel6\".\"canceledon\" o31, \"eninvoiceapprovallevel6\".\"needscontract_deprec\" o32, \"eninvoiceapprovallevel6\".\"isreassigned\" o33, \"eninvoiceapprovallevel6\".\"issubstitutefor\" o34");
fromBuilder.Append(" FROM ({InvoiceApproval} \"eninvoiceapproval5\" Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel6\" ON (\"eninvoiceapproval5\".\"id\" = \"eninvoiceapprovallevel6\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval5\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval5\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval5\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel6\".\"isaccounting\" = 1) AND (\"eninvoiceapprovallevel6\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel6\".\"levelnumber\" ASC ");
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
RL_6dc54c806e79e3021c958eb2cb6d90be outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelContabReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovModifInv.GetInvoiceApprovalLevelContab.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6dc54c806e79e3021c958eb2cb6d90be _tmp = new RL_6dc54c806e79e3021c958eb2cb6d90be();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelContabReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovModifInv.GetInvoiceApprovalLevelContab.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6dc54c806e79e3021c958eb2cb6d90be)_tmp;
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
