using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("IntervaltId")]
public long? varLcIntervaltId;
[JsonProperty("ShowWarning")]
public bool? varLcShowWarning;
[JsonProperty("Seconds")]
public int? varLcSeconds;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs varLcGetSettings;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel ToModel() {long varLcIntervaltId = variables.varLcIntervaltId == null ? 0L : variables.varLcIntervaltId.Value;
bool varLcShowWarning = variables.varLcShowWarning == null ? false : variables.varLcShowWarning.Value;
int varLcSeconds = variables.varLcSeconds == null ? 0 : variables.varLcSeconds.Value;
ConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel screenModel = new ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel(varLcIntervaltId, varLcShowWarning, varLcSeconds, _varLcGetSettings, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
