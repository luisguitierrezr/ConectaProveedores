using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_File")]
public byte[] outParamo_File;
[JsonProperty("o_FileName")]
public string outParamo_FileName;


    public static RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_File, string outParamo_FileName) {RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Outputs result = new RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_File = outParamo_File;
// Write optimized result.outParamo_FileName
result.outParamo_FileName = "";
return result;
}


    

    
}
