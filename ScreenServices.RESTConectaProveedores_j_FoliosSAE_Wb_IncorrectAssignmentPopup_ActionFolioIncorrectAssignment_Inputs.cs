using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_ActionFolioIncorrectAssignment_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_FolioApprovalLevelId")]
public long? inParami_FolioApprovalLevelId;
[JsonProperty("i_Motive")]
public string inParami_Motive;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_ActionFolioIncorrectAssignment_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_ActionFolioIncorrectAssignment_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_ActionFolioIncorrectAssignment_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_ActionFolioIncorrectAssignment_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_ActionFolioIncorrectAssignment_Model result = new ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_ActionFolioIncorrectAssignment_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId == null ? 0L : inParami_FolioApprovalLevelId.Value;
result.inParami_Motive = inParami_Motive == null ? "" : inParami_Motive;
return result;
}

}
