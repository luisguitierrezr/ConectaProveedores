namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovRejectReqOrdFile : VarsBag {
public long inParami_OrderRequestFileApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Reason;
public int inParamOffsetUtc;
public Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate resCurrOrderRequestFileApprovalLevelCreateOrUpdate2 =  new Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd2 =  new Actions.lcoOrderLogAdd();
public RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 queryResGetPrevOrderRequestFileApprovalLevel_outParamList = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
public long queryResGetPrevOrderRequestFileApprovalLevel_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd3 =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderRequestFileApprovalCreateOrUpdate resOrderRequestFileApprovalCreateOrUpdate3 =  new Actions.lcoOrderRequestFileApprovalCreateOrUpdate();
public Actions.lcoOrderRequestFileCommentCreateOrUpdate resOrderRequestFileCommentCreateOrUpdate =  new Actions.lcoOrderRequestFileCommentCreateOrUpdate();
public Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate resCurrOrderRequestFileApprovalLevelCreateOrUpdate =  new Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate();
public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public RL_92308773b3659a47f4c72e6531100b74 queryResGetCurrOrderRequestFileApprovalLevel_outParamList = new RL_92308773b3659a47f4c72e6531100b74();
public long queryResGetCurrOrderRequestFileApprovalLevel_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd4 =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate resOrderRequestFileApprovalLevelCreateOrUpdate =  new Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate();
public Actions.lcoOrderRequestFileCreateOrUpdate resOrderRequestFileCreateOrUpdate2 =  new Actions.lcoOrderRequestFileCreateOrUpdate();
public Actions.lcoOrderRequestFileCreateOrUpdate resOrderRequestFileCreateOrUpdate =  new Actions.lcoOrderRequestFileCreateOrUpdate();
public Actions.lcoOrderRequestFileApprovalCreateOrUpdate resOrderRequestFileApprovalCreateOrUpdate =  new Actions.lcoOrderRequestFileApprovalCreateOrUpdate();
public Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate resNextOrderRequestFileApprovalLevelCreateOrUpdate =  new Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate();
public RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 queryResGetNextOrderRequestFileApprovalLevel_outParamList = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
public long queryResGetNextOrderRequestFileApprovalLevel_outParamCount = 0L;

public Actions.lcoOrderRequestFileApprovalCreateOrUpdate resOrderRequestFileApprovalCreateOrUpdate2 =  new Actions.lcoOrderRequestFileApprovalCreateOrUpdate();
public lcvApprovRejectReqOrdFile(long inParami_OrderRequestFileApprovalLevelId, bool inParami_IsApprove, string inParami_Reason, int inParamOffsetUtc) {
this.inParami_OrderRequestFileApprovalLevelId = inParami_OrderRequestFileApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Reason = inParami_Reason;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoApprovRejectReqOrdFile : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamOutput = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApprovRejectReqOrdFile() {
}
}
/// <summary>
/// Action <code>ApprovRejectReqOrdFile</code> that represents the Service Studio action
///  <code>ApprovRejectReqOrdFile</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApprovRejectReqOrdFile(IRequestContext requestContext,long inParami_OrderRequestFileApprovalLevelId,bool inParami_IsApprove,string inParami_Reason,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamOutput = default;
lcoApprovRejectReqOrdFile result = new lcoApprovRejectReqOrdFile();
lcvApprovRejectReqOrdFile localVars = new lcvApprovRejectReqOrdFile(inParami_OrderRequestFileApprovalLevelId, inParami_IsApprove, inParami_Reason, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovRejectReqOrdFile", "fb3c1a9d-6e3d-464f-ab44-65299afebe5a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovRejectReqOrdFile", "fb3c1a9d-6e3d-464f-ab44-65299afebe5a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetCurrOrderRequestFileApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCurrOrderRequestFileApprovalLevel_maxRecords = 1;
if (datasetGetCurrOrderRequestFileApprovalLevel_maxRecords < 1) datasetGetCurrOrderRequestFileApprovalLevel_maxRecords = 1;
int datasetGetCurrOrderRequestFileApprovalLevel_startIndex = 0;(localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamCount) = await FuncActionApprovRejectReqOrdFile.datasetGetCurrOrderRequestFileApprovalLevel(requestContext,datasetGetCurrOrderRequestFileApprovalLevel_maxRecords,datasetGetCurrOrderRequestFileApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderRequestFileApprovalLevelId,cancellationToken);

if(((localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) {
// Output
// Output.IsSuccess = False
result.outParamOutput.ssIsSuccess = false;

// Output.Message = "File approval cannot be updated!"
result.outParamOutput.ssMessage = AppUtils.GetStringResource("8gqiMU1nsEOuzQ7WH10+iQ#Value.-1009123617.1", "File approval cannot be updated!");
} else {
if((localVars.inParami_IsApprove)) {
// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;

// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovedBy = GetUserId
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();
// CurrOrderRequestFileApprovalLevelCreateOrUpdate
localVars.resCurrOrderRequestFileApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel,cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssOrderId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("3tpf7AhXWk6_vyAVpK4YDQ#Value.2189724.1", "File")+" ")+localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename)+" ")+AppUtils.GetStringResource("3tpf7AhXWk6_vyAVpK4YDQ#Value.-1295231707.1", "has been approved"))+".") },cancellationToken);

