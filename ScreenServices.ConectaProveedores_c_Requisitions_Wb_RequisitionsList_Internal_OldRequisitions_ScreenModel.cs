using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ScreenModel).Namespace);

    public bool varLcl_ShowFilters;
public string varLcl_TableSort;
public int varLcl_StartIndex;
public long varLcl_ApplicationRoleIdForAggregate;
public bool varLcl_IsAllowSelectApplicationRoles;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetRequisitions;
public int varLcl_CountAfterFetchGetRequisitions;
public bool varLcl_ShowCancelPopup;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public long varLcl_RequisitonToCancel;
public bool varLcl_ShowScreenTableDownloads;
public BasicTypeList<long> varLcl_RequisitionsListInternalIdList;
public bool varLcIsListFullNeedRefresh;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters;
public AggregateRecord<RL_7324330f004cfb528140f21030a5e90f> ScreenDataSetGetRequisitionStatuses;
public AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Model varLcGetRequisitionsFull;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitions_Model varLcGetRequisitions;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ScreenModel(bool varLcl_ShowFilters, string varLcl_TableSort, int varLcl_StartIndex, long varLcl_ApplicationRoleIdForAggregate, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetRequisitions, int varLcl_CountAfterFetchGetRequisitions, bool varLcl_ShowCancelPopup, string varLcl_AmountFromText, string varLcl_AmountToText, long varLcl_RequisitonToCancel, bool varLcl_ShowScreenTableDownloads, BasicTypeList<long> varLcl_RequisitionsListInternalIdList, bool varLcIsListFullNeedRefresh, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters, AggregateRecord<RL_7324330f004cfb528140f21030a5e90f> ScreenDataSetGetRequisitionStatuses, AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Model varLcGetRequisitionsFull, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitions_Model varLcGetRequisitions, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ShowFilters", "l_TableSort", "l_StartIndex", "l_ApplicationRoleIdForAggregate", "l_IsAllowSelectApplicationRoles", "l_ReInvokeToggler", "l_ColumnJSONVarGetRequisitions", "l_CountAfterFetchGetRequisitions", "l_ShowCancelPopup", "l_AmountFromText", "l_AmountToText", "l_RequisitonToCancel", "l_ShowScreenTableDownloads", "l_RequisitionsListInternalIdList", "IsListFullNeedRefresh", "GetCompanies", "GetApprovalStatuses", "GetProjectAssetServices", "GetCostCenters", "GetRequisitionStatuses", "GetEntraRole", "GetRequisitionsFull", "GetUserApplicationRolesAndMore", "GetRequisitions", "ClientVars"}, new string[] {"varLcl_ShowFilters", "varLcl_TableSort", "varLcl_StartIndex", "varLcl_ApplicationRoleIdForAggregate", "varLcl_IsAllowSelectApplicationRoles", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetRequisitions", "varLcl_CountAfterFetchGetRequisitions", "varLcl_ShowCancelPopup", "varLcl_AmountFromText", "varLcl_AmountToText", "varLcl_RequisitonToCancel", "varLcl_ShowScreenTableDownloads", "varLcl_RequisitionsListInternalIdList", "varLcIsListFullNeedRefresh", "ScreenDataSetGetCompanies", "ScreenDataSetGetApprovalStatuses", "ScreenDataSetGetProjectAssetServices", "ScreenDataSetGetCostCenters", "ScreenDataSetGetRequisitionStatuses", "ScreenDataSetGetEntraRole", "varLcGetRequisitionsFull", "varLcGetUserApplicationRolesAndMore", "varLcGetRequisitions", "clientVariables"});
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ApplicationRoleIdForAggregate = varLcl_ApplicationRoleIdForAggregate;
this.varLcl_IsAllowSelectApplicationRoles = varLcl_IsAllowSelectApplicationRoles;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetRequisitions = varLcl_ColumnJSONVarGetRequisitions;
this.varLcl_CountAfterFetchGetRequisitions = varLcl_CountAfterFetchGetRequisitions;
this.varLcl_ShowCancelPopup = varLcl_ShowCancelPopup;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.varLcl_RequisitonToCancel = varLcl_RequisitonToCancel;
this.varLcl_ShowScreenTableDownloads = varLcl_ShowScreenTableDownloads;
this.varLcl_RequisitionsListInternalIdList = varLcl_RequisitionsListInternalIdList;
this.varLcIsListFullNeedRefresh = varLcIsListFullNeedRefresh;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.ScreenDataSetGetApprovalStatuses = ScreenDataSetGetApprovalStatuses;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.ScreenDataSetGetCostCenters = ScreenDataSetGetCostCenters;
this.ScreenDataSetGetRequisitionStatuses = ScreenDataSetGetRequisitionStatuses;
this.ScreenDataSetGetEntraRole = ScreenDataSetGetEntraRole;
this.varLcGetRequisitionsFull = varLcGetRequisitionsFull;
this.varLcGetUserApplicationRolesAndMore = varLcGetUserApplicationRolesAndMore;
this.varLcGetRequisitions = varLcGetRequisitions;
this.clientVariables = clientVariables;
}



    
// Query Function "GetCompanies" reVAODIKxUe5cuYbmaVh4A of Action "Wb_RequisitionsList_Internal_OldRequisitions"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCompanies", "3840e5ad-0a32-47c5-b972-e61b99a561e0");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal_OldRequisitions","c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/ScreenDataSets.reVAODIKxUe5cuYbmaVh4A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany49\".\"id\" o0, NULL o1, \"encompany49\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany49\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCompanies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCompanies.List", cancellationToken: cancellationToken);
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

// Query Function "GetApprovalStatuses" o_+YafnGEkWI9mRZbxFmhQ of Action "Wb_RequisitionsList_Internal_OldRequisitions"
public static async Task<(RL_51a4e63e168a01408e3f55c611518e13,long)> datasetGetApprovalStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetApprovalStatuses", "6998ffa3-c6f9-4512-88f6-64596f116685");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal_OldRequisitions","c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetApprovalStatuses");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/ScreenDataSets.o_+YafnGEkWI9mRZbxFmhQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus16\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enapprovalstatus16\".\"labeles\" o9");
fromBuilder.Append(" FROM {ApprovalStatus} \"enapprovalstatus16\"");
whereBuilder.Append(" WHERE (\"enapprovalstatus16\".\"is_active\" = 1) AND (\"enapprovalstatus16\".\"isreq\" = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalstatus16\".\"order\" ASC ");
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
RL_51a4e63e168a01408e3f55c611518e13 outParamList = new RL_51a4e63e168a01408e3f55c611518e13();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetApprovalStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_51a4e63e168a01408e3f55c611518e13 _tmp = new RL_51a4e63e168a01408e3f55c611518e13();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetApprovalStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_51a4e63e168a01408e3f55c611518e13)_tmp;
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

