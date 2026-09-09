namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetInvoiceFilesCreditNotes : VarsBag {
public RL_2d16aaaf46aa59a96936af8c3c3547a0 inParamInvoiceList;
public RL_a18358ba225612b834f3458f070d11b3 queryResGetCreditNoteInvoiceById_outParamList = new RL_a18358ba225612b834f3458f070d11b3();
public long queryResGetCreditNoteInvoiceById_outParamCount = 0L;

public RL_a18358ba225612b834f3458f070d11b3 resListDistinct_outParamDistinctList = new RL_a18358ba225612b834f3458f070d11b3();

public lcvGetInvoiceFilesCreditNotes(RL_2d16aaaf46aa59a96936af8c3c3547a0 inParamInvoiceList) {
this.inParamInvoiceList = inParamInvoiceList;
}
}
public class lcoGetInvoiceFilesCreditNotes : VarsBag {
public RL_a18358ba225612b834f3458f070d11b3 outParamCreditNoteInvoiceList = new RL_a18358ba225612b834f3458f070d11b3();

public lcoGetInvoiceFilesCreditNotes() {
}
}
/// <summary>
/// Action <code>GetInvoiceFilesCreditNotes</code> that represents the Service Studio action
///  <code>GetInvoiceFilesCreditNotes</code> <p> Description: </p>
/// </summary>
public static async Task<RL_a18358ba225612b834f3458f070d11b3> ActionGetInvoiceFilesCreditNotes(IRequestContext requestContext,RL_2d16aaaf46aa59a96936af8c3c3547a0 inParamInvoiceList,CancellationToken cancellationToken) {
RL_a18358ba225612b834f3458f070d11b3 outParamCreditNoteInvoiceList = default;
lcoGetInvoiceFilesCreditNotes result = new lcoGetInvoiceFilesCreditNotes();
lcvGetInvoiceFilesCreditNotes localVars = new lcvGetInvoiceFilesCreditNotes(inParamInvoiceList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetInvoiceFilesCreditNotes", "ffac1c46-480e-4e14-86ce-ffa5f5ed0061"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetInvoiceFilesCreditNotes", "ffac1c46-480e-4e14-86ce-ffa5f5ed0061", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach InvoiceList
localVars.inParamInvoiceList.StartIteration();
try {while (!((localVars.inParamInvoiceList.Eof))) {
// Query datasetGetCreditNoteInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCreditNoteInvoiceById_maxRecords = 0;
int datasetGetCreditNoteInvoiceById_startIndex = 0;(localVars.queryResGetCreditNoteInvoiceById_outParamList,localVars.queryResGetCreditNoteInvoiceById_outParamCount) = await FuncActionGetInvoiceFilesCreditNotes.datasetGetCreditNoteInvoiceById(requestContext,datasetGetCreditNoteInvoiceById_maxRecords,datasetGetCreditNoteInvoiceById_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceList.CurrentRec.ssCreditNoteInvoiceId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamCreditNoteInvoiceList,localVars.queryResGetCreditNoteInvoiceById_outParamList,cancellationToken);

localVars.inParamInvoiceList.Advance();
}

} finally {
localVars.inParamInvoiceList.EndIteration();
}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_a18358ba225612b834f3458f070d11b3) result.outParamCreditNoteInvoiceList.Distinct()));

// CreditNoteInvoiceList = ListDistinct.DistinctList
result.outParamCreditNoteInvoiceList=localVars.resListDistinct_outParamDistinctList;
} //close CreateActionActivity using block
} // try

finally {
outParamCreditNoteInvoiceList = result.outParamCreditNoteInvoiceList;
} // inner-finally
RETURN_STATEMENT:
return outParamCreditNoteInvoiceList;
}

