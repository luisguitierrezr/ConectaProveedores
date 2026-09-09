using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsForSpecialWorkflow")]
public bool? outParamIsForSpecialWorkflow;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsForSpecialWorkflow) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Outputs();
conf.IncludeBinariesURL = false;
result.outParamIsForSpecialWorkflow = (bool?) outParamIsForSpecialWorkflow;
return result;
}


    

    
}
