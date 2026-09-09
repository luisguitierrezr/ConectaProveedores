using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ManagerName")]
public string outParamManagerName;


    public static RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamManagerName) {RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs result = new RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs();
result.outParamManagerName = outParamManagerName;
return result;
}


    public static ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Model ToModel(RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs variables) {ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Model result = new ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Model();
result.outParamManagerName = variables == null || variables.outParamManagerName == null ? "" : variables.outParamManagerName;
return result;
}


    public static RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs result = new RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs();
result.outParamManagerName = screenModel.outParamManagerName;
return result;
}

}
