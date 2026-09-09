using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_AssignUserId")]
public string inParami_AssignUserId;
[JsonProperty("i_AssignApprovalProcessId")]
public long? inParami_AssignApprovalProcessId;
[JsonProperty("i_Comment")]
public string inParami_Comment;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Model result = new ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_AssignUserId = inParami_AssignUserId == null ? "" : inParami_AssignUserId;
result.inParami_AssignApprovalProcessId = inParami_AssignApprovalProcessId == null ? 0L : inParami_AssignApprovalProcessId.Value;
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
return result;
}

}
