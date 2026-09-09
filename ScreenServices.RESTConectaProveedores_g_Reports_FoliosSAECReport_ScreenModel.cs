using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2> ScreenDataSetGetFolioStatuses;
[JsonProperty("GetTelcelDirections")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5> ScreenDataSetGetTelcelDirections;
[JsonProperty("GetFolioSAECItems")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_89c1eb236aae2b02b66345e2ec5e59e9> ScreenDataSetGetFolioSAECItems;
[JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> ScreenDataSetGetCompanies;
[JsonProperty("GetApplicants")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_9fd4d8d4a1a7da3e37ee97c8163946e6> ScreenDataSetGetApplicants;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("IsToEmpty")]
public bool? varLcIsToEmpty;
[JsonProperty("Loading")]
public bool? varLcLoading;
[JsonProperty("ColumnJSONVar")]
public string varLcColumnJSONVar;
[JsonProperty("CountAfterFetch")]
public int? varLcCountAfterFetch;
[JsonProperty("ReInvokeToggler")]
public bool? varLcReInvokeToggler;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel ToModel() {int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
bool varLcIsToEmpty = variables.varLcIsToEmpty == null ? false : variables.varLcIsToEmpty.Value;
bool varLcLoading = variables.varLcLoading == null ? false : variables.varLcLoading.Value;
string varLcColumnJSONVar = variables.varLcColumnJSONVar == null ? "" : variables.varLcColumnJSONVar;
int varLcCountAfterFetch = variables.varLcCountAfterFetch == null ? 0 : variables.varLcCountAfterFetch.Value;
bool varLcReInvokeToggler = variables.varLcReInvokeToggler == null ? false : variables.varLcReInvokeToggler.Value;
AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> _ScreenDataSetGetFolioStatuses = (variables.ScreenDataSetGetFolioStatuses != null) ? variables.ScreenDataSetGetFolioStatuses.FromJS((array) => {
return RL_ba9fc810801f4aabee0bc4ef3685a9dd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2.ToStructure);
}
) : null;
AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838> _ScreenDataSetGetTelcelDirections = (variables.ScreenDataSetGetTelcelDirections != null) ? variables.ScreenDataSetGetTelcelDirections.FromJS((array) => {
return RL_9895159eebcdcdaed80fbd832f52d838.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5.ToStructure);
}
) : null;
AggregateRecord<RL_ed90a45f2cc96d244d7fc28b114020f0> _ScreenDataSetGetFolioSAECItems = (variables.ScreenDataSetGetFolioSAECItems != null) ? variables.ScreenDataSetGetFolioSAECItems.FromJS((array) => {
return RL_ed90a45f2cc96d244d7fc28b114020f0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_89c1eb236aae2b02b66345e2ec5e59e9.ToStructure);
}
) : null;
AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_060f887b4f32b5cdb78b49175875565c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.ToStructure);
}
) : null;
AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b> _ScreenDataSetGetApplicants = (variables.ScreenDataSetGetApplicants != null) ? variables.ScreenDataSetGetApplicants.FromJS((array) => {
return RL_89fdc2de9b4f3c518b096795c532253b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_9fd4d8d4a1a7da3e37ee97c8163946e6.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
ConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel screenModel = new ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel(varLcStartIndex, varLcTableSort, varLcIsToEmpty, varLcLoading, varLcColumnJSONVar, varLcCountAfterFetch, varLcReInvokeToggler, _ScreenDataSetGetFolioStatuses, _ScreenDataSetGetTelcelDirections, _ScreenDataSetGetFolioSAECItems, _ScreenDataSetGetCompanies, _ScreenDataSetGetApplicants, _ScreenDataSetGetRegions, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
