namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetReqApprovalProcessLevels : VarsBag {
public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord inParami_ApprovalProcess;
public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition;
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
/// Variable <code>l_HasStartedAccounting</code> that represents the Service Studio Boolean
///  <code>l_HasStartedAccounting</code> <p>Description: HasStartedAccounting</p>
/// </summary>
public bool varLcl_HasStartedAccounting = false;

public RL_25486e09ba20acde3d8ef9d3e8a6e625 queryResGetProofOfForeignResidence_outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
public long queryResGetProofOfForeignResidence_outParamCount = 0L;

public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public RC_5404698ef74632f0bc59763509d95177 resGetRequisitionApprovalLevel_outParamRecord = new RC_5404698ef74632f0bc59763509d95177();

public int resListIndexOf_outParamPosition = 0;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount = 0L;

public Actions.lcoGetReqNextApprover resGetReqNextApprover =  new Actions.lcoGetReqNextApprover();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoGetUserRole resGetUserRole =  new Actions.lcoGetUserRole();
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionById_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionById_outParamCount = 0L;

public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplierById_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplierById_outParamCount = 0L;

public lcvGetReqApprovalProcessLevels(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord inParami_ApprovalProcess, EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition) {
this.inParami_ApprovalProcess = inParami_ApprovalProcess;
this.inParami_Requisition = inParami_Requisition;
}
}
public class lcoGetReqApprovalProcessLevels : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoGetReqApprovalProcessLevels() {
}
}
/// <summary>
/// Action <code>GetReqApprovalProcessLevels</code> that represents the Service Studio action
///  <code>GetReqApprovalProcessLevels</code> <p> Description: Action to get list of approval proces
/// s levels</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionGetReqApprovalProcessLevels(IRequestContext requestContext,EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord inParami_ApprovalProcess,EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoGetReqApprovalProcessLevels result = new lcoGetReqApprovalProcessLevels();
lcvGetReqApprovalProcessLevels localVars = new lcvGetReqApprovalProcessLevels(inParami_ApprovalProcess, inParami_Requisition);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetReqApprovalProcessLevels", "badf897a-9930-4014-920e-c0d88e0c25b5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetReqApprovalProcessLevels", "badf897a-9930-4014-920e-c0d88e0c25b5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetApprovalProcessLevelsByApprovalProcessId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords = 0;
int datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex = 0;(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount) = await FuncActionGetReqApprovalProcessLevels.datasetGetApprovalProcessLevelsByApprovalProcessId(requestContext,datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords,datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex,IterationMultiplicity.Multiple,localVars.inParami_ApprovalProcess.ssId,cancellationToken);

// Query datasetGetRegionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionById_maxRecords = 1;
if (datasetGetRegionById_maxRecords < 1) datasetGetRegionById_maxRecords = 1;
int datasetGetRegionById_startIndex = 0;(localVars.queryResGetRegionById_outParamList,localVars.queryResGetRegionById_outParamCount) = await FuncActionGetReqApprovalProcessLevels.datasetGetRegionById(requestContext,datasetGetRegionById_maxRecords,datasetGetRegionById_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssRegionId,cancellationToken);

// GetUserRole
localVars.resGetUserRole.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.inParami_Requisition.ssApplicantId,3,true,false,cancellationToken);

if(((localVars.resGetUserRole.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Can't determine approval workflow, because the user does not have a role."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("p_SpWR4N50K3w8Rfi06mTg#Value.325519913.1", "Can't determine approval workflow, because the user does not have a role.");
} else {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,async (p, cancellationToken) => (p.ssENApprovalProcessLevel.ssApplicationRoleId==localVars.resGetUserRole.outParamo_ApplicationRoleId),cancellationToken);

if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Can't determine approval workflow, because the user's role is not present in the workflow."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("zx5bBjFAXU+KSZhaTizZdg#Value.-946459261.1", "Can't determine approval workflow, because the user's role is not present in the workflow.");
} else {
// Foreach GetApprovalProcessLevelsByApprovalProcessId.List
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.StartIteration();
try {localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Advance((localVars.resListIndexOf_outParamPosition+1));
while (!((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Eof))) {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion!=""))) {
if((!((BuiltInFunction.IndexSC (localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion, localVars.queryResGetRegionById_outParamList.CurrentRec.ssENRegion.ssCommissionRegion, 0, false, true)!=(-1))))) {
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Advance();
continue;
}

}

if(((((((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))||(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))||localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract)||localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)||localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract))) {
bool block3 = false;
do {
block3 = false;
bool block1 = false;
do {
block1 = false;
do {
if((((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0)))))) {
if((((localVars.inParami_Requisition.ssTotalAmount>localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount)&&(localVars.inParami_Requisition.ssTotalAmount<localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount)))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount==(((decimal)0))))) {
if(((localVars.inParami_Requisition.ssTotalAmount>localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount==(((decimal)0)))&&(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))) {
if(((localVars.inParami_Requisition.ssTotalAmount<localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount))) {
break;
}

} else {
// ALIGN
}

}

}

