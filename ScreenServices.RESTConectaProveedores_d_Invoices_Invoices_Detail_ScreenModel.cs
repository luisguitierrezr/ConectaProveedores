using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("RefreshInvoiceDetailsHistory")]
public String varLcRefreshInvoiceDetailsHistory;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;
[JsonProperty("GetInitializationData")]
public RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs varLcGetInitializationData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
DateTime varLcRefreshInvoiceDetailsHistory = variables.varLcRefreshInvoiceDetailsHistory == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcRefreshInvoiceDetailsHistory, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Model _varLcGetInitializationData = (variables.varLcGetInitializationData != null) ? RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs.ToModel(variables.varLcGetInitializationData) : null;
ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel(inParami_InvoiceId, inParami_RequisitionId, varLcRefreshInvoiceDetailsHistory, _varLcGetUserApplicationRoles, _varLcGetInitializationData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
