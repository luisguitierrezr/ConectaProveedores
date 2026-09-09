using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_InvoiceApprovalLevelId")]
public long? inParami_InvoiceApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Model ToModel() {ConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Model result = new ConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Model();
result.inParami_InvoiceId = inParami_InvoiceId == null ? 0L : inParami_InvoiceId.Value;
result.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId == null ? 0L : inParami_InvoiceApprovalLevelId.Value;
result.inParami_IsApprove = inParami_IsApprove == null ? false : inParami_IsApprove.Value;
result.inParami_Comment = inParami_Comment == null ? "" : inParami_Comment;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