// Are there more levels?
if(((localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssLevelNumber<localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval.ssMaxLevel))) {
// Query datasetGetNextOrderRequestFileApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextOrderRequestFileApprovalLevel_maxRecords = 1;
if (datasetGetNextOrderRequestFileApprovalLevel_maxRecords < 1) datasetGetNextOrderRequestFileApprovalLevel_maxRecords = 1;
int datasetGetNextOrderRequestFileApprovalLevel_startIndex = 0;(localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList,localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamCount) = await FuncActionApprovRejectReqOrdFile.datasetGetNextOrderRequestFileApprovalLevel(requestContext,datasetGetNextOrderRequestFileApprovalLevel_maxRecords,datasetGetNextOrderRequestFileApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval.ssId,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssLevelNumber,cancellationToken);

// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssAssignedTo,cancellationToken);

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApproval.CurrentLevel = GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.LevelNumber
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval.ssCurrentLevel = localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssLevelNumber;

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.RejectedBy = NullTextIdentifier
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssRejectedBy = BuiltInFunction.NullTextIdentifier ();

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.RejectedOn = NullDate
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssRejectedOn = BuiltInFunction.NullDate ();

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.AssignedTo = If
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId) : (localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssAssignedTo));

// GetNextOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
// NextOrderRequestFileApprovalLevelCreateOrUpdate
localVars.resNextOrderRequestFileApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel,cancellationToken);

// OrderRequestFileApprovalCreateOrUpdate2
localVars.resOrderRequestFileApprovalCreateOrUpdate2.outParamId = await Actions.ActionOrderRequestFileApprovalCreateOrUpdate(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval,cancellationToken);

// Output.IsSuccess = True
result.outParamOutput.ssIsSuccess = true;
// SendOrdReqFileNextApproverEmail
await Actions.ActionSendOrdReqFileNextApproverEmail(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssId,cancellationToken);

} else {
// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApproval.FinishedOn = CurrDateTime
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFile.IsApproved = True
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssIsApproved = true;
// OrderRequestFileCreateOrUpdate
localVars.resOrderRequestFileCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileCreateOrUpdate(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile,cancellationToken);

// OrderRequestFileApprovalCreateOrUpdate
localVars.resOrderRequestFileApprovalCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileApprovalCreateOrUpdate(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval,cancellationToken);

// OrderLogAdd2
localVars.resOrderLogAdd2.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssOrderId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("AqulwE_DnEmq_sfr6P07Iw#Value.2189724.1", "File")+" ")+localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename)+" ")+AppUtils.GetStringResource("AqulwE_DnEmq_sfr6P07Iw#Value.1455861801.1", "has been updated to Approved status"))+".") },cancellationToken);

// NeedsApproval?
if((localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssNeedsApproval)) {
// OrderMainValidateAllFilesApproved
await Actions.ActionOrderMainValidateAllFilesApproved(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssOrderId,cancellationToken);

}

