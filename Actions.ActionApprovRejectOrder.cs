namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovRejectOrder : VarsBag {
public long inParami_OrderId;
public long inParami_OrderApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Reason;
public Actions.lcoOrderApprovalLevelCreateOrUpdate resCurrentOrderApprovalLevelCU4 =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCU3 =  new Actions.lcoOrderMainCreateOrUpdate();
public Actions.lcoOrderApprovalLevelCreateOrUpdate resNextOrderApprovalLevelCU5 =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCU2 =  new Actions.lcoOrderMainCreateOrUpdate();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCU =  new Actions.lcoOrderMainCreateOrUpdate();
public Actions.lcoOrderApprovalLevelCreateOrUpdate resCurrentOrderApprovalLevelCU3 =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public Actions.lcoOrderApprovalCreateOrUpdate resOrderApprovalCU =  new Actions.lcoOrderApprovalCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd6 =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderLogAdd resOrderLogAdd4 =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderApprovalCreateOrUpdate resOrderApprovalCU2 =  new Actions.lcoOrderApprovalCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd3 =  new Actions.lcoOrderLogAdd();
public Actions.lcoGetLastAppoverGerenteJefe resGetLastAppoverGerenteJefe =  new Actions.lcoGetLastAppoverGerenteJefe();
public RL_e789cb37ac17656efa6a3e4ebf8105c4 queryResGetCurrentOrderApprovalLevel_outParamList = new RL_e789cb37ac17656efa6a3e4ebf8105c4();
public long queryResGetCurrentOrderApprovalLevel_outParamCount = 0L;

public Actions.lcoOrderCommentCreateOrUpdate resOrderCommentCreateOrUpdate =  new Actions.lcoOrderCommentCreateOrUpdate();
public RL_ee0c9b1586585bb225d3aea45637d365 queryResGetNextOrderApprovalLevel_outParamList = new RL_ee0c9b1586585bb225d3aea45637d365();
public long queryResGetNextOrderApprovalLevel_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd5 =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderApprovalLevelCreateOrUpdate resCurrentOrderApprovalLevelCU2 =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd2 =  new Actions.lcoOrderLogAdd();
public lcvApprovRejectOrder(long inParami_OrderId, long inParami_OrderApprovalLevelId, bool inParami_IsApprove, string inParami_Reason) {
this.inParami_OrderId = inParami_OrderId;
this.inParami_OrderApprovalLevelId = inParami_OrderApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Reason = inParami_Reason;
}
}
public class lcoApprovRejectOrder : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApprovRejectOrder() {
}
}
/// <summary>
/// Action <code>ApprovRejectOrder</code> that represents the Service Studio action
///  <code>ApprovRejectOrder</code> <p> Description: Advance Order to Next Step.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApprovRejectOrder(IRequestContext requestContext,long inParami_OrderId,long inParami_OrderApprovalLevelId,bool inParami_IsApprove,string inParami_Reason,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoApprovRejectOrder result = new lcoApprovRejectOrder();
lcvApprovRejectOrder localVars = new lcvApprovRejectOrder(inParami_OrderId, inParami_OrderApprovalLevelId, inParami_IsApprove, inParami_Reason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovRejectOrder", "f73279b7-e725-4093-b0d6-b5e1b430d251"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovRejectOrder", "f73279b7-e725-4093-b0d6-b5e1b430d251", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetCurrentOrderApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCurrentOrderApprovalLevel_maxRecords = 1;
if (datasetGetCurrentOrderApprovalLevel_maxRecords < 1) datasetGetCurrentOrderApprovalLevel_maxRecords = 1;
int datasetGetCurrentOrderApprovalLevel_startIndex = 0;(localVars.queryResGetCurrentOrderApprovalLevel_outParamList,localVars.queryResGetCurrentOrderApprovalLevel_outParamCount) = await FuncActionApprovRejectOrder.datasetGetCurrentOrderApprovalLevel(requestContext,datasetGetCurrentOrderApprovalLevel_maxRecords,datasetGetCurrentOrderApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderApprovalLevelId,localVars.inParami_OrderId,cancellationToken);

if((((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId)&&(localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)))) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Order cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("JxgIwaSWjkqaOUpO6sRZFw#Value.2095613080.1", "Order cannot be updated!");
} else {
// ApprovalRejected?
if(((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId))) {
// ClearOldApproval
await Actions.ActionClearOldOrderApproval(requestContext,localVars.inParami_OrderId,cancellationToken);

}

// Query datasetGetNextOrderApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextOrderApprovalLevel_maxRecords = 1;
if (datasetGetNextOrderApprovalLevel_maxRecords < 1) datasetGetNextOrderApprovalLevel_maxRecords = 1;
int datasetGetNextOrderApprovalLevel_startIndex = 0;(localVars.queryResGetNextOrderApprovalLevel_outParamList,localVars.queryResGetNextOrderApprovalLevel_outParamCount) = await FuncActionApprovRejectOrder.datasetGetNextOrderApprovalLevel(requestContext,datasetGetNextOrderApprovalLevel_maxRecords,datasetGetNextOrderApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssId,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssLevelNumber,cancellationToken);

if((localVars.inParami_IsApprove)) {
// CurrentApprovalLevel
// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovalStatusId = If
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("EW9OOAC7ZEm3iGeypPwFAg"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId));

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovedBy = GetUserId
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.AssignedTo = If
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo = (((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo) : (BuiltInFunction.GetUserId ()));
// Are there more levels?
if(((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssCurrentLevel<localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssMaxLevel))) {
// GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.AssignedOn = CurrDateTime
localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedOn = BuiltInFunction.CurrDateTime ();

// GetCurrentOrderApprovalLevel.List.Current.OrderApproval.CurrentLevel = GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.LevelNumber
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssCurrentLevel = localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssLevelNumber;
// CurrentOrderApprovalLevelCU2
localVars.resCurrentOrderApprovalLevelCU2.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("1wvnzpF6f0e_yTGxh8Fb_g#Value.76453678.1", "Order")+" ")+localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("1wvnzpF6f0e_yTGxh8Fb_g#Value.1185244855.1", "approved"))+(((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (((" "+AppUtils.GetStringResource("1wvnzpF6f0e_yTGxh8Fb_g#Value.1391357666.1", "by a substitute"))+".")) : ("."))) },cancellationToken);

