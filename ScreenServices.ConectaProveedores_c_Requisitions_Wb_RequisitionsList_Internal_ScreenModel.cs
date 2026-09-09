using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel).Namespace);

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
public AggregateRecord<RL_7324330f004cfb528140f21030a5e90f> ScreenDataSetGetRequisitionStatuses;
public AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Model varLcGetRequisitionsFull;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Model varLcGetRequisitions;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel(bool varLcl_ShowFilters, string varLcl_TableSort, int varLcl_StartIndex, long varLcl_ApplicationRoleIdForAggregate, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetRequisitions, int varLcl_CountAfterFetchGetRequisitions, bool varLcl_ShowCancelPopup, string varLcl_AmountFromText, string varLcl_AmountToText, long varLcl_RequisitonToCancel, bool varLcl_ShowScreenTableDownloads, BasicTypeList<long> varLcl_RequisitionsListInternalIdList, bool varLcIsListFullNeedRefresh, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses, AggregateRecord<RL_7324330f004cfb528140f21030a5e90f> ScreenDataSetGetRequisitionStatuses, AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Model varLcGetRequisitionsFull, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Model varLcGetRequisitions, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ShowFilters", "l_TableSort", "l_StartIndex", "l_ApplicationRoleIdForAggregate", "l_IsAllowSelectApplicationRoles", "l_ReInvokeToggler", "l_ColumnJSONVarGetRequisitions", "l_CountAfterFetchGetRequisitions", "l_ShowCancelPopup", "l_AmountFromText", "l_AmountToText", "l_RequisitonToCancel", "l_ShowScreenTableDownloads", "l_RequisitionsListInternalIdList", "IsListFullNeedRefresh", "GetCompanies", "GetApprovalStatuses", "GetRequisitionStatuses", "GetEntraRole", "GetProjectAssetServices", "GetCostCenters", "GetUserApplicationRolesAndMore", "GetRequisitionsFull", "GetRequisitions", "ClientVars"}, new string[] {"varLcl_ShowFilters", "varLcl_TableSort", "varLcl_StartIndex", "varLcl_ApplicationRoleIdForAggregate", "varLcl_IsAllowSelectApplicationRoles", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetRequisitions", "varLcl_CountAfterFetchGetRequisitions", "varLcl_ShowCancelPopup", "varLcl_AmountFromText", "varLcl_AmountToText", "varLcl_RequisitonToCancel", "varLcl_ShowScreenTableDownloads", "varLcl_RequisitionsListInternalIdList", "varLcIsListFullNeedRefresh", "ScreenDataSetGetCompanies", "ScreenDataSetGetApprovalStatuses", "ScreenDataSetGetRequisitionStatuses", "ScreenDataSetGetEntraRole", "ScreenDataSetGetProjectAssetServices", "ScreenDataSetGetCostCenters", "varLcGetUserApplicationRolesAndMore", "varLcGetRequisitionsFull", "varLcGetRequisitions", "clientVariables"});
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
this.ScreenDataSetGetRequisitionStatuses = ScreenDataSetGetRequisitionStatuses;
this.ScreenDataSetGetEntraRole = ScreenDataSetGetEntraRole;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.ScreenDataSetGetCostCenters = ScreenDataSetGetCostCenters;
this.varLcGetUserApplicationRolesAndMore = varLcGetUserApplicationRolesAndMore;
this.varLcGetRequisitionsFull = varLcGetRequisitionsFull;
this.varLcGetRequisitions = varLcGetRequisitions;
this.clientVariables = clientVariables;
}



    
// Query Function "GetCompanies" hOH3C8a5xUKQw38CuMLOZQ of Action "Wb_RequisitionsList_Internal"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetCompanies", "0bf7e184-b9c6-42c5-90c3-7f02b8c2ce65");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal","c_Requisitions.Wb_RequisitionsList_Internal.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/ScreenDataSets.hOH3C8a5xUKQw38CuMLOZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany52\".\"id\" o0, NULL o1, \"encompany52\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany52\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetCompanies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetCompanies.List", cancellationToken: cancellationToken);
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

