using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_FolioApprovalLevelId")]
public long? inParami_FolioApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId == null ? 0L : inParami_FolioApprovalLevelId.Value;
result.inParami_IsApprove = inParami_IsApprove == null ? false : inParami_IsApprove.Value;
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
