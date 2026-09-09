using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_CancelReason")]
public string inParami_CancelReason;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_CancelReason = inParami_CancelReason == null ? "" : inParami_CancelReason;
return result;
}

}
