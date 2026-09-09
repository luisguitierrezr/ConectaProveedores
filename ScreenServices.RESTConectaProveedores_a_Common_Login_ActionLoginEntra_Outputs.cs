using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Message")]
public string outParamo_Message;
[JsonProperty("o_IsSuccess")]
public bool? outParamo_IsSuccess;


    public static RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_Message, bool outParamo_IsSuccess) {RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Outputs result = new RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_Message = outParamo_Message;
result.outParamo_IsSuccess = (bool?) outParamo_IsSuccess;
return result;
}


    

    
}
