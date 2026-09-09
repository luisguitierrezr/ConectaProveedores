namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateInvoicesReport48_Invoices5Files : VarsBag {
public long inParami_InvoiceId;
public RL_00a03f803f0d49826089181417370afb resListFilterXml_outParamFilteredList = new RL_00a03f803f0d49826089181417370afb();

public RL_00a03f803f0d49826089181417370afb resListFilterPdf_outParamFilteredList = new RL_00a03f803f0d49826089181417370afb();

public RL_717be923c258f39ae670dbff1acf2ded queryResGetInvoiceAccountingCostCenters_outParamList = new RL_717be923c258f39ae670dbff1acf2ded();
public long queryResGetInvoiceAccountingCostCenters_outParamCount = 0L;

public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public lcvGenerateInvoicesReport48_Invoices5Files(long inParami_InvoiceId) {
this.inParami_InvoiceId = inParami_InvoiceId;
}
}
public class lcoGenerateInvoicesReport48_Invoices5Files : VarsBag {
public ST_67affae36317a1bf9109868208ade0a8Structure outParamo_InvoicesReport48_Files = new ST_67affae36317a1bf9109868208ade0a8Structure();

public lcoGenerateInvoicesReport48_Invoices5Files() {
}
}
/// <summary>
/// Action <code>GenerateInvoicesReport48_Invoices5Files</code> that represents the Service Studio
///  action <code>GenerateInvoicesReport48_Invoices5Files</code> <p> Description
/// : GenerateInvoiceReport48_Invoices5Files</p>
/// </summary>
public static async Task<ST_67affae36317a1bf9109868208ade0a8Structure> ActionGenerateInvoicesReport48_Invoices5Files(IRequestContext requestContext,long inParami_InvoiceId,CancellationToken cancellationToken) {
ST_67affae36317a1bf9109868208ade0a8Structure outParamo_InvoicesReport48_Files = default;
lcoGenerateInvoicesReport48_Invoices5Files result = new lcoGenerateInvoicesReport48_Invoices5Files();
lcvGenerateInvoicesReport48_Invoices5Files localVars = new lcvGenerateInvoicesReport48_Invoices5Files(inParami_InvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateInvoicesReport48_Invoices5Files", "d00e7806-2eef-448e-91a8-98f811296a1e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateInvoicesReport48_Invoices5Files", "d00e7806-2eef-448e-91a8-98f811296a1e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices5Files.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Multiple,localVars.inParami_InvoiceId,cancellationToken);

// ListFilterPdf
localVars.resListFilterPdf_outParamFilteredList = (((RL_00a03f803f0d49826089181417370afb)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENInvoiceFile.ssFilename), ".pdf", 0, false, false)!=(-1)), cancellationToken)));

// ListFilterXml
localVars.resListFilterXml_outParamFilteredList = (((RL_00a03f803f0d49826089181417370afb)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENInvoiceFile.ssFilename), ".xml", 0, false, false)!=(-1)), cancellationToken)));

// Query datasetGetInvoiceAccountingCostCenters
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingCostCenters_maxRecords = 0;
int datasetGetInvoiceAccountingCostCenters_startIndex = 0;(localVars.queryResGetInvoiceAccountingCostCenters_outParamList,localVars.queryResGetInvoiceAccountingCostCenters_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices5Files.datasetGetInvoiceAccountingCostCenters(requestContext,datasetGetInvoiceAccountingCostCenters_maxRecords,datasetGetInvoiceAccountingCostCenters_startIndex,IterationMultiplicity.Single,localVars.inParami_InvoiceId,cancellationToken);

// Foreach GetInvoiceAccountingCostCenters.List
localVars.queryResGetInvoiceAccountingCostCenters_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceAccountingCostCenters_outParamList.Eof))) {
// o_InvoicesReport48_Files.CostCenters = o_InvoicesReport48_Files.CostCenters + If + If
result.outParamo_InvoicesReport48_Files.ssCostCenters = ((result.outParamo_InvoicesReport48_Files.ssCostCenters+(((result.outParamo_InvoicesReport48_Files.ssCostCenters!="")) ? (",") : ("")))+(((localVars.queryResGetInvoiceAccountingCostCenters_outParamList.CurrentRec.ssENCostCenterSAP.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceAccountingCostCenters_outParamList.CurrentRec.ssENCeBeCostCenterSAP.ssDenominacion) : (localVars.queryResGetInvoiceAccountingCostCenters_outParamList.CurrentRec.ssENCostCenterSAP.ssDenominacion)));
localVars.queryResGetInvoiceAccountingCostCenters_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceAccountingCostCenters_outParamList.EndIteration();
}

// Files
// o_InvoicesReport48_Files.PdfName = ListFilterPdf.FilteredList.Current.InvoiceFile.Filename
result.outParamo_InvoicesReport48_Files.ssPdfName = localVars.resListFilterPdf_outParamFilteredList.CurrentRec.ssENInvoiceFile.ssFilename;

// o_InvoicesReport48_Files.XmlName = ListFilterXml.FilteredList.Current.InvoiceFile.Filename
result.outParamo_InvoicesReport48_Files.ssXmlName = localVars.resListFilterXml_outParamFilteredList.CurrentRec.ssENInvoiceFile.ssFilename;
} //close CreateActionActivity using block
} // try

