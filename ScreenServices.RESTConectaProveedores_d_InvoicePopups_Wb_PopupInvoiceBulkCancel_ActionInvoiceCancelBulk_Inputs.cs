using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_ActionInvoiceCancelBulk_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_InvoiceList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_3797d4971af6bc97d739ac602330acb1> inParami_InvoiceList;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_ActionInvoiceCancelBulk_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_ActionInvoiceCancelBulk_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_ActionInvoiceCancelBulk_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_ActionInvoiceCancelBulk_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_ActionInvoiceCancelBulk_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_ActionInvoiceCancelBulk_Model();
result.inParami_InvoiceList = RL_0bff49813ef08eecaf6190c2661eb115.FromRestList(inParami_InvoiceList, ssConectaProveedores.RestRecords.RESTRC_3797d4971af6bc97d739ac602330acb1.ToStructure);
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
