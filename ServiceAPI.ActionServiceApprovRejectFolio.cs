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

    public class S4PIServiceApprovRejectFolioInput {
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_FolioApprovalLevelId")]
public long? inParami_FolioApprovalLevelId;
[JsonProperty("i_IsApprove")]
public bool? inParami_IsApprove;
[JsonProperty("i_Comment")]
public string inParami_Comment;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceApprovRejectFolioInput(long? inParami_FolioId, long? inParami_FolioApprovalLevelId, bool? inParami_IsApprove, string inParami_Comment, int? inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}

public S4PIServiceApprovRejectFolioInput() {
this.inParami_Comment = "";
}

}

public class S4PIServiceApprovRejectFolioOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
public S4PIServiceApprovRejectFolioOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {
this.outParamo_Output = outParamo_Output;
}

}

[HttpPost()]
[Route("serviceapi/serviceapprovrejectfolio")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceApprovRejectFolio", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceApprovRejectFolio(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceApprovRejectFolioInput, S4PIServiceApprovRejectFolioOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
S4PIServiceApprovRejectFolioInput inputs = serviceActionInput.InputParameters;
inputs.inParami_Comment = (inputs.inParami_Comment ?? "");
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_FolioId == null)) {
validationErrors["i_FolioId"]=new string[] {"The i_FolioId mandatory parameter is missing in the request."};
}

if((inputs.inParami_FolioApprovalLevelId == null)) {
validationErrors["i_FolioApprovalLevelId"]=new string[] {"The i_FolioApprovalLevelId mandatory parameter is missing in the request."};
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
outParamo_Output = await Flows.ActionServiceApprovRejectFolio(context,inputs.inParami_FolioId.Value,inputs.inParami_FolioApprovalLevelId.Value,inputs.inParami_IsApprove.Value,inputs.inParami_Comment,inputs.inParamOffsetUtc.Value,inputs.inParami_GetUserId,ctx);

return new S4PIServiceApprovRejectFolioOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceApprovRejectFolio : VarsBag {
public long inParami_FolioId;
public long inParami_FolioApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public int inParamOffsetUtc;
public string inParami_GetUserId;
public Actions.lcoApprovRejectFolio resApprovRejectFolio =  new Actions.lcoApprovRejectFolio();
public lcvServiceApprovRejectFolio(long inParami_FolioId, long inParami_FolioApprovalLevelId, bool inParami_IsApprove, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceApprovRejectFolio : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoServiceApprovRejectFolio() {
}
}
/// <summary>
/// Action <code>ServiceApprovRejectFolio</code> that represents the Service Studio action
///  <code>ServiceApprovRejectFolio</code> <p> Description: Action that Approves, Reject Folios.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionServiceApprovRejectFolio(IRequestContext requestContext,long inParami_FolioId,long inParami_FolioApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoServiceApprovRejectFolio result = new lcoServiceApprovRejectFolio();
lcvServiceApprovRejectFolio localVars = new lcvServiceApprovRejectFolio(inParami_FolioId, inParami_FolioApprovalLevelId, inParami_IsApprove, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceApprovRejectFolio", "efe9285f-a001-4174-b2ca-9a2343727132"))
using (activitySource.CreateServiceActionActivity("ServiceApprovRejectFolio")){
// ApprovRejectFolio
localVars.resApprovRejectFolio.outParamo_Output = await Actions.ActionApprovRejectFolio(requestContext,localVars.inParami_FolioId,localVars.inParami_FolioApprovalLevelId,localVars.inParami_IsApprove,localVars.inParami_Comment,localVars.inParamOffsetUtc,localVars.inParami_GetUserId,cancellationToken);

// o_Output = ApprovRejectFolio.o_Output
result.outParamo_Output=localVars.resApprovRejectFolio.outParamo_Output;
} //close CreateActionActivity using block
} // try

catch (Ex_InitializeWFUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = InitializeWF.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
catch (Ex_GetNextApproverUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = GetNextApprover.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

        public static class FuncActionServiceApprovRejectFolio {
            
        }
    }
}
