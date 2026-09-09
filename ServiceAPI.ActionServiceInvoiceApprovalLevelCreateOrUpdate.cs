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

    public class S4PIServiceInvoiceApprovalLevelCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource;
public S4PIServiceInvoiceApprovalLevelCreateOrUpdateInput(JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceInvoiceApprovalLevelCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceInvoiceApprovalLevelCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoiceapprovallevelcreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceApprovalLevelCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceApprovalLevelCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceApprovalLevelCreateOrUpdateInput, S4PIServiceInvoiceApprovalLevelCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceInvoiceApprovalLevelCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceInvoiceApprovalLevelCreateOrUpdate(context,JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceInvoiceApprovalLevelCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceApprovalLevelCreateOrUpdate : VarsBag {
public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource;
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public lcvServiceInvoiceApprovalLevelCreateOrUpdate(EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceInvoiceApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceInvoiceApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceApprovalLevelCreateOrUpdate</code> that represents the Service Studio
///  action <code>ServiceInvoiceApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceInvoiceApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceInvoiceApprovalLevelCreateOrUpdate result = new lcoServiceInvoiceApprovalLevelCreateOrUpdate();
lcvServiceInvoiceApprovalLevelCreateOrUpdate localVars = new lcvServiceInvoiceApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceApprovalLevelCreateOrUpdate", "7ead8177-eae2-4910-9361-328a68757a57"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceApprovalLevelCreateOrUpdate")){
// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.inParamSource,cancellationToken);

// Id = InvoiceApprovalLevelCreateOrUpdate.Id
result.outParamId=localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceInvoiceApprovalLevelCreateOrUpdate {
            
        }
    }
}
