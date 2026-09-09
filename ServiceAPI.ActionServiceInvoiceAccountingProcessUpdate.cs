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

    public class S4PIServiceInvoiceAccountingProcessUpdateInput {
[JsonProperty("Source")]
public JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource;
public S4PIServiceInvoiceAccountingProcessUpdateInput(JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceInvoiceAccountingProcessUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceInvoiceAccountingProcessUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoiceaccountingprocessupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceAccountingProcessUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceAccountingProcessUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceAccountingProcessUpdateInput, S4PIServiceInvoiceAccountingProcessUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceInvoiceAccountingProcessUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceInvoiceAccountingProcessUpdate(context,JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceInvoiceAccountingProcessUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceAccountingProcessUpdate : VarsBag {
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource;
public Actions.lcoInvoiceAccountingProcessUpdate resInvoiceAccountingProcessUpdate =  new Actions.lcoInvoiceAccountingProcessUpdate();
public lcvServiceInvoiceAccountingProcessUpdate(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceInvoiceAccountingProcessUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceInvoiceAccountingProcessUpdate() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceAccountingProcessUpdate</code> that represents the Service Studio action
///  <code>ServiceInvoiceAccountingProcessUpdate</code> <p> Description: Encapsulates the Update entit
/// y action, enabling logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionServiceInvoiceAccountingProcessUpdate(IRequestContext requestContext,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceInvoiceAccountingProcessUpdate result = new lcoServiceInvoiceAccountingProcessUpdate();
lcvServiceInvoiceAccountingProcessUpdate localVars = new lcvServiceInvoiceAccountingProcessUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceAccountingProcessUpdate", "8f56d707-6b4b-4979-bb09-88a55e97b94d"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceAccountingProcessUpdate")){
// InvoiceAccountingProcessUpdate
localVars.resInvoiceAccountingProcessUpdate.outParamId = await Actions.ActionInvoiceAccountingProcessUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = InvoiceAccountingProcessUpdate.Id
result.outParamId=localVars.resInvoiceAccountingProcessUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceInvoiceAccountingProcessUpdate {
            
        }
    }
}
