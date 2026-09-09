using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel).Namespace);

    public int varLcStartIndex;
public string varLcTableSort;
public int varLcl_Step;
public string varLcl_OrderNumberFilter;
public long varLcl_CompanyIdFilter;
public long varLcl_OrderIdSelected;
public bool varLcIsSelected;
public RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines;
public bool varLcl_IsSelectAll;
public bool varLcl_IsShowSelectAll;
public string varLcl_OrderIdNumberSelected;
public bool varLcl_IsExcludeFinalDelivery;
public bool varLcl_ShowOnlyAvailable;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public AggregateRecord<RL_67e2db3b41beb37bb78f90d8e94803d5> ScreenDataSetGerOrderByOrderNumber;
public ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Model varLcGetOrderMainItems;
public ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Model varLcGetOrders;
public ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Model varLcGetApplicantType;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel(int varLcStartIndex, string varLcTableSort, int varLcl_Step, string varLcl_OrderNumberFilter, long varLcl_CompanyIdFilter, long varLcl_OrderIdSelected, bool varLcIsSelected, RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines, bool varLcl_IsSelectAll, bool varLcl_IsShowSelectAll, string varLcl_OrderIdNumberSelected, bool varLcl_IsExcludeFinalDelivery, bool varLcl_ShowOnlyAvailable, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, AggregateRecord<RL_67e2db3b41beb37bb78f90d8e94803d5> ScreenDataSetGerOrderByOrderNumber, ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Model varLcGetOrderMainItems, ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Model varLcGetOrders, ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Model varLcGetApplicantType, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"StartIndex", "TableSort", "l_Step", "l_OrderNumberFilter", "l_CompanyIdFilter", "l_OrderIdSelected", "IsSelected", "LocalSelectedLines", "l_IsSelectAll", "l_IsShowSelectAll", "l_OrderIdNumberSelected", "l_IsExcludeFinalDelivery", "l_ShowOnlyAvailable", "GetCompanies", "GerOrderByOrderNumber", "GetOrderMainItems", "GetOrders", "GetApplicantType", "ClientVars"}, new string[] {"varLcStartIndex", "varLcTableSort", "varLcl_Step", "varLcl_OrderNumberFilter", "varLcl_CompanyIdFilter", "varLcl_OrderIdSelected", "varLcIsSelected", "varLcLocalSelectedLines", "varLcl_IsSelectAll", "varLcl_IsShowSelectAll", "varLcl_OrderIdNumberSelected", "varLcl_IsExcludeFinalDelivery", "varLcl_ShowOnlyAvailable", "ScreenDataSetGetCompanies", "ScreenDataSetGerOrderByOrderNumber", "varLcGetOrderMainItems", "varLcGetOrders", "varLcGetApplicantType", "clientVariables"});
this.varLcStartIndex = varLcStartIndex;
this.varLcTableSort = varLcTableSort;
this.varLcl_Step = varLcl_Step;
this.varLcl_OrderNumberFilter = varLcl_OrderNumberFilter;
this.varLcl_CompanyIdFilter = varLcl_CompanyIdFilter;
this.varLcl_OrderIdSelected = varLcl_OrderIdSelected;
this.varLcIsSelected = varLcIsSelected;
this.varLcLocalSelectedLines = varLcLocalSelectedLines;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsShowSelectAll = varLcl_IsShowSelectAll;
this.varLcl_OrderIdNumberSelected = varLcl_OrderIdNumberSelected;
this.varLcl_IsExcludeFinalDelivery = varLcl_IsExcludeFinalDelivery;
this.varLcl_ShowOnlyAvailable = varLcl_ShowOnlyAvailable;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.ScreenDataSetGerOrderByOrderNumber = ScreenDataSetGerOrderByOrderNumber;
this.varLcGetOrderMainItems = varLcGetOrderMainItems;
this.varLcGetOrders = varLcGetOrders;
this.varLcGetApplicantType = varLcGetApplicantType;
this.clientVariables = clientVariables;
}



    
// Query Function "GetCompanies" feXdIjAx6kmcmd_FULO+Ew of Action "NewFolioSAE"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.NewFolioSAE.GetCompanies", "22dde57d-3130-49ea-9c99-dfc550b3be13");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("NewFolioSAE","j_FoliosSAE.NewFolioSAE.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.A9a0qV5qVkGK3yRWtX+Agg/ScreenDataSets.feXdIjAx6kmcmd_FULO+Ew, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany68\".\"id\" o0, NULL o1, \"encompany68\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany68\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
RL_060f887b4f32b5cdb78b49175875565c outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.NewFolioSAE.GetCompanies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_060f887b4f32b5cdb78b49175875565c _tmp = new RL_060f887b4f32b5cdb78b49175875565c();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.NewFolioSAE.GetCompanies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_060f887b4f32b5cdb78b49175875565c)_tmp;
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

