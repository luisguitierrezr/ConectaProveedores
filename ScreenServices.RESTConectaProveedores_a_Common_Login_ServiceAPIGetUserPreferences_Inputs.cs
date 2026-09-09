using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_UserId")]
public string inParami_UserId;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Model ToModel() {ConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Model result = new ConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Model();
result.inParami_UserId = inParami_UserId == null ? "" : inParami_UserId;
return result;
}

}
