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

    public class S4PIServiceInvoiceCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource;
[JsonProperty("IsStartApproval")]
public bool? inParamIsStartApproval;
public S4PIServiceInvoiceCreateOrUpdateInput(JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource, bool? inParamIsStartApproval) {
this.inParamSource = inParamSource;
this.inParamIsStartApproval = inParamIsStartApproval;
}

public S4PIServiceInvoiceCreateOrUpdateInput() {
this.inParamIsStartApproval = false;
}

}

public class S4PIServiceInvoiceCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceInvoiceCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoicecreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceCreateOrUpdateInput, S4PIServiceInvoiceCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceInvoiceCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
inputs.inParamIsStartApproval = (inputs.inParamIsStartApproval ?? false);
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceInvoiceCreateOrUpdate(context,JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),inputs.inParamIsStartApproval.Value,ctx);

return new S4PIServiceInvoiceCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceCreateOrUpdate : VarsBag {
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource;
public bool inParamIsStartApproval;
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public lcvServiceInvoiceCreateOrUpdate(EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource, bool inParamIsStartApproval) {
this.inParamSource = inParamSource;
this.inParamIsStartApproval = inParamIsStartApproval;
}
}
public class lcoServiceInvoiceCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceInvoiceCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceCreateOrUpdate</code> that represents the Service Studio action
///  <code>ServiceInvoiceCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceInvoiceCreateOrUpdate(IRequestContext requestContext,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource,bool inParamIsStartApproval,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceInvoiceCreateOrUpdate result = new lcoServiceInvoiceCreateOrUpdate();
lcvServiceInvoiceCreateOrUpdate localVars = new lcvServiceInvoiceCreateOrUpdate(inParamSource, inParamIsStartApproval);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceCreateOrUpdate", "cc25019a-9875-44f2-8fb8-0e14b7f01664"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceCreateOrUpdate")){
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.inParamSource,localVars.inParamIsStartApproval,cancellationToken);

// Id = InvoiceCreateOrUpdate.Id
result.outParamId=localVars.resInvoiceCreateOrUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceInvoiceCreateOrUpdate {
            
        }
    }
}
