using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetRequisitionLogsByRequisitionId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692> ScreenDataSetGetRequisitionLogsByRequisitionId;
[JsonProperty("CountRequisitionLogs")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835> ScreenDataSetCountRequisitionLogs;
[JsonProperty("GetUsers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930> ScreenDataSetGetUsers;
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
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


    public static RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel ToModel() {long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
DateTime inParami_refresh = variables.inParami_refresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_refresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime varLcl_DateTimeVar = variables.varLcl_DateTimeVar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcl_DateTimeVar);
string varLcl_UserName = variables.varLcl_UserName == null ? "" : variables.varLcl_UserName;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 10 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_229a538de0ea5acc5992a93132dd8a21> _ScreenDataSetGetRequisitionLogsByRequisitionId = (variables.ScreenDataSetGetRequisitionLogsByRequisitionId != null) ? variables.ScreenDataSetGetRequisitionLogsByRequisitionId.FromJS((array) => {
return RL_229a538de0ea5acc5992a93132dd8a21.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692.ToStructure);
}
) : null;
AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> _ScreenDataSetCountRequisitionLogs = (variables.ScreenDataSetCountRequisitionLogs != null) ? variables.ScreenDataSetCountRequisitionLogs.FromJS((array) => {
return RL_11e68f59508e412eaf5b78801dd06b0e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835.ToStructure);
}
) : null;
AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> _ScreenDataSetGetUsers = (variables.ScreenDataSetGetUsers != null) ? variables.ScreenDataSetGetUsers.FromJS((array) => {
return RL_8e4276b7147c8295b1546570303ecba2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930.ToStructure);
}
) : null;
ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel screenModel = new ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel(inParami_RequisitionId, inParami_refresh, varLcl_DateTimeVar, varLcl_UserName, varLcMaxRecords, _ScreenDataSetGetRequisitionLogsByRequisitionId, _ScreenDataSetCountRequisitionLogs, _ScreenDataSetGetUsers, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
