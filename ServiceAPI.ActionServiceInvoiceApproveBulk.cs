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

    public class S4PIServiceInvoiceApproveBulkInput {
[JsonProperty("i_InvoiceList")]
public JSONRC_3797d4971af6bc97d739ac602330acb1[] inParami_InvoiceList;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceInvoiceApproveBulkInput(JSONRC_3797d4971af6bc97d739ac602330acb1[] inParami_InvoiceList, string inParami_Comment, int? inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceInvoiceApproveBulkOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("NotificationContent")]
public JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
[JsonProperty("NotificationError")]
public JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
[JsonProperty("IsFinish")]
public bool outParamIsFinish;
public S4PIServiceInvoiceApproveBulkOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent, JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError, bool outParamIsFinish) {
this.outParamo_Output = outParamo_Output;
this.outParamNotificationContent = outParamNotificationContent;
this.outParamNotificationError = outParamNotificationError;
this.outParamIsFinish = outParamIsFinish;
}

public bool ShouldSerializeoutParamIsFinish() {return (this.outParamIsFinish != false);
}
}

[HttpPost()]
[Route("serviceapi/serviceinvoiceapprovebulk")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceApproveBulk", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceApproveBulk(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceApproveBulkInput, S4PIServiceInvoiceApproveBulkOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
bool outParamIsFinish;
S4PIServiceInvoiceApproveBulkInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_InvoiceList == null)) {
validationErrors["i_InvoiceList"]=new string[] {"The i_InvoiceList mandatory parameter is missing in the request."};
}

if((inputs.inParami_Comment == null)) {
validationErrors["i_Comment"]=new string[] {"The i_Comment mandatory parameter is missing in the request."};
}

if((inputs.inParamOffsetUtc == null)) {
validationErrors["OffsetUtc"]=new string[] {"The OffsetUtc mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamo_Output,outParamNotificationContent,outParamNotificationError,outParamIsFinish) = await Flows.ActionServiceInvoiceApproveBulk(context,RL_0bff49813ef08eecaf6190c2661eb115.ToList(inputs.inParami_InvoiceList, (str) => JSONRC_3797d4971af6bc97d739ac602330acb1.ToStructure(str, behaviorsConfiguration)),inputs.inParami_Comment,inputs.inParamOffsetUtc.Value,inputs.inParami_GetUserId,ctx);

return new S4PIServiceInvoiceApproveBulkOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration), JSONST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure(outParamNotificationContent, behaviorsConfiguration), JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure.FromStructure(outParamNotificationError, behaviorsConfiguration), outParamIsFinish);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceApproveBulk : VarsBag {
public RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
public Actions.lcoInvoiceApproveBulk resInvoiceApproveBulk =  new Actions.lcoInvoiceApproveBulk();
public lcvServiceInvoiceApproveBulk(RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceInvoiceApproveBulk : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public bool outParamIsFinish = false;

public lcoServiceInvoiceApproveBulk() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceApproveBulk</code> that represents the Service Studio action
///  <code>ServiceInvoiceApproveBulk</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure,bool)> ActionServiceInvoiceApproveBulk(IRequestContext requestContext,RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
bool outParamIsFinish = default;
lcoServiceInvoiceApproveBulk result = new lcoServiceInvoiceApproveBulk();
lcvServiceInvoiceApproveBulk localVars = new lcvServiceInvoiceApproveBulk(inParami_InvoiceList, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceApproveBulk", "e5b75d05-8f99-441e-8edc-1ea572652215"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceApproveBulk")){
// InvoiceApproveBulk
(localVars.resInvoiceApproveBulk.outParamo_Output,localVars.resInvoiceApproveBulk.outParamNotificationContent,localVars.resInvoiceApproveBulk.outParamNotificationError,localVars.resInvoiceApproveBulk.outParamIsFinish) = await Actions.ActionInvoiceApproveBulk(requestContext,localVars.inParami_InvoiceList,localVars.inParami_Comment,localVars.inParamOffsetUtc,localVars.inParami_GetUserId,cancellationToken);

// o_Output = InvoiceApproveBulk.o_Output
result.outParamo_Output=localVars.resInvoiceApproveBulk.outParamo_Output;

// NotificationContent = InvoiceApproveBulk.NotificationContent
result.outParamNotificationContent=localVars.resInvoiceApproveBulk.outParamNotificationContent;

// NotificationError = InvoiceApproveBulk.NotificationError
result.outParamNotificationError=localVars.resInvoiceApproveBulk.outParamNotificationError;

// IsFinish = InvoiceApproveBulk.IsFinish
result.outParamIsFinish=localVars.resInvoiceApproveBulk.outParamIsFinish;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamNotificationContent = result.outParamNotificationContent;
outParamNotificationError = result.outParamNotificationError;
outParamIsFinish = result.outParamIsFinish;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamNotificationContent,outParamNotificationError,outParamIsFinish);
}

        public static class FuncActionServiceInvoiceApproveBulk {
            
        }
    }
}
