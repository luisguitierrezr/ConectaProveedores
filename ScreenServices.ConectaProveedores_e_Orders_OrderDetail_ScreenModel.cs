using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_OrderDetail_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_OrderDetail_ScreenModel).Namespace);

    public long inParami_OrderId;
public bool varLcShowOrderReject_Popup;
public DateTime varLcl_RefreshSideBar;
public int varLcl_ActiveTab;
public bool varLcIsShowHistoric;
public DateTime varLcl_ForceRefresh;
public AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ScreenDataSetGetRejectComment;
public AggregateRecord<RL_9129a40e214c2e67892c6ae5dfbfb7b5> ScreenDataSetGetOrdersByContractNumber;
public AggregateRecord<RL_4f9bb0401ba1a9d16c01e66cc4639c20> ScreenDataSetGetOrderMainById;
public ConectaProveedores_e_Orders_OrderDetail_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_OrderDetail_ScreenModel() {
}



    public ConectaProveedores_e_Orders_OrderDetail_ScreenModel(long inParami_OrderId, bool varLcShowOrderReject_Popup, DateTime varLcl_RefreshSideBar, int varLcl_ActiveTab, bool varLcIsShowHistoric, DateTime varLcl_ForceRefresh, AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ScreenDataSetGetRejectComment, AggregateRecord<RL_9129a40e214c2e67892c6ae5dfbfb7b5> ScreenDataSetGetOrdersByContractNumber, AggregateRecord<RL_4f9bb0401ba1a9d16c01e66cc4639c20> ScreenDataSetGetOrderMainById, ConectaProveedores_e_Orders_OrderDetail_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "ShowOrderReject_Popup", "l_RefreshSideBar", "l_ActiveTab", "IsShowHistoric", "l_ForceRefresh", "GetRejectComment", "GetOrdersByContractNumber", "GetOrderMainById", "GetSettings", "ClientVars"}, new string[] {"inParami_OrderId", "varLcShowOrderReject_Popup", "varLcl_RefreshSideBar", "varLcl_ActiveTab", "varLcIsShowHistoric", "varLcl_ForceRefresh", "ScreenDataSetGetRejectComment", "ScreenDataSetGetOrdersByContractNumber", "ScreenDataSetGetOrderMainById", "varLcGetSettings", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.varLcShowOrderReject_Popup = varLcShowOrderReject_Popup;
this.varLcl_RefreshSideBar = varLcl_RefreshSideBar;
this.varLcl_ActiveTab = varLcl_ActiveTab;
this.varLcIsShowHistoric = varLcIsShowHistoric;
this.varLcl_ForceRefresh = varLcl_ForceRefresh;
this.ScreenDataSetGetRejectComment = ScreenDataSetGetRejectComment;
this.ScreenDataSetGetOrdersByContractNumber = ScreenDataSetGetOrdersByContractNumber;
this.ScreenDataSetGetOrderMainById = ScreenDataSetGetOrderMainById;
this.varLcGetSettings = varLcGetSettings;
this.clientVariables = clientVariables;
}



    
// Query Function "GetRejectComment" 89XDDs8cZUG+FEqeeHT84A of Action "OrderDetail"
public static async Task<(RL_17d8289ea48572225dc9530a5725652a,long)> datasetGetRejectComment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrderDetail.GetRejectComment", "0ec3d5f3-1ccf-4165-be14-4a9e7874fce0");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrderDetail","e_Orders.OrderDetail.GetRejectComment");
// Query Iterations: Never
// Refresh Query qP+1sLoy0kOKAK2774c_gA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.c642tYNQ0UWc5pcW_StrRw/ScreenDataSets.89XDDs8cZUG+FEqeeHT84A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enordercomment1\".\"message\" o6");
fromBuilder.Append(" FROM {OrderComment} \"enordercomment1\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enordercomment1\".\"orderid\" = @qporOrderId) AND (\"enordercomment1\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enordercomment1\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercomment1\".\"commenttypeid\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enordercomment1\".\"id\" DESC ");
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
RL_17d8289ea48572225dc9530a5725652a outParamList = new RL_17d8289ea48572225dc9530a5725652a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrderDetail.GetRejectComment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_17d8289ea48572225dc9530a5725652a _tmp = new RL_17d8289ea48572225dc9530a5725652a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrderDetail.GetRejectComment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_17d8289ea48572225dc9530a5725652a)_tmp;
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

private static async Task<RC_64337b445a88908182ed34f64cf1399b> datasetGetOrdersByContractNumberReadDbAsync(RC_64337b445a88908182ed34f64cf1399b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrdersByContractNumber" 8WztRRn4cEudfDen0DdK4A of Action "OrderDetail"
public static async Task<(RL_9129a40e214c2e67892c6ae5dfbfb7b5,long)> datasetGetOrdersByContractNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderDetail_ContractNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrderDetail.GetOrdersByContractNumber", "45ed6cf1-f819-4b70-9d7c-37a7d0374ae0");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrderDetail","e_Orders.OrderDetail.GetOrdersByContractNumber");
// Query Iterations: Never
// Refresh Query i8rxG8UQLk6so3qy9cwGRw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.c642tYNQ0UWc5pcW_StrRw/ScreenDataSets.8WztRRn4cEudfDen0DdK4A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain99\" Left JOIN {OrderDetail} \"enorderdetail16\" ON (\"enordermain99\".\"id\" = \"enorderdetail16\".\"orderid\")) ");
whereBuilder.Append(" WHERE (\"enorderdetail16\".\"contractnumber\" = @qpteOrderDetail_ContractNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderDetail_ContractNumber", DbType.String, qpteOrderDetail_ContractNumber);
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
RL_9129a40e214c2e67892c6ae5dfbfb7b5 outParamList = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersByContractNumberReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrderDetail.GetOrdersByContractNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9129a40e214c2e67892c6ae5dfbfb7b5 _tmp = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersByContractNumberReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrderDetail.GetOrdersByContractNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9129a40e214c2e67892c6ae5dfbfb7b5)_tmp;
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

