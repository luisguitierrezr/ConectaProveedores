using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetCurrencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e> ScreenDataSetGetCurrencies;
[JsonProperty("GetOperators")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965> ScreenDataSetGetOperators;
[JsonProperty("GetProposalStatus")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2> ScreenDataSetGetProposalStatus;
[JsonProperty("GetBanks")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a> ScreenDataSetGetBanks;
[JsonProperty("GetProposalTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef> ScreenDataSetGetProposalTypes;
[JsonProperty("GetProposals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ce0b7a0d9784faac9b31d2f092421318> ScreenDataSetGetProposals;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_ShowFilters")]
public bool? varLcl_ShowFilters;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetProposal")]
public string varLcl_ColumnJSONVarGetProposal;
[JsonProperty("l_CountAfterFetchGetProposal")]
public int? varLcl_CountAfterFetchGetProposal;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_IsAutoRefresh")]
public bool? varLcl_IsAutoRefresh;
[JsonProperty("l_AmountFromText")]
public string varLcl_AmountFromText;
[JsonProperty("l_AmountToText")]
public string varLcl_AmountToText;
[JsonProperty("GetUploadType")]
public RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs varLcGetUploadType;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "FileExtended.id desc" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ShowFilters = variables.varLcl_ShowFilters == null ? false : variables.varLcl_ShowFilters.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetProposal = variables.varLcl_ColumnJSONVarGetProposal == null ? "" : variables.varLcl_ColumnJSONVarGetProposal;
int varLcl_CountAfterFetchGetProposal = variables.varLcl_CountAfterFetchGetProposal == null ? 0 : variables.varLcl_CountAfterFetchGetProposal.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
bool varLcl_IsAutoRefresh = variables.varLcl_IsAutoRefresh == null ? false : variables.varLcl_IsAutoRefresh.Value;
string varLcl_AmountFromText = variables.varLcl_AmountFromText == null ? "" : variables.varLcl_AmountFromText;
string varLcl_AmountToText = variables.varLcl_AmountToText == null ? "" : variables.varLcl_AmountToText;
AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> _ScreenDataSetGetCurrencies = (variables.ScreenDataSetGetCurrencies != null) ? variables.ScreenDataSetGetCurrencies.FromJS((array) => {
return RL_1353a59e0688582d82bbddc41b47193e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e.ToStructure);
}
) : null;
AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> _ScreenDataSetGetOperators = (variables.ScreenDataSetGetOperators != null) ? variables.ScreenDataSetGetOperators.FromJS((array) => {
return RL_f03e17396f660361b67a45f0e1101893.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965.ToStructure);
}
) : null;
AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> _ScreenDataSetGetProposalStatus = (variables.ScreenDataSetGetProposalStatus != null) ? variables.ScreenDataSetGetProposalStatus.FromJS((array) => {
return RL_edf26e482e095588ed6d5cbd5313bc7f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2.ToStructure);
}
) : null;
AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> _ScreenDataSetGetBanks = (variables.ScreenDataSetGetBanks != null) ? variables.ScreenDataSetGetBanks.FromJS((array) => {
return RL_0fc5fa92a15115f6e97a1071c9876bcd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a.ToStructure);
}
) : null;
AggregateRecord<RL_75c16c4807d1a3963546d53942756918> _ScreenDataSetGetProposalTypes = (variables.ScreenDataSetGetProposalTypes != null) ? variables.ScreenDataSetGetProposalTypes.FromJS((array) => {
return RL_75c16c4807d1a3963546d53942756918.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef.ToStructure);
}
) : null;
AggregateRecord<RL_8ba5b56e8055656db873b3771bf59d3c> _ScreenDataSetGetProposals = (variables.ScreenDataSetGetProposals != null) ? variables.ScreenDataSetGetProposals.FromJS((array) => {
return RL_8ba5b56e8055656db873b3771bf59d3c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ce0b7a0d9784faac9b31d2f092421318.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Model _varLcGetUploadType = (variables.varLcGetUploadType != null) ? RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs.ToModel(variables.varLcGetUploadType) : null;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel screenModel = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ShowFilters, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetProposal, varLcl_CountAfterFetchGetProposal, varLcl_Loading, varLcl_IsAutoRefresh, varLcl_AmountFromText, varLcl_AmountToText, _ScreenDataSetGetCurrencies, _ScreenDataSetGetOperators, _ScreenDataSetGetProposalStatus, _ScreenDataSetGetBanks, _ScreenDataSetGetProposalTypes, _ScreenDataSetGetProposals, _varLcGetUploadType, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
