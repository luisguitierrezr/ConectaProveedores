using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;


    public static RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Inputs result = inputParameters.ToObject<RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Inputs>(settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Model ToModel() {ConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Model result = new ConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
return result;
}

}
