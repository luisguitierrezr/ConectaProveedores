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

    public class S4PIServiceRequisitionLogAddInput {
[JsonProperty("Source")]
public JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource;
public S4PIServiceRequisitionLogAddInput(JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceRequisitionLogAddOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceRequisitionLogAddOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/servicerequisitionlogadd")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceRequisitionLogAdd", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceRequisitionLogAdd(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceRequisitionLogAddInput, S4PIServiceRequisitionLogAddOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceRequisitionLogAddInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceRequisitionLogAdd(context,JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceRequisitionLogAddOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceRequisitionLogAdd : VarsBag {
public EN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource;
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public lcvServiceRequisitionLogAdd(EN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceRequisitionLogAdd : VarsBag {
public long outParamId = 0L;

public lcoServiceRequisitionLogAdd() {
}
}
/// <summary>
/// Action <code>ServiceRequisitionLogAdd</code> that represents the Service Studio action
///  <code>ServiceRequisitionLogAdd</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceRequisitionLogAdd(IRequestContext requestContext,EN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceRequisitionLogAdd result = new lcoServiceRequisitionLogAdd();
lcvServiceRequisitionLogAdd localVars = new lcvServiceRequisitionLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceRequisitionLogAdd", "fcba76de-7bfc-4856-a977-f30a4d6f762a"))
using (activitySource.CreateServiceActionActivity("ServiceRequisitionLogAdd")){
// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,localVars.inParamSource,cancellationToken);

// Id = RequisitionLogAdd.Id
result.outParamId=localVars.resRequisitionLogAdd.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceRequisitionLogAdd {
            
        }
    }
}
