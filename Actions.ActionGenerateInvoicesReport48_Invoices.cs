namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateInvoicesReport48_Invoices : VarsBag {
public long inParami_RequisitionId;
public string inParami_RequisitionFrequency;
public string inParami_RequisitionProjectPeriod;
public string inParami_RequisitionProject;
public string inParami_RequisitionRegion;
public string inParami_RequisitionName;
public DateTime inParami_RequisitionCreatedOn;
public string inParami_RequisitionCebe;
public string inParami_RequisitionCeCo;
public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParami_Supplier;
public ST_4301e782f48f03168dfeb78159c19548Structure inParami_Filters;
public int inParami_OffsetUtc;
public Actions.lcoGenerateInvoicesReport48_Invoices0Line resGenerateInvoicesReport48_Invoices0Line =  new Actions.lcoGenerateInvoicesReport48_Invoices0Line();
public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoicesByRequisitionId_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoicesByRequisitionId_outParamCount = 0L;

public lcvGenerateInvoicesReport48_Invoices(long inParami_RequisitionId, string inParami_RequisitionFrequency, string inParami_RequisitionProjectPeriod, string inParami_RequisitionProject, string inParami_RequisitionRegion, string inParami_RequisitionName, DateTime inParami_RequisitionCreatedOn, string inParami_RequisitionCebe, string inParami_RequisitionCeCo, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParami_Supplier, ST_4301e782f48f03168dfeb78159c19548Structure inParami_Filters, int inParami_OffsetUtc) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionFrequency = inParami_RequisitionFrequency;
this.inParami_RequisitionProjectPeriod = inParami_RequisitionProjectPeriod;
this.inParami_RequisitionProject = inParami_RequisitionProject;
this.inParami_RequisitionRegion = inParami_RequisitionRegion;
this.inParami_RequisitionName = inParami_RequisitionName;
this.inParami_RequisitionCreatedOn = inParami_RequisitionCreatedOn;
this.inParami_RequisitionCebe = inParami_RequisitionCebe;
this.inParami_RequisitionCeCo = inParami_RequisitionCeCo;
this.inParami_Supplier = inParami_Supplier;
this.inParami_Filters = inParami_Filters;
this.inParami_OffsetUtc = inParami_OffsetUtc;
}
}
public class lcoGenerateInvoicesReport48_Invoices : VarsBag {
public RL_36f497358824531a4d0365a750b33706 outParamo_InvoicesReport48List = new RL_36f497358824531a4d0365a750b33706();

public lcoGenerateInvoicesReport48_Invoices() {
}
}
/// <summary>
/// Action <code>GenerateInvoicesReport48_Invoices</code> that represents the Service Studio action
///  <code>GenerateInvoicesReport48_Invoices</code> <p> Description
/// : GenerateInvoiceReport48_Invoices</p>
/// </summary>
public static async Task<RL_36f497358824531a4d0365a750b33706> ActionGenerateInvoicesReport48_Invoices(IRequestContext requestContext,long inParami_RequisitionId,string inParami_RequisitionFrequency,string inParami_RequisitionProjectPeriod,string inParami_RequisitionProject,string inParami_RequisitionRegion,string inParami_RequisitionName,DateTime inParami_RequisitionCreatedOn,string inParami_RequisitionCebe,string inParami_RequisitionCeCo,EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParami_Supplier,ST_4301e782f48f03168dfeb78159c19548Structure inParami_Filters,int inParami_OffsetUtc,CancellationToken cancellationToken) {
RL_36f497358824531a4d0365a750b33706 outParamo_InvoicesReport48List = default;
lcoGenerateInvoicesReport48_Invoices result = new lcoGenerateInvoicesReport48_Invoices();
lcvGenerateInvoicesReport48_Invoices localVars = new lcvGenerateInvoicesReport48_Invoices(inParami_RequisitionId, inParami_RequisitionFrequency, inParami_RequisitionProjectPeriod, inParami_RequisitionProject, inParami_RequisitionRegion, inParami_RequisitionName, inParami_RequisitionCreatedOn, inParami_RequisitionCebe, inParami_RequisitionCeCo, inParami_Supplier, inParami_Filters, inParami_OffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateInvoicesReport48_Invoices", "651fd9b2-c133-464b-9f5a-cf90c92fe553"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateInvoicesReport48_Invoices", "651fd9b2-c133-464b-9f5a-cf90c92fe553", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByRequisitionId_maxRecords = 0;
int datasetGetInvoicesByRequisitionId_startIndex = 0;(localVars.queryResGetInvoicesByRequisitionId_outParamList,localVars.queryResGetInvoicesByRequisitionId_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices.datasetGetInvoicesByRequisitionId(requestContext,datasetGetInvoicesByRequisitionId_maxRecords,datasetGetInvoicesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParami_Filters.ssDateFrom,localVars.inParami_Filters.ssDateTo,localVars.inParami_Filters.ssInvoiceName,localVars.inParami_Filters.ssInvoiceStatusId,localVars.inParami_OffsetUtc,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetInvoicesByRequisitionId.List
localVars.queryResGetInvoicesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoicesByRequisitionId_outParamList.Eof))) {
// GenerateInvoicesReport48_Invoices0Line
localVars.resGenerateInvoicesReport48_Invoices0Line.outParamo_InvoicesReport48 = await Actions.ActionGenerateInvoicesReport48_Invoices0Line(requestContext,localVars.queryResGetInvoicesByRequisitionId_outParamList.CurrentRec.ssENInvoice.ssId,localVars.inParami_RequisitionFrequency,localVars.inParami_RequisitionProjectPeriod,localVars.inParami_RequisitionProject,localVars.inParami_RequisitionName,localVars.inParami_RequisitionCreatedOn,localVars.inParami_RequisitionCebe,localVars.inParami_RequisitionCeCo,localVars.inParami_Supplier,localVars.inParami_OffsetUtc,localVars.inParami_RequisitionRegion,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_InvoicesReport48List,localVars.resGenerateInvoicesReport48_Invoices0Line.outParamo_InvoicesReport48,cancellationToken);

localVars.queryResGetInvoicesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoicesByRequisitionId_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_InvoicesReport48List = result.outParamo_InvoicesReport48List;
} // inner-finally
RETURN_STATEMENT:
return outParamo_InvoicesReport48List;
}

