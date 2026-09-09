using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Email")]
public string inParamEmail;


    public static RESTConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Model ToModel() {ConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Model result = new ConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Model();
result.inParamEmail = inParamEmail == null ? "" : inParamEmail;
return result;
}

}