// Query Function "GetProjectAssetServices" XeMxcDGegUWyhF4wQJGvuw of Action "Wb_RequisitionsList_Internal_OldRequisitions"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetProjectAssetServices", "7031e35d-9e31-4581-b284-5e304091afbb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal_OldRequisitions","c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetProjectAssetServices");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/ScreenDataSets.XeMxcDGegUWyhF4wQJGvuw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service19\".\"id\" o0, \"enproject_asset_service19\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service19\"");
orderByBuilder.Append(" ORDER BY \"enproject_asset_service19\".\"description\" ASC ");
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
RL_39dc6f4415ce9196844d0ada601cc72b outParamList = new RL_39dc6f4415ce9196844d0ada601cc72b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetProjectAssetServices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39dc6f4415ce9196844d0ada601cc72b _tmp = new RL_39dc6f4415ce9196844d0ada601cc72b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetProjectAssetServices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39dc6f4415ce9196844d0ada601cc72b)_tmp;
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

// Query Function "GetCostCenters" GXCLjFRlKkCwFokKTR4llA of Action "Wb_RequisitionsList_Internal_OldRequisitions"
public static async Task<(RL_ec55ed22dae89075d036f3a863173164,long)> datasetGetCostCenters(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCostCenters", "8c8b7019-6554-402a-b016-890a4d1e2594");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal_OldRequisitions","c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCostCenters");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/ScreenDataSets.GXCLjFRlKkCwFokKTR4llA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encostcentersap16\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"encostcentersap16\".\"ce_coste\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM {CostCenterSAP} \"encostcentersap16\"");
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
RL_ec55ed22dae89075d036f3a863173164 outParamList = new RL_ec55ed22dae89075d036f3a863173164();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCostCenters.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ec55ed22dae89075d036f3a863173164 _tmp = new RL_ec55ed22dae89075d036f3a863173164();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetCostCenters.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ec55ed22dae89075d036f3a863173164)_tmp;
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

// Query Function "GetRequisitionStatuses" RPoRsbkAd0q1Z08_RE3dWA of Action "Wb_RequisitionsList_Internal_OldRequisitions"
public static async Task<(RL_7324330f004cfb528140f21030a5e90f,long)> datasetGetRequisitionStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionStatuses", "b111fa44-00b9-4a77-b567-4f3f444ddd58");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal_OldRequisitions","c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionStatuses");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/ScreenDataSets.RPoRsbkAd0q1Z08_RE3dWA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionstatus3\".\"id\" o0, \"enrequisitionstatus3\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {RequisitionStatus} \"enrequisitionstatus3\"");
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
RL_7324330f004cfb528140f21030a5e90f outParamList = new RL_7324330f004cfb528140f21030a5e90f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7324330f004cfb528140f21030a5e90f _tmp = new RL_7324330f004cfb528140f21030a5e90f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7324330f004cfb528140f21030a5e90f)_tmp;
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

private static async Task<RC_2d026dc77741fad17a11f0df63aa3b4b> datasetGetEntraRoleReadDbAsync(RC_2d026dc77741fad17a11f0df63aa3b4b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetEntraRole" AwzzyKqBYUqQK6yszWNUtA of Action "Wb_RequisitionsList_Internal_OldRequisitions"
public static async Task<(RL_ea7d18baeeefa57d5c86706d7efb98e9,long)> datasetGetEntraRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetEntraRole", "c8f30c03-81aa-4a61-902b-acaccd6354b4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal_OldRequisitions","c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetEntraRole");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/ScreenDataSets.AwzzyKqBYUqQK6yszWNUtA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"enentrarole57\".\"issolicitante\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal111\" Inner JOIN {EntraRole} \"enentrarole57\" ON (\"enentrarole57\".\"rolename\" = \"enuser_extended_internal111\".\"jobtitle\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal111\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal111\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal111\".\"id\" IS NULL)");
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
RL_ea7d18baeeefa57d5c86706d7efb98e9 outParamList = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetEntraRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetEntraRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ea7d18baeeefa57d5c86706d7efb98e9 _tmp = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
_tmp.AlternateReadDbMethodAsync = datasetGetEntraRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetEntraRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ea7d18baeeefa57d5c86706d7efb98e9)_tmp;
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


    public class lcvGetRequisitionsFull : VarsBag {
public RL_2b41a595aabe414dbaa0e4db170b16f9 queryResGetRequisitionsList_outParamList = new RL_2b41a595aabe414dbaa0e4db170b16f9();
public long queryResGetRequisitionsList_outParamCount = 0L;

public Actions.lcoEncodeSortForSQL resEncodeSortForSQL =  new Actions.lcoEncodeSortForSQL();
public lcvGetRequisitionsFull() {
}
}
public class lcoGetRequisitionsFull : VarsBag {
public RL_a88cee033f640538574578015052224b outParamList = new RL_a88cee033f640538574578015052224b();

public string outParamSortClause = "";

public lcoGetRequisitionsFull() {
}
}
/// <summary>
/// Action <code>GetRequisitionsFull</code> that represents the Service Studio action
///  <code>GetRequisitionsFull</code> <p> Description: Query to fetch Requisitions.</p>
/// </summary>
public async Task<(RL_a88cee033f640538574578015052224b,string)> DataActionGetRequisitionsFull(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_a88cee033f640538574578015052224b outParamList = default;
string outParamSortClause = default;
lcoGetRequisitionsFull result = new lcoGetRequisitionsFull();
lcvGetRequisitionsFull localVars = new lcvGetRequisitionsFull();
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitionsFull", "2e3d709f-1854-4a7d-b3ab-c0175a0e95a9"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsList_Internal_OldRequisitions", "GetRequisitionsFull")){
// EncodeSortForSQL
localVars.resEncodeSortForSQL.outParamSortForSQL = await Actions.ActionEncodeSortForSQL(requestContext,varLcl_TableSort,cancellationToken);

// SortClause = "ORDER BY " + EncodeSortForSQL.SortForSQL
result.outParamSortClause=("ORDER BY "+localVars.resEncodeSortForSQL.outParamSortForSQL);
// Query QueryGetRequisitionsList
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsList_maxRecords = 999999999;
if (QueryGetRequisitionsList_maxRecords < 1) QueryGetRequisitionsList_maxRecords = 1;
int QueryGetRequisitionsList_startIndex = 0;(localVars.queryResGetRequisitionsList_outParamList,localVars.queryResGetRequisitionsList_outParamCount) = await FuncDataActionGetRequisitionsFull.QueryGetRequisitionsList(requestContext,QueryGetRequisitionsList_maxRecords,QueryGetRequisitionsList_startIndex,IterationMultiplicity.Single,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(model.clientVariables.ssOffsetUtc*(-1)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),varLcGetUserApplicationRolesAndMore.outParamAppRoleListText,varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.clientVariables.ssRequisitions_RequisitionSearch,model.clientVariables.ssRequisitions_ProjectId,model.clientVariables.ssRequisitions_UploadDate,model.clientVariables.ssRequisitions_CompanyId,model.clientVariables.ssRequisitions_AmountFrom,model.clientVariables.ssRequisitions_AmountTo,model.clientVariables.ssRequisitions_CostCenterId,model.clientVariables.ssRequisitions_SupplierId,model.clientVariables.ssRequisitions_RequisitionsStatusId,model.clientVariables.ssRequisitions_ApprovalStatusId,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),result.outParamSortClause,cancellationToken);

