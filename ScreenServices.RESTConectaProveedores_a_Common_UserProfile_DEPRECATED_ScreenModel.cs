using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserDetails")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79> ScreenDataSetGetUserDetails;
[JsonProperty("GetApplicationRoles")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c2921a936d592680b8275006015423c4> ScreenDataSetGetApplicationRoles;
[JsonProperty("OldName")]
public string varLcOldName;
[JsonProperty("OldEmail")]
public string varLcOldEmail;
[JsonProperty("OldPhotoURL")]
public string varLcOldPhotoURL;
[JsonProperty("IsExternal")]
public bool? varLcIsExternal;
[JsonProperty("VerificationCode")]
public string varLcVerificationCode;
[JsonProperty("ShowVerificationCode")]
public bool? varLcShowVerificationCode;
[JsonProperty("ShowGetCodeButton")]
public bool? varLcShowGetCodeButton;
[JsonProperty("CountdownValue")]
public int? varLcCountdownValue;
[JsonProperty("TimerIntervalHandle")]
public String varLcTimerIntervalHandle;
[JsonProperty("IsButtonEnabled")]
public bool? varLcIsButtonEnabled;
[JsonProperty("IntervalDuration")]
public int? varLcIntervalDuration;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("IsExecuting_GetCode")]
public bool? varLcIsExecuting_GetCode;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel ToModel() {string varLcOldName = variables.varLcOldName == null ? "" : variables.varLcOldName;
string varLcOldEmail = variables.varLcOldEmail == null ? "" : variables.varLcOldEmail;
string varLcOldPhotoURL = variables.varLcOldPhotoURL == null ? "" : variables.varLcOldPhotoURL;
bool varLcIsExternal = variables.varLcIsExternal == null ? false : variables.varLcIsExternal.Value;
string varLcVerificationCode = variables.varLcVerificationCode == null ? "" : variables.varLcVerificationCode;
bool varLcShowVerificationCode = variables.varLcShowVerificationCode == null ? false : variables.varLcShowVerificationCode.Value;
bool varLcShowGetCodeButton = variables.varLcShowGetCodeButton == null ? false : variables.varLcShowGetCodeButton.Value;
int varLcCountdownValue = variables.varLcCountdownValue == null ? 0 : variables.varLcCountdownValue.Value;
object varLcTimerIntervalHandle = (Object)variables.varLcTimerIntervalHandle;
bool varLcIsButtonEnabled = variables.varLcIsButtonEnabled == null ? false : variables.varLcIsButtonEnabled.Value;
int varLcIntervalDuration = variables.varLcIntervalDuration == null ? 1000 : variables.varLcIntervalDuration.Value;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
bool varLcIsExecuting_GetCode = variables.varLcIsExecuting_GetCode == null ? false : variables.varLcIsExecuting_GetCode.Value;
AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> _ScreenDataSetGetUserDetails = (variables.ScreenDataSetGetUserDetails != null) ? variables.ScreenDataSetGetUserDetails.FromJS((array) => {
return RL_8430333e95ceffc00def96d8abb01f75.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79.ToStructure);
}
) : null;
AggregateRecord<RL_6baa91071578818b75d38b8795012b73> _ScreenDataSetGetApplicationRoles = (variables.ScreenDataSetGetApplicationRoles != null) ? variables.ScreenDataSetGetApplicationRoles.FromJS((array) => {
return RL_6baa91071578818b75d38b8795012b73.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c2921a936d592680b8275006015423c4.ToStructure);
}
) : null;
ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel screenModel = new ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel(varLcOldName, varLcOldEmail, varLcOldPhotoURL, varLcIsExternal, varLcVerificationCode, varLcShowVerificationCode, varLcShowGetCodeButton, varLcCountdownValue, varLcTimerIntervalHandle, varLcIsButtonEnabled, varLcIntervalDuration, varLcIsExecuting, varLcIsExecuting_GetCode, _ScreenDataSetGetUserDetails, _ScreenDataSetGetApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
