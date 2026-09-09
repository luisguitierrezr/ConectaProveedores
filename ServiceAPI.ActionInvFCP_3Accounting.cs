using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvFCP_3AccountingInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
[JsonProperty("ExchangeRate")]
public decimal? inParamExchangeRate;
[JsonProperty("IsMIRO")]
public bool? inParamIsMIRO;
public S4PIInvFCP_3AccountingInput(long? inParamInvoiceAccountingProcessId, decimal? inParamExchangeRate, bool? inParamIsMIRO) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamExchangeRate = inParamExchangeRate;
this.inParamIsMIRO = inParamIsMIRO;
}

}

public class S4PIInvFCP_3AccountingOutput {
[JsonProperty("IsSuccess")]
public bool outParamIsSuccess;
[JsonProperty("Message")]
public string outParamMessage;
public S4PIInvFCP_3AccountingOutput(bool outParamIsSuccess, string outParamMessage) {
this.outParamIsSuccess = outParamIsSuccess;
this.outParamMessage = outParamMessage;
}

public bool ShouldSerializeoutParamIsSuccess() {return (this.outParamIsSuccess != true);
}
}

[HttpPost()]
[Route("serviceapi/invfcp_3accounting")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvFCP_3Accounting", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvFCP_3Accounting(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvFCP_3AccountingInput, S4PIInvFCP_3AccountingOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsSuccess;
string outParamMessage;
S4PIInvFCP_3AccountingInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if((inputs.inParamExchangeRate == null)) {
validationErrors["ExchangeRate"]=new string[] {"The ExchangeRate mandatory parameter is missing in the request."};
}

if((inputs.inParamIsMIRO == null)) {
validationErrors["IsMIRO"]=new string[] {"The IsMIRO mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamIsSuccess,outParamMessage) = await Flows.ActionInvFCP_3Accounting(context,inputs.inParamInvoiceAccountingProcessId.Value,inputs.inParamExchangeRate.Value,inputs.inParamIsMIRO.Value,ctx);

return new S4PIInvFCP_3AccountingOutput(outParamIsSuccess, outParamMessage);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvFCP_3Accounting : VarsBag {
public long inParamInvoiceAccountingProcessId;
public decimal inParamExchangeRate;
public bool inParamIsMIRO;
public Actions.lcoEntryAccountingInvProcess_F43 resEntryAccountingInvProcess_F43 =  new Actions.lcoEntryAccountingInvProcess_F43();
public Actions.lcoEntryAccountingInvProcess_MIRO resEntryAccountingInvProcess_MIRO =  new Actions.lcoEntryAccountingInvProcess_MIRO();
public lcvInvFCP_3Accounting(long inParamInvoiceAccountingProcessId, decimal inParamExchangeRate, bool inParamIsMIRO) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamExchangeRate = inParamExchangeRate;
this.inParamIsMIRO = inParamIsMIRO;
}
}
public class lcoInvFCP_3Accounting : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public lcoInvFCP_3Accounting() {
}
}
/// <summary>
/// Action <code>InvFCP_3Accounting</code> that represents the Service Studio action
///  <code>InvFCP_3Accounting</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string)> ActionInvFCP_3Accounting(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,decimal inParamExchangeRate,bool inParamIsMIRO,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
lcoInvFCP_3Accounting result = new lcoInvFCP_3Accounting();
lcvInvFCP_3Accounting localVars = new lcvInvFCP_3Accounting(inParamInvoiceAccountingProcessId, inParamExchangeRate, inParamIsMIRO);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvFCP_3Accounting", "9bb05e31-6e53-47fa-9b41-2a0a704f89cc"))
using (activitySource.CreateServiceActionActivity("InvFCP_3Accounting")){
if((localVars.inParamIsMIRO)) {
// EntryAccountingInvProcess_MIRO
(localVars.resEntryAccountingInvProcess_MIRO.outParamIsSuccess,localVars.resEntryAccountingInvProcess_MIRO.outParamMessage) = await Actions.ActionEntryAccountingInvProcess_MIRO(requestContext,localVars.inParamInvoiceAccountingProcessId,localVars.inParamExchangeRate,cancellationToken);

// IsSuccess = EntryAccountingInvProcess_MIRO.IsSuccess
result.outParamIsSuccess=localVars.resEntryAccountingInvProcess_MIRO.outParamIsSuccess;

// Message = EntryAccountingInvProcess_MIRO.Message
result.outParamMessage=localVars.resEntryAccountingInvProcess_MIRO.outParamMessage;
} else {
// EntryAccountingInvProcess_F43
(localVars.resEntryAccountingInvProcess_F43.outParamIsSuccess,localVars.resEntryAccountingInvProcess_F43.outParamMessage) = await Actions.ActionEntryAccountingInvProcess_F43(requestContext,localVars.inParamInvoiceAccountingProcessId,localVars.inParamExchangeRate,cancellationToken);

// IsSuccess = EntryAccountingInvProcess_F43.IsSuccess
result.outParamIsSuccess=localVars.resEntryAccountingInvProcess_F43.outParamIsSuccess;

// Message = EntryAccountingInvProcess_F43.Message
result.outParamMessage=localVars.resEntryAccountingInvProcess_F43.outParamMessage;
}

} //close CreateActionActivity using block
} // try

finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage);
}

        public static class FuncActionInvFCP_3Accounting {
            
        }
    }
}
