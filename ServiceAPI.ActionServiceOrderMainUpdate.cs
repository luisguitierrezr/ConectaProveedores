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

    public class S4PIServiceOrderMainUpdateInput {
[JsonProperty("Source")]
public JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource;
public S4PIServiceOrderMainUpdateInput(JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceOrderMainUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceOrderMainUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceordermainupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderMainUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderMainUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderMainUpdateInput, S4PIServiceOrderMainUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceOrderMainUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceOrderMainUpdate(context,JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceOrderMainUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderMainUpdate : VarsBag {
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource;
public Actions.lcoOrderMainUpdate resOrderMainUpdate =  new Actions.lcoOrderMainUpdate();
public lcvServiceOrderMainUpdate(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceOrderMainUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceOrderMainUpdate() {
}
}
/// <summary>
/// Action <code>ServiceOrderMainUpdate</code> that represents the Service Studio action
///  <code>ServiceOrderMainUpdate</code> <p> Description: Encapsulates the Update entity action
/// , enabling logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionServiceOrderMainUpdate(IRequestContext requestContext,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceOrderMainUpdate result = new lcoServiceOrderMainUpdate();
lcvServiceOrderMainUpdate localVars = new lcvServiceOrderMainUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderMainUpdate", "840176f1-e659-4634-a32f-d73e91625b29"))
using (activitySource.CreateServiceActionActivity("ServiceOrderMainUpdate")){
// OrderMainUpdate
localVars.resOrderMainUpdate.outParamId = await Actions.ActionOrderMainUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = OrderMainUpdate.Id
result.outParamId=localVars.resOrderMainUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceOrderMainUpdate {
            
        }
    }
}
