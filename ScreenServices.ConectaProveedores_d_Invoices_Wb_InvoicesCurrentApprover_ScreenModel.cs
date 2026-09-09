using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel).Namespace);

    public long inParamInvoiceId;
public AggregateRecord<RL_bed92cf49c584b7d4ab2b8923c043fa1> ScreenDataSetGetInvoiceApprovalsCurrentApprover;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel(long inParamInvoiceId, AggregateRecord<RL_bed92cf49c584b7d4ab2b8923c043fa1> ScreenDataSetGetInvoiceApprovalsCurrentApprover, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "GetInvoiceApprovalsCurrentApprover", "ClientVars"}, new string[] {"inParamInvoiceId", "ScreenDataSetGetInvoiceApprovalsCurrentApprover", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.ScreenDataSetGetInvoiceApprovalsCurrentApprover = ScreenDataSetGetInvoiceApprovalsCurrentApprover;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_0c929027c696b201a1aceb2f23c1d74d> datasetGetInvoiceApprovalsCurrentApproverReadDbAsync(RC_0c929027c696b201a1aceb2f23c1d74d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalsCurrentApprover" diJnpDtqM0KOBAjTbs5sqA of Action "Wb_InvoicesCurrentApprover"
public static async Task<(RL_bed92cf49c584b7d4ab2b8923c043fa1,long)> datasetGetInvoiceApprovalsCurrentApprover(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoicesCurrentApprover.GetInvoiceApprovalsCurrentApprover", "a4672276-6a3b-4233-8e04-08d36ece6ca8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoicesCurrentApprover","d_Invoices.Wb_InvoicesCurrentApprover.GetInvoiceApprovalsCurrentApprover");
// Query Iterations: Never
// Refresh Query QSqftR5RxEW2y2+LS7Ht7A Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.m6pfYkhPQEe4m4uSj8QP9Q/ScreenDataSets.diJnpDtqM0KOBAjTbs5sqA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole58\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"enuser170\".\"name\" o43, NULL o44, NULL o45, NULL o46");
fromBuilder.Append(" FROM ((({InvoiceApproval} \"eninvoiceapproval38\" Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel37\" ON (\"eninvoiceapproval38\".\"id\" = \"eninvoiceapprovallevel37\".\"invoiceapprovalid\"))  Left JOIN {User} \"enuser170\" ON (\"eninvoiceapprovallevel37\".\"assignedto\" = \"enuser170\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole58\" ON (\"eninvoiceapprovallevel37\".\"applicationroleid\" = \"enapplicationrole58\".\"id\")) ");
whereBuilder.Append(" WHERE ((\"eninvoiceapprovallevel37\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") AND ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval38\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval38\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval38\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(")");
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
RL_bed92cf49c584b7d4ab2b8923c043fa1 outParamList = new RL_bed92cf49c584b7d4ab2b8923c043fa1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsCurrentApproverReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoicesCurrentApprover.GetInvoiceApprovalsCurrentApprover.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bed92cf49c584b7d4ab2b8923c043fa1 _tmp = new RL_bed92cf49c584b7d4ab2b8923c043fa1();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsCurrentApproverReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoicesCurrentApprover.GetInvoiceApprovalsCurrentApprover.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bed92cf49c584b7d4ab2b8923c043fa1)_tmp;
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
