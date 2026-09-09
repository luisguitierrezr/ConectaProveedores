using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ErrorMessage")]
public string outParamErrorMessage;


    public static RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMessage) {RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Outputs result = new RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMessage = outParamErrorMessage;
return result;
}


    

    
}
