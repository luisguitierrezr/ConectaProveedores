using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_UserId")]
public string inParami_UserId;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Model();
result.inParami_InvoiceId = inParami_InvoiceId == null ? 0L : inParami_InvoiceId.Value;
result.inParami_UserId = inParami_UserId == null ? "" : inParami_UserId;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