finally {
outParamo_InvoicesReport48_Files = result.outParamo_InvoicesReport48_Files;
} // inner-finally
RETURN_STATEMENT:
return outParamo_InvoicesReport48_Files;
}

public static class FuncActionGenerateInvoicesReport48_Invoices5Files {

private static async Task<RC_edbb7c49338c371c22a2fa657a1d867d> datasetGetInvoiceAccountingCostCentersReadDbAsync(RC_edbb7c49338c371c22a2fa657a1d867d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCeBeCostCenterSAP.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceAccountingServices.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingCostCenters" GtPiwaCQDEeieZEFkzWXDQ of Action "GenerateInvoicesReport48_Invoices5Files"
public static async Task<(RL_717be923c258f39ae670dbff1acf2ded,long)> datasetGetInvoiceAccountingCostCenters(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccounting_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices5Files.GetInvoiceAccountingCostCenters", "c1e2d31a-90a0-470c-a279-91059335970d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices5Files.GetInvoiceAccountingCostCenters", "c1e2d31a-90a0-470c-a279-91059335970d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.BngO0O8ujkSRqJj4ESlqHg/NodesNotShownInESpaceTree.GtPiwaCQDEeieZEFkzWXDQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"encebecostcentersap\".\"denominacion\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"encostcentersap5\".\"id\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"encostcentersap5\".\"denominacion\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84");
fromBuilder.Append(" FROM ((({InvoiceAccounting} \"eninvoiceaccounting15\" Left JOIN {InvoiceAccountingServices} \"eninvoiceaccountingservices4\" ON (\"eninvoiceaccounting15\".\"id\" = \"eninvoiceaccountingservices4\".\"invoiceaccountingid\"))  Left JOIN {CostCenterSAP} \"encostcentersap5\" ON (\"eninvoiceaccountingservices4\".\"costcenterid\" = \"encostcentersap5\".\"id\"))  Left JOIN {CostCenterSAP} \"encebecostcentersap\" ON (\"eninvoiceaccountingservices4\".\"cebecostcenterid\" = \"encebecostcentersap\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccounting_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting15\".\"invoiceid\" = @qpinInvoiceAccounting_InvoiceId) AND (\"eninvoiceaccounting15\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccounting_InvoiceId", DbType.Int64, qpinInvoiceAccounting_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting15\".\"invoiceid\" IS NULL)");
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
RL_717be923c258f39ae670dbff1acf2ded outParamList = new RL_717be923c258f39ae670dbff1acf2ded();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingCostCentersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices5Files.GetInvoiceAccountingCostCenters.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_717be923c258f39ae670dbff1acf2ded _tmp = new RL_717be923c258f39ae670dbff1acf2ded();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingCostCentersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices5Files.GetInvoiceAccountingCostCenters.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_717be923c258f39ae670dbff1acf2ded)_tmp;
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

// Query Function "GetInvoiceFilesByInvoiceId" UcX1wycTTU+epdREDjpQ_w of Action "GenerateInvoicesReport48_Invoices5Files"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices5Files.GetInvoiceFilesByInvoiceId", "c3f5c551-1327-4f4d-9ea5-d4440e3a50ff");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices5Files.GetInvoiceFilesByInvoiceId", "c3f5c551-1327-4f4d-9ea5-d4440e3a50ff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.BngO0O8ujkSRqJj4ESlqHg/NodesNotShownInESpaceTree.UcX1wycTTU+epdREDjpQ_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoicefile23\".\"filename\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile23\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile23\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile23\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile23\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (\"eninvoicefile23\".\"isextra\" = 1))");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices5Files.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices5Files.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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
