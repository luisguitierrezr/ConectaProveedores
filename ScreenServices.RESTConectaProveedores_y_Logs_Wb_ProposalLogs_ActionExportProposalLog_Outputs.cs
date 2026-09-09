using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_File")]
public byte[] outParamo_File;


    public static RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_File) {RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Outputs result = new RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_File = outParamo_File;
return result;
}


    

    
}
