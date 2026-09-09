using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_ActionCancelProposal_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("i_CancelReason")]
public string inParami_CancelReason;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_ActionCancelProposal_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_ActionCancelProposal_Inputs result = inputParameters.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_ActionCancelProposal_Inputs>(settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_ActionCancelProposal_Model ToModel() {ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_ActionCancelProposal_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_ActionCancelProposal_Model();
result.inParami_ProposalId = inParami_ProposalId == null ? 0L : inParami_ProposalId.Value;
result.inParami_CancelReason = inParami_CancelReason == null ? "" : inParami_CancelReason;
return result;
}

}
