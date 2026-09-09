using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Invoices_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Invoices_ScreenModel).Namespace);

    public long varLcl_ApplicationRoleIdForAggregate;
public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_IsAllowSelectApplicationRoles;
public bool varLcl_ReInvokeToggler;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public bool varLcl_IsShowSelectAll;
public bool varLcl_IsSelectAll;
public bool varLcl_IsSelectedForApproval;
public bool varLcl_IsSelectAllForApproval;
public bool varLcl_IsSelectedForAssignment;
public bool varLcl_IsSelectAllForAssignment;
public bool varLcl_ShowBulkRejectPopup;
public long varLcl_InvoiceId;
public RL_09457db01df0de3852b9312cdd42fb2a varLcl_InvoiceApprovalLevelList;
public long varLcl_InvoiceApprovalLevelId;
public bool varLcl_ShowBulkApproveInvoices;
public bool varLcl_ShowApproveInvoice;
public bool varLcl_ShowRejectInvoice;
public bool varLcl_ShowAssignFirstApproverPopup;
public bool varLcl_ShowBulkComment;
public bool varLcl_ShowComment;
public bool varLcl_ShowAssignAnalistaPopup;
public ST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent;
public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError;
public BasicTypeList<long> varLcl_InvoicesTablesIdList;
public bool varLcl_ShowScreenTableDownloads;
public bool varLcIsListFullNeedRefresh;
public AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ScreenDataSetGetInvoices;
public AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ScreenDataSetGetInvoicesFull;
public AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public ConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Model varLcGetInvoiceCountToAssign;
public ConectaProveedores_d_Invoices_Invoices_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Invoices_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Invoices_ScreenModel(long varLcl_ApplicationRoleIdForAggregate, string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, bool varLcl_IsShowSelectAll, bool varLcl_IsSelectAll, bool varLcl_IsSelectedForApproval, bool varLcl_IsSelectAllForApproval, bool varLcl_IsSelectedForAssignment, bool varLcl_IsSelectAllForAssignment, bool varLcl_ShowBulkRejectPopup, long varLcl_InvoiceId, RL_09457db01df0de3852b9312cdd42fb2a varLcl_InvoiceApprovalLevelList, long varLcl_InvoiceApprovalLevelId, bool varLcl_ShowBulkApproveInvoices, bool varLcl_ShowApproveInvoice, bool varLcl_ShowRejectInvoice, bool varLcl_ShowAssignFirstApproverPopup, bool varLcl_ShowBulkComment, bool varLcl_ShowComment, bool varLcl_ShowAssignAnalistaPopup, ST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError, BasicTypeList<long> varLcl_InvoicesTablesIdList, bool varLcl_ShowScreenTableDownloads, bool varLcIsListFullNeedRefresh, AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ScreenDataSetGetInvoices, AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ScreenDataSetGetInvoicesFull, AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, ConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Model varLcGetInvoiceCountToAssign, ConectaProveedores_d_Invoices_Invoices_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ApplicationRoleIdForAggregate", "l_ColumnJSONVar", "l_CountAfterFetch", "l_IsAllowSelectApplicationRoles", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "l_IsShowSelectAll", "l_IsSelectAll", "l_IsSelectedForApproval", "l_IsSelectAllForApproval", "l_IsSelectedForAssignment", "l_IsSelectAllForAssignment", "l_ShowBulkRejectPopup", "l_InvoiceId", "l_InvoiceApprovalLevelList", "l_InvoiceApprovalLevelId", "l_ShowBulkApproveInvoices", "l_ShowApproveInvoice", "l_ShowRejectInvoice", "l_ShowAssignFirstApproverPopup", "l_ShowBulkComment", "l_ShowComment", "l_ShowAssignAnalistaPopup", "NotifContent", "NotifError", "l_InvoicesTablesIdList", "l_ShowScreenTableDownloads", "IsListFullNeedRefresh", "GetInvoices", "GetApprovalStatuses", "GetProjectAssetServices", "GetInvoicesFull", "GetEntraRole", "GetCompanies", "GetInvoiceCountToAssign", "GetUserApplicationRolesAndMore", "ClientVars"}, new string[] {"varLcl_ApplicationRoleIdForAggregate", "varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_IsAllowSelectApplicationRoles", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "varLcl_IsShowSelectAll", "varLcl_IsSelectAll", "varLcl_IsSelectedForApproval", "varLcl_IsSelectAllForApproval", "varLcl_IsSelectedForAssignment", "varLcl_IsSelectAllForAssignment", "varLcl_ShowBulkRejectPopup", "varLcl_InvoiceId", "varLcl_InvoiceApprovalLevelList", "varLcl_InvoiceApprovalLevelId", "varLcl_ShowBulkApproveInvoices", "varLcl_ShowApproveInvoice", "varLcl_ShowRejectInvoice", "varLcl_ShowAssignFirstApproverPopup", "varLcl_ShowBulkComment", "varLcl_ShowComment", "varLcl_ShowAssignAnalistaPopup", "varLcNotifContent", "varLcNotifError", "varLcl_InvoicesTablesIdList", "varLcl_ShowScreenTableDownloads", "varLcIsListFullNeedRefresh", "ScreenDataSetGetInvoices", "ScreenDataSetGetApprovalStatuses", "ScreenDataSetGetProjectAssetServices", "ScreenDataSetGetInvoicesFull", "ScreenDataSetGetEntraRole", "ScreenDataSetGetCompanies", "varLcGetInvoiceCountToAssign", "varLcGetUserApplicationRolesAndMore", "clientVariables"});
this.varLcl_ApplicationRoleIdForAggregate = varLcl_ApplicationRoleIdForAggregate;
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_IsAllowSelectApplicationRoles = varLcl_IsAllowSelectApplicationRoles;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_IsShowSelectAll = varLcl_IsShowSelectAll;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsSelectedForApproval = varLcl_IsSelectedForApproval;
this.varLcl_IsSelectAllForApproval = varLcl_IsSelectAllForApproval;
this.varLcl_IsSelectedForAssignment = varLcl_IsSelectedForAssignment;
this.varLcl_IsSelectAllForAssignment = varLcl_IsSelectAllForAssignment;
this.varLcl_ShowBulkRejectPopup = varLcl_ShowBulkRejectPopup;
this.varLcl_InvoiceId = varLcl_InvoiceId;
this.varLcl_InvoiceApprovalLevelList = varLcl_InvoiceApprovalLevelList;
this.varLcl_InvoiceApprovalLevelId = varLcl_InvoiceApprovalLevelId;
this.varLcl_ShowBulkApproveInvoices = varLcl_ShowBulkApproveInvoices;
this.varLcl_ShowApproveInvoice = varLcl_ShowApproveInvoice;
this.varLcl_ShowRejectInvoice = varLcl_ShowRejectInvoice;
this.varLcl_ShowAssignFirstApproverPopup = varLcl_ShowAssignFirstApproverPopup;
this.varLcl_ShowBulkComment = varLcl_ShowBulkComment;
this.varLcl_ShowComment = varLcl_ShowComment;
this.varLcl_ShowAssignAnalistaPopup = varLcl_ShowAssignAnalistaPopup;
this.varLcNotifContent = varLcNotifContent;
this.varLcNotifError = varLcNotifError;
this.varLcl_InvoicesTablesIdList = varLcl_InvoicesTablesIdList;
this.varLcl_ShowScreenTableDownloads = varLcl_ShowScreenTableDownloads;
this.varLcIsListFullNeedRefresh = varLcIsListFullNeedRefresh;
this.ScreenDataSetGetInvoices = ScreenDataSetGetInvoices;
this.ScreenDataSetGetApprovalStatuses = ScreenDataSetGetApprovalStatuses;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.ScreenDataSetGetInvoicesFull = ScreenDataSetGetInvoicesFull;
this.ScreenDataSetGetEntraRole = ScreenDataSetGetEntraRole;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.varLcGetInvoiceCountToAssign = varLcGetInvoiceCountToAssign;
this.varLcGetUserApplicationRolesAndMore = varLcGetUserApplicationRolesAndMore;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_acb134934352a9d72fd2cc0509d2f469> datasetGetInvoicesReadDbAsync(RC_acb134934352a9d72fd2cc0509d2f469 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssDontShowAction = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetInvoices" SealEjuqg0uZL0E3sufR4Q of Action "Invoices"
public static async Task<(RL_c5ca0a80d78493d156f2b1a68d86a831,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpapInvoiceApprovalLevel_ApprovalStatusId,long qpcoRequisition_CompanyId,string qpteInvoice_InvoiceName,long qpprRequisition_ProjectAssetServiceId,string qpteInvoice_RequisitionName,long qpsuSupplier_Id,DateTime qpdaInvoice_UploadDateFrom,DateTime qpdaInvoice_UploadDateTo,int qpinOffsetUtc,string qpteAppRolesListText,long qpreCorporativoRegionId,bool qpboIsCorporativoCxP,string qpteTelcelDirectionsListText,long qpreUserRegion,string qpusGetUserId,long qpreGetUserRegionId,string qptel_TableSort,bool qpboIsSegmentationCorporativo,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Invoices.GetInvoices", "12a5e649-aa3b-4b83-992f-4137b2e7d1e1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Invoices","d_Invoices.Invoices.GetInvoices");
// Query Iterations: Multiple
// Refresh Query 7Nnc32W2yUKMYBPz8nT9bw Iterations: Multiple
// Refresh Query al6ezRZN3E+7B_1W9TTpeA Iterations: Multiple
// Refresh Query mSL0yCBfx06AB8ajCn6vQA Iterations: Multiple
// Refresh Query VjeJOr6S_EqZk9sChrFeew Iterations: Multiple
// Refresh Query uFlStyoGPU6KomSSuMBp5Q Iterations: Multiple
// Refresh Query HF7j4xUVsEmFAsOZV9WEXg Iterations: Multiple
// Refresh Query 2jaNI1IsXECOS3h04ADqSw Iterations: Multiple
// Refresh Query LuHSDTZPP0+0cIg29_JRLg Iterations: Multiple
// Refresh Query fTsbmvD+h0iswdJ6TDInBQ Iterations: Multiple
// Refresh Query LNxmRM1juEaUyckL7x7sVA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/ScreenDataSets.SealEjuqg0uZL0E3sufR4Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalstatus9\".\"label\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"eninvoice117\".\"id\" o28, \"eninvoice117\".\"name\" o29, \"eninvoice117\".\"requisitionid\" o30, \"eninvoice117\".\"folioid\" o31, \"eninvoice117\".\"ordermainid\" o32, \"eninvoice117\".\"cfditypeid\" o33, trim_scale(\"eninvoice117\".\"totalamount\"::numeric) o34, \"eninvoice117\".\"currency\" o35, \"eninvoice117\".\"invoicestatusid\" o36, \"eninvoice117\".\"accountingdatetime\" o37, \"eninvoice117\".\"paymentdatetime\" o38, \"eninvoice117\".\"createdon\" o39, \"eninvoice117\".\"createdby\" o40, \"eninvoice117\".\"updatedon\" o41, \"eninvoice117\".\"updatedby\" o42, \"eninvoice117\".\"submittedon\" o43, \"eninvoice117\".\"isnewversion\" o44, \"eninvoice117\".\"id_poliza\" o45, \"eninvoice117\".\"id_poliza_sap\" o46, \"eninvoice117\".\"doc51\" o47, \"eninvoice117\".\"accountingerror\" o48, \"eninvoice117\".\"orderaccconceptsid\" o49, trim_scale(\"eninvoice117\".\"amortization\"::numeric) o50, \"eninvoice117\".\"creditnoteinvoiceid\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, \"eninvoiceapproval32\".\"invoiceid\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, \"eninvoiceapprovallevel32\".\"id\" o83, \"eninvoiceapprovallevel32\".\"invoiceapprovalid\" o84, \"eninvoiceapprovallevel32\".\"levelnumber\" o85, \"eninvoiceapprovallevel32\".\"assignedto\" o86, \"eninvoiceapprovallevel32\".\"applicationroleid\" o87, \"eninvoiceapprovallevel32\".\"entrajobtitle\" o88, \"eninvoiceapprovallevel32\".\"departmentid\" o89, \"eninvoiceapprovallevel32\".\"managementid\" o90, \"eninvoiceapprovallevel32\".\"subdirectionid\" o91, \"eninvoiceapprovallevel32\".\"entraroleid\" o92, \"eninvoiceapprovallevel32\".\"approvalstatusid\" o93, \"eninvoiceapprovallevel32\".\"canbefirstapprover\" o94, \"eninvoiceapprovallevel32\".\"selectsnextapprover\" o95, \"eninvoiceapprovallevel32\".\"selectsfirstapprover\" o96, \"eninvoiceapprovallevel32\".\"isaccounting\" o97, \"eninvoiceapprovallevel32\".\"isstartaccounting\" o98, \"eninvoiceapprovallevel32\".\"approvedby\" o99, \"eninvoiceapprovallevel32\".\"approvedon\" o100, \"eninvoiceapprovallevel32\".\"requesttomodifyby\" o101, \"eninvoiceapprovallevel32\".\"requesttomodifyon\" o102, \"eninvoiceapprovallevel32\".\"canceledby\" o103, \"eninvoiceapprovallevel32\".\"canceledon\" o104, \"eninvoiceapprovallevel32\".\"needscontract_deprec\" o105, \"eninvoiceapprovallevel32\".\"isreassigned\" o106, \"eninvoiceapprovallevel32\".\"issubstitutefor\" o107, NULL o108, \"eninvoicestatus10\".\"label\" o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, \"enregion109\".\"code\" o123, \"enregion109\".\"name\" o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, \"enrequisition96\".\"name\" o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, \"ensupplier83\".\"name\" o195, \"ensupplier83\".\"number\" o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, \"ensupplier83\".\"n_ident_fis_1\" o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, (CASE WHEN (\"eninvoiceapprovallevel32\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition96\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition96\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition96\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" OR (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition96\".\"accountingregionid\" = @qpreGetUserRegionId) AND (\"enrequisition96\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition96\".\"accountingregionid\" IS NULL)");
}
selectBuilder.Append(" AND (\"enrequisition96\".\"accountingregionid\" IS NOT NULL))) THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((((((({Invoice} \"eninvoice117\" Left JOIN {InvoiceApproval} \"eninvoiceapproval32\" ON (\"eninvoice117\".\"id\" = \"eninvoiceapproval32\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel32\" ON ((\"eninvoiceapprovallevel32\".\"invoiceapprovalid\" = \"eninvoiceapproval32\".\"id\") AND ((\"eninvoiceapprovallevel32\".\"approvalstatusid\" <> ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel32\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel32\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel32\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel32\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((CASE WHEN char_length(caseaccent_normalize(cast(\"eninvoiceapprovallevel32\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"eninvoiceapprovallevel32\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRolesListText collate \"default\"))-1) END)) <> (-1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel32\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel32\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel32\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel32\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel32\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel32\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel32\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel32\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel32\".\"canceledby\" IS NULL)");
}
fromBuilder.Append("))))  Inner JOIN {Requisition} \"enrequisition96\" ON (\"eninvoice117\".\"requisitionid\" = \"enrequisition96\".\"id\"))  Left JOIN {Supplier} \"ensupplier83\" ON (\"enrequisition96\".\"supplierid\" = \"ensupplier83\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus10\" ON (\"eninvoice117\".\"invoicestatusid\" = \"eninvoicestatus10\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole52\" ON (\"eninvoiceapprovallevel32\".\"applicationroleid\" = \"enapplicationrole52\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus9\" ON (\"eninvoiceapprovallevel32\".\"approvalstatusid\" = \"enapprovalstatus9\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting30\" ON (\"eninvoice117\".\"id\" = \"eninvoiceaccounting30\".\"invoiceid\"))  Left JOIN {Region} \"enregion109\" ON (\"enrequisition96\".\"regionid\" = \"enregion109\".\"id\"))  Left JOIN {Company} \"encompany30\" ON (\"enrequisition96\".\"companyid\" = \"encompany30\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service7\" ON (\"enrequisition96\".\"projectassetserviceid\" = \"enproject_asset_service7\".\"id\"))  Left JOIN {User} \"enuser166\" ON (\"eninvoiceapprovallevel32\".\"assignedto\" = \"enuser166\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteInvoice_InvoiceName != "" && qpteInvoice_InvoiceName != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice117\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvoice_InvoiceName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoice_InvoiceName", DbType.String, qpteInvoice_InvoiceName);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteInvoice_InvoiceName", DbType.String, qpteInvoice_InvoiceName);
}
if (qpteInvoice_RequisitionName != "" && qpteInvoice_RequisitionName != "") {
whereBuilder.Append("(caseaccent_normalize(\"enrequisition96\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvoice_RequisitionName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoice_RequisitionName", DbType.String, qpteInvoice_RequisitionName);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteInvoice_RequisitionName", DbType.String, qpteInvoice_RequisitionName);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier83\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier83\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier83\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaInvoice_UploadDateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice117\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaInvoice_UploadDateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvoice_UploadDateFrom", DbType.DateTime, qpdaInvoice_UploadDateFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaInvoice_UploadDateFrom", DbType.DateTime, qpdaInvoice_UploadDateFrom);
}
if (qpdaInvoice_UploadDateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice117\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaInvoice_UploadDateTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvoice_UploadDateTo", DbType.DateTime, qpdaInvoice_UploadDateTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaInvoice_UploadDateTo", DbType.DateTime, qpdaInvoice_UploadDateTo);
}
if (qpcoRequisition_CompanyId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoRequisition_CompanyId != 0) {
whereBuilder.Append("((\"enrequisition96\".\"companyid\" = @qpcoRequisition_CompanyId) AND (\"enrequisition96\".\"companyid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoRequisition_CompanyId", DbType.Int64, qpcoRequisition_CompanyId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoRequisition_CompanyId", DbType.Int64, qpcoRequisition_CompanyId);
} else {
whereBuilder.Append("(\"enrequisition96\".\"companyid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpprRequisition_ProjectAssetServiceId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpprRequisition_ProjectAssetServiceId != 0) {
whereBuilder.Append("((\"enrequisition96\".\"projectassetserviceid\" = @qpprRequisition_ProjectAssetServiceId) AND (\"enrequisition96\".\"projectassetserviceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprRequisition_ProjectAssetServiceId", DbType.Int64, qpprRequisition_ProjectAssetServiceId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprRequisition_ProjectAssetServiceId", DbType.Int64, qpprRequisition_ProjectAssetServiceId);
} else {
whereBuilder.Append("(\"enrequisition96\".\"projectassetserviceid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(\"eninvoice117\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") AND ");
if (qpapInvoiceApprovalLevel_ApprovalStatusId != BuiltInFunction.NullIdentifier()) {
whereBuilder.Append("(");
if (qpapInvoiceApprovalLevel_ApprovalStatusId != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel32\".\"approvalstatusid\" = @qpapInvoiceApprovalLevel_ApprovalStatusId) AND (\"eninvoiceapprovallevel32\".\"approvalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapInvoiceApprovalLevel_ApprovalStatusId", DbType.Int32, qpapInvoiceApprovalLevel_ApprovalStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpapInvoiceApprovalLevel_ApprovalStatusId", DbType.Int32, qpapInvoiceApprovalLevel_ApprovalStatusId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel32\".\"approvalstatusid\" IS NULL)");
}
whereBuilder.Append(" AND (");
if (qpreUserRegion != 0) {
whereBuilder.Append("((\"enrequisition96\".\"regionid\" = @qpreUserRegion) AND (\"enrequisition96\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreUserRegion", DbType.Int64, qpreUserRegion);
} else {
whereBuilder.Append("(\"enrequisition96\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreUserRegion != 0) {
whereBuilder.Append("((\"enrequisition96\".\"accountingregionid\" = @qpreUserRegion) AND (\"enrequisition96\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreUserRegion", DbType.Int64, qpreUserRegion);
} else {
whereBuilder.Append("(\"enrequisition96\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpboIsSegmentationCorporativo = 1) THEN (CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpteTelcelDirectionsListText = '') THEN 1 ELSE (CASE WHEN ((((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition96\".\"regionid\" = @qpreCorporativoRegionId) AND (\"enrequisition96\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition96\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition96\".\"accountingregionid\" = @qpreCorporativoRegionId) AND (\"enrequisition96\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition96\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition96\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition96\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition96\".\"regionid\" <> @qpreCorporativoRegionId) OR (\"enrequisition96\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition96\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel32\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel32\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel32\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) ELSE 1 END) ELSE 1 END) ELSE (CASE WHEN ((");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enrequisition96\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition96\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enrequisition96\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel32\".\"id\" IS NOT NULL)) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel32\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel32\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel32\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"eninvoicestatus10\".\"isinaccounting\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Company", "Invoice", "InvoiceApproval", "ApplicationRole", "Project_Asset_Service", "InvoiceStatus", "User", "InvoiceApprovalLevel", "Supplier", "Requisition", "ApprovalStatus", "InvoiceAccounting", "Region" }, new string[] { "ENCompany30", "ENInvoice117", "ENInvoiceApproval32", "ENApplicationRole52", "ENProject_Asset_Service7", "ENInvoiceStatus10", "ENUser166", "ENInvoiceApprovalLevel32", "ENSupplier83", "ENRequisition96", "ENApprovalStatus9", "ENInvoiceAccounting30", "ENRegion109" }, new System.Collections.Generic.Dictionary<string, string>[] { ENCompanyEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceApprovalEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENProject_Asset_ServiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENInvoiceApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enregion109\".\"code\" ASC ");
orderByColumns.Add("\"enapprovalstatus9\".\"order\" ASC ");
orderByColumns.Add("\"eninvoice117\".\"createdon\" DESC ");
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
RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[13];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query d_Invoices.Invoices.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5ca0a80d78493d156f2b1a68d86a831 _tmp = new RL_c5ca0a80d78493d156f2b1a68d86a831();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5ca0a80d78493d156f2b1a68d86a831)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query d_Invoices.Invoices.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetApprovalStatuses" lN8FN06AHkqxybpCiTZcnw of Action "Invoices"
public static async Task<(RL_51a4e63e168a01408e3f55c611518e13,long)> datasetGetApprovalStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Invoices.GetApprovalStatuses", "3705df94-804e-4a1e-b1c9-ba4289365c9f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Invoices","d_Invoices.Invoices.GetApprovalStatuses");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/ScreenDataSets.lN8FN06AHkqxybpCiTZcnw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus10\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enapprovalstatus10\".\"labeles\" o9");
fromBuilder.Append(" FROM {ApprovalStatus} \"enapprovalstatus10\"");
whereBuilder.Append(" WHERE (\"enapprovalstatus10\".\"is_active\" = 1) AND (\"enapprovalstatus10\".\"isinv\" = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalstatus10\".\"order\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetApprovalStatuses.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetApprovalStatuses.List", cancellationToken: cancellationToken);
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

// Query Function "GetProjectAssetServices" wujzZqpL402oDK4_EtDtkQ of Action "Invoices"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Invoices.GetProjectAssetServices", "66f3e8c2-4baa-4de3-a80c-ae3f12d0ed91");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Invoices","d_Invoices.Invoices.GetProjectAssetServices");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/ScreenDataSets.wujzZqpL402oDK4_EtDtkQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service8\".\"id\" o0, \"enproject_asset_service8\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service8\"");
orderByBuilder.Append(" ORDER BY \"enproject_asset_service8\".\"description\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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

private static async Task<RC_acb134934352a9d72fd2cc0509d2f469> datasetGetInvoicesFullReadDbAsync(RC_acb134934352a9d72fd2cc0509d2f469 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssDontShowAction = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetInvoicesFull" ga1ihVlf1UGcVije03UwWg of Action "Invoices"
public static async Task<(RL_c5ca0a80d78493d156f2b1a68d86a831,long)> datasetGetInvoicesFull(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpapInvoiceApprovalLevel_ApprovalStatusId,long qpcoRequisition_CompanyId,string qpteInvoice_InvoiceName,long qpprRequisition_ProjectAssetServiceId,string qpteInvoice_RequisitionName,long qpsuSupplier_Id,DateTime qpdaInvoice_UploadDateFrom,DateTime qpdaInvoice_UploadDateTo,int qpinOffsetUtc,string qpteAppRolesListText,long qpreCorporativoRegionId,bool qpboIsCorporativoCxP,string qpteTelcelDirectionsListText,long qpreUserRegion,string qpusGetUserId,long qpreGetUserRegionId,string qptel_TableSort,bool qpboIsSegmentationCorporativo,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Invoices.GetInvoicesFull", "8562ad81-5f59-41d5-9c56-28ded375305a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Invoices","d_Invoices.Invoices.GetInvoicesFull");
// Query Iterations: Multiple
// Refresh Query SwwVWm_Is0eF+XQblGdCIg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/ScreenDataSets.ga1ihVlf1UGcVije03UwWg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalstatus11\".\"label\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"eninvoice118\".\"id\" o28, \"eninvoice118\".\"name\" o29, NULL o30, NULL o31, NULL o32, NULL o33, trim_scale(\"eninvoice118\".\"totalamount\"::numeric) o34, NULL o35, NULL o36, NULL o37, NULL o38, \"eninvoice118\".\"createdon\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, \"eninvoiceaccounting31\".\"suppliernumber\" o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, \"eninvoiceapprovallevel33\".\"id\" o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, \"eninvoicestatus11\".\"label\" o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, \"enrequisition97\".\"name\" o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, \"ensupplier84\".\"name\" o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, \"enuser167\".\"name\" o222, NULL o223, NULL o224, NULL o225, (CASE WHEN (\"eninvoiceapprovallevel33\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition97\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition97\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition97\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" OR (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition97\".\"accountingregionid\" = @qpreGetUserRegionId) AND (\"enrequisition97\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition97\".\"accountingregionid\" IS NULL)");
}
selectBuilder.Append(" AND (\"enrequisition97\".\"accountingregionid\" IS NOT NULL))) THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((((((({Invoice} \"eninvoice118\" Left JOIN {InvoiceApproval} \"eninvoiceapproval33\" ON (\"eninvoice118\".\"id\" = \"eninvoiceapproval33\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel33\" ON ((\"eninvoiceapprovallevel33\".\"invoiceapprovalid\" = \"eninvoiceapproval33\".\"id\") AND ((\"eninvoiceapprovallevel33\".\"approvalstatusid\" <> ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel33\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel33\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel33\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel33\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((CASE WHEN char_length(caseaccent_normalize(cast(\"eninvoiceapprovallevel33\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"eninvoiceapprovallevel33\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRolesListText collate \"default\"))-1) END)) <> (-1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel33\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel33\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel33\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel33\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel33\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel33\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel33\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel33\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel33\".\"canceledby\" IS NULL)");
}
fromBuilder.Append("))))  Inner JOIN {Requisition} \"enrequisition97\" ON (\"eninvoice118\".\"requisitionid\" = \"enrequisition97\".\"id\"))  Left JOIN {Supplier} \"ensupplier84\" ON (\"enrequisition97\".\"supplierid\" = \"ensupplier84\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus11\" ON (\"eninvoice118\".\"invoicestatusid\" = \"eninvoicestatus11\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole53\" ON (\"eninvoiceapprovallevel33\".\"applicationroleid\" = \"enapplicationrole53\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus11\" ON (\"eninvoiceapprovallevel33\".\"approvalstatusid\" = \"enapprovalstatus11\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting31\" ON (\"eninvoice118\".\"id\" = \"eninvoiceaccounting31\".\"invoiceid\"))  Left JOIN {Region} \"enregion110\" ON (\"enrequisition97\".\"regionid\" = \"enregion110\".\"id\"))  Left JOIN {Company} \"encompany31\" ON (\"enrequisition97\".\"companyid\" = \"encompany31\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service9\" ON (\"enrequisition97\".\"projectassetserviceid\" = \"enproject_asset_service9\".\"id\"))  Left JOIN {User} \"enuser167\" ON (\"eninvoiceapprovallevel33\".\"assignedto\" = \"enuser167\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteInvoice_InvoiceName != "" && qpteInvoice_InvoiceName != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice118\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvoice_InvoiceName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoice_InvoiceName", DbType.String, qpteInvoice_InvoiceName);
}
if (qpteInvoice_RequisitionName != "" && qpteInvoice_RequisitionName != "") {
whereBuilder.Append("(caseaccent_normalize(\"enrequisition97\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvoice_RequisitionName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoice_RequisitionName", DbType.String, qpteInvoice_RequisitionName);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier84\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier84\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier84\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaInvoice_UploadDateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice118\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaInvoice_UploadDateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvoice_UploadDateFrom", DbType.DateTime, qpdaInvoice_UploadDateFrom);
}
if (qpdaInvoice_UploadDateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice118\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaInvoice_UploadDateTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvoice_UploadDateTo", DbType.DateTime, qpdaInvoice_UploadDateTo);
}
if (qpcoRequisition_CompanyId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoRequisition_CompanyId != 0) {
whereBuilder.Append("((\"enrequisition97\".\"companyid\" = @qpcoRequisition_CompanyId) AND (\"enrequisition97\".\"companyid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoRequisition_CompanyId", DbType.Int64, qpcoRequisition_CompanyId);
} else {
whereBuilder.Append("(\"enrequisition97\".\"companyid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpprRequisition_ProjectAssetServiceId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpprRequisition_ProjectAssetServiceId != 0) {
whereBuilder.Append("((\"enrequisition97\".\"projectassetserviceid\" = @qpprRequisition_ProjectAssetServiceId) AND (\"enrequisition97\".\"projectassetserviceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprRequisition_ProjectAssetServiceId", DbType.Int64, qpprRequisition_ProjectAssetServiceId);
} else {
whereBuilder.Append("(\"enrequisition97\".\"projectassetserviceid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(\"eninvoice118\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") AND ");
if (qpapInvoiceApprovalLevel_ApprovalStatusId != BuiltInFunction.NullIdentifier()) {
whereBuilder.Append("(");
if (qpapInvoiceApprovalLevel_ApprovalStatusId != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel33\".\"approvalstatusid\" = @qpapInvoiceApprovalLevel_ApprovalStatusId) AND (\"eninvoiceapprovallevel33\".\"approvalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapInvoiceApprovalLevel_ApprovalStatusId", DbType.Int32, qpapInvoiceApprovalLevel_ApprovalStatusId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel33\".\"approvalstatusid\" IS NULL)");
}
whereBuilder.Append(" AND (");
if (qpreUserRegion != 0) {
whereBuilder.Append("((\"enrequisition97\".\"regionid\" = @qpreUserRegion) AND (\"enrequisition97\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUserRegion", DbType.Int64, qpreUserRegion);
} else {
whereBuilder.Append("(\"enrequisition97\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreUserRegion != 0) {
whereBuilder.Append("((\"enrequisition97\".\"accountingregionid\" = @qpreUserRegion) AND (\"enrequisition97\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUserRegion", DbType.Int64, qpreUserRegion);
} else {
whereBuilder.Append("(\"enrequisition97\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpboIsSegmentationCorporativo = 1) THEN (CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpteTelcelDirectionsListText = '') THEN 1 ELSE (CASE WHEN ((((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition97\".\"regionid\" = @qpreCorporativoRegionId) AND (\"enrequisition97\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition97\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition97\".\"accountingregionid\" = @qpreCorporativoRegionId) AND (\"enrequisition97\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition97\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition97\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition97\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition97\".\"regionid\" <> @qpreCorporativoRegionId) OR (\"enrequisition97\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition97\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel33\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel33\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel33\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) ELSE 1 END) ELSE 1 END) ELSE (CASE WHEN ((");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enrequisition97\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition97\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enrequisition97\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel33\".\"id\" IS NOT NULL)) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel33\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel33\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel33\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"eninvoicestatus11\".\"isinaccounting\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "InvoiceApprovalLevel", "Region", "Requisition", "InvoiceStatus", "Supplier", "Company", "User", "ApplicationRole", "InvoiceAccounting", "Project_Asset_Service", "Invoice", "InvoiceApproval", "ApprovalStatus" }, new string[] { "ENInvoiceApprovalLevel33", "ENRegion110", "ENRequisition97", "ENInvoiceStatus11", "ENSupplier84", "ENCompany31", "ENUser167", "ENApplicationRole53", "ENInvoiceAccounting31", "ENProject_Asset_Service9", "ENInvoice118", "ENInvoiceApproval33", "ENApprovalStatus11" }, new System.Collections.Generic.Dictionary<string, string>[] { ENInvoiceApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENProject_Asset_ServiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceApprovalEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enregion110\".\"code\" ASC ");
orderByColumns.Add("\"enapprovalstatus11\".\"order\" ASC ");
orderByColumns.Add("\"eninvoice118\".\"createdon\" DESC ");
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
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesFullReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[13];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetInvoicesFull.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5ca0a80d78493d156f2b1a68d86a831 _tmp = new RL_c5ca0a80d78493d156f2b1a68d86a831();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesFullReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetInvoicesFull.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5ca0a80d78493d156f2b1a68d86a831)_tmp;
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
// Query Function "GetEntraRole" rWyMy5pJi0eHWOIbh_wtXA of Action "Invoices"
public static async Task<(RL_ea7d18baeeefa57d5c86706d7efb98e9,long)> datasetGetEntraRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Invoices.GetEntraRole", "cb8c6cad-499a-478b-8758-e21b87fc2d5c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Invoices","d_Invoices.Invoices.GetEntraRole");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/ScreenDataSets.rWyMy5pJi0eHWOIbh_wtXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enentrarole50\".\"isareacxp\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal102\" Inner JOIN {EntraRole} \"enentrarole50\" ON (\"enentrarole50\".\"rolename\" = \"enuser_extended_internal102\".\"jobtitle\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal102\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal102\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal102\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetEntraRole.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetEntraRole.List", cancellationToken: cancellationToken);
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

// Query Function "GetCompanies" Ydoq7G_v4Um_FOcGs6XUAw of Action "Invoices"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Invoices.GetCompanies", "ec2ada61-ef6f-49e1-bf14-e706b3a5d403");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Invoices","d_Invoices.Invoices.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/ScreenDataSets.Ydoq7G_v4Um_FOcGs6XUAw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany32\".\"id\" o0, NULL o1, \"encompany32\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany32\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetCompanies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetCompanies.List", cancellationToken: cancellationToken);
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


    public class lcvGetInvoiceCountToAssign : VarsBag {
public RL_eb723ca0f1d2182a5703efa79cc03660 queryResGetInvoiceToAssignCount_outParamList = new RL_eb723ca0f1d2182a5703efa79cc03660();
public long queryResGetInvoiceToAssignCount_outParamCount = 0L;

public lcvGetInvoiceCountToAssign() {
}
}
public class lcoGetInvoiceCountToAssign : VarsBag {
public bool outParamIsShowInfoMsg = false;

public lcoGetInvoiceCountToAssign() {
}
}
/// <summary>
/// Action <code>GetInvoiceCountToAssign</code> that represents the Service Studio action
///  <code>GetInvoiceCountToAssign</code> <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetInvoiceCountToAssign(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsShowInfoMsg = default;
lcoGetInvoiceCountToAssign result = new lcoGetInvoiceCountToAssign();
lcvGetInvoiceCountToAssign localVars = new lcvGetInvoiceCountToAssign();
ConectaProveedores_d_Invoices_Invoices_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoiceCountToAssign", "1b00dd12-a1ef-4797-82ca-4af9cc27d2d9"))
using (activitySource.CreateScreenDataActionActivity("Invoices", "GetInvoiceCountToAssign")){
// GetUserApplicationRolesAndMore.AppRolesListText = Substr
varLcGetUserApplicationRolesAndMore.outParamAppRolesListText = BuiltInFunction.SubstrSC (varLcGetUserApplicationRolesAndMore.outParamAppRolesListText, 1, BuiltInFunction.LengthSC (varLcGetUserApplicationRolesAndMore.outParamAppRolesListText));
// LogMessage
await ExtendedActions.LogMessage(requestContext,((("TelcelDirectionsListTextForQuery: "+varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListTextForQuery)+" | AppRolesListText: ")+varLcGetUserApplicationRolesAndMore.outParamAppRolesListText),"Logs",cancellationToken);

// Query QueryGetInvoiceToAssignCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetInvoiceToAssignCount_maxRecords = 0;
int QueryGetInvoiceToAssignCount_startIndex = 0;(localVars.queryResGetInvoiceToAssignCount_outParamList,localVars.queryResGetInvoiceToAssignCount_outParamCount) = await FuncDataActionGetInvoiceCountToAssign.QueryGetInvoiceToAssignCount(requestContext,QueryGetInvoiceToAssignCount_maxRecords,QueryGetInvoiceToAssignCount_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),(varLcGetUserApplicationRolesAndMore.outParamAppRolesListText==""),(((varLcGetUserApplicationRolesAndMore.outParamAppRolesListText=="")) ? ("(0)") : ((("("+varLcGetUserApplicationRolesAndMore.outParamAppRolesListText)+")"))),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId,(((varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListTextForQuery=="")) ? ("(0)") : ((("("+varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListTextForQuery)+")"))),(varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText==""),cancellationToken);

// IsShowInfoMsg = GetInvoiceToAssignCount.List.Current.Integer.Value = 0
result.outParamIsShowInfoMsg=(localVars.queryResGetInvoiceToAssignCount_outParamList.CurrentRec.ssSTInteger.ssValue==0);
} //close CreateActionActivity using block
} // try

finally {
outParamIsShowInfoMsg = result.outParamIsShowInfoMsg;
} // inner-finally
RETURN_STATEMENT:
return outParamIsShowInfoMsg;
}
public class lcvGetUserApplicationRolesAndMore : VarsBag {
public int resFindIsJefeCxP_outParamPosition = 0;

public RL_b9107f331631f30bcef7fe9d900d99ae queryResGetUserApplicationRoleTempByConcepts_outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
public long queryResGetUserApplicationRoleTempByConcepts_outParamCount = 0L;

public int resFindIsAnalistaCxP_outParamPosition = 0;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public int resFindIsSupervisorR0orR9_outParamPosition = 0;

public int resFindIsCorporativoCxP_outParamPosition = 0;

public lcvGetUserApplicationRolesAndMore() {
}
}
public class lcoGetUserApplicationRolesAndMore : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public bool outParamIsCorporativoCxP = false;

public string outParamAppRolesListText = "";

public string outParamTelcelDirectionsListText = "";

public bool outParamIsSupervisor = false;

public bool outParamIsAnalistaCxP = false;

public bool outParamIsJefeCxP = false;

public long outParamCorporativoRegionId = 0L;

public string outParamTelcelDirectionsListTextForQuery = "";

public long outParamUserRegion = 0L;

public bool outParamIsActiveDEV_NewVersionScreenDownloads = false;

public lcoGetUserApplicationRolesAndMore() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRolesAndMore</code> that represents the Service Studio action
///  <code>GetUserApplicationRolesAndMore</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,bool,string,string,bool,bool,bool,long,string,long,bool)> DataActionGetUserApplicationRolesAndMore(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
bool outParamIsCorporativoCxP = default;
string outParamAppRolesListText = default;
string outParamTelcelDirectionsListText = default;
bool outParamIsSupervisor = default;
bool outParamIsAnalistaCxP = default;
bool outParamIsJefeCxP = default;
long outParamCorporativoRegionId = default;
string outParamTelcelDirectionsListTextForQuery = default;
long outParamUserRegion = default;
bool outParamIsActiveDEV_NewVersionScreenDownloads = default;
lcoGetUserApplicationRolesAndMore result = new lcoGetUserApplicationRolesAndMore();
lcvGetUserApplicationRolesAndMore localVars = new lcvGetUserApplicationRolesAndMore();
ConectaProveedores_d_Invoices_Invoices_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRolesAndMore", "d4d17998-855e-4921-a749-97b5a77c9d1a"))
using (activitySource.CreateScreenDataActionActivity("Invoices", "GetUserApplicationRolesAndMore")){
// IsActiveDEV_NewVersionScreenDownloads = IsActiveDEV_NewScreenDownloads
result.outParamIsActiveDEV_NewVersionScreenDownloads=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_NewScreenDownloads])));
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

