using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceCheckUserInput {
[JsonProperty("i_UserEmail")]
public string inParami_UserEmail;
public S4PIServiceCheckUserInput(string inParami_UserEmail) {
this.inParami_UserEmail = inParami_UserEmail;
}

}

public class S4PIServiceCheckUserOutput {
[JsonProperty("o_Role")]
public string outParamo_Role;
[JsonProperty("o_Success")]
public bool outParamo_Success;
[JsonProperty("o_UserId")]
public string outParamo_UserId;
public S4PIServiceCheckUserOutput(string outParamo_Role, bool outParamo_Success, string outParamo_UserId) {
this.outParamo_Role = outParamo_Role;
this.outParamo_Success = outParamo_Success;
this.outParamo_UserId = outParamo_UserId;
}

}

[HttpPost()]
[Route("serviceapi/servicecheckuser")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceCheckUser", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceCheckUser(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceCheckUserInput, S4PIServiceCheckUserOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
string outParamo_Role;
bool outParamo_Success;
string outParamo_UserId;
S4PIServiceCheckUserInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_UserEmail == null)) {
validationErrors["i_UserEmail"]=new string[] {"The i_UserEmail mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamo_Role,outParamo_Success,outParamo_UserId) = await Flows.ActionServiceCheckUser(context,inputs.inParami_UserEmail,ctx);

return new S4PIServiceCheckUserOutput(outParamo_Role, outParamo_Success, outParamo_UserId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceCheckUser : VarsBag {
public string inParami_UserEmail;
public Actions.lcoCheckUser resCheckUser =  new Actions.lcoCheckUser();
public lcvServiceCheckUser(string inParami_UserEmail) {
this.inParami_UserEmail = inParami_UserEmail;
}
}
public class lcoServiceCheckUser : VarsBag {
public string outParamo_Role = "";

public bool outParamo_Success = false;

public string outParamo_UserId = "";

public lcoServiceCheckUser() {
}
}
/// <summary>
/// Action <code>ServiceCheckUser</code> that represents the Service Studio action
///  <code>ServiceCheckUser</code> <p> Description: This action verifies at login if the user emai
/// l exists.</p>
/// </summary>
public static async Task<(string,bool,string)> ActionServiceCheckUser(IRequestContext requestContext,string inParami_UserEmail,CancellationToken cancellationToken) {
string outParamo_Role = default;
bool outParamo_Success = default;
string outParamo_UserId = default;
lcoServiceCheckUser result = new lcoServiceCheckUser();
lcvServiceCheckUser localVars = new lcvServiceCheckUser(inParami_UserEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceCheckUser", "141be594-8cec-418a-a51b-a55aa2528e6a"))
using (activitySource.CreateServiceActionActivity("ServiceCheckUser")){
// CheckUser
(localVars.resCheckUser.outParamo_Role,localVars.resCheckUser.outParamo_Success,localVars.resCheckUser.outParamo_UserId) = await Actions.ActionCheckUser(requestContext,localVars.inParami_UserEmail,cancellationToken);

// o_Role = CheckUser.o_Role
result.outParamo_Role=localVars.resCheckUser.outParamo_Role;

// o_Success = CheckUser.o_Success
result.outParamo_Success=localVars.resCheckUser.outParamo_Success;

// o_UserId = CheckUser.o_UserId
result.outParamo_UserId=localVars.resCheckUser.outParamo_UserId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Role = result.outParamo_Role;
outParamo_Success = result.outParamo_Success;
outParamo_UserId = result.outParamo_UserId;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Role,outParamo_Success,outParamo_UserId);
}

        public static class FuncActionServiceCheckUser {
            
        }
    }
}
