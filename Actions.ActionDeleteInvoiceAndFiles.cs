namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteInvoiceAndFiles : VarsBag {
public long inParamInvoiceId;
public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public lcvDeleteInvoiceAndFiles(long inParamInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
}
}
/// <summary>
/// Action <code>DeleteInvoiceAndFiles</code> that represents the Service Studio action
///  <code>DeleteInvoiceAndFiles</code> <p> Description: Delete Invoice and Files</p>
/// </summary>
public static async Task ActionDeleteInvoiceAndFiles(IRequestContext requestContext,long inParamInvoiceId,CancellationToken cancellationToken) {
lcvDeleteInvoiceAndFiles localVars = new lcvDeleteInvoiceAndFiles(inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteInvoiceAndFiles", "72909939-bacc-4eb3-b87c-42b162558ee6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteInvoiceAndFiles", "72909939-bacc-4eb3-b87c-42b162558ee6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceAndFiles.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceFilesByInvoiceId.List
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Eof))) {
// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

// DeleteInvoiceFile
await ExtendedActions.DeleteInvoiceFile(requestContext,localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssId,cancellationToken);

localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.EndIteration();
}

// DeleteInvoice
await ExtendedActions.DeleteInvoice(requestContext,localVars.inParamInvoiceId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteInvoiceAndFiles {

// Query Function "GetInvoiceFilesByInvoiceId" 3rqEMTlfJUSF2xLaCHoAMQ of Action "DeleteInvoiceAndFiles"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceAndFiles.GetInvoiceFilesByInvoiceId", "3184bade-5f39-4425-85db-12da087a0031");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceAndFiles.GetInvoiceFilesByInvoiceId", "3184bade-5f39-4425-85db-12da087a0031", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.OZmQcsy6s064fEKxYlWO5g/NodesNotShownInESpaceTree.3rqEMTlfJUSF2xLaCHoAMQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicefile8\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile8\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile8\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile8\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile8\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile8\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoicefile8\".\"filename\" ASC ");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceAndFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceAndFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
