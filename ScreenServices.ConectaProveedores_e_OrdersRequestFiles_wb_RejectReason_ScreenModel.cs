using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel).Namespace);

    public long inParamOrderRequestFilesId;
public AggregateRecord<RL_520d7bdfa592e7631b7e51777aa739f1> ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel() {
}



    public ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel(long inParamOrderRequestFilesId, AggregateRecord<RL_520d7bdfa592e7631b7e51777aa739f1> ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderRequestFilesId", "GetOrderRequestFileCommentsByOrderRequestFileId", "ClientVars"}, new string[] {"inParamOrderRequestFilesId", "ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId", "clientVariables"});
this.inParamOrderRequestFilesId = inParamOrderRequestFilesId;
this.ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId = ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_45b72d53609a7a1da4a98878c5ec7590> datasetGetOrderRequestFileCommentsByOrderRequestFileIdReadDbAsync(RC_45b72d53609a7a1da4a98878c5ec7590 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCommentType.Read( r, ref index);
rec.ssENOrderRequestFileComment.Read( r, ref index);
return rec;
}
// Query Function "GetOrderRequestFileCommentsByOrderRequestFileId" +siZvKl7ekyAYovo0cHL9g of Action "wb_RejectReason"
public static async Task<(RL_520d7bdfa592e7631b7e51777aa739f1,long)> datasetGetOrderRequestFileCommentsByOrderRequestFileId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFileComment_OrderRequestFileId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_OrdersRequestFiles.wb_RejectReason.GetOrderRequestFileCommentsByOrderRequestFileId", "bc99c8fa-7ba9-4c7a-8062-8be8d1c1cbf6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_RejectReason","e_OrdersRequestFiles.wb_RejectReason.GetOrderRequestFileCommentsByOrderRequestFileId");
// Query Iterations: Never
// Refresh Query 7g_+2gAGekO+Wnmz17dgGA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.QVuy0_xq1k6uAfJb8WCO0A/NodesShownInESpaceTree.0nYx0Kd4fkenYQ_I+u2Vgw/ScreenDataSets.+siZvKl7ekyAYovo0cHL9g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enorderrequestfilecomment\".\"message\" o9");
fromBuilder.Append(" FROM ({OrderRequestFileComment} \"enorderrequestfilecomment\" Left JOIN {CommentType} \"encommenttype\" ON (\"enorderrequestfilecomment\".\"commenttypeid\" = \"encommenttype\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFileComment_OrderRequestFileId != 0) {
whereBuilder.Append("((\"enorderrequestfilecomment\".\"orderrequestfileid\" = @qporOrderRequestFileComment_OrderRequestFileId) AND (\"enorderrequestfilecomment\".\"orderrequestfileid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFileComment_OrderRequestFileId", DbType.Int64, qporOrderRequestFileComment_OrderRequestFileId);
} else {
whereBuilder.Append("(\"enorderrequestfilecomment\".\"orderrequestfileid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderrequestfilecomment\".\"commenttypeid\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enorderrequestfilecomment\".\"id\" DESC ");
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
RL_520d7bdfa592e7631b7e51777aa739f1 outParamList = new RL_520d7bdfa592e7631b7e51777aa739f1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRequestFileCommentsByOrderRequestFileIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_OrdersRequestFiles.wb_RejectReason.GetOrderRequestFileCommentsByOrderRequestFileId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_520d7bdfa592e7631b7e51777aa739f1 _tmp = new RL_520d7bdfa592e7631b7e51777aa739f1();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRequestFileCommentsByOrderRequestFileIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_OrdersRequestFiles.wb_RejectReason.GetOrderRequestFileCommentsByOrderRequestFileId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_520d7bdfa592e7631b7e51777aa739f1)_tmp;
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
