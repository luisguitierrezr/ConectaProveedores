using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel).Namespace);

    public long inParami_ProposalId;
public long inParami_ProposalLineId;
public DateTime inParami_refresh;
public DateTime varLcl_DateTimeVar;
public string varLcl_UserName;
public int varLcMaxRecords;
public AggregateRecord<RL_f6f48bf2db0bc517dcae1aa52c83f316> ScreenDataSetGetProposalLogsByProposalId;
public AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountProposalLogs;
public AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel() {
}



    public ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel(long inParami_ProposalId, long inParami_ProposalLineId, DateTime inParami_refresh, DateTime varLcl_DateTimeVar, string varLcl_UserName, int varLcMaxRecords, AggregateRecord<RL_f6f48bf2db0bc517dcae1aa52c83f316> ScreenDataSetGetProposalLogsByProposalId, AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountProposalLogs, AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalId", "i_ProposalLineId", "i_refresh", "l_DateTimeVar", "l_UserName", "MaxRecords", "GetProposalLogsByProposalId", "CountProposalLogs", "GetUsers", "ClientVars"}, new string[] {"inParami_ProposalId", "inParami_ProposalLineId", "inParami_refresh", "varLcl_DateTimeVar", "varLcl_UserName", "varLcMaxRecords", "ScreenDataSetGetProposalLogsByProposalId", "ScreenDataSetCountProposalLogs", "ScreenDataSetGetUsers", "clientVariables"});
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_ProposalLineId = inParami_ProposalLineId;
this.inParami_refresh = inParami_refresh;
this.varLcl_DateTimeVar = varLcl_DateTimeVar;
this.varLcl_UserName = varLcl_UserName;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetProposalLogsByProposalId = ScreenDataSetGetProposalLogsByProposalId;
this.ScreenDataSetCountProposalLogs = ScreenDataSetCountProposalLogs;
this.ScreenDataSetGetUsers = ScreenDataSetGetUsers;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_38bf7bcb20a8b257cedfd0071956fdaa> datasetGetProposalLogsByProposalIdReadDbAsync(RC_38bf7bcb20a8b257cedfd0071956fdaa rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalLogs.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLogsByProposalId" QhOmhz7bF0Gz5rNeoyKvQw of Action "Wb_ProposalLogs"
public static async Task<(RL_f6f48bf2db0bc517dcae1aa52c83f316,long)> datasetGetProposalLogsByProposalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposalLogs_ProposalId,long qpprProposalLogs_ProposalLineId,DateTime qpdaProposalLogs_CreatedOn,string qpteUser_Name,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_ProposalLogs.GetProposalLogsByProposalId", "87a61342-db3e-4117-b3e6-b35ea322af43");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ProposalLogs","y_Logs.Wb_ProposalLogs.GetProposalLogsByProposalId");
// Query Iterations: Multiple
// Refresh Query tr4hR1jvlEeU7_nYFT6lKA Iterations: Multiple
// Refresh Query BOkOKXmdqEuvUY9sXNJo6w Iterations: Multiple
// Refresh Query 5uG4tJziX0yHhKp88fYErw Iterations: Multiple
// Refresh Query oaFQJjo_v0W8usM6BtVYXA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.p0aZ+zKTOUuzkZq9rFAxhw/ScreenDataSets.QhOmhz7bF0Gz5rNeoyKvQw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enproposallogs1\".\"createdby\" o3, \"enproposallogs1\".\"createdon\" o4, \"enproposallogs1\".\"message\" o5, \"enproposallogs1\".\"iserror\" o6, NULL o7, \"enuser209\".\"name\" o8, NULL o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({ProposalLogs} \"enproposallogs1\" Left JOIN {User} \"enuser209\" ON (\"enproposallogs1\".\"createdby\" = \"enuser209\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((CASE WHEN (@qpprProposalLogs_ProposalId = 0) THEN (CASE WHEN (\"enproposallogs1\".\"proposallineid\" IS NULL) THEN 1 ELSE 0 END) ELSE (CASE WHEN (@qpprProposalLogs_ProposalLineId = 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalId", DbType.Int64, qpprProposalLogs_ProposalId);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalLineId", DbType.Int64, qpprProposalLogs_ProposalLineId);
if (qpprProposalLogs_ProposalId != 0) {
whereBuilder.Append("((\"enproposallogs1\".\"proposalid\" = @qpprProposalLogs_ProposalId) AND (\"enproposallogs1\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalId", DbType.Int64, qpprProposalLogs_ProposalId);
} else {
whereBuilder.Append("(\"enproposallogs1\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpprProposalLogs_ProposalLineId != 0) {
whereBuilder.Append("((\"enproposallogs1\".\"proposallineid\" = @qpprProposalLogs_ProposalLineId) AND (\"enproposallogs1\".\"proposallineid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalLineId", DbType.Int64, qpprProposalLogs_ProposalLineId);
} else {
whereBuilder.Append("(\"enproposallogs1\".\"proposallineid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) END) = 1) AND ");
if (qpdaProposalLogs_CreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaProposalLogs_CreatedOn = (cast(\"enproposallogs1\".\"createdon\" as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaProposalLogs_CreatedOn", DbType.DateTime, qpdaProposalLogs_CreatedOn);
}
if (qpteUser_Name != "") {
whereBuilder.Append("(@qpteUser_Name = \"enuser209\".\"name\")");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Name", DbType.String, qpteUser_Name);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enproposallogs1\".\"id\" DESC ");
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
RL_f6f48bf2db0bc517dcae1aa52c83f316 outParamList = new RL_f6f48bf2db0bc517dcae1aa52c83f316();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLogsByProposalIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_ProposalLogs.GetProposalLogsByProposalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f6f48bf2db0bc517dcae1aa52c83f316 _tmp = new RL_f6f48bf2db0bc517dcae1aa52c83f316();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLogsByProposalIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_ProposalLogs.GetProposalLogsByProposalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f6f48bf2db0bc517dcae1aa52c83f316)_tmp;
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

// Query Function "CountProposalLogs" d2rynk79Rku3eRrzgY+ZOQ of Action "Wb_ProposalLogs"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetCountProposalLogs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposalId,long qpprProposalLineId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_ProposalLogs.CountProposalLogs", "9ef26a77-fd4e-4b46-b779-1af3818f9939");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ProposalLogs","y_Logs.Wb_ProposalLogs.CountProposalLogs");
// Query Iterations: Never
// Refresh Query Qhs+YSRLNU6donb4CsMV_w Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.p0aZ+zKTOUuzkZq9rFAxhw/ScreenDataSets.d2rynk79Rku3eRrzgY+ZOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enproposallogs2\".\"id\") \"count\"");
fromBuilder.Append(" FROM {ProposalLogs} \"enproposallogs2\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((CASE WHEN (@qpprProposalId = 0) THEN (CASE WHEN (\"enproposallogs2\".\"proposallineid\" IS NULL) THEN 1 ELSE 0 END) ELSE (CASE WHEN (@qpprProposalLineId = 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineId", DbType.Int64, qpprProposalLineId);
if (qpprProposalId != 0) {
whereBuilder.Append("((\"enproposallogs2\".\"proposalid\" = @qpprProposalId) AND (\"enproposallogs2\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
} else {
whereBuilder.Append("(\"enproposallogs2\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpprProposalLineId != 0) {
whereBuilder.Append("((\"enproposallogs2\".\"proposallineid\" = @qpprProposalLineId) AND (\"enproposallogs2\".\"proposallineid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineId", DbType.Int64, qpprProposalLineId);
} else {
whereBuilder.Append("(\"enproposallogs2\".\"proposallineid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) END) = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_ProposalLogs.CountProposalLogs.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_ProposalLogs.CountProposalLogs.List", cancellationToken: cancellationToken);
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

// Query Function "GetUsers" e4bk4PqXcUi5SqJ9xHZUNg of Action "Wb_ProposalLogs"
public static async Task<(RL_8e4276b7147c8295b1546570303ecba2,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposalLogs_ProposalId,long qpprProposalLogs_ProposalLineId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_ProposalLogs.GetUsers", "e0e4867b-97fa-4871-b94a-a27dc4765436");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ProposalLogs","y_Logs.Wb_ProposalLogs.GetUsers");
// Query Iterations: Multiple
// Refresh Query dDJfKDXf70aGzTkR28XOkw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.p0aZ+zKTOUuzkZq9rFAxhw/ScreenDataSets.e4bk4PqXcUi5SqJ9xHZUNg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser210\".\"name\" \"username\"");
fromBuilder.Append(" FROM (({ProposalLogs} \"enproposallogs3\" Inner JOIN {Proposal} \"enproposal24\" ON (\"enproposallogs3\".\"proposalid\" = \"enproposal24\".\"id\"))  Left JOIN {User} \"enuser210\" ON (\"enproposallogs3\".\"createdby\" = \"enuser210\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((CASE WHEN (@qpprProposalLogs_ProposalId = 0) THEN (CASE WHEN (\"enproposallogs3\".\"proposallineid\" IS NULL) THEN 1 ELSE 0 END) ELSE (CASE WHEN (@qpprProposalLogs_ProposalLineId = 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalId", DbType.Int64, qpprProposalLogs_ProposalId);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalLineId", DbType.Int64, qpprProposalLogs_ProposalLineId);
if (qpprProposalLogs_ProposalId != 0) {
whereBuilder.Append("((\"enproposallogs3\".\"proposalid\" = @qpprProposalLogs_ProposalId) AND (\"enproposallogs3\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalId", DbType.Int64, qpprProposalLogs_ProposalId);
} else {
whereBuilder.Append("(\"enproposallogs3\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpprProposalLogs_ProposalLineId != 0) {
whereBuilder.Append("((\"enproposallogs3\".\"proposallineid\" = @qpprProposalLogs_ProposalLineId) AND (\"enproposallogs3\".\"proposallineid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLogs_ProposalLineId", DbType.Int64, qpprProposalLogs_ProposalLineId);
} else {
whereBuilder.Append("(\"enproposallogs3\".\"proposallineid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) END) = 1)");
groupByBuilder.Append(" GROUP BY \"enuser210\".\"name\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_ProposalLogs.GetUsers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_ProposalLogs.GetUsers.List", cancellationToken: cancellationToken);
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
