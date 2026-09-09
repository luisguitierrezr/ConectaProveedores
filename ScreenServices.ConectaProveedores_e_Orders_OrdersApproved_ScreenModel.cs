using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_OrdersApproved_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_OrdersApproved_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetOrders;
public int varLcl_CountAfterFetchGetOrders;
public RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList;
public bool varLcl_ShowOrderApproval;
public long varLcl_OrderIdForPopup;
public bool varLcIsListFullNeedRefresh;
public AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> ScreenDataSetGetOrdersApprovedFull;
public AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> ScreenDataSetGetOrdersApproved;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_OrdersApproved_ScreenModel() {
}



    public ConectaProveedores_e_Orders_OrdersApproved_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetOrders, int varLcl_CountAfterFetchGetOrders, RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList, bool varLcl_ShowOrderApproval, long varLcl_OrderIdForPopup, bool varLcIsListFullNeedRefresh, AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> ScreenDataSetGetOrdersApprovedFull, AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> ScreenDataSetGetOrdersApproved, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetOrders", "l_CountAfterFetchGetOrders", "l_DaysInAssigmentList", "l_ShowOrderApproval", "l_OrderIdForPopup", "IsListFullNeedRefresh", "GetOrdersApprovedFull", "GetOrdersApproved", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetOrders", "varLcl_CountAfterFetchGetOrders", "varLcl_DaysInAssigmentList", "varLcl_ShowOrderApproval", "varLcl_OrderIdForPopup", "varLcIsListFullNeedRefresh", "ScreenDataSetGetOrdersApprovedFull", "ScreenDataSetGetOrdersApproved", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetOrders = varLcl_ColumnJSONVarGetOrders;
