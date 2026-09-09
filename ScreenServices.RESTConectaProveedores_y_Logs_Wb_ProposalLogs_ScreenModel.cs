using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProposalLogsByProposalId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa> ScreenDataSetGetProposalLogsByProposalId;
[JsonProperty("CountProposalLogs")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835> ScreenDataSetCountProposalLogs;
[JsonProperty("GetUsers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930> ScreenDataSetGetUsers;
[JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("i_ProposalLineId")]
public long? inParami_ProposalLineId;
[JsonProperty("i_refresh")]
public String inParami_refresh;
[JsonProperty("l_DateTimeVar")]
public String varLcl_DateTimeVar;
[JsonProperty("l_UserName")]
public string varLcl_UserName;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel ToModel() {long inParami_ProposalId = variables.inParami_ProposalId == null ? 0L : variables.inParami_ProposalId.Value;
long inParami_ProposalLineId = variables.inParami_ProposalLineId == null ? 0L : variables.inParami_ProposalLineId.Value;
DateTime inParami_refresh = variables.inParami_refresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_refresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime varLcl_DateTimeVar = variables.varLcl_DateTimeVar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcl_DateTimeVar);
string varLcl_UserName = variables.varLcl_UserName == null ? "" : variables.varLcl_UserName;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 10 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_f6f48bf2db0bc517dcae1aa52c83f316> _ScreenDataSetGetProposalLogsByProposalId = (variables.ScreenDataSetGetProposalLogsByProposalId != null) ? variables.ScreenDataSetGetProposalLogsByProposalId.FromJS((array) => {
return RL_f6f48bf2db0bc517dcae1aa52c83f316.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa.ToStructure);
}
) : null;
AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> _ScreenDataSetCountProposalLogs = (variables.ScreenDataSetCountProposalLogs != null) ? variables.ScreenDataSetCountProposalLogs.FromJS((array) => {
return RL_11e68f59508e412eaf5b78801dd06b0e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835.ToStructure);
}
) : null;
AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> _ScreenDataSetGetUsers = (variables.ScreenDataSetGetUsers != null) ? variables.ScreenDataSetGetUsers.FromJS((array) => {
return RL_8e4276b7147c8295b1546570303ecba2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930.ToStructure);
}
) : null;
ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel screenModel = new ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel(inParami_ProposalId, inParami_ProposalLineId, inParami_refresh, varLcl_DateTimeVar, varLcl_UserName, varLcMaxRecords, _ScreenDataSetGetProposalLogsByProposalId, _ScreenDataSetCountProposalLogs, _ScreenDataSetGetUsers, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