private static async Task<RC_04c362ab7ba29f051f4f0e5fa0df3577> datasetGerOrderByOrderNumberReadDbAsync(RC_04c362ab7ba29f051f4f0e5fa0df3577 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
return rec;
}
// Query Function "GerOrderByOrderNumber" 5sQxml_HKUmR_8WeKBz7TA of Action "NewFolioSAE"
public static async Task<(RL_67e2db3b41beb37bb78f90d8e94803d5,long)> datasetGerOrderByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderMain_OrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.NewFolioSAE.GerOrderByOrderNumber", "9a31c4e6-c75f-4929-91ff-c59e281cfb4c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("NewFolioSAE","j_FoliosSAE.NewFolioSAE.GerOrderByOrderNumber");
// Query Iterations: Never
// Refresh Query sGkcirKWKUKV1C5uACxQNA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.A9a0qV5qVkGK3yRWtX+Agg/ScreenDataSets.5sQxml_HKUmR_8WeKBz7TA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enordermain154\".\"applicant\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain154\" Inner JOIN {OrderStatus} \"enorderstatus19\" ON (\"enordermain154\".\"orderstatusid\" = \"enorderstatus19\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enordermain154\".\"ordernumber\" = @qpteOrderMain_OrderNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderMain_OrderNumber", DbType.String, qpteOrderMain_OrderNumber);
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
RL_67e2db3b41beb37bb78f90d8e94803d5 outParamList = new RL_67e2db3b41beb37bb78f90d8e94803d5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGerOrderByOrderNumberReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.NewFolioSAE.GerOrderByOrderNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_67e2db3b41beb37bb78f90d8e94803d5 _tmp = new RL_67e2db3b41beb37bb78f90d8e94803d5();
_tmp.AlternateReadDbMethodAsync = datasetGerOrderByOrderNumberReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.NewFolioSAE.GerOrderByOrderNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_67e2db3b41beb37bb78f90d8e94803d5)_tmp;
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
public RL_bab3397f952f07af0f0aa229e6f2b36e queryResGetOrdersItems2_outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
public long queryResGetOrdersItems2_outParamCount = 0L;

