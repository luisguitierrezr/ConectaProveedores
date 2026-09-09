using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceDeleteAllOrdersInput {
public S4PIServiceDeleteAllOrdersInput() {
}

}

public class S4PIServiceDeleteAllOrdersOutput {
public S4PIServiceDeleteAllOrdersOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicedeleteallorders")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceDeleteAllOrders", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceDeleteAllOrders(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceDeleteAllOrdersInput, S4PIServiceDeleteAllOrdersOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceDeleteAllOrdersInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceDeleteAllOrders(context,ctx);

return new S4PIServiceDeleteAllOrdersOutput();
}
, cancellationToken);
}



    public partial class Flows {
        /// <summary>
/// Action <code>ServiceDeleteAllOrders</code> that represents the Service Studio action
///  <code>ServiceDeleteAllOrders</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceDeleteAllOrders(IRequestContext requestContext,CancellationToken cancellationToken) {
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceDeleteAllOrders", "217ab508-3cb8-4ac2-a6aa-b71437892059"))
using (activitySource.CreateServiceActionActivity("ServiceDeleteAllOrders")){
// DeleteAllOrders
await Actions.ActionDeleteAllOrders(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceDeleteAllOrders {
            
        }
    }
}
