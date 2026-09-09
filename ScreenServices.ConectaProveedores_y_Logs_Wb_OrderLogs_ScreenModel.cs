using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Logs_Wb_OrderLogs_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Logs_Wb_OrderLogs_ScreenModel).Namespace);

    public long inParami_OrderMainId;
public DateTime inParami_refresh;
public DateTime varLcl_DateTimeVar;
public string varLcl_UserName;
public int varLcMaxRecords;
public AggregateRecord<RL_09a534c151a8c55dd3e3e1962f18631c> ScreenDataSetGetOrderLogsByOrderMainId;
public AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountOrderLogs;
public AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Logs_Wb_OrderLogs_ScreenModel() {
}



    public ConectaProveedores_y_Logs_Wb_OrderLogs_ScreenModel(long inParami_OrderMainId, DateTime inParami_refresh, DateTime varLcl_DateTimeVar, string varLcl_UserName, int varLcMaxRecords, AggregateRecord<RL_09a534c151a8c55dd3e3e1962f18631c> ScreenDataSetGetOrderLogsByOrderMainId, AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountOrderLogs, AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderMainId", "i_refresh", "l_DateTimeVar", "l_UserName", "MaxRecords", "GetOrderLogsByOrderMainId", "CountOrderLogs", "GetUsers", "ClientVars"}, new string[] {"inParami_OrderMainId", "inParami_refresh", "varLcl_DateTimeVar", "varLcl_UserName", "varLcMaxRecords", "ScreenDataSetGetOrderLogsByOrderMainId", "ScreenDataSetCountOrderLogs", "ScreenDataSetGetUsers", "clientVariables"});
this.inParami_OrderMainId = inParami_OrderMainId;
this.inParami_refresh = inParami_refresh;
this.varLcl_DateTimeVar = varLcl_DateTimeVar;
this.varLcl_UserName = varLcl_UserName;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetOrderLogsByOrderMainId = ScreenDataSetGetOrderLogsByOrderMainId;
this.ScreenDataSetCountOrderLogs = ScreenDataSetCountOrderLogs;
this.ScreenDataSetGetUsers = ScreenDataSetGetUsers;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_48f837ac894bfbcf11c3d8c2e6c47c59> datasetGetOrderLogsByOrderMainIdReadDbAsync(RC_48f837ac894bfbcf11c3d8c2e6c47c59 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderLogs.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderLogsByOrderMainId" KTSsbqXjhkWILqdpN2QtVQ of Action "Wb_OrderLogs"
public static async Task<(RL_09a534c151a8c55dd3e3e1962f18631c,long)> datasetGetOrderLogsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderLogs_OrderId,DateTime qpdaOrderLogs_CreatedOn,string qpteUser_Name,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_OrderLogs.GetOrderLogsByOrderMainId", "6eac3429-e3a5-4586-882e-a76937642d55");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderLogs","y_Logs.Wb_OrderLogs.GetOrderLogsByOrderMainId");
// Query Iterations: Multiple
// Refresh Query PkWonqGq002jUjpgg_4P2g Iterations: Multiple
// Refresh Query 3vgbHEfthE+ZYZCKJU9jSQ Iterations: Multiple
// Refresh Query eo3tBvs_2EG+f6T1XF2ENQ Iterations: Multiple
// Refresh Query 9wse4dSN1E26rwxHIcd5LA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.b12L+GWJm0O6l2vnrVhbJw/ScreenDataSets.KTSsbqXjhkWILqdpN2QtVQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enorderlogs1\".\"createdby\" o2, \"enorderlogs1\".\"createdon\" o3, \"enorderlogs1\".\"message\" o4, \"enorderlogs1\".\"iserror\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"enuser207\".\"name\" o36, NULL o37, NULL o38, NULL o39");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain117\" Left JOIN {OrderLogs} \"enorderlogs1\" ON (\"enordermain117\".\"id\" = \"enorderlogs1\".\"orderid\"))  Left JOIN {User} \"enuser207\" ON (\"enorderlogs1\".\"createdby\" = \"enuser207\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpdaOrderLogs_CreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaOrderLogs_CreatedOn = (cast(\"enorderlogs1\".\"createdon\" as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaOrderLogs_CreatedOn", DbType.DateTime, qpdaOrderLogs_CreatedOn);
}
if (qpteUser_Name != "") {
whereBuilder.Append("(@qpteUser_Name = \"enuser207\".\"name\") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Name", DbType.String, qpteUser_Name);
}
if (qporOrderLogs_OrderId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qporOrderLogs_OrderId != 0) {
whereBuilder.Append("((\"enorderlogs1\".\"orderid\" = @qporOrderLogs_OrderId) AND (\"enorderlogs1\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderLogs_OrderId", DbType.Int64, qporOrderLogs_OrderId);
} else {
whereBuilder.Append("(\"enorderlogs1\".\"orderid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enorderlogs1\".\"id\" DESC ");
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
RL_09a534c151a8c55dd3e3e1962f18631c outParamList = new RL_09a534c151a8c55dd3e3e1962f18631c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderLogsByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_OrderLogs.GetOrderLogsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_09a534c151a8c55dd3e3e1962f18631c _tmp = new RL_09a534c151a8c55dd3e3e1962f18631c();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderLogsByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_OrderLogs.GetOrderLogsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_09a534c151a8c55dd3e3e1962f18631c)_tmp;
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

