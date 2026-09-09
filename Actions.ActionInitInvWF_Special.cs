namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitInvWF_Special : VarsBag {
public long inParami_InvoiceId;
public long inParami_ApprovalProcessId;
/// <summary>
/// Variable <code>l_HasStarted</code> that represents the Service Studio Boolean
///  <code>l_HasStarted</code> <p>Description: HasStarted</p>
/// </summary>
public bool varLcl_HasStarted = false;

/// <summary>
/// Variable <code>l_ApprovalProcessLevels</code> that represents the Service Studio
///  ApprovalProcessLevelList <code>l_ApprovalProcessLevels</code> <p>Description: ApprovalProcessLeve
/// l List</p>
/// </summary>
public RL_be2041fc5a275dcf5504e8e79ebd2184 varLcl_ApprovalProcessLevels = new RL_be2041fc5a275dcf5504e8e79ebd2184();

public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplierById_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplierById_outParamCount = 0L;

public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_c851528f2bd72df8d6fa01fc1d7dda59 queryResGetRequisitionById_outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public int resListIndexOfIsFirstApprover_outParamPosition = 0;

public RL_25486e09ba20acde3d8ef9d3e8a6e625 queryResGetProofOfForeignResidence_outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
public long queryResGetProofOfForeignResidence_outParamCount = 0L;

public int resListIndexOfJobTitle_outParamPosition = 0;

public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public RL_b13d2bf72a0c08d2621757797ed1bce6 queryResGetUserEntraRoleId_outParamList = new RL_b13d2bf72a0c08d2621757797ed1bce6();
public long queryResGetUserEntraRoleId_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate2 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate2 =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public RL_d9cdf6b439bedcf27f386d3d21afc6a2 queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList = new RL_d9cdf6b439bedcf27f386d3d21afc6a2();
public long queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount = 0L;

public Actions.lcoInvoiceLogAdd resInvoiceLogAdd2 =  new Actions.lcoInvoiceLogAdd();
public RC_a542803a75b19356be8279fb269e55fb resGetInvoiceApprovalLevel_outParamRecord = new RC_a542803a75b19356be8279fb269e55fb();

public lcvInitInvWF_Special(long inParami_InvoiceId, long inParami_ApprovalProcessId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
}
}
public class lcoInitInvWF_Special : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitInvWF_Special() {
}
}
/// <summary>
/// Action <code>InitInvWF_Special</code> that represents the Service Studio action
///  <code>InitInvWF_Special</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitInvWF_Special(IRequestContext requestContext,long inParami_InvoiceId,long inParami_ApprovalProcessId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitInvWF_Special result = new lcoInitInvWF_Special();
lcvInitInvWF_Special localVars = new lcvInitInvWF_Special(inParami_InvoiceId, inParami_ApprovalProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitInvWF_Special", "f41ec7de-01f9-485a-aa7a-2be73d57d2cb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitInvWF_Special", "f41ec7de-01f9-485a-aa7a-2be73d57d2cb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 0;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInitInvWF_Special.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Query datasetGetApprovalProcessLevelsByApprovalProcessId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords = 0;
int datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex = 0;(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount) = await FuncActionInitInvWF_Special.datasetGetApprovalProcessLevelsByApprovalProcessId(requestContext,datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords,datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex,IterationMultiplicity.Multiple,localVars.inParami_ApprovalProcessId,cancellationToken);

// Query datasetGetUserEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserEntraRoleId_maxRecords = 1;
if (datasetGetUserEntraRoleId_maxRecords < 1) datasetGetUserEntraRoleId_maxRecords = 1;
int datasetGetUserEntraRoleId_startIndex = 0;(localVars.queryResGetUserEntraRoleId_outParamList,localVars.queryResGetUserEntraRoleId_outParamCount) = await FuncActionInitInvWF_Special.datasetGetUserEntraRoleId(requestContext,datasetGetUserEntraRoleId_maxRecords,datasetGetUserEntraRoleId_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssApplicantId,cancellationToken);

// Not found?
if(((localVars.queryResGetUserEntraRoleId_outParamList.CurrentRec.ssEntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("H5DQUDQL2EqIBbloUoKVfA#Message.-1285359476.1", "Cannot determine next approver, because the requisition's applicant Entra Role was not found!"));

} else {
// ListIndexOfIsFirstApprover
localVars.resListIndexOfIsFirstApprover_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,async (p, cancellationToken) => p.ssENApprovalProcessLevel.ssIsFirstApprover,cancellationToken);

// ListIndexOfJobTitle
localVars.resListIndexOfJobTitle_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,async (p, cancellationToken) => (p.ssENApprovalProcessLevel.ssEntraRoleId==localVars.queryResGetUserEntraRoleId_outParamList.CurrentRec.ssEntraRoleId),cancellationToken);

// ListAppendApplicant
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_ApprovalProcessLevels,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList[localVars.resListIndexOfJobTitle_outParamPosition].ssENApprovalProcessLevel,cancellationToken);

