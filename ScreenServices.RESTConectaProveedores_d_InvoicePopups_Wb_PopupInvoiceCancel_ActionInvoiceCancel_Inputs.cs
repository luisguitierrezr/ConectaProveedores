using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_ActionInvoiceCancel_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_InvoiceApprovalLevelId")]
public long? inParami_InvoiceApprovalLevelId;
[JsonProperty("i_CancelReason")]
public string inParami_CancelReason;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_ActionInvoiceCancel_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_ActionInvoiceCancel_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_ActionInvoiceCancel_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_ActionInvoiceCancel_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_ActionInvoiceCancel_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_ActionInvoiceCancel_Model();
result.inParami_InvoiceId = inParami_InvoiceId == null ? 0L : inParami_InvoiceId.Value;
result.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId == null ? 0L : inParami_InvoiceApprovalLevelId.Value;
result.inParami_CancelReason = inParami_CancelReason == null ? "" : inParami_CancelReason;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
