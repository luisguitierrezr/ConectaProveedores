using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel).Namespace);

    public long inParamInvoiceId;
public string inParamZipName;
public string inParamButtonName;
public RL_e2f87228588c7237002d108caedf9018 varLcFileJsonList;
public AggregateRecord<RL_9d61cc7501a4784be77b036c540a3e93> ScreenDataSetGetInvoicesByFolioId;
public AggregateRecord<RL_599a55f2ca551e3817b27381ea3fcd80> ScreenDataSetGetFolioFilesByFolioId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel() {
}



    public ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel(long inParamInvoiceId, string inParamZipName, string inParamButtonName, RL_e2f87228588c7237002d108caedf9018 varLcFileJsonList, AggregateRecord<RL_9d61cc7501a4784be77b036c540a3e93> ScreenDataSetGetInvoicesByFolioId, AggregateRecord<RL_599a55f2ca551e3817b27381ea3fcd80> ScreenDataSetGetFolioFilesByFolioId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "ZipName", "ButtonName", "FileJsonList", "GetInvoicesByFolioId", "GetFolioFilesByFolioId", "ClientVars"}, new string[] {"inParamInvoiceId", "inParamZipName", "inParamButtonName", "varLcFileJsonList", "ScreenDataSetGetInvoicesByFolioId", "ScreenDataSetGetFolioFilesByFolioId", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.inParamZipName = inParamZipName;
this.inParamButtonName = inParamButtonName;
this.varLcFileJsonList = varLcFileJsonList;
this.ScreenDataSetGetInvoicesByFolioId = ScreenDataSetGetInvoicesByFolioId;
this.ScreenDataSetGetFolioFilesByFolioId = ScreenDataSetGetFolioFilesByFolioId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_d0f36b0aa01c99a6864922a3e47b0bc5> datasetGetInvoicesByFolioIdReadDbAsync(RC_d0f36b0aa01c99a6864922a3e47b0bc5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" 77W3xm6D2UqjOxKdHkxzHA of Action "wb_DownloadAllFolioFilesByInvoiceId"
public static async Task<(RL_9d61cc7501a4784be77b036c540a3e93,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetInvoicesByFolioId", "c6b7b5ef-836e-4ad9-a33b-129d1e4c731c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_DownloadAllFolioFilesByInvoiceId","s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetInvoicesByFolioId");
// Query Iterations: Multiple
// Refresh Query f+V+YcGQoEeVmZpdKpsZxw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.2U30RcCSoUG+QhQMrCUZgA/NodesShownInESpaceTree.zy4VQRcjVEye_1izlJQnCQ/ScreenDataSets.77W3xm6D2UqjOxKdHkxzHA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"eninvoice133\".\"folioid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enstorage27\".\"id\" o32, NULL o33, NULL o34, NULL o35, \"enstorage27\".\"filename\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"enstorage27\".\"size\" o50, NULL o51");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice133\" Inner JOIN {InvoiceFile} \"eninvoicefile47\" ON (\"eninvoice133\".\"id\" = \"eninvoicefile47\".\"invoiceid\"))  Inner JOIN {Storage} \"enstorage27\" ON (\"eninvoicefile47\".\"storageid\" = \"enstorage27\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice133\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice133\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice133\".\"id\" IS NULL)");
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
RL_9d61cc7501a4784be77b036c540a3e93 outParamList = new RL_9d61cc7501a4784be77b036c540a3e93();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9d61cc7501a4784be77b036c540a3e93 _tmp = new RL_9d61cc7501a4784be77b036c540a3e93();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9d61cc7501a4784be77b036c540a3e93)_tmp;
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

private static async Task<RC_db98be0f77f582e2a41dd64bb6a4005e> datasetGetFolioFilesByFolioIdReadDbAsync(RC_db98be0f77f582e2a41dd64bb6a4005e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioFiles.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetFolioFilesByFolioId" Pw275+K+z0Wd7lnnxzBAGA of Action "wb_DownloadAllFolioFilesByInvoiceId"
public static async Task<(RL_599a55f2ca551e3817b27381ea3fcd80,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioFiles_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetFolioFilesByFolioId", "e7bb0d3f-bee2-45cf-9dee-59e7c7304018");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_DownloadAllFolioFilesByInvoiceId","s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetFolioFilesByFolioId");
// Query Iterations: Multiple
// Refresh Query n69Rt8ngJkKom2QfREd1ZA Iterations: Multiple
// Refresh Query k+lh7NJzCUu02gJs5epyRg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.2U30RcCSoUG+QhQMrCUZgA/NodesShownInESpaceTree.zy4VQRcjVEye_1izlJQnCQ/ScreenDataSets.Pw275+K+z0Wd7lnnxzBAGA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enstorage28\".\"id\" o8, NULL o9, NULL o10, NULL o11, \"enstorage28\".\"filename\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage28\".\"size\" o26, NULL o27");
fromBuilder.Append(" FROM ({FolioFiles} \"enfoliofiles6\" Inner JOIN {Storage} \"enstorage28\" ON (\"enfoliofiles6\".\"storageid\" = \"enstorage28\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioFiles_FolioId != 0) {
whereBuilder.Append("((\"enfoliofiles6\".\"folioid\" = @qpfoFolioFiles_FolioId) AND (\"enfoliofiles6\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioFiles_FolioId", DbType.Int64, qpfoFolioFiles_FolioId);
} else {
whereBuilder.Append("(\"enfoliofiles6\".\"folioid\" IS NULL)");
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
RL_599a55f2ca551e3817b27381ea3fcd80 outParamList = new RL_599a55f2ca551e3817b27381ea3fcd80();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioFilesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_599a55f2ca551e3817b27381ea3fcd80 _tmp = new RL_599a55f2ca551e3817b27381ea3fcd80();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioFilesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query s_Storage.wb_DownloadAllFolioFilesByInvoiceId.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_599a55f2ca551e3817b27381ea3fcd80)_tmp;
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
