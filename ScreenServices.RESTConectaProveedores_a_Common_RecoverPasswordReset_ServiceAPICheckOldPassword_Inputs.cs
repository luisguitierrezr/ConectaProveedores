using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Password")]
public string inParami_Password;
[JsonProperty("i_Email")]
public string inParami_Email;


    public static RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Model ToModel() {ConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Model result = new ConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Model();
result.inParami_Password = inParami_Password == null ? "" : inParami_Password;
result.inParami_Email = inParami_Email == null ? "" : inParami_Email;
return result;
}

}