// List = GetRequisitionsList.List
result.outParamList=(await RL_a88cee033f640538574578015052224b.ConvertAsync(localVars.queryResGetRequisitionsList_outParamList, new RL_a88cee033f640538574578015052224b(), async (RC_58280cdffc99dfa38a289f32f19bc2e2 source, RC_ed0b8e4be2720d34635f080b43e417d8 target, CancellationToken cancellationToken) => {
target.ssENApplicationRole = source.ssENApplicationRole;
target.ssENApprovalStatus = source.ssENApprovalStatus;
target.ssENCompany = source.ssENCompany;
target.ssENCostCenterSAP = source.ssENCostCenterSAP;
target.ssENCurrency = source.ssENCurrency;
target.ssSTDontShowAction = source.ssSTDontShowAction;
target.ssSTIsUserFromThisRegion = source.ssSTIsUserFromThisRegion;
target.ssENProject_Asset_Service = source.ssENProject_Asset_Service;
target.ssENRegion = source.ssENRegion;
target.ssENRequisition = source.ssENRequisition;
target.ssENRequisitionApproval = source.ssENRequisitionApproval;
target.ssENRequisitionApprovalLevel = source.ssENRequisitionApprovalLevel;
target.ssENRequisitionStatus = source.ssENRequisitionStatus;
target.ssENSegmentAccGroup = source.ssENSegmentAccGroup;
target.ssENSegmentAccGroupTelcelDir = source.ssENSegmentAccGroupTelcelDir;
target.ssENSupplier = source.ssENSupplier;
target.ssENTelcelDirection = source.ssENTelcelDirection;
target.ssSTUpdatedBy = source.ssSTUserUpdatedByName;
target.ssSTUserApplicantName = source.ssSTUserApplicantName;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamSortClause = result.outParamSortClause;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamSortClause);
}
public class lcvGetUserApplicationRolesAndMore : VarsBag {
public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_b9107f331631f30bcef7fe9d900d99ae queryResGetUserApplicationRoleTempByConcepts_outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
public long queryResGetUserApplicationRoleTempByConcepts_outParamCount = 0L;

public Actions.lcoGetCanUploadInvoices resGetCanUploadInvoices =  new Actions.lcoGetCanUploadInvoices();
public int resFindIsCorporativoCxP_outParamPosition = 0;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public lcvGetUserApplicationRolesAndMore() {
}
}
public class lcoGetUserApplicationRolesAndMore : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamAppRoleListText = "";

public bool outParamIsCorporativoCxP = false;

public bool outParamo_CanUploadInvoices = false;

public string outParamTelcelDirectionsListText = "";

public long outParamCorporativoRegionId = 0L;

public long outParamUserRegion = 0L;

public bool outParamIsActiveDEV_NewVersionScreenDownloads = false;

public lcoGetUserApplicationRolesAndMore() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRolesAndMore</code> that represents the Service Studio action
///  <code>GetUserApplicationRolesAndMore</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,bool,bool,string,long,long,bool)> DataActionGetUserApplicationRolesAndMore(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRoleListText = default;
bool outParamIsCorporativoCxP = default;
bool outParamo_CanUploadInvoices = default;
string outParamTelcelDirectionsListText = default;
long outParamCorporativoRegionId = default;
long outParamUserRegion = default;
bool outParamIsActiveDEV_NewVersionScreenDownloads = default;
lcoGetUserApplicationRolesAndMore result = new lcoGetUserApplicationRolesAndMore();
lcvGetUserApplicationRolesAndMore localVars = new lcvGetUserApplicationRolesAndMore();
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRolesAndMore", "820a45a3-edaa-4181-97c8-e9d493034af0"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsList_Internal_OldRequisitions", "GetUserApplicationRolesAndMore")){
// IsActiveDEV_NewVersionScreenDownloads = IsActiveDEV_NewScreenDownloads
result.outParamIsActiveDEV_NewVersionScreenDownloads=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_NewScreenDownloads])));
// GetCanUploadInvoices
localVars.resGetCanUploadInvoices.outParami_CanUpload = await Actions.ActionGetCanUploadInvoices(requestContext,cancellationToken);

// o_CanUploadInvoices = False
result.outParamo_CanUploadInvoices=false;

// UserRegion = GetUserRegionId()
result.outParamUserRegion=(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken));
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetUserApplicationRoleTempByConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempByConcepts_maxRecords = 0;
int datasetGetUserApplicationRoleTempByConcepts_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList,localVars.queryResGetUserApplicationRoleTempByConcepts_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetUserApplicationRoleTempByConcepts(requestContext,datasetGetUserApplicationRoleTempByConcepts_maxRecords,datasetGetUserApplicationRoleTempByConcepts_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamUserRolesList,(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_3d56036e64426be06ca36c503a3c39e0 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENApplicationRole.ssId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken)),cancellationToken);

// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// CorporativoRegionId = GetMR00RegionId()
result.outParamCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));
// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// AppRoleListText = AppRoleListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamAppRoleListText=((result.outParamAppRoleListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
result.outParamUserRolesList.Advance();
}

} finally {
result.outParamUserRolesList.EndIteration();
}

if((result.outParamIsCorporativoCxP)) {
// Query datasetGetSegmentAccGroupTelcelDirectionsByDepartment
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords = 0;
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,"",cancellationToken)),cancellationToken);

// Foreach GetSegmentAccGroupTelcelDirectionsByDepartment.List
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.StartIteration();
try {while (!((localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Eof))) {
// TelcelDirectionsListText = TelcelDirectionsListText + "," + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId + ","
result.outParamTelcelDirectionsListText=(((result.outParamTelcelDirectionsListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId))+",");
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Advance();
}

} finally {
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.EndIteration();
}