// Foreach GetApprovalProcessLevelsByApprovalProcessId.List
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.StartIteration();
try {localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Advance(((((localVars.resListIndexOfIsFirstApprover_outParamPosition!=(-1))&&(localVars.resListIndexOfIsFirstApprover_outParamPosition!=localVars.resListIndexOfJobTitle_outParamPosition))) ? (localVars.resListIndexOfIsFirstApprover_outParamPosition) : ((localVars.resListIndexOfJobTitle_outParamPosition+1))));
while (!((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Eof))) {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion!=""))) {
if((!((BuiltInFunction.IndexSC (localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion, localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRegion.ssCommissionRegion, 0, false, true)!=(-1))))) {
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Advance();
continue;
}

}

if(((((((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))||(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))||localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract)||localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)||localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract))) {
bool block3 = false;
do {
block3 = false;
bool block2 = false;
do {
block2 = false;
do {
if((((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0)))))) {
if((((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssTotalAmount>localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount)&&(localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssTotalAmount<localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount)))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount==(((decimal)0))))) {
if(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssTotalAmount>localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount==(((decimal)0)))&&(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))) {
if(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssTotalAmount<localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount))) {
break;
}

} else {
// ALIGN
}

}

}

if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract&&((!localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssHasContract)||(localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssHasContract&&localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssIsContractPending))))) {
// jump to block2
block2 = true;
break;
} else {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract&&((!localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssHasContract)||(localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssHasContract&&localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssIsContractPending))))) {
// jump to block2
block2 = true;
break;
} else {
if((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)) {
// Query datasetGetSupplierById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierById_maxRecords = 1;
if (datasetGetSupplierById_maxRecords < 1) datasetGetSupplierById_maxRecords = 1;
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncActionInitInvWF_Special.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssSupplierId,cancellationToken);

if(((localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX"))) {
// Query datasetGetProofOfForeignResidence
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProofOfForeignResidence_maxRecords = 1;
if (datasetGetProofOfForeignResidence_maxRecords < 1) datasetGetProofOfForeignResidence_maxRecords = 1;
int datasetGetProofOfForeignResidence_startIndex = 0;(localVars.queryResGetProofOfForeignResidence_outParamList,localVars.queryResGetProofOfForeignResidence_outParamCount) = await FuncActionInitInvWF_Special.datasetGetProofOfForeignResidence(requestContext,datasetGetProofOfForeignResidence_maxRecords,datasetGetProofOfForeignResidence_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssId,cancellationToken);

if((localVars.queryResGetProofOfForeignResidence_outParamList.Empty)) {
// jump to block2
block2 = true;
break;
}

}

}

// ALIGN
// jump to block3
block3 = true;
break;
}

}

} while(false)
;
if((block2 || block3)) {
break;
}

// ALIGN
// ALIGN
} while(false)
;
if(block3) {
break;
}

// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_ApprovalProcessLevels,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel,cancellationToken);

} while(false)
;
// ALIGN
// ALIGN
} else {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_ApprovalProcessLevels,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel,cancellationToken);

}

localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.EndIteration();
}

// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcl_ApprovalProcessLevels,async (p, cancellationToken) => p.ssLevelNumber,true,cancellationToken);

// InvoiceApprovalCreateOrUpdate
localVars.resInvoiceApprovalCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssAprovalProcessId = localVars.inParami_ApprovalProcessId, ssProcessTypeCode = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENProcessType.ssCode, ssApprovalProcessVersion = Convert.ToString(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcess.ssVersion), ssCurrentLevel = localVars.varLcl_ApprovalProcessLevels[0].ssLevelNumber, ssMaxLevel = localVars.varLcl_ApprovalProcessLevels[(localVars.varLcl_ApprovalProcessLevels.Length-1)].ssLevelNumber, ssStartedOn = BuiltInFunction.CurrDateTime (), ssHasStartedAccounting = false },cancellationToken);

