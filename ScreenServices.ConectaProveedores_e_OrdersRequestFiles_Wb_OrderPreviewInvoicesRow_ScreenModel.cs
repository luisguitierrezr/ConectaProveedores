using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public AggregateRecord<RL_e40371698c3bd2f83f525cf47c117634> ScreenDataSetGetInvoiceFilesByInvoiceId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel() {
}



    public ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel(long inParami_InvoiceId, AggregateRecord<RL_e40371698c3bd2f83f525cf47c117634> ScreenDataSetGetInvoiceFilesByInvoiceId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "GetInvoiceFilesByInvoiceId", "ClientVars"}, new string[] {"inParami_InvoiceId", "ScreenDataSetGetInvoiceFilesByInvoiceId", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.ScreenDataSetGetInvoiceFilesByInvoiceId = ScreenDataSetGetInvoiceFilesByInvoiceId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_7cb091de697d14a1ce465208aa77fcb0> datasetGetInvoiceFilesByInvoiceIdReadDbAsync(RC_7cb091de697d14a1ce465208aa77fcb0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFilesByInvoiceId" z+jVa1XDdUyW3TLRqk4dVg of Action "Wb_OrderPreviewInvoicesRow"
public static async Task<(RL_e40371698c3bd2f83f525cf47c117634,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.GetInvoiceFilesByInvoiceId", "6bd5e8cf-c355-4c75-96dd-32d1aa4e1d56");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderPreviewInvoicesRow","e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.GetInvoiceFilesByInvoiceId");
// Query Iterations: Multiple
// Refresh Query j4k9wd7WkkGya5a3EL8c5w Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.QVuy0_xq1k6uAfJb8WCO0A/NodesShownInESpaceTree.dtuVylIDuEasDAb8xGd11Q/ScreenDataSets.z+jVa1XDdUyW3TLRqk4dVg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoicefile50\".\"filename\" o2, NULL o3, NULL o4, \"eninvoicefile50\".\"storageid\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage33\".\"size\" o26, NULL o27");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile50\" Inner JOIN {Storage} \"enstorage33\" ON (\"eninvoicefile50\".\"storageid\" = \"enstorage33\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile50\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile50\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile50\".\"invoiceid\" IS NULL)");
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
RL_e40371698c3bd2f83f525cf47c117634 outParamList = new RL_e40371698c3bd2f83f525cf47c117634();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e40371698c3bd2f83f525cf47c117634 _tmp = new RL_e40371698c3bd2f83f525cf47c117634();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_OrdersRequestFiles.Wb_OrderPreviewInvoicesRow.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e40371698c3bd2f83f525cf47c117634)_tmp;
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