// Query Function "GetApprovalStatuses" h55ZLvnTbkif9SEVq3pFSw of Action "Wb_RequisitionsList_Internal"
public static async Task<(RL_51a4e63e168a01408e3f55c611518e13,long)> datasetGetApprovalStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetApprovalStatuses", "2e599e87-d3f9-486e-9ff5-2115ab7a454b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal","c_Requisitions.Wb_RequisitionsList_Internal.GetApprovalStatuses");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/ScreenDataSets.h55ZLvnTbkif9SEVq3pFSw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus17\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enapprovalstatus17\".\"labeles\" o9");
fromBuilder.Append(" FROM {ApprovalStatus} \"enapprovalstatus17\"");
whereBuilder.Append(" WHERE (\"enapprovalstatus17\".\"is_active\" = 1) AND (\"enapprovalstatus17\".\"isreq\" = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalstatus17\".\"order\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetApprovalStatuses.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetApprovalStatuses.List", cancellationToken: cancellationToken);
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

// Query Function "GetRequisitionStatuses" PyQxjMDOgE2tJ78_e8ZXhg of Action "Wb_RequisitionsList_Internal"
public static async Task<(RL_7324330f004cfb528140f21030a5e90f,long)> datasetGetRequisitionStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionStatuses", "8c31243f-cec0-4d80-ad27-bf3f7bc65786");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal","c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionStatuses");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/ScreenDataSets.PyQxjMDOgE2tJ78_e8ZXhg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionstatus5\".\"id\" o0, \"enrequisitionstatus5\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {RequisitionStatus} \"enrequisitionstatus5\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionStatuses.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionStatuses.List", cancellationToken: cancellationToken);
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
// Query Function "GetEntraRole" ESimosvMu0+J3ou4wJqoPQ of Action "Wb_RequisitionsList_Internal"
public static async Task<(RL_ea7d18baeeefa57d5c86706d7efb98e9,long)> datasetGetEntraRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetEntraRole", "a2a62811-cccb-4fbb-89de-8bb8c09aa83d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal","c_Requisitions.Wb_RequisitionsList_Internal.GetEntraRole");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/ScreenDataSets.ESimosvMu0+J3ou4wJqoPQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"enentrarole61\".\"issolicitante\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal116\" Inner JOIN {EntraRole} \"enentrarole61\" ON (\"enentrarole61\".\"rolename\" = \"enuser_extended_internal116\".\"jobtitle\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal116\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal116\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal116\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetEntraRole.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetEntraRole.List", cancellationToken: cancellationToken);
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

