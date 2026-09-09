using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public int varLcl_MaxRecords;
public string varLcNewMsg;
public bool varLcIsOpenMenu;
public bool varLcIsPublic;
public AggregateRecord<RL_2b8298c99eec97081abcd9d7211953b5> ScreenDataSetGetInvoiceCommentsByInvoiceId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel(long inParami_InvoiceId, int varLcl_MaxRecords, string varLcNewMsg, bool varLcIsOpenMenu, bool varLcIsPublic, AggregateRecord<RL_2b8298c99eec97081abcd9d7211953b5> ScreenDataSetGetInvoiceCommentsByInvoiceId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "l_MaxRecords", "NewMsg", "IsOpenMenu", "IsPublic", "GetInvoiceCommentsByInvoiceId", "ClientVars"}, new string[] {"inParami_InvoiceId", "varLcl_MaxRecords", "varLcNewMsg", "varLcIsOpenMenu", "varLcIsPublic", "ScreenDataSetGetInvoiceCommentsByInvoiceId", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.varLcl_MaxRecords = varLcl_MaxRecords;
this.varLcNewMsg = varLcNewMsg;
this.varLcIsOpenMenu = varLcIsOpenMenu;
this.varLcIsPublic = varLcIsPublic;
this.ScreenDataSetGetInvoiceCommentsByInvoiceId = ScreenDataSetGetInvoiceCommentsByInvoiceId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_e3f679a5677e9bcd15fc4cdbc37afdac> datasetGetInvoiceCommentsByInvoiceIdReadDbAsync(RC_e3f679a5677e9bcd15fc4cdbc37afdac rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceComment.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceCommentsByInvoiceId" y+EkE+_uKEmrOi3TBlRt4Q of Action "Wb_InvoiceDetailsChat"
public static async Task<(RL_2b8298c99eec97081abcd9d7211953b5,long)> datasetGetInvoiceCommentsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,long qpinInvoiceComment_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetailsChat.GetInvoiceCommentsByInvoiceId", "1324e1cb-eeef-4928-ab3a-2dd306546de1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetailsChat","d_Invoices.Wb_InvoiceDetailsChat.GetInvoiceCommentsByInvoiceId");
// Query Iterations: Multiple
// Refresh Query JT0vWdEgjE2Gk6L3vjH4KA Iterations: Multiple
// Refresh Query QDsgUXxBmkSNOT_NbOEdig Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.xGUhgGmXC0yb_OZYi4fNbA/ScreenDataSets.y+EkE+_uKEmrOi3TBlRt4Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"eninvoicecomment1\".\"createdon\" o4, \"eninvoicecomment1\".\"createdby\" o5, \"eninvoicecomment1\".\"message\" o6, \"eninvoicecomment1\".\"ispublic\" o7, NULL o8, \"enuser171\".\"name\" o9, NULL o10, \"enuser171\".\"photourl\" o11, \"enuser171\".\"username\" o12");
fromBuilder.Append(" FROM ({InvoiceComment} \"eninvoicecomment1\" Left JOIN {User} \"enuser171\" ON (\"eninvoicecomment1\".\"createdby\" = \"enuser171\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceComment_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicecomment1\".\"invoiceid\" = @qpinInvoiceComment_InvoiceId) AND (\"eninvoicecomment1\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceComment_InvoiceId", DbType.Int64, qpinInvoiceComment_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicecomment1\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND ((NOT (@qpboCheckProveedorRole = 1)) OR (\"eninvoicecomment1\".\"ispublic\" = 1))");
orderByBuilder.Append(" ORDER BY \"eninvoicecomment1\".\"createdon\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
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
RL_2b8298c99eec97081abcd9d7211953b5 outParamList = new RL_2b8298c99eec97081abcd9d7211953b5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceCommentsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetailsChat.GetInvoiceCommentsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b8298c99eec97081abcd9d7211953b5 _tmp = new RL_2b8298c99eec97081abcd9d7211953b5();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceCommentsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetailsChat.GetInvoiceCommentsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2b8298c99eec97081abcd9d7211953b5)_tmp;
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
