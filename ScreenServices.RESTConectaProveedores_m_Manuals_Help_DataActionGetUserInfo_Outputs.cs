using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsAreaCxP")]
public bool? outParamIsAreaCxP;


    public static RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsAreaCxP) {RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs result = new RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs();
result.outParamIsAreaCxP = (bool?) outParamIsAreaCxP;
return result;
}


    public static ConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Model ToModel(RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs variables) {ConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Model result = new ConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Model();
result.outParamIsAreaCxP = variables == null || variables.outParamIsAreaCxP == null ? false : variables.outParamIsAreaCxP.Value;
return result;
}


    public static RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs result = new RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs();
result.outParamIsAreaCxP = (bool?) screenModel.outParamIsAreaCxP;
return result;
}

}
