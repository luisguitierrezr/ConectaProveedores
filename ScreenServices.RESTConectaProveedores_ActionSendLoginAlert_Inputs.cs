using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ActionSendLoginAlert_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Username")]
public string inParamUsername;
[JsonProperty("Environment")]
public string inParamEnvironment;


    public static RESTConectaProveedores_ActionSendLoginAlert_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_ActionSendLoginAlert_Inputs result = inputParameters.ToObject<RESTConectaProveedores_ActionSendLoginAlert_Inputs>(settings);
return result;
}


    public ConectaProveedores_ActionSendLoginAlert_Model ToModel() {ConectaProveedores_ActionSendLoginAlert_Model result = new ConectaProveedores_ActionSendLoginAlert_Model();
result.inParamUsername = inParamUsername == null ? "" : inParamUsername;
result.inParamEnvironment = inParamEnvironment == null ? "" : inParamEnvironment;
return result;
}

}
