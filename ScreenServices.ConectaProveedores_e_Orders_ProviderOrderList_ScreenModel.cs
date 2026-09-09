using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_ProviderOrderList_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_ProviderOrderList_ScreenModel).Namespace);

    public int varLcl_StartIndex;
public string varLcl_TableSort;
public AggregateRecord<RL_22e659721c63481b25b29a0491fd3d7f> ScreenDataSetGetOrders;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_ProviderOrderList_ScreenModel() {
}



    public ConectaProveedores_e_Orders_ProviderOrderList_ScreenModel(int varLcl_StartIndex, string varLcl_TableSort, AggregateRecord<RL_22e659721c63481b25b29a0491fd3d7f> ScreenDataSetGetOrders, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_StartIndex", "l_TableSort", "GetOrders", "ClientVars"}, new string[] {"varLcl_StartIndex", "varLcl_TableSort", "ScreenDataSetGetOrders", "clientVariables"});
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.ScreenDataSetGetOrders = ScreenDataSetGetOrders;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_d95294610b1c7b76b1445c6a23286bc4> datasetGetOrdersReadDbAsync(RC_d95294610b1c7b76b1445c6a23286bc4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrders" 2XwNImiS7kyb1mv0bNEv1w of Action "ProviderOrderList"
public static async Task<(RL_22e659721c63481b25b29a0491fd3d7f,long)> datasetGetOrders(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderProviderList_Number,long qpsuOrderMain_SupplierId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.ProviderOrderList.GetOrders", "220d7cd9-9268-4cee-9bd6-6bf46cd12fd7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProviderOrderList","e_Orders.ProviderOrderList.GetOrders");
// Query Iterations: Multiple
// Refresh Query 47XpS1wklkqY4abNmp0fZw Iterations: Multiple
// Refresh Query ExqehpP2BU2UC0URX+iwxA Iterations: Multiple
// Refresh Query n+PxIDLBE0qZbqXKr_x3pA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.KSvZ7eEc6EOvBi0h40fNyw/ScreenDataSets.2XwNImiS7kyb1mv0bNEv1w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encompany42\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encurrency22\".\"code\" o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enordermain104\".\"id\" o16, \"enordermain104\".\"ordernumber\" o17, \"enordermain104\".\"orderdate\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, trim_scale(\"enordermain104\".\"totalamount\"::numeric) o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"enorderstatus13\".\"label\" o46, \"enorderstatus13\".\"class\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78");
fromBuilder.Append(" FROM (((({OrderMain} \"enordermain104\" Inner JOIN {Company} \"encompany42\" ON (\"enordermain104\".\"companyid\" = \"encompany42\".\"id\"))  Inner JOIN {Supplier} \"ensupplier102\" ON (\"enordermain104\".\"supplierid\" = \"ensupplier102\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus13\" ON (\"enordermain104\".\"orderstatusid\" = \"enorderstatus13\".\"id\"))  Left JOIN {Currency} \"encurrency22\" ON (\"enordermain104\".\"currencyid\" = \"encurrency22\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain104\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain104\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain104\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordermain104\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId);
whereBuilder.Append(") AND ");
if (qpteOrderProviderList_Number != "" && qpteOrderProviderList_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain104\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderProviderList_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderProviderList_Number", DbType.String, qpteOrderProviderList_Number);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderProviderList_Number", DbType.String, qpteOrderProviderList_Number);
}
whereBuilder.Append("(\"enordermain104\".\"isreleased\" = 1)");
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Supplier", "OrderStatus", "Currency", "Company", "OrderMain" }, new string[] { "ENSupplier102", "ENOrderStatus13", "ENCurrency22", "ENCompany42", "ENOrderMain104" }, new System.Collections.Generic.Dictionary<string, string>[] { ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_22e659721c63481b25b29a0491fd3d7f outParamList = new RL_22e659721c63481b25b29a0491fd3d7f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.ProviderOrderList.GetOrders.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.ProviderOrderList.GetOrders.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_22e659721c63481b25b29a0491fd3d7f _tmp = new RL_22e659721c63481b25b29a0491fd3d7f();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.ProviderOrderList.GetOrders.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_22e659721c63481b25b29a0491fd3d7f)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.ProviderOrderList.GetOrders.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
