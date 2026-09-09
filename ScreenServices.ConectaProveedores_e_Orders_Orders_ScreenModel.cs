using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Orders_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Orders_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetOrders;
public int varLcl_CountAfterFetchGetOrders;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38> ScreenDataSetGetOrderStatuses;
public ConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Model varLcGetOrdersData;
public ConectaProveedores_e_Orders_Orders_DataActionCheckUser_Model varLcCheckUser;
public ConectaProveedores_e_Orders_Orders_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Orders_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Orders_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetOrders, int varLcl_CountAfterFetchGetOrders, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38> ScreenDataSetGetOrderStatuses, ConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Model varLcGetOrdersData, ConectaProveedores_e_Orders_Orders_DataActionCheckUser_Model varLcCheckUser, ConectaProveedores_e_Orders_Orders_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetOrders", "l_CountAfterFetchGetOrders", "GetRegions", "GetOrderStatuses", "GetOrdersData", "CheckUser", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetOrders", "varLcl_CountAfterFetchGetOrders", "ScreenDataSetGetRegions", "ScreenDataSetGetOrderStatuses", "varLcGetOrdersData", "varLcCheckUser", "varLcGetUserApplicationRoles", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetOrders = varLcl_ColumnJSONVarGetOrders;
this.varLcl_CountAfterFetchGetOrders = varLcl_CountAfterFetchGetOrders;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetOrderStatuses = ScreenDataSetGetOrderStatuses;
this.varLcGetOrdersData = varLcGetOrdersData;
this.varLcCheckUser = varLcCheckUser;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
// Query Function "GetRegions" 1eRrRFDTN0OKH3ZnXgNVXg of Action "Orders"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Orders.GetRegions", "446be4d5-d350-4337-8a1f-76675e03555e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Orders","e_Orders.Orders.GetRegions");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.C5K8iX6FYEWvMyGL8r54jg/ScreenDataSets.1eRrRFDTN0OKH3ZnXgNVXg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion124\".\"id\" o0, NULL o1, \"enregion124\".\"name\" o2, NULL o3, \"enregion124\".\"centrortp\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion124\"");
whereBuilder.Append(" WHERE (\"enregion124\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion124\".\"code\" ASC ");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Orders.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Orders.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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

