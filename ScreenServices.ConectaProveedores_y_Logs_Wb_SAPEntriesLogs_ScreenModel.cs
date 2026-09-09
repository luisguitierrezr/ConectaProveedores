using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel).Namespace);

    public long inParami_OrderMainId;
public DateTime inParami_refresh;
public DateTime varLcl_DateTimeVar;
public int varLcMaxRecords;
public AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> ScreenDataSetGetEntriesByOrderMainId;
public AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountEntries;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel() {
}



    public ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel(long inParami_OrderMainId, DateTime inParami_refresh, DateTime varLcl_DateTimeVar, int varLcMaxRecords, AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> ScreenDataSetGetEntriesByOrderMainId, AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountEntries, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderMainId", "i_refresh", "l_DateTimeVar", "MaxRecords", "GetEntriesByOrderMainId", "CountEntries", "ClientVars"}, new string[] {"inParami_OrderMainId", "inParami_refresh", "varLcl_DateTimeVar", "varLcMaxRecords", "ScreenDataSetGetEntriesByOrderMainId", "ScreenDataSetCountEntries", "clientVariables"});
this.inParami_OrderMainId = inParami_OrderMainId;
this.inParami_refresh = inParami_refresh;
this.varLcl_DateTimeVar = varLcl_DateTimeVar;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetEntriesByOrderMainId = ScreenDataSetGetEntriesByOrderMainId;
this.ScreenDataSetCountEntries = ScreenDataSetCountEntries;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_cf58ea0f756ca06745169deb0b41c0eb> datasetGetEntriesByOrderMainIdReadDbAsync(RC_cf58ea0f756ca06745169deb0b41c0eb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderItemEntries.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetEntriesByOrderMainId" VFeFmZnZhEi8Gx6amjTtcA of Action "Wb_SAPEntriesLogs"
public static async Task<(RL_3dd9bb7875fde1313207084bc3e4eb42,long)> datasetGetEntriesByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderMainItem_OrderMainId,DateTime qpdaOrderItemEntries_CreatedOn,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_SAPEntriesLogs.GetEntriesByOrderMainId", "99855754-d999-4884-bc1b-1e9a9a34ed70");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SAPEntriesLogs","y_Logs.Wb_SAPEntriesLogs.GetEntriesByOrderMainId");
// Query Iterations: Multiple
// Refresh Query LAITCXOTQ0Gylny8zikyuA Iterations: Multiple
// Refresh Query XnzBHu8ngkC+MK70IH1IeA Iterations: Multiple
// Refresh Query ajknvKhBcEuAbeCWHVFq2Q Iterations: Multiple
// Refresh Query poeV5rb310O1axG2px_ZFQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.SeO6l0kWpEC4+tZGODYvxg/ScreenDataSets.VFeFmZnZhEi8Gx6amjTtcA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, trim_scale(\"enorderitementries4\".\"quantity_\"::numeric) o2, NULL o3, NULL o4, \"enorderitementries4\".\"createdon\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM ({OrderItemEntries} \"enorderitementries4\" Left JOIN {OrderMainItem} \"enordermainitem24\" ON (\"enorderitementries4\".\"ordermainitemid\" = \"enordermainitem24\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpdaOrderItemEntries_CreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaOrderItemEntries_CreatedOn = (cast(\"enorderitementries4\".\"createdon\" as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaOrderItemEntries_CreatedOn", DbType.DateTime, qpdaOrderItemEntries_CreatedOn);
}
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem24\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem24\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem24\".\"ordermainid\" IS NULL)");
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
RL_3dd9bb7875fde1313207084bc3e4eb42 outParamList = new RL_3dd9bb7875fde1313207084bc3e4eb42();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetEntriesByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_SAPEntriesLogs.GetEntriesByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3dd9bb7875fde1313207084bc3e4eb42 _tmp = new RL_3dd9bb7875fde1313207084bc3e4eb42();
_tmp.AlternateReadDbMethodAsync = datasetGetEntriesByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_SAPEntriesLogs.GetEntriesByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3dd9bb7875fde1313207084bc3e4eb42)_tmp;
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

// Query Function "CountEntries" YCkt7WhfNkaHZ3a1Qm2OOQ of Action "Wb_SAPEntriesLogs"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetCountEntries(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_SAPEntriesLogs.CountEntries", "ed2d2960-5f68-4636-8767-76b5426d8e39");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SAPEntriesLogs","y_Logs.Wb_SAPEntriesLogs.CountEntries");
// Query Iterations: Never
// Refresh Query rY4JNwmII06hiyWQRMgcuA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.SeO6l0kWpEC4+tZGODYvxg/ScreenDataSets.YCkt7WhfNkaHZ3a1Qm2OOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enorderitementries5\".\"id\") \"count\"");
fromBuilder.Append(" FROM ({OrderItemEntries} \"enorderitementries5\" Left JOIN {OrderMainItem} \"enordermainitem25\" ON (\"enorderitementries5\".\"ordermainitemid\" = \"enordermainitem25\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem25\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem25\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem25\".\"ordermainid\" IS NULL)");
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
RL_11e68f59508e412eaf5b78801dd06b0e outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_SAPEntriesLogs.CountEntries.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_11e68f59508e412eaf5b78801dd06b0e _tmp = new RL_11e68f59508e412eaf5b78801dd06b0e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_SAPEntriesLogs.CountEntries.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_11e68f59508e412eaf5b78801dd06b0e)_tmp;
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
