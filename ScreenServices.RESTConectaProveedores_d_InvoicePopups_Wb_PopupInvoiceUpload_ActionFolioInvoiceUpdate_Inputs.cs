using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_Comments")]
public string inParami_Comments;
[JsonProperty("FilesListExtra")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesListExtra;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesList;
[JsonProperty("CreditNoteFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamCreditNoteFilesList;
[JsonProperty("InvoiceToCreate")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate;
[JsonProperty("InvoiceForeignToCreate")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate;
[JsonProperty("ImportAnticipo")]
public decimal? inParamImportAnticipo;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_UpdateComment")]
public string inParami_UpdateComment;
[JsonProperty("i_HaveNewFiles")]
public bool? inParami_HaveNewFiles;
[JsonProperty("i_NewFileNamesUploaded")]
public string inParami_NewFileNamesUploaded;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_Comments = inParami_Comments == null ? "" : inParami_Comments;
result.inParamFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamCreditNoteFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamCreditNoteFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamInvoiceToCreate = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(inParamInvoiceToCreate);
result.inParamInvoiceForeignToCreate = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(inParamInvoiceForeignToCreate);
result.inParamImportAnticipo = inParamImportAnticipo == null ? 0.0M : inParamImportAnticipo.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
result.inParami_UpdateComment = inParami_UpdateComment == null ? "" : inParami_UpdateComment;
result.inParami_HaveNewFiles = inParami_HaveNewFiles == null ? false : inParami_HaveNewFiles.Value;
result.inParami_NewFileNamesUploaded = inParami_NewFileNamesUploaded == null ? "" : inParami_NewFileNamesUploaded;
return result;
}

}
