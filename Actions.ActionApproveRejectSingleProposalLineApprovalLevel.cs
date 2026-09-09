namespace ssConectaProveedores;

public partial class Actions {
public class lcvApproveRejectSingleProposalLineApprovalLevel : VarsBag {
public long inParami_ProposalId;
public long inParami_ProposalLineApprovalLevelId;
public bool inParami_IsReject;
public string inParami_Comment;
/// <summary>
/// Variable <code>l__IsRefreshProposal</code> that represents the Service Studio Boolean
///  <code>l__IsRefreshProposal</code> <p>Description: IsRefreshProposal</p>
/// </summary>
public bool varLcl__IsRefreshProposal = false;

public Actions.lcoProposalApprovalLevelCreateOrUpdate resProposalApprovalLevelCreateOrUpdate =  new Actions.lcoProposalApprovalLevelCreateOrUpdate();
public RL_cb657a85ad5767a90a0cf2a0623ecec3 queryResGetOneNotApproved_outParamList = new RL_cb657a85ad5767a90a0cf2a0623ecec3();
public long queryResGetOneNotApproved_outParamCount = 0L;

public RL_e23a8e9d8d827e81e0e0449c363a37eb queryResGetOnePending_outParamList = new RL_e23a8e9d8d827e81e0e0449c363a37eb();
public long queryResGetOnePending_outParamCount = 0L;

public Actions.lcoProposalApprovalLevelCreateOrUpdate resProposalApprovalLevelCreateOrUpdate2 =  new Actions.lcoProposalApprovalLevelCreateOrUpdate();
public Actions.lcoProposalLogAdd resProposalLogAddApproved =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalCommentCreateOrUpdate resProposalCommentCreateOrUpdate =  new Actions.lcoProposalCommentCreateOrUpdate();
public RL_d22dbb34ff25b8803ae17b65f615d2c8 queryResGetUserApplicationRolesByUserId_outParamList = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
public long queryResGetUserApplicationRolesByUserId_outParamCount = 0L;

public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoProposalLineApprovalLevelCreateOrUpdate resProposalLineApprovalLevelCreateOrUpdate =  new Actions.lcoProposalLineApprovalLevelCreateOrUpdate();
public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public RL_368bd99a5798bf4e2cf7c1704f1b6372 queryResGetProposalLineApprovalLevelById_outParamList = new RL_368bd99a5798bf4e2cf7c1704f1b6372();
public long queryResGetProposalLineApprovalLevelById_outParamCount = 0L;

public Actions.lcoProposalLogAdd resProposalLogAddRejected2 =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalLogAdd resProposalLogAddRejected =  new Actions.lcoProposalLogAdd();
public lcvApproveRejectSingleProposalLineApprovalLevel(long inParami_ProposalId, long inParami_ProposalLineApprovalLevelId, bool inParami_IsReject, string inParami_Comment) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_ProposalLineApprovalLevelId = inParami_ProposalLineApprovalLevelId;
this.inParami_IsReject = inParami_IsReject;
this.inParami_Comment = inParami_Comment;
}
}
public class lcoApproveRejectSingleProposalLineApprovalLevel : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApproveRejectSingleProposalLineApprovalLevel() {
}
}
/// <summary>
/// Action <code>ApproveRejectSingleProposalLineApprovalLevel</code> that represents the Service Studio
///  action <code>ApproveRejectSingleProposalLineApprovalLevel</code> <p> Description: Action to approv
/// e or reject ProposalLineApprovalLevel</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApproveRejectSingleProposalLineApprovalLevel(IRequestContext requestContext,long inParami_ProposalId,long inParami_ProposalLineApprovalLevelId,bool inParami_IsReject,string inParami_Comment,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoApproveRejectSingleProposalLineApprovalLevel result = new lcoApproveRejectSingleProposalLineApprovalLevel();
lcvApproveRejectSingleProposalLineApprovalLevel localVars = new lcvApproveRejectSingleProposalLineApprovalLevel(inParami_ProposalId, inParami_ProposalLineApprovalLevelId, inParami_IsReject, inParami_Comment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApproveRejectSingleProposalLineApprovalLevel", "cbd322d5-0b24-4e90-baaa-f350b3ab5dde"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApproveRejectSingleProposalLineApprovalLevel", "cbd322d5-0b24-4e90-baaa-f350b3ab5dde", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalLineApprovalLevelById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLineApprovalLevelById_maxRecords = 1;
if (datasetGetProposalLineApprovalLevelById_maxRecords < 1) datasetGetProposalLineApprovalLevelById_maxRecords = 1;
int datasetGetProposalLineApprovalLevelById_startIndex = 0;(localVars.queryResGetProposalLineApprovalLevelById_outParamList,localVars.queryResGetProposalLineApprovalLevelById_outParamCount) = await FuncActionApproveRejectSingleProposalLineApprovalLevel.datasetGetProposalLineApprovalLevelById(requestContext,datasetGetProposalLineApprovalLevelById_maxRecords,datasetGetProposalLineApprovalLevelById_startIndex,IterationMultiplicity.Never,localVars.inParami_ProposalLineApprovalLevelId,cancellationToken);

if(((localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId==(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Proposal is rejected, you can't update it's proposal lines."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("J3NUdvLJwU22C64nC+pVgg#Value.1506408365.1", "Proposal is rejected, you can't update it's proposal lines.");
} else {
if(((localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Proposal line cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("Crbdbg1ickOlapzaNoLc9A#Value.-1466937596.1", "Proposal line cannot be updated!");
} else {
// Query datasetGetUserApplicationRolesByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRolesByUserId_maxRecords = 1;
if (datasetGetUserApplicationRolesByUserId_maxRecords < 1) datasetGetUserApplicationRolesByUserId_maxRecords = 1;
int datasetGetUserApplicationRolesByUserId_startIndex = 0;(localVars.queryResGetUserApplicationRolesByUserId_outParamList,localVars.queryResGetUserApplicationRolesByUserId_outParamCount) = await FuncActionApproveRejectSingleProposalLineApprovalLevel.datasetGetUserApplicationRolesByUserId(requestContext,datasetGetUserApplicationRolesByUserId_maxRecords,datasetGetUserApplicationRolesByUserId_startIndex,IterationMultiplicity.Never,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApplicationRoleId,BuiltInFunction.GetUserId (),cancellationToken);

if((localVars.inParami_IsReject)) {
// GetProposalLineApprovalLevelById.List.Current.ProposalLineApprovalLevel.ApprovalStatusId = Rejected
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId;

// GetProposalLineApprovalLevelById.List.Current.ProposalLineApprovalLevel.RejectedBy = GetUserId
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssRejectedBy = BuiltInFunction.GetUserId ();

// GetProposalLineApprovalLevelById.List.Current.ProposalLineApprovalLevel.RejectedOn = CurrDateTime
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssRejectedOn = BuiltInFunction.CurrDateTime ();
// ProposalCommentCreateOrUpdate
localVars.resProposalCommentCreateOrUpdate.outParamId = await Actions.ActionProposalCommentCreateOrUpdate(requestContext,new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId, ssProposalId = localVars.inParami_ProposalId, ssProposalLineId = localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssProposalLineId, ssProposalLineApprovalLevelId = localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssId, ssApplicationRoleId = localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApplicationRoleId, ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = localVars.inParami_Comment },cancellationToken);

// ProposalLogAddRejected
localVars.resProposalLogAddRejected.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssProposalLineId,BuiltInFunction.GetUserId (),((((((localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLine.ssN_DocType+" ")+AppUtils.GetStringResource("hMcPLCtlukqQFMFV_NIL1g#Value.-608496514.1", "rejected"))+((localVars.queryResGetUserApplicationRolesByUserId_outParamList.Empty) ? ((" "+AppUtils.GetStringResource("hMcPLCtlukqQFMFV_NIL1g#Value.1391357666.1", "by a substitute"))) : (" ")))+AppUtils.GetStringResource("hMcPLCtlukqQFMFV_NIL1g#Value.448016147.1", "with the following comment:"))+" ")+localVars.inParami_Comment),false,cancellationToken);

} else {
// Approved
// GetProposalLineApprovalLevelById.List.Current.ProposalLineApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;

// GetProposalLineApprovalLevelById.List.Current.ProposalLineApprovalLevel.ApprovedBy = GetUserId
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// GetProposalLineApprovalLevelById.List.Current.ProposalLineApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();
// ProposalLogAddApproved
localVars.resProposalLogAddApproved.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssProposalLineId,BuiltInFunction.GetUserId (),(((localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLine.ssN_DocType+" ")+AppUtils.GetStringResource("c1U4exxX2Ui6wWj5_JDHZw#Value.1185244855.1", "approved"))+((localVars.queryResGetUserApplicationRolesByUserId_outParamList.Empty) ? (((" "+AppUtils.GetStringResource("c1U4exxX2Ui6wWj5_JDHZw#Value.1391357666.1", "by a substitute"))+".")) : ("."))),false,cancellationToken);

}

// ProposalLineApprovalLevelCreateOrUpdate
localVars.resProposalLineApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalLineApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel,cancellationToken);

if((localVars.inParami_IsReject)) {
// GetProposalLineApprovalLevelById.List.Current.Proposal.ProposalStatusId = Rejected
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId;

// GetProposalLineApprovalLevelById.List.Current.ProposalApprovalLevel.ApprovalStatusId = Rejected
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId;
// ProposalApprovalLevelCreateOrUpdate2
localVars.resProposalApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionProposalApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel,cancellationToken);

// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.inParami_ProposalId, ssProposalStatusId = localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// ProposalLogAddRejected2
localVars.resProposalLogAddRejected2.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.GetUserId (),((((AppUtils.GetStringResource("gci4nrrAFESYWTU+vQam_Q#Value.-998289193.1", "Updated proposal")+" ")+localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("gci4nrrAFESYWTU+vQam_Q#Value.-433919027.1", "to the state rejected.")),false,cancellationToken);

// SendRejectedProposalEmails
await Actions.ActionSendRejectedProposalEmails(requestContext,localVars.inParami_ProposalId,localVars.inParami_Comment,cancellationToken);

} else {
// Query datasetGetOnePending
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOnePending_maxRecords = 0;
int datasetGetOnePending_startIndex = 0;(localVars.queryResGetOnePending_outParamList,localVars.queryResGetOnePending_outParamCount) = await FuncActionApproveRejectSingleProposalLineApprovalLevel.datasetGetOnePending(requestContext,datasetGetOnePending_maxRecords,datasetGetOnePending_startIndex,IterationMultiplicity.Never,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssId,cancellationToken);

if((localVars.queryResGetOnePending_outParamList.Empty)) {
// Query datasetGetOneNotApproved
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOneNotApproved_maxRecords = 1;
if (datasetGetOneNotApproved_maxRecords < 1) datasetGetOneNotApproved_maxRecords = 1;
int datasetGetOneNotApproved_startIndex = 0;(localVars.queryResGetOneNotApproved_outParamList,localVars.queryResGetOneNotApproved_outParamCount) = await FuncActionApproveRejectSingleProposalLineApprovalLevel.datasetGetOneNotApproved(requestContext,datasetGetOneNotApproved_maxRecords,datasetGetOneNotApproved_startIndex,IterationMultiplicity.Never,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssId,cancellationToken);

if((localVars.queryResGetOneNotApproved_outParamList.Empty)) {
// GetProposalLineApprovalLevelById.List.Current.ProposalApprovalLevel.HasFinished = True
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssHasFinished = true;

// l__IsRefreshProposal = True
localVars.varLcl__IsRefreshProposal=true;

// GetProposalLineApprovalLevelById.List.Current.ProposalApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;
// ProposalApprovalLevelCreateOrUpdate
localVars.resProposalApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel,cancellationToken);

}

}

// RefreshProposalApprovalLevel
await Actions.ActionGetNextProposalApprovalLevel(requestContext,localVars.inParami_ProposalId,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssProposalLineId,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssLevelNumber,localVars.queryResGetUserApplicationRolesByUserId_outParamList.Empty,localVars.varLcl__IsRefreshProposal,cancellationToken);

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

public static class FuncActionApproveRejectSingleProposalLineApprovalLevel {

// Query Function "GetOneNotApproved" D0MfLgeYwEGgfK3vfhD2JQ of Action "ApproveRejectSingleProposalLineApprovalLevel"
public static async Task<(RL_cb657a85ad5767a90a0cf2a0623ecec3,long)> datasetGetOneNotApproved(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalApprovalLevelId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApproveRejectSingleProposalLineApprovalLevel.GetOneNotApproved", "2e1f430f-9807-41c0-a07c-adef7e10f625");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApproveRejectSingleProposalLineApprovalLevel.GetOneNotApproved", "2e1f430f-9807-41c0-a07c-adef7e10f625", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1SLTyyQLkE66qvNQs6td3g/NodesNotShownInESpaceTree.D0MfLgeYwEGgfK3vfhD2JQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {ProposalLineApprovalLevel} \"enproposallineapprovallevel2\"");
whereBuilder.Append(" WHERE (\"enproposallineapprovallevel2\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") AND ");
if (qpprProposalApprovalLevelId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel2\".\"proposalapprovallevelid\" = @qpprProposalApprovalLevelId) AND (\"enproposallineapprovallevel2\".\"proposalapprovallevelid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalApprovalLevelId", DbType.Int64, qpprProposalApprovalLevelId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel2\".\"proposalapprovallevelid\" IS NULL)");
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
RL_cb657a85ad5767a90a0cf2a0623ecec3 outParamList = new RL_cb657a85ad5767a90a0cf2a0623ecec3();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApproveRejectSingleProposalLineApprovalLevel.GetOneNotApproved.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cb657a85ad5767a90a0cf2a0623ecec3 _tmp = new RL_cb657a85ad5767a90a0cf2a0623ecec3();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApproveRejectSingleProposalLineApprovalLevel.GetOneNotApproved.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cb657a85ad5767a90a0cf2a0623ecec3)_tmp;
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

private static async Task<RC_5327da8894a76849e4ef5a737a86e7d3> datasetGetOnePendingReadDbAsync(RC_5327da8894a76849e4ef5a737a86e7d3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalLineApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetOnePending" DaHCMSVxfUmbDsrXC_1eXQ of Action "ApproveRejectSingleProposalLineApprovalLevel"
public static async Task<(RL_e23a8e9d8d827e81e0e0449c363a37eb,long)> datasetGetOnePending(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApproveRejectSingleProposalLineApprovalLevel.GetOnePending", "31c2a10d-7125-497d-9b0e-cad70bfd5e5d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApproveRejectSingleProposalLineApprovalLevel.GetOnePending", "31c2a10d-7125-497d-9b0e-cad70bfd5e5d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1SLTyyQLkE66qvNQs6td3g/NodesNotShownInESpaceTree.DaHCMSVxfUmbDsrXC_1eXQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15");
fromBuilder.Append(" FROM ({ProposalApprovalLevel} \"enproposalapprovallevel4\" Left JOIN {ProposalLineApprovalLevel} \"enproposallineapprovallevel3\" ON (\"enproposalapprovallevel4\".\"id\" = \"enproposallineapprovallevel3\".\"proposalapprovallevelid\")) ");
whereBuilder.Append(" WHERE (\"enproposallineapprovallevel3\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND ");
if (qpprProposalApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enproposalapprovallevel4\".\"id\" = @qpprProposalApprovalLevel_Id) AND (\"enproposalapprovallevel4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalApprovalLevel_Id", DbType.Int64, qpprProposalApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enproposalapprovallevel4\".\"id\" IS NULL)");
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
RL_e23a8e9d8d827e81e0e0449c363a37eb outParamList = new RL_e23a8e9d8d827e81e0e0449c363a37eb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOnePendingReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApproveRejectSingleProposalLineApprovalLevel.GetOnePending.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e23a8e9d8d827e81e0e0449c363a37eb _tmp = new RL_e23a8e9d8d827e81e0e0449c363a37eb();
_tmp.AlternateReadDbMethodAsync = datasetGetOnePendingReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApproveRejectSingleProposalLineApprovalLevel.GetOnePending.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e23a8e9d8d827e81e0e0449c363a37eb)_tmp;
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

// Query Function "GetUserApplicationRolesByUserId" XR7mkkjic0ugHpzQyzh4AA of Action "ApproveRejectSingleProposalLineApprovalLevel"
public static async Task<(RL_d22dbb34ff25b8803ae17b65f615d2c8,long)> datasetGetUserApplicationRolesByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApplicationRoleId,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApproveRejectSingleProposalLineApprovalLevel.GetUserApplicationRolesByUserId", "92e61e5d-e248-4b73-a01e-9cd0cb387800");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApproveRejectSingleProposalLineApprovalLevel.GetUserApplicationRolesByUserId", "92e61e5d-e248-4b73-a01e-9cd0cb387800", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1SLTyyQLkE66qvNQs6td3g/NodesNotShownInESpaceTree.XR7mkkjic0ugHpzQyzh4AA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {UserApplicationRole} \"enuserapplicationrole13\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationrole13\".\"userid\" = @qpusUserId) AND (\"enuserapplicationrole13\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationrole13\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole13\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND ");
if (qpapApplicationRoleId != 0) {
whereBuilder.Append("((\"enuserapplicationrole13\".\"applicationroleid\" = @qpapApplicationRoleId) AND (\"enuserapplicationrole13\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRoleId", DbType.Int64, qpapApplicationRoleId);
} else {
whereBuilder.Append("(\"enuserapplicationrole13\".\"applicationroleid\" IS NULL)");
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
RL_d22dbb34ff25b8803ae17b65f615d2c8 outParamList = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApproveRejectSingleProposalLineApprovalLevel.GetUserApplicationRolesByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d22dbb34ff25b8803ae17b65f615d2c8 _tmp = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApproveRejectSingleProposalLineApprovalLevel.GetUserApplicationRolesByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d22dbb34ff25b8803ae17b65f615d2c8)_tmp;
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

private static async Task<RC_5b9ef0a641f5e1a605fb31b6e1e86d2a> datasetGetProposalLineApprovalLevelByIdReadDbAsync(RC_5b9ef0a641f5e1a605fb31b6e1e86d2a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENProposalLineApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLineApprovalLevelById" mfAO1bdYJEyOjzzXTC6w0A of Action "ApproveRejectSingleProposalLineApprovalLevel"
public static async Task<(RL_368bd99a5798bf4e2cf7c1704f1b6372,long)> datasetGetProposalLineApprovalLevelById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalLineApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApproveRejectSingleProposalLineApprovalLevel.GetProposalLineApprovalLevelById", "d50ef099-58b7-4c24-8e8f-3cd74c2eb0d0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApproveRejectSingleProposalLineApprovalLevel.GetProposalLineApprovalLevelById", "d50ef099-58b7-4c24-8e8f-3cd74c2eb0d0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1SLTyyQLkE66qvNQs6td3g/NodesNotShownInESpaceTree.mfAO1bdYJEyOjzzXTC6w0A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposal10\".\"id\" o0, \"enproposal10\".\"name\" o1, \"enproposal10\".\"paymentdate\" o2, \"enproposal10\".\"proposaldate\" o3, \"enproposal10\".\"proposaltypeid\" o4, \"enproposal10\".\"bankid\" o5, \"enproposal10\".\"proposalstatusid\" o6, \"enproposal10\".\"fileid\" o7, \"enproposal10\".\"totalproposallines\" o8, trim_scale(\"enproposal10\".\"totalvalueml\"::numeric) o9, trim_scale(\"enproposal10\".\"totalvaluemd\"::numeric) o10, \"enproposal10\".\"currencyid\" o11, \"enproposal10\".\"regionid\" o12, \"enproposal10\".\"createdby\" o13, \"enproposal10\".\"createdon\" o14, \"enproposal10\".\"lastupdatedon\" o15, \"enproposal10\".\"maxdatepaymentchanges\" o16, \"enproposal10\".\"assignedtoid\" o17, \"enproposalapprovallevel5\".\"id\" o18, \"enproposalapprovallevel5\".\"proposalapprovalid\" o19, \"enproposalapprovallevel5\".\"levelnumber\" o20, \"enproposalapprovallevel5\".\"applicationroleid\" o21, \"enproposalapprovallevel5\".\"approvalstatusid\" o22, \"enproposalapprovallevel5\".\"hasstarted\" o23, \"enproposalapprovallevel5\".\"hasfinished\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enproposalline7\".\"n_doctype\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, \"enproposallineapprovallevel4\".\"id\" o53, \"enproposallineapprovallevel4\".\"proposallineid\" o54, \"enproposallineapprovallevel4\".\"proposalapprovallevelid\" o55, \"enproposallineapprovallevel4\".\"applicationroleid\" o56, \"enproposallineapprovallevel4\".\"approvalstatusid\" o57, \"enproposallineapprovallevel4\".\"approvedby\" o58, \"enproposallineapprovallevel4\".\"approvedon\" o59, \"enproposallineapprovallevel4\".\"rejectedby\" o60, \"enproposallineapprovallevel4\".\"rejectedon\" o61");
fromBuilder.Append(" FROM ((({ProposalLineApprovalLevel} \"enproposallineapprovallevel4\" Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel5\" ON (\"enproposallineapprovallevel4\".\"proposalapprovallevelid\" = \"enproposalapprovallevel5\".\"id\"))  Left JOIN {ProposalLine} \"enproposalline7\" ON (\"enproposallineapprovallevel4\".\"proposallineid\" = \"enproposalline7\".\"id\"))  Left JOIN {Proposal} \"enproposal10\" ON (\"enproposalline7\".\"proposalid\" = \"enproposal10\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalLineApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel4\".\"id\" = @qpprProposalLineApprovalLevel_Id) AND (\"enproposallineapprovallevel4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_Id", DbType.Int64, qpprProposalLineApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel4\".\"id\" IS NULL)");
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
RL_368bd99a5798bf4e2cf7c1704f1b6372 outParamList = new RL_368bd99a5798bf4e2cf7c1704f1b6372();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLineApprovalLevelByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApproveRejectSingleProposalLineApprovalLevel.GetProposalLineApprovalLevelById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_368bd99a5798bf4e2cf7c1704f1b6372 _tmp = new RL_368bd99a5798bf4e2cf7c1704f1b6372();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLineApprovalLevelByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApproveRejectSingleProposalLineApprovalLevel.GetProposalLineApprovalLevelById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_368bd99a5798bf4e2cf7c1704f1b6372)_tmp;
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
