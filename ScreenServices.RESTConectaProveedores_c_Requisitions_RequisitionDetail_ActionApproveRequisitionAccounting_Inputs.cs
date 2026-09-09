using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Requisition")]
public ssConectaProveedores.RestRecords.RESTRC_cc86cc41f7a6d52842bfa86c15f13d61 inParami_Requisition;
[JsonProperty("i_RequisitionApprovalLevelId")]
public long? inParami_RequisitionApprovalLevelId;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Model ToModel() {ConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Model result = new ConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Model();
result.inParami_Requisition = ssConectaProveedores.RestRecords.RESTRC_cc86cc41f7a6d52842bfa86c15f13d61.ToStructure(inParami_Requisition);
result.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId == null ? 0L : inParami_RequisitionApprovalLevelId.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
