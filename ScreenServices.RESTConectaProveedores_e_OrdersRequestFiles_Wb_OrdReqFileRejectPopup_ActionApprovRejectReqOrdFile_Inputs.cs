using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_ActionApprovRejectReqOrdFile_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OrderRequestFileApprovalLevelId")]
public long? inParami_OrderRequestFileApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Reason")]
public string inParami_Reason;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_ActionApprovRejectReqOrdFile_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_ActionApprovRejectReqOrdFile_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_ActionApprovRejectReqOrdFile_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_ActionApprovRejectReqOrdFile_Model ToModel() {ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_ActionApprovRejectReqOrdFile_Model result = new ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_ActionApprovRejectReqOrdFile_Model();
result.inParami_OrderRequestFileApprovalLevelId = inParami_OrderRequestFileApprovalLevelId == null ? 0L : inParami_OrderRequestFileApprovalLevelId.Value;
result.inParami_IsApprove = inParami_IsApprove == null ? false : inParami_IsApprove.Value;
result.inParami_Reason = inParami_Reason == null ? "" : inParami_Reason;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
