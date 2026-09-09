using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("OrderNumber")]
public string inParamOrderNumber;


    public static RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Model ToModel() {ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Model result = new ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Model();
result.inParamOrderNumber = inParamOrderNumber == null ? "" : inParamOrderNumber;
return result;
}

}
