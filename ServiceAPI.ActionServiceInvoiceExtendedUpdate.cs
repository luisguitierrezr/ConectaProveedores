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

    public class S4PIServiceInvoiceExtendedUpdateInput {
[JsonProperty("Source")]
public JSONEN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource;
public S4PIServiceInvoiceExtendedUpdateInput(JSONEN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceInvoiceExtendedUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceInvoiceExtendedUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoiceextendedupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceExtendedUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceExtendedUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceExtendedUpdateInput, S4PIServiceInvoiceExtendedUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceInvoiceExtendedUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceInvoiceExtendedUpdate(context,JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceInvoiceExtendedUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceExtendedUpdate : VarsBag {
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource;
public Actions.lcoInvoiceExtendedUpdate resInvoiceExtendedUpdate =  new Actions.lcoInvoiceExtendedUpdate();
public lcvServiceInvoiceExtendedUpdate(EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceInvoiceExtendedUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceInvoiceExtendedUpdate() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceExtendedUpdate</code> that represents the Service Studio action
///  <code>ServiceInvoiceExtendedUpdate</code> <p> Description: Encapsulates the Update entity action
/// , enabling logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionServiceInvoiceExtendedUpdate(IRequestContext requestContext,EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceInvoiceExtendedUpdate result = new lcoServiceInvoiceExtendedUpdate();
lcvServiceInvoiceExtendedUpdate localVars = new lcvServiceInvoiceExtendedUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceExtendedUpdate", "686a8e4d-7006-4f8e-a6fc-c72772e2af5d"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceExtendedUpdate")){
// InvoiceExtendedUpdate
localVars.resInvoiceExtendedUpdate.outParamId = await Actions.ActionInvoiceExtendedUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = InvoiceExtendedUpdate.Id
result.outParamId=localVars.resInvoiceExtendedUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceInvoiceExtendedUpdate {
            
        }
    }
}
