namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceFilesDeleteAll : VarsBag {
public long inParamInvoiceId;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
/// <summary>
/// Variable <code>AllFilesList</code> that represents the Service Studio InvoiceFileStructList
///  <code>AllFilesList</code> <p>Description: </p>
/// </summary>
public RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcAllFilesList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public RL_7b4ceb84b6a1255d3a42c8932279bc3c resListFilter_outParamFilteredList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public lcvInvoiceFilesDeleteAll(long inParamInvoiceId, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
}
}
/// <summary>
/// Action <code>InvoiceFilesDeleteAll</code> that represents the Service Studio action
///  <code>InvoiceFilesDeleteAll</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task ActionInvoiceFilesDeleteAll(IRequestContext requestContext,long inParamInvoiceId,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,CancellationToken cancellationToken) {
lcvInvoiceFilesDeleteAll localVars = new lcvInvoiceFilesDeleteAll(inParamInvoiceId, inParamFilesList, inParamExtraFilesList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceFilesDeleteAll", "c170e5c1-ca0c-417a-a09e-be8424f7f97f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceFilesDeleteAll", "c170e5c1-ca0c-417a-a09e-be8424f7f97f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcAllFilesList,localVars.inParamFilesList,cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcAllFilesList,localVars.inParamExtraFilesList,cancellationToken);

// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionInvoiceFilesDeleteAll.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceFilesByInvoiceId.List
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Eof))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_7b4ceb84b6a1255d3a42c8932279bc3c)await  localVars.varLcAllFilesList.FilterAsync(async (p, cancellationToken) => (localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId==p.ssStorageId), cancellationToken)));

// exists?
if((!((!localVars.resListFilter_outParamFilteredList.Empty)))) {
// DeleteInvoiceFile
await ExtendedActions.DeleteInvoiceFile(requestContext,localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssId,cancellationToken);

// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

}

localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceFilesDeleteAll {

// Query Function "GetInvoiceFilesByInvoiceId" Gr2XcRmTVk60Iw45Pn3xCA of Action "InvoiceFilesDeleteAll"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceFilesDeleteAll.GetInvoiceFilesByInvoiceId", "7197bd1a-9319-4e56-b423-0e393e7df108");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceFilesDeleteAll.GetInvoiceFilesByInvoiceId", "7197bd1a-9319-4e56-b423-0e393e7df108", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.weVwwQzKekGgnr6EJPf5fw/NodesNotShownInESpaceTree.Gr2XcRmTVk60Iw45Pn3xCA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicefile20\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile20\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile20\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile20\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile20\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile20\".\"invoiceid\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceFilesDeleteAll.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceFilesDeleteAll.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
