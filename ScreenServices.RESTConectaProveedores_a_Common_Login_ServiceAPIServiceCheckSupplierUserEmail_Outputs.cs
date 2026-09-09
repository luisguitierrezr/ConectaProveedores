using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_NotExists")]
public bool? outParamo_NotExists;
[JsonProperty("o_NotActive")]
public bool? outParamo_NotActive;
[JsonProperty("o_IsDeleted")]
public bool? outParamo_IsDeleted;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_NotExists, bool outParamo_NotActive, bool outParamo_IsDeleted) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Outputs result = new RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_NotExists = (bool?) outParamo_NotExists;
result.outParamo_NotActive = (bool?) outParamo_NotActive;
result.outParamo_IsDeleted = (bool?) outParamo_IsDeleted;
return result;
}


    

    
}
