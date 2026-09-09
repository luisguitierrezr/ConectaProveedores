using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignOrderToUser_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_OrderApprovalLevelId")]
public long? inParami_OrderApprovalLevelId;
[JsonProperty("i_UserId")]
public string inParami_UserId;


    public static RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignOrderToUser_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignOrderToUser_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignOrderToUser_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignOrderToUser_Model ToModel() {ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignOrderToUser_Model result = new ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignOrderToUser_Model();
result.inParami_OrderId = inParami_OrderId == null ? 0L : inParami_OrderId.Value;
result.inParami_OrderApprovalLevelId = inParami_OrderApprovalLevelId == null ? 0L : inParami_OrderApprovalLevelId.Value;
result.inParami_UserId = inParami_UserId == null ? "" : inParami_UserId;
return result;
}

}
