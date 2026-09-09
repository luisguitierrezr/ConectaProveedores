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

    public class S4PIServiceInvoiceCancelInput {
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_InvoiceApprovalLevelId")]
public long? inParami_InvoiceApprovalLevelId;
[JsonProperty("i_CancelReason")]
public string inParami_CancelReason;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceInvoiceCancelInput(long? inParami_InvoiceId, long? inParami_InvoiceApprovalLevelId, string inParami_CancelReason, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_CancelReason = inParami_CancelReason;
this.inParami_GetUserId = inParami_GetUserId;
}

public S4PIServiceInvoiceCancelInput() {
this.inParami_InvoiceApprovalLevelId = 0L;
this.inParami_CancelReason = "";
}

}

public class S4PIServiceInvoiceCancelOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
public S4PIServiceInvoiceCancelOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {
this.outParamo_Output = outParamo_Output;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoicecancel")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceCancel", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceCancel(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceCancelInput, S4PIServiceInvoiceCancelOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
S4PIServiceInvoiceCancelInput inputs = serviceActionInput.InputParameters;
inputs.inParami_InvoiceApprovalLevelId = (inputs.inParami_InvoiceApprovalLevelId ?? 0L);
inputs.inParami_CancelReason = (inputs.inParami_CancelReason ?? "");
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_InvoiceId == null)) {
validationErrors["i_InvoiceId"]=new string[] {"The i_InvoiceId mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_Output = await Flows.ActionServiceInvoiceCancel(context,inputs.inParami_InvoiceId.Value,inputs.inParami_InvoiceApprovalLevelId.Value,inputs.inParami_CancelReason,inputs.inParami_GetUserId,ctx);

return new S4PIServiceInvoiceCancelOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceCancel : VarsBag {
public long inParami_InvoiceId;
public long inParami_InvoiceApprovalLevelId;
public string inParami_CancelReason;
public string inParami_GetUserId;
public Actions.lcoInvoiceCancel resInvoiceCancel =  new Actions.lcoInvoiceCancel();
public lcvServiceInvoiceCancel(long inParami_InvoiceId, long inParami_InvoiceApprovalLevelId, string inParami_CancelReason, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_CancelReason = inParami_CancelReason;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceInvoiceCancel : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoServiceInvoiceCancel() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceCancel</code> that represents the Service Studio action
///  <code>ServiceInvoiceCancel</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionServiceInvoiceCancel(IRequestContext requestContext,long inParami_InvoiceId,long inParami_InvoiceApprovalLevelId,string inParami_CancelReason,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoServiceInvoiceCancel result = new lcoServiceInvoiceCancel();
lcvServiceInvoiceCancel localVars = new lcvServiceInvoiceCancel(inParami_InvoiceId, inParami_InvoiceApprovalLevelId, inParami_CancelReason, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceCancel", "36b80df0-79c2-4fe7-bdb5-d45dc6d65964"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceCancel")){
// InvoiceCancel
localVars.resInvoiceCancel.outParamo_Output = await Actions.ActionInvoiceCancel(requestContext,localVars.inParami_InvoiceId,localVars.inParami_InvoiceApprovalLevelId,localVars.inParami_CancelReason,localVars.inParami_GetUserId,cancellationToken);

// o_Output = InvoiceCancel.o_Output
result.outParamo_Output=localVars.resInvoiceCancel.outParamo_Output;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

        public static class FuncActionServiceInvoiceCancel {
            
        }
    }
}
