using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceDeleteRequisitionTablesByIdInput {
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
public S4PIServiceDeleteRequisitionTablesByIdInput(long? inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}

}

public class S4PIServiceDeleteRequisitionTablesByIdOutput {
public S4PIServiceDeleteRequisitionTablesByIdOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicedeleterequisitiontablesbyid")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceDeleteRequisitionTablesById", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceDeleteRequisitionTablesById(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceDeleteRequisitionTablesByIdInput, S4PIServiceDeleteRequisitionTablesByIdOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceDeleteRequisitionTablesByIdInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamRequisitionId == null)) {
validationErrors["RequisitionId"]=new string[] {"The RequisitionId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceDeleteRequisitionTablesById(context,inputs.inParamRequisitionId.Value,ctx);

return new S4PIServiceDeleteRequisitionTablesByIdOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceDeleteRequisitionTablesById : VarsBag {
public long inParamRequisitionId;
public lcvServiceDeleteRequisitionTablesById(long inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}
}
/// <summary>
/// Action <code>ServiceDeleteRequisitionTablesById</code> that represents the Service Studio action
///  <code>ServiceDeleteRequisitionTablesById</code> <p> Description: </p>
/// </summary>
public static async Task ActionServiceDeleteRequisitionTablesById(IRequestContext requestContext,long inParamRequisitionId,CancellationToken cancellationToken) {
lcvServiceDeleteRequisitionTablesById localVars = new lcvServiceDeleteRequisitionTablesById(inParamRequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceDeleteRequisitionTablesById", "3d2126f6-c77c-4058-885d-9307c737b1bc"))
using (activitySource.CreateServiceActionActivity("ServiceDeleteRequisitionTablesById")){
// DeleteRequisitionTablesById
await Actions.ActionDeleteRequisitionTablesById(requestContext,localVars.inParamRequisitionId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceDeleteRequisitionTablesById {
            
        }
    }
}
