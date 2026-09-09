using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_DashboardApprover_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProposalLines")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2a967ca085a7d7066ca851285c363d53> ScreenDataSetGetProposalLines;
[JsonProperty("GetApprovedProposalLines")]
public RESTConectaProveedores_a_Main_DashboardApprover_DataActionGetApprovedProposalLines_Outputs varLcGetApprovedProposalLines;
[JsonProperty("GetNotApprovedProposalLines")]
public RESTConectaProveedores_a_Main_DashboardApprover_DataActionGetNotApprovedProposalLines_Outputs varLcGetNotApprovedProposalLines;
[JsonProperty("GetRejectedProposalLines")]
public RESTConectaProveedores_a_Main_DashboardApprover_DataActionGetRejectedProposalLines_Outputs varLcGetRejectedProposalLines;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Main_DashboardApprover_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_DashboardApprover_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Main_DashboardApprover_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Main_DashboardApprover_ScreenModel ToModel() {AggregateRecord<RL_90a833a7c67bd4e28d2034b8adc2432b> _ScreenDataSetGetProposalLines = (variables.ScreenDataSetGetProposalLines != null) ? variables.ScreenDataSetGetProposalLines.FromJS((array) => {
return RL_90a833a7c67bd4e28d2034b8adc2432b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2a967ca085a7d7066ca851285c363d53.ToStructure);
}
) : null;
ConectaProveedores_a_Main_DashboardApprover_DataActionGetApprovedProposalLines_Model _varLcGetApprovedProposalLines = (variables.varLcGetApprovedProposalLines != null) ? RESTConectaProveedores_a_Main_DashboardApprover_DataActionGetApprovedProposalLines_Outputs.ToModel(variables.varLcGetApprovedProposalLines) : null;
ConectaProveedores_a_Main_DashboardApprover_DataActionGetNotApprovedProposalLines_Model _varLcGetNotApprovedProposalLines = (variables.varLcGetNotApprovedProposalLines != null) ? RESTConectaProveedores_a_Main_DashboardApprover_DataActionGetNotApprovedProposalLines_Outputs.ToModel(variables.varLcGetNotApprovedProposalLines) : null;
ConectaProveedores_a_Main_DashboardApprover_DataActionGetRejectedProposalLines_Model _varLcGetRejectedProposalLines = (variables.varLcGetRejectedProposalLines != null) ? RESTConectaProveedores_a_Main_DashboardApprover_DataActionGetRejectedProposalLines_Outputs.ToModel(variables.varLcGetRejectedProposalLines) : null;
ConectaProveedores_a_Main_DashboardApprover_ScreenModel screenModel = new ConectaProveedores_a_Main_DashboardApprover_ScreenModel(_ScreenDataSetGetProposalLines, _varLcGetApprovedProposalLines, _varLcGetNotApprovedProposalLines, _varLcGetRejectedProposalLines, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
