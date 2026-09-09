using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
