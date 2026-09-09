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

    public class S4PIServiceInvoiceCancelBulkInput {
[JsonProperty("i_InvoiceList")]
public JSONRC_3797d4971af6bc97d739ac602330acb1[] inParami_InvoiceList;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceInvoiceCancelBulkInput(JSONRC_3797d4971af6bc97d739ac602330acb1[] inParami_InvoiceList, string inParami_Comment, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceInvoiceCancelBulkOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("NotificationContent")]
public JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
[JsonProperty("NotificationError")]
public JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
public S4PIServiceInvoiceCancelBulkOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent, JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError) {
this.outParamo_Output = outParamo_Output;
this.outParamNotificationContent = outParamNotificationContent;
this.outParamNotificationError = outParamNotificationError;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoicecancelbulk")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceCancelBulk", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceCancelBulk(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceCancelBulkInput, S4PIServiceInvoiceCancelBulkOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
S4PIServiceInvoiceCancelBulkInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_InvoiceList == null)) {
validationErrors["i_InvoiceList"]=new string[] {"The i_InvoiceList mandatory parameter is missing in the request."};
}

if((inputs.inParami_Comment == null)) {
validationErrors["i_Comment"]=new string[] {"The i_Comment mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamo_Output,outParamNotificationContent,outParamNotificationError) = await Flows.ActionServiceInvoiceCancelBulk(context,RL_0bff49813ef08eecaf6190c2661eb115.ToList(inputs.inParami_InvoiceList, (str) => JSONRC_3797d4971af6bc97d739ac602330acb1.ToStructure(str, behaviorsConfiguration)),inputs.inParami_Comment,inputs.inParami_GetUserId,ctx);

return new S4PIServiceInvoiceCancelBulkOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration), JSONST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure(outParamNotificationContent, behaviorsConfiguration), JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure.FromStructure(outParamNotificationError, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceCancelBulk : VarsBag {
public RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList;
public string inParami_Comment;
public string inParami_GetUserId;
public Actions.lcoInvoiceCancelBulk resInvoiceCancelBulk =  new Actions.lcoInvoiceCancelBulk();
public lcvServiceInvoiceCancelBulk(RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList, string inParami_Comment, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceInvoiceCancelBulk : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public lcoServiceInvoiceCancelBulk() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceCancelBulk</code> that represents the Service Studio action
///  <code>ServiceInvoiceCancelBulk</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)> ActionServiceInvoiceCancelBulk(IRequestContext requestContext,RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList,string inParami_Comment,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
lcoServiceInvoiceCancelBulk result = new lcoServiceInvoiceCancelBulk();
lcvServiceInvoiceCancelBulk localVars = new lcvServiceInvoiceCancelBulk(inParami_InvoiceList, inParami_Comment, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceCancelBulk", "324deecd-e79f-40d0-a68b-d827df970b15"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceCancelBulk")){
// InvoiceCancelBulk
(localVars.resInvoiceCancelBulk.outParamo_Output,localVars.resInvoiceCancelBulk.outParamNotificationContent,localVars.resInvoiceCancelBulk.outParamNotificationError) = await Actions.ActionInvoiceCancelBulk(requestContext,localVars.inParami_InvoiceList,localVars.inParami_Comment,localVars.inParami_GetUserId,cancellationToken);

// o_Output = InvoiceCancelBulk.o_Output
result.outParamo_Output=localVars.resInvoiceCancelBulk.outParamo_Output;

// NotificationContent = InvoiceCancelBulk.NotificationContent
result.outParamNotificationContent=localVars.resInvoiceCancelBulk.outParamNotificationContent;

// NotificationError = InvoiceCancelBulk.NotificationError
result.outParamNotificationError=localVars.resInvoiceCancelBulk.outParamNotificationError;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamNotificationContent = result.outParamNotificationContent;
outParamNotificationError = result.outParamNotificationError;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamNotificationContent,outParamNotificationError);
}

        public static class FuncActionServiceInvoiceCancelBulk {
            
        }
    }
}
