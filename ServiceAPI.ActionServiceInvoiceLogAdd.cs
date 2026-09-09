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

    public class S4PIServiceInvoiceLogAddInput {
[JsonProperty("Source")]
public JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource;
public S4PIServiceInvoiceLogAddInput(JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceInvoiceLogAddOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceInvoiceLogAddOutput(long outParamId) {
this.outParamId = outParamId;
}

}

[HttpPost()]
[Route("serviceapi/serviceinvoicelogadd")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceInvoiceLogAdd", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceInvoiceLogAdd(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceInvoiceLogAddInput, S4PIServiceInvoiceLogAddOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamId;
S4PIServiceInvoiceLogAddInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamSource == null)) {
validationErrors["Source"]=new string[] {"The Source mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamId = await Flows.ActionServiceInvoiceLogAdd(context,JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.ToStructure(inputs.inParamSource, behaviorsConfiguration),ctx);

return new S4PIServiceInvoiceLogAddOutput(outParamId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceInvoiceLogAdd : VarsBag {
public EN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource;
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public lcvServiceInvoiceLogAdd(EN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoServiceInvoiceLogAdd : VarsBag {
public long outParamId = 0L;

public lcoServiceInvoiceLogAdd() {
}
}
/// <summary>
/// Action <code>ServiceInvoiceLogAdd</code> that represents the Service Studio action
///  <code>ServiceInvoiceLogAdd</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionServiceInvoiceLogAdd(IRequestContext requestContext,EN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoServiceInvoiceLogAdd result = new lcoServiceInvoiceLogAdd();
lcvServiceInvoiceLogAdd localVars = new lcvServiceInvoiceLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceInvoiceLogAdd", "7c25fbca-69c5-4006-814f-ce4964487a19"))
using (activitySource.CreateServiceActionActivity("ServiceInvoiceLogAdd")){
// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,localVars.inParamSource,cancellationToken);

// Id = InvoiceLogAdd.Id
result.outParamId=localVars.resInvoiceLogAdd.outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

        public static class FuncActionServiceInvoiceLogAdd {
            
        }
    }
}
