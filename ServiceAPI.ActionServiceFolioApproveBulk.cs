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

    public class S4PIServiceFolioApproveBulkInput {
[JsonProperty("i_FolioList")]
public JSONRC_6041e483640e901fd2a96b2a9af2a903[] inParami_FolioList;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceFolioApproveBulkInput(JSONRC_6041e483640e901fd2a96b2a9af2a903[] inParami_FolioList, string inParami_Comment, int? inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_FolioList = inParami_FolioList;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceFolioApproveBulkOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("NotificationContent")]
public JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
[JsonProperty("NotificationError")]
public JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
public S4PIServiceFolioApproveBulkOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, JSONST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent, JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError) {
this.outParamo_Output = outParamo_Output;
this.outParamNotificationContent = outParamNotificationContent;
this.outParamNotificationError = outParamNotificationError;
}

}

[HttpPost()]
[Route("serviceapi/servicefolioapprovebulk")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceFolioApproveBulk", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceFolioApproveBulk(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceFolioApproveBulkInput, S4PIServiceFolioApproveBulkOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError;
S4PIServiceFolioApproveBulkInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_FolioList == null)) {
validationErrors["i_FolioList"]=new string[] {"The i_FolioList mandatory parameter is missing in the request."};
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
(outParamo_Output,outParamNotificationContent,outParamNotificationError) = await Flows.ActionServiceFolioApproveBulk(context,RL_79ea8920a52237936a05ba9320d22c38.ToList(inputs.inParami_FolioList, (str) => JSONRC_6041e483640e901fd2a96b2a9af2a903.ToStructure(str, behaviorsConfiguration)),inputs.inParami_Comment,inputs.inParamOffsetUtc.Value,inputs.inParami_GetUserId,ctx);

return new S4PIServiceFolioApproveBulkOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration), JSONST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure(outParamNotificationContent, behaviorsConfiguration), JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure.FromStructure(outParamNotificationError, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceFolioApproveBulk : VarsBag {
public RL_79ea8920a52237936a05ba9320d22c38 inParami_FolioList;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
public Actions.lcoFolioApproveBulk resFolioApproveBulk =  new Actions.lcoFolioApproveBulk();
public lcvServiceFolioApproveBulk(RL_79ea8920a52237936a05ba9320d22c38 inParami_FolioList, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_FolioList = inParami_FolioList;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceFolioApproveBulk : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public lcoServiceFolioApproveBulk() {
}
}
/// <summary>
/// Action <code>ServiceFolioApproveBulk</code> that represents the Service Studio action
///  <code>ServiceFolioApproveBulk</code> <p> Description: Action to approve Folios in bulk.</p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)> ActionServiceFolioApproveBulk(IRequestContext requestContext,RL_79ea8920a52237936a05ba9320d22c38 inParami_FolioList,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
lcoServiceFolioApproveBulk result = new lcoServiceFolioApproveBulk();
lcvServiceFolioApproveBulk localVars = new lcvServiceFolioApproveBulk(inParami_FolioList, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceFolioApproveBulk", "c0c48772-6da2-48b8-9491-fd0134c6647c"))
using (activitySource.CreateServiceActionActivity("ServiceFolioApproveBulk")){
// FolioApproveBulk
(localVars.resFolioApproveBulk.outParamo_Output,localVars.resFolioApproveBulk.outParamNotificationContent,localVars.resFolioApproveBulk.outParamNotificationError) = await Actions.ActionFolioApproveBulk(requestContext,localVars.inParami_FolioList,localVars.inParami_Comment,localVars.inParamOffsetUtc,localVars.inParami_GetUserId,cancellationToken);

// o_Output = FolioApproveBulk.o_Output
result.outParamo_Output=localVars.resFolioApproveBulk.outParamo_Output;

// NotificationContent = FolioApproveBulk.NotificationContent
result.outParamNotificationContent=localVars.resFolioApproveBulk.outParamNotificationContent;

// NotificationError = FolioApproveBulk.NotificationError
result.outParamNotificationError=localVars.resFolioApproveBulk.outParamNotificationError;
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

        public static class FuncActionServiceFolioApproveBulk {
            
        }
    }
}
