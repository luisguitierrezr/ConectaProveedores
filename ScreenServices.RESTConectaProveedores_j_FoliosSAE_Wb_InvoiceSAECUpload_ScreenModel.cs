using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("ShowTitle")]
public bool? inParamShowTitle;
[JsonProperty("OrderId")]
public long? inParamOrderId;
[JsonProperty("IsFromFolio")]
public bool? inParamIsFromFolio;
[JsonProperty("ImportAnticipo")]
public decimal? inParamImportAnticipo;
[JsonProperty("i_IsEnable")]
public bool? inParami_IsEnable;
[JsonProperty("ErrorMsg")]
public string varLcErrorMsg;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("CreditNoteFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcCreditNoteFilesList;
[JsonProperty("IsOpenPopupForeigner")]
public bool? varLcIsOpenPopupForeigner;
[JsonProperty("InvoiceForeign")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
[JsonProperty("AccData")]
public ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcAccData;
[JsonProperty("IsUploadCreditNote")]
public bool? varLcIsUploadCreditNote;
[JsonProperty("ToStore_Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcToStore_Invoice;
[JsonProperty("ToStore_InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord varLcToStore_InvoiceExtended;
[JsonProperty("ToStore_ClaveProdServ")]
public string varLcToStore_ClaveProdServ;
[JsonProperty("ToStore_TipoDeComprobante")]
public string varLcToStore_TipoDeComprobante;
[JsonProperty("GetSupplier")]
public RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_DataActionGetSupplier_Outputs varLcGetSupplier;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel ToModel() {bool inParamShowTitle = variables.inParamShowTitle == null ? false : variables.inParamShowTitle.Value;
long inParamOrderId = variables.inParamOrderId == null ? 0L : variables.inParamOrderId.Value;
bool inParamIsFromFolio = variables.inParamIsFromFolio == null ? false : variables.inParamIsFromFolio.Value;
decimal inParamImportAnticipo = variables.inParamImportAnticipo == null ? 0.0M : variables.inParamImportAnticipo.Value;
bool inParami_IsEnable = variables.inParami_IsEnable == null ? false : variables.inParami_IsEnable.Value;
string varLcErrorMsg = variables.varLcErrorMsg == null ? "" : variables.varLcErrorMsg;
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcCreditNoteFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
bool varLcIsOpenPopupForeigner = variables.varLcIsOpenPopupForeigner == null ? false : variables.varLcIsOpenPopupForeigner.Value;
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeign);
ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcAccData = ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure.ToStructure(variables.varLcAccData);
bool varLcIsUploadCreditNote = variables.varLcIsUploadCreditNote == null ? false : variables.varLcIsUploadCreditNote.Value;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcToStore_Invoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcToStore_Invoice);
EN_f81a3d226103fd013068b8763798067aEntityRecord varLcToStore_InvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(variables.varLcToStore_InvoiceExtended);
string varLcToStore_ClaveProdServ = variables.varLcToStore_ClaveProdServ == null ? "" : variables.varLcToStore_ClaveProdServ;
string varLcToStore_TipoDeComprobante = variables.varLcToStore_TipoDeComprobante == null ? "" : variables.varLcToStore_TipoDeComprobante;
ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_DataActionGetSupplier_Model _varLcGetSupplier = (variables.varLcGetSupplier != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_DataActionGetSupplier_Outputs.ToModel(variables.varLcGetSupplier) : null;
ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel(inParamShowTitle, inParamOrderId, inParamIsFromFolio, inParamImportAnticipo, inParami_IsEnable, varLcErrorMsg, varLcFilesList, varLcCreditNoteFilesList, varLcIsOpenPopupForeigner, varLcInvoiceForeign, varLcAccData, varLcIsUploadCreditNote, varLcToStore_Invoice, varLcToStore_InvoiceExtended, varLcToStore_ClaveProdServ, varLcToStore_TipoDeComprobante, _varLcGetSupplier, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
