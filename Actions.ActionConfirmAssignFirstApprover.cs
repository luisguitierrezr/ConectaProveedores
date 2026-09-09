namespace ssConectaProveedores;

public partial class Actions {
public class lcvConfirmAssignFirstApprover : VarsBag {
public long inParami_InvoiceId;
public string inParami_UserId;
public string inParami_GetUserId;
public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserById_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserById_outParamCount = 0L;

public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetFirstInvoiceApprovalLevel_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetFirstInvoiceApprovalLevel_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution2 =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd2 =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd3 =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoGetUserRole resGetUserRole =  new Actions.lcoGetUserRole();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public lcvConfirmAssignFirstApprover(long inParami_InvoiceId, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoConfirmAssignFirstApprover : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoConfirmAssignFirstApprover() {
}
}
/// <summary>
/// Action <code>ConfirmAssignFirstApprover</code> that represents the Service Studio action
///  <code>ConfirmAssignFirstApprover</code> <p> Description: ConfirmAssignFirstApprover</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionConfirmAssignFirstApprover(IRequestContext requestContext,long inParami_InvoiceId,string inParami_UserId,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoConfirmAssignFirstApprover result = new lcoConfirmAssignFirstApprover();
lcvConfirmAssignFirstApprover localVars = new lcvConfirmAssignFirstApprover(inParami_InvoiceId, inParami_UserId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ConfirmAssignFirstApprover", "b9f85c50-5bbc-4f7b-bcb6-51ece5423bac"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ConfirmAssignFirstApprover", "b9f85c50-5bbc-4f7b-bcb6-51ece5423bac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetUserRole
localVars.resGetUserRole.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,localVars.inParami_UserId,3,true,false,cancellationToken);

// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionConfirmAssignFirstApprover.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// Query datasetGetFirstInvoiceApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFirstInvoiceApprovalLevel_maxRecords = 1;
if (datasetGetFirstInvoiceApprovalLevel_maxRecords < 1) datasetGetFirstInvoiceApprovalLevel_maxRecords = 1;
int datasetGetFirstInvoiceApprovalLevel_startIndex = 0;(localVars.queryResGetFirstInvoiceApprovalLevel_outParamList,localVars.queryResGetFirstInvoiceApprovalLevel_outParamCount) = await FuncActionConfirmAssignFirstApprover.datasetGetFirstInvoiceApprovalLevel(requestContext,datasetGetFirstInvoiceApprovalLevel_maxRecords,datasetGetFirstInvoiceApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// GetFirstInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovalStatusId = Assigned
localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId;

// GetFirstInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedBy = If
localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetFirstInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetFirstInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel = GetFirstInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel + 1
localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel = (localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel+1);

// GetFirstInvoiceApprovalLevel.List.Current.Invoice.InvoiceStatusId = InApproval_UserArea
localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId;

// GetFirstInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.AssignedTo = If
localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo = (((localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));
// InvoiceApprovalLevelCreateOrUpdate2
localVars.resInvoiceApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// HasActiveSubstitution2
(localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.inParami_UserId,cancellationToken);

// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceApprovalId = localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssId, ssLevelNumber = (localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel+1), ssAssignedTo = (((localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId) : (localVars.inParami_UserId)), ssApplicationRoleId = localVars.resGetUserRole.outParamo_ApplicationRoleId, ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId, ssIsSubstituteFor = localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor },cancellationToken);

// InvoiceApprovalCreateOrUpdate
localVars.resInvoiceApprovalCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = (((""+localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssName)+" ")+AppUtils.GetStringResource("Ej6DqKOXN0y+wJKqDY9Ejg#Value.-1634715040.1", "has been assigned as the first approver.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate
localVars.resInvoiceStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// InvoiceLogAdd2
localVars.resInvoiceLogAdd2.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = (((((((AppUtils.GetStringResource("uAfo26WNl0+MzltT7tUSpA#Value.-670115059.1", "Invoice")+" '")+localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssName)+"' ")+AppUtils.GetStringResource("uAfo26WNl0+MzltT7tUSpA#Value.-910623388.1", "has been updated to status"))+" '")+(await Functions.ssGetInvoiceStatus(requestContext,localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId,cancellationToken)).ssENInvoiceStatus.ssLabel)+"'."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// InvoiceLogAdd3
localVars.resInvoiceLogAdd3.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = ((((AppUtils.GetStringResource("+4xiJMKPRkCqNHSNM15usg#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetFirstInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("+4xiJMKPRkCqNHSNM15usg#Value.476391.1", "initiated approval process.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionConfirmAssignFirstApprover {

// Query Function "GetUserById" SNd5JT4FcEaqaCIqMmePng of Action "ConfirmAssignFirstApprover"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ConfirmAssignFirstApprover.GetUserById", "2579d748-053e-4670-aa68-222a32678f9e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ConfirmAssignFirstApprover.GetUserById", "2579d748-053e-4670-aa68-222a32678f9e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UFz4ubxbe0+8tlHs5UI7rA/NodesNotShownInESpaceTree.SNd5JT4FcEaqaCIqMmePng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser106\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser106\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser106\".\"id\" = @qpusId) AND (\"enuser106\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser106\".\"id\" IS NULL)");
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ConfirmAssignFirstApprover.GetUserById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ConfirmAssignFirstApprover.GetUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetFirstInvoiceApprovalLevelReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFirstInvoiceApprovalLevel" UfGvNqoa10u7RI8Xohmz8A of Action "ConfirmAssignFirstApprover"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetFirstInvoiceApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ConfirmAssignFirstApprover.GetFirstInvoiceApprovalLevel", "36aff151-1aaa-4bd7-bb44-8f17a219b3f0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ConfirmAssignFirstApprover.GetFirstInvoiceApprovalLevel", "36aff151-1aaa-4bd7-bb44-8f17a219b3f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UFz4ubxbe0+8tlHs5UI7rA/NodesNotShownInESpaceTree.UfGvNqoa10u7RI8Xohmz8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice54\".\"id\" o0, \"eninvoice54\".\"name\" o1, \"eninvoice54\".\"requisitionid\" o2, \"eninvoice54\".\"folioid\" o3, \"eninvoice54\".\"ordermainid\" o4, \"eninvoice54\".\"cfditypeid\" o5, trim_scale(\"eninvoice54\".\"totalamount\"::numeric) o6, \"eninvoice54\".\"currency\" o7, \"eninvoice54\".\"invoicestatusid\" o8, \"eninvoice54\".\"accountingdatetime\" o9, \"eninvoice54\".\"paymentdatetime\" o10, \"eninvoice54\".\"createdon\" o11, \"eninvoice54\".\"createdby\" o12, \"eninvoice54\".\"updatedon\" o13, \"eninvoice54\".\"updatedby\" o14, \"eninvoice54\".\"submittedon\" o15, \"eninvoice54\".\"isnewversion\" o16, \"eninvoice54\".\"id_poliza\" o17, \"eninvoice54\".\"id_poliza_sap\" o18, \"eninvoice54\".\"doc51\" o19, \"eninvoice54\".\"accountingerror\" o20, \"eninvoice54\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice54\".\"amortization\"::numeric) o22, \"eninvoice54\".\"creditnoteinvoiceid\" o23, \"eninvoiceapproval17\".\"id\" o24, \"eninvoiceapproval17\".\"invoiceid\" o25, \"eninvoiceapproval17\".\"aprovalprocessid\" o26, \"eninvoiceapproval17\".\"processtypecode\" o27, \"eninvoiceapproval17\".\"approvalprocessversion\" o28, \"eninvoiceapproval17\".\"currentlevel\" o29, \"eninvoiceapproval17\".\"maxlevel\" o30, \"eninvoiceapproval17\".\"startedon\" o31, \"eninvoiceapproval17\".\"finishedon\" o32, \"eninvoiceapproval17\".\"hasstartedaccounting\" o33, \"eninvoiceapprovallevel18\".\"id\" o34, \"eninvoiceapprovallevel18\".\"invoiceapprovalid\" o35, \"eninvoiceapprovallevel18\".\"levelnumber\" o36, \"eninvoiceapprovallevel18\".\"assignedto\" o37, \"eninvoiceapprovallevel18\".\"applicationroleid\" o38, \"eninvoiceapprovallevel18\".\"entrajobtitle\" o39, \"eninvoiceapprovallevel18\".\"departmentid\" o40, \"eninvoiceapprovallevel18\".\"managementid\" o41, \"eninvoiceapprovallevel18\".\"subdirectionid\" o42, \"eninvoiceapprovallevel18\".\"entraroleid\" o43, \"eninvoiceapprovallevel18\".\"approvalstatusid\" o44, \"eninvoiceapprovallevel18\".\"canbefirstapprover\" o45, \"eninvoiceapprovallevel18\".\"selectsnextapprover\" o46, \"eninvoiceapprovallevel18\".\"selectsfirstapprover\" o47, \"eninvoiceapprovallevel18\".\"isaccounting\" o48, \"eninvoiceapprovallevel18\".\"isstartaccounting\" o49, \"eninvoiceapprovallevel18\".\"approvedby\" o50, \"eninvoiceapprovallevel18\".\"approvedon\" o51, \"eninvoiceapprovallevel18\".\"requesttomodifyby\" o52, \"eninvoiceapprovallevel18\".\"requesttomodifyon\" o53, \"eninvoiceapprovallevel18\".\"canceledby\" o54, \"eninvoiceapprovallevel18\".\"canceledon\" o55, \"eninvoiceapprovallevel18\".\"needscontract_deprec\" o56, \"eninvoiceapprovallevel18\".\"isreassigned\" o57, \"eninvoiceapprovallevel18\".\"issubstitutefor\" o58");
fromBuilder.Append(" FROM (({InvoiceApprovalLevel} \"eninvoiceapprovallevel18\" Left JOIN {InvoiceApproval} \"eninvoiceapproval17\" ON (\"eninvoiceapprovallevel18\".\"invoiceapprovalid\" = \"eninvoiceapproval17\".\"id\"))  Left JOIN {Invoice} \"eninvoice54\" ON (\"eninvoiceapproval17\".\"invoiceid\" = \"eninvoice54\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoiceapprovallevel18\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId);
whereBuilder.Append(") AND ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval17\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval17\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval17\".\"invoiceid\" IS NULL)");
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
RL_e8a2bfdbad62aa404e80d55d80faa387 outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFirstInvoiceApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ConfirmAssignFirstApprover.GetFirstInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetFirstInvoiceApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ConfirmAssignFirstApprover.GetFirstInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8a2bfdbad62aa404e80d55d80faa387)_tmp;
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
