namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportRequisitionLog : VarsBag {
public long inParami_RequisitionId;
/// <summary>
/// Variable <code>ExcelLogToExport</code> that represents the Service Studio
///  ExcelRequisitionLogToExportList <code>ExcelLogToExport</code> <p>Description: </p>
/// </summary>
public RL_8784265c9b53c1e1c23af2a418666616 varLcExcelLogToExport = new RL_8784265c9b53c1e1c23af2a418666616();

public byte[] resRecordListToExcelFile_outParamOut = new byte[] {};
public RL_229a538de0ea5acc5992a93132dd8a21 queryResGetRequisitionLogsByRequisitionId_outParamList = new RL_229a538de0ea5acc5992a93132dd8a21();
public long queryResGetRequisitionLogsByRequisitionId_outParamCount = 0L;

public lcvExportRequisitionLog(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
public class lcoExportRequisitionLog : VarsBag {
public byte[] outParamo_File = new byte[] {};

public lcoExportRequisitionLog() {
}
}
/// <summary>
/// Action <code>ExportRequisitionLog</code> that represents the Service Studio action
///  <code>ExportRequisitionLog</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionExportRequisitionLog(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
lcoExportRequisitionLog result = new lcoExportRequisitionLog();
lcvExportRequisitionLog localVars = new lcvExportRequisitionLog(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportRequisitionLog", "10d55920-7aa9-434e-9517-f41adbd3087e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportRequisitionLog", "10d55920-7aa9-434e-9517-f41adbd3087e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionLogsByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionLogsByRequisitionId_maxRecords = 0;
int datasetGetRequisitionLogsByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionLogsByRequisitionId_outParamList,localVars.queryResGetRequisitionLogsByRequisitionId_outParamCount) = await FuncActionExportRequisitionLog.datasetGetRequisitionLogsByRequisitionId(requestContext,datasetGetRequisitionLogsByRequisitionId_maxRecords,datasetGetRequisitionLogsByRequisitionId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.inParami_RequisitionId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcExcelLogToExport,(await RL_8784265c9b53c1e1c23af2a418666616.ConvertAsync(localVars.queryResGetRequisitionLogsByRequisitionId_outParamList, new RL_8784265c9b53c1e1c23af2a418666616(), async (RC_f5b6f78be278df3dd44e2d0a42d99692 source, ST_83be973cab4e7f90c5adb2c45a579242Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionName = source.ssENRequisition.ssName;
target.ssCreatedBy = source.ssENUser.ssName;
target.ssCreatedOn = source.ssENRequisitionLogs.ssCreatedOn;
target.ssMessage = source.ssENRequisitionLogs.ssMessage;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelExportRequisitionLogRecordListToExcelFile
localVars.resRecordListToExcelFile_outParamOut = await FuncActionExportRequisitionLog.RLToExcelExportRequisitionLogRecordListToExcelFile(requestContext,localVars.varLcExcelLogToExport,cancellationToken);

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

public static class FuncActionExportRequisitionLog {

private static async Task<RC_f5b6f78be278df3dd44e2d0a42d99692> datasetGetRequisitionLogsByRequisitionIdReadDbAsync(RC_f5b6f78be278df3dd44e2d0a42d99692 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionLogs.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionLogsByRequisitionId" bzHn2lqZXkyutOA+eZwt_g of Action "ExportRequisitionLog"
public static async Task<(RL_229a538de0ea5acc5992a93132dd8a21,long)> datasetGetRequisitionLogsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionLogs_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ExportRequisitionLog.GetRequisitionLogsByRequisitionId", "dae7316f-995a-4c5e-aeb4-e03e799c2dfe");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ExportRequisitionLog.GetRequisitionLogsByRequisitionId", "dae7316f-995a-4c5e-aeb4-e03e799c2dfe", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.IFnVEKl6TkOVF_Qa29MIfg/NodesNotShownInESpaceTree.bzHn2lqZXkyutOA+eZwt_g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition6\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, \"enrequisitionlogs\".\"createdon\" o61, \"enrequisitionlogs\".\"message\" o62, NULL o63, NULL o64, \"enuser11\".\"name\" o65, NULL o66, NULL o67, NULL o68");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition6\" Inner JOIN {RequisitionLogs} \"enrequisitionlogs\" ON (\"enrequisition6\".\"id\" = \"enrequisitionlogs\".\"requisitionid\"))  Left JOIN {User} \"enuser11\" ON (\"enrequisitionlogs\".\"createdby\" = \"enuser11\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisitionLogs_RequisitionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisitionLogs_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionlogs\".\"requisitionid\" = @qpreRequisitionLogs_RequisitionId) AND (\"enrequisitionlogs\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionLogs_RequisitionId", DbType.Int64, qpreRequisitionLogs_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionlogs\".\"requisitionid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enrequisitionlogs\".\"createdon\" DESC ");
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
RL_229a538de0ea5acc5992a93132dd8a21 outParamList = new RL_229a538de0ea5acc5992a93132dd8a21();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionLogsByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, false, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ExportRequisitionLog.GetRequisitionLogsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_229a538de0ea5acc5992a93132dd8a21 _tmp = new RL_229a538de0ea5acc5992a93132dd8a21();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionLogsByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ExportRequisitionLog.GetRequisitionLogsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_229a538de0ea5acc5992a93132dd8a21)_tmp;
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
/// RecordList To Excel: RLToExcelExportRequisitionLogRecordListToExcelFile (KB9ZLksUkvE2bUA6wPHHKGw)
///  of Action "ExportRequisitionLog"
/// </summary>
public static async Task<byte[]> RLToExcelExportRequisitionLogRecordListToExcelFile(IRequestContext requestContext,RL_8784265c9b53c1e1c23af2a418666616 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(4, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Requisición");
excel.CreateCell("Creado por");
excel.CreateCell("Creado el");
excel.CreateCell("Mensaje");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionName);
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
