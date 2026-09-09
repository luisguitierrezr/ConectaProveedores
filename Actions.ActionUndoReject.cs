namespace ssConectaProveedores;

public partial class Actions {
public class lcvUndoReject : VarsBag {
public long inParami_ProposalId;
public long inParami_ProposalLineApprovalLevelId;
public RL_379ef1eaf8ca0c4557841a9701c37878 queryResGetProposalLineApprovalLevelById_outParamList = new RL_379ef1eaf8ca0c4557841a9701c37878();
public long queryResGetProposalLineApprovalLevelById_outParamCount = 0L;

public Actions.lcoProposalApprovalLevelCreateOrUpdate resProposalApprovalLevelCreateOrUpdate =  new Actions.lcoProposalApprovalLevelCreateOrUpdate();
public Actions.lcoProposalLineApprovalLevelCreateOrUpdate resProposalLineApprovalLevelCreateOrUpdate =  new Actions.lcoProposalLineApprovalLevelCreateOrUpdate();
public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public RL_88245586d5ac2ebd4048f53abef0c31b queryResGetProposalById_outParamList = new RL_88245586d5ac2ebd4048f53abef0c31b();
public long queryResGetProposalById_outParamCount = 0L;

public Actions.lcoProposalLogAdd resProposalLogAdd2 =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoProposalLogAdd resProposalLogAdd =  new Actions.lcoProposalLogAdd();
public lcvUndoReject(long inParami_ProposalId, long inParami_ProposalLineApprovalLevelId) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_ProposalLineApprovalLevelId = inParami_ProposalLineApprovalLevelId;
}
}
public class lcoUndoReject : VarsBag {
public bool outParamo_HasProposalChangedStatus = false;

public lcoUndoReject() {
}
}
/// <summary>
/// Action <code>UndoReject</code> that represents the Service Studio action <code>UndoReject</code>
///  <p> Description: </p>
/// </summary>
public static async Task<bool> ActionUndoReject(IRequestContext requestContext,long inParami_ProposalId,long inParami_ProposalLineApprovalLevelId,CancellationToken cancellationToken) {
bool outParamo_HasProposalChangedStatus = default;
lcoUndoReject result = new lcoUndoReject();
lcvUndoReject localVars = new lcvUndoReject(inParami_ProposalId, inParami_ProposalLineApprovalLevelId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UndoReject", "823cf4d6-559d-4817-ad5e-20c5dde712e5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UndoReject", "823cf4d6-559d-4817-ad5e-20c5dde712e5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalLineApprovalLevelById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLineApprovalLevelById_maxRecords = 1;
if (datasetGetProposalLineApprovalLevelById_maxRecords < 1) datasetGetProposalLineApprovalLevelById_maxRecords = 1;
int datasetGetProposalLineApprovalLevelById_startIndex = 0;(localVars.queryResGetProposalLineApprovalLevelById_outParamList,localVars.queryResGetProposalLineApprovalLevelById_outParamCount) = await FuncActionUndoReject.datasetGetProposalLineApprovalLevelById(requestContext,datasetGetProposalLineApprovalLevelById_maxRecords,datasetGetProposalLineApprovalLevelById_startIndex,IterationMultiplicity.Never,localVars.inParami_ProposalLineApprovalLevelId,cancellationToken);

// Is really rejected?
if(((localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId))) {
// GetProposalLineApprovalLevelById.List.Current.ProposalLineApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetProposalLineApprovalLevelById.List.Current.ProposalApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;
// ProposalLineApprovalLevelCreateOrUpdate
localVars.resProposalLineApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalLineApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel,cancellationToken);

// ProposalApprovalLevelCreateOrUpdate
localVars.resProposalApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalApprovalLevel,cancellationToken);

// ProposalLogAdd
localVars.resProposalLogAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLine.ssId,BuiltInFunction.GetUserId (),(((localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLine.ssN_DocType+":")+" ")+AppUtils.GetStringResource("ucECERDKd06PuPXUkUoXpA#Value.1567775674.1", "rejected status reverted by an admin.")),false,cancellationToken);

// Query datasetGetProposalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalById_maxRecords = 1;
if (datasetGetProposalById_maxRecords < 1) datasetGetProposalById_maxRecords = 1;
int datasetGetProposalById_startIndex = 0;(localVars.queryResGetProposalById_outParamList,localVars.queryResGetProposalById_outParamCount) = await FuncActionUndoReject.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Never,localVars.inParami_ProposalId,cancellationToken);

// ProposalLogAdd2
localVars.resProposalLogAdd2.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,localVars.queryResGetProposalLineApprovalLevelById_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssProposalLineId,BuiltInFunction.GetUserId (),((((AppUtils.GetStringResource("S45TN5cXcEia0HiHEuANkA#Value.1376292480.1", "This proposal line")+" ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("S45TN5cXcEia0HiHEuANkA#Value.-1353271415.1", "has had it's rejection status undone by an admin")),false,cancellationToken);

// GetProposalById.List.Current.Proposal.ProposalStatusId = InApproval
localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("7agdijeyhUC3qdG5GpOcAg"))).ssId;
// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.inParami_ProposalId, ssProposalStatusId = localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// o_HasProposalChangedStatus = True
result.outParamo_HasProposalChangedStatus=true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_HasProposalChangedStatus = result.outParamo_HasProposalChangedStatus;
} // inner-finally
RETURN_STATEMENT:
return outParamo_HasProposalChangedStatus;
}

