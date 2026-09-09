using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionSaveOrderDetail_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ErrorMsg")]
public string outParamErrorMsg;


    public static RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionSaveOrderDetail_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMsg) {RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionSaveOrderDetail_Outputs result = new RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ActionSaveOrderDetail_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMsg = outParamErrorMsg;
return result;
}


    

    
}
