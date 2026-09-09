using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Binary")]
public byte[] outParamBinary;


    public static RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamBinary) {RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Outputs result = new RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Outputs();
conf.IncludeBinariesURL = false;
result.outParamBinary = outParamBinary;
return result;
}


    

    
}
