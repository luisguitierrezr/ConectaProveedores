using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel).Namespace);

    public long inParami_RequisitionId;
public DateTime inParami_refresh;
public DateTime varLcl_DateTimeVar;
public string varLcl_UserName;
public int varLcMaxRecords;
public AggregateRecord<RL_229a538de0ea5acc5992a93132dd8a21> ScreenDataSetGetRequisitionLogsByRequisitionId;
public AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountRequisitionLogs;
public AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel() {
}



    public ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel(long inParami_RequisitionId, DateTime inParami_refresh, DateTime varLcl_DateTimeVar, string varLcl_UserName, int varLcMaxRecords, AggregateRecord<RL_229a538de0ea5acc5992a93132dd8a21> ScreenDataSetGetRequisitionLogsByRequisitionId, AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountRequisitionLogs, AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_RequisitionId", "i_refresh", "l_DateTimeVar", "l_UserName", "MaxRecords", "GetRequisitionLogsByRequisitionId", "CountRequisitionLogs", "GetUsers", "ClientVars"}, new string[] {"inParami_RequisitionId", "inParami_refresh", "varLcl_DateTimeVar", "varLcl_UserName", "varLcMaxRecords", "ScreenDataSetGetRequisitionLogsByRequisitionId", "ScreenDataSetCountRequisitionLogs", "ScreenDataSetGetUsers", "clientVariables"});
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_refresh = inParami_refresh;
this.varLcl_DateTimeVar = varLcl_DateTimeVar;
this.varLcl_UserName = varLcl_UserName;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetRequisitionLogsByRequisitionId = ScreenDataSetGetRequisitionLogsByRequisitionId;
this.ScreenDataSetCountRequisitionLogs = ScreenDataSetCountRequisitionLogs;
this.ScreenDataSetGetUsers = ScreenDataSetGetUsers;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_f5b6f78be278df3dd44e2d0a42d99692> datasetGetRequisitionLogsByRequisitionIdReadDbAsync(RC_f5b6f78be278df3dd44e2d0a42d99692 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionLogs.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionLogsByRequisitionId" oshRJlbhdEODyPdwjIZagg of Action "Wb_RequisitionLogs"
public static async Task<(RL_229a538de0ea5acc5992a93132dd8a21,long)> datasetGetRequisitionLogsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionLogs_RequisitionId,DateTime qpdaRequisitionLogs_CreatedOn,string qpteUser_Name,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_RequisitionLogs.GetRequisitionLogsByRequisitionId", "2651c8a2-e156-4374-83c8-f7708c865a82");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionLogs","y_Logs.Wb_RequisitionLogs.GetRequisitionLogsByRequisitionId");
// Query Iterations: Multiple
// Refresh Query 2CY0QlZRpEO+p1i7kOaOEg Iterations: Multiple
// Refresh Query nw90qWWLXkeG7exjJmYqeg Iterations: Multiple
// Refresh Query 75PrYrxvRUSVGm9zaBj21g Iterations: Multiple
// Refresh Query poltQQ+ybkSj6zkWaX7RZA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.sM_5IWO7CEmjymz6Zs5EoQ/ScreenDataSets.oshRJlbhdEODyPdwjIZagg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, \"enrequisitionlogs2\".\"createdby\" o60, \"enrequisitionlogs2\".\"createdon\" o61, \"enrequisitionlogs2\".\"message\" o62, \"enrequisitionlogs2\".\"iserror\" o63, NULL o64, \"enuser203\".\"name\" o65, NULL o66, NULL o67, NULL o68");
fromBuilder.Append(" FROM (({RequisitionLogs} \"enrequisitionlogs2\" Left JOIN {Requisition} \"enrequisition125\" ON (\"enrequisitionlogs2\".\"requisitionid\" = \"enrequisition125\".\"id\"))  Left JOIN {User} \"enuser203\" ON (\"enrequisitionlogs2\".\"createdby\" = \"enuser203\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpdaRequisitionLogs_CreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaRequisitionLogs_CreatedOn = (cast(\"enrequisitionlogs2\".\"createdon\" as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaRequisitionLogs_CreatedOn", DbType.DateTime, qpdaRequisitionLogs_CreatedOn);
}
if (qpteUser_Name != "") {
whereBuilder.Append("(@qpteUser_Name = \"enuser203\".\"name\") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Name", DbType.String, qpteUser_Name);
}
if (qpreRequisitionLogs_RequisitionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisitionLogs_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionlogs2\".\"requisitionid\" = @qpreRequisitionLogs_RequisitionId) AND (\"enrequisitionlogs2\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionLogs_RequisitionId", DbType.Int64, qpreRequisitionLogs_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionlogs2\".\"requisitionid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enrequisitionlogs2\".\"id\" DESC ");
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
RL_229a538de0ea5acc5992a93132dd8a21 outParamList = new RL_229a538de0ea5acc5992a93132dd8a21();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionLogsByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_RequisitionLogs.GetRequisitionLogsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_229a538de0ea5acc5992a93132dd8a21 _tmp = new RL_229a538de0ea5acc5992a93132dd8a21();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionLogsByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_RequisitionLogs.GetRequisitionLogsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_229a538de0ea5acc5992a93132dd8a21)_tmp;
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

