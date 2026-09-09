using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoicesByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_426e2c309e94de792ac54a8e3665e09a> ScreenDataSetGetInvoicesByFolioId;
[JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f049d8b2272822e744e04ef94d71a8ef> ScreenDataSetGetFolioById;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("IsReadOnly")]
public bool? inParamIsReadOnly;
[JsonProperty("l_CanUploadInvoice")]
public bool? varLcl_CanUploadInvoice;
[JsonProperty("l_IsOpenPopupInvoices")]
public bool? varLcl_IsOpenPopupInvoices;
[JsonProperty("l_InvoiceIdToPopup")]
public long? varLcl_InvoiceIdToPopup;
[JsonProperty("l_InvoiceStatusIdToPopup")]
public int? varLcl_InvoiceStatusIdToPopup;
[JsonProperty("l_CreditNoteInvoiceIdToPopup")]
public long? varLcl_CreditNoteInvoiceIdToPopup;
[JsonProperty("l_ImportAnticipo")]
public decimal? varLcl_ImportAnticipo;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
bool inParamIsReadOnly = variables.inParamIsReadOnly == null ? false : variables.inParamIsReadOnly.Value;
bool varLcl_CanUploadInvoice = variables.varLcl_CanUploadInvoice == null ? true : variables.varLcl_CanUploadInvoice.Value;
bool varLcl_IsOpenPopupInvoices = variables.varLcl_IsOpenPopupInvoices == null ? false : variables.varLcl_IsOpenPopupInvoices.Value;
long varLcl_InvoiceIdToPopup = variables.varLcl_InvoiceIdToPopup == null ? 0L : variables.varLcl_InvoiceIdToPopup.Value;
int varLcl_InvoiceStatusIdToPopup = variables.varLcl_InvoiceStatusIdToPopup == null ? 0 : variables.varLcl_InvoiceStatusIdToPopup.Value;
long varLcl_CreditNoteInvoiceIdToPopup = variables.varLcl_CreditNoteInvoiceIdToPopup == null ? 0L : variables.varLcl_CreditNoteInvoiceIdToPopup.Value;
decimal varLcl_ImportAnticipo = variables.varLcl_ImportAnticipo == null ? 0.0M : variables.varLcl_ImportAnticipo.Value;
AggregateRecord<RL_963435a7e2b76a25c650ba38c8633cf8> _ScreenDataSetGetInvoicesByFolioId = (variables.ScreenDataSetGetInvoicesByFolioId != null) ? variables.ScreenDataSetGetInvoicesByFolioId.FromJS((array) => {
return RL_963435a7e2b76a25c650ba38c8633cf8.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_426e2c309e94de792ac54a8e3665e09a.ToStructure);
}
) : null;
AggregateRecord<RL_66bb1349260f72f9d01bbe22c0aaf421> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_66bb1349260f72f9d01bbe22c0aaf421.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f049d8b2272822e744e04ef94d71a8ef.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel(inParami_FolioId, inParamIsReadOnly, varLcl_CanUploadInvoice, varLcl_IsOpenPopupInvoices, varLcl_InvoiceIdToPopup, varLcl_InvoiceStatusIdToPopup, varLcl_CreditNoteInvoiceIdToPopup, varLcl_ImportAnticipo, _ScreenDataSetGetInvoicesByFolioId, _ScreenDataSetGetFolioById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