// NeedAccounting?
if((localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssNeedAccounting)) {
// InvoiceAccountingProcess_Create
await Actions.ActionInvoiceAccountingProcess_Create(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssInvoiceId,"",true,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamOffsetUtc,cancellationToken);

// Output.IsSuccess = True
result.outParamOutput.ssIsSuccess = true;

// Output.Message = "Accounting process started successfully."
result.outParamOutput.ssMessage = AppUtils.GetStringResource("i66AlKzgUEutRTzxcUZL3A#Value.1463600876.1", "Accounting process started successfully.");
} else {
// Output.IsSuccess = True
result.outParamOutput.ssIsSuccess = true;
}

}

} else {
// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovalStatusId = Rejected
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId;

// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.RejectedBy = GetUserId
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssRejectedBy = BuiltInFunction.GetUserId ();

// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.RejectedOn = CurrDateTime
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssRejectedOn = BuiltInFunction.CurrDateTime ();
// CurrOrderRequestFileApprovalLevelCreateOrUpdate2
localVars.resCurrOrderRequestFileApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionOrderRequestFileApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel,cancellationToken);

// OrderLogAdd3
localVars.resOrderLogAdd3.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssOrderId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((((((AppUtils.GetStringResource("sP8zOZ7EK0yBuYCIrhsdGA#Value.2189724.1", "File")+" ")+localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename)+" ")+AppUtils.GetStringResource("sP8zOZ7EK0yBuYCIrhsdGA#Value.1205994220.1", "has been rejected"))+". ")+AppUtils.GetStringResource("sP8zOZ7EK0yBuYCIrhsdGA#Value.-1851097500.1", "Reason"))+": ")+localVars.inParami_Reason) },cancellationToken);

// OrderRequestFileCommentCreateOrUpdate
localVars.resOrderRequestFileCommentCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileCommentCreateOrUpdate(requestContext,new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderRequestFileId = localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssId, ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = ((AppUtils.GetStringResource("QvLaFVW2NkazEqBpQPamqA#Value.1403692947.1", "The payment information file you uploaded was rejected because")+": ")+localVars.inParami_Reason) },cancellationToken);

// Query datasetGetPrevOrderRequestFileApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPrevOrderRequestFileApprovalLevel_maxRecords = 1;
if (datasetGetPrevOrderRequestFileApprovalLevel_maxRecords < 1) datasetGetPrevOrderRequestFileApprovalLevel_maxRecords = 1;
int datasetGetPrevOrderRequestFileApprovalLevel_startIndex = 0;(localVars.queryResGetPrevOrderRequestFileApprovalLevel_outParamList,localVars.queryResGetPrevOrderRequestFileApprovalLevel_outParamCount) = await FuncActionApprovRejectReqOrdFile.datasetGetPrevOrderRequestFileApprovalLevel(requestContext,datasetGetPrevOrderRequestFileApprovalLevel_maxRecords,datasetGetPrevOrderRequestFileApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval.ssId,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssLevelNumber,cancellationToken);

// Empty?
if((localVars.queryResGetPrevOrderRequestFileApprovalLevel_outParamList.Empty)) {
// GetCurrOrderRequestFileApprovalLevel.List.Current.OrderRequestFile.IsRejected = True
localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssIsRejected = true;
// OrderRequestFileCreateOrUpdate2
localVars.resOrderRequestFileCreateOrUpdate2.outParamId = await Actions.ActionOrderRequestFileCreateOrUpdate(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile,cancellationToken);

// OrderLogAdd4
localVars.resOrderLogAdd4.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssOrderId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("fYW_LrqAuEeZ_UUB7GW1RQ#Value.2189724.1", "File")+" ")+localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename)+" ")+AppUtils.GetStringResource("fYW_LrqAuEeZ_UUB7GW1RQ#Value.-1150401406.1", "has been updated to Rejected status"))+".") },cancellationToken);

// Output.IsSuccess = True
result.outParamOutput.ssIsSuccess = true;
// SendOrderReqFileRejectedEmail
await Actions.ActionSendOrderReqFileRejectedEmail(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFile.ssId,localVars.inParami_Reason,cancellationToken);

} else {
// GetPrevOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetPrevOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetPrevOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetPrevOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetPrevOrderRequestFileApprovalLevel.List.Current.OrderRequestFileApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetPrevOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();
// OrderRequestFileApprovalLevelCreateOrUpdate
localVars.resOrderRequestFileApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetPrevOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel,cancellationToken);