// LogMessage
await ExtendedActions.LogMessage(requestContext,result.outParamTelcelDirectionsListText,"TelcelDirectionIds",cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamAppRoleListText = result.outParamAppRoleListText;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
outParamo_CanUploadInvoices = result.outParamo_CanUploadInvoices;
outParamTelcelDirectionsListText = result.outParamTelcelDirectionsListText;
outParamCorporativoRegionId = result.outParamCorporativoRegionId;
outParamUserRegion = result.outParamUserRegion;
outParamIsActiveDEV_NewVersionScreenDownloads = result.outParamIsActiveDEV_NewVersionScreenDownloads;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamAppRoleListText,outParamIsCorporativoCxP,outParamo_CanUploadInvoices,outParamTelcelDirectionsListText,outParamCorporativoRegionId,outParamUserRegion,outParamIsActiveDEV_NewVersionScreenDownloads);
}
public class lcvGetRequisitions : VarsBag {
public RL_eb723ca0f1d2182a5703efa79cc03660 queryResGetRequisitionsCount_outParamList = new RL_eb723ca0f1d2182a5703efa79cc03660();
public long queryResGetRequisitionsCount_outParamCount = 0L;

public RL_2b41a595aabe414dbaa0e4db170b16f9 queryResGetRequisitionsList_outParamList = new RL_2b41a595aabe414dbaa0e4db170b16f9();
public long queryResGetRequisitionsList_outParamCount = 0L;

public Actions.lcoEncodeSortForSQL resEncodeSortForSQL =  new Actions.lcoEncodeSortForSQL();
public lcvGetRequisitions() {
}
}
public class lcoGetRequisitions : VarsBag {
public RL_a88cee033f640538574578015052224b outParamList = new RL_a88cee033f640538574578015052224b();

public int outParamTotalCount = 0;

public string outParamSortClause = "";

public lcoGetRequisitions() {
}
}
/// <summary>
/// Action <code>GetRequisitions</code> that represents the Service Studio action
///  <code>GetRequisitions</code> <p> Description: Query to fetch Requisitions.</p>
/// </summary>
public async Task<(RL_a88cee033f640538574578015052224b,int,string)> DataActionGetRequisitions(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_a88cee033f640538574578015052224b outParamList = default;
int outParamTotalCount = default;
string outParamSortClause = default;
lcoGetRequisitions result = new lcoGetRequisitions();
lcvGetRequisitions localVars = new lcvGetRequisitions();
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitions", "de2ee5a8-f3ca-4bc7-9cc4-b863dd9f51f0"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsList_Internal_OldRequisitions", "GetRequisitions")){
// EncodeSortForSQL
localVars.resEncodeSortForSQL.outParamSortForSQL = await Actions.ActionEncodeSortForSQL(requestContext,varLcl_TableSort,cancellationToken);

// SortClause = "ORDER BY " + EncodeSortForSQL.SortForSQL
result.outParamSortClause=("ORDER BY "+localVars.resEncodeSortForSQL.outParamSortForSQL);
// Query QueryGetRequisitionsList
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsList_maxRecords = 999999999;
if (QueryGetRequisitionsList_maxRecords < 1) QueryGetRequisitionsList_maxRecords = 1;
int QueryGetRequisitionsList_startIndex = 0;(localVars.queryResGetRequisitionsList_outParamList,localVars.queryResGetRequisitionsList_outParamCount) = await FuncDataActionGetRequisitions.QueryGetRequisitionsList(requestContext,QueryGetRequisitionsList_maxRecords,QueryGetRequisitionsList_startIndex,IterationMultiplicity.Single,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(model.clientVariables.ssOffsetUtc*(-1)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),varLcGetUserApplicationRolesAndMore.outParamAppRoleListText,varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.clientVariables.ssRequisitions_RequisitionSearch,model.clientVariables.ssRequisitions_ProjectId,model.clientVariables.ssRequisitions_UploadDate,model.clientVariables.ssRequisitions_CompanyId,model.clientVariables.ssRequisitions_AmountFrom,model.clientVariables.ssRequisitions_AmountTo,model.clientVariables.ssRequisitions_CostCenterId,model.clientVariables.ssRequisitions_SupplierId,model.clientVariables.ssRequisitions_RequisitionsStatusId,model.clientVariables.ssRequisitions_ApprovalStatusId,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),model.clientVariables.ssMaxRecords,varLcl_StartIndex,result.outParamSortClause,cancellationToken);

// Query QueryGetRequisitionsCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsCount_maxRecords = 1;
if (QueryGetRequisitionsCount_maxRecords < 1) QueryGetRequisitionsCount_maxRecords = 1;
int QueryGetRequisitionsCount_startIndex = 0;(localVars.queryResGetRequisitionsCount_outParamList,localVars.queryResGetRequisitionsCount_outParamCount) = await FuncDataActionGetRequisitions.QueryGetRequisitionsCount(requestContext,QueryGetRequisitionsCount_maxRecords,QueryGetRequisitionsCount_startIndex,IterationMultiplicity.Never,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(model.clientVariables.ssOffsetUtc*(-1)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),varLcGetUserApplicationRolesAndMore.outParamAppRoleListText,varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.clientVariables.ssRequisitions_RequisitionSearch,model.clientVariables.ssRequisitions_ProjectId,model.clientVariables.ssRequisitions_UploadDate,model.clientVariables.ssRequisitions_CompanyId,model.clientVariables.ssRequisitions_AmountFrom,model.clientVariables.ssRequisitions_AmountTo,model.clientVariables.ssRequisitions_CostCenterId,model.clientVariables.ssRequisitions_SupplierId,model.clientVariables.ssRequisitions_RequisitionsStatusId,model.clientVariables.ssRequisitions_ApprovalStatusId,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),cancellationToken);

// List = GetRequisitionsList.List
result.outParamList=(await RL_a88cee033f640538574578015052224b.ConvertAsync(localVars.queryResGetRequisitionsList_outParamList, new RL_a88cee033f640538574578015052224b(), async (RC_58280cdffc99dfa38a289f32f19bc2e2 source, RC_ed0b8e4be2720d34635f080b43e417d8 target, CancellationToken cancellationToken) => {
target.ssENApplicationRole = source.ssENApplicationRole;
target.ssENApprovalStatus = source.ssENApprovalStatus;
target.ssENCompany = source.ssENCompany;
target.ssENCostCenterSAP = source.ssENCostCenterSAP;
target.ssENCurrency = source.ssENCurrency;
target.ssSTDontShowAction = source.ssSTDontShowAction;
target.ssSTIsUserFromThisRegion = source.ssSTIsUserFromThisRegion;
target.ssENProject_Asset_Service = source.ssENProject_Asset_Service;
target.ssENRegion = source.ssENRegion;
target.ssENRequisition = source.ssENRequisition;
target.ssENRequisitionApproval = source.ssENRequisitionApproval;
target.ssENRequisitionApprovalLevel = source.ssENRequisitionApprovalLevel;
target.ssENRequisitionStatus = source.ssENRequisitionStatus;
target.ssENSegmentAccGroup = source.ssENSegmentAccGroup;
target.ssENSegmentAccGroupTelcelDir = source.ssENSegmentAccGroupTelcelDir;
target.ssENSupplier = source.ssENSupplier;
target.ssENTelcelDirection = source.ssENTelcelDirection;
target.ssSTUpdatedBy = source.ssSTUserUpdatedByName;
target.ssSTUserApplicantName = source.ssSTUserApplicantName;
return target;
}, cancellationToken));

