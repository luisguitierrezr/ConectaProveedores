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

    public class S4PIServiceLogsAccountingCreateInput {
[JsonProperty("Source")]
public JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource;
public S4PIServiceLogsAccountingCreateInput(JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceLogsAccountingCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceLogsAccountingCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/servicelogsaccountingcreate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceLogsAccountingCreate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceLogsAccountingCreate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceLogsAccountingCreateInput, S4PIServiceLogsAccountingCreateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceLogsAccountingCreateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceLogsAccountingCreate(context,JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceLogsAccountingCreateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceLogsAccountingCreate : VarsBag {
public EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public lcvServiceLogsAccountingCreate(EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceLogsAccountingCreate : VarsBag {
public long outParamId = 0L;

public lcoServiceLogsAccountingCreate() {
}
}
/// <summary>
/// Action <code>ServiceLogsAccountingCreate</code> that represents the Service Studio action
///  <code>ServiceLogsAccountingCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionServiceLogsAccountingCreate(IRequestContext requestContext,EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceLogsAccountingCreate result = new lcoServiceLogsAccountingCreate();
lcvServiceLogsAccountingCreate localVars = new lcvServiceLogsAccountingCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceLogsAccountingCreate", "2fc84310-a9c7-47c1-99c9-a2e9b3329259"))
using (activitySource.CreateServiceActionActivity("ServiceLogsAccountingCreate")){
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,localVars.inParamSource,cancellationToken);

// Id = LogsAccountingCreate.Id
result.outParamId=localVars.resLogsAccountingCreate.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceLogsAccountingCreate {
            
        }
    }
}