// OrderRequestFileApprovalCreateOrUpdate3
localVars.resOrderRequestFileApprovalCreateOrUpdate3.outParamId = await Actions.ActionOrderRequestFileApprovalCreateOrUpdate(requestContext,localVars.queryResGetCurrOrderRequestFileApprovalLevel_outParamList.CurrentRec.ssENOrderRequestFileApproval,cancellationToken);

// Output.IsSuccess = True
result.outParamOutput.ssIsSuccess = true;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamOutput = result.outParamOutput;
} // inner-finally
RETURN_STATEMENT:
return outParamOutput;
}

public static class FuncActionApprovRejectReqOrdFile {

private static async Task<RC_b93868933f6a016605b24812ac8e5133> datasetGetPrevOrderRequestFileApprovalLevelReadDbAsync(RC_b93868933f6a016605b24812ac8e5133 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderRequestFileApproval.Read( r, ref index);
rec.ssENOrderRequestFileApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetPrevOrderRequestFileApprovalLevel" +E_RJV+mvUatKl3d_asHnQ of Action "ApprovRejectReqOrdFile"
public static async Task<(RL_3c8cbdb9e0fe43bbb7aa86b8fa547000,long)> datasetGetPrevOrderRequestFileApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFileApproval_Id,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectReqOrdFile.GetPrevOrderRequestFileApprovalLevel", "25d14ff8-a65f-46bd-ad2a-5dddfdab079d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectReqOrdFile.GetPrevOrderRequestFileApprovalLevel", "25d14ff8-a65f-46bd-ad2a-5dddfdab079d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.nRo8+z1uT0arRGUpmv6+Wg/NodesNotShownInESpaceTree.+E_RJV+mvUatKl3d_asHnQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enorderrequestfileapprovallevel2\".\"id\" o6, \"enorderrequestfileapprovallevel2\".\"orderrequestfileapprovalid\" o7, \"enorderrequestfileapprovallevel2\".\"levelnumber\" o8, \"enorderrequestfileapprovallevel2\".\"entraroleid\" o9, \"enorderrequestfileapprovallevel2\".\"assignedto\" o10, \"enorderrequestfileapprovallevel2\".\"approvalstatusid\" o11, \"enorderrequestfileapprovallevel2\".\"approvedby\" o12, \"enorderrequestfileapprovallevel2\".\"approvedon\" o13, \"enorderrequestfileapprovallevel2\".\"rejectedby\" o14, \"enorderrequestfileapprovallevel2\".\"rejectedon\" o15, \"enorderrequestfileapprovallevel2\".\"isreassigned\" o16, \"enorderrequestfileapprovallevel2\".\"issubstitutefor\" o17");
fromBuilder.Append(" FROM ({OrderRequestFileApproval} \"enorderrequestfileapproval3\" Left JOIN {OrderRequestFileApprovalLevel} \"enorderrequestfileapprovallevel2\" ON (\"enorderrequestfileapproval3\".\"id\" = \"enorderrequestfileapprovallevel2\".\"orderrequestfileapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFileApproval_Id != 0) {
whereBuilder.Append("((\"enorderrequestfileapproval3\".\"id\" = @qporOrderRequestFileApproval_Id) AND (\"enorderrequestfileapproval3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFileApproval_Id", DbType.Int64, qporOrderRequestFileApproval_Id);
} else {
whereBuilder.Append("(\"enorderrequestfileapproval3\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderrequestfileapprovallevel2\".\"levelnumber\" < @qpinLevelNumber)");
orderByBuilder.Append(" ORDER BY \"enorderrequestfileapprovallevel2\".\"levelnumber\" DESC ");
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
RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 outParamList = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetPrevOrderRequestFileApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectReqOrdFile.GetPrevOrderRequestFileApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 _tmp = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
_tmp.AlternateReadDbMethodAsync = datasetGetPrevOrderRequestFileApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectReqOrdFile.GetPrevOrderRequestFileApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c8cbdb9e0fe43bbb7aa86b8fa547000)_tmp;
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

private static async Task<RC_a8588ebdb39bb2eab61d2bf4ba981fa2> datasetGetCurrOrderRequestFileApprovalLevelReadDbAsync(RC_a8588ebdb39bb2eab61d2bf4ba981fa2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderRequestFile.Read( r, ref index);
rec.ssENOrderRequestFileApproval.Read( r, ref index);
rec.ssENOrderRequestFileApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetCurrOrderRequestFileApprovalLevel" E3kmSwm0lE6G377CxD+YeQ of Action "ApprovRejectReqOrdFile"
public static async Task<(RL_92308773b3659a47f4c72e6531100b74,long)> datasetGetCurrOrderRequestFileApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFileApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectReqOrdFile.GetCurrOrderRequestFileApprovalLevel", "4b267913-b409-4e94-86df-bec2c43f9879");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectReqOrdFile.GetCurrOrderRequestFileApprovalLevel", "4b267913-b409-4e94-86df-bec2c43f9879", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.nRo8+z1uT0arRGUpmv6+Wg/NodesNotShownInESpaceTree.E3kmSwm0lE6G377CxD+YeQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderrequestfile9\".\"id\" o0, \"enorderrequestfile9\".\"orderid\" o1, \"enorderrequestfile9\".\"invoiceid\" o2, \"enorderrequestfile9\".\"filename\" o3, \"enorderrequestfile9\".\"storageid\" o4, \"enorderrequestfile9\".\"description\" o5, \"enorderrequestfile9\".\"needsapproval\" o6, \"enorderrequestfile9\".\"isapproved\" o7, \"enorderrequestfile9\".\"isrejected\" o8, \"enorderrequestfile9\".\"createdby\" o9, \"enorderrequestfile9\".\"createdon\" o10, \"enorderrequestfile9\".\"updatedby\" o11, \"enorderrequestfile9\".\"updatedon\" o12, \"enorderrequestfile9\".\"orderaccconceptid\" o13, \"enorderrequestfile9\".\"isfinancialfile\" o14, \"enorderrequestfile9\".\"ordercontractfile\" o15, \"enorderrequestfile9\".\"needaccounting\" o16, \"enorderrequestfileapproval4\".\"id\" o17, \"enorderrequestfileapproval4\".\"orderrequestfileid\" o18, \"enorderrequestfileapproval4\".\"currentlevel\" o19, \"enorderrequestfileapproval4\".\"maxlevel\" o20, \"enorderrequestfileapproval4\".\"startedon\" o21, \"enorderrequestfileapproval4\".\"finishedon\" o22, \"enorderrequestfileapprovallevel3\".\"id\" o23, \"enorderrequestfileapprovallevel3\".\"orderrequestfileapprovalid\" o24, \"enorderrequestfileapprovallevel3\".\"levelnumber\" o25, \"enorderrequestfileapprovallevel3\".\"entraroleid\" o26, \"enorderrequestfileapprovallevel3\".\"assignedto\" o27, \"enorderrequestfileapprovallevel3\".\"approvalstatusid\" o28, \"enorderrequestfileapprovallevel3\".\"approvedby\" o29, \"enorderrequestfileapprovallevel3\".\"approvedon\" o30, \"enorderrequestfileapprovallevel3\".\"rejectedby\" o31, \"enorderrequestfileapprovallevel3\".\"rejectedon\" o32, \"enorderrequestfileapprovallevel3\".\"isreassigned\" o33, \"enorderrequestfileapprovallevel3\".\"issubstitutefor\" o34");
fromBuilder.Append(" FROM (({OrderRequestFileApprovalLevel} \"enorderrequestfileapprovallevel3\" Left JOIN {OrderRequestFileApproval} \"enorderrequestfileapproval4\" ON (\"enorderrequestfileapprovallevel3\".\"orderrequestfileapprovalid\" = \"enorderrequestfileapproval4\".\"id\"))  Left JOIN {OrderRequestFile} \"enorderrequestfile9\" ON (\"enorderrequestfileapproval4\".\"orderrequestfileid\" = \"enorderrequestfile9\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFileApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enorderrequestfileapprovallevel3\".\"id\" = @qporOrderRequestFileApprovalLevel_Id) AND (\"enorderrequestfileapprovallevel3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFileApprovalLevel_Id", DbType.Int64, qporOrderRequestFileApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enorderrequestfileapprovallevel3\".\"id\" IS NULL)");
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
RL_92308773b3659a47f4c72e6531100b74 outParamList = new RL_92308773b3659a47f4c72e6531100b74();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCurrOrderRequestFileApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectReqOrdFile.GetCurrOrderRequestFileApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_92308773b3659a47f4c72e6531100b74 _tmp = new RL_92308773b3659a47f4c72e6531100b74();
_tmp.AlternateReadDbMethodAsync = datasetGetCurrOrderRequestFileApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectReqOrdFile.GetCurrOrderRequestFileApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_92308773b3659a47f4c72e6531100b74)_tmp;
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

