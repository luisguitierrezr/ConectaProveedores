using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_ScreenModel).Namespace);

    public long inParamFolioId;
public string varLcErrorMsg;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public bool varLcHasChanged;
public AggregateRecord<RL_5a0829a2b3c6573471cd9bfcbf323787> ScreenDataSetGetSupplierUsersByUserId;
public AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetInvoiceFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_ScreenModel(long inParamFolioId, string varLcErrorMsg, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, bool varLcHasChanged, AggregateRecord<RL_5a0829a2b3c6573471cd9bfcbf323787> ScreenDataSetGetSupplierUsersByUserId, AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetInvoiceFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioId", "ErrorMsg", "FilesList", "HasChanged", "GetSupplierUsersByUserId", "GetInvoiceFiles", "ClientVars"}, new string[] {"inParamFolioId", "varLcErrorMsg", "varLcFilesList", "varLcHasChanged", "ScreenDataSetGetSupplierUsersByUserId", "ScreenDataSetGetInvoiceFiles", "clientVariables"});
this.inParamFolioId = inParamFolioId;
this.varLcErrorMsg = varLcErrorMsg;
this.varLcFilesList = varLcFilesList;
this.varLcHasChanged = varLcHasChanged;
this.ScreenDataSetGetSupplierUsersByUserId = ScreenDataSetGetSupplierUsersByUserId;
this.ScreenDataSetGetInvoiceFiles = ScreenDataSetGetInvoiceFiles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_187912d0df64c67be181be3d4f7af5f3> datasetGetSupplierUsersByUserIdReadDbAsync(RC_187912d0df64c67be181be3d4f7af5f3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierUsersByUserId" Ob3QHmIKEU+7vfYi6a_jyw of Action "Wb_SupportSAEUploadEdit"
public static async Task<(RL_5a0829a2b3c6573471cd9bfcbf323787,long)> datasetGetSupplierUsersByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusSupplierUser_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SupportSAEUploadEdit.GetSupplierUsersByUserId", "1ed0bd39-0a62-4f11-bbbd-f622e9afe3cb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SupportSAEUploadEdit","j_FoliosSAE.Wb_SupportSAEUploadEdit.GetSupplierUsersByUserId");
// Query Iterations: Never
// Refresh Query 2mT3Ajf+AUOIG0RSnvVY2A Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MPPaQaX+UkKrNdmEUJc8Qg/ScreenDataSets.Ob3QHmIKEU+7vfYi6a_jyw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42");
fromBuilder.Append(" FROM ({SupplierUser} \"ensupplieruser26\" Left JOIN {Supplier} \"ensupplier137\" ON (\"ensupplieruser26\".\"supplierid\" = \"ensupplier137\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusSupplierUser_UserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser26\".\"userid\" = @qpusSupplierUser_UserId) AND (\"ensupplieruser26\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusSupplierUser_UserId", DbType.String, qpusSupplierUser_UserId);
} else {
whereBuilder.Append("(\"ensupplieruser26\".\"userid\" IS NULL)");
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
RL_5a0829a2b3c6573471cd9bfcbf323787 outParamList = new RL_5a0829a2b3c6573471cd9bfcbf323787();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierUsersByUserIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SupportSAEUploadEdit.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5a0829a2b3c6573471cd9bfcbf323787 _tmp = new RL_5a0829a2b3c6573471cd9bfcbf323787();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierUsersByUserIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SupportSAEUploadEdit.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5a0829a2b3c6573471cd9bfcbf323787)_tmp;
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

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoiceFilesReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles" acWerb4D1ESWuICguub+qA of Action "Wb_SupportSAEUploadEdit"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SupportSAEUploadEdit.GetInvoiceFiles", "ad9ec569-03be-44d4-96b8-80a0bae6fea8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SupportSAEUploadEdit","j_FoliosSAE.Wb_SupportSAEUploadEdit.GetInvoiceFiles");
// Query Iterations: Multiple
// Refresh Query DCbYhVzDHE6w63a7p2l2ZA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MPPaQaX+UkKrNdmEUJc8Qg/ScreenDataSets.acWerb4D1ESWuICguub+qA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"eninvoicefile55\".\"filename\" o26, \"eninvoicefile55\".\"isextra\" o27, NULL o28, \"eninvoicefile55\".\"storageid\" o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile55\" Inner JOIN {Invoice} \"eninvoice151\" ON (\"eninvoicefile55\".\"invoiceid\" = \"eninvoice151\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice151\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice151\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice151\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoicefile55\".\"isextra\" = 1)");
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
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SupportSAEUploadEdit.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SupportSAEUploadEdit.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ff28012de5324af3e81e5ace09ecb1f0)_tmp;
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