public lcvGetOrderMainItems() {
}
}
public class lcoGetOrderMainItems : VarsBag {
public RL_4e1292c876d12cf32f3c04367498157e outParamList = new RL_4e1292c876d12cf32f3c04367498157e();

public lcoGetOrderMainItems() {
}
}
/// <summary>
/// Action <code>GetOrderMainItems</code> that represents the Service Studio action
///  <code>GetOrderMainItems</code> <p> Description: </p>
/// </summary>
public async Task<RL_4e1292c876d12cf32f3c04367498157e> DataActionGetOrderMainItems(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_4e1292c876d12cf32f3c04367498157e outParamList = default;
lcoGetOrderMainItems result = new lcoGetOrderMainItems();
lcvGetOrderMainItems localVars = new lcvGetOrderMainItems();
ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderMainItems", "1c40205d-5039-4184-9f48-6d0d1e530aeb"))
using (activitySource.CreateScreenDataActionActivity("NewFolioSAE", "GetOrderMainItems")){
// Query QueryGetOrdersItems2
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersItems2_maxRecords = 999999999;
if (QueryGetOrdersItems2_maxRecords < 1) QueryGetOrdersItems2_maxRecords = 1;
int QueryGetOrdersItems2_startIndex = 0;(localVars.queryResGetOrdersItems2_outParamList,localVars.queryResGetOrdersItems2_outParamCount) = await FuncDataActionGetOrderMainItems.QueryGetOrdersItems2(requestContext,QueryGetOrdersItems2_maxRecords,QueryGetOrdersItems2_startIndex,IterationMultiplicity.Multiple,varLcl_OrderIdSelected,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,varLcl_IsExcludeFinalDelivery,varLcl_ShowOnlyAvailable,cancellationToken);

// List = GetOrdersItems2.List
result.outParamList=(await RL_4e1292c876d12cf32f3c04367498157e.ConvertAsync(localVars.queryResGetOrdersItems2_outParamList, new RL_4e1292c876d12cf32f3c04367498157e(), async (RC_447a4f014542f360a86edbc89025680b source, ST_1bddfac19e9b0cef65924aa7568fd106Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}
public class lcvGetOrders : VarsBag {
/// <summary>
/// Variable <code>TableSortBy</code> that represents the Service Studio Text <code>TableSortBy</code>
///  <p>Description: </p>
/// </summary>
public string varLcTableSortBy = "";

public RL_eb723ca0f1d2182a5703efa79cc03660 queryResGetOrdersCount_outParamList = new RL_eb723ca0f1d2182a5703efa79cc03660();
public long queryResGetOrdersCount_outParamCount = 0L;

public RL_ba76bc23b46b20e6625cad46f2aea8e4 queryResGetOrdersList_outParamList = new RL_ba76bc23b46b20e6625cad46f2aea8e4();
public long queryResGetOrdersList_outParamCount = 0L;

public lcvGetOrders() {
}
}
public class lcoGetOrders : VarsBag {
public RL_ba76bc23b46b20e6625cad46f2aea8e4 outParamList = new RL_ba76bc23b46b20e6625cad46f2aea8e4();

public int outParamCount = 0;

public lcoGetOrders() {
}
}
/// <summary>
/// Action <code>GetOrders</code> that represents the Service Studio action <code>GetOrders</code> <p>
///  Description: </p>
/// </summary>
public async Task<(RL_ba76bc23b46b20e6625cad46f2aea8e4,int)> DataActionGetOrders(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_ba76bc23b46b20e6625cad46f2aea8e4 outParamList = default;
int outParamCount = default;
lcoGetOrders result = new lcoGetOrders();
lcvGetOrders localVars = new lcvGetOrders();
ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrders", "79f96118-ec4f-4ec3-bc44-dd71a6c7bb6f"))
using (activitySource.CreateScreenDataActionActivity("NewFolioSAE", "GetOrders")){
if(((varLcTableSort==""))) {
// Default Sort
// TableSortBy = "{OrderMain}.[OrderNumber] DESC"
localVars.varLcTableSortBy="{OrderMain}.[OrderNumber] DESC";
} else {
// SortBy
// TableSortBy = TableSort
localVars.varLcTableSortBy=varLcTableSort;
}

// Query QueryGetOrdersList
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersList_maxRecords = 0;
int QueryGetOrdersList_startIndex = 0;(localVars.queryResGetOrdersList_outParamList,localVars.queryResGetOrdersList_outParamCount) = await FuncDataActionGetOrders.QueryGetOrdersList(requestContext,QueryGetOrdersList_maxRecords,QueryGetOrdersList_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId,varLcl_OrderNumberFilter,model.clientVariables.ssMaxRecords,varLcStartIndex,localVars.varLcTableSortBy,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,cancellationToken);

// Query QueryGetOrdersCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersCount_maxRecords = 0;
int QueryGetOrdersCount_startIndex = 0;(localVars.queryResGetOrdersCount_outParamList,localVars.queryResGetOrdersCount_outParamCount) = await FuncDataActionGetOrders.QueryGetOrdersCount(requestContext,QueryGetOrdersCount_maxRecords,QueryGetOrdersCount_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId,varLcl_OrderNumberFilter,cancellationToken);

// List = GetOrdersList.List
result.outParamList=localVars.queryResGetOrdersList_outParamList;

// Count = GetOrdersCount.List.Current.Integer.Value
result.outParamCount=localVars.queryResGetOrdersCount_outParamList.CurrentRec.ssSTInteger.ssValue;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamCount = result.outParamCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamCount);
}
public class lcvGetApplicantType : VarsBag {
public RL_89fdc2de9b4f3c518b096795c532253b queryResGetApplicants_outParamList = new RL_89fdc2de9b4f3c518b096795c532253b();
public long queryResGetApplicants_outParamCount = 0L;

public lcvGetApplicantType() {
}
}
public class lcoGetApplicantType : VarsBag {
public int outParamApprovalProcessTypeId = BuiltInFunction.NullIdentifier ();

public long outParamApplicantId = 0L;

public lcoGetApplicantType() {
}
}
/// <summary>
/// Action <code>GetApplicantType</code> that represents the Service Studio action
///  <code>GetApplicantType</code> <p> Description: </p>
/// </summary>
public async Task<(int,long)> DataActionGetApplicantType(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamApprovalProcessTypeId = default;
long outParamApplicantId = default;
lcoGetApplicantType result = new lcoGetApplicantType();
lcvGetApplicantType localVars = new lcvGetApplicantType();
ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetApplicantType", "91ea3ec9-4648-461e-b0e5-ee4fa614036f"))
using (activitySource.CreateScreenDataActionActivity("NewFolioSAE", "GetApplicantType")){
// Query datasetGetApplicants
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApplicants_maxRecords = 1;
if (datasetGetApplicants_maxRecords < 1) datasetGetApplicants_maxRecords = 1;
int datasetGetApplicants_startIndex = 0;(localVars.queryResGetApplicants_outParamList,localVars.queryResGetApplicants_outParamCount) = await FuncDataActionGetApplicantType.datasetGetApplicants(requestContext,datasetGetApplicants_maxRecords,datasetGetApplicants_startIndex,IterationMultiplicity.Never,ScreenDataSetGerOrderByOrderNumber.List.CurrentRec.ssENOrderMain.ssApplicant,cancellationToken);

// ApprovalProcessTypeId = GetApplicants.List.Current.Applicant.ApprovalProcessTypeId
result.outParamApprovalProcessTypeId=localVars.queryResGetApplicants_outParamList.CurrentRec.ssENApplicant.ssApprovalProcessTypeId;

// ApplicantId = GetApplicants.List.Current.Applicant.Id
result.outParamApplicantId=localVars.queryResGetApplicants_outParamList.CurrentRec.ssENApplicant.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamApprovalProcessTypeId = result.outParamApprovalProcessTypeId;
outParamApplicantId = result.outParamApplicantId;
} // inner-finally
RETURN_STATEMENT:
return (outParamApprovalProcessTypeId,outParamApplicantId);
}


    public static class FuncDataActionGetOrderMainItems {

// Query Function "GetOrdersItems2" bgN1HUHf40S+zzWaDfVcqg of Action "GetOrderMainItems"
public static async Task<(RL_bab3397f952f07af0f0aa229e6f2b36e,long)> QueryGetOrdersItems2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,bool qpboi_ExcludeFinalDelivery,bool qpboi_ShowOnlyAvailable,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.NewFolioSAE.GetOrderMainItems.GetOrdersItems2", "1d75036e-df41-44e3-becf-359a0df55caa");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.NewFolioSAE.GetOrderMainItems.GetOrdersItems2", "1d75036e-df41-44e3-becf-359a0df55caa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceled", DbType.Int32, qpfoi_folioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceledByProvider", DbType.Int32, qpfoi_folioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qporl_OrderIdSelected", DbType.Int64, qporl_OrderIdSelected);
sqlCmd.CreateParameter("@qpboi_ExcludeFinalDelivery", DbType.Boolean, qpboi_ExcludeFinalDelivery);
sqlCmd.CreateParameter("@qpboi_ShowOnlyAvailable", DbType.Boolean, qpboi_ShowOnlyAvailable);
string sql = "";
string advSql = "WITH OrderDetails AS ( \n    SELECT  \n        0 AS \"dummyzero\",  \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " AS \"ordermainitemid\", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n         \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        ), 0) + COALESCE(( \n            SELECT COALESCE(SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))),0) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n            OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0)) \n        ), 0) AS QtdDelivered, \n         \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " -  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " - ( \n            COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n                INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled  \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n            ), 0)  +  COALESCE(( \n                SELECT COALESCE(SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))),0) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n                OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0)) \n            ), 0) \n        ) AS QttAvailable, \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " AS \"currencycode\", \n        ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " * ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + " /  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ")) AS \"totalprice\", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"class\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"deliverydate\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatrate\"") + ", \n        COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"totalprice\"") + " AS DECIMAL(18,2))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        ), 0) AS \"foliototalprice\", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"pepelement\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ismultipleimputation\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \n    INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " \n    WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " = @qporl_OrderIdSelected \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + " = 0  \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + " = 0 \n    AND (@qpboi_ExcludeFinalDelivery = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + " = 0) \n) \nSELECT * FROM OrderDetails \nWHERE (@qpboi_ShowOnlyAvailable = 0 OR \n    ( \n        QttAvailable > 0 AND \n        \"isdeleted\" = 0 AND \n        \"isblocked\" = 0 AND \n        \"isfinaldelivery\" = 0 \n    ) \n) \nORDER BY \"position\" ASC";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bab3397f952f07af0f0aa229e6f2b36e outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.NewFolioSAE.GetOrderMainItems.GetOrdersItems2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bab3397f952f07af0f0aa229e6f2b36e _tmp = new RL_bab3397f952f07af0f0aa229e6f2b36e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.NewFolioSAE.GetOrderMainItems.GetOrdersItems2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bab3397f952f07af0f0aa229e6f2b36e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems2 in GetOrderMainItems in NewFolioSAE in j_FoliosSAE in ConectaProveedores (WITH OrderDetails AS (      SELECT           0 AS [DummyZero], -- Giving it an alias so the CTE handles it neatly          {OrderMainItem}.[Id] AS [OrderMainItemId],          {OrderMain}.[OrderNumber],          {OrderMainItem}.[Position],          {OrderMainItem}.[MaterialCode],          {OrderMainItem}.[MaterialDescription],          {OrderMainItem}.[Quantity],            /* --- QtdDelivered Calculation --- */          {OrderMainItem}.[QuantityDelivered] + COALESCE((              SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))              FROM {FolioItems}              INNER JOIN {Folio} ON {Folio}.[Id] = {FolioItems}.[FolioId]              WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]              AND ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled AND {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          ), 0) + COALESCE((              SELECT COALESCE(SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3))),0)              FROM {O ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems2 in GetOrderMainItems in NewFolioSAE in j_FoliosSAE in ConectaProveedores (WITH OrderDetails AS (      SELECT           0 AS [DummyZero], -- Giving it an alias so the CTE handles it neatly          {OrderMainItem}.[Id] AS [OrderMainItemId],          {OrderMain}.[OrderNumber],          {OrderMainItem}.[Position],          {OrderMainItem}.[MaterialCode],          {OrderMainItem}.[MaterialDescription],          {OrderMainItem}.[Quantity],            /* --- QtdDelivered Calculation --- */          {OrderMainItem}.[QuantityDelivered] + COALESCE((              SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))              FROM {FolioItems}              INNER JOIN {Folio} ON {Folio}.[Id] = {FolioItems}.[FolioId]              WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]              AND ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled AND {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          ), 0) + COALESCE((              SELECT COALESCE(SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3))),0)              FROM {O ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems2 in GetOrderMainItems in NewFolioSAE in j_FoliosSAE in ConectaProveedores (WITH OrderDetails AS (      SELECT           0 AS [DummyZero], -- Giving it an alias so the CTE handles it neatly          {OrderMainItem}.[Id] AS [OrderMainItemId],          {OrderMain}.[OrderNumber],          {OrderMainItem}.[Position],          {OrderMainItem}.[MaterialCode],          {OrderMainItem}.[MaterialDescription],          {OrderMainItem}.[Quantity],            /* --- QtdDelivered Calculation --- */          {OrderMainItem}.[QuantityDelivered] + COALESCE((              SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))              FROM {FolioItems}              INNER JOIN {Folio} ON {Folio}.[Id] = {FolioItems}.[FolioId]              WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]              AND ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled AND {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          ), 0) + COALESCE((              SELECT COALESCE(SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3))),0)              FROM {O ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetOrders {

// Query Function "GetOrdersCount" skezACgvBkeNShT1NE0thA of Action "GetOrders"
public static async Task<(RL_eb723ca0f1d2182a5703efa79cc03660,long)> QueryGetOrdersCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuUserSuplierId,int qporOrderStatusIdApproved,string qpteOrderNumberFilter,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersCount", "00b347b2-2f28-4706-8d4a-14f5344d2d84");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersCount", "00b347b2-2f28-4706-8d4a-14f5344d2d84", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
sqlCmd.CreateParameter("@qpsuUserSuplierId", DbType.Int64, qpsuUserSuplierId);
sqlCmd.CreateParameter("@qporOrderStatusIdApproved", DbType.Int32, qporOrderStatusIdApproved);
sqlCmd.CreateParameter("@qpteOrderNumberFilter", DbType.String, qpteOrderNumberFilter);
string sql = "";
string advSql = "SELECT count(1) \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuUserSuplierId \n  AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " = @qporOrderStatusIdApproved \n  AND (@qpteOrderNumberFilter = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + " collate \"default\") \n        LIKE '%' || caseaccent_normalize(@qpteOrderNumberFilter collate \"default\") || '%') \n  AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"isreleased\"") + " = TRUE";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersCount.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb723ca0f1d2182a5703efa79cc03660)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersCount in GetOrders in NewFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT count(1)  FROM {OrderMain}  INNER JOIN {Company} ON {Company}.[Id] = {OrderMain}.[CompanyId]  LEFT JOIN {OrderStatus} ON {OrderStatus}.[Id] = {OrderMain}.[OrderStatusId]  LEFT JOIN {Currency} ON {Currency}.[Code] = {OrderMain}.[CurrencyId]  WHERE {OrderMain}.[SupplierId] = @UserSuplierId    AND {OrderMain}.[OrderStatusId] = @OrderStatusIdApproved    AND (@OrderNumberFilter = '' OR caseaccent_normalize({OrderMain}.[OrderNumber] collate \"default\")          LIKE '%' || caseaccent_normalize(@OrderNumberFilter collate \"default\") || '%')    AND {OrderMain}.[IsReleased] = TRUE): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersCount in GetOrders in NewFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT count(1)  FROM {OrderMain}  INNER JOIN {Company} ON {Company}.[Id] = {OrderMain}.[CompanyId]  LEFT JOIN {OrderStatus} ON {OrderStatus}.[Id] = {OrderMain}.[OrderStatusId]  LEFT JOIN {Currency} ON {Currency}.[Code] = {OrderMain}.[CurrencyId]  WHERE {OrderMain}.[SupplierId] = @UserSuplierId    AND {OrderMain}.[OrderStatusId] = @OrderStatusIdApproved    AND (@OrderNumberFilter = '' OR caseaccent_normalize({OrderMain}.[OrderNumber] collate \"default\")          LIKE '%' || caseaccent_normalize(@OrderNumberFilter collate \"default\") || '%')    AND {OrderMain}.[IsReleased] = TRUE): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersCount in GetOrders in NewFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT count(1)  FROM {OrderMain}  INNER JOIN {Company} ON {Company}.[Id] = {OrderMain}.[CompanyId]  LEFT JOIN {OrderStatus} ON {OrderStatus}.[Id] = {OrderMain}.[OrderStatusId]  LEFT JOIN {Currency} ON {Currency}.[Code] = {OrderMain}.[CurrencyId]  WHERE {OrderMain}.[SupplierId] = @UserSuplierId    AND {OrderMain}.[OrderStatusId] = @OrderStatusIdApproved    AND (@OrderNumberFilter = '' OR caseaccent_normalize({OrderMain}.[OrderNumber] collate \"default\")          LIKE '%' || caseaccent_normalize(@OrderNumberFilter collate \"default\") || '%')    AND {OrderMain}.[IsReleased] = TRUE): " + aqExcep.Message));
}
}
}

