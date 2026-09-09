namespace ssConectaProveedores;

public partial class Actions {
public class lcvPayUnpaySingleProposalLine : VarsBag {
public long inParami_ProposalLineId;
public bool inParami_IsPay;
public string inParami_Comment;
public byte[] inParami_Binary;
public string inParami_Filename;
/// <summary>
/// Variable <code>l_logMsg</code> that represents the Service Studio Text <code>l_logMsg</code>
///  <p>Description: </p>
/// </summary>
public string varLcl_logMsg = "";

/// <summary>
/// Variable <code>l_OldProposalStatusId</code> that represents the Service Studio
///  ProposalStatusIdentifier <code>l_OldProposalStatusId</code> <p>Description: </p>
/// </summary>
public int varLcl_OldProposalStatusId = 0;

public Actions.lcoProposalLogAdd resProposalLogAdd2 =  new Actions.lcoProposalLogAdd();
public RL_5a265eacaa987aecd8ded8a7c13b9b2d queryResGetProposalLineUnpaid_outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
public long queryResGetProposalLineUnpaid_outParamCount = 0L;

public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate2 =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoProposalCommentFileCreateOrUpdate resProposalCommentFileCreateOrUpdate =  new Actions.lcoProposalCommentFileCreateOrUpdate();
public Actions.lcoProposalLogAdd resProposalLogAdd3 =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalLogAdd resProposalLogAdd =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalLineCreateOrUpdate resProposalLineCreateOrUpdate =  new Actions.lcoProposalLineCreateOrUpdate();
public Actions.lcoGetMaxDatePaymentChanges resGetMaxDatePaymentChanges =  new Actions.lcoGetMaxDatePaymentChanges();
public RL_759d79b1f4cfae069cc62371125fee8f queryResGetProposalLineById_outParamList = new RL_759d79b1f4cfae069cc62371125fee8f();
public long queryResGetProposalLineById_outParamCount = 0L;

public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate2 =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoProposalCommentCreateOrUpdate resProposalCommentCreateOrUpdate =  new Actions.lcoProposalCommentCreateOrUpdate();
public RL_5a265eacaa987aecd8ded8a7c13b9b2d queryResGetProposalLineApproved_outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
public long queryResGetProposalLineApproved_outParamCount = 0L;

public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public lcvPayUnpaySingleProposalLine(long inParami_ProposalLineId, bool inParami_IsPay, string inParami_Comment, byte[] inParami_Binary, string inParami_Filename) {
this.inParami_ProposalLineId = inParami_ProposalLineId;
this.inParami_IsPay = inParami_IsPay;
this.inParami_Comment = inParami_Comment;
this.inParami_Binary = inParami_Binary;
this.inParami_Filename = inParami_Filename;
}
}
public class lcoPayUnpaySingleProposalLine : VarsBag {
public bool outParamo_HasProposalChangedStatus = false;

public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoPayUnpaySingleProposalLine() {
}
}
/// <summary>
/// Action <code>PayUnpaySingleProposalLine</code> that represents the Service Studio action
///  <code>PayUnpaySingleProposalLine</code> <p> Description: Action to pay or unpay ProposalLine.</p>
/// </summary>
public static async Task<(bool,ST_046fb53ebbe142526d95e87ef1ae9711Structure)> ActionPayUnpaySingleProposalLine(IRequestContext requestContext,long inParami_ProposalLineId,bool inParami_IsPay,string inParami_Comment,byte[] inParami_Binary,string inParami_Filename,CancellationToken cancellationToken) {
bool outParamo_HasProposalChangedStatus = default;
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoPayUnpaySingleProposalLine result = new lcoPayUnpaySingleProposalLine();
lcvPayUnpaySingleProposalLine localVars = new lcvPayUnpaySingleProposalLine(inParami_ProposalLineId, inParami_IsPay, inParami_Comment, inParami_Binary, inParami_Filename);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("PayUnpaySingleProposalLine", "84c5752e-e525-491e-980e-8915d23cc8c0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("PayUnpaySingleProposalLine", "84c5752e-e525-491e-980e-8915d23cc8c0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalLineById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLineById_maxRecords = 1;
if (datasetGetProposalLineById_maxRecords < 1) datasetGetProposalLineById_maxRecords = 1;
int datasetGetProposalLineById_startIndex = 0;(localVars.queryResGetProposalLineById_outParamList,localVars.queryResGetProposalLineById_outParamCount) = await FuncActionPayUnpaySingleProposalLine.datasetGetProposalLineById(requestContext,datasetGetProposalLineById_maxRecords,datasetGetProposalLineById_startIndex,IterationMultiplicity.Never,localVars.inParami_ProposalLineId,cancellationToken);

// l_OldProposalStatusId = GetProposalLineById.List.Current.Proposal.ProposalStatusId
localVars.varLcl_OldProposalStatusId=localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId;
// Is Already Paid or (Has passed date allowed)?
if(((((localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("WSrbHwGzvEKPytCj7doVWw"))).ssId)||(localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssAssignedToId!=BuiltInFunction.GetUserId ()))||(((localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssMaxDatePaymentChanges!=BuiltInFunction.NullDate ())) ? ((BuiltInFunction.CurrDate ()>localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssMaxDatePaymentChanges)) : (false))))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "This proposal line cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("l4DJJXPMHUOn3RKexFcLFg#Value.-1166288890.1", "This proposal line cannot be updated!");
} else {
if((localVars.inParami_IsPay)) {
// Paid
// GetProposalLineById.List.Current.ProposalLine.ApprovalStatusId = Paid
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("WSrbHwGzvEKPytCj7doVWw"))).ssId;

// GetProposalLineById.List.Current.ProposalLine.PaidBy = GetUserId
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssPaidBy = BuiltInFunction.GetUserId ();

// GetProposalLineById.List.Current.ProposalLine.PaidOn = CurrDateTime
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssPaidOn = BuiltInFunction.CurrDateTime ();
} else {
// Unpaid
// GetProposalLineById.List.Current.ProposalLine.ApprovalStatusId = NotPaid
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bkD8ux0JT02InXZZfkOUsA"))).ssId;

// GetProposalLineById.List.Current.ProposalLine.UnpaidBy = GetUserId
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssUnpaidBy = BuiltInFunction.GetUserId ();

// GetProposalLineById.List.Current.ProposalLine.UnpaidOn = CurrDateTime
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssUnpaidOn = BuiltInFunction.CurrDateTime ();
// ProposalCommentCreateOrUpdate
localVars.resProposalCommentCreateOrUpdate.outParamId = await Actions.ActionProposalCommentCreateOrUpdate(requestContext,new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("Yb_2rORMO0CiONuueCSezA"))).ssId, ssProposalId = localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssId, ssProposalLineId = localVars.inParami_ProposalLineId, ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = localVars.inParami_Comment },cancellationToken);

