using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsActiveDEV_C01")]
public bool? outParamo_IsActiveDEV_C01;


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsActiveDEV_C01) {RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs result = new RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs();
result.outParamo_IsActiveDEV_C01 = (bool?) outParamo_IsActiveDEV_C01;
return result;
}


    public static ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Model ToModel(RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs variables) {ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Model result = new ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Model();
result.outParamo_IsActiveDEV_C01 = variables == null || variables.outParamo_IsActiveDEV_C01 == null ? false : variables.outParamo_IsActiveDEV_C01.Value;
return result;
}


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs result = new RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs();
result.outParamo_IsActiveDEV_C01 = (bool?) screenModel.outParamo_IsActiveDEV_C01;
return result;
}

}
