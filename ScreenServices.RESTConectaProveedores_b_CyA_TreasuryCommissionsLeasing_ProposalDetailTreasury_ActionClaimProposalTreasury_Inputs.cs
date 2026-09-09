using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("i_UserId")]
public string inParami_UserId;


    public static RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Inputs result = inputParameters.ToObject<RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Inputs>(settings);
return result;
}


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Model ToModel() {ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Model result = new ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Model();
result.inParami_ProposalId = inParami_ProposalId == null ? 0L : inParami_ProposalId.Value;
result.inParami_UserId = inParami_UserId == null ? "" : inParami_UserId;
return result;
}

}
