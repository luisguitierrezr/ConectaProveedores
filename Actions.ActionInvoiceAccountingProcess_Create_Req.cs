namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcess_Create_Req : VarsBag {
public long inParamRequisitionId;
/// <summary>
/// Variable <code>Requisition</code> that represents the Service Studio Requisition
///  <code>Requisition</code> <p>Description: </p>
/// </summary>
public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord varLcRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();

public RL_96dd8a4e4f78e65ee5dd5a096dbe2ade queryResGetRequisitionById_outParamList = new RL_96dd8a4e4f78e65ee5dd5a096dbe2ade();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public lcvInvoiceAccountingProcess_Create_Req(long inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}
}
public class lcoInvoiceAccountingProcess_Create_Req : VarsBag {
public long outParamSupplierId = 0L;

public lcoInvoiceAccountingProcess_Create_Req() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcess_Create_Req</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcess_Create_Req</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingProcess_Create_Req(IRequestContext requestContext,long inParamRequisitionId,CancellationToken cancellationToken) {
long outParamSupplierId = default;
lcoInvoiceAccountingProcess_Create_Req result = new lcoInvoiceAccountingProcess_Create_Req();
lcvInvoiceAccountingProcess_Create_Req localVars = new lcvInvoiceAccountingProcess_Create_Req(inParamRequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcess_Create_Req", "9755ba76-fcfc-4266-b3c2-98b64a52ffb0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcess_Create_Req", "9755ba76-fcfc-4266-b3c2-98b64a52ffb0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInvoiceAccountingProcess_Create_Req.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParamRequisitionId,cancellationToken);

// SupplierId = GetRequisitionById.List.Current.Requisition.SupplierId
result.outParamSupplierId=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssSupplierId;

// Requisition = GetRequisitionById.List.Current.Requisition
localVars.varLcRequisition=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition;
// set accounting
// Requisition.RequisitionStatusId = Accounting
localVars.varLcRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("jCOIXdyYhUKLqNTv4OsxNA"))).ssId;
// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.varLcRequisition,cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParamRequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("DuGlKISb_k60IXgxKfHRPA#Value.2063792252.1", "Requisition")+" ")+localVars.varLcRequisition.ssName)+" ")+AppUtils.GetStringResource("DuGlKISb_k60IXgxKfHRPA#Value.2068068348.1", "started the accounting process.")) },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParamRequisitionId, ssRequisitionStatusId = localVars.varLcRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamSupplierId = result.outParamSupplierId;
} // inner-finally
RETURN_STATEMENT:
return outParamSupplierId;
}

public static class FuncActionInvoiceAccountingProcess_Create_Req {

private static async Task<RC_d8083705fb77c898d676210940ce11bd> datasetGetRequisitionByIdReadDbAsync(RC_d8083705fb77c898d676210940ce11bd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" jqwFZKVf+Uic5qpNLcFtFg of Action "InvoiceAccountingProcess_Create_Req"
public static async Task<(RL_96dd8a4e4f78e65ee5dd5a096dbe2ade,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_Create_Req.GetRequisitionById", "6405ac8e-5fa5-48f9-9ce6-aa4d2dc16d16");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_Create_Req.GetRequisitionById", "6405ac8e-5fa5-48f9-9ce6-aa4d2dc16d16", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.drpVl_z8ZkKzwpi2SlL_sA/NodesNotShownInESpaceTree.jqwFZKVf+Uic5qpNLcFtFg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enrequisition41\".\"id\" o11, \"enrequisition41\".\"name\" o12, \"enrequisition41\".\"counter\" o13, NULL o14, \"enrequisition41\".\"supplierid\" o15, \"enrequisition41\".\"regionid\" o16, \"enrequisition41\".\"accountingregionid\" o17, \"enrequisition41\".\"applicantid\" o18, \"enrequisition41\".\"maxdatefinishcapture\" o19, \"enrequisition41\".\"projectassetserviceid\" o20, \"enrequisition41\".\"projectassetservice\" o21, \"enrequisition41\".\"projectdescription\" o22, \"enrequisition41\".\"frequencyid\" o23, \"enrequisition41\".\"issustainability\" o24, \"enrequisition41\".\"sustainabilityid\" o25, \"enrequisition41\".\"businessvaluecategoryid\" o26, \"enrequisition41\".\"businessvaluesubcategoryid\" o27, trim_scale(\"enrequisition41\".\"totalamount\"::numeric) o28, \"enrequisition41\".\"currencyid\" o29, \"enrequisition41\".\"distributionid\" o30, \"enrequisition41\".\"costcenterid\" o31, \"enrequisition41\".\"hascontract\" o32, \"enrequisition41\".\"iscontractpending\" o33, \"enrequisition41\".\"hasdeposit\" o34, \"enrequisition41\".\"hasinsurance\" o35, \"enrequisition41\".\"hasadvancepayment\" o36, \"enrequisition41\".\"accountingservicetypeid_depr\" o37, \"enrequisition41\".\"servicedescription_deprec\" o38, \"enrequisition41\".\"invoiceusageid_deprec\" o39, \"enrequisition41\".\"serviceformatid\" o40, \"enrequisition41\".\"companyid\" o41, trim_scale(\"enrequisition41\".\"retentionrate\"::numeric) o42, trim_scale(\"enrequisition41\".\"negotiatedexchangerate\"::numeric) o43, \"enrequisition41\".\"paymentmethodid\" o44, \"enrequisition41\".\"paymenttermsid\" o45, \"enrequisition41\".\"isautomaticaccounting\" o46, \"enrequisition41\".\"createdby\" o47, \"enrequisition41\".\"createdon\" o48, \"enrequisition41\".\"updatedon\" o49, \"enrequisition41\".\"updatedby\" o50, \"enrequisition41\".\"createdbyapplicationrole\" o51, \"enrequisition41\".\"dateofcommitment\" o52, \"enrequisition41\".\"hascontractfileuploaded\" o53, \"enrequisition41\".\"hasupdateddateofcommitment\" o54, \"enrequisition41\".\"submittedon\" o55, \"enrequisition41\".\"isdonation\" o56, \"enrequisition41\".\"advwithoutinvoice\" o57, \"enrequisition41\".\"wasadvwithoutinvoice\" o58, \"enrequisition41\".\"isadvanced\" o59, \"enrequisition41\".\"documenttypeid\" o60, \"enrequisition41\".\"iscreatedbyanassistente\" o61, \"enrequisition41\".\"telceldirectionid\" o62, \"enrequisition41\".\"hasmultiupload\" o63, \"enrequisition41\".\"accountingdate\" o64, \"enrequisition41\".\"paymentoptionsid\" o65, \"enrequisition41\".\"paymentwaysid\" o66, \"enrequisition41\".\"buydocnumber\" o67, \"enrequisition41\".\"buydocposition\" o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition41\" Left JOIN {Supplier} \"ensupplier26\" ON (\"enrequisition41\".\"supplierid\" = \"ensupplier26\".\"id\"))  Left JOIN {Company} \"encompany8\" ON (\"enrequisition41\".\"companyid\" = \"encompany8\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition41\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition41\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition41\".\"id\" IS NULL)");
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
RL_96dd8a4e4f78e65ee5dd5a096dbe2ade outParamList = new RL_96dd8a4e4f78e65ee5dd5a096dbe2ade();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_Create_Req.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_96dd8a4e4f78e65ee5dd5a096dbe2ade _tmp = new RL_96dd8a4e4f78e65ee5dd5a096dbe2ade();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_Create_Req.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_96dd8a4e4f78e65ee5dd5a096dbe2ade)_tmp;
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
