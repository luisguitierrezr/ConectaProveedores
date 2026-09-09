using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ActionRequisitionCancel_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("i_RequisitionApprovalLevelId")]
public long? inParami_RequisitionApprovalLevelId;
[JsonProperty("i_CancelReason")]
public string inParami_CancelReason;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ActionRequisitionCancel_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ActionRequisitionCancel_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ActionRequisitionCancel_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ActionRequisitionCancel_Model ToModel() {ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ActionRequisitionCancel_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_ActionRequisitionCancel_Model();
result.inParami_RequisitionId = inParami_RequisitionId == null ? 0L : inParami_RequisitionId.Value;
result.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId == null ? 0L : inParami_RequisitionApprovalLevelId.Value;
result.inParami_CancelReason = inParami_CancelReason == null ? "" : inParami_CancelReason;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
