using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ActionFolioCreate_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("I_SelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> inParamI_SelectedLines;
[JsonProperty("I_OrderMainId")]
public long? inParamI_OrderMainId;
[JsonProperty("I_FirstApprovalId")]
public string inParamI_FirstApprovalId;
[JsonProperty("I_Comments")]
public string inParamI_Comments;
[JsonProperty("InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord inParamInvoiceExtended;
[JsonProperty("FilesListExtra")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesListExtra;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesList;
[JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("InvoiceForeignToCreate")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate;
[JsonProperty("ApprovalProcessTypeId")]
public int? inParamApprovalProcessTypeId;
[JsonProperty("ConstructionData")]
public ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData;
[JsonProperty("ApprovalProcessId")]
public long? inParamApprovalProcessId;
[JsonProperty("i_SummaryRec")]
public ssConectaProveedores.RestRecords.RESTRC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec;
[JsonProperty("i_IsMassCreate")]
public bool? inParami_IsMassCreate;
[JsonProperty("i_MinuteSelected")]
public int? inParami_MinuteSelected;
[JsonProperty("i_OrderAccConceptID")]
public long? inParami_OrderAccConceptID;
[JsonProperty("CreditNoteFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamCreditNoteFilesList;
[JsonProperty("ImportAnticipo")]
public decimal? inParamImportAnticipo;
[JsonProperty("IsNational")]
public bool? inParamIsNational;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ActionFolioCreate_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ActionFolioCreate_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ActionFolioCreate_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ActionFolioCreate_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ActionFolioCreate_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ActionFolioCreate_Model();
result.inParamI_SelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(inParamI_SelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
result.inParamI_OrderMainId = inParamI_OrderMainId == null ? 0L : inParamI_OrderMainId.Value;
result.inParamI_FirstApprovalId = inParamI_FirstApprovalId == null ? "" : inParamI_FirstApprovalId;
result.inParamI_Comments = inParamI_Comments == null ? "" : inParamI_Comments;
result.inParamInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(inParamInvoiceExtended);
result.inParamFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamInvoiceId = inParamInvoiceId == null ? 0L : inParamInvoiceId.Value;
result.inParamInvoiceForeignToCreate = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(inParamInvoiceForeignToCreate);
result.inParamApprovalProcessTypeId = inParamApprovalProcessTypeId == null ? 0 : inParamApprovalProcessTypeId.Value;
result.inParamConstructionData = ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44.ToStructure(inParamConstructionData);
result.inParamApprovalProcessId = inParamApprovalProcessId == null ? 0L : inParamApprovalProcessId.Value;
result.inParami_SummaryRec = ssConectaProveedores.RestRecords.RESTRC_45d2d2c3c5fe5caa10fa5e20326622ac.ToStructure(inParami_SummaryRec);
result.inParami_IsMassCreate = inParami_IsMassCreate == null ? false : inParami_IsMassCreate.Value;
result.inParami_MinuteSelected = inParami_MinuteSelected == null ? 0 : inParami_MinuteSelected.Value;
result.inParami_OrderAccConceptID = inParami_OrderAccConceptID == null ? 0L : inParami_OrderAccConceptID.Value;
result.inParamCreditNoteFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamCreditNoteFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamImportAnticipo = inParamImportAnticipo == null ? 0.0M : inParamImportAnticipo.Value;
result.inParamIsNational = inParamIsNational == null ? false : inParamIsNational.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
