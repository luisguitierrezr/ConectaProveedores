using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Requisition")]
public ssConectaProveedores.RestRecords.RESTRC_44742d4360afdf16ff97b37b2eff1760 inParami_Requisition;
[JsonProperty("i_IsFinishCapture")]
public bool? inParami_IsFinishCapture;
[JsonProperty("i_IsNewVersion")]
public bool? inParami_IsNewVersion;
[JsonProperty("i_CreateForUser")]
public string inParami_CreateForUser;
[JsonProperty("ApprovalProcessId")]
public long? inParamApprovalProcessId;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Model ToModel() {ConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Model result = new ConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Model();
result.inParami_Requisition = ssConectaProveedores.RestRecords.RESTRC_44742d4360afdf16ff97b37b2eff1760.ToStructure(inParami_Requisition);
result.inParami_IsFinishCapture = inParami_IsFinishCapture == null ? false : inParami_IsFinishCapture.Value;
result.inParami_IsNewVersion = inParami_IsNewVersion == null ? false : inParami_IsNewVersion.Value;
result.inParami_CreateForUser = inParami_CreateForUser == null ? "" : inParami_CreateForUser;
result.inParamApprovalProcessId = inParamApprovalProcessId == null ? 0L : inParamApprovalProcessId.Value;
return result;
}

}
