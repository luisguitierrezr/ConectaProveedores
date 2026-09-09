using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public string inParami_InvoiceName;
public bool inParami_IsSaveAllFiles;
public bool inParami_IsSaveSelectedFiles;
public AggregateRecord<RL_a8a8885e97333843e8d61cbbac75c28c> ScreenDataSetInvoiceFilesById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel() {
}



    public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel(long inParami_InvoiceId, string inParami_InvoiceName, bool inParami_IsSaveAllFiles, bool inParami_IsSaveSelectedFiles, AggregateRecord<RL_a8a8885e97333843e8d61cbbac75c28c> ScreenDataSetInvoiceFilesById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_InvoiceName", "i_IsSaveAllFiles", "i_IsSaveSelectedFiles", "InvoiceFilesById", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_InvoiceName", "inParami_IsSaveAllFiles", "inParami_IsSaveSelectedFiles", "ScreenDataSetInvoiceFilesById", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceName = inParami_InvoiceName;
this.inParami_IsSaveAllFiles = inParami_IsSaveAllFiles;
this.inParami_IsSaveSelectedFiles = inParami_IsSaveSelectedFiles;
this.ScreenDataSetInvoiceFilesById = ScreenDataSetInvoiceFilesById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_eb0c76f6f640a3fe05b6e66cf112863f> datasetInvoiceFilesByIdReadDbAsync(RC_eb0c76f6f640a3fe05b6e66cf112863f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "InvoiceFileIsSelectedStorageRecord.IsSelected", false);
return rec;
}
// Query Function "InvoiceFilesById" 0oRbMCFq8EaLb+dSd_BKZA of Action "Wb_InvoiceFilesAudit"
public static async Task<(RL_a8a8885e97333843e8d61cbbac75c28c,long)> datasetInvoiceFilesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoiceAudit.Wb_InvoiceFilesAudit.InvoiceFilesById", "305b84d2-6a21-46f0-8b6f-e75277f04a64");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceFilesAudit","d_InvoiceAudit.Wb_InvoiceFilesAudit.InvoiceFilesById");
// Query Iterations: Multiple
// Refresh Query zJVcLbYldEeHm0EEjQvTpg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.QghyiWtm3kyZz6m9v9fCNw/NodesShownInESpaceTree.E5Kiqxep_kyPF6G70vMpDw/ScreenDataSets.0oRbMCFq8EaLb+dSd_BKZA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoicefile49\".\"filename\" o2, NULL o3, NULL o4, \"eninvoicefile49\".\"storageid\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage31\".\"size\" o26, NULL o27, 0 \"isselected\"");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile49\" Inner JOIN {Storage} \"enstorage31\" ON (\"eninvoicefile49\".\"storageid\" = \"enstorage31\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile49\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile49\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile49\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (\"eninvoicefile49\".\"isextra\" = 1))");
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
RL_a8a8885e97333843e8d61cbbac75c28c outParamList = new RL_a8a8885e97333843e8d61cbbac75c28c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetInvoiceFilesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.Wb_InvoiceFilesAudit.InvoiceFilesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a8a8885e97333843e8d61cbbac75c28c _tmp = new RL_a8a8885e97333843e8d61cbbac75c28c();
_tmp.AlternateReadDbMethodAsync = datasetInvoiceFilesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.Wb_InvoiceFilesAudit.InvoiceFilesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a8a8885e97333843e8d61cbbac75c28c)_tmp;
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
