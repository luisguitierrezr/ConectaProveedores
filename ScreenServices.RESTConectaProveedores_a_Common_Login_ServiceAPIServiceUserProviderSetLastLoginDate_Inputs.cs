using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_userId")]
public string inParami_userId;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Model ToModel() {ConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Model result = new ConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Model();
result.inParami_userId = inParami_userId == null ? "" : inParami_userId;
return result;
}

}