// Query Function "CountOrderLogs" 3EF1yLbqQkaU4+Hh1icFxA of Action "Wb_OrderLogs"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetCountOrderLogs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_OrderLogs.CountOrderLogs", "c87541dc-eab6-4642-94e3-e1e1d62705c4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderLogs","y_Logs.Wb_OrderLogs.CountOrderLogs");
// Query Iterations: Never
// Refresh Query UWAbyv44t0+p4rPZeC3DTw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.b12L+GWJm0O6l2vnrVhbJw/ScreenDataSets.3EF1yLbqQkaU4+Hh1icFxA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enorderlogs2\".\"id\") \"count\"");
fromBuilder.Append(" FROM {OrderLogs} \"enorderlogs2\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderId != 0) {
whereBuilder.Append("((\"enorderlogs2\".\"orderid\" = @qporOrderId) AND (\"enorderlogs2\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enorderlogs2\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" OR (\"enorderlogs2\".\"orderid\" IS NULL))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_OrderLogs.CountOrderLogs.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_OrderLogs.CountOrderLogs.List", cancellationToken: cancellationToken);
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

// Query Function "GetUsers" xb7916cvqUK6LwQqnnoyHw of Action "Wb_OrderLogs"
public static async Task<(RL_8e4276b7147c8295b1546570303ecba2,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderLogs_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_OrderLogs.GetUsers", "d7fdbec5-2fa7-42a9-ba2f-042a9e7a321f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderLogs","y_Logs.Wb_OrderLogs.GetUsers");
// Query Iterations: Multiple
// Refresh Query abIbdpQfVEu7lxkd3ozOgQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.b12L+GWJm0O6l2vnrVhbJw/ScreenDataSets.xb7916cvqUK6LwQqnnoyHw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser208\".\"name\" \"username\"");
fromBuilder.Append(" FROM (({User} \"enuser208\" Left JOIN {OrderMain} \"enordermain118\" ON (\"enuser208\".\"id\" = \"enordermain118\".\"createdby\"))  Inner JOIN {OrderLogs} \"enorderlogs3\" ON (\"enuser208\".\"id\" = \"enorderlogs3\".\"createdby\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderLogs_OrderId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qporOrderLogs_OrderId != 0) {
whereBuilder.Append("((\"enorderlogs3\".\"orderid\" = @qporOrderLogs_OrderId) AND (\"enorderlogs3\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderLogs_OrderId", DbType.Int64, qporOrderLogs_OrderId);
} else {
whereBuilder.Append("(\"enorderlogs3\".\"orderid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
groupByBuilder.Append(" GROUP BY \"enuser208\".\"name\"");
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
RL_8e4276b7147c8295b1546570303ecba2 outParamList = new RL_8e4276b7147c8295b1546570303ecba2();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_OrderLogs.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8e4276b7147c8295b1546570303ecba2 _tmp = new RL_8e4276b7147c8295b1546570303ecba2();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_OrderLogs.GetUsers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8e4276b7147c8295b1546570303ecba2)_tmp;
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
