using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Found")]
public bool? outParamFound;
[JsonProperty("PatternResult")]
public string outParamPatternResult;
[JsonProperty("FirstIndex")]
public int? outParamFirstIndex;


    public static RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamFound, string outParamPatternResult, int outParamFirstIndex) {RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Outputs result = new RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Outputs();
conf.IncludeBinariesURL = false;
result.outParamFound = (bool?) outParamFound;
// Write optimized result.outParamPatternResult
result.outParamPatternResult = "";
// Write optimized result.outParamFirstIndex
result.outParamFirstIndex = (int?) 0;
return result;
}


    

    
}
