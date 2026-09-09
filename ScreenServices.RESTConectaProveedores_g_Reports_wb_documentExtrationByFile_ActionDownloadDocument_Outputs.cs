using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_file")]
public byte[] outParamo_file;
[JsonProperty("o_filename")]
public string outParamo_filename;


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_file, string outParamo_filename) {RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Outputs result = new RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_file = outParamo_file;
result.outParamo_filename = outParamo_filename;
return result;
}


    

    
}
