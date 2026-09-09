using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsShowInfoMsg")]
public bool? outParamIsShowInfoMsg;


    public static RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsShowInfoMsg) {RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs result = new RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs();
result.outParamIsShowInfoMsg = (bool?) outParamIsShowInfoMsg;
return result;
}


    public static ConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Model ToModel(RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs variables) {ConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Model result = new ConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Model();
result.outParamIsShowInfoMsg = variables == null || variables.outParamIsShowInfoMsg == null ? false : variables.outParamIsShowInfoMsg.Value;
return result;
}


    public static RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs result = new RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs();
result.outParamIsShowInfoMsg = (bool?) screenModel.outParamIsShowInfoMsg;
return result;
}

}
