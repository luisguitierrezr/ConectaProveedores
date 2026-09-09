using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_UserEmail")]
public string inParami_UserEmail;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Model ToModel() {ConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Model result = new ConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Model();
result.inParami_UserEmail = inParami_UserEmail == null ? "" : inParami_UserEmail;
return result;
}

}
