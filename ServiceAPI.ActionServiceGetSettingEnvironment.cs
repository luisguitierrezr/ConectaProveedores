using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetSettingEnvironmentInput {
public S4PIServiceGetSettingEnvironmentInput() {
}

}

public class S4PIServiceGetSettingEnvironmentOutput {
[JsonProperty("Value")]
public string outParamValue;
public S4PIServiceGetSettingEnvironmentOutput(string outParamValue) {
this.outParamValue = outParamValue;
}

}

[HttpPost()]
[Route("serviceapi/servicegetsettingenvironment")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetSettingEnvironment", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetSettingEnvironment(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetSettingEnvironmentInput, S4PIServiceGetSettingEnvironmentOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
string outParamValue;
S4PIServiceGetSettingEnvironmentInput inputs = serviceActionInput.InputParameters;
ctx.ThrowIfCancellationRequested();
outParamValue = await Flows.ActionServiceGetSettingEnvironment(context,ctx);

return new S4PIServiceGetSettingEnvironmentOutput(outParamValue);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcoServiceGetSettingEnvironment : VarsBag {
public string outParamValue = "";

public lcoServiceGetSettingEnvironment() {
}
}
/// <summary>
/// Action <code>ServiceGetSettingEnvironment</code> that represents the Service Studio action
///  <code>ServiceGetSettingEnvironment</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionServiceGetSettingEnvironment(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamValue = default;
lcoServiceGetSettingEnvironment result = new lcoServiceGetSettingEnvironment();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetSettingEnvironment", "26bcc2d6-688a-4331-ad95-14f82fd6fa8e"))
using (activitySource.CreateServiceActionActivity("ServiceGetSettingEnvironment")){
// Value = Environment
result.outParamValue=((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])));
} //close CreateActionActivity using block
} // try

finally {
outParamValue = result.outParamValue;
} // inner-finally
RETURN_STATEMENT:
return outParamValue;
}

        public static class FuncActionServiceGetSettingEnvironment {
            
        }
    }
}