// TotalCount = GetRequisitionsCount.List.Current.Integer.Value
result.outParamTotalCount=localVars.queryResGetRequisitionsCount_outParamList.CurrentRec.ssSTInteger.ssValue;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamTotalCount = result.outParamTotalCount;
outParamSortClause = result.outParamSortClause;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamTotalCount,outParamSortClause);
}


    public static class FuncDataActionGetRequisitionsFull {

private static async Task<RC_58280cdffc99dfa38a289f32f19bc2e2> QueryGetRequisitionsListReadDbAsync(RC_58280cdffc99dfa38a289f32f19bc2e2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read(r, ref index);
rec.ssENRequisitionApproval.Read(r, ref index);
rec.ssENRequisitionApprovalLevel.Read(r, ref index);
rec.ssENApprovalStatus.Read(r, ref index);
rec.ssENApplicationRole.Read(r, ref index);
rec.ssENRequisitionStatus.Read(r, ref index);
rec.ssENCompany.Read(r, ref index);
rec.ssSTUserApplicantName.Read(r, ref index);
rec.ssSTUserUpdatedByName.Read(r, ref index);
rec.ssENProject_Asset_Service.Read(r, ref index);
rec.ssENSupplier.Read(r, ref index);
rec.ssENRegion.Read(r, ref index);
rec.ssENCurrency.Read(r, ref index);
rec.ssENCostCenterSAP.Read(r, ref index);
rec.ssENTelcelDirection.Read(r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read(r, ref index);
rec.ssENSegmentAccGroup.Read(r, ref index);
rec.ssSTDontShowAction.Read(r, ref index);
rec.ssSTIsUserFromThisRegion.Read(r, ref index);
return rec;
}
// Query Function "GetRequisitionsList" k7+pIT+LYk6Z9Ogh_+NJYw of Action "GetRequisitionsFull"
public static async Task<(RL_2b41a595aabe414dbaa0e4db170b16f9,long)> QueryGetRequisitionsList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteRequisition_Name,long qpprRequisition_ProjectId,DateTime qpdaRequisition_UploadDate,long qpcoRequisition_CompanyId,decimal qpdeRequisition_AmountFrom,decimal qpdeRequisition_AmountTo,long qpcoRequisition_CostCenterId,long qpsuRequisition_SupplierId,int qpreRequisition_StatusId,int qpapRequisition_ApprovalStatusId,DateTime qpdaNullDate,long qploNullIdentifier,string qpteSortClause,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionsFull.GetRequisitionsList", "21a9bf93-8b3f-4e62-99f4-e821ffe34963");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionsFull.GetRequisitionsList", "21a9bf93-8b3f-4e62-99f4-e821ffe34963", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpapApprovalStatusPending", DbType.Int32, qpapApprovalStatusPending);
sqlCmd.CreateParameter("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameter("@qpteRequisition_Name", DbType.String, qpteRequisition_Name);
sqlCmd.CreateParameter("@qpprRequisition_ProjectId", DbType.Int64, qpprRequisition_ProjectId);
sqlCmd.CreateParameter("@qploNullIdentifier", DbType.Int64, qploNullIdentifier);
sqlCmd.CreateParameter("@qpdaRequisition_UploadDate", DbType.DateTime, qpdaRequisition_UploadDate);
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpcoRequisition_CompanyId", DbType.Int64, qpcoRequisition_CompanyId);
sqlCmd.CreateParameter("@qpdeRequisition_AmountFrom", DbType.Decimal, qpdeRequisition_AmountFrom);
sqlCmd.CreateParameter("@qpdeRequisition_AmountTo", DbType.Decimal, qpdeRequisition_AmountTo);
sqlCmd.CreateParameter("@qpcoRequisition_CostCenterId", DbType.Int64, qpcoRequisition_CostCenterId);
sqlCmd.CreateParameter("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
sqlCmd.CreateParameter("@qpreRequisition_StatusId", DbType.Int32, qpreRequisition_StatusId);
sqlCmd.CreateParameter("@qpapRequisition_ApprovalStatusId", DbType.Int32, qpapRequisition_ApprovalStatusId);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
string sql = "";
string advSql = "SELECT  \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"counter\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"maxdatefinishcapture\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetservice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectdescription\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"frequencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"issustainability\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"sustainabilityid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"businessvaluecategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"businessvaluesubcategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"distributionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontract\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscontractpending\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasdeposit\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasinsurance\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasadvancepayment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingservicetypeid_depr\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"servicedescription_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"invoiceusageid_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"serviceformatid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"retentionrate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"negotiatedexchangerate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentmethodid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymenttermsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isautomaticaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdbyapplicationrole\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"dateofcommitment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontractfileuploaded\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasupdateddateofcommitment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"submittedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isdonation\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"advwithoutinvoice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"wasadvwithoutinvoice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isadvanced\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"documenttypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscreatedbyanassistente\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasmultiupload\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentoptionsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentwaysid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"buydocnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"buydocposition\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"aprovalprocessid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"processtypecode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"approvalprocessversion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"currentlevel\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"maxlevel\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"startedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"finishedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"hasstartedaccounting\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entrajobtitle\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"departmentid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"managementid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"subdirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entraroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entrausername\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"needscontract\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledon_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isstartaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledon_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approveasareausuaria\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"ismandatory\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isreassigned\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"issubstitutefor\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscya\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscyaapproval\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isreq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isinv\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isareausuaria\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isareacxp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"canbulkapprovefolios\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"rfc\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"postalcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"cyaimport\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"fspuse\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedby\"") + ", \nCOALESCE(User_Applicant.\"name\", '') AS UserApplicantName, \nCOALESCE(UpdatedBy.\"name\", '') AS UserUpdatedByName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"isothers\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"updatedby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"tratamiento\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"conceptobusq_1_2\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"calle_numero\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"distrito\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"codigopostal_pobl_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"pais\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"region_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"idioma\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"telefono\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"extension\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"fax\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"cliente\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"soc_glasociada\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"clavedegrupo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"n_ident_fis_1\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"personafisica\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"ramo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"grupodeporte\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"email\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"regionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"divisionfi\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"commissionregion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfsp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfcp\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"symbol\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"minorunitdecimals\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"soc_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"div_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"area\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ce_coste\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"cebe\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"descripcion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"responsable\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ceco\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costesprim_reales_ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costessecund_reales_ind_debl\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ingresosreales_ind_debloqueo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"actualiz_comprom__ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costesprimariosplan_ind_debl\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costessecund_plan_ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ingresosplan_ind_debloqueo_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"autor\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"isactive\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"updatedby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"createdby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"groupname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"updatedby\"") + ", \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " IS NULL \n    OR \n    ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " <> @qpusGetUserId \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n            AND STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) = 0 \n        ) \n    ) \n) AS DontShowAction, \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n    OR \n    ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " IS NOT NULL \n    ) \n) AS IsUserFromThisRegion \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n@qpboCheckUserSession = 1 \nAND (@qpteRequisition_Name = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%' || @qpteRequisition_Name || '%')) \nAND (@qpprRequisition_ProjectId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " = @qpprRequisition_ProjectId) \nAND (@qpdaRequisition_UploadDate = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) = @qpdaRequisition_UploadDate) \nAND (@qpcoRequisition_CompanyId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " = @qpcoRequisition_CompanyId) \nAND (@qpdeRequisition_AmountFrom = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " >= @qpdeRequisition_AmountFrom) \nAND (@qpdeRequisition_AmountTo = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " <= @qpdeRequisition_AmountTo) \nAND (@qpcoRequisition_CostCenterId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " = @qpcoRequisition_CostCenterId) \nAND (@qpsuRequisition_SupplierId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " = @qpsuRequisition_SupplierId) \nAND (@qpreRequisition_StatusId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " = @qpreRequisition_StatusId) \nAND \n( \n    @qpapRequisition_ApprovalStatusId = @qploNullIdentifier \n    OR \n    ( \n        @qpapRequisition_ApprovalStatusId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n            OR \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        ) \n    ) \n) \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \n " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteSortClause)) + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".Code") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " DESC";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_2b41a595aabe414dbaa0e4db170b16f9 outParamList = new RL_2b41a595aabe414dbaa0e4db170b16f9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetRequisitionsListReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[19];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false});
opt[7] = new BitArray(new bool[] {false});
opt[8] = new BitArray(new bool[] {false});
opt[9] = new BitArray(new bool[] {false});
opt[10] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[11] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[12] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[13] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[14] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[15] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[16] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[17] = new BitArray(new bool[] {false, false, false, false, false});
opt[18] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionsFull.GetRequisitionsList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b41a595aabe414dbaa0e4db170b16f9 _tmp = new RL_2b41a595aabe414dbaa0e4db170b16f9();
_tmp.AlternateReadDbMethodAsync = QueryGetRequisitionsListReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitionsFull.GetRequisitionsList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2b41a595aabe414dbaa0e4db170b16f9)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsList in GetRequisitionsFull in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  {Company}.*,  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR  ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitionsFull in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  {Company}.*,  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR  ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitionsFull in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  {Company}.*,  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR  ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetUserApplicationRolesAndMore {

private static async Task<RC_6d4a92ad9e5239e9c12dd070f5b17d69> datasetGetRoleConceptReadDbAsync(RC_6d4a92ad9e5239e9c12dd070f5b17d69 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" mNZEBaVyk0WTRzZMuJAQLA of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetRoleConcept", "0544d698-72a5-4593-9347-364cb890102c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetRoleConcept", "0544d698-72a5-4593-9347-364cb890102c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/DataActions.o0UKgqrtgUGXyOnUkwNK8A/NodesNotShownInESpaceTree.mNZEBaVyk0WTRzZMuJAQLA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole63\".\"code\" o1, \"enapplicationrole63\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole63\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion142\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept22\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal112\" Inner JOIN {User} \"enuser183\" ON (\"enuser_extended_internal112\".\"id\" = \"enuser183\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole58\" ON (\"enuser_extended_internal112\".\"jobtitle\" = \"enentrarole58\".\"rolename\"))  Left JOIN {Region} \"enregion142\" ON (\"enuser_extended_internal112\".\"regionid\" = \"enregion142\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept22\" ON (\"enentrarole58\".\"id\" = \"enroleconcept22\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole63\" ON (\"enroleconcept22\".\"applicationroleid\" = \"enapplicationrole63\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser183\".\"id\" = @qpusUser_Id) AND (\"enuser183\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser183\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept22\".\"conceptid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")");
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
RL_721bdfcca4a4edbce82baece8dfe837b outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_721bdfcca4a4edbce82baece8dfe837b _tmp = new RL_721bdfcca4a4edbce82baece8dfe837b();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_721bdfcca4a4edbce82baece8dfe837b)_tmp;
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

