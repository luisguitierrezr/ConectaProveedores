using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderApprovalsByOrderId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d95078dcb8f428bf6873002913f3165e> ScreenDataSetGetOrderApprovalsByOrderId;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
AggregateRecord<RL_8f94456a098435a6d91415089487edb3> _ScreenDataSetGetOrderApprovalsByOrderId = (variables.ScreenDataSetGetOrderApprovalsByOrderId != null) ? variables.ScreenDataSetGetOrderApprovalsByOrderId.FromJS((array) => {
return RL_8f94456a098435a6d91415089487edb3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d95078dcb8f428bf6873002913f3165e.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_ScreenModel(inParami_OrderId, _ScreenDataSetGetOrderApprovalsByOrderId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
