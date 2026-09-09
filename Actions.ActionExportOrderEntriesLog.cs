namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportOrderEntriesLog : VarsBag {
public long inParami_OrderMainId;
/// <summary>
/// Variable <code>ExcelLogToExport</code> that represents the Service Studio
///  ExcelOrderEntriesLogToExportList <code>ExcelLogToExport</code> <p>Description: </p>
/// </summary>
public RL_1089d48ddd01268f96cdb97961ee0e9d varLcExcelLogToExport = new RL_1089d48ddd01268f96cdb97961ee0e9d();

public byte[] resRecordListToExcelFile_outParamOut = new byte[] {};
public RL_3dd9bb7875fde1313207084bc3e4eb42 queryResGetEntriesByOrderMainId_outParamList = new RL_3dd9bb7875fde1313207084bc3e4eb42();
public long queryResGetEntriesByOrderMainId_outParamCount = 0L;

public lcvExportOrderEntriesLog(long inParami_OrderMainId) {
this.inParami_OrderMainId = inParami_OrderMainId;
}
}
public class lcoExportOrderEntriesLog : VarsBag {
public byte[] outParamo_File = new byte[] {};

public lcoExportOrderEntriesLog() {
}
}
/// <summary>
/// Action <code>ExportOrderEntriesLog</code> that represents the Service Studio action
///  <code>ExportOrderEntriesLog</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionExportOrderEntriesLog(IRequestContext requestContext,long inParami_OrderMainId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
lcoExportOrderEntriesLog result = new lcoExportOrderEntriesLog();
lcvExportOrderEntriesLog localVars = new lcvExportOrderEntriesLog(inParami_OrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportOrderEntriesLog", "ad87a91f-942a-483d-8637-00fb914cfb4d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportOrderEntriesLog", "ad87a91f-942a-483d-8637-00fb914cfb4d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetEntriesByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetEntriesByOrderMainId_maxRecords = 0;
int datasetGetEntriesByOrderMainId_startIndex = 0;(localVars.queryResGetEntriesByOrderMainId_outParamList,localVars.queryResGetEntriesByOrderMainId_outParamCount) = await FuncActionExportOrderEntriesLog.datasetGetEntriesByOrderMainId(requestContext,datasetGetEntriesByOrderMainId_maxRecords,datasetGetEntriesByOrderMainId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.inParami_OrderMainId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcExcelLogToExport,(await RL_1089d48ddd01268f96cdb97961ee0e9d.ConvertAsync(localVars.queryResGetEntriesByOrderMainId_outParamList, new RL_1089d48ddd01268f96cdb97961ee0e9d(), async (RC_cf58ea0f756ca06745169deb0b41c0eb source, ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure target, CancellationToken cancellationToken) => {
target.ssItemPosition = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssQuantity = source.ssENOrderItemEntries.ssQuantity_;
target.ssCreatedBy = source.ssENOrderItemEntries.ssCreatedBy;
target.ssCreatedOn = source.ssENOrderItemEntries.ssCreatedOn;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelExportOrderEntriesLogRecordListToExcelFile
localVars.resRecordListToExcelFile_outParamOut = await FuncActionExportOrderEntriesLog.RLToExcelExportOrderEntriesLogRecordListToExcelFile(requestContext,localVars.varLcExcelLogToExport,cancellationToken);

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

public static class FuncActionExportOrderEntriesLog {

private static async Task<RC_cf58ea0f756ca06745169deb0b41c0eb> datasetGetEntriesByOrderMainIdReadDbAsync(RC_cf58ea0f756ca06745169deb0b41c0eb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderItemEntries.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetEntriesByOrderMainId" _U2411da+0qzSWg+QEZnaQ of Action "ExportOrderEntriesLog"
public static async Task<(RL_3dd9bb7875fde1313207084bc3e4eb42,long)> datasetGetEntriesByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ExportOrderEntriesLog.GetEntriesByOrderMainId", "d7b84dfd-5a57-4afb-b349-683e40466769");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ExportOrderEntriesLog.GetEntriesByOrderMainId", "d7b84dfd-5a57-4afb-b349-683e40466769", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.H6mHrSqUPUiGNwD7kUz7TQ/NodesNotShownInESpaceTree._U2411da+0qzSWg+QEZnaQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, trim_scale(\"enorderitementries\".\"quantity_\"::numeric) o2, NULL o3, NULL o4, \"enorderitementries\".\"createdon\" o5, \"enorderitementries\".\"createdby\" o6, NULL o7, NULL o8, NULL o9, \"enordermainitem6\".\"position\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM ({OrderItemEntries} \"enorderitementries\" Left JOIN {OrderMainItem} \"enordermainitem6\" ON (\"enorderitementries\".\"ordermainitemid\" = \"enordermainitem6\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem6\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem6\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem6\".\"ordermainid\" IS NULL)");
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
RL_3dd9bb7875fde1313207084bc3e4eb42 outParamList = new RL_3dd9bb7875fde1313207084bc3e4eb42();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetEntriesByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, false, false, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ExportOrderEntriesLog.GetEntriesByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3dd9bb7875fde1313207084bc3e4eb42 _tmp = new RL_3dd9bb7875fde1313207084bc3e4eb42();
_tmp.AlternateReadDbMethodAsync = datasetGetEntriesByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ExportOrderEntriesLog.GetEntriesByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3dd9bb7875fde1313207084bc3e4eb42)_tmp;
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
/// RecordList To Excel: RLToExcelExportOrderEntriesLogRecordListToExcelFile (K0jGcqZyPbEy6FohBb0_3Kg)
///  of Action "ExportOrderEntriesLog"
/// </summary>
public static async Task<byte[]> RLToExcelExportOrderEntriesLogRecordListToExcelFile(IRequestContext requestContext,RL_1089d48ddd01268f96cdb97961ee0e9d ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(4, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Item Position");
excel.CreateCell("Quantity");
excel.CreateCell("Creado por");
excel.CreateCell("Creado el");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssItemPosition);
excel.CreateCell(ssRecordList.CurrentRec.ssQuantity);
excel.CreateCell(ssRecordList.CurrentRec.ssCreatedBy);
excel.CreateCellDateTime(ssRecordList.CurrentRec.ssCreatedOn);

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
