using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceFolioApproval_ConstructionInput {
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;
public S4PIServiceFolioApproval_ConstructionInput(long? inParamFolioId, int? inParamOffsetUtc) {
this.inParamFolioId = inParamFolioId;
this.inParamOffsetUtc = inParamOffsetUtc;
}

}

public class S4PIServiceFolioApproval_ConstructionOutput {
public S4PIServiceFolioApproval_ConstructionOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicefolioapproval_construction")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceFolioApproval_Construction", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceFolioApproval_Construction(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceFolioApproval_ConstructionInput, S4PIServiceFolioApproval_ConstructionOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceFolioApproval_ConstructionInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamFolioId == null)) {
validationErrors["FolioId"]=new string[] {"The FolioId mandatory parameter is missing in the request."};
}

if((inputs.inParamOffsetUtc == null)) {
validationErrors["OffsetUtc"]=new string[] {"The OffsetUtc mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceFolioApproval_Construction(context,inputs.inParamFolioId.Value,inputs.inParamOffsetUtc.Value,ctx);

return new S4PIServiceFolioApproval_ConstructionOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceFolioApproval_Construction : VarsBag {
public long inParamFolioId;
public int inParamOffsetUtc;
public lcvServiceFolioApproval_Construction(long inParamFolioId, int inParamOffsetUtc) {
this.inParamFolioId = inParamFolioId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
/// <summary>
/// Action <code>ServiceFolioApproval_Construction</code> that represents the Service Studio action
///  <code>ServiceFolioApproval_Construction</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceFolioApproval_Construction(IRequestContext requestContext,long inParamFolioId,int inParamOffsetUtc,CancellationToken cancellationToken) {
lcvServiceFolioApproval_Construction localVars = new lcvServiceFolioApproval_Construction(inParamFolioId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceFolioApproval_Construction", "5250ac0a-146c-4215-a1dd-1255c2a939d6"))
using (activitySource.CreateServiceActionActivity("ServiceFolioApproval_Construction")){
// FolioApproval_Construction
await Actions.ActionFolioApproval_Construction(requestContext,localVars.inParamFolioId,localVars.inParamOffsetUtc,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceFolioApproval_Construction {
            
        }
    }
}
