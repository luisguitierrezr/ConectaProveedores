using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsDevEnvironment")]
public bool? outParamo_IsDevEnvironment;
[JsonProperty("o_Environment")]
public string outParamo_Environment;
[JsonProperty("o_IsActiveDEV_HU13045")]
public bool? outParamo_IsActiveDEV_HU13045;
[JsonProperty("o_IsActiveDEV_HU13046")]
public bool? outParamo_IsActiveDEV_HU13046;
[JsonProperty("o_IsActiveDEV_HU13047")]
public bool? outParamo_IsActiveDEV_HU13047;
[JsonProperty("o_IsActiveDEV_HU13048")]
public bool? outParamo_IsActiveDEV_HU13048;


    public static RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsDevEnvironment, string outParamo_Environment, bool outParamo_IsActiveDEV_HU13045, bool outParamo_IsActiveDEV_HU13046, bool outParamo_IsActiveDEV_HU13047, bool outParamo_IsActiveDEV_HU13048) {RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs result = new RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs();
// Write optimized result.outParamo_IsDevEnvironment
result.outParamo_IsDevEnvironment = (bool?) false;
result.outParamo_Environment = outParamo_Environment;
result.outParamo_IsActiveDEV_HU13045 = (bool?) outParamo_IsActiveDEV_HU13045;
result.outParamo_IsActiveDEV_HU13046 = (bool?) outParamo_IsActiveDEV_HU13046;
result.outParamo_IsActiveDEV_HU13047 = (bool?) outParamo_IsActiveDEV_HU13047;
result.outParamo_IsActiveDEV_HU13048 = (bool?) outParamo_IsActiveDEV_HU13048;
return result;
}


    public static ConectaProveedores_a_Common_Menu_DataActionGetSettings_Model ToModel(RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs variables) {ConectaProveedores_a_Common_Menu_DataActionGetSettings_Model result = new ConectaProveedores_a_Common_Menu_DataActionGetSettings_Model();
result.outParamo_IsDevEnvironment = variables == null || variables.outParamo_IsDevEnvironment == null ? false : variables.outParamo_IsDevEnvironment.Value;
result.outParamo_Environment = variables == null || variables.outParamo_Environment == null ? "" : variables.outParamo_Environment;
result.outParamo_IsActiveDEV_HU13045 = variables == null || variables.outParamo_IsActiveDEV_HU13045 == null ? false : variables.outParamo_IsActiveDEV_HU13045.Value;
result.outParamo_IsActiveDEV_HU13046 = variables == null || variables.outParamo_IsActiveDEV_HU13046 == null ? false : variables.outParamo_IsActiveDEV_HU13046.Value;
result.outParamo_IsActiveDEV_HU13047 = variables == null || variables.outParamo_IsActiveDEV_HU13047 == null ? false : variables.outParamo_IsActiveDEV_HU13047.Value;
result.outParamo_IsActiveDEV_HU13048 = variables == null || variables.outParamo_IsActiveDEV_HU13048 == null ? false : variables.outParamo_IsActiveDEV_HU13048.Value;
return result;
}


    public static RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Common_Menu_DataActionGetSettings_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs result = new RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs();
result.outParamo_IsDevEnvironment = (bool?) screenModel.outParamo_IsDevEnvironment;
result.outParamo_Environment = screenModel.outParamo_Environment;
result.outParamo_IsActiveDEV_HU13045 = (bool?) screenModel.outParamo_IsActiveDEV_HU13045;
result.outParamo_IsActiveDEV_HU13046 = (bool?) screenModel.outParamo_IsActiveDEV_HU13046;
result.outParamo_IsActiveDEV_HU13047 = (bool?) screenModel.outParamo_IsActiveDEV_HU13047;
result.outParamo_IsActiveDEV_HU13048 = (bool?) screenModel.outParamo_IsActiveDEV_HU13048;
return result;
}

}
