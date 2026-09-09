using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_OrdersToApprove_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_OrdersToApprove_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetOrders;
public int varLcl_CountAfterFetchGetOrders;
public RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList;
public bool varLcl_IsSelectAll;
public bool varLcl_IsAnyLineSelected;
public bool varLcl_ShowBulkApproveOrders;
public RL_8fd60efb0627be3c248dd395b7512757 varLcl_OrderApprovalLevelList;
public AggregateRecord<RL_7394c44f189d8cb48f64219bbd82b88d> ScreenDataSetGetOrdersToApprove;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_OrdersToApprove_ScreenModel() {
}



    public ConectaProveedores_e_Orders_OrdersToApprove_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetOrders, int varLcl_CountAfterFetchGetOrders, RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList, bool varLcl_IsSelectAll, bool varLcl_IsAnyLineSelected, bool varLcl_ShowBulkApproveOrders, RL_8fd60efb0627be3c248dd395b7512757 varLcl_OrderApprovalLevelList, AggregateRecord<RL_7394c44f189d8cb48f64219bbd82b88d> ScreenDataSetGetOrdersToApprove, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetOrders", "l_CountAfterFetchGetOrders", "l_DaysInAssigmentList", "l_IsSelectAll", "l_IsAnyLineSelected", "l_ShowBulkApproveOrders", "l_OrderApprovalLevelList", "GetOrdersToApprove", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetOrders", "varLcl_CountAfterFetchGetOrders", "varLcl_DaysInAssigmentList", "varLcl_IsSelectAll", "varLcl_IsAnyLineSelected", "varLcl_ShowBulkApproveOrders", "varLcl_OrderApprovalLevelList", "ScreenDataSetGetOrdersToApprove", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetOrders = varLcl_ColumnJSONVarGetOrders;
