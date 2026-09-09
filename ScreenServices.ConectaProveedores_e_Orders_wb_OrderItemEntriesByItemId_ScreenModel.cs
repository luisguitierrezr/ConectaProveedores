using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_wb_OrderItemEntriesByItemId_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_wb_OrderItemEntriesByItemId_ScreenModel).Namespace);

    public long inParamOrderMainItemId;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> ScreenDataSetGetOrderItemEntriesByOrderMainItemid;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_wb_OrderItemEntriesByItemId_ScreenModel() {
}



    public ConectaProveedores_e_Orders_wb_OrderItemEntriesByItemId_ScreenModel(long inParamOrderMainItemId, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> ScreenDataSetGetOrderItemEntriesByOrderMainItemid, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderMainItemId", "StartIndex", "MaxRecords", "GetOrderItemEntriesByOrderMainItemid", "ClientVars"}, new string[] {"inParamOrderMainItemId", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetGetOrderItemEntriesByOrderMainItemid", "clientVariables"});
this.inParamOrderMainItemId = inParamOrderMainItemId;
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
// Query Function "GetOrderItemEntriesByOrderMainItemid" 9cCzHWazwkSp68NMpqWSng of Action "wb_OrderItemEntriesByItemId"
public static async Task<(RL_3dd9bb7875fde1313207084bc3e4eb42,long)> datasetGetOrderItemEntriesByOrderMainItemid(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderItemEntries_OrderMainItemid,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.wb_OrderItemEntriesByItemId.GetOrderItemEntriesByOrderMainItemid", "1db3c0f5-b366-44c2-a9eb-c34ca6a5929e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_OrderItemEntriesByItemId","e_Orders.wb_OrderItemEntriesByItemId.GetOrderItemEntriesByOrderMainItemid");
// Query Iterations: Multiple
// Refresh Query APWugHINqUqhQ+XMLj+Cow Iterations: Multiple
// Refresh Query N7+xcWe3t0ydbDBHkcMBow Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.4fzomhhZzUmeJ4FyxG+XHw/ScreenDataSets.9cCzHWazwkSp68NMpqWSng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, trim_scale(\"enorderitementries2\".\"quantity_\"::numeric) o2, NULL o3, NULL o4, \"enorderitementries2\".\"createdon\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enordermainitem19\".\"materialcode\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM ({OrderItemEntries} \"enorderitementries2\" Left JOIN {OrderMainItem} \"enordermainitem19\" ON (\"enorderitementries2\".\"ordermainitemid\" = \"enordermainitem19\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderItemEntries_OrderMainItemid != 0) {
whereBuilder.Append("((\"enorderitementries2\".\"ordermainitemid\" = @qporOrderItemEntries_OrderMainItemid) AND (\"enorderitementries2\".\"ordermainitemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderItemEntries_OrderMainItemid", DbType.Int64, qporOrderItemEntries_OrderMainItemid);
sqlCountCmd.CreateParameterWithoutReplacements("@qporOrderItemEntries_OrderMainItemid", DbType.Int64, qporOrderItemEntries_OrderMainItemid);
} else {
whereBuilder.Append("(\"enorderitementries2\".\"ordermainitemid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderitementries2\".\"createdon\" DESC ");
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
opt[0] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.wb_OrderItemEntriesByItemId.GetOrderItemEntriesByOrderMainItemid.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.wb_OrderItemEntriesByItemId.GetOrderItemEntriesByOrderMainItemid.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.wb_OrderItemEntriesByItemId.GetOrderItemEntriesByOrderMainItemid.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3dd9bb7875fde1313207084bc3e4eb42)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.wb_OrderItemEntriesByItemId.GetOrderItemEntriesByOrderMainItemid.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
