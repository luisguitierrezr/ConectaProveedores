using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ActionUploadInvoiceFiles_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
[JsonProperty("OrderMainId")]
public long? inParamOrderMainId;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure> inParamFilesList;
[JsonProperty("ExtraFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure> inParamExtraFilesList;
[JsonProperty("IgnoreCreation")]
public bool? inParamIgnoreCreation;
[JsonProperty("InvoiceForeign")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign;
[JsonProperty("InvoicesSum")]
public decimal? inParamInvoicesSum;
[JsonProperty("IsModify")]
public bool? inParamIsModify;
[JsonProperty("IsStartApproval")]
public bool? inParamIsStartApproval;
[JsonProperty("AccountingDataTypeId")]
public int? inParamAccountingDataTypeId;
[JsonProperty("OrderAccConceptsID")]
public long? inParamOrderAccConceptsID;
[JsonProperty("ImportAnticipo")]
public decimal? inParamImportAnticipo;
[JsonProperty("CreditNoteInvoiceId")]
public long? inParamCreditNoteInvoiceId;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ActionUploadInvoiceFiles_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ActionUploadInvoiceFiles_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ActionUploadInvoiceFiles_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ActionUploadInvoiceFiles_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ActionUploadInvoiceFiles_Model result = new ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ActionUploadInvoiceFiles_Model();
result.inParamInvoiceId = inParamInvoiceId == null ? 0L : inParamInvoiceId.Value;
result.inParamRequisitionId = inParamRequisitionId == null ? 0L : inParamRequisitionId.Value;
result.inParamOrderMainId = inParamOrderMainId == null ? 0L : inParamOrderMainId.Value;
result.inParamFolioId = inParamFolioId == null ? 0L : inParamFolioId.Value;
result.inParamFilesList = RL_7b4ceb84b6a1255d3a42c8932279bc3c.FromRestList(inParamFilesList, ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure.ToStructure);
result.inParamExtraFilesList = RL_7b4ceb84b6a1255d3a42c8932279bc3c.FromRestList(inParamExtraFilesList, ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure.ToStructure);
result.inParamIgnoreCreation = inParamIgnoreCreation == null ? false : inParamIgnoreCreation.Value;
result.inParamInvoiceForeign = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(inParamInvoiceForeign);
result.inParamInvoicesSum = inParamInvoicesSum == null ? 0.0M : inParamInvoicesSum.Value;
result.inParamIsModify = inParamIsModify == null ? false : inParamIsModify.Value;
result.inParamIsStartApproval = inParamIsStartApproval == null ? false : inParamIsStartApproval.Value;
result.inParamAccountingDataTypeId = inParamAccountingDataTypeId == null ? 0 : inParamAccountingDataTypeId.Value;
result.inParamOrderAccConceptsID = inParamOrderAccConceptsID == null ? 0L : inParamOrderAccConceptsID.Value;
result.inParamImportAnticipo = inParamImportAnticipo == null ? 0.0M : inParamImportAnticipo.Value;
result.inParamCreditNoteInvoiceId = inParamCreditNoteInvoiceId == null ? 0L : inParamCreditNoteInvoiceId.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
