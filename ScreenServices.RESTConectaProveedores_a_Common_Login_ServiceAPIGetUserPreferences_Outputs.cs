using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_TableLinesCount")]
public int? outParamo_TableLinesCount;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Outputs FromOutputs(IBehaviorsConfiguration conf, int outParamo_TableLinesCount) {RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Outputs result = new RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_TableLinesCount = (int?) outParamo_TableLinesCount;
return result;
}


    

    
}
