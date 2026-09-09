using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsValid")]
public bool? outParamIsValid;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsValid) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Outputs result = new RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Outputs();
conf.IncludeBinariesURL = false;
result.outParamIsValid = (bool?) outParamIsValid;
return result;
}


    

    
}
