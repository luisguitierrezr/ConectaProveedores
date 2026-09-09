using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceProposalDeleteInput {
[JsonProperty("Id")]
public long? inParamId;
public S4PIServiceProposalDeleteInput(long? inParamId) {
this.inParamId = inParamId;
}

}

public class S4PIServiceProposalDeleteOutput {
public S4PIServiceProposalDeleteOutput() {
}

}

[HttpPost()]
[Route("serviceapi/serviceproposaldelete")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceProposalDelete", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceProposalDelete(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceProposalDeleteInput, S4PIServiceProposalDeleteOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceProposalDeleteInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamId == null)) {
validationErrors["Id"]=new string[] {"The Id mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceProposalDelete(context,inputs.inParamId.Value,ctx);

return new S4PIServiceProposalDeleteOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceProposalDelete : VarsBag {
public long inParamId;
public lcvServiceProposalDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>ServiceProposalDelete</code> that represents the Service Studio action
///  <code>ServiceProposalDelete</code> <p> Description: Encapsulates the Delete entity action, enablin
/// g logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionServiceProposalDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvServiceProposalDelete localVars = new lcvServiceProposalDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceProposalDelete", "3d6df5f9-84a7-439c-957a-12d277830888"))
using (activitySource.CreateServiceActionActivity("ServiceProposalDelete")){
// ProposalDelete
await Actions.ActionProposalDelete(requestContext,localVars.inParamId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceProposalDelete {
            
        }
    }
}
