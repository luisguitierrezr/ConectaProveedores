using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioCommentsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6> ScreenDataSetGetFolioCommentsByFolioId;
[JsonProperty("GetApprovalList")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259> ScreenDataSetGetApprovalList;
[JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526> ScreenDataSetGetFolioById;
[JsonProperty("GetFolioItemsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2> ScreenDataSetGetFolioItemsByFolioId;
[JsonProperty("GetFolioObservationsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b> ScreenDataSetGetFolioObservationsByFolioId;
[JsonProperty("GetOrderDetail")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9> ScreenDataSetGetOrderDetail;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> inParami_LocalSelectedLines;
[JsonProperty("l_SummaryRec")]
public ssConectaProveedores.RestRecords.RESTRC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec;
[JsonProperty("WithDatesError")]
public bool? varLcWithDatesError;
[JsonProperty("WithQuantityError")]
public bool? varLcWithQuantityError;
[JsonProperty("WithFilesError")]
public bool? varLcWithFilesError;
[JsonProperty("DatesQuantityPEPError")]
public bool? varLcDatesQuantityPEPError;
[JsonProperty("Withprorata")]
public bool? varLcWithprorata;
[JsonProperty("firstUserIdentifier")]
public string varLcfirstUserIdentifier;
[JsonProperty("Comments")]
public string varLcComments;
[JsonProperty("InvoiceToCreate")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate;
[JsonProperty("InvoiceForeignToCreate")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("FilesListExtra")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesListExtra;
[JsonProperty("ApproverValid")]
public bool? varLcApproverValid;
[JsonProperty("ApproverErrorMessage")]
public string varLcApproverErrorMessage;
[JsonProperty("MaxAmountError")]
public bool? varLcMaxAmountError;
[JsonProperty("LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> varLcLocalSelectedLines;
[JsonProperty("l_ImportAnticipo")]
public decimal? varLcl_ImportAnticipo;
[JsonProperty("CreditNoteFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcCreditNoteFilesList;
[JsonProperty("l_IsOpenPopup")]
public bool? varLcl_IsOpenPopup;
[JsonProperty("l_IsOpenPopupComment")]
public string varLcl_IsOpenPopupComment;
[JsonProperty("HaveNewFiles")]
public bool? varLcHaveNewFiles;
[JsonProperty("NewFileNamesUploaded")]
public string varLcNewFileNamesUploaded;
[JsonProperty("L_IsNational")]
public bool? varLcL_IsNational;
[JsonProperty("CreditNoteInvoiceToCreate")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate;
[JsonProperty("CreditNote_IsNeeded")]
public bool? varLcCreditNote_IsNeeded;
[JsonProperty("InvoiceExtendedToCreate")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate;
[JsonProperty("OrderAccConceptsIdToCreate")]
public long? varLcOrderAccConceptsIdToCreate;
[JsonProperty("GetOrderMainItems")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetOrderMainItems_Outputs varLcGetOrderMainItems;
[JsonProperty("GetSummary")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSummary_Outputs varLcGetSummary;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetFolioFiles")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs varLcGetFolioFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel ToModel() {long inParamFolioId = variables.inParamFolioId == null ? 0L : variables.inParamFolioId.Value;
long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
RL_123aa03224ec08dab8cbe26021987012 inParami_LocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.inParami_LocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec = ssConectaProveedores.RestRecords.RESTRC_0b2176705fa164c9531eb643caf0e9d4.ToStructure(variables.varLcl_SummaryRec);
bool varLcWithDatesError = variables.varLcWithDatesError == null ? false : variables.varLcWithDatesError.Value;
bool varLcWithQuantityError = variables.varLcWithQuantityError == null ? false : variables.varLcWithQuantityError.Value;
bool varLcWithFilesError = variables.varLcWithFilesError == null ? false : variables.varLcWithFilesError.Value;
bool varLcDatesQuantityPEPError = variables.varLcDatesQuantityPEPError == null ? false : variables.varLcDatesQuantityPEPError.Value;
bool varLcWithprorata = variables.varLcWithprorata == null ? false : variables.varLcWithprorata.Value;
string varLcfirstUserIdentifier = variables.varLcfirstUserIdentifier == null ? "" : variables.varLcfirstUserIdentifier;
string varLcComments = variables.varLcComments == null ? "" : variables.varLcComments;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcInvoiceToCreate);
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeignToCreate);
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
bool varLcApproverValid = variables.varLcApproverValid == null ? true : variables.varLcApproverValid.Value;
string varLcApproverErrorMessage = variables.varLcApproverErrorMessage == null ? "" : variables.varLcApproverErrorMessage;
bool varLcMaxAmountError = variables.varLcMaxAmountError == null ? false : variables.varLcMaxAmountError.Value;
RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.varLcLocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
decimal varLcl_ImportAnticipo = variables.varLcl_ImportAnticipo == null ? 0.0M : variables.varLcl_ImportAnticipo.Value;
RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcCreditNoteFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
bool varLcl_IsOpenPopup = variables.varLcl_IsOpenPopup == null ? false : variables.varLcl_IsOpenPopup.Value;
string varLcl_IsOpenPopupComment = variables.varLcl_IsOpenPopupComment == null ? "" : variables.varLcl_IsOpenPopupComment;
bool varLcHaveNewFiles = variables.varLcHaveNewFiles == null ? false : variables.varLcHaveNewFiles.Value;
string varLcNewFileNamesUploaded = variables.varLcNewFileNamesUploaded == null ? "" : variables.varLcNewFileNamesUploaded;
bool varLcL_IsNational = variables.varLcL_IsNational == null ? false : variables.varLcL_IsNational.Value;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcCreditNoteInvoiceToCreate);
bool varLcCreditNote_IsNeeded = variables.varLcCreditNote_IsNeeded == null ? false : variables.varLcCreditNote_IsNeeded.Value;
EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(variables.varLcInvoiceExtendedToCreate);
long varLcOrderAccConceptsIdToCreate = variables.varLcOrderAccConceptsIdToCreate == null ? 0L : variables.varLcOrderAccConceptsIdToCreate.Value;
AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> _ScreenDataSetGetFolioCommentsByFolioId = (variables.ScreenDataSetGetFolioCommentsByFolioId != null) ? variables.ScreenDataSetGetFolioCommentsByFolioId.FromJS((array) => {
return RL_5fec0894721bcc83c763c610a52bfbfd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6.ToStructure);
}
) : null;
AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> _ScreenDataSetGetApprovalList = (variables.ScreenDataSetGetApprovalList != null) ? variables.ScreenDataSetGetApprovalList.FromJS((array) => {
return RL_4d304652a66e6de5c7b4ce65fcc7c50b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259.ToStructure);
}
) : null;
AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_4f8b259bdd04db22be8fb771f1ad1d4f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526.ToStructure);
}
) : null;
AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> _ScreenDataSetGetFolioItemsByFolioId = (variables.ScreenDataSetGetFolioItemsByFolioId != null) ? variables.ScreenDataSetGetFolioItemsByFolioId.FromJS((array) => {
return RL_a968cf9f63475dc9358672149b11245a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.ToStructure);
}
) : null;
AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> _ScreenDataSetGetFolioObservationsByFolioId = (variables.ScreenDataSetGetFolioObservationsByFolioId != null) ? variables.ScreenDataSetGetFolioObservationsByFolioId.FromJS((array) => {
return RL_994583bfe1c92160ce9fe58b4f4e0d70.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b.ToStructure);
}
) : null;
AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> _ScreenDataSetGetOrderDetail = (variables.ScreenDataSetGetOrderDetail != null) ? variables.ScreenDataSetGetOrderDetail.FromJS((array) => {
return RL_398a2e7b47dcd31617b8f6499aea0bce.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetOrderMainItems_Model _varLcGetOrderMainItems = (variables.varLcGetOrderMainItems != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetOrderMainItems_Outputs.ToModel(variables.varLcGetOrderMainItems) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSummary_Model _varLcGetSummary = (variables.varLcGetSummary != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSummary_Outputs.ToModel(variables.varLcGetSummary) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Model _varLcGetFolioFiles = (variables.varLcGetFolioFiles != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs.ToModel(variables.varLcGetFolioFiles) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel(inParamFolioId, inParami_OrderId, inParami_LocalSelectedLines, varLcl_SummaryRec, varLcWithDatesError, varLcWithQuantityError, varLcWithFilesError, varLcDatesQuantityPEPError, varLcWithprorata, varLcfirstUserIdentifier, varLcComments, varLcInvoiceToCreate, varLcInvoiceForeignToCreate, varLcFilesList, varLcFilesListExtra, varLcApproverValid, varLcApproverErrorMessage, varLcMaxAmountError, varLcLocalSelectedLines, varLcl_ImportAnticipo, varLcCreditNoteFilesList, varLcl_IsOpenPopup, varLcl_IsOpenPopupComment, varLcHaveNewFiles, varLcNewFileNamesUploaded, varLcL_IsNational, varLcCreditNoteInvoiceToCreate, varLcCreditNote_IsNeeded, varLcInvoiceExtendedToCreate, varLcOrderAccConceptsIdToCreate, _ScreenDataSetGetFolioCommentsByFolioId, _ScreenDataSetGetApprovalList, _ScreenDataSetGetFolioById, _ScreenDataSetGetFolioItemsByFolioId, _ScreenDataSetGetFolioObservationsByFolioId, _ScreenDataSetGetOrderDetail, _varLcGetOrderMainItems, _varLcGetSummary, _varLcGetSettings, _varLcGetFolioFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
