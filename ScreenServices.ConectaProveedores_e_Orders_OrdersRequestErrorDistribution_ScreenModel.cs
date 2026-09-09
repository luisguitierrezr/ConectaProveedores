using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetOrders;
public int varLcl_CountAfterFetchGetOrders;
public bool varLcl_Loading;
public RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList;
public DateTime varLcl_Refresh;
public long varLcl_OrderMainId;
public bool varLcl_LogsPopUp;
public bool varLcl_DistributionPopUp;
public string varLcl_OrderNumber;
public AggregateRecord<RL_7ea77cbfb509e64003daa02c749dcc25> ScreenDataSetGetOrdersWithErrors;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel() {
}



    public ConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetOrders, int varLcl_CountAfterFetchGetOrders, bool varLcl_Loading, RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList, DateTime varLcl_Refresh, long varLcl_OrderMainId, bool varLcl_LogsPopUp, bool varLcl_DistributionPopUp, string varLcl_OrderNumber, AggregateRecord<RL_7ea77cbfb509e64003daa02c749dcc25> ScreenDataSetGetOrdersWithErrors, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetOrders", "l_CountAfterFetchGetOrders", "l_Loading", "l_DaysInAssigmentList", "l_Refresh", "l_OrderMainId", "l_LogsPopUp", "l_DistributionPopUp", "l_OrderNumber", "GetOrdersWithErrors", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetOrders", "varLcl_CountAfterFetchGetOrders", "varLcl_Loading", "varLcl_DaysInAssigmentList", "varLcl_Refresh", "varLcl_OrderMainId", "varLcl_LogsPopUp", "varLcl_DistributionPopUp", "varLcl_OrderNumber", "ScreenDataSetGetOrdersWithErrors", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetOrders = varLcl_ColumnJSONVarGetOrders;
