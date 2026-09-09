namespace ssConectaProveedores;

public partial class Actions {
public class lcvDownloadManualFile : VarsBag {
public long inParami_ManualId;
public RL_808097b75a7bd51cc15eb7e0762dc255 queryResGetManualFile_outParamList = new RL_808097b75a7bd51cc15eb7e0762dc255();
public long queryResGetManualFile_outParamCount = 0L;

public lcvDownloadManualFile(long inParami_ManualId) {
this.inParami_ManualId = inParami_ManualId;
}
}
public class lcoDownloadManualFile : VarsBag {
public RC_9558728eac8dc806cf1b0c0e9a8e1262 outParamFile = new RC_9558728eac8dc806cf1b0c0e9a8e1262();

public lcoDownloadManualFile() {
}
}
/// <summary>
/// Action <code>DownloadManualFile</code> that represents the Service Studio action
///  <code>DownloadManualFile</code> <p> Description: DownloadManualFile</p>
/// </summary>
public static async Task<RC_9558728eac8dc806cf1b0c0e9a8e1262> ActionDownloadManualFile(IRequestContext requestContext,long inParami_ManualId,CancellationToken cancellationToken) {
RC_9558728eac8dc806cf1b0c0e9a8e1262 outParamFile = default;
lcoDownloadManualFile result = new lcoDownloadManualFile();
lcvDownloadManualFile localVars = new lcvDownloadManualFile(inParami_ManualId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DownloadManualFile", "1a300ba8-4fd8-42b4-93e3-7ae466206f98"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DownloadManualFile", "1a300ba8-4fd8-42b4-93e3-7ae466206f98", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetManualFile
cancellationToken.ThrowIfCancellationRequested();
int datasetGetManualFile_maxRecords = 1;
if (datasetGetManualFile_maxRecords < 1) datasetGetManualFile_maxRecords = 1;
int datasetGetManualFile_startIndex = 0;(localVars.queryResGetManualFile_outParamList,localVars.queryResGetManualFile_outParamCount) = await FuncActionDownloadManualFile.datasetGetManualFile(requestContext,datasetGetManualFile_maxRecords,datasetGetManualFile_startIndex,IterationMultiplicity.Never,localVars.inParami_ManualId,cancellationToken);

// File.Binary = GetManualFile.List.Current.ManualFile.File
result.outParamFile.ssBinary = localVars.queryResGetManualFile_outParamList.CurrentRec.ssENManualFile.ssFile;

// File.Filename = GetManualFile.List.Current.ManualFile.Filename
result.outParamFile.ssFilename = localVars.queryResGetManualFile_outParamList.CurrentRec.ssENManualFile.ssFilename;
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
} // inner-finally
RETURN_STATEMENT:
return outParamFile;
}

public static class FuncActionDownloadManualFile {

// Query Function "GetManualFile" 0V3Jd2iEQUe90WXE_AGbFA of Action "DownloadManualFile"
public static async Task<(RL_808097b75a7bd51cc15eb7e0762dc255,long)> datasetGetManualFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpmaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DownloadManualFile.GetManualFile", "77c95dd1-8468-4741-bdd1-65c4fc019b14");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DownloadManualFile.GetManualFile", "77c95dd1-8468-4741-bdd1-65c4fc019b14", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.qAswGthPtEKT43rkZiBvmA/NodesNotShownInESpaceTree.0V3Jd2iEQUe90WXE_AGbFA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enmanualfile\".\"filename\" o1, \"enmanualfile\".\"file\" o2, NULL o3");
fromBuilder.Append(" FROM {ManualFile} \"enmanualfile\"");
whereBuilder.Append(" WHERE ");
if (qpmaId != 0) {
whereBuilder.Append("((\"enmanualfile\".\"id\" = @qpmaId) AND (\"enmanualfile\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaId", DbType.Int64, qpmaId);
} else {
whereBuilder.Append("(\"enmanualfile\".\"id\" IS NULL)");
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
RL_808097b75a7bd51cc15eb7e0762dc255 outParamList = new RL_808097b75a7bd51cc15eb7e0762dc255();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DownloadManualFile.GetManualFile.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_808097b75a7bd51cc15eb7e0762dc255 _tmp = new RL_808097b75a7bd51cc15eb7e0762dc255();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DownloadManualFile.GetManualFile.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_808097b75a7bd51cc15eb7e0762dc255)_tmp;
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
