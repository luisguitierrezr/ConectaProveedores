using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ActionFolioApproval_Construction_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ActionFolioApproval_Construction_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ActionFolioApproval_Construction_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ActionFolioApproval_Construction_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ActionFolioApproval_Construction_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ActionFolioApproval_Construction_Model result = new ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ActionFolioApproval_Construction_Model();
result.inParamFolioId = inParamFolioId == null ? 0L : inParamFolioId.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
