using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_EntraRoleName")]
public string outParamo_EntraRoleName;


    public static RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_EntraRoleName) {RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Outputs result = new RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_EntraRoleName = outParamo_EntraRoleName;
return result;
}


    

    
}
