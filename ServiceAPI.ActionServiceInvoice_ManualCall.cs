using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using ssConectaProveedores.RestRecords;

namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceInvoice_ManualCallInput {
[JsonProperty("InvoiceAccountingProcess")]
public JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess;
public S4PIServiceInvoice_ManualCallInput(JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess) {
this.inParamInvoiceAccountingProcess = inParamInvoiceAccountingProcess;
}

}

public class S4PIServiceInvoice_ManualCallOutput {
public S4PIServiceInvoice_ManualCallOutput() {
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoice_manualcall")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoice_ManualCall", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoice_ManualCall(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoice_ManualCallInput, S4PIServiceInvoice_ManualCallOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceInvoice_ManualCallInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcess == null)) {
validationErrors["InvoiceAccountingProcess"]=new string[] {"The InvoiceAccountingProcess mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceInvoice_ManualCall(context,JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(inputs.inParamInvoiceAccountingProcess, behaviorsConfiguration),ctx);

return new S4PIServiceInvoice_ManualCallOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoice_ManualCall : VarsBag {
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess;
public lcvServiceInvoice_ManualCall(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess) {
this.inParamInvoiceAccountingProcess = inParamInvoiceAccountingProcess;
}
}
/// <summary>
/// Action <code>ServiceInvoice_ManualCall</code> that represents the Service Studio action
///  <code>ServiceInvoice_ManualCall</code> <p> Description: Set Process as Finished and check if ther
/// e is any Pending process for the same supplier</p>
/// </summary>
public static async Task ActionServiceInvoice_ManualCall(IRequestContext requestContext,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess,CancellationToken cancellationToken) {
lcvServiceInvoice_ManualCall localVars = new lcvServiceInvoice_ManualCall(inParamInvoiceAccountingProcess);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoice_ManualCall", "47aa9223-1444-4007-9dfb-9a7f40e7e54d"))
using (activitySource.CreateServiceActionActivity("ServiceInvoice_ManualCall")){
// Invoice_ManualCall
await Actions.ActionInvoice_ManualCall(requestContext,localVars.inParamInvoiceAccountingProcess,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceInvoice_ManualCall {
            
        }
    }
}
