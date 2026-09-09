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

    public class S4PIServiceOrderLogAddInput {
[JsonProperty("Source")]
public JSONEN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource;
public S4PIServiceOrderLogAddInput(JSONEN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceOrderLogAddOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceOrderLogAddOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceorderlogadd")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderLogAdd", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderLogAdd(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderLogAddInput, S4PIServiceOrderLogAddOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceOrderLogAddInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceOrderLogAdd(context,JSONEN_a8e484428097204171df8a1feecb2534EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceOrderLogAddOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderLogAdd : VarsBag {
public EN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource;
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public lcvServiceOrderLogAdd(EN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceOrderLogAdd : VarsBag {
public long outParamId = 0L;

public lcoServiceOrderLogAdd() {
}
}
/// <summary>
/// Action <code>ServiceOrderLogAdd</code> that represents the Service Studio action
///  <code>ServiceOrderLogAdd</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceOrderLogAdd(IRequestContext requestContext,EN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceOrderLogAdd result = new lcoServiceOrderLogAdd();
lcvServiceOrderLogAdd localVars = new lcvServiceOrderLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderLogAdd", "e5807760-d203-45ff-82b9-dcb76197b2ec"))
using (activitySource.CreateServiceActionActivity("ServiceOrderLogAdd")){
// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,localVars.inParamSource,cancellationToken);

// Id = OrderLogAdd.Id
result.outParamId=localVars.resOrderLogAdd.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceOrderLogAdd {
            
        }
    }
}
