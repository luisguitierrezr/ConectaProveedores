using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetIsCorporativoCxPFromUARInput {
[JsonProperty("i_ConceptId")]
public int? inParami_ConceptId;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceGetIsCorporativoCxPFromUARInput(int? inParami_ConceptId, string inParami_GetUserId) {
this.inParami_ConceptId = inParami_ConceptId;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetIsCorporativoCxPFromUAROutput {
[JsonProperty("o_IsFromCorporativo")]
public bool outParamo_IsFromCorporativo;
public S4PIServiceGetIsCorporativoCxPFromUAROutput(bool outParamo_IsFromCorporativo) {
this.outParamo_IsFromCorporativo = outParamo_IsFromCorporativo;
}

}

[HttpPost()]
[Route("serviceapi/servicegetiscorporativocxpfromuar")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetIsCorporativoCxPFromUAR", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetIsCorporativoCxPFromUAR(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetIsCorporativoCxPFromUARInput, S4PIServiceGetIsCorporativoCxPFromUAROutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamo_IsFromCorporativo;
S4PIServiceGetIsCorporativoCxPFromUARInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_ConceptId == null)) {
validationErrors["i_ConceptId"]=new string[] {"The i_ConceptId mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_IsFromCorporativo = await Flows.ActionServiceGetIsCorporativoCxPFromUAR(context,inputs.inParami_ConceptId.Value,inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetIsCorporativoCxPFromUAROutput(outParamo_IsFromCorporativo);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetIsCorporativoCxPFromUAR : VarsBag {
public int inParami_ConceptId;
public string inParami_GetUserId;
public Actions.lcoGetIsCorporativoCxPFromUAR resGetIsCorporativoCxPFromUAR =  new Actions.lcoGetIsCorporativoCxPFromUAR();
public lcvServiceGetIsCorporativoCxPFromUAR(int inParami_ConceptId, string inParami_GetUserId) {
this.inParami_ConceptId = inParami_ConceptId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetIsCorporativoCxPFromUAR : VarsBag {
public bool outParamo_IsFromCorporativo = false;

public lcoServiceGetIsCorporativoCxPFromUAR() {
}
}
/// <summary>
/// Action <code>ServiceGetIsCorporativoCxPFromUAR</code> that represents the Service Studio action
///  <code>ServiceGetIsCorporativoCxPFromUAR</code> <p> Description: From UserApplicationRole</p>
/// </summary>
public static async Task<bool> ActionServiceGetIsCorporativoCxPFromUAR(IRequestContext requestContext,int inParami_ConceptId,string inParami_GetUserId,CancellationToken cancellationToken) {
bool outParamo_IsFromCorporativo = default;
lcoServiceGetIsCorporativoCxPFromUAR result = new lcoServiceGetIsCorporativoCxPFromUAR();
lcvServiceGetIsCorporativoCxPFromUAR localVars = new lcvServiceGetIsCorporativoCxPFromUAR(inParami_ConceptId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetIsCorporativoCxPFromUAR", "824b7ea0-0158-431b-85b7-43b35811c286"))
using (activitySource.CreateServiceActionActivity("ServiceGetIsCorporativoCxPFromUAR")){
// GetIsCorporativoCxPFromUAR
localVars.resGetIsCorporativoCxPFromUAR.outParamo_IsFromCorporativo = await Actions.ActionGetIsCorporativoCxPFromUAR(requestContext,localVars.inParami_ConceptId,localVars.inParami_GetUserId,cancellationToken);

// o_IsFromCorporativo = GetIsCorporativoCxPFromUAR.o_IsFromCorporativo
result.outParamo_IsFromCorporativo=localVars.resGetIsCorporativoCxPFromUAR.outParamo_IsFromCorporativo;
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsFromCorporativo = result.outParamo_IsFromCorporativo;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsFromCorporativo;
}

        public static class FuncActionServiceGetIsCorporativoCxPFromUAR {
            
        }
    }
}
