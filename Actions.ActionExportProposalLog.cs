namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportProposalLog : VarsBag {
public long inParami_ProposalId;
public long inParami_ProposalLineId;
/// <summary>
/// Variable <code>ExcelLogToExport</code> that represents the Service Studio
///  ExcelProposalLogToExportList <code>ExcelLogToExport</code> <p>Description: </p>
/// </summary>
public RL_c548b25bdcfb12c815d629040c2b9cfa varLcExcelLogToExport = new RL_c548b25bdcfb12c815d629040c2b9cfa();

public byte[] resRecordListToExcelFile_outParamOut = new byte[] {};
public RL_3286f6c378c910e4e42e108563fc6bb5 queryResGetProposalLogsByProposalId_outParamList = new RL_3286f6c378c910e4e42e108563fc6bb5();
public long queryResGetProposalLogsByProposalId_outParamCount = 0L;

public lcvExportProposalLog(long inParami_ProposalId, long inParami_ProposalLineId) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_ProposalLineId = inParami_ProposalLineId;
}
}
public class lcoExportProposalLog : VarsBag {
public byte[] outParamo_File = new byte[] {};

public lcoExportProposalLog() {
}
}
/// <summary>
/// Action <code>ExportProposalLog</code> that represents the Service Studio action
///  <code>ExportProposalLog</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionExportProposalLog(IRequestContext requestContext,long inParami_ProposalId,long inParami_ProposalLineId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
lcoExportProposalLog result = new lcoExportProposalLog();
lcvExportProposalLog localVars = new lcvExportProposalLog(inParami_ProposalId, inParami_ProposalLineId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportProposalLog", "a07f8e2c-0799-4937-897a-038796fa64d2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportProposalLog", "a07f8e2c-0799-4937-897a-038796fa64d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalLogsByProposalId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLogsByProposalId_maxRecords = 0;
int datasetGetProposalLogsByProposalId_startIndex = 0;(localVars.queryResGetProposalLogsByProposalId_outParamList,localVars.queryResGetProposalLogsByProposalId_outParamCount) = await FuncActionExportProposalLog.datasetGetProposalLogsByProposalId(requestContext,datasetGetProposalLogsByProposalId_maxRecords,datasetGetProposalLogsByProposalId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.inParami_ProposalId,localVars.inParami_ProposalLineId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcExcelLogToExport,(await RL_c548b25bdcfb12c815d629040c2b9cfa.ConvertAsync(localVars.queryResGetProposalLogsByProposalId_outParamList, new RL_c548b25bdcfb12c815d629040c2b9cfa(), async (RC_a6b7967ad624705fbcd9d81593f9e64b source, ST_d9d3688bd2889652b9e8e27acc05ba6cStructure target, CancellationToken cancellationToken) => {
target.ssProposalName = source.ssENProposal.ssName;
target.ssCreatedBy = source.ssENUser.ssName;
target.ssCreatedOn = source.ssENProposalLogs.ssCreatedOn;
target.ssMessage = source.ssENProposalLogs.ssMessage;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelExportProposalLogRecordListToExcelFile
localVars.resRecordListToExcelFile_outParamOut = await FuncActionExportProposalLog.RLToExcelExportProposalLogRecordListToExcelFile(requestContext,localVars.varLcExcelLogToExport,cancellationToken);

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

public static class FuncActionExportProposalLog {

private static async Task<RC_a6b7967ad624705fbcd9d81593f9e64b> datasetGetProposalLogsByProposalIdReadDbAsync(RC_a6b7967ad624705fbcd9d81593f9e64b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalLogs.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLogsByProposalId" Z8A5H9KDrE6OS+zOSgrq2Q of Action "ExportProposalLog"
public static async Task<(RL_3286f6c378c910e4e42e108563fc6bb5,long)> datasetGetProposalLogsByProposalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposalLogs_ProposalId,long qpprProposalLogs_ProposalLineId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ExportProposalLog.GetProposalLogsByProposalId", "1f39c067-83d2-4eac-8e4b-ecce4a0aead9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ExportProposalLog.GetProposalLogsByProposalId", "1f39c067-83d2-4eac-8e4b-ecce4a0aead9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LI5_oJkHN0mJegOHlvpk0g/NodesNotShownInESpaceTree.Z8A5H9KDrE6OS+zOSgrq2Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enproposal7\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enproposallogs\".\"createdon\" o22, \"enproposallogs\".\"message\" o23, NULL o24, NULL o25, \"enuser95\".\"name\" o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM (({ProposalLogs} \"enproposallogs\" Inner JOIN {Proposal} \"enproposal7\" ON (\"enproposallogs\".\"proposalid\" = \"enproposal7\".\"id\"))  Left JOIN {User} \"enuser95\" ON (\"enproposallogs\".\"createdby\" = \"enuser95\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((CASE WHEN (@qpprProposalLogs_ProposalId = 0) THEN (CASE WHEN (\"enproposallogs\".\"proposallineid\" IS NULL) THEN 1 ELSE 0 END) ELSE (CASE WHEN (@qpprProposalLogs_ProposalLineId = 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalId", DbType.Int64, qpprProposalLogs_ProposalId);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalLineId", DbType.Int64, qpprProposalLogs_ProposalLineId);
if (qpprProposalLogs_ProposalId != 0) {
whereBuilder.Append("((\"enproposallogs\".\"proposalid\" = @qpprProposalLogs_ProposalId) AND (\"enproposallogs\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalId", DbType.Int64, qpprProposalLogs_ProposalId);
} else {
whereBuilder.Append("(\"enproposallogs\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpprProposalLogs_ProposalLineId != 0) {
whereBuilder.Append("((\"enproposallogs\".\"proposallineid\" = @qpprProposalLogs_ProposalLineId) AND (\"enproposallogs\".\"proposallineid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalLineId", DbType.Int64, qpprProposalLogs_ProposalLineId);
} else {
whereBuilder.Append("(\"enproposallogs\".\"proposallineid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enproposallogs\".\"createdon\" DESC ");
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
RL_3286f6c378c910e4e42e108563fc6bb5 outParamList = new RL_3286f6c378c910e4e42e108563fc6bb5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLogsByProposalIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, false, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ExportProposalLog.GetProposalLogsByProposalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3286f6c378c910e4e42e108563fc6bb5 _tmp = new RL_3286f6c378c910e4e42e108563fc6bb5();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLogsByProposalIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ExportProposalLog.GetProposalLogsByProposalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3286f6c378c910e4e42e108563fc6bb5)_tmp;
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
/// RecordList To Excel: RLToExcelExportProposalLogRecordListToExcelFile (KKLLmEpf3_kqqtTYmW36vSw) of
///  Action "ExportProposalLog"
/// </summary>
public static async Task<byte[]> RLToExcelExportProposalLogRecordListToExcelFile(IRequestContext requestContext,RL_c548b25bdcfb12c815d629040c2b9cfa ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(4, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Número de propuesta");
excel.CreateCell("Creado por");
excel.CreateCell("Creado el");
excel.CreateCell("Mensaje");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssProposalName);
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
