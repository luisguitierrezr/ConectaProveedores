namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportOrderLog : VarsBag {
public long inParami_OrderMainId;
/// <summary>
/// Variable <code>ExcelLogToExport</code> that represents the Service Studio ExcelOrderLogToExportList
///  <code>ExcelLogToExport</code> <p>Description: </p>
/// </summary>
public RL_2ed2db5e92154c5915466940c779fa10 varLcExcelLogToExport = new RL_2ed2db5e92154c5915466940c779fa10();

public RL_09a534c151a8c55dd3e3e1962f18631c queryResGetOrderLogsByOrderId_outParamList = new RL_09a534c151a8c55dd3e3e1962f18631c();
public long queryResGetOrderLogsByOrderId_outParamCount = 0L;

public byte[] resRecordListToExcelFile_outParamOut = new byte[] {};
public lcvExportOrderLog(long inParami_OrderMainId) {
this.inParami_OrderMainId = inParami_OrderMainId;
}
}
public class lcoExportOrderLog : VarsBag {
public byte[] outParamo_File = new byte[] {};

public lcoExportOrderLog() {
}
}
/// <summary>
/// Action <code>ExportOrderLog</code> that represents the Service Studio action
///  <code>ExportOrderLog</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionExportOrderLog(IRequestContext requestContext,long inParami_OrderMainId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
lcoExportOrderLog result = new lcoExportOrderLog();
lcvExportOrderLog localVars = new lcvExportOrderLog(inParami_OrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportOrderLog", "2edbfe41-40da-4823-913b-c98fc1824d22"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportOrderLog", "2edbfe41-40da-4823-913b-c98fc1824d22", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderLogsByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderLogsByOrderId_maxRecords = 0;
int datasetGetOrderLogsByOrderId_startIndex = 0;(localVars.queryResGetOrderLogsByOrderId_outParamList,localVars.queryResGetOrderLogsByOrderId_outParamCount) = await FuncActionExportOrderLog.datasetGetOrderLogsByOrderId(requestContext,datasetGetOrderLogsByOrderId_maxRecords,datasetGetOrderLogsByOrderId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.inParami_OrderMainId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcExcelLogToExport,(await RL_2ed2db5e92154c5915466940c779fa10.ConvertAsync(localVars.queryResGetOrderLogsByOrderId_outParamList, new RL_2ed2db5e92154c5915466940c779fa10(), async (RC_48f837ac894bfbcf11c3d8c2e6c47c59 source, ST_5fdc1be15c9e934a0a534eba5239d3c9Structure target, CancellationToken cancellationToken) => {
target.ssOrderName = source.ssENOrderMain.ssOrderNumber;
target.ssCreatedBy = source.ssENUser.ssName;
target.ssCreatedOn = source.ssENOrderLogs.ssCreatedOn;
target.ssMessage = source.ssENOrderLogs.ssMessage;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelExportOrderLogRecordListToExcelFile
localVars.resRecordListToExcelFile_outParamOut = await FuncActionExportOrderLog.RLToExcelExportOrderLogRecordListToExcelFile(requestContext,localVars.varLcExcelLogToExport,cancellationToken);

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

public static class FuncActionExportOrderLog {

private static async Task<RC_48f837ac894bfbcf11c3d8c2e6c47c59> datasetGetOrderLogsByOrderIdReadDbAsync(RC_48f837ac894bfbcf11c3d8c2e6c47c59 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderLogs.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderLogsByOrderId" wmBSF7IX10estRu3n2OUHQ of Action "ExportOrderLog"
public static async Task<(RL_09a534c151a8c55dd3e3e1962f18631c,long)> datasetGetOrderLogsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderLogs_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ExportOrderLog.GetOrderLogsByOrderId", "175260c2-17b2-47d7-acb5-1bb79f63941d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ExportOrderLog.GetOrderLogsByOrderId", "175260c2-17b2-47d7-acb5-1bb79f63941d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Qf7bLtpAI0iRO8mPwYJNIg/NodesNotShownInESpaceTree.wmBSF7IX10estRu3n2OUHQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enorderlogs\".\"createdon\" o3, \"enorderlogs\".\"message\" o4, NULL o5, NULL o6, \"enordermain11\".\"ordernumber\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"enuser31\".\"name\" o36, NULL o37, NULL o38, NULL o39");
fromBuilder.Append(" FROM (({OrderLogs} \"enorderlogs\" Left JOIN {OrderMain} \"enordermain11\" ON (\"enorderlogs\".\"orderid\" = \"enordermain11\".\"id\"))  Left JOIN {User} \"enuser31\" ON (\"enordermain11\".\"createdby\" = \"enuser31\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderLogs_OrderId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qporOrderLogs_OrderId != 0) {
whereBuilder.Append("((\"enorderlogs\".\"orderid\" = @qporOrderLogs_OrderId) AND (\"enorderlogs\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderLogs_OrderId", DbType.Int64, qporOrderLogs_OrderId);
} else {
whereBuilder.Append("(\"enorderlogs\".\"orderid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enorderlogs\".\"createdon\" DESC ");
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
RL_09a534c151a8c55dd3e3e1962f18631c outParamList = new RL_09a534c151a8c55dd3e3e1962f18631c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderLogsByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ExportOrderLog.GetOrderLogsByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_09a534c151a8c55dd3e3e1962f18631c _tmp = new RL_09a534c151a8c55dd3e3e1962f18631c();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderLogsByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ExportOrderLog.GetOrderLogsByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_09a534c151a8c55dd3e3e1962f18631c)_tmp;
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
/// RecordList To Excel: RLToExcelExportOrderLogRecordListToExcelFile (KfK24_jPNckmkM_lU7uUJ5w) of
///  Action "ExportOrderLog"
/// </summary>
public static async Task<byte[]> RLToExcelExportOrderLogRecordListToExcelFile(IRequestContext requestContext,RL_2ed2db5e92154c5915466940c779fa10 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(4, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Nombre del pedido");
excel.CreateCell("Creado por");
excel.CreateCell("Creado el");
excel.CreateCell("Mensaje");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssOrderName);
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
