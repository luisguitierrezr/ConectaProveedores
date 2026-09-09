using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetLast10Proposals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d> ScreenDataSetGetLast10Proposals;
[JsonProperty("GetErrorAPIProposals")]
public RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetErrorAPIProposals_Outputs varLcGetErrorAPIProposals;
[JsonProperty("GetActiveProposals")]
public RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs varLcGetActiveProposals;
[JsonProperty("GetProcessedProposals")]
public RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs varLcGetProcessedProposals;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Main_DashboardAdmin_ScreenModel ToModel() {AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> _ScreenDataSetGetLast10Proposals = (variables.ScreenDataSetGetLast10Proposals != null) ? variables.ScreenDataSetGetLast10Proposals.FromJS((array) => {
return RL_f4591be205d3928a9fe22daf19d979cd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d.ToStructure);
}
) : null;
ConectaProveedores_a_Main_DashboardAdmin_DataActionGetErrorAPIProposals_Model _varLcGetErrorAPIProposals = (variables.varLcGetErrorAPIProposals != null) ? RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetErrorAPIProposals_Outputs.ToModel(variables.varLcGetErrorAPIProposals) : null;
ConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Model _varLcGetActiveProposals = (variables.varLcGetActiveProposals != null) ? RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs.ToModel(variables.varLcGetActiveProposals) : null;
ConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Model _varLcGetProcessedProposals = (variables.varLcGetProcessedProposals != null) ? RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs.ToModel(variables.varLcGetProcessedProposals) : null;
ConectaProveedores_a_Main_DashboardAdmin_ScreenModel screenModel = new ConectaProveedores_a_Main_DashboardAdmin_ScreenModel(_ScreenDataSetGetLast10Proposals, _varLcGetErrorAPIProposals, _varLcGetActiveProposals, _varLcGetProcessedProposals, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
