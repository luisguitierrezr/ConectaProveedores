namespace ssConectaProveedores;

public partial class Actions {
public class lcvCancelProposal : VarsBag {
public long inParami_ProposalId;
public string inParami_CancelReason;
public Actions.lcoProposalLogAdd resProposalLogAdd =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalApprovalCreateOrUpdate resProposalApprovalCreateOrUpdate =  new Actions.lcoProposalApprovalCreateOrUpdate();
public RL_5a265eacaa987aecd8ded8a7c13b9b2d queryResGetProposalLines_outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
public long queryResGetProposalLines_outParamCount = 0L;

public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoProposalCommentCreateOrUpdate resProposalCommentCreateOrUpdate =  new Actions.lcoProposalCommentCreateOrUpdate();
public Actions.lcoProposalLineCreateOrUpdate resProposalLineCreateOrUpdate =  new Actions.lcoProposalLineCreateOrUpdate();
public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public RL_539231a5cc05839b9d01250c4ae7131c queryResGetProposalById_outParamList = new RL_539231a5cc05839b9d01250c4ae7131c();
public long queryResGetProposalById_outParamCount = 0L;

public Actions.lcoProposalLogAdd resProposalLineLogAdd =  new Actions.lcoProposalLogAdd();
public lcvCancelProposal(long inParami_ProposalId, string inParami_CancelReason) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_CancelReason = inParami_CancelReason;
}
}
/// <summary>
/// Action <code>CancelProposal</code> that represents the Service Studio action
///  <code>CancelProposal</code> <p> Description: </p>
/// </summary>
public static async Task ActionCancelProposal(IRequestContext requestContext,long inParami_ProposalId,string inParami_CancelReason,CancellationToken cancellationToken) {
lcvCancelProposal localVars = new lcvCancelProposal(inParami_ProposalId, inParami_CancelReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CancelProposal", "736e4377-b497-4951-8d62-219d9d5105c4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CancelProposal", "736e4377-b497-4951-8d62-219d9d5105c4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalById_maxRecords = 1;
if (datasetGetProposalById_maxRecords < 1) datasetGetProposalById_maxRecords = 1;
int datasetGetProposalById_startIndex = 0;(localVars.queryResGetProposalById_outParamList,localVars.queryResGetProposalById_outParamCount) = await FuncActionCancelProposal.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Never,localVars.inParami_ProposalId,cancellationToken);

// Is Already Canceled or Being Paid?
if((!(((localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId==(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId)||(localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId==(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId))))) {
// GetProposalById.List.Current.Proposal.ProposalStatusId = Canceled
localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId;

// GetProposalById.List.Current.ProposalApproval.FinishedOn = CurrDateTime
localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposalApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();
// ProposalCommentCreateOrUpdate
localVars.resProposalCommentCreateOrUpdate.outParamId = await Actions.ActionProposalCommentCreateOrUpdate(requestContext,new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("qajvy+SdnE6bqldjFZvPIg"))).ssId, ssProposalId = localVars.inParami_ProposalId, ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = localVars.inParami_CancelReason },cancellationToken);

// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.inParami_ProposalId, ssProposalStatusId = localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// ProposalApprovalCreateOrUpdate
localVars.resProposalApprovalCreateOrUpdate.outParamId = await Actions.ActionProposalApprovalCreateOrUpdate(requestContext,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposalApproval,cancellationToken);

// Query datasetGetProposalLines
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLines_maxRecords = 0;
int datasetGetProposalLines_startIndex = 0;(localVars.queryResGetProposalLines_outParamList,localVars.queryResGetProposalLines_outParamCount) = await FuncActionCancelProposal.datasetGetProposalLines(requestContext,datasetGetProposalLines_maxRecords,datasetGetProposalLines_startIndex,IterationMultiplicity.Single,localVars.inParami_ProposalId,cancellationToken);

// Foreach GetProposalLines.List
localVars.queryResGetProposalLines_outParamList.StartIteration();
try {while (!((localVars.queryResGetProposalLines_outParamList.Eof))) {
// Set Cancel
// GetProposalLines.List.Current.ProposalLine.ApprovalStatusId = Canceled
localVars.queryResGetProposalLines_outParamList.CurrentRec.ssENProposalLine.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId;
// ProposalLineCreateOrUpdate
localVars.resProposalLineCreateOrUpdate.outParamId = await Actions.ActionProposalLineCreateOrUpdate(requestContext,localVars.queryResGetProposalLines_outParamList.CurrentRec.ssENProposalLine,cancellationToken);

// ProposalLineLogAdd
localVars.resProposalLineLogAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,localVars.queryResGetProposalLines_outParamList.CurrentRec.ssENProposalLine.ssId,BuiltInFunction.GetUserId (),((((AppUtils.GetStringResource("EJOl9V_sdEivflJOn6qAog#Value.877971942.1", "Payment")+" ")+localVars.queryResGetProposalLines_outParamList.CurrentRec.ssENProposalLine.ssN_DocType)+" ")+AppUtils.GetStringResource("EJOl9V_sdEivflJOn6qAog#Value.1923066730.1", "manually cancelled.")),false,cancellationToken);

localVars.queryResGetProposalLines_outParamList.Advance();
}

} finally {
localVars.queryResGetProposalLines_outParamList.EndIteration();
}

