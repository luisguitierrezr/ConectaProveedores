namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitReqWF_Special : VarsBag {
public long inParami_RequisitionId;
public long inParami_ApprovalProcessId;
public string inParami_CreateForUser;
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

/// <summary>
/// Variable <code>CurrentLevelNumber</code> that represents the Service Studio Integer
///  <code>CurrentLevelNumber</code> <p>Description: CurrentLevelNumber</p>
/// </summary>
public int varLcCurrentLevelNumber = 0;

/// <summary>
/// Variable <code>l_RequisitionApprovalLevel</code> that represents the Service Studio
///  RequisitionApprovalLevel <code>l_RequisitionApprovalLevel</code> <p>Description
/// : RequisitionApprovalLevel</p>
/// </summary>
public EN_27b1469f497d364a764a1359956ef9adEntityRecord varLcl_RequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();

public int resListIndexOfIsFirstApprover_outParamPosition = 0;

public RL_25486e09ba20acde3d8ef9d3e8a6e625 queryResGetProofOfForeignResidence_outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
public long queryResGetProofOfForeignResidence_outParamCount = 0L;

public RC_5404698ef74632f0bc59763509d95177 resGetRequisitionApprovalLevel_outParamRecord = new RC_5404698ef74632f0bc59763509d95177();

public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplierById_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplierById_outParamCount = 0L;

public int resListIndexOfJobTitle_outParamPosition = 0;

public RL_b9a4d89a3154e989f9ae297e352963c3 queryResGetRequisitionById_outParamList = new RL_b9a4d89a3154e989f9ae297e352963c3();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate3 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoFindNextApproverSpecial resFindNextApproverSpecial =  new Actions.lcoFindNextApproverSpecial();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public RL_b13d2bf72a0c08d2621757797ed1bce6 queryResGetUserEntraRoleId_outParamList = new RL_b13d2bf72a0c08d2621757797ed1bce6();
public long queryResGetUserEntraRoleId_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public RL_d9cdf6b439bedcf27f386d3d21afc6a2 queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList = new RL_d9cdf6b439bedcf27f386d3d21afc6a2();
public long queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount = 0L;

public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public RL_2fd4ee9249069fb78258eb73022e4cb9 queryResGetANALISTA_CXP_outParamList = new RL_2fd4ee9249069fb78258eb73022e4cb9();
public long queryResGetANALISTA_CXP_outParamCount = 0L;

public lcvInitReqWF_Special(long inParami_RequisitionId, long inParami_ApprovalProcessId, string inParami_CreateForUser) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_CreateForUser = inParami_CreateForUser;
}
}
public class lcoInitReqWF_Special : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitReqWF_Special() {
}
}
/// <summary>
/// Action <code>InitReqWF_Special</code> that represents the Service Studio action
///  <code>InitReqWF_Special</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitReqWF_Special(IRequestContext requestContext,long inParami_RequisitionId,long inParami_ApprovalProcessId,string inParami_CreateForUser,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitReqWF_Special result = new lcoInitReqWF_Special();
lcvInitReqWF_Special localVars = new lcvInitReqWF_Special(inParami_RequisitionId, inParami_ApprovalProcessId, inParami_CreateForUser);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitReqWF_Special", "69904e5f-c697-4da7-a600-4ec93851617f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitReqWF_Special", "69904e5f-c697-4da7-a600-4ec93851617f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 0;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInitReqWF_Special.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetApprovalProcessLevelsByApprovalProcessId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords = 0;
int datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex = 0;(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount) = await FuncActionInitReqWF_Special.datasetGetApprovalProcessLevelsByApprovalProcessId(requestContext,datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords,datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex,IterationMultiplicity.Multiple,localVars.inParami_ApprovalProcessId,cancellationToken);

