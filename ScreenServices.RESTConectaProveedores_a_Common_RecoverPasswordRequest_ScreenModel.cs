using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("Email")]
public string varLcEmail;
[JsonProperty("IsButtonEnabled")]
public bool? varLcIsButtonEnabled;
[JsonProperty("GetSettingsEnviroment")]
public RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs varLcGetSettingsEnviroment;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel ToModel() {bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
string varLcEmail = variables.varLcEmail == null ? "" : variables.varLcEmail;
bool varLcIsButtonEnabled = variables.varLcIsButtonEnabled == null ? true : variables.varLcIsButtonEnabled.Value;
ConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Model _varLcGetSettingsEnviroment = (variables.varLcGetSettingsEnviroment != null) ? RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs.ToModel(variables.varLcGetSettingsEnviroment) : null;
ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel screenModel = new ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel(varLcIsExecuting, varLcEmail, varLcIsButtonEnabled, _varLcGetSettingsEnviroment, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
