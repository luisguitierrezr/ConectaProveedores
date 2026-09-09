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

    public class S4PIServiceApprovModifInvInput {
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_InvoiceApprovalLevelId")]
public long? inParami_InvoiceApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceApprovModifInvInput(long? inParami_InvoiceId, long? inParami_InvoiceApprovalLevelId, bool? inParami_IsApprove, string inParami_Comment, int? inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}

public S4PIServiceApprovModifInvInput() {
this.inParami_Comment = "";
}

}

public class S4PIServiceApprovModifInvOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("IsFinish")]
public bool outParamIsFinish;
public S4PIServiceApprovModifInvOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, bool outParamIsFinish) {
this.outParamo_Output = outParamo_Output;
this.outParamIsFinish = outParamIsFinish;
}

public bool ShouldSerializeoutParamIsFinish() {return (this.outParamIsFinish != false);
}
}

[HttpPost()]
[Route("serviceapi/serviceapprovmodifinv")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceApprovModifInv", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceApprovModifInv(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceApprovModifInvInput, S4PIServiceApprovModifInvOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
bool outParamIsFinish;
S4PIServiceApprovModifInvInput inputs = serviceActionInput.InputParameters;
inputs.inParami_Comment = (inputs.inParami_Comment ?? "");
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_InvoiceId == null)) {
validationErrors["i_InvoiceId"]=new string[] {"The i_InvoiceId mandatory parameter is missing in the request."};
}

if((inputs.inParami_InvoiceApprovalLevelId == null)) {
validationErrors["i_InvoiceApprovalLevelId"]=new string[] {"The i_InvoiceApprovalLevelId mandatory parameter is missing in the request."};
}

if((inputs.inParami_IsApprove == null)) {
validationErrors["i_IsApprove"]=new string[] {"The i_IsApprove mandatory parameter is missing in the request."};
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
(outParamo_Output,outParamIsFinish) = await Flows.ActionServiceApprovModifInv(context,inputs.inParami_InvoiceId.Value,inputs.inParami_InvoiceApprovalLevelId.Value,inputs.inParami_IsApprove.Value,inputs.inParami_Comment,inputs.inParamOffsetUtc.Value,inputs.inParami_GetUserId,ctx);

return new S4PIServiceApprovModifInvOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration), outParamIsFinish);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceApprovModifInv : VarsBag {
public long inParami_InvoiceId;
public long inParami_InvoiceApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
public Actions.lcoApprovModifInv resApprovModifInv =  new Actions.lcoApprovModifInv();
public lcvServiceApprovModifInv(long inParami_InvoiceId, long inParami_InvoiceApprovalLevelId, bool inParami_IsApprove, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceApprovModifInv : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public bool outParamIsFinish = false;

public lcoServiceApprovModifInv() {
}
}
/// <summary>
/// Action <code>ServiceApprovModifInv</code> that represents the Service Studio action
///  <code>ServiceApprovModifInv</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,bool)> ActionServiceApprovModifInv(IRequestContext requestContext,long inParami_InvoiceId,long inParami_InvoiceApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
bool outParamIsFinish = default;
lcoServiceApprovModifInv result = new lcoServiceApprovModifInv();
lcvServiceApprovModifInv localVars = new lcvServiceApprovModifInv(inParami_InvoiceId, inParami_InvoiceApprovalLevelId, inParami_IsApprove, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceApprovModifInv", "122c8a5a-584b-4375-a458-b9b56c3952d5"))
using (activitySource.CreateServiceActionActivity("ServiceApprovModifInv")){
// ApprovModifInv
(localVars.resApprovModifInv.outParamo_Output,localVars.resApprovModifInv.outParamIsFinish) = await Actions.ActionApprovModifInv(requestContext,localVars.inParami_InvoiceId,localVars.inParami_InvoiceApprovalLevelId,localVars.inParami_IsApprove,localVars.inParami_Comment,localVars.inParamOffsetUtc,localVars.inParami_GetUserId,cancellationToken);

// o_Output = ApprovModifInv.o_Output
result.outParamo_Output=localVars.resApprovModifInv.outParamo_Output;

// IsFinish = ApprovModifInv.IsFinish
result.outParamIsFinish=localVars.resApprovModifInv.outParamIsFinish;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamIsFinish = result.outParamIsFinish;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamIsFinish);
}

        public static class FuncActionServiceApprovModifInv {
            
        }
    }
}
