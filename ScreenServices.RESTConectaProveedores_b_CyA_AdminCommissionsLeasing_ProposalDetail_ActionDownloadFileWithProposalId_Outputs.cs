using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionDownloadFileWithProposalId_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Filename")]
public string outParamo_Filename;
[JsonProperty("o_BinaryData")]
public byte[] outParamo_BinaryData;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionDownloadFileWithProposalId_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_Filename, byte[] outParamo_BinaryData) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionDownloadFileWithProposalId_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionDownloadFileWithProposalId_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_Filename = outParamo_Filename;
result.outParamo_BinaryData = outParamo_BinaryData;
return result;
}


    

    
}