// NextOrderApprovalLevelCU5
localVars.resNextOrderApprovalLevelCU5.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// OrderApprovalCU
localVars.resOrderApprovalCU.outParamId = await Actions.ActionOrderApprovalCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval,cancellationToken);

// IsFromComplement?
if((((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"))).ssId)||(localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId)))) {
// OrderStatusId
// GetCurrentOrderApprovalLevel.List.Current.OrderMain.OrderStatusId = InApproval
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("gqnAVya9FU+_7f97jQeuCA"))).ssId;
// OrderMainCU
(localVars.resOrderMainCU.outParamId,localVars.resOrderMainCU.outParamHasSuccess,localVars.resOrderMainCU.outParamErrorMessage,localVars.resOrderMainCU.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// OrderLogAdd2
localVars.resOrderLogAdd2.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("9TRrYpoa2km+OMe0T4cKVg#Value.76453678.1", "Order")+" ")+localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("9TRrYpoa2km+OMe0T4cKVg#Value.-1917711778.1", "updated to status In Approval.")) },cancellationToken);

// Has Request Documents
if(((!localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderDetail.ssHasntRequestDocuments))) {
// SendOrderRequestedFilesEmailProveedor
await Actions.ActionSendOrderRequestedFilesEmailProveedor(requestContext,localVars.inParami_OrderId,cancellationToken);

}

}

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendOrderNextApproverEmail
await Actions.ActionSendOrderNextApproverEmail(requestContext,localVars.inParami_OrderId,cancellationToken);

} else {
// ApprovalLevel
// GetCurrentOrderApprovalLevel.List.Current.OrderApproval.FinishedOn = CurrDateTime
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetCurrentOrderApprovalLevel.List.Current.OrderMain.OrderStatusId = Approved
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId;
// GetLastAppoverGerenteJefe
(localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelGerente_CxP,localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelJefe_CxP) = await Actions.ActionGetLastAppoverGerenteJefe(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// Approval
// GetCurrentOrderApprovalLevel.List.Current.OrderApproval.LastApproverPuestodelGerente = GetLastAppoverGerenteJefe.o_LastApproverPuestodelGerente_CxP
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssLastApproverPuestodelGerente = localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelGerente_CxP;

// GetCurrentOrderApprovalLevel.List.Current.OrderApproval.LastApproverPuestodelJefe = GetLastAppoverGerenteJefe.o_LastApproverPuestodelJefe_CxP
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssLastApproverPuestodelJefe = localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelJefe_CxP;
// CurrentOrderApprovalLevelCU3
localVars.resCurrentOrderApprovalLevelCU3.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// OrderLogAdd5
localVars.resOrderLogAdd5.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("bBvLL1fvrkyH9xWozImb7A#Value.76453678.1", "Order")+" ")+localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("bBvLL1fvrkyH9xWozImb7A#Value.1185244855.1", "approved"))+(((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (((" "+AppUtils.GetStringResource("bBvLL1fvrkyH9xWozImb7A#Value.1391357666.1", "by a substitute"))+".")) : ("."))) },cancellationToken);

