using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceOrdersDistribution_DeleteOldInput {
[JsonProperty("OrderMainId")]
public long? inParamOrderMainId;
public S4PIServiceOrdersDistribution_DeleteOldInput(long? inParamOrderMainId) {
this.inParamOrderMainId = inParamOrderMainId;
}

}

public class S4PIServiceOrdersDistribution_DeleteOldOutput {
public S4PIServiceOrdersDistribution_DeleteOldOutput() {
}

}

[HttpPost()]
[Route("serviceapi/serviceordersdistribution_deleteold")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrdersDistribution_DeleteOld", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrdersDistribution_DeleteOld(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrdersDistribution_DeleteOldInput, S4PIServiceOrdersDistribution_DeleteOldOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceOrdersDistribution_DeleteOldInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamOrderMainId == null)) {
validationErrors["OrderMainId"]=new string[] {"The OrderMainId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceOrdersDistribution_DeleteOld(context,inputs.inParamOrderMainId.Value,ctx);

return new S4PIServiceOrdersDistribution_DeleteOldOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrdersDistribution_DeleteOld : VarsBag {
public long inParamOrderMainId;
public lcvServiceOrdersDistribution_DeleteOld(long inParamOrderMainId) {
this.inParamOrderMainId = inParamOrderMainId;
}
}
/// <summary>
/// Action <code>ServiceOrdersDistribution_DeleteOld</code> that represents the Service Studio action
///  <code>ServiceOrdersDistribution_DeleteOld</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceOrdersDistribution_DeleteOld(IRequestContext requestContext,long inParamOrderMainId,CancellationToken cancellationToken) {
lcvServiceOrdersDistribution_DeleteOld localVars = new lcvServiceOrdersDistribution_DeleteOld(inParamOrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrdersDistribution_DeleteOld", "2cb5bba4-8d9b-45aa-b754-e95f2cdcada8"))
using (activitySource.CreateServiceActionActivity("ServiceOrdersDistribution_DeleteOld")){
// OrdersDistribution_DeleteOld
await Actions.ActionOrdersDistribution_DeleteOld(requestContext,localVars.inParamOrderMainId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceOrdersDistribution_DeleteOld {
            
        }
    }
}
