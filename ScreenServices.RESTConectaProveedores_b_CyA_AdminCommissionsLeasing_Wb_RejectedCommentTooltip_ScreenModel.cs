using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetCommentsByProposalLineApprovalLevelId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c> ScreenDataSetGetCommentsByProposalLineApprovalLevelId;
[JsonProperty("i_ProposalLineApprovalLevelId")]
public long? inParami_ProposalLineApprovalLevelId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel ToModel() {long inParami_ProposalLineApprovalLevelId = variables.inParami_ProposalLineApprovalLevelId == null ? 0L : variables.inParami_ProposalLineApprovalLevelId.Value;
AggregateRecord<RL_b1eac7b235569839fbbc9e410d978a26> _ScreenDataSetGetCommentsByProposalLineApprovalLevelId = (variables.ScreenDataSetGetCommentsByProposalLineApprovalLevelId != null) ? variables.ScreenDataSetGetCommentsByProposalLineApprovalLevelId.FromJS((array) => {
return RL_b1eac7b235569839fbbc9e410d978a26.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel screenModel = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel(inParami_ProposalLineApprovalLevelId, _ScreenDataSetGetCommentsByProposalLineApprovalLevelId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
