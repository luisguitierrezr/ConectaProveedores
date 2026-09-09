using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUsers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930> ScreenDataSetGetUsers;
[JsonProperty("GetFolioLogsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7> ScreenDataSetGetFolioLogsByFolioId;
[JsonProperty("CountFolioLogs")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb> ScreenDataSetCountFolioLogs;
[JsonProperty("i_refresh")]
public String inParami_refresh;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
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


    public static RESTConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel ToModel() {DateTime inParami_refresh = variables.inParami_refresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_refresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
DateTime varLcl_DateTimeVar = variables.varLcl_DateTimeVar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcl_DateTimeVar);
string varLcl_UserName = variables.varLcl_UserName == null ? "" : variables.varLcl_UserName;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 10 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> _ScreenDataSetGetUsers = (variables.ScreenDataSetGetUsers != null) ? variables.ScreenDataSetGetUsers.FromJS((array) => {
return RL_8e4276b7147c8295b1546570303ecba2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930.ToStructure);
}
) : null;
AggregateRecord<RL_4f2c6ead1defc6a22d01e9202d23be15> _ScreenDataSetGetFolioLogsByFolioId = (variables.ScreenDataSetGetFolioLogsByFolioId != null) ? variables.ScreenDataSetGetFolioLogsByFolioId.FromJS((array) => {
return RL_4f2c6ead1defc6a22d01e9202d23be15.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7.ToStructure);
}
) : null;
AggregateRecord<RL_9801bd776ff900c0406cf35f97fa0b26> _ScreenDataSetCountFolioLogs = (variables.ScreenDataSetCountFolioLogs != null) ? variables.ScreenDataSetCountFolioLogs.FromJS((array) => {
return RL_9801bd776ff900c0406cf35f97fa0b26.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb.ToStructure);
}
) : null;
ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel screenModel = new ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel(inParami_refresh, inParami_FolioId, varLcl_DateTimeVar, varLcl_UserName, varLcMaxRecords, _ScreenDataSetGetUsers, _ScreenDataSetGetFolioLogsByFolioId, _ScreenDataSetCountFolioLogs, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
