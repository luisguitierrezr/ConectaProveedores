using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ActionSaveAndValidateOrderDistributionConfig_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Id")]
public long? outParamId;
[JsonProperty("HasSuccess")]
public bool? outParamHasSuccess;
[JsonProperty("ErrorMessage")]
public string outParamErrorMessage;


    public static RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ActionSaveAndValidateOrderDistributionConfig_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamId, bool outParamHasSuccess, string outParamErrorMessage) {RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ActionSaveAndValidateOrderDistributionConfig_Outputs result = new RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ActionSaveAndValidateOrderDistributionConfig_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamId
result.outParamId = (long?) 0L;
result.outParamHasSuccess = (bool?) outParamHasSuccess;
result.outParamErrorMessage = outParamErrorMessage;
return result;
}


    

    
}
