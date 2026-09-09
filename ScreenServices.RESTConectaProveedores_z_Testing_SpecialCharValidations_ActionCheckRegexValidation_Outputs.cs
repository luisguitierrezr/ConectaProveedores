using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Valid")]
public ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure outParamValid;


    public static RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_b453bea0930035904f55a74692afd3a8Structure outParamValid) {RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Outputs result = new RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamValid to the result.outParamValid
result.outParamValid = new ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure();
result.outParamValid.AttrIsValid = (bool?) outParamValid.ssIsValid;
result.outParamValid.AttrValidationMessage = outParamValid.ssValidationMessage;
return result;
}


    

    
}
