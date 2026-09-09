using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsAnticipoWithInv")]
public bool? outParamIsAnticipoWithInv;
[JsonProperty("IsLastLevel")]
public bool? outParamIsLastLevel;


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsAnticipoWithInv, bool outParamIsLastLevel) {RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs();
result.outParamIsAnticipoWithInv = (bool?) outParamIsAnticipoWithInv;
result.outParamIsLastLevel = (bool?) outParamIsLastLevel;
return result;
}


    public static ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Model ToModel(RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs variables) {ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Model result = new ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Model();
result.outParamIsAnticipoWithInv = variables == null || variables.outParamIsAnticipoWithInv == null ? false : variables.outParamIsAnticipoWithInv.Value;
result.outParamIsLastLevel = variables == null || variables.outParamIsLastLevel == null ? false : variables.outParamIsLastLevel.Value;
return result;
}


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs();
result.outParamIsAnticipoWithInv = (bool?) screenModel.outParamIsAnticipoWithInv;
result.outParamIsLastLevel = (bool?) screenModel.outParamIsLastLevel;
return result;
}

}
