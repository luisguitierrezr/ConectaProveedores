using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("FolioID")]
public long? inParamFolioID;
[JsonProperty("I_SelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> inParamI_SelectedLines;
[JsonProperty("I_OrderMainId")]
public long? inParamI_OrderMainId;
[JsonProperty("I_Comments")]
public string inParamI_Comments;
[JsonProperty("FilesListExtra")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesListExtra;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesList;
[JsonProperty("ApprovalProcessTypeId")]
public int? inParamApprovalProcessTypeId;
[JsonProperty("ConstructionData")]
public ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData;
[JsonProperty("i_SummaryRec")]
public ssConectaProveedores.RestRecords.RESTRC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec;
[JsonProperty("InvoiceToCreate")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate;
[JsonProperty("InvoiceForeignToCreate")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate;
[JsonProperty("CreditNoteFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamCreditNoteFilesList;
[JsonProperty("ImportAnticipo")]
public decimal? inParamImportAnticipo;
[JsonProperty("i_UpdateComment")]
public string inParami_UpdateComment;
[JsonProperty("i_HaveNewFiles")]
public bool? inParami_HaveNewFiles;
[JsonProperty("i_NewFileNamesUploaded")]
public string inParami_NewFileNamesUploaded;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Model();
result.inParamFolioID = inParamFolioID == null ? 0L : inParamFolioID.Value;
result.inParamI_SelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(inParamI_SelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
result.inParamI_OrderMainId = inParamI_OrderMainId == null ? 0L : inParamI_OrderMainId.Value;
result.inParamI_Comments = inParamI_Comments == null ? "" : inParamI_Comments;
result.inParamFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamApprovalProcessTypeId = inParamApprovalProcessTypeId == null ? 0 : inParamApprovalProcessTypeId.Value;
result.inParamConstructionData = ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44.ToStructure(inParamConstructionData);
result.inParami_SummaryRec = ssConectaProveedores.RestRecords.RESTRC_45d2d2c3c5fe5caa10fa5e20326622ac.ToStructure(inParami_SummaryRec);
result.inParamInvoiceToCreate = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(inParamInvoiceToCreate);
result.inParamInvoiceForeignToCreate = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(inParamInvoiceForeignToCreate);
result.inParamCreditNoteFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamCreditNoteFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamImportAnticipo = inParamImportAnticipo == null ? 0.0M : inParamImportAnticipo.Value;
result.inParami_UpdateComment = inParami_UpdateComment == null ? "" : inParami_UpdateComment;
result.inParami_HaveNewFiles = inParami_HaveNewFiles == null ? false : inParami_HaveNewFiles.Value;
result.inParami_NewFileNamesUploaded = inParami_NewFileNamesUploaded == null ? "" : inParami_NewFileNamesUploaded;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