if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract&&((!localVars.inParami_Requisition.ssHasContract)||(localVars.inParami_Requisition.ssHasContract&&localVars.inParami_Requisition.ssIsContractPending))))) {
// jump to block1
block1 = true;
break;
} else {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract&&((!localVars.inParami_Requisition.ssHasContract)||(localVars.inParami_Requisition.ssHasContract&&localVars.inParami_Requisition.ssIsContractPending))))) {
// jump to block1
block1 = true;
break;
} else {
if((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)) {
// Query datasetGetSupplierById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierById_maxRecords = 1;
if (datasetGetSupplierById_maxRecords < 1) datasetGetSupplierById_maxRecords = 1;
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncActionGetReqApprovalProcessLevels.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssSupplierId,cancellationToken);

if(((localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX"))) {
// Query datasetGetProofOfForeignResidence
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProofOfForeignResidence_maxRecords = 1;
if (datasetGetProofOfForeignResidence_maxRecords < 1) datasetGetProofOfForeignResidence_maxRecords = 1;
int datasetGetProofOfForeignResidence_startIndex = 0;(localVars.queryResGetProofOfForeignResidence_outParamList,localVars.queryResGetProofOfForeignResidence_outParamCount) = await FuncActionGetReqApprovalProcessLevels.datasetGetProofOfForeignResidence(requestContext,datasetGetProofOfForeignResidence_maxRecords,datasetGetProofOfForeignResidence_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssId,cancellationToken);

if((localVars.queryResGetProofOfForeignResidence_outParamList.Empty)) {
// jump to block1
block1 = true;
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
if((block1 || block3)) {
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
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Approval Process not configured!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("z6CSnmzrmE2yhVGoApJ+EA#Value.-777494200.1", "Approval Process not configured!");
} else {
// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcl_ApprovalProcessLevels,async (p, cancellationToken) => p.ssLevelNumber,true,cancellationToken);

// l_HasStartedAccounting = l_ApprovalProcessLevels[0].IsStartAccounting
localVars.varLcl_HasStartedAccounting=localVars.varLcl_ApprovalProcessLevels[0].ssIsStartAccounting;
// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_Requisition.ssId, ssProcessTypeCode = localVars.inParami_ApprovalProcess.ssCode, ssApprovalProcessVersion = Convert.ToString(localVars.inParami_ApprovalProcess.ssVersion), ssCurrentLevel = localVars.varLcl_ApprovalProcessLevels[0].ssLevelNumber, ssMaxLevel = localVars.varLcl_ApprovalProcessLevels[(localVars.varLcl_ApprovalProcessLevels.Length-1)].ssLevelNumber, ssStartedOn = BuiltInFunction.CurrDateTime (), ssHasStartedAccounting = localVars.varLcl_HasStartedAccounting },cancellationToken);

// Foreach l_ApprovalProcessLevels
localVars.varLcl_ApprovalProcessLevels.StartIteration();
try {while (!((localVars.varLcl_ApprovalProcessLevels.Eof))) {
// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,new EN_27b1469f497d364a764a1359956ef9adEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionApprovalId = localVars.resRequisitionApprovalCreateOrUpdate.outParamId, ssLevelNumber = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssLevelNumber, ssApplicationRoleId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssApplicationRoleId, ssAssignedTo = BuiltInFunction.NullTextIdentifier (), ssNeedsContract = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssNeedsContract, ssApprovalStatusId = (((!localVars.varLcl_HasStarted)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)), ssIsAccounting = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssIsAccounting_DEPREC, ssIsStartAccounting = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssIsStartAccounting, ssApproveAsAreaUsuaria = (localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssNeedsContract||(localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssNeedsProofOfForeignResidence&&(!localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssIsAccounting_DEPREC))) },cancellationToken);

if((!(localVars.varLcl_HasStarted))) {
// GetReqNextApprover
(localVars.resGetReqNextApprover.outParamo_Output,localVars.resGetReqNextApprover.outParamo_UserId) = await Actions.ActionGetReqNextApprover(requestContext,localVars.inParami_Requisition.ssId,BuiltInFunction.GetUserId (),true,cancellationToken);

// IsSuccess
if((localVars.resGetReqNextApprover.outParamo_Output.ssIsSuccess)) {
// GetRequisitionApprovalLevel
localVars.resGetRequisitionApprovalLevel_outParamRecord = await ExtendedActions.GetRequisitionApprovalLevel(requestContext,localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId,cancellationToken);

// GetRequisitionApprovalLevel.Record.RequisitionApprovalLevel.AssignedTo = GetReqNextApprover.o_UserId
localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel.ssAssignedTo = localVars.resGetReqNextApprover.outParamo_UserId;
// RequisitionApprovalLevelCreateOrUpdate2
localVars.resRequisitionApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.resGetRequisitionApprovalLevel_outParamRecord.ssENRequisitionApprovalLevel,cancellationToken);

} else {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("3dgmRrYe10WVxibP6lC4qQ#Message.-1194184190.1", "Cannot determine first approver!"));

}

}

// l_HasStarted = True
localVars.varLcl_HasStarted=true;
localVars.varLcl_ApprovalProcessLevels.Advance();
}

} finally {
localVars.varLcl_ApprovalProcessLevels.EndIteration();
}

if((localVars.varLcl_HasStartedAccounting)) {
// InitializeRequisitionAccounting
await Actions.ActionInitializeRequisitionAccounting(requestContext,localVars.inParami_Requisition.ssId,cancellationToken);

}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

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

public static class FuncActionGetReqApprovalProcessLevels {

// Query Function "GetProofOfForeignResidence" l7JyBU_vMkiNw5C_QO1eiw of Action "GetReqApprovalProcessLevels"
public static async Task<(RL_25486e09ba20acde3d8ef9d3e8a6e625,long)> datasetGetProofOfForeignResidence(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcessLevels.GetProofOfForeignResidence", "0572b297-ef4f-4832-8dc3-90bf40ed5e8b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcessLevels.GetProofOfForeignResidence", "0572b297-ef4f-4832-8dc3-90bf40ed5e8b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.eonfujCZFECSDsDYjgwltQ/NodesNotShownInESpaceTree.l7JyBU_vMkiNw5C_QO1eiw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {RequisitionContractFile} \"enrequisitioncontractfile7\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile7\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncontractfile7\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile7\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile7\".\"contractfiletypeid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcessLevels.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcessLevels.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessLevelsByApprovalProcessId" i__SUV93ik++J1rI+CtifQ of Action "GetReqApprovalProcessLevels"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcessLevelsByApprovalProcessId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId", "51d2ff8b-775f-4f8a-be27-5ac8f82b627d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId", "51d2ff8b-775f-4f8a-be27-5ac8f82b627d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.eonfujCZFECSDsDYjgwltQ/NodesNotShownInESpaceTree.i__SUV93ik++J1rI+CtifQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enapprovalprocesslevel12\".\"levelnumber\" o21, \"enapprovalprocesslevel12\".\"applicationroleid\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, trim_scale(\"enapprovalprocesslevel12\".\"minamount\"::numeric) o30, trim_scale(\"enapprovalprocesslevel12\".\"maxamount\"::numeric) o31, NULL o32, NULL o33, \"enapprovalprocesslevel12\".\"onlyregion\" o34, \"enapprovalprocesslevel12\".\"withoutcontract\" o35, \"enapprovalprocesslevel12\".\"needsproofofforeignresidence\" o36, \"enapprovalprocesslevel12\".\"needscontract\" o37, \"enapprovalprocesslevel12\".\"isaccounting_deprec\" o38, \"enapprovalprocesslevel12\".\"isstartaccounting\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess29\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel12\" ON (\"enapprovalprocess29\".\"id\" = \"enapprovalprocesslevel12\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess29\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess29\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess29\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel12\".\"levelnumber\" ASC ");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, false, false, true, true, false, false, false, false, false, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

// Query Function "GetRegionById" JkEMoNFKRU2gdV2foo1t0Q of Action "GetReqApprovalProcessLevels"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcessLevels.GetRegionById", "a00c4126-4ad1-4d45-a075-5d9fa28d6dd1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcessLevels.GetRegionById", "a00c4126-4ad1-4d45-a075-5d9fa28d6dd1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.eonfujCZFECSDsDYjgwltQ/NodesNotShownInESpaceTree.JkEMoNFKRU2gdV2foo1t0Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enregion45\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion45\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enregion45\".\"id\" = @qpreId) AND (\"enregion45\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enregion45\".\"id\" IS NULL)");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcessLevels.GetRegionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcessLevels.GetRegionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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

// Query Function "GetSupplierById" OTTh7aFM5kOd_wCk++DFnw of Action "GetReqApprovalProcessLevels"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcessLevels.GetSupplierById", "ede13439-4ca1-43e6-9dff-00a4fbe0c59f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcessLevels.GetSupplierById", "ede13439-4ca1-43e6-9dff-00a4fbe0c59f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.eonfujCZFECSDsDYjgwltQ/NodesNotShownInESpaceTree.OTTh7aFM5kOd_wCk++DFnw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"ensupplier34\".\"pais\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier34\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier34\".\"id\" = @qpsuId) AND (\"ensupplier34\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier34\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcessLevels.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcessLevels.GetSupplierById.List", cancellationToken: cancellationToken);
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



}


}
