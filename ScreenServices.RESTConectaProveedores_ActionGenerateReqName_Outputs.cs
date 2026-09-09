using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ActionGenerateReqName_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Name")]
public string outParamo_Name;
[JsonProperty("o_Counter")]
public int? outParamo_Counter;


    public static RESTConectaProveedores_ActionGenerateReqName_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_Name, int outParamo_Counter) {RESTConectaProveedores_ActionGenerateReqName_Outputs result = new RESTConectaProveedores_ActionGenerateReqName_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_Name = outParamo_Name;
result.outParamo_Counter = (int?) outParamo_Counter;
return result;
}


    

    
}
