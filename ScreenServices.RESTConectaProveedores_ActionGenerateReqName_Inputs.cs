using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ActionGenerateReqName_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_RegionId")]
public long? inParami_RegionId;


    public static RESTConectaProveedores_ActionGenerateReqName_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_ActionGenerateReqName_Inputs result = inputParameters.ToObject<RESTConectaProveedores_ActionGenerateReqName_Inputs>(settings);
return result;
}


    public ConectaProveedores_ActionGenerateReqName_Model ToModel() {ConectaProveedores_ActionGenerateReqName_Model result = new ConectaProveedores_ActionGenerateReqName_Model();
result.inParami_RegionId = inParami_RegionId == null ? 0L : inParami_RegionId.Value;
return result;
}

}
