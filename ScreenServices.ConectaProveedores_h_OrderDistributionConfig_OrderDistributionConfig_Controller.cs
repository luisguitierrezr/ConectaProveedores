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
[Route("screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfig")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_LayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("h_OrderDistributionConfig.OrderDistributionConfig"), ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        {
bool check;
check = await ExtendedActions.CheckConectaProveedoresAdminRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotConectaProveedoresAdminRoleException( "ConectaProveedoresAdmin role required");

    }


    static ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ExportOrderDistributionConfig*/"6dONWMH_kUW9Ti9X5sMIKA*43eyTvu0nE6QEXuNtSpN0A", 
/*ImportOrderDistributionConfigFromExcel*/"6dONWMH_kUW9Ti9X5sMIKA*WGqCd8Kd_UWQ8vJ8Z8f7Bw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_Controller(
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
[Route("DataActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="OrderDistributionConfig",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "N9tDUeibRoeXDWx8UfSXLw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel model = null;
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

try {model = RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamAllowImport;
outParamAllowImport = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamAllowImport);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="OrderDistributionConfig",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionImportOrderDistributionConfigFromExcel")]
[RESTScreenServicesActionProperties(Name="ImportOrderDistributionConfigFromExcel",Screen="OrderDistributionConfig",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionImportOrderDistributionConfigFromExcel(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OSmQuiekvt_Bs0DSPUM4Mg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionImportOrderDistributionConfigFromExcel_Model inputs = null;
Actions.lcoImportOrderDistributionConfigFromExcel res =  new Actions.lcoImportOrderDistributionConfigFromExcel();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionImportOrderDistributionConfigFromExcel_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamHasSuccess,res.outParamErrorMessage) = await Actions.ActionImportOrderDistributionConfigFromExcel(requestContext,inputs.inParamFileContent,cancellationToken);

var output = RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionImportOrderDistributionConfigFromExcel_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamHasSuccess, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionExportOrderDistributionConfig")]
[RESTScreenServicesActionProperties(Name="ExportOrderDistributionConfig",Screen="OrderDistributionConfig",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionExportOrderDistributionConfig(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "5aypJeVhMe1__WONy4OmCw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Model inputs = null;
Actions.lcoExportOrderDistributionConfig res =  new Actions.lcoExportOrderDistributionConfig();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_File = await Actions.ActionExportOrderDistributionConfig(requestContext,inputs.inParami_OrderId,inputs.inParami_TabNumber,inputs.inParami_TableSort,inputs.inParami_OrderDistributionConfig_Applicant,inputs.inParami_OrderDistributionConfig_ApplicantDescription,inputs.inParami_OrderDistributionConfig_Direction,inputs.inParami_OrderDistributionConfig_Division,inputs.inParami_OrderDistributionConfig_Role,cancellationToken);

var output = RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ActionExportOrderDistributionConfig_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File);
return output;


    }, cancellationToken);
}
}
