using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_PasswordPolicy_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("Password")]
public string inParamPassword;
[JsonProperty("PasswordComplexityPolicy")]
public ssConectaProveedores.RestRecords.RESTST_0774152396050b877fe73fc0db09d4f4Structure varLcPasswordComplexityPolicy;
[JsonProperty("PasswordValidationResult")]
public ssConectaProveedores.RestRecords.RESTST_b9e6959231369ae517164f0fb8e8606dStructure varLcPasswordValidationResult;
[JsonProperty("IsValidPassword")]
public bool? varLcIsValidPassword;
[JsonProperty("IsMissingSpecialCharacter")]
public bool? varLcIsMissingSpecialCharacter;
[JsonProperty("GetMaxSavedOldPasswords")]
public RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs varLcGetMaxSavedOldPasswords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_PasswordPolicy_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_PasswordPolicy_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_PasswordPolicy_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_PasswordPolicy_ScreenModel ToModel() {string inParamPassword = variables.inParamPassword == null ? "" : variables.inParamPassword;
ST_0774152396050b877fe73fc0db09d4f4Structure varLcPasswordComplexityPolicy = ssConectaProveedores.RestRecords.RESTST_0774152396050b877fe73fc0db09d4f4Structure.ToStructure(variables.varLcPasswordComplexityPolicy);
ST_b9e6959231369ae517164f0fb8e8606dStructure varLcPasswordValidationResult = ssConectaProveedores.RestRecords.RESTST_b9e6959231369ae517164f0fb8e8606dStructure.ToStructure(variables.varLcPasswordValidationResult);
bool varLcIsValidPassword = variables.varLcIsValidPassword == null ? false : variables.varLcIsValidPassword.Value;
bool varLcIsMissingSpecialCharacter = variables.varLcIsMissingSpecialCharacter == null ? true : variables.varLcIsMissingSpecialCharacter.Value;
ConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Model _varLcGetMaxSavedOldPasswords = (variables.varLcGetMaxSavedOldPasswords != null) ? RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs.ToModel(variables.varLcGetMaxSavedOldPasswords) : null;
ConectaProveedores_a_Common_PasswordPolicy_ScreenModel screenModel = new ConectaProveedores_a_Common_PasswordPolicy_ScreenModel(inParamPassword, varLcPasswordComplexityPolicy, varLcPasswordValidationResult, varLcIsValidPassword, varLcIsMissingSpecialCharacter, _varLcGetMaxSavedOldPasswords, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