public static class FuncActionUndoReject {

private static async Task<RC_90af34fed2114347870a398404753d70> datasetGetProposalLineApprovalLevelByIdReadDbAsync(RC_90af34fed2114347870a398404753d70 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENProposalLineApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLineApprovalLevelById" xkBJKczvK0Su94WrrgTFWA of Action "UndoReject"
public static async Task<(RL_379ef1eaf8ca0c4557841a9701c37878,long)> datasetGetProposalLineApprovalLevelById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalLineApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UndoReject.GetProposalLineApprovalLevelById", "294940c6-efcc-442b-aef7-85abae04c558");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UndoReject.GetProposalLineApprovalLevelById", "294940c6-efcc-442b-aef7-85abae04c558", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1vQ8gp1VF0itXiDF3ecS5Q/NodesNotShownInESpaceTree.xkBJKczvK0Su94WrrgTFWA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalapprovallevel2\".\"id\" o0, \"enproposalapprovallevel2\".\"proposalapprovalid\" o1, \"enproposalapprovallevel2\".\"levelnumber\" o2, \"enproposalapprovallevel2\".\"applicationroleid\" o3, \"enproposalapprovallevel2\".\"approvalstatusid\" o4, \"enproposalapprovallevel2\".\"hasstarted\" o5, \"enproposalapprovallevel2\".\"hasfinished\" o6, \"enproposalline2\".\"id\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enproposalline2\".\"n_doctype\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enproposallineapprovallevel1\".\"id\" o35, \"enproposallineapprovallevel1\".\"proposallineid\" o36, \"enproposallineapprovallevel1\".\"proposalapprovallevelid\" o37, \"enproposallineapprovallevel1\".\"applicationroleid\" o38, \"enproposallineapprovallevel1\".\"approvalstatusid\" o39, \"enproposallineapprovallevel1\".\"approvedby\" o40, \"enproposallineapprovallevel1\".\"approvedon\" o41, \"enproposallineapprovallevel1\".\"rejectedby\" o42, \"enproposallineapprovallevel1\".\"rejectedon\" o43");
fromBuilder.Append(" FROM (({ProposalLineApprovalLevel} \"enproposallineapprovallevel1\" Left JOIN {ProposalLine} \"enproposalline2\" ON (\"enproposallineapprovallevel1\".\"proposallineid\" = \"enproposalline2\".\"id\"))  Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel2\" ON (\"enproposallineapprovallevel1\".\"proposalapprovallevelid\" = \"enproposalapprovallevel2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalLineApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel1\".\"id\" = @qpprProposalLineApprovalLevel_Id) AND (\"enproposallineapprovallevel1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_Id", DbType.Int64, qpprProposalLineApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel1\".\"id\" IS NULL)");
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
RL_379ef1eaf8ca0c4557841a9701c37878 outParamList = new RL_379ef1eaf8ca0c4557841a9701c37878();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLineApprovalLevelByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UndoReject.GetProposalLineApprovalLevelById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_379ef1eaf8ca0c4557841a9701c37878 _tmp = new RL_379ef1eaf8ca0c4557841a9701c37878();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLineApprovalLevelByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UndoReject.GetProposalLineApprovalLevelById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_379ef1eaf8ca0c4557841a9701c37878)_tmp;
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

// Query Function "GetProposalById" hk7wuiZBl0a82oL46HLRRQ of Action "UndoReject"
public static async Task<(RL_88245586d5ac2ebd4048f53abef0c31b,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UndoReject.GetProposalById", "baf04e86-4126-4697-bcda-82f8e872d145");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UndoReject.GetProposalById", "baf04e86-4126-4697-bcda-82f8e872d145", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1vQ8gp1VF0itXiDF3ecS5Q/NodesNotShownInESpaceTree.hk7wuiZBl0a82oL46HLRRQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposal3\".\"id\" o0, \"enproposal3\".\"name\" o1, \"enproposal3\".\"paymentdate\" o2, \"enproposal3\".\"proposaldate\" o3, \"enproposal3\".\"proposaltypeid\" o4, \"enproposal3\".\"bankid\" o5, \"enproposal3\".\"proposalstatusid\" o6, \"enproposal3\".\"fileid\" o7, \"enproposal3\".\"totalproposallines\" o8, trim_scale(\"enproposal3\".\"totalvalueml\"::numeric) o9, trim_scale(\"enproposal3\".\"totalvaluemd\"::numeric) o10, \"enproposal3\".\"currencyid\" o11, \"enproposal3\".\"regionid\" o12, \"enproposal3\".\"createdby\" o13, \"enproposal3\".\"createdon\" o14, \"enproposal3\".\"lastupdatedon\" o15, \"enproposal3\".\"maxdatepaymentchanges\" o16, \"enproposal3\".\"assignedtoid\" o17");
fromBuilder.Append(" FROM {Proposal} \"enproposal3\"");
whereBuilder.Append(" WHERE ");
if (qpprId != 0) {
whereBuilder.Append("((\"enproposal3\".\"id\" = @qpprId) AND (\"enproposal3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int64, qpprId);
} else {
whereBuilder.Append("(\"enproposal3\".\"id\" IS NULL)");
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
RL_88245586d5ac2ebd4048f53abef0c31b outParamList = new RL_88245586d5ac2ebd4048f53abef0c31b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UndoReject.GetProposalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_88245586d5ac2ebd4048f53abef0c31b _tmp = new RL_88245586d5ac2ebd4048f53abef0c31b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UndoReject.GetProposalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_88245586d5ac2ebd4048f53abef0c31b)_tmp;
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
