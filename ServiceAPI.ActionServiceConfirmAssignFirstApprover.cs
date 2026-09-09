using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using ssConectaProveedores.RestRecords;

namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceConfirmAssignFirstApproverInput {
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_UserId")]
public string inParami_UserId;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceConfirmAssignFirstApproverInput(long? inParami_InvoiceId, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceConfirmAssignFirstApproverOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
public S4PIServiceConfirmAssignFirstApproverOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {
this.outParamo_Output = outParamo_Output;
}

}

[HttpPost()]
[Route("serviceapi/serviceconfirmassignfirstapprover")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceConfirmAssignFirstApprover", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceConfirmAssignFirstApprover(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceConfirmAssignFirstApproverInput, S4PIServiceConfirmAssignFirstApproverOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
S4PIServiceConfirmAssignFirstApproverInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_InvoiceId == null)) {
validationErrors["i_InvoiceId"]=new string[] {"The i_InvoiceId mandatory parameter is missing in the request."};
}

if((inputs.inParami_UserId == null)) {
validationErrors["i_UserId"]=new string[] {"The i_UserId mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_Output = await Flows.ActionServiceConfirmAssignFirstApprover(context,inputs.inParami_InvoiceId.Value,inputs.inParami_UserId,inputs.inParami_GetUserId,ctx);

return new S4PIServiceConfirmAssignFirstApproverOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceConfirmAssignFirstApprover : VarsBag {
public long inParami_InvoiceId;
public string inParami_UserId;
public string inParami_GetUserId;
public Actions.lcoConfirmAssignFirstApprover resConfirmAssignFirstApprover =  new Actions.lcoConfirmAssignFirstApprover();
public lcvServiceConfirmAssignFirstApprover(long inParami_InvoiceId, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceConfirmAssignFirstApprover : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoServiceConfirmAssignFirstApprover() {
}
}
/// <summary>
/// Action <code>ServiceConfirmAssignFirstApprover</code> that represents the Service Studio action
///  <code>ServiceConfirmAssignFirstApprover</code> <p> Description: ConfirmAssignFirstApprover</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionServiceConfirmAssignFirstApprover(IRequestContext requestContext,long inParami_InvoiceId,string inParami_UserId,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoServiceConfirmAssignFirstApprover result = new lcoServiceConfirmAssignFirstApprover();
lcvServiceConfirmAssignFirstApprover localVars = new lcvServiceConfirmAssignFirstApprover(inParami_InvoiceId, inParami_UserId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceConfirmAssignFirstApprover", "309e3c66-5e0f-42f9-a56c-1ba81f3d110d"))
using (activitySource.CreateServiceActionActivity("ServiceConfirmAssignFirstApprover")){
// ConfirmAssignFirstApprover
localVars.resConfirmAssignFirstApprover.outParamo_Output = await Actions.ActionConfirmAssignFirstApprover(requestContext,localVars.inParami_InvoiceId,localVars.inParami_UserId,localVars.inParami_GetUserId,cancellationToken);

// o_Output = ConfirmAssignFirstApprover.o_Output
result.outParamo_Output=localVars.resConfirmAssignFirstApprover.outParamo_Output;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

        public static class FuncActionServiceConfirmAssignFirstApprover {
            
        }
    }
}
