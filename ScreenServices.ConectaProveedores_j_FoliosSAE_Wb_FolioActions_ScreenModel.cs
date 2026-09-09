using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel).Namespace);

    public long inParami_FolioId;
public bool inParami_DirectReport;
public string varLcl_PopupTitle;
public bool varLcl_ShowPopUp;
public bool varLcl_ShowApprovePopup;
public bool varLcl_ShowEstablishFlowPopup;
public bool varLcl_ShowReassignPopup;
public bool varLcl_ShowCompleteEntryPopup;
public bool varLcl_ShowResendEntryPopup;
public bool varLcl_EvidenceRequest;
public bool varLcl_Reject;
public bool varLcl_Comment;
public bool varLcl_Cancel;
public bool varLcl_IsFirstApprover;
public bool varLcI_ShowCancelPopup;
public bool varLcl_ShowIncorrectAssignmentPopup;
public bool varLcl_ShowReassignFolioFromRejectPopup;
public AggregateRecord<RL_eed3c87ea3369e022265db9ef075a8c7> ScreenDataSetGetFolioApprovalLevelById;
public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Model varLcGetFolioTypeDA;
public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Model varLcGetUserInfo;
public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel(long inParami_FolioId, bool inParami_DirectReport, string varLcl_PopupTitle, bool varLcl_ShowPopUp, bool varLcl_ShowApprovePopup, bool varLcl_ShowEstablishFlowPopup, bool varLcl_ShowReassignPopup, bool varLcl_ShowCompleteEntryPopup, bool varLcl_ShowResendEntryPopup, bool varLcl_EvidenceRequest, bool varLcl_Reject, bool varLcl_Comment, bool varLcl_Cancel, bool varLcl_IsFirstApprover, bool varLcI_ShowCancelPopup, bool varLcl_ShowIncorrectAssignmentPopup, bool varLcl_ShowReassignFolioFromRejectPopup, AggregateRecord<RL_eed3c87ea3369e022265db9ef075a8c7> ScreenDataSetGetFolioApprovalLevelById, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Model varLcGetFolioTypeDA, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Model varLcGetUserInfo, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "i_DirectReport", "l_PopupTitle", "l_ShowPopUp", "l_ShowApprovePopup", "l_ShowEstablishFlowPopup", "l_ShowReassignPopup", "l_ShowCompleteEntryPopup", "l_ShowResendEntryPopup", "l_EvidenceRequest", "l_Reject", "l_Comment", "l_Cancel", "l_IsFirstApprover", "I_ShowCancelPopup", "l_ShowIncorrectAssignmentPopup", "l_ShowReassignFolioFromRejectPopup", "GetFolioApprovalLevelById", "GetFolioTypeDA", "GetUserInfo", "GetUserApplicationRoles", "ClientVars"}, new string[] {"inParami_FolioId", "inParami_DirectReport", "varLcl_PopupTitle", "varLcl_ShowPopUp", "varLcl_ShowApprovePopup", "varLcl_ShowEstablishFlowPopup", "varLcl_ShowReassignPopup", "varLcl_ShowCompleteEntryPopup", "varLcl_ShowResendEntryPopup", "varLcl_EvidenceRequest", "varLcl_Reject", "varLcl_Comment", "varLcl_Cancel", "varLcl_IsFirstApprover", "varLcI_ShowCancelPopup", "varLcl_ShowIncorrectAssignmentPopup", "varLcl_ShowReassignFolioFromRejectPopup", "ScreenDataSetGetFolioApprovalLevelById", "varLcGetFolioTypeDA", "varLcGetUserInfo", "varLcGetUserApplicationRoles", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.inParami_DirectReport = inParami_DirectReport;
this.varLcl_PopupTitle = varLcl_PopupTitle;
this.varLcl_ShowPopUp = varLcl_ShowPopUp;
this.varLcl_ShowApprovePopup = varLcl_ShowApprovePopup;
this.varLcl_ShowEstablishFlowPopup = varLcl_ShowEstablishFlowPopup;
this.varLcl_ShowReassignPopup = varLcl_ShowReassignPopup;
this.varLcl_ShowCompleteEntryPopup = varLcl_ShowCompleteEntryPopup;
this.varLcl_ShowResendEntryPopup = varLcl_ShowResendEntryPopup;
this.varLcl_EvidenceRequest = varLcl_EvidenceRequest;
this.varLcl_Reject = varLcl_Reject;
this.varLcl_Comment = varLcl_Comment;
this.varLcl_Cancel = varLcl_Cancel;
this.varLcl_IsFirstApprover = varLcl_IsFirstApprover;
this.varLcI_ShowCancelPopup = varLcI_ShowCancelPopup;
this.varLcl_ShowIncorrectAssignmentPopup = varLcl_ShowIncorrectAssignmentPopup;
this.varLcl_ShowReassignFolioFromRejectPopup = varLcl_ShowReassignFolioFromRejectPopup;
this.ScreenDataSetGetFolioApprovalLevelById = ScreenDataSetGetFolioApprovalLevelById;
this.varLcGetFolioTypeDA = varLcGetFolioTypeDA;
this.varLcGetUserInfo = varLcGetUserInfo;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_e278706027049cb67d7e751f6d362f51> datasetGetFolioApprovalLevelByIdReadDbAsync(RC_e278706027049cb67d7e751f6d362f51 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssShowActions = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelOrderMainShowActionsRecord.ShowActions", false);
return rec;
}
// Query Function "GetFolioApprovalLevelById" tmlNc0Yo40CJCPyAgJZHJA of Action "Wb_FolioActions"
public static async Task<(RL_eed3c87ea3369e022265db9ef075a8c7,long)> datasetGetFolioApprovalLevelById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckDesviacionesRole,bool qpboCheckProveedorRole,bool qpboCheckUserSession,bool qpboGetIsCorporativo,string qpteEntraRolesListText,long qpenFolioApprovalLevel_EntraRoleId,string qpusGetUserId,long qpreGetUserRegionId,long qpapFolioApprovalLevel_ApplicationRoleId,long qpapFolioApprovalLevel_ApplicationRoleId1,long qpsuFolio_SupplierId,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioActions.GetFolioApprovalLevelById", "734d69b6-2846-40e3-8908-fc8080964724");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioActions","j_FoliosSAE.Wb_FolioActions.GetFolioApprovalLevelById");
// Query Iterations: Never
// Refresh Query vgtXTieMok6lRcw7ufnsHA Iterations: Never
// Refresh Query qCfmlU4EqUe+le_9Bra_ug Iterations: Never
// Refresh Query GYx_mSteskecWGaBPj1vSg Iterations: Never
// Refresh Query HUgl4NgkL0uHAFw1dH52YQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.N3OnNxr3QUeYJ4p9Y0nTPw/ScreenDataSets.tmlNc0Yo40CJCPyAgJZHJA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency46\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, trim_scale(\"enfolio87\".\"totalamount\"::numeric) o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enfolioapprovallevel46\".\"id\" o35, NULL o36, \"enfolioapprovallevel46\".\"levelnumber\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, \"enfolioapprovallevel46\".\"isinvoiceapproval\" o54, \"enfoliostatus16\".\"id\" o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, (CASE WHEN ((((\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") AND (\"enfolio87\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(")) OR ((\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(") AND (\"enfolio87\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) OR ((\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") AND (\"enfolio87\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("ZfpLpTdXy0CRfRTjg6qPeA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"showactions\"");
fromBuilder.Append(" FROM (((((({Folio} \"enfolio87\" Left JOIN {FolioStatus} \"enfoliostatus16\" ON (\"enfolio87\".\"foliostatusid\" = \"enfoliostatus16\".\"id\"))  Left JOIN {FolioApproval} \"enfolioapproval50\" ON (\"enfolio87\".\"id\" = \"enfolioapproval50\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel46\" ON (((\"enfolioapproval50\".\"id\" = \"enfolioapprovallevel46\".\"folioapprovalid\") AND ((CASE WHEN (\"enfolioapprovallevel46\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel46\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel46\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((((");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel46\".\"approvedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel46\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(" OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel46\".\"canceledby\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel46\".\"canceledby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel46\".\"rejectedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel46\".\"rejectedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if (qpapFolioApprovalLevel_ApplicationRoleId != 0) {
fromBuilder.Append("((\"enfolioapprovallevel46\".\"applicationroleid\" = @qpapFolioApprovalLevel_ApplicationRoleId) AND (\"enfolioapprovallevel46\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapFolioApprovalLevel_ApplicationRoleId", DbType.Int64, qpapFolioApprovalLevel_ApplicationRoleId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel46\".\"applicationroleid\" IS NULL)");
}
fromBuilder.Append(") OR ");
if (qpenFolioApprovalLevel_EntraRoleId != 0) {
fromBuilder.Append("((\"enfolioapprovallevel46\".\"entraroleid\" = @qpenFolioApprovalLevel_EntraRoleId) AND (\"enfolioapprovallevel46\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenFolioApprovalLevel_EntraRoleId", DbType.Int64, qpenFolioApprovalLevel_EntraRoleId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel46\".\"entraroleid\" IS NULL)");
}
fromBuilder.Append(") OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel46\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel46\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) THEN 1 ELSE 0 END) END) = 1)) AND (((((\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
fromBuilder.Append(") OR (\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
fromBuilder.Append(")) OR (\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId);
fromBuilder.Append(")) OR (\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("w+wMayzP1kit5Zcgfd05+g"))).ssId);
fromBuilder.Append(")) OR (\"enfolioapprovallevel46\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
fromBuilder.Append("))))  Left JOIN {OrderMain} \"enordermain129\" ON (\"enfolio87\".\"orderid\" = \"enordermain129\".\"id\"))  Left JOIN {Invoice} \"eninvoice148\" ON (\"enfolio87\".\"id\" = \"eninvoice148\".\"folioid\"))  Left JOIN {Currency} \"encurrency46\" ON (\"enfolio87\".\"currencyid\" = \"encurrency46\".\"code\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio87\".\"id\" = @qpfoFolio_Id) AND (\"enfolio87\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio87\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboCheckProveedorRole = 1) THEN (CASE WHEN (");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
if (qpsuFolio_SupplierId != 0) {
whereBuilder.Append("((\"enfolio87\".\"supplierid\" = @qpsuFolio_SupplierId) AND (\"enfolio87\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuFolio_SupplierId", DbType.Int64, qpsuFolio_SupplierId);
} else {
whereBuilder.Append("(\"enfolio87\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpsuFolio_SupplierId <> 0)) THEN 1 ELSE 0 END) ELSE (CASE WHEN (@qpboCheckDesviacionesRole = 1) THEN 1 ELSE (CASE WHEN ((\"enfolioapprovallevel46\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (((((CASE WHEN (\"enfolioapprovallevel46\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpsuFolio_SupplierId", DbType.Int64, qpsuFolio_SupplierId);
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckDesviacionesRole", DbType.Boolean, qpboCheckDesviacionesRole);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel46\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel46\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((");
if (qpapFolioApprovalLevel_ApplicationRoleId1 != 0) {
whereBuilder.Append("((\"enfolioapprovallevel46\".\"applicationroleid\" = @qpapFolioApprovalLevel_ApplicationRoleId1) AND (\"enfolioapprovallevel46\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapFolioApprovalLevel_ApplicationRoleId1", DbType.Int64, qpapFolioApprovalLevel_ApplicationRoleId1);
} else {
whereBuilder.Append("(\"enfolioapprovallevel46\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpenFolioApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel46\".\"entraroleid\" = @qpenFolioApprovalLevel_EntraRoleId) AND (\"enfolioapprovallevel46\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenFolioApprovalLevel_EntraRoleId", DbType.Int64, qpenFolioApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel46\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(") OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel46\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel46\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain129\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain129\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain129\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval50\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval50\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval50\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel46\".\"approvedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel46\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel46\".\"rejectedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel46\".\"rejectedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel46\".\"canceledby\" = @qpusGetUserId) AND (\"enfolioapprovallevel46\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel46\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel46\".\"levelnumber\" DESC ");
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
RL_eed3c87ea3369e022265db9ef075a8c7 outParamList = new RL_eed3c87ea3369e022265db9ef075a8c7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioActions.GetFolioApprovalLevelById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_eed3c87ea3369e022265db9ef075a8c7 _tmp = new RL_eed3c87ea3369e022265db9ef075a8c7();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioActions.GetFolioApprovalLevelById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eed3c87ea3369e022265db9ef075a8c7)_tmp;
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


    public class lcvGetFolioTypeDA : VarsBag {
public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioType_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioType_outParamCount = 0L;

public lcvGetFolioTypeDA() {
}
}
public class lcoGetFolioTypeDA : VarsBag {
public bool outParamo_ShowOptions = false;

public bool outParamo_IsActiveDEV_HU13045 = false;

public lcoGetFolioTypeDA() {
}
}
/// <summary>
/// Action <code>GetFolioTypeDA</code> that represents the Service Studio action
///  <code>GetFolioTypeDA</code> <p> Description: </p>
/// </summary>
public async Task<(bool,bool)> DataActionGetFolioTypeDA(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_ShowOptions = default;
bool outParamo_IsActiveDEV_HU13045 = default;
lcoGetFolioTypeDA result = new lcoGetFolioTypeDA();
lcvGetFolioTypeDA localVars = new lcvGetFolioTypeDA();
ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolioTypeDA", "31f0c045-7fef-4ca3-a9b8-12ea129b4ae8"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioActions", "GetFolioTypeDA")){
// Query datasetGetFolioType
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioType_maxRecords = 1;
if (datasetGetFolioType_maxRecords < 1) datasetGetFolioType_maxRecords = 1;
int datasetGetFolioType_startIndex = 0;(localVars.queryResGetFolioType_outParamList,localVars.queryResGetFolioType_outParamCount) = await FuncDataActionGetFolioTypeDA.datasetGetFolioType(requestContext,datasetGetFolioType_maxRecords,datasetGetFolioType_startIndex,IterationMultiplicity.Never,inParami_FolioId,cancellationToken);

// GetFolioType.Empty?
if((localVars.queryResGetFolioType_outParamList.Empty)) {
// O_SetVisible = True
// o_ShowOptions = True
result.outParamo_ShowOptions=true;
} else {
// O_SetVisible = False
// o_ShowOptions = False
result.outParamo_ShowOptions=false;
}

// o_IsActiveDEV_HU13045 = IsActiveDEV_HU13045
result.outParamo_IsActiveDEV_HU13045=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13045])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_ShowOptions = result.outParamo_ShowOptions;
outParamo_IsActiveDEV_HU13045 = result.outParamo_IsActiveDEV_HU13045;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_ShowOptions,outParamo_IsActiveDEV_HU13045);
}
public class lcvGetUserInfo : VarsBag {
public RL_7ee55cfd657529e0c1a187beec22d18a queryResGetUserExtendedInternals_outParamList = new RL_7ee55cfd657529e0c1a187beec22d18a();
public long queryResGetUserExtendedInternals_outParamCount = 0L;

public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetFolioApprovalsByFolioId_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetFolioApprovalsByFolioId_outParamCount = 0L;

public lcvGetUserInfo() {
}
}
public class lcoGetUserInfo : VarsBag {
public bool outParamIsAllowedCancelFolio = false;

public bool outParamIsAllowedReassign = false;

public lcoGetUserInfo() {
}
}
/// <summary>
/// Action <code>GetUserInfo</code> that represents the Service Studio action <code>GetUserInfo</code>
///  <p> Description: </p>
/// </summary>
public async Task<(bool,bool)> DataActionGetUserInfo(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsAllowedCancelFolio = default;
bool outParamIsAllowedReassign = default;
lcoGetUserInfo result = new lcoGetUserInfo();
lcvGetUserInfo localVars = new lcvGetUserInfo();
ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserInfo", "52a76b7e-55ed-49e0-aa02-8e39a7876df4"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioActions", "GetUserInfo")){
// Query datasetGetUserExtendedInternals
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternals_maxRecords = 1;
if (datasetGetUserExtendedInternals_maxRecords < 1) datasetGetUserExtendedInternals_maxRecords = 1;
int datasetGetUserExtendedInternals_startIndex = 0;(localVars.queryResGetUserExtendedInternals_outParamList,localVars.queryResGetUserExtendedInternals_outParamCount) = await FuncDataActionGetUserInfo.datasetGetUserExtendedInternals(requestContext,datasetGetUserExtendedInternals_maxRecords,datasetGetUserExtendedInternals_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetFolioApprovalsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalsByFolioId_maxRecords = 1;
if (datasetGetFolioApprovalsByFolioId_maxRecords < 1) datasetGetFolioApprovalsByFolioId_maxRecords = 1;
int datasetGetFolioApprovalsByFolioId_startIndex = 0;(localVars.queryResGetFolioApprovalsByFolioId_outParamList,localVars.queryResGetFolioApprovalsByFolioId_outParamCount) = await FuncDataActionGetUserInfo.datasetGetFolioApprovalsByFolioId(requestContext,datasetGetFolioApprovalsByFolioId_maxRecords,datasetGetFolioApprovalsByFolioId_startIndex,IterationMultiplicity.Never,inParami_FolioId,cancellationToken);

// IsAllowedCancelFolio = Index <> -1 or Index <> -1
result.outParamIsAllowedCancelFolio=((BuiltInFunction.IndexSC (localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssRoleName, "JEFE DE ALMACEN DE MATERIALES CON 3ROS", 0, false, true)!=(-1))||(BuiltInFunction.IndexSC (localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssRoleName, "SUPERVISOR DE ALMACEN DE MATERIALES CON 3ROS", 0, false, true)!=(-1)));

// IsAllowedReassign = notGetFolioApprovalsByFolioId.List.Empty and CheckAlmacenRole() and IsActiveDEV_HU13045
result.outParamIsAllowedReassign=(((!localVars.queryResGetFolioApprovalsByFolioId_outParamList.Empty)&&(await Functions.ssCheckAlmacenRole(requestContext,"",cancellationToken)))&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13045]))));
} //close CreateActionActivity using block
} // try

