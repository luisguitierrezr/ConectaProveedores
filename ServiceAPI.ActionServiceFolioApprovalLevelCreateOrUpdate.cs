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

    public class S4PIServiceFolioApprovalLevelCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource;
public S4PIServiceFolioApprovalLevelCreateOrUpdateInput(JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceFolioApprovalLevelCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceFolioApprovalLevelCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/servicefolioapprovallevelcreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceFolioApprovalLevelCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceFolioApprovalLevelCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceFolioApprovalLevelCreateOrUpdateInput, S4PIServiceFolioApprovalLevelCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceFolioApprovalLevelCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceFolioApprovalLevelCreateOrUpdate(context,JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceFolioApprovalLevelCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceFolioApprovalLevelCreateOrUpdate : VarsBag {
public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource;
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public lcvServiceFolioApprovalLevelCreateOrUpdate(EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceFolioApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceFolioApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceFolioApprovalLevelCreateOrUpdate</code> that represents the Service Studio
///  action <code>ServiceFolioApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceFolioApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceFolioApprovalLevelCreateOrUpdate result = new lcoServiceFolioApprovalLevelCreateOrUpdate();
lcvServiceFolioApprovalLevelCreateOrUpdate localVars = new lcvServiceFolioApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceFolioApprovalLevelCreateOrUpdate", "82b259dc-87b9-4596-abbd-cd7d625f731b"))
using (activitySource.CreateServiceActionActivity("ServiceFolioApprovalLevelCreateOrUpdate")){
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = FolioApprovalLevelCreateOrUpdate.Id
result.outParamId=localVars.resFolioApprovalLevelCreateOrUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceFolioApprovalLevelCreateOrUpdate {
            
        }
    }
}
