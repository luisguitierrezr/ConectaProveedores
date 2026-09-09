using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsDevEnvironment")]
public bool? outParamIsDevEnvironment;
[JsonProperty("Environment")]
public string outParamEnvironment;


    public static RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsDevEnvironment, string outParamEnvironment) {RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs result = new RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs();
// Write optimized result.outParamIsDevEnvironment
result.outParamIsDevEnvironment = (bool?) false;
result.outParamEnvironment = outParamEnvironment;
return result;
}


    public static ConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Model ToModel(RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs variables) {ConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Model result = new ConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Model();
result.outParamIsDevEnvironment = variables == null || variables.outParamIsDevEnvironment == null ? false : variables.outParamIsDevEnvironment.Value;
result.outParamEnvironment = variables == null || variables.outParamEnvironment == null ? "" : variables.outParamEnvironment;
return result;
}


    public static RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs result = new RESTConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Outputs();
result.outParamIsDevEnvironment = (bool?) screenModel.outParamIsDevEnvironment;
result.outParamEnvironment = screenModel.outParamEnvironment;
return result;
}

}
