namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimerCancelPartiallyPaidProposals : VarsBag {
public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoProposalLogAdd resProposalLogAdd =  new Actions.lcoProposalLogAdd();
public RL_88245586d5ac2ebd4048f53abef0c31b queryResGetProposalsBeingPaid_outParamList = new RL_88245586d5ac2ebd4048f53abef0c31b();
public long queryResGetProposalsBeingPaid_outParamCount = 0L;

public lcvTimerCancelPartiallyPaidProposals() {
}
}
/// <summary>
/// Action <code>TimerCancelPartiallyPaidProposals</code> that represents the Service Studio action
///  <code>TimerCancelPartiallyPaidProposals</code> <p> Description: </p>
/// </summary>
public static async Task ActionTimerCancelPartiallyPaidProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimerCancelPartiallyPaidProposals localVars = new lcvTimerCancelPartiallyPaidProposals();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("TimerCancelPartiallyPaidProposals", "96223766-a94e-4d0b-9340-d819ced3cb18"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("TimerCancelPartiallyPaidProposals", "96223766-a94e-4d0b-9340-d819ced3cb18", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetProposalsBeingPaid
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalsBeingPaid_maxRecords = 0;
int datasetGetProposalsBeingPaid_startIndex = 0;(localVars.queryResGetProposalsBeingPaid_outParamList,localVars.queryResGetProposalsBeingPaid_outParamCount) = await FuncActionTimerCancelPartiallyPaidProposals.datasetGetProposalsBeingPaid(requestContext,datasetGetProposalsBeingPaid_maxRecords,datasetGetProposalsBeingPaid_startIndex,IterationMultiplicity.Single,cancellationToken);

// Has passed max date for payment?
if(((BuiltInFunction.CurrDate ()>localVars.queryResGetProposalsBeingPaid_outParamList.CurrentRec.ssENProposal.ssMaxDatePaymentChanges))) {
// Foreach GetProposalsBeingPaid.List
localVars.queryResGetProposalsBeingPaid_outParamList.StartIteration();
try {while (!((localVars.queryResGetProposalsBeingPaid_outParamList.Eof))) {
// GetProposalsBeingPaid.List.Current.Proposal.ProposalStatusId = PartiallyPaid
localVars.queryResGetProposalsBeingPaid_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId;
// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalsBeingPaid_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.resProposalCreateOrUpdate.outParamId, ssProposalStatusId = localVars.queryResGetProposalsBeingPaid_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// ProposalLogAdd
localVars.resProposalLogAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.queryResGetProposalsBeingPaid_outParamList.CurrentRec.ssENProposal.ssId,0L,BuiltInFunction.NullTextIdentifier (),((((AppUtils.GetStringResource("QTyUo3VCsUSszF5LVwtyRQ#Value.-928198894.1", "Proposal")+" ")+localVars.queryResGetProposalsBeingPaid_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("QTyUo3VCsUSszF5LVwtyRQ#Value.-1602634615.1", "being paid exceeded payment limit. Updated to Partially Paid.")),false,cancellationToken);

// SendCanceledProposalEmail
await Actions.ActionSendCanceledProposalEmail(requestContext,localVars.queryResGetProposalsBeingPaid_outParamList.CurrentRec.ssENProposal.ssId,AppUtils.GetStringResource("jk+Nvlv+gkmL_FmIBOpGVg#Value.133464492.1", "Proposal payments date limit expired! Automatically cancelled."),cancellationToken);

localVars.queryResGetProposalsBeingPaid_outParamList.Advance();
}

} finally {
localVars.queryResGetProposalsBeingPaid_outParamList.EndIteration();
}

}

} //close CreateActionActivity using block
} // try

catch (Ex_SendingEmailUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

goto RETURN_STATEMENT;

} // Catch
finally {
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionTimerCancelPartiallyPaidProposals {

// Query Function "GetProposalsBeingPaid" ahUj0tzjI0aP_buuTVFE+Q of Action "TimerCancelPartiallyPaidProposals"
public static async Task<(RL_88245586d5ac2ebd4048f53abef0c31b,long)> datasetGetProposalsBeingPaid(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerCancelPartiallyPaidProposals.GetProposalsBeingPaid", "d223156a-e3dc-4623-8ffd-bbae4d5144f9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerCancelPartiallyPaidProposals.GetProposalsBeingPaid", "d223156a-e3dc-4623-8ffd-bbae4d5144f9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Zjcilk6pC02TQNgZztPLGA/NodesNotShownInESpaceTree.ahUj0tzjI0aP_buuTVFE+Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposal6\".\"id\" o0, \"enproposal6\".\"name\" o1, \"enproposal6\".\"paymentdate\" o2, \"enproposal6\".\"proposaldate\" o3, \"enproposal6\".\"proposaltypeid\" o4, \"enproposal6\".\"bankid\" o5, \"enproposal6\".\"proposalstatusid\" o6, \"enproposal6\".\"fileid\" o7, \"enproposal6\".\"totalproposallines\" o8, trim_scale(\"enproposal6\".\"totalvalueml\"::numeric) o9, trim_scale(\"enproposal6\".\"totalvaluemd\"::numeric) o10, \"enproposal6\".\"currencyid\" o11, \"enproposal6\".\"regionid\" o12, \"enproposal6\".\"createdby\" o13, \"enproposal6\".\"createdon\" o14, \"enproposal6\".\"lastupdatedon\" o15, \"enproposal6\".\"maxdatepaymentchanges\" o16, \"enproposal6\".\"assignedtoid\" o17");
fromBuilder.Append(" FROM {Proposal} \"enproposal6\"");
whereBuilder.Append(" WHERE (\"enproposal6\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId);
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
RL_88245586d5ac2ebd4048f53abef0c31b outParamList = new RL_88245586d5ac2ebd4048f53abef0c31b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerCancelPartiallyPaidProposals.GetProposalsBeingPaid.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerCancelPartiallyPaidProposals.GetProposalsBeingPaid.List", cancellationToken: cancellationToken);
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
