using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionFilteredProposalsExport_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Output")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("o_File")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure outParamo_File;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionFilteredProposalsExport_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionFilteredProposalsExport_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionFilteredProposalsExport_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_Output to the result.outParamo_Output
result.outParamo_Output = new ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure();
result.outParamo_Output.AttrIsSuccess = (bool?) outParamo_Output.ssIsSuccess;
result.outParamo_Output.AttrMessage = outParamo_Output.ssMessage;
// Write optimized result.outParamo_Output.AttrLines
result.outParamo_Output.AttrLines = (int?) 0;
// Write the needed fields of the record outParamo_File to the result.outParamo_File
result.outParamo_File = new ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure();
result.outParamo_File.AttrName = outParamo_File.ssName;
result.outParamo_File.AttrBinaryData = outParamo_File.ssBinaryData;
return result;
}


    

    
}
