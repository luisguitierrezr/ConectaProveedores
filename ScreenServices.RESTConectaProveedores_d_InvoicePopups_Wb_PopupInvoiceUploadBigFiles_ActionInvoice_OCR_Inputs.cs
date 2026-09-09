using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("PDFBinaryData")]
public byte[] inParamPDFBinaryData;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Model();
result.inParamPDFBinaryData = inParamPDFBinaryData == null ? new byte[] {} : inParamPDFBinaryData;
return result;
}

}
