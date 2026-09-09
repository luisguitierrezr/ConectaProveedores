using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Success")]
public bool? outParamSuccess;
[JsonProperty("Message")]
public string outParamMessage;


    public static RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamSuccess, string outParamMessage) {RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Outputs result = new RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_ActionInvoiceManualAccounting_Outputs();
conf.IncludeBinariesURL = false;
result.outParamSuccess = (bool?) outParamSuccess;
result.outParamMessage = outParamMessage;
return result;
}


    

    
}
