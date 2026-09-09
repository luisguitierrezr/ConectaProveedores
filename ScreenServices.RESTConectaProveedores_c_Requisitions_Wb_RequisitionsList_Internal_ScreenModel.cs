using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> ScreenDataSetGetCompanies;
[JsonProperty("GetApprovalStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302> ScreenDataSetGetApprovalStatuses;
[JsonProperty("GetRequisitionStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b> ScreenDataSetGetRequisitionStatuses;
[JsonProperty("GetEntraRole")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b> ScreenDataSetGetEntraRole;
[JsonProperty("GetProjectAssetServices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetServices;
[JsonProperty("GetCostCenters")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d> ScreenDataSetGetCostCenters;
[JsonProperty("l_ShowFilters")]
public bool? varLcl_ShowFilters;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_ApplicationRoleIdForAggregate")]
public long? varLcl_ApplicationRoleIdForAggregate;
[JsonProperty("l_IsAllowSelectApplicationRoles")]
public bool? varLcl_IsAllowSelectApplicationRoles;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetRequisitions")]
public string varLcl_ColumnJSONVarGetRequisitions;
[JsonProperty("l_CountAfterFetchGetRequisitions")]
public int? varLcl_CountAfterFetchGetRequisitions;
[JsonProperty("l_ShowCancelPopup")]
public bool? varLcl_ShowCancelPopup;
[JsonProperty("l_AmountFromText")]
public string varLcl_AmountFromText;
[JsonProperty("l_AmountToText")]
public string varLcl_AmountToText;
[JsonProperty("l_RequisitonToCancel")]
public long? varLcl_RequisitonToCancel;
[JsonProperty("l_ShowScreenTableDownloads")]
public bool? varLcl_ShowScreenTableDownloads;
[JsonProperty("l_RequisitionsListInternalIdList")]
public RestList<long> varLcl_RequisitionsListInternalIdList;
[JsonProperty("IsListFullNeedRefresh")]
public bool? varLcIsListFullNeedRefresh;
[JsonProperty("GetUserApplicationRolesAndMore")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetUserApplicationRolesAndMore_Outputs varLcGetUserApplicationRolesAndMore;
[JsonProperty("GetRequisitionsFull")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs varLcGetRequisitionsFull;
[JsonProperty("GetRequisitions")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs varLcGetRequisitions;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel ToModel() {bool varLcl_ShowFilters = variables.varLcl_ShowFilters == null ? false : variables.varLcl_ShowFilters.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "Requisition.Id DESC" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
long varLcl_ApplicationRoleIdForAggregate = variables.varLcl_ApplicationRoleIdForAggregate == null ? 0L : variables.varLcl_ApplicationRoleIdForAggregate.Value;
bool varLcl_IsAllowSelectApplicationRoles = variables.varLcl_IsAllowSelectApplicationRoles == null ? false : variables.varLcl_IsAllowSelectApplicationRoles.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetRequisitions = variables.varLcl_ColumnJSONVarGetRequisitions == null ? "" : variables.varLcl_ColumnJSONVarGetRequisitions;
int varLcl_CountAfterFetchGetRequisitions = variables.varLcl_CountAfterFetchGetRequisitions == null ? 0 : variables.varLcl_CountAfterFetchGetRequisitions.Value;
bool varLcl_ShowCancelPopup = variables.varLcl_ShowCancelPopup == null ? false : variables.varLcl_ShowCancelPopup.Value;
string varLcl_AmountFromText = variables.varLcl_AmountFromText == null ? "" : variables.varLcl_AmountFromText;
string varLcl_AmountToText = variables.varLcl_AmountToText == null ? "" : variables.varLcl_AmountToText;
long varLcl_RequisitonToCancel = variables.varLcl_RequisitonToCancel == null ? 0L : variables.varLcl_RequisitonToCancel.Value;
bool varLcl_ShowScreenTableDownloads = variables.varLcl_ShowScreenTableDownloads == null ? false : variables.varLcl_ShowScreenTableDownloads.Value;
BasicTypeList<long> varLcl_RequisitionsListInternalIdList = BasicTypeList<long>.FromRestList(variables.varLcl_RequisitionsListInternalIdList);
bool varLcIsListFullNeedRefresh = variables.varLcIsListFullNeedRefresh == null ? false : variables.varLcIsListFullNeedRefresh.Value;
AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_060f887b4f32b5cdb78b49175875565c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.ToStructure);
}
) : null;
AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> _ScreenDataSetGetApprovalStatuses = (variables.ScreenDataSetGetApprovalStatuses != null) ? variables.ScreenDataSetGetApprovalStatuses.FromJS((array) => {
return RL_51a4e63e168a01408e3f55c611518e13.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302.ToStructure);
}
) : null;
AggregateRecord<RL_7324330f004cfb528140f21030a5e90f> _ScreenDataSetGetRequisitionStatuses = (variables.ScreenDataSetGetRequisitionStatuses != null) ? variables.ScreenDataSetGetRequisitionStatuses.FromJS((array) => {
return RL_7324330f004cfb528140f21030a5e90f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b.ToStructure);
}
) : null;
AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> _ScreenDataSetGetEntraRole = (variables.ScreenDataSetGetEntraRole != null) ? variables.ScreenDataSetGetEntraRole.FromJS((array) => {
return RL_ea7d18baeeefa57d5c86706d7efb98e9.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b.ToStructure);
}
) : null;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetServices = (variables.ScreenDataSetGetProjectAssetServices != null) ? variables.ScreenDataSetGetProjectAssetServices.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> _ScreenDataSetGetCostCenters = (variables.ScreenDataSetGetCostCenters != null) ? variables.ScreenDataSetGetCostCenters.FromJS((array) => {
return RL_ec55ed22dae89075d036f3a863173164.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetUserApplicationRolesAndMore_Model _varLcGetUserApplicationRolesAndMore = (variables.varLcGetUserApplicationRolesAndMore != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetUserApplicationRolesAndMore_Outputs.ToModel(variables.varLcGetUserApplicationRolesAndMore) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Model _varLcGetRequisitionsFull = (variables.varLcGetRequisitionsFull != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs.ToModel(variables.varLcGetRequisitionsFull) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Model _varLcGetRequisitions = (variables.varLcGetRequisitions != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs.ToModel(variables.varLcGetRequisitions) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel(varLcl_ShowFilters, varLcl_TableSort, varLcl_StartIndex, varLcl_ApplicationRoleIdForAggregate, varLcl_IsAllowSelectApplicationRoles, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetRequisitions, varLcl_CountAfterFetchGetRequisitions, varLcl_ShowCancelPopup, varLcl_AmountFromText, varLcl_AmountToText, varLcl_RequisitonToCancel, varLcl_ShowScreenTableDownloads, varLcl_RequisitionsListInternalIdList, varLcIsListFullNeedRefresh, _ScreenDataSetGetCompanies, _ScreenDataSetGetApprovalStatuses, _ScreenDataSetGetRequisitionStatuses, _ScreenDataSetGetEntraRole, _ScreenDataSetGetProjectAssetServices, _ScreenDataSetGetCostCenters, _varLcGetUserApplicationRolesAndMore, _varLcGetRequisitionsFull, _varLcGetRequisitions, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
