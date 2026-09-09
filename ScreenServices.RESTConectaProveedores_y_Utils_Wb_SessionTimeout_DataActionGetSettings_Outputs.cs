using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("WarningTime")]
public String outParamWarningTime;
[JsonProperty("LogoutTime")]
public String outParamLogoutTime;
[JsonProperty("WarningMinutes")]
public int? outParamWarningMinutes;
[JsonProperty("LogoutMinutes")]
public int? outParamLogoutMinutes;


    public static RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, DateTime outParamWarningTime, DateTime outParamLogoutTime, int outParamWarningMinutes, int outParamLogoutMinutes) {RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs result = new RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs();
result.outParamWarningTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamWarningTime, conf.DateTimeFormat);
result.outParamLogoutTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamLogoutTime, conf.DateTimeFormat);
result.outParamWarningMinutes = (int?) outParamWarningMinutes;
result.outParamLogoutMinutes = (int?) outParamLogoutMinutes;
return result;
}


    public static ConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Model ToModel(RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs variables) {ConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Model result = new ConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Model();
result.outParamWarningTime = variables == null || variables.outParamWarningTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.outParamWarningTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
result.outParamLogoutTime = variables == null || variables.outParamLogoutTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.outParamLogoutTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
result.outParamWarningMinutes = variables == null || variables.outParamWarningMinutes == null ? 0 : variables.outParamWarningMinutes.Value;
result.outParamLogoutMinutes = variables == null || variables.outParamLogoutMinutes == null ? 0 : variables.outParamLogoutMinutes.Value;
return result;
}


    public static RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs result = new RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs();
result.outParamWarningTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(screenModel.outParamWarningTime, conf.DateTimeFormat);
result.outParamLogoutTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(screenModel.outParamLogoutTime, conf.DateTimeFormat);
result.outParamWarningMinutes = (int?) screenModel.outParamWarningMinutes;
result.outParamLogoutMinutes = (int?) screenModel.outParamLogoutMinutes;
return result;
}

}
