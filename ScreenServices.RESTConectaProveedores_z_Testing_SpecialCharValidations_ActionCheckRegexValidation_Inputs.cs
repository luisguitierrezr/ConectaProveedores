using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Text")]
public string inParamText;


    public static RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Inputs result = inputParameters.ToObject<RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Inputs>(settings);
return result;
}


    public ConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Model ToModel() {ConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Model result = new ConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Model();
result.inParamText = inParamText == null ? "" : inParamText;
return result;
}

}