private static async Task<RC_06eea14cc287e1e6b6d33a1bc97971e2> datasetGetOrderMainByIdReadDbAsync(RC_06eea14cc287e1e6b6d33a1bc97971e2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" v0fK3SCXZkOWCnstsDD9fg of Action "OrderDetail"
public static async Task<(RL_4f9bb0401ba1a9d16c01e66cc4639c20,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboGetIsCxP_RequestErrorDistribution,long qpenOrderApprovalLevel_EntraRoleId,string qpusGetUserId,long qpreGetUserRegionId,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrderDetail.GetOrderMainById", "ddca47bf-9720-4366-960a-7b2db030fd7e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrderDetail","e_Orders.OrderDetail.GetOrderMainById");
// Query Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.c642tYNQ0UWc5pcW_StrRw/ScreenDataSets.v0fK3SCXZkOWCnstsDD9fg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval28\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enorderapprovallevel27\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enorderdetail17\".\"contractnumber\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"enorderdetail17\".\"hasntrequestdocuments\" o63, \"enordermain100\".\"id\" o64, NULL o65, NULL o66, \"enordermain100\".\"orderstatusid\" o67, NULL o68, NULL o69, \"enordermain100\".\"supplierid\" o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, \"enorderstatus9\".\"label\" o94, \"enorderstatus9\".\"class\" o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141");
fromBuilder.Append(" FROM (((((({OrderMain} \"enordermain100\" Left JOIN {OrderApproval} \"enorderapproval28\" ON (\"enordermain100\".\"id\" = \"enorderapproval28\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel27\" ON (\"enorderapproval28\".\"id\" = \"enorderapprovallevel27\".\"orderapprovalid\"))  Left JOIN {OrderStatus} \"enorderstatus9\" ON (\"enordermain100\".\"orderstatusid\" = \"enorderstatus9\".\"id\"))  Left JOIN {Supplier} \"ensupplier98\" ON (\"enordermain100\".\"supplierid\" = \"ensupplier98\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail17\" ON (\"enordermain100\".\"id\" = \"enorderdetail17\".\"orderid\"))  Left JOIN {SupplierUser} \"ensupplieruser22\" ON (\"ensupplier98\".\"id\" = \"ensupplieruser22\".\"supplierid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain100\".\"id\" = @qporOrderMain_Id) AND (\"enordermain100\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain100\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser22\".\"userid\" = @qpusGetUserId) AND (\"ensupplieruser22\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"ensupplieruser22\".\"userid\" IS NULL)");
}
whereBuilder.Append(" THEN (CASE WHEN (\"enordermain100\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId);
whereBuilder.Append(") THEN 1 ELSE 0 END) ELSE (CASE WHEN (((\"enorderapprovallevel27\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel27\".\"assignedto\" = @qpusGetUserId) AND (\"enorderapprovallevel27\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enorderapprovallevel27\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR (((\"enorderapprovallevel27\".\"assignedto\" IS NULL) AND (");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain100\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain100\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain100\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain100\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain100\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain100\".\"regionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderapprovallevel27\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel27\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderapprovallevel27\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append("))) OR ((\"enordermain100\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append(") OR ((\"enordermain100\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId);
whereBuilder.Append(") AND (@qpboGetIsCxP_RequestErrorDistribution = 1)))) THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel27\".\"levelnumber\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCxP_RequestErrorDistribution", DbType.Boolean, qpboGetIsCxP_RequestErrorDistribution);
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
RL_4f9bb0401ba1a9d16c01e66cc4639c20 outParamList = new RL_4f9bb0401ba1a9d16c01e66cc4639c20();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[4] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrderDetail.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f9bb0401ba1a9d16c01e66cc4639c20 _tmp = new RL_4f9bb0401ba1a9d16c01e66cc4639c20();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrderDetail.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f9bb0401ba1a9d16c01e66cc4639c20)_tmp;
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


    public class lcoGetSettings : VarsBag {
public bool outParamo_IsActiveDEV_HU13008_Complement = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsActiveDEV_HU13008_Complement = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_e_Orders_OrderDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "2f7ffc95-9807-4551-a6fa-95f7f16406f6"))
using (activitySource.CreateScreenDataActionActivity("OrderDetail", "GetSettings")){
// o_IsActiveDEV_HU13008_Complement = IsActiveDEV_HU13008_Complement
result.outParamo_IsActiveDEV_HU13008_Complement=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13008_Complement])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsActiveDEV_HU13008_Complement = result.outParamo_IsActiveDEV_HU13008_Complement;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsActiveDEV_HU13008_Complement;
}


    public static class FuncDataActionGetSettings {
}


}