// Query Function "GetOrderStatuses" f1yY2em4z0287b3KGMdaqQ of Action "Orders"
public static async Task<(RL_cf716c649767b1312d0b25fa52ff2f38,long)> datasetGetOrderStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Orders.GetOrderStatuses", "d9985c7f-b8e9-4dcf-bced-bdca18c75aa9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Orders","e_Orders.Orders.GetOrderStatuses");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.C5K8iX6FYEWvMyGL8r54jg/ScreenDataSets.f1yY2em4z0287b3KGMdaqQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderstatus6\".\"id\" o0, \"enorderstatus6\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {OrderStatus} \"enorderstatus6\"");
whereBuilder.Append(" WHERE (\"enorderstatus6\".\"is_active\" = 1) AND (((((((((\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId);
whereBuilder.Append(") OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"))).ssId);
whereBuilder.Append(")) OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("gqnAVya9FU+_7f97jQeuCA"))).ssId);
whereBuilder.Append(")) OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("XJxoo8RXb0K2bc9xcMC4lg"))).ssId);
whereBuilder.Append(")) OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("rQ22nid450ur93GrTIUjww"))).ssId);
whereBuilder.Append(")) OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append(")) OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId);
whereBuilder.Append(")) OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId);
whereBuilder.Append(")) OR (\"enorderstatus6\".\"id\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("+y0n+52Y0kWtv1lCSYVl5g"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"enorderstatus6\".\"label\" ASC ");
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
RL_cf716c649767b1312d0b25fa52ff2f38 outParamList = new RL_cf716c649767b1312d0b25fa52ff2f38();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Orders.GetOrderStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cf716c649767b1312d0b25fa52ff2f38 _tmp = new RL_cf716c649767b1312d0b25fa52ff2f38();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Orders.GetOrderStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cf716c649767b1312d0b25fa52ff2f38)_tmp;
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


    public class lcvGetOrdersData : VarsBag {
public RL_ba8a6fa9497761be975dfc71dab6b632 queryResGetOrders_outParamList = new RL_ba8a6fa9497761be975dfc71dab6b632();
public long queryResGetOrders_outParamCount = 0L;

public RL_eb723ca0f1d2182a5703efa79cc03660 queryResGetCount_outParamList = new RL_eb723ca0f1d2182a5703efa79cc03660();
public long queryResGetCount_outParamCount = 0L;

public lcvGetOrdersData() {
}
}
public class lcoGetOrdersData : VarsBag {
public RL_e48e3539313f992e2f1ace5c3cb135f5 outParamOrders = new RL_e48e3539313f992e2f1ace5c3cb135f5();

public int outParamCount = 0;

public string outParamSortClause = "";

public lcoGetOrdersData() {
}
}
/// <summary>
/// Action <code>GetOrdersData</code> that represents the Service Studio action
///  <code>GetOrdersData</code> <p> Description: Query to fetch Orders.</p>
/// </summary>
public async Task<(RL_e48e3539313f992e2f1ace5c3cb135f5,int,string)> DataActionGetOrdersData(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_e48e3539313f992e2f1ace5c3cb135f5 outParamOrders = default;
int outParamCount = default;
string outParamSortClause = default;
lcoGetOrdersData result = new lcoGetOrdersData();
lcvGetOrdersData localVars = new lcvGetOrdersData();
ConectaProveedores_e_Orders_Orders_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrdersData", "02466a2c-a871-493e-a88e-9997ea658f36"))
using (activitySource.CreateScreenDataActionActivity("Orders", "GetOrdersData")){
// SortClause = "ORDER BY " + l_TableSort
result.outParamSortClause=("ORDER BY "+varLcl_TableSort);
// Query QueryGetOrders
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrders_maxRecords = 999999999;
if (QueryGetOrders_maxRecords < 1) QueryGetOrders_maxRecords = 1;
int QueryGetOrders_startIndex = 0;(localVars.queryResGetOrders_outParamList,localVars.queryResGetOrders_outParamCount) = await FuncDataActionGetOrdersData.QueryGetOrders(requestContext,QueryGetOrders_maxRecords,QueryGetOrders_startIndex,IterationMultiplicity.Multiple,model.clientVariables.ssOrders_Number,model.clientVariables.ssOrders_OrderStatusId,model.clientVariables.ssOrders_SupplierId,model.clientVariables.ssOrders_DateFrom,model.clientVariables.ssOrders_DateTo,model.clientVariables.ssOrders_RegionId,varLcGetUserApplicationRoles.outParamUserRegion,varLcGetUserApplicationRoles.outParamIsAllRegions,BuiltInFunction.NullDate (),BuiltInFunction.NullIdentifier (),result.outParamSortClause,varLcl_StartIndex,model.clientVariables.ssMaxRecords,(model.clientVariables.ssOffsetUtc*(-1)),cancellationToken);

// Query QueryGetCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetCount_maxRecords = 1;
if (QueryGetCount_maxRecords < 1) QueryGetCount_maxRecords = 1;
int QueryGetCount_startIndex = 0;(localVars.queryResGetCount_outParamList,localVars.queryResGetCount_outParamCount) = await FuncDataActionGetOrdersData.QueryGetCount(requestContext,QueryGetCount_maxRecords,QueryGetCount_startIndex,IterationMultiplicity.Never,model.clientVariables.ssOrders_Number,model.clientVariables.ssOrders_OrderStatusId,model.clientVariables.ssOrders_SupplierId,model.clientVariables.ssOrders_DateFrom,model.clientVariables.ssOrders_DateTo,model.clientVariables.ssOrders_RegionId,varLcGetUserApplicationRoles.outParamUserRegion,varLcGetUserApplicationRoles.outParamIsAllRegions,BuiltInFunction.NullDate (),BuiltInFunction.NullIdentifier (),(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId,(model.clientVariables.ssOffsetUtc*(-1)),cancellationToken);

// Orders = GetOrders.List
result.outParamOrders=(await RL_e48e3539313f992e2f1ace5c3cb135f5.ConvertAsync(localVars.queryResGetOrders_outParamList, new RL_e48e3539313f992e2f1ace5c3cb135f5(), async (RC_d0bb3f44a292c80efaf69b83c1f1cc02 source, ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// Count = GetCount.List.Current.Integer.Value
result.outParamCount=localVars.queryResGetCount_outParamList.CurrentRec.ssSTInteger.ssValue;
} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// RaiseError AbortActivityChangeException
throw new AbortActivityChangeException (ex.Message);

} // Catch
finally {
outParamOrders = result.outParamOrders;
outParamCount = result.outParamCount;
outParamSortClause = result.outParamSortClause;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamOrders,outParamCount,outParamSortClause);
}
public class lcvCheckUser : VarsBag {
public Actions.lcoCheckUserSession resCheckUserSession =  new Actions.lcoCheckUserSession();
public Actions.lcoGetIsUserCxP resGetIsUserCxP =  new Actions.lcoGetIsUserCxP();
public lcvCheckUser() {
}
}
public class lcoCheckUser : VarsBag {
public bool outParamIsCxP = false;

public lcoCheckUser() {
}
}
/// <summary>
/// Action <code>CheckUser</code> that represents the Service Studio action <code>CheckUser</code> <p>
///  Description: Acton to check User.</p>
/// </summary>
public async Task<bool> DataActionCheckUser(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsCxP = default;
lcoCheckUser result = new lcoCheckUser();
lcvCheckUser localVars = new lcvCheckUser();
ConectaProveedores_e_Orders_Orders_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("CheckUser", "11210504-3a87-4e97-ada3-1fd850682d93"))
using (activitySource.CreateScreenDataActionActivity("Orders", "CheckUser")){
// CheckUserSession
localVars.resCheckUserSession.outParamIsValidSession = await Actions.ActionCheckUserSession(requestContext,cancellationToken);

// GetIsUserCxP
localVars.resGetIsUserCxP.outParamo_Value = await Actions.ActionGetIsUserCxP(requestContext,cancellationToken);

// IsCxP = GetIsUserCxP.o_Value
result.outParamIsCxP=localVars.resGetIsUserCxP.outParamo_Value;
} //close CreateActionActivity using block
} // try

finally {
outParamIsCxP = result.outParamIsCxP;
} // inner-finally
RETURN_STATEMENT:
return outParamIsCxP;
}
public class lcvGetUserApplicationRoles : VarsBag {
public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionCorp_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionCorp_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public long outParamUserRegion = 0L;

public long outParamSupplierId = 0L;

public bool outParamIsAllRegions = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: Query to fetch User Application Roles.</p>
/// </summary>
public async Task<(long,long,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamUserRegion = default;
long outParamSupplierId = default;
bool outParamIsAllRegions = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_e_Orders_Orders_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "d5bc1f51-906d-451b-805f-d1ad3ae8aa27"))
using (activitySource.CreateScreenDataActionActivity("Orders", "GetUserApplicationRoles")){
// GetUserRegionId
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

// Query datasetGetRegionCorp
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionCorp_maxRecords = 1;
if (datasetGetRegionCorp_maxRecords < 1) datasetGetRegionCorp_maxRecords = 1;
int datasetGetRegionCorp_startIndex = 0;(localVars.queryResGetRegionCorp_outParamList,localVars.queryResGetRegionCorp_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRegionCorp(requestContext,datasetGetRegionCorp_maxRecords,datasetGetRegionCorp_startIndex,IterationMultiplicity.Never,cancellationToken);

// UserRegion = GetUserRegionId.o_RegionId
result.outParamUserRegion=localVars.resGetUserRegionId.outParamo_RegionId;

// SupplierId = NullIdentifier
result.outParamSupplierId=Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// IsAllRegions = GetUserRegionId.o_RegionId = NullIdentifier or GetUserRegionId.o_RegionId = GetRegionCorp.List.Current.Region.Id
result.outParamIsAllRegions=((localVars.resGetUserRegionId.outParamo_RegionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))||(localVars.resGetUserRegionId.outParamo_RegionId==localVars.queryResGetRegionCorp_outParamList.CurrentRec.ssENRegion.ssId));
} //close CreateActionActivity using block
} // try

finally {
outParamUserRegion = result.outParamUserRegion;
outParamSupplierId = result.outParamSupplierId;
outParamIsAllRegions = result.outParamIsAllRegions;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRegion,outParamSupplierId,outParamIsAllRegions);
}


    public static class FuncDataActionGetOrdersData {

// Query Function "GetOrders" lCV9LZ4enEeCoUbV3tyrVw of Action "GetOrdersData"
public static async Task<(RL_ba8a6fa9497761be975dfc71dab6b632,long)> QueryGetOrders(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrders_Number,int qporOrders_OrderStatusId,long qpsuOrders_SupplierId,DateTime qpdaOrders_DateFrom,DateTime qpdaOrders_DateTo,long qpreOrders_RegionId,long qpreUserRegion,bool qpboIsAllRegions,DateTime qpdaNullDate,int qpinNullIdentifier,string qpteSortClause,int qpinStartIndex,int qpinMaxRecords,int qpinOffsetUtc,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("e_Orders.Orders.GetOrdersData.GetOrders", "2d7d2594-1e9e-479c-82a1-46d5dedcab57");
using var queryActivity = activitySource.CreateSqlQueryActivity("e_Orders.Orders.GetOrdersData.GetOrders", "2d7d2594-1e9e-479c-82a1-46d5dedcab57", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityOrdersImportRequest = AppUtils.Instance.RuntimeEntityReplace("OrdersImportRequest");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityEntraRole = AppUtils.Instance.RuntimeEntityReplace("EntraRole");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qpteOrders_Number", DbType.String, qpteOrders_Number);
sqlCmd.CreateParameter("@qporOrders_OrderStatusId", DbType.Int32, qporOrders_OrderStatusId);
sqlCmd.CreateParameter("@qpinNullIdentifier", DbType.Int32, qpinNullIdentifier);
sqlCmd.CreateParameter("@qpsuOrders_SupplierId", DbType.Int64, qpsuOrders_SupplierId);
sqlCmd.CreateParameter("@qpdaOrders_DateFrom", DbType.DateTime, qpdaOrders_DateFrom);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpdaOrders_DateTo", DbType.DateTime, qpdaOrders_DateTo);
sqlCmd.CreateParameter("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCmd.CreateParameter("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCmd.CreateParameter("@qpreOrders_RegionId", DbType.Int64, qpreOrders_RegionId);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
sqlCmd.CreateParameter("@qpinStartIndex", DbType.Int32, qpinStartIndex);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + "                        AS OrderMainId, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + "               AS OrderNumber, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + "                 AS OrderDate, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"label\"") + "                   AS OrderStatus, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"class\"") + "                   AS OrderStatusClass, \n     \n    ( \n        SELECT MAX(MaxReq.\"createdon\") \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,"") + " MaxReq \n        WHERE MaxReq.\"ordermainid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n    ) AS OrderImportDateTime, \n     \n     \n     \n     \n     \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + "                         AS Region, \n    TelcelD.\"name\"                          AS TelcelDirection, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + "                       AS SupplierName, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + "                     AS SupplierNumber, \n    User_First.\"name\"                       AS FirstLevelUserName, \n    UserExt_First.\"jobtitle\"                AS FirstLevelJobTitle, \n    EntraRole_First.\"rolename\"              AS FirstEntraRoleName,  \n    User_Curr.\"name\"                        AS CurrLevelUserName, \n    UserExt_Curr.\"jobtitle\"                 AS CurrLevelJobTitle, \n    EntraRole_Curr.\"rolename\"               AS CurrEntraRoleName,  \n    CASE \n        WHEN OrderApprovalLevel_Curr.\"approvedon\" <> @qpdaNullDate \n        THEN OrderApprovalLevel_Curr.\"approvedon\" \n        WHEN OrderApprovalLevel_Curr.\"assignedon\" = @qpdaNullDate \n        THEN ( \n            SELECT MAX(MaxReq.\"createdon\") \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,"") + " MaxReq \n            WHERE MaxReq.\"ordermainid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n        ) \n        ELSE OrderApprovalLevel_Curr.\"assignedon\" \n    END AS AssignedOn \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_Curr ON ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_Curr.\"orderapprovalid\" AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"currentlevel\"") + " = OrderApprovalLevel_Curr.\"levelnumber\") \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Curr ON OrderApprovalLevel_Curr.\"assignedto\" = User_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_Curr ON User_Curr.\"id\" = UserExt_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_Curr ON OrderApprovalLevel_Curr.\"entraroleid\" = EntraRole_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_First \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_First.\"orderapprovalid\" AND \n        OrderApprovalLevel_First.\"iscomplement\" = True \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_First ON OrderApprovalLevel_First.\"assignedto\" = User_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_First ON User_First.\"id\" = UserExt_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_First ON OrderApprovalLevel_First.\"entraroleid\" = EntraRole_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " TelcelD ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"telceldirectionid\"") + " = TelcelD.\"id\" \nWHERE \n( \n    COALESCE(CAST(@qpteOrders_Number AS text), '') = '' \n    OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ") \n    LIKE caseaccent_normalize(CONCAT('%', CAST(@qpteOrders_Number AS text), '%')) COLLATE \"C\" \n) \nAND \n( \n    @qporOrders_OrderStatusId = @qpinNullIdentifier \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " = @qporOrders_OrderStatusId \n) \nAND \n( \n    @qpsuOrders_SupplierId = @qpinNullIdentifier \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuOrders_SupplierId \n) \nAND \n( \n    @qpdaOrders_DateFrom = @qpdaNullDate \n    OR \n    CAST( \n        CASE \n            WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " = @qpdaNullDate \n                THEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour') \n            ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " \n        END \n        AS DATE \n    ) >= CAST(@qpdaOrders_DateFrom AS DATE) \n) \nAND ( \n    @qpdaOrders_DateTo = @qpdaNullDate \n    OR \n    CAST( \n        CASE \n            WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " = @qpdaNullDate \n                THEN ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) \n            ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " \n        END \n        AS DATE \n    ) <= CAST(@qpdaOrders_DateTo AS DATE) \n) \nAND  \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " = @qpreUserRegion  \n    OR @qpboIsAllRegions = TRUE \n) \nAND  \n( \n    @qpreOrders_RegionId = @qpinNullIdentifier  \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " = @qpreOrders_RegionId \n) \n " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteSortClause)) + " \nLIMIT @qpinMaxRecords \nOFFSET @qpinStartIndex";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ba8a6fa9497761be975dfc71dab6b632 outParamList = new RL_ba8a6fa9497761be975dfc71dab6b632();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Orders.GetOrdersData.GetOrders.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ba8a6fa9497761be975dfc71dab6b632 _tmp = new RL_ba8a6fa9497761be975dfc71dab6b632();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Orders.GetOrdersData.GetOrders.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ba8a6fa9497761be975dfc71dab6b632)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrders in GetOrdersData in Orders in e_Orders in ConectaProveedores (SELECT      {OrderMain}.[Id]                        AS OrderMainId,      {OrderMain}.[OrderNumber]               AS OrderNumber,      {OrderMain}.[OrderDate]                 AS OrderDate,      {OrderStatus}.[Label]                   AS OrderStatus,      {OrderStatus}.[Class]                   AS OrderStatusClass,        /* Direct maximum CreatedOn lookup */      (          SELECT MAX(MaxReq.[CreatedOn])          FROM {OrdersImportRequest} MaxReq          WHERE MaxReq.[OrderMainId] = {OrderMain}.[Id]      ) AS OrderImportDateTime,        -- CASE          --     WHEN {OrdersImportRequest}.[UpdatedOn] = @NullDate      --     THEN {OrdersImportRequest}.[CreatedOn]      --     ELSE {OrdersImportRequest}.[UpdatedOn]      -- END AS OrderImportDate,      {Region}.[Code]                         AS Region,      TelcelD.[Name]                          AS TelcelDirection,      {Supplier}.[Name]                       AS SupplierName,      {Supplier}.[Number]                     AS SupplierNumber,   ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrders in GetOrdersData in Orders in e_Orders in ConectaProveedores (SELECT      {OrderMain}.[Id]                        AS OrderMainId,      {OrderMain}.[OrderNumber]               AS OrderNumber,      {OrderMain}.[OrderDate]                 AS OrderDate,      {OrderStatus}.[Label]                   AS OrderStatus,      {OrderStatus}.[Class]                   AS OrderStatusClass,        /* Direct maximum CreatedOn lookup */      (          SELECT MAX(MaxReq.[CreatedOn])          FROM {OrdersImportRequest} MaxReq          WHERE MaxReq.[OrderMainId] = {OrderMain}.[Id]      ) AS OrderImportDateTime,        -- CASE          --     WHEN {OrdersImportRequest}.[UpdatedOn] = @NullDate      --     THEN {OrdersImportRequest}.[CreatedOn]      --     ELSE {OrdersImportRequest}.[UpdatedOn]      -- END AS OrderImportDate,      {Region}.[Code]                         AS Region,      TelcelD.[Name]                          AS TelcelDirection,      {Supplier}.[Name]                       AS SupplierName,      {Supplier}.[Number]                     AS SupplierNumber,   ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrders in GetOrdersData in Orders in e_Orders in ConectaProveedores (SELECT      {OrderMain}.[Id]                        AS OrderMainId,      {OrderMain}.[OrderNumber]               AS OrderNumber,      {OrderMain}.[OrderDate]                 AS OrderDate,      {OrderStatus}.[Label]                   AS OrderStatus,      {OrderStatus}.[Class]                   AS OrderStatusClass,        /* Direct maximum CreatedOn lookup */      (          SELECT MAX(MaxReq.[CreatedOn])          FROM {OrdersImportRequest} MaxReq          WHERE MaxReq.[OrderMainId] = {OrderMain}.[Id]      ) AS OrderImportDateTime,        -- CASE          --     WHEN {OrdersImportRequest}.[UpdatedOn] = @NullDate      --     THEN {OrdersImportRequest}.[CreatedOn]      --     ELSE {OrdersImportRequest}.[UpdatedOn]      -- END AS OrderImportDate,      {Region}.[Code]                         AS Region,      TelcelD.[Name]                          AS TelcelDirection,      {Supplier}.[Name]                       AS SupplierName,      {Supplier}.[Number]                     AS SupplierNumber,   ...): " + aqExcep.Message));
}
}
}

