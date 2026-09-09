using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPICheckLastPassword_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsCorrect")]
public bool? outParamo_IsCorrect;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPICheckLastPassword_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsCorrect) {RESTConectaProveedores_a_Common_Login_ServiceAPICheckLastPassword_Outputs result = new RESTConectaProveedores_a_Common_Login_ServiceAPICheckLastPassword_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_IsCorrect = (bool?) outParamo_IsCorrect;
return result;
}


    

    
}
