using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Region")]
public string outParamo_Region;
[JsonProperty("o_IsCXP")]
public bool? outParamo_IsCXP;
[JsonProperty("o_CanSeeDistributionError")]
public bool? outParamo_CanSeeDistributionError;


    public static RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_Region, bool outParamo_IsCXP, bool outParamo_CanSeeDistributionError) {RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs result = new RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs();
result.outParamo_Region = outParamo_Region;
result.outParamo_IsCXP = (bool?) outParamo_IsCXP;
result.outParamo_CanSeeDistributionError = (bool?) outParamo_CanSeeDistributionError;
return result;
}


    public static ConectaProveedores_a_Common_Menu_DataActionGetUserData_Model ToModel(RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs variables) {ConectaProveedores_a_Common_Menu_DataActionGetUserData_Model result = new ConectaProveedores_a_Common_Menu_DataActionGetUserData_Model();
result.outParamo_Region = variables == null || variables.outParamo_Region == null ? "" : variables.outParamo_Region;
result.outParamo_IsCXP = variables == null || variables.outParamo_IsCXP == null ? false : variables.outParamo_IsCXP.Value;
result.outParamo_CanSeeDistributionError = variables == null || variables.outParamo_CanSeeDistributionError == null ? false : variables.outParamo_CanSeeDistributionError.Value;
return result;
}


    public static RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Common_Menu_DataActionGetUserData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs result = new RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs();
result.outParamo_Region = screenModel.outParamo_Region;
result.outParamo_IsCXP = (bool?) screenModel.outParamo_IsCXP;
result.outParamo_CanSeeDistributionError = (bool?) screenModel.outParamo_CanSeeDistributionError;
return result;
}

}