private static async Task<RC_3d56036e64426be06ca36c503a3c39e0> datasetGetUserApplicationRoleTempByConceptsReadDbAsync(RC_3d56036e64426be06ca36c503a3c39e0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUserApplicationRoleTemp.Read( r, ref index);
rec.ssENUserApplicationRoleTempByConcept.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleTempByConcepts" +tloLiHL+keYyEzybwQTgA of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_b9107f331631f30bcef7fe9d900d99ae,long)> datasetGetUserApplicationRoleTempByConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "2e68d9fa-cb21-47fa-98c8-4cf26f041380");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "2e68d9fa-cb21-47fa-98c8-4cf26f041380", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/DataActions.o0UKgqrtgUGXyOnUkwNK8A/NodesNotShownInESpaceTree.+tloLiHL+keYyEzybwQTgA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole64\".\"id\" o0, \"enapplicationrole64\".\"code\" o1, \"enapplicationrole64\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM (({UserApplicationRoleTempByConcept} \"enuserapplicationroletempbyconcept6\" Left JOIN {UserApplicationRoleTemp} \"enuserapplicationroletemp10\" ON (\"enuserapplicationroletempbyconcept6\".\"userapplicationroletempid\" = \"enuserapplicationroletemp10\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole64\" ON (\"enuserapplicationroletempbyconcept6\".\"applicationroleid\" = \"enapplicationrole64\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp10\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp10\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp10\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp10\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enuserapplicationroletempbyconcept6\".\"conceptid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")");
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
RL_b9107f331631f30bcef7fe9d900d99ae outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempByConceptsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b9107f331631f30bcef7fe9d900d99ae _tmp = new RL_b9107f331631f30bcef7fe9d900d99ae();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempByConceptsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b9107f331631f30bcef7fe9d900d99ae)_tmp;
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

