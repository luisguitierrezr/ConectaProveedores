using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ActionFolioReassign_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_AssignUserId")]
public string inParami_AssignUserId;
[JsonProperty("i_FolioApprovalLevelId")]
public long? inParami_FolioApprovalLevelId;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ActionFolioReassign_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ActionFolioReassign_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ActionFolioReassign_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ActionFolioReassign_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ActionFolioReassign_Model result = new ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_ActionFolioReassign_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_AssignUserId = inParami_AssignUserId == null ? "" : inParami_AssignUserId;
result.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId == null ? 0L : inParami_FolioApprovalLevelId.Value;
return result;
}

}