this.varLcl_CountAfterFetchGetOrders = varLcl_CountAfterFetchGetOrders;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_DaysInAssigmentList = varLcl_DaysInAssigmentList;
this.varLcl_Refresh = varLcl_Refresh;
this.varLcl_OrderMainId = varLcl_OrderMainId;
this.varLcl_LogsPopUp = varLcl_LogsPopUp;
this.varLcl_DistributionPopUp = varLcl_DistributionPopUp;
this.varLcl_OrderNumber = varLcl_OrderNumber;
this.ScreenDataSetGetOrdersWithErrors = ScreenDataSetGetOrdersWithErrors;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_f100e5d5057b18be95e8602dfe9dd2af> datasetGetOrdersWithErrorsReadDbAsync(RC_f100e5d5057b18be95e8602dfe9dd2af rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssDiffDays = r.ReadInteger(index++, "CurrencyUserOrderStatusOrderApprovalOrderMainDiffDaysCompanySupplierRegionRecord.DiffDays", 0);
return rec;
}
// Query Function "GetOrdersWithErrors" 9F2JbVDXsUuXTcWnJp36Jw of Action "OrdersRequestErrorDistribution"
public static async Task<(RL_7ea77cbfb509e64003daa02c749dcc25,long)> datasetGetOrdersWithErrors(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinDiffDays,string qpteOrderWithErrors_Number,long qpsuOrderMain_SupplierId,long qpreOrderMain_DivisionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrdersRequestErrorDistribution.GetOrdersWithErrors", "6d895df4-d750-4bb1-974d-c5a7269dfa27");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrdersRequestErrorDistribution","e_Orders.OrdersRequestErrorDistribution.GetOrdersWithErrors");
// Query Iterations: Multiple
// Refresh Query pzULXThDI0CWgkaK1CXpjA Iterations: Multiple
// Refresh Query U378uYEfnEuFQZOjF2RlBg Iterations: Multiple
// Refresh Query lUjhOyJaeEyCII8embJpdg Iterations: Multiple
// Refresh Query q_GNQ85ACEKPOIf99TjTfw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.SP_2QFQrEUy+2VMktK_PBA/ScreenDataSets.9F2JbVDXsUuXTcWnJp36Jw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany34\".\"externalid\" o1, \"encompany34\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encurrency12\".\"code\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enordermain90\".\"id\" o24, \"enordermain90\".\"ordernumber\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enordermain90\".\"procurementgroup\" o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, trim_scale(\"enordermain90\".\"totalamount\"::numeric) o44, NULL o45, NULL o46, NULL o47, \"enordermain90\".\"applicant\" o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, \"enorderstatus2\".\"label\" o54, \"enorderstatus2\".\"class\" o55, NULL o56, NULL o57, NULL o58, NULL o59, \"enregion120\".\"code\" o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, \"ensupplier91\".\"name\" o74, \"ensupplier91\".\"number\" o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enordermain90\".\"createdon\" as date)::timestamptz)) \"diffdays\"");
fromBuilder.Append(" FROM ((((((({OrderMain} \"enordermain90\" Left JOIN {Supplier} \"ensupplier91\" ON (\"enordermain90\".\"supplierid\" = \"ensupplier91\".\"id\"))  Left JOIN {Company} \"encompany34\" ON (\"enordermain90\".\"companyid\" = \"encompany34\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus2\" ON (\"enordermain90\".\"orderstatusid\" = \"enorderstatus2\".\"id\"))  Left JOIN {OrderApproval} \"enorderapproval23\" ON (\"enordermain90\".\"id\" = \"enorderapproval23\".\"orderid\"))  Left JOIN {User} \"enuser176\" ON (\"enordermain90\".\"createdby\" = \"enuser176\".\"id\"))  Left JOIN {Region} \"enregion120\" ON (\"enordermain90\".\"regionid\" = \"enregion120\".\"id\"))  Left JOIN {Currency} \"encurrency12\" ON (\"enordermain90\".\"currencyid\" = \"encurrency12\".\"code\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (\"enorderapproval23\".\"id\" IS NULL) AND ((\"enordermain90\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append(") OR (\"enordermain90\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId);
whereBuilder.Append(")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteOrderWithErrors_Number != "" && qpteOrderWithErrors_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain90\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderWithErrors_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderWithErrors_Number", DbType.String, qpteOrderWithErrors_Number);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderWithErrors_Number", DbType.String, qpteOrderWithErrors_Number);
}
if (qpsuOrderMain_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain90\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain90\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain90\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpinDiffDays != 0) {
whereBuilder.Append("(((@qpinDiffDays = 3) AND ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enordermain90\".\"createdon\" as date)::timestamptz)) >= @qpinDiffDays)) OR ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enordermain90\".\"createdon\" as date)::timestamptz)) = @qpinDiffDays)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinDiffDays", DbType.Int32, qpinDiffDays);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinDiffDays", DbType.Int32, qpinDiffDays);
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCountCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
}
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain90\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain90\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain90\".\"divisionid\" IS NULL)");
}
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "OrderStatus", "OrderApproval", "Supplier", "OrderMain", "Company", "Currency", "User", "Region" }, new string[] { "ENOrderStatus2", "ENOrderApproval23", "ENSupplier91", "ENOrderMain90", "ENCompany34", "ENCurrency12", "ENUser176", "ENRegion120" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderStatusEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_7ea77cbfb509e64003daa02c749dcc25 outParamList = new RL_7ea77cbfb509e64003daa02c749dcc25();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersWithErrorsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersRequestErrorDistribution.GetOrdersWithErrors.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrdersRequestErrorDistribution.GetOrdersWithErrors.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7ea77cbfb509e64003daa02c749dcc25 _tmp = new RL_7ea77cbfb509e64003daa02c749dcc25();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersWithErrorsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrdersRequestErrorDistribution.GetOrdersWithErrors.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7ea77cbfb509e64003daa02c749dcc25)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersRequestErrorDistribution.GetOrdersWithErrors.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
