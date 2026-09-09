using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel).Namespace);

    public long inParami_OrderId;
public AggregateRecord<RL_8f94456a098435a6d91415089487edb3> ScreenDataSetGetOrderApprovalsByOrderId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel(long inParami_OrderId, AggregateRecord<RL_8f94456a098435a6d91415089487edb3> ScreenDataSetGetOrderApprovalsByOrderId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "GetOrderApprovalsByOrderId", "ClientVars"}, new string[] {"inParami_OrderId", "ScreenDataSetGetOrderApprovalsByOrderId", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.ScreenDataSetGetOrderApprovalsByOrderId = ScreenDataSetGetOrderApprovalsByOrderId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_d95078dcb8f428bf6873002913f3165e> datasetGetOrderApprovalsByOrderIdReadDbAsync(RC_d95078dcb8f428bf6873002913f3165e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalsByOrderId" On00ttNhD0C5Kviuvl8vBQ of Action "Wb_OrderApprovalPopup"
public static async Task<(RL_8f94456a098435a6d91415089487edb3,long)> datasetGetOrderApprovalsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderApprovalPopup.GetOrderApprovalsByOrderId", "b6347d3a-61d3-400f-b92a-f8aebe5f2f05");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderApprovalPopup","e_Orders.Wb_OrderApprovalPopup.GetOrderApprovalsByOrderId");
// Query Iterations: Multiple
// Refresh Query 11ssTmPkYUe7vMurjgdkBw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.Ev2df_5nNUi1bV8aee5QaA/ScreenDataSets.On00ttNhD0C5Kviuvl8vBQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole54\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enorderapprovallevel25\".\"approvalstatusid\" o20, NULL o21, \"enorderapprovallevel25\".\"approvedon\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enuser179\".\"name\" o32, \"enuser179\".\"email\" o33, NULL o34, NULL o35");
fromBuilder.Append(" FROM ((({OrderApproval} \"enorderapproval26\" Left JOIN {OrderApprovalLevel} \"enorderapprovallevel25\" ON (\"enorderapproval26\".\"id\" = \"enorderapprovallevel25\".\"orderapprovalid\"))  Left JOIN {User} \"enuser179\" ON (\"enorderapprovallevel25\".\"assignedto\" = \"enuser179\".\"id\"))  Left JOIN {EntraRole} \"enentrarole54\" ON (\"enorderapprovallevel25\".\"entraroleid\" = \"enentrarole54\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval26\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval26\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval26\".\"orderid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel25\".\"levelnumber\" ASC ");
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
RL_8f94456a098435a6d91415089487edb3 outParamList = new RL_8f94456a098435a6d91415089487edb3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalsByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, false, true, false, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderApprovalPopup.GetOrderApprovalsByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8f94456a098435a6d91415089487edb3 _tmp = new RL_8f94456a098435a6d91415089487edb3();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalsByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderApprovalPopup.GetOrderApprovalsByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8f94456a098435a6d91415089487edb3)_tmp;
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
