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

    public class S4PIServiceRequisitionCancelInput {
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("i_RequisitionApprovalLevelId")]
public long? inParami_RequisitionApprovalLevelId;
[JsonProperty("i_CancelReason")]
public string inParami_CancelReason;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceRequisitionCancelInput(long? inParami_RequisitionId, long? inParami_RequisitionApprovalLevelId, string inParami_CancelReason, string inParami_GetUserId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParami_CancelReason = inParami_CancelReason;
this.inParami_GetUserId = inParami_GetUserId;
}

public S4PIServiceRequisitionCancelInput() {
this.inParami_RequisitionApprovalLevelId = 0L;
this.inParami_CancelReason = "";
}

}

public class S4PIServiceRequisitionCancelOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
public S4PIServiceRequisitionCancelOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {
this.outParamo_Output = outParamo_Output;
}

}

[HttpPost()]
[Route("serviceapi/servicerequisitioncancel")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceRequisitionCancel", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceRequisitionCancel(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceRequisitionCancelInput, S4PIServiceRequisitionCancelOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
S4PIServiceRequisitionCancelInput inputs = serviceActionInput.InputParameters;
inputs.inParami_RequisitionApprovalLevelId = (inputs.inParami_RequisitionApprovalLevelId ?? 0L);
inputs.inParami_CancelReason = (inputs.inParami_CancelReason ?? "");
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_RequisitionId == null)) {
validationErrors["i_RequisitionId"]=new string[] {"The i_RequisitionId mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_Output = await Flows.ActionServiceRequisitionCancel(context,inputs.inParami_RequisitionId.Value,inputs.inParami_RequisitionApprovalLevelId.Value,inputs.inParami_CancelReason,inputs.inParami_GetUserId,ctx);

return new S4PIServiceRequisitionCancelOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceRequisitionCancel : VarsBag {
public long inParami_RequisitionId;
public long inParami_RequisitionApprovalLevelId;
public string inParami_CancelReason;
public string inParami_GetUserId;
public Actions.lcoRequisitionCancel resRequisitionCancel =  new Actions.lcoRequisitionCancel();
public lcvServiceRequisitionCancel(long inParami_RequisitionId, long inParami_RequisitionApprovalLevelId, string inParami_CancelReason, string inParami_GetUserId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParami_CancelReason = inParami_CancelReason;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceRequisitionCancel : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoServiceRequisitionCancel() {
}
}
/// <summary>
/// Action <code>ServiceRequisitionCancel</code> that represents the Service Studio action
///  <code>ServiceRequisitionCancel</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionServiceRequisitionCancel(IRequestContext requestContext,long inParami_RequisitionId,long inParami_RequisitionApprovalLevelId,string inParami_CancelReason,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoServiceRequisitionCancel result = new lcoServiceRequisitionCancel();
lcvServiceRequisitionCancel localVars = new lcvServiceRequisitionCancel(inParami_RequisitionId, inParami_RequisitionApprovalLevelId, inParami_CancelReason, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceRequisitionCancel", "6a4a0f1e-4ef6-46a5-a430-695dbf1426e0"))
using (activitySource.CreateServiceActionActivity("ServiceRequisitionCancel")){
// RequisitionCancel
localVars.resRequisitionCancel.outParamo_Output = await Actions.ActionRequisitionCancel(requestContext,localVars.inParami_RequisitionId,localVars.inParami_RequisitionApprovalLevelId,localVars.inParami_CancelReason,localVars.inParami_GetUserId,cancellationToken);

// o_Output = RequisitionCancel.o_Output
result.outParamo_Output=localVars.resRequisitionCancel.outParamo_Output;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

        public static class FuncActionServiceRequisitionCancel {
            
        }
    }
}
