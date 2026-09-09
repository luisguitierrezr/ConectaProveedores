using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Model ToModel() {ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Model();
result.inParamInvoiceId = inParamInvoiceId == null ? 0L : inParamInvoiceId.Value;
return result;
}

}
