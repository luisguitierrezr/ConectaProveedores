using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Model ToModel() {ConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Model result = new ConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Model();
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
