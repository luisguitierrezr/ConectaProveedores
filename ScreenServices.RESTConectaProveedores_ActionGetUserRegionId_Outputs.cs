using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ActionGetUserRegionId_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_RegionId")]
public long? outParamo_RegionId;


    public static RESTConectaProveedores_ActionGetUserRegionId_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamo_RegionId) {RESTConectaProveedores_ActionGetUserRegionId_Outputs result = new RESTConectaProveedores_ActionGetUserRegionId_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_RegionId = (long?) outParamo_RegionId;
return result;
}


    

    
}