// UserRegion = GetUserRegionId()
result.outParamUserRegion=(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken));
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

// FindIsSupervisorR0orR9
localVars.resFindIsSupervisorR0orR9_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => (((p.ssENRegion.ssCommissionRegion=="R0")||(p.ssENRegion.ssCommissionRegion=="R9"))&&(BuiltInFunction.IndexSC (p.ssENApplicationRole.ssCode, "SUPERVISOR", 0, false, true)!=(-1))),cancellationToken);

// FindIsAnalistaCxP
localVars.resFindIsAnalistaCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((BuiltInFunction.IndexSC (p.ssENApplicationRole.ssCode, "ANALISTA", 0, false, true)!=(-1))&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// FindIsJefeCxP
localVars.resFindIsJefeCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((BuiltInFunction.IndexSC (p.ssENApplicationRole.ssCode, "JEFE", 0, false, true)!=(-1))&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// IsSupervisor = FindIsSupervisorR0orR9.Position <> -1
result.outParamIsSupervisor=(localVars.resFindIsSupervisorR0orR9_outParamPosition!=(-1));

// CorporativoRegionId = GetMR00RegionId()
result.outParamCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));

// IsAnalistaCxP = FindIsAnalistaCxP.Position <> -1
result.outParamIsAnalistaCxP=(localVars.resFindIsAnalistaCxP_outParamPosition!=(-1));

