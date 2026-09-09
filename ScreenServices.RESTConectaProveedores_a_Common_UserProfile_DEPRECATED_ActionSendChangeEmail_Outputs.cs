using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionSendChangeEmail_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Success")]
public bool? outParamSuccess;


    public static RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionSendChangeEmail_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamSuccess) {RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionSendChangeEmail_Outputs result = new RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionSendChangeEmail_Outputs();
conf.IncludeBinariesURL = false;
result.outParamSuccess = (bool?) outParamSuccess;
return result;
}


    

    
}
