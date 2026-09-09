using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ManualId")]
public long? inParami_ManualId;


    public static RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Inputs result = inputParameters.ToObject<RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Inputs>(settings);
return result;
}


    public ConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Model ToModel() {ConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Model result = new ConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Model();
result.inParami_ManualId = inParami_ManualId == null ? 0L : inParami_ManualId.Value;
return result;
}

}
