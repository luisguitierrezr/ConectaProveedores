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

    public class S4PIServiceFolioLogAddInput {
[JsonProperty("Source")]
public JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource;
public S4PIServiceFolioLogAddInput(JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceFolioLogAddOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceFolioLogAddOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/servicefoliologadd")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceFolioLogAdd", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceFolioLogAdd(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceFolioLogAddInput, S4PIServiceFolioLogAddOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceFolioLogAddInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceFolioLogAdd(context,JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceFolioLogAddOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceFolioLogAdd : VarsBag {
public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource;
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public lcvServiceFolioLogAdd(EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceFolioLogAdd : VarsBag {
public long outParamId = 0L;

public lcoServiceFolioLogAdd() {
}
}
/// <summary>
/// Action <code>ServiceFolioLogAdd</code> that represents the Service Studio action
///  <code>ServiceFolioLogAdd</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceFolioLogAdd(IRequestContext requestContext,EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceFolioLogAdd result = new lcoServiceFolioLogAdd();
lcvServiceFolioLogAdd localVars = new lcvServiceFolioLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceFolioLogAdd", "f577651d-8370-44ce-b20c-4ab44fee3ed6"))
using (activitySource.CreateServiceActionActivity("ServiceFolioLogAdd")){
// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,localVars.inParamSource,cancellationToken);

// Id = FolioLogAdd.Id
result.outParamId=localVars.resFolioLogAdd.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceFolioLogAdd {
            
        }
    }
}
