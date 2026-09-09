using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_ActionApprovModifReq_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("i_RequisitionApprovalLevelId")]
public long? inParami_RequisitionApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_ActionApprovModifReq_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_ActionApprovModifReq_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_ActionApprovModifReq_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_ActionApprovModifReq_Model ToModel() {ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_ActionApprovModifReq_Model result = new ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_ActionApprovModifReq_Model();
result.inParami_RequisitionId = inParami_RequisitionId == null ? 0L : inParami_RequisitionId.Value;
result.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId == null ? 0L : inParami_RequisitionApprovalLevelId.Value;
result.inParami_IsApprove = inParami_IsApprove == null ? false : inParami_IsApprove.Value;
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
