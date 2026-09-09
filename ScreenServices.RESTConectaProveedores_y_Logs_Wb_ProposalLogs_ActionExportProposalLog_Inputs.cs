using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("i_ProposalLineId")]
public long? inParami_ProposalLineId;


    public static RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Inputs result = inputParameters.ToObject<RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Inputs>(settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Model ToModel() {ConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Model result = new ConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Model();
result.inParami_ProposalId = inParami_ProposalId == null ? 0L : inParami_ProposalId.Value;
result.inParami_ProposalLineId = inParami_ProposalLineId == null ? 0L : inParami_ProposalLineId.Value;
return result;
}

}
