using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940> ScreenDataSetGetInvoiceStatuses;
[JsonProperty("GetSuppliers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668> ScreenDataSetGetSuppliers;
[JsonProperty("GetInvoices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8> ScreenDataSetGetInvoices;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("GetInvoicesAllRecords")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8> ScreenDataSetGetInvoicesAllRecords;
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
[JsonProperty("GetSettings")]
public RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel ToModel() {long varLcApplicationRoleIdForAggregate = variables.varLcApplicationRoleIdForAggregate == null ? 0L : variables.varLcApplicationRoleIdForAggregate.Value;
string varLcColumnJSONVar = variables.varLcColumnJSONVar == null ? "" : variables.varLcColumnJSONVar;
int varLcCountAfterFetch = variables.varLcCountAfterFetch == null ? 0 : variables.varLcCountAfterFetch.Value;
bool varLcIsToEmpty = variables.varLcIsToEmpty == null ? false : variables.varLcIsToEmpty.Value;
bool varLcLoading = variables.varLcLoading == null ? false : variables.varLcLoading.Value;
bool varLcReInvokeToggler = variables.varLcReInvokeToggler == null ? false : variables.varLcReInvokeToggler.Value;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> _ScreenDataSetGetInvoiceStatuses = (variables.ScreenDataSetGetInvoiceStatuses != null) ? variables.ScreenDataSetGetInvoiceStatuses.FromJS((array) => {
return RL_3262178c68dd5ed5c99ed4279a563975.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940.ToStructure);
}
) : null;
AggregateRecord<RL_1543a4f2af6703945e350e1348a6aecf> _ScreenDataSetGetSuppliers = (variables.ScreenDataSetGetSuppliers != null) ? variables.ScreenDataSetGetSuppliers.FromJS((array) => {
return RL_1543a4f2af6703945e350e1348a6aecf.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668.ToStructure);
}
) : null;
AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> _ScreenDataSetGetInvoices = (variables.ScreenDataSetGetInvoices != null) ? variables.ScreenDataSetGetInvoices.FromJS((array) => {
return RL_fd60f97a407491778f4e2750fb2d9997.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> _ScreenDataSetGetInvoicesAllRecords = (variables.ScreenDataSetGetInvoicesAllRecords != null) ? variables.ScreenDataSetGetInvoicesAllRecords.FromJS((array) => {
return RL_fd60f97a407491778f4e2750fb2d9997.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8.ToStructure);
}
) : null;
ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel screenModel = new ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel(varLcApplicationRoleIdForAggregate, varLcColumnJSONVar, varLcCountAfterFetch, varLcIsToEmpty, varLcLoading, varLcReInvokeToggler, varLcStartIndex, varLcTableSort, _ScreenDataSetGetInvoiceStatuses, _ScreenDataSetGetSuppliers, _ScreenDataSetGetInvoices, _ScreenDataSetGetRegions, _ScreenDataSetGetInvoicesAllRecords, _varLcGetSettings, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
