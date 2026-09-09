namespace ssConectaProveedores;

public partial class Actions {
public class lcvReassign : VarsBag {
public RL_8c69b09c6d811e27e13cdf810a622fb2 inParamInvList;
public RL_6f013a7f2ef00b964b6e71f1ec07b189 inParamReqList;
public string inParami_TargetUserAUEntraId;
public string inParami_Reason;
public string inParami_SourceUserId;
/// <summary>
/// Variable <code>l_InvoiceLogs</code> that represents the Service Studio InvoiceLogList
///  <code>l_InvoiceLogs</code> <p>Description: InvoiceLog List</p>
/// </summary>
public RL_3c85b6eb7948435e547c7243037d9ca0 varLcl_InvoiceLogs = new RL_3c85b6eb7948435e547c7243037d9ca0();

/// <summary>
/// Variable <code>l_RequisitionApprovalLevels</code> that represents the Service Studio
///  RequisitionApprovalLevelList <code>l_RequisitionApprovalLevels</code> <p>Description
/// : RequisitionApprovalLevel List</p>
/// </summary>
public RL_75b7c1c818327cb126543d6d6a18a3c3 varLcl_RequisitionApprovalLevels = new RL_75b7c1c818327cb126543d6d6a18a3c3();

/// <summary>
/// Variable <code>l_Reassignments</code> that represents the Service Studio ReassignmentsList
///  <code>l_Reassignments</code> <p>Description: Reassignments List</p>
/// </summary>
public RL_1baaef4f70e46e094f278bb36a3e6c6e varLcl_Reassignments = new RL_1baaef4f70e46e094f278bb36a3e6c6e();

/// <summary>
/// Variable <code>l_TargetUserAUUser</code> that represents the Service Studio
///  UserUser_Extended_InternalRecord <code>l_TargetUserAUUser</code> <p>Description: User</p>
/// </summary>
public RC_34272dae45b4de5e1332f46c6e8700b9 varLcl_TargetUserAUUser = new RC_34272dae45b4de5e1332f46c6e8700b9();

/// <summary>
/// Variable <code>l_RequisitionLogs</code> that represents the Service Studio RequisitionLogsList
///  <code>l_RequisitionLogs</code> <p>Description: RequisitionLogs List</p>
/// </summary>
public RL_fdafd442807cd919d566b3ebfe8b6822 varLcl_RequisitionLogs = new RL_fdafd442807cd919d566b3ebfe8b6822();

/// <summary>
/// Variable <code>l_InvoiceApprovalLevels</code> that represents the Service Studio
///  InvoiceApprovalLevelList <code>l_InvoiceApprovalLevels</code> <p>Description: InvoiceApprovalLeve
/// l List</p>
/// </summary>
public RL_ceb6b480297e13460f270b15b86cd978 varLcl_InvoiceApprovalLevels = new RL_ceb6b480297e13460f270b15b86cd978();

/// <summary>
/// Variable <code>l_ReqInvListReassigned</code> that represents the Service Studio Text
///  <code>l_ReqInvListReassigned</code> <p>Description: ReqInvListReassigned</p>
/// </summary>
public string varLcl_ReqInvListReassigned = "";

public RL_752c66ffcb633a1081093541635464e7 queryResGetUserAUByEntraId_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserAUByEntraId_outParamCount = 0L;

public string resJSONSerialize1_outParamJSON = "";
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisition_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisition_outParamCount = 0L;

public RL_6f013a7f2ef00b964b6e71f1ec07b189 resListFilterReqList_outParamFilteredList = new RL_6f013a7f2ef00b964b6e71f1ec07b189();

public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoice_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoice_outParamCount = 0L;

public string resJSONSerialize2_outParamJSON = "";
public RL_8c69b09c6d811e27e13cdf810a622fb2 resListFilterInvList_outParamFilteredList = new RL_8c69b09c6d811e27e13cdf810a622fb2();

public RL_8430333e95ceffc00def96d8abb01f75 queryResGetSourceUserById_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetSourceUserById_outParamCount = 0L;

public lcvReassign(RL_8c69b09c6d811e27e13cdf810a622fb2 inParamInvList, RL_6f013a7f2ef00b964b6e71f1ec07b189 inParamReqList, string inParami_TargetUserAUEntraId, string inParami_Reason, string inParami_SourceUserId) {
this.inParamInvList = inParamInvList;
this.inParamReqList = inParamReqList;
this.inParami_TargetUserAUEntraId = inParami_TargetUserAUEntraId;
this.inParami_Reason = inParami_Reason;
this.inParami_SourceUserId = inParami_SourceUserId;
}
}
public class lcoReassign : VarsBag {
public ST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent = new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();

public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoReassign() {
}
}
/// <summary>
/// Action <code>Reassign</code> that represents the Service Studio action <code>Reassign</code> <p>
///  Description: </p>
/// </summary>
public static async Task<(ST_6fc999fa8f6e0055c73f2f167c4bad19Structure,ST_046fb53ebbe142526d95e87ef1ae9711Structure)> ActionReassign(IRequestContext requestContext,RL_8c69b09c6d811e27e13cdf810a622fb2 inParamInvList,RL_6f013a7f2ef00b964b6e71f1ec07b189 inParamReqList,string inParami_TargetUserAUEntraId,string inParami_Reason,string inParami_SourceUserId,CancellationToken cancellationToken) {
ST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent = default;
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoReassign result = new lcoReassign();
lcvReassign localVars = new lcvReassign(inParamInvList, inParamReqList, inParami_TargetUserAUEntraId, inParami_Reason, inParami_SourceUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Reassign", "925670dc-8e5e-4858-8873-923ab905c3f6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Reassign", "925670dc-8e5e-4858-8873-923ab905c3f6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_TargetUserAUEntraId==""))) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Reassignment failed due to: Target User Area Usuaria and Target User Area CxP have not been selected."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("gBRO5JhMK0aPm8ST5TVVjg#Value.-2026206664.1", "Reassignment failed due to: Target User Area Usuaria and Target User Area CxP have not been selected.");
} else {
// Query datasetGetUserAUByEntraId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserAUByEntraId_maxRecords = 1;
if (datasetGetUserAUByEntraId_maxRecords < 1) datasetGetUserAUByEntraId_maxRecords = 1;
int datasetGetUserAUByEntraId_startIndex = 0;(localVars.queryResGetUserAUByEntraId_outParamList,localVars.queryResGetUserAUByEntraId_outParamCount) = await FuncActionReassign.datasetGetUserAUByEntraId(requestContext,datasetGetUserAUByEntraId_maxRecords,datasetGetUserAUByEntraId_startIndex,IterationMultiplicity.Never,localVars.inParami_TargetUserAUEntraId,cancellationToken);

// Empty?
if((localVars.queryResGetUserAUByEntraId_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Reassignment failed due to: Target User Area Usuaria selected has not yet logged into the application."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("O3cIchAWpESk4rlYiEfryA#Value.401913282.1", "Reassignment failed due to: Target User Area Usuaria selected has not yet logged into the application.");
} else {
// l_TargetUserAUUser = GetUserAUByEntraId.List.Current
localVars.varLcl_TargetUserAUUser=localVars.queryResGetUserAUByEntraId_outParamList.CurrentRec;
// Query datasetGetSourceUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSourceUserById_maxRecords = 1;
if (datasetGetSourceUserById_maxRecords < 1) datasetGetSourceUserById_maxRecords = 1;
int datasetGetSourceUserById_startIndex = 0;(localVars.queryResGetSourceUserById_outParamList,localVars.queryResGetSourceUserById_outParamCount) = await FuncActionReassign.datasetGetSourceUserById(requestContext,datasetGetSourceUserById_maxRecords,datasetGetSourceUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_SourceUserId,cancellationToken);

// ListFilterReqList
localVars.resListFilterReqList_outParamFilteredList = (((RL_6f013a7f2ef00b964b6e71f1ec07b189)await  localVars.inParamReqList.FilterAsync(async (p, cancellationToken) => p.ssIsSelected, cancellationToken)));

// ListFilterInvList
localVars.resListFilterInvList_outParamFilteredList = (((RL_8c69b09c6d811e27e13cdf810a622fb2)await  localVars.inParamInvList.FilterAsync(async (p, cancellationToken) => p.ssIsSelected, cancellationToken)));

// Foreach ListFilterReqList.FilteredList
localVars.resListFilterReqList_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterReqList_outParamFilteredList.Eof))) {
// Query datasetGetRequisition
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisition_maxRecords = 1;
if (datasetGetRequisition_maxRecords < 1) datasetGetRequisition_maxRecords = 1;
int datasetGetRequisition_startIndex = 0;(localVars.queryResGetRequisition_outParamList,localVars.queryResGetRequisition_outParamCount) = await FuncActionReassign.datasetGetRequisition(requestContext,datasetGetRequisition_maxRecords,datasetGetRequisition_startIndex,IterationMultiplicity.Never,localVars.resListFilterReqList_outParamFilteredList.CurrentRec.ssRequisitionApprovalLevelId,cancellationToken);

// ListAppendReassignments
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_Reassignments,new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssSourceUserId = localVars.queryResGetRequisition_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo, ssTargetUserId = localVars.varLcl_TargetUserAUUser.ssENUser.ssId, ssRequisitionId = localVars.resListFilterReqList_outParamFilteredList.CurrentRec.ssRequisitionId, ssRequisitionApprovalLevelId = localVars.resListFilterReqList_outParamFilteredList.CurrentRec.ssRequisitionApprovalLevelId, ssReason = localVars.inParami_Reason, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// GetRequisition.List.Current.RequisitionApprovalLevel.AssignedTo = l_TargetUserAUUser.User.Id
localVars.queryResGetRequisition_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = localVars.varLcl_TargetUserAUUser.ssENUser.ssId;

// GetRequisition.List.Current.RequisitionApprovalLevel.IsReassigned = True
localVars.queryResGetRequisition_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsReassigned = true;

// GetRequisition.List.Current.RequisitionApprovalLevel.IsSubstituteFor = l_TargetUserAUUser.User.Id
localVars.queryResGetRequisition_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor = localVars.varLcl_TargetUserAUUser.ssENUser.ssId;
// ListAppendRequisitionApprovalLevels
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_RequisitionApprovalLevels,localVars.queryResGetRequisition_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// ListAppendRequisitionLogs
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_RequisitionLogs,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.resListFilterReqList_outParamFilteredList.CurrentRec.ssRequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("79LkrsVoAUSvuGl_KMcrXA#Value.-682383654.1", "Reassignment:")+" ")+localVars.queryResGetSourceUserById_outParamList.CurrentRec.ssENUser.ssName)+" -> ")+localVars.varLcl_TargetUserAUUser.ssENUser.ssName) },cancellationToken);

