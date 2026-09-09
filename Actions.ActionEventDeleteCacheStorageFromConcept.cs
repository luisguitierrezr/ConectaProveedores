namespace ssConectaProveedores;

public partial class Actions {
public class lcvEventDeleteCacheStorageFromConcept : VarsBag {
public long inParami_RequisitionId;
public long inParami_InvoiceId;
public long inParami_OrderId;
public long inParami_FolioId;
public long inParami_OrderRequestFileId;
/// <summary>
/// Variable <code>StorageIdList</code> that represents the Service Studio StorageIdentifierList
///  <code>StorageIdList</code> <p>Description: </p>
/// </summary>
public BasicTypeList<long> varLcStorageIdList = new BasicTypeList<long>();

public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioById_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioById_outParamCount = 0L;

public RL_0822a9314a3d52420dc7ca5047ccbaee queryResGetOrderContractFiles_outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
public long queryResGetOrderContractFiles_outParamCount = 0L;

public RL_0822a9314a3d52420dc7ca5047ccbaee queryResGetOrderRequestFiles_outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
public long queryResGetOrderRequestFiles_outParamCount = 0L;

public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoiceById_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoiceById_outParamCount = 0L;

public RL_0822a9314a3d52420dc7ca5047ccbaee queryResGetRequisitionAccountingFiles_outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
public long queryResGetRequisitionAccountingFiles_outParamCount = 0L;

public RL_0ad79b64673379e41188da81c3628c0f queryResGetRequisitionById_outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
public long queryResGetRequisitionById_outParamCount = 0L;

public RL_0822a9314a3d52420dc7ca5047ccbaee queryResGetInvoiceFiles_outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
public long queryResGetInvoiceFiles_outParamCount = 0L;

public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainById_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainById_outParamCount = 0L;

public RL_d258c3d50d870257794347fdeb7cc218 queryResGetOrderRequestFileById_outParamList = new RL_d258c3d50d870257794347fdeb7cc218();
public long queryResGetOrderRequestFileById_outParamCount = 0L;

public RL_0822a9314a3d52420dc7ca5047ccbaee queryResGetRequisitionContractFiles_outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
public long queryResGetRequisitionContractFiles_outParamCount = 0L;

public RL_0822a9314a3d52420dc7ca5047ccbaee queryResGetFolioInvoiceFiles_outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
public long queryResGetFolioInvoiceFiles_outParamCount = 0L;

public RL_0822a9314a3d52420dc7ca5047ccbaee queryResGetFolioFiles_outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
public long queryResGetFolioFiles_outParamCount = 0L;

public lcvEventDeleteCacheStorageFromConcept(long inParami_RequisitionId, long inParami_InvoiceId, long inParami_OrderId, long inParami_FolioId, long inParami_OrderRequestFileId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_OrderId = inParami_OrderId;
this.inParami_FolioId = inParami_FolioId;
this.inParami_OrderRequestFileId = inParami_OrderRequestFileId;
}
}
/// <summary>
/// Action <code>EventDeleteCacheStorageFromConcept</code> that represents the Service Studio action
///  <code>EventDeleteCacheStorageFromConcept</code> <p> Description: </p>
/// </summary>
public static async Task ActionEventDeleteCacheStorageFromConcept(IRequestContext requestContext,long inParami_RequisitionId,long inParami_InvoiceId,long inParami_OrderId,long inParami_FolioId,long inParami_OrderRequestFileId,CancellationToken cancellationToken) {
lcvEventDeleteCacheStorageFromConcept localVars = new lcvEventDeleteCacheStorageFromConcept(inParami_RequisitionId, inParami_InvoiceId, inParami_OrderId, inParami_FolioId, inParami_OrderRequestFileId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EventDeleteCacheStorageFromConcept", "63012acd-aeef-4eb8-bbc3-d1236e86fd83"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EventDeleteCacheStorageFromConcept", "63012acd-aeef-4eb8-bbc3-d1236e86fd83", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Requisition?
if(((localVars.inParami_RequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Empty?
if((localVars.queryResGetRequisitionById_outParamList.Empty)) {
goto RETURN_STATEMENT;

} else {
// Query datasetGetRequisitionAccountingFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionAccountingFiles_maxRecords = 0;
int datasetGetRequisitionAccountingFiles_startIndex = 0;(localVars.queryResGetRequisitionAccountingFiles_outParamList,localVars.queryResGetRequisitionAccountingFiles_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetRequisitionAccountingFiles(requestContext,datasetGetRequisitionAccountingFiles_maxRecords,datasetGetRequisitionAccountingFiles_startIndex,IterationMultiplicity.Multiple,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetRequisitionContractFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionContractFiles_maxRecords = 0;
int datasetGetRequisitionContractFiles_startIndex = 0;(localVars.queryResGetRequisitionContractFiles_outParamList,localVars.queryResGetRequisitionContractFiles_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetRequisitionContractFiles(requestContext,datasetGetRequisitionContractFiles_maxRecords,datasetGetRequisitionContractFiles_startIndex,IterationMultiplicity.Multiple,localVars.inParami_RequisitionId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcStorageIdList,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetRequisitionAccountingFiles_outParamList, new BasicTypeList<long>(), async (RC_6d589cc6382d191584ced81e067dc8ba source, long target, CancellationToken cancellationToken) => {
target = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcStorageIdList,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetRequisitionContractFiles_outParamList, new BasicTypeList<long>(), async (RC_6d589cc6382d191584ced81e067dc8ba source, long target, CancellationToken cancellationToken) => {
target = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

}

} else {
// Invoice?
if(((localVars.inParami_InvoiceId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Empty?
if((localVars.queryResGetInvoiceById_outParamList.Empty)) {
goto RETURN_STATEMENT;

} else {
// Query datasetGetInvoiceFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles_maxRecords = 0;
int datasetGetInvoiceFiles_startIndex = 0;(localVars.queryResGetInvoiceFiles_outParamList,localVars.queryResGetInvoiceFiles_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Multiple,localVars.inParami_InvoiceId,cancellationToken);

// ListAppendAll3
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcStorageIdList,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetInvoiceFiles_outParamList, new BasicTypeList<long>(), async (RC_6d589cc6382d191584ced81e067dc8ba source, long target, CancellationToken cancellationToken) => {
target = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

}

} else {
// Order?
if(((localVars.inParami_OrderId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 1;
if (datasetGetOrderMainById_maxRecords < 1) datasetGetOrderMainById_maxRecords = 1;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// Empty?
if((localVars.queryResGetOrderMainById_outParamList.Empty)) {
goto RETURN_STATEMENT;

} else {
// Query datasetGetOrderContractFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderContractFiles_maxRecords = 0;
int datasetGetOrderContractFiles_startIndex = 0;(localVars.queryResGetOrderContractFiles_outParamList,localVars.queryResGetOrderContractFiles_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetOrderContractFiles(requestContext,datasetGetOrderContractFiles_maxRecords,datasetGetOrderContractFiles_startIndex,IterationMultiplicity.Multiple,localVars.inParami_OrderId,cancellationToken);

// ListAppendAll6
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcStorageIdList,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetOrderContractFiles_outParamList, new BasicTypeList<long>(), async (RC_6d589cc6382d191584ced81e067dc8ba source, long target, CancellationToken cancellationToken) => {
target = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

}

} else {
// OrderRequestFile?
if(((localVars.inParami_OrderRequestFileId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetOrderRequestFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFileById_maxRecords = 0;
int datasetGetOrderRequestFileById_startIndex = 0;(localVars.queryResGetOrderRequestFileById_outParamList,localVars.queryResGetOrderRequestFileById_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetOrderRequestFileById(requestContext,datasetGetOrderRequestFileById_maxRecords,datasetGetOrderRequestFileById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderRequestFileId,cancellationToken);

// Empty?
if((localVars.queryResGetOrderRequestFileById_outParamList.Empty)) {
goto RETURN_STATEMENT;

} else {
// Query datasetGetOrderRequestFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFiles_maxRecords = 0;
int datasetGetOrderRequestFiles_startIndex = 0;(localVars.queryResGetOrderRequestFiles_outParamList,localVars.queryResGetOrderRequestFiles_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetOrderRequestFiles(requestContext,datasetGetOrderRequestFiles_maxRecords,datasetGetOrderRequestFiles_startIndex,IterationMultiplicity.Multiple,localVars.inParami_OrderRequestFileId,cancellationToken);

// ListAppendAll7
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcStorageIdList,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetOrderRequestFiles_outParamList, new BasicTypeList<long>(), async (RC_6d589cc6382d191584ced81e067dc8ba source, long target, CancellationToken cancellationToken) => {
target = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

}

} else {
// Folio
if(((localVars.inParami_FolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
goto RETURN_STATEMENT;

} else {
// Query datasetGetFolioFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFiles_maxRecords = 0;
int datasetGetFolioFiles_startIndex = 0;(localVars.queryResGetFolioFiles_outParamList,localVars.queryResGetFolioFiles_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetFolioFiles(requestContext,datasetGetFolioFiles_maxRecords,datasetGetFolioFiles_startIndex,IterationMultiplicity.Multiple,localVars.inParami_FolioId,cancellationToken);

// Query datasetGetFolioInvoiceFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioInvoiceFiles_maxRecords = 0;
int datasetGetFolioInvoiceFiles_startIndex = 0;(localVars.queryResGetFolioInvoiceFiles_outParamList,localVars.queryResGetFolioInvoiceFiles_outParamCount) = await FuncActionEventDeleteCacheStorageFromConcept.datasetGetFolioInvoiceFiles(requestContext,datasetGetFolioInvoiceFiles_maxRecords,datasetGetFolioInvoiceFiles_startIndex,IterationMultiplicity.Multiple,localVars.inParami_FolioId,cancellationToken);

// ListAppendAll4
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcStorageIdList,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetFolioFiles_outParamList, new BasicTypeList<long>(), async (RC_6d589cc6382d191584ced81e067dc8ba source, long target, CancellationToken cancellationToken) => {
target = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll5
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcStorageIdList,(await BasicTypeList<long>.ConvertAsync(localVars.queryResGetFolioInvoiceFiles_outParamList, new BasicTypeList<long>(), async (RC_6d589cc6382d191584ced81e067dc8ba source, long target, CancellationToken cancellationToken) => {
target = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

}

} else {
goto RETURN_STATEMENT;

}

}

}

}

}

// DeleteCacheStorageFromList
await ServiceAPIs.ServiceAPIDeleteCacheStorageFromList(requestContext,localVars.varLcStorageIdList,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionEventDeleteCacheStorageFromConcept {

// Query Function "GetFolioById" Qv1xDNjJsk2NUtKbQ0t1Pg of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetFolioById", "0c71fd42-c9d8-4db2-8d52-d29b434b753e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetFolioById", "0c71fd42-c9d8-4db2-8d52-d29b434b753e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.Qv1xDNjJsk2NUtKbQ0t1Pg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio18\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio18\".\"id\" = @qpfoId) AND (\"enfolio18\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio18\".\"id\" IS NULL)");
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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

// Query Function "GetOrderContractFiles" 4EIKKhyTm06Gff9Mc+zq9g of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0822a9314a3d52420dc7ca5047ccbaee,long)> datasetGetOrderContractFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetOrderContractFiles", "2a0a42e0-931c-4e9b-867d-ff4c73eceaf6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetOrderContractFiles", "2a0a42e0-931c-4e9b-867d-ff4c73eceaf6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.4EIKKhyTm06Gff9Mc+zq9g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderfile\".\"storageid\" \"storageid\"");
fromBuilder.Append(" FROM ({OrderContractFile} \"enordercontractfile\" Left JOIN {OrderFile} \"enorderfile\" ON (\"enordercontractfile\".\"orderfileid\" = \"enorderfile\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderfile\".\"storageid\" IS NOT NULL)");
groupByBuilder.Append(" GROUP BY \"enorderfile\".\"storageid\"");
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
RL_0822a9314a3d52420dc7ca5047ccbaee outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetOrderContractFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0822a9314a3d52420dc7ca5047ccbaee _tmp = new RL_0822a9314a3d52420dc7ca5047ccbaee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetOrderContractFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0822a9314a3d52420dc7ca5047ccbaee)_tmp;
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

// Query Function "GetOrderRequestFiles" gyuMOxivZUOtXFvM2mTCrg of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0822a9314a3d52420dc7ca5047ccbaee,long)> datasetGetOrderRequestFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFile_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetOrderRequestFiles", "3b8c2b83-af18-4365-ad5c-5bccda64c2ae");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetOrderRequestFiles", "3b8c2b83-af18-4365-ad5c-5bccda64c2ae", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.gyuMOxivZUOtXFvM2mTCrg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderfile1\".\"storageid\" \"storageid\"");
fromBuilder.Append(" FROM (({OrderRequestFile} \"enorderrequestfile4\" Left JOIN {OrderContractFile} \"enordercontractfile1\" ON (\"enorderrequestfile4\".\"ordercontractfile\" = \"enordercontractfile1\".\"id\"))  Left JOIN {OrderFile} \"enorderfile1\" ON (\"enordercontractfile1\".\"orderfileid\" = \"enorderfile1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFile_Id != 0) {
whereBuilder.Append("((\"enorderrequestfile4\".\"id\" = @qporOrderRequestFile_Id) AND (\"enorderrequestfile4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFile_Id", DbType.Int64, qporOrderRequestFile_Id);
} else {
whereBuilder.Append("(\"enorderrequestfile4\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderfile1\".\"storageid\" IS NOT NULL)");
groupByBuilder.Append(" GROUP BY \"enorderfile1\".\"storageid\"");
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
RL_0822a9314a3d52420dc7ca5047ccbaee outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetOrderRequestFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0822a9314a3d52420dc7ca5047ccbaee _tmp = new RL_0822a9314a3d52420dc7ca5047ccbaee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetOrderRequestFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0822a9314a3d52420dc7ca5047ccbaee)_tmp;
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

// Query Function "GetInvoiceById" BLlaaZhvPE+vbn_fwtGcOg of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetInvoiceById", "695ab904-6f98-4f3c-af6e-7fdfc2d19c3a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetInvoiceById", "695ab904-6f98-4f3c-af6e-7fdfc2d19c3a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.BLlaaZhvPE+vbn_fwtGcOg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice22\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoice22\".\"id\" = @qpinId) AND (\"eninvoice22\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoice22\".\"id\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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

// Query Function "GetRequisitionAccountingFiles" hbfgb408pU+P0BuuKA1MNQ of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0822a9314a3d52420dc7ca5047ccbaee,long)> datasetGetRequisitionAccountingFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccounting_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetRequisitionAccountingFiles", "6fe0b785-3c8d-4fa5-8fd0-1bae280d4c35");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetRequisitionAccountingFiles", "6fe0b785-3c8d-4fa5-8fd0-1bae280d4c35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.hbfgb408pU+P0BuuKA1MNQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionfile24\".\"storageid\" \"storageid\"");
fromBuilder.Append(" FROM ({RequisitionAccounting} \"enrequisitionaccounting1\" Left JOIN {RequisitionFile2} \"enrequisitionfile24\" ON (\"enrequisitionaccounting1\".\"evidencefileid\" = \"enrequisitionfile24\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccounting_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionaccounting1\".\"requisitionid\" = @qpreRequisitionAccounting_RequisitionId) AND (\"enrequisitionaccounting1\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccounting_RequisitionId", DbType.Int64, qpreRequisitionAccounting_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionaccounting1\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionfile24\".\"storageid\" IS NOT NULL)");
groupByBuilder.Append(" GROUP BY \"enrequisitionfile24\".\"storageid\"");
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
RL_0822a9314a3d52420dc7ca5047ccbaee outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetRequisitionAccountingFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0822a9314a3d52420dc7ca5047ccbaee _tmp = new RL_0822a9314a3d52420dc7ca5047ccbaee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetRequisitionAccountingFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0822a9314a3d52420dc7ca5047ccbaee)_tmp;
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

// Query Function "GetRequisitionById" l2H4d_cgCEepCmN2N9f7Fw of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0ad79b64673379e41188da81c3628c0f,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetRequisitionById", "77f86197-20f7-4708-a90a-637637d7fb17");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetRequisitionById", "77f86197-20f7-4708-a90a-637637d7fb17", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.l2H4d_cgCEepCmN2N9f7Fw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM {Requisition} \"enrequisition27\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enrequisition27\".\"id\" = @qpreId) AND (\"enrequisition27\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enrequisition27\".\"id\" IS NULL)");
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
RL_0ad79b64673379e41188da81c3628c0f outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0ad79b64673379e41188da81c3628c0f _tmp = new RL_0ad79b64673379e41188da81c3628c0f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0ad79b64673379e41188da81c3628c0f)_tmp;
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

// Query Function "GetInvoiceFiles" JM7mhrM1F06kiI03lbGnJw of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0822a9314a3d52420dc7ca5047ccbaee,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetInvoiceFiles", "86e6ce24-35b3-4e17-a488-8d3795b1a727");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetInvoiceFiles", "86e6ce24-35b3-4e17-a488-8d3795b1a727", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.JM7mhrM1F06kiI03lbGnJw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicefile6\".\"storageid\" \"storageid\"");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile6\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile6\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile6\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile6\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoicefile6\".\"storageid\" IS NOT NULL)");
groupByBuilder.Append(" GROUP BY \"eninvoicefile6\".\"storageid\"");
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
RL_0822a9314a3d52420dc7ca5047ccbaee outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0822a9314a3d52420dc7ca5047ccbaee _tmp = new RL_0822a9314a3d52420dc7ca5047ccbaee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0822a9314a3d52420dc7ca5047ccbaee)_tmp;
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

// Query Function "GetOrderMainById" TUQ6mMG8kEOABm89bCG1Fg of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetOrderMainById", "983a444d-bcc1-4390-8006-6f3d6c21b516");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetOrderMainById", "983a444d-bcc1-4390-8006-6f3d6c21b516", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.TUQ6mMG8kEOABm89bCG1Fg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain29\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain29\".\"id\" = @qporId) AND (\"enordermain29\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain29\".\"id\" IS NULL)");
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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

// Query Function "GetOrderRequestFileById" HqOLpDkdKUaPHr4Ay6Af7g of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_d258c3d50d870257794347fdeb7cc218,long)> datasetGetOrderRequestFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetOrderRequestFileById", "a48ba31e-1d39-4629-8f1e-be00cba01fee");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetOrderRequestFileById", "a48ba31e-1d39-4629-8f1e-be00cba01fee", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.HqOLpDkdKUaPHr4Ay6Af7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM {OrderRequestFile} \"enorderrequestfile5\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enorderrequestfile5\".\"id\" = @qporId) AND (\"enorderrequestfile5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enorderrequestfile5\".\"id\" IS NULL)");
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
RL_d258c3d50d870257794347fdeb7cc218 outParamList = new RL_d258c3d50d870257794347fdeb7cc218();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d258c3d50d870257794347fdeb7cc218 _tmp = new RL_d258c3d50d870257794347fdeb7cc218();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d258c3d50d870257794347fdeb7cc218)_tmp;
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

// Query Function "GetRequisitionContractFiles" AZf6qVAIxkOftbMS_1pysw of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0822a9314a3d52420dc7ca5047ccbaee,long)> datasetGetRequisitionContractFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetRequisitionContractFiles", "a9fa9701-0850-43c6-9fb5-b312ff5a72b3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetRequisitionContractFiles", "a9fa9701-0850-43c6-9fb5-b312ff5a72b3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.AZf6qVAIxkOftbMS_1pysw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionfile25\".\"storageid\" \"storageid\"");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile4\" Left JOIN {RequisitionFile2} \"enrequisitionfile25\" ON (\"enrequisitioncontractfile4\".\"requisitionfileid\" = \"enrequisitionfile25\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile4\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile4\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile4\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionfile25\".\"storageid\" IS NOT NULL)");
groupByBuilder.Append(" GROUP BY \"enrequisitionfile25\".\"storageid\"");
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
RL_0822a9314a3d52420dc7ca5047ccbaee outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetRequisitionContractFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0822a9314a3d52420dc7ca5047ccbaee _tmp = new RL_0822a9314a3d52420dc7ca5047ccbaee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetRequisitionContractFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0822a9314a3d52420dc7ca5047ccbaee)_tmp;
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

// Query Function "GetFolioInvoiceFiles" QSPJ66wS1UaMnV9cyEyjsQ of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0822a9314a3d52420dc7ca5047ccbaee,long)> datasetGetFolioInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetFolioInvoiceFiles", "ebc92341-12ac-46d5-8c9d-5f5cc84ca3b1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetFolioInvoiceFiles", "ebc92341-12ac-46d5-8c9d-5f5cc84ca3b1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.QSPJ66wS1UaMnV9cyEyjsQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicefile7\".\"storageid\" \"storageid\"");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice23\" Inner JOIN {InvoiceFile} \"eninvoicefile7\" ON (\"eninvoice23\".\"id\" = \"eninvoicefile7\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice23\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice23\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice23\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoicefile7\".\"storageid\" IS NOT NULL)");
groupByBuilder.Append(" GROUP BY \"eninvoicefile7\".\"storageid\"");
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
RL_0822a9314a3d52420dc7ca5047ccbaee outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetFolioInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0822a9314a3d52420dc7ca5047ccbaee _tmp = new RL_0822a9314a3d52420dc7ca5047ccbaee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetFolioInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0822a9314a3d52420dc7ca5047ccbaee)_tmp;
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

// Query Function "GetFolioFiles" QwT++DrxSkWkPCsw3tAK_g of Action "EventDeleteCacheStorageFromConcept"
public static async Task<(RL_0822a9314a3d52420dc7ca5047ccbaee,long)> datasetGetFolioFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventDeleteCacheStorageFromConcept.GetFolioFiles", "f8fe0443-f13a-454a-a43c-2b30ded00afe");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventDeleteCacheStorageFromConcept.GetFolioFiles", "f8fe0443-f13a-454a-a43c-2b30ded00afe", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zSoBY++uuE67w9Ejbob9gw/NodesNotShownInESpaceTree.QwT++DrxSkWkPCsw3tAK_g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliofiles1\".\"storageid\" \"storageid\"");
fromBuilder.Append(" FROM {FolioFiles} \"enfoliofiles1\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliofiles1\".\"folioid\" = @qpfoFolioId) AND (\"enfoliofiles1\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliofiles1\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfoliofiles1\".\"storageid\" IS NOT NULL)");
groupByBuilder.Append(" GROUP BY \"enfoliofiles1\".\"storageid\"");
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
RL_0822a9314a3d52420dc7ca5047ccbaee outParamList = new RL_0822a9314a3d52420dc7ca5047ccbaee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventDeleteCacheStorageFromConcept.GetFolioFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0822a9314a3d52420dc7ca5047ccbaee _tmp = new RL_0822a9314a3d52420dc7ca5047ccbaee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventDeleteCacheStorageFromConcept.GetFolioFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0822a9314a3d52420dc7ca5047ccbaee)_tmp;
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
