using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetApprovalList")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259> ScreenDataSetGetApprovalList;
[JsonProperty("GetOrderDetail")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9> ScreenDataSetGetOrderDetail;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("ApplicantId")]
public long? inParamApplicantId;
[JsonProperty("LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> inParamLocalSelectedLines;
[JsonProperty("l_IsApplyToAll")]
public bool? varLcl_IsApplyToAll;
[JsonProperty("DeliveryDate")]
public String varLcDeliveryDate;
[JsonProperty("l_SummaryRec")]
public ssConectaProveedores.RestRecords.RESTRC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec;
[JsonProperty("MaxAmountError")]
public bool? varLcMaxAmountError;
[JsonProperty("DatesQuantityPEPError")]
public bool? varLcDatesQuantityPEPError;
[JsonProperty("WithFilesError")]
public bool? varLcWithFilesError;
[JsonProperty("WithDatesError")]
public bool? varLcWithDatesError;
[JsonProperty("WithQuantityError")]
public bool? varLcWithQuantityError;
[JsonProperty("WithPaymentError")]
public bool? varLcWithPaymentError;
[JsonProperty("WithConceptMinutesError")]
public bool? varLcWithConceptMinutesError;
[JsonProperty("WithApprovalProcessError")]
public bool? varLcWithApprovalProcessError;
[JsonProperty("Withprorata")]
public bool? varLcWithprorata;
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
[JsonProperty("MinuteSelected")]
public int? varLcMinuteSelected;
[JsonProperty("ConstructionStruct")]
public ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct;
[JsonProperty("MinuteDocumentTypeList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure> varLcMinuteDocumentTypeList;
[JsonProperty("l_ApprovalProcessId")]
public long? varLcl_ApprovalProcessId;
[JsonProperty("GetMinutes")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutes_Outputs varLcGetMinutes;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetSummary")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSummary_Outputs varLcGetSummary;
[JsonProperty("GetMinutesDocuments")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs varLcGetMinutesDocuments;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
long inParamApplicantId = variables.inParamApplicantId == null ? 0L : variables.inParamApplicantId.Value;
RL_123aa03224ec08dab8cbe26021987012 inParamLocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.inParamLocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
bool varLcl_IsApplyToAll = variables.varLcl_IsApplyToAll == null ? false : variables.varLcl_IsApplyToAll.Value;
DateTime varLcDeliveryDate = variables.varLcDeliveryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcDeliveryDate);
RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec = ssConectaProveedores.RestRecords.RESTRC_0b2176705fa164c9531eb643caf0e9d4.ToStructure(variables.varLcl_SummaryRec);
bool varLcMaxAmountError = variables.varLcMaxAmountError == null ? false : variables.varLcMaxAmountError.Value;
bool varLcDatesQuantityPEPError = variables.varLcDatesQuantityPEPError == null ? true : variables.varLcDatesQuantityPEPError.Value;
bool varLcWithFilesError = variables.varLcWithFilesError == null ? false : variables.varLcWithFilesError.Value;
bool varLcWithDatesError = variables.varLcWithDatesError == null ? false : variables.varLcWithDatesError.Value;
bool varLcWithQuantityError = variables.varLcWithQuantityError == null ? false : variables.varLcWithQuantityError.Value;
bool varLcWithPaymentError = variables.varLcWithPaymentError == null ? false : variables.varLcWithPaymentError.Value;
bool varLcWithConceptMinutesError = variables.varLcWithConceptMinutesError == null ? false : variables.varLcWithConceptMinutesError.Value;
bool varLcWithApprovalProcessError = variables.varLcWithApprovalProcessError == null ? false : variables.varLcWithApprovalProcessError.Value;
bool varLcWithprorata = variables.varLcWithprorata == null ? false : variables.varLcWithprorata.Value;
string varLcComments = variables.varLcComments == null ? "" : variables.varLcComments;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcInvoiceToCreate);
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeignToCreate);
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
int varLcMinuteSelected = variables.varLcMinuteSelected == null ? 0 : variables.varLcMinuteSelected.Value;
RC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct = ssConectaProveedores.RestRecords.RESTRC_1c2482ce6cd4b83ca44ec0510b231d44.ToStructure(variables.varLcConstructionStruct);
RL_f4c5cb6ef02fae333513cbd4dafd500c varLcMinuteDocumentTypeList = RL_f4c5cb6ef02fae333513cbd4dafd500c.FromRestList(variables.varLcMinuteDocumentTypeList, ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.ToStructure);
long varLcl_ApprovalProcessId = variables.varLcl_ApprovalProcessId == null ? 0L : variables.varLcl_ApprovalProcessId.Value;
AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> _ScreenDataSetGetApprovalList = (variables.ScreenDataSetGetApprovalList != null) ? variables.ScreenDataSetGetApprovalList.FromJS((array) => {
return RL_4d304652a66e6de5c7b4ce65fcc7c50b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259.ToStructure);
}
) : null;
AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> _ScreenDataSetGetOrderDetail = (variables.ScreenDataSetGetOrderDetail != null) ? variables.ScreenDataSetGetOrderDetail.FromJS((array) => {
return RL_398a2e7b47dcd31617b8f6499aea0bce.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutes_Model _varLcGetMinutes = (variables.varLcGetMinutes != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutes_Outputs.ToModel(variables.varLcGetMinutes) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSummary_Model _varLcGetSummary = (variables.varLcGetSummary != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSummary_Outputs.ToModel(variables.varLcGetSummary) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Model _varLcGetMinutesDocuments = (variables.varLcGetMinutesDocuments != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs.ToModel(variables.varLcGetMinutesDocuments) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel(inParami_OrderId, inParamApplicantId, inParamLocalSelectedLines, varLcl_IsApplyToAll, varLcDeliveryDate, varLcl_SummaryRec, varLcMaxAmountError, varLcDatesQuantityPEPError, varLcWithFilesError, varLcWithDatesError, varLcWithQuantityError, varLcWithPaymentError, varLcWithConceptMinutesError, varLcWithApprovalProcessError, varLcWithprorata, varLcComments, varLcInvoiceToCreate, varLcInvoiceForeignToCreate, varLcFilesList, varLcFilesListExtra, varLcMinuteSelected, varLcConstructionStruct, varLcMinuteDocumentTypeList, varLcl_ApprovalProcessId, _ScreenDataSetGetApprovalList, _ScreenDataSetGetOrderDetail, _varLcGetMinutes, _varLcGetSettings, _varLcGetSummary, _varLcGetMinutesDocuments, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