localVars.resListFilterReqList_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterReqList_outParamFilteredList.EndIteration();
}

// Foreach ListFilterInvList.FilteredList
localVars.resListFilterInvList_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterInvList_outParamFilteredList.Eof))) {
// Query datasetGetInvoice
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoice_maxRecords = 1;
if (datasetGetInvoice_maxRecords < 1) datasetGetInvoice_maxRecords = 1;
int datasetGetInvoice_startIndex = 0;(localVars.queryResGetInvoice_outParamList,localVars.queryResGetInvoice_outParamCount) = await FuncActionReassign.datasetGetInvoice(requestContext,datasetGetInvoice_maxRecords,datasetGetInvoice_startIndex,IterationMultiplicity.Never,localVars.resListFilterInvList_outParamFilteredList.CurrentRec.ssInvoiceApprovalLevelId,cancellationToken);

// Has status to be updated?
if((!(((localVars.queryResGetInvoice_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(localVars.queryResGetInvoice_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId))))) {
// ListAppendReassignments2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_Reassignments,new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssSourceUserId = localVars.queryResGetInvoice_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo, ssTargetUserId = localVars.varLcl_TargetUserAUUser.ssENUser.ssId, ssInvoiceId = localVars.resListFilterInvList_outParamFilteredList.CurrentRec.ssInvoiceId, ssInvoiceApprovalLevelId = localVars.resListFilterInvList_outParamFilteredList.CurrentRec.ssInvoiceApprovalLevelId, ssReason = localVars.inParami_Reason, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// GetInvoice.List.Current.InvoiceApprovalLevel.AssignedTo = l_TargetUserAUUser.User.Id
localVars.queryResGetInvoice_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo = localVars.varLcl_TargetUserAUUser.ssENUser.ssId;

// GetInvoice.List.Current.InvoiceApprovalLevel.IsReassigned = True
localVars.queryResGetInvoice_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsReassigned = true;

// GetInvoice.List.Current.InvoiceApprovalLevel.IsSubstituteFor = l_TargetUserAUUser.User.Id
localVars.queryResGetInvoice_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsSubstituteFor = localVars.varLcl_TargetUserAUUser.ssENUser.ssId;
// ListAppendInvoiceApprovalLevels
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_InvoiceApprovalLevels,localVars.queryResGetInvoice_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// ListAppendInvoiceLogs
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_InvoiceLogs,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.resListFilterInvList_outParamFilteredList.CurrentRec.ssInvoiceId, ssMessage = ((((AppUtils.GetStringResource("p_Asl7kORkqKFBJhjwkRhA#Value.-682383654.1", "Reassignment:")+" ")+localVars.queryResGetSourceUserById_outParamList.CurrentRec.ssENUser.ssName)+" -> ")+localVars.varLcl_TargetUserAUUser.ssENUser.ssName), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

}

localVars.resListFilterInvList_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterInvList_outParamFilteredList.EndIteration();
}

// CreateOrUpdateSomeReassignments
await ExtendedActions.CreateOrUpdateSomeReassignments(requestContext,(await RL_462b16c1ddedb19ce2dbad5e94ccb4ef.ConvertAsync(localVars.varLcl_Reassignments, new RL_462b16c1ddedb19ce2dbad5e94ccb4ef(), async (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord source, RC_c9394e1c31772209550f46c7f600d6ee target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// CreateOrUpdateSomeRequisitionApprovalLevel
await ExtendedActions.CreateOrUpdateSomeRequisitionApprovalLevel(requestContext,(await RL_d8bc800f4e3c344ab91bf54150e31a34.ConvertAsync(localVars.varLcl_RequisitionApprovalLevels, new RL_d8bc800f4e3c344ab91bf54150e31a34(), async (EN_27b1469f497d364a764a1359956ef9adEntityRecord source, RC_5404698ef74632f0bc59763509d95177 target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// CreateOrUpdateSomeRequisitionLogs
await ExtendedActions.CreateOrUpdateSomeRequisitionLogs(requestContext,(await RL_57c324e581f9aea86c504fb7e70730b1.ConvertAsync(localVars.varLcl_RequisitionLogs, new RL_57c324e581f9aea86c504fb7e70730b1(), async (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord source, RC_da02352775767d2a57ea4cd35cd18496 target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// CreateOrUpdateSomeInvoiceApprovalLevel
await ExtendedActions.CreateOrUpdateSomeInvoiceApprovalLevel(requestContext,(await RL_b2132c93db5fd1f839353b7412eed8f5.ConvertAsync(localVars.varLcl_InvoiceApprovalLevels, new RL_b2132c93db5fd1f839353b7412eed8f5(), async (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord source, RC_a542803a75b19356be8279fb269e55fb target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// CreateOrUpdateSomeInvoiceLog
await ExtendedActions.CreateOrUpdateSomeInvoiceLog(requestContext,(await RL_741430f005c8952521bfb8de73240573.ConvertAsync(localVars.varLcl_InvoiceLogs, new RL_741430f005c8952521bfb8de73240573(), async (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord source, RC_deaf8695933be1bd95c8a487c5df0dc4 target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// o_NotificationContent
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_NotificationContent.Email = l_TargetUserAUUser.User.Email
result.outParamo_NotificationContent.ssEmail = localVars.varLcl_TargetUserAUUser.ssENUser.ssEmail;

// o_NotificationContent.Name = l_TargetUserAUUser.User.Name
result.outParamo_NotificationContent.ssName = localVars.varLcl_TargetUserAUUser.ssENUser.ssName;

// o_NotificationContent.JobTitle = l_TargetUserAUUser.User_Extended_Internal.JobTitle
result.outParamo_NotificationContent.ssJobTitle = localVars.varLcl_TargetUserAUUser.ssENUser_Extended_Internal.ssJobTitle;

// o_NotificationContent.PhoneNumber = "Undefined"
result.outParamo_NotificationContent.ssPhoneNumber = AppUtils.GetStringResource("Haz2w6H9MUuk5sXqzzSFlA#Value.965837104.1", "Undefined");
// Foreach ListFilterReqList.FilteredList
localVars.resListFilterReqList_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterReqList_outParamFilteredList.Eof))) {
// l_ReqInvListReassigned = l_ReqInvListReassigned + ", " + ListFilterReqList.FilteredList.Current.RequisitionName
localVars.varLcl_ReqInvListReassigned=((localVars.varLcl_ReqInvListReassigned+", ")+localVars.resListFilterReqList_outParamFilteredList.CurrentRec.ssRequisitionName);
localVars.resListFilterReqList_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterReqList_outParamFilteredList.EndIteration();
}

// Foreach ListFilterInvList.FilteredList
localVars.resListFilterInvList_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterInvList_outParamFilteredList.Eof))) {
// l_ReqInvListReassigned = l_ReqInvListReassigned + ", " + ListFilterInvList.FilteredList.Current.InvoiceName
localVars.varLcl_ReqInvListReassigned=((localVars.varLcl_ReqInvListReassigned+", ")+localVars.resListFilterInvList_outParamFilteredList.CurrentRec.ssInvoiceName);
localVars.resListFilterInvList_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterInvList_outParamFilteredList.EndIteration();
}

// l_ReqInvListReassigned = Substr
localVars.varLcl_ReqInvListReassigned=BuiltInFunction.SubstrSC (localVars.varLcl_ReqInvListReassigned, 2, BuiltInFunction.LengthSC (localVars.varLcl_ReqInvListReassigned));
// SendReassignmentNotifyTargetUser
await Actions.ActionSendReassignmentNotifyTargetUser(requestContext,localVars.varLcl_TargetUserAUUser,localVars.varLcl_ReqInvListReassigned,localVars.queryResGetSourceUserById_outParamList.CurrentRec.ssENUser.ssName,cancellationToken);

// JSON Serialize JsonSerializeReassignJSONSerialize1
FuncActionReassign.JsonSerializeReassignJSONSerialize1(localVars.varLcl_InvoiceLogs, out localVars.resJSONSerialize1_outParamJSON);
// AuditCreateWrapper
await Actions.ActionAuditCreateWrapper(requestContext,new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrigin = 4, ssIdentifier = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssMessage = "", ssScreen = "Reassignments", ssFunctionality = "Create", ssOriginalJSON = BuiltInFunction.SubstrSC (localVars.resJSONSerialize1_outParamJSON, 0, 99999) },cancellationToken);

// JSON Serialize JsonSerializeReassignJSONSerialize2
FuncActionReassign.JsonSerializeReassignJSONSerialize2(localVars.varLcl_RequisitionLogs, out localVars.resJSONSerialize2_outParamJSON);
// AuditCreateWrapper2
await Actions.ActionAuditCreateWrapper(requestContext,new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrigin = 4, ssIdentifier = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssMessage = "", ssScreen = "Reassignments", ssFunctionality = "Create", ssOriginalJSON = BuiltInFunction.SubstrSC (localVars.resJSONSerialize2_outParamJSON, 0, 99999) },cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_NotificationContent = result.outParamo_NotificationContent;
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_NotificationContent,outParamo_Output);
}

public static class FuncActionReassign {

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserAUByEntraIdReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserAUByEntraId" asuZDAyg8EyllyU3udzqKA of Action "Reassign"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserAUByEntraId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteUser_Extended_Internal_EntraId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Reassign.GetUserAUByEntraId", "0c99cb6a-a00c-4cf0-a597-2537b9dcea28");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Reassign.GetUserAUByEntraId", "0c99cb6a-a00c-4cf0-a597-2537b9dcea28", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3HBWkl6OWEiIc5I6uQXD9g/NodesNotShownInESpaceTree.asuZDAyg8EyllyU3udzqKA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser87\".\"id\" o0, \"enuser87\".\"name\" o1, \"enuser87\".\"email\" o2, \"enuser87\".\"photourl\" o3, \"enuser87\".\"username\" o4, \"enuser_extended_internal54\".\"id\" o5, \"enuser_extended_internal54\".\"employeenumber\" o6, \"enuser_extended_internal54\".\"managedby\" o7, \"enuser_extended_internal54\".\"regionid\" o8, \"enuser_extended_internal54\".\"departmentid\" o9, \"enuser_extended_internal54\".\"managementid\" o10, \"enuser_extended_internal54\".\"subdirectionid\" o11, \"enuser_extended_internal54\".\"telceldirectionid\" o12, \"enuser_extended_internal54\".\"city\" o13, \"enuser_extended_internal54\".\"jobtitle\" o14, \"enuser_extended_internal54\".\"entraroleid\" o15, \"enuser_extended_internal54\".\"onpremisesdistinguishedname\" o16, \"enuser_extended_internal54\".\"hasrolesassigned\" o17, \"enuser_extended_internal54\".\"lastsync\" o18, \"enuser_extended_internal54\".\"createdby\" o19, \"enuser_extended_internal54\".\"createdon\" o20, \"enuser_extended_internal54\".\"updatedby\" o21, \"enuser_extended_internal54\".\"updatedon\" o22, \"enuser_extended_internal54\".\"entraid\" o23, \"enuser_extended_internal54\".\"telceldireccion\" o24");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal54\" Inner JOIN {User} \"enuser87\" ON (\"enuser_extended_internal54\".\"id\" = \"enuser87\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal54\".\"entraid\" = @qpteUser_Extended_Internal_EntraId)");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_EntraId", DbType.String, qpteUser_Extended_Internal_EntraId);
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserAUByEntraIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Reassign.GetUserAUByEntraId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserAUByEntraIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Reassign.GetUserAUByEntraId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_752c66ffcb633a1081093541635464e7)_tmp;
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

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisition" TDnkcjycFkCcfY0B4CEvTQ of Action "Reassign"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisition(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Reassign.GetRequisition", "72e4394c-9c3c-4016-9c7d-8d01e0212f4d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Reassign.GetRequisition", "72e4394c-9c3c-4016-9c7d-8d01e0212f4d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3HBWkl6OWEiIc5I6uQXD9g/NodesNotShownInESpaceTree.TDnkcjycFkCcfY0B4CEvTQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enrequisitionapprovallevel11\".\"id\" o68, \"enrequisitionapprovallevel11\".\"requisitionapprovalid\" o69, \"enrequisitionapprovallevel11\".\"levelnumber\" o70, \"enrequisitionapprovallevel11\".\"applicationroleid\" o71, \"enrequisitionapprovallevel11\".\"entrajobtitle\" o72, \"enrequisitionapprovallevel11\".\"departmentid\" o73, \"enrequisitionapprovallevel11\".\"managementid\" o74, \"enrequisitionapprovallevel11\".\"subdirectionid\" o75, \"enrequisitionapprovallevel11\".\"entraroleid\" o76, \"enrequisitionapprovallevel11\".\"entrausername\" o77, \"enrequisitionapprovallevel11\".\"assignedto\" o78, \"enrequisitionapprovallevel11\".\"needscontract\" o79, \"enrequisitionapprovallevel11\".\"approvalstatusid\" o80, \"enrequisitionapprovallevel11\".\"approvedby\" o81, \"enrequisitionapprovallevel11\".\"approvedon\" o82, \"enrequisitionapprovallevel11\".\"requesttomodifyby\" o83, \"enrequisitionapprovallevel11\".\"requesttomodifyon\" o84, \"enrequisitionapprovallevel11\".\"canceledby\" o85, \"enrequisitionapprovallevel11\".\"canceledon_deprec\" o86, \"enrequisitionapprovallevel11\".\"isaccounting\" o87, \"enrequisitionapprovallevel11\".\"isstartaccounting\" o88, \"enrequisitionapprovallevel11\".\"canceledon_\" o89, \"enrequisitionapprovallevel11\".\"approveasareausuaria\" o90, \"enrequisitionapprovallevel11\".\"ismandatory\" o91, \"enrequisitionapprovallevel11\".\"isreassigned\" o92, \"enrequisitionapprovallevel11\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition37\" Left JOIN {RequisitionApproval} \"enrequisitionapproval13\" ON (\"enrequisition37\".\"id\" = \"enrequisitionapproval13\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel11\" ON (\"enrequisitionapproval13\".\"id\" = \"enrequisitionapprovallevel11\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel11\".\"id\" = @qpreRequisitionApprovalLevel_Id) AND (\"enrequisitionapprovallevel11\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalLevel_Id", DbType.Int64, qpreRequisitionApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel11\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Reassign.GetRequisition.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Reassign.GetRequisition.List", cancellationToken: cancellationToken);
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

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoiceReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoice" Uuk3dTqxZkagSUXBj84fIw of Action "Reassign"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoice(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Reassign.GetInvoice", "7537e952-b13a-4666-a049-45c18fce1f23");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Reassign.GetInvoice", "7537e952-b13a-4666-a049-45c18fce1f23", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3HBWkl6OWEiIc5I6uQXD9g/NodesNotShownInESpaceTree.Uuk3dTqxZkagSUXBj84fIw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceapprovallevel16\".\"id\" o34, \"eninvoiceapprovallevel16\".\"invoiceapprovalid\" o35, \"eninvoiceapprovallevel16\".\"levelnumber\" o36, \"eninvoiceapprovallevel16\".\"assignedto\" o37, \"eninvoiceapprovallevel16\".\"applicationroleid\" o38, \"eninvoiceapprovallevel16\".\"entrajobtitle\" o39, \"eninvoiceapprovallevel16\".\"departmentid\" o40, \"eninvoiceapprovallevel16\".\"managementid\" o41, \"eninvoiceapprovallevel16\".\"subdirectionid\" o42, \"eninvoiceapprovallevel16\".\"entraroleid\" o43, \"eninvoiceapprovallevel16\".\"approvalstatusid\" o44, \"eninvoiceapprovallevel16\".\"canbefirstapprover\" o45, \"eninvoiceapprovallevel16\".\"selectsnextapprover\" o46, \"eninvoiceapprovallevel16\".\"selectsfirstapprover\" o47, \"eninvoiceapprovallevel16\".\"isaccounting\" o48, \"eninvoiceapprovallevel16\".\"isstartaccounting\" o49, \"eninvoiceapprovallevel16\".\"approvedby\" o50, \"eninvoiceapprovallevel16\".\"approvedon\" o51, \"eninvoiceapprovallevel16\".\"requesttomodifyby\" o52, \"eninvoiceapprovallevel16\".\"requesttomodifyon\" o53, \"eninvoiceapprovallevel16\".\"canceledby\" o54, \"eninvoiceapprovallevel16\".\"canceledon\" o55, \"eninvoiceapprovallevel16\".\"needscontract_deprec\" o56, \"eninvoiceapprovallevel16\".\"isreassigned\" o57, \"eninvoiceapprovallevel16\".\"issubstitutefor\" o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice39\" Left JOIN {InvoiceApproval} \"eninvoiceapproval15\" ON (\"eninvoice39\".\"id\" = \"eninvoiceapproval15\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel16\" ON (\"eninvoiceapproval15\".\"id\" = \"eninvoiceapprovallevel16\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApprovalLevel_Id != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel16\".\"id\" = @qpinInvoiceApprovalLevel_Id) AND (\"eninvoiceapprovallevel16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalLevel_Id", DbType.Int64, qpinInvoiceApprovalLevel_Id);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel16\".\"id\" IS NULL)");
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
RL_e8a2bfdbad62aa404e80d55d80faa387 outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Reassign.GetInvoice.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Reassign.GetInvoice.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8a2bfdbad62aa404e80d55d80faa387)_tmp;
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

// Query Function "GetSourceUserById" N8Ew1Cvb0UiZMzMZT_RMZQ of Action "Reassign"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetSourceUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Reassign.GetSourceUserById", "d430c137-db2b-48d1-9933-33194ff44c65");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Reassign.GetSourceUserById", "d430c137-db2b-48d1-9933-33194ff44c65", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3HBWkl6OWEiIc5I6uQXD9g/NodesNotShownInESpaceTree.N8Ew1Cvb0UiZMzMZT_RMZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser88\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser88\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser88\".\"id\" = @qpusId) AND (\"enuser88\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser88\".\"id\" IS NULL)");
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Reassign.GetSourceUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Reassign.GetSourceUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
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



/// <summary>
/// JSONSerialize: JsonSerializeReassignJSONSerialize1 (KJPAMPn78o0WcNlyGNzEzIw)  of Action "Reassign"
/// </summary>
public static void JsonSerializeReassignJSONSerialize1 (RL_3c85b6eb7948435e547c7243037d9ca0 inParamRecordList, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = inParamRecordList.ToArray<ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructureDelegate(config));
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeReassignJSONSerialize2 (KUx7Jfd6cMEyeldpcWN40ww)  of Action "Reassign"
/// </summary>
public static void JsonSerializeReassignJSONSerialize2 (RL_fdafd442807cd919d566b3ebfe8b6822 inParamRecordList, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = inParamRecordList.ToArray<ssConectaProveedores.RestRecords.JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.FromStructureDelegate(config));
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
