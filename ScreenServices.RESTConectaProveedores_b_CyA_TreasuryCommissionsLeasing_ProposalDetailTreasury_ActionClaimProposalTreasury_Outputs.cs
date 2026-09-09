using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsSuccess")]
public bool? outParamo_IsSuccess;


    public static RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsSuccess) {RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Outputs result = new RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamo_IsSuccess
result.outParamo_IsSuccess = (bool?) false;
return result;
}


    

    
}
