using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;


    public static RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Model ToModel() {ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Model result = new ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
return result;
}

}