public static class FuncActionGetInvoiceFilesCreditNotes {

private static async Task<RC_e89a3df29980b4bfe26cbaac4d2e6d26> datasetGetCreditNoteInvoiceByIdReadDbAsync(RC_e89a3df29980b4bfe26cbaac4d2e6d26 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetCreditNoteInvoiceById" jNXfOxVZj0eiUd53RP8qhg of Action "GetInvoiceFilesCreditNotes"
public static async Task<(RL_a18358ba225612b834f3458f070d11b3,long)> datasetGetCreditNoteInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetInvoiceFilesCreditNotes.GetCreditNoteInvoiceById", "3bdfd58c-5915-478f-a251-de7744ff2a86");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetInvoiceFilesCreditNotes.GetCreditNoteInvoiceById", "3bdfd58c-5915-478f-a251-de7744ff2a86", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Rhys_w5IFE6Gzv+l9e0AYQ/NodesNotShownInESpaceTree.jNXfOxVZj0eiUd53RP8qhg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice77\".\"id\" o0, \"eninvoice77\".\"name\" o1, \"eninvoice77\".\"requisitionid\" o2, \"eninvoice77\".\"folioid\" o3, \"eninvoice77\".\"ordermainid\" o4, \"eninvoice77\".\"cfditypeid\" o5, trim_scale(\"eninvoice77\".\"totalamount\"::numeric) o6, \"eninvoice77\".\"currency\" o7, \"eninvoice77\".\"invoicestatusid\" o8, \"eninvoice77\".\"accountingdatetime\" o9, \"eninvoice77\".\"paymentdatetime\" o10, \"eninvoice77\".\"createdon\" o11, \"eninvoice77\".\"createdby\" o12, \"eninvoice77\".\"updatedon\" o13, \"eninvoice77\".\"updatedby\" o14, \"eninvoice77\".\"submittedon\" o15, \"eninvoice77\".\"isnewversion\" o16, \"eninvoice77\".\"id_poliza\" o17, \"eninvoice77\".\"id_poliza_sap\" o18, \"eninvoice77\".\"doc51\" o19, \"eninvoice77\".\"accountingerror\" o20, \"eninvoice77\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice77\".\"amortization\"::numeric) o22, \"eninvoice77\".\"creditnoteinvoiceid\" o23, \"eninvoicefile25\".\"id\" o24, \"eninvoicefile25\".\"invoiceid\" o25, \"eninvoicefile25\".\"filename\" o26, \"eninvoicefile25\".\"isextra\" o27, \"eninvoicefile25\".\"isreport\" o28, \"eninvoicefile25\".\"storageid\" o29, \"eninvoicefile25\".\"createdby\" o30, \"eninvoicefile25\".\"createdon\" o31, \"enstorage15\".\"id\" o32, \"enstorage15\".\"concept\" o33, \"enstorage15\".\"internalconceptid\" o34, \"enstorage15\".\"file\" o35, \"enstorage15\".\"filename\" o36, \"enstorage15\".\"vendor\" o37, \"enstorage15\".\"doc_type\" o38, \"enstorage15\".\"object_type\" o39, \"enstorage15\".\"istosendtoexternal\" o40, \"enstorage15\".\"withentegrationerror\" o41, \"enstorage15\".\"isexternal\" o42, \"enstorage15\".\"archive_id\" o43, \"enstorage15\".\"arc_doc_id\" o44, \"enstorage15\".\"error_message\" o45, \"enstorage15\".\"sentwhen\" o46, \"enstorage15\".\"istodelete\" o47, \"enstorage15\".\"istobig\" o48, \"enstorage15\".\"attempt\" o49, \"enstorage15\".\"size\" o50, \"enstorage15\".\"createat\" o51, \"enuser142\".\"id\" o52, \"enuser142\".\"name\" o53, \"enuser142\".\"email\" o54, \"enuser142\".\"photourl\" o55, \"enuser142\".\"username\" o56");
fromBuilder.Append(" FROM ((({InvoiceFile} \"eninvoicefile25\" Inner JOIN {Invoice} \"eninvoice77\" ON (\"eninvoicefile25\".\"invoiceid\" = \"eninvoice77\".\"id\"))  Inner JOIN {User} \"enuser142\" ON (\"eninvoicefile25\".\"createdby\" = \"enuser142\".\"id\"))  Left JOIN {Storage} \"enstorage15\" ON (\"eninvoicefile25\".\"storageid\" = \"enstorage15\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile25\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile25\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile25\".\"invoiceid\" IS NULL)");
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
RL_a18358ba225612b834f3458f070d11b3 outParamList = new RL_a18358ba225612b834f3458f070d11b3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCreditNoteInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetInvoiceFilesCreditNotes.GetCreditNoteInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a18358ba225612b834f3458f070d11b3 _tmp = new RL_a18358ba225612b834f3458f070d11b3();
_tmp.AlternateReadDbMethodAsync = datasetGetCreditNoteInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetInvoiceFilesCreditNotes.GetCreditNoteInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a18358ba225612b834f3458f070d11b3)_tmp;
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
