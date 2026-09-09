namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceCancel : VarsBag {
public long inParami_InvoiceId;
public long inParami_InvoiceApprovalLevelId;
public string inParami_CancelReason;
public string inParami_GetUserId;
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public Actions.lcoInvoiceCommentCreateOrUpdate resInvoiceCommentCreateOrUpdate =  new Actions.lcoInvoiceCommentCreateOrUpdate();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoiceById_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public lcvInvoiceCancel(long inParami_InvoiceId, long inParami_InvoiceApprovalLevelId, string inParami_CancelReason, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_CancelReason = inParami_CancelReason;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoInvoiceCancel : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInvoiceCancel() {
}
}
/// <summary>
/// Action <code>InvoiceCancel</code> that represents the Service Studio action
///  <code>InvoiceCancel</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInvoiceCancel(IRequestContext requestContext,long inParami_InvoiceId,long inParami_InvoiceApprovalLevelId,string inParami_CancelReason,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInvoiceCancel result = new lcoInvoiceCancel();
lcvInvoiceCancel localVars = new lcvInvoiceCancel(inParami_InvoiceId, inParami_InvoiceApprovalLevelId, inParami_CancelReason, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceCancel", "cabf43bf-8d9f-4c3d-89fb-35bb9cd4dc85"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceCancel", "cabf43bf-8d9f-4c3d-89fb-35bb9cd4dc85", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvoiceCancel.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceApprovalLevelId,localVars.inParami_InvoiceId,cancellationToken);

// empty?
if((localVars.queryResGetInvoiceById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Invoice not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("nQK+m_hpwEii0t_p7PZZ3w#Value.-793651777.1", "Invoice not found!");
} else {
// status check
if((((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId)||(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("clB7Cs6DQ0ebdBjstV8soA"))).ssId))||(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId))||(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId)))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Invoice's current status does not allow a cancellation to be made!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("bICKtcn+5kykqZkdHlBN5g#Value.-1822790303.1", "Invoice's current status does not allow a cancellation to be made!");
} else {
// GetInvoiceById.List.Current.InvoiceApproval.FinishedOn = CurrDateTime
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceById.List.Current.InvoiceApprovalLevel.ApprovalStatusId = Canceled
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId;

// GetInvoiceById.List.Current.InvoiceApprovalLevel.CanceledBy = If
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssCanceledBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetInvoiceById.List.Current.InvoiceApprovalLevel.CanceledOn = CurrDateTime
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssCanceledOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = Canceled
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// InvoiceCommentCreateOrUpdate
localVars.resInvoiceCommentCreateOrUpdate.outParamId = await Actions.ActionInvoiceCommentCreateOrUpdate(requestContext,new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceApprovalLevelId = localVars.inParami_InvoiceApprovalLevelId, ssApplicationRoleId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApplicationRoleId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssMessage = localVars.inParami_CancelReason, ssIsPublic = true },cancellationToken);

