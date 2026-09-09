using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("OrderDistributionConfigId")]
public long? inParamOrderDistributionConfigId;
[JsonProperty("OrderMainId")]
public long? inParamOrderMainId;
[JsonProperty("SendEmails")]
public bool? inParamSendEmails;
[JsonProperty("UpdateOrder")]
public bool? inParamUpdateOrder;


    public static RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Inputs result = inputParameters.ToObject<RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Inputs>(settings);
return result;
}


    public ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Model ToModel() {ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Model result = new ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Model();
result.inParamOrderDistributionConfigId = inParamOrderDistributionConfigId == null ? 0L : inParamOrderDistributionConfigId.Value;
result.inParamOrderMainId = inParamOrderMainId == null ? 0L : inParamOrderMainId.Value;
result.inParamSendEmails = inParamSendEmails == null ? false : inParamSendEmails.Value;
result.inParamUpdateOrder = inParamUpdateOrder == null ? false : inParamUpdateOrder.Value;
return result;
}

}
