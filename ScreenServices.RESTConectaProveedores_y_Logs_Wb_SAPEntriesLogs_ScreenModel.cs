using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetEntriesByOrderMainId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb> ScreenDataSetGetEntriesByOrderMainId;
[JsonProperty("CountEntries")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835> ScreenDataSetCountEntries;
[JsonProperty("i_OrderMainId")]
public long? inParami_OrderMainId;
[JsonProperty("i_refresh")]
public String inParami_refresh;
[JsonProperty("l_DateTimeVar")]
public String varLcl_DateTimeVar;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel ToModel() {long inParami_OrderMainId = variables.inParami_OrderMainId == null ? 0L : variables.inParami_OrderMainId.Value;
DateTime inParami_refresh = variables.inParami_refresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_refresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime varLcl_DateTimeVar = variables.varLcl_DateTimeVar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcl_DateTimeVar);
int varLcMaxRecords = variables.varLcMaxRecords == null ? 10 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> _ScreenDataSetGetEntriesByOrderMainId = (variables.ScreenDataSetGetEntriesByOrderMainId != null) ? variables.ScreenDataSetGetEntriesByOrderMainId.FromJS((array) => {
return RL_3dd9bb7875fde1313207084bc3e4eb42.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb.ToStructure);
}
) : null;
AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> _ScreenDataSetCountEntries = (variables.ScreenDataSetCountEntries != null) ? variables.ScreenDataSetCountEntries.FromJS((array) => {
return RL_11e68f59508e412eaf5b78801dd06b0e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835.ToStructure);
}
) : null;
ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel screenModel = new ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_ScreenModel(inParami_OrderMainId, inParami_refresh, varLcl_DateTimeVar, varLcMaxRecords, _ScreenDataSetGetEntriesByOrderMainId, _ScreenDataSetCountEntries, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
