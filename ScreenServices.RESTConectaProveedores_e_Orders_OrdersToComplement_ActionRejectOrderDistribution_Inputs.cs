using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersToComplement_ActionRejectOrderDistribution_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OrderId")]
public long? inParami_OrderId;


    public static RESTConectaProveedores_e_Orders_OrdersToComplement_ActionRejectOrderDistribution_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_OrdersToComplement_ActionRejectOrderDistribution_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_OrdersToComplement_ActionRejectOrderDistribution_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_OrdersToComplement_ActionRejectOrderDistribution_Model ToModel() {ConectaProveedores_e_Orders_OrdersToComplement_ActionRejectOrderDistribution_Model result = new ConectaProveedores_e_Orders_OrdersToComplement_ActionRejectOrderDistribution_Model();
result.inParami_OrderId = inParami_OrderId == null ? 0L : inParami_OrderId.Value;
return result;
}

}
