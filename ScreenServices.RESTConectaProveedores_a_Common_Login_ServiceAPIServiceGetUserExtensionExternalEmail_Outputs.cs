using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_ExternalEmail")]
public string outParamo_ExternalEmail;
[JsonProperty("o_RegionToBeAssigned")]
public string outParamo_RegionToBeAssigned;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_ExternalEmail, string outParamo_RegionToBeAssigned) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Outputs result = new RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_ExternalEmail = outParamo_ExternalEmail;
result.outParamo_RegionToBeAssigned = outParamo_RegionToBeAssigned;
return result;
}


    

    
}
