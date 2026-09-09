using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel).Namespace);

    public DateTime inParami_refresh;
public long inParami_FolioId;
public DateTime varLcl_DateTimeVar;
public string varLcl_UserName;
public int varLcMaxRecords;
public AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers;
public AggregateRecord<RL_4f2c6ead1defc6a22d01e9202d23be15> ScreenDataSetGetFolioLogsByFolioId;
public AggregateRecord<RL_9801bd776ff900c0406cf35f97fa0b26> ScreenDataSetCountFolioLogs;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel() {
}



    public ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel(DateTime inParami_refresh, long inParami_FolioId, DateTime varLcl_DateTimeVar, string varLcl_UserName, int varLcMaxRecords, AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers, AggregateRecord<RL_4f2c6ead1defc6a22d01e9202d23be15> ScreenDataSetGetFolioLogsByFolioId, AggregateRecord<RL_9801bd776ff900c0406cf35f97fa0b26> ScreenDataSetCountFolioLogs, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_refresh", "i_FolioId", "l_DateTimeVar", "l_UserName", "MaxRecords", "GetUsers", "GetFolioLogsByFolioId", "CountFolioLogs", "ClientVars"}, new string[] {"inParami_refresh", "inParami_FolioId", "varLcl_DateTimeVar", "varLcl_UserName", "varLcMaxRecords", "ScreenDataSetGetUsers", "ScreenDataSetGetFolioLogsByFolioId", "ScreenDataSetCountFolioLogs", "clientVariables"});
this.inParami_refresh = inParami_refresh;
this.inParami_FolioId = inParami_FolioId;
this.varLcl_DateTimeVar = varLcl_DateTimeVar;
this.varLcl_UserName = varLcl_UserName;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetUsers = ScreenDataSetGetUsers;
this.ScreenDataSetGetFolioLogsByFolioId = ScreenDataSetGetFolioLogsByFolioId;
this.ScreenDataSetCountFolioLogs = ScreenDataSetCountFolioLogs;
this.clientVariables = clientVariables;
}



    
// Query Function "GetUsers" 2y9SU4B3FEigcWZKDjzP0w of Action "Wb_FolioLogs"
public static async Task<(RL_8e4276b7147c8295b1546570303ecba2,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,bool qpboCheckUserSession,long qpfoFolioLog_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_FolioLogs.GetUsers", "53522fdb-7780-4814-a071-664a0e3ccfd3");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioLogs","y_Logs.Wb_FolioLogs.GetUsers");
// Query Iterations: Multiple
// Refresh Query mpvai_ogiEaqzdieSh3jGQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.saP7bh0NaEK+1VmXgx9L6g/ScreenDataSets.2y9SU4B3FEigcWZKDjzP0w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser205\".\"name\" \"username\"");
fromBuilder.Append(" FROM (({User} \"enuser205\" Left JOIN {Folio} \"enfolio76\" ON (\"enuser205\".\"id\" = \"enfolio76\".\"firstapproveruserid\"))  Left JOIN {FolioLog} \"enfoliolog1\" ON (\"enuser205\".\"id\" = \"enfoliolog1\".\"createdby\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolioLog_FolioId != 0) {
whereBuilder.Append("((\"enfoliolog1\".\"folioid\" = @qpfoFolioLog_FolioId) AND (\"enfoliolog1\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioLog_FolioId", DbType.Int64, qpfoFolioLog_FolioId);
} else {
whereBuilder.Append("(\"enfoliolog1\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpboCheckProveedorRole) {
whereBuilder.Append("(\"enfoliolog1\".\"isforsupplier\" = 1)");
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
groupByBuilder.Append(" GROUP BY \"enuser205\".\"name\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_FolioLogs.GetUsers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_FolioLogs.GetUsers.List", cancellationToken: cancellationToken);
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

private static async Task<RC_9f9ef21ffaabef46bdddd7ca965685a7> datasetGetFolioLogsByFolioIdReadDbAsync(RC_9f9ef21ffaabef46bdddd7ca965685a7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioLog.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioLogsByFolioId" dQLnqXCyBUea2OnzaT5moQ of Action "Wb_FolioLogs"
public static async Task<(RL_4f2c6ead1defc6a22d01e9202d23be15,long)> datasetGetFolioLogsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,bool qpboCheckUserSession,long qpfoFolioLog_FolioId,DateTime qpdaFolioLog_CreatedOn,string qpteUser_Name,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_FolioLogs.GetFolioLogsByFolioId", "a9e70275-b270-4705-9ad8-e9f3693e66a1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioLogs","y_Logs.Wb_FolioLogs.GetFolioLogsByFolioId");
// Query Iterations: Multiple
// Refresh Query XH7VJ3TGpUCOvKPVgfQhPg Iterations: Multiple
// Refresh Query SBYqoQtN_U2obXyBPSZbgA Iterations: Multiple
// Refresh Query 8kJQSVAaGEuA7mOH19zwrg Iterations: Multiple
// Refresh Query 6G34hRgIBkWarFlnE4VfBg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.saP7bh0NaEK+1VmXgx9L6g/ScreenDataSets.dQLnqXCyBUea2OnzaT5moQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfoliolog2\".\"message\" o2, \"enfoliolog2\".\"createdby\" o3, \"enfoliolog2\".\"createdon\" o4, \"enfoliolog2\".\"iserror\" o5, NULL o6, NULL o7, \"enuser206\".\"name\" o8, NULL o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({FolioLog} \"enfoliolog2\" Left JOIN {User} \"enuser206\" ON (\"enfoliolog2\".\"createdby\" = \"enuser206\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpdaFolioLog_CreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaFolioLog_CreatedOn = (cast(\"enfoliolog2\".\"createdon\" as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioLog_CreatedOn", DbType.DateTime, qpdaFolioLog_CreatedOn);
}
if (qpteUser_Name != "") {
whereBuilder.Append("(@qpteUser_Name = \"enuser206\".\"name\") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Name", DbType.String, qpteUser_Name);
}
if (qpfoFolioLog_FolioId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpfoFolioLog_FolioId != 0) {
whereBuilder.Append("((\"enfoliolog2\".\"folioid\" = @qpfoFolioLog_FolioId) AND (\"enfoliolog2\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioLog_FolioId", DbType.Int64, qpfoFolioLog_FolioId);
} else {
whereBuilder.Append("(\"enfoliolog2\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpboCheckProveedorRole) {
whereBuilder.Append("(\"enfoliolog2\".\"isforsupplier\" = 1)");
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enfoliolog2\".\"id\" DESC ");
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
RL_4f2c6ead1defc6a22d01e9202d23be15 outParamList = new RL_4f2c6ead1defc6a22d01e9202d23be15();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioLogsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_FolioLogs.GetFolioLogsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f2c6ead1defc6a22d01e9202d23be15 _tmp = new RL_4f2c6ead1defc6a22d01e9202d23be15();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioLogsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_FolioLogs.GetFolioLogsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f2c6ead1defc6a22d01e9202d23be15)_tmp;
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

// Query Function "CountFolioLogs" cVpg2xvUJkaOBEiuq_1a7g of Action "Wb_FolioLogs"
public static async Task<(RL_9801bd776ff900c0406cf35f97fa0b26,long)> datasetCountFolioLogs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_FolioLogs.CountFolioLogs", "db605a71-d41b-4626-8e04-48aeabfd5aee");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioLogs","y_Logs.Wb_FolioLogs.CountFolioLogs");
// Query Iterations: Never
// Refresh Query 6qaUyec4dkeZN_MJxFrmHw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.saP7bh0NaEK+1VmXgx9L6g/ScreenDataSets.cVpg2xvUJkaOBEiuq_1a7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enfoliolog3\".\"folioid\") \"countlogs\"");
fromBuilder.Append(" FROM {FolioLog} \"enfoliolog3\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpboCheckProveedorRole) {
whereBuilder.Append("(\"enfoliolog3\".\"isforsupplier\" = 1)");
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
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
RL_9801bd776ff900c0406cf35f97fa0b26 outParamList = new RL_9801bd776ff900c0406cf35f97fa0b26();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_FolioLogs.CountFolioLogs.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9801bd776ff900c0406cf35f97fa0b26 _tmp = new RL_9801bd776ff900c0406cf35f97fa0b26();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_FolioLogs.CountFolioLogs.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9801bd776ff900c0406cf35f97fa0b26)_tmp;
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
