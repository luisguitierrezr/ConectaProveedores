using Microsoft.AspNetCore.Mvc;
using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Abstractions.Controllers;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;
using OutSystems.RESTService.Runtime.Core.ErrorHandling;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Core.ClientSettings;

namespace ssConectaProveedores.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/ConectaProveedores/y_Utils/InvoiceReportPdf")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_y_Utils_InvoiceReportPdf_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_y_Utils_InvoiceReportPdf_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_y_Utils_InvoiceReportPdf_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_y_Utils_InvoiceReportPdf_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_y_Utils_InvoiceReportPdf_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_y_Utils_InvoiceReportPdf_Controller.GetDbBinaryConfigs(); }
    }

    public static readonly CheckPermissionsIndex Permissions;

    private static readonly HashSet<IScreenControllerProxy> childControllers = new();
    public static IEnumerable<IScreenControllerProxy> GetChildControllers() {
        return childControllers;
    }

    private static volatile bool initialized = false;
    public static void EnsureInitialized() {
        // Only a single thread can do initializations at the time. Allows the CheckPermissionsIndex class non-threadsafe.
        // This should always be done only once at ApplicationStart
        lock (ScreenServicesApiController.GlobalScreenServicesInitializationLock) {
            if (!initialized) {
                initialized = true; // InitPermissionIndexes propagates to new parents as well so we can set it as initialized here before going into recursion

                SafeAddChildController("ssUltimatePDF.ScreenServices.UltimatePDF_PrintLayout_ScreenToPDF_Controller", "UltimatePDF", childControllers);
SafeAddChildController("ssUltimatePDF.ScreenServices.UltimatePDF_PrintLayout_PrintLayout_Controller", "UltimatePDF", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ValidationReport_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("y_Utils.InvoiceReportPdf"), ConectaProveedores_y_Utils_InvoiceReportPdf_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        return;

    }


    static ConectaProveedores_y_Utils_InvoiceReportPdf_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.SetCurrentLocale*/"uXCIR2Atc0+es3zYuZSnNw*RYFw8sBg3EmaGosPH65dzg", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_y_Utils_InvoiceReportPdf_Controller(
        IAppInfo appInfo,
        IApplicationLogger applicationLogger,
        ISettingsProvider settingsProvider,
        IHttpContextAccessor httpContextAccessor,
        IRequestContext requestContext,
        IClientSettingsService clientSettingsService,
        IFileTokenSerializerConfigurator fileTokenSerializerConfigurator
    ) : base(
        appInfo,
        applicationLogger,
        settingsProvider,
        httpContextAccessor,
        requestContext,
        clientSettingsService,
        fileTokenSerializerConfigurator
    ) {
    }

[HttpPost]
[Route("DataActionGetMainData")]
[RESTScreenServicesActionProperties(Name="GetMainData",Screen="InvoiceReportPdf",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetMainData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wdrABS+mipJ5C2BZQAeXqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_f54c1d1bac41c2667837ac97bb484830Structure outParamValidationReport;
RC_b6257dfb536e679f8b7be7b4b56f189b outParamInvoiceExtended;
long outParamFolioId;
bool outParamIsFromRequisition;
(outParamValidationReport,outParamInvoiceExtended,outParamFolioId,outParamIsFromRequisition) = await model.DataActionGetMainData(requestContext,cancellationToken);

var output = RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamValidationReport, outParamInvoiceExtended, outParamFolioId, outParamIsFromRequisition);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetTableItems")]
[RESTScreenServicesActionProperties(Name="GetTableItems",Screen="InvoiceReportPdf",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetTableItems(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ZV7seOXCsRXozCzAyqUR1w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_f0441ae281d3bacc0d1d0acaed8c2549 outParamTableLine;
outParamTableLine = await model.DataActionGetTableItems(requestContext,cancellationToken);

var output = RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamTableLine);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetInvoiceFiles")]
[RESTScreenServicesActionProperties(Name="GetInvoiceFiles",Screen="InvoiceReportPdf",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetInvoiceFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YF75rIJ5X8CRGYI1Os94XA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamFilesString;
outParamFilesString = await model.DataActionGetInvoiceFiles(requestContext,cancellationToken);

var output = RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamFilesString);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetEletronicAuthorizations")]
[RESTScreenServicesActionProperties(Name="GetEletronicAuthorizations",Screen="InvoiceReportPdf",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetEletronicAuthorizations(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "63B7_VnhJPkSpVmNiS3ajw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {model = RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_2d1a9f1ebd1dae77afe7dba56f4eb06c outParamValidationReportAuthorizationList;
outParamValidationReportAuthorizationList = await model.DataActionGetEletronicAuthorizations(requestContext,cancellationToken);

var output = RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetEletronicAuthorizations_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamValidationReportAuthorizationList);
return output;


    }, cancellationToken);
}
}
