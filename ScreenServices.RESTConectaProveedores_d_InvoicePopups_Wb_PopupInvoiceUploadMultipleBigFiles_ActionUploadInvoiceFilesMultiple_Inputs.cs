using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ActionUploadInvoiceFilesMultiple_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
[JsonProperty("OrderMainId")]
public long? inParamOrderMainId;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("MultiUploadInvoiceFileStructList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure> inParamMultiUploadInvoiceFileStructList;
[JsonProperty("IsStartApproval")]
public bool? inParamIsStartApproval;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ActionUploadInvoiceFilesMultiple_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ActionUploadInvoiceFilesMultiple_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ActionUploadInvoiceFilesMultiple_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ActionUploadInvoiceFilesMultiple_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ActionUploadInvoiceFilesMultiple_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ActionUploadInvoiceFilesMultiple_Model();
result.inParamInvoiceId = inParamInvoiceId == null ? 0L : inParamInvoiceId.Value;
result.inParamRequisitionId = inParamRequisitionId == null ? 0L : inParamRequisitionId.Value;
result.inParamOrderMainId = inParamOrderMainId == null ? 0L : inParamOrderMainId.Value;
result.inParamFolioId = inParamFolioId == null ? 0L : inParamFolioId.Value;
result.inParamMultiUploadInvoiceFileStructList = RL_2e76d5be11218f97ffd872b5a7213337.FromRestList(inParamMultiUploadInvoiceFileStructList, ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure.ToStructure);
result.inParamIsStartApproval = inParamIsStartApproval == null ? false : inParamIsStartApproval.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
