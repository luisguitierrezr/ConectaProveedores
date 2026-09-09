using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_HasProposalChangedStatus")]
public bool? outParamo_HasProposalChangedStatus;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_HasProposalChangedStatus) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_HasProposalChangedStatus = (bool?) outParamo_HasProposalChangedStatus;
return result;
}


    

    
}
