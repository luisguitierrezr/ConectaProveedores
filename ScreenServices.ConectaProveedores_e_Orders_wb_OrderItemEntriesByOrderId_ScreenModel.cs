using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel).Namespace);

    public long inParamOrderMainId;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> ScreenDataSetGetOrderItemEntriesByOrderMainItemid;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel() {
}



    public ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel(long inParamOrderMainId, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> ScreenDataSetGetOrderItemEntriesByOrderMainItemid, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderMainId", "StartIndex", "MaxRecords", "GetOrderItemEntriesByOrderMainItemid", "ClientVars"}, new string[] {"inParamOrderMainId", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetGetOrderItemEntriesByOrderMainItemid", "clientVariables"});
this.inParamOrderMainId = inParamOrderMainId;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetOrderItemEntriesByOrderMainItemid = ScreenDataSetGetOrderItemEntriesByOrderMainItemid;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_cf58ea0f756ca06745169deb0b41c0eb> datasetGetOrderItemEntriesByOrderMainItemidReadDbAsync(RC_cf58ea0f756ca06745169deb0b41c0eb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderItemEntries.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetOrderItemEntriesByOrderMainItemid" 3Y3_19qLK0+40qBt0VP09g of Action "wb_OrderItemEntriesByOrderId"
public static async Task<(RL_3dd9bb7875fde1313207084bc3e4eb42,long)> datasetGetOrderItemEntriesByOrderMainItemid(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.wb_OrderItemEntriesByOrderId.GetOrderItemEntriesByOrderMainItemid", "d7ff8ddd-8bda-4f2b-b8d2-a06dd153f4f6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_OrderItemEntriesByOrderId","e_Orders.wb_OrderItemEntriesByOrderId.GetOrderItemEntriesByOrderMainItemid");
// Query Iterations: Multiple
// Refresh Query X96oDyFyXUeYzgSTNtcLxw Iterations: Multiple
// Refresh Query 0rU4I1z+mEGWKNDZVBEOwA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bP3ymxiuMkeQVWQmgMAGeA/ScreenDataSets.3Y3_19qLK0+40qBt0VP09g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, trim_scale(\"enorderitementries3\".\"quantity_\"::numeric) o2, NULL o3, \"enorderitementries3\".\"entrydocument\" o4, \"enorderitementries3\".\"createdon\" o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enordermainitem20\".\"position\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM ({OrderItemEntries} \"enorderitementries3\" Left JOIN {OrderMainItem} \"enordermainitem20\" ON (\"enorderitementries3\".\"ordermainitemid\" = \"enordermainitem20\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem20\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem20\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
sqlCountCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem20\".\"ordermainid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enordermainitem20\".\"position\" ASC ");
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
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_3dd9bb7875fde1313207084bc3e4eb42 outParamList = new RL_3dd9bb7875fde1313207084bc3e4eb42();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderItemEntriesByOrderMainItemidReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.wb_OrderItemEntriesByOrderId.GetOrderItemEntriesByOrderMainItemid.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.wb_OrderItemEntriesByOrderId.GetOrderItemEntriesByOrderMainItemid.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3dd9bb7875fde1313207084bc3e4eb42 _tmp = new RL_3dd9bb7875fde1313207084bc3e4eb42();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderItemEntriesByOrderMainItemidReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.wb_OrderItemEntriesByOrderId.GetOrderItemEntriesByOrderMainItemid.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3dd9bb7875fde1313207084bc3e4eb42)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.wb_OrderItemEntriesByOrderId.GetOrderItemEntriesByOrderMainItemid.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
