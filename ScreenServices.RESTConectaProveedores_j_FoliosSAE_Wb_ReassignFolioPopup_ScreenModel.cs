using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_FolioApprovalLevelId")]
public long? inParami_FolioApprovalLevelId;
[JsonProperty("l_IsExecuting")]
public bool? varLcl_IsExecuting;
[JsonProperty("l_AssignUserId")]
public string varLcl_AssignUserId;
[JsonProperty("GetUsersList")]
public RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs varLcGetUsersList;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
long inParami_FolioApprovalLevelId = variables.inParami_FolioApprovalLevelId == null ? 0L : variables.inParami_FolioApprovalLevelId.Value;
bool varLcl_IsExecuting = variables.varLcl_IsExecuting == null ? false : variables.varLcl_IsExecuting.Value;
string varLcl_AssignUserId = variables.varLcl_AssignUserId == null ? "" : variables.varLcl_AssignUserId;
ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Model _varLcGetUsersList = (variables.varLcGetUsersList != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs.ToModel(variables.varLcGetUsersList) : null;
ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ScreenModel(inParami_FolioId, inParami_FolioApprovalLevelId, varLcl_IsExecuting, varLcl_AssignUserId, _varLcGetUsersList, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
