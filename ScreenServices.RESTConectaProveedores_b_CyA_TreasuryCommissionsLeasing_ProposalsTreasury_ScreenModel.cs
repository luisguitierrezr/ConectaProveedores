using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProposalStatus")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2> ScreenDataSetGetProposalStatus;
[JsonProperty("GetProposals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_bb9053a6ea6eec7bc3ffbc5b5de7b452> ScreenDataSetGetProposals;
[JsonProperty("GetProposalsSum")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_24005b43e3f3ca8801049bcbbd68ea10> ScreenDataSetGetProposalsSum;
[JsonProperty("GetOperators")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965> ScreenDataSetGetOperators;
[JsonProperty("GetBanks")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a> ScreenDataSetGetBanks;
[JsonProperty("GetProposalsAssign")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_8129c2d9846bc83a20ef6f3e7b60c809> ScreenDataSetGetProposalsAssign;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("l_ShowFilters")]
public bool? varLcl_ShowFilters;
[JsonProperty("l_RefeshSideBar")]
public String varLcl_RefeshSideBar;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetProposalsTreasury")]
public string varLcl_ColumnJSONVarGetProposalsTreasury;
[JsonProperty("l_CountAfterFetchGetProposalsTreasury")]
public int? varLcl_CountAfterFetchGetProposalsTreasury;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_proposalId")]
public long? varLcl_proposalId;
[JsonProperty("l_AmountFromText")]
public string varLcl_AmountFromText;
[JsonProperty("l_AmountToText")]
public string varLcl_AmountToText;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel ToModel() {string varLcTableSort = variables.varLcTableSort == null ? "FileExtended.id desc" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
bool varLcl_ShowFilters = variables.varLcl_ShowFilters == null ? false : variables.varLcl_ShowFilters.Value;
DateTime varLcl_RefeshSideBar = variables.varLcl_RefeshSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetProposalsTreasury = variables.varLcl_ColumnJSONVarGetProposalsTreasury == null ? "" : variables.varLcl_ColumnJSONVarGetProposalsTreasury;
int varLcl_CountAfterFetchGetProposalsTreasury = variables.varLcl_CountAfterFetchGetProposalsTreasury == null ? 0 : variables.varLcl_CountAfterFetchGetProposalsTreasury.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
long varLcl_proposalId = variables.varLcl_proposalId == null ? 0L : variables.varLcl_proposalId.Value;
string varLcl_AmountFromText = variables.varLcl_AmountFromText == null ? "" : variables.varLcl_AmountFromText;
string varLcl_AmountToText = variables.varLcl_AmountToText == null ? "" : variables.varLcl_AmountToText;
AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> _ScreenDataSetGetProposalStatus = (variables.ScreenDataSetGetProposalStatus != null) ? variables.ScreenDataSetGetProposalStatus.FromJS((array) => {
return RL_edf26e482e095588ed6d5cbd5313bc7f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2.ToStructure);
}
) : null;
AggregateRecord<RL_f8f660cba6c51b3d6579cc8426c3f972> _ScreenDataSetGetProposals = (variables.ScreenDataSetGetProposals != null) ? variables.ScreenDataSetGetProposals.FromJS((array) => {
return RL_f8f660cba6c51b3d6579cc8426c3f972.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_bb9053a6ea6eec7bc3ffbc5b5de7b452.ToStructure);
}
) : null;
AggregateRecord<RL_c43fa070956fae30a46b9d776792d6cc> _ScreenDataSetGetProposalsSum = (variables.ScreenDataSetGetProposalsSum != null) ? variables.ScreenDataSetGetProposalsSum.FromJS((array) => {
return RL_c43fa070956fae30a46b9d776792d6cc.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_24005b43e3f3ca8801049bcbbd68ea10.ToStructure);
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
AggregateRecord<RL_999b467c81e0dee8574a63e95d64104c> _ScreenDataSetGetProposalsAssign = (variables.ScreenDataSetGetProposalsAssign != null) ? variables.ScreenDataSetGetProposalsAssign.FromJS((array) => {
return RL_999b467c81e0dee8574a63e95d64104c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_8129c2d9846bc83a20ef6f3e7b60c809.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel screenModel = new ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel(varLcTableSort, varLcStartIndex, varLcl_ShowFilters, varLcl_RefeshSideBar, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetProposalsTreasury, varLcl_CountAfterFetchGetProposalsTreasury, varLcl_Loading, varLcl_proposalId, varLcl_AmountFromText, varLcl_AmountToText, _ScreenDataSetGetProposalStatus, _ScreenDataSetGetProposals, _ScreenDataSetGetProposalsSum, _ScreenDataSetGetOperators, _ScreenDataSetGetBanks, _ScreenDataSetGetProposalsAssign, _ScreenDataSetGetRegions, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
