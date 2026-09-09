using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_File")]
public byte[] outParamo_File;


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_File) {RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_File = outParamo_File;
return result;
}


    

    
}
