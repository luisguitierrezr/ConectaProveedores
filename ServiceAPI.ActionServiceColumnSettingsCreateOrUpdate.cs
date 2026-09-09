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

    public class S4PIServiceColumnSettingsCreateOrUpdateInput {
[JsonProperty("Source")]
public JSONEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource;
public S4PIServiceColumnSettingsCreateOrUpdateInput(JSONEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceColumnSettingsCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceColumnSettingsCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/servicecolumnsettingscreateorupdate")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceColumnSettingsCreateOrUpdate", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceColumnSettingsCreateOrUpdate(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceColumnSettingsCreateOrUpdateInput, S4PIServiceColumnSettingsCreateOrUpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceColumnSettingsCreateOrUpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceColumnSettingsCreateOrUpdate(context,JSONEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceColumnSettingsCreateOrUpdateOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceColumnSettingsCreateOrUpdate : VarsBag {
public EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource;
public Actions.lcoColumnSettingsCreateOrUpdate2 resColumnSettingsCreateOrUpdate2 =  new Actions.lcoColumnSettingsCreateOrUpdate2();
public lcvServiceColumnSettingsCreateOrUpdate(EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceColumnSettingsCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoServiceColumnSettingsCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ServiceColumnSettingsCreateOrUpdate</code> that represents the Service Studio action
///  <code>ServiceColumnSettingsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionServiceColumnSettingsCreateOrUpdate(IRequestContext requestContext,EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceColumnSettingsCreateOrUpdate result = new lcoServiceColumnSettingsCreateOrUpdate();
lcvServiceColumnSettingsCreateOrUpdate localVars = new lcvServiceColumnSettingsCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceColumnSettingsCreateOrUpdate", "a22344df-1471-46b2-83b2-e6bbecfcbcfa"))
using (activitySource.CreateServiceActionActivity("ServiceColumnSettingsCreateOrUpdate")){
// ColumnSettingsCreateOrUpdate2
localVars.resColumnSettingsCreateOrUpdate2.outParamId = await Actions.ActionColumnSettingsCreateOrUpdate2(requestContext,localVars.inParamSource,cancellationToken);

// Id = ColumnSettingsCreateOrUpdate2.Id
result.outParamId=localVars.resColumnSettingsCreateOrUpdate2.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceColumnSettingsCreateOrUpdate {
            
        }
    }
}
