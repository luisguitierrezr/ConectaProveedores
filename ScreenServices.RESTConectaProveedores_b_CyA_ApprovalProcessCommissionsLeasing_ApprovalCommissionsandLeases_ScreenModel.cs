using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProposalLines")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_406ede22ed9cba3b6b03435d73fe20b6> ScreenDataSetGetProposalLines;
[JsonProperty("GetOperators")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965> ScreenDataSetGetOperators;
[JsonProperty("GetBanks")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a> ScreenDataSetGetBanks;
[JsonProperty("GetProposalLinesSum")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b> ScreenDataSetGetProposalLinesSum;
[JsonProperty("GetProposalType")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef> ScreenDataSetGetProposalType;
[JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> ScreenDataSetGetCompanies;
[JsonProperty("GetApprovalStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302> ScreenDataSetGetApprovalStatuses;
[JsonProperty("l_ShowFilters")]
public bool? varLcl_ShowFilters;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_IsSelected")]
public bool? varLcl_IsSelected;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsShowSelectAll")]
public bool? varLcl_IsShowSelectAll;
[JsonProperty("l_ShowRejectPopup")]
public bool? varLcl_ShowRejectPopup;
[JsonProperty("l_ProposalIdForRejectPopup")]
public long? varLcl_ProposalIdForRejectPopup;
[JsonProperty("l_ProposalLineApprovalLevelIdToReject")]
public long? varLcl_ProposalLineApprovalLevelIdToReject;
[JsonProperty("l_ApplicationRoleIdForAggregate")]
public long? varLcl_ApplicationRoleIdForAggregate;
[JsonProperty("l_IsAllowSelectApplicationRoles")]
public bool? varLcl_IsAllowSelectApplicationRoles;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetProposalLines")]
public string varLcl_ColumnJSONVarGetProposalLines;
[JsonProperty("l_CountAfterFetchGetProposalLines")]
public int? varLcl_CountAfterFetchGetProposalLines;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_RefeshDocumentSideBar")]
public String varLcl_RefeshDocumentSideBar;
[JsonProperty("l_SelectdLogDocumentId")]
public long? varLcl_SelectdLogDocumentId;
[JsonProperty("l_SelectdLogDocumentNumber")]
public string varLcl_SelectdLogDocumentNumber;
[JsonProperty("l_SelectdLogProposalId")]
public long? varLcl_SelectdLogProposalId;
[JsonProperty("l_AmountFromText")]
public string varLcl_AmountFromText;
[JsonProperty("l_AmountToText")]
public string varLcl_AmountToText;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel ToModel() {bool varLcl_ShowFilters = variables.varLcl_ShowFilters == null ? false : variables.varLcl_ShowFilters.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_IsSelected = variables.varLcl_IsSelected == null ? false : variables.varLcl_IsSelected.Value;
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsShowSelectAll = variables.varLcl_IsShowSelectAll == null ? false : variables.varLcl_IsShowSelectAll.Value;
bool varLcl_ShowRejectPopup = variables.varLcl_ShowRejectPopup == null ? false : variables.varLcl_ShowRejectPopup.Value;
long varLcl_ProposalIdForRejectPopup = variables.varLcl_ProposalIdForRejectPopup == null ? 0L : variables.varLcl_ProposalIdForRejectPopup.Value;
long varLcl_ProposalLineApprovalLevelIdToReject = variables.varLcl_ProposalLineApprovalLevelIdToReject == null ? 0L : variables.varLcl_ProposalLineApprovalLevelIdToReject.Value;
long varLcl_ApplicationRoleIdForAggregate = variables.varLcl_ApplicationRoleIdForAggregate == null ? 0L : variables.varLcl_ApplicationRoleIdForAggregate.Value;
bool varLcl_IsAllowSelectApplicationRoles = variables.varLcl_IsAllowSelectApplicationRoles == null ? false : variables.varLcl_IsAllowSelectApplicationRoles.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetProposalLines = variables.varLcl_ColumnJSONVarGetProposalLines == null ? "" : variables.varLcl_ColumnJSONVarGetProposalLines;
int varLcl_CountAfterFetchGetProposalLines = variables.varLcl_CountAfterFetchGetProposalLines == null ? 0 : variables.varLcl_CountAfterFetchGetProposalLines.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
DateTime varLcl_RefeshDocumentSideBar = variables.varLcl_RefeshDocumentSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshDocumentSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
long varLcl_SelectdLogDocumentId = variables.varLcl_SelectdLogDocumentId == null ? 0L : variables.varLcl_SelectdLogDocumentId.Value;
string varLcl_SelectdLogDocumentNumber = variables.varLcl_SelectdLogDocumentNumber == null ? "" : variables.varLcl_SelectdLogDocumentNumber;
long varLcl_SelectdLogProposalId = variables.varLcl_SelectdLogProposalId == null ? 0L : variables.varLcl_SelectdLogProposalId.Value;
string varLcl_AmountFromText = variables.varLcl_AmountFromText == null ? "" : variables.varLcl_AmountFromText;
string varLcl_AmountToText = variables.varLcl_AmountToText == null ? "" : variables.varLcl_AmountToText;
AggregateRecord<RL_529b8c0e645b1a53088b78c48fb2a9be> _ScreenDataSetGetProposalLines = (variables.ScreenDataSetGetProposalLines != null) ? variables.ScreenDataSetGetProposalLines.FromJS((array) => {
return RL_529b8c0e645b1a53088b78c48fb2a9be.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_406ede22ed9cba3b6b03435d73fe20b6.ToStructure);
}
) : null;
AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> _ScreenDataSetGetOperators = (variables.ScreenDataSetGetOperators != null) ? variables.ScreenDataSetGetOperators.FromJS((array) => {
return RL_f03e17396f660361b67a45f0e1101893.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965.ToStructure);
}
) : null;
AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> _ScreenDataSetGetBanks = (variables.ScreenDataSetGetBanks != null) ? variables.ScreenDataSetGetBanks.FromJS((array) => {
return RL_0fc5fa92a15115f6e97a1071c9876bcd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a.ToStructure);
}
) : null;
AggregateRecord<RL_8af3ce06aba4cbfdf62ee5d0bb265fe6> _ScreenDataSetGetProposalLinesSum = (variables.ScreenDataSetGetProposalLinesSum != null) ? variables.ScreenDataSetGetProposalLinesSum.FromJS((array) => {
return RL_8af3ce06aba4cbfdf62ee5d0bb265fe6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b.ToStructure);
}
) : null;
AggregateRecord<RL_75c16c4807d1a3963546d53942756918> _ScreenDataSetGetProposalType = (variables.ScreenDataSetGetProposalType != null) ? variables.ScreenDataSetGetProposalType.FromJS((array) => {
return RL_75c16c4807d1a3963546d53942756918.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef.ToStructure);
}
) : null;
AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_060f887b4f32b5cdb78b49175875565c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.ToStructure);
}
) : null;
AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> _ScreenDataSetGetApprovalStatuses = (variables.ScreenDataSetGetApprovalStatuses != null) ? variables.ScreenDataSetGetApprovalStatuses.FromJS((array) => {
return RL_51a4e63e168a01408e3f55c611518e13.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel screenModel = new ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel(varLcl_ShowFilters, varLcl_TableSort, varLcl_StartIndex, varLcl_IsSelected, varLcl_IsSelectAll, varLcl_IsShowSelectAll, varLcl_ShowRejectPopup, varLcl_ProposalIdForRejectPopup, varLcl_ProposalLineApprovalLevelIdToReject, varLcl_ApplicationRoleIdForAggregate, varLcl_IsAllowSelectApplicationRoles, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetProposalLines, varLcl_CountAfterFetchGetProposalLines, varLcl_Loading, varLcl_RefeshDocumentSideBar, varLcl_SelectdLogDocumentId, varLcl_SelectdLogDocumentNumber, varLcl_SelectdLogProposalId, varLcl_AmountFromText, varLcl_AmountToText, _ScreenDataSetGetProposalLines, _ScreenDataSetGetOperators, _ScreenDataSetGetBanks, _ScreenDataSetGetProposalLinesSum, _ScreenDataSetGetProposalType, _ScreenDataSetGetCompanies, _ScreenDataSetGetApprovalStatuses, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
