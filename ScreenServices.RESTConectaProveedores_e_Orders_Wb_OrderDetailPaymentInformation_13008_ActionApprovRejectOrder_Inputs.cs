using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionApprovRejectOrder_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_OrderApprovalLevelId")]
public long? inParami_OrderApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Reason")]
public string inParami_Reason;


    public static RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionApprovRejectOrder_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionApprovRejectOrder_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionApprovRejectOrder_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionApprovRejectOrder_Model ToModel() {ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionApprovRejectOrder_Model result = new ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionApprovRejectOrder_Model();
result.inParami_OrderId = inParami_OrderId == null ? 0L : inParami_OrderId.Value;
result.inParami_OrderApprovalLevelId = inParami_OrderApprovalLevelId == null ? 0L : inParami_OrderApprovalLevelId.Value;
result.inParami_IsApprove = inParami_IsApprove == null ? false : inParami_IsApprove.Value;
result.inParami_Reason = inParami_Reason == null ? "" : inParami_Reason;
return result;
}

}
