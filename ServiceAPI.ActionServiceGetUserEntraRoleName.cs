using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetUserEntraRoleNameInput {
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceGetUserEntraRoleNameInput(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetUserEntraRoleNameOutput {
[JsonProperty("o_EntraRoleName")]
public string outParamo_EntraRoleName;
public S4PIServiceGetUserEntraRoleNameOutput(string outParamo_EntraRoleName) {
this.outParamo_EntraRoleName = outParamo_EntraRoleName;
}

}

[HttpPost()]
[Route("serviceapi/servicegetuserentrarolename")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetUserEntraRoleName", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetUserEntraRoleName(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetUserEntraRoleNameInput, S4PIServiceGetUserEntraRoleNameOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
string outParamo_EntraRoleName;
S4PIServiceGetUserEntraRoleNameInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_EntraRoleName = await Flows.ActionServiceGetUserEntraRoleName(context,inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetUserEntraRoleNameOutput(outParamo_EntraRoleName);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetUserEntraRoleName : VarsBag {
public string inParami_GetUserId;
public Actions.lcoGetUserEntraRoleName resGetUserEntraRoleName =  new Actions.lcoGetUserEntraRoleName();
public lcvServiceGetUserEntraRoleName(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetUserEntraRoleName : VarsBag {
public string outParamo_EntraRoleName = "";

public lcoServiceGetUserEntraRoleName() {
}
}
/// <summary>
/// Action <code>ServiceGetUserEntraRoleName</code> that represents the Service Studio action
///  <code>ServiceGetUserEntraRoleName</code> <p> Description: Get Entra Role name from user.</p>
/// </summary>
public static async Task<string> ActionServiceGetUserEntraRoleName(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
string outParamo_EntraRoleName = default;
lcoServiceGetUserEntraRoleName result = new lcoServiceGetUserEntraRoleName();
lcvServiceGetUserEntraRoleName localVars = new lcvServiceGetUserEntraRoleName(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetUserEntraRoleName", "ecf9a2dc-e1fc-4cae-8610-394e99f20b03"))
using (activitySource.CreateServiceActionActivity("ServiceGetUserEntraRoleName")){
// GetUserEntraRoleName
localVars.resGetUserEntraRoleName.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,localVars.inParami_GetUserId,cancellationToken);

// o_EntraRoleName = GetUserEntraRoleName.o_EntraRoleName
result.outParamo_EntraRoleName=localVars.resGetUserEntraRoleName.outParamo_EntraRoleName;
} //close CreateActionActivity using block
} // try

finally {
outParamo_EntraRoleName = result.outParamo_EntraRoleName;
} // inner-finally
RETURN_STATEMENT:
return outParamo_EntraRoleName;
}

        public static class FuncActionServiceGetUserEntraRoleName {
            
        }
    }
}
