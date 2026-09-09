using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetUserDepartmentNameInput {
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceGetUserDepartmentNameInput(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetUserDepartmentNameOutput {
[JsonProperty("o_Department")]
public string outParamo_Department;
public S4PIServiceGetUserDepartmentNameOutput(string outParamo_Department) {
this.outParamo_Department = outParamo_Department;
}

}

[HttpPost()]
[Route("serviceapi/servicegetuserdepartmentname")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetUserDepartmentName", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetUserDepartmentName(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetUserDepartmentNameInput, S4PIServiceGetUserDepartmentNameOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
string outParamo_Department;
S4PIServiceGetUserDepartmentNameInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_Department = await Flows.ActionServiceGetUserDepartmentName(context,inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetUserDepartmentNameOutput(outParamo_Department);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetUserDepartmentName : VarsBag {
public string inParami_GetUserId;
public Actions.lcoGetUserDepartmentName resGetUserDepartmentName =  new Actions.lcoGetUserDepartmentName();
public lcvServiceGetUserDepartmentName(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetUserDepartmentName : VarsBag {
public string outParamo_Department = "";

public lcoServiceGetUserDepartmentName() {
}
}
/// <summary>
/// Action <code>ServiceGetUserDepartmentName</code> that represents the Service Studio action
///  <code>ServiceGetUserDepartmentName</code> <p> Description: Get logged User Department name</p>
/// </summary>
public static async Task<string> ActionServiceGetUserDepartmentName(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
string outParamo_Department = default;
lcoServiceGetUserDepartmentName result = new lcoServiceGetUserDepartmentName();
lcvServiceGetUserDepartmentName localVars = new lcvServiceGetUserDepartmentName(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetUserDepartmentName", "2a629ee2-87f0-4c23-bdd6-0b889d5d29b5"))
using (activitySource.CreateServiceActionActivity("ServiceGetUserDepartmentName")){
// GetUserDepartmentName
localVars.resGetUserDepartmentName.outParamo_Department = await Actions.ActionGetUserDepartmentName(requestContext,localVars.inParami_GetUserId,cancellationToken);

// o_Department = GetUserDepartmentName.o_Department
result.outParamo_Department=localVars.resGetUserDepartmentName.outParamo_Department;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Department = result.outParamo_Department;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Department;
}

        public static class FuncActionServiceGetUserDepartmentName {
            
        }
    }
}
