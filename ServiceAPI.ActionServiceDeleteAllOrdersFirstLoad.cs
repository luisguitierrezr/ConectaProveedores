using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceDeleteAllOrdersFirstLoadInput {
public S4PIServiceDeleteAllOrdersFirstLoadInput() {
}

}

public class S4PIServiceDeleteAllOrdersFirstLoadOutput {
public S4PIServiceDeleteAllOrdersFirstLoadOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicedeleteallordersfirstload")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceDeleteAllOrdersFirstLoad", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceDeleteAllOrdersFirstLoad(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceDeleteAllOrdersFirstLoadInput, S4PIServiceDeleteAllOrdersFirstLoadOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceDeleteAllOrdersFirstLoadInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceDeleteAllOrdersFirstLoad(context,ctx);

return new S4PIServiceDeleteAllOrdersFirstLoadOutput();
}
, cancellationToken);
}



    public partial class Flows {
        /// <summary>
/// Action <code>ServiceDeleteAllOrdersFirstLoad</code> that represents the Service Studio action
///  <code>ServiceDeleteAllOrdersFirstLoad</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceDeleteAllOrdersFirstLoad(IRequestContext requestContext,CancellationToken cancellationToken) {
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceDeleteAllOrdersFirstLoad", "3a2381ac-6bfe-48d9-947d-7611b8f6d5b2"))
using (activitySource.CreateServiceActionActivity("ServiceDeleteAllOrdersFirstLoad")){
// DeleteAllOrdersFirstLoad
await Actions.ActionDeleteAllOrdersFirstLoad(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceDeleteAllOrdersFirstLoad {
            
        }
    }
}
