using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsCxP")]
public bool? outParamIsCxP;


    public static RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsCxP) {RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs result = new RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs();
result.outParamIsCxP = (bool?) outParamIsCxP;
return result;
}


    public static ConectaProveedores_e_Orders_Orders_DataActionCheckUser_Model ToModel(RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs variables) {ConectaProveedores_e_Orders_Orders_DataActionCheckUser_Model result = new ConectaProveedores_e_Orders_Orders_DataActionCheckUser_Model();
result.outParamIsCxP = variables == null || variables.outParamIsCxP == null ? false : variables.outParamIsCxP.Value;
return result;
}


    public static RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_e_Orders_Orders_DataActionCheckUser_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs result = new RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs();
result.outParamIsCxP = (bool?) screenModel.outParamIsCxP;
return result;
}

}