// Foreach l_ApprovalProcessLevels
localVars.varLcl_ApprovalProcessLevels.StartIteration();
try {while (!((localVars.varLcl_ApprovalProcessLevels.Eof))) {
// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceApprovalId = localVars.resInvoiceApprovalCreateOrUpdate.outParamId, ssLevelNumber = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssLevelNumber, ssAssignedTo = BuiltInFunction.NullTextIdentifier (), ssApplicationRoleId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssApplicationRoleId, ssEntraJobTitle = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssJobTitle, ssDepartmentId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssDepartmentId, ssManagementId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssManagementId, ssSubdirectionId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssSubdirectionId, ssEntraRoleId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssEntraRoleId, ssApprovalStatusId = (((!localVars.varLcl_HasStarted)) ? ((((localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssSelectsFirstApprover||localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssSelectsNextApprover)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)), ssSelectsNextApprover = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssSelectsNextApprover, ssSelectsFirstApprover = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssSelectsFirstApprover },cancellationToken);

if((!(localVars.varLcl_HasStarted))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssApplicantId,cancellationToken);

// GetInvoiceApprovalLevel
localVars.resGetInvoiceApprovalLevel_outParamRecord = await ExtendedActions.GetInvoiceApprovalLevel(requestContext,localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId,cancellationToken);

// GetInvoiceApprovalLevel.Record.InvoiceApprovalLevel.AssignedTo = If
localVars.resGetInvoiceApprovalLevel_outParamRecord.ssENInvoiceApprovalLevel.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId) : (localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssApplicantId));
// InvoiceApprovalLevelCreateOrUpdate2
localVars.resInvoiceApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.resGetInvoiceApprovalLevel_outParamRecord.ssENInvoiceApprovalLevel,cancellationToken);

}

// l_HasStarted = True
localVars.varLcl_HasStarted=true;
localVars.varLcl_ApprovalProcessLevels.Advance();
}

} finally {
localVars.varLcl_ApprovalProcessLevels.EndIteration();
}

// GetRequisitionById.List.Current.Invoice.InvoiceStatusId = InApproval_UserArea
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId;

