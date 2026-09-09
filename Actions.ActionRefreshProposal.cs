namespace ssConectaProveedores;

public partial class Actions {
public class lcvRefreshProposal : VarsBag {
public long inParami_ProposalId;
public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public RL_9f9acf7f8fbbfb480a215bc421efa609 queryResGetProposalApprovalLevels_outParamList = new RL_9f9acf7f8fbbfb480a215bc421efa609();
public long queryResGetProposalApprovalLevels_outParamCount = 0L;

public Actions.lcoProposalLogAdd resProposalLogAddApproved =  new Actions.lcoProposalLogAdd();
public int resListIndexOf_outParamPosition = 0;

public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoProposalApprovalCreateOrUpdate resProposalApprovalCreateOrUpdate =  new Actions.lcoProposalApprovalCreateOrUpdate();
public lcvRefreshProposal(long inParami_ProposalId) {
this.inParami_ProposalId = inParami_ProposalId;
}
}
/// <summary>
/// Action <code>RefreshProposal</code> that represents the Service Studio action
///  <code>RefreshProposal</code> <p> Description: Action to refresh Proposal</p>
/// </summary>
public static async Task ActionRefreshProposal(IRequestContext requestContext,long inParami_ProposalId,CancellationToken cancellationToken) {
lcvRefreshProposal localVars = new lcvRefreshProposal(inParami_ProposalId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RefreshProposal", "d9e5aae9-46f5-4dd2-bab5-063d573a7bd9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RefreshProposal", "d9e5aae9-46f5-4dd2-bab5-063d573a7bd9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalApprovalLevels
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalApprovalLevels_maxRecords = 0;
int datasetGetProposalApprovalLevels_startIndex = 0;(localVars.queryResGetProposalApprovalLevels_outParamList,localVars.queryResGetProposalApprovalLevels_outParamCount) = await FuncActionRefreshProposal.datasetGetProposalApprovalLevels(requestContext,datasetGetProposalApprovalLevels_maxRecords,datasetGetProposalApprovalLevels_startIndex,IterationMultiplicity.Single,localVars.inParami_ProposalId,cancellationToken);

// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetProposalApprovalLevels_outParamList,async (p, cancellationToken) => (!p.ssENProposalApprovalLevel.ssHasFinished),cancellationToken);

if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// GetProposalApprovalLevels.List.Current.ProposalApproval.FinishedOn = CurrDateTime
localVars.queryResGetProposalApprovalLevels_outParamList.CurrentRec.ssENProposalApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetProposalApprovalLevels.List.Current.Proposal.ProposalStatusId = Approved
localVars.queryResGetProposalApprovalLevels_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId;
// ProposalApprovalCreateOrUpdate
localVars.resProposalApprovalCreateOrUpdate.outParamId = await Actions.ActionProposalApprovalCreateOrUpdate(requestContext,localVars.queryResGetProposalApprovalLevels_outParamList.CurrentRec.ssENProposalApproval,cancellationToken);

// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalApprovalLevels_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalLogAddApproved
localVars.resProposalLogAddApproved.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.GetUserId (),((((AppUtils.GetStringResource("QQACZULS0kKYsXYgRH4S3A#Value.709609352.1", "Propuesta updated")+" ")+localVars.queryResGetProposalApprovalLevels_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("QQACZULS0kKYsXYgRH4S3A#Value.-2017770957.1", "al estado Aprobado.")),false,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.inParami_ProposalId, ssProposalStatusId = localVars.queryResGetProposalApprovalLevels_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRefreshProposal {

private static async Task<RC_921fd9090c7367c088e0777ee6e3ef28> datasetGetProposalApprovalLevelsReadDbAsync(RC_921fd9090c7367c088e0777ee6e3ef28 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetProposalApprovalLevels" dUy8C_aQBEqyP4+bISdtZQ of Action "RefreshProposal"
public static async Task<(RL_9f9acf7f8fbbfb480a215bc421efa609,long)> datasetGetProposalApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RefreshProposal.GetProposalApprovalLevels", "0bbc4c75-90f6-4a04-b23f-8f9b21276d65");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RefreshProposal.GetProposalApprovalLevels", "0bbc4c75-90f6-4a04-b23f-8f9b21276d65", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.6arl2fVG0k26tQY9Vzp72Q/NodesNotShownInESpaceTree.dUy8C_aQBEqyP4+bISdtZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposal13\".\"id\" o0, \"enproposal13\".\"name\" o1, \"enproposal13\".\"paymentdate\" o2, \"enproposal13\".\"proposaldate\" o3, \"enproposal13\".\"proposaltypeid\" o4, \"enproposal13\".\"bankid\" o5, \"enproposal13\".\"proposalstatusid\" o6, \"enproposal13\".\"fileid\" o7, \"enproposal13\".\"totalproposallines\" o8, trim_scale(\"enproposal13\".\"totalvalueml\"::numeric) o9, trim_scale(\"enproposal13\".\"totalvaluemd\"::numeric) o10, \"enproposal13\".\"currencyid\" o11, \"enproposal13\".\"regionid\" o12, \"enproposal13\".\"createdby\" o13, \"enproposal13\".\"createdon\" o14, \"enproposal13\".\"lastupdatedon\" o15, \"enproposal13\".\"maxdatepaymentchanges\" o16, \"enproposal13\".\"assignedtoid\" o17, \"enproposalapproval5\".\"id\" o18, \"enproposalapproval5\".\"proposalid\" o19, \"enproposalapproval5\".\"processtypecode\" o20, \"enproposalapproval5\".\"approvalprocessversion\" o21, \"enproposalapproval5\".\"currentlevel_deprec\" o22, \"enproposalapproval5\".\"maxlevel_deprec\" o23, \"enproposalapproval5\".\"startedon\" o24, \"enproposalapproval5\".\"finishedon\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enproposalapprovallevel7\".\"hasfinished\" o32");
fromBuilder.Append(" FROM (({ProposalApprovalLevel} \"enproposalapprovallevel7\" Left JOIN {ProposalApproval} \"enproposalapproval5\" ON (\"enproposalapprovallevel7\".\"proposalapprovalid\" = \"enproposalapproval5\".\"id\"))  Left JOIN {Proposal} \"enproposal13\" ON (\"enproposalapproval5\".\"proposalid\" = \"enproposal13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal13\".\"id\" = @qpprProposal_Id) AND (\"enproposal13\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal13\".\"id\" IS NULL)");
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
RL_9f9acf7f8fbbfb480a215bc421efa609 outParamList = new RL_9f9acf7f8fbbfb480a215bc421efa609();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RefreshProposal.GetProposalApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9f9acf7f8fbbfb480a215bc421efa609 _tmp = new RL_9f9acf7f8fbbfb480a215bc421efa609();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RefreshProposal.GetProposalApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9f9acf7f8fbbfb480a215bc421efa609)_tmp;
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
