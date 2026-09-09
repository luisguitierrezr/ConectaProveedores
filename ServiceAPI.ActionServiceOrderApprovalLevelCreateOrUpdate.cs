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

    public class S4PIServiceOrderApprovalLevelCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource;
public S4PIServiceOrderApprovalLevelCreateOrUpdateInput(JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceOrderApprovalLevelCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceOrderApprovalLevelCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceorderapprovallevelcreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderApprovalLevelCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderApprovalLevelCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderApprovalLevelCreateOrUpdateInput, S4PIServiceOrderApprovalLevelCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceOrderApprovalLevelCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceOrderApprovalLevelCreateOrUpdate(context,JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceOrderApprovalLevelCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderApprovalLevelCreateOrUpdate : VarsBag {
public EN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource;
public Actions.lcoOrderApprovalLevelCreateOrUpdate resOrderApprovalLevelCreateOrUpdate =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public lcvServiceOrderApprovalLevelCreateOrUpdate(EN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceOrderApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceOrderApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceOrderApprovalLevelCreateOrUpdate</code> that represents the Service Studio
///  action <code>ServiceOrderApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceOrderApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceOrderApprovalLevelCreateOrUpdate result = new lcoServiceOrderApprovalLevelCreateOrUpdate();
lcvServiceOrderApprovalLevelCreateOrUpdate localVars = new lcvServiceOrderApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderApprovalLevelCreateOrUpdate", "2c42d0df-391b-4528-b073-a4e011371faf"))
using (activitySource.CreateServiceActionActivity("ServiceOrderApprovalLevelCreateOrUpdate")){
// OrderApprovalLevelCreateOrUpdate
localVars.resOrderApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = OrderApprovalLevelCreateOrUpdate.Id
result.outParamId=localVars.resOrderApprovalLevelCreateOrUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceOrderApprovalLevelCreateOrUpdate {
            
        }
    }
}
