using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_RequestsReport_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("GetApplicants")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_9fd4d8d4a1a7da3e37ee97c8163946e6> ScreenDataSetGetApplicants;
[JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> ScreenDataSetGetCompanies;
[JsonProperty("Loading")]
public bool? varLcLoading;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("IsToEmpty")]
public bool? varLcIsToEmpty;
[JsonProperty("ColumnJSONVar")]
public string varLcColumnJSONVar;
[JsonProperty("ReInvokeToggler")]
public bool? varLcReInvokeToggler;
[JsonProperty("CountAfterFetch")]
public int? varLcCountAfterFetch;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;
[JsonProperty("GetOrderRequests")]
public RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs varLcGetOrderRequests;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_g_Reports_RequestsReport_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_RequestsReport_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_g_Reports_RequestsReport_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_g_Reports_RequestsReport_ScreenModel ToModel() {bool varLcLoading = variables.varLcLoading == null ? false : variables.varLcLoading.Value;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
bool varLcIsToEmpty = variables.varLcIsToEmpty == null ? false : variables.varLcIsToEmpty.Value;
string varLcColumnJSONVar = variables.varLcColumnJSONVar == null ? "" : variables.varLcColumnJSONVar;
bool varLcReInvokeToggler = variables.varLcReInvokeToggler == null ? false : variables.varLcReInvokeToggler.Value;
int varLcCountAfterFetch = variables.varLcCountAfterFetch == null ? 0 : variables.varLcCountAfterFetch.Value;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b> _ScreenDataSetGetApplicants = (variables.ScreenDataSetGetApplicants != null) ? variables.ScreenDataSetGetApplicants.FromJS((array) => {
return RL_89fdc2de9b4f3c518b096795c532253b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_9fd4d8d4a1a7da3e37ee97c8163946e6.ToStructure);
}
) : null;
AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_060f887b4f32b5cdb78b49175875565c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.ToStructure);
}
) : null;
ConectaProveedores_g_Reports_RequestsReport_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Model _varLcGetOrderRequests = (variables.varLcGetOrderRequests != null) ? RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs.ToModel(variables.varLcGetOrderRequests) : null;
ConectaProveedores_g_Reports_RequestsReport_ScreenModel screenModel = new ConectaProveedores_g_Reports_RequestsReport_ScreenModel(varLcLoading, varLcStartIndex, varLcTableSort, varLcIsToEmpty, varLcColumnJSONVar, varLcReInvokeToggler, varLcCountAfterFetch, _ScreenDataSetGetRegions, _ScreenDataSetGetApplicants, _ScreenDataSetGetCompanies, _varLcGetUserApplicationRoles, _varLcGetOrderRequests, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
