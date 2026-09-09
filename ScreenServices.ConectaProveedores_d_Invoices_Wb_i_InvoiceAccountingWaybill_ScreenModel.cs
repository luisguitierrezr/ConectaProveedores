using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public string inParami_ExtendedClass;
public AggregateRecord<RL_14eea858c7edac2969e2f91a68030ca7> ScreenDataSetGetInvoiceWaybill;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel(long inParami_InvoiceId, string inParami_ExtendedClass, AggregateRecord<RL_14eea858c7edac2969e2f91a68030ca7> ScreenDataSetGetInvoiceWaybill, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_ExtendedClass", "GetInvoiceWaybill", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_ExtendedClass", "ScreenDataSetGetInvoiceWaybill", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_ExtendedClass = inParami_ExtendedClass;
this.ScreenDataSetGetInvoiceWaybill = ScreenDataSetGetInvoiceWaybill;
this.clientVariables = clientVariables;
}



    
// Query Function "GetInvoiceWaybill" mrUd_Dv3u0ii_dgyf+J2_Q of Action "Wb_i_InvoiceAccountingWaybill"
public static async Task<(RL_14eea858c7edac2969e2f91a68030ca7,long)> datasetGetInvoiceWaybill(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccountingWaybill.GetInvoiceWaybill", "fc1db59a-f73b-48bb-a2fd-d8327fe276fd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccountingWaybill","d_Invoices.Wb_i_InvoiceAccountingWaybill.GetInvoiceWaybill");
// Query Iterations: Never
// Refresh Query MvTGB67DsEyz_h5nmZP5rw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.+k486IPsI0a0nTHYewjRzw/ScreenDataSets.mrUd_Dv3u0ii_dgyf+J2_Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceextendedcartaporte2\".\"descripcion\" o1, trim_scale(\"eninvoiceextendedcartaporte2\".\"valormercancia\"::numeric) o2, \"eninvoiceextendedcartaporte2\".\"centroatencion\" o3, \"eninvoiceextendedcartaporte2\".\"calle\" o4, \"eninvoiceextendedcartaporte2\".\"numeroexterior\" o5, \"eninvoiceextendedcartaporte2\".\"codigopostal\" o6");
fromBuilder.Append(" FROM {InvoiceExtendedCartaPorte} \"eninvoiceextendedcartaporte2\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceextendedcartaporte2\".\"id\" = @qpinId) AND (\"eninvoiceextendedcartaporte2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceextendedcartaporte2\".\"id\" IS NULL)");
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
RL_14eea858c7edac2969e2f91a68030ca7 outParamList = new RL_14eea858c7edac2969e2f91a68030ca7();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccountingWaybill.GetInvoiceWaybill.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_14eea858c7edac2969e2f91a68030ca7 _tmp = new RL_14eea858c7edac2969e2f91a68030ca7();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccountingWaybill.GetInvoiceWaybill.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_14eea858c7edac2969e2f91a68030ca7)_tmp;
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
