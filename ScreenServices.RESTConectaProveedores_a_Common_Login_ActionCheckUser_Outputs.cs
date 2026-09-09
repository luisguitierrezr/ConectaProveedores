using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ActionCheckUser_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Role")]
public string outParamo_Role;
[JsonProperty("o_Success")]
public bool? outParamo_Success;
[JsonProperty("o_UserId")]
public string outParamo_UserId;


    public static RESTConectaProveedores_a_Common_Login_ActionCheckUser_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_Role, bool outParamo_Success, string outParamo_UserId) {RESTConectaProveedores_a_Common_Login_ActionCheckUser_Outputs result = new RESTConectaProveedores_a_Common_Login_ActionCheckUser_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamo_Role
result.outParamo_Role = "";
result.outParamo_Success = (bool?) outParamo_Success;
result.outParamo_UserId = outParamo_UserId;
return result;
}


    

    
}
