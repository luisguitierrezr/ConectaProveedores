using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;


    public static RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Inputs result = inputParameters.ToObject<RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Inputs>(settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Model ToModel() {ConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Model result = new ConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Model();
result.inParami_RequisitionId = inParami_RequisitionId == null ? 0L : inParami_RequisitionId.Value;
return result;
}

}
