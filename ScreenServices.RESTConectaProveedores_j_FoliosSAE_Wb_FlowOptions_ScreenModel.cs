using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_ApplicantId")]
public long? inParami_ApplicantId;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_MandatoryError")]
public bool? inParami_MandatoryError;
[JsonProperty("l_ApprovalProcessId")]
public long? varLcl_ApprovalProcessId;
[JsonProperty("l_IsMandatoryError")]
public bool? varLcl_IsMandatoryError;
[JsonProperty("GetApprovalProcesses")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs varLcGetApprovalProcesses;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel ToModel() {long inParami_ApplicantId = variables.inParami_ApplicantId == null ? 0L : variables.inParami_ApplicantId.Value;
long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
bool inParami_MandatoryError = variables.inParami_MandatoryError == null ? false : variables.inParami_MandatoryError.Value;
long varLcl_ApprovalProcessId = variables.varLcl_ApprovalProcessId == null ? 0L : variables.varLcl_ApprovalProcessId.Value;
bool varLcl_IsMandatoryError = variables.varLcl_IsMandatoryError == null ? false : variables.varLcl_IsMandatoryError.Value;
ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Model _varLcGetApprovalProcesses = (variables.varLcGetApprovalProcesses != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs.ToModel(variables.varLcGetApprovalProcesses) : null;
ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel(inParami_ApplicantId, inParami_FolioId, inParami_MandatoryError, varLcl_ApprovalProcessId, varLcl_IsMandatoryError, _varLcGetApprovalProcesses, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
