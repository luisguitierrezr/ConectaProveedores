using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsActiveDEV_HU13008_Complement")]
public bool? outParamo_IsActiveDEV_HU13008_Complement;


    public static RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsActiveDEV_HU13008_Complement) {RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs result = new RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs();
result.outParamo_IsActiveDEV_HU13008_Complement = (bool?) outParamo_IsActiveDEV_HU13008_Complement;
return result;
}


    public static ConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Model ToModel(RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs variables) {ConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Model result = new ConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Model();
result.outParamo_IsActiveDEV_HU13008_Complement = variables == null || variables.outParamo_IsActiveDEV_HU13008_Complement == null ? false : variables.outParamo_IsActiveDEV_HU13008_Complement.Value;
return result;
}


    public static RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs result = new RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs();
result.outParamo_IsActiveDEV_HU13008_Complement = (bool?) screenModel.outParamo_IsActiveDEV_HU13008_Complement;
return result;
}

}
