using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceSendLoginAlertInput {
[JsonProperty("Username")]
public string inParamUsername;
[JsonProperty("Environment")]
public string inParamEnvironment;
public S4PIServiceSendLoginAlertInput(string inParamUsername, string inParamEnvironment) {
this.inParamUsername = inParamUsername;
this.inParamEnvironment = inParamEnvironment;
}

}

public class S4PIServiceSendLoginAlertOutput {
public S4PIServiceSendLoginAlertOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicesendloginalert")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceSendLoginAlert", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceSendLoginAlert(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceSendLoginAlertInput, S4PIServiceSendLoginAlertOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceSendLoginAlertInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamUsername == null)) {
validationErrors["Username"]=new string[] {"The Username mandatory parameter is missing in the request."};
}

if((inputs.inParamEnvironment == null)) {
validationErrors["Environment"]=new string[] {"The Environment mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceSendLoginAlert(context,inputs.inParamUsername,inputs.inParamEnvironment,ctx);

return new S4PIServiceSendLoginAlertOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceSendLoginAlert : VarsBag {
public string inParamUsername;
public string inParamEnvironment;
public lcvServiceSendLoginAlert(string inParamUsername, string inParamEnvironment) {
this.inParamUsername = inParamUsername;
this.inParamEnvironment = inParamEnvironment;
}
}
/// <summary>
/// Action <code>ServiceSendLoginAlert</code> that represents the Service Studio action
///  <code>ServiceSendLoginAlert</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceSendLoginAlert(IRequestContext requestContext,string inParamUsername,string inParamEnvironment,CancellationToken cancellationToken) {
lcvServiceSendLoginAlert localVars = new lcvServiceSendLoginAlert(inParamUsername, inParamEnvironment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceSendLoginAlert", "12c349cc-c222-4fcd-8e7a-642d279273ae"))
using (activitySource.CreateServiceActionActivity("ServiceSendLoginAlert")){
// SendLoginAlert
await Actions.ActionSendLoginAlert(requestContext,localVars.inParamUsername,localVars.inParamEnvironment,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceSendLoginAlert {
            
        }
    }
}
