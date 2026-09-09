using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ValidationReport")]
public ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure outParamValidationReport;
[JsonProperty("InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTRC_b6257dfb536e679f8b7be7b4b56f189b outParamInvoiceExtended;
[JsonProperty("FolioId")]
public long? outParamFolioId;
[JsonProperty("IsFromRequisition")]
public bool? outParamIsFromRequisition;


    public static RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_f54c1d1bac41c2667837ac97bb484830Structure outParamValidationReport, RC_b6257dfb536e679f8b7be7b4b56f189b outParamInvoiceExtended, long outParamFolioId, bool outParamIsFromRequisition) {RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs result = new RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs();
// Write the needed fields of the record outParamValidationReport to the result.outParamValidationReport
result.outParamValidationReport = new ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure();
result.outParamValidationReport.AttrSupplier = outParamValidationReport.ssSupplier;
result.outParamValidationReport.AttrProject = outParamValidationReport.ssProject;
result.outParamValidationReport.AttrReservePeriod = outParamValidationReport.ssReservePeriod;
result.outParamValidationReport.AttrInvoiceNumber = outParamValidationReport.ssInvoiceNumber;
result.outParamValidationReport.AttrFrequency = outParamValidationReport.ssFrequency;
result.outParamValidationReport.AttrRequisitionNumber = outParamValidationReport.ssRequisitionNumber;
result.outParamValidationReport.AttrOrderNumber = outParamValidationReport.ssOrderNumber;
result.outParamValidationReport.AttrDeliveryDate = outParamValidationReport.ssDeliveryDate;
// Write optimized result.outParamValidationReport.AttrValidationReportItems
result.outParamValidationReport.AttrValidationReportItems = new RL_f0441ae281d3bacc0d1d0acaed8c2549().ToRestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructureDelegate(conf));
result.outParamValidationReport.AttrBusinessCat = outParamValidationReport.ssBusinessCat;
result.outParamValidationReport.AttrBusinessSubcat = outParamValidationReport.ssBusinessSubcat;
result.outParamValidationReport.AttrCharacteristics = outParamValidationReport.ssCharacteristics;
result.outParamValidationReport.AttrDeliveries = outParamValidationReport.ssDeliveries;
result.outParamValidationReport.AttrAttachments = outParamValidationReport.ssAttachments;
// Write optimized result.outParamValidationReport.AttrValidationReportAuthorizations
result.outParamValidationReport.AttrValidationReportAuthorizations = new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c().ToRestList<ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure>(ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructureDelegate(conf));
result.outParamValidationReport.AttrFolioCreationDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamValidationReport.ssFolioCreationDate);
result.outParamValidationReport.AttrSociety = outParamValidationReport.ssSociety;
result.outParamValidationReport.AttrPEPElement = outParamValidationReport.ssPEPElement;
result.outParamValidationReport.AttrDeliverySite = outParamValidationReport.ssDeliverySite;
result.outParamValidationReport.AttrEntryNumber = outParamValidationReport.ssEntryNumber;
result.outParamValidationReport.AttrEntryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamValidationReport.ssEntryDate, conf.DateTimeFormat);
// Write the needed fields of the record outParamInvoiceExtended to the result.outParamInvoiceExtended
result.outParamInvoiceExtended = new ssConectaProveedores.RestRecords.RESTRC_b6257dfb536e679f8b7be7b4b56f189b();
// Write the needed fields of the record outParamInvoiceExtended.ssENInvoice to the result.outParamInvoiceExtended.AttrInvoice
result.outParamInvoiceExtended.AttrInvoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrId
result.outParamInvoiceExtended.AttrInvoice.AttrId = (long?) 0L;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrName
result.outParamInvoiceExtended.AttrInvoice.AttrName = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrRequisitionId
result.outParamInvoiceExtended.AttrInvoice.AttrRequisitionId = (long?) 0L;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrFolioId
result.outParamInvoiceExtended.AttrInvoice.AttrFolioId = (long?) 0L;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrOrderMainId
result.outParamInvoiceExtended.AttrInvoice.AttrOrderMainId = (long?) 0L;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrCFDITypeId
result.outParamInvoiceExtended.AttrInvoice.AttrCFDITypeId = (int?) 0;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrTotalAmount
result.outParamInvoiceExtended.AttrInvoice.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrCurrency
result.outParamInvoiceExtended.AttrInvoice.AttrCurrency = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrInvoiceStatusId
result.outParamInvoiceExtended.AttrInvoice.AttrInvoiceStatusId = (int?) 0;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrAccountingDateTime
result.outParamInvoiceExtended.AttrInvoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrPaymentDateTime
result.outParamInvoiceExtended.AttrInvoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrCreatedOn
result.outParamInvoiceExtended.AttrInvoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrCreatedBy
result.outParamInvoiceExtended.AttrInvoice.AttrCreatedBy = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrUpdatedOn
result.outParamInvoiceExtended.AttrInvoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrUpdatedBy
result.outParamInvoiceExtended.AttrInvoice.AttrUpdatedBy = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrSubmittedOn
result.outParamInvoiceExtended.AttrInvoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrIsNewVersion
result.outParamInvoiceExtended.AttrInvoice.AttrIsNewVersion = (bool?) false;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrID_POLIZA
result.outParamInvoiceExtended.AttrInvoice.AttrID_POLIZA = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrID_POLIZA_SAP
result.outParamInvoiceExtended.AttrInvoice.AttrID_POLIZA_SAP = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrDoc51
result.outParamInvoiceExtended.AttrInvoice.AttrDoc51 = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrAccountingError
result.outParamInvoiceExtended.AttrInvoice.AttrAccountingError = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrOrderAccConceptsID
result.outParamInvoiceExtended.AttrInvoice.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrAmortization
result.outParamInvoiceExtended.AttrInvoice.AttrAmortization = (decimal?) 0.0M;
// Write optimized result.outParamInvoiceExtended.AttrInvoice.AttrCreditNoteInvoiceId
result.outParamInvoiceExtended.AttrInvoice.AttrCreditNoteInvoiceId = (long?) 0L;
// Write the needed fields of the record outParamInvoiceExtended.ssENInvoiceExtended to the result.outParamInvoiceExtended.AttrInvoiceExtended
result.outParamInvoiceExtended.AttrInvoiceExtended = new ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord();
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrId
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrId = (long?) 0L;
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrVersion
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrVersion = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrFolio
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrFolio = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrSerie
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrSerie = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrFechaEmision
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrFechaEmision = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrFormaPago
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrFormaPago = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrMetodoPago
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrMetodoPago = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrLugarExpedicion
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrLugarExpedicion = "";
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrSubtotal = (decimal?) outParamInvoiceExtended.ssENInvoiceExtended.ssSubtotal;
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrDescuento
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrDescuento = (decimal?) 0.0M;
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrTotalIVA = (decimal?) outParamInvoiceExtended.ssENInvoiceExtended.ssTotalIVA;
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrRetenciones = (decimal?) outParamInvoiceExtended.ssENInvoiceExtended.ssRetenciones;
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrTotal = (decimal?) outParamInvoiceExtended.ssENInvoiceExtended.ssTotal;
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrTipoComprobante
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrTipoComprobante = "";
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrMoneda = outParamInvoiceExtended.ssENInvoiceExtended.ssMoneda;
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrTipoCambio
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrTipoCambio = (decimal?) 0.0M;
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrUsoCFDI
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrUsoCFDI = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrExportacion
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrExportacion = "";
// Write optimized result.outParamInvoiceExtended.AttrInvoiceExtended.AttrUUID
result.outParamInvoiceExtended.AttrInvoiceExtended.AttrUUID = "";
result.outParamFolioId = (long?) outParamFolioId;
result.outParamIsFromRequisition = (bool?) outParamIsFromRequisition;
return result;
}


    public static ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Model ToModel(RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs variables) {ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Model result = new ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Model();
result.outParamValidationReport = variables == null ? new ST_f54c1d1bac41c2667837ac97bb484830Structure() : ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure.ToStructure(variables.outParamValidationReport);
result.outParamInvoiceExtended = variables == null ? new RC_b6257dfb536e679f8b7be7b4b56f189b() : ssConectaProveedores.RestRecords.RESTRC_b6257dfb536e679f8b7be7b4b56f189b.ToStructure(variables.outParamInvoiceExtended);
result.outParamFolioId = variables == null || variables.outParamFolioId == null ? 0L : variables.outParamFolioId.Value;
result.outParamIsFromRequisition = variables == null || variables.outParamIsFromRequisition == null ? false : variables.outParamIsFromRequisition.Value;
return result;
}


    public static RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs result = new RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs();
result.outParamValidationReport = ssConectaProveedores.RestRecords.RESTST_f54c1d1bac41c2667837ac97bb484830Structure.FromStructure(screenModel.outParamValidationReport, conf);
result.outParamInvoiceExtended = ssConectaProveedores.RestRecords.RESTRC_b6257dfb536e679f8b7be7b4b56f189b.FromStructure(screenModel.outParamInvoiceExtended, conf);
result.outParamFolioId = (long?) screenModel.outParamFolioId;
result.outParamIsFromRequisition = (bool?) screenModel.outParamIsFromRequisition;
return result;
}

}
