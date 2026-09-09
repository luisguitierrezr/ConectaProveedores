namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportInvoiceLogs : VarsBag {
public long inParami_InvoiceId;
/// <summary>
/// Variable <code>ExcelLogToExport</code> that represents the Service Studio
///  ExcelInvoiceLogToExportList <code>ExcelLogToExport</code> <p>Description: </p>
/// </summary>
public RL_ea45cdee0de01dcaf2dd1c576a5f22d2 varLcExcelLogToExport = new RL_ea45cdee0de01dcaf2dd1c576a5f22d2();

public RL_8623462923ce4f5fca06be3fb804a6be queryResGetInvoiceLogsByInvoiceId_outParamList = new RL_8623462923ce4f5fca06be3fb804a6be();
public long queryResGetInvoiceLogsByInvoiceId_outParamCount = 0L;

public byte[] resRecordListToExcelFile_outParamOut = new byte[] {};
public lcvExportInvoiceLogs(long inParami_InvoiceId) {
this.inParami_InvoiceId = inParami_InvoiceId;
}
}
public class lcoExportInvoiceLogs : VarsBag {
public byte[] outParamo_File = new byte[] {};

public lcoExportInvoiceLogs() {
}
}
/// <summary>
/// Action <code>ExportInvoiceLogs</code> that represents the Service Studio action
///  <code>ExportInvoiceLogs</code> <p> Description: Action to Export Invoice Logs.</p>
/// </summary>
public static async Task<byte[]> ActionExportInvoiceLogs(IRequestContext requestContext,long inParami_InvoiceId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
lcoExportInvoiceLogs result = new lcoExportInvoiceLogs();
lcvExportInvoiceLogs localVars = new lcvExportInvoiceLogs(inParami_InvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportInvoiceLogs", "7ea43ae3-241f-41b7-90b0-2ef36ae4a082"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportInvoiceLogs", "7ea43ae3-241f-41b7-90b0-2ef36ae4a082", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceLogsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceLogsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceLogsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceLogsByInvoiceId_outParamList,localVars.queryResGetInvoiceLogsByInvoiceId_outParamCount) = await FuncActionExportInvoiceLogs.datasetGetInvoiceLogsByInvoiceId(requestContext,datasetGetInvoiceLogsByInvoiceId_maxRecords,datasetGetInvoiceLogsByInvoiceId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.inParami_InvoiceId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcExcelLogToExport,(await RL_ea45cdee0de01dcaf2dd1c576a5f22d2.ConvertAsync(localVars.queryResGetInvoiceLogsByInvoiceId_outParamList, new RL_ea45cdee0de01dcaf2dd1c576a5f22d2(), async (RC_febdfe749051cd5849a077ecffdddeec source, ST_dcf36ec11d8d763002f3a9a106379cf7Structure target, CancellationToken cancellationToken) => {
target.ssInvoiceName = source.ssENInvoice.ssName;
target.ssCreatedBy = source.ssENUser.ssName;
target.ssCreatedOn = source.ssENInvoiceLog.ssCreatedOn;
target.ssMessage = source.ssENInvoiceLog.ssMessage;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelExportInvoiceLogsRecordListToExcelFile
localVars.resRecordListToExcelFile_outParamOut = await FuncActionExportInvoiceLogs.RLToExcelExportInvoiceLogsRecordListToExcelFile(requestContext,localVars.varLcExcelLogToExport,cancellationToken);

// o_File = RecordListToExcelFile
result.outParamo_File=localVars.resRecordListToExcelFile_outParamOut;
} //close CreateActionActivity using block
} // try

finally {
outParamo_File = result.outParamo_File;
} // inner-finally
RETURN_STATEMENT:
return outParamo_File;
}

public static class FuncActionExportInvoiceLogs {

private static async Task<RC_febdfe749051cd5849a077ecffdddeec> datasetGetInvoiceLogsByInvoiceIdReadDbAsync(RC_febdfe749051cd5849a077ecffdddeec rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceLog.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceLogsByInvoiceId" z13NR8hZLECu4QfI5ikQDA of Action "ExportInvoiceLogs"
public static async Task<(RL_8623462923ce4f5fca06be3fb804a6be,long)> datasetGetInvoiceLogsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ExportInvoiceLogs.GetInvoiceLogsByInvoiceId", "47cd5dcf-59c8-402c-aee1-07c8e629100c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ExportInvoiceLogs.GetInvoiceLogsByInvoiceId", "47cd5dcf-59c8-402c-aee1-07c8e629100c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.4zqkfh8kt0GQsC7zauSggg/NodesNotShownInESpaceTree.z13NR8hZLECu4QfI5ikQDA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice32\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"eninvoicelog\".\"message\" o26, \"eninvoicelog\".\"createdon\" o27, NULL o28, NULL o29, NULL o30, \"enuser80\".\"name\" o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice32\" Left JOIN {InvoiceLog} \"eninvoicelog\" ON (\"eninvoice32\".\"id\" = \"eninvoicelog\".\"invoiceid\"))  Left JOIN {User} \"enuser80\" ON (\"eninvoicelog\".\"createdby\" = \"enuser80\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoice_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice32\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice32\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice32\".\"id\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"eninvoicelog\".\"createdon\" DESC ");
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
RL_8623462923ce4f5fca06be3fb804a6be outParamList = new RL_8623462923ce4f5fca06be3fb804a6be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceLogsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ExportInvoiceLogs.GetInvoiceLogsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8623462923ce4f5fca06be3fb804a6be _tmp = new RL_8623462923ce4f5fca06be3fb804a6be();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceLogsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ExportInvoiceLogs.GetInvoiceLogsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8623462923ce4f5fca06be3fb804a6be)_tmp;
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


/// <summary>
/// RecordList To Excel: RLToExcelExportInvoiceLogsRecordListToExcelFile (KjWwbb2OURkGl51wgNd5_6A) of
///  Action "ExportInvoiceLogs"
/// </summary>
public static async Task<byte[]> RLToExcelExportInvoiceLogsRecordListToExcelFile(IRequestContext requestContext,RL_ea45cdee0de01dcaf2dd1c576a5f22d2 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(4, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Nombre de factura");
excel.CreateCell("Creado por");
excel.CreateCell("Creado el");
excel.CreateCell("Mensaje");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceName);
excel.CreateCell(ssRecordList.CurrentRec.ssCreatedBy);
excel.CreateCellDateTime(ssRecordList.CurrentRec.ssCreatedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssMessage);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}


}


}
