using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel).Namespace);

    public long inParamOrderId;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public ST_9b020d447acc32d28b5e58ce81130d00Structure varLcTempValues;
public AggregateRecord<RL_1ded8df557cc19c3bf639ef70eaf909e> ScreenDataSetGetOrderById;
public ConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Model varLcGetOrderMainItems;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel() {
}



    public ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel(long inParamOrderId, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, ST_9b020d447acc32d28b5e58ce81130d00Structure varLcTempValues, AggregateRecord<RL_1ded8df557cc19c3bf639ef70eaf909e> ScreenDataSetGetOrderById, ConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Model varLcGetOrderMainItems, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderId", "TableSort", "StartIndex", "MaxRecords", "TempValues", "GetOrderById", "GetOrderMainItems", "ClientVars"}, new string[] {"inParamOrderId", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcTempValues", "ScreenDataSetGetOrderById", "varLcGetOrderMainItems", "clientVariables"});
this.inParamOrderId = inParamOrderId;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcTempValues = varLcTempValues;
this.ScreenDataSetGetOrderById = ScreenDataSetGetOrderById;
this.varLcGetOrderMainItems = varLcGetOrderMainItems;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_7001c2850e85d9dc361469a649a88466> datasetGetOrderByIdReadDbAsync(RC_7001c2850e85d9dc361469a649a88466 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENDistribution.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
rec.ssENOrdersImportRequest.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" 5QYSEhNxKkuiJWtexYpIvA of Action "wb_OrderDetail_1Info"
public static async Task<(RL_1ded8df557cc19c3bf639ef70eaf909e,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.wb_OrderDetail_1Info.GetOrderById", "121206e5-7113-4b2a-a225-6b5ec58a48bc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_OrderDetail_1Info","e_Orders.wb_OrderDetail_1Info.GetOrderById");
// Query Iterations: Multiple
// Refresh Query YT1YLicWfUmx6FBbYgUeiQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.TxRxXHvAJ06IcIvVszFjpw/ScreenDataSets.5QYSEhNxKkuiJWtexYpIvA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"encompany35\".\"externalid\" o9, \"encompany35\".\"description\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"encurrency15\".\"code\" o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"endistribution2\".\"label\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, \"enordermain93\".\"ordernumber\" o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enordermain93\".\"procurementgroup\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, \"enordermain93\".\"sustainabilitycategory\" o110, \"enordermain93\".\"sustainabilitysubcategory\" o111, trim_scale(\"enordermain93\".\"totalamount\"::numeric) o112, NULL o113, NULL o114, NULL o115, \"enordermain93\".\"applicant\" o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, \"enordermainitem18\".\"purchaserequisitionnumber\" o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, \"enordermainitem18\".\"contractnumber\" o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, \"enordermainitem18\".\"ismultipleimputation\" o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, \"enordersimportrequest4\".\"createdon\" o180, \"enordersimportrequest4\".\"updatedon\" o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, \"enregion121\".\"divisionfi\" o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, NULL o226, NULL o227, NULL o228");
fromBuilder.Append(" FROM ((((((((((({OrderMain} \"enordermain93\" Left JOIN {OrderStatus} \"enorderstatus3\" ON (\"enordermain93\".\"orderstatusid\" = \"enorderstatus3\".\"id\"))  Left JOIN {Company} \"encompany35\" ON (\"enordermain93\".\"companyid\" = \"encompany35\".\"id\"))  Left JOIN {Supplier} \"ensupplier92\" ON (\"enordermain93\".\"supplierid\" = \"ensupplier92\".\"id\"))  Left JOIN {OrderMainItem} \"enordermainitem18\" ON (\"enordermain93\".\"id\" = \"enordermainitem18\".\"ordermainid\"))  Left JOIN {OrderDetail} \"enorderdetail14\" ON (\"enordermain93\".\"id\" = \"enorderdetail14\".\"orderid\"))  Left JOIN {Distribution} \"endistribution2\" ON (\"enorderdetail14\".\"distributionid\" = \"endistribution2\".\"id\"))  Left JOIN {Currency} \"encurrency15\" ON (\"enordermain93\".\"currencyid\" = \"encurrency15\".\"code\"))  Left JOIN {Region} \"enregion121\" ON (\"enordermain93\".\"regionid\" = \"enregion121\".\"id\"))  Left JOIN {CostCenterSAP} \"encostcentersap13\" ON (\"enordermainitem18\".\"costcenterid\" = \"encostcentersap13\".\"id\"))  Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype10\" ON (\"enordermainitem18\".\"glaccountid\" = \"enaccountingaccounts_servicetype10\".\"id\"))  Left JOIN {OrdersImportRequest} \"enordersimportrequest4\" ON (\"enordermain93\".\"id\" = \"enordersimportrequest4\".\"ordermainid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain93\".\"id\" = @qporOrderMain_Id) AND (\"enordermain93\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain93\".\"id\" IS NULL)");
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
RL_1ded8df557cc19c3bf639ef70eaf909e outParamList = new RL_1ded8df557cc19c3bf639ef70eaf909e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[12];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, false});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, false, false, false, true, true, true, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true});
opt[8] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.wb_OrderDetail_1Info.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1ded8df557cc19c3bf639ef70eaf909e _tmp = new RL_1ded8df557cc19c3bf639ef70eaf909e();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.wb_OrderDetail_1Info.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1ded8df557cc19c3bf639ef70eaf909e)_tmp;
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


    public class lcvGetOrderMainItems : VarsBag {
public RL_eb723ca0f1d2182a5703efa79cc03660 queryResGetOrdersItemsCount_outParamList = new RL_eb723ca0f1d2182a5703efa79cc03660();
public long queryResGetOrdersItemsCount_outParamCount = 0L;

public RL_655c0a8b64ba745fe765edb883275714 queryResGetOrdersItems_outParamList = new RL_655c0a8b64ba745fe765edb883275714();
public long queryResGetOrdersItems_outParamCount = 0L;

public lcvGetOrderMainItems() {
}
}
public class lcoGetOrderMainItems : VarsBag {
public RL_3e44f5588517fc49ab4a1e35f755766f outParamList = new RL_3e44f5588517fc49ab4a1e35f755766f();

public int outParamCount = 0;

public lcoGetOrderMainItems() {
}
}
/// <summary>
/// Action <code>GetOrderMainItems</code> that represents the Service Studio action
///  <code>GetOrderMainItems</code> <p> Description: </p>
/// </summary>
public async Task<(RL_3e44f5588517fc49ab4a1e35f755766f,int)> DataActionGetOrderMainItems(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_3e44f5588517fc49ab4a1e35f755766f outParamList = default;
int outParamCount = default;
lcoGetOrderMainItems result = new lcoGetOrderMainItems();
lcvGetOrderMainItems localVars = new lcvGetOrderMainItems();
ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderMainItems", "10bd9d6f-6ff8-4097-bf32-3ef53e19a3be"))
using (activitySource.CreateScreenDataActionActivity("wb_OrderDetail_1Info", "GetOrderMainItems")){
// Query QueryGetOrdersItems
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersItems_maxRecords = 999999999;
if (QueryGetOrdersItems_maxRecords < 1) QueryGetOrdersItems_maxRecords = 1;
int QueryGetOrdersItems_startIndex = 0;(localVars.queryResGetOrdersItems_outParamList,localVars.queryResGetOrdersItems_outParamCount) = await FuncDataActionGetOrderMainItems.QueryGetOrdersItems(requestContext,QueryGetOrdersItems_maxRecords,QueryGetOrdersItems_startIndex,IterationMultiplicity.Multiple,inParamOrderId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,cancellationToken);

// Query QueryGetOrdersItemsCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersItemsCount_maxRecords = 1;
if (QueryGetOrdersItemsCount_maxRecords < 1) QueryGetOrdersItemsCount_maxRecords = 1;
int QueryGetOrdersItemsCount_startIndex = 0;(localVars.queryResGetOrdersItemsCount_outParamList,localVars.queryResGetOrdersItemsCount_outParamCount) = await FuncDataActionGetOrderMainItems.QueryGetOrdersItemsCount(requestContext,QueryGetOrdersItemsCount_maxRecords,QueryGetOrdersItemsCount_startIndex,IterationMultiplicity.Never,inParamOrderId,cancellationToken);

// List = GetOrdersItems.List
result.outParamList=(await RL_3e44f5588517fc49ab4a1e35f755766f.ConvertAsync(localVars.queryResGetOrdersItems_outParamList, new RL_3e44f5588517fc49ab4a1e35f755766f(), async (RC_7b1aae62a8e090753ba4cda6cb9c5acd source, ST_662e235c01358293d93e19bedad72008Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// Count = GetOrdersItemsCount.List.Current.Integer.Value
result.outParamCount=localVars.queryResGetOrdersItemsCount_outParamList.CurrentRec.ssSTInteger.ssValue;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamCount = result.outParamCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamCount);
}


    public static class FuncDataActionGetOrderMainItems {

// Query Function "GetOrdersItemsCount" 80BUv2UCfEebSSJnlMgEYw of Action "GetOrderMainItems"
public static async Task<(RL_eb723ca0f1d2182a5703efa79cc03660,long)> QueryGetOrdersItemsCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItemsCount", "bf5440f3-0265-477c-9b49-226794c80463");
using var queryActivity = activitySource.CreateSqlQueryActivity("e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItemsCount", "bf5440f3-0265-477c-9b49-226794c80463", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
sqlCmd.CreateParameter("@qporl_OrderIdSelected", DbType.Int64, qporl_OrderIdSelected);
string sql = "";
string advSql = "SELECT    count(1) \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " \n \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " = @qporl_OrderIdSelected";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_eb723ca0f1d2182a5703efa79cc03660 outParamList = new RL_eb723ca0f1d2182a5703efa79cc03660();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItemsCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_eb723ca0f1d2182a5703efa79cc03660 _tmp = new RL_eb723ca0f1d2182a5703efa79cc03660();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItemsCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb723ca0f1d2182a5703efa79cc03660)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItemsCount in GetOrderMainItems in wb_OrderDetail_1Info in e_Orders in ConectaProveedores (SELECT    count(1)    FROM {OrderMainItem}  INNER JOIN {OrderMain}      ON {OrderMain}.[Id] = {OrderMainItem}.[OrderMainId]  LEFT JOIN {Currency}      ON {OrderMain}.[CurrencyId] = {Currency}.[Code]  LEFT JOIN {OrderMainItemStatus}      ON {OrderMain}.[OrderStatusId] = {OrderMainItemStatus}.[Id]    WHERE {OrderMain}.[Id] = @l_OrderIdSelected): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItemsCount in GetOrderMainItems in wb_OrderDetail_1Info in e_Orders in ConectaProveedores (SELECT    count(1)    FROM {OrderMainItem}  INNER JOIN {OrderMain}      ON {OrderMain}.[Id] = {OrderMainItem}.[OrderMainId]  LEFT JOIN {Currency}      ON {OrderMain}.[CurrencyId] = {Currency}.[Code]  LEFT JOIN {OrderMainItemStatus}      ON {OrderMain}.[OrderStatusId] = {OrderMainItemStatus}.[Id]    WHERE {OrderMain}.[Id] = @l_OrderIdSelected): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItemsCount in GetOrderMainItems in wb_OrderDetail_1Info in e_Orders in ConectaProveedores (SELECT    count(1)    FROM {OrderMainItem}  INNER JOIN {OrderMain}      ON {OrderMain}.[Id] = {OrderMainItem}.[OrderMainId]  LEFT JOIN {Currency}      ON {OrderMain}.[CurrencyId] = {Currency}.[Code]  LEFT JOIN {OrderMainItemStatus}      ON {OrderMain}.[OrderStatusId] = {OrderMainItemStatus}.[Id]    WHERE {OrderMain}.[Id] = @l_OrderIdSelected): " + aqExcep.Message));
}
}
}

// Query Function "GetOrdersItems" UsUb_FLVZEae1XgoabmwKg of Action "GetOrderMainItems"
public static async Task<(RL_655c0a8b64ba745fe765edb883275714,long)> QueryGetOrdersItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItems", "fc1bc552-d552-4664-9ed5-782869b9b02a");
using var queryActivity = activitySource.CreateSqlQueryActivity("e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItems", "fc1bc552-d552-4664-9ed5-782869b9b02a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceled", DbType.Int32, qpfoi_folioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceledByProvider", DbType.Int32, qpfoi_folioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qporl_OrderIdSelected", DbType.Int64, qporl_OrderIdSelected);
string sql = "";
string advSql = "SELECT  \n    0, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n    ), 0) +  COALESCE((SELECT COALESCE(SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))),0) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n            OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0)) \n    ), 0)  +  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " as QtdDelivered, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " -  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " - ( \n        COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled  \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        ), 0)  +   COALESCE((SELECT COALESCE(SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))),0) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n            OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0)) \n        ), 0) \n    ) AS QttAvailable, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + "* " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"class\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"deliverydate\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatrate\"") + ", \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"totalprice\"") + " AS DECIMAL(18,2))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n    ), 0), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ce_coste\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatindicator\"") + " \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + "  \n    on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " \n    on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"regionid\"") + " \n \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " = @qporl_OrderIdSelected \norder by  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + " asc";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_655c0a8b64ba745fe765edb883275714 outParamList = new RL_655c0a8b64ba745fe765edb883275714();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_655c0a8b64ba745fe765edb883275714 _tmp = new RL_655c0a8b64ba745fe765edb883275714();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.wb_OrderDetail_1Info.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_655c0a8b64ba745fe765edb883275714)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems in GetOrderMainItems in wb_OrderDetail_1Info in e_Orders in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0) +  COALESCE((SELECT COALESCE(SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3))),0)              FROM {OrderItemEntries}              WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))      ), 0)  + {OrderMainItem}.[Q ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in wb_OrderDetail_1Info in e_Orders in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0) +  COALESCE((SELECT COALESCE(SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3))),0)              FROM {OrderItemEntries}              WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))      ), 0)  + {OrderMainItem}.[Q ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in wb_OrderDetail_1Info in e_Orders in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0) +  COALESCE((SELECT COALESCE(SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3))),0)              FROM {OrderItemEntries}              WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))      ), 0)  + {OrderMainItem}.[Q ...): " + aqExcep.Message));
}
}
}
}


}
