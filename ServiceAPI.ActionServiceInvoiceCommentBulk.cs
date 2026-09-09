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

    public class S4PIServiceInvoiceCommentBulkInput {
[JsonProperty("i_InvoiceList")]
public JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad[] inParami_InvoiceList;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceInvoiceCommentBulkInput(JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad[] inParami_InvoiceList, string inParami_Comment, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceInvoiceCommentBulkOutput {
public S4PIServiceInvoiceCommentBulkOutput() {
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoicecommentbulk")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceCommentBulk", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceCommentBulk(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceCommentBulkInput, S4PIServiceInvoiceCommentBulkOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceInvoiceCommentBulkInput inputs = serviceActionInput.InputParameters;
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
await Flows.ActionServiceInvoiceCommentBulk(context,RL_12444f18cbf938e5a637c66b266df871.ToList(inputs.inParami_InvoiceList, (str) => JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad.ToStructure(str, behaviorsConfiguration)),inputs.inParami_Comment,inputs.inParami_GetUserId,ctx);

return new S4PIServiceInvoiceCommentBulkOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceCommentBulk : VarsBag {
public RL_12444f18cbf938e5a637c66b266df871 inParami_InvoiceList;
public string inParami_Comment;
public string inParami_GetUserId;
public lcvServiceInvoiceCommentBulk(RL_12444f18cbf938e5a637c66b266df871 inParami_InvoiceList, string inParami_Comment, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParami_GetUserId = inParami_GetUserId;
}
}
/// <summary>
/// Action <code>ServiceInvoiceCommentBulk</code> that represents the Service Studio action
///  <code>ServiceInvoiceCommentBulk</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceInvoiceCommentBulk(IRequestContext requestContext,RL_12444f18cbf938e5a637c66b266df871 inParami_InvoiceList,string inParami_Comment,string inParami_GetUserId,CancellationToken cancellationToken) {
lcvServiceInvoiceCommentBulk localVars = new lcvServiceInvoiceCommentBulk(inParami_InvoiceList, inParami_Comment, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceCommentBulk", "c386c379-6aee-464e-b15b-a408e5c79b77"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceCommentBulk")){
// InvoiceCommentBulk
await Actions.ActionInvoiceCommentBulk(requestContext,localVars.inParami_InvoiceList,localVars.inParami_Comment,localVars.inParami_GetUserId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceInvoiceCommentBulk {
            
        }
    }
}
