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

    public class S4PIFolio_CreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource;
public S4PIFolio_CreateOrUpdateInput(JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIFolio_CreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIFolio_CreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/folio_createorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "Folio_CreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIFolio_CreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIFolio_CreateOrUpdateInput, S4PIFolio_CreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIFolio_CreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionFolio_CreateOrUpdate(context,JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIFolio_CreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvFolio_CreateOrUpdate : VarsBag {
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource;
public long resCreateOrUpdateFolio_outParamId = 0L;

public lcvFolio_CreateOrUpdate(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoFolio_CreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoFolio_CreateOrUpdate() {
}
}
/// <summary>
/// Action <code>Folio_CreateOrUpdate</code> that represents the Service Studio action
///  <code>Folio_CreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionFolio_CreateOrUpdate(IRequestContext requestContext,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoFolio_CreateOrUpdate result = new lcoFolio_CreateOrUpdate();
lcvFolio_CreateOrUpdate localVars = new lcvFolio_CreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("Folio_CreateOrUpdate", "8766acb3-d316-4f68-9d23-1c5c5d5ae54b"))
using (activitySource.CreateServiceActionActivity("Folio_CreateOrUpdate")){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateFolio
localVars.resCreateOrUpdateFolio_outParamId = await ExtendedActions.CreateOrUpdateFolio(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_cfeb2cf80ab683e7d9a9b5d02d9c9526)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFolio.Id
result.outParamId=localVars.resCreateOrUpdateFolio_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionFolio_CreateOrUpdate {
            
        }
    }
}
