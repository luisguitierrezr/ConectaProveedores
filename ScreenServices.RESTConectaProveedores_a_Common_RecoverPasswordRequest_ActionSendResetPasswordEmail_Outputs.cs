using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Success")]
public bool? outParamSuccess;


    public static RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamSuccess) {RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs result = new RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Outputs();
conf.IncludeBinariesURL = false;
result.outParamSuccess = (bool?) outParamSuccess;
return result;
}


    

    
}
