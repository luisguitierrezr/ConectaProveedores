using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Email")]
public string inParami_Email;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Model ToModel() {ConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Model result = new ConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Model();
result.inParami_Email = inParami_Email == null ? "" : inParami_Email;
return result;
}

}
