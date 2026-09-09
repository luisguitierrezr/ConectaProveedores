using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFoliosSAE")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d> ScreenDataSetGetFoliosSAE;
[JsonProperty("GetFoliosSAEFull")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d> ScreenDataSetGetFoliosSAEFull;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c> ScreenDataSetGetRegions;
[JsonProperty("GetFolioStatus")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2> ScreenDataSetGetFolioStatus;
[JsonProperty("l_ApplicationRoleIdForAggregate")]
public long? varLcl_ApplicationRoleIdForAggregate;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_CountAfterFetch")]
public int? varLcl_CountAfterFetch;
[JsonProperty("l_IsAllowSelectApplicationRoles")]
public bool? varLcl_IsAllowSelectApplicationRoles;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_IsSelected")]
public bool? varLcl_IsSelected;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsShowSelectAll")]
public bool? varLcl_IsShowSelectAll;
[JsonProperty("IsListFullNeedRefresh")]
public bool? varLcIsListFullNeedRefresh;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel ToModel() {long varLcl_ApplicationRoleIdForAggregate = variables.varLcl_ApplicationRoleIdForAggregate == null ? 0L : variables.varLcl_ApplicationRoleIdForAggregate.Value;
string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_IsAllowSelectApplicationRoles = variables.varLcl_IsAllowSelectApplicationRoles == null ? false : variables.varLcl_IsAllowSelectApplicationRoles.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
bool varLcl_IsSelected = variables.varLcl_IsSelected == null ? false : variables.varLcl_IsSelected.Value;
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsShowSelectAll = variables.varLcl_IsShowSelectAll == null ? false : variables.varLcl_IsShowSelectAll.Value;
bool varLcIsListFullNeedRefresh = variables.varLcIsListFullNeedRefresh == null ? false : variables.varLcIsListFullNeedRefresh.Value;
AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> _ScreenDataSetGetFoliosSAE = (variables.ScreenDataSetGetFoliosSAE != null) ? variables.ScreenDataSetGetFoliosSAE.FromJS((array) => {
return RL_c2883fff640d266ea46702d7f4b1c10f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d.ToStructure);
}
) : null;
AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> _ScreenDataSetGetFoliosSAEFull = (variables.ScreenDataSetGetFoliosSAEFull != null) ? variables.ScreenDataSetGetFoliosSAEFull.FromJS((array) => {
return RL_c2883fff640d266ea46702d7f4b1c10f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d.ToStructure);
}
) : null;
AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_07bd6e6f32ae098d324b78b5f3777516.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c.ToStructure);
}
) : null;
AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> _ScreenDataSetGetFolioStatus = (variables.ScreenDataSetGetFolioStatus != null) ? variables.ScreenDataSetGetFolioStatus.FromJS((array) => {
return RL_ba9fc810801f4aabee0bc4ef3685a9dd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel(varLcl_ApplicationRoleIdForAggregate, varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_IsAllowSelectApplicationRoles, varLcl_Loading, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, varLcl_IsSelected, varLcl_IsSelectAll, varLcl_IsShowSelectAll, varLcIsListFullNeedRefresh, _ScreenDataSetGetFoliosSAE, _ScreenDataSetGetFoliosSAEFull, _ScreenDataSetGetRegions, _ScreenDataSetGetFolioStatus, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