public static class FuncActionGenerateInvoicesReport48_Invoices {

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoicesByRequisitionIdReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByRequisitionId" 0SZ7ygbtJ0mIqzIaohf9lw of Action "GenerateInvoicesReport48_Invoices"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaDateFrom,DateTime qpdaDateTo,string qpteInvoiceName,int qpinInvoice_InvoiceStatusId,int qpini_OffsetUtc,long qpreInvoice_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices.GetInvoicesByRequisitionId", "ca7b26d1-ed06-4927-88ab-321aa217fd97");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices.GetInvoicesByRequisitionId", "ca7b26d1-ed06-4927-88ab-321aa217fd97", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.stkfZTPBS0afWs+QyS_lUw/NodesNotShownInESpaceTree.0SZ7ygbtJ0mIqzIaohf9lw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice27\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice27\" Left JOIN {InvoiceApproval} \"eninvoiceapproval11\" ON (\"eninvoice27\".\"id\" = \"eninvoiceapproval11\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel12\" ON (\"eninvoiceapproval11\".\"id\" = \"eninvoiceapprovallevel12\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreInvoice_RequisitionId != 0) {
whereBuilder.Append("((\"eninvoice27\".\"requisitionid\" = @qpreInvoice_RequisitionId) AND (\"eninvoice27\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreInvoice_RequisitionId", DbType.Int64, qpreInvoice_RequisitionId);
} else {
whereBuilder.Append("(\"eninvoice27\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpteInvoiceName != "" && qpteInvoiceName != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice27\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvoiceName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceName", DbType.String, qpteInvoiceName);
}
if (qpinInvoice_InvoiceStatusId != BuiltInFunction.NullIdentifier()) {
if (qpinInvoice_InvoiceStatusId != 0) {
whereBuilder.Append("((\"eninvoice27\".\"invoicestatusid\" = @qpinInvoice_InvoiceStatusId) AND (\"eninvoice27\".\"invoicestatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
} else {
whereBuilder.Append("(\"eninvoice27\".\"invoicestatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaDateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice27\".\"createdon\"::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaDateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpini_OffsetUtc", DbType.Int32, qpini_OffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaDateFrom", DbType.DateTime, qpdaDateFrom);
}
if (qpdaDateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice27\".\"createdon\"::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaDateTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpini_OffsetUtc", DbType.Int32, qpini_OffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaDateTo", DbType.DateTime, qpdaDateTo);
}
whereBuilder.Append("(\"eninvoiceapprovallevel12\".\"levelnumber\" = \"eninvoiceapproval11\".\"currentlevel\")");
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
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
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
