using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoicesList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1> outParamInvoicesList;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_ff28012de5324af3e81e5ace09ecb1f0 outParamInvoicesList) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs();
// Write the needed fields of the list outParamInvoicesList to the result.outParamInvoicesList
ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1 tmpoutParamInvoicesListElement;
if(outParamInvoicesList.Empty) {
// Write the needed fields of the record outParamInvoicesList.CurrentRec to the tmpoutParamInvoicesListElement
tmpoutParamInvoicesListElement = new ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1();
// Write the needed fields of the record outParamInvoicesList.CurrentRec.ssENInvoice to the tmpoutParamInvoicesListElement.AttrInvoice
tmpoutParamInvoicesListElement.AttrInvoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrId
tmpoutParamInvoicesListElement.AttrInvoice.AttrId = (long?) 0L;
tmpoutParamInvoicesListElement.AttrInvoice.AttrName = outParamInvoicesList.CurrentRec.ssENInvoice.ssName;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrRequisitionId
tmpoutParamInvoicesListElement.AttrInvoice.AttrRequisitionId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrFolioId
tmpoutParamInvoicesListElement.AttrInvoice.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderMainId
tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderMainId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCFDITypeId
tmpoutParamInvoicesListElement.AttrInvoice.AttrCFDITypeId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrTotalAmount
tmpoutParamInvoicesListElement.AttrInvoice.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCurrency
tmpoutParamInvoicesListElement.AttrInvoice.AttrCurrency = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrInvoiceStatusId
tmpoutParamInvoicesListElement.AttrInvoice.AttrInvoiceStatusId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingDateTime
tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrPaymentDateTime
tmpoutParamInvoicesListElement.AttrInvoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedOn
tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedBy
tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedOn
tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedBy
tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrSubmittedOn
tmpoutParamInvoicesListElement.AttrInvoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrIsNewVersion
tmpoutParamInvoicesListElement.AttrInvoice.AttrIsNewVersion = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA
tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA_SAP
tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA_SAP = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrDoc51
tmpoutParamInvoicesListElement.AttrInvoice.AttrDoc51 = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingError
tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingError = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderAccConceptsID
tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrAmortization
tmpoutParamInvoicesListElement.AttrInvoice.AttrAmortization = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCreditNoteInvoiceId
tmpoutParamInvoicesListElement.AttrInvoice.AttrCreditNoteInvoiceId = (long?) 0L;
// Write the needed fields of the record outParamInvoicesList.CurrentRec.ssENInvoiceFile to the tmpoutParamInvoicesListElement.AttrInvoiceFile
tmpoutParamInvoicesListElement.AttrInvoiceFile = new ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrId
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrInvoiceId
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrInvoiceId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrFilename
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrFilename = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsExtra
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsExtra = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsReport
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsReport = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrStorageId
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrStorageId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedBy
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedOn
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
result.outParamInvoicesList = new RestList<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1>(new ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1[] {}, tmpoutParamInvoicesListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1>
 tmpoutParamInvoicesList1List = new List<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1>
();
try {outParamInvoicesList.StartIteration();
while (!(outParamInvoicesList.Eof)) {
// Write the needed fields of the record outParamInvoicesList.CurrentRec to the tmpoutParamInvoicesListElement
tmpoutParamInvoicesListElement = new ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1();
// Write the needed fields of the record outParamInvoicesList.CurrentRec.ssENInvoice to the tmpoutParamInvoicesListElement.AttrInvoice
tmpoutParamInvoicesListElement.AttrInvoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrId
tmpoutParamInvoicesListElement.AttrInvoice.AttrId = (long?) 0L;
tmpoutParamInvoicesListElement.AttrInvoice.AttrName = outParamInvoicesList.CurrentRec.ssENInvoice.ssName;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrRequisitionId
tmpoutParamInvoicesListElement.AttrInvoice.AttrRequisitionId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrFolioId
tmpoutParamInvoicesListElement.AttrInvoice.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderMainId
tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderMainId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCFDITypeId
tmpoutParamInvoicesListElement.AttrInvoice.AttrCFDITypeId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrTotalAmount
tmpoutParamInvoicesListElement.AttrInvoice.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCurrency
tmpoutParamInvoicesListElement.AttrInvoice.AttrCurrency = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrInvoiceStatusId
tmpoutParamInvoicesListElement.AttrInvoice.AttrInvoiceStatusId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingDateTime
tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrPaymentDateTime
tmpoutParamInvoicesListElement.AttrInvoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedOn
tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedBy
tmpoutParamInvoicesListElement.AttrInvoice.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedOn
tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedBy
tmpoutParamInvoicesListElement.AttrInvoice.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrSubmittedOn
tmpoutParamInvoicesListElement.AttrInvoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrIsNewVersion
tmpoutParamInvoicesListElement.AttrInvoice.AttrIsNewVersion = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA
tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA_SAP
tmpoutParamInvoicesListElement.AttrInvoice.AttrID_POLIZA_SAP = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrDoc51
tmpoutParamInvoicesListElement.AttrInvoice.AttrDoc51 = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingError
tmpoutParamInvoicesListElement.AttrInvoice.AttrAccountingError = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderAccConceptsID
tmpoutParamInvoicesListElement.AttrInvoice.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrAmortization
tmpoutParamInvoicesListElement.AttrInvoice.AttrAmortization = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoice.AttrCreditNoteInvoiceId
tmpoutParamInvoicesListElement.AttrInvoice.AttrCreditNoteInvoiceId = (long?) 0L;
// Write the needed fields of the record outParamInvoicesList.CurrentRec.ssENInvoiceFile to the tmpoutParamInvoicesListElement.AttrInvoiceFile
tmpoutParamInvoicesListElement.AttrInvoiceFile = new ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrId
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrInvoiceId
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrInvoiceId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrFilename
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrFilename = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsExtra
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsExtra = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsReport
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrIsReport = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrStorageId
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrStorageId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedBy
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedOn
tmpoutParamInvoicesListElement.AttrInvoiceFile.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
tmpoutParamInvoicesList1List.Add(tmpoutParamInvoicesListElement);
outParamInvoicesList.Advance();
}

} finally {
outParamInvoicesList.EndIteration();
}

result.outParamInvoicesList = new RestList<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1>(tmpoutParamInvoicesList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1));
}

return result;
}


    public static ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Model ToModel(RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs variables) {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Model();
result.outParamInvoicesList = variables == null ? new RL_ff28012de5324af3e81e5ace09ecb1f0() : RL_ff28012de5324af3e81e5ace09ecb1f0.FromRestList(variables.outParamInvoicesList, ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1.ToStructure);
return result;
}


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs();
result.outParamInvoicesList = screenModel.outParamInvoicesList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1>(ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1.FromStructureDelegate(conf));
return result;
}

}
