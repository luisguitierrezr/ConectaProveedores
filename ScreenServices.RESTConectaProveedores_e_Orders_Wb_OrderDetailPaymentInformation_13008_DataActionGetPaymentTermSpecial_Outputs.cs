using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Id")]
public long? outParamId;
[JsonProperty("IsActive")]
public bool? outParamIsActive;


    public static RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamId, bool outParamIsActive) {RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs result = new RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs();
result.outParamId = (long?) outParamId;
result.outParamIsActive = (bool?) outParamIsActive;
return result;
}


    public static ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Model ToModel(RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs variables) {ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Model result = new ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Model();
result.outParamId = variables == null || variables.outParamId == null ? 0L : variables.outParamId.Value;
result.outParamIsActive = variables == null || variables.outParamIsActive == null ? false : variables.outParamIsActive.Value;
return result;
}


    public static RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs result = new RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Outputs();
result.outParamId = (long?) screenModel.outParamId;
result.outParamIsActive = (bool?) screenModel.outParamIsActive;
return result;
}

}