// OrderApprovalCU2
localVars.resOrderApprovalCU2.outParamId = await Actions.ActionOrderApprovalCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval,cancellationToken);

// OrderMainCU2
(localVars.resOrderMainCU2.outParamId,localVars.resOrderMainCU2.outParamHasSuccess,localVars.resOrderMainCU2.outParamErrorMessage,localVars.resOrderMainCU2.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// OrderLogAdd4
localVars.resOrderLogAdd4.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("RSxwWJw2yEuVo7Fx09qNHA#Value.76453678.1", "Order")+" ")+localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("RSxwWJw2yEuVo7Fx09qNHA#Value.-580004439.1", "updated to status Approved.")) },cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendOrderApprovedEmailProveedor
await Actions.ActionSendOrderApprovedEmailProveedor(requestContext,localVars.inParami_OrderId,cancellationToken);

}

} else {
// CurrentApprovalLevel
// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovalStatusId = Rejected
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId;

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.RejectedBy = GetUserId
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssRejectedBy = BuiltInFunction.GetUserId ();

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.RejectedOn = CurrDateTime
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssRejectedOn = BuiltInFunction.CurrDateTime ();

// GetCurrentOrderApprovalLevel.List.Current.OrderMain.OrderStatusId = ApprovalRejected
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId;

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.AssignedTo = If
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo = (((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo) : (BuiltInFunction.GetUserId ()));
// CurrentOrderApprovalLevelCU4
localVars.resCurrentOrderApprovalLevelCU4.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// OrderLogAdd3
localVars.resOrderLogAdd3.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((((((AppUtils.GetStringResource("ljfN_Vg+WkyRGd7vMPxJyg#Value.76453678.1", "Order")+" ")+localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("ljfN_Vg+WkyRGd7vMPxJyg#Value.-608496514.1", "rejected"))+(((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (((" "+AppUtils.GetStringResource("ljfN_Vg+WkyRGd7vMPxJyg#Value.1391357666.1", "by a substitute"))+".")) : (".")))+" ")+AppUtils.GetStringResource("ljfN_Vg+WkyRGd7vMPxJyg#Value.-1984451418.1", "Motive"))+": ")+localVars.inParami_Reason) },cancellationToken);

// OrderCommentCreateOrUpdate
localVars.resOrderCommentCreateOrUpdate.outParamId = await Actions.ActionOrderCommentCreateOrUpdate(requestContext,new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId, ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssOrderApprovalLevelId = localVars.inParami_OrderApprovalLevelId, ssEntraRoleId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId, ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = localVars.inParami_Reason },cancellationToken);

// OrderMainCU3
(localVars.resOrderMainCU3.outParamId,localVars.resOrderMainCU3.outParamHasSuccess,localVars.resOrderMainCU3.outParamErrorMessage,localVars.resOrderMainCU3.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// OrderLogAdd6
localVars.resOrderLogAdd6.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("4sa8DUcNbkO5_j05aYpbnQ#Value.76453678.1", "Order")+" ")+localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("4sa8DUcNbkO5_j05aYpbnQ#Value.1766043771.1", "updated to status Rejected and returned for information completion"))+".") },cancellationToken);