// Query Function "GetProjectAssetServices" 8Xft8kqgTUi+jSg5SwStYg of Action "Wb_RequisitionsList_Internal"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetProjectAssetServices", "f2ed77f1-a04a-484d-be8d-28394b04ad62");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal","c_Requisitions.Wb_RequisitionsList_Internal.GetProjectAssetServices");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/ScreenDataSets.8Xft8kqgTUi+jSg5SwStYg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service23\".\"id\" o0, \"enproject_asset_service23\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service23\"");
orderByBuilder.Append(" ORDER BY \"enproject_asset_service23\".\"description\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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

// Query Function "GetCostCenters" H1a9+SyPsECuZObiArG3_A of Action "Wb_RequisitionsList_Internal"
public static async Task<(RL_ec55ed22dae89075d036f3a863173164,long)> datasetGetCostCenters(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetCostCenters", "f9bd561f-8f2c-40b0-ae64-e6e202b1b7fc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Internal","c_Requisitions.Wb_RequisitionsList_Internal.GetCostCenters");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/ScreenDataSets.H1a9+SyPsECuZObiArG3_A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encostcentersap20\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"encostcentersap20\".\"ce_coste\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM {CostCenterSAP} \"encostcentersap20\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetCostCenters.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetCostCenters.List", cancellationToken: cancellationToken);
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


    public class lcvGetUserApplicationRolesAndMore : VarsBag {
public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public Actions.lcoGetCanUploadInvoices resGetCanUploadInvoices =  new Actions.lcoGetCanUploadInvoices();
public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public RL_b9107f331631f30bcef7fe9d900d99ae queryResGetUserApplicationRoleTempByConcepts_outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
public long queryResGetUserApplicationRoleTempByConcepts_outParamCount = 0L;

public int resFindIsCorporativoCxP_outParamPosition = 0;

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
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRolesAndMore", "4cdcf4e2-872f-400c-988c-8827b50c5e47"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsList_Internal", "GetUserApplicationRolesAndMore")){
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
public class lcvGetRequisitionsFull : VarsBag {
public RL_9ede71d9c6d03aba8c5ee336f1d0813f queryResGetRequisitionsList_outParamList = new RL_9ede71d9c6d03aba8c5ee336f1d0813f();
public long queryResGetRequisitionsList_outParamCount = 0L;

public Actions.lcoEncodeSortForSQL resEncodeSortForSQL =  new Actions.lcoEncodeSortForSQL();
public lcvGetRequisitionsFull() {
}
}
public class lcoGetRequisitionsFull : VarsBag {
public RL_5cba7bdf2f2718a3daba441ead02b59b outParamList = new RL_5cba7bdf2f2718a3daba441ead02b59b();

public string outParamSortClause = "";

public lcoGetRequisitionsFull() {
}
}
/// <summary>
/// Action <code>GetRequisitionsFull</code> that represents the Service Studio action
///  <code>GetRequisitionsFull</code> <p> Description: Query to fetch Requisitions.</p>
/// </summary>
public async Task<(RL_5cba7bdf2f2718a3daba441ead02b59b,string)> DataActionGetRequisitionsFull(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_5cba7bdf2f2718a3daba441ead02b59b outParamList = default;
string outParamSortClause = default;
lcoGetRequisitionsFull result = new lcoGetRequisitionsFull();
lcvGetRequisitionsFull localVars = new lcvGetRequisitionsFull();
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitionsFull", "9b3d52ef-aea0-4137-8406-9933013f9fd8"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsList_Internal", "GetRequisitionsFull")){
// EncodeSortForSQL
localVars.resEncodeSortForSQL.outParamSortForSQL = await Actions.ActionEncodeSortForSQL(requestContext,varLcl_TableSort,cancellationToken);

// SortClause = "ORDER BY " + EncodeSortForSQL.SortForSQL
result.outParamSortClause=("ORDER BY "+localVars.resEncodeSortForSQL.outParamSortForSQL);
// Query QueryGetRequisitionsList
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsList_maxRecords = 999999999;
if (QueryGetRequisitionsList_maxRecords < 1) QueryGetRequisitionsList_maxRecords = 1;
int QueryGetRequisitionsList_startIndex = 0;(localVars.queryResGetRequisitionsList_outParamList,localVars.queryResGetRequisitionsList_outParamCount) = await FuncDataActionGetRequisitionsFull.QueryGetRequisitionsList(requestContext,QueryGetRequisitionsList_maxRecords,QueryGetRequisitionsList_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(model.clientVariables.ssOffsetUtc*(-1)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),varLcGetUserApplicationRolesAndMore.outParamAppRoleListText,varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.clientVariables.ssRequisitions_RequisitionSearch,model.clientVariables.ssRequisitions_ProjectId,model.clientVariables.ssRequisitions_UploadDate,model.clientVariables.ssRequisitions_CompanyId,model.clientVariables.ssRequisitions_AmountFrom,model.clientVariables.ssRequisitions_AmountTo,model.clientVariables.ssRequisitions_CostCenterId,model.clientVariables.ssRequisitions_SupplierId,model.clientVariables.ssRequisitions_RequisitionsStatusId,model.clientVariables.ssRequisitions_ApprovalStatusId,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),result.outParamSortClause,cancellationToken);

