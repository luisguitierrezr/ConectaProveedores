using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserId")]
public string inParamUserId;
[JsonProperty("IsDonation")]
public bool? inParamIsDonation;
[JsonProperty("ProcessTypeCode")]
public string inParamProcessTypeCode;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Model ToModel() {ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Model result = new ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Model();
result.inParamUserId = inParamUserId == null ? "" : inParamUserId;
result.inParamIsDonation = inParamIsDonation == null ? false : inParamIsDonation.Value;
result.inParamProcessTypeCode = inParamProcessTypeCode == null ? "" : inParamProcessTypeCode;
return result;
}

}
