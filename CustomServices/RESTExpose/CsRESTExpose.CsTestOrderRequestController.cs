using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Binders;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.ErrorHandling;
using OutSystems.RESTService.Runtime.Core.Filters;
using ssConectaProveedores.CsRESTExpose;


namespace ssConectaProveedores.CsRESTExpose.CsTestOrderRequest;

[EnableCors("RestExposeCorsPolicy")]
[TypeFilter(typeof(OnRestExposeRequestFilter), Arguments = new object[] { typeof(CsTestOrderRequestController.OnFilter), "c43b356a-db07-4875-be02-a7cc6f50c60e", new string[] { "rest/TestOrderRequest/swagger.json","rest/TestOrderRequest" } })]
[TypeFilter(typeof(OnRestExposeResponseFilter), Arguments = new object[] { typeof(CsTestOrderRequestController.OnFilter) })]
[Route("rest/TestOrderRequest")]
[RestServiceControllerConfiguration(DefaultValuesBehavior=DefaultValuesBehavior.DontSend, HTTPSecurity=HTTPSecurity.SSL)]
public class CsTestOrderRequestController : RestExposeApiController {
public class OnFilter : AbstractFilter {
  public override bool SkipOnRequestImplementation => true;
  public override bool SkipOnResponseImplementation => true;
}

public CsTestOrderRequestController(IAppInfo appInfo, IApplicationLogger applicationLogger, ISettingsProvider settingsProvider, IHttpContextAccessor httpContextAccessor, IRequestContext requestContext) : base(appInfo, applicationLogger, settingsProvider, httpContextAccessor, requestContext) { }
public override bool IsSwaggerRequest(string currentRoute) {
    return currentRoute == "rest/TestOrderRequest" || currentRoute == "rest/TestOrderRequest/swagger.json";
}
[HttpGet]
[Route("swagger.json")]
[Produces(typeof(string))]
public IActionResult FlowSwagger() {
    return base.SwaggerJson("TestOrderRequest");
}

[HttpGet]
[Route("")]
[Produces(typeof(string))]
public IActionResult FlowSwaggerDoc() {
  return base.SwaggerDoc("TestOrderRequest");
}

[HttpGet]
[Route("GetOrderRequest")]
[Produces(typeof(ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure))]
[RESTExposeActionProperties("GetOrderRequest", false, false)]
public async Task<IActionResult> FlowTestOrderRequestActionGetOrderRequest([FromQuery(Name= "OrderNumber"), ModelBinder(typeof(AbstractParamBinder))] string auxinParamOrderNumber = null,CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
string inParamOrderNumber = "";
try {
if (auxinParamOrderNumber == null) {
  validationErrors.Add("The 'OrderNumber' URL parameter is missing in the request.");
} else {
inParamOrderNumber = auxinParamOrderNumber;
}
} catch {
  validationErrors.Add("Failed to parse. 'Text' compatible data type is required for parameter 'OrderNumber'.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

ST_9c87dd52bd762501ef8a064794927f08Structure outParamResponse;
cancellationToken.ThrowIfCancellationRequested();
outParamResponse = await ssConectaProveedores.CsRESTExpose.CsTestOrderRequest.CsTestOrderRequestControllerFlows.FlowTestOrderRequestActionGetOrderRequest(requestContext,inParamOrderNumber,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(typeof(ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure), ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure.FromStructure(outParamResponse, this.BehaviorsConfiguration));
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpPost]
[Route("DeleteOrderRequest")]
[Produces(typeof(string))]
[RESTExposeActionProperties("DeleteOrderRequest", false, false)]
public async Task<IActionResult> FlowTestOrderRequestActionDeleteOrderRequest([FromQuery(Name= "OrderNumber"), ModelBinder(typeof(AbstractParamBinder))] string auxinParamOrderNumber = null,CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
string inParamOrderNumber = "";
try {
if (auxinParamOrderNumber == null) {
  validationErrors.Add("The 'OrderNumber' URL parameter is missing in the request.");
} else {
inParamOrderNumber = auxinParamOrderNumber;
}
} catch {
  validationErrors.Add("Failed to parse. 'Text' compatible data type is required for parameter 'OrderNumber'.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

string outParamResponse;
cancellationToken.ThrowIfCancellationRequested();
outParamResponse = await ssConectaProveedores.CsRESTExpose.CsTestOrderRequest.CsTestOrderRequestControllerFlows.FlowTestOrderRequestActionDeleteOrderRequest(requestContext,inParamOrderNumber,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(outParamResponse);
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}


[HttpGet]
[Route("SetOrderRequestReleased")]
[Produces(typeof(string))]
[RESTExposeActionProperties("SetOrderRequestReleased", false, false)]
public async Task<IActionResult> FlowTestOrderRequestActionSetOrderRequestReleased([FromQuery(Name= "OrderNumber"), ModelBinder(typeof(AbstractParamBinder))] string auxinParamOrderNumber = null,CancellationToken cancellationToken = default) {
var appInfo = AppInfo.GetAppInfo();
var requestContext = appInfo.RequestContext;
appInfo.CheckIsApplicationEnabled();
DateTime startExecution = DateTime.UtcNow;
string errorLogId = "";
try {
cancellationToken.ThrowIfCancellationRequested();
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

this.ValidateRequestSecurity();
var validationErrors = new List<String>();
string inParamOrderNumber = "";
try {
if (auxinParamOrderNumber == null) {
  validationErrors.Add("The 'OrderNumber' URL parameter is missing in the request.");
} else {
inParamOrderNumber = auxinParamOrderNumber;
}
} catch {
  validationErrors.Add("Failed to parse. 'Text' compatible data type is required for parameter 'OrderNumber'.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

string outParamResponse;
cancellationToken.ThrowIfCancellationRequested();
outParamResponse = await ssConectaProveedores.CsRESTExpose.CsTestOrderRequest.CsTestOrderRequestControllerFlows.FlowTestOrderRequestActionSetOrderRequestReleased(requestContext,inParamOrderNumber,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(outParamResponse);
} catch (Exception ex) {
  await DatabaseAccess.FreeUpResourcesAsync(false);
  if (ex is RestExposeException) {
    throw;
  }
  throw new RestExposeException(ex, RestServiceHttpUtils.GetCurrentStatusCode(httpContextAccessor.Context.Response));
} finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

}
}

}

