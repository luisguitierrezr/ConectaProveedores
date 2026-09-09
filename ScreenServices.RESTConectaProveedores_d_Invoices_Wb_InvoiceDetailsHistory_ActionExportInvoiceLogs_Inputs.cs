using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Model ToModel() {ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Model result = new ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Model();
result.inParami_InvoiceId = inParami_InvoiceId == null ? 0L : inParami_InvoiceId.Value;
return result;
}

}
