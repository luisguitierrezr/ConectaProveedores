using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserExtendedInternals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_82a9276cec67a3d539884db9fd67d1e2> ScreenDataSetGetUserExtendedInternals;
[JsonProperty("IsResetPassword")]
public bool? inParamIsResetPassword;
[JsonProperty("UserEmail")]
public string varLcUserEmail;
[JsonProperty("Password")]
public string varLcPassword;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("MakePasswordVisible")]
public bool? varLcMakePasswordVisible;
[JsonProperty("RememberMe")]
public bool? varLcRememberMe;
[JsonProperty("IsEnabled")]
public bool? varLcIsEnabled;
[JsonProperty("ShowSelectUserPopup")]
public bool? varLcShowSelectUserPopup;
[JsonProperty("Step")]
public int? varLcStep;
[JsonProperty("UserCode")]
public string varLcUserCode;
[JsonProperty("IsEnabledCode")]
public bool? varLcIsEnabledCode;
[JsonProperty("IsExecutingCodeRequest")]
public bool? varLcIsExecutingCodeRequest;
[JsonProperty("UserExternalEmail")]
public string varLcUserExternalEmail;
[JsonProperty("RegionToBeAssign")]
public string varLcRegionToBeAssign;
[JsonProperty("Msg")]
public string varLcMsg;
[JsonProperty("Get2FA")]
public RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs varLcGet2FA;
[JsonProperty("GetSettingsEnviroment")]
public RESTConectaProveedores_a_Common_Login_DataActionGetSettingsEnviroment_Outputs varLcGetSettingsEnviroment;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_Login_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Login_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_Login_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ScreenModel ToModel() {bool inParamIsResetPassword = variables.inParamIsResetPassword == null ? false : variables.inParamIsResetPassword.Value;
string varLcUserEmail = variables.varLcUserEmail == null ? "" : variables.varLcUserEmail;
string varLcPassword = variables.varLcPassword == null ? "" : variables.varLcPassword;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
bool varLcMakePasswordVisible = variables.varLcMakePasswordVisible == null ? false : variables.varLcMakePasswordVisible.Value;
bool varLcRememberMe = variables.varLcRememberMe == null ? false : variables.varLcRememberMe.Value;
bool varLcIsEnabled = variables.varLcIsEnabled == null ? true : variables.varLcIsEnabled.Value;
bool varLcShowSelectUserPopup = variables.varLcShowSelectUserPopup == null ? false : variables.varLcShowSelectUserPopup.Value;
int varLcStep = variables.varLcStep == null ? 1 : variables.varLcStep.Value;
string varLcUserCode = variables.varLcUserCode == null ? "" : variables.varLcUserCode;
bool varLcIsEnabledCode = variables.varLcIsEnabledCode == null ? true : variables.varLcIsEnabledCode.Value;
bool varLcIsExecutingCodeRequest = variables.varLcIsExecutingCodeRequest == null ? false : variables.varLcIsExecutingCodeRequest.Value;
string varLcUserExternalEmail = variables.varLcUserExternalEmail == null ? "" : variables.varLcUserExternalEmail;
string varLcRegionToBeAssign = variables.varLcRegionToBeAssign == null ? "" : variables.varLcRegionToBeAssign;
string varLcMsg = variables.varLcMsg == null ? "" : variables.varLcMsg;
AggregateRecord<RL_e8fb9c349f962da0bba19bd202a05712> _ScreenDataSetGetUserExtendedInternals = (variables.ScreenDataSetGetUserExtendedInternals != null) ? variables.ScreenDataSetGetUserExtendedInternals.FromJS((array) => {
return RL_e8fb9c349f962da0bba19bd202a05712.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_82a9276cec67a3d539884db9fd67d1e2.ToStructure);
}
) : null;
ConectaProveedores_a_Common_Login_DataActionGet2FA_Model _varLcGet2FA = (variables.varLcGet2FA != null) ? RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs.ToModel(variables.varLcGet2FA) : null;
ConectaProveedores_a_Common_Login_DataActionGetSettingsEnviroment_Model _varLcGetSettingsEnviroment = (variables.varLcGetSettingsEnviroment != null) ? RESTConectaProveedores_a_Common_Login_DataActionGetSettingsEnviroment_Outputs.ToModel(variables.varLcGetSettingsEnviroment) : null;
ConectaProveedores_a_Common_Login_ScreenModel screenModel = new ConectaProveedores_a_Common_Login_ScreenModel(inParamIsResetPassword, varLcUserEmail, varLcPassword, varLcIsExecuting, varLcMakePasswordVisible, varLcRememberMe, varLcIsEnabled, varLcShowSelectUserPopup, varLcStep, varLcUserCode, varLcIsEnabledCode, varLcIsExecutingCodeRequest, varLcUserExternalEmail, varLcRegionToBeAssign, varLcMsg, _ScreenDataSetGetUserExtendedInternals, _varLcGet2FA, _varLcGetSettingsEnviroment, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
