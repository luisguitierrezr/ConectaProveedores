using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_LinesReport_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_aa8eac9e200aee33e0be6438a23c61c3> ScreenDataSetGetInvoices;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("ApplicationRoleIdForAggregate")]
public long? varLcApplicationRoleIdForAggregate;
[JsonProperty("ColumnJSONVar")]
public string varLcColumnJSONVar;
[JsonProperty("CountAfterFetch")]
public int? varLcCountAfterFetch;
[JsonProperty("IsToEmpty")]
public bool? varLcIsToEmpty;
[JsonProperty("Loading")]
public bool? varLcLoading;
[JsonProperty("ReInvokeToggler")]
public bool? varLcReInvokeToggler;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_g_Reports_LinesReport_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_g_Reports_LinesReport_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_LinesReport_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_g_Reports_LinesReport_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_g_Reports_LinesReport_ScreenModel ToModel() {long varLcApplicationRoleIdForAggregate = variables.varLcApplicationRoleIdForAggregate == null ? 0L : variables.varLcApplicationRoleIdForAggregate.Value;
string varLcColumnJSONVar = variables.varLcColumnJSONVar == null ? "" : variables.varLcColumnJSONVar;
int varLcCountAfterFetch = variables.varLcCountAfterFetch == null ? 0 : variables.varLcCountAfterFetch.Value;
bool varLcIsToEmpty = variables.varLcIsToEmpty == null ? false : variables.varLcIsToEmpty.Value;
bool varLcLoading = variables.varLcLoading == null ? false : variables.varLcLoading.Value;
bool varLcReInvokeToggler = variables.varLcReInvokeToggler == null ? false : variables.varLcReInvokeToggler.Value;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
AggregateRecord<RL_6f578d989bb546e044c5b0b47d17f46f> _ScreenDataSetGetInvoices = (variables.ScreenDataSetGetInvoices != null) ? variables.ScreenDataSetGetInvoices.FromJS((array) => {
return RL_6f578d989bb546e044c5b0b47d17f46f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_aa8eac9e200aee33e0be6438a23c61c3.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
ConectaProveedores_g_Reports_LinesReport_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_g_Reports_LinesReport_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_g_Reports_LinesReport_ScreenModel screenModel = new ConectaProveedores_g_Reports_LinesReport_ScreenModel(varLcApplicationRoleIdForAggregate, varLcColumnJSONVar, varLcCountAfterFetch, varLcIsToEmpty, varLcLoading, varLcReInvokeToggler, varLcStartIndex, varLcTableSort, _ScreenDataSetGetInvoices, _ScreenDataSetGetRegions, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
