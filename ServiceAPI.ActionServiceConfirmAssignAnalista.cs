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

    public class S4PIServiceConfirmAssignAnalistaInput {
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_InvoiceApprovalLevelId")]
public long? inParami_InvoiceApprovalLevelId;
[JsonProperty("i_UserId")]
public string inParami_UserId;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceConfirmAssignAnalistaInput(long? inParami_InvoiceId, long? inParami_InvoiceApprovalLevelId, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceConfirmAssignAnalistaOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
public S4PIServiceConfirmAssignAnalistaOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {
this.outParamo_Output = outParamo_Output;
}

}

[HttpPost()]
[Route("serviceapi/serviceconfirmassignanalista")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceConfirmAssignAnalista", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceConfirmAssignAnalista(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceConfirmAssignAnalistaInput, S4PIServiceConfirmAssignAnalistaOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
S4PIServiceConfirmAssignAnalistaInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_InvoiceId == null)) {
validationErrors["i_InvoiceId"]=new string[] {"The i_InvoiceId mandatory parameter is missing in the request."};
}

if((inputs.inParami_InvoiceApprovalLevelId == null)) {
validationErrors["i_InvoiceApprovalLevelId"]=new string[] {"The i_InvoiceApprovalLevelId mandatory parameter is missing in the request."};
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
outParamo_Output = await Flows.ActionServiceConfirmAssignAnalista(context,inputs.inParami_InvoiceId.Value,inputs.inParami_InvoiceApprovalLevelId.Value,inputs.inParami_UserId,inputs.inParami_GetUserId,ctx);

return new S4PIServiceConfirmAssignAnalistaOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceConfirmAssignAnalista : VarsBag {
public long inParami_InvoiceId;
public long inParami_InvoiceApprovalLevelId;
public string inParami_UserId;
public string inParami_GetUserId;
public Actions.lcoConfirmAssignAnalista resConfirmAssignAnalista =  new Actions.lcoConfirmAssignAnalista();
public lcvServiceConfirmAssignAnalista(long inParami_InvoiceId, long inParami_InvoiceApprovalLevelId, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceConfirmAssignAnalista : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoServiceConfirmAssignAnalista() {
}
}
/// <summary>
/// Action <code>ServiceConfirmAssignAnalista</code> that represents the Service Studio action
///  <code>ServiceConfirmAssignAnalista</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionServiceConfirmAssignAnalista(IRequestContext requestContext,long inParami_InvoiceId,long inParami_InvoiceApprovalLevelId,string inParami_UserId,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoServiceConfirmAssignAnalista result = new lcoServiceConfirmAssignAnalista();
lcvServiceConfirmAssignAnalista localVars = new lcvServiceConfirmAssignAnalista(inParami_InvoiceId, inParami_InvoiceApprovalLevelId, inParami_UserId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceConfirmAssignAnalista", "603304c0-380d-4bfb-9a41-ef15665d0507"))
using (activitySource.CreateServiceActionActivity("ServiceConfirmAssignAnalista")){
// ConfirmAssignAnalista
localVars.resConfirmAssignAnalista.outParamo_Output = await Actions.ActionConfirmAssignAnalista(requestContext,localVars.inParami_InvoiceId,localVars.inParami_InvoiceApprovalLevelId,localVars.inParami_UserId,localVars.inParami_GetUserId,cancellationToken);

// o_Output = ConfirmAssignAnalista.o_Output
result.outParamo_Output=localVars.resConfirmAssignAnalista.outParamo_Output;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

        public static class FuncActionServiceConfirmAssignAnalista {
            
        }
    }
}
