using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_IsSaveAllFiles")]
public bool? varLci_IsSaveAllFiles;
[JsonProperty("i_IsSaveSelectedFiles")]
public bool? varLci_IsSaveSelectedFiles;
[JsonProperty("GetInvoices")]
public RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs varLcGetInvoices;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel ToModel() {bool varLci_IsSaveAllFiles = variables.varLci_IsSaveAllFiles == null ? false : variables.varLci_IsSaveAllFiles.Value;
bool varLci_IsSaveSelectedFiles = variables.varLci_IsSaveSelectedFiles == null ? false : variables.varLci_IsSaveSelectedFiles.Value;
ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Model _varLcGetInvoices = (variables.varLcGetInvoices != null) ? RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs.ToModel(variables.varLcGetInvoices) : null;
ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel screenModel = new ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel(varLci_IsSaveAllFiles, varLci_IsSaveSelectedFiles, _varLcGetInvoices, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
