using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("NewPassword")]
public string varLcNewPassword;
[JsonProperty("ConfirmPassword")]
public string varLcConfirmPassword;
[JsonProperty("IsPasswordVisible")]
public bool? varLcIsPasswordVisible;
[JsonProperty("IsConfirmPasswordVisible")]
public bool? varLcIsConfirmPasswordVisible;
[JsonProperty("IsButtonEnabled")]
public bool? varLcIsButtonEnabled;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("IsNewPasswordCompliant")]
public bool? varLcIsNewPasswordCompliant;
[JsonProperty("VerificationCode")]
public string varLcVerificationCode;
[JsonProperty("Email")]
public string varLcEmail;
[JsonProperty("GetSettingsEnviroment")]
public RESTConectaProveedores_a_Common_RecoverPasswordReset_DataActionGetSettingsEnviroment_Outputs varLcGetSettingsEnviroment;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel ToModel() {string varLcNewPassword = variables.varLcNewPassword == null ? "" : variables.varLcNewPassword;
string varLcConfirmPassword = variables.varLcConfirmPassword == null ? "" : variables.varLcConfirmPassword;
bool varLcIsPasswordVisible = variables.varLcIsPasswordVisible == null ? false : variables.varLcIsPasswordVisible.Value;
bool varLcIsConfirmPasswordVisible = variables.varLcIsConfirmPasswordVisible == null ? false : variables.varLcIsConfirmPasswordVisible.Value;
bool varLcIsButtonEnabled = variables.varLcIsButtonEnabled == null ? false : variables.varLcIsButtonEnabled.Value;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
bool varLcIsNewPasswordCompliant = variables.varLcIsNewPasswordCompliant == null ? false : variables.varLcIsNewPasswordCompliant.Value;
string varLcVerificationCode = variables.varLcVerificationCode == null ? "" : variables.varLcVerificationCode;
string varLcEmail = variables.varLcEmail == null ? "" : variables.varLcEmail;
ConectaProveedores_a_Common_RecoverPasswordReset_DataActionGetSettingsEnviroment_Model _varLcGetSettingsEnviroment = (variables.varLcGetSettingsEnviroment != null) ? RESTConectaProveedores_a_Common_RecoverPasswordReset_DataActionGetSettingsEnviroment_Outputs.ToModel(variables.varLcGetSettingsEnviroment) : null;
ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel screenModel = new ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel(varLcNewPassword, varLcConfirmPassword, varLcIsPasswordVisible, varLcIsConfirmPasswordVisible, varLcIsButtonEnabled, varLcIsExecuting, varLcIsNewPasswordCompliant, varLcVerificationCode, varLcEmail, _varLcGetSettingsEnviroment, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
