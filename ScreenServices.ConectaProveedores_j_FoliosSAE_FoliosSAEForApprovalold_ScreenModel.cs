using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel).Namespace);

    public long varLcl_ApplicationRoleIdForAggregate;
public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_IsAllowSelectApplicationRoles;
public bool varLcl_Loading;
public bool varLcl_ReInvokeToggler;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public bool varLcl_IsSelected;
public bool varLcl_IsSelectAll;
public bool varLcl_IsShowSelectAll;
public long varLcl_FolioId;
public RL_bff3f4c3dd4f015750297ff735629582 varLcl_FolioApprovalLevelList;
public long varLcl_FolioApprovalLevelId;
public bool varLcl_ShowBulkApproveFolio;
public bool varLcl_ShowApproveFolio;
public ST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent;
public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError;
public AggregateRecord<RL_53ee8acf49c9618a86f040a6ab1ebb06> ScreenDataSetGetSuppliers;
public AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> ScreenDataSetGetRegions;
public AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ScreenDataSetGetFoliosSAE;
public ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel(long varLcl_ApplicationRoleIdForAggregate, string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_Loading, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, bool varLcl_IsSelected, bool varLcl_IsSelectAll, bool varLcl_IsShowSelectAll, long varLcl_FolioId, RL_bff3f4c3dd4f015750297ff735629582 varLcl_FolioApprovalLevelList, long varLcl_FolioApprovalLevelId, bool varLcl_ShowBulkApproveFolio, bool varLcl_ShowApproveFolio, ST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError, AggregateRecord<RL_53ee8acf49c9618a86f040a6ab1ebb06> ScreenDataSetGetSuppliers, AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> ScreenDataSetGetRegions, AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ScreenDataSetGetFoliosSAE, ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ApplicationRoleIdForAggregate", "l_ColumnJSONVar", "l_CountAfterFetch", "l_IsAllowSelectApplicationRoles", "l_Loading", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "l_IsSelected", "l_IsSelectAll", "l_IsShowSelectAll", "l_FolioId", "l_FolioApprovalLevelList", "l_FolioApprovalLevelId", "l_ShowBulkApproveFolio", "l_ShowApproveFolio", "NotifContent", "NotifError", "GetSuppliers", "GetRegions", "GetFoliosSAE", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcl_ApplicationRoleIdForAggregate", "varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_IsAllowSelectApplicationRoles", "varLcl_Loading", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "varLcl_IsSelected", "varLcl_IsSelectAll", "varLcl_IsShowSelectAll", "varLcl_FolioId", "varLcl_FolioApprovalLevelList", "varLcl_FolioApprovalLevelId", "varLcl_ShowBulkApproveFolio", "varLcl_ShowApproveFolio", "varLcNotifContent", "varLcNotifError", "ScreenDataSetGetSuppliers", "ScreenDataSetGetRegions", "ScreenDataSetGetFoliosSAE", "varLcGetUserApplicationRoles", "clientVariables"});
this.varLcl_ApplicationRoleIdForAggregate = varLcl_ApplicationRoleIdForAggregate;
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_IsAllowSelectApplicationRoles = varLcl_IsAllowSelectApplicationRoles;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_IsSelected = varLcl_IsSelected;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsShowSelectAll = varLcl_IsShowSelectAll;
this.varLcl_FolioId = varLcl_FolioId;
this.varLcl_FolioApprovalLevelList = varLcl_FolioApprovalLevelList;
this.varLcl_FolioApprovalLevelId = varLcl_FolioApprovalLevelId;
this.varLcl_ShowBulkApproveFolio = varLcl_ShowBulkApproveFolio;
this.varLcl_ShowApproveFolio = varLcl_ShowApproveFolio;
this.varLcNotifContent = varLcNotifContent;
this.varLcNotifError = varLcNotifError;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetFoliosSAE = ScreenDataSetGetFoliosSAE;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_c0133441667bf39f1c8403118864a3c3> datasetGetSuppliersReadDbAsync(RC_c0133441667bf39f1c8403118864a3c3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSupplier.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "IsSelectedSupplierRecord.IsSelected", false);
return rec;
}
// Query Function "GetSuppliers" ZynnBsLRokGaWVDTbnVyHw of Action "FoliosSAEForApprovalold"
public static async Task<(RL_53ee8acf49c9618a86f040a6ab1ebb06,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRegionId,long qpreRegionId1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEForApprovalold.GetSuppliers", "06e72967-d1c2-41a2-9a59-50d36e75721f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEForApprovalold","j_FoliosSAE.FoliosSAEForApprovalold.GetSuppliers");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.5ihZqOgotkaDu8LdGZlE0g/ScreenDataSets.ZynnBsLRokGaWVDTbnVyHw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplier152\".\"id\" o0, NULL o1, \"ensupplier152\".\"name\" o2, \"ensupplier152\".\"number\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, 0 \"isselected\"");
fromBuilder.Append(" FROM {Supplier} \"ensupplier152\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((((@qpreRegionId = @qpreRegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId1", DbType.Int64, qpreRegionId);
if (qpreRegionId != 0) {
whereBuilder.Append("((\"ensupplier152\".\"regionid\" = @qpreRegionId1) AND (\"ensupplier152\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId1", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"ensupplier152\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreRegionId1 != 0) {
whereBuilder.Append("((\"ensupplier152\".\"regionid\" = @qpreRegionId) AND (\"ensupplier152\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId1);
} else {
whereBuilder.Append("(\"ensupplier152\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier152\".\"regionid\" IS NULL))");
orderByBuilder.Append(" ORDER BY \"ensupplier152\".\"name\" ASC ");
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
RL_53ee8acf49c9618a86f040a6ab1ebb06 outParamList = new RL_53ee8acf49c9618a86f040a6ab1ebb06();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetSuppliers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_53ee8acf49c9618a86f040a6ab1ebb06 _tmp = new RL_53ee8acf49c9618a86f040a6ab1ebb06();
_tmp.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetSuppliers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_53ee8acf49c9618a86f040a6ab1ebb06)_tmp;
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

private static async Task<RC_fd17f3b5298bdff8f863d6f0335db07c> datasetGetRegionsReadDbAsync(RC_fd17f3b5298bdff8f863d6f0335db07c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssRegion_Text = r.ReadText(index++, "Region_TextRegionRecord.Region_Text", "");
return rec;
}
// Query Function "GetRegions" kXGjocVlCUqHgOtcpZ+PmQ of Action "FoliosSAEForApprovalold"
public static async Task<(RL_07bd6e6f32ae098d324b78b5f3777516,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEForApprovalold.GetRegions", "a1a37191-65c5-4a09-8780-eb5ca59f8f99");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEForApprovalold","j_FoliosSAE.FoliosSAEForApprovalold.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.5ihZqOgotkaDu8LdGZlE0g/ScreenDataSets.kXGjocVlCUqHgOtcpZ+PmQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion199\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, ((\"enregion199\".\"code\" || ' ') || \"enregion199\".\"name\") \"region_text\"");
fromBuilder.Append(" FROM {Region} \"enregion199\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (\"enregion199\".\"isactive\" = 1)");
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
RL_07bd6e6f32ae098d324b78b5f3777516 outParamList = new RL_07bd6e6f32ae098d324b78b5f3777516();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRegionsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_07bd6e6f32ae098d324b78b5f3777516 _tmp = new RL_07bd6e6f32ae098d324b78b5f3777516();
_tmp.AlternateReadDbMethodAsync = datasetGetRegionsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_07bd6e6f32ae098d324b78b5f3777516)_tmp;
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

private static async Task<RC_d7d7e269eeb924718adc0d2a0b1d922d> datasetGetFoliosSAEReadDbAsync(RC_d7d7e269eeb924718adc0d2a0b1d922d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssCanApprove = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.CanApprove", false);
rec.ssDontShowAction = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetFoliosSAE" e9ef4MSi9UyKFJ+W2iiGGg of Action "FoliosSAEForApprovalold"
public static async Task<(RL_c2883fff640d266ea46702d7f4b1c10f,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdaFolioApproved_CreatedOnDate,DateTime qpdaFolioApproved_CreatedToDate,string qpteFolioApproved_FolioNumber,string qpteFolioApproved_OrderNumber,long qpreRegion_Id,long qpsuSupplier_Id,bool qpboFolioForApproval_AssignedToMe,bool qpboGetIsCorporativo,string qpteAppRoleListText,string qpteEntraRolesListText,long qpdeFolioApprovalLevel_DepartmentId,string qpusGetUserId,long qpreGetUserRegionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEForApprovalold.GetFoliosSAE", "e09fd77b-a2c4-4cf5-8a14-9f96da28861a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEForApprovalold","j_FoliosSAE.FoliosSAEForApprovalold.GetFoliosSAE");
// Query Iterations: Multiple
// Refresh Query FZWv2Q9tiUSaphn2dPzJzQ Iterations: Multiple
// Refresh Query gA03aXSLH0KNCwN2lvqk5Q Iterations: Multiple
// Refresh Query lVrXYmcC30Sv5PwmjHqpdw Iterations: Multiple
// Refresh Query aYa3EIRksEqAijJpkVuM9A Iterations: Multiple
// Refresh Query DUADjLPcwkyLDLhJTEFeaA Iterations: Multiple
// Refresh Query vGIndoMeJ0mbjFdZ+XurAw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.5ihZqOgotkaDu8LdGZlE0g/ScreenDataSets.e9ef4MSi9UyKFJ+W2iiGGg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalstatus36\".\"label\" o8, \"enapprovalstatus36\".\"class\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enfolio113\".\"id\" o17, \"enfolio113\".\"isdraft\" o18, \"enfolio113\".\"folionumber\" o19, \"enfolio113\".\"canproveedorcancel\" o20, \"enfolio113\".\"orderid\" o21, \"enfolio113\".\"supplierid\" o22, \"enfolio113\".\"companyid\" o23, \"enfolio113\".\"foliostatusid\" o24, trim_scale(\"enfolio113\".\"totalamount\"::numeric) o25, trim_scale(\"enfolio113\".\"totaliva_amount\"::numeric) o26, trim_scale(\"enfolio113\".\"partialamount\"::numeric) o27, \"enfolio113\".\"currencyid\" o28, \"enfolio113\".\"firstapproveruserid\" o29, \"enfolio113\".\"approvalprocesstypeid\" o30, \"enfolio113\".\"sapentryerror\" o31, \"enfolio113\".\"createdby\" o32, \"enfolio113\".\"createdon\" o33, \"enfolio113\".\"updatedby\" o34, \"enfolio113\".\"updatedon\" o35, \"enfolio113\".\"minuteselected\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enfolioapprovallevel55\".\"id\" o47, \"enfolioapprovallevel55\".\"folioapprovalid\" o48, \"enfolioapprovallevel55\".\"levelnumber\" o49, \"enfolioapprovallevel55\".\"applicationroleid\" o50, \"enfolioapprovallevel55\".\"entrajobtitle\" o51, \"enfolioapprovallevel55\".\"entraroleid\" o52, \"enfolioapprovallevel55\".\"departmentid\" o53, \"enfolioapprovallevel55\".\"assignedto\" o54, \"enfolioapprovallevel55\".\"approvalstatusid\" o55, \"enfolioapprovallevel55\".\"ismandatory\" o56, \"enfolioapprovallevel55\".\"isreassigned\" o57, \"enfolioapprovallevel55\".\"approvedby\" o58, \"enfolioapprovallevel55\".\"approvedon\" o59, \"enfolioapprovallevel55\".\"canceledby\" o60, \"enfolioapprovallevel55\".\"canceledon\" o61, \"enfolioapprovallevel55\".\"rejectedby\" o62, \"enfolioapprovallevel55\".\"rejectedon\" o63, \"enfolioapprovallevel55\".\"issubstitutefor\" o64, \"enfolioapprovallevel55\".\"rejectreason\" o65, \"enfolioapprovallevel55\".\"isinvoiceapproval\" o66, NULL o67, \"enfoliostatus24\".\"label\" o68, \"enfoliostatus24\".\"class\" o69, NULL o70, NULL o71, NULL o72, NULL o73, \"enordermain153\".\"ordernumber\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enregion200\".\"code\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, \"ensupplier153\".\"name\" o117, \"ensupplier153\".\"number\" o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, (CASE WHEN (((\"enfolioapprovallevel55\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enfolioapprovallevel55\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(")) AND ((\"enfolio113\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(") OR (\"enfolio113\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"canapprove\", (CASE WHEN (\"enfolioapprovallevel55\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain153\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain153\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain153\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio113\" Left JOIN {FolioApproval} \"enfolioapproval59\" ON (\"enfolio113\".\"id\" = \"enfolioapproval59\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel55\" ON (\"enfolioapproval59\".\"id\" = \"enfolioapprovallevel55\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain153\" ON (\"enfolio113\".\"orderid\" = \"enordermain153\".\"id\"))  Left JOIN {Region} \"enregion200\" ON (\"enordermain153\".\"regionid\" = \"enregion200\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole93\" ON (\"enfolioapprovallevel55\".\"applicationroleid\" = \"enapplicationrole93\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus24\" ON (\"enfolio113\".\"foliostatusid\" = \"enfoliostatus24\".\"id\"))  Left JOIN {Supplier} \"ensupplier153\" ON (\"enfolio113\".\"supplierid\" = \"ensupplier153\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus36\" ON (\"enfolioapprovallevel55\".\"approvalstatusid\" = \"enapprovalstatus36\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteFolioApproved_FolioNumber != "" && qpteFolioApproved_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio113\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioApproved_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_FolioNumber", DbType.String, qpteFolioApproved_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_FolioNumber", DbType.String, qpteFolioApproved_FolioNumber);
}
if (qpteFolioApproved_OrderNumber != "" && qpteFolioApproved_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain153\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioApproved_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_OrderNumber", DbType.String, qpteFolioApproved_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_OrderNumber", DbType.String, qpteFolioApproved_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier153\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier153\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier153\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((@qpdaFolioApproved_CreatedOnDate = (date '1900-01-01')) OR ((cast(\"enfolio113\".\"createdon\" as date)::timestamptz) >= @qpdaFolioApproved_CreatedOnDate)) AND ((@qpdaFolioApproved_CreatedToDate = (date '1900-01-01')) OR ((cast(\"enfolio113\".\"createdon\" as date)::timestamptz) <= @qpdaFolioApproved_CreatedToDate))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedOnDate", DbType.DateTime, qpdaFolioApproved_CreatedOnDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedOnDate", DbType.DateTime, qpdaFolioApproved_CreatedOnDate);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedToDate", DbType.DateTime, qpdaFolioApproved_CreatedToDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedToDate", DbType.DateTime, qpdaFolioApproved_CreatedToDate);
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion200\".\"id\" = @qpreRegion_Id) AND (\"enregion200\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion200\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboFolioForApproval_AssignedToMe = 1) THEN (CASE WHEN ((\"enfolioapprovallevel55\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") AND ((CASE WHEN (\"enfolioapprovallevel55\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboFolioForApproval_AssignedToMe", DbType.Boolean, qpboFolioForApproval_AssignedToMe);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboFolioForApproval_AssignedToMe", DbType.Boolean, qpboFolioForApproval_AssignedToMe);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel55\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel55\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel55\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain153\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain153\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain153\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval59\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval59\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval59\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel55\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel55\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel55\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel55\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1)) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((\"enfolioapprovallevel55\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (((((CASE WHEN (\"enfolioapprovallevel55\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel55\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel55\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel55\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel55\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain153\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain153\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain153\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval59\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval59\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval59\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel55\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel55\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel55\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel55\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel55\".\"approvedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel55\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel55\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel55\".\"rejectedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel55\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel55\".\"rejectedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel55\".\"canceledby\" = @qpusGetUserId) AND (\"enfolioapprovallevel55\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel55\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Region", "Supplier", "FolioStatus", "Folio", "ApplicationRole", "OrderMain", "FolioApproval", "FolioApprovalLevel", "ApprovalStatus" }, new string[] { "ENRegion200", "ENSupplier153", "ENFolioStatus24", "ENFolio113", "ENApplicationRole93", "ENOrderMain153", "ENFolioApproval59", "ENFolioApprovalLevel55", "ENApprovalStatus36" }, new System.Collections.Generic.Dictionary<string, string>[] { ENRegionEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio113\".\"id\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_c2883fff640d266ea46702d7f4b1c10f outParamList = new RL_c2883fff640d266ea46702d7f4b1c10f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAEForApprovalold.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetFoliosSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c2883fff640d266ea46702d7f4b1c10f _tmp = new RL_c2883fff640d266ea46702d7f4b1c10f();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c2883fff640d266ea46702d7f4b1c10f)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAEForApprovalold.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


    public class lcvGetUserApplicationRoles : VarsBag {
public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public Actions.lcoGetUserEntraRoleName resGetUserEntraRoleName =  new Actions.lcoGetUserEntraRoleName();
public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamAppRoleListText = "";

public string outParamEntraRolesListText = "";

public bool outParamCanBulkApprove = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,string,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRoleListText = default;
string outParamEntraRolesListText = default;
bool outParamCanBulkApprove = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "63d15a51-dbc4-4ef2-a695-4d2d1b84d86a"))
using (activitySource.CreateScreenDataActionActivity("FoliosSAEForApprovalold", "GetUserApplicationRoles")){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// Foreach GetRoleConcept.List
localVars.queryResGetRoleConcept_outParamList.StartIteration();
try {while (!((localVars.queryResGetRoleConcept_outParamList.Eof))) {
// AppRoleListText = AppRoleListText + "," + GetRoleConcept.List.Current.RoleConcept.ApplicationRoleId
result.outParamAppRoleListText=((result.outParamAppRoleListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId));

// EntraRolesListText = EntraRolesListText + "," + GetRoleConcept.List.Current.User_Extended_Internal.EntraRoleId
result.outParamEntraRolesListText=((result.outParamEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId));
localVars.queryResGetRoleConcept_outParamList.Advance();
}

} finally {
localVars.queryResGetRoleConcept_outParamList.EndIteration();
}

// GetUserEntraRoleName
localVars.resGetUserEntraRoleName.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken);

// CanBulkApprove = Index = -1 and Index = -1
result.outParamCanBulkApprove=((BuiltInFunction.IndexSC (localVars.resGetUserEntraRoleName.outParamo_EntraRoleName, "analista", 0, false, true)==(-1))&&(BuiltInFunction.IndexSC (localVars.resGetUserEntraRoleName.outParamo_EntraRoleName, "jefe", 0, false, true)==(-1)));
} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamAppRoleListText = result.outParamAppRoleListText;
outParamEntraRolesListText = result.outParamEntraRolesListText;
outParamCanBulkApprove = result.outParamCanBulkApprove;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText,outParamCanBulkApprove);
}


    public static class FuncDataActionGetUserApplicationRoles {

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
// Query Function "GetRoleConcept" szt_aAVvT0eNJ8Lj9sApVQ of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.FoliosSAEForApprovalold.GetUserApplicationRoles.GetRoleConcept", "687f3bb3-6f05-474f-8d27-c2e3f6c02955");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.FoliosSAEForApprovalold.GetUserApplicationRoles.GetRoleConcept", "687f3bb3-6f05-474f-8d27-c2e3f6c02955", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.5ihZqOgotkaDu8LdGZlE0g/DataActions.UVrRY8Tb8k6mlU0tG4TYag/NodesNotShownInESpaceTree.szt_aAVvT0eNJ8Lj9sApVQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole94\".\"code\" o1, \"enapplicationrole94\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept38\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal145\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal145\" Inner JOIN {User} \"enuser248\" ON (\"enuser_extended_internal145\".\"id\" = \"enuser248\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole90\" ON (\"enuser_extended_internal145\".\"jobtitle\" = \"enentrarole90\".\"rolename\"))  Left JOIN {Region} \"enregion201\" ON (\"enuser_extended_internal145\".\"regionid\" = \"enregion201\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept38\" ON (\"enentrarole90\".\"id\" = \"enroleconcept38\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole94\" ON (\"enroleconcept38\".\"applicationroleid\" = \"enapplicationrole94\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser248\".\"id\" = @qpusUser_Id) AND (\"enuser248\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser248\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept38\".\"conceptid\" = ");
whereBuilder.Append(2
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
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApprovalold.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
}


}
