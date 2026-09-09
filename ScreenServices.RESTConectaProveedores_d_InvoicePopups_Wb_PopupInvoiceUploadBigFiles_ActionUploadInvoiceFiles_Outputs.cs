using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionUploadInvoiceFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ErrorMsg")]
public string outParamErrorMsg;
[JsonProperty("o_Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice;
[JsonProperty("o_InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended;
[JsonProperty("ClaveProdServ")]
public string outParamClaveProdServ;
[JsonProperty("TipoComprobante")]
public string outParamTipoComprobante;
[JsonProperty("IsMissingCreditNote")]
public bool? outParamIsMissingCreditNote;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionUploadInvoiceFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMsg, EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice, EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended, string outParamClaveProdServ, string outParamTipoComprobante, bool outParamIsMissingCreditNote) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionUploadInvoiceFiles_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionUploadInvoiceFiles_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMsg = outParamErrorMsg;
// Write optimized result.outParamo_Invoice
result.outParamo_Invoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), conf);
// Write optimized result.outParamo_InvoiceExtended
result.outParamo_InvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(new EN_f81a3d226103fd013068b8763798067aEntityRecord(), conf);
// Write optimized result.outParamClaveProdServ
result.outParamClaveProdServ = "";
// Write optimized result.outParamTipoComprobante
result.outParamTipoComprobante = "";
result.outParamIsMissingCreditNote = (bool?) outParamIsMissingCreditNote;
return result;
}


    

    
}
