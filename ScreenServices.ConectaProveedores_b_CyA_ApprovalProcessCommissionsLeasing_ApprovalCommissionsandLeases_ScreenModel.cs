using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel).Namespace);

    public bool varLcl_ShowFilters;
public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_IsSelected;
public bool varLcl_IsSelectAll;
public bool varLcl_IsShowSelectAll;
public bool varLcl_ShowRejectPopup;
public long varLcl_ProposalIdForRejectPopup;
public long varLcl_ProposalLineApprovalLevelIdToReject;
public long varLcl_ApplicationRoleIdForAggregate;
public bool varLcl_IsAllowSelectApplicationRoles;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposalLines;
public int varLcl_CountAfterFetchGetProposalLines;
public bool varLcl_Loading;
public DateTime varLcl_RefeshDocumentSideBar;
public long varLcl_SelectdLogDocumentId;
public string varLcl_SelectdLogDocumentNumber;
public long varLcl_SelectdLogProposalId;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public AggregateRecord<RL_529b8c0e645b1a53088b78c48fb2a9be> ScreenDataSetGetProposalLines;
public AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators;
public AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks;
public AggregateRecord<RL_8af3ce06aba4cbfdf62ee5d0bb265fe6> ScreenDataSetGetProposalLinesSum;
public AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ScreenDataSetGetProposalType;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses;
public ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel() {
}



    public ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel(bool varLcl_ShowFilters, string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_IsSelected, bool varLcl_IsSelectAll, bool varLcl_IsShowSelectAll, bool varLcl_ShowRejectPopup, long varLcl_ProposalIdForRejectPopup, long varLcl_ProposalLineApprovalLevelIdToReject, long varLcl_ApplicationRoleIdForAggregate, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposalLines, int varLcl_CountAfterFetchGetProposalLines, bool varLcl_Loading, DateTime varLcl_RefeshDocumentSideBar, long varLcl_SelectdLogDocumentId, string varLcl_SelectdLogDocumentNumber, long varLcl_SelectdLogProposalId, string varLcl_AmountFromText, string varLcl_AmountToText, AggregateRecord<RL_529b8c0e645b1a53088b78c48fb2a9be> ScreenDataSetGetProposalLines, AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators, AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks, AggregateRecord<RL_8af3ce06aba4cbfdf62ee5d0bb265fe6> ScreenDataSetGetProposalLinesSum, AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ScreenDataSetGetProposalType, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses, ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ShowFilters", "l_TableSort", "l_StartIndex", "l_IsSelected", "l_IsSelectAll", "l_IsShowSelectAll", "l_ShowRejectPopup", "l_ProposalIdForRejectPopup", "l_ProposalLineApprovalLevelIdToReject", "l_ApplicationRoleIdForAggregate", "l_IsAllowSelectApplicationRoles", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposalLines", "l_CountAfterFetchGetProposalLines", "l_Loading", "l_RefeshDocumentSideBar", "l_SelectdLogDocumentId", "l_SelectdLogDocumentNumber", "l_SelectdLogProposalId", "l_AmountFromText", "l_AmountToText", "GetProposalLines", "GetOperators", "GetBanks", "GetProposalLinesSum", "GetProposalType", "GetCompanies", "GetApprovalStatuses", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcl_ShowFilters", "varLcl_TableSort", "varLcl_StartIndex", "varLcl_IsSelected", "varLcl_IsSelectAll", "varLcl_IsShowSelectAll", "varLcl_ShowRejectPopup", "varLcl_ProposalIdForRejectPopup", "varLcl_ProposalLineApprovalLevelIdToReject", "varLcl_ApplicationRoleIdForAggregate", "varLcl_IsAllowSelectApplicationRoles", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposalLines", "varLcl_CountAfterFetchGetProposalLines", "varLcl_Loading", "varLcl_RefeshDocumentSideBar", "varLcl_SelectdLogDocumentId", "varLcl_SelectdLogDocumentNumber", "varLcl_SelectdLogProposalId", "varLcl_AmountFromText", "varLcl_AmountToText", "ScreenDataSetGetProposalLines", "ScreenDataSetGetOperators", "ScreenDataSetGetBanks", "ScreenDataSetGetProposalLinesSum", "ScreenDataSetGetProposalType", "ScreenDataSetGetCompanies", "ScreenDataSetGetApprovalStatuses", "varLcGetUserApplicationRoles", "clientVariables"});
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_IsSelected = varLcl_IsSelected;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsShowSelectAll = varLcl_IsShowSelectAll;
this.varLcl_ShowRejectPopup = varLcl_ShowRejectPopup;
this.varLcl_ProposalIdForRejectPopup = varLcl_ProposalIdForRejectPopup;
this.varLcl_ProposalLineApprovalLevelIdToReject = varLcl_ProposalLineApprovalLevelIdToReject;
this.varLcl_ApplicationRoleIdForAggregate = varLcl_ApplicationRoleIdForAggregate;
this.varLcl_IsAllowSelectApplicationRoles = varLcl_IsAllowSelectApplicationRoles;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposalLines = varLcl_ColumnJSONVarGetProposalLines;
this.varLcl_CountAfterFetchGetProposalLines = varLcl_CountAfterFetchGetProposalLines;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_RefeshDocumentSideBar = varLcl_RefeshDocumentSideBar;
this.varLcl_SelectdLogDocumentId = varLcl_SelectdLogDocumentId;
this.varLcl_SelectdLogDocumentNumber = varLcl_SelectdLogDocumentNumber;
this.varLcl_SelectdLogProposalId = varLcl_SelectdLogProposalId;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.ScreenDataSetGetProposalLines = ScreenDataSetGetProposalLines;
this.ScreenDataSetGetOperators = ScreenDataSetGetOperators;
this.ScreenDataSetGetBanks = ScreenDataSetGetBanks;
this.ScreenDataSetGetProposalLinesSum = ScreenDataSetGetProposalLinesSum;
this.ScreenDataSetGetProposalType = ScreenDataSetGetProposalType;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.ScreenDataSetGetApprovalStatuses = ScreenDataSetGetApprovalStatuses;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_406ede22ed9cba3b6b03435d73fe20b6> datasetGetProposalLinesReadDbAsync(RC_406ede22ed9cba3b6b03435d73fe20b6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENBank.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENProposalLineApprovalLevel.Read( r, ref index);
rec.ssENProposalType.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "BankProposalApprovalLevelProposalProposalTypeApprovalStatusProposalLineApprovalLevelProposalApprovalProposalLineApplicationRoleIsSelectedCompanyRegionRecord.IsSelected", false);
return rec;
}
// Query Function "GetProposalLines" T045IaEgbUikLDD3TIFm9g of Action "ApprovalCommissionsandLeases"
public static async Task<(RL_529b8c0e645b1a53088b78c48fb2a9be,long)> datasetGetProposalLines(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,decimal qpdeCommision_Leases_AmountMLFrom,decimal qpdeCommision_Leases_AmountMLTo,int qpapProposalLineApprovalLevel_ApprovalStatusId,long qpapApplicationRole_Id,long qpbaProposal_BankId,long qpcoCompany_Id,DateTime qpdaProposal_PaymentDate,string qpteCommision_Leases_ProposalSearch,long qpreRegion_Id,long qpsuProposalLine_SupplierId,int qpprProposalType_Id,DateTime qpdaCommision_Leases_UploadDate,int qpinOffsetUtc,long qpreProposal_RegionId,long qpapProposalLineApprovalLevel_ApplicationRoleId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLines", "21394e4f-20a1-486d-a42c-30f74c8166f6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ApprovalCommissionsandLeases","b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLines");
// Query Iterations: Multiple
// Refresh Query lZVC1bepLEOPnymM9VnMzQ Iterations: Multiple
// Refresh Query Jby5cfjnHUa9O+y7W5XjqA Iterations: Multiple
// Refresh Query krdeR5kPeE+IfgFVjGtlPg Iterations: Multiple
// Refresh Query MTKiNxdMdEOFdvqSTO3rEg Iterations: Multiple
// Refresh Query lUe2WUkXdUel2dYxCWpkDA Iterations: Multiple
// Refresh Query aUmD+YZsl0ucbPz2Aj_WCg Iterations: Multiple
// Refresh Query zGr9HkeR902MXrHgoGliLw Iterations: Multiple
// Refresh Query PU4UsX7JB0+fRv6XjtKzEQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Y3pwduz0C0izqgHcWJtGKw/NodesShownInESpaceTree.aQZnFr0OmkKmO1CTJiZM7g/ScreenDataSets.T045IaEgbUikLDD3TIFm9g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole72\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalstatus19\".\"label\" o8, \"enapprovalstatus19\".\"class\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enbank1\".\"code\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"enproposal15\".\"id\" o34, \"enproposal15\".\"name\" o35, \"enproposal15\".\"paymentdate\" o36, NULL o37, NULL o38, NULL o39, \"enproposal15\".\"proposalstatusid\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, \"enproposalline10\".\"id\" o67, \"enproposalline10\".\"proposalid\" o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, \"enproposalline10\".\"cuenta\" o74, NULL o75, \"enproposalline10\".\"nombre1\" o76, NULL o77, \"enproposalline10\".\"n_doc_\" o78, \"enproposalline10\".\"n_doctype\" o79, trim_scale(\"enproposalline10\".\"importeenml\"::numeric) o80, NULL o81, NULL o82, NULL o83, \"enproposalline10\".\"soc_\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, \"enproposallineapprovallevel5\".\"id\" o95, NULL o96, NULL o97, NULL o98, \"enproposallineapprovallevel5\".\"approvalstatusid\" o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, \"enproposaltype\".\"label\" o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, \"enregion150\".\"divisionfi\" o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, 0 \"isselected\"");
fromBuilder.Append(" FROM (((((((((({ProposalLineApprovalLevel} \"enproposallineapprovallevel5\" Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel8\" ON (\"enproposallineapprovallevel5\".\"proposalapprovallevelid\" = \"enproposalapprovallevel8\".\"id\"))  Left JOIN {ProposalApproval} \"enproposalapproval6\" ON (\"enproposalapprovallevel8\".\"proposalapprovalid\" = \"enproposalapproval6\".\"id\"))  Left JOIN {Proposal} \"enproposal15\" ON (\"enproposalapproval6\".\"proposalid\" = \"enproposal15\".\"id\"))  Left JOIN {ProposalLine} \"enproposalline10\" ON (\"enproposallineapprovallevel5\".\"proposallineid\" = \"enproposalline10\".\"id\"))  Left JOIN {Region} \"enregion150\" ON (\"enproposal15\".\"regionid\" = \"enregion150\".\"id\"))  Left JOIN {Company} \"encompany54\" ON (\"enproposalline10\".\"soc_\" = \"encompany54\".\"externalid\"))  Left JOIN {Bank} \"enbank1\" ON (\"enproposal15\".\"bankid\" = \"enbank1\".\"id\"))  Inner JOIN {ApplicationRole} \"enapplicationrole72\" ON (\"enproposallineapprovallevel5\".\"applicationroleid\" = \"enapplicationrole72\".\"id\"))  Left JOIN {ProposalType} \"enproposaltype\" ON (\"enproposal15\".\"proposaltypeid\" = \"enproposaltype\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus19\" ON (\"enproposallineapprovallevel5\".\"approvalstatusid\" = \"enapprovalstatus19\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuProposalLine_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuProposalLine_SupplierId != 0) {
whereBuilder.Append("((\"enproposalline10\".\"supplierid\" = @qpsuProposalLine_SupplierId) AND (\"enproposalline10\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuProposalLine_SupplierId", DbType.Int64, qpsuProposalLine_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuProposalLine_SupplierId", DbType.Int64, qpsuProposalLine_SupplierId);
} else {
whereBuilder.Append("(\"enproposalline10\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteCommision_Leases_ProposalSearch != " " && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "") {
whereBuilder.Append("(((((caseaccent_normalize(\"enproposal15\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\")) OR (caseaccent_normalize(\"enproposalline10\".\"n_doctype\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enproposalline10\".\"nombre1\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enproposalline10\".\"nombre1\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enproposalline10\".\"cuenta\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteCommision_Leases_ProposalSearch", DbType.String, qpteCommision_Leases_ProposalSearch);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteCommision_Leases_ProposalSearch", DbType.String, qpteCommision_Leases_ProposalSearch);
}
if (qpreProposal_RegionId != 0) {
whereBuilder.Append("((\"enproposal15\".\"regionid\" = @qpreProposal_RegionId) AND (\"enproposal15\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
} else {
whereBuilder.Append("(\"enproposal15\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapProposalLineApprovalLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel5\".\"applicationroleid\" = @qpapProposalLineApprovalLevel_ApplicationRoleId) AND (\"enproposallineapprovallevel5\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapProposalLineApprovalLevel_ApplicationRoleId", DbType.Int64, qpapProposalLineApprovalLevel_ApplicationRoleId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpapProposalLineApprovalLevel_ApplicationRoleId", DbType.Int64, qpapProposalLineApprovalLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel5\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (((\"enproposal15\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(") AND (\"enproposal15\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId);
whereBuilder.Append(")) AND (\"enproposal15\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(")) AND ");
if (qpapProposalLineApprovalLevel_ApprovalStatusId != BuiltInFunction.NullIdentifier()) {
if (qpapProposalLineApprovalLevel_ApprovalStatusId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel5\".\"approvalstatusid\" = @qpapProposalLineApprovalLevel_ApprovalStatusId) AND (\"enproposallineapprovallevel5\".\"approvalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapProposalLineApprovalLevel_ApprovalStatusId", DbType.Int32, qpapProposalLineApprovalLevel_ApprovalStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpapProposalLineApprovalLevel_ApprovalStatusId", DbType.Int32, qpapProposalLineApprovalLevel_ApprovalStatusId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel5\".\"approvalstatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpbaProposal_BankId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpbaProposal_BankId != 0) {
whereBuilder.Append("((\"enproposal15\".\"bankid\" = @qpbaProposal_BankId) AND (\"enproposal15\".\"bankid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
} else {
whereBuilder.Append("(\"enproposal15\".\"bankid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaProposal_PaymentDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaProposal_PaymentDate::date = \"enproposal15\".\"paymentdate\"::date) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaProposal_PaymentDate", DbType.DateTime, qpdaProposal_PaymentDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaProposal_PaymentDate", DbType.DateTime, qpdaProposal_PaymentDate);
}
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion150\".\"id\" = @qpreRegion_Id) AND (\"enregion150\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion150\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpprProposalType_Id != BuiltInFunction.NullIdentifier()) {
if (qpprProposalType_Id != 0) {
whereBuilder.Append("((\"enproposaltype\".\"id\" = @qpprProposalType_Id) AND (\"enproposaltype\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalType_Id", DbType.Int32, qpprProposalType_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalType_Id", DbType.Int32, qpprProposalType_Id);
} else {
whereBuilder.Append("(\"enproposaltype\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaCommision_Leases_UploadDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaCommision_Leases_UploadDate = (cast(((\"enproposal15\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaCommision_Leases_UploadDate", DbType.DateTime, qpdaCommision_Leases_UploadDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaCommision_Leases_UploadDate", DbType.DateTime, qpdaCommision_Leases_UploadDate);
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
}
if (qpapApplicationRole_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpapApplicationRole_Id != 0) {
whereBuilder.Append("((\"enapplicationrole72\".\"id\" = @qpapApplicationRole_Id) AND (\"enapplicationrole72\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRole_Id", DbType.Int64, qpapApplicationRole_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpapApplicationRole_Id", DbType.Int64, qpapApplicationRole_Id);
} else {
whereBuilder.Append("(\"enapplicationrole72\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpcoCompany_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoCompany_Id != 0) {
whereBuilder.Append("((\"encompany54\".\"id\" = @qpcoCompany_Id) AND (\"encompany54\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
} else {
whereBuilder.Append("(\"encompany54\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdeCommision_Leases_AmountMLFrom != (((decimal)0))) {
whereBuilder.Append("(\"enproposalline10\".\"importeenml\" >= @qpdeCommision_Leases_AmountMLFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeCommision_Leases_AmountMLFrom", DbType.Decimal, qpdeCommision_Leases_AmountMLFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeCommision_Leases_AmountMLFrom", DbType.Decimal, qpdeCommision_Leases_AmountMLFrom);
}
if (qpdeCommision_Leases_AmountMLTo != (((decimal)0))) {
whereBuilder.Append("(\"enproposalline10\".\"importeenml\" <= @qpdeCommision_Leases_AmountMLTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeCommision_Leases_AmountMLTo", DbType.Decimal, qpdeCommision_Leases_AmountMLTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeCommision_Leases_AmountMLTo", DbType.Decimal, qpdeCommision_Leases_AmountMLTo);
}
whereBuilder.Append("(\"enproposallineapprovallevel5\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Bank", "ApprovalStatus", "Proposal", "Region", "ApplicationRole", "ProposalApprovalLevel", "ProposalLine", "ProposalLineApprovalLevel", "ProposalApproval", "ProposalType", "Company" }, new string[] { "ENBank1", "ENApprovalStatus19", "ENProposal15", "ENRegion150", "ENApplicationRole72", "ENProposalApprovalLevel8", "ENProposalLine10", "ENProposalLineApprovalLevel5", "ENProposalApproval6", "ENProposalType", "ENCompany54" }, new System.Collections.Generic.Dictionary<string, string>[] { ENBankEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENProposalEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENProposalApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENProposalLineEntity.AttributesToDatabaseNamesMap(), ENProposalLineApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENProposalApprovalEntity.AttributesToDatabaseNamesMap(), ENProposalTypeEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enapprovalstatus19\".\"order\" ASC ");
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
RL_529b8c0e645b1a53088b78c48fb2a9be outParamList = new RL_529b8c0e645b1a53088b78c48fb2a9be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLinesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[11];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true});
opt[4] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {false, false, true, true, true, true, true, false, true, false, true, false, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLines.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLines.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_529b8c0e645b1a53088b78c48fb2a9be _tmp = new RL_529b8c0e645b1a53088b78c48fb2a9be();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLinesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLines.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_529b8c0e645b1a53088b78c48fb2a9be)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLines.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetOperators" KDU6Kwd21k6l9rCKcHJKEA of Action "ApprovalCommissionsandLeases"
public static async Task<(RL_f03e17396f660361b67a45f0e1101893,long)> datasetGetOperators(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetOperators", "2b3a3528-7607-4ed6-a5f6-b08a70724a10");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ApprovalCommissionsandLeases","b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetOperators");
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
selectBuilder.Append("/* /NRWebFlows.Y3pwduz0C0izqgHcWJtGKw/NodesShownInESpaceTree.aQZnFr0OmkKmO1CTJiZM7g/ScreenDataSets.KDU6Kwd21k6l9rCKcHJKEA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enoperator\".\"operator\" o0, \"enoperator\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Operator} \"enoperator\"");
whereBuilder.Append(" WHERE (\"enoperator\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1)");
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
RL_f03e17396f660361b67a45f0e1101893 outParamList = new RL_f03e17396f660361b67a45f0e1101893();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetOperators.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f03e17396f660361b67a45f0e1101893 _tmp = new RL_f03e17396f660361b67a45f0e1101893();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetOperators.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f03e17396f660361b67a45f0e1101893)_tmp;
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

// Query Function "GetBanks" wUnZO9R1jEi9bICzhczWVw of Action "ApprovalCommissionsandLeases"
public static async Task<(RL_0fc5fa92a15115f6e97a1071c9876bcd,long)> datasetGetBanks(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetBanks", "3bd949c1-75d4-488c-bd6c-80b385ccd657");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ApprovalCommissionsandLeases","b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetBanks");
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
selectBuilder.Append("/* /NRWebFlows.Y3pwduz0C0izqgHcWJtGKw/NodesShownInESpaceTree.aQZnFr0OmkKmO1CTJiZM7g/ScreenDataSets.wUnZO9R1jEi9bICzhczWVw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbank2\".\"id\" o0, NULL o1, \"enbank2\".\"shortname\" o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {Bank} \"enbank2\"");
whereBuilder.Append(" WHERE (\"enbank2\".\"isactive\" = 1) AND (@qpboCheckUserSession = 1)");
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
RL_0fc5fa92a15115f6e97a1071c9876bcd outParamList = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetBanks.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0fc5fa92a15115f6e97a1071c9876bcd _tmp = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetBanks.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0fc5fa92a15115f6e97a1071c9876bcd)_tmp;
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

private static async Task<RC_46775da414dc909821822de65ba32d4b> datasetGetProposalLinesSumReadDbAsync(RC_46775da414dc909821822de65ba32d4b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssSymbol = r.ReadText(index++, "SymbolImporteenMLSumRecord.Symbol", "");
rec.ssImporteenMLSum = r.ReadDecimal(index++, "SymbolImporteenMLSumRecord.ImporteenMLSum", 0.0M);
return rec;
}
// Query Function "GetProposalLinesSum" iRabWaSqqkKPrPpMK3plpQ of Action "ApprovalCommissionsandLeases"
public static async Task<(RL_8af3ce06aba4cbfdf62ee5d0bb265fe6,long)> datasetGetProposalLinesSum(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,decimal qpdeCommision_Leases_AmountMLFrom,decimal qpdeCommision_Leases_AmountMLTo,int qpapProposalLineApprovalLevel_ApprovalStatusId,long qpapApplicationRole_Id,long qpbaProposal_BankId,long qpcoCompany_Id,DateTime qpdaProposal_PaymentDate,string qpteCommision_Leases_ProposalSearch,long qpreRegion_Id,long qpsuProposalLine_SupplierId,int qpprProposalType_Id,DateTime qpdaCommision_Leases_UploadDate,int qpinOffsetUtc,long qpreProposal_RegionId,long qpapProposalLineApprovalLevel_ApplicationRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLinesSum", "599b1689-aaa4-42aa-8fac-fa4c2b7a65a5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ApprovalCommissionsandLeases","b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLinesSum");
// Query Iterations: Never
// Refresh Query Bem0f+atZEGSngcq3xxR1A Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Y3pwduz0C0izqgHcWJtGKw/NodesShownInESpaceTree.aQZnFr0OmkKmO1CTJiZM7g/ScreenDataSets.iRabWaSqqkKPrPpMK3plpQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency27\".\"symbol\" \"symbol\", Sum(\"enproposalline11\".\"importeenml\") \"importeenmlsum\"");
fromBuilder.Append(" FROM ((((((((((({ProposalLineApprovalLevel} \"enproposallineapprovallevel6\" Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel9\" ON (\"enproposallineapprovallevel6\".\"proposalapprovallevelid\" = \"enproposalapprovallevel9\".\"id\"))  Left JOIN {ProposalApproval} \"enproposalapproval7\" ON (\"enproposalapprovallevel9\".\"proposalapprovalid\" = \"enproposalapproval7\".\"id\"))  Left JOIN {Proposal} \"enproposal16\" ON (\"enproposalapproval7\".\"proposalid\" = \"enproposal16\".\"id\"))  Left JOIN {ProposalLine} \"enproposalline11\" ON (\"enproposallineapprovallevel6\".\"proposallineid\" = \"enproposalline11\".\"id\"))  Left JOIN {Region} \"enregion151\" ON (\"enproposal16\".\"regionid\" = \"enregion151\".\"id\"))  Left JOIN {Company} \"encompany55\" ON (\"enproposalline11\".\"soc_\" = \"encompany55\".\"externalid\"))  Left JOIN {Bank} \"enbank3\" ON (\"enproposal16\".\"bankid\" = \"enbank3\".\"id\"))  Inner JOIN {ApplicationRole} \"enapplicationrole73\" ON (\"enproposallineapprovallevel6\".\"applicationroleid\" = \"enapplicationrole73\".\"id\"))  Left JOIN {ProposalType} \"enproposaltype1\" ON (\"enproposal16\".\"proposaltypeid\" = \"enproposaltype1\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus20\" ON (\"enproposallineapprovallevel6\".\"approvalstatusid\" = \"enapprovalstatus20\".\"id\"))  Left JOIN {Currency} \"encurrency27\" ON (\"enproposal16\".\"currencyid\" = \"encurrency27\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuProposalLine_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuProposalLine_SupplierId != 0) {
whereBuilder.Append("((\"enproposalline11\".\"supplierid\" = @qpsuProposalLine_SupplierId) AND (\"enproposalline11\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuProposalLine_SupplierId", DbType.Int64, qpsuProposalLine_SupplierId);
} else {
whereBuilder.Append("(\"enproposalline11\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteCommision_Leases_ProposalSearch != " " && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "" && qpteCommision_Leases_ProposalSearch != "") {
whereBuilder.Append("(((((caseaccent_normalize(\"enproposal16\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\")) OR (caseaccent_normalize(\"enproposalline11\".\"n_doctype\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enproposalline11\".\"nombre1\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enproposalline11\".\"nombre1\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enproposalline11\".\"cuenta\" collate \"default\") like caseaccent_normalize((('%' || @qpteCommision_Leases_ProposalSearch) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteCommision_Leases_ProposalSearch", DbType.String, qpteCommision_Leases_ProposalSearch);
}
if (qpreProposal_RegionId != 0) {
whereBuilder.Append("((\"enproposal16\".\"regionid\" = @qpreProposal_RegionId) AND (\"enproposal16\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
} else {
whereBuilder.Append("(\"enproposal16\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapProposalLineApprovalLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel6\".\"applicationroleid\" = @qpapProposalLineApprovalLevel_ApplicationRoleId) AND (\"enproposallineapprovallevel6\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapProposalLineApprovalLevel_ApplicationRoleId", DbType.Int64, qpapProposalLineApprovalLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel6\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (((\"enproposal16\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(") AND (\"enproposal16\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId);
whereBuilder.Append(")) AND (\"enproposal16\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(")) AND ");
if (qpapProposalLineApprovalLevel_ApprovalStatusId != BuiltInFunction.NullIdentifier()) {
if (qpapProposalLineApprovalLevel_ApprovalStatusId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel6\".\"approvalstatusid\" = @qpapProposalLineApprovalLevel_ApprovalStatusId) AND (\"enproposallineapprovallevel6\".\"approvalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapProposalLineApprovalLevel_ApprovalStatusId", DbType.Int32, qpapProposalLineApprovalLevel_ApprovalStatusId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel6\".\"approvalstatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpbaProposal_BankId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpbaProposal_BankId != 0) {
whereBuilder.Append("((\"enproposal16\".\"bankid\" = @qpbaProposal_BankId) AND (\"enproposal16\".\"bankid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
} else {
whereBuilder.Append("(\"enproposal16\".\"bankid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaProposal_PaymentDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaProposal_PaymentDate::date = \"enproposal16\".\"paymentdate\"::date) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaProposal_PaymentDate", DbType.DateTime, qpdaProposal_PaymentDate);
}
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion151\".\"id\" = @qpreRegion_Id) AND (\"enregion151\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion151\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpprProposalType_Id != BuiltInFunction.NullIdentifier()) {
if (qpprProposalType_Id != 0) {
whereBuilder.Append("((\"enproposaltype1\".\"id\" = @qpprProposalType_Id) AND (\"enproposaltype1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalType_Id", DbType.Int32, qpprProposalType_Id);
} else {
whereBuilder.Append("(\"enproposaltype1\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaCommision_Leases_UploadDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("(@qpdaCommision_Leases_UploadDate = (cast(((\"enproposal16\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaCommision_Leases_UploadDate", DbType.DateTime, qpdaCommision_Leases_UploadDate);
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
}
if (qpapApplicationRole_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpapApplicationRole_Id != 0) {
whereBuilder.Append("((\"enapplicationrole73\".\"id\" = @qpapApplicationRole_Id) AND (\"enapplicationrole73\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRole_Id", DbType.Int64, qpapApplicationRole_Id);
} else {
whereBuilder.Append("(\"enapplicationrole73\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpcoCompany_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoCompany_Id != 0) {
whereBuilder.Append("((\"encompany55\".\"id\" = @qpcoCompany_Id) AND (\"encompany55\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
} else {
whereBuilder.Append("(\"encompany55\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdeCommision_Leases_AmountMLFrom != (((decimal)0))) {
whereBuilder.Append("(\"enproposalline11\".\"importeenml\" >= @qpdeCommision_Leases_AmountMLFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeCommision_Leases_AmountMLFrom", DbType.Decimal, qpdeCommision_Leases_AmountMLFrom);
}
if (qpdeCommision_Leases_AmountMLTo != (((decimal)0))) {
whereBuilder.Append("(\"enproposalline11\".\"importeenml\" <= @qpdeCommision_Leases_AmountMLTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeCommision_Leases_AmountMLTo", DbType.Decimal, qpdeCommision_Leases_AmountMLTo);
}
whereBuilder.Append("(\"enproposallineapprovallevel6\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(")");
groupByBuilder.Append(" GROUP BY \"encurrency27\".\"symbol\"");
orderByBuilder.Append(" ORDER BY 1 ASC");
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
RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 outParamList = new RL_8af3ce06aba4cbfdf62ee5d0bb265fe6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLinesSumReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLinesSum.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8af3ce06aba4cbfdf62ee5d0bb265fe6 _tmp = new RL_8af3ce06aba4cbfdf62ee5d0bb265fe6();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLinesSumReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalLinesSum.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8af3ce06aba4cbfdf62ee5d0bb265fe6)_tmp;
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

// Query Function "GetProposalType" +12ufULJ6EK4qblrI4tAVQ of Action "ApprovalCommissionsandLeases"
public static async Task<(RL_75c16c4807d1a3963546d53942756918,long)> datasetGetProposalType(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalType", "7dae5dfb-c942-42e8-b8a9-b96b238b4055");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ApprovalCommissionsandLeases","b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalType");
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
selectBuilder.Append("/* /NRWebFlows.Y3pwduz0C0izqgHcWJtGKw/NodesShownInESpaceTree.aQZnFr0OmkKmO1CTJiZM7g/ScreenDataSets.+12ufULJ6EK4qblrI4tAVQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposaltype2\".\"id\" o0, \"enproposaltype2\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {ProposalType} \"enproposaltype2\"");
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
RL_75c16c4807d1a3963546d53942756918 outParamList = new RL_75c16c4807d1a3963546d53942756918();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalType.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_75c16c4807d1a3963546d53942756918 _tmp = new RL_75c16c4807d1a3963546d53942756918();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetProposalType.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_75c16c4807d1a3963546d53942756918)_tmp;
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

// Query Function "GetCompanies" SuXegzjzRE+y1MwhqVfcXA of Action "ApprovalCommissionsandLeases"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetCompanies", "83dee54a-f338-4f44-b2d4-cc21a957dc5c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ApprovalCommissionsandLeases","b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.Y3pwduz0C0izqgHcWJtGKw/NodesShownInESpaceTree.aQZnFr0OmkKmO1CTJiZM7g/ScreenDataSets.SuXegzjzRE+y1MwhqVfcXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany56\".\"id\" o0, \"encompany56\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany56\"");
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
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetCompanies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetCompanies.List", cancellationToken: cancellationToken);
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

// Query Function "GetApprovalStatuses" g462kfbqzkq+l7WoU6ouig of Action "ApprovalCommissionsandLeases"
public static async Task<(RL_51a4e63e168a01408e3f55c611518e13,long)> datasetGetApprovalStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetApprovalStatuses", "91b68e83-eaf6-4ace-be97-b5a853aa2e8a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ApprovalCommissionsandLeases","b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetApprovalStatuses");
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
selectBuilder.Append("/* /NRWebFlows.Y3pwduz0C0izqgHcWJtGKw/NodesShownInESpaceTree.aQZnFr0OmkKmO1CTJiZM7g/ScreenDataSets.g462kfbqzkq+l7WoU6ouig, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus21\".\"id\" o0, \"enapprovalstatus21\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {ApprovalStatus} \"enapprovalstatus21\"");
whereBuilder.Append(" WHERE (\"enapprovalstatus21\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1) AND (\"enapprovalstatus21\".\"iscyaapproval\" = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalstatus21\".\"label\" ASC ");
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
RL_51a4e63e168a01408e3f55c611518e13 outParamList = new RL_51a4e63e168a01408e3f55c611518e13();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetApprovalStatuses.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetApprovalStatuses.List", cancellationToken: cancellationToken);
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


    public class lcvGetUserApplicationRoles : VarsBag {
public RL_d70d60310c194f7f5b4377c60b208de6 queryResGetUserRoles_outParamList = new RL_d70d60310c194f7f5b4377c60b208de6();
public long queryResGetUserRoles_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_da93b3cf8542f5b831efc106e94ee7e2 outParamUserRolesList = new RL_da93b3cf8542f5b831efc106e94ee7e2();

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<RL_da93b3cf8542f5b831efc106e94ee7e2> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_da93b3cf8542f5b831efc106e94ee7e2 outParamUserRolesList = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "f372aed9-dc80-4168-afe8-f5f4f51ddf9c"))
using (activitySource.CreateScreenDataActionActivity("ApprovalCommissionsandLeases", "GetUserApplicationRoles")){
// Query QueryGetUserRoles
cancellationToken.ThrowIfCancellationRequested();
int QueryGetUserRoles_maxRecords = 0;
int QueryGetUserRoles_startIndex = 0;(localVars.queryResGetUserRoles_outParamList,localVars.queryResGetUserRoles_outParamCount) = await FuncDataActionGetUserApplicationRoles.QueryGetUserRoles(requestContext,QueryGetUserRoles_maxRecords,QueryGetUserRoles_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),2,cancellationToken);

// UserRolesList = GetUserRoles.List
result.outParamUserRolesList=(await RL_da93b3cf8542f5b831efc106e94ee7e2.ConvertAsync(localVars.queryResGetUserRoles_outParamList, new RL_da93b3cf8542f5b831efc106e94ee7e2(), async (RC_7bfa75f5202ddb9627a7dd8185c0c12b source, ST_9adff333942ff7120fc18c8e55f201fdStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
} // inner-finally
RETURN_STATEMENT:
return outParamUserRolesList;
}


    public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetUserRoles" j8kO5pKTUUikUaru6vonyg of Action "GetUserApplicationRoles"
public static async Task<(RL_d70d60310c194f7f5b4377c60b208de6,long)> QueryGetUserRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,int qproRoleStatusActiveId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetUserApplicationRoles.GetUserRoles", "e60ec98f-9392-4851-a451-aaeeeafa27ca");
using var queryActivity = activitySource.CreateSqlQueryActivity("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetUserApplicationRoles.GetUserRoles", "e60ec98f-9392-4851-a451-aaeeeafa27ca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityUserApplicationRole = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRole");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityUserApplicationRoleTemp = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRoleTemp");
sqlCmd.CreateParameter("@qpusUserId", DbType.String, qpusUserId);
sqlCmd.CreateParameter("@qproRoleStatusActiveId", DbType.Int32, qproRoleStatusActiveId);
string sql = "";
string advSql = "SELECT  \n    uar.ApplicationRoleId, \n    ar.Name \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRole,"") + " uar \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uar.ApplicationRoleId = ar.Id \nWHERE uar.UserId = @qpusUserId \n  AND uar.RoleStatusId = @qproRoleStatusActiveId \n \nUNION \n \nSELECT  \n    uat.ApplicationRoleId, \n    ar.Name \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRoleTemp,"") + " uat \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uat.ApplicationRoleId = ar.Id \nWHERE uat.UserId = @qpusUserId \n  AND uat.RoleStatusId = @qproRoleStatusActiveId";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d70d60310c194f7f5b4377c60b208de6 outParamList = new RL_d70d60310c194f7f5b4377c60b208de6();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d70d60310c194f7f5b4377c60b208de6 _tmp = new RL_d70d60310c194f7f5b4377c60b208de6();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d70d60310c194f7f5b4377c60b208de6)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetUserRoles in GetUserApplicationRoles in ApprovalCommissionsandLeases in b_CyA_ApprovalProcessCommissionsLeasing in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    UNION    SELECT       uat.ApplicationRoleId,      ar.Name  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId  ): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in ApprovalCommissionsandLeases in b_CyA_ApprovalProcessCommissionsLeasing in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    UNION    SELECT       uat.ApplicationRoleId,      ar.Name  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId  ): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in ApprovalCommissionsandLeases in b_CyA_ApprovalProcessCommissionsLeasing in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    UNION    SELECT       uat.ApplicationRoleId,      ar.Name  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId  ): " + aqExcep.Message));
}
}
}
}


}
