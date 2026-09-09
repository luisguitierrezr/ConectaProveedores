using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceDeleteOrderByNumberInput {
[JsonProperty("OrderNumber")]
public string inParamOrderNumber;
public S4PIServiceDeleteOrderByNumberInput(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}

}

public class S4PIServiceDeleteOrderByNumberOutput {
[JsonProperty("IsDeleted")]
public bool outParamIsDeleted;
public S4PIServiceDeleteOrderByNumberOutput(bool outParamIsDeleted) {
this.outParamIsDeleted = outParamIsDeleted;
}

}

[HttpPost()]
[Route("serviceapi/servicedeleteorderbynumber")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceDeleteOrderByNumber", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceDeleteOrderByNumber(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceDeleteOrderByNumberInput, S4PIServiceDeleteOrderByNumberOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsDeleted;
S4PIServiceDeleteOrderByNumberInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamOrderNumber == null)) {
validationErrors["OrderNumber"]=new string[] {"The OrderNumber mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamIsDeleted = await Flows.ActionServiceDeleteOrderByNumber(context,inputs.inParamOrderNumber,ctx);

return new S4PIServiceDeleteOrderByNumberOutput(outParamIsDeleted);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceDeleteOrderByNumber : VarsBag {
public string inParamOrderNumber;
public Actions.lcoDeleteOrderByNumber resDeleteOrderByNumber =  new Actions.lcoDeleteOrderByNumber();
public lcvServiceDeleteOrderByNumber(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoServiceDeleteOrderByNumber : VarsBag {
public bool outParamIsDeleted = false;

public lcoServiceDeleteOrderByNumber() {
}
}
/// <summary>
/// Action <code>ServiceDeleteOrderByNumber</code> that represents the Service Studio action
///  <code>ServiceDeleteOrderByNumber</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionServiceDeleteOrderByNumber(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
bool outParamIsDeleted = default;
lcoServiceDeleteOrderByNumber result = new lcoServiceDeleteOrderByNumber();
lcvServiceDeleteOrderByNumber localVars = new lcvServiceDeleteOrderByNumber(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceDeleteOrderByNumber", "6486b1fb-113e-4e3b-8cbc-20d82a70cd66"))
using (activitySource.CreateServiceActionActivity("ServiceDeleteOrderByNumber")){
// DeleteOrderByNumber
localVars.resDeleteOrderByNumber.outParamIsDeleted = await Actions.ActionDeleteOrderByNumber(requestContext,localVars.inParamOrderNumber,cancellationToken);

// IsDeleted = DeleteOrderByNumber.IsDeleted
result.outParamIsDeleted=localVars.resDeleteOrderByNumber.outParamIsDeleted;
} //close CreateActionActivity using block
} // try

finally {
outParamIsDeleted = result.outParamIsDeleted;
} // inner-finally
RETURN_STATEMENT:
return outParamIsDeleted;
}

        public static class FuncActionServiceDeleteOrderByNumber {
            
        }
    }
}