// ProposalLogAdd
localVars.resProposalLogAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,0L,BuiltInFunction.GetUserId (),((((AppUtils.GetStringResource("dskCi6QV4Ei8ESIbDjqgbA#Value.-928198894.1", "Proposal")+" ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("dskCi6QV4Ei8ESIbDjqgbA#Value.1923066730.1", "manually cancelled.")),false,cancellationToken);

// SendCanceledProposalEmail
await Actions.ActionSendCanceledProposalEmail(requestContext,localVars.inParami_ProposalId,localVars.inParami_CancelReason,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionCancelProposal {

// Query Function "GetProposalLines" 3dhVZ+l4AkeGohT7_iOmqA of Action "CancelProposal"
public static async Task<(RL_5a265eacaa987aecd8ded8a7c13b9b2d,long)> datasetGetProposalLines(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CancelProposal.GetProposalLines", "6755d8dd-78e9-4702-86a2-14fbfe23a6a8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CancelProposal.GetProposalLines", "6755d8dd-78e9-4702-86a2-14fbfe23a6a8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.d0Nuc5e0UUmNYiGdnVEFxA/NodesNotShownInESpaceTree.3dhVZ+l4AkeGohT7_iOmqA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalline1\".\"id\" o0, \"enproposalline1\".\"proposalid\" o1, \"enproposalline1\".\"approvalstatusid\" o2, \"enproposalline1\".\"companyid\" o3, \"enproposalline1\".\"supplierid\" o4, \"enproposalline1\".\"fe_contab_\" o5, \"enproposalline1\".\"ej__mes\" o6, \"enproposalline1\".\"cuenta\" o7, \"enproposalline1\".\"referencia\" o8, \"enproposalline1\".\"nombre1\" o9, \"enproposalline1\".\"nombre2\" o10, \"enproposalline1\".\"n_doc_\" o11, \"enproposalline1\".\"n_doctype\" o12, trim_scale(\"enproposalline1\".\"importeenml\"::numeric) o13, \"enproposalline1\".\"ml\" o14, trim_scale(\"enproposalline1\".\"importeenmd\"::numeric) o15, \"enproposalline1\".\"mon_\" o16, \"enproposalline1\".\"soc_\" o17, \"enproposalline1\".\"div_\" o18, \"enproposalline1\".\"lib_mayor\" o19, \"enproposalline1\".\"textocab_documento\" o20, \"enproposalline1\".\"doc_comp_\" o21, \"enproposalline1\".\"paidby\" o22, \"enproposalline1\".\"paidon\" o23, \"enproposalline1\".\"unpaidby\" o24, \"enproposalline1\".\"unpaidon\" o25, \"enproposalline1\".\"haserrors\" o26, \"enproposalline1\".\"errormessage\" o27");
fromBuilder.Append(" FROM {ProposalLine} \"enproposalline1\"");
whereBuilder.Append(" WHERE ");
if (qpprProposalId != 0) {
whereBuilder.Append("((\"enproposalline1\".\"proposalid\" = @qpprProposalId) AND (\"enproposalline1\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
} else {
whereBuilder.Append("(\"enproposalline1\".\"proposalid\" IS NULL)");
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
RL_5a265eacaa987aecd8ded8a7c13b9b2d outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CancelProposal.GetProposalLines.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5a265eacaa987aecd8ded8a7c13b9b2d _tmp = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CancelProposal.GetProposalLines.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5a265eacaa987aecd8ded8a7c13b9b2d)_tmp;
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

private static async Task<RC_577e0d18883096d0ebc3eb78e20586ee> datasetGetProposalByIdReadDbAsync(RC_577e0d18883096d0ebc3eb78e20586ee rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
return rec;
}
// Query Function "GetProposalById" ChEn+SW4+06IMYqQrk4FjQ of Action "CancelProposal"
public static async Task<(RL_539231a5cc05839b9d01250c4ae7131c,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CancelProposal.GetProposalById", "f927110a-b825-4efb-8831-8a90ae4e058d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CancelProposal.GetProposalById", "f927110a-b825-4efb-8831-8a90ae4e058d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.d0Nuc5e0UUmNYiGdnVEFxA/NodesNotShownInESpaceTree.ChEn+SW4+06IMYqQrk4FjQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposal2\".\"id\" o0, \"enproposal2\".\"name\" o1, \"enproposal2\".\"paymentdate\" o2, \"enproposal2\".\"proposaldate\" o3, \"enproposal2\".\"proposaltypeid\" o4, \"enproposal2\".\"bankid\" o5, \"enproposal2\".\"proposalstatusid\" o6, \"enproposal2\".\"fileid\" o7, \"enproposal2\".\"totalproposallines\" o8, trim_scale(\"enproposal2\".\"totalvalueml\"::numeric) o9, trim_scale(\"enproposal2\".\"totalvaluemd\"::numeric) o10, \"enproposal2\".\"currencyid\" o11, \"enproposal2\".\"regionid\" o12, \"enproposal2\".\"createdby\" o13, \"enproposal2\".\"createdon\" o14, \"enproposal2\".\"lastupdatedon\" o15, \"enproposal2\".\"maxdatepaymentchanges\" o16, \"enproposal2\".\"assignedtoid\" o17, \"enproposalapproval2\".\"id\" o18, \"enproposalapproval2\".\"proposalid\" o19, \"enproposalapproval2\".\"processtypecode\" o20, \"enproposalapproval2\".\"approvalprocessversion\" o21, \"enproposalapproval2\".\"currentlevel_deprec\" o22, \"enproposalapproval2\".\"maxlevel_deprec\" o23, \"enproposalapproval2\".\"startedon\" o24, \"enproposalapproval2\".\"finishedon\" o25");
fromBuilder.Append(" FROM ({Proposal} \"enproposal2\" Left JOIN {ProposalApproval} \"enproposalapproval2\" ON (\"enproposal2\".\"id\" = \"enproposalapproval2\".\"proposalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal2\".\"id\" = @qpprProposal_Id) AND (\"enproposal2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal2\".\"id\" IS NULL)");
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
RL_539231a5cc05839b9d01250c4ae7131c outParamList = new RL_539231a5cc05839b9d01250c4ae7131c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CancelProposal.GetProposalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_539231a5cc05839b9d01250c4ae7131c _tmp = new RL_539231a5cc05839b9d01250c4ae7131c();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CancelProposal.GetProposalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_539231a5cc05839b9d01250c4ae7131c)_tmp;
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
