using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ActionCreatePositionContacts_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("LastPositionContractId")]
public long? outParamLastPositionContractId;


    public static RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ActionCreatePositionContacts_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamLastPositionContractId) {RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ActionCreatePositionContacts_Outputs result = new RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ActionCreatePositionContacts_Outputs();
conf.IncludeBinariesURL = false;
result.outParamLastPositionContractId = (long?) outParamLastPositionContractId;
return result;
}


    

    
}