this.varLcl_CountAfterFetchGetOrders = varLcl_CountAfterFetchGetOrders;
this.varLcl_DaysInAssigmentList = varLcl_DaysInAssigmentList;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsAnyLineSelected = varLcl_IsAnyLineSelected;
this.varLcl_ShowBulkApproveOrders = varLcl_ShowBulkApproveOrders;
this.varLcl_OrderApprovalLevelList = varLcl_OrderApprovalLevelList;
this.ScreenDataSetGetOrdersToApprove = ScreenDataSetGetOrdersToApprove;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_0a41c52434474d75060edec9b8b557c0> datasetGetOrdersToApproveReadDbAsync(RC_0a41c52434474d75060edec9b8b557c0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssDaysInAssigment = r.ReadInteger(index++, "CurrencyOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysInAssigmentCompanySupplierRegionRecord.DaysInAssigment", 0);
rec.ssIsSelected = r.ReadBoolean(index++, "CurrencyOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysInAssigmentCompanySupplierRegionRecord.IsSelected", false);
return rec;
}
// Query Function "GetOrdersToApprove" S8RHcZa6VkeAEK+8vk6IRQ of Action "OrdersToApprove"
public static async Task<(RL_7394c44f189d8cb48f64219bbd82b88d,long)> datasetGetOrdersToApprove(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinDaysInAssigment,string qpteOrderToApprove_Number,long qpsuOrderMain_SupplierId,long qpenOrderApprovalLevel_EntraRoleId,string qpusOrderApprovalLevel_AssignedTo,long qpreOrderMain_DivisionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrdersToApprove.GetOrdersToApprove", "7147c44b-ba96-4756-8010-afbcbe4e8845");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrdersToApprove","e_Orders.OrdersToApprove.GetOrdersToApprove");
// Query Iterations: Multiple
// Refresh Query ZeDGeBFnjkGfJOiw8q7Xqg Iterations: Multiple
// Refresh Query k_MdU_gqq0KRhCfrrmhjig Iterations: Multiple
// Refresh Query sIU8pckaxkuusGx0SBYk8w Iterations: Multiple
// Refresh Query TN1EOpt0W0a0WF3Z2dbASw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.+QgJCCA9r0OwNG4qbKzO3A/ScreenDataSets.S8RHcZa6VkeAEK+8vk6IRQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany33\".\"externalid\" o1, \"encompany33\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encurrency11\".\"code\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enorderapprovallevel21\".\"id\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enorderapprovallevel21\".\"approvalstatusid\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, \"enordermain87\".\"id\" o41, \"enordermain87\".\"ordernumber\" o42, \"enordermain87\".\"orderdate\" o43, \"enordermain87\".\"orderstatusid\" o44, \"enordermain87\".\"previousorderstatusid\" o45, \"enordermain87\".\"assignmentcode\" o46, \"enordermain87\".\"supplierid\" o47, \"enordermain87\".\"companyid\" o48, \"enordermain87\".\"documenttypeid\" o49, \"enordermain87\".\"currencyid\" o50, \"enordermain87\".\"telceldirectionid\" o51, \"enordermain87\".\"procurementgroup\" o52, \"enordermain87\".\"creatorsapnumber\" o53, \"enordermain87\".\"creatorsapname\" o54, \"enordermain87\".\"country\" o55, \"enordermain87\".\"isdeleted\" o56, \"enordermain87\".\"isreleased\" o57, trim_scale(\"enordermain87\".\"exchangerate\"::numeric) o58, \"enordermain87\".\"sustainabilitycategory\" o59, \"enordermain87\".\"sustainabilitysubcategory\" o60, trim_scale(\"enordermain87\".\"totalamount\"::numeric) o61, \"enordermain87\".\"fromcosmoz\" o62, \"enordermain87\".\"regionid\" o63, \"enordermain87\".\"divisionid\" o64, \"enordermain87\".\"applicant\" o65, \"enordermain87\".\"createdby\" o66, \"enordermain87\".\"createdon\" o67, \"enordermain87\".\"updatedby\" o68, \"enordermain87\".\"updatedon\" o69, NULL o70, \"enorderstatus1\".\"label\" o71, \"enorderstatus1\".\"class\" o72, NULL o73, NULL o74, NULL o75, NULL o76, \"enregion115\".\"code\" o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, \"ensupplier88\".\"name\" o91, \"ensupplier88\".\"number\" o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, (CASE WHEN (\"enorderapprovallevel21\".\"rejectedby\" IS NOT NULL) THEN (date_part('day', cast(\"enorderapprovallevel21\".\"rejectedon\" as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) ELSE (CASE WHEN (\"enorderapprovallevel21\".\"approvedby\" IS NOT NULL) THEN (date_part('day', cast(\"enorderapprovallevel21\".\"approvedon\" as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) ELSE (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) END) END) \"daysinassigment\", 0 \"isselected\"");
fromBuilder.Append(" FROM ((((((({OrderApprovalLevel} \"enorderapprovallevel21\" Left JOIN {OrderApproval} \"enorderapproval21\" ON (\"enorderapprovallevel21\".\"orderapprovalid\" = \"enorderapproval21\".\"id\"))  Left JOIN {OrderMain} \"enordermain87\" ON (\"enorderapproval21\".\"orderid\" = \"enordermain87\".\"id\") AND (\"enorderapproval21\".\"orderid\" = \"enordermain87\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus1\" ON (\"enordermain87\".\"orderstatusid\" = \"enorderstatus1\".\"id\"))  Left JOIN {Supplier} \"ensupplier88\" ON (\"enordermain87\".\"supplierid\" = \"ensupplier88\".\"id\"))  Left JOIN {Company} \"encompany33\" ON (\"enordermain87\".\"companyid\" = \"encompany33\".\"id\"))  Left JOIN {Region} \"enregion115\" ON (\"enordermain87\".\"regionid\" = \"enregion115\".\"id\"))  Left JOIN {Currency} \"encurrency11\" ON (\"enordermain87\".\"currencyid\" = \"encurrency11\".\"code\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteOrderToApprove_Number != "" && qpteOrderToApprove_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain87\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderToApprove_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderToApprove_Number", DbType.String, qpteOrderToApprove_Number);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderToApprove_Number", DbType.String, qpteOrderToApprove_Number);
}
if (qpinDaysInAssigment != 0) {
whereBuilder.Append("(((@qpinDaysInAssigment = 4) AND ((CASE WHEN (\"enorderapprovallevel21\".\"rejectedby\" IS NOT NULL) THEN (date_part('day', cast(\"enorderapprovallevel21\".\"rejectedon\" as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) ELSE (CASE WHEN (\"enorderapprovallevel21\".\"approvedby\" IS NOT NULL) THEN (date_part('day', cast(\"enorderapprovallevel21\".\"approvedon\" as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) ELSE (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) END) END) >= @qpinDaysInAssigment)) OR ((CASE WHEN (\"enorderapprovallevel21\".\"rejectedby\" IS NOT NULL) THEN (date_part('day', cast(\"enorderapprovallevel21\".\"rejectedon\" as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) ELSE (CASE WHEN (\"enorderapprovallevel21\".\"approvedby\" IS NOT NULL) THEN (date_part('day', cast(\"enorderapprovallevel21\".\"approvedon\" as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) ELSE (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel21\".\"assignedon\" as date)::timestamptz)) END) END) = @qpinDaysInAssigment)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinDaysInAssigment", DbType.Int32, qpinDaysInAssigment);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinDaysInAssigment", DbType.Int32, qpinDaysInAssigment);
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCountCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
}
if (qpsuOrderMain_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain87\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain87\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain87\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(\"enordermain87\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("gqnAVya9FU+_7f97jQeuCA"))).ssId);
whereBuilder.Append(") AND (\"enorderapprovallevel21\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") AND (");
if ((qpusOrderApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel21\".\"assignedto\" = @qpusOrderApprovalLevel_AssignedTo) AND (\"enorderapprovallevel21\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enorderapprovallevel21\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR ((\"enorderapprovallevel21\".\"assignedto\" IS NULL) AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain87\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain87\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain87\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderapprovallevel21\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel21\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderapprovallevel21\".\"entraroleid\" IS NULL)");
}
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "OrderApproval", "Currency", "OrderStatus", "OrderMain", "Region", "Company", "Supplier", "OrderApprovalLevel" }, new string[] { "ENOrderApproval21", "ENCurrency11", "ENOrderStatus1", "ENOrderMain87", "ENRegion115", "ENCompany33", "ENSupplier88", "ENOrderApprovalLevel21" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderApprovalEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalLevelEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
} else {
orderByBuilder.Append(" ORDER BY 1 ASC");
}
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
RL_7394c44f189d8cb48f64219bbd82b88d outParamList = new RL_7394c44f189d8cb48f64219bbd82b88d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersToApproveReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersToApprove.GetOrdersToApprove.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrdersToApprove.GetOrdersToApprove.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7394c44f189d8cb48f64219bbd82b88d _tmp = new RL_7394c44f189d8cb48f64219bbd82b88d();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersToApproveReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrdersToApprove.GetOrdersToApprove.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7394c44f189d8cb48f64219bbd82b88d)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersToApprove.GetOrdersToApprove.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
