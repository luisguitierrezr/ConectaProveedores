using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetCommentsByProposalLineId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a> ScreenDataSetGetCommentsByProposalLineId;
[JsonProperty("i_ProposalLineId")]
public long? inParami_ProposalLineId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel ToModel() {long inParami_ProposalLineId = variables.inParami_ProposalLineId == null ? 0L : variables.inParami_ProposalLineId.Value;
AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> _ScreenDataSetGetCommentsByProposalLineId = (variables.ScreenDataSetGetCommentsByProposalLineId != null) ? variables.ScreenDataSetGetCommentsByProposalLineId.FromJS((array) => {
return RL_6f7a73531f09191ac235a09fbbea38a5.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel screenModel = new ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel(inParami_ProposalLineId, _ScreenDataSetGetCommentsByProposalLineId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
