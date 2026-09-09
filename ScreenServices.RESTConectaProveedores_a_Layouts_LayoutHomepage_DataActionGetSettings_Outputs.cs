using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsDevEnvironment")]
public bool? outParamo_IsDevEnvironment;
[JsonProperty("o_Environment")]
public string outParamo_Environment;


    public static RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsDevEnvironment, string outParamo_Environment) {RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs result = new RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs();
// Write optimized result.outParamo_IsDevEnvironment
result.outParamo_IsDevEnvironment = (bool?) false;
result.outParamo_Environment = outParamo_Environment;
return result;
}


    public static ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Model ToModel(RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs variables) {ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Model result = new ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Model();
result.outParamo_IsDevEnvironment = variables == null || variables.outParamo_IsDevEnvironment == null ? false : variables.outParamo_IsDevEnvironment.Value;
result.outParamo_Environment = variables == null || variables.outParamo_Environment == null ? "" : variables.outParamo_Environment;
return result;
}


    public static RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs result = new RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs();
result.outParamo_IsDevEnvironment = (bool?) screenModel.outParamo_IsDevEnvironment;
result.outParamo_Environment = screenModel.outParamo_Environment;
return result;
}

}
