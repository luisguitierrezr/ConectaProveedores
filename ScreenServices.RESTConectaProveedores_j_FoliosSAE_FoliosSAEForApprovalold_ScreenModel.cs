using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSuppliers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3> ScreenDataSetGetSuppliers;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c> ScreenDataSetGetRegions;
[JsonProperty("GetFoliosSAE")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d> ScreenDataSetGetFoliosSAE;
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
[JsonProperty("l_FolioId")]
public long? varLcl_FolioId;
[JsonProperty("l_FolioApprovalLevelList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_ab183c41bd8594296e7d4471350fb29f> varLcl_FolioApprovalLevelList;
[JsonProperty("l_FolioApprovalLevelId")]
public long? varLcl_FolioApprovalLevelId;
[JsonProperty("l_ShowBulkApproveFolio")]
public bool? varLcl_ShowBulkApproveFolio;
[JsonProperty("l_ShowApproveFolio")]
public bool? varLcl_ShowApproveFolio;
[JsonProperty("NotifContent")]
public ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent;
[JsonProperty("NotifError")]
public ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel ToModel() {long varLcl_ApplicationRoleIdForAggregate = variables.varLcl_ApplicationRoleIdForAggregate == null ? 0L : variables.varLcl_ApplicationRoleIdForAggregate.Value;
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
long varLcl_FolioId = variables.varLcl_FolioId == null ? 0L : variables.varLcl_FolioId.Value;
RL_bff3f4c3dd4f015750297ff735629582 varLcl_FolioApprovalLevelList = RL_bff3f4c3dd4f015750297ff735629582.FromRestList(variables.varLcl_FolioApprovalLevelList, ssConectaProveedores.RestRecords.RESTRC_ab183c41bd8594296e7d4471350fb29f.ToStructure);
long varLcl_FolioApprovalLevelId = variables.varLcl_FolioApprovalLevelId == null ? 0L : variables.varLcl_FolioApprovalLevelId.Value;
bool varLcl_ShowBulkApproveFolio = variables.varLcl_ShowBulkApproveFolio == null ? false : variables.varLcl_ShowBulkApproveFolio.Value;
bool varLcl_ShowApproveFolio = variables.varLcl_ShowApproveFolio == null ? false : variables.varLcl_ShowApproveFolio.Value;
ST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent = ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure.ToStructure(variables.varLcNotifContent);
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError = ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure.ToStructure(variables.varLcNotifError);
AggregateRecord<RL_53ee8acf49c9618a86f040a6ab1ebb06> _ScreenDataSetGetSuppliers = (variables.ScreenDataSetGetSuppliers != null) ? variables.ScreenDataSetGetSuppliers.FromJS((array) => {
return RL_53ee8acf49c9618a86f040a6ab1ebb06.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c0133441667bf39f1c8403118864a3c3.ToStructure);
}
) : null;
AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_07bd6e6f32ae098d324b78b5f3777516.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c.ToStructure);
}
) : null;
AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> _ScreenDataSetGetFoliosSAE = (variables.ScreenDataSetGetFoliosSAE != null) ? variables.ScreenDataSetGetFoliosSAE.FromJS((array) => {
return RL_c2883fff640d266ea46702d7f4b1c10f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_FoliosSAEForApprovalold_ScreenModel(varLcl_ApplicationRoleIdForAggregate, varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_IsAllowSelectApplicationRoles, varLcl_Loading, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, varLcl_IsSelected, varLcl_IsSelectAll, varLcl_IsShowSelectAll, varLcl_FolioId, varLcl_FolioApprovalLevelList, varLcl_FolioApprovalLevelId, varLcl_ShowBulkApproveFolio, varLcl_ShowApproveFolio, varLcNotifContent, varLcNotifError, _ScreenDataSetGetSuppliers, _ScreenDataSetGetRegions, _ScreenDataSetGetFoliosSAE, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