// Query Function "CountRequisitionLogs" VVclJ6ndrkG3URoMrLyxiw of Action "Wb_RequisitionLogs"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetCountRequisitionLogs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_RequisitionLogs.CountRequisitionLogs", "27255755-dda9-41ae-b751-1a0cacbcb18b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionLogs","y_Logs.Wb_RequisitionLogs.CountRequisitionLogs");
// Query Iterations: Never
// Refresh Query nm9052EE+k+fe_V83mj6xw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.sM_5IWO7CEmjymz6Zs5EoQ/ScreenDataSets.VVclJ6ndrkG3URoMrLyxiw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enrequisitionlogs3\".\"id\") \"count\"");
fromBuilder.Append(" FROM {RequisitionLogs} \"enrequisitionlogs3\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisitionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionlogs3\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionlogs3\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionlogs3\".\"requisitionid\" IS NULL)");
}
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
RL_11e68f59508e412eaf5b78801dd06b0e outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_RequisitionLogs.CountRequisitionLogs.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_RequisitionLogs.CountRequisitionLogs.List", cancellationToken: cancellationToken);
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

// Query Function "GetUsers" r9KAysrJJ0ep4ir+whA3xQ of Action "Wb_RequisitionLogs"
public static async Task<(RL_8e4276b7147c8295b1546570303ecba2,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionLogs_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Logs.Wb_RequisitionLogs.GetUsers", "ca80d2af-c9ca-4727-a9e2-2afec21037c5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionLogs","y_Logs.Wb_RequisitionLogs.GetUsers");
// Query Iterations: Multiple
// Refresh Query Ouycclbrw0W3Ww_U02FjQw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PRtIyIVlKUilQXdxhPsavg/NodesShownInESpaceTree.sM_5IWO7CEmjymz6Zs5EoQ/ScreenDataSets.r9KAysrJJ0ep4ir+whA3xQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser204\".\"name\" \"username\"");
fromBuilder.Append(" FROM (({User} \"enuser204\" Left JOIN {Requisition} \"enrequisition126\" ON (\"enuser204\".\"id\" = \"enrequisition126\".\"applicantid\"))  Inner JOIN {RequisitionLogs} \"enrequisitionlogs4\" ON (\"enuser204\".\"id\" = \"enrequisitionlogs4\".\"createdby\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisitionLogs_RequisitionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisitionLogs_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionlogs4\".\"requisitionid\" = @qpreRequisitionLogs_RequisitionId) AND (\"enrequisitionlogs4\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionLogs_RequisitionId", DbType.Int64, qpreRequisitionLogs_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionlogs4\".\"requisitionid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
groupByBuilder.Append(" GROUP BY \"enuser204\".\"name\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Logs.Wb_RequisitionLogs.GetUsers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Logs.Wb_RequisitionLogs.GetUsers.List", cancellationToken: cancellationToken);
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
