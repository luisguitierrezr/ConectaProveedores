using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ActionGetUserRegionId_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_ActionGetUserRegionId_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_ActionGetUserRegionId_Inputs result = inputParameters.ToObject<RESTConectaProveedores_ActionGetUserRegionId_Inputs>(settings);
return result;
}


    public ConectaProveedores_ActionGetUserRegionId_Model ToModel() {ConectaProveedores_ActionGetUserRegionId_Model result = new ConectaProveedores_ActionGetUserRegionId_Model();
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
