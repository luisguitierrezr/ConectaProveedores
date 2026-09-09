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

    public class S4PIServiceConfirmBulkAssignAnalistaInput {
[JsonProperty("i_InvoiceList")]
public JSONRC_3797d4971af6bc97d739ac602330acb1[] inParami_InvoiceList;
[JsonProperty("i_UserId")]
public string inParami_UserId;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceConfirmBulkAssignAnalistaInput(JSONRC_3797d4971af6bc97d739ac602330acb1[] inParami_InvoiceList, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceConfirmBulkAssignAnalistaOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("NotificationContent")]
public JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
[JsonProperty("NotificationError")]
public JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
public S4PIServiceConfirmBulkAssignAnalistaOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent, JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError) {
this.outParamo_Output = outParamo_Output;
this.outParamNotificationContent = outParamNotificationContent;
this.outParamNotificationError = outParamNotificationError;
}

}

[HttpPost()]
[Route("serviceapi/serviceconfirmbulkassignanalista")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceConfirmBulkAssignAnalista", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceConfirmBulkAssignAnalista(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceConfirmBulkAssignAnalistaInput, S4PIServiceConfirmBulkAssignAnalistaOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
S4PIServiceConfirmBulkAssignAnalistaInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_InvoiceList == null)) {
validationErrors["i_InvoiceList"]=new string[] {"The i_InvoiceList mandatory parameter is missing in the request."};
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
(outParamo_Output,outParamNotificationContent,outParamNotificationError) = await Flows.ActionServiceConfirmBulkAssignAnalista(context,RL_0bff49813ef08eecaf6190c2661eb115.ToList(inputs.inParami_InvoiceList, (str) => JSONRC_3797d4971af6bc97d739ac602330acb1.ToStructure(str, behaviorsConfiguration)),inputs.inParami_UserId,inputs.inParami_GetUserId,ctx);

return new S4PIServiceConfirmBulkAssignAnalistaOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration), JSONST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure(outParamNotificationContent, behaviorsConfiguration), JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure.FromStructure(outParamNotificationError, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceConfirmBulkAssignAnalista : VarsBag {
public RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList;
public string inParami_UserId;
public string inParami_GetUserId;
public Actions.lcoConfirmBulkAssignAnalista resConfirmBulkAssignAnalista =  new Actions.lcoConfirmBulkAssignAnalista();
public lcvServiceConfirmBulkAssignAnalista(RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceConfirmBulkAssignAnalista : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public lcoServiceConfirmBulkAssignAnalista() {
}
}
/// <summary>
/// Action <code>ServiceConfirmBulkAssignAnalista</code> that represents the Service Studio action
///  <code>ServiceConfirmBulkAssignAnalista</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)> ActionServiceConfirmBulkAssignAnalista(IRequestContext requestContext,RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList,string inParami_UserId,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
lcoServiceConfirmBulkAssignAnalista result = new lcoServiceConfirmBulkAssignAnalista();
lcvServiceConfirmBulkAssignAnalista localVars = new lcvServiceConfirmBulkAssignAnalista(inParami_InvoiceList, inParami_UserId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceConfirmBulkAssignAnalista", "1489d02d-d68e-4bb9-8543-3dbbeaf06659"))
using (activitySource.CreateServiceActionActivity("ServiceConfirmBulkAssignAnalista")){
// ConfirmBulkAssignAnalista
(localVars.resConfirmBulkAssignAnalista.outParamo_Output,localVars.resConfirmBulkAssignAnalista.outParamNotificationContent,localVars.resConfirmBulkAssignAnalista.outParamNotificationError) = await Actions.ActionConfirmBulkAssignAnalista(requestContext,localVars.inParami_InvoiceList,localVars.inParami_UserId,localVars.inParami_GetUserId,cancellationToken);

// o_Output = ConfirmBulkAssignAnalista.o_Output
result.outParamo_Output=localVars.resConfirmBulkAssignAnalista.outParamo_Output;

// NotificationContent = ConfirmBulkAssignAnalista.NotificationContent
result.outParamNotificationContent=localVars.resConfirmBulkAssignAnalista.outParamNotificationContent;

// NotificationError = ConfirmBulkAssignAnalista.NotificationError
result.outParamNotificationError=localVars.resConfirmBulkAssignAnalista.outParamNotificationError;
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

        public static class FuncActionServiceConfirmBulkAssignAnalista {
            
        }
    }
}
