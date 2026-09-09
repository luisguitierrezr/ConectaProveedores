using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_OrderLogs_ActionExportOrderLog_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OrderMainId")]
public long? inParami_OrderMainId;


    public static RESTConectaProveedores_y_Logs_Wb_OrderLogs_ActionExportOrderLog_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_y_Logs_Wb_OrderLogs_ActionExportOrderLog_Inputs result = inputParameters.ToObject<RESTConectaProveedores_y_Logs_Wb_OrderLogs_ActionExportOrderLog_Inputs>(settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_OrderLogs_ActionExportOrderLog_Model ToModel() {ConectaProveedores_y_Logs_Wb_OrderLogs_ActionExportOrderLog_Model result = new ConectaProveedores_y_Logs_Wb_OrderLogs_ActionExportOrderLog_Model();
result.inParami_OrderMainId = inParami_OrderMainId == null ? 0L : inParami_OrderMainId.Value;
return result;
}

}
