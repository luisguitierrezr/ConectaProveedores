using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_OrdersInComplement_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_OrdersInComplement_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetOrders;
public int varLcl_CountAfterFetchGetOrders;
public bool varLcl_Loading;
public RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList;
public bool varLcIsListFullNeedRefresh;
public AggregateRecord<RL_b7a22557f49e97dcd2b91bca0c98fab2> ScreenDataSetGetOrdersInComplementFull;
public AggregateRecord<RL_b7a22557f49e97dcd2b91bca0c98fab2> ScreenDataSetGetOrdersInComplement;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_OrdersInComplement_ScreenModel() {
}



    public ConectaProveedores_e_Orders_OrdersInComplement_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetOrders, int varLcl_CountAfterFetchGetOrders, bool varLcl_Loading, RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList, bool varLcIsListFullNeedRefresh, AggregateRecord<RL_b7a22557f49e97dcd2b91bca0c98fab2> ScreenDataSetGetOrdersInComplementFull, AggregateRecord<RL_b7a22557f49e97dcd2b91bca0c98fab2> ScreenDataSetGetOrdersInComplement, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetOrders", "l_CountAfterFetchGetOrders", "l_Loading", "l_DaysInAssigmentList", "IsListFullNeedRefresh", "GetOrdersInComplementFull", "GetOrdersInComplement", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetOrders", "varLcl_CountAfterFetchGetOrders", "varLcl_Loading", "varLcl_DaysInAssigmentList", "varLcIsListFullNeedRefresh", "ScreenDataSetGetOrdersInComplementFull", "ScreenDataSetGetOrdersInComplement", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetOrders = varLcl_ColumnJSONVarGetOrders;
