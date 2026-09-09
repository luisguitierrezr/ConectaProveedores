using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProposalLineById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758> ScreenDataSetGetProposalLineById;
[JsonProperty("i_ProposalLineId")]
public long? inParami_ProposalLineId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel ToModel() {long inParami_ProposalLineId = variables.inParami_ProposalLineId == null ? 0L : variables.inParami_ProposalLineId.Value;
AggregateRecord<RL_64d6c39a28702aee27a7d75c307bc2c1> _ScreenDataSetGetProposalLineById = (variables.ScreenDataSetGetProposalLineById != null) ? variables.ScreenDataSetGetProposalLineById.FromJS((array) => {
return RL_64d6c39a28702aee27a7d75c307bc2c1.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel screenModel = new ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel(inParami_ProposalLineId, _ScreenDataSetGetProposalLineById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
