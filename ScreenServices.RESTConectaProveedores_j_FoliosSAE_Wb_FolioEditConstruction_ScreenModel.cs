using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioCommentsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6> ScreenDataSetGetFolioCommentsByFolioId;
[JsonProperty("GetFolioObservationsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b> ScreenDataSetGetFolioObservationsByFolioId;
[JsonProperty("GetOrderDetail")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9> ScreenDataSetGetOrderDetail;
[JsonProperty("GetApprovalList")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259> ScreenDataSetGetApprovalList;
[JsonProperty("GetFolioExtendedById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5> ScreenDataSetGetFolioExtendedById;
[JsonProperty("GetFolioItemsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2> ScreenDataSetGetFolioItemsByFolioId;
[JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526> ScreenDataSetGetFolioById;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> inParami_LocalSelectedLines;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesList;
[JsonProperty("l_IsApplyToAll")]
public bool? varLcl_IsApplyToAll;
[JsonProperty("DeliveryDate")]
public String varLcDeliveryDate;
[JsonProperty("l_SummaryRec")]
public ssConectaProveedores.RestRecords.RESTRC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec;
[JsonProperty("WithDatesError")]
public bool? varLcWithDatesError;
[JsonProperty("WithQuantityError")]
public bool? varLcWithQuantityError;
[JsonProperty("WithPaymentError")]
public bool? varLcWithPaymentError;
[JsonProperty("WithFilesError")]
public bool? varLcWithFilesError;
[JsonProperty("WithConceptMinutesError")]
public bool? varLcWithConceptMinutesError;
[JsonProperty("WithApprovalProcessError")]
public bool? varLcWithApprovalProcessError;
[JsonProperty("DatesQuantityPEPError")]
public bool? varLcDatesQuantityPEPError;
[JsonProperty("Withprorata")]
public bool? varLcWithprorata;
[JsonProperty("Comments")]
public string varLcComments;
[JsonProperty("FilesListExtra")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesListExtra;
[JsonProperty("MinuteSelected")]
public int? varLcMinuteSelected;
[JsonProperty("ConstructionStruct")]
public ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct;
[JsonProperty("MinuteDocumentTypeList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure> varLcMinuteDocumentTypeList;
[JsonProperty("MaxAmountError")]
public bool? varLcMaxAmountError;
[JsonProperty("LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> varLcLocalSelectedLines;
[JsonProperty("l_IsOpenPopup")]
public bool? varLcl_IsOpenPopup;
[JsonProperty("l_IsOpenPopupComment")]
public string varLcl_IsOpenPopupComment;
[JsonProperty("HaveNewFiles")]
public bool? varLcHaveNewFiles;
[JsonProperty("NewFileNamesUploaded")]
public string varLcNewFileNamesUploaded;
[JsonProperty("GetOrderMainItems")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetOrderMainItems_Outputs varLcGetOrderMainItems;
[JsonProperty("GetMinutes")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutes_Outputs varLcGetMinutes;
[JsonProperty("GetSummary")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetSummary_Outputs varLcGetSummary;
[JsonProperty("GetMinutesDocuments")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs varLcGetMinutesDocuments;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel ToModel() {long inParamFolioId = variables.inParamFolioId == null ? 0L : variables.inParamFolioId.Value;
long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
RL_123aa03224ec08dab8cbe26021987012 inParami_LocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.inParami_LocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.inParamFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
bool varLcl_IsApplyToAll = variables.varLcl_IsApplyToAll == null ? false : variables.varLcl_IsApplyToAll.Value;
DateTime varLcDeliveryDate = variables.varLcDeliveryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcDeliveryDate);
RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec = ssConectaProveedores.RestRecords.RESTRC_0b2176705fa164c9531eb643caf0e9d4.ToStructure(variables.varLcl_SummaryRec);
bool varLcWithDatesError = variables.varLcWithDatesError == null ? false : variables.varLcWithDatesError.Value;
bool varLcWithQuantityError = variables.varLcWithQuantityError == null ? false : variables.varLcWithQuantityError.Value;
bool varLcWithPaymentError = variables.varLcWithPaymentError == null ? false : variables.varLcWithPaymentError.Value;
bool varLcWithFilesError = variables.varLcWithFilesError == null ? false : variables.varLcWithFilesError.Value;
bool varLcWithConceptMinutesError = variables.varLcWithConceptMinutesError == null ? false : variables.varLcWithConceptMinutesError.Value;
bool varLcWithApprovalProcessError = variables.varLcWithApprovalProcessError == null ? false : variables.varLcWithApprovalProcessError.Value;
bool varLcDatesQuantityPEPError = variables.varLcDatesQuantityPEPError == null ? false : variables.varLcDatesQuantityPEPError.Value;
bool varLcWithprorata = variables.varLcWithprorata == null ? false : variables.varLcWithprorata.Value;
string varLcComments = variables.varLcComments == null ? "" : variables.varLcComments;
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
int varLcMinuteSelected = variables.varLcMinuteSelected == null ? 0 : variables.varLcMinuteSelected.Value;
RC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct = ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44.ToStructure(variables.varLcConstructionStruct);
RL_f4c5cb6ef02fae333513cbd4dafd500c varLcMinuteDocumentTypeList = RL_f4c5cb6ef02fae333513cbd4dafd500c.FromRestList(variables.varLcMinuteDocumentTypeList, ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.ToStructure);
bool varLcMaxAmountError = variables.varLcMaxAmountError == null ? false : variables.varLcMaxAmountError.Value;
RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.varLcLocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
bool varLcl_IsOpenPopup = variables.varLcl_IsOpenPopup == null ? false : variables.varLcl_IsOpenPopup.Value;
string varLcl_IsOpenPopupComment = variables.varLcl_IsOpenPopupComment == null ? "" : variables.varLcl_IsOpenPopupComment;
bool varLcHaveNewFiles = variables.varLcHaveNewFiles == null ? false : variables.varLcHaveNewFiles.Value;
string varLcNewFileNamesUploaded = variables.varLcNewFileNamesUploaded == null ? "" : variables.varLcNewFileNamesUploaded;
AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> _ScreenDataSetGetFolioCommentsByFolioId = (variables.ScreenDataSetGetFolioCommentsByFolioId != null) ? variables.ScreenDataSetGetFolioCommentsByFolioId.FromJS((array) => {
return RL_5fec0894721bcc83c763c610a52bfbfd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6.ToStructure);
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
AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> _ScreenDataSetGetApprovalList = (variables.ScreenDataSetGetApprovalList != null) ? variables.ScreenDataSetGetApprovalList.FromJS((array) => {
return RL_4d304652a66e6de5c7b4ce65fcc7c50b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259.ToStructure);
}
) : null;
AggregateRecord<RL_abf5dc59037dde79c92447e12cf9bfc9> _ScreenDataSetGetFolioExtendedById = (variables.ScreenDataSetGetFolioExtendedById != null) ? variables.ScreenDataSetGetFolioExtendedById.FromJS((array) => {
return RL_abf5dc59037dde79c92447e12cf9bfc9.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5.ToStructure);
}
) : null;
AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> _ScreenDataSetGetFolioItemsByFolioId = (variables.ScreenDataSetGetFolioItemsByFolioId != null) ? variables.ScreenDataSetGetFolioItemsByFolioId.FromJS((array) => {
return RL_a968cf9f63475dc9358672149b11245a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.ToStructure);
}
) : null;
AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_4f8b259bdd04db22be8fb771f1ad1d4f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetOrderMainItems_Model _varLcGetOrderMainItems = (variables.varLcGetOrderMainItems != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetOrderMainItems_Outputs.ToModel(variables.varLcGetOrderMainItems) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutes_Model _varLcGetMinutes = (variables.varLcGetMinutes != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutes_Outputs.ToModel(variables.varLcGetMinutes) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetSummary_Model _varLcGetSummary = (variables.varLcGetSummary != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetSummary_Outputs.ToModel(variables.varLcGetSummary) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Model _varLcGetMinutesDocuments = (variables.varLcGetMinutesDocuments != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs.ToModel(variables.varLcGetMinutesDocuments) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel(inParamFolioId, inParami_OrderId, inParami_LocalSelectedLines, inParamFilesList, varLcl_IsApplyToAll, varLcDeliveryDate, varLcl_SummaryRec, varLcWithDatesError, varLcWithQuantityError, varLcWithPaymentError, varLcWithFilesError, varLcWithConceptMinutesError, varLcWithApprovalProcessError, varLcDatesQuantityPEPError, varLcWithprorata, varLcComments, varLcFilesListExtra, varLcMinuteSelected, varLcConstructionStruct, varLcMinuteDocumentTypeList, varLcMaxAmountError, varLcLocalSelectedLines, varLcl_IsOpenPopup, varLcl_IsOpenPopupComment, varLcHaveNewFiles, varLcNewFileNamesUploaded, _ScreenDataSetGetFolioCommentsByFolioId, _ScreenDataSetGetFolioObservationsByFolioId, _ScreenDataSetGetOrderDetail, _ScreenDataSetGetApprovalList, _ScreenDataSetGetFolioExtendedById, _ScreenDataSetGetFolioItemsByFolioId, _ScreenDataSetGetFolioById, _varLcGetOrderMainItems, _varLcGetMinutes, _varLcGetSummary, _varLcGetMinutesDocuments, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
