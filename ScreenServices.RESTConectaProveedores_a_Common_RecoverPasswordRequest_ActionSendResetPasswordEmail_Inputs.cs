using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ApplicationName")]
public string inParamApplicationName;
[JsonProperty("CustomerEmail")]
public string inParamCustomerEmail;


    public static RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Model ToModel() {ConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Model result = new ConectaProveedores_a_Common_RecoverPasswordRequest_ActionSendResetPasswordEmail_Model();
result.inParamApplicationName = inParamApplicationName == null ? "" : inParamApplicationName;
result.inParamCustomerEmail = inParamCustomerEmail == null ? "" : inParamCustomerEmail;
return result;
}

}
