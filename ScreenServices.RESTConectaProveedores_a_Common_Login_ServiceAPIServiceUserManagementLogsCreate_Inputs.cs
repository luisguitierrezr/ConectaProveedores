using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserId")]
public string inParamUserId;
[JsonProperty("Message")]
public string inParamMessage;
[JsonProperty("IpAddress")]
public string inParamIpAddress;
[JsonProperty("Screen")]
public string inParamScreen;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Model ToModel() {ConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Model result = new ConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Model();
result.inParamUserId = inParamUserId == null ? "" : inParamUserId;
result.inParamMessage = inParamMessage == null ? "" : inParamMessage;
result.inParamIpAddress = inParamIpAddress == null ? "" : inParamIpAddress;
result.inParamScreen = inParamScreen == null ? "" : inParamScreen;
return result;
}

}