// List = GetRequisitionsList.List
result.outParamList=(await RL_5cba7bdf2f2718a3daba441ead02b59b.ConvertAsync(localVars.queryResGetRequisitionsList_outParamList, new RL_5cba7bdf2f2718a3daba441ead02b59b(), async (RC_065973fb437991de65b823e42c10f6b8 source, ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure target, CancellationToken cancellationToken) => {
target = source;
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
public class lcvGetRequisitions : VarsBag {
public Actions.lcoEncodeSortForSQL resEncodeSortForSQL =  new Actions.lcoEncodeSortForSQL();
public RL_6afe7592bf936cbdcd13fc348b4ae3a3 queryResGetRequisitionsList_outParamList = new RL_6afe7592bf936cbdcd13fc348b4ae3a3();
public long queryResGetRequisitionsList_outParamCount = 0L;

public RL_eb723ca0f1d2182a5703efa79cc03660 queryResGetRequisitionsListCount_outParamList = new RL_eb723ca0f1d2182a5703efa79cc03660();
public long queryResGetRequisitionsListCount_outParamCount = 0L;

public lcvGetRequisitions() {
}
}
public class lcoGetRequisitions : VarsBag {
public RL_00620735fb8e7105f7e39e5561e40930 outParamList = new RL_00620735fb8e7105f7e39e5561e40930();

public int outParamTotalCount = 0;

public string outParamSortClause = "";

public lcoGetRequisitions() {
}
}
/// <summary>
/// Action <code>GetRequisitions</code> that represents the Service Studio action
///  <code>GetRequisitions</code> <p> Description: Query to fetch Requisitions.</p>
/// </summary>
public async Task<(RL_00620735fb8e7105f7e39e5561e40930,int,string)> DataActionGetRequisitions(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_00620735fb8e7105f7e39e5561e40930 outParamList = default;
int outParamTotalCount = default;
string outParamSortClause = default;
lcoGetRequisitions result = new lcoGetRequisitions();
lcvGetRequisitions localVars = new lcvGetRequisitions();
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitions", "cbc208bf-68cb-40d0-8539-4ffe7213232f"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsList_Internal", "GetRequisitions")){
// EncodeSortForSQL
localVars.resEncodeSortForSQL.outParamSortForSQL = await Actions.ActionEncodeSortForSQL(requestContext,varLcl_TableSort,cancellationToken);

// SortClause = "ORDER BY " + EncodeSortForSQL.SortForSQL
result.outParamSortClause=("ORDER BY "+localVars.resEncodeSortForSQL.outParamSortForSQL);
// Query QueryGetRequisitionsList
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsList_maxRecords = 999999999;
if (QueryGetRequisitionsList_maxRecords < 1) QueryGetRequisitionsList_maxRecords = 1;
int QueryGetRequisitionsList_startIndex = 0;(localVars.queryResGetRequisitionsList_outParamList,localVars.queryResGetRequisitionsList_outParamCount) = await FuncDataActionGetRequisitions.QueryGetRequisitionsList(requestContext,QueryGetRequisitionsList_maxRecords,QueryGetRequisitionsList_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(model.clientVariables.ssOffsetUtc*(-1)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),varLcGetUserApplicationRolesAndMore.outParamAppRoleListText,varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.clientVariables.ssRequisitions_RequisitionSearch,model.clientVariables.ssRequisitions_ProjectId,model.clientVariables.ssRequisitions_UploadDate,model.clientVariables.ssRequisitions_CompanyId,model.clientVariables.ssRequisitions_AmountFrom,model.clientVariables.ssRequisitions_AmountTo,model.clientVariables.ssRequisitions_CostCenterId,model.clientVariables.ssRequisitions_SupplierId,model.clientVariables.ssRequisitions_RequisitionsStatusId,model.clientVariables.ssRequisitions_ApprovalStatusId,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),model.clientVariables.ssMaxRecords,varLcl_StartIndex,result.outParamSortClause,cancellationToken);

// Query QueryGetRequisitionsListCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsListCount_maxRecords = 1;
if (QueryGetRequisitionsListCount_maxRecords < 1) QueryGetRequisitionsListCount_maxRecords = 1;
int QueryGetRequisitionsListCount_startIndex = 0;(localVars.queryResGetRequisitionsListCount_outParamList,localVars.queryResGetRequisitionsListCount_outParamCount) = await FuncDataActionGetRequisitions.QueryGetRequisitionsListCount(requestContext,QueryGetRequisitionsListCount_maxRecords,QueryGetRequisitionsListCount_startIndex,IterationMultiplicity.Never,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(model.clientVariables.ssOffsetUtc*(-1)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),varLcGetUserApplicationRolesAndMore.outParamAppRoleListText,varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.clientVariables.ssRequisitions_RequisitionSearch,model.clientVariables.ssRequisitions_ProjectId,model.clientVariables.ssRequisitions_UploadDate,model.clientVariables.ssRequisitions_CompanyId,model.clientVariables.ssRequisitions_AmountFrom,model.clientVariables.ssRequisitions_AmountTo,model.clientVariables.ssRequisitions_CostCenterId,model.clientVariables.ssRequisitions_SupplierId,model.clientVariables.ssRequisitions_RequisitionsStatusId,model.clientVariables.ssRequisitions_ApprovalStatusId,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),cancellationToken);

// List = GetRequisitionsList.List
result.outParamList=(await RL_00620735fb8e7105f7e39e5561e40930.ConvertAsync(localVars.queryResGetRequisitionsList_outParamList, new RL_00620735fb8e7105f7e39e5561e40930(), async (RC_a6a6e5f593e9e8b5f977af7779bd66f0 source, ST_23b064f7387b135df7725dcd963884ceStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// TotalCount = GetRequisitionsListCount.List.Current.Integer.Value
result.outParamTotalCount=localVars.queryResGetRequisitionsListCount_outParamList.CurrentRec.ssSTInteger.ssValue;
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
// Query Function "GetRoleConcept" lIeQF0IRmEKRyCM4k3aG9w of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetRoleConcept", "17908794-1142-4298-91c8-2338937686f7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetRoleConcept", "17908794-1142-4298-91c8-2338937686f7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/DataActions.4vTcTC+HDECYjIgntQxeRw/NodesNotShownInESpaceTree.lIeQF0IRmEKRyCM4k3aG9w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole66\".\"code\" o1, \"enapplicationrole66\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole66\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion146\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept24\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal117\" Inner JOIN {User} \"enuser186\" ON (\"enuser_extended_internal117\".\"id\" = \"enuser186\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole62\" ON (\"enuser_extended_internal117\".\"jobtitle\" = \"enentrarole62\".\"rolename\"))  Left JOIN {Region} \"enregion146\" ON (\"enuser_extended_internal117\".\"regionid\" = \"enregion146\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept24\" ON (\"enentrarole62\".\"id\" = \"enroleconcept24\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole66\" ON (\"enroleconcept24\".\"applicationroleid\" = \"enapplicationrole66\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser186\".\"id\" = @qpusUser_Id) AND (\"enuser186\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser186\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept24\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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

private static async Task<RC_dbac6e35b37e102dd601262a956066d2> datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync(RC_dbac6e35b37e102dd601262a956066d2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
return rec;
}
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" PTr+mEU6E0m45USpi+3Z2w of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "98fe3a3d-3a45-4913-b8e5-44a98bedd9db");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "98fe3a3d-3a45-4913-b8e5-44a98bedd9db", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/DataActions.4vTcTC+HDECYjIgntQxeRw/NodesNotShownInESpaceTree.PTr+mEU6E0m45USpi+3Z2w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir9\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup9\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir9\" ON (\"ensegmentaccgroup9\".\"id\" = \"ensegmentaccgrouptelceldir9\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper((trim(\"ensegmentaccgroup9\".\"groupname\")))) collate \"default\") like caseaccent_normalize((Upper((trim(@qpteSegmentAccGroup_GroupName)))) collate \"default\")) AND (\"ensegmentaccgroup9\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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

private static async Task<RC_3d56036e64426be06ca36c503a3c39e0> datasetGetUserApplicationRoleTempByConceptsReadDbAsync(RC_3d56036e64426be06ca36c503a3c39e0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUserApplicationRoleTemp.Read( r, ref index);
rec.ssENUserApplicationRoleTempByConcept.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleTempByConcepts" 2dt8q4B1VkCNOqgPxyfrTg of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_b9107f331631f30bcef7fe9d900d99ae,long)> datasetGetUserApplicationRoleTempByConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "ab7cdbd9-7580-4056-8d3a-a80fc727eb4e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "ab7cdbd9-7580-4056-8d3a-a80fc727eb4e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.oyEe8HQjokSgAC+jkEfdsA/DataActions.4vTcTC+HDECYjIgntQxeRw/NodesNotShownInESpaceTree.2dt8q4B1VkCNOqgPxyfrTg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole67\".\"id\" o0, \"enapplicationrole67\".\"code\" o1, \"enapplicationrole67\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM (({UserApplicationRoleTempByConcept} \"enuserapplicationroletempbyconcept7\" Left JOIN {UserApplicationRoleTemp} \"enuserapplicationroletemp11\" ON (\"enuserapplicationroletempbyconcept7\".\"userapplicationroletempid\" = \"enuserapplicationroletemp11\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole67\" ON (\"enuserapplicationroletempbyconcept7\".\"applicationroleid\" = \"enapplicationrole67\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp11\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp11\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp11\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp11\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enuserapplicationroletempbyconcept7\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
}
public static class FuncDataActionGetRequisitionsFull {

// Query Function "GetRequisitionsList" rV7GAIE3WECH6O77zxoBKg of Action "GetRequisitionsFull"
public static async Task<(RL_9ede71d9c6d03aba8c5ee336f1d0813f,long)> QueryGetRequisitionsList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusApproved,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteRequisition_Name,long qpprRequisition_ProjectId,DateTime qpdaRequisition_UploadDate,long qpcoRequisition_CompanyId,decimal qpdeRequisition_AmountFrom,decimal qpdeRequisition_AmountTo,long qpcoRequisition_CostCenterId,long qpsuRequisition_SupplierId,int qpreRequisition_StatusId,int qpapRequisition_ApprovalStatusId,DateTime qpdaNullDate,long qploNullIdentifier,string qpteSortClause,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionsFull.GetRequisitionsList", "00c65ead-3781-4058-87e8-eefbcf1a012a");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionsFull.GetRequisitionsList", "00c65ead-3781-4058-87e8-eefbcf1a012a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityInvoice = AppUtils.Instance.RuntimeEntityReplace("Invoice");
string entityInvoicePoliza = AppUtils.Instance.RuntimeEntityReplace("InvoicePoliza");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
sqlCmd.CreateParameter("@qpapApprovalStatusApproved", DbType.Int32, qpapApprovalStatusApproved);
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
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
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
string sql = "";
string advSql = "WITH LastApprover AS( \n        SELECT  \n            Approver.RequisitionId as RequisitionId, \n            Approver.Name as Name, \n            Approver.ApprovedOn as ApprovedOn \n        FROM ( \n            SELECT  \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " AS RequisitionId, \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"name\"") + " AS Name, \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedon\"") + " AS ApprovedOn, \n                ROW_NUMBER() OVER ( \n                PARTITION BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \n                ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedon\"") + " DESC \n                ) AS RN \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \n            LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \n            LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n            LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " = @qpapApprovalStatusApproved \n        ) Approver \n        WHERE Approver.RN = 1        \n), \n \nInvoicesPoliza AS ( \n    SELECT \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"requisitionid\"") + " AS RequisitionId, \n        STRING_AGG( \n            CONCAT( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,".\"polizasap\"") + ", '(', TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,".\"sentwhen\"") + ", 'DD/MM/YYYY'), ')'),  \n            ', ' \n            ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,".\"sentwhen\"") + " DESC \n        ) AS PolizaSAP \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,"") + " \n    INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,".\"sent\"") + " = 1 \n    GROUP BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"requisitionid\"") + " \n) \n \nSELECT  \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"label\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + ", \nCOALESCE(User_Applicant.\"name\", '') AS UserApplicantName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"advwithoutinvoice\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isaccounting\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscontractpending\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontractfileuploaded\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approveasareausuaria\"") + ", \nLastApprover.Name, \nLastApprover.ApprovedOn, \nInvoicesPoliza.PolizaSAP, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + ", \nCOALESCE(UpdatedBy.\"name\", '') AS UserUpdatedByName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedon\"") + ", \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " IS NULL \n    OR \n    ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " <> @qpusGetUserId \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n            AND STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) = 0 \n        ) \n    ) \n) AS DontShowAction \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nLEFT JOIN LastApprover ON LastApprover.RequisitionId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN InvoicesPoliza ON InvoicesPoliza.RequisitionId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nWHERE \n@qpboCheckUserSession = 1 \nAND (@qpteRequisition_Name = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%' || @qpteRequisition_Name || '%')) \nAND (@qpprRequisition_ProjectId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " = @qpprRequisition_ProjectId) \nAND (@qpdaRequisition_UploadDate = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) = @qpdaRequisition_UploadDate) \nAND (@qpcoRequisition_CompanyId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " = @qpcoRequisition_CompanyId) \nAND (@qpdeRequisition_AmountFrom = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " >= @qpdeRequisition_AmountFrom) \nAND (@qpdeRequisition_AmountTo = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " <= @qpdeRequisition_AmountTo) \nAND (@qpcoRequisition_CostCenterId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " = @qpcoRequisition_CostCenterId) \nAND (@qpsuRequisition_SupplierId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " = @qpsuRequisition_SupplierId) \nAND (@qpreRequisition_StatusId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " = @qpreRequisition_StatusId) \nAND \n( \n    @qpapRequisition_ApprovalStatusId = @qploNullIdentifier \n    OR \n    ( \n        @qpapRequisition_ApprovalStatusId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n            OR \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        ) \n    ) \n) \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \n " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteSortClause)) + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " DESC";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_9ede71d9c6d03aba8c5ee336f1d0813f outParamList = new RL_9ede71d9c6d03aba8c5ee336f1d0813f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionsFull.GetRequisitionsList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9ede71d9c6d03aba8c5ee336f1d0813f _tmp = new RL_9ede71d9c6d03aba8c5ee336f1d0813f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitionsFull.GetRequisitionsList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9ede71d9c6d03aba8c5ee336f1d0813f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsList in GetRequisitionsFull in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (WITH LastApprover AS(          SELECT               Approver.RequisitionId as RequisitionId,              Approver.Name as Name,              Approver.ApprovedOn as ApprovedOn          FROM (              SELECT                   {Requisition}.[Id] AS RequisitionId,                  {User}.[Name] AS Name,                  {RequisitionApprovalLevel}.[ApprovedOn] AS ApprovedOn,                  ROW_NUMBER() OVER (                  PARTITION BY {Requisition}.[Id]                  ORDER BY {RequisitionApprovalLevel}.[ApprovedOn] DESC                  ) AS RN              FROM {Requisition}              LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]              LEFT JOIN {RequisitionApprovalLevel} ON {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]              LEFT JOIN {User} ON {User}.[Id] = {RequisitionApprovalLevel}.[ApprovedBy]              WHERE {RequisitionApprovalLevel}.[ApprovalStatusId] = @ApprovalStat ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitionsFull in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (WITH LastApprover AS(          SELECT               Approver.RequisitionId as RequisitionId,              Approver.Name as Name,              Approver.ApprovedOn as ApprovedOn          FROM (              SELECT                   {Requisition}.[Id] AS RequisitionId,                  {User}.[Name] AS Name,                  {RequisitionApprovalLevel}.[ApprovedOn] AS ApprovedOn,                  ROW_NUMBER() OVER (                  PARTITION BY {Requisition}.[Id]                  ORDER BY {RequisitionApprovalLevel}.[ApprovedOn] DESC                  ) AS RN              FROM {Requisition}              LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]              LEFT JOIN {RequisitionApprovalLevel} ON {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]              LEFT JOIN {User} ON {User}.[Id] = {RequisitionApprovalLevel}.[ApprovedBy]              WHERE {RequisitionApprovalLevel}.[ApprovalStatusId] = @ApprovalStat ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitionsFull in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (WITH LastApprover AS(          SELECT               Approver.RequisitionId as RequisitionId,              Approver.Name as Name,              Approver.ApprovedOn as ApprovedOn          FROM (              SELECT                   {Requisition}.[Id] AS RequisitionId,                  {User}.[Name] AS Name,                  {RequisitionApprovalLevel}.[ApprovedOn] AS ApprovedOn,                  ROW_NUMBER() OVER (                  PARTITION BY {Requisition}.[Id]                  ORDER BY {RequisitionApprovalLevel}.[ApprovedOn] DESC                  ) AS RN              FROM {Requisition}              LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]              LEFT JOIN {RequisitionApprovalLevel} ON {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]              LEFT JOIN {User} ON {User}.[Id] = {RequisitionApprovalLevel}.[ApprovedBy]              WHERE {RequisitionApprovalLevel}.[ApprovalStatusId] = @ApprovalStat ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetRequisitions {

