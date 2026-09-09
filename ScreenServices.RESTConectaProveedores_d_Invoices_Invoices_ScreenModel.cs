using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469> ScreenDataSetGetInvoices;
[JsonProperty("GetApprovalStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302> ScreenDataSetGetApprovalStatuses;
[JsonProperty("GetProjectAssetServices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetServices;
[JsonProperty("GetInvoicesFull")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469> ScreenDataSetGetInvoicesFull;
[JsonProperty("GetEntraRole")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b> ScreenDataSetGetEntraRole;
[JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> ScreenDataSetGetCompanies;
[JsonProperty("l_ApplicationRoleIdForAggregate")]
public long? varLcl_ApplicationRoleIdForAggregate;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_CountAfterFetch")]
public int? varLcl_CountAfterFetch;
[JsonProperty("l_IsAllowSelectApplicationRoles")]
public bool? varLcl_IsAllowSelectApplicationRoles;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_IsShowSelectAll")]
public bool? varLcl_IsShowSelectAll;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsSelectedForApproval")]
public bool? varLcl_IsSelectedForApproval;
[JsonProperty("l_IsSelectAllForApproval")]
public bool? varLcl_IsSelectAllForApproval;
[JsonProperty("l_IsSelectedForAssignment")]
public bool? varLcl_IsSelectedForAssignment;
[JsonProperty("l_IsSelectAllForAssignment")]
public bool? varLcl_IsSelectAllForAssignment;
[JsonProperty("l_ShowBulkRejectPopup")]
public bool? varLcl_ShowBulkRejectPopup;
[JsonProperty("l_InvoiceId")]
public long? varLcl_InvoiceId;
[JsonProperty("l_InvoiceApprovalLevelList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814> varLcl_InvoiceApprovalLevelList;
[JsonProperty("l_InvoiceApprovalLevelId")]
public long? varLcl_InvoiceApprovalLevelId;
[JsonProperty("l_ShowBulkApproveInvoices")]
public bool? varLcl_ShowBulkApproveInvoices;
[JsonProperty("l_ShowApproveInvoice")]
public bool? varLcl_ShowApproveInvoice;
[JsonProperty("l_ShowRejectInvoice")]
public bool? varLcl_ShowRejectInvoice;
[JsonProperty("l_ShowAssignFirstApproverPopup")]
public bool? varLcl_ShowAssignFirstApproverPopup;
[JsonProperty("l_ShowBulkComment")]
public bool? varLcl_ShowBulkComment;
[JsonProperty("l_ShowComment")]
public bool? varLcl_ShowComment;
[JsonProperty("l_ShowAssignAnalistaPopup")]
public bool? varLcl_ShowAssignAnalistaPopup;
[JsonProperty("NotifContent")]
public ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent;
[JsonProperty("NotifError")]
public ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError;
[JsonProperty("l_InvoicesTablesIdList")]
public RestList<long> varLcl_InvoicesTablesIdList;
[JsonProperty("l_ShowScreenTableDownloads")]
public bool? varLcl_ShowScreenTableDownloads;
[JsonProperty("IsListFullNeedRefresh")]
public bool? varLcIsListFullNeedRefresh;
[JsonProperty("GetInvoiceCountToAssign")]
public RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs varLcGetInvoiceCountToAssign;
[JsonProperty("GetUserApplicationRolesAndMore")]
public RESTConectaProveedores_d_Invoices_Invoices_DataActionGetUserApplicationRolesAndMore_Outputs varLcGetUserApplicationRolesAndMore;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Invoices_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Invoices_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Invoices_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Invoices_ScreenModel ToModel() {long varLcl_ApplicationRoleIdForAggregate = variables.varLcl_ApplicationRoleIdForAggregate == null ? 0L : variables.varLcl_ApplicationRoleIdForAggregate.Value;
string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_IsAllowSelectApplicationRoles = variables.varLcl_IsAllowSelectApplicationRoles == null ? false : variables.varLcl_IsAllowSelectApplicationRoles.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
bool varLcl_IsShowSelectAll = variables.varLcl_IsShowSelectAll == null ? false : variables.varLcl_IsShowSelectAll.Value;
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsSelectedForApproval = variables.varLcl_IsSelectedForApproval == null ? false : variables.varLcl_IsSelectedForApproval.Value;
bool varLcl_IsSelectAllForApproval = variables.varLcl_IsSelectAllForApproval == null ? false : variables.varLcl_IsSelectAllForApproval.Value;
bool varLcl_IsSelectedForAssignment = variables.varLcl_IsSelectedForAssignment == null ? false : variables.varLcl_IsSelectedForAssignment.Value;
bool varLcl_IsSelectAllForAssignment = variables.varLcl_IsSelectAllForAssignment == null ? false : variables.varLcl_IsSelectAllForAssignment.Value;
bool varLcl_ShowBulkRejectPopup = variables.varLcl_ShowBulkRejectPopup == null ? false : variables.varLcl_ShowBulkRejectPopup.Value;
long varLcl_InvoiceId = variables.varLcl_InvoiceId == null ? 0L : variables.varLcl_InvoiceId.Value;
RL_09457db01df0de3852b9312cdd42fb2a varLcl_InvoiceApprovalLevelList = RL_09457db01df0de3852b9312cdd42fb2a.FromRestList(variables.varLcl_InvoiceApprovalLevelList, ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814.ToStructure);
long varLcl_InvoiceApprovalLevelId = variables.varLcl_InvoiceApprovalLevelId == null ? 0L : variables.varLcl_InvoiceApprovalLevelId.Value;
bool varLcl_ShowBulkApproveInvoices = variables.varLcl_ShowBulkApproveInvoices == null ? false : variables.varLcl_ShowBulkApproveInvoices.Value;
bool varLcl_ShowApproveInvoice = variables.varLcl_ShowApproveInvoice == null ? false : variables.varLcl_ShowApproveInvoice.Value;
bool varLcl_ShowRejectInvoice = variables.varLcl_ShowRejectInvoice == null ? false : variables.varLcl_ShowRejectInvoice.Value;
bool varLcl_ShowAssignFirstApproverPopup = variables.varLcl_ShowAssignFirstApproverPopup == null ? false : variables.varLcl_ShowAssignFirstApproverPopup.Value;
bool varLcl_ShowBulkComment = variables.varLcl_ShowBulkComment == null ? false : variables.varLcl_ShowBulkComment.Value;
bool varLcl_ShowComment = variables.varLcl_ShowComment == null ? false : variables.varLcl_ShowComment.Value;
bool varLcl_ShowAssignAnalistaPopup = variables.varLcl_ShowAssignAnalistaPopup == null ? false : variables.varLcl_ShowAssignAnalistaPopup.Value;
ST_6ac87b97c676cd17082ba2063283d4baStructure varLcNotifContent = ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure.ToStructure(variables.varLcNotifContent);
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure varLcNotifError = ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure.ToStructure(variables.varLcNotifError);
BasicTypeList<long> varLcl_InvoicesTablesIdList = BasicTypeList<long>.FromRestList(variables.varLcl_InvoicesTablesIdList);
bool varLcl_ShowScreenTableDownloads = variables.varLcl_ShowScreenTableDownloads == null ? false : variables.varLcl_ShowScreenTableDownloads.Value;
bool varLcIsListFullNeedRefresh = variables.varLcIsListFullNeedRefresh == null ? false : variables.varLcIsListFullNeedRefresh.Value;
AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> _ScreenDataSetGetInvoices = (variables.ScreenDataSetGetInvoices != null) ? variables.ScreenDataSetGetInvoices.FromJS((array) => {
return RL_c5ca0a80d78493d156f2b1a68d86a831.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469.ToStructure);
}
) : null;
AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> _ScreenDataSetGetApprovalStatuses = (variables.ScreenDataSetGetApprovalStatuses != null) ? variables.ScreenDataSetGetApprovalStatuses.FromJS((array) => {
return RL_51a4e63e168a01408e3f55c611518e13.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302.ToStructure);
}
) : null;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetServices = (variables.ScreenDataSetGetProjectAssetServices != null) ? variables.ScreenDataSetGetProjectAssetServices.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> _ScreenDataSetGetInvoicesFull = (variables.ScreenDataSetGetInvoicesFull != null) ? variables.ScreenDataSetGetInvoicesFull.FromJS((array) => {
return RL_c5ca0a80d78493d156f2b1a68d86a831.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469.ToStructure);
}
) : null;
AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> _ScreenDataSetGetEntraRole = (variables.ScreenDataSetGetEntraRole != null) ? variables.ScreenDataSetGetEntraRole.FromJS((array) => {
return RL_ea7d18baeeefa57d5c86706d7efb98e9.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b.ToStructure);
}
) : null;
AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_060f887b4f32b5cdb78b49175875565c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Model _varLcGetInvoiceCountToAssign = (variables.varLcGetInvoiceCountToAssign != null) ? RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs.ToModel(variables.varLcGetInvoiceCountToAssign) : null;
ConectaProveedores_d_Invoices_Invoices_DataActionGetUserApplicationRolesAndMore_Model _varLcGetUserApplicationRolesAndMore = (variables.varLcGetUserApplicationRolesAndMore != null) ? RESTConectaProveedores_d_Invoices_Invoices_DataActionGetUserApplicationRolesAndMore_Outputs.ToModel(variables.varLcGetUserApplicationRolesAndMore) : null;
ConectaProveedores_d_Invoices_Invoices_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Invoices_ScreenModel(varLcl_ApplicationRoleIdForAggregate, varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_IsAllowSelectApplicationRoles, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, varLcl_IsShowSelectAll, varLcl_IsSelectAll, varLcl_IsSelectedForApproval, varLcl_IsSelectAllForApproval, varLcl_IsSelectedForAssignment, varLcl_IsSelectAllForAssignment, varLcl_ShowBulkRejectPopup, varLcl_InvoiceId, varLcl_InvoiceApprovalLevelList, varLcl_InvoiceApprovalLevelId, varLcl_ShowBulkApproveInvoices, varLcl_ShowApproveInvoice, varLcl_ShowRejectInvoice, varLcl_ShowAssignFirstApproverPopup, varLcl_ShowBulkComment, varLcl_ShowComment, varLcl_ShowAssignAnalistaPopup, varLcNotifContent, varLcNotifError, varLcl_InvoicesTablesIdList, varLcl_ShowScreenTableDownloads, varLcIsListFullNeedRefresh, _ScreenDataSetGetInvoices, _ScreenDataSetGetApprovalStatuses, _ScreenDataSetGetProjectAssetServices, _ScreenDataSetGetInvoicesFull, _ScreenDataSetGetEntraRole, _ScreenDataSetGetCompanies, _varLcGetInvoiceCountToAssign, _varLcGetUserApplicationRolesAndMore, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
