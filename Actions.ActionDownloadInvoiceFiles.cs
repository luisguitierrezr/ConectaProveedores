namespace ssConectaProveedores;

public partial class Actions {
public class lcvDownloadInvoiceFiles : VarsBag {
public long inParamInvoiceId;
public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public Actions.lcoDownloadZipByStorageIdList resDownloadZipByStorageIdList =  new Actions.lcoDownloadZipByStorageIdList();
public lcvDownloadInvoiceFiles(long inParamInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoDownloadInvoiceFiles : VarsBag {
public byte[] outParamBinaryZIP = new byte[] {};

public string outParamErrorMsg = "";

public lcoDownloadInvoiceFiles() {
}
}
/// <summary>
/// Action <code>DownloadInvoiceFiles</code> that represents the Service Studio action
///  <code>DownloadInvoiceFiles</code> <p> Description: </p>
/// </summary>
public static async Task<(byte[],string)> ActionDownloadInvoiceFiles(IRequestContext requestContext,long inParamInvoiceId,CancellationToken cancellationToken) {
byte[] outParamBinaryZIP = default;
string outParamErrorMsg = default;
lcoDownloadInvoiceFiles result = new lcoDownloadInvoiceFiles();
lcvDownloadInvoiceFiles localVars = new lcvDownloadInvoiceFiles(inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DownloadInvoiceFiles", "a7ddfd23-59f0-4a80-8ec4-33c9d74b80ff"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DownloadInvoiceFiles", "a7ddfd23-59f0-4a80-8ec4-33c9d74b80ff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionDownloadInvoiceFiles.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// DownloadZipByStorageIdList
(localVars.resDownloadZipByStorageIdList.outParamBinaryZIP,localVars.resDownloadZipByStorageIdList.outParamErrorMsg) = await Actions.ActionDownloadZipByStorageIdList(requestContext,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList, new BasicTypeList<long>(), async (RC_18990af86f7169e92b712b468e13b947 source, long target, CancellationToken cancellationToken) => {
target = source.ssENInvoiceFile.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

// BinaryZIP = DownloadZipByStorageIdList.BinaryZIP
result.outParamBinaryZIP=localVars.resDownloadZipByStorageIdList.outParamBinaryZIP;

// ErrorMsg = DownloadZipByStorageIdList.ErrorMsg
result.outParamErrorMsg=localVars.resDownloadZipByStorageIdList.outParamErrorMsg;
} //close CreateActionActivity using block
} // try

finally {
outParamBinaryZIP = result.outParamBinaryZIP;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamBinaryZIP,outParamErrorMsg);
}

public static class FuncActionDownloadInvoiceFiles {

// Query Function "GetInvoiceFilesByInvoiceId" ilQ5GAHQbEy+apCYld_ZOQ of Action "DownloadInvoiceFiles"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DownloadInvoiceFiles.GetInvoiceFilesByInvoiceId", "1839548a-d001-4c6c-be6a-909895dfd939");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DownloadInvoiceFiles.GetInvoiceFilesByInvoiceId", "1839548a-d001-4c6c-be6a-909895dfd939", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.I_3dp_BZgEqOxDPJ10uA_w/NodesNotShownInESpaceTree.ilQ5GAHQbEy+apCYld_ZOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile13\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile13\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile13\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile13\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile13\".\"invoiceid\" IS NULL)");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DownloadInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DownloadInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