// GoBackToComplement
await Actions.ActionGoBackToComplement(requestContext,localVars.inParami_OrderId,cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendOrderRejectedEmail
await Actions.ActionSendOrderRejectedEmail(requestContext,localVars.inParami_OrderId,cancellationToken);

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

public static class FuncActionApprovRejectOrder {

private static async Task<RC_769ee8aabb441225ce35b37fa0078ec1> datasetGetCurrentOrderApprovalLevelReadDbAsync(RC_769ee8aabb441225ce35b37fa0078ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetCurrentOrderApprovalLevel" X7hBowZNjkyIfXUyoZmInA of Action "ApprovRejectOrder"
public static async Task<(RL_e789cb37ac17656efa6a3e4ebf8105c4,long)> datasetGetCurrentOrderApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApprovalLevel_Id,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectOrder.GetCurrentOrderApprovalLevel", "a341b85f-4d06-4c8e-887d-7532a199889c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectOrder.GetCurrentOrderApprovalLevel", "a341b85f-4d06-4c8e-887d-7532a199889c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.t3ky9yXnk0Cw1rXhtDDSUQ/NodesNotShownInESpaceTree.X7hBowZNjkyIfXUyoZmInA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval20\".\"id\" o0, \"enorderapproval20\".\"orderid\" o1, \"enorderapproval20\".\"currentlevel\" o2, \"enorderapproval20\".\"maxlevel\" o3, \"enorderapproval20\".\"startedon\" o4, \"enorderapproval20\".\"finishedon\" o5, \"enorderapproval20\".\"lastapproverpuestodelgerente\" o6, \"enorderapproval20\".\"lastapproverpuestodeljefe\" o7, \"enorderapprovallevel19\".\"id\" o8, \"enorderapprovallevel19\".\"orderapprovalid\" o9, \"enorderapprovallevel19\".\"levelnumber\" o10, \"enorderapprovallevel19\".\"entraroleid\" o11, \"enorderapprovallevel19\".\"assignedto\" o12, \"enorderapprovallevel19\".\"assignedon\" o13, \"enorderapprovallevel19\".\"approvalstatusid\" o14, \"enorderapprovallevel19\".\"approvedby\" o15, \"enorderapprovallevel19\".\"approvedon\" o16, \"enorderapprovallevel19\".\"rejectedby\" o17, \"enorderapprovallevel19\".\"rejectedon\" o18, \"enorderapprovallevel19\".\"iscomplement\" o19, \"enorderapprovallevel19\".\"isreassigned\" o20, \"enorderapprovallevel19\".\"issubstitutefor\" o21, \"enorderapprovallevel19\".\"tomodifyby\" o22, \"enorderapprovallevel19\".\"tomodifyon\" o23, \"enorderapprovallevel19\".\"wascanceledby\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"enorderdetail9\".\"hasntrequestdocuments\" o63, \"enordermain65\".\"id\" o64, \"enordermain65\".\"ordernumber\" o65, \"enordermain65\".\"orderdate\" o66, \"enordermain65\".\"orderstatusid\" o67, \"enordermain65\".\"previousorderstatusid\" o68, \"enordermain65\".\"assignmentcode\" o69, \"enordermain65\".\"supplierid\" o70, \"enordermain65\".\"companyid\" o71, \"enordermain65\".\"documenttypeid\" o72, \"enordermain65\".\"currencyid\" o73, \"enordermain65\".\"telceldirectionid\" o74, \"enordermain65\".\"procurementgroup\" o75, \"enordermain65\".\"creatorsapnumber\" o76, \"enordermain65\".\"creatorsapname\" o77, \"enordermain65\".\"country\" o78, \"enordermain65\".\"isdeleted\" o79, \"enordermain65\".\"isreleased\" o80, trim_scale(\"enordermain65\".\"exchangerate\"::numeric) o81, \"enordermain65\".\"sustainabilitycategory\" o82, \"enordermain65\".\"sustainabilitysubcategory\" o83, trim_scale(\"enordermain65\".\"totalamount\"::numeric) o84, \"enordermain65\".\"fromcosmoz\" o85, \"enordermain65\".\"regionid\" o86, \"enordermain65\".\"divisionid\" o87, \"enordermain65\".\"applicant\" o88, \"enordermain65\".\"createdby\" o89, \"enordermain65\".\"createdon\" o90, \"enordermain65\".\"updatedby\" o91, \"enordermain65\".\"updatedon\" o92");
fromBuilder.Append(" FROM ((({OrderMain} \"enordermain65\" Left JOIN {OrderApproval} \"enorderapproval20\" ON (\"enordermain65\".\"id\" = \"enorderapproval20\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel19\" ON (\"enorderapproval20\".\"id\" = \"enorderapprovallevel19\".\"orderapprovalid\"))  Left JOIN {OrderDetail} \"enorderdetail9\" ON (\"enordermain65\".\"id\" = \"enorderdetail9\".\"orderid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain65\".\"id\" = @qporOrderMain_Id) AND (\"enordermain65\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain65\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qporOrderApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enorderapprovallevel19\".\"id\" = @qporOrderApprovalLevel_Id) AND (\"enorderapprovallevel19\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApprovalLevel_Id", DbType.Int64, qporOrderApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enorderapprovallevel19\".\"id\" IS NULL)");
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
RL_e789cb37ac17656efa6a3e4ebf8105c4 outParamList = new RL_e789cb37ac17656efa6a3e4ebf8105c4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCurrentOrderApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectOrder.GetCurrentOrderApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e789cb37ac17656efa6a3e4ebf8105c4 _tmp = new RL_e789cb37ac17656efa6a3e4ebf8105c4();
_tmp.AlternateReadDbMethodAsync = datasetGetCurrentOrderApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectOrder.GetCurrentOrderApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e789cb37ac17656efa6a3e4ebf8105c4)_tmp;
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

// Query Function "GetNextOrderApprovalLevel" jHO5xzMkRkK5WbY9DJuotw of Action "ApprovRejectOrder"
public static async Task<(RL_ee0c9b1586585bb225d3aea45637d365,long)> datasetGetNextOrderApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApprovalId,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectOrder.GetNextOrderApprovalLevel", "c7b9738c-2433-4246-b959-b63d0c9ba8b7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectOrder.GetNextOrderApprovalLevel", "c7b9738c-2433-4246-b959-b63d0c9ba8b7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.t3ky9yXnk0Cw1rXhtDDSUQ/NodesNotShownInESpaceTree.jHO5xzMkRkK5WbY9DJuotw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapprovallevel20\".\"id\" o0, \"enorderapprovallevel20\".\"orderapprovalid\" o1, \"enorderapprovallevel20\".\"levelnumber\" o2, \"enorderapprovallevel20\".\"entraroleid\" o3, \"enorderapprovallevel20\".\"assignedto\" o4, \"enorderapprovallevel20\".\"assignedon\" o5, \"enorderapprovallevel20\".\"approvalstatusid\" o6, \"enorderapprovallevel20\".\"approvedby\" o7, \"enorderapprovallevel20\".\"approvedon\" o8, \"enorderapprovallevel20\".\"rejectedby\" o9, \"enorderapprovallevel20\".\"rejectedon\" o10, \"enorderapprovallevel20\".\"iscomplement\" o11, \"enorderapprovallevel20\".\"isreassigned\" o12, \"enorderapprovallevel20\".\"issubstitutefor\" o13, \"enorderapprovallevel20\".\"tomodifyby\" o14, \"enorderapprovallevel20\".\"tomodifyon\" o15, \"enorderapprovallevel20\".\"wascanceledby\" o16");
fromBuilder.Append(" FROM {OrderApprovalLevel} \"enorderapprovallevel20\"");
whereBuilder.Append(" WHERE ");
if (qporOrderApprovalId != 0) {
whereBuilder.Append("((\"enorderapprovallevel20\".\"orderapprovalid\" = @qporOrderApprovalId) AND (\"enorderapprovallevel20\".\"orderapprovalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApprovalId", DbType.Int64, qporOrderApprovalId);
} else {
whereBuilder.Append("(\"enorderapprovallevel20\".\"orderapprovalid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel20\".\"levelnumber\" > @qpinLevelNumber)");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel20\".\"levelnumber\" ASC ");
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
RL_ee0c9b1586585bb225d3aea45637d365 outParamList = new RL_ee0c9b1586585bb225d3aea45637d365();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectOrder.GetNextOrderApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ee0c9b1586585bb225d3aea45637d365 _tmp = new RL_ee0c9b1586585bb225d3aea45637d365();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectOrder.GetNextOrderApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ee0c9b1586585bb225d3aea45637d365)_tmp;
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
