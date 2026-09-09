namespace ssConectaProveedores;

public partial class Actions {
public class lcvClaimProposalTreasury : VarsBag {
public long inParami_ProposalId;
public string inParami_UserId;
public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoGetMaxDatePaymentChanges resGetMaxDatePaymentChanges =  new Actions.lcoGetMaxDatePaymentChanges();
public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserById_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserById_outParamCount = 0L;

public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate2 =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoProposalLogAdd resProposalLogAddProposalSigned =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalLogAdd resProposalLogAdd =  new Actions.lcoProposalLogAdd();
public RL_88245586d5ac2ebd4048f53abef0c31b queryResGetProposalById_outParamList = new RL_88245586d5ac2ebd4048f53abef0c31b();
public long queryResGetProposalById_outParamCount = 0L;

public lcvClaimProposalTreasury(long inParami_ProposalId, string inParami_UserId) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_UserId = inParami_UserId;
}
}
public class lcoClaimProposalTreasury : VarsBag {
public bool outParamo_IsSuccess = false;

public lcoClaimProposalTreasury() {
}
}
/// <summary>
/// Action <code>ClaimProposalTreasury</code> that represents the Service Studio action
///  <code>ClaimProposalTreasury</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionClaimProposalTreasury(IRequestContext requestContext,long inParami_ProposalId,string inParami_UserId,CancellationToken cancellationToken) {
bool outParamo_IsSuccess = default;
lcoClaimProposalTreasury result = new lcoClaimProposalTreasury();
lcvClaimProposalTreasury localVars = new lcvClaimProposalTreasury(inParami_ProposalId, inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ClaimProposalTreasury", "6511c909-2843-402f-99db-0b4e12a70403"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ClaimProposalTreasury", "6511c909-2843-402f-99db-0b4e12a70403", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalById_maxRecords = 1;
if (datasetGetProposalById_maxRecords < 1) datasetGetProposalById_maxRecords = 1;
int datasetGetProposalById_startIndex = 0;(localVars.queryResGetProposalById_outParamList,localVars.queryResGetProposalById_outParamCount) = await FuncActionClaimProposalTreasury.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Never,localVars.inParami_ProposalId,cancellationToken);

// empty?
if((!(localVars.queryResGetProposalById_outParamList.Empty))) {
// GetProposalById.List.Current.Proposal.AssignedToId = i_UserId
localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssAssignedToId = localVars.inParami_UserId;
if(((localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssMaxDatePaymentChanges==BuiltInFunction.NullDate ()))) {
// GetMaxDatePaymentChanges
localVars.resGetMaxDatePaymentChanges.outParamo_MaxDate = await Actions.ActionGetMaxDatePaymentChanges(requestContext,cancellationToken);

// GetProposalById.List.Current.Proposal.MaxDatePaymentChanges = GetMaxDatePaymentChanges.o_MaxDate
localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssMaxDatePaymentChanges = localVars.resGetMaxDatePaymentChanges.outParamo_MaxDate;

// GetProposalById.List.Current.Proposal.ProposalStatusId = BeingPaid
localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId;
// ProposalCreateOrUpdate2
localVars.resProposalCreateOrUpdate2.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.inParami_ProposalId, ssProposalStatusId = localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// SendPaymentStatusUpdate
await Actions.ActionSendPaymentStatusUpdate(requestContext,localVars.inParami_ProposalId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId,false,cancellationToken);

} else {
// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal,cancellationToken);

}

// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 0;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionClaimProposalTreasury.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// ProposalLogAddProposalSigned
localVars.resProposalLogAddProposalSigned.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,0L,localVars.inParami_UserId,(AppUtils.GetStringResource("Qk9gOw6t10KXWS9XGkYs8Q#Value.1542616073.1", "Proposal Signed to:")+localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssName),false,cancellationToken);

// ProposalLogAdd
localVars.resProposalLogAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.inParami_ProposalId,0L,localVars.inParami_UserId,((((AppUtils.GetStringResource("KkmyLO+sxkuK0TRzM1VhXg#Value.426991543.1", "Claimed proposal")+" ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName)+".")+AppUtils.GetStringResource("KkmyLO+sxkuK0TRzM1VhXg#Value.-1431265975.1", "Status updated to 'Being Paid'.")),false,cancellationToken);

// o_IsSuccess = True
result.outParamo_IsSuccess=true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_IsSuccess = result.outParamo_IsSuccess;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsSuccess;
}

public static class FuncActionClaimProposalTreasury {

// Query Function "GetUserById" _gWpgH6xcUyaDNr98SWS5g of Action "ClaimProposalTreasury"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClaimProposalTreasury.GetUserById", "80a905fe-b17e-4c71-9a0c-dafdf12592e6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClaimProposalTreasury.GetUserById", "80a905fe-b17e-4c71-9a0c-dafdf12592e6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CckRZUMoL0CZ2wtOEqcEAw/NodesNotShownInESpaceTree._gWpgH6xcUyaDNr98SWS5g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser66\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser66\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser66\".\"id\" = @qpusId) AND (\"enuser66\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser66\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuser66\".\"name\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClaimProposalTreasury.GetUserById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClaimProposalTreasury.GetUserById.List", cancellationToken: cancellationToken);
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

// Query Function "GetProposalById" m8FgwcNDo06z2e4MQZFYoQ of Action "ClaimProposalTreasury"
public static async Task<(RL_88245586d5ac2ebd4048f53abef0c31b,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClaimProposalTreasury.GetProposalById", "c160c19b-43c3-4ea3-b3d9-ee0c419158a1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClaimProposalTreasury.GetProposalById", "c160c19b-43c3-4ea3-b3d9-ee0c419158a1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CckRZUMoL0CZ2wtOEqcEAw/NodesNotShownInESpaceTree.m8FgwcNDo06z2e4MQZFYoQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposal1\".\"id\" o0, \"enproposal1\".\"name\" o1, \"enproposal1\".\"paymentdate\" o2, \"enproposal1\".\"proposaldate\" o3, \"enproposal1\".\"proposaltypeid\" o4, \"enproposal1\".\"bankid\" o5, \"enproposal1\".\"proposalstatusid\" o6, \"enproposal1\".\"fileid\" o7, \"enproposal1\".\"totalproposallines\" o8, trim_scale(\"enproposal1\".\"totalvalueml\"::numeric) o9, trim_scale(\"enproposal1\".\"totalvaluemd\"::numeric) o10, \"enproposal1\".\"currencyid\" o11, \"enproposal1\".\"regionid\" o12, \"enproposal1\".\"createdby\" o13, \"enproposal1\".\"createdon\" o14, \"enproposal1\".\"lastupdatedon\" o15, \"enproposal1\".\"maxdatepaymentchanges\" o16, \"enproposal1\".\"assignedtoid\" o17");
fromBuilder.Append(" FROM {Proposal} \"enproposal1\"");
whereBuilder.Append(" WHERE ");
if (qpprId != 0) {
whereBuilder.Append("((\"enproposal1\".\"id\" = @qpprId) AND (\"enproposal1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int64, qpprId);
} else {
whereBuilder.Append("(\"enproposal1\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (((\"enproposal1\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(") OR (\"enproposal1\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId);
whereBuilder.Append(")) OR (\"enproposal1\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append("))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClaimProposalTreasury.GetProposalById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClaimProposalTreasury.GetProposalById.List", cancellationToken: cancellationToken);
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
