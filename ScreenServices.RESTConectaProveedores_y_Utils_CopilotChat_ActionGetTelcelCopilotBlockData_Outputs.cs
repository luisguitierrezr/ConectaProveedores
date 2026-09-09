using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_CopilotChat_ActionGetTelcelCopilotBlockData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Name")]
public string outParamName;
[JsonProperty("Email")]
public string outParamEmail;
[JsonProperty("URL")]
public string outParamURL;
[JsonProperty("Roles")]
public string outParamRoles;
[JsonProperty("Secret")]
public string outParamSecret;


    public static RESTConectaProveedores_y_Utils_CopilotChat_ActionGetTelcelCopilotBlockData_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamName, string outParamEmail, string outParamURL, string outParamRoles, string outParamSecret) {RESTConectaProveedores_y_Utils_CopilotChat_ActionGetTelcelCopilotBlockData_Outputs result = new RESTConectaProveedores_y_Utils_CopilotChat_ActionGetTelcelCopilotBlockData_Outputs();
conf.IncludeBinariesURL = false;
result.outParamName = outParamName;
result.outParamEmail = outParamEmail;
result.outParamURL = outParamURL;
result.outParamRoles = outParamRoles;
result.outParamSecret = outParamSecret;
return result;
}


    

    
}