// IsJefeCxP = FindIsJefeCxP.Position <> -1
result.outParamIsJefeCxP=(localVars.resFindIsJefeCxP_outParamPosition!=(-1));
// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// AppRolesListText = AppRolesListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamAppRolesListText=((result.outParamAppRolesListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
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

// TelcelDirectionsListTextForQuery = TelcelDirectionsListTextForQuery + ", " + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId
result.outParamTelcelDirectionsListTextForQuery=((result.outParamTelcelDirectionsListTextForQuery+", ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId));
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Advance();
}

} finally {
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.EndIteration();
}

// TelcelDirectionsListTextForQuery = Substr
result.outParamTelcelDirectionsListTextForQuery=BuiltInFunction.SubstrSC (result.outParamTelcelDirectionsListTextForQuery, 1, BuiltInFunction.LengthSC (result.outParamTelcelDirectionsListTextForQuery));
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
outParamAppRolesListText = result.outParamAppRolesListText;
outParamTelcelDirectionsListText = result.outParamTelcelDirectionsListText;
outParamIsSupervisor = result.outParamIsSupervisor;
outParamIsAnalistaCxP = result.outParamIsAnalistaCxP;
outParamIsJefeCxP = result.outParamIsJefeCxP;
outParamCorporativoRegionId = result.outParamCorporativoRegionId;
outParamTelcelDirectionsListTextForQuery = result.outParamTelcelDirectionsListTextForQuery;
outParamUserRegion = result.outParamUserRegion;
outParamIsActiveDEV_NewVersionScreenDownloads = result.outParamIsActiveDEV_NewVersionScreenDownloads;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamIsCorporativoCxP,outParamAppRolesListText,outParamTelcelDirectionsListText,outParamIsSupervisor,outParamIsAnalistaCxP,outParamIsJefeCxP,outParamCorporativoRegionId,outParamTelcelDirectionsListTextForQuery,outParamUserRegion,outParamIsActiveDEV_NewVersionScreenDownloads);
}


    public static class FuncDataActionGetInvoiceCountToAssign {

// Query Function "GetInvoiceToAssignCount" jZZjmLo9R0eo0McBC1SYwg of Action "GetInvoiceCountToAssign"
public static async Task<(RL_eb723ca0f1d2182a5703efa79cc03660,long)> QueryGetInvoiceToAssignCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusi_UserId,bool qpboi_IsUserRolesEmpty,string qptei_UserRoles,long qprei_RegionId,int qpapi_ToAssignStatus,string qptei_TelcelDirections,bool qpboi_IsTelcelDirectionsEmpty,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("d_Invoices.Invoices.GetInvoiceCountToAssign.GetInvoiceToAssignCount", "9863968d-3dba-4747-a8d0-c7010b5498c2");
using var queryActivity = activitySource.CreateSqlQueryActivity("d_Invoices.Invoices.GetInvoiceCountToAssign.GetInvoiceToAssignCount", "9863968d-3dba-4747-a8d0-c7010b5498c2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityInvoiceApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("InvoiceApprovalLevel");
string entityInvoiceApproval = AppUtils.Instance.RuntimeEntityReplace("InvoiceApproval");
string entityInvoice = AppUtils.Instance.RuntimeEntityReplace("Invoice");
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
sqlCmd.CreateParameter("@qpusi_UserId", DbType.String, qpusi_UserId);
sqlCmd.CreateParameter("@qpboi_IsUserRolesEmpty", DbType.Boolean, qpboi_IsUserRolesEmpty);
sqlCmd.CreateParameter("@qprei_RegionId", DbType.Int64, qprei_RegionId);
sqlCmd.CreateParameter("@qpboi_IsTelcelDirectionsEmpty", DbType.Boolean, qpboi_IsTelcelDirectionsEmpty);
sqlCmd.CreateParameter("@qpapi_ToAssignStatus", DbType.Int32, qpapi_ToAssignStatus);
string sql = "";
string advSql = "SELECT  \n    COUNT(ial.Id) AS ApprovalCount \nFROM \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceApprovalLevel,"") + " ial  \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceApproval,"") + " ia ON ial.InvoiceApprovalId = ia.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,"") + " inv ON ia.InvoiceId = inv.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " req ON inv.RequisitionId = req.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " asl ON ial.ApprovalStatusId = asl.Id \nWHERE \n    ( \n        ial.AssignedTo = @qpusi_UserId \n        OR ( \n            @qpboi_IsUserRolesEmpty = 0 \n            AND ial.ApplicationRoleId IN  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qptei_UserRoles)) + " \n            AND req.RegionId = @qprei_RegionId \n            AND @qpboi_IsTelcelDirectionsEmpty = 0 \n            AND req.TelcelDirectionId IN  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qptei_TelcelDirections)) + " \n        ) \n    ) \n    AND (ial.ApprovalStatusId = @qpapi_ToAssignStatus)";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetInvoiceCountToAssign.GetInvoiceToAssignCount.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetInvoiceCountToAssign.GetInvoiceToAssignCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb723ca0f1d2182a5703efa79cc03660)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetInvoiceToAssignCount in GetInvoiceCountToAssign in Invoices in d_Invoices in ConectaProveedores (SELECT       COUNT(ial.Id) AS ApprovalCount  FROM      {InvoiceApprovalLevel} ial   INNER JOIN {InvoiceApproval} ia ON ial.InvoiceApprovalId = ia.Id  INNER JOIN {Invoice} inv ON ia.InvoiceId = inv.Id  INNER JOIN {Requisition} req ON inv.RequisitionId = req.Id  INNER JOIN {ApprovalStatus} asl ON ial.ApprovalStatusId = asl.Id  WHERE      (          ial.AssignedTo = @i_UserId          OR (              @i_IsUserRolesEmpty = 0              AND ial.ApplicationRoleId IN @i_UserRoles              AND req.RegionId = @i_RegionId              AND @i_IsTelcelDirectionsEmpty = 0              AND req.TelcelDirectionId IN @i_TelcelDirections          )      )      AND (ial.ApprovalStatusId = @i_ToAssignStatus)): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetInvoiceToAssignCount in GetInvoiceCountToAssign in Invoices in d_Invoices in ConectaProveedores (SELECT       COUNT(ial.Id) AS ApprovalCount  FROM      {InvoiceApprovalLevel} ial   INNER JOIN {InvoiceApproval} ia ON ial.InvoiceApprovalId = ia.Id  INNER JOIN {Invoice} inv ON ia.InvoiceId = inv.Id  INNER JOIN {Requisition} req ON inv.RequisitionId = req.Id  INNER JOIN {ApprovalStatus} asl ON ial.ApprovalStatusId = asl.Id  WHERE      (          ial.AssignedTo = @i_UserId          OR (              @i_IsUserRolesEmpty = 0              AND ial.ApplicationRoleId IN @i_UserRoles              AND req.RegionId = @i_RegionId              AND @i_IsTelcelDirectionsEmpty = 0              AND req.TelcelDirectionId IN @i_TelcelDirections          )      )      AND (ial.ApprovalStatusId = @i_ToAssignStatus)): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetInvoiceToAssignCount in GetInvoiceCountToAssign in Invoices in d_Invoices in ConectaProveedores (SELECT       COUNT(ial.Id) AS ApprovalCount  FROM      {InvoiceApprovalLevel} ial   INNER JOIN {InvoiceApproval} ia ON ial.InvoiceApprovalId = ia.Id  INNER JOIN {Invoice} inv ON ia.InvoiceId = inv.Id  INNER JOIN {Requisition} req ON inv.RequisitionId = req.Id  INNER JOIN {ApprovalStatus} asl ON ial.ApprovalStatusId = asl.Id  WHERE      (          ial.AssignedTo = @i_UserId          OR (              @i_IsUserRolesEmpty = 0              AND ial.ApplicationRoleId IN @i_UserRoles              AND req.RegionId = @i_RegionId              AND @i_IsTelcelDirectionsEmpty = 0              AND req.TelcelDirectionId IN @i_TelcelDirections          )      )      AND (ial.ApprovalStatusId = @i_ToAssignStatus)): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetUserApplicationRolesAndMore {

