using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_ActionFolioEstablishFlow_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_ApprovalProcessId")]
public long? inParami_ApprovalProcessId;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_ActionFolioEstablishFlow_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_ActionFolioEstablishFlow_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_ActionFolioEstablishFlow_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_ActionFolioEstablishFlow_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_ActionFolioEstablishFlow_Model result = new ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_ActionFolioEstablishFlow_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_ApprovalProcessId = inParami_ApprovalProcessId == null ? 0L : inParami_ApprovalProcessId.Value;
return result;
}

}