finally {
outParamIsAllowedCancelFolio = result.outParamIsAllowedCancelFolio;
outParamIsAllowedReassign = result.outParamIsAllowedReassign;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsAllowedCancelFolio,outParamIsAllowedReassign);
}
public class lcvGetUserApplicationRoles : VarsBag {
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

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,string)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRoleListText = default;
string outParamEntraRolesListText = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "d1e5daec-8cee-4b1b-903f-ff25904bba78"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioActions", "GetUserApplicationRoles")){
if((!((await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken))))) {
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

}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamAppRoleListText = result.outParamAppRoleListText;
outParamEntraRolesListText = result.outParamEntraRolesListText;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText);
}


    public static class FuncDataActionGetFolioTypeDA {

// Query Function "GetFolioType" slR5bX_8Jk27_DzQpR2dcw of Action "GetFolioTypeDA"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioType(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioActions.GetFolioTypeDA.GetFolioType", "6d7954b2-fc7f-4d26-bbfc-3cd0a51d9d73");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioActions.GetFolioTypeDA.GetFolioType", "6d7954b2-fc7f-4d26-bbfc-3cd0a51d9d73", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.N3OnNxr3QUeYJ4p9Y0nTPw/DataActions.RcDwMe9_o0ypuBLqEptK6A/NodesNotShownInESpaceTree.slR5bX_8Jk27_DzQpR2dcw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio88\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio88\".\"id\" = @qpfoId) AND (\"enfolio88\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio88\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolio88\".\"approvalprocesstypeid\" = ");
whereBuilder.Append(1
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioActions.GetFolioTypeDA.GetFolioType.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioActions.GetFolioTypeDA.GetFolioType.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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
public static class FuncDataActionGetUserInfo {

// Query Function "GetUserExtendedInternals" LFiBOUyLdUmmceY9C2hxEg of Action "GetUserInfo"
public static async Task<(RL_7ee55cfd657529e0c1a187beec22d18a,long)> datasetGetUserExtendedInternals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetUserExtendedInternals", "3981582c-8b4c-4975-a671-e63d0b687112");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetUserExtendedInternals", "3981582c-8b4c-4975-a671-e63d0b687112", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.N3OnNxr3QUeYJ4p9Y0nTPw/DataActions.fmunUu1V4EmqAo45p4dt9A/NodesNotShownInESpaceTree.LFiBOUyLdUmmceY9C2hxEg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole81\".\"rolename\" \"rolename\"");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal136\" Inner JOIN {User} \"enuser230\" ON (\"enuser_extended_internal136\".\"id\" = \"enuser230\".\"id\"))  Left JOIN {EntraRole} \"enentrarole81\" ON (\"enuser_extended_internal136\".\"entraroleid\" = \"enentrarole81\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser230\".\"id\" = @qpusUser_Id) AND (\"enuser230\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser230\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enentrarole81\".\"rolename\"");
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
RL_7ee55cfd657529e0c1a187beec22d18a outParamList = new RL_7ee55cfd657529e0c1a187beec22d18a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7ee55cfd657529e0c1a187beec22d18a _tmp = new RL_7ee55cfd657529e0c1a187beec22d18a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7ee55cfd657529e0c1a187beec22d18a)_tmp;
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

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalsByFolioIdReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalsByFolioId" tl849HbLkUC5fWCK6Pwd1A of Action "GetUserInfo"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetFolioApprovalsByFolioId", "f4385fb6-cb76-4091-b97d-608ae8fc1dd4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetFolioApprovalsByFolioId", "f4385fb6-cb76-4091-b97d-608ae8fc1dd4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.N3OnNxr3QUeYJ4p9Y0nTPw/DataActions.fmunUu1V4EmqAo45p4dt9A/NodesNotShownInESpaceTree.tl849HbLkUC5fWCK6Pwd1A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval51\" Inner JOIN {FolioApprovalLevel} \"enfolioapprovallevel47\" ON ((\"enfolioapproval51\".\"id\" = \"enfolioapprovallevel47\".\"folioapprovalid\") AND (\"enfolioapprovallevel47\".\"rejectreason\" <> ''))) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval51\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval51\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval51\".\"folioid\" IS NULL)");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioActions.GetUserInfo.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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
public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetUserApplicationRoleTempActive" 3VeIJw+FWUWIza6yUsVlkg of Action "GetUserApplicationRoles"
public static async Task<(RL_87311ea350338b4dcd53388d23fa3f86,long)> datasetGetUserApplicationRoleTempActive(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "278857dd-850f-4559-88cd-aeb252c56592");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "278857dd-850f-4559-88cd-aeb252c56592", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.N3OnNxr3QUeYJ4p9Y0nTPw/DataActions.7Nrl0e6MG0uQP_8lkEu6eA/NodesNotShownInESpaceTree.3VeIJw+FWUWIza6yUsVlkg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enuserapplicationroletemp14\".\"entraroleid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {UserApplicationRoleTemp} \"enuserapplicationroletemp14\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp14\".\"userid\" = @qpusUserId) AND (\"enuserapplicationroletemp14\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp14\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp14\".\"rolestatusid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
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
// Query Function "GetRoleConcept" CKNggTUBwkejG43GwiJSgg of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetRoleConcept", "8160a308-0135-47c2-a31b-8dc6c2225282");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetRoleConcept", "8160a308-0135-47c2-a31b-8dc6c2225282", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.N3OnNxr3QUeYJ4p9Y0nTPw/DataActions.7Nrl0e6MG0uQP_8lkEu6eA/NodesNotShownInESpaceTree.CKNggTUBwkejG43GwiJSgg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole89\".\"code\" o1, \"enapplicationrole89\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept35\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal137\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal137\" Inner JOIN {User} \"enuser231\" ON (\"enuser_extended_internal137\".\"id\" = \"enuser231\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole82\" ON (\"enuser_extended_internal137\".\"jobtitle\" = \"enentrarole82\".\"rolename\"))  Left JOIN {Region} \"enregion183\" ON (\"enuser_extended_internal137\".\"regionid\" = \"enregion183\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept35\" ON (\"enentrarole82\".\"id\" = \"enroleconcept35\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole89\" ON (\"enroleconcept35\".\"applicationroleid\" = \"enapplicationrole89\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser231\".\"id\" = @qpusUser_Id) AND (\"enuser231\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser231\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept35\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioActions.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
