using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceOrderMainDeleteInput {
[JsonProperty("Id")]
public long? inParamId;
public S4PIServiceOrderMainDeleteInput(long? inParamId) {
this.inParamId = inParamId;
}

}

public class S4PIServiceOrderMainDeleteOutput {
public S4PIServiceOrderMainDeleteOutput() {
}

}

[HttpPost()]
[Route("serviceapi/serviceordermaindelete")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderMainDelete", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderMainDelete(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderMainDeleteInput, S4PIServiceOrderMainDeleteOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceOrderMainDeleteInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamId == null)) {
validationErrors["Id"]=new string[] {"The Id mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceOrderMainDelete(context,inputs.inParamId.Value,ctx);

return new S4PIServiceOrderMainDeleteOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderMainDelete : VarsBag {
public long inParamId;
public lcvServiceOrderMainDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>ServiceOrderMainDelete</code> that represents the Service Studio action
///  <code>ServiceOrderMainDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionServiceOrderMainDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvServiceOrderMainDelete localVars = new lcvServiceOrderMainDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderMainDelete", "ab452611-3e25-421d-a73b-71dc55e31d62"))
using (activitySource.CreateServiceActionActivity("ServiceOrderMainDelete")){
// OrderMainDelete
await Actions.ActionOrderMainDelete(requestContext,localVars.inParamId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceOrderMainDelete {
            
        }
    }
}