// Query Function "GetRequisitionsList" xIIQYjYE40GLE53izJkIRQ of Action "GetRequisitions"
public static async Task<(RL_6afe7592bf936cbdcd13fc348b4ae3a3,long)> QueryGetRequisitionsList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteRequisition_Name,long qpprRequisition_ProjectId,DateTime qpdaRequisition_UploadDate,long qpcoRequisition_CompanyId,decimal qpdeRequisition_AmountFrom,decimal qpdeRequisition_AmountTo,long qpcoRequisition_CostCenterId,long qpsuRequisition_SupplierId,int qpreRequisition_StatusId,int qpapRequisition_ApprovalStatusId,DateTime qpdaNullDate,long qploNullIdentifier,int qpinMaxRecords,int qpinStartIndex,string qpteSortClause,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsList", "621082c4-0436-41e3-8b13-9de2cc990845");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsList", "621082c4-0436-41e3-8b13-9de2cc990845", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
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
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
sqlCmd.CreateParameter("@qpinStartIndex", DbType.Int32, qpinStartIndex);
string sql = "";
string advSql = "SELECT  \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"label\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + ", \nCOALESCE(User_Applicant.\"name\", '') AS UserApplicantName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"advwithoutinvoice\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isaccounting\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscontractpending\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontractfileuploaded\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approveasareausuaria\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + ", \nCOALESCE(UpdatedBy.\"name\", '') AS UserUpdatedByName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedon\"") + ", \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " IS NULL \n    OR \n    ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " <> @qpusGetUserId \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n            AND STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) = 0 \n        ) \n    ) \n) AS DontShowAction \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n@qpboCheckUserSession = 1 \nAND (@qpteRequisition_Name = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%' || @qpteRequisition_Name || '%')) \nAND (@qpprRequisition_ProjectId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " = @qpprRequisition_ProjectId) \nAND (@qpdaRequisition_UploadDate = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) = @qpdaRequisition_UploadDate) \nAND (@qpcoRequisition_CompanyId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " = @qpcoRequisition_CompanyId) \nAND (@qpdeRequisition_AmountFrom = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " >= @qpdeRequisition_AmountFrom) \nAND (@qpdeRequisition_AmountTo = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " <= @qpdeRequisition_AmountTo) \nAND (@qpcoRequisition_CostCenterId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " = @qpcoRequisition_CostCenterId) \nAND (@qpsuRequisition_SupplierId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " = @qpsuRequisition_SupplierId) \nAND (@qpreRequisition_StatusId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " = @qpreRequisition_StatusId) \nAND \n( \n    @qpapRequisition_ApprovalStatusId = @qploNullIdentifier \n    OR \n    ( \n        @qpapRequisition_ApprovalStatusId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n            OR \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        ) \n    ) \n) \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \n " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteSortClause)) + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " DESC \nLIMIT @qpinMaxRecords  \nOFFSET @qpinStartIndex";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_6afe7592bf936cbdcd13fc348b4ae3a3 outParamList = new RL_6afe7592bf936cbdcd13fc348b4ae3a3();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6afe7592bf936cbdcd13fc348b4ae3a3 _tmp = new RL_6afe7592bf936cbdcd13fc348b4ae3a3();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6afe7592bf936cbdcd13fc348b4ae3a3)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsList in GetRequisitions in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[Label],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[Label],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {RequisitionApprovalLevel}.[Approval ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitions in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[Label],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[Label],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {RequisitionApprovalLevel}.[Approval ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitions in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[Label],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[Label],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {RequisitionApprovalLevel}.[Approval ...): " + aqExcep.Message));
}
}
}

