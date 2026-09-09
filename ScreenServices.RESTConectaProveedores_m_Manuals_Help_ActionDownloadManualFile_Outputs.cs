using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("File")]
public ssConectaProveedores.RestRecords.RESTRC_9558728eac8dc806cf1b0c0e9a8e1262 outParamFile;


    public static RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Outputs FromOutputs(IBehaviorsConfiguration conf, RC_9558728eac8dc806cf1b0c0e9a8e1262 outParamFile) {RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Outputs result = new RESTConectaProveedores_m_Manuals_Help_ActionDownloadManualFile_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamFile to the result.outParamFile
result.outParamFile = new ssConectaProveedores.RestRecords.RESTRC_9558728eac8dc806cf1b0c0e9a8e1262();
result.outParamFile.AttrFilename = outParamFile.ssFilename;
result.outParamFile.AttrBinary = outParamFile.ssBinary;
return result;
}


    

    
}
