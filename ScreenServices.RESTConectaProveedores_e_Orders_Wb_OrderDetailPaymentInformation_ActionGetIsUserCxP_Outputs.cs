using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionGetIsUserCxP_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Value")]
public bool? outParamo_Value;


    public static RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionGetIsUserCxP_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_Value) {RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionGetIsUserCxP_Outputs result = new RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionGetIsUserCxP_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_Value = (bool?) outParamo_Value;
return result;
}


    

    
}
