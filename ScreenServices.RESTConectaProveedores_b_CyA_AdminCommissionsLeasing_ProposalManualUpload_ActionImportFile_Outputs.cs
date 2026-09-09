using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Ouput")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Ouput;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Ouput) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_Ouput to the result.outParamo_Ouput
result.outParamo_Ouput = new ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure();
result.outParamo_Ouput.AttrIsSuccess = (bool?) outParamo_Ouput.ssIsSuccess;
result.outParamo_Ouput.AttrMessage = outParamo_Ouput.ssMessage;
// Write optimized result.outParamo_Ouput.AttrLines
result.outParamo_Ouput.AttrLines = (int?) 0;
return result;
}


    

    
}
