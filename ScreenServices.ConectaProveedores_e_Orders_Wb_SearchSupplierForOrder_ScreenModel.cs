using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel).Namespace);

    public long inParamSupplierId;
public bool inParamIsEnabled;
public long inParamOrderMainId;
public AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSupplierById;
public AggregateRecord<RL_03c4be65764ae68c963db8500f2f1711> ScreenDataSetGetOrderById;
public AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel(long inParamSupplierId, bool inParamIsEnabled, long inParamOrderMainId, AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSupplierById, AggregateRecord<RL_03c4be65764ae68c963db8500f2f1711> ScreenDataSetGetOrderById, AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"SupplierId", "IsEnabled", "OrderMainId", "GetSupplierById", "GetOrderById", "GetSuppliers", "ClientVars"}, new string[] {"inParamSupplierId", "inParamIsEnabled", "inParamOrderMainId", "ScreenDataSetGetSupplierById", "ScreenDataSetGetOrderById", "ScreenDataSetGetSuppliers", "clientVariables"});
this.inParamSupplierId = inParamSupplierId;
this.inParamIsEnabled = inParamIsEnabled;
this.inParamOrderMainId = inParamOrderMainId;
this.ScreenDataSetGetSupplierById = ScreenDataSetGetSupplierById;
this.ScreenDataSetGetOrderById = ScreenDataSetGetOrderById;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_c81aee5ce0504fe68694be6deb703b5e> datasetGetSupplierByIdReadDbAsync(RC_c81aee5ce0504fe68694be6deb703b5e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierById" nPMgOtfl70SOLl5QoacJjA of Action "Wb_SearchSupplierForOrder"
public static async Task<(RL_f647e8c4990b814587d1a017e4c9dd44,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_SearchSupplierForOrder.GetSupplierById", "3a20f39c-e5d7-44ef-8e2e-5e50a1a7098c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchSupplierForOrder","e_Orders.Wb_SearchSupplierForOrder.GetSupplierById");
// Query Iterations: Never
// Refresh Query eppFaBpa806THNlBGZF5qw Iterations: Never
// Refresh Query 4VUiNOCfdUK15pquw6tnDw Iterations: Never
// Refresh Query BHMrNVzOtkKdd4u8+nwgCw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.TAGyJO10+Eq9RbO7_YZ53g/ScreenDataSets.nPMgOtfl70SOLl5QoacJjA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"ensupplier89\".\"id\" o13, \"ensupplier89\".\"tratamiento\" o14, \"ensupplier89\".\"name\" o15, \"ensupplier89\".\"number\" o16, NULL o17, NULL o18, NULL o19, NULL o20, \"ensupplier89\".\"pais\" o21, \"ensupplier89\".\"region_\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"ensupplier89\".\"n_ident_fis_1\" o30, NULL o31, \"ensupplier89\".\"ramo\" o32, \"ensupplier89\".\"grupodeporte\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier89\" Left JOIN {Region} \"enregion117\" ON (\"ensupplier89\".\"regionid\" = \"enregion117\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier89\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier89\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier89\".\"id\" IS NULL)");
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
RL_f647e8c4990b814587d1a017e4c9dd44 outParamList = new RL_f647e8c4990b814587d1a017e4c9dd44();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, true, true, true, true, false, false, true, true, true, true, true, true, true, false, true, false, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_SearchSupplierForOrder.GetSupplierById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f647e8c4990b814587d1a017e4c9dd44 _tmp = new RL_f647e8c4990b814587d1a017e4c9dd44();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_SearchSupplierForOrder.GetSupplierById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f647e8c4990b814587d1a017e4c9dd44)_tmp;
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

private static async Task<RC_b944c231fcedefdc49a0fe2c36d0fb8a> datasetGetOrderByIdReadDbAsync(RC_b944c231fcedefdc49a0fe2c36d0fb8a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" TyCDnXgxuk6AE9+MhcJy4Q of Action "Wb_SearchSupplierForOrder"
public static async Task<(RL_03c4be65764ae68c963db8500f2f1711,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_SearchSupplierForOrder.GetOrderById", "9d83204f-3178-4eba-8013-df8c85c272e1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchSupplierForOrder","e_Orders.Wb_SearchSupplierForOrder.GetOrderById");
// Query Iterations: Multiple
// Refresh Query E5p9rgeSUkeVylcz8osKDw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.TAGyJO10+Eq9RbO7_YZ53g/ScreenDataSets.TyCDnXgxuk6AE9+MhcJy4Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, \"enordermain89\".\"regionid\" o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, \"enregion118\".\"divisionfi\" o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain89\" Left JOIN {OrderDetail} \"enorderdetail12\" ON (\"enordermain89\".\"id\" = \"enorderdetail12\".\"orderid\"))  Left JOIN {Region} \"enregion118\" ON (\"enordermain89\".\"regionid\" = \"enregion118\".\"id\")) ");
whereBuilder.Append(" WHERE (");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain89\".\"id\" = @qporOrderMain_Id) AND (\"enordermain89\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain89\".\"id\" IS NULL)");
}
whereBuilder.Append(" OR (\"enordermain89\".\"id\" IS NULL))");
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
RL_03c4be65764ae68c963db8500f2f1711 outParamList = new RL_03c4be65764ae68c963db8500f2f1711();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_SearchSupplierForOrder.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_03c4be65764ae68c963db8500f2f1711 _tmp = new RL_03c4be65764ae68c963db8500f2f1711();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_SearchSupplierForOrder.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_03c4be65764ae68c963db8500f2f1711)_tmp;
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

