using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceFile3DeleteInput {
[JsonProperty("Id")]
public long? inParamId;
public S4PIServiceFile3DeleteInput(long? inParamId) {
this.inParamId = inParamId;
}

}

public class S4PIServiceFile3DeleteOutput {
public S4PIServiceFile3DeleteOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicefile3delete")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceFile3Delete", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceFile3Delete(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceFile3DeleteInput, S4PIServiceFile3DeleteOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceFile3DeleteInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamId == null)) {
validationErrors["Id"]=new string[] {"The Id mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceFile3Delete(context,inputs.inParamId.Value,ctx);

return new S4PIServiceFile3DeleteOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceFile3Delete : VarsBag {
public long inParamId;
public lcvServiceFile3Delete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>ServiceFile3Delete</code> that represents the Service Studio action
///  <code>ServiceFile3Delete</code> <p> Description: Encapsulates the Delete entity action, enablin
/// g logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionServiceFile3Delete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvServiceFile3Delete localVars = new lcvServiceFile3Delete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceFile3Delete", "911ef08a-36ff-4cc8-afd4-fef60d63ae7b"))
using (activitySource.CreateServiceActionActivity("ServiceFile3Delete")){
// File3Delete
await Actions.ActionFile3Delete(requestContext,localVars.inParamId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceFile3Delete {
            
        }
    }
}
