using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceGenerateInvoiceReportInput {
[JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("InvoiceName")]
public string inParamInvoiceName;
public S4PIServiceGenerateInvoiceReportInput(long? inParamInvoiceId, string inParamInvoiceName) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceName = inParamInvoiceName;
}

}

public class S4PIServiceGenerateInvoiceReportOutput {
public S4PIServiceGenerateInvoiceReportOutput() {
}

}

[HttpPost()]
[Route("serviceapi/servicegenerateinvoicereport")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGenerateInvoiceReport", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGenerateInvoiceReport(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGenerateInvoiceReportInput, S4PIServiceGenerateInvoiceReportOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIServiceGenerateInvoiceReportInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceId == null)) {
validationErrors["InvoiceId"]=new string[] {"The InvoiceId mandatory parameter is missing in the request."};
}

if((inputs.inParamInvoiceName == null)) {
validationErrors["InvoiceName"]=new string[] {"The InvoiceName mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionServiceGenerateInvoiceReport(context,inputs.inParamInvoiceId.Value,inputs.inParamInvoiceName,ctx);

return new S4PIServiceGenerateInvoiceReportOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGenerateInvoiceReport : VarsBag {
public long inParamInvoiceId;
public string inParamInvoiceName;
public lcvServiceGenerateInvoiceReport(long inParamInvoiceId, string inParamInvoiceName) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceName = inParamInvoiceName;
}
}
/// <summary>
/// Action <code>ServiceGenerateInvoiceReport</code> that represents the Service Studio action
///  <code>ServiceGenerateInvoiceReport</code> <p> Description: Generate Pdf Report related to a
/// n Invoice</p>
/// </summary>
public static async Task ActionServiceGenerateInvoiceReport(IRequestContext requestContext,long inParamInvoiceId,string inParamInvoiceName,CancellationToken cancellationToken) {
lcvServiceGenerateInvoiceReport localVars = new lcvServiceGenerateInvoiceReport(inParamInvoiceId, inParamInvoiceName);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGenerateInvoiceReport", "202426c1-e322-424d-8ef2-40fc0ba6bf62"))
using (activitySource.CreateServiceActionActivity("ServiceGenerateInvoiceReport")){
// GenerateInvoiceReport
await Actions.ActionGenerateInvoiceReport(requestContext,localVars.inParamInvoiceId,localVars.inParamInvoiceName,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionServiceGenerateInvoiceReport {
            
        }
    }
}