// Query Function "GetRequisitionsListCount" Ao7f2spf_0uezIcgkipSQA of Action "GetRequisitions"
public static async Task<(RL_eb723ca0f1d2182a5703efa79cc03660,long)> QueryGetRequisitionsListCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteRequisition_Name,long qpprRequisition_ProjectId,DateTime qpdaRequisition_UploadDate,long qpcoRequisition_CompanyId,decimal qpdeRequisition_AmountFrom,decimal qpdeRequisition_AmountTo,long qpcoRequisition_CostCenterId,long qpsuRequisition_SupplierId,int qpreRequisition_StatusId,int qpapRequisition_ApprovalStatusId,DateTime qpdaNullDate,long qploNullIdentifier,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsListCount", "dadf8e02-5fca-4bff-9ecc-8720922a5240");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsListCount", "dadf8e02-5fca-4bff-9ecc-8720922a5240", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
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
string advSql = "SELECT  \nCOUNT( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ") \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n@qpboCheckUserSession = 1 \nAND (@qpteRequisition_Name = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%' || @qpteRequisition_Name || '%')) \nAND (@qpprRequisition_ProjectId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " = @qpprRequisition_ProjectId) \nAND (@qpdaRequisition_UploadDate = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) = @qpdaRequisition_UploadDate) \nAND (@qpcoRequisition_CompanyId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " = @qpcoRequisition_CompanyId) \nAND (@qpdeRequisition_AmountFrom = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " >= @qpdeRequisition_AmountFrom) \nAND (@qpdeRequisition_AmountTo = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + " <= @qpdeRequisition_AmountTo) \nAND (@qpcoRequisition_CostCenterId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " = @qpcoRequisition_CostCenterId) \nAND (@qpsuRequisition_SupplierId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " = @qpsuRequisition_SupplierId) \nAND (@qpreRequisition_StatusId = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " = @qpreRequisition_StatusId) \nAND \n( \n    @qpapRequisition_ApprovalStatusId = @qploNullIdentifier \n    OR \n    ( \n        @qpapRequisition_ApprovalStatusId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n            OR \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        ) \n    ) \n) \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n)";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsListCount.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Internal.GetRequisitions.GetRequisitionsListCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb723ca0f1d2182a5703efa79cc03660)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsListCount in GetRequisitions in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (SELECT   COUNT({Requisition}.[Id])    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @ApprovalStatusPending          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )              OR {RequisitionA ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsListCount in GetRequisitions in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (SELECT   COUNT({Requisition}.[Id])    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @ApprovalStatusPending          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )              OR {RequisitionA ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsListCount in GetRequisitions in Wb_RequisitionsList_Internal in c_Requisitions in ConectaProveedores (SELECT   COUNT({Requisition}.[Id])    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @ApprovalStatusPending          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )              OR {RequisitionA ...): " + aqExcep.Message));
}
}
}
}


}
