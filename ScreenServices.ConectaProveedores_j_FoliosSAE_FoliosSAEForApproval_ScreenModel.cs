using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_ScreenModel).Namespace);

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
public bool varLcIsListFullNeedRefresh;
public AggregateRecord<RL_03e3cf3b917f5a94fbd0a8404cd2dee5> ScreenDataSetGetFoliosSAE;
public AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus;
public AggregateRecord<RL_03e3cf3b917f5a94fbd0a8404cd2dee5> ScreenDataSetGetFoliosSAEFull;
public AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> ScreenDataSetGetRegions;
public ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_ScreenModel(long varLcl_ApplicationRoleIdForAggregate, string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_Loading, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, bool varLcl_IsSelected, bool varLcl_IsSelectAll, bool varLcl_IsShowSelectAll, long varLcl_FolioId, RL_bff3f4c3dd4f015750297ff735629582 varLcl_FolioApprovalLevelList, long varLcl_FolioApprovalLevelId, bool varLcl_ShowBulkApproveFolio, bool varLcl_ShowApproveFolio, ST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError, bool varLcIsListFullNeedRefresh, AggregateRecord<RL_03e3cf3b917f5a94fbd0a8404cd2dee5> ScreenDataSetGetFoliosSAE, AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus, AggregateRecord<RL_03e3cf3b917f5a94fbd0a8404cd2dee5> ScreenDataSetGetFoliosSAEFull, AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> ScreenDataSetGetRegions, ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ApplicationRoleIdForAggregate", "l_ColumnJSONVar", "l_CountAfterFetch", "l_IsAllowSelectApplicationRoles", "l_Loading", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "l_IsSelected", "l_IsSelectAll", "l_IsShowSelectAll", "l_FolioId", "l_FolioApprovalLevelList", "l_FolioApprovalLevelId", "l_ShowBulkApproveFolio", "l_ShowApproveFolio", "NotifContent", "NotifError", "IsListFullNeedRefresh", "GetFoliosSAE", "GetFolioStatus", "GetFoliosSAEFull", "GetRegions", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcl_ApplicationRoleIdForAggregate", "varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_IsAllowSelectApplicationRoles", "varLcl_Loading", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "varLcl_IsSelected", "varLcl_IsSelectAll", "varLcl_IsShowSelectAll", "varLcl_FolioId", "varLcl_FolioApprovalLevelList", "varLcl_FolioApprovalLevelId", "varLcl_ShowBulkApproveFolio", "varLcl_ShowApproveFolio", "varLcNotifContent", "varLcNotifError", "varLcIsListFullNeedRefresh", "ScreenDataSetGetFoliosSAE", "ScreenDataSetGetFolioStatus", "ScreenDataSetGetFoliosSAEFull", "ScreenDataSetGetRegions", "varLcGetUserApplicationRoles", "clientVariables"});
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
this.varLcIsListFullNeedRefresh = varLcIsListFullNeedRefresh;
this.ScreenDataSetGetFoliosSAE = ScreenDataSetGetFoliosSAE;
this.ScreenDataSetGetFolioStatus = ScreenDataSetGetFolioStatus;
this.ScreenDataSetGetFoliosSAEFull = ScreenDataSetGetFoliosSAEFull;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_7bf0e8779480c1f841bf78e3626ee944> datasetGetFoliosSAEReadDbAsync(RC_7bf0e8779480c1f841bf78e3626ee944 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENLastApprover.Read( r, ref index);
rec.ssENLastFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssCanApprove = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.CanApprove", false);
rec.ssDontShowAction = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetFoliosSAE" hv_1VU0ASEmbHywMF0mAMA of Action "FoliosSAEForApproval"
public static async Task<(RL_03e3cf3b917f5a94fbd0a8404cd2dee5,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdaFolioForApproval_CreatedOnDate,DateTime qpdaFolioForApproval_CreatedToDate,string qpteFolioForApproval_FolioNumber,string qpteFolioForApproval_OrderNumber,long qpreRegion_Id,int qpfoFolioStatus_Id,long qpsuSupplier_Id,int qpinOffsetUtc,bool qpboGetIsCorporativo,string qpteAppRoleListText,string qpteEntraRolesListText,long qpdeFolioApprovalLevel_DepartmentId,string qpusFolioApprovalLevel_AssignedTo,long qpreGetUserRegionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAE", "55f5ff86-004d-4948-9b1f-2c0c17498030");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEForApproval","j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAE");
// Query Iterations: Multiple
// Refresh Query TMtIqm7ns0iq77SyPhUk5A Iterations: Multiple
// Refresh Query JPNazjKfa0iY4y3WcGpsMA Iterations: Multiple
// Refresh Query wBQ3QLLuzEGNwDhdffJZMw Iterations: Multiple
// Refresh Query S3tCGe0JXUiaaI_asfpe+A Iterations: Multiple
// Refresh Query XzhPH5IBK0OlQHJrzZ9Yag Iterations: Multiple
// Refresh Query ayU5UNXRXkq0VoXstodEWg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.WPDOmKU6H0iy5RvpigxnpA/ScreenDataSets.hv_1VU0ASEmbHywMF0mAMA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapprovalstatus34\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enfolio108\".\"id\" o10, \"enfolio108\".\"isdraft\" o11, \"enfolio108\".\"folionumber\" o12, \"enfolio108\".\"canproveedorcancel\" o13, \"enfolio108\".\"orderid\" o14, \"enfolio108\".\"supplierid\" o15, \"enfolio108\".\"companyid\" o16, \"enfolio108\".\"foliostatusid\" o17, trim_scale(\"enfolio108\".\"totalamount\"::numeric) o18, trim_scale(\"enfolio108\".\"totaliva_amount\"::numeric) o19, trim_scale(\"enfolio108\".\"partialamount\"::numeric) o20, \"enfolio108\".\"currencyid\" o21, \"enfolio108\".\"firstapproveruserid\" o22, \"enfolio108\".\"approvalprocesstypeid\" o23, \"enfolio108\".\"sapentryerror\" o24, \"enfolio108\".\"createdby\" o25, \"enfolio108\".\"createdon\" o26, \"enfolio108\".\"updatedby\" o27, \"enfolio108\".\"updatedon\" o28, \"enfolio108\".\"minuteselected\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enfolioapprovallevel51\".\"id\" o40, \"enfolioapprovallevel51\".\"folioapprovalid\" o41, \"enfolioapprovallevel51\".\"levelnumber\" o42, \"enfolioapprovallevel51\".\"applicationroleid\" o43, \"enfolioapprovallevel51\".\"entrajobtitle\" o44, \"enfolioapprovallevel51\".\"entraroleid\" o45, \"enfolioapprovallevel51\".\"departmentid\" o46, \"enfolioapprovallevel51\".\"assignedto\" o47, \"enfolioapprovallevel51\".\"approvalstatusid\" o48, \"enfolioapprovallevel51\".\"ismandatory\" o49, \"enfolioapprovallevel51\".\"isreassigned\" o50, \"enfolioapprovallevel51\".\"approvedby\" o51, \"enfolioapprovallevel51\".\"approvedon\" o52, \"enfolioapprovallevel51\".\"canceledby\" o53, \"enfolioapprovallevel51\".\"canceledon\" o54, \"enfolioapprovallevel51\".\"rejectedby\" o55, \"enfolioapprovallevel51\".\"rejectedon\" o56, \"enfolioapprovallevel51\".\"issubstitutefor\" o57, \"enfolioapprovallevel51\".\"rejectreason\" o58, \"enfolioapprovallevel51\".\"isinvoiceapproval\" o59, NULL o60, \"enfoliostatus20\".\"label\" o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, \"enlastapprover1\".\"name\" o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, \"enordermain150\".\"ordernumber\" o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, \"enregion193\".\"code\" o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, \"ensupplier148\".\"name\" o135, \"ensupplier148\".\"number\" o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, (CASE WHEN (((\"enfolioapprovallevel51\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enfolioapprovallevel51\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(")) AND ((\"enfolio108\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(") OR (\"enfolio108\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"canapprove\", (CASE WHEN (\"enfolioapprovallevel51\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain150\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain150\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain150\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM ((((((((({Folio} \"enfolio108\" Left JOIN {FolioApproval} \"enfolioapproval55\" ON (\"enfolio108\".\"id\" = \"enfolioapproval55\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel51\" ON (\"enfolioapproval55\".\"id\" = \"enfolioapprovallevel51\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain150\" ON (\"enfolio108\".\"orderid\" = \"enordermain150\".\"id\"))  Left JOIN {Region} \"enregion193\" ON (\"enordermain150\".\"regionid\" = \"enregion193\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus20\" ON (\"enfolio108\".\"foliostatusid\" = \"enfoliostatus20\".\"id\"))  Left JOIN {Supplier} \"ensupplier148\" ON (\"enfolio108\".\"supplierid\" = \"ensupplier148\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus34\" ON (\"enfolioapprovallevel51\".\"approvalstatusid\" = \"enapprovalstatus34\".\"id\"))  Left JOIN {FolioApprovalLevel} \"enlastfolioapprovallevel\" ON ((\"enfolioapproval55\".\"id\" = \"enlastfolioapprovallevel\".\"folioapprovalid\") AND (\"enlastfolioapprovallevel\".\"levelnumber\" = (\"enfolioapproval55\".\"currentlevel\" - 1))))  Left JOIN {User} \"enlastapprover1\" ON (\"enlastfolioapprovallevel\".\"assignedto\" = \"enlastapprover1\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolioStatus_Id != BuiltInFunction.NullIdentifier()) {
if (qpfoFolioStatus_Id != 0) {
whereBuilder.Append("((\"enfoliostatus20\".\"id\" = @qpfoFolioStatus_Id) AND (\"enfoliostatus20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioStatus_Id", DbType.Int32, qpfoFolioStatus_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolioStatus_Id", DbType.Int32, qpfoFolioStatus_Id);
} else {
whereBuilder.Append("(\"enfoliostatus20\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteFolioForApproval_FolioNumber != "" && qpteFolioForApproval_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio108\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioForApproval_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioForApproval_FolioNumber", DbType.String, qpteFolioForApproval_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioForApproval_FolioNumber", DbType.String, qpteFolioForApproval_FolioNumber);
}
if (qpteFolioForApproval_OrderNumber != "" && qpteFolioForApproval_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain150\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioForApproval_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioForApproval_OrderNumber", DbType.String, qpteFolioForApproval_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioForApproval_OrderNumber", DbType.String, qpteFolioForApproval_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier148\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier148\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier148\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((@qpdaFolioForApproval_CreatedOnDate = (date '1900-01-01')) OR ((cast(((\"enfolio108\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaFolioForApproval_CreatedOnDate)) AND ((@qpdaFolioForApproval_CreatedToDate = (date '1900-01-01')) OR ((cast(((\"enfolio108\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaFolioForApproval_CreatedToDate))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioForApproval_CreatedOnDate", DbType.DateTime, qpdaFolioForApproval_CreatedOnDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioForApproval_CreatedOnDate", DbType.DateTime, qpdaFolioForApproval_CreatedOnDate);
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioForApproval_CreatedToDate", DbType.DateTime, qpdaFolioForApproval_CreatedToDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioForApproval_CreatedToDate", DbType.DateTime, qpdaFolioForApproval_CreatedToDate);
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion193\".\"id\" = @qpreRegion_Id) AND (\"enregion193\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion193\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((((\"enfolioapprovallevel51\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") OR (\"enfolioapprovallevel51\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
whereBuilder.Append(")) OR (\"enfolioapprovallevel51\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("w+wMayzP1kit5Zcgfd05+g"))).ssId);
whereBuilder.Append(")) AND ((CASE WHEN (\"enfolioapprovallevel51\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel51\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel51\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enfolioapprovallevel51\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel51\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel51\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel51\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel51\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain150\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain150\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain150\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval55\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval55\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval55\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel51\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel51\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel51\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel51\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1)) AND (NOT (\"enfolioapprovallevel51\".\"isinvoiceapproval\" = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "FolioStatus", "ApprovalStatus", "Supplier", "Region", "LastFolioApprovalLevel", "FolioApprovalLevel", "OrderMain", "Folio", "FolioApproval", "LastApprover" }, new string[] { "ENFolioStatus20", "ENApprovalStatus34", "ENSupplier148", "ENRegion193", "ENLastFolioApprovalLevel", "ENFolioApprovalLevel51", "ENOrderMain150", "ENFolio108", "ENFolioApproval55", "ENLastApprover1" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio108\".\"id\" DESC ");
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
RL_03e3cf3b917f5a94fbd0a8404cd2dee5 outParamList = new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_03e3cf3b917f5a94fbd0a8404cd2dee5 _tmp = new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_03e3cf3b917f5a94fbd0a8404cd2dee5)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetFolioStatus" M9fTc7aPlE6Mh9jEPp35hQ of Action "FoliosSAEForApproval"
public static async Task<(RL_ba9fc810801f4aabee0bc4ef3685a9dd,long)> datasetGetFolioStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEForApproval.GetFolioStatus", "73d3d733-8fb6-4e94-8c87-d8c43e9df985");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEForApproval","j_FoliosSAE.FoliosSAEForApproval.GetFolioStatus");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.WPDOmKU6H0iy5RvpigxnpA/ScreenDataSets.M9fTc7aPlE6Mh9jEPp35hQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliostatus21\".\"id\" o0, \"enfoliostatus21\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {FolioStatus} \"enfoliostatus21\"");
whereBuilder.Append(" WHERE ((\"enfoliostatus21\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
whereBuilder.Append(") OR (\"enfoliostatus21\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
whereBuilder.Append("))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApproval.GetFolioStatus.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApproval.GetFolioStatus.List", cancellationToken: cancellationToken);
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

private static async Task<RC_7bf0e8779480c1f841bf78e3626ee944> datasetGetFoliosSAEFullReadDbAsync(RC_7bf0e8779480c1f841bf78e3626ee944 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENLastApprover.Read( r, ref index);
rec.ssENLastFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssCanApprove = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.CanApprove", false);
rec.ssDontShowAction = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetFoliosSAEFull" LtRdhKMvtUaLBYERYbGawQ of Action "FoliosSAEForApproval"
public static async Task<(RL_03e3cf3b917f5a94fbd0a8404cd2dee5,long)> datasetGetFoliosSAEFull(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdaFolioForApproval_CreatedOnDate,DateTime qpdaFolioForApproval_CreatedToDate,string qpteFolioForApproval_FolioNumber,string qpteFolioForApproval_OrderNumber,long qpreRegion_Id,int qpfoFolioStatus_Id,long qpsuSupplier_Id,int qpinOffsetUtc,bool qpboGetIsCorporativo,string qpteAppRoleListText,string qpteEntraRolesListText,long qpdeFolioApprovalLevel_DepartmentId,string qpusFolioApprovalLevel_AssignedTo,long qpreGetUserRegionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAEFull", "845dd42e-2fa3-46b5-8b05-811161b19ac1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEForApproval","j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAEFull");
// Query Iterations: Multiple
// Refresh Query mBqboPehU0OYCpmTK6XlXw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.WPDOmKU6H0iy5RvpigxnpA/ScreenDataSets.LtRdhKMvtUaLBYERYbGawQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfolio109\".\"folionumber\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, trim_scale(\"enfolio109\".\"totalamount\"::numeric) o18, NULL o19, NULL o20, \"enfolio109\".\"currencyid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enfolio109\".\"createdon\" o26, NULL o27, NULL o28, NULL o29, NULL o30, \"enfolioapproval56\".\"folioid\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, \"enfoliostatus22\".\"label\" o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, \"enordermain151\".\"ordernumber\" o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, \"enregion194\".\"code\" o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, \"ensupplier149\".\"name\" o135, \"ensupplier149\".\"number\" o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, (CASE WHEN (((\"enfolioapprovallevel52\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enfolioapprovallevel52\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(")) AND ((\"enfolio109\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(") OR (\"enfolio109\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"canapprove\", (CASE WHEN (\"enfolioapprovallevel52\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain151\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain151\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain151\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM ((((((((({Folio} \"enfolio109\" Left JOIN {FolioApproval} \"enfolioapproval56\" ON (\"enfolio109\".\"id\" = \"enfolioapproval56\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel52\" ON (\"enfolioapproval56\".\"id\" = \"enfolioapprovallevel52\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain151\" ON (\"enfolio109\".\"orderid\" = \"enordermain151\".\"id\"))  Left JOIN {Region} \"enregion194\" ON (\"enordermain151\".\"regionid\" = \"enregion194\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus22\" ON (\"enfolio109\".\"foliostatusid\" = \"enfoliostatus22\".\"id\"))  Left JOIN {Supplier} \"ensupplier149\" ON (\"enfolio109\".\"supplierid\" = \"ensupplier149\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus35\" ON (\"enfolioapprovallevel52\".\"approvalstatusid\" = \"enapprovalstatus35\".\"id\"))  Left JOIN {FolioApprovalLevel} \"enlastfolioapprovallevel1\" ON ((\"enfolioapproval56\".\"id\" = \"enlastfolioapprovallevel1\".\"folioapprovalid\") AND (\"enlastfolioapprovallevel1\".\"levelnumber\" = (\"enfolioapproval56\".\"currentlevel\" - 1))))  Left JOIN {User} \"enlastapprover2\" ON (\"enlastfolioapprovallevel1\".\"assignedto\" = \"enlastapprover2\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolioStatus_Id != BuiltInFunction.NullIdentifier()) {
if (qpfoFolioStatus_Id != 0) {
whereBuilder.Append("((\"enfoliostatus22\".\"id\" = @qpfoFolioStatus_Id) AND (\"enfoliostatus22\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioStatus_Id", DbType.Int32, qpfoFolioStatus_Id);
} else {
whereBuilder.Append("(\"enfoliostatus22\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteFolioForApproval_FolioNumber != "" && qpteFolioForApproval_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio109\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioForApproval_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioForApproval_FolioNumber", DbType.String, qpteFolioForApproval_FolioNumber);
}
if (qpteFolioForApproval_OrderNumber != "" && qpteFolioForApproval_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain151\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioForApproval_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioForApproval_OrderNumber", DbType.String, qpteFolioForApproval_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier149\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier149\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier149\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((@qpdaFolioForApproval_CreatedOnDate = (date '1900-01-01')) OR ((cast(((\"enfolio109\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaFolioForApproval_CreatedOnDate)) AND ((@qpdaFolioForApproval_CreatedToDate = (date '1900-01-01')) OR ((cast(((\"enfolio109\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaFolioForApproval_CreatedToDate))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioForApproval_CreatedOnDate", DbType.DateTime, qpdaFolioForApproval_CreatedOnDate);
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioForApproval_CreatedToDate", DbType.DateTime, qpdaFolioForApproval_CreatedToDate);
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion194\".\"id\" = @qpreRegion_Id) AND (\"enregion194\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion194\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((((\"enfolioapprovallevel52\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") OR (\"enfolioapprovallevel52\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
whereBuilder.Append(")) OR (\"enfolioapprovallevel52\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("w+wMayzP1kit5Zcgfd05+g"))).ssId);
whereBuilder.Append(")) AND ((CASE WHEN (\"enfolioapprovallevel52\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel52\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel52\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enfolioapprovallevel52\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel52\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel52\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel52\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel52\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain151\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain151\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain151\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval56\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval56\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval56\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel52\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel52\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel52\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel52\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1)) AND (NOT (\"enfolioapprovallevel52\".\"isinvoiceapproval\" = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Folio", "OrderMain", "FolioApprovalLevel", "ApprovalStatus", "Supplier", "Region", "FolioStatus", "FolioApproval", "LastFolioApprovalLevel", "LastApprover" }, new string[] { "ENFolio109", "ENOrderMain151", "ENFolioApprovalLevel52", "ENApprovalStatus35", "ENSupplier149", "ENRegion194", "ENFolioStatus22", "ENFolioApproval56", "ENLastFolioApprovalLevel1", "ENLastApprover2" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio109\".\"id\" DESC ");
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
RL_03e3cf3b917f5a94fbd0a8404cd2dee5 outParamList = new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAEFullReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, false, true, true, false, true, true, true, true, false, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAEFull.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_03e3cf3b917f5a94fbd0a8404cd2dee5 _tmp = new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAEFullReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApproval.GetFoliosSAEFull.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_03e3cf3b917f5a94fbd0a8404cd2dee5)_tmp;
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
// Query Function "GetRegions" TZa+36bT_kOFCV4Yqc3rQQ of Action "FoliosSAEForApproval"
public static async Task<(RL_07bd6e6f32ae098d324b78b5f3777516,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAEForApproval.GetRegions", "dfbe964d-d3a6-43fe-8509-5e18a9cdeb41");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAEForApproval","j_FoliosSAE.FoliosSAEForApproval.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.WPDOmKU6H0iy5RvpigxnpA/ScreenDataSets.TZa+36bT_kOFCV4Yqc3rQQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion195\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, ((\"enregion195\".\"code\" || ' ') || \"enregion195\".\"name\") \"region_text\"");
fromBuilder.Append(" FROM {Region} \"enregion195\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (\"enregion195\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApproval.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApproval.GetRegions.List", cancellationToken: cancellationToken);
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


    public class lcvGetUserApplicationRoles : VarsBag {
public int resListIndexOf_outParamPosition = 0;

public RL_87311ea350338b4dcd53388d23fa3f86 queryResGetUserApplicationRoleTempActive_outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
public long queryResGetUserApplicationRoleTempActive_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

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
ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "5a69ff78-2836-43bc-82e7-832d8a9e3404"))
using (activitySource.CreateScreenDataActionActivity("FoliosSAEForApproval", "GetUserApplicationRoles")){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetUserApplicationRoleTempActive
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempActive_maxRecords = 0;
int datasetGetUserApplicationRoleTempActive_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempActive_outParamList,localVars.queryResGetUserApplicationRoleTempActive_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetUserApplicationRoleTempActive(requestContext,datasetGetUserApplicationRoleTempActive_maxRecords,datasetGetUserApplicationRoleTempActive_startIndex,IterationMultiplicity.Single,BuiltInFunction.GetUserId (),cancellationToken);

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

// Foreach GetUserApplicationRoleTempActive.List
localVars.queryResGetUserApplicationRoleTempActive_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserApplicationRoleTempActive_outParamList.Eof))) {
// EntraRolesListText = EntraRolesListText + "," + GetUserApplicationRoleTempActive.List.Current.UserApplicationRoleTemp.EntraRoleId
result.outParamEntraRolesListText=((result.outParamEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetUserApplicationRoleTempActive_outParamList.CurrentRec.ssENUserApplicationRoleTemp.ssEntraRoleId));
localVars.queryResGetUserApplicationRoleTempActive_outParamList.Advance();
}

} finally {
localVars.queryResGetUserApplicationRoleTempActive_outParamList.EndIteration();
}

// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => p.ssENApplicationRole.ssCanBulkApproveFolios,cancellationToken);

// CanBulkApprove = ListIndexOf.Position <> -1
result.outParamCanBulkApprove=(localVars.resListIndexOf_outParamPosition!=(-1));
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

// Query Function "GetUserApplicationRoleTempActive" SsCFdlGt30KrO3eYfK_g2A of Action "GetUserApplicationRoles"
public static async Task<(RL_87311ea350338b4dcd53388d23fa3f86,long)> datasetGetUserApplicationRoleTempActive(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "7685c04a-ad51-42df-ab3b-77987cafe0d8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "7685c04a-ad51-42df-ab3b-77987cafe0d8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.WPDOmKU6H0iy5RvpigxnpA/DataActions.eP9pWjYovEOC54Mtip40BA/NodesNotShownInESpaceTree.SsCFdlGt30KrO3eYfK_g2A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enuserapplicationroletemp16\".\"entraroleid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {UserApplicationRoleTemp} \"enuserapplicationroletemp16\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp16\".\"userid\" = @qpusUserId) AND (\"enuserapplicationroletemp16\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp16\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp16\".\"rolestatusid\" = ");
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
RL_87311ea350338b4dcd53388d23fa3f86 outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_87311ea350338b4dcd53388d23fa3f86 _tmp = new RL_87311ea350338b4dcd53388d23fa3f86();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_87311ea350338b4dcd53388d23fa3f86)_tmp;
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
// Query Function "GetRoleConcept" XUEJqxKFGkeDDm9e2Bn_OQ of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetRoleConcept", "ab09415d-8512-471a-830e-6f5ed819ff39");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetRoleConcept", "ab09415d-8512-471a-830e-6f5ed819ff39", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.WPDOmKU6H0iy5RvpigxnpA/DataActions.eP9pWjYovEOC54Mtip40BA/NodesNotShownInESpaceTree.XUEJqxKFGkeDDm9e2Bn_OQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole92\".\"code\" o1, \"enapplicationrole92\".\"name\" o2, NULL o3, NULL o4, NULL o5, \"enapplicationrole92\".\"canbulkapprovefolios\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept37\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal143\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal143\" Inner JOIN {User} \"enuser245\" ON (\"enuser_extended_internal143\".\"id\" = \"enuser245\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole88\" ON (\"enuser_extended_internal143\".\"jobtitle\" = \"enentrarole88\".\"rolename\"))  Left JOIN {Region} \"enregion196\" ON (\"enuser_extended_internal143\".\"regionid\" = \"enregion196\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept37\" ON (\"enentrarole88\".\"id\" = \"enroleconcept37\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole92\" ON (\"enroleconcept37\".\"applicationroleid\" = \"enapplicationrole92\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser245\".\"id\" = @qpusUser_Id) AND (\"enuser245\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser245\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept37\".\"conceptid\" = ");
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
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAEForApproval.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