private static async Task<RC_dbac6e35b37e102dd601262a956066d2> datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync(RC_dbac6e35b37e102dd601262a956066d2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
return rec;
}
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" Iiks_odRB0aI5zxSgDqhWQ of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "fe2c2922-5187-4607-88e7-3c52803aa159");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "fe2c2922-5187-4607-88e7-3c52803aa159", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.1KJ5wUFye0q8d6VWzk7Fsg/DataActions.o0UKgqrtgUGXyOnUkwNK8A/NodesNotShownInESpaceTree.Iiks_odRB0aI5zxSgDqhWQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir6\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup6\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir6\" ON (\"ensegmentaccgroup6\".\"id\" = \"ensegmentaccgrouptelceldir6\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper((trim(\"ensegmentaccgroup6\".\"groupname\")))) collate \"default\") like caseaccent_normalize((Upper((trim(@qpteSegmentAccGroup_GroupName)))) collate \"default\")) AND (\"ensegmentaccgroup6\".\"isactive\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteSegmentAccGroup_GroupName", DbType.String, qpteSegmentAccGroup_GroupName);
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
RL_4b6f9359ce9887bc6f37c96ecf62266d outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4b6f9359ce9887bc6f37c96ecf62266d _tmp = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
_tmp.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4b6f9359ce9887bc6f37c96ecf62266d)_tmp;
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
public static class FuncDataActionGetRequisitions {

// Query Function "GetRequisitionsCount" SrUdezhlB0CWUDR2aKpWcA of Action "GetRequisitions"
public static async Task<(RL_eb723ca0f1d2182a5703efa79cc03660,long)> QueryGetRequisitionsCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteRequisition_Name,long qpprRequisition_ProjectId,DateTime qpdaRequisition_UploadDate,long qpcoRequisition_CompanyId,decimal qpdeRequisition_AmountFrom,decimal qpdeRequisition_AmountTo,long qpcoRequisition_CostCenterId,long qpsuRequisition_SupplierId,int qpreRequisition_StatusId,int qpapRequisition_ApprovalStatusId,DateTime qpdaNullDate,long qploNullIdentifier,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsCount", "7b1db54a-6538-4007-9650-347668aa5670");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsCount", "7b1db54a-6538-4007-9650-347668aa5670", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
sqlCmd.CreateParameter("@qpapApprovalStatusPending", DbType.Int32, qpapApprovalStatusPending);
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCmd.CreateParameter("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameter("@qpteRequisition_Name", DbType.String, qpteRequisition_Name);
sqlCmd.CreateParameter("@qpprRequisition_ProjectId", DbType.Int64, qpprRequisition_ProjectId);
sqlCmd.CreateParameter("@qploNullIdentifier", DbType.Int64, qploNullIdentifier);
sqlCmd.CreateParameter("@qpdaRequisition_UploadDate", DbType.DateTime, qpdaRequisition_UploadDate);
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpcoRequisition_CompanyId", DbType.Int64, qpcoRequisition_CompanyId);
sqlCmd.CreateParameter("@qpdeRequisition_AmountFrom", DbType.Decimal, qpdeRequisition_AmountFrom);
sqlCmd.CreateParameter("@qpdeRequisition_AmountTo", DbType.Decimal, qpdeRequisition_AmountTo);
sqlCmd.CreateParameter("@qpcoRequisition_CostCenterId", DbType.Int64, qpcoRequisition_CostCenterId);
sqlCmd.CreateParameter("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
sqlCmd.CreateParameter("@qpreRequisition_StatusId", DbType.Int32, qpreRequisition_StatusId);
sqlCmd.CreateParameter("@qpapRequisition_ApprovalStatusId", DbType.Int32, qpapRequisition_ApprovalStatusId);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
string sql = "";
string advSql = "SELECT  \nCOUNT( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ") \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n@qpboCheckUserSession = 1 \nAND (@qpteRequisition_Name = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%' || @qpteRequisition_Name || '%')) \nAND (@qpprRequisition_ProjectId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " = @qpprRequisition_ProjectId) \nAND (@qpdaRequisition_UploadDate = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) = @qpdaRequisition_UploadDate) \nAND (@qpcoRequisition_CompanyId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " = @qpcoRequisition_CompanyId) \nAND (@qpdeRequisition_AmountFrom = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " >= @qpdeRequisition_AmountFrom) \nAND (@qpdeRequisition_AmountTo = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " <= @qpdeRequisition_AmountTo) \nAND (@qpcoRequisition_CostCenterId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " = @qpcoRequisition_CostCenterId) \nAND (@qpsuRequisition_SupplierId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " = @qpsuRequisition_SupplierId) \nAND (@qpreRequisition_StatusId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " = @qpreRequisition_StatusId) \nAND \n( \n    @qpapRequisition_ApprovalStatusId = @qploNullIdentifier \n    OR \n    ( \n        @qpapRequisition_ApprovalStatusId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n            OR \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        ) \n    ) \n) \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n)";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsCount.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb723ca0f1d2182a5703efa79cc03660)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsCount in GetRequisitions in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   COUNT({Requisition}.[Id])    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @ApprovalStatusPending          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )              OR {RequisitionA ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsCount in GetRequisitions in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   COUNT({Requisition}.[Id])    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @ApprovalStatusPending          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )              OR {RequisitionA ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsCount in GetRequisitions in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   COUNT({Requisition}.[Id])    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @ApprovalStatusPending          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )              OR {RequisitionA ...): " + aqExcep.Message));
}
}
}

