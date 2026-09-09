using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public DateTime inParami_Refresh;
public DateTime varLcl_DateTimeVar;
public string varLcl_UserName;
public int varLcMaxRecords;
public AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountInvoiceLogs;
public AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers;
public AggregateRecord<RL_8623462923ce4f5fca06be3fb804a6be> ScreenDataSetGetInvoiceLogsByInvoiceId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel(long inParami_InvoiceId, DateTime inParami_Refresh, DateTime varLcl_DateTimeVar, string varLcl_UserName, int varLcMaxRecords, AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ScreenDataSetCountInvoiceLogs, AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ScreenDataSetGetUsers, AggregateRecord<RL_8623462923ce4f5fca06be3fb804a6be> ScreenDataSetGetInvoiceLogsByInvoiceId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_Refresh", "l_DateTimeVar", "l_UserName", "MaxRecords", "CountInvoiceLogs", "GetUsers", "GetInvoiceLogsByInvoiceId", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_Refresh", "varLcl_DateTimeVar", "varLcl_UserName", "varLcMaxRecords", "ScreenDataSetCountInvoiceLogs", "ScreenDataSetGetUsers", "ScreenDataSetGetInvoiceLogsByInvoiceId", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_Refresh = inParami_Refresh;
this.varLcl_DateTimeVar = varLcl_DateTimeVar;
this.varLcl_UserName = varLcl_UserName;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetCountInvoiceLogs = ScreenDataSetCountInvoiceLogs;
this.ScreenDataSetGetUsers = ScreenDataSetGetUsers;
this.ScreenDataSetGetInvoiceLogsByInvoiceId = ScreenDataSetGetInvoiceLogsByInvoiceId;
this.clientVariables = clientVariables;
}



    
// Query Function "CountInvoiceLogs" rZZUPHd5QUOa1VDnXrnXhA of Action "Wb_InvoiceDetailsHistory"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetCountInvoiceLogs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetailsHistory.CountInvoiceLogs", "3c5496ad-7977-4341-9ad5-50e75eb9d784");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetailsHistory","d_Invoices.Wb_InvoiceDetailsHistory.CountInvoiceLogs");
// Query Iterations: Never
// Refresh Query pzF0cvtTMkSfLT2NefuTnA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.Ts_0wS+oaEaApOM0cWSoyQ/ScreenDataSets.rZZUPHd5QUOa1VDnXrnXhA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"eninvoicelog2\".\"id\") \"count\"");
fromBuilder.Append(" FROM {InvoiceLog} \"eninvoicelog2\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoiceId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicelog2\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicelog2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicelog2\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetailsHistory.CountInvoiceLogs.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetailsHistory.CountInvoiceLogs.List", cancellationToken: cancellationToken);
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

// Query Function "GetUsers" iD4Fj4+ZSkig4SWIZgOO7Q of Action "Wb_InvoiceDetailsHistory"
public static async Task<(RL_8e4276b7147c8295b1546570303ecba2,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisition_RegionId,long qpinInvoiceLog_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetailsHistory.GetUsers", "8f053e88-998f-484a-a0e1-258866038eed");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetailsHistory","d_Invoices.Wb_InvoiceDetailsHistory.GetUsers");
// Query Iterations: Multiple
// Refresh Query k0w+yzWUQES8yN5pmEz6GQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.Ts_0wS+oaEaApOM0cWSoyQ/ScreenDataSets.iD4Fj4+ZSkig4SWIZgOO7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser172\".\"name\" \"username\"");
fromBuilder.Append(" FROM (({User} \"enuser172\" Left JOIN {InvoiceLog} \"eninvoicelog3\" ON (\"enuser172\".\"id\" = \"eninvoicelog3\".\"createdby\"))  Left JOIN ({Invoice} \"eninvoice123\" Left JOIN {Requisition} \"enrequisition99\" ON (\"enrequisition99\".\"id\" = \"eninvoice123\".\"requisitionid\"))  ON (\"enuser172\".\"id\" = \"eninvoice123\".\"createdby\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoiceLog_InvoiceId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpinInvoiceLog_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicelog3\".\"invoiceid\" = @qpinInvoiceLog_InvoiceId) AND (\"eninvoicelog3\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceLog_InvoiceId", DbType.Int64, qpinInvoiceLog_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicelog3\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition99\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition99\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition99\".\"regionid\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enuser172\".\"name\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetailsHistory.GetUsers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetailsHistory.GetUsers.List", cancellationToken: cancellationToken);
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

private static async Task<RC_febdfe749051cd5849a077ecffdddeec> datasetGetInvoiceLogsByInvoiceIdReadDbAsync(RC_febdfe749051cd5849a077ecffdddeec rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceLog.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceLogsByInvoiceId" UZ9hvhTAN0So_3YpL61sLA of Action "Wb_InvoiceDetailsHistory"
public static async Task<(RL_8623462923ce4f5fca06be3fb804a6be,long)> datasetGetInvoiceLogsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpinInvoice_Id,DateTime qpdaInvoiceLog_CreatedOn,string qpteUser_Name,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetailsHistory.GetInvoiceLogsByInvoiceId", "be619f51-c014-4437-a8ff-76292fad6c2c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetailsHistory","d_Invoices.Wb_InvoiceDetailsHistory.GetInvoiceLogsByInvoiceId");
// Query Iterations: Multiple
// Refresh Query jMKo_tV+TUaB1E5a4+tVWA Iterations: Multiple
// Refresh Query kwyE4DQVrUKylqVvEFqanA Iterations: Multiple
// Refresh Query 5hKCbCKsHkqjihh3_ebm6w Iterations: Multiple
// Refresh Query iWvnN80d0kqR7iVp5u9_ew Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.Ts_0wS+oaEaApOM0cWSoyQ/ScreenDataSets.UZ9hvhTAN0So_3YpL61sLA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"eninvoicelog4\".\"message\" o26, \"eninvoicelog4\".\"createdon\" o27, \"eninvoicelog4\".\"createdby\" o28, \"eninvoicelog4\".\"iserror\" o29, NULL o30, \"enuser173\".\"name\" o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM (({InvoiceLog} \"eninvoicelog4\" Left JOIN {Invoice} \"eninvoice124\" ON (\"eninvoice124\".\"id\" = \"eninvoicelog4\".\"invoiceid\"))  Left JOIN {User} \"enuser173\" ON (\"eninvoicelog4\".\"createdby\" = \"enuser173\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpdaInvoiceLog_CreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaInvoiceLog_CreatedOn = (cast(\"eninvoicelog4\".\"createdon\" as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvoiceLog_CreatedOn", DbType.DateTime, qpdaInvoiceLog_CreatedOn);
}
if (qpteUser_Name != "") {
whereBuilder.Append("(@qpteUser_Name = \"enuser173\".\"name\") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Name", DbType.String, qpteUser_Name);
}
if (qpinInvoice_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice124\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice124\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice124\".\"id\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"eninvoicelog4\".\"id\" DESC ");
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
RL_8623462923ce4f5fca06be3fb804a6be outParamList = new RL_8623462923ce4f5fca06be3fb804a6be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceLogsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetailsHistory.GetInvoiceLogsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8623462923ce4f5fca06be3fb804a6be _tmp = new RL_8623462923ce4f5fca06be3fb804a6be();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceLogsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetailsHistory.GetInvoiceLogsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8623462923ce4f5fca06be3fb804a6be)_tmp;
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
