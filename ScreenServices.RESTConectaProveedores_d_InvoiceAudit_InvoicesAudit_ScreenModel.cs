using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("HasSearched")]
public bool? varLcHasSearched;
[JsonProperty("InvoiceName")]
public string varLcInvoiceName;
[JsonProperty("GetUserRegion")]
public RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs varLcGetUserRegion;
[JsonProperty("GetInvoice")]
public RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs varLcGetInvoice;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel ToModel() {bool varLcHasSearched = variables.varLcHasSearched == null ? false : variables.varLcHasSearched.Value;
string varLcInvoiceName = variables.varLcInvoiceName == null ? "" : variables.varLcInvoiceName;
ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Model _varLcGetUserRegion = (variables.varLcGetUserRegion != null) ? RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs.ToModel(variables.varLcGetUserRegion) : null;
ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Model _varLcGetInvoice = (variables.varLcGetInvoice != null) ? RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Outputs.ToModel(variables.varLcGetInvoice) : null;
ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel screenModel = new ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel(varLcHasSearched, varLcInvoiceName, _varLcGetUserRegion, _varLcGetInvoice, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
