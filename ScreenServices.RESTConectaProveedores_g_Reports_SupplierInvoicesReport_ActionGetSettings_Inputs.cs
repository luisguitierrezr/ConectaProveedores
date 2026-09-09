using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("TableName")]
public string inParamTableName;


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Model ToModel() {ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Model result = new ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Model();
result.inParamTableName = inParamTableName == null ? "" : inParamTableName;
return result;
}

}
