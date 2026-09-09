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

    public class S4PIServiceApprovModifRequisitionInput {
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("i_RequisitionApprovalLevelId")]
public long? inParami_RequisitionApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceApprovModifRequisitionInput(long? inParami_RequisitionId, long? inParami_RequisitionApprovalLevelId, bool? inParami_IsApprove, string inParami_Comment, int? inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}

public S4PIServiceApprovModifRequisitionInput() {
this.inParami_Comment = "";
}

}

public class S4PIServiceApprovModifRequisitionOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
public S4PIServiceApprovModifRequisitionOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {
this.outParamo_Output = outParamo_Output;
}

}

[HttpPost()]
[Route("serviceapi/serviceapprovmodifrequisition")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceApprovModifRequisition", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceApprovModifRequisition(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceApprovModifRequisitionInput, S4PIServiceApprovModifRequisitionOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
S4PIServiceApprovModifRequisitionInput inputs = serviceActionInput.InputParameters;
inputs.inParami_Comment = (inputs.inParami_Comment ?? "");
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_RequisitionId == null)) {
validationErrors["i_RequisitionId"]=new string[] {"The i_RequisitionId mandatory parameter is missing in the request."};
}

if((inputs.inParami_RequisitionApprovalLevelId == null)) {
validationErrors["i_RequisitionApprovalLevelId"]=new string[] {"The i_RequisitionApprovalLevelId mandatory parameter is missing in the request."};
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
outParamo_Output = await Flows.ActionServiceApprovModifRequisition(context,inputs.inParami_RequisitionId.Value,inputs.inParami_RequisitionApprovalLevelId.Value,inputs.inParami_IsApprove.Value,inputs.inParami_Comment,inputs.inParamOffsetUtc.Value,inputs.inParami_GetUserId,ctx);

return new S4PIServiceApprovModifRequisitionOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceApprovModifRequisition : VarsBag {
public long inParami_RequisitionId;
public long inParami_RequisitionApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
public Actions.lcoApprovModifReq resApprovModifReq =  new Actions.lcoApprovModifReq();
public lcvServiceApprovModifRequisition(long inParami_RequisitionId, long inParami_RequisitionApprovalLevelId, bool inParami_IsApprove, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceApprovModifRequisition : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoServiceApprovModifRequisition() {
}
}
/// <summary>
/// Action <code>ServiceApprovModifRequisition</code> that represents the Service Studio action
///  <code>ServiceApprovModifRequisition</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionServiceApprovModifRequisition(IRequestContext requestContext,long inParami_RequisitionId,long inParami_RequisitionApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoServiceApprovModifRequisition result = new lcoServiceApprovModifRequisition();
lcvServiceApprovModifRequisition localVars = new lcvServiceApprovModifRequisition(inParami_RequisitionId, inParami_RequisitionApprovalLevelId, inParami_IsApprove, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceApprovModifRequisition", "e2c229d0-1a9a-4537-b1b4-ad1ef8ad8c5f"))
using (activitySource.CreateServiceActionActivity("ServiceApprovModifRequisition")){
// ApprovModifReq
localVars.resApprovModifReq.outParamo_Output = await Actions.ActionApprovModifReq(requestContext,localVars.inParami_RequisitionId,localVars.inParami_RequisitionApprovalLevelId,localVars.inParami_IsApprove,localVars.inParami_Comment,localVars.inParamOffsetUtc,localVars.inParami_GetUserId,cancellationToken);

// o_Output = ApprovModifReq.o_Output
result.outParamo_Output=localVars.resApprovModifReq.outParamo_Output;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

        public static class FuncActionServiceApprovModifRequisition {
            
        }
    }
}