// Query datasetGetUserEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserEntraRoleId_maxRecords = 1;
if (datasetGetUserEntraRoleId_maxRecords < 1) datasetGetUserEntraRoleId_maxRecords = 1;
int datasetGetUserEntraRoleId_startIndex = 0;(localVars.queryResGetUserEntraRoleId_outParamList,localVars.queryResGetUserEntraRoleId_outParamCount) = await FuncActionInitReqWF_Special.datasetGetUserEntraRoleId(requestContext,datasetGetUserEntraRoleId_maxRecords,datasetGetUserEntraRoleId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Not found?
if(((localVars.queryResGetUserEntraRoleId_outParamList.CurrentRec.ssEntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (AppUtils.GetStringResource("AoIAPquY3UG5K_xlwQIsmQ#Message.-555375952.1", "Cannot determine next approver, because your Entra Role was not found!"));

} else {
// ListIndexOfIsFirstApprover
localVars.resListIndexOfIsFirstApprover_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,async (p, cancellationToken) => p.ssENApprovalProcessLevel.ssIsFirstApprover,cancellationToken);

// ListIndexOfJobTitle
localVars.resListIndexOfJobTitle_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,async (p, cancellationToken) => (p.ssENApprovalProcessLevel.ssEntraRoleId==localVars.queryResGetUserEntraRoleId_outParamList.CurrentRec.ssEntraRoleId),cancellationToken);

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
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncActionInitReqWF_Special.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssSupplierId,cancellationToken);

if(((localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX"))) {
// Query datasetGetProofOfForeignResidence
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProofOfForeignResidence_maxRecords = 1;
if (datasetGetProofOfForeignResidence_maxRecords < 1) datasetGetProofOfForeignResidence_maxRecords = 1;
int datasetGetProofOfForeignResidence_startIndex = 0;(localVars.queryResGetProofOfForeignResidence_outParamList,localVars.queryResGetProofOfForeignResidence_outParamCount) = await FuncActionInitReqWF_Special.datasetGetProofOfForeignResidence(requestContext,datasetGetProofOfForeignResidence_maxRecords,datasetGetProofOfForeignResidence_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssId,cancellationToken);

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

if((localVars.varLcl_ApprovalProcessLevels.Empty)) {
// RequisitionApprovalCreateOrUpdate2
localVars.resRequisitionApprovalCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssAprovalProcessId = localVars.inParami_ApprovalProcessId, ssProcessTypeCode = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENProcessType.ssCode, ssApprovalProcessVersion = Convert.ToString(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcess.ssVersion), ssCurrentLevel = 1, ssStartedOn = BuiltInFunction.CurrDateTime (), ssHasStartedAccounting = true },cancellationToken);

// InitReqWF_CxP
await Actions.ActionInitReqWF_CxP(requestContext,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetANALISTA_CXP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetANALISTA_CXP_maxRecords = 1;
if (datasetGetANALISTA_CXP_maxRecords < 1) datasetGetANALISTA_CXP_maxRecords = 1;
int datasetGetANALISTA_CXP_startIndex = 0;(localVars.queryResGetANALISTA_CXP_outParamList,localVars.queryResGetANALISTA_CXP_outParamCount) = await FuncActionInitReqWF_Special.datasetGetANALISTA_CXP(requestContext,datasetGetANALISTA_CXP_maxRecords,datasetGetANALISTA_CXP_startIndex,IterationMultiplicity.Never,cancellationToken);

// l_RequisitionApprovalLevel
// l_RequisitionApprovalLevel.Id = NullIdentifier
localVars.varLcl_RequisitionApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_RequisitionApprovalLevel.RequisitionApprovalId = RequisitionApprovalCreateOrUpdate2.Id
localVars.varLcl_RequisitionApprovalLevel.ssRequisitionApprovalId = localVars.resRequisitionApprovalCreateOrUpdate2.outParamId;

// l_RequisitionApprovalLevel.LevelNumber = 1
localVars.varLcl_RequisitionApprovalLevel.ssLevelNumber = 1;

// l_RequisitionApprovalLevel.ApplicationRoleId = GetANALISTA_CXP.List.Current.ApplicationRole.Id
localVars.varLcl_RequisitionApprovalLevel.ssApplicationRoleId = localVars.queryResGetANALISTA_CXP_outParamList.CurrentRec.ssENApplicationRole.ssId;

// l_RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_RequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_RequisitionApprovalLevel.IsAccounting = True
localVars.varLcl_RequisitionApprovalLevel.ssIsAccounting = true;

// l_RequisitionApprovalLevel.IsStartAccounting = True
localVars.varLcl_RequisitionApprovalLevel.ssIsStartAccounting = true;
// Empty?
if((localVars.queryResGetANALISTA_CXP_outParamList.Empty)) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("JPzreAxtBUChEVuT2SFNPQ#Message.2138269536.1", "ANALISTA_CXP - Analista CxP/Egresos role has not yet been created."));

} else {
// RequisitionApprovalLevelCreateOrUpdate3
localVars.resRequisitionApprovalLevelCreateOrUpdate3.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_RequisitionApprovalLevel,cancellationToken);

}

} else {
// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcl_ApprovalProcessLevels,async (p, cancellationToken) => p.ssLevelNumber,true,cancellationToken);

// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssAprovalProcessId = localVars.inParami_ApprovalProcessId, ssProcessTypeCode = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENProcessType.ssCode, ssApprovalProcessVersion = Convert.ToString(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcess.ssVersion), ssCurrentLevel = localVars.varLcl_ApprovalProcessLevels[0].ssLevelNumber, ssMaxLevel = localVars.varLcl_ApprovalProcessLevels[(localVars.varLcl_ApprovalProcessLevels.Length-1)].ssLevelNumber, ssStartedOn = BuiltInFunction.CurrDateTime (), ssHasStartedAccounting = false },cancellationToken);

// CurrentLevelNumber = l_ApprovalProcessLevels[0].LevelNumber
localVars.varLcCurrentLevelNumber=localVars.varLcl_ApprovalProcessLevels[0].ssLevelNumber;
// Foreach l_ApprovalProcessLevels
localVars.varLcl_ApprovalProcessLevels.StartIteration();
try {while (!((localVars.varLcl_ApprovalProcessLevels.Eof))) {
// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,new EN_27b1469f497d364a764a1359956ef9adEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionApprovalId = localVars.resRequisitionApprovalCreateOrUpdate.outParamId, ssLevelNumber = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssLevelNumber, ssApplicationRoleId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssApplicationRoleId, ssEntraJobTitle = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssJobTitle, ssDepartmentId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssDepartmentId, ssManagementId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssManagementId, ssSubdirectionId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssSubdirectionId, ssEntraRoleId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssEntraRoleId, ssAssignedTo = BuiltInFunction.NullTextIdentifier (), ssNeedsContract = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssNeedsContract, ssApprovalStatusId = (((!localVars.varLcl_HasStarted)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)) },cancellationToken);

if(((!localVars.varLcl_HasStarted))) {
// GetRequisitionApprovalLevel
localVars.resGetRequisitionApprovalLevel_outParamRecord = await ExtendedActions.GetRequisitionApprovalLevel(requestContext,localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId,cancellationToken);

// i_CreateForUser?
if(((localVars.inParami_CreateForUser!=BuiltInFunction.NullTextIdentifier ()))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.inParami_CreateForUser,cancellationToken);

// AssignedTo
// GetRequisitionApprovalLevel.Record.RequisitionApprovalLevel.AssignedTo = If
localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_CreateForUser) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// GetRequisitionApprovalLevel.Record.RequisitionApprovalLevel.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
} else {
// FindNextApproverSpecial
(localVars.resFindNextApproverSpecial.outParamo_Output,localVars.resFindNextApproverSpecial.outParamo_UserId,localVars.resFindNextApproverSpecial.outParamo_IsSubstituteFor) = await Actions.ActionFindNextApproverSpecial(requestContext,localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssEntraRoleId,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRegionId,localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssDepartmentId,localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssManagementId,localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssSubdirectionId,cancellationToken);

// IsSuccess
if((localVars.resFindNextApproverSpecial.outParamo_Output.ssIsSuccess)) {
// AssignedTo
// GetRequisitionApprovalLevel.Record.RequisitionApprovalLevel.AssignedTo = FindNextApproverSpecial.o_UserId
localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssAssignedTo = localVars.resFindNextApproverSpecial.outParamo_UserId;

// GetRequisitionApprovalLevel.Record.RequisitionApprovalLevel.IsSubstituteFor = FindNextApproverSpecial.o_IsSubstituteFor
localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssIsSubstituteFor = localVars.resFindNextApproverSpecial.outParamo_IsSubstituteFor;
} else {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (localVars.resFindNextApproverSpecial.outParamo_Output.ssMessage);

}

}

// RequisitionApprovalLevelCreateOrUpdate2
localVars.resRequisitionApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel,cancellationToken);

}