private static async Task<RC_d14c83cafc2c8c4853d5f866ece1c59b> QueryGetOrdersListReadDbAsync(RC_d14c83cafc2c8c4853d5f866ece1c59b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read(r, ref index);
rec.ssENCompany.Read(r, ref index);
rec.ssENCurrency.Read(r, ref index);
rec.ssENOrderStatus.Read(r, ref index);
rec.ssSTQuantidadeEntregada.Read(r, ref index);
rec.ssSTQuantidadeTotal.Read(r, ref index);
return rec;
}
// Query Function "GetOrdersList" NUpangU3Akmv1dFFvBZapw of Action "GetOrders"
public static async Task<(RL_ba76bc23b46b20e6625cad46f2aea8e4,long)> QueryGetOrdersList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuUserSuplierId,int qporOrderStatusIdApproved,string qpteOrderNumberFilter,int qpinMaxRecords,int qpinIndex,string qpteOrderBy,int qpfoFolioStatusIDCanceled,int qpfoFolioStatusIDCanceledByProvider,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersList", "9e5a4a35-3705-4902-afd5-d145bc165aa7");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersList", "9e5a4a35-3705-4902-afd5-d145bc165aa7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
sqlCmd.CreateParameter("@qpfoFolioStatusIDCanceled", DbType.Int32, qpfoFolioStatusIDCanceled);
sqlCmd.CreateParameter("@qpfoFolioStatusIDCanceledByProvider", DbType.Int32, qpfoFolioStatusIDCanceledByProvider);
sqlCmd.CreateParameter("@qpsuUserSuplierId", DbType.Int64, qpsuUserSuplierId);
sqlCmd.CreateParameter("@qporOrderStatusIdApproved", DbType.Int32, qporOrderStatusIdApproved);
sqlCmd.CreateParameter("@qpteOrderNumberFilter", DbType.String, qpteOrderNumberFilter);
sqlCmd.CreateParameter("@qpinIndex", DbType.Int32, qpinIndex);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
string sql = "";
string advSql = "SELECT  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"previousorderstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"assignmentcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"documenttypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"procurementgroup\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"creatorsapnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"creatorsapname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"country\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"isdeleted\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"isreleased\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"exchangerate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"sustainabilitycategory\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"sustainabilitysubcategory\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"totalamount\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"fromcosmoz\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"updatedon\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"rfc\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"postalcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"cyaimport\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"fspuse\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedby\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"symbol\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"minorunitdecimals\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"labeles\"") + ", \n    COALESCE((SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + "  \n            ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \n            ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIDCanceled \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIDCanceledByProvider \n    ), 0) + COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,2))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n        INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \n            ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n        AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 OR ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0 \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0)) \n    ), 0) as TotalDeliveredQuantity, \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " AS DECIMAL(18,2))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n        ), 0) AS TotalOrderItemQtt \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuUserSuplierId \n  AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " = @qporOrderStatusIdApproved \n  AND (@qpteOrderNumberFilter = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + " collate \"default\") \n        LIKE '%' || caseaccent_normalize(@qpteOrderNumberFilter collate \"default\") || '%') \n  AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"isreleased\"") + " = TRUE \nORDER BY  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteOrderBy)) + " \nOFFSET @qpinIndex \nLIMIT @qpinMaxRecords";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ba76bc23b46b20e6625cad46f2aea8e4 outParamList = new RL_ba76bc23b46b20e6625cad46f2aea8e4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetOrdersListReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false});
opt[4] = new BitArray(new bool[] {false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ba76bc23b46b20e6625cad46f2aea8e4 _tmp = new RL_ba76bc23b46b20e6625cad46f2aea8e4();
_tmp.AlternateReadDbMethodAsync = QueryGetOrdersListReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.NewFolioSAE.GetOrders.GetOrdersList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ba76bc23b46b20e6625cad46f2aea8e4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersList in GetOrders in NewFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT       {OrderMain}.*,      {Company}.*,      {Currency}.*,      {OrderStatus}.*,      COALESCE((SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          INNER JOIN {Folio}               ON {Folio}.[Id] = {FolioItems}.[FolioId]          INNER JOIN {OrderMainItem}              ON {OrderMainItem}.[Id] = {FolioItems}.[OrderMainItemId]          WHERE {OrderMainItem}.[OrderMainId] = {OrderMain}.[Id]          AND {Folio}.[FolioStatusId] <> @FolioStatusIDCanceled          AND {Folio}.[FolioStatusId] <> @FolioStatusIDCanceledByProvider      ), 0) + COALESCE((          SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,2)))          FROM {OrderItemEntries}          INNER JOIN {OrderMainItem}              ON {OrderMainItem}.[Id] = {OrderItemEntries}.[OrderMainItemid]          WHERE {OrderMainItem}.[OrderMainId] = {OrderMain}.[Id]          AND ({OrderItemEntries}.[Quantity_] > 0 OR (          {OrderItemEntries}.[Quantity_] < 0          AND {O ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersList in GetOrders in NewFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT       {OrderMain}.*,      {Company}.*,      {Currency}.*,      {OrderStatus}.*,      COALESCE((SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          INNER JOIN {Folio}               ON {Folio}.[Id] = {FolioItems}.[FolioId]          INNER JOIN {OrderMainItem}              ON {OrderMainItem}.[Id] = {FolioItems}.[OrderMainItemId]          WHERE {OrderMainItem}.[OrderMainId] = {OrderMain}.[Id]          AND {Folio}.[FolioStatusId] <> @FolioStatusIDCanceled          AND {Folio}.[FolioStatusId] <> @FolioStatusIDCanceledByProvider      ), 0) + COALESCE((          SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,2)))          FROM {OrderItemEntries}          INNER JOIN {OrderMainItem}              ON {OrderMainItem}.[Id] = {OrderItemEntries}.[OrderMainItemid]          WHERE {OrderMainItem}.[OrderMainId] = {OrderMain}.[Id]          AND ({OrderItemEntries}.[Quantity_] > 0 OR (          {OrderItemEntries}.[Quantity_] < 0          AND {O ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersList in GetOrders in NewFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT       {OrderMain}.*,      {Company}.*,      {Currency}.*,      {OrderStatus}.*,      COALESCE((SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          INNER JOIN {Folio}               ON {Folio}.[Id] = {FolioItems}.[FolioId]          INNER JOIN {OrderMainItem}              ON {OrderMainItem}.[Id] = {FolioItems}.[OrderMainItemId]          WHERE {OrderMainItem}.[OrderMainId] = {OrderMain}.[Id]          AND {Folio}.[FolioStatusId] <> @FolioStatusIDCanceled          AND {Folio}.[FolioStatusId] <> @FolioStatusIDCanceledByProvider      ), 0) + COALESCE((          SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,2)))          FROM {OrderItemEntries}          INNER JOIN {OrderMainItem}              ON {OrderMainItem}.[Id] = {OrderItemEntries}.[OrderMainItemid]          WHERE {OrderMainItem}.[OrderMainId] = {OrderMain}.[Id]          AND ({OrderItemEntries}.[Quantity_] > 0 OR (          {OrderItemEntries}.[Quantity_] < 0          AND {O ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetApplicantType {

// Query Function "GetApplicants" jbdxIqbGE0a4Lt_zlChajg of Action "GetApplicantType"
public static async Task<(RL_89fdc2de9b4f3c518b096795c532253b,long)> datasetGetApplicants(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteApplicant,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.NewFolioSAE.GetApplicantType.GetApplicants", "2271b78d-c6a6-4613-b82e-dff394285a8e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.NewFolioSAE.GetApplicantType.GetApplicants", "2271b78d-c6a6-4613-b82e-dff394285a8e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.A9a0qV5qVkGK3yRWtX+Agg/DataActions.yT7qkUhGHkaw5e5PphQDbw/NodesNotShownInESpaceTree.jbdxIqbGE0a4Lt_zlChajg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicant6\".\"id\" o0, NULL o1, NULL o2, \"enapplicant6\".\"approvalprocesstypeid\" o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {Applicant} \"enapplicant6\"");
whereBuilder.Append(" WHERE ((Upper(\"enapplicant6\".\"applicant\")) = (Upper((trim(@qpteApplicant)))))");
sqlCmd.CreateParameterWithoutReplacements("@qpteApplicant", DbType.String, qpteApplicant);
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
RL_89fdc2de9b4f3c518b096795c532253b outParamList = new RL_89fdc2de9b4f3c518b096795c532253b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.NewFolioSAE.GetApplicantType.GetApplicants.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_89fdc2de9b4f3c518b096795c532253b _tmp = new RL_89fdc2de9b4f3c518b096795c532253b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.NewFolioSAE.GetApplicantType.GetApplicants.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_89fdc2de9b4f3c518b096795c532253b)_tmp;
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
