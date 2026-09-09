namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetRequisitionFilesById : VarsBag {
public long inParamRequisitionId;
public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResRequisitionFilesById_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResRequisitionFilesById_outParamCount = 0L;

public lcvGetRequisitionFilesById(long inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}
}
public class lcoGetRequisitionFilesById : VarsBag {
public RL_a1f410d0f62252476f2a43f62445ebc5 outParamFiles = new RL_a1f410d0f62252476f2a43f62445ebc5();

public lcoGetRequisitionFilesById() {
}
}
/// <summary>
/// Action <code>GetRequisitionFilesById</code> that represents the Service Studio action
///  <code>GetRequisitionFilesById</code> <p> Description: </p>
/// </summary>
public static async Task<RL_a1f410d0f62252476f2a43f62445ebc5> ActionGetRequisitionFilesById(IRequestContext requestContext,long inParamRequisitionId,CancellationToken cancellationToken) {
RL_a1f410d0f62252476f2a43f62445ebc5 outParamFiles = default;
lcoGetRequisitionFilesById result = new lcoGetRequisitionFilesById();
lcvGetRequisitionFilesById localVars = new lcvGetRequisitionFilesById(inParamRequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetRequisitionFilesById", "6fbc8eb6-c60e-4d2a-97f1-f4922db6de16"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetRequisitionFilesById", "6fbc8eb6-c60e-4d2a-97f1-f4922db6de16", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetRequisitionFilesById
cancellationToken.ThrowIfCancellationRequested();
int datasetRequisitionFilesById_maxRecords = 0;
int datasetRequisitionFilesById_startIndex = 0;(localVars.queryResRequisitionFilesById_outParamList,localVars.queryResRequisitionFilesById_outParamCount) = await FuncActionGetRequisitionFilesById.datasetRequisitionFilesById(requestContext,datasetRequisitionFilesById_maxRecords,datasetRequisitionFilesById_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach RequisitionFilesById.List
localVars.queryResRequisitionFilesById_outParamList.StartIteration();
try {while (!((localVars.queryResRequisitionFilesById_outParamList.Eof))) {
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.queryResRequisitionFilesById_outParamList.CurrentRec.ssENRequisitionFile2.ssStorageId,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamFiles,new ST_a158c76eb93396680623c04244f48b6cStructure(){ ssName = localVars.resServiceStorageGetFile_outParamo_filename, ssBinaryData = localVars.resServiceStorageGetFile_outParamo_File },cancellationToken);

localVars.queryResRequisitionFilesById_outParamList.Advance();
}

} finally {
localVars.queryResRequisitionFilesById_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamFiles = result.outParamFiles;
} // inner-finally
RETURN_STATEMENT:
return outParamFiles;
}

public static class FuncActionGetRequisitionFilesById {

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetRequisitionFilesByIdReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "RequisitionFilesById" jVEKry0HC02AWTd9jrP2tA of Action "GetRequisitionFilesById"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetRequisitionFilesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetRequisitionFilesById.RequisitionFilesById", "af0a518d-072d-4d0b-8059-377d8eb3f6b4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetRequisitionFilesById.RequisitionFilesById", "af0a518d-072d-4d0b-8059-377d8eb3f6b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.to68bw7GKk2X8fSSLbbeFg/NodesNotShownInESpaceTree.jVEKry0HC02AWTd9jrP2tA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enrequisitionfile26\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile6\" Left JOIN {RequisitionFile2} \"enrequisitionfile26\" ON (\"enrequisitioncontractfile6\".\"requisitionfileid\" = \"enrequisitionfile26\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile6\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile6\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile6\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionfile26\".\"storageid\" IS NOT NULL)");
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
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetRequisitionFilesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRequisitionFilesById.RequisitionFilesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetRequisitionFilesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRequisitionFilesById.RequisitionFilesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
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
