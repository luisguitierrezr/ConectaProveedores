using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Text")]
public string inParamText;
[JsonProperty("RegexPattern")]
public string inParamRegexPattern;
[JsonProperty("IgnoreCase")]
public bool? inParamIgnoreCase;
[JsonProperty("MultiLine")]
public bool? inParamMultiLine;
[JsonProperty("SingleLine")]
public bool? inParamSingleLine;


    public static RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Model ToModel() {ConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Model result = new ConectaProveedores_a_Common_PasswordPolicy_ActionRegex_Search_Model();
result.inParamText = inParamText == null ? "" : inParamText;
result.inParamRegexPattern = inParamRegexPattern == null ? "" : inParamRegexPattern;
result.inParamIgnoreCase = inParamIgnoreCase == null ? true : inParamIgnoreCase.Value;
result.inParamMultiLine = inParamMultiLine == null ? false : inParamMultiLine.Value;
result.inParamSingleLine = inParamSingleLine == null ? false : inParamSingleLine.Value;
return result;
}

}
