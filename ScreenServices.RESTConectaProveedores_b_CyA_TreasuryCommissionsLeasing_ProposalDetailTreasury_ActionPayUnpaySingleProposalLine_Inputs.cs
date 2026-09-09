using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ProposalLineId")]
public long? inParami_ProposalLineId;
[JsonProperty("i_IsPay")]
public bool? inParami_IsPay;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("i_Binary")]
public byte[] inParami_Binary;
[JsonProperty("i_Filename")]
public string inParami_Filename;


    public static RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Inputs result = inputParameters.ToObject<RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Inputs>(settings);
return result;
}


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Model ToModel() {ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Model result = new ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Model();
result.inParami_ProposalLineId = inParami_ProposalLineId == null ? 0L : inParami_ProposalLineId.Value;
result.inParami_IsPay = inParami_IsPay == null ? false : inParami_IsPay.Value;
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
result.inParami_Binary = inParami_Binary == null ? new byte[] {} : inParami_Binary;
result.inParami_Filename = inParami_Filename == null ? "" : inParami_Filename;
return result;
}

}
