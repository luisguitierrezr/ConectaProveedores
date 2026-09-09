using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGetUserSupplierInput {
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceGetUserSupplierInput(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetUserSupplierOutput {
[JsonProperty("o_SupplierId")]
public long outParamo_SupplierId;
public S4PIServiceGetUserSupplierOutput(long outParamo_SupplierId) {
this.outParamo_SupplierId = outParamo_SupplierId;
}

}

[HttpPost()]
[Route("serviceapi/servicegetusersupplier")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetUserSupplier", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetUserSupplier(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetUserSupplierInput, S4PIServiceGetUserSupplierOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamo_SupplierId;
S4PIServiceGetUserSupplierInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_SupplierId = await Flows.ActionServiceGetUserSupplier(context,inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetUserSupplierOutput(outParamo_SupplierId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetUserSupplier : VarsBag {
public string inParami_GetUserId;
public Actions.lcoGetUserSupplier resGetUserSupplier =  new Actions.lcoGetUserSupplier();
public lcvServiceGetUserSupplier(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetUserSupplier : VarsBag {
public long outParamo_SupplierId = 0L;

public lcoServiceGetUserSupplier() {
}
}
/// <summary>
/// Action <code>ServiceGetUserSupplier</code> that represents the Service Studio action
///  <code>ServiceGetUserSupplier</code> <p> Description: Action to get SupplierId from curren
/// t user</p>
/// </summary>
public static async Task<long> ActionServiceGetUserSupplier(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_SupplierId = default;
lcoServiceGetUserSupplier result = new lcoServiceGetUserSupplier();
lcvServiceGetUserSupplier localVars = new lcvServiceGetUserSupplier(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetUserSupplier", "ad4a28d5-77ec-4489-9b81-9f243c8420e4"))
using (activitySource.CreateServiceActionActivity("ServiceGetUserSupplier")){
// GetUserSupplier
localVars.resGetUserSupplier.outParamo_SupplierId = await Actions.ActionGetUserSupplier(requestContext,localVars.inParami_GetUserId,cancellationToken);

// o_SupplierId = GetUserSupplier.o_SupplierId
result.outParamo_SupplierId=localVars.resGetUserSupplier.outParamo_SupplierId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_SupplierId = result.outParamo_SupplierId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_SupplierId;
}

        public static class FuncActionServiceGetUserSupplier {
            
        }
    }
}
