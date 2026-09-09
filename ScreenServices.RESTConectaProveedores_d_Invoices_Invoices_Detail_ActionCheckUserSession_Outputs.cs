using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_Detail_ActionCheckUserSession_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsValidSession")]
public bool? outParamIsValidSession;


    public static RESTConectaProveedores_d_Invoices_Invoices_Detail_ActionCheckUserSession_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsValidSession) {RESTConectaProveedores_d_Invoices_Invoices_Detail_ActionCheckUserSession_Outputs result = new RESTConectaProveedores_d_Invoices_Invoices_Detail_ActionCheckUserSession_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamIsValidSession
result.outParamIsValidSession = (bool?) false;
return result;
}


    

    
}