if((!(BinaryContentUtils.AreBothBinariesNull(localVars.inParami_Binary, BuiltInFunction.NullBinary ())))) {
// ProposalCommentFileCreateOrUpdate
localVars.resProposalCommentFileCreateOrUpdate.outParamId = await Actions.ActionProposalCommentFileCreateOrUpdate(requestContext,new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentId = localVars.resProposalCommentCreateOrUpdate.outParamId, ssFilename = localVars.inParami_Filename, ssBinary = localVars.inParami_Binary },cancellationToken);

}

}

// ProposalLineCreateOrUpdate
localVars.resProposalLineCreateOrUpdate.outParamId = await Actions.ActionProposalLineCreateOrUpdate(requestContext,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine,cancellationToken);

// ProposalLogAdd
localVars.resProposalLogAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssId,localVars.inParami_ProposalLineId,BuiltInFunction.GetUserId (),((((localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposalLine.ssN_DocType+" ")+((localVars.inParami_IsPay) ? (AppUtils.GetStringResource("Ev6DSbdfakuJ2D9g85yRxw#Value.3433164.1", "paid")) : (AppUtils.GetStringResource("Ev6DSbdfakuJ2D9g85yRxw#Value.414076780.1", "not paid with the following comment:"))))+" ")+localVars.inParami_Comment),false,cancellationToken);

