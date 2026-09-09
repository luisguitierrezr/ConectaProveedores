using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetSettingIsDevEnvironmentInput {
public S4PIServiceGetSettingIsDevEnvironmentInput() {
}

}

public class S4PIServiceGetSettingIsDevEnvironmentOutput {
[JsonProperty("Value")]
public bool outParamValue;
public S4PIServiceGetSettingIsDevEnvironmentOutput(bool outParamValue) {
this.outParamValue = outParamValue;
}

}

[HttpPost()]
[Route("serviceapi/servicegetsettingisdevenvironment")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetSettingIsDevEnvironment", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetSettingIsDevEnvironment(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetSettingIsDevEnvironmentInput, S4PIServiceGetSettingIsDevEnvironmentOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamValue;
S4PIServiceGetSettingIsDevEnvironmentInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
outParamValue = await Flows.ActionServiceGetSettingIsDevEnvironment(context,ctx);

return new S4PIServiceGetSettingIsDevEnvironmentOutput(outParamValue);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcoServiceGetSettingIsDevEnvironment : VarsBag {
public bool outParamValue = false;

public lcoServiceGetSettingIsDevEnvironment() {
}
}
/// <summary>
/// Action <code>ServiceGetSettingIsDevEnvironment</code> that represents the Service Studio action
///  <code>ServiceGetSettingIsDevEnvironment</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionServiceGetSettingIsDevEnvironment(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamValue = default;
lcoServiceGetSettingIsDevEnvironment result = new lcoServiceGetSettingIsDevEnvironment();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetSettingIsDevEnvironment", "d02b6568-79be-4ba9-af5c-ee6bca1af2fd"))
using (activitySource.CreateServiceActionActivity("ServiceGetSettingIsDevEnvironment")){
// Value = IsDevEnvironment
result.outParamValue=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment])));
} //close CreateActionActivity using block
} // try

finally {
outParamValue = result.outParamValue;
} // inner-finally
RETURN_STATEMENT:
return outParamValue;
}

        public static class FuncActionServiceGetSettingIsDevEnvironment {
            
        }
    }
}
