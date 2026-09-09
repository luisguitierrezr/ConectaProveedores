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

    public class S4PIServiceOrderAccConceptsCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource;
public S4PIServiceOrderAccConceptsCreateOrUpdateInput(JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceOrderAccConceptsCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceOrderAccConceptsCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceorderaccconceptscreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderAccConceptsCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderAccConceptsCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderAccConceptsCreateOrUpdateInput, S4PIServiceOrderAccConceptsCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceOrderAccConceptsCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceOrderAccConceptsCreateOrUpdate(context,JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceOrderAccConceptsCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderAccConceptsCreateOrUpdate : VarsBag {
public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource;
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public lcvServiceOrderAccConceptsCreateOrUpdate(EN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceOrderAccConceptsCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceOrderAccConceptsCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceOrderAccConceptsCreateOrUpdate</code> that represents the Service Studio action
///  <code>ServiceOrderAccConceptsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionServiceOrderAccConceptsCreateOrUpdate(IRequestContext requestContext,EN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceOrderAccConceptsCreateOrUpdate result = new lcoServiceOrderAccConceptsCreateOrUpdate();
lcvServiceOrderAccConceptsCreateOrUpdate localVars = new lcvServiceOrderAccConceptsCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderAccConceptsCreateOrUpdate", "e278ddd2-6f6d-4d2f-9998-fe6a031d318f"))
using (activitySource.CreateServiceActionActivity("ServiceOrderAccConceptsCreateOrUpdate")){
// OrderAccConceptsCreateOrUpdate
localVars.resOrderAccConceptsCreateOrUpdate.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = OrderAccConceptsCreateOrUpdate.Id
result.outParamId=localVars.resOrderAccConceptsCreateOrUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceOrderAccConceptsCreateOrUpdate {
            
        }
    }
}
