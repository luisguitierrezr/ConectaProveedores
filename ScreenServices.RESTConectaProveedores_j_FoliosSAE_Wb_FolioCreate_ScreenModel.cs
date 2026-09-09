using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderDetail")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9> ScreenDataSetGetOrderDetail;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> inParamLocalSelectedLines;
[JsonProperty("AprovalProcessTypeId")]
public int? inParamAprovalProcessTypeId;
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
[JsonProperty("WithFilesError")]
public bool? varLcWithFilesError;
[JsonProperty("WithProrata")]
public bool? varLcWithProrata;
[JsonProperty("ApproverValid")]
public bool? varLcApproverValid;
[JsonProperty("ApproverErrorMessage")]
public string varLcApproverErrorMessage;
[JsonProperty("firstUserIdentifier")]
public string varLcfirstUserIdentifier;
[JsonProperty("OrderAccConceptsIdToCreate")]
public long? varLcOrderAccConceptsIdToCreate;
[JsonProperty("DatesQuantityPEPError")]
public bool? varLcDatesQuantityPEPError;
[JsonProperty("MaxAmountError")]
public bool? varLcMaxAmountError;
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
[JsonProperty("CreditNoteFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcCreditNoteFilesList;
[JsonProperty("CreditNoteInvoiceToCreate")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate;
[JsonProperty("CreditNote_IsNeeded")]
public bool? varLcCreditNote_IsNeeded;
[JsonProperty("L_IsNational")]
public bool? varLcL_IsNational;
[JsonProperty("InvoiceExtendedToCreate")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate;
[JsonProperty("l_ImportAnticipo")]
public decimal? varLcl_ImportAnticipo;
[JsonProperty("GetFirstApproverList")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetFirstApproverList_Outputs varLcGetFirstApproverList;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetSummary")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSummary_Outputs varLcGetSummary;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
RL_123aa03224ec08dab8cbe26021987012 inParamLocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.inParamLocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
int inParamAprovalProcessTypeId = variables.inParamAprovalProcessTypeId == null ? 0 : variables.inParamAprovalProcessTypeId.Value;
bool varLcl_IsApplyToAll = variables.varLcl_IsApplyToAll == null ? false : variables.varLcl_IsApplyToAll.Value;
DateTime varLcDeliveryDate = variables.varLcDeliveryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcDeliveryDate);
RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec = ssConectaProveedores.RestRecords.RESTRC_0b2176705fa164c9531eb643caf0e9d4.ToStructure(variables.varLcl_SummaryRec);
bool varLcWithDatesError = variables.varLcWithDatesError == null ? false : variables.varLcWithDatesError.Value;
bool varLcWithQuantityError = variables.varLcWithQuantityError == null ? false : variables.varLcWithQuantityError.Value;
bool varLcWithFilesError = variables.varLcWithFilesError == null ? false : variables.varLcWithFilesError.Value;
bool varLcWithProrata = variables.varLcWithProrata == null ? false : variables.varLcWithProrata.Value;
bool varLcApproverValid = variables.varLcApproverValid == null ? true : variables.varLcApproverValid.Value;
string varLcApproverErrorMessage = variables.varLcApproverErrorMessage == null ? "" : variables.varLcApproverErrorMessage;
string varLcfirstUserIdentifier = variables.varLcfirstUserIdentifier == null ? "" : variables.varLcfirstUserIdentifier;
long varLcOrderAccConceptsIdToCreate = variables.varLcOrderAccConceptsIdToCreate == null ? 0L : variables.varLcOrderAccConceptsIdToCreate.Value;
bool varLcDatesQuantityPEPError = variables.varLcDatesQuantityPEPError == null ? true : variables.varLcDatesQuantityPEPError.Value;
bool varLcMaxAmountError = variables.varLcMaxAmountError == null ? false : variables.varLcMaxAmountError.Value;
string varLcComments = variables.varLcComments == null ? "" : variables.varLcComments;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcInvoiceToCreate);
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeignToCreate);
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcCreditNoteFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcCreditNoteInvoiceToCreate);
bool varLcCreditNote_IsNeeded = variables.varLcCreditNote_IsNeeded == null ? false : variables.varLcCreditNote_IsNeeded.Value;
bool varLcL_IsNational = variables.varLcL_IsNational == null ? false : variables.varLcL_IsNational.Value;
EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(variables.varLcInvoiceExtendedToCreate);
decimal varLcl_ImportAnticipo = variables.varLcl_ImportAnticipo == null ? 0.0M : variables.varLcl_ImportAnticipo.Value;
AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> _ScreenDataSetGetOrderDetail = (variables.ScreenDataSetGetOrderDetail != null) ? variables.ScreenDataSetGetOrderDetail.FromJS((array) => {
return RL_398a2e7b47dcd31617b8f6499aea0bce.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetFirstApproverList_Model _varLcGetFirstApproverList = (variables.varLcGetFirstApproverList != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetFirstApproverList_Outputs.ToModel(variables.varLcGetFirstApproverList) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSummary_Model _varLcGetSummary = (variables.varLcGetSummary != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSummary_Outputs.ToModel(variables.varLcGetSummary) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel(inParami_OrderId, inParamLocalSelectedLines, inParamAprovalProcessTypeId, varLcl_IsApplyToAll, varLcDeliveryDate, varLcl_SummaryRec, varLcWithDatesError, varLcWithQuantityError, varLcWithFilesError, varLcWithProrata, varLcApproverValid, varLcApproverErrorMessage, varLcfirstUserIdentifier, varLcOrderAccConceptsIdToCreate, varLcDatesQuantityPEPError, varLcMaxAmountError, varLcComments, varLcInvoiceToCreate, varLcInvoiceForeignToCreate, varLcFilesList, varLcFilesListExtra, varLcCreditNoteFilesList, varLcCreditNoteInvoiceToCreate, varLcCreditNote_IsNeeded, varLcL_IsNational, varLcInvoiceExtendedToCreate, varLcl_ImportAnticipo, _ScreenDataSetGetOrderDetail, _varLcGetFirstApproverList, _varLcGetSettings, _varLcGetSummary, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
