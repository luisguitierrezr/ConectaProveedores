using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("PolizaSAP")]
public string inParamPolizaSAP;
[JsonProperty("PolizaSAP_CN")]
public string inParamPolizaSAP_CN;


    public static RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Model ToModel() {ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Model result = new ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Model();
result.inParamInvoiceId = inParamInvoiceId == null ? 0L : inParamInvoiceId.Value;
result.inParamPolizaSAP = inParamPolizaSAP == null ? "" : inParamPolizaSAP;
result.inParamPolizaSAP_CN = inParamPolizaSAP_CN == null ? "" : inParamPolizaSAP_CN;
return result;
}

}
