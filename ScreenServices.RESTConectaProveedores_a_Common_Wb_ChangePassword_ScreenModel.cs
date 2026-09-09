using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserDetail")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79> ScreenDataSetGetUserDetail;
[JsonProperty("OldPassword")]
public string varLcOldPassword;
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

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel ToModel() {string varLcOldPassword = variables.varLcOldPassword == null ? "" : variables.varLcOldPassword;
string varLcNewPassword = variables.varLcNewPassword == null ? "" : variables.varLcNewPassword;
string varLcConfirmPassword = variables.varLcConfirmPassword == null ? "" : variables.varLcConfirmPassword;
bool varLcIsPasswordVisible = variables.varLcIsPasswordVisible == null ? false : variables.varLcIsPasswordVisible.Value;
bool varLcIsConfirmPasswordVisible = variables.varLcIsConfirmPasswordVisible == null ? false : variables.varLcIsConfirmPasswordVisible.Value;
bool varLcIsButtonEnabled = variables.varLcIsButtonEnabled == null ? false : variables.varLcIsButtonEnabled.Value;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
bool varLcIsNewPasswordCompliant = variables.varLcIsNewPasswordCompliant == null ? false : variables.varLcIsNewPasswordCompliant.Value;
AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> _ScreenDataSetGetUserDetail = (variables.ScreenDataSetGetUserDetail != null) ? variables.ScreenDataSetGetUserDetail.FromJS((array) => {
return RL_8430333e95ceffc00def96d8abb01f75.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79.ToStructure);
}
) : null;
ConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel screenModel = new ConectaProveedores_a_Common_Wb_ChangePassword_ScreenModel(varLcOldPassword, varLcNewPassword, varLcConfirmPassword, varLcIsPasswordVisible, varLcIsConfirmPasswordVisible, varLcIsButtonEnabled, varLcIsExecuting, varLcIsNewPasswordCompliant, _ScreenDataSetGetUserDetail, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
