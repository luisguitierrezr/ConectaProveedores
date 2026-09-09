using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel).Namespace);

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
public bool varLcIsListFullNeedRefresh;
public AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ScreenDataSetGetFoliosSAE;
public AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ScreenDataSetGetFoliosSAEFull;
public AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> ScreenDataSetGetRegions;
public AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus;
public ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel(long varLcl_ApplicationRoleIdForAggregate, string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_Loading, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, bool varLcl_IsSelected, bool varLcl_IsSelectAll, bool varLcl_IsShowSelectAll, bool varLcIsListFullNeedRefresh, AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ScreenDataSetGetFoliosSAE, AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ScreenDataSetGetFoliosSAEFull, AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> ScreenDataSetGetRegions, AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus, ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ApplicationRoleIdForAggregate", "l_ColumnJSONVar", "l_CountAfterFetch", "l_IsAllowSelectApplicationRoles", "l_Loading", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "l_IsSelected", "l_IsSelectAll", "l_IsShowSelectAll", "IsListFullNeedRefresh", "GetFoliosSAE", "GetFoliosSAEFull", "GetRegions", "GetFolioStatus", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcl_ApplicationRoleIdForAggregate", "varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_IsAllowSelectApplicationRoles", "varLcl_Loading", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "varLcl_IsSelected", "varLcl_IsSelectAll", "varLcl_IsShowSelectAll", "varLcIsListFullNeedRefresh", "ScreenDataSetGetFoliosSAE", "ScreenDataSetGetFoliosSAEFull", "ScreenDataSetGetRegions", "ScreenDataSetGetFolioStatus", "varLcGetUserApplicationRoles", "clientVariables"});
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
this.varLcIsListFullNeedRefresh = varLcIsListFullNeedRefresh;
this.ScreenDataSetGetFoliosSAE = ScreenDataSetGetFoliosSAE;
this.ScreenDataSetGetFoliosSAEFull = ScreenDataSetGetFoliosSAEFull;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetFolioStatus = ScreenDataSetGetFolioStatus;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
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
// Query Function "GetFoliosSAE" cgFfKsht_Uyb22eusG2efQ of Action "FoliosSAEApproved"
public static async Task<(RL_c2883fff640d266ea46702d7f4b1c10f,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdaFolioApproved_CreatedOnDate,DateTime qpdaFolioApproved_CreatedToDate,string qpteFolioApproved_FolioNumber,string qpteFolioApproved_OrderNumber,long qpreRegion_Id,int qpfoFolioStatus_Id,long qpsuSupplier_Id,int qpinOffsetUtc,bool qpboGetIsCorporativo,string qpteAppRoleListText,string qpteEntraRolesListText,long qpdeFolioApprovalLevel_DepartmentId,string qpusGetUserId,long qpreGetUserRegionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEApproved.GetFoliosSAE", "2a5f0172-6dc8-4cfd-9bdb-67aeb06d9e7d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEApproved","j_FoliosSAE.FoliosSAEApproved.GetFoliosSAE");
// Query Iterations: Multiple
// Refresh Query gROTrJQRaUy+uceV5r7H6w Iterations: Multiple
// Refresh Query Wk9XseYg_06Hv33ij4A9FA Iterations: Multiple
// Refresh Query UxrbK58uXEqYsRixXIHjPw Iterations: Multiple
// Refresh Query dAsi79s79keyDyhfOxhgTg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.IVmMI7+550ykkmjtgIBkVQ/ScreenDataSets.cgFfKsht_Uyb22eusG2efQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalstatus30\".\"label\" o8, \"enapprovalstatus30\".\"class\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enfolio83\".\"id\" o17, NULL o18, \"enfolio83\".\"folionumber\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enfolio83\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, \"enfolio83\".\"currencyid\" o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enfolio83\".\"createdon\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enfoliostatus11\".\"label\" o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, \"enordermain125\".\"ordernumber\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enregion177\".\"code\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, \"ensupplier129\".\"name\" o117, \"ensupplier129\".\"number\" o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, (CASE WHEN (((\"enfolioapprovallevel43\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enfolioapprovallevel43\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(")) AND ((\"enfolio83\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(") OR (\"enfolio83\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"canapprove\", (CASE WHEN (\"enfolioapprovallevel43\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain125\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain125\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain125\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio83\" Left JOIN {FolioApproval} \"enfolioapproval47\" ON (\"enfolio83\".\"id\" = \"enfolioapproval47\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel43\" ON (\"enfolioapproval47\".\"id\" = \"enfolioapprovallevel43\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain125\" ON (\"enfolio83\".\"orderid\" = \"enordermain125\".\"id\"))  Left JOIN {Region} \"enregion177\" ON (\"enordermain125\".\"regionid\" = \"enregion177\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole86\" ON (\"enfolioapprovallevel43\".\"applicationroleid\" = \"enapplicationrole86\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus11\" ON (\"enfolio83\".\"foliostatusid\" = \"enfoliostatus11\".\"id\"))  Left JOIN {Supplier} \"ensupplier129\" ON (\"enfolio83\".\"supplierid\" = \"ensupplier129\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus30\" ON (\"enfolioapprovallevel43\".\"approvalstatusid\" = \"enapprovalstatus30\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteFolioApproved_FolioNumber != "" && qpteFolioApproved_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio83\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioApproved_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_FolioNumber", DbType.String, qpteFolioApproved_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_FolioNumber", DbType.String, qpteFolioApproved_FolioNumber);
}
if (qpteFolioApproved_OrderNumber != "" && qpteFolioApproved_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain125\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioApproved_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_OrderNumber", DbType.String, qpteFolioApproved_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_OrderNumber", DbType.String, qpteFolioApproved_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier129\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier129\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier129\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((@qpdaFolioApproved_CreatedOnDate = (date '1900-01-01')) OR ((cast(((\"enfolio83\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaFolioApproved_CreatedOnDate)) AND ((@qpdaFolioApproved_CreatedToDate = (date '1900-01-01')) OR ((cast(((\"enfolio83\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaFolioApproved_CreatedToDate))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedOnDate", DbType.DateTime, qpdaFolioApproved_CreatedOnDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedOnDate", DbType.DateTime, qpdaFolioApproved_CreatedOnDate);
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedToDate", DbType.DateTime, qpdaFolioApproved_CreatedToDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedToDate", DbType.DateTime, qpdaFolioApproved_CreatedToDate);
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion177\".\"id\" = @qpreRegion_Id) AND (\"enregion177\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion177\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpfoFolioStatus_Id != BuiltInFunction.NullIdentifier()) {
if (qpfoFolioStatus_Id != 0) {
whereBuilder.Append("((\"enfoliostatus11\".\"id\" = @qpfoFolioStatus_Id) AND (\"enfoliostatus11\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioStatus_Id", DbType.Int32, qpfoFolioStatus_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolioStatus_Id", DbType.Int32, qpfoFolioStatus_Id);
} else {
whereBuilder.Append("(\"enfoliostatus11\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((\"enfolioapprovallevel43\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (\"enfolioapprovallevel43\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")) AND (((((CASE WHEN (\"enfolioapprovallevel43\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel43\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel43\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel43\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel43\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel43\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel43\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel43\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain125\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain125\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain125\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval47\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval47\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval47\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel43\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel43\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel43\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel43\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel43\".\"approvedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel43\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel43\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel43\".\"rejectedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel43\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel43\".\"rejectedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel43\".\"canceledby\" = @qpusGetUserId) AND (\"enfolioapprovallevel43\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel43\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")) AND (NOT (\"enfolioapprovallevel43\".\"isinvoiceapproval\" = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Region", "FolioApproval", "FolioStatus", "Supplier", "ApprovalStatus", "Folio", "OrderMain", "FolioApprovalLevel", "ApplicationRole" }, new string[] { "ENRegion177", "ENFolioApproval47", "ENFolioStatus11", "ENSupplier129", "ENApprovalStatus30", "ENFolio83", "ENOrderMain125", "ENFolioApprovalLevel43", "ENApplicationRole86" }, new System.Collections.Generic.Dictionary<string, string>[] { ENRegionEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio83\".\"id\" DESC ");
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
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, false, true, true, false, true, true, true, true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAEApproved.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEApproved.GetFoliosSAE.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEApproved.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c2883fff640d266ea46702d7f4b1c10f)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAEApproved.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_d7d7e269eeb924718adc0d2a0b1d922d> datasetGetFoliosSAEFullReadDbAsync(RC_d7d7e269eeb924718adc0d2a0b1d922d rec, DbDataReader r, CancellationToken cancellationToken) {
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
// Query Function "GetFoliosSAEFull" D+7IOKXSxUqqzIZwrXmv8g of Action "FoliosSAEApproved"
public static async Task<(RL_c2883fff640d266ea46702d7f4b1c10f,long)> datasetGetFoliosSAEFull(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdaFolioApproved_CreatedOnDate,DateTime qpdaFolioApproved_CreatedToDate,string qpteFolioApproved_FolioNumber,string qpteFolioApproved_OrderNumber,long qpreRegion_Id,int qpfoFolioStatus_Id,long qpsuSupplier_Id,int qpinOffsetUtc,bool qpboGetIsCorporativo,string qpteAppRoleListText,string qpteEntraRolesListText,long qpdeFolioApprovalLevel_DepartmentId,string qpusGetUserId,long qpreGetUserRegionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEApproved.GetFoliosSAEFull", "38c8ee0f-d2a5-4ac5-aacc-8670ad79aff2");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEApproved","j_FoliosSAE.FoliosSAEApproved.GetFoliosSAEFull");
// Query Iterations: Multiple
// Refresh Query evnY2WAkOkaBNhcMacxeog Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.IVmMI7+550ykkmjtgIBkVQ/ScreenDataSets.D+7IOKXSxUqqzIZwrXmv8g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enfolio84\".\"folionumber\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enfolio84\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, \"enfolio84\".\"currencyid\" o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enfolio84\".\"createdon\" o33, NULL o34, NULL o35, NULL o36, NULL o37, \"enfolioapproval48\".\"folioid\" o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enfoliostatus12\".\"label\" o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, \"enordermain126\".\"ordernumber\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enregion178\".\"code\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, \"ensupplier130\".\"name\" o117, \"ensupplier130\".\"number\" o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, (CASE WHEN (((\"enfolioapprovallevel44\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enfolioapprovallevel44\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(")) AND ((\"enfolio84\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(") OR (\"enfolio84\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"canapprove\", (CASE WHEN (\"enfolioapprovallevel44\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain126\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain126\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain126\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio84\" Left JOIN {FolioApproval} \"enfolioapproval48\" ON (\"enfolio84\".\"id\" = \"enfolioapproval48\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel44\" ON (\"enfolioapproval48\".\"id\" = \"enfolioapprovallevel44\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain126\" ON (\"enfolio84\".\"orderid\" = \"enordermain126\".\"id\"))  Left JOIN {Region} \"enregion178\" ON (\"enordermain126\".\"regionid\" = \"enregion178\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole87\" ON (\"enfolioapprovallevel44\".\"applicationroleid\" = \"enapplicationrole87\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus12\" ON (\"enfolio84\".\"foliostatusid\" = \"enfoliostatus12\".\"id\"))  Left JOIN {Supplier} \"ensupplier130\" ON (\"enfolio84\".\"supplierid\" = \"ensupplier130\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus31\" ON (\"enfolioapprovallevel44\".\"approvalstatusid\" = \"enapprovalstatus31\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteFolioApproved_FolioNumber != "" && qpteFolioApproved_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio84\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioApproved_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_FolioNumber", DbType.String, qpteFolioApproved_FolioNumber);
}
if (qpteFolioApproved_OrderNumber != "" && qpteFolioApproved_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain126\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioApproved_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioApproved_OrderNumber", DbType.String, qpteFolioApproved_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier130\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier130\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier130\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((@qpdaFolioApproved_CreatedOnDate = (date '1900-01-01')) OR ((cast(((\"enfolio84\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaFolioApproved_CreatedOnDate)) AND ((@qpdaFolioApproved_CreatedToDate = (date '1900-01-01')) OR ((cast(((\"enfolio84\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaFolioApproved_CreatedToDate))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedOnDate", DbType.DateTime, qpdaFolioApproved_CreatedOnDate);
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioApproved_CreatedToDate", DbType.DateTime, qpdaFolioApproved_CreatedToDate);
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion178\".\"id\" = @qpreRegion_Id) AND (\"enregion178\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion178\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpfoFolioStatus_Id != BuiltInFunction.NullIdentifier()) {
if (qpfoFolioStatus_Id != 0) {
whereBuilder.Append("((\"enfoliostatus12\".\"id\" = @qpfoFolioStatus_Id) AND (\"enfoliostatus12\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioStatus_Id", DbType.Int32, qpfoFolioStatus_Id);
} else {
whereBuilder.Append("(\"enfoliostatus12\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((\"enfolioapprovallevel44\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (\"enfolioapprovallevel44\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")) AND (((((CASE WHEN (\"enfolioapprovallevel44\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel44\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel44\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel44\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel44\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel44\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel44\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel44\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain126\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain126\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain126\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval48\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval48\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval48\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel44\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel44\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel44\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel44\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel44\".\"approvedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel44\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel44\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel44\".\"rejectedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel44\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel44\".\"rejectedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel44\".\"canceledby\" = @qpusGetUserId) AND (\"enfolioapprovallevel44\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel44\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")) AND (NOT (\"enfolioapprovallevel44\".\"isinvoiceapproval\" = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Region", "FolioApprovalLevel", "FolioStatus", "FolioApproval", "ApplicationRole", "ApprovalStatus", "OrderMain", "Folio", "Supplier" }, new string[] { "ENRegion178", "ENFolioApprovalLevel44", "ENFolioStatus12", "ENFolioApproval48", "ENApplicationRole87", "ENApprovalStatus31", "ENOrderMain126", "ENFolio84", "ENSupplier130" }, new System.Collections.Generic.Dictionary<string, string>[] { ENRegionEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio84\".\"id\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_c2883fff640d266ea46702d7f4b1c10f outParamList = new RL_c2883fff640d266ea46702d7f4b1c10f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAEFullReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, false, true, true, false, true, true, true, true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEApproved.GetFoliosSAEFull.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c2883fff640d266ea46702d7f4b1c10f _tmp = new RL_c2883fff640d266ea46702d7f4b1c10f();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAEFullReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEApproved.GetFoliosSAEFull.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c2883fff640d266ea46702d7f4b1c10f)_tmp;
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
// Query Function "GetRegions" TL5+w8Ky60Kcx2ssohXoOQ of Action "FoliosSAEApproved"
public static async Task<(RL_07bd6e6f32ae098d324b78b5f3777516,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEApproved.GetRegions", "c37ebe4c-b2c2-42eb-9cc7-6b2ca215e839");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEApproved","j_FoliosSAE.FoliosSAEApproved.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.IVmMI7+550ykkmjtgIBkVQ/ScreenDataSets.TL5+w8Ky60Kcx2ssohXoOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion179\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, ((\"enregion179\".\"code\" || ' ') || \"enregion179\".\"name\") \"region_text\"");
fromBuilder.Append(" FROM {Region} \"enregion179\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (\"enregion179\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEApproved.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEApproved.GetRegions.List", cancellationToken: cancellationToken);
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

// Query Function "GetFolioStatus" vGx2xDzvw0+LSt6YpumemQ of Action "FoliosSAEApproved"
public static async Task<(RL_ba9fc810801f4aabee0bc4ef3685a9dd,long)> datasetGetFolioStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEApproved.GetFolioStatus", "c4766cbc-ef3c-4fc3-8b4a-de98a6e99e99");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEApproved","j_FoliosSAE.FoliosSAEApproved.GetFolioStatus");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.IVmMI7+550ykkmjtgIBkVQ/ScreenDataSets.vGx2xDzvw0+LSt6YpumemQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliostatus13\".\"id\" o0, \"enfoliostatus13\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {FolioStatus} \"enfoliostatus13\"");
whereBuilder.Append(" WHERE (\"enfoliostatus13\".\"is_active\" = 1)");
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
RL_ba9fc810801f4aabee0bc4ef3685a9dd outParamList = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEApproved.GetFolioStatus.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ba9fc810801f4aabee0bc4ef3685a9dd _tmp = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEApproved.GetFolioStatus.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ba9fc810801f4aabee0bc4ef3685a9dd)_tmp;
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

public bool outParamIsActiveDEV_NewVersionScreenDownloads = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,string,bool,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRoleListText = default;
string outParamEntraRolesListText = default;
bool outParamCanBulkApprove = default;
bool outParamIsActiveDEV_NewVersionScreenDownloads = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "f24d1077-cb0b-4517-8934-5b319256c586"))
using (activitySource.CreateScreenDataActionActivity("FoliosSAEApproved", "GetUserApplicationRoles")){
// IsActiveDEV_NewVersionScreenDownloads = IsActiveDEV_NewScreenDownloads
result.outParamIsActiveDEV_NewVersionScreenDownloads=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_NewScreenDownloads])));
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
outParamIsActiveDEV_NewVersionScreenDownloads = result.outParamIsActiveDEV_NewVersionScreenDownloads;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText,outParamCanBulkApprove,outParamIsActiveDEV_NewVersionScreenDownloads);
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
// Query Function "GetRoleConcept" rJr9dsntp0i72dpjtV6lpQ of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.FoliosSAEApproved.GetUserApplicationRoles.GetRoleConcept", "76fd9aac-edc9-48a7-bbd9-da63b55ea5a5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.FoliosSAEApproved.GetUserApplicationRoles.GetRoleConcept", "76fd9aac-edc9-48a7-bbd9-da63b55ea5a5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.IVmMI7+550ykkmjtgIBkVQ/DataActions.dxBN8gvLF0WJNFsxklbFhg/NodesNotShownInESpaceTree.rJr9dsntp0i72dpjtV6lpQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole88\".\"code\" o1, \"enapplicationrole88\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept34\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal135\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal135\" Inner JOIN {User} \"enuser228\" ON (\"enuser_extended_internal135\".\"id\" = \"enuser228\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole80\" ON (\"enuser_extended_internal135\".\"jobtitle\" = \"enentrarole80\".\"rolename\"))  Left JOIN {Region} \"enregion180\" ON (\"enuser_extended_internal135\".\"regionid\" = \"enregion180\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept34\" ON (\"enentrarole80\".\"id\" = \"enroleconcept34\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole88\" ON (\"enroleconcept34\".\"applicationroleid\" = \"enapplicationrole88\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser228\".\"id\" = @qpusUser_Id) AND (\"enuser228\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser228\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept34\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEApproved.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEApproved.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