private static async Task<RC_c81aee5ce0504fe68694be6deb703b5e> datasetGetSuppliersReadDbAsync(RC_c81aee5ce0504fe68694be6deb703b5e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetSuppliers" +RVgpkP0HkeVFr853gOA7g of Action "Wb_SearchSupplierForOrder"
public static async Task<(RL_f647e8c4990b814587d1a017e4c9dd44,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,long qpreSupplier_RegionId2,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_SearchSupplierForOrder.GetSuppliers", "a66015f9-f443-471e-9516-bf39de0380ee");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchSupplierForOrder","e_Orders.Wb_SearchSupplierForOrder.GetSuppliers");
// Query Iterations: Multiple
// Refresh Query H3uw44okrE+76S7+4bLGBg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.TAGyJO10+Eq9RbO7_YZ53g/ScreenDataSets.+RVgpkP0HkeVFr853gOA7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"ensupplier90\".\"id\" o13, NULL o14, \"ensupplier90\".\"name\" o15, \"ensupplier90\".\"number\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"ensupplier90\".\"n_ident_fis_1\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier90\" Left JOIN {Region} \"enregion119\" ON (\"ensupplier90\".\"regionid\" = \"enregion119\".\"id\")) ");
whereBuilder.Append(" WHERE ((\"ensupplier90\".\"regionid\" IS NULL) OR ((CASE WHEN (@qpreSupplier_RegionId <> 0) THEN (CASE WHEN (@qpreSupplier_RegionId = @qpreSupplier_RegionId1) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier90\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier90\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier90\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier90\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier90\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier90\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) ELSE (CASE WHEN ");
if (qpreSupplier_RegionId2 != 0) {
whereBuilder.Append("((\"ensupplier90\".\"regionid\" = @qpreSupplier_RegionId2) AND (\"ensupplier90\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId2", DbType.Int64, qpreSupplier_RegionId2);
} else {
whereBuilder.Append("(\"ensupplier90\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1))");
orderByBuilder.Append(" ORDER BY \"ensupplier90\".\"name\" ASC ");
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
RL_f647e8c4990b814587d1a017e4c9dd44 outParamList = new RL_f647e8c4990b814587d1a017e4c9dd44();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_SearchSupplierForOrder.GetSuppliers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f647e8c4990b814587d1a017e4c9dd44 _tmp = new RL_f647e8c4990b814587d1a017e4c9dd44();
_tmp.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_SearchSupplierForOrder.GetSuppliers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f647e8c4990b814587d1a017e4c9dd44)_tmp;
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