// l_HasStarted = True
localVars.varLcl_HasStarted=true;
localVars.varLcl_ApprovalProcessLevels.Advance();
}

} finally {
localVars.varLcl_ApprovalProcessLevels.EndIteration();
}

}

// AccountingRegion defined?
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcess.ssAccountingRegionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// GetRequisitionById.List.Current.Requisition.AccountingRegionId = GetApprovalProcessLevelsByApprovalProcessId.List.Current.ApprovalProcess.AccountingRegionId
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssAccountingRegionId = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcess.ssAccountingRegionId;
// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition,cancellationToken);

}

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInitReqWF_Special {

// Query Function "GetProofOfForeignResidence" P4juKxXnsUmKH52HAzdvoA of Action "InitReqWF_Special"
public static async Task<(RL_25486e09ba20acde3d8ef9d3e8a6e625,long)> datasetGetProofOfForeignResidence(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_Special.GetProofOfForeignResidence", "2bee883f-e715-49b1-8a1f-9d8703376fa0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_Special.GetProofOfForeignResidence", "2bee883f-e715-49b1-8a1f-9d8703376fa0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.X06QaZfGp02mAE7JOFFhfw/NodesNotShownInESpaceTree.P4juKxXnsUmKH52HAzdvoA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {RequisitionContractFile} \"enrequisitioncontractfile5\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile5\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncontractfile5\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile5\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile5\".\"contractfiletypeid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_Special.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_Special.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
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

// Query Function "GetSupplierById" BWKNS3RTfEyqbd+hX0JMfw of Action "InitReqWF_Special"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_Special.GetSupplierById", "4b8d6205-5374-4c7c-aa6d-dfa15f424c7f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_Special.GetSupplierById", "4b8d6205-5374-4c7c-aa6d-dfa15f424c7f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.X06QaZfGp02mAE7JOFFhfw/NodesNotShownInESpaceTree.BWKNS3RTfEyqbd+hX0JMfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"ensupplier19\".\"pais\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier19\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier19\".\"id\" = @qpsuId) AND (\"ensupplier19\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier19\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_Special.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_Special.GetSupplierById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_4b3e229d9fe6ec886da8c5cf0d4be972> datasetGetRequisitionByIdReadDbAsync(RC_4b3e229d9fe6ec886da8c5cf0d4be972 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" 9j7hZTxeEUuDz3_HVlKWNg of Action "InitReqWF_Special"
public static async Task<(RL_b9a4d89a3154e989f9ae297e352963c3,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_Special.GetRequisitionById", "65e13ef6-5e3c-4b11-83cf-7fc756529636");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_Special.GetRequisitionById", "65e13ef6-5e3c-4b11-83cf-7fc756529636", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.X06QaZfGp02mAE7JOFFhfw/NodesNotShownInESpaceTree.9j7hZTxeEUuDz3_HVlKWNg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enregion27\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enrequisition31\".\"id\" o13, \"enrequisition31\".\"name\" o14, \"enrequisition31\".\"counter\" o15, \"enrequisition31\".\"requisitionstatusid\" o16, \"enrequisition31\".\"supplierid\" o17, \"enrequisition31\".\"regionid\" o18, \"enrequisition31\".\"accountingregionid\" o19, \"enrequisition31\".\"applicantid\" o20, \"enrequisition31\".\"maxdatefinishcapture\" o21, \"enrequisition31\".\"projectassetserviceid\" o22, \"enrequisition31\".\"projectassetservice\" o23, \"enrequisition31\".\"projectdescription\" o24, \"enrequisition31\".\"frequencyid\" o25, \"enrequisition31\".\"issustainability\" o26, \"enrequisition31\".\"sustainabilityid\" o27, \"enrequisition31\".\"businessvaluecategoryid\" o28, \"enrequisition31\".\"businessvaluesubcategoryid\" o29, trim_scale(\"enrequisition31\".\"totalamount\"::numeric) o30, \"enrequisition31\".\"currencyid\" o31, \"enrequisition31\".\"distributionid\" o32, \"enrequisition31\".\"costcenterid\" o33, \"enrequisition31\".\"hascontract\" o34, \"enrequisition31\".\"iscontractpending\" o35, \"enrequisition31\".\"hasdeposit\" o36, \"enrequisition31\".\"hasinsurance\" o37, \"enrequisition31\".\"hasadvancepayment\" o38, \"enrequisition31\".\"accountingservicetypeid_depr\" o39, \"enrequisition31\".\"servicedescription_deprec\" o40, \"enrequisition31\".\"invoiceusageid_deprec\" o41, \"enrequisition31\".\"serviceformatid\" o42, \"enrequisition31\".\"companyid\" o43, trim_scale(\"enrequisition31\".\"retentionrate\"::numeric) o44, trim_scale(\"enrequisition31\".\"negotiatedexchangerate\"::numeric) o45, \"enrequisition31\".\"paymentmethodid\" o46, \"enrequisition31\".\"paymenttermsid\" o47, \"enrequisition31\".\"isautomaticaccounting\" o48, \"enrequisition31\".\"createdby\" o49, \"enrequisition31\".\"createdon\" o50, \"enrequisition31\".\"updatedon\" o51, \"enrequisition31\".\"updatedby\" o52, \"enrequisition31\".\"createdbyapplicationrole\" o53, \"enrequisition31\".\"dateofcommitment\" o54, \"enrequisition31\".\"hascontractfileuploaded\" o55, \"enrequisition31\".\"hasupdateddateofcommitment\" o56, \"enrequisition31\".\"submittedon\" o57, \"enrequisition31\".\"isdonation\" o58, \"enrequisition31\".\"advwithoutinvoice\" o59, \"enrequisition31\".\"wasadvwithoutinvoice\" o60, \"enrequisition31\".\"isadvanced\" o61, \"enrequisition31\".\"documenttypeid\" o62, \"enrequisition31\".\"iscreatedbyanassistente\" o63, \"enrequisition31\".\"telceldirectionid\" o64, \"enrequisition31\".\"hasmultiupload\" o65, \"enrequisition31\".\"accountingdate\" o66, \"enrequisition31\".\"paymentoptionsid\" o67, \"enrequisition31\".\"paymentwaysid\" o68, \"enrequisition31\".\"buydocnumber\" o69, \"enrequisition31\".\"buydocposition\" o70");
fromBuilder.Append(" FROM ({Requisition} \"enrequisition31\" Left JOIN {Region} \"enregion27\" ON (\"enrequisition31\".\"regionid\" = \"enregion27\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition31\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition31\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition31\".\"id\" IS NULL)");
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
RL_b9a4d89a3154e989f9ae297e352963c3 outParamList = new RL_b9a4d89a3154e989f9ae297e352963c3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_Special.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b9a4d89a3154e989f9ae297e352963c3 _tmp = new RL_b9a4d89a3154e989f9ae297e352963c3();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_Special.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b9a4d89a3154e989f9ae297e352963c3)_tmp;
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

// Query Function "GetUserEntraRoleId" SNeB2lkJgkC8D3qhmTa0hQ of Action "InitReqWF_Special"
public static async Task<(RL_b13d2bf72a0c08d2621757797ed1bce6,long)> datasetGetUserEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_Special.GetUserEntraRoleId", "da81d748-0959-4082-bc0f-7aa19936b485");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_Special.GetUserEntraRoleId", "da81d748-0959-4082-bc0f-7aa19936b485", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.X06QaZfGp02mAE7JOFFhfw/NodesNotShownInESpaceTree.SNeB2lkJgkC8D3qhmTa0hQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser_extended_internal41\".\"entraroleid\" \"entraroleid\"");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal41\" Inner JOIN {User} \"enuser70\" ON (\"enuser_extended_internal41\".\"id\" = \"enuser70\".\"id\"))  Left JOIN {EntraRole} \"enentrarole16\" ON (\"enuser_extended_internal41\".\"entraroleid\" = \"enentrarole16\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser70\".\"id\" = @qpusUser_Id) AND (\"enuser70\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser70\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enuser_extended_internal41\".\"entraroleid\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_Special.GetUserEntraRoleId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_Special.GetUserEntraRoleId.List", cancellationToken: cancellationToken);
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
// Query Function "GetApprovalProcessLevelsByApprovalProcessId" +0qF5LHhj0CA6T6BwzlMZA of Action "InitReqWF_Special"
public static async Task<(RL_d9cdf6b439bedcf27f386d3d21afc6a2,long)> datasetGetApprovalProcessLevelsByApprovalProcessId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_Special.GetApprovalProcessLevelsByApprovalProcessId", "e4854afb-e1b1-408f-80e9-3e81c3394c64");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_Special.GetApprovalProcessLevelsByApprovalProcessId", "e4854afb-e1b1-408f-80e9-3e81c3394c64", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.X06QaZfGp02mAE7JOFFhfw/NodesNotShownInESpaceTree.+0qF5LHhj0CA6T6BwzlMZA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enapprovalprocess7\".\"accountingregionid\" o5, NULL o6, NULL o7, \"enapprovalprocess7\".\"version\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enapprovalprocesslevel2\".\"levelnumber\" o21, \"enapprovalprocesslevel2\".\"applicationroleid\" o22, NULL o23, \"enapprovalprocesslevel2\".\"isfirstapprover\" o24, \"enapprovalprocesslevel2\".\"jobtitle\" o25, \"enapprovalprocesslevel2\".\"entraroleid\" o26, \"enapprovalprocesslevel2\".\"departmentid\" o27, \"enapprovalprocesslevel2\".\"managementid\" o28, \"enapprovalprocesslevel2\".\"subdirectionid\" o29, trim_scale(\"enapprovalprocesslevel2\".\"minamount\"::numeric) o30, trim_scale(\"enapprovalprocesslevel2\".\"maxamount\"::numeric) o31, NULL o32, NULL o33, \"enapprovalprocesslevel2\".\"onlyregion\" o34, \"enapprovalprocesslevel2\".\"withoutcontract\" o35, \"enapprovalprocesslevel2\".\"needsproofofforeignresidence\" o36, \"enapprovalprocesslevel2\".\"needscontract\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"enprocesstype2\".\"code\" o46, NULL o47, NULL o48, NULL o49");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess7\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel2\" ON (\"enapprovalprocess7\".\"id\" = \"enapprovalprocesslevel2\".\"approvalprocessid\"))  Left JOIN {ProcessType} \"enprocesstype2\" ON (\"enapprovalprocess7\".\"processtypeid\" = \"enprocesstype2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess7\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess7\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess7\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel2\".\"applicationroleid\" IS NULL)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel2\".\"levelnumber\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, true, false, false, true, false, false, false, false, false, false, false, false, true, true, false, false, false, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_Special.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_Special.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
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

// Query Function "GetANALISTA_CXP" F9qh+hcvhUufTnAdIYBLOA of Action "InitReqWF_Special"
public static async Task<(RL_2fd4ee9249069fb78258eb73022e4cb9,long)> datasetGetANALISTA_CXP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_Special.GetANALISTA_CXP", "faa1da17-2f17-4b85-9f4e-701d21804b38");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_Special.GetANALISTA_CXP", "faa1da17-2f17-4b85-9f4e-701d21804b38", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.X06QaZfGp02mAE7JOFFhfw/NodesNotShownInESpaceTree.F9qh+hcvhUufTnAdIYBLOA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole10\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {ApplicationRole} \"enapplicationrole10\"");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper(\"enapplicationrole10\".\"code\")) collate \"default\") like caseaccent_normalize('ANALISTA_CXP' collate \"default\"))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_Special.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_Special.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
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



}


}
