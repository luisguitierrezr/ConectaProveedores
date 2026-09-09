using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_ActionFolioApproveBulk_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_6041e483640e901fd2a96b2a9af2a903> inParami_FolioList;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_ActionFolioApproveBulk_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_ActionFolioApproveBulk_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_ActionFolioApproveBulk_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_ActionFolioApproveBulk_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_ActionFolioApproveBulk_Model result = new ConectaProveedores_j_FoliosSAE_Wb_PopupFormSAEBulkApprove_ActionFolioApproveBulk_Model();
result.inParami_FolioList = RL_79ea8920a52237936a05ba9320d22c38.FromRestList(inParami_FolioList, ssConectaProveedores.RestRecords.RESTRC_6041e483640e901fd2a96b2a9af2a903.ToStructure);
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
