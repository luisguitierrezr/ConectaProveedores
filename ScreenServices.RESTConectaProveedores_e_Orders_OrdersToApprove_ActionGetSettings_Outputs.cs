using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersToApprove_ActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("OutSettingsText")]
public string outParamOutSettingsText;


    public static RESTConectaProveedores_e_Orders_OrdersToApprove_ActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamOutSettingsText) {RESTConectaProveedores_e_Orders_OrdersToApprove_ActionGetSettings_Outputs result = new RESTConectaProveedores_e_Orders_OrdersToApprove_ActionGetSettings_Outputs();
conf.IncludeBinariesURL = false;
result.outParamOutSettingsText = outParamOutSettingsText;
return result;
}


    

    
}
