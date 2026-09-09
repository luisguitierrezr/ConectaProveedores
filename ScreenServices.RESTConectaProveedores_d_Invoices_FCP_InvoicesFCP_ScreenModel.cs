using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoicesFCP")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_306956f424b25ba445c85694148eaa7a> ScreenDataSetGetInvoicesFCP;
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
[JsonProperty("l_IsOpenPopupAccounting")]
public bool? varLcl_IsOpenPopupAccounting;
[JsonProperty("l_ID_POLIZA_SAP")]
public string varLcl_ID_POLIZA_SAP;
[JsonProperty("l_ID_POLIZA_SAP_CN")]
public string varLcl_ID_POLIZA_SAP_CN;
[JsonProperty("l_Invoice_Popup")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_Popup;
[JsonProperty("l_Invoice_CN_Popup")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_CN_Popup;
[JsonProperty("GetUserApplicationRolesAndMore")]
public RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs varLcGetUserApplicationRolesAndMore;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel ToModel() {long varLcl_ApplicationRoleIdForAggregate = variables.varLcl_ApplicationRoleIdForAggregate == null ? 0L : variables.varLcl_ApplicationRoleIdForAggregate.Value;
string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_IsAllowSelectApplicationRoles = variables.varLcl_IsAllowSelectApplicationRoles == null ? false : variables.varLcl_IsAllowSelectApplicationRoles.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
bool varLcl_IsOpenPopupAccounting = variables.varLcl_IsOpenPopupAccounting == null ? false : variables.varLcl_IsOpenPopupAccounting.Value;
string varLcl_ID_POLIZA_SAP = variables.varLcl_ID_POLIZA_SAP == null ? "" : variables.varLcl_ID_POLIZA_SAP;
string varLcl_ID_POLIZA_SAP_CN = variables.varLcl_ID_POLIZA_SAP_CN == null ? "" : variables.varLcl_ID_POLIZA_SAP_CN;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_Popup = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcl_Invoice_Popup);
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_CN_Popup = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcl_Invoice_CN_Popup);
AggregateRecord<RL_a9ef13a7afdd5c93ea6dfe986c3c8b78> _ScreenDataSetGetInvoicesFCP = (variables.ScreenDataSetGetInvoicesFCP != null) ? variables.ScreenDataSetGetInvoicesFCP.FromJS((array) => {
return RL_a9ef13a7afdd5c93ea6dfe986c3c8b78.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_306956f424b25ba445c85694148eaa7a.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Model _varLcGetUserApplicationRolesAndMore = (variables.varLcGetUserApplicationRolesAndMore != null) ? RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs.ToModel(variables.varLcGetUserApplicationRolesAndMore) : null;
ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel screenModel = new ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel(varLcl_ApplicationRoleIdForAggregate, varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_IsAllowSelectApplicationRoles, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, varLcl_IsOpenPopupAccounting, varLcl_ID_POLIZA_SAP, varLcl_ID_POLIZA_SAP_CN, varLcl_Invoice_Popup, varLcl_Invoice_CN_Popup, _ScreenDataSetGetInvoicesFCP, _varLcGetUserApplicationRolesAndMore, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
