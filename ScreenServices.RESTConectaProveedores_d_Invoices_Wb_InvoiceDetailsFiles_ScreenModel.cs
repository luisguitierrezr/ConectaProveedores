using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_InvoiceName")]
public string inParami_InvoiceName;
[JsonProperty("IsProveedor")]
public bool? inParamIsProveedor;
[JsonProperty("GetInvoiceFiles")]
public RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs varLcGetInvoiceFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
string inParami_InvoiceName = variables.inParami_InvoiceName == null ? "" : variables.inParami_InvoiceName;
bool inParamIsProveedor = variables.inParamIsProveedor == null ? false : variables.inParamIsProveedor.Value;
ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Model _varLcGetInvoiceFiles = (variables.varLcGetInvoiceFiles != null) ? RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs.ToModel(variables.varLcGetInvoiceFiles) : null;
ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel(inParami_InvoiceId, inParami_InvoiceName, inParamIsProveedor, _varLcGetInvoiceFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