this.varLcl_CountAfterFetchGetOrders = varLcl_CountAfterFetchGetOrders;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_DaysInAssigmentList = varLcl_DaysInAssigmentList;
this.varLcIsListFullNeedRefresh = varLcIsListFullNeedRefresh;
this.ScreenDataSetGetOrdersInComplementFull = ScreenDataSetGetOrdersInComplementFull;
this.ScreenDataSetGetOrdersInComplement = ScreenDataSetGetOrdersInComplement;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_d18f18b6c2e290ef15fc1a9c5cb968d2> datasetGetOrdersInComplementFullReadDbAsync(RC_d18f18b6c2e290ef15fc1a9c5cb968d2 rec, DbDataReader r, CancellationToken cancellationToken) {
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
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssDaysInAssigment = r.ReadInteger(index++, "CurrencyUserOrderStatusOrderApprovalApprovalStatusOrderMainOrderApprovalLevelIsSelectedDaysInAssigmentUser_Extended_InternalCompanySupplierRegionRecord.DaysInAssigment", 0);
rec.ssIsSelected = r.ReadBoolean(index++, "CurrencyUserOrderStatusOrderApprovalApprovalStatusOrderMainOrderApprovalLevelIsSelectedDaysInAssigmentUser_Extended_InternalCompanySupplierRegionRecord.IsSelected", false);
return rec;
}
// Query Function "GetOrdersInComplementFull" XriyOLicHkWtTy4N2SJHaQ of Action "OrdersInComplement"
public static async Task<(RL_b7a22557f49e97dcd2b91bca0c98fab2,long)> datasetGetOrdersInComplementFull(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinDaysInAssigment,string qpteOrderInComplement_Number,long qpsuOrderMain_SupplierId,string qpusOrderApprovalLevel_AssignedTo,long qpreOrderMain_DivisionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrdersInComplement.GetOrdersInComplementFull", "38b2b85e-9cb8-451e-ad4f-2e0dd9224769");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrdersInComplement","e_Orders.OrdersInComplement.GetOrdersInComplementFull");
// Query Iterations: Multiple
// Refresh Query kHfZ1MbYnUqgdezuLAsGcw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.y6v_YuoVFEaMsqFiWTzUdg/ScreenDataSets.XriyOLicHkWtTy4N2SJHaQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapprovalstatus12\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encompany36\".\"externalid\" o11, \"encompany36\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"encurrency16\".\"code\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enordermain94\".\"id\" o51, \"enordermain94\".\"ordernumber\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, \"enordermain94\".\"procurementgroup\" o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, trim_scale(\"enordermain94\".\"totalamount\"::numeric) o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enorderstatus4\".\"label\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enregion122\".\"code\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, \"ensupplier93\".\"name\" o101, \"ensupplier93\".\"number\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel23\".\"assignedon\" as date)::timestamptz)) \"daysinassigment\", 0 \"isselected\"");
fromBuilder.Append(" FROM (((((((((({OrderMain} \"enordermain94\" Left JOIN {Supplier} \"ensupplier93\" ON (\"enordermain94\".\"supplierid\" = \"ensupplier93\".\"id\"))  Left JOIN {Company} \"encompany36\" ON (\"enordermain94\".\"companyid\" = \"encompany36\".\"id\"))  Left JOIN {User} \"enuser177\" ON (\"enordermain94\".\"createdby\" = \"enuser177\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal107\" ON (\"enuser177\".\"id\" = \"enuser_extended_internal107\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus4\" ON (\"enordermain94\".\"orderstatusid\" = \"enorderstatus4\".\"id\"))  Left JOIN {OrderApproval} \"enorderapproval24\" ON (\"enordermain94\".\"id\" = \"enorderapproval24\".\"orderid\") AND (\"enorderapproval24\".\"orderid\" = \"enordermain94\".\"id\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel23\" ON (\"enorderapproval24\".\"id\" = \"enorderapprovallevel23\".\"orderapprovalid\"))  Left JOIN {Region} \"enregion122\" ON (\"enordermain94\".\"regionid\" = \"enregion122\".\"id\"))  Left JOIN {Currency} \"encurrency16\" ON (\"enordermain94\".\"currencyid\" = \"encurrency16\".\"code\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus12\" ON (\"enorderapprovallevel23\".\"approvalstatusid\" = \"enapprovalstatus12\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteOrderInComplement_Number != "" && qpteOrderInComplement_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain94\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderInComplement_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderInComplement_Number", DbType.String, qpteOrderInComplement_Number);
}
if (qpsuOrderMain_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain94\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain94\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain94\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpinDaysInAssigment != 0) {
whereBuilder.Append("(((@qpinDaysInAssigment = 3) AND ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel23\".\"assignedon\" as date)::timestamptz)) >= @qpinDaysInAssigment)) OR ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel23\".\"assignedon\" as date)::timestamptz)) = @qpinDaysInAssigment)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinDaysInAssigment", DbType.Int32, qpinDaysInAssigment);
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
}
whereBuilder.Append("((\"enordermain94\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"))).ssId);
whereBuilder.Append(") OR (\"enordermain94\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId);
whereBuilder.Append(")) AND (\"enorderapprovallevel23\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId);
whereBuilder.Append(") AND ");
if ((qpusOrderApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel23\".\"assignedto\" = @qpusOrderApprovalLevel_AssignedTo) AND (\"enorderapprovallevel23\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enorderapprovallevel23\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain94\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain94\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain94\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordermain94\".\"isreleased\" = 1)");
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "ApprovalStatus", "Supplier", "OrderApprovalLevel", "User_Extended_Internal", "Currency", "User", "Company", "Region", "OrderStatus", "OrderMain", "OrderApproval" }, new string[] { "ENApprovalStatus12", "ENSupplier93", "ENOrderApprovalLevel23", "ENUser_Extended_Internal107", "ENCurrency16", "ENUser177", "ENCompany36", "ENRegion122", "ENOrderStatus4", "ENOrderMain94", "ENOrderApproval24" }, new System.Collections.Generic.Dictionary<string, string>[] { ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENUser_Extended_InternalEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_b7a22557f49e97dcd2b91bca0c98fab2 outParamList = new RL_b7a22557f49e97dcd2b91bca0c98fab2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersInComplementFullReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[11];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrdersInComplement.GetOrdersInComplementFull.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b7a22557f49e97dcd2b91bca0c98fab2 _tmp = new RL_b7a22557f49e97dcd2b91bca0c98fab2();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersInComplementFullReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrdersInComplement.GetOrdersInComplementFull.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b7a22557f49e97dcd2b91bca0c98fab2)_tmp;
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

private static async Task<RC_d18f18b6c2e290ef15fc1a9c5cb968d2> datasetGetOrdersInComplementReadDbAsync(RC_d18f18b6c2e290ef15fc1a9c5cb968d2 rec, DbDataReader r, CancellationToken cancellationToken) {
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
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssDaysInAssigment = r.ReadInteger(index++, "CurrencyUserOrderStatusOrderApprovalApprovalStatusOrderMainOrderApprovalLevelIsSelectedDaysInAssigmentUser_Extended_InternalCompanySupplierRegionRecord.DaysInAssigment", 0);
rec.ssIsSelected = r.ReadBoolean(index++, "CurrencyUserOrderStatusOrderApprovalApprovalStatusOrderMainOrderApprovalLevelIsSelectedDaysInAssigmentUser_Extended_InternalCompanySupplierRegionRecord.IsSelected", false);
return rec;
}
// Query Function "GetOrdersInComplement" FwABnxV8DkWeIu10sCytYg of Action "OrdersInComplement"
public static async Task<(RL_b7a22557f49e97dcd2b91bca0c98fab2,long)> datasetGetOrdersInComplement(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinDaysInAssigment,string qpteOrderInComplement_Number,long qpsuOrderMain_SupplierId,string qpusOrderApprovalLevel_AssignedTo,long qpreOrderMain_DivisionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrdersInComplement.GetOrdersInComplement", "9f010017-7c15-450e-9e22-ed74b02cad62");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrdersInComplement","e_Orders.OrdersInComplement.GetOrdersInComplement");
// Query Iterations: Multiple
// Refresh Query d2SNhEkVsESUoGYDoIrviQ Iterations: Multiple
// Refresh Query ZVo5Gt7p8UCaJIJzKVTaeg Iterations: Multiple
// Refresh Query z2qVc+4Mw0qyZXpBpCnbRg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.y6v_YuoVFEaMsqFiWTzUdg/ScreenDataSets.FwABnxV8DkWeIu10sCytYg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encompany37\".\"externalid\" o11, \"encompany37\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"encurrency17\".\"code\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enordermain95\".\"id\" o51, \"enordermain95\".\"ordernumber\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, \"enordermain95\".\"procurementgroup\" o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, trim_scale(\"enordermain95\".\"totalamount\"::numeric) o71, NULL o72, NULL o73, NULL o74, \"enordermain95\".\"applicant\" o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enorderstatus5\".\"label\" o81, \"enorderstatus5\".\"class\" o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enregion123\".\"code\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, \"ensupplier94\".\"name\" o101, \"ensupplier94\".\"number\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel24\".\"assignedon\" as date)::timestamptz)) \"daysinassigment\", 0 \"isselected\"");
fromBuilder.Append(" FROM (((((((((({OrderMain} \"enordermain95\" Left JOIN {Supplier} \"ensupplier94\" ON (\"enordermain95\".\"supplierid\" = \"ensupplier94\".\"id\"))  Left JOIN {Company} \"encompany37\" ON (\"enordermain95\".\"companyid\" = \"encompany37\".\"id\"))  Left JOIN {User} \"enuser178\" ON (\"enordermain95\".\"createdby\" = \"enuser178\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal108\" ON (\"enuser178\".\"id\" = \"enuser_extended_internal108\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus5\" ON (\"enordermain95\".\"orderstatusid\" = \"enorderstatus5\".\"id\"))  Left JOIN {OrderApproval} \"enorderapproval25\" ON (\"enordermain95\".\"id\" = \"enorderapproval25\".\"orderid\") AND (\"enorderapproval25\".\"orderid\" = \"enordermain95\".\"id\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel24\" ON (\"enorderapproval25\".\"id\" = \"enorderapprovallevel24\".\"orderapprovalid\"))  Left JOIN {Region} \"enregion123\" ON (\"enordermain95\".\"regionid\" = \"enregion123\".\"id\"))  Left JOIN {Currency} \"encurrency17\" ON (\"enordermain95\".\"currencyid\" = \"encurrency17\".\"code\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus13\" ON (\"enorderapprovallevel24\".\"approvalstatusid\" = \"enapprovalstatus13\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteOrderInComplement_Number != "" && qpteOrderInComplement_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain95\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderInComplement_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderInComplement_Number", DbType.String, qpteOrderInComplement_Number);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderInComplement_Number", DbType.String, qpteOrderInComplement_Number);
}
if (qpsuOrderMain_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain95\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain95\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain95\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpinDaysInAssigment != 0) {
whereBuilder.Append("(((@qpinDaysInAssigment = 3) AND ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel24\".\"assignedon\" as date)::timestamptz)) >= @qpinDaysInAssigment)) OR ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enorderapprovallevel24\".\"assignedon\" as date)::timestamptz)) = @qpinDaysInAssigment)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinDaysInAssigment", DbType.Int32, qpinDaysInAssigment);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinDaysInAssigment", DbType.Int32, qpinDaysInAssigment);
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCountCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
}
whereBuilder.Append("((\"enordermain95\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"))).ssId);
whereBuilder.Append(") OR (\"enordermain95\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId);
whereBuilder.Append(")) AND (\"enorderapprovallevel24\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId);
whereBuilder.Append(") AND ");
if ((qpusOrderApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel24\".\"assignedto\" = @qpusOrderApprovalLevel_AssignedTo) AND (\"enorderapprovallevel24\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enorderapprovallevel24\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain95\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain95\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain95\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordermain95\".\"isreleased\" = 1)");
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Company", "Region", "OrderApprovalLevel", "OrderMain", "Currency", "User_Extended_Internal", "User", "OrderStatus", "ApprovalStatus", "Supplier", "OrderApproval" }, new string[] { "ENCompany37", "ENRegion123", "ENOrderApprovalLevel24", "ENOrderMain95", "ENCurrency17", "ENUser_Extended_Internal108", "ENUser178", "ENOrderStatus5", "ENApprovalStatus13", "ENSupplier94", "ENOrderApproval25" }, new System.Collections.Generic.Dictionary<string, string>[] { ENCompanyEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENUser_Extended_InternalEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_b7a22557f49e97dcd2b91bca0c98fab2 outParamList = new RL_b7a22557f49e97dcd2b91bca0c98fab2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersInComplementReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[11];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, false, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersInComplement.GetOrdersInComplement.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrdersInComplement.GetOrdersInComplement.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b7a22557f49e97dcd2b91bca0c98fab2 _tmp = new RL_b7a22557f49e97dcd2b91bca0c98fab2();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersInComplementReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrdersInComplement.GetOrdersInComplement.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b7a22557f49e97dcd2b91bca0c98fab2)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersInComplement.GetOrdersInComplement.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
