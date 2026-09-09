using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsShowAssignFirstApproverPopup_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsShow")]
public bool? outParamIsShow;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsShowAssignFirstApproverPopup_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsShow) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsShowAssignFirstApproverPopup_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsShowAssignFirstApproverPopup_Outputs();
conf.IncludeBinariesURL = false;
result.outParamIsShow = (bool?) outParamIsShow;
return result;
}


    

    
}