this.varLcl_CountAfterFetchGetOrders = varLcl_CountAfterFetchGetOrders;
this.varLcl_DaysInAssigmentList = varLcl_DaysInAssigmentList;
this.varLcl_ShowOrderApproval = varLcl_ShowOrderApproval;
this.varLcl_OrderIdForPopup = varLcl_OrderIdForPopup;
this.varLcIsListFullNeedRefresh = varLcIsListFullNeedRefresh;
this.ScreenDataSetGetOrdersApprovedFull = ScreenDataSetGetOrdersApprovedFull;
this.ScreenDataSetGetOrdersApproved = ScreenDataSetGetOrdersApproved;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_b4754aede4b6751be05d5ea422ed168c> datasetGetOrdersApprovedFullReadDbAsync(RC_b4754aede4b6751be05d5ea422ed168c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrdersApprovedFull" f7wjErlFAEubX7zpiKygag of Action "OrdersApproved"
public static async Task<(RL_e72491aae94589c6bfa425f20599b823,long)> datasetGetOrdersApprovedFull(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpteOrderApproved_Number,long qpsuOrderMain_SupplierId,string qpusGetUserId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrdersApproved.GetOrdersApprovedFull", "1223bc7f-45b9-4b00-9b5f-bce988aca06a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrdersApproved","e_Orders.OrdersApproved.GetOrdersApprovedFull");
// Query Iterations: Multiple
// Refresh Query sVlk_xe1lE+j+QNz1w0w5A Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.0JiLxwcIGku9UxcbNGSF9Q/ScreenDataSets.f7wjErlFAEubX7zpiKygag, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapprovalstatus14\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encompany39\".\"externalid\" o11, \"encompany39\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"encurrency19\".\"code\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enordermain101\".\"id\" o51, \"enordermain101\".\"ordernumber\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, \"enordermain101\".\"procurementgroup\" o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, trim_scale(\"enordermain101\".\"totalamount\"::numeric) o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enorderstatus10\".\"label\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enregion127\".\"code\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, \"ensupplier99\".\"name\" o101, \"ensupplier99\".\"number\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126");
fromBuilder.Append(" FROM (((((((({OrderApprovalLevel} \"enorderapprovallevel28\" Left JOIN {OrderApproval} \"enorderapproval29\" ON (\"enorderapprovallevel28\".\"orderapprovalid\" = \"enorderapproval29\".\"id\"))  Left JOIN {OrderMain} \"enordermain101\" ON (\"enorderapproval29\".\"orderid\" = \"enordermain101\".\"id\") AND (\"enorderapproval29\".\"orderid\" = \"enordermain101\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus10\" ON (\"enordermain101\".\"orderstatusid\" = \"enorderstatus10\".\"id\"))  Left JOIN {Supplier} \"ensupplier99\" ON (\"enordermain101\".\"supplierid\" = \"ensupplier99\".\"id\"))  Left JOIN {Company} \"encompany39\" ON (\"enordermain101\".\"companyid\" = \"encompany39\".\"id\"))  Left JOIN {Region} \"enregion127\" ON (\"enordermain101\".\"regionid\" = \"enregion127\".\"id\"))  Left JOIN {Currency} \"encurrency19\" ON (\"enordermain101\".\"currencyid\" = \"encurrency19\".\"code\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus14\" ON (\"enorderapprovallevel28\".\"approvalstatusid\" = \"enapprovalstatus14\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteOrderApproved_Number != "" && qpteOrderApproved_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain101\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderApproved_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderApproved_Number", DbType.String, qpteOrderApproved_Number);
}
if (qpsuOrderMain_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain101\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain101\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain101\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel28\".\"approvedby\" = @qpusGetUserId) AND (\"enorderapprovallevel28\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enorderapprovallevel28\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(" OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel28\".\"rejectedby\" = @qpusGetUserId) AND (\"enorderapprovallevel28\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enorderapprovallevel28\".\"rejectedby\" IS NULL)");
}
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "OrderApproval", "Currency", "OrderApprovalLevel", "ApprovalStatus", "Supplier", "Region", "OrderStatus", "Company", "OrderMain" }, new string[] { "ENOrderApproval29", "ENCurrency19", "ENOrderApprovalLevel28", "ENApprovalStatus14", "ENSupplier99", "ENRegion127", "ENOrderStatus10", "ENCompany39", "ENOrderMain101" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderApprovalEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enorderapprovallevel28\".\"approvedon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_e72491aae94589c6bfa425f20599b823 outParamList = new RL_e72491aae94589c6bfa425f20599b823();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersApprovedFullReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrdersApproved.GetOrdersApprovedFull.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e72491aae94589c6bfa425f20599b823 _tmp = new RL_e72491aae94589c6bfa425f20599b823();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersApprovedFullReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrdersApproved.GetOrdersApprovedFull.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e72491aae94589c6bfa425f20599b823)_tmp;
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

private static async Task<RC_b4754aede4b6751be05d5ea422ed168c> datasetGetOrdersApprovedReadDbAsync(RC_b4754aede4b6751be05d5ea422ed168c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrdersApproved" ZfMNqo_FZUa48KZDdxtv1g of Action "OrdersApproved"
public static async Task<(RL_e72491aae94589c6bfa425f20599b823,long)> datasetGetOrdersApproved(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpteOrderApproved_Number,long qpsuOrderMain_SupplierId,string qpusGetUserId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrdersApproved.GetOrdersApproved", "aa0df365-c58f-4665-b8f0-a643771b6fd6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrdersApproved","e_Orders.OrdersApproved.GetOrdersApproved");
// Query Iterations: Multiple
// Refresh Query Mb7ITNVmwECLb8uPkltl7w Iterations: Multiple
// Refresh Query wHar6urDTkiswRJ2SGMjlQ Iterations: Multiple
// Refresh Query Jfy2VJt1K0WEkhHkTKX+Sw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.0JiLxwcIGku9UxcbNGSF9Q/ScreenDataSets.ZfMNqo_FZUa48KZDdxtv1g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapprovalstatus15\".\"label\" o1, \"enapprovalstatus15\".\"class\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encompany40\".\"externalid\" o11, \"encompany40\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"encurrency20\".\"code\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enordermain102\".\"id\" o51, \"enordermain102\".\"ordernumber\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, \"enordermain102\".\"procurementgroup\" o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, trim_scale(\"enordermain102\".\"totalamount\"::numeric) o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enorderstatus11\".\"label\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enregion128\".\"code\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, \"ensupplier100\".\"name\" o101, \"ensupplier100\".\"number\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126");
fromBuilder.Append(" FROM (((((((({OrderApprovalLevel} \"enorderapprovallevel29\" Left JOIN {OrderApproval} \"enorderapproval30\" ON (\"enorderapprovallevel29\".\"orderapprovalid\" = \"enorderapproval30\".\"id\"))  Left JOIN {OrderMain} \"enordermain102\" ON (\"enorderapproval30\".\"orderid\" = \"enordermain102\".\"id\") AND (\"enorderapproval30\".\"orderid\" = \"enordermain102\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus11\" ON (\"enordermain102\".\"orderstatusid\" = \"enorderstatus11\".\"id\"))  Left JOIN {Supplier} \"ensupplier100\" ON (\"enordermain102\".\"supplierid\" = \"ensupplier100\".\"id\"))  Left JOIN {Company} \"encompany40\" ON (\"enordermain102\".\"companyid\" = \"encompany40\".\"id\"))  Left JOIN {Region} \"enregion128\" ON (\"enordermain102\".\"regionid\" = \"enregion128\".\"id\"))  Left JOIN {Currency} \"encurrency20\" ON (\"enordermain102\".\"currencyid\" = \"encurrency20\".\"code\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus15\" ON (\"enorderapprovallevel29\".\"approvalstatusid\" = \"enapprovalstatus15\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteOrderApproved_Number != "" && qpteOrderApproved_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain102\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderApproved_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderApproved_Number", DbType.String, qpteOrderApproved_Number);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderApproved_Number", DbType.String, qpteOrderApproved_Number);
}
if (qpsuOrderMain_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain102\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain102\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain102\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel29\".\"approvedby\" = @qpusGetUserId) AND (\"enorderapprovallevel29\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enorderapprovallevel29\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(" OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel29\".\"rejectedby\" = @qpusGetUserId) AND (\"enorderapprovallevel29\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enorderapprovallevel29\".\"rejectedby\" IS NULL)");
}
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "ApprovalStatus", "Company", "OrderApprovalLevel", "Region", "Currency", "Supplier", "OrderMain", "OrderApproval", "OrderStatus" }, new string[] { "ENApprovalStatus15", "ENCompany40", "ENOrderApprovalLevel29", "ENRegion128", "ENCurrency20", "ENSupplier100", "ENOrderMain102", "ENOrderApproval30", "ENOrderStatus11" }, new System.Collections.Generic.Dictionary<string, string>[] { ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enorderapprovallevel29\".\"approvedon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_e72491aae94589c6bfa425f20599b823 outParamList = new RL_e72491aae94589c6bfa425f20599b823();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersApprovedReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersApproved.GetOrdersApproved.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrdersApproved.GetOrdersApproved.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e72491aae94589c6bfa425f20599b823 _tmp = new RL_e72491aae94589c6bfa425f20599b823();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersApprovedReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrdersApproved.GetOrdersApproved.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e72491aae94589c6bfa425f20599b823)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersApproved.GetOrdersApproved.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
