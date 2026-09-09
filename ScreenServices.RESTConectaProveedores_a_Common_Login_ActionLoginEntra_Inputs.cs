using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_UserEmailTelcel")]
public string inParami_UserEmailTelcel;
[JsonProperty("i_NewRegion")]
public string inParami_NewRegion;


    public static RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ActionLoginEntra_Model ToModel() {ConectaProveedores_a_Common_Login_ActionLoginEntra_Model result = new ConectaProveedores_a_Common_Login_ActionLoginEntra_Model();
result.inParami_UserEmailTelcel = inParami_UserEmailTelcel == null ? "" : inParami_UserEmailTelcel;
result.inParami_NewRegion = inParami_NewRegion == null ? "" : inParami_NewRegion;
return result;
}

}
