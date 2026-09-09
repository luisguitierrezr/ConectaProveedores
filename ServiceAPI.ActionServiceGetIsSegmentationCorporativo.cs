using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetIsSegmentationCorporativoInput {
public S4PIServiceGetIsSegmentationCorporativoInput() {
}

}

public class S4PIServiceGetIsSegmentationCorporativoOutput {
[JsonProperty("IsSegmentationCorporativo")]
public bool outParamIsSegmentationCorporativo;
public S4PIServiceGetIsSegmentationCorporativoOutput(bool outParamIsSegmentationCorporativo) {
this.outParamIsSegmentationCorporativo = outParamIsSegmentationCorporativo;
}

}

[HttpPost()]
[Route("serviceapi/servicegetissegmentationcorporativo")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetIsSegmentationCorporativo", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetIsSegmentationCorporativo(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetIsSegmentationCorporativoInput, S4PIServiceGetIsSegmentationCorporativoOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsSegmentationCorporativo;
S4PIServiceGetIsSegmentationCorporativoInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
outParamIsSegmentationCorporativo = await Flows.ActionServiceGetIsSegmentationCorporativo(context,ctx);

return new S4PIServiceGetIsSegmentationCorporativoOutput(outParamIsSegmentationCorporativo);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcoServiceGetIsSegmentationCorporativo : VarsBag {
public bool outParamIsSegmentationCorporativo = false;

public lcoServiceGetIsSegmentationCorporativo() {
}
}
/// <summary>
/// Action <code>ServiceGetIsSegmentationCorporativo</code> that represents the Service Studio action
///  <code>ServiceGetIsSegmentationCorporativo</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionServiceGetIsSegmentationCorporativo(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsSegmentationCorporativo = default;
lcoServiceGetIsSegmentationCorporativo result = new lcoServiceGetIsSegmentationCorporativo();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetIsSegmentationCorporativo", "56e768b2-820e-4c84-9a7d-a07b96edc555"))
using (activitySource.CreateServiceActionActivity("ServiceGetIsSegmentationCorporativo")){
// IsSegmentationCorporativo = IsSegmentationCorporativo
result.outParamIsSegmentationCorporativo=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsSegmentationCorporativo = result.outParamIsSegmentationCorporativo;
} // inner-finally
RETURN_STATEMENT:
return outParamIsSegmentationCorporativo;
}

        public static class FuncActionServiceGetIsSegmentationCorporativo {
            
        }
    }
}
