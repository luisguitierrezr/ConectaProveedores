using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_DashboardTreasury_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetLast10Proposals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_bb9053a6ea6eec7bc3ffbc5b5de7b452> ScreenDataSetGetLast10Proposals;
[JsonProperty("GetPartiallyPaidProposals")]
public RESTConectaProveedores_a_Main_DashboardTreasury_DataActionGetPartiallyPaidProposals_Outputs varLcGetPartiallyPaidProposals;
[JsonProperty("GetPaidProposals")]
public RESTConectaProveedores_a_Main_DashboardTreasury_DataActionGetPaidProposals_Outputs varLcGetPaidProposals;
[JsonProperty("GetActiveProposals")]
public RESTConectaProveedores_a_Main_DashboardTreasury_DataActionGetActiveProposals_Outputs varLcGetActiveProposals;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Main_DashboardTreasury_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_DashboardTreasury_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Main_DashboardTreasury_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Main_DashboardTreasury_ScreenModel ToModel() {AggregateRecord<RL_f8f660cba6c51b3d6579cc8426c3f972> _ScreenDataSetGetLast10Proposals = (variables.ScreenDataSetGetLast10Proposals != null) ? variables.ScreenDataSetGetLast10Proposals.FromJS((array) => {
return RL_f8f660cba6c51b3d6579cc8426c3f972.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_bb9053a6ea6eec7bc3ffbc5b5de7b452.ToStructure);
}
) : null;
ConectaProveedores_a_Main_DashboardTreasury_DataActionGetPartiallyPaidProposals_Model _varLcGetPartiallyPaidProposals = (variables.varLcGetPartiallyPaidProposals != null) ? RESTConectaProveedores_a_Main_DashboardTreasury_DataActionGetPartiallyPaidProposals_Outputs.ToModel(variables.varLcGetPartiallyPaidProposals) : null;
ConectaProveedores_a_Main_DashboardTreasury_DataActionGetPaidProposals_Model _varLcGetPaidProposals = (variables.varLcGetPaidProposals != null) ? RESTConectaProveedores_a_Main_DashboardTreasury_DataActionGetPaidProposals_Outputs.ToModel(variables.varLcGetPaidProposals) : null;
ConectaProveedores_a_Main_DashboardTreasury_DataActionGetActiveProposals_Model _varLcGetActiveProposals = (variables.varLcGetActiveProposals != null) ? RESTConectaProveedores_a_Main_DashboardTreasury_DataActionGetActiveProposals_Outputs.ToModel(variables.varLcGetActiveProposals) : null;
ConectaProveedores_a_Main_DashboardTreasury_ScreenModel screenModel = new ConectaProveedores_a_Main_DashboardTreasury_ScreenModel(_ScreenDataSetGetLast10Proposals, _varLcGetPartiallyPaidProposals, _varLcGetPaidProposals, _varLcGetActiveProposals, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
