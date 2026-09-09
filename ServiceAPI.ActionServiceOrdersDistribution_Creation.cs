using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceOrdersDistribution_CreationInput {
[JsonProperty("OrdersImportRequestId")]
public long? inParamOrdersImportRequestId;
public S4PIServiceOrdersDistribution_CreationInput(long? inParamOrdersImportRequestId) {
this.inParamOrdersImportRequestId = inParamOrdersImportRequestId;
}

public S4PIServiceOrdersDistribution_CreationInput() {
this.inParamOrdersImportRequestId = 0L;
}

}

public class S4PIServiceOrdersDistribution_CreationOutput {
public S4PIServiceOrdersDistribution_CreationOutput() {
}

}

[HttpPost()]
[Route("serviceapi/serviceordersdistribution_creation")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrdersDistribution_Creation", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrdersDistribution_Creation(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrdersDistribution_CreationInput, S4PIServiceOrdersDistribution_CreationOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceOrdersDistribution_CreationInput inputs = serviceActionInput.InputParameters;
inputs.inParamOrdersImportRequestId = (inputs.inParamOrdersImportRequestId ?? 0L);
ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceOrdersDistribution_Creation(context,inputs.inParamOrdersImportRequestId.Value,ctx);

return new S4PIServiceOrdersDistribution_CreationOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrdersDistribution_Creation : VarsBag {
public long inParamOrdersImportRequestId;
public lcvServiceOrdersDistribution_Creation(long inParamOrdersImportRequestId) {
this.inParamOrdersImportRequestId = inParamOrdersImportRequestId;
}
}
/// <summary>
/// Action <code>ServiceOrdersDistribution_Creation</code> that represents the Service Studio action
///  <code>ServiceOrdersDistribution_Creation</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceOrdersDistribution_Creation(IRequestContext requestContext,long inParamOrdersImportRequestId,CancellationToken cancellationToken) {
lcvServiceOrdersDistribution_Creation localVars = new lcvServiceOrdersDistribution_Creation(inParamOrdersImportRequestId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrdersDistribution_Creation", "02ad24c2-1239-4015-b07a-8505259ab633"))
using (activitySource.CreateServiceActionActivity("ServiceOrdersDistribution_Creation")){
// OrdersDistribution_Creation
await Actions.ActionOrdersDistribution_Creation(requestContext,localVars.inParamOrdersImportRequestId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceOrdersDistribution_Creation {
            
        }
    }
}
