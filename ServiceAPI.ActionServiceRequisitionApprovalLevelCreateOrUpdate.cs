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

    public class S4PIServiceRequisitionApprovalLevelCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource;
public S4PIServiceRequisitionApprovalLevelCreateOrUpdateInput(JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceRequisitionApprovalLevelCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceRequisitionApprovalLevelCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/servicerequisitionapprovallevelcreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceRequisitionApprovalLevelCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceRequisitionApprovalLevelCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceRequisitionApprovalLevelCreateOrUpdateInput, S4PIServiceRequisitionApprovalLevelCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceRequisitionApprovalLevelCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceRequisitionApprovalLevelCreateOrUpdate(context,JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceRequisitionApprovalLevelCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceRequisitionApprovalLevelCreateOrUpdate : VarsBag {
public EN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource;
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public lcvServiceRequisitionApprovalLevelCreateOrUpdate(EN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceRequisitionApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceRequisitionApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceRequisitionApprovalLevelCreateOrUpdate</code> that represents the Service
///  Studio action <code>ServiceRequisitionApprovalLevelCreateOrUpdate</code> <p> Description
/// : Encapsulates the CreateOrUpdate entity action, enabling logic to run consistently before and
///  after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceRequisitionApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceRequisitionApprovalLevelCreateOrUpdate result = new lcoServiceRequisitionApprovalLevelCreateOrUpdate();
lcvServiceRequisitionApprovalLevelCreateOrUpdate localVars = new lcvServiceRequisitionApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceRequisitionApprovalLevelCreateOrUpdate", "eb40c634-17ba-424e-87f2-85af00ca95ff"))
using (activitySource.CreateServiceActionActivity("ServiceRequisitionApprovalLevelCreateOrUpdate")){
// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = RequisitionApprovalLevelCreateOrUpdate.Id
result.outParamId=localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceRequisitionApprovalLevelCreateOrUpdate {
            
        }
    }
}
