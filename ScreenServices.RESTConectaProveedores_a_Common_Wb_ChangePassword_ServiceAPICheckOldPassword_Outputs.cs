using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Wb_ChangePassword_ServiceAPICheckOldPassword_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsOld")]
public bool? outParamo_IsOld;


    public static RESTConectaProveedores_a_Common_Wb_ChangePassword_ServiceAPICheckOldPassword_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsOld) {RESTConectaProveedores_a_Common_Wb_ChangePassword_ServiceAPICheckOldPassword_Outputs result = new RESTConectaProveedores_a_Common_Wb_ChangePassword_ServiceAPICheckOldPassword_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_IsOld = (bool?) outParamo_IsOld;
return result;
}


    

    
}