// Is Approved?
if(((localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId==(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId))) {
// GetMaxDatePaymentChanges
localVars.resGetMaxDatePaymentChanges.outParamo_MaxDate = await Actions.ActionGetMaxDatePaymentChanges(requestContext,cancellationToken);

// Proposal Being paid
// GetProposalLineById.List.Current.Proposal.ProposalStatusId = BeingPaid
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId;

// GetProposalLineById.List.Current.Proposal.MaxDatePaymentChanges = GetMaxDatePaymentChanges.o_MaxDate
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssMaxDatePaymentChanges = localVars.resGetMaxDatePaymentChanges.outParamo_MaxDate;
// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.resProposalCreateOrUpdate.outParamId, ssProposalStatusId = localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// SendPaymentStatusUpdate
await Actions.ActionSendPaymentStatusUpdate(requestContext,localVars.resProposalCreateOrUpdate.outParamId,localVars.varLcl_OldProposalStatusId,false,cancellationToken);

// ProposalLogAdd2
localVars.resProposalLogAdd2.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.GetUserId (),((((AppUtils.GetStringResource("1Wl_5ZuuaUiEoth802NisA#Value.-998289193.1", "Updated proposal")+" ")+localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("1Wl_5ZuuaUiEoth802NisA#Value.1408582942.1", "to the state Being Paid.")),false,cancellationToken);

// o_HasProposalChangedStatus = True
result.outParamo_HasProposalChangedStatus=true;
} else {
// Is already Being Paid or Partially Paid?
if((!(((localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId==(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId)||(localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId==(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId))))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Proposal cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("5sm3bU3kg0eOCVVzSCpgLg#Value.1765530164.1", "Proposal cannot be updated!");
goto RETURN_STATEMENT;

}

}

// Query datasetGetProposalLineApproved
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLineApproved_maxRecords = 1;
if (datasetGetProposalLineApproved_maxRecords < 1) datasetGetProposalLineApproved_maxRecords = 1;
int datasetGetProposalLineApproved_startIndex = 0;(localVars.queryResGetProposalLineApproved_outParamList,localVars.queryResGetProposalLineApproved_outParamCount) = await FuncActionPayUnpaySingleProposalLine.datasetGetProposalLineApproved(requestContext,datasetGetProposalLineApproved_maxRecords,datasetGetProposalLineApproved_startIndex,IterationMultiplicity.Never,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssId,cancellationToken);

// All paid or unpaid?
if((localVars.queryResGetProposalLineApproved_outParamList.Empty)) {
// Query datasetGetProposalLineUnpaid
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLineUnpaid_maxRecords = 1;
if (datasetGetProposalLineUnpaid_maxRecords < 1) datasetGetProposalLineUnpaid_maxRecords = 1;
int datasetGetProposalLineUnpaid_startIndex = 0;(localVars.queryResGetProposalLineUnpaid_outParamList,localVars.queryResGetProposalLineUnpaid_outParamCount) = await FuncActionPayUnpaySingleProposalLine.datasetGetProposalLineUnpaid(requestContext,datasetGetProposalLineUnpaid_maxRecords,datasetGetProposalLineUnpaid_startIndex,IterationMultiplicity.Never,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssId,cancellationToken);

// Any unpaid?
if(((!localVars.queryResGetProposalLineUnpaid_outParamList.Empty))) {
// Proposal Partially Paid
// GetProposalLineById.List.Current.Proposal.ProposalStatusId = PartiallyPaid
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId;

// l_logMsg = "Updated proposal" + " " + GetProposalLineById.List.Current.Proposal.Name + " " + "to the state Partially Paid."
localVars.varLcl_logMsg=((((AppUtils.GetStringResource("URSzCaLujUuGRU+c25hwOg#Value.-998289193.1", "Updated proposal")+" ")+localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("URSzCaLujUuGRU+c25hwOg#Value.-843157139.1", "to the state Partially Paid."));
} else {
// Proposal Paid
// GetProposalLineById.List.Current.Proposal.ProposalStatusId = Paid
localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId;

// l_logMsg = "Updated proposal" + " " + GetProposalLineById.List.Current.Proposal.Name + " " + "to the state Paid."
localVars.varLcl_logMsg=((((AppUtils.GetStringResource("m6x5LRhuTkWjIGHimXWtSw#Value.-998289193.1", "Updated proposal")+" ")+localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+AppUtils.GetStringResource("m6x5LRhuTkWjIGHimXWtSw#Value.-1251398241.1", "to the state Paid."));
}

// ProposalCreateOrUpdate2
localVars.resProposalCreateOrUpdate2.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate2
localVars.resProposalStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssId, ssProposalStatusId = localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// SendPaymentStatusUpdate2
await Actions.ActionSendPaymentStatusUpdate(requestContext,localVars.resProposalCreateOrUpdate2.outParamId,localVars.varLcl_OldProposalStatusId,(localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssProposalStatusId==(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId),cancellationToken);

// ProposalLogAdd3
localVars.resProposalLogAdd3.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.queryResGetProposalLineById_outParamList.CurrentRec.ssENProposal.ssId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.GetUserId (),localVars.varLcl_logMsg,false,cancellationToken);

// o_HasProposalChangedStatus = True
result.outParamo_HasProposalChangedStatus=true;
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_HasProposalChangedStatus = result.outParamo_HasProposalChangedStatus;
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_HasProposalChangedStatus,outParamo_Output);
}

public static class FuncActionPayUnpaySingleProposalLine {

// Query Function "GetProposalLineUnpaid" MXvgIFIEKki+LrRJFicxoQ of Action "PayUnpaySingleProposalLine"
public static async Task<(RL_5a265eacaa987aecd8ded8a7c13b9b2d,long)> datasetGetProposalLineUnpaid(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("PayUnpaySingleProposalLine.GetProposalLineUnpaid", "20e07b31-0452-482a-be2e-b449162731a1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("PayUnpaySingleProposalLine.GetProposalLineUnpaid", "20e07b31-0452-482a-be2e-b449162731a1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LnXFhCXlHkmYDokV0jzIwA/NodesNotShownInESpaceTree.MXvgIFIEKki+LrRJFicxoQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {ProposalLine} \"enproposalline3\"");
whereBuilder.Append(" WHERE ");
if (qpprProposalId != 0) {
whereBuilder.Append("((\"enproposalline3\".\"proposalid\" = @qpprProposalId) AND (\"enproposalline3\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
} else {
whereBuilder.Append("(\"enproposalline3\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enproposalline3\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bkD8ux0JT02InXZZfkOUsA"))).ssId);
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
RL_5a265eacaa987aecd8ded8a7c13b9b2d outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query PayUnpaySingleProposalLine.GetProposalLineUnpaid.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query PayUnpaySingleProposalLine.GetProposalLineUnpaid.List", cancellationToken: cancellationToken);
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

private static async Task<RC_05f5be3a1430a1bea3f80a8be6d08c9b> datasetGetProposalLineByIdReadDbAsync(RC_05f5be3a1430a1bea3f80a8be6d08c9b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLineById" S0wFjJMKxk+BGxQDh2YqSw of Action "PayUnpaySingleProposalLine"
public static async Task<(RL_759d79b1f4cfae069cc62371125fee8f,long)> datasetGetProposalLineById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalLine_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("PayUnpaySingleProposalLine.GetProposalLineById", "8c054c4b-0a93-4fc6-811b-140387662a4b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("PayUnpaySingleProposalLine.GetProposalLineById", "8c054c4b-0a93-4fc6-811b-140387662a4b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LnXFhCXlHkmYDokV0jzIwA/NodesNotShownInESpaceTree.S0wFjJMKxk+BGxQDh2YqSw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposal4\".\"id\" o0, \"enproposal4\".\"name\" o1, \"enproposal4\".\"paymentdate\" o2, \"enproposal4\".\"proposaldate\" o3, \"enproposal4\".\"proposaltypeid\" o4, \"enproposal4\".\"bankid\" o5, \"enproposal4\".\"proposalstatusid\" o6, \"enproposal4\".\"fileid\" o7, \"enproposal4\".\"totalproposallines\" o8, trim_scale(\"enproposal4\".\"totalvalueml\"::numeric) o9, trim_scale(\"enproposal4\".\"totalvaluemd\"::numeric) o10, \"enproposal4\".\"currencyid\" o11, \"enproposal4\".\"regionid\" o12, \"enproposal4\".\"createdby\" o13, \"enproposal4\".\"createdon\" o14, \"enproposal4\".\"lastupdatedon\" o15, \"enproposal4\".\"maxdatepaymentchanges\" o16, \"enproposal4\".\"assignedtoid\" o17, \"enproposalline4\".\"id\" o18, \"enproposalline4\".\"proposalid\" o19, \"enproposalline4\".\"approvalstatusid\" o20, \"enproposalline4\".\"companyid\" o21, \"enproposalline4\".\"supplierid\" o22, \"enproposalline4\".\"fe_contab_\" o23, \"enproposalline4\".\"ej__mes\" o24, \"enproposalline4\".\"cuenta\" o25, \"enproposalline4\".\"referencia\" o26, \"enproposalline4\".\"nombre1\" o27, \"enproposalline4\".\"nombre2\" o28, \"enproposalline4\".\"n_doc_\" o29, \"enproposalline4\".\"n_doctype\" o30, trim_scale(\"enproposalline4\".\"importeenml\"::numeric) o31, \"enproposalline4\".\"ml\" o32, trim_scale(\"enproposalline4\".\"importeenmd\"::numeric) o33, \"enproposalline4\".\"mon_\" o34, \"enproposalline4\".\"soc_\" o35, \"enproposalline4\".\"div_\" o36, \"enproposalline4\".\"lib_mayor\" o37, \"enproposalline4\".\"textocab_documento\" o38, \"enproposalline4\".\"doc_comp_\" o39, \"enproposalline4\".\"paidby\" o40, \"enproposalline4\".\"paidon\" o41, \"enproposalline4\".\"unpaidby\" o42, \"enproposalline4\".\"unpaidon\" o43, \"enproposalline4\".\"haserrors\" o44, \"enproposalline4\".\"errormessage\" o45");
fromBuilder.Append(" FROM ({ProposalLine} \"enproposalline4\" Left JOIN {Proposal} \"enproposal4\" ON (\"enproposalline4\".\"proposalid\" = \"enproposal4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalLine_Id != 0) {
whereBuilder.Append("((\"enproposalline4\".\"id\" = @qpprProposalLine_Id) AND (\"enproposalline4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLine_Id", DbType.Int64, qpprProposalLine_Id);
} else {
whereBuilder.Append("(\"enproposalline4\".\"id\" IS NULL)");
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
RL_759d79b1f4cfae069cc62371125fee8f outParamList = new RL_759d79b1f4cfae069cc62371125fee8f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLineByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query PayUnpaySingleProposalLine.GetProposalLineById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_759d79b1f4cfae069cc62371125fee8f _tmp = new RL_759d79b1f4cfae069cc62371125fee8f();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLineByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query PayUnpaySingleProposalLine.GetProposalLineById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_759d79b1f4cfae069cc62371125fee8f)_tmp;
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

// Query Function "GetProposalLineApproved" uOFO2dOuoU2TZlQKicnBGQ of Action "PayUnpaySingleProposalLine"
public static async Task<(RL_5a265eacaa987aecd8ded8a7c13b9b2d,long)> datasetGetProposalLineApproved(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("PayUnpaySingleProposalLine.GetProposalLineApproved", "d94ee1b8-aed3-4da1-9366-540a89c9c119");
using var queryActivity = activitySource.CreateAggregateQueryActivity("PayUnpaySingleProposalLine.GetProposalLineApproved", "d94ee1b8-aed3-4da1-9366-540a89c9c119", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LnXFhCXlHkmYDokV0jzIwA/NodesNotShownInESpaceTree.uOFO2dOuoU2TZlQKicnBGQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {ProposalLine} \"enproposalline5\"");
whereBuilder.Append(" WHERE ");
if (qpprProposalId != 0) {
whereBuilder.Append("((\"enproposalline5\".\"proposalid\" = @qpprProposalId) AND (\"enproposalline5\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
} else {
whereBuilder.Append("(\"enproposalline5\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enproposalline5\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
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
RL_5a265eacaa987aecd8ded8a7c13b9b2d outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query PayUnpaySingleProposalLine.GetProposalLineApproved.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query PayUnpaySingleProposalLine.GetProposalLineApproved.List", cancellationToken: cancellationToken);
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



}


}