// Query Function "GetCount" omoDsPCcHEuODlDIpkFljg of Action "GetOrdersData"
public static async Task<(RL_eb723ca0f1d2182a5703efa79cc03660,long)> QueryGetCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrders_Number,int qporOrders_OrderStatusId,long qpsuOrders_SupplierId,DateTime qpdaOrders_DateFrom,DateTime qpdaOrders_DateTo,long qpreOrders_RegionId,long qpreUserRegion,bool qpboIsAllRegions,DateTime qpdaNullDate,int qpinNullIdentifier,int qporOrderStatusToComplement,int qpinOffsetUtc,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("e_Orders.Orders.GetOrdersData.GetCount", "b0036aa2-9cf0-4b1c-8e0e-50c8a641658e");
using var queryActivity = activitySource.CreateSqlQueryActivity("e_Orders.Orders.GetOrdersData.GetCount", "b0036aa2-9cf0-4b1c-8e0e-50c8a641658e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityEntraRole = AppUtils.Instance.RuntimeEntityReplace("EntraRole");
sqlCmd.CreateParameter("@qporOrderStatusToComplement", DbType.Int32, qporOrderStatusToComplement);
sqlCmd.CreateParameter("@qpteOrders_Number", DbType.String, qpteOrders_Number);
sqlCmd.CreateParameter("@qporOrders_OrderStatusId", DbType.Int32, qporOrders_OrderStatusId);
sqlCmd.CreateParameter("@qpinNullIdentifier", DbType.Int32, qpinNullIdentifier);
sqlCmd.CreateParameter("@qpsuOrders_SupplierId", DbType.Int64, qpsuOrders_SupplierId);
sqlCmd.CreateParameter("@qpdaOrders_DateFrom", DbType.DateTime, qpdaOrders_DateFrom);
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpdaOrders_DateTo", DbType.DateTime, qpdaOrders_DateTo);
sqlCmd.CreateParameter("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCmd.CreateParameter("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCmd.CreateParameter("@qpreOrders_RegionId", DbType.Int64, qpreOrders_RegionId);
string sql = "";
string advSql = "SELECT \n    COUNT( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + ") \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " \n \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_Curr ON ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_Curr.\"orderapprovalid\" AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"currentlevel\"") + " = OrderApprovalLevel_Curr.\"levelnumber\") \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Curr ON OrderApprovalLevel_Curr.\"assignedto\" = User_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_Curr ON User_Curr.\"id\" = UserExt_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_Curr ON OrderApprovalLevel_Curr.\"entraroleid\" = EntraRole_Curr.\"id\" \n \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_First ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_First.\"orderapprovalid\" AND ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " = @qporOrderStatusToComplement \n            AND OrderApprovalLevel_First.\"levelnumber\" = 1 \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " <> @qporOrderStatusToComplement \n            AND OrderApprovalLevel_First.\"iscomplement\" = True \n        ) \n) \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_First ON OrderApprovalLevel_First.\"assignedto\" = User_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_First ON User_First.\"id\" = UserExt_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_First ON OrderApprovalLevel_First.\"entraroleid\" = EntraRole_First.\"id\" \n \nWHERE \n( \n    COALESCE(CAST(@qpteOrders_Number AS text), '') = '' \n    OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ") \n    LIKE caseaccent_normalize(CONCAT('%', CAST(@qpteOrders_Number AS text), '%')) COLLATE \"C\" \n) \nAND \n( \n    @qporOrders_OrderStatusId = @qpinNullIdentifier \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " = @qporOrders_OrderStatusId \n) \nAND \n( \n    @qpsuOrders_SupplierId = @qpinNullIdentifier \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuOrders_SupplierId \n) \nAND \n( \n    @qpdaOrders_DateFrom = @qpdaNullDate \n    OR \n    CAST( \n        CASE \n            WHEN ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " = @qpdaNullDate OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " IS NULL) \n                THEN ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) \n            ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " \n        END \n        AS DATE \n    ) >= CAST(@qpdaOrders_DateFrom AS DATE) \n) \nAND ( \n    @qpdaOrders_DateTo = @qpdaNullDate \n    OR \n    CAST( \n        CASE \n            WHEN ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " = @qpdaNullDate OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " IS NULL) \n                THEN ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) \n            ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " \n        END \n        AS DATE \n    ) <= CAST(@qpdaOrders_DateTo AS DATE) \n) \nAND  \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " = @qpreUserRegion  \n    OR @qpboIsAllRegions = TRUE \n) \nAND  \n( \n    @qpreOrders_RegionId = @qpinNullIdentifier  \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " = @qpreOrders_RegionId \n)";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Orders.GetOrdersData.GetCount.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Orders.GetOrdersData.GetCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb723ca0f1d2182a5703efa79cc03660)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetCount in GetOrdersData in Orders in e_Orders in ConectaProveedores (SELECT      COUNT({OrderMain}.[Id])    FROM {OrderMain}  LEFT JOIN {OrderApproval} ON {OrderApproval}.[OrderId] = {OrderMain}.[Id]  LEFT JOIN {OrderStatus} ON {OrderMain}.[OrderStatusId] = {OrderStatus}.[Id]  LEFT JOIN {Supplier} ON {OrderMain}.[SupplierId] = {Supplier}.[Id]  LEFT JOIN {Region} ON {Region}.[Id] = {OrderMain}.[DivisionId]    /* Nível atual */  LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_Curr ON ({OrderApproval}.[Id] = OrderApprovalLevel_Curr.[OrderApprovalId] AND {OrderApproval}.[CurrentLevel] = OrderApprovalLevel_Curr.[LevelNumber])  LEFT JOIN {User} User_Curr ON OrderApprovalLevel_Curr.[AssignedTo] = User_Curr.[Id]  LEFT JOIN {User_Extended_Internal} UserExt_Curr ON User_Curr.[Id] = UserExt_Curr.[Id]  LEFT JOIN {EntraRole} EntraRole_Curr ON OrderApprovalLevel_Curr.[EntraRoleId] = EntraRole_Curr.[Id]    /* Primeiro nível */  LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_First ON {OrderApproval}.[Id] = OrderApprovalLevel_First.[OrderApprovalId] AND (           ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetCount in GetOrdersData in Orders in e_Orders in ConectaProveedores (SELECT      COUNT({OrderMain}.[Id])    FROM {OrderMain}  LEFT JOIN {OrderApproval} ON {OrderApproval}.[OrderId] = {OrderMain}.[Id]  LEFT JOIN {OrderStatus} ON {OrderMain}.[OrderStatusId] = {OrderStatus}.[Id]  LEFT JOIN {Supplier} ON {OrderMain}.[SupplierId] = {Supplier}.[Id]  LEFT JOIN {Region} ON {Region}.[Id] = {OrderMain}.[DivisionId]    /* Nível atual */  LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_Curr ON ({OrderApproval}.[Id] = OrderApprovalLevel_Curr.[OrderApprovalId] AND {OrderApproval}.[CurrentLevel] = OrderApprovalLevel_Curr.[LevelNumber])  LEFT JOIN {User} User_Curr ON OrderApprovalLevel_Curr.[AssignedTo] = User_Curr.[Id]  LEFT JOIN {User_Extended_Internal} UserExt_Curr ON User_Curr.[Id] = UserExt_Curr.[Id]  LEFT JOIN {EntraRole} EntraRole_Curr ON OrderApprovalLevel_Curr.[EntraRoleId] = EntraRole_Curr.[Id]    /* Primeiro nível */  LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_First ON {OrderApproval}.[Id] = OrderApprovalLevel_First.[OrderApprovalId] AND (           ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetCount in GetOrdersData in Orders in e_Orders in ConectaProveedores (SELECT      COUNT({OrderMain}.[Id])    FROM {OrderMain}  LEFT JOIN {OrderApproval} ON {OrderApproval}.[OrderId] = {OrderMain}.[Id]  LEFT JOIN {OrderStatus} ON {OrderMain}.[OrderStatusId] = {OrderStatus}.[Id]  LEFT JOIN {Supplier} ON {OrderMain}.[SupplierId] = {Supplier}.[Id]  LEFT JOIN {Region} ON {Region}.[Id] = {OrderMain}.[DivisionId]    /* Nível atual */  LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_Curr ON ({OrderApproval}.[Id] = OrderApprovalLevel_Curr.[OrderApprovalId] AND {OrderApproval}.[CurrentLevel] = OrderApprovalLevel_Curr.[LevelNumber])  LEFT JOIN {User} User_Curr ON OrderApprovalLevel_Curr.[AssignedTo] = User_Curr.[Id]  LEFT JOIN {User_Extended_Internal} UserExt_Curr ON User_Curr.[Id] = UserExt_Curr.[Id]  LEFT JOIN {EntraRole} EntraRole_Curr ON OrderApprovalLevel_Curr.[EntraRoleId] = EntraRole_Curr.[Id]    /* Primeiro nível */  LEFT JOIN {OrderApprovalLevel} OrderApprovalLevel_First ON {OrderApproval}.[Id] = OrderApprovalLevel_First.[OrderApprovalId] AND (           ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionCheckUser {
}
public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetRegionCorp" DZyc2y2SP0mUWG3HUYvsOw of Action "GetUserApplicationRoles"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionCorp(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Orders.GetUserApplicationRoles.GetRegionCorp", "db9c9c0d-922d-493f-9458-6dc7518bec3b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Orders.GetUserApplicationRoles.GetRegionCorp", "db9c9c0d-922d-493f-9458-6dc7518bec3b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.C5K8iX6FYEWvMyGL8r54jg/DataActions.UR+81W2QG0WAX9GtOuiqJw/NodesNotShownInESpaceTree.DZyc2y2SP0mUWG3HUYvsOw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion125\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion125\"");
whereBuilder.Append(" WHERE (\"enregion125\".\"isactive\" = 1) AND (\"enregion125\".\"centrortp\" = 'MX00')");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Orders.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Orders.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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
