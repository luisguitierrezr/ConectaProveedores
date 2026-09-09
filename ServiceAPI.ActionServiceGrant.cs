using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGrantInput {
[JsonProperty("Email")]
public string inParamEmail;
public S4PIServiceGrantInput(string inParamEmail) {
this.inParamEmail = inParamEmail;
}

}

public class S4PIServiceGrantOutput {
public S4PIServiceGrantOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicegrant")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGrant", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGrant(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGrantInput, S4PIServiceGrantOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceGrantInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamEmail == null)) {
validationErrors["Email"]=new string[] {"The Email mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceGrant(context,inputs.inParamEmail,ctx);

return new S4PIServiceGrantOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGrant : VarsBag {
public string inParamEmail;
public lcvServiceGrant(string inParamEmail) {
this.inParamEmail = inParamEmail;
}
}
/// <summary>
/// Action <code>ServiceGrant</code> that represents the Service Studio action
///  <code>ServiceGrant</code> <p> Description: Action to grant ConectaProveedoresRole basic Role</p>
/// </summary>
public static async Task ActionServiceGrant(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
lcvServiceGrant localVars = new lcvServiceGrant(inParamEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGrant", "577f3d86-382f-4fb3-983a-f3c1d8ddd611"))
using (activitySource.CreateServiceActionActivity("ServiceGrant")){
// Grant
await Actions.ActionGrant(requestContext,localVars.inParamEmail,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceGrant {
            
        }
    }
}
