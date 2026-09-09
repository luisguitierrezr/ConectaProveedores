using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_Loading;
public bool varLcl_ReInvokeToggler;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public AggregateRecord<RL_e14179ee8651dc8cb6e49b70d6c98c9d> ScreenDataSetGetInvoiceItemsByInvoiceId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_ScreenModel(long inParami_InvoiceId, string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_Loading, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, AggregateRecord<RL_e14179ee8651dc8cb6e49b70d6c98c9d> ScreenDataSetGetInvoiceItemsByInvoiceId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "l_ColumnJSONVar", "l_CountAfterFetch", "l_Loading", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "GetInvoiceItemsByInvoiceId", "ClientVars"}, new string[] {"inParami_InvoiceId", "varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_Loading", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "ScreenDataSetGetInvoiceItemsByInvoiceId", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.ScreenDataSetGetInvoiceItemsByInvoiceId = ScreenDataSetGetInvoiceItemsByInvoiceId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_f5e2444cde8ccebe1d8b8fbec7a36039> datasetGetInvoiceItemsByInvoiceIdReadDbAsync(RC_f5e2444cde8ccebe1d8b8fbec7a36039 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtendedItem.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceItemsByInvoiceId" NYov24lkuUCAWGNJQ0GiTQ of Action "Wb_InvoiceDetailsItems"
public static async Task<(RL_e14179ee8651dc8cb6e49b70d6c98c9d,long)> datasetGetInvoiceItemsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItem_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetailsItems.GetInvoiceItemsByInvoiceId", "db2f8a35-6489-40b9-8058-63494341a24d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetailsItems","d_Invoices.Wb_InvoiceDetailsItems.GetInvoiceItemsByInvoiceId");
// Query Iterations: Multiple
// Refresh Query 5Akh_BPQG0usPaVEd9GbMQ Iterations: Multiple
// Refresh Query tJiBfV+e5EO4COGypnE67A Iterations: Multiple
// Refresh Query RNlYKken0UOpwaiCc0OWng Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.g8_p1i_8dkyG78ePsDzz4w/ScreenDataSets.NYov24lkuUCAWGNJQ0GiTQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency10\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"eninvoiceextendeditem10\".\"productnumber\" o31, \"eninvoiceextendeditem10\".\"description\" o32, \"eninvoiceextendeditem10\".\"materialcode\" o33, \"eninvoiceextendeditem10\".\"quantity\" o34, trim_scale(\"eninvoiceextendeditem10\".\"unityprice\"::numeric) o35, NULL o36, NULL o37, \"enrequisition103\".\"name\" o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94");
fromBuilder.Append(" FROM ((({InvoiceExtendedItem} \"eninvoiceextendeditem10\" Left JOIN {Invoice} \"eninvoice127\" ON (\"eninvoiceextendeditem10\".\"invoiceid\" = \"eninvoice127\".\"id\"))  Left JOIN {Currency} \"encurrency10\" ON (\"eninvoiceextendeditem10\".\"currency\" = \"encurrency10\".\"code\"))  Left JOIN {Requisition} \"enrequisition103\" ON (\"eninvoice127\".\"requisitionid\" = \"enrequisition103\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItem_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem10\".\"invoiceid\" = @qpinInvoiceExtendedItem_InvoiceId) AND (\"eninvoiceextendeditem10\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItem_InvoiceId", DbType.Int64, qpinInvoiceExtendedItem_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem10\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceextendeditem10\".\"description\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_e14179ee8651dc8cb6e49b70d6c98c9d outParamList = new RL_e14179ee8651dc8cb6e49b70d6c98c9d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceItemsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, false, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetailsItems.GetInvoiceItemsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e14179ee8651dc8cb6e49b70d6c98c9d _tmp = new RL_e14179ee8651dc8cb6e49b70d6c98c9d();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceItemsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetailsItems.GetInvoiceItemsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e14179ee8651dc8cb6e49b70d6c98c9d)_tmp;
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
