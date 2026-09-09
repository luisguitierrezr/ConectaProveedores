using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("i_ProposalLineApprovalLevelId")]
public long? inParami_ProposalLineApprovalLevelId;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Inputs result = inputParameters.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Inputs>(settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Model ToModel() {ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Model();
result.inParami_ProposalId = inParami_ProposalId == null ? 0L : inParami_ProposalId.Value;
result.inParami_ProposalLineApprovalLevelId = inParami_ProposalLineApprovalLevelId == null ? 0L : inParami_ProposalLineApprovalLevelId.Value;
return result;
}

}