private static async Task<RC_3d56036e64426be06ca36c503a3c39e0> datasetGetUserApplicationRoleTempByConceptsReadDbAsync(RC_3d56036e64426be06ca36c503a3c39e0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUserApplicationRoleTemp.Read( r, ref index);
rec.ssENUserApplicationRoleTempByConcept.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleTempByConcepts" 1755Pf4XeUSGJBeKniFWtQ of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_b9107f331631f30bcef7fe9d900d99ae,long)> datasetGetUserApplicationRoleTempByConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "3d79bed7-17fe-4479-8624-178a9e2156b5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "3d79bed7-17fe-4479-8624-178a9e2156b5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/DataActions.mHnR1F6FIUmnSZe1p3ydGg/NodesNotShownInESpaceTree.1755Pf4XeUSGJBeKniFWtQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole54\".\"id\" o0, \"enapplicationrole54\".\"code\" o1, \"enapplicationrole54\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM (({UserApplicationRoleTempByConcept} \"enuserapplicationroletempbyconcept5\" Left JOIN {UserApplicationRoleTemp} \"enuserapplicationroletemp9\" ON (\"enuserapplicationroletempbyconcept5\".\"userapplicationroletempid\" = \"enuserapplicationroletemp9\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole54\" ON (\"enuserapplicationroletempbyconcept5\".\"applicationroleid\" = \"enapplicationrole54\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp9\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp9\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp9\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp9\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enuserapplicationroletempbyconcept5\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" lK+amouISEeTdJ3JORD+CA of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "9a9aaf94-888b-4748-9374-9dc93910fe08");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "9a9aaf94-888b-4748-9374-9dc93910fe08", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/DataActions.mHnR1F6FIUmnSZe1p3ydGg/NodesNotShownInESpaceTree.lK+amouISEeTdJ3JORD+CA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir5\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup5\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir5\" ON (\"ensegmentaccgroup5\".\"id\" = \"ensegmentaccgrouptelceldir5\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((trim(\"ensegmentaccgroup5\".\"groupname\")) collate \"default\") like caseaccent_normalize(@qpteSegmentAccGroup_GroupName collate \"default\")) AND (\"ensegmentaccgroup5\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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
// Query Function "GetRoleConcept" pecxp3FKV0KSbGCGVUTb5g of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetRoleConcept", "a731e7a5-4a71-4257-926c-60865544dbe6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetRoleConcept", "a731e7a5-4a71-4257-926c-60865544dbe6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.zqSZI4aohUeinDLMAY86JA/DataActions.mHnR1F6FIUmnSZe1p3ydGg/NodesNotShownInESpaceTree.pecxp3FKV0KSbGCGVUTb5g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole55\".\"code\" o1, \"enapplicationrole55\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole55\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion111\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept20\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal103\" Inner JOIN {User} \"enuser168\" ON (\"enuser_extended_internal103\".\"id\" = \"enuser168\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole51\" ON (\"enuser_extended_internal103\".\"jobtitle\" = \"enentrarole51\".\"rolename\"))  Left JOIN {Region} \"enregion111\" ON (\"enuser_extended_internal103\".\"regionid\" = \"enregion111\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept20\" ON (\"enentrarole51\".\"id\" = \"enroleconcept20\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole55\" ON (\"enroleconcept20\".\"applicationroleid\" = \"enapplicationrole55\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser168\".\"id\" = @qpusUser_Id) AND (\"enuser168\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser168\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept20\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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