// has approval?
if(((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApproval.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceApprovalCreateOrUpdate
localVars.resInvoiceApprovalCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

}

// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate
localVars.resInvoiceStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = (((((((AppUtils.GetStringResource("lKKfVB8GzkmKFsNfeSY_KQ#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("lKKfVB8GzkmKFsNfeSY_KQ#Value.666913335.1", "manually cancelled with the following comment:"))+" ")+localVars.inParami_CancelReason)+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// has approval?
if(((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApproval.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// InvEmailAll_Canceled
await Actions.ActionInvEmailAll_Canceled(requestContext,localVars.inParami_InvoiceId,localVars.inParami_CancelReason,cancellationToken);

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

public static class FuncActionInvoiceCancel {

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoiceByIdReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" 1GVy1GvUq0mY8eFfhKbs8Q of Action "InvoiceCancel"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalLevel_Id,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceCancel.GetInvoiceById", "d47265d4-d46b-49ab-98f1-e15f84a6ecf1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceCancel.GetInvoiceById", "d47265d4-d46b-49ab-98f1-e15f84a6ecf1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.v0O_yp+NPUyJ+zW7nNTchQ/NodesNotShownInESpaceTree.1GVy1GvUq0mY8eFfhKbs8Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice59\".\"id\" o0, \"eninvoice59\".\"name\" o1, \"eninvoice59\".\"requisitionid\" o2, \"eninvoice59\".\"folioid\" o3, \"eninvoice59\".\"ordermainid\" o4, \"eninvoice59\".\"cfditypeid\" o5, trim_scale(\"eninvoice59\".\"totalamount\"::numeric) o6, \"eninvoice59\".\"currency\" o7, \"eninvoice59\".\"invoicestatusid\" o8, \"eninvoice59\".\"accountingdatetime\" o9, \"eninvoice59\".\"paymentdatetime\" o10, \"eninvoice59\".\"createdon\" o11, \"eninvoice59\".\"createdby\" o12, \"eninvoice59\".\"updatedon\" o13, \"eninvoice59\".\"updatedby\" o14, \"eninvoice59\".\"submittedon\" o15, \"eninvoice59\".\"isnewversion\" o16, \"eninvoice59\".\"id_poliza\" o17, \"eninvoice59\".\"id_poliza_sap\" o18, \"eninvoice59\".\"doc51\" o19, \"eninvoice59\".\"accountingerror\" o20, \"eninvoice59\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice59\".\"amortization\"::numeric) o22, \"eninvoice59\".\"creditnoteinvoiceid\" o23, \"eninvoiceapproval19\".\"id\" o24, \"eninvoiceapproval19\".\"invoiceid\" o25, \"eninvoiceapproval19\".\"aprovalprocessid\" o26, \"eninvoiceapproval19\".\"processtypecode\" o27, \"eninvoiceapproval19\".\"approvalprocessversion\" o28, \"eninvoiceapproval19\".\"currentlevel\" o29, \"eninvoiceapproval19\".\"maxlevel\" o30, \"eninvoiceapproval19\".\"startedon\" o31, \"eninvoiceapproval19\".\"finishedon\" o32, \"eninvoiceapproval19\".\"hasstartedaccounting\" o33, \"eninvoiceapprovallevel20\".\"id\" o34, \"eninvoiceapprovallevel20\".\"invoiceapprovalid\" o35, \"eninvoiceapprovallevel20\".\"levelnumber\" o36, \"eninvoiceapprovallevel20\".\"assignedto\" o37, \"eninvoiceapprovallevel20\".\"applicationroleid\" o38, \"eninvoiceapprovallevel20\".\"entrajobtitle\" o39, \"eninvoiceapprovallevel20\".\"departmentid\" o40, \"eninvoiceapprovallevel20\".\"managementid\" o41, \"eninvoiceapprovallevel20\".\"subdirectionid\" o42, \"eninvoiceapprovallevel20\".\"entraroleid\" o43, \"eninvoiceapprovallevel20\".\"approvalstatusid\" o44, \"eninvoiceapprovallevel20\".\"canbefirstapprover\" o45, \"eninvoiceapprovallevel20\".\"selectsnextapprover\" o46, \"eninvoiceapprovallevel20\".\"selectsfirstapprover\" o47, \"eninvoiceapprovallevel20\".\"isaccounting\" o48, \"eninvoiceapprovallevel20\".\"isstartaccounting\" o49, \"eninvoiceapprovallevel20\".\"approvedby\" o50, \"eninvoiceapprovallevel20\".\"approvedon\" o51, \"eninvoiceapprovallevel20\".\"requesttomodifyby\" o52, \"eninvoiceapprovallevel20\".\"requesttomodifyon\" o53, \"eninvoiceapprovallevel20\".\"canceledby\" o54, \"eninvoiceapprovallevel20\".\"canceledon\" o55, \"eninvoiceapprovallevel20\".\"needscontract_deprec\" o56, \"eninvoiceapprovallevel20\".\"isreassigned\" o57, \"eninvoiceapprovallevel20\".\"issubstitutefor\" o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice59\" Left JOIN {InvoiceApproval} \"eninvoiceapproval19\" ON (\"eninvoice59\".\"id\" = \"eninvoiceapproval19\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel20\" ON (\"eninvoiceapproval19\".\"id\" = \"eninvoiceapprovallevel20\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice59\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice59\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice59\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpinInvoiceApprovalLevel_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalLevel_Id", DbType.Int64, qpinInvoiceApprovalLevel_Id);
if (qpinInvoiceApprovalLevel_Id != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel20\".\"id\" = @qpinInvoiceApprovalLevel_Id) AND (\"eninvoiceapprovallevel20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalLevel_Id", DbType.Int64, qpinInvoiceApprovalLevel_Id);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel20\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceCancel.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceCancel.GetInvoiceById.List", cancellationToken: cancellationToken);
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
