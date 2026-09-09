using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_ActionInvoiceCommentBulk_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_InvoiceList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_c45ce7ee0ff58d891b8d78c9e2e835ad> inParami_InvoiceList;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_ActionInvoiceCommentBulk_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_ActionInvoiceCommentBulk_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_ActionInvoiceCommentBulk_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_ActionInvoiceCommentBulk_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_ActionInvoiceCommentBulk_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_ActionInvoiceCommentBulk_Model();
result.inParami_InvoiceList = RL_12444f18cbf938e5a637c66b266df871.FromRestList(inParami_InvoiceList, ssConectaProveedores.RestRecords.RESTRC_c45ce7ee0ff58d891b8d78c9e2e835ad.ToStructure);
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
