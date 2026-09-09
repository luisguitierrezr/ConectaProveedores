using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPIServiceUserManagementLogsCreate_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Id")]
public long? outParamId;


    public static RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPIServiceUserManagementLogsCreate_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamId) {RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPIServiceUserManagementLogsCreate_Outputs result = new RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPIServiceUserManagementLogsCreate_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamId
result.outParamId = (long?) 0L;
return result;
}


    

    
}
