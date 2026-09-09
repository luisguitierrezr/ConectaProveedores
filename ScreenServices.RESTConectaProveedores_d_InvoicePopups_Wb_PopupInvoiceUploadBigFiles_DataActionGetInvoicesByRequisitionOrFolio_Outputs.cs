using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoicesList")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord> outParamInvoicesList;
[JsonProperty("InvoicesSum")]
public decimal? outParamInvoicesSum;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_2d16aaaf46aa59a96936af8c3c3547a0 outParamInvoicesList, decimal outParamInvoicesSum) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs();
// Write the needed fields of the list outParamInvoicesList to the result.outParamInvoicesList
ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord tmpoutParamInvoicesListElement;
if(outParamInvoicesList.Empty) {
// Write the needed fields of the record outParamInvoicesList.CurrentRec to the tmpoutParamInvoicesListElement
tmpoutParamInvoicesListElement = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
// Write optimized tmpoutParamInvoicesListElement.AttrId
tmpoutParamInvoicesListElement.AttrId = (long?) 0L;
tmpoutParamInvoicesListElement.AttrName = outParamInvoicesList.CurrentRec.ssName;
// Write optimized tmpoutParamInvoicesListElement.AttrRequisitionId
tmpoutParamInvoicesListElement.AttrRequisitionId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrFolioId
tmpoutParamInvoicesListElement.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrOrderMainId
tmpoutParamInvoicesListElement.AttrOrderMainId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrCFDITypeId
tmpoutParamInvoicesListElement.AttrCFDITypeId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrTotalAmount
tmpoutParamInvoicesListElement.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrCurrency
tmpoutParamInvoicesListElement.AttrCurrency = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceStatusId
tmpoutParamInvoicesListElement.AttrInvoiceStatusId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrAccountingDateTime
tmpoutParamInvoicesListElement.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrPaymentDateTime
tmpoutParamInvoicesListElement.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrCreatedOn
tmpoutParamInvoicesListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrCreatedBy
tmpoutParamInvoicesListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrUpdatedOn
tmpoutParamInvoicesListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrUpdatedBy
tmpoutParamInvoicesListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrSubmittedOn
tmpoutParamInvoicesListElement.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrIsNewVersion
tmpoutParamInvoicesListElement.AttrIsNewVersion = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrID_POLIZA
tmpoutParamInvoicesListElement.AttrID_POLIZA = "";
// Write optimized tmpoutParamInvoicesListElement.AttrID_POLIZA_SAP
tmpoutParamInvoicesListElement.AttrID_POLIZA_SAP = "";
// Write optimized tmpoutParamInvoicesListElement.AttrDoc51
tmpoutParamInvoicesListElement.AttrDoc51 = "";
// Write optimized tmpoutParamInvoicesListElement.AttrAccountingError
tmpoutParamInvoicesListElement.AttrAccountingError = "";
// Write optimized tmpoutParamInvoicesListElement.AttrOrderAccConceptsID
tmpoutParamInvoicesListElement.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrAmortization
tmpoutParamInvoicesListElement.AttrAmortization = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrCreditNoteInvoiceId
tmpoutParamInvoicesListElement.AttrCreditNoteInvoiceId = (long?) 0L;
result.outParamInvoicesList = new RestList<ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord>(new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord[] {}, tmpoutParamInvoicesListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord>
 tmpoutParamInvoicesList1List = new List<ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord>
();
try {outParamInvoicesList.StartIteration();
while (!(outParamInvoicesList.Eof)) {
// Write the needed fields of the record outParamInvoicesList.CurrentRec to the tmpoutParamInvoicesListElement
tmpoutParamInvoicesListElement = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
// Write optimized tmpoutParamInvoicesListElement.AttrId
tmpoutParamInvoicesListElement.AttrId = (long?) 0L;
tmpoutParamInvoicesListElement.AttrName = outParamInvoicesList.CurrentRec.ssName;
// Write optimized tmpoutParamInvoicesListElement.AttrRequisitionId
tmpoutParamInvoicesListElement.AttrRequisitionId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrFolioId
tmpoutParamInvoicesListElement.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrOrderMainId
tmpoutParamInvoicesListElement.AttrOrderMainId = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrCFDITypeId
tmpoutParamInvoicesListElement.AttrCFDITypeId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrTotalAmount
tmpoutParamInvoicesListElement.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrCurrency
tmpoutParamInvoicesListElement.AttrCurrency = "";
// Write optimized tmpoutParamInvoicesListElement.AttrInvoiceStatusId
tmpoutParamInvoicesListElement.AttrInvoiceStatusId = (int?) 0;
// Write optimized tmpoutParamInvoicesListElement.AttrAccountingDateTime
tmpoutParamInvoicesListElement.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrPaymentDateTime
tmpoutParamInvoicesListElement.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrCreatedOn
tmpoutParamInvoicesListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrCreatedBy
tmpoutParamInvoicesListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrUpdatedOn
tmpoutParamInvoicesListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrUpdatedBy
tmpoutParamInvoicesListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoicesListElement.AttrSubmittedOn
tmpoutParamInvoicesListElement.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoicesListElement.AttrIsNewVersion
tmpoutParamInvoicesListElement.AttrIsNewVersion = (bool?) false;
// Write optimized tmpoutParamInvoicesListElement.AttrID_POLIZA
tmpoutParamInvoicesListElement.AttrID_POLIZA = "";
// Write optimized tmpoutParamInvoicesListElement.AttrID_POLIZA_SAP
tmpoutParamInvoicesListElement.AttrID_POLIZA_SAP = "";
// Write optimized tmpoutParamInvoicesListElement.AttrDoc51
tmpoutParamInvoicesListElement.AttrDoc51 = "";
// Write optimized tmpoutParamInvoicesListElement.AttrAccountingError
tmpoutParamInvoicesListElement.AttrAccountingError = "";
// Write optimized tmpoutParamInvoicesListElement.AttrOrderAccConceptsID
tmpoutParamInvoicesListElement.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized tmpoutParamInvoicesListElement.AttrAmortization
tmpoutParamInvoicesListElement.AttrAmortization = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoicesListElement.AttrCreditNoteInvoiceId
tmpoutParamInvoicesListElement.AttrCreditNoteInvoiceId = (long?) 0L;
tmpoutParamInvoicesList1List.Add(tmpoutParamInvoicesListElement);
outParamInvoicesList.Advance();
}

} finally {
outParamInvoicesList.EndIteration();
}

result.outParamInvoicesList = new RestList<ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord>(tmpoutParamInvoicesList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord));
}

result.outParamInvoicesSum = (decimal?) outParamInvoicesSum;
return result;
}


    public static ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model ToModel(RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs variables) {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model();
result.outParamInvoicesList = variables == null ? new RL_2d16aaaf46aa59a96936af8c3c3547a0() : RL_2d16aaaf46aa59a96936af8c3c3547a0.FromRestList(variables.outParamInvoicesList, ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure);
result.outParamInvoicesSum = variables == null || variables.outParamInvoicesSum == null ? 0.0M : variables.outParamInvoicesSum.Value;
return result;
}


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs();
result.outParamInvoicesList = screenModel.outParamInvoicesList.ToRestList<ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructureDelegate(conf));
result.outParamInvoicesSum = (decimal?) screenModel.outParamInvoicesSum;
return result;
}

}
