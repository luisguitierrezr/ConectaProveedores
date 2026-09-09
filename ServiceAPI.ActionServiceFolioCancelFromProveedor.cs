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

    public class S4PIServiceFolioCancelFromProveedorInput {
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
public S4PIServiceFolioCancelFromProveedorInput(long? inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}

}

public class S4PIServiceFolioCancelFromProveedorOutput {
[JsonProperty("o_Output")]
public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
public S4PIServiceFolioCancelFromProveedorOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output) {
this.outParamo_Output = outParamo_Output;
}

}

[HttpPost()]
[Route("serviceapi/servicefoliocancelfromproveedor")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceFolioCancelFromProveedor", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceFolioCancelFromProveedor(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceFolioCancelFromProveedorInput, S4PIServiceFolioCancelFromProveedorOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
S4PIServiceFolioCancelFromProveedorInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_FolioId == null)) {
validationErrors["i_FolioId"]=new string[] {"The i_FolioId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_Output = await Flows.ActionServiceFolioCancelFromProveedor(context,inputs.inParami_FolioId.Value,ctx);

return new S4PIServiceFolioCancelFromProveedorOutput(JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_Output, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceFolioCancelFromProveedor : VarsBag {
public long inParami_FolioId;
public Actions.lcoFolioCancelFromProveedor resFolioCancelFromProveedor =  new Actions.lcoFolioCancelFromProveedor();
public lcvServiceFolioCancelFromProveedor(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
public class lcoServiceFolioCancelFromProveedor : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoServiceFolioCancelFromProveedor() {
}
}
/// <summary>
/// Action <code>ServiceFolioCancelFromProveedor</code> that represents the Service Studio action
///  <code>ServiceFolioCancelFromProveedor</code> <p> Description: Action to Cancel Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionServiceFolioCancelFromProveedor(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoServiceFolioCancelFromProveedor result = new lcoServiceFolioCancelFromProveedor();
lcvServiceFolioCancelFromProveedor localVars = new lcvServiceFolioCancelFromProveedor(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceFolioCancelFromProveedor", "7c021470-a903-4d07-abea-dc8a6afc0739"))
using (activitySource.CreateServiceActionActivity("ServiceFolioCancelFromProveedor")){
// FolioCancelFromProveedor
localVars.resFolioCancelFromProveedor.outParamo_Output = await Actions.ActionFolioCancelFromProveedor(requestContext,localVars.inParami_FolioId,cancellationToken);

// o_Output = FolioCancelFromProveedor.o_Output
result.outParamo_Output=localVars.resFolioCancelFromProveedor.outParamo_Output;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

        public static class FuncActionServiceFolioCancelFromProveedor {
            
        }
    }
}
