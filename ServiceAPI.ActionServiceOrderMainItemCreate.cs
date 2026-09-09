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

    public class S4PIServiceOrderMainItemCreateInput {
[JsonProperty("Source")]
public JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource;
public S4PIServiceOrderMainItemCreateInput(JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceOrderMainItemCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceOrderMainItemCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceordermainitemcreate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderMainItemCreate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderMainItemCreate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderMainItemCreateInput, S4PIServiceOrderMainItemCreateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceOrderMainItemCreateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceOrderMainItemCreate(context,JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceOrderMainItemCreateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderMainItemCreate : VarsBag {
public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource;
public Actions.lcoOrderMainItemCreate resOrderMainItemCreate =  new Actions.lcoOrderMainItemCreate();
public lcvServiceOrderMainItemCreate(EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceOrderMainItemCreate : VarsBag {
public long outParamId = 0L;

public lcoServiceOrderMainItemCreate() {
}
}
/// <summary>
/// Action <code>ServiceOrderMainItemCreate</code> that represents the Service Studio action
///  <code>ServiceOrderMainItemCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionServiceOrderMainItemCreate(IRequestContext requestContext,EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceOrderMainItemCreate result = new lcoServiceOrderMainItemCreate();
lcvServiceOrderMainItemCreate localVars = new lcvServiceOrderMainItemCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderMainItemCreate", "99dbcc34-56b1-438d-8a5e-b2ed9aed53a7"))
using (activitySource.CreateServiceActionActivity("ServiceOrderMainItemCreate")){
// OrderMainItemCreate
localVars.resOrderMainItemCreate.outParamId = await Actions.ActionOrderMainItemCreate(requestContext,localVars.inParamSource,cancellationToken);

// Id = OrderMainItemCreate.Id
result.outParamId=localVars.resOrderMainItemCreate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceOrderMainItemCreate {
            
        }
    }
}
