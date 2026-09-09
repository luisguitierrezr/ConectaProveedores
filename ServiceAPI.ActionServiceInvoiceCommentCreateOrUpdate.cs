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

    public class S4PIServiceInvoiceCommentCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure inParamSource;
public S4PIServiceInvoiceCommentCreateOrUpdateInput(JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceInvoiceCommentCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceInvoiceCommentCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoicecommentcreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceCommentCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceCommentCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceCommentCreateOrUpdateInput, S4PIServiceInvoiceCommentCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceInvoiceCommentCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceInvoiceCommentCreateOrUpdate(context,JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceInvoiceCommentCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceCommentCreateOrUpdate : VarsBag {
public ST_f1259a41db43b1c9d9faa83c38ada6a7Structure inParamSource;
public Actions.lcoInvoiceCommentCreateOrUpdate resInvoiceCommentCreateOrUpdate =  new Actions.lcoInvoiceCommentCreateOrUpdate();
public lcvServiceInvoiceCommentCreateOrUpdate(ST_f1259a41db43b1c9d9faa83c38ada6a7Structure inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceInvoiceCommentCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceInvoiceCommentCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceCommentCreateOrUpdate</code> that represents the Service Studio action
///  <code>ServiceInvoiceCommentCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionServiceInvoiceCommentCreateOrUpdate(IRequestContext requestContext,ST_f1259a41db43b1c9d9faa83c38ada6a7Structure inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceInvoiceCommentCreateOrUpdate result = new lcoServiceInvoiceCommentCreateOrUpdate();
lcvServiceInvoiceCommentCreateOrUpdate localVars = new lcvServiceInvoiceCommentCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceCommentCreateOrUpdate", "37dc86fc-09d2-4078-a068-19d2da37088f"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceCommentCreateOrUpdate")){
// InvoiceCommentCreateOrUpdate
localVars.resInvoiceCommentCreateOrUpdate.outParamId = await Actions.ActionInvoiceCommentCreateOrUpdate(requestContext,(await RecordUtils.ConvertAsync(localVars.inParamSource, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), async (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure source, EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord target, CancellationToken cancellationToken) => {
target.ssId = BuiltInFunction.LongIntegerToIdentifier (source.ssId);
target.ssInvoiceId = source.ssInvoiceId;
target.ssInvoiceApprovalLevelId = source.ssInvoiceApprovalLevelId;
target.ssApplicationRoleId = source.ssApplicationRoleId;
target.ssCreatedOn = source.ssCreatedOn;
target.ssCreatedBy = source.ssCreatedBy;
target.ssMessage = source.ssMessage;
target.ssIsPublic = source.ssIsPublic;
return target;
}, cancellationToken)),cancellationToken);

// Id = InvoiceCommentCreateOrUpdate.Id
result.outParamId=localVars.resInvoiceCommentCreateOrUpdate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceInvoiceCommentCreateOrUpdate {
            
        }
    }
}
