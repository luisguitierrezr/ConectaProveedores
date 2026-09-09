using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignBulkOrderToUser_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_UserId")]
public string inParami_UserId;
[JsonProperty("i_OrderList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e> inParami_OrderList;


    public static RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignBulkOrderToUser_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignBulkOrderToUser_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignBulkOrderToUser_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignBulkOrderToUser_Model ToModel() {ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignBulkOrderToUser_Model result = new ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ActionAssignBulkOrderToUser_Model();
result.inParami_UserId = inParami_UserId == null ? "" : inParami_UserId;
result.inParami_OrderList = RL_ae86137c3849df82f874f36658b7a66a.FromRestList(inParami_OrderList, ssConectaProveedores.RestRecords.RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e.ToStructure);
return result;
}

}
