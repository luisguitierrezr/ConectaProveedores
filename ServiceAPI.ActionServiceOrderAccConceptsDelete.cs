using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceOrderAccConceptsDeleteInput {
[JsonProperty("Id")]
public long? inParamId;
public S4PIServiceOrderAccConceptsDeleteInput(long? inParamId) {
this.inParamId = inParamId;
}

}

public class S4PIServiceOrderAccConceptsDeleteOutput {
public S4PIServiceOrderAccConceptsDeleteOutput() {
}

}

[HttpPost()]
[Route("serviceapi/serviceorderaccconceptsdelete")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderAccConceptsDelete", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderAccConceptsDelete(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderAccConceptsDeleteInput, S4PIServiceOrderAccConceptsDeleteOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceOrderAccConceptsDeleteInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamId == null)) {
validationErrors["Id"]=new string[] {"The Id mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceOrderAccConceptsDelete(context,inputs.inParamId.Value,ctx);

return new S4PIServiceOrderAccConceptsDeleteOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderAccConceptsDelete : VarsBag {
public long inParamId;
public lcvServiceOrderAccConceptsDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>ServiceOrderAccConceptsDelete</code> that represents the Service Studio action
///  <code>ServiceOrderAccConceptsDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionServiceOrderAccConceptsDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvServiceOrderAccConceptsDelete localVars = new lcvServiceOrderAccConceptsDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderAccConceptsDelete", "cbd56f79-fc75-4edf-b5b9-753cc6e6bbc0"))
using (activitySource.CreateServiceActionActivity("ServiceOrderAccConceptsDelete")){
// OrderAccConceptsDelete
await Actions.ActionOrderAccConceptsDelete(requestContext,localVars.inParamId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceOrderAccConceptsDelete {
            
        }
    }
}