// GetRequisitionById.List.Current.Invoice.SubmittedOn = CurrDate
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENInvoice.ssSubmittedOn = BuiltInFunction.CurrDate ();
// InvoiceCreateOrUpdate2
localVars.resInvoiceCreateOrUpdate2.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceLogAdd2
localVars.resInvoiceLogAdd2.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = ((((AppUtils.GetStringResource("gcJBGdyqMEW+3oZjh3ujJQ#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("gcJBGdyqMEW+3oZjh3ujJQ#Value.476391.1", "initiated approval process.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate2
localVars.resInvoiceStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// Result
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// InvEmailFirstApprov_ToApprove
await Actions.ActionInvEmailFirstApprov_ToApprove(requestContext,localVars.inParami_InvoiceId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInitInvWF_Special {

// Query Function "GetSupplierById" 5sxlA91BG0m9hq8VQwgV5Q of Action "InitInvWF_Special"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF_Special.GetSupplierById", "0365cce6-41dd-491b-bd86-af15430815e5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF_Special.GetSupplierById", "0365cce6-41dd-491b-bd86-af15430815e5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3sce9PkBWkiqeivnPVfSyw/NodesNotShownInESpaceTree.5sxlA91BG0m9hq8VQwgV5Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"ensupplier48\".\"pais\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier48\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier48\".\"id\" = @qpsuId) AND (\"ensupplier48\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier48\".\"id\" IS NULL)");
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF_Special.GetSupplierById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF_Special.GetSupplierById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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

private static async Task<RC_3336d2630e2646e00d0c2f5c3e5a01ea> datasetGetRequisitionByIdReadDbAsync(RC_3336d2630e2646e00d0c2f5c3e5a01ea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" nr3gCtUzj0qXlc+DoaODvQ of Action "InitInvWF_Special"
public static async Task<(RL_c851528f2bd72df8d6fa01fc1d7dda59,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF_Special.GetRequisitionById", "0ae0bd9e-33d5-4a8f-9795-cf83a1a383bd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF_Special.GetRequisitionById", "0ae0bd9e-33d5-4a8f-9795-cf83a1a383bd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3sce9PkBWkiqeivnPVfSyw/NodesNotShownInESpaceTree.nr3gCtUzj0qXlc+DoaODvQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice74\".\"id\" o0, \"eninvoice74\".\"name\" o1, \"eninvoice74\".\"requisitionid\" o2, \"eninvoice74\".\"folioid\" o3, \"eninvoice74\".\"ordermainid\" o4, \"eninvoice74\".\"cfditypeid\" o5, trim_scale(\"eninvoice74\".\"totalamount\"::numeric) o6, \"eninvoice74\".\"currency\" o7, \"eninvoice74\".\"invoicestatusid\" o8, \"eninvoice74\".\"accountingdatetime\" o9, \"eninvoice74\".\"paymentdatetime\" o10, \"eninvoice74\".\"createdon\" o11, \"eninvoice74\".\"createdby\" o12, \"eninvoice74\".\"updatedon\" o13, \"eninvoice74\".\"updatedby\" o14, \"eninvoice74\".\"submittedon\" o15, \"eninvoice74\".\"isnewversion\" o16, \"eninvoice74\".\"id_poliza\" o17, \"eninvoice74\".\"id_poliza_sap\" o18, \"eninvoice74\".\"doc51\" o19, \"eninvoice74\".\"accountingerror\" o20, \"eninvoice74\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice74\".\"amortization\"::numeric) o22, \"eninvoice74\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enregion61\".\"commissionregion\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enrequisition71\".\"id\" o37, NULL o38, NULL o39, NULL o40, \"enrequisition71\".\"supplierid\" o41, NULL o42, NULL o43, \"enrequisition71\".\"applicantid\" o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, trim_scale(\"enrequisition71\".\"totalamount\"::numeric) o54, NULL o55, NULL o56, NULL o57, \"enrequisition71\".\"hascontract\" o58, \"enrequisition71\".\"iscontractpending\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice74\" Left JOIN {Requisition} \"enrequisition71\" ON (\"eninvoice74\".\"requisitionid\" = \"enrequisition71\".\"id\"))  Left JOIN {Region} \"enregion61\" ON (\"enrequisition71\".\"regionid\" = \"enregion61\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice74\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice74\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice74\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, true, true, true, false, true, true, false, true, true, true, true, true, true, true, true, true, false, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF_Special.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c851528f2bd72df8d6fa01fc1d7dda59 _tmp = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF_Special.GetRequisitionById.List", cancellationToken: cancellationToken);
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

// Query Function "GetProofOfForeignResidence" 1pAAUyk+LU+HBeqYlnwPMg of Action "InitInvWF_Special"
public static async Task<(RL_25486e09ba20acde3d8ef9d3e8a6e625,long)> datasetGetProofOfForeignResidence(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF_Special.GetProofOfForeignResidence", "530090d6-3e29-4f2d-8705-ea98967c0f32");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF_Special.GetProofOfForeignResidence", "530090d6-3e29-4f2d-8705-ea98967c0f32", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3sce9PkBWkiqeivnPVfSyw/NodesNotShownInESpaceTree.1pAAUyk+LU+HBeqYlnwPMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {RequisitionContractFile} \"enrequisitioncontractfile12\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile12\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncontractfile12\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile12\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile12\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("DmZNPQ718EWxmSQhfgzeiw"))).ssId);
whereBuilder.Append(")");
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
RL_25486e09ba20acde3d8ef9d3e8a6e625 outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF_Special.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_25486e09ba20acde3d8ef9d3e8a6e625 _tmp = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF_Special.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_25486e09ba20acde3d8ef9d3e8a6e625)_tmp;
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

// Query Function "GetUserEntraRoleId" CwfNeEtrFE2leGtjPPyBrg of Action "InitInvWF_Special"
public static async Task<(RL_b13d2bf72a0c08d2621757797ed1bce6,long)> datasetGetUserEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF_Special.GetUserEntraRoleId", "78cd070b-6b4b-4d14-a578-6b633cfc81ae");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF_Special.GetUserEntraRoleId", "78cd070b-6b4b-4d14-a578-6b633cfc81ae", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.3sce9PkBWkiqeivnPVfSyw/NodesNotShownInESpaceTree.CwfNeEtrFE2leGtjPPyBrg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser_extended_internal82\".\"entraroleid\" \"entraroleid\"");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal82\" Inner JOIN {User} \"enuser137\" ON (\"enuser_extended_internal82\".\"id\" = \"enuser137\".\"id\"))  Left JOIN {EntraRole} \"enentrarole39\" ON (\"enuser_extended_internal82\".\"entraroleid\" = \"enentrarole39\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser137\".\"id\" = @qpusUser_Id) AND (\"enuser137\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser137\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enuser_extended_internal82\".\"entraroleid\"");
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
RL_b13d2bf72a0c08d2621757797ed1bce6 outParamList = new RL_b13d2bf72a0c08d2621757797ed1bce6();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF_Special.GetUserEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b13d2bf72a0c08d2621757797ed1bce6 _tmp = new RL_b13d2bf72a0c08d2621757797ed1bce6();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF_Special.GetUserEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b13d2bf72a0c08d2621757797ed1bce6)_tmp;
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

private static async Task<RC_e8e14675b36a42a5af653378f08cb179> datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync(RC_e8e14675b36a42a5af653378f08cb179 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessLevelsByApprovalProcessId" gPznlLHHvUOU9OkjNlSy1A of Action "InitInvWF_Special"
public static async Task<(RL_d9cdf6b439bedcf27f386d3d21afc6a2,long)> datasetGetApprovalProcessLevelsByApprovalProcessId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitInvWF_Special.GetApprovalProcessLevelsByApprovalProcessId", "94e7fc80-c7b1-43bd-94f4-e9233654b2d4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitInvWF_Special.GetApprovalProcessLevelsByApprovalProcessId", "94e7fc80-c7b1-43bd-94f4-e9233654b2d4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.3sce9PkBWkiqeivnPVfSyw/NodesNotShownInESpaceTree.gPznlLHHvUOU9OkjNlSy1A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess37\".\"version\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enapprovalprocesslevel15\".\"levelnumber\" o21, \"enapprovalprocesslevel15\".\"applicationroleid\" o22, NULL o23, \"enapprovalprocesslevel15\".\"isfirstapprover\" o24, \"enapprovalprocesslevel15\".\"jobtitle\" o25, \"enapprovalprocesslevel15\".\"entraroleid\" o26, \"enapprovalprocesslevel15\".\"departmentid\" o27, \"enapprovalprocesslevel15\".\"managementid\" o28, \"enapprovalprocesslevel15\".\"subdirectionid\" o29, trim_scale(\"enapprovalprocesslevel15\".\"minamount\"::numeric) o30, trim_scale(\"enapprovalprocesslevel15\".\"maxamount\"::numeric) o31, NULL o32, NULL o33, \"enapprovalprocesslevel15\".\"onlyregion\" o34, \"enapprovalprocesslevel15\".\"withoutcontract\" o35, \"enapprovalprocesslevel15\".\"needsproofofforeignresidence\" o36, \"enapprovalprocesslevel15\".\"needscontract\" o37, NULL o38, NULL o39, NULL o40, \"enapprovalprocesslevel15\".\"selectsnextapprover\" o41, \"enapprovalprocesslevel15\".\"selectsfirstapprover\" o42, NULL o43, NULL o44, NULL o45, \"enprocesstype12\".\"code\" o46, NULL o47, NULL o48, NULL o49");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess37\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel15\" ON (\"enapprovalprocess37\".\"id\" = \"enapprovalprocesslevel15\".\"approvalprocessid\"))  Left JOIN {ProcessType} \"enprocesstype12\" ON (\"enapprovalprocess37\".\"processtypeid\" = \"enprocesstype12\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess37\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess37\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess37\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel15\".\"applicationroleid\" IS NULL)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel15\".\"levelnumber\" ASC ");
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
RL_d9cdf6b439bedcf27f386d3d21afc6a2 outParamList = new RL_d9cdf6b439bedcf27f386d3d21afc6a2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, false, false, false, false, false, false, false, false, true, true, false, false, false, false, true, true, true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitInvWF_Special.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d9cdf6b439bedcf27f386d3d21afc6a2 _tmp = new RL_d9cdf6b439bedcf27f386d3d21afc6a2();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitInvWF_Special.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d9cdf6b439bedcf27f386d3d21afc6a2)_tmp;
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
