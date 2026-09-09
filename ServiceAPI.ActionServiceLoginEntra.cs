using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceLoginEntraInput {
[JsonProperty("i_UserEmailTelcel")]
public string inParami_UserEmailTelcel;
[JsonProperty("i_NewRegion")]
public string inParami_NewRegion;
public S4PIServiceLoginEntraInput(string inParami_UserEmailTelcel, string inParami_NewRegion) {
this.inParami_UserEmailTelcel = inParami_UserEmailTelcel;
this.inParami_NewRegion = inParami_NewRegion;
}

}

public class S4PIServiceLoginEntraOutput {
[JsonProperty("o_Message")]
public string outParamo_Message;
[JsonProperty("o_IsSuccess")]
public bool outParamo_IsSuccess;
public S4PIServiceLoginEntraOutput(string outParamo_Message, bool outParamo_IsSuccess) {
this.outParamo_Message = outParamo_Message;
this.outParamo_IsSuccess = outParamo_IsSuccess;
}

}

[HttpPost()]
[Route("serviceapi/serviceloginentra")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceLoginEntra", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceLoginEntra(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceLoginEntraInput, S4PIServiceLoginEntraOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
string outParamo_Message;
bool outParamo_IsSuccess;
S4PIServiceLoginEntraInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_UserEmailTelcel == null)) {
validationErrors["i_UserEmailTelcel"]=new string[] {"The i_UserEmailTelcel mandatory parameter is missing in the request."};
}

if((inputs.inParami_NewRegion == null)) {
validationErrors["i_NewRegion"]=new string[] {"The i_NewRegion mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamo_Message,outParamo_IsSuccess) = await Flows.ActionServiceLoginEntra(context,inputs.inParami_UserEmailTelcel,inputs.inParami_NewRegion,ctx);

return new S4PIServiceLoginEntraOutput(outParamo_Message, outParamo_IsSuccess);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceLoginEntra : VarsBag {
public string inParami_UserEmailTelcel;
public string inParami_NewRegion;
public Actions.lcoLoginEntra resLoginEntra =  new Actions.lcoLoginEntra();
public lcvServiceLoginEntra(string inParami_UserEmailTelcel, string inParami_NewRegion) {
this.inParami_UserEmailTelcel = inParami_UserEmailTelcel;
this.inParami_NewRegion = inParami_NewRegion;
}
}
public class lcoServiceLoginEntra : VarsBag {
public string outParamo_Message = "";

public bool outParamo_IsSuccess = false;

public lcoServiceLoginEntra() {
}
}
/// <summary>
/// Action <code>ServiceLoginEntra</code> that represents the Service Studio action
///  <code>ServiceLoginEntra</code> <p> Description: Action to get data from Entra, assign Roles and se
/// t User Session.</p>
/// </summary>
public static async Task<(string,bool)> ActionServiceLoginEntra(IRequestContext requestContext,string inParami_UserEmailTelcel,string inParami_NewRegion,CancellationToken cancellationToken) {
string outParamo_Message = default;
bool outParamo_IsSuccess = default;
lcoServiceLoginEntra result = new lcoServiceLoginEntra();
lcvServiceLoginEntra localVars = new lcvServiceLoginEntra(inParami_UserEmailTelcel, inParami_NewRegion);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceLoginEntra", "6edca908-4009-4327-b7dc-7cc0af53d517"))
using (activitySource.CreateServiceActionActivity("ServiceLoginEntra")){
// LoginEntra
(localVars.resLoginEntra.outParamo_Message,localVars.resLoginEntra.outParamo_IsSuccess) = await Actions.ActionLoginEntra(requestContext,localVars.inParami_UserEmailTelcel,localVars.inParami_NewRegion,cancellationToken);

// o_Message = LoginEntra.o_Message
result.outParamo_Message=localVars.resLoginEntra.outParamo_Message;

// o_IsSuccess = LoginEntra.o_IsSuccess
result.outParamo_IsSuccess=localVars.resLoginEntra.outParamo_IsSuccess;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Message = result.outParamo_Message;
outParamo_IsSuccess = result.outParamo_IsSuccess;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Message,outParamo_IsSuccess);
}

        public static class FuncActionServiceLoginEntra {
            
        }
    }
}
