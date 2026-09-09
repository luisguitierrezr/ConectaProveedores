using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProposalById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d> ScreenDataSetGetProposalById;
[JsonProperty("GetProposalLinesByProposalId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cbff39127609a0f830b2d34948d1c019> ScreenDataSetGetProposalLinesByProposalId;
[JsonProperty("GetFileImportLogsByFileId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_30fde7bd8b6b69ef09faede048f7361d> ScreenDataSetGetFileImportLogsByFileId;
[JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("DateTextFormatted")]
public string varLcDateTextFormatted;
[JsonProperty("l_RefeshSideBar")]
public String varLcl_RefeshSideBar;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetProposalDetailError")]
public string varLcl_ColumnJSONVarGetProposalDetailError;
[JsonProperty("l_CountAfterFetchGetProposalDetailError")]
public int? varLcl_CountAfterFetchGetProposalDetailError;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel ToModel() {long inParami_ProposalId = variables.inParami_ProposalId == null ? 0L : variables.inParami_ProposalId.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcDateTextFormatted = variables.varLcDateTextFormatted == null ? "" : variables.varLcDateTextFormatted;
DateTime varLcl_RefeshSideBar = variables.varLcl_RefeshSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetProposalDetailError = variables.varLcl_ColumnJSONVarGetProposalDetailError == null ? "" : variables.varLcl_ColumnJSONVarGetProposalDetailError;
int varLcl_CountAfterFetchGetProposalDetailError = variables.varLcl_CountAfterFetchGetProposalDetailError == null ? 0 : variables.varLcl_CountAfterFetchGetProposalDetailError.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> _ScreenDataSetGetProposalById = (variables.ScreenDataSetGetProposalById != null) ? variables.ScreenDataSetGetProposalById.FromJS((array) => {
return RL_f4591be205d3928a9fe22daf19d979cd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d.ToStructure);
}
) : null;
AggregateRecord<RL_5a265eacaa987aecd8ded8a7c13b9b2d> _ScreenDataSetGetProposalLinesByProposalId = (variables.ScreenDataSetGetProposalLinesByProposalId != null) ? variables.ScreenDataSetGetProposalLinesByProposalId.FromJS((array) => {
return RL_5a265eacaa987aecd8ded8a7c13b9b2d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cbff39127609a0f830b2d34948d1c019.ToStructure);
}
) : null;
AggregateRecord<RL_0a29febe5e5b3c22dc11930cd3be5c9e> _ScreenDataSetGetFileImportLogsByFileId = (variables.ScreenDataSetGetFileImportLogsByFileId != null) ? variables.ScreenDataSetGetFileImportLogsByFileId.FromJS((array) => {
return RL_0a29febe5e5b3c22dc11930cd3be5c9e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_30fde7bd8b6b69ef09faede048f7361d.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel screenModel = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel(inParami_ProposalId, varLcTableSort, varLcStartIndex, varLcDateTextFormatted, varLcl_RefeshSideBar, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetProposalDetailError, varLcl_CountAfterFetchGetProposalDetailError, varLcl_Loading, _ScreenDataSetGetProposalById, _ScreenDataSetGetProposalLinesByProposalId, _ScreenDataSetGetFileImportLogsByFileId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
