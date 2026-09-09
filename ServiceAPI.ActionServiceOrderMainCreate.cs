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

    public class S4PIServiceOrderMainCreateInput {
[JsonProperty("Source")]
public JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource;
public S4PIServiceOrderMainCreateInput(JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceOrderMainCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceOrderMainCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceordermaincreate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderMainCreate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderMainCreate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderMainCreateInput, S4PIServiceOrderMainCreateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceOrderMainCreateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceOrderMainCreate(context,JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceOrderMainCreateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderMainCreate : VarsBag {
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource;
public Actions.lcoOrderMainCreate resOrderMainCreate =  new Actions.lcoOrderMainCreate();
public lcvServiceOrderMainCreate(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceOrderMainCreate : VarsBag {
public long outParamId = 0L;

public lcoServiceOrderMainCreate() {
}
}
/// <summary>
/// Action <code>ServiceOrderMainCreate</code> that represents the Service Studio action
///  <code>ServiceOrderMainCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionServiceOrderMainCreate(IRequestContext requestContext,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceOrderMainCreate result = new lcoServiceOrderMainCreate();
lcvServiceOrderMainCreate localVars = new lcvServiceOrderMainCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderMainCreate", "ce121e71-de98-4387-bdf1-a1c384f91cf4"))
using (activitySource.CreateServiceActionActivity("ServiceOrderMainCreate")){
// OrderMainCreate
localVars.resOrderMainCreate.outParamId = await Actions.ActionOrderMainCreate(requestContext,localVars.inParamSource,cancellationToken);

// Id = OrderMainCreate.Id
result.outParamId=localVars.resOrderMainCreate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceOrderMainCreate {
            
        }
    }
}
