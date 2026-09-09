using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProposalById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d> ScreenDataSetGetProposalById;
[JsonProperty("GetProposalStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2> ScreenDataSetGetProposalStatuses;
[JsonProperty("GetProposalApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f> ScreenDataSetGetProposalApprovalLevels;
[JsonProperty("GetProposalLinesByProposalId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56> ScreenDataSetGetProposalLinesByProposalId;
[JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_DateTextFormatted")]
public string varLcl_DateTextFormatted;
[JsonProperty("l_RefeshSideBar")]
public String varLcl_RefeshSideBar;
[JsonProperty("l_ShowCancelPopup")]
public bool? varLcl_ShowCancelPopup;
[JsonProperty("l_ProposalApprovalLevelId")]
public long? varLcl_ProposalApprovalLevelId;
[JsonProperty("l_ShowUnpaidDetailPopup")]
public bool? varLcl_ShowUnpaidDetailPopup;
[JsonProperty("l_ProposalLineId")]
public long? varLcl_ProposalLineId;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetProposalLinesB")]
public string varLcl_ColumnJSONVarGetProposalLinesB;
[JsonProperty("l_CountAfterFetchGetProposalLinesB")]
public int? varLcl_CountAfterFetchGetProposalLinesB;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_ListForApprovalLevelDropdown")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_786401d4272d8830c4a71cf084346ee6> varLcl_ListForApprovalLevelDropdown;
[JsonProperty("l_RefeshDocumentSideBar")]
public String varLcl_RefeshDocumentSideBar;
[JsonProperty("l_SelectdLogDocumentId")]
public long? varLcl_SelectdLogDocumentId;
[JsonProperty("l_SelectdLogDocumentNumber")]
public string varLcl_SelectdLogDocumentNumber;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel ToModel() {long inParami_ProposalId = variables.inParami_ProposalId == null ? 0L : variables.inParami_ProposalId.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_DateTextFormatted = variables.varLcl_DateTextFormatted == null ? "" : variables.varLcl_DateTextFormatted;
DateTime varLcl_RefeshSideBar = variables.varLcl_RefeshSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_ShowCancelPopup = variables.varLcl_ShowCancelPopup == null ? false : variables.varLcl_ShowCancelPopup.Value;
long varLcl_ProposalApprovalLevelId = variables.varLcl_ProposalApprovalLevelId == null ? 0L : variables.varLcl_ProposalApprovalLevelId.Value;
bool varLcl_ShowUnpaidDetailPopup = variables.varLcl_ShowUnpaidDetailPopup == null ? false : variables.varLcl_ShowUnpaidDetailPopup.Value;
long varLcl_ProposalLineId = variables.varLcl_ProposalLineId == null ? 0L : variables.varLcl_ProposalLineId.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetProposalLinesB = variables.varLcl_ColumnJSONVarGetProposalLinesB == null ? "" : variables.varLcl_ColumnJSONVarGetProposalLinesB;
int varLcl_CountAfterFetchGetProposalLinesB = variables.varLcl_CountAfterFetchGetProposalLinesB == null ? 0 : variables.varLcl_CountAfterFetchGetProposalLinesB.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
RL_1de096a2cd5bc9c1d57a6496eba081e9 varLcl_ListForApprovalLevelDropdown = RL_1de096a2cd5bc9c1d57a6496eba081e9.FromRestList(variables.varLcl_ListForApprovalLevelDropdown, ssConectaProveedores.RestRecords.RESTRC_786401d4272d8830c4a71cf084346ee6.ToStructure);
DateTime varLcl_RefeshDocumentSideBar = variables.varLcl_RefeshDocumentSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshDocumentSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
long varLcl_SelectdLogDocumentId = variables.varLcl_SelectdLogDocumentId == null ? 0L : variables.varLcl_SelectdLogDocumentId.Value;
string varLcl_SelectdLogDocumentNumber = variables.varLcl_SelectdLogDocumentNumber == null ? "" : variables.varLcl_SelectdLogDocumentNumber;
AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> _ScreenDataSetGetProposalById = (variables.ScreenDataSetGetProposalById != null) ? variables.ScreenDataSetGetProposalById.FromJS((array) => {
return RL_f4591be205d3928a9fe22daf19d979cd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d.ToStructure);
}
) : null;
AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> _ScreenDataSetGetProposalStatuses = (variables.ScreenDataSetGetProposalStatuses != null) ? variables.ScreenDataSetGetProposalStatuses.FromJS((array) => {
return RL_edf26e482e095588ed6d5cbd5313bc7f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2.ToStructure);
}
) : null;
AggregateRecord<RL_5c3f0f159a56c705e2e8b813bae3e604> _ScreenDataSetGetProposalApprovalLevels = (variables.ScreenDataSetGetProposalApprovalLevels != null) ? variables.ScreenDataSetGetProposalApprovalLevels.FromJS((array) => {
return RL_5c3f0f159a56c705e2e8b813bae3e604.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f.ToStructure);
}
) : null;
AggregateRecord<RL_fdf11fa7a74406ff2a80f555d1ce34a5> _ScreenDataSetGetProposalLinesByProposalId = (variables.ScreenDataSetGetProposalLinesByProposalId != null) ? variables.ScreenDataSetGetProposalLinesByProposalId.FromJS((array) => {
return RL_fdf11fa7a74406ff2a80f555d1ce34a5.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel screenModel = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel(inParami_ProposalId, varLcl_TableSort, varLcl_StartIndex, varLcl_DateTextFormatted, varLcl_RefeshSideBar, varLcl_ShowCancelPopup, varLcl_ProposalApprovalLevelId, varLcl_ShowUnpaidDetailPopup, varLcl_ProposalLineId, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetProposalLinesB, varLcl_CountAfterFetchGetProposalLinesB, varLcl_Loading, varLcl_ListForApprovalLevelDropdown, varLcl_RefeshDocumentSideBar, varLcl_SelectdLogDocumentId, varLcl_SelectdLogDocumentNumber, _ScreenDataSetGetProposalById, _ScreenDataSetGetProposalStatuses, _ScreenDataSetGetProposalApprovalLevels, _ScreenDataSetGetProposalLinesByProposalId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
