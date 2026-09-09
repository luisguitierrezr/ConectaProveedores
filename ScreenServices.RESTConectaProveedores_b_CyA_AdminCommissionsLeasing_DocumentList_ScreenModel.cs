using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetProposalLines")]
public string varLcl_ColumnJSONVarGetProposalLines;
[JsonProperty("GetProposalLines")]
public RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs varLcGetProposalLines;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "ProposalLine.id DESC" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetProposalLines = variables.varLcl_ColumnJSONVarGetProposalLines == null ? "" : variables.varLcl_ColumnJSONVarGetProposalLines;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Model _varLcGetProposalLines = (variables.varLcGetProposalLines != null) ? RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs.ToModel(variables.varLcGetProposalLines) : null;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel screenModel = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetProposalLines, _varLcGetProposalLines, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
