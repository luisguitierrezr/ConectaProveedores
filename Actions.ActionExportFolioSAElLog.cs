namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportFolioSAElLog : VarsBag {
public long inParami_FolioId;
/// <summary>
/// Variable <code>ExcelLogToExport</code> that represents the Service Studio ExcelFolioLogToExportList
///  <code>ExcelLogToExport</code> <p>Description: </p>
/// </summary>
public RL_dc4d95fbd0db63ac62ca0dfbd88665dd varLcExcelLogToExport = new RL_dc4d95fbd0db63ac62ca0dfbd88665dd();

public byte[] resRecordListToExcelFile_outParamOut = new byte[] {};
public RL_dee17ce4f31506555cb30478e439c102 queryResGetFolioLogsByFolioId_outParamList = new RL_dee17ce4f31506555cb30478e439c102();
public long queryResGetFolioLogsByFolioId_outParamCount = 0L;

public lcvExportFolioSAElLog(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
public class lcoExportFolioSAElLog : VarsBag {
public byte[] outParamo_File = new byte[] {};

public string outParamo_FileName = "";

public lcoExportFolioSAElLog() {
}
}
/// <summary>
/// Action <code>ExportFolioSAElLog</code> that represents the Service Studio action
///  <code>ExportFolioSAElLog</code> <p> Description: </p>
/// </summary>
public static async Task<(byte[],string)> ActionExportFolioSAElLog(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
string outParamo_FileName = default;
lcoExportFolioSAElLog result = new lcoExportFolioSAElLog();
lcvExportFolioSAElLog localVars = new lcvExportFolioSAElLog(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportFolioSAElLog", "833580ea-ca6a-40b3-943e-9a62f3be4cd5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportFolioSAElLog", "833580ea-ca6a-40b3-943e-9a62f3be4cd5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioLogsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioLogsByFolioId_maxRecords = 0;
int datasetGetFolioLogsByFolioId_startIndex = 0;(localVars.queryResGetFolioLogsByFolioId_outParamList,localVars.queryResGetFolioLogsByFolioId_outParamCount) = await FuncActionExportFolioSAElLog.datasetGetFolioLogsByFolioId(requestContext,datasetGetFolioLogsByFolioId_maxRecords,datasetGetFolioLogsByFolioId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.inParami_FolioId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcExcelLogToExport,(await RL_dc4d95fbd0db63ac62ca0dfbd88665dd.ConvertAsync(localVars.queryResGetFolioLogsByFolioId_outParamList, new RL_dc4d95fbd0db63ac62ca0dfbd88665dd(), async (RC_bbf6ac66012cd4c117435ee07fe47293 source, ST_2e562a380f69a76cb54ade40213e888fStructure target, CancellationToken cancellationToken) => {
target.ssNumerodefolio = source.ssENFolio.ssFolioNumber;
target.ssCreadopor = (((source.ssENFolioLog.ssCreatedBy!=BuiltInFunction.NullTextIdentifier ())) ? (source.ssENUser.ssName) : ("Portal Conecta Proveedores"));
target.ssCreadoel = source.ssENFolioLog.ssCreatedOn;
target.ssMensaje = source.ssENFolioLog.ssMessage;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelExportFolioSAElLogRecordListToExcelFile
localVars.resRecordListToExcelFile_outParamOut = await FuncActionExportFolioSAElLog.RLToExcelExportFolioSAElLogRecordListToExcelFile(requestContext,localVars.varLcExcelLogToExport,cancellationToken);

// o_File = RecordListToExcelFile
result.outParamo_File=localVars.resRecordListToExcelFile_outParamOut;

// o_FileName = GetFolioLogsByFolioId.List.Current.Folio.FolioNumber
result.outParamo_FileName=localVars.queryResGetFolioLogsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
} //close CreateActionActivity using block
} // try

finally {
outParamo_File = result.outParamo_File;
outParamo_FileName = result.outParamo_FileName;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_File,outParamo_FileName);
}

public static class FuncActionExportFolioSAElLog {

private static async Task<RC_bbf6ac66012cd4c117435ee07fe47293> datasetGetFolioLogsByFolioIdReadDbAsync(RC_bbf6ac66012cd4c117435ee07fe47293 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioLog.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioLogsByFolioId" gOVN1i2I9UqXHZwXV5mlAQ of Action "ExportFolioSAElLog"
public static async Task<(RL_dee17ce4f31506555cb30478e439c102,long)> datasetGetFolioLogsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpfoFolioLog_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ExportFolioSAElLog.GetFolioLogsByFolioId", "d64de580-882d-4af5-971d-9c175799a501");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ExportFolioSAElLog.GetFolioLogsByFolioId", "d64de580-882d-4af5-971d-9c175799a501", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.6oA1g2rKs0CUPppi875M1Q/NodesNotShownInESpaceTree.gOVN1i2I9UqXHZwXV5mlAQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio29\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enfoliolog\".\"message\" o22, \"enfoliolog\".\"createdby\" o23, \"enfoliolog\".\"createdon\" o24, NULL o25, NULL o26, NULL o27, \"enuser84\".\"name\" o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM (({FolioLog} \"enfoliolog\" Left JOIN {User} \"enuser84\" ON (\"enfoliolog\".\"createdby\" = \"enuser84\".\"id\"))  Left JOIN {Folio} \"enfolio29\" ON (\"enfoliolog\".\"folioid\" = \"enfolio29\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolioLog_FolioId != 0) {
whereBuilder.Append("((\"enfoliolog\".\"folioid\" = @qpfoFolioLog_FolioId) AND (\"enfoliolog\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioLog_FolioId", DbType.Int64, qpfoFolioLog_FolioId);
} else {
whereBuilder.Append("(\"enfoliolog\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliolog\".\"createdon\" DESC ");
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
RL_dee17ce4f31506555cb30478e439c102 outParamList = new RL_dee17ce4f31506555cb30478e439c102();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioLogsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ExportFolioSAElLog.GetFolioLogsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dee17ce4f31506555cb30478e439c102 _tmp = new RL_dee17ce4f31506555cb30478e439c102();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioLogsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ExportFolioSAElLog.GetFolioLogsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dee17ce4f31506555cb30478e439c102)_tmp;
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
/// RecordList To Excel: RLToExcelExportFolioSAElLogRecordListToExcelFile (KwresmMM1c02CmqOC4S_pgQ) of
///  Action "ExportFolioSAElLog"
/// </summary>
public static async Task<byte[]> RLToExcelExportFolioSAElLogRecordListToExcelFile(IRequestContext requestContext,RL_dc4d95fbd0db63ac62ca0dfbd88665dd ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(4, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Número de Folio SAEC");
excel.CreateCell("Creado por");
excel.CreateCell("Creado el");
excel.CreateCell("Mensaje");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssNumerodefolio);
excel.CreateCell(ssRecordList.CurrentRec.ssCreadopor);
excel.CreateCellDateTime(ssRecordList.CurrentRec.ssCreadoel);
excel.CreateCell(ssRecordList.CurrentRec.ssMensaje);

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