private static async Task<RC_b93868933f6a016605b24812ac8e5133> datasetGetNextOrderRequestFileApprovalLevelReadDbAsync(RC_b93868933f6a016605b24812ac8e5133 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderRequestFileApproval.Read( r, ref index);
rec.ssENOrderRequestFileApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetNextOrderRequestFileApprovalLevel" Zbw1+0q1s0yU6S0hfsm7yA of Action "ApprovRejectReqOrdFile"
public static async Task<(RL_3c8cbdb9e0fe43bbb7aa86b8fa547000,long)> datasetGetNextOrderRequestFileApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFileApproval_Id,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectReqOrdFile.GetNextOrderRequestFileApprovalLevel", "fb35bc65-b54a-4cb3-94e9-2d217ec9bbc8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectReqOrdFile.GetNextOrderRequestFileApprovalLevel", "fb35bc65-b54a-4cb3-94e9-2d217ec9bbc8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.nRo8+z1uT0arRGUpmv6+Wg/NodesNotShownInESpaceTree.Zbw1+0q1s0yU6S0hfsm7yA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enorderrequestfileapprovallevel4\".\"id\" o6, \"enorderrequestfileapprovallevel4\".\"orderrequestfileapprovalid\" o7, \"enorderrequestfileapprovallevel4\".\"levelnumber\" o8, \"enorderrequestfileapprovallevel4\".\"entraroleid\" o9, \"enorderrequestfileapprovallevel4\".\"assignedto\" o10, \"enorderrequestfileapprovallevel4\".\"approvalstatusid\" o11, \"enorderrequestfileapprovallevel4\".\"approvedby\" o12, \"enorderrequestfileapprovallevel4\".\"approvedon\" o13, \"enorderrequestfileapprovallevel4\".\"rejectedby\" o14, \"enorderrequestfileapprovallevel4\".\"rejectedon\" o15, \"enorderrequestfileapprovallevel4\".\"isreassigned\" o16, \"enorderrequestfileapprovallevel4\".\"issubstitutefor\" o17");
fromBuilder.Append(" FROM ({OrderRequestFileApprovalLevel} \"enorderrequestfileapprovallevel4\" Left JOIN {OrderRequestFileApproval} \"enorderrequestfileapproval5\" ON (\"enorderrequestfileapprovallevel4\".\"orderrequestfileapprovalid\" = \"enorderrequestfileapproval5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFileApproval_Id != 0) {
whereBuilder.Append("((\"enorderrequestfileapproval5\".\"id\" = @qporOrderRequestFileApproval_Id) AND (\"enorderrequestfileapproval5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFileApproval_Id", DbType.Int64, qporOrderRequestFileApproval_Id);
} else {
whereBuilder.Append("(\"enorderrequestfileapproval5\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderrequestfileapprovallevel4\".\"levelnumber\" > @qpinLevelNumber)");
orderByBuilder.Append(" ORDER BY \"enorderrequestfileapprovallevel4\".\"levelnumber\" ASC ");
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
RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 outParamList = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextOrderRequestFileApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectReqOrdFile.GetNextOrderRequestFileApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 _tmp = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
_tmp.AlternateReadDbMethodAsync = datasetGetNextOrderRequestFileApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectReqOrdFile.GetNextOrderRequestFileApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c8cbdb9e0fe43bbb7aa86b8fa547000)_tmp;
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
