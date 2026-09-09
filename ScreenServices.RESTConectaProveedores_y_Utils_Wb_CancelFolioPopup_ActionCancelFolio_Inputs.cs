using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ActionCancelFolio_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Object")]
public ssConectaProveedores.RestRecords.RESTRC_b668eee4846e2937101a51355804499d inParamObject;
[JsonProperty("FolioReject")]
public ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure inParamFolioReject;
[JsonProperty("FolioApprovalLevels_List")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79> inParamFolioApprovalLevels_List;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ActionCancelFolio_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ActionCancelFolio_Inputs result = inputParameters.ToObject<RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ActionCancelFolio_Inputs>(settings);
return result;
}


    public ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ActionCancelFolio_Model ToModel() {ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ActionCancelFolio_Model result = new ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ActionCancelFolio_Model();
result.inParamObject = ssConectaProveedores.RestRecords.RESTRC_b668eee4846e2937101a51355804499d.ToStructure(inParamObject);
result.inParamFolioReject = ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure.ToStructure(inParamFolioReject);
result.inParamFolioApprovalLevels_List = RL_8430333e95ceffc00def96d8abb01f75.FromRestList(inParamFolioApprovalLevels_List, ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79.ToStructure);
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