private static async Task<RC_58280cdffc99dfa38a289f32f19bc2e2> QueryGetRequisitionsListReadDbAsync(RC_58280cdffc99dfa38a289f32f19bc2e2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read(r, ref index);
rec.ssENRequisitionApproval.Read(r, ref index);
rec.ssENRequisitionApprovalLevel.Read(r, ref index);
rec.ssENApprovalStatus.Read(r, ref index);
rec.ssENApplicationRole.Read(r, ref index);
rec.ssENRequisitionStatus.Read(r, ref index);
rec.ssENCompany.Read(r, ref index);
rec.ssSTUserApplicantName.Read(r, ref index);
rec.ssSTUserUpdatedByName.Read(r, ref index);
rec.ssENProject_Asset_Service.Read(r, ref index);
rec.ssENSupplier.Read(r, ref index);
rec.ssENRegion.Read(r, ref index);
rec.ssENCurrency.Read(r, ref index);
rec.ssENCostCenterSAP.Read(r, ref index);
rec.ssENTelcelDirection.Read(r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read(r, ref index);
rec.ssENSegmentAccGroup.Read(r, ref index);
rec.ssSTDontShowAction.Read(r, ref index);
rec.ssSTIsUserFromThisRegion.Read(r, ref index);
return rec;
}
// Query Function "GetRequisitionsList" CEg9u46p_EiIhLnbLEIQtw of Action "GetRequisitions"
public static async Task<(RL_2b41a595aabe414dbaa0e4db170b16f9,long)> QueryGetRequisitionsList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteRequisition_Name,long qpprRequisition_ProjectId,DateTime qpdaRequisition_UploadDate,long qpcoRequisition_CompanyId,decimal qpdeRequisition_AmountFrom,decimal qpdeRequisition_AmountTo,long qpcoRequisition_CostCenterId,long qpsuRequisition_SupplierId,int qpreRequisition_StatusId,int qpapRequisition_ApprovalStatusId,DateTime qpdaNullDate,long qploNullIdentifier,int qpinMaxRecords,int qpinStartIndex,string qpteSortClause,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsList", "bb3d4808-a98e-48fc-8884-b9db2c4210b7");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsList", "bb3d4808-a98e-48fc-8884-b9db2c4210b7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpapApprovalStatusPending", DbType.Int32, qpapApprovalStatusPending);
sqlCmd.CreateParameter("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameter("@qpteRequisition_Name", DbType.String, qpteRequisition_Name);
sqlCmd.CreateParameter("@qpprRequisition_ProjectId", DbType.Int64, qpprRequisition_ProjectId);
sqlCmd.CreateParameter("@qploNullIdentifier", DbType.Int64, qploNullIdentifier);
sqlCmd.CreateParameter("@qpdaRequisition_UploadDate", DbType.DateTime, qpdaRequisition_UploadDate);
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpcoRequisition_CompanyId", DbType.Int64, qpcoRequisition_CompanyId);
sqlCmd.CreateParameter("@qpdeRequisition_AmountFrom", DbType.Decimal, qpdeRequisition_AmountFrom);
sqlCmd.CreateParameter("@qpdeRequisition_AmountTo", DbType.Decimal, qpdeRequisition_AmountTo);
sqlCmd.CreateParameter("@qpcoRequisition_CostCenterId", DbType.Int64, qpcoRequisition_CostCenterId);
sqlCmd.CreateParameter("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
sqlCmd.CreateParameter("@qpreRequisition_StatusId", DbType.Int32, qpreRequisition_StatusId);
sqlCmd.CreateParameter("@qpapRequisition_ApprovalStatusId", DbType.Int32, qpapRequisition_ApprovalStatusId);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
sqlCmd.CreateParameter("@qpinStartIndex", DbType.Int32, qpinStartIndex);
string sql = "";
string advSql = "SELECT  \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"counter\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"maxdatefinishcapture\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetservice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectdescription\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"frequencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"issustainability\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"sustainabilityid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"businessvaluecategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"businessvaluesubcategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"distributionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontract\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscontractpending\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasdeposit\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasinsurance\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasadvancepayment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingservicetypeid_depr\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"servicedescription_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"invoiceusageid_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"serviceformatid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"retentionrate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"negotiatedexchangerate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentmethodid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymenttermsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isautomaticaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdbyapplicationrole\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"dateofcommitment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontractfileuploaded\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasupdateddateofcommitment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"submittedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isdonation\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"advwithoutinvoice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"wasadvwithoutinvoice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isadvanced\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"documenttypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscreatedbyanassistente\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasmultiupload\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentoptionsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentwaysid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"buydocnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"buydocposition\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"aprovalprocessid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"processtypecode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"approvalprocessversion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"currentlevel\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"maxlevel\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"startedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"finishedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"hasstartedaccounting\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entrajobtitle\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"departmentid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"managementid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"subdirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entraroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entrausername\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"needscontract\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledon_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isstartaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledon_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approveasareausuaria\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"ismandatory\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isreassigned\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"issubstitutefor\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscya\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscyaapproval\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isreq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isinv\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isareausuaria\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isareacxp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"canbulkapprovefolios\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"rfc\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"postalcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"cyaimport\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"fspuse\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedby\"") + ", \nCOALESCE(User_Applicant.\"name\", '') AS UserApplicantName, \nCOALESCE(UpdatedBy.\"name\", '') AS UserUpdatedByName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"isothers\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"updatedby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"tratamiento\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"conceptobusq_1_2\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"calle_numero\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"distrito\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"codigopostal_pobl_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"pais\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"region_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"idioma\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"telefono\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"extension\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"fax\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"cliente\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"soc_glasociada\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"clavedegrupo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"n_ident_fis_1\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"personafisica\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"ramo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"grupodeporte\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"email\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"regionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"divisionfi\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"commissionregion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfsp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfcp\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"symbol\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"minorunitdecimals\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"soc_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"div_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"area\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ce_coste\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"cebe\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"descripcion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"responsable\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ceco\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costesprim_reales_ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costessecund_reales_ind_debl\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ingresosreales_ind_debloqueo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"actualiz_comprom__ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costesprimariosplan_ind_debl\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costessecund_plan_ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ingresosplan_ind_debloqueo_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"autor\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"isactive\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"updatedby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"createdby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"groupname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"updatedby\"") + ", \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " IS NULL \n    OR \n    ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " <> @qpusGetUserId \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n            AND STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) = 0 \n        ) \n    ) \n) AS DontShowAction, \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n    OR \n    ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " IS NOT NULL \n    ) \n) AS IsUserFromThisRegion \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n@qpboCheckUserSession = 1 \nAND (@qpteRequisition_Name = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%' || @qpteRequisition_Name || '%')) \nAND (@qpprRequisition_ProjectId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " = @qpprRequisition_ProjectId) \nAND (@qpdaRequisition_UploadDate = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) = @qpdaRequisition_UploadDate) \nAND (@qpcoRequisition_CompanyId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " = @qpcoRequisition_CompanyId) \nAND (@qpdeRequisition_AmountFrom = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " >= @qpdeRequisition_AmountFrom) \nAND (@qpdeRequisition_AmountTo = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " <= @qpdeRequisition_AmountTo) \nAND (@qpcoRequisition_CostCenterId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " = @qpcoRequisition_CostCenterId) \nAND (@qpsuRequisition_SupplierId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " = @qpsuRequisition_SupplierId) \nAND (@qpreRequisition_StatusId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " = @qpreRequisition_StatusId) \nAND \n( \n    @qpapRequisition_ApprovalStatusId = @qploNullIdentifier \n    OR \n    ( \n        @qpapRequisition_ApprovalStatusId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n            OR \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        ) \n    ) \n) \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \n " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteSortClause)) + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".Code") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " DESC \nLIMIT @qpinMaxRecords  \nOFFSET @qpinStartIndex";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_2b41a595aabe414dbaa0e4db170b16f9 outParamList = new RL_2b41a595aabe414dbaa0e4db170b16f9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetRequisitionsListReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[19];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false});
opt[7] = new BitArray(new bool[] {false});
opt[8] = new BitArray(new bool[] {false});
opt[9] = new BitArray(new bool[] {false});
opt[10] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[11] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[12] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[13] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[14] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[15] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[16] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[17] = new BitArray(new bool[] {false, false, false, false, false});
opt[18] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b41a595aabe414dbaa0e4db170b16f9 _tmp = new RL_2b41a595aabe414dbaa0e4db170b16f9();
_tmp.AlternateReadDbMethodAsync = QueryGetRequisitionsListReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.GetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2b41a595aabe414dbaa0e4db170b16f9)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsList in GetRequisitions in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  {Company}.*,  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR  ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitions in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  {Company}.*,  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR  ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitions in Wb_RequisitionsList_Internal_OldRequisitions in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  {Company}.*,  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR  ...): " + aqExcep.Message));
}
}
}
}


}
