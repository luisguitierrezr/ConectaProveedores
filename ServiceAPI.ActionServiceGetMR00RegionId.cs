using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetMR00RegionIdInput {
public S4PIServiceGetMR00RegionIdInput() {
}

}

public class S4PIServiceGetMR00RegionIdOutput {
[JsonProperty("RegionId")]
public long outParamRegionId;
public S4PIServiceGetMR00RegionIdOutput(long outParamRegionId) {
this.outParamRegionId = outParamRegionId;
}

}

[HttpPost()]
[Route("serviceapi/servicegetmr00regionid")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetMR00RegionId", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetMR00RegionId(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetMR00RegionIdInput, S4PIServiceGetMR00RegionIdOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamRegionId;
S4PIServiceGetMR00RegionIdInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
outParamRegionId = await Flows.ActionServiceGetMR00RegionId(context,ctx);

return new S4PIServiceGetMR00RegionIdOutput(outParamRegionId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetMR00RegionId : VarsBag {
public Actions.lcoGetMR00RegionId resGetMR00RegionId =  new Actions.lcoGetMR00RegionId();
public lcvServiceGetMR00RegionId() {
}
}
public class lcoServiceGetMR00RegionId : VarsBag {
public long outParamRegionId = 0L;

public lcoServiceGetMR00RegionId() {
}
}
/// <summary>
/// Action <code>ServiceGetMR00RegionId</code> that represents the Service Studio action
///  <code>ServiceGetMR00RegionId</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionServiceGetMR00RegionId(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamRegionId = default;
lcoServiceGetMR00RegionId result = new lcoServiceGetMR00RegionId();
lcvServiceGetMR00RegionId localVars = new lcvServiceGetMR00RegionId();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetMR00RegionId", "75659169-cee8-4cea-b551-4c8db6c93bb6"))
using (activitySource.CreateServiceActionActivity("ServiceGetMR00RegionId")){
// GetMR00RegionId
localVars.resGetMR00RegionId.outParamRegionId = await Actions.ActionGetMR00RegionId(requestContext,cancellationToken);

// RegionId = GetMR00RegionId.RegionId
result.outParamRegionId=localVars.resGetMR00RegionId.outParamRegionId;
} //close CreateActionActivity using block
} // try

finally {
outParamRegionId = result.outParamRegionId;
} // inner-finally
RETURN_STATEMENT:
return outParamRegionId;
}

        public static class FuncActionServiceGetMR00RegionId {
            
        }
    }
}
