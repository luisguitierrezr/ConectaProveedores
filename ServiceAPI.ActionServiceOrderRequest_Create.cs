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

    public class S4PIServiceOrderRequest_CreateInput {
[JsonProperty("Request")]
public JSONST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest;
[JsonProperty("AllowCreation")]
public bool? inParamAllowCreation;
public S4PIServiceOrderRequest_CreateInput(JSONST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest, bool? inParamAllowCreation) {
this.inParamRequest = inParamRequest;
this.inParamAllowCreation = inParamAllowCreation;
}

}

public class S4PIServiceOrderRequest_CreateOutput {
[JsonProperty("Response")]
public JSONST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse;
public S4PIServiceOrderRequest_CreateOutput(JSONST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

[HttpPost()]
[Route("serviceapi/serviceorderrequest_create")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrderRequest_Create", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrderRequest_Create(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrderRequest_CreateInput, S4PIServiceOrderRequest_CreateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse;
S4PIServiceOrderRequest_CreateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamRequest == null)) {
validationErrors["Request"]=new string[] {"The Request mandatory parameter is missing in the request."};
}

if((inputs.inParamAllowCreation == null)) {
validationErrors["AllowCreation"]=new string[] {"The AllowCreation mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamResponse = await Flows.ActionServiceOrderRequest_Create(context,JSONST_9c87dd52bd762501ef8a064794927f08Structure.ToStructure(inputs.inParamRequest, behaviorsConfiguration),inputs.inParamAllowCreation.Value,ctx);

return new S4PIServiceOrderRequest_CreateOutput(JSONST_5a17d82af8397abda9cf3915ce9c082fStructure.FromStructure(outParamResponse, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrderRequest_Create : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest;
public bool inParamAllowCreation;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoOrdersImport_CreateRequest resOrderRequest_Create =  new Actions.lcoOrdersImport_CreateRequest();
public lcvServiceOrderRequest_Create(ST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest, bool inParamAllowCreation) {
this.inParamRequest = inParamRequest;
this.inParamAllowCreation = inParamAllowCreation;
}
}
public class lcoServiceOrderRequest_Create : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoServiceOrderRequest_Create() {
}
}
/// <summary>
/// Action <code>ServiceOrderRequest_Create</code> that represents the Service Studio action
///  <code>ServiceOrderRequest_Create</code> <p> Description: </p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionServiceOrderRequest_Create(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest,bool inParamAllowCreation,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = default;
lcoServiceOrderRequest_Create result = new lcoServiceOrderRequest_Create();
lcvServiceOrderRequest_Create localVars = new lcvServiceOrderRequest_Create(inParamRequest, inParamAllowCreation);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrderRequest_Create", "b2319987-e7c4-4cdc-b4c7-a7ada34a4043"))
using (activitySource.CreateServiceActionActivity("ServiceOrderRequest_Create")){
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call Order Create API", ssDescription = (((((AppUtils.GetStringResource("2_9QrJGe_keUyQj_v7kbrw#Value.-1924903246.1", "Order ")+localVars.inParamRequest.ssOrderNumber)+" // ReleaseCode ")+localVars.inParamRequest.ssReleased)+" // Items ")+Convert.ToString(localVars.inParamRequest.ssOrderItems.Length)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("aLSmUDKuY0yTX3RQe5p3KQ"))).ssId },cancellationToken);

// OrderRequest_Create
localVars.resOrderRequest_Create.outParamResponse = await Actions.ActionOrdersImport_CreateRequest(requestContext,"API",localVars.inParamRequest,localVars.inParamAllowCreation,cancellationToken);

// Response = OrderRequest_Create.Response
result.outParamResponse=localVars.resOrderRequest_Create.outParamResponse;
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta Order Create API", ssDescription = ((AppUtils.GetStringResource("aRabTxBaZEyK3GfWtL0qww#Value.-1924903246.1", "Order ")+result.outParamResponse.ssOrderNumber)+(((result.outParamResponse.ssErrorMessage!="")) ? ((" // ErrorMsg "+result.outParamResponse.ssErrorMessage)) : (" ha devolvido successo"))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("aLSmUDKuY0yTX3RQe5p3KQ"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Response.HasSuccess = False
result.outParamResponse.ssHasSuccess = false;

// Response.ErrorMessage = AllExceptions.ExceptionMessage
result.outParamResponse.ssErrorMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResponse = result.outParamResponse;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

        public static class FuncActionServiceOrderRequest_Create {
            
        }
    }
}
