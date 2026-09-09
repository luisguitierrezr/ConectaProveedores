using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Result")]
public ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult;
[JsonProperty("PositionFirstContactId")]
public long? outParamPositionFirstContactId;


    public static RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult, long outParamPositionFirstContactId) {RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Outputs result = new RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamResult to the result.outParamResult
result.outParamResult = new ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure();
// Write optimized result.outParamResult.AttrIdentifier
result.outParamResult.AttrIdentifier = (long?) 0L;
result.outParamResult.AttrHasSuccess = (bool?) outParamResult.ssHasSuccess;
result.outParamResult.AttrErrorMessage = outParamResult.ssErrorMessage;
// Write optimized result.outParamPositionFirstContactId
result.outParamPositionFirstContactId = (long?) 0L;
return result;
}


    

    
}
