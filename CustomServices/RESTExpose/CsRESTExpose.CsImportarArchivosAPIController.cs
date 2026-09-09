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


namespace ssConectaProveedores.CsRESTExpose.CsImportarArchivosAPI;

[EnableCors("RestExposeCorsPolicy")]
[TypeFilter(typeof(OnRestExposeRequestFilter), Arguments = new object[] { typeof(CsImportarArchivosAPIController.OnFilter), "f6617cae-5fa1-4332-9f35-75463f8d599e", new string[] { "rest/ImportarArchivosAPI/swagger.json","rest/ImportarArchivosAPI" } })]
[TypeFilter(typeof(OnRestExposeResponseFilter), Arguments = new object[] { typeof(CsImportarArchivosAPIController.OnFilter) })]
[Route("rest/ImportarArchivosAPI")]
[RestServiceControllerConfiguration(DefaultValuesBehavior=DefaultValuesBehavior.DontSend, HTTPSecurity=HTTPSecurity.SSL)]
public class CsImportarArchivosAPIController : RestExposeApiController {
public class OnFilter : AbstractFilter {
  protected override async Task OnAuthenticationImplementationAsync(FilterContext filterContext, IHttpRequest httpRequestMessage, IHttpResponse httpResponseMessage, CancellationToken cancellationToken = default) {
      try {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = true;

await ssConectaProveedores.CsRESTExpose.CsImportarArchivosAPI.CsImportarArchivosAPIControllerFlows.FlowImportarArchivosAPIActionOnAuthentication(AppInfo.GetAppInfo().RequestContext,cancellationToken);

      } catch {
          await DatabaseAccess.FreeUpResourcesAsync(false, cancellationToken);
          throw;
      }
      finally {
AppInfo.GetAppInfo().RequestContext.IsServiceAction = false;

      }
  }

  public override bool SkipOnRequestImplementation => true;
  public override bool SkipOnResponseImplementation => true;
}

public CsImportarArchivosAPIController(IAppInfo appInfo, IApplicationLogger applicationLogger, ISettingsProvider settingsProvider, IHttpContextAccessor httpContextAccessor, IRequestContext requestContext) : base(appInfo, applicationLogger, settingsProvider, httpContextAccessor, requestContext) { }
public override bool IsSwaggerRequest(string currentRoute) {
    return currentRoute == "rest/ImportarArchivosAPI" || currentRoute == "rest/ImportarArchivosAPI/swagger.json";
}
[HttpGet]
[Route("swagger.json")]
[Produces(typeof(string))]
public IActionResult FlowSwagger() {
    return base.SwaggerJson("ImportarArchivosAPI");
}

[HttpGet]
[Route("")]
[Produces(typeof(string))]
public IActionResult FlowSwaggerDoc() {
  return base.SwaggerDoc("ImportarArchivosAPI");
}

[HttpPost]
[Route("ComisionesArrendamientos")]
[Produces(typeof(ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure))]
[RESTExposeActionProperties("ComisionesArrendamientos", false, false)]
public async Task<IActionResult> FlowImportarArchivosAPIActionComisionesArrendamientos([FromBody]String auxinParami_File,[FromQuery(Name= "i_APIKey"), ModelBinder(typeof(AbstractParamBinder))] string auxinParami_APIKey = null,CancellationToken cancellationToken = default) {
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
string inParami_APIKey = "";
try {
if (auxinParami_APIKey == null) {
  validationErrors.Add("The 'i_APIKey' URL parameter is missing in the request.");
} else {
inParami_APIKey = auxinParami_APIKey;
}
} catch {
  validationErrors.Add("Failed to parse. 'Text' compatible data type is required for parameter 'i_APIKey'.");
}
string inParami_Filename = "";
String auxinParami_Filename = "";
try {
auxinParami_Filename = RestServiceHttpUtils.TryGetRequestHeader(httpContextAccessor.Context.Request, "NombreDelArchivo");
if (String.IsNullOrEmpty(auxinParami_Filename)) {
  validationErrors.Add("The 'NombreDelArchivo' HTTP Header is missing in the request.");
} else {
inParami_Filename = auxinParami_Filename;
}
} catch {
  validationErrors.Add("Failed to parse. 'Text' compatible data type is required for parameter 'NombreDelArchivo'.");
}
string inParami_File = "";
try {
if (String.IsNullOrEmpty(auxinParami_File)) {
  validationErrors.Add("The request body is missing.");
} else {
inParami_File = auxinParami_File;
}
} catch {
  validationErrors.Add("Failed to parse. 'Text' compatible data type is required for parameter 'i_File'.");
}
if (validationErrors.Any()) {
    throw RestExposeErrorsHelper.InvalidRequest(new Dictionary<string, string[]>() { { "ValidationErrors", validationErrors.ToArray() } });
}

ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_API_Ouput;
cancellationToken.ThrowIfCancellationRequested();
outParamo_API_Ouput = await ssConectaProveedores.CsRESTExpose.CsImportarArchivosAPI.CsImportarArchivosAPIControllerFlows.FlowImportarArchivosAPIActionComisionesArrendamientos(requestContext,inParami_APIKey,inParami_Filename,inParami_File,cancellationToken);

await DatabaseAccess.FreeUpResourcesAsync(true);
return this.GetResponseResult(typeof(ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure), ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(outParamo_API_Ouput, this.BehaviorsConfiguration));
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

