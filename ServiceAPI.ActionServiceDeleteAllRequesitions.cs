using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceDeleteAllRequesitionsInput {
public S4PIServiceDeleteAllRequesitionsInput() {
}

}

public class S4PIServiceDeleteAllRequesitionsOutput {
public S4PIServiceDeleteAllRequesitionsOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicedeleteallrequesitions")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceDeleteAllRequesitions", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceDeleteAllRequesitions(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceDeleteAllRequesitionsInput, S4PIServiceDeleteAllRequesitionsOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceDeleteAllRequesitionsInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceDeleteAllRequesitions(context,ctx);

return new S4PIServiceDeleteAllRequesitionsOutput();
}
, cancellationToken);
}



    public partial class Flows {
        /// <summary>
/// Action <code>ServiceDeleteAllRequesitions</code> that represents the Service Studio action
///  <code>ServiceDeleteAllRequesitions</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceDeleteAllRequesitions(IRequestContext requestContext,CancellationToken cancellationToken) {
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceDeleteAllRequesitions", "442bb3f3-7ab1-43b7-b93f-72a775766fe7"))
using (activitySource.CreateServiceActionActivity("ServiceDeleteAllRequesitions")){
// DeleteAllRequesitions
await Actions.ActionDeleteAllRequesitions(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceDeleteAllRequesitions {
            
        }
    }
}
