using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetCommentsByProposalId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a> ScreenDataSetGetCommentsByProposalId;
[JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel ToModel() {long inParami_ProposalId = variables.inParami_ProposalId == null ? 0L : variables.inParami_ProposalId.Value;
AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> _ScreenDataSetGetCommentsByProposalId = (variables.ScreenDataSetGetCommentsByProposalId != null) ? variables.ScreenDataSetGetCommentsByProposalId.FromJS((array) => {
return RL_6f7a73531f09191ac235a09fbbea38a5.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel screenModel = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel(inParami_ProposalId, _ScreenDataSetGetCommentsByProposalId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
