using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionUploadInvoiceFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

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


    public static RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionUploadInvoiceFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMsg, EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice, EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended, string outParamClaveProdServ, string outParamTipoComprobante, bool outParamIsMissingCreditNote) {RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionUploadInvoiceFiles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionUploadInvoiceFiles_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMsg = outParamErrorMsg;
// Write the needed fields of the record outParamo_Invoice to the result.outParamo_Invoice
result.outParamo_Invoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
result.outParamo_Invoice.AttrId = (long?) outParamo_Invoice.ssId;
result.outParamo_Invoice.AttrName = outParamo_Invoice.ssName;
result.outParamo_Invoice.AttrRequisitionId = (long?) outParamo_Invoice.ssRequisitionId;
result.outParamo_Invoice.AttrFolioId = (long?) outParamo_Invoice.ssFolioId;
result.outParamo_Invoice.AttrOrderMainId = (long?) outParamo_Invoice.ssOrderMainId;
result.outParamo_Invoice.AttrCFDITypeId = (int?) outParamo_Invoice.ssCFDITypeId;
result.outParamo_Invoice.AttrTotalAmount = (decimal?) outParamo_Invoice.ssTotalAmount;
result.outParamo_Invoice.AttrCurrency = outParamo_Invoice.ssCurrency;
result.outParamo_Invoice.AttrInvoiceStatusId = (int?) outParamo_Invoice.ssInvoiceStatusId;
result.outParamo_Invoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_Invoice.ssAccountingDateTime, conf.DateTimeFormat);
result.outParamo_Invoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_Invoice.ssPaymentDateTime, conf.DateTimeFormat);
result.outParamo_Invoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_Invoice.ssCreatedOn, conf.DateTimeFormat);
result.outParamo_Invoice.AttrCreatedBy = outParamo_Invoice.ssCreatedBy;
result.outParamo_Invoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_Invoice.ssUpdatedOn, conf.DateTimeFormat);
result.outParamo_Invoice.AttrUpdatedBy = outParamo_Invoice.ssUpdatedBy;
result.outParamo_Invoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_Invoice.ssSubmittedOn, conf.DateTimeFormat);
result.outParamo_Invoice.AttrIsNewVersion = (bool?) outParamo_Invoice.ssIsNewVersion;
result.outParamo_Invoice.AttrID_POLIZA = outParamo_Invoice.ssID_POLIZA;
result.outParamo_Invoice.AttrID_POLIZA_SAP = outParamo_Invoice.ssID_POLIZA_SAP;
result.outParamo_Invoice.AttrDoc51 = outParamo_Invoice.ssDoc51;
result.outParamo_Invoice.AttrAccountingError = outParamo_Invoice.ssAccountingError;
result.outParamo_Invoice.AttrOrderAccConceptsID = (long?) outParamo_Invoice.ssOrderAccConceptsID;
result.outParamo_Invoice.AttrAmortization = (decimal?) outParamo_Invoice.ssAmortization;
result.outParamo_Invoice.AttrCreditNoteInvoiceId = (long?) outParamo_Invoice.ssCreditNoteInvoiceId;
// Write optimized result.outParamo_InvoiceExtended
result.outParamo_InvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(new EN_f81a3d226103fd013068b8763798067aEntityRecord(), conf);
result.outParamClaveProdServ = outParamClaveProdServ;
result.outParamTipoComprobante = outParamTipoComprobante;
result.outParamIsMissingCreditNote = (bool?) outParamIsMissingCreditNote;
return result;
}


    

    
}
