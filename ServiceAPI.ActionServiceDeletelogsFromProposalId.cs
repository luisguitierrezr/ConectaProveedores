using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceDeletelogsFromProposalIdInput {
[JsonProperty("ProposalId")]
public long? inParamProposalId;
public S4PIServiceDeletelogsFromProposalIdInput(long? inParamProposalId) {
this.inParamProposalId = inParamProposalId;
}

}

public class S4PIServiceDeletelogsFromProposalIdOutput {
public S4PIServiceDeletelogsFromProposalIdOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicedeletelogsfromproposalid")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceDeletelogsFromProposalId", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceDeletelogsFromProposalId(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceDeletelogsFromProposalIdInput, S4PIServiceDeletelogsFromProposalIdOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceDeletelogsFromProposalIdInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamProposalId == null)) {
validationErrors["ProposalId"]=new string[] {"The ProposalId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceDeletelogsFromProposalId(context,inputs.inParamProposalId.Value,ctx);

return new S4PIServiceDeletelogsFromProposalIdOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceDeletelogsFromProposalId : VarsBag {
public long inParamProposalId;
public lcvServiceDeletelogsFromProposalId(long inParamProposalId) {
this.inParamProposalId = inParamProposalId;
}
}
/// <summary>
/// Action <code>ServiceDeletelogsFromProposalId</code> that represents the Service Studio action
///  <code>ServiceDeletelogsFromProposalId</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceDeletelogsFromProposalId(IRequestContext requestContext,long inParamProposalId,CancellationToken cancellationToken) {
lcvServiceDeletelogsFromProposalId localVars = new lcvServiceDeletelogsFromProposalId(inParamProposalId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceDeletelogsFromProposalId", "5e05a299-f583-4124-9df5-20ff8de8a8b7"))
using (activitySource.CreateServiceActionActivity("ServiceDeletelogsFromProposalId")){
// DeletelogsFromProposalId
await Actions.ActionDeletelogsFromProposalId(requestContext,localVars.inParamProposalId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceDeletelogsFromProposalId {
            
        }
    }
}
