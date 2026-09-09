using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceDeleteOneRequisitionInput {
public S4PIServiceDeleteOneRequisitionInput() {
}

}

public class S4PIServiceDeleteOneRequisitionOutput {
public S4PIServiceDeleteOneRequisitionOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicedeleteonerequisition")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceDeleteOneRequisition", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceDeleteOneRequisition(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceDeleteOneRequisitionInput, S4PIServiceDeleteOneRequisitionOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceDeleteOneRequisitionInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceDeleteOneRequisition(context,ctx);

return new S4PIServiceDeleteOneRequisitionOutput();
}
, cancellationToken);
}



    public partial class Flows {
        /// <summary>
/// Action <code>ServiceDeleteOneRequisition</code> that represents the Service Studio action
///  <code>ServiceDeleteOneRequisition</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceDeleteOneRequisition(IRequestContext requestContext,CancellationToken cancellationToken) {
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceDeleteOneRequisition", "bb6acea5-7755-49a2-af42-40b851341fc0"))
using (activitySource.CreateServiceActionActivity("ServiceDeleteOneRequisition")){
// DeleteOneRequisition
await Actions.ActionDeleteOneRequisition(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceDeleteOneRequisition {
            
        }
    }
}
