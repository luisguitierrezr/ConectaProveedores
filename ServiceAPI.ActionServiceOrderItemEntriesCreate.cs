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

    public class S4PIServiceOrderItemEntriesCreateInput {
[JsonProperty("Source")]
public JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource;
public S4PIServiceOrderItemEntriesCreateInput(JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceOrderItemEntriesCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceOrderItemEntriesCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceorderitementriescreate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderItemEntriesCreate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderItemEntriesCreate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderItemEntriesCreateInput, S4PIServiceOrderItemEntriesCreateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceOrderItemEntriesCreateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceOrderItemEntriesCreate(context,JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceOrderItemEntriesCreateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderItemEntriesCreate : VarsBag {
public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource;
public Actions.lcoOrderItemEntriesCreate resOrderItemEntriesCreate =  new Actions.lcoOrderItemEntriesCreate();
public lcvServiceOrderItemEntriesCreate(EN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceOrderItemEntriesCreate : VarsBag {
public long outParamId = 0L;

public lcoServiceOrderItemEntriesCreate() {
}
}
/// <summary>
/// Action <code>ServiceOrderItemEntriesCreate</code> that represents the Service Studio action
///  <code>ServiceOrderItemEntriesCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionServiceOrderItemEntriesCreate(IRequestContext requestContext,EN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceOrderItemEntriesCreate result = new lcoServiceOrderItemEntriesCreate();
lcvServiceOrderItemEntriesCreate localVars = new lcvServiceOrderItemEntriesCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderItemEntriesCreate", "d1f2cd14-85b7-4a8a-bfa6-bb283f42986f"))
using (activitySource.CreateServiceActionActivity("ServiceOrderItemEntriesCreate")){
// OrderItemEntriesCreate
localVars.resOrderItemEntriesCreate.outParamId = await Actions.ActionOrderItemEntriesCreate(requestContext,localVars.inParamSource,cancellationToken);

// Id = OrderItemEntriesCreate.Id
result.outParamId=localVars.resOrderItemEntriesCreate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceOrderItemEntriesCreate {
            
        }
    }
}
