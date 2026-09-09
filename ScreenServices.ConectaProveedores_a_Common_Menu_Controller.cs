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
[Route("screenservices/ConectaProveedores/a_Common/Menu")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Common_Menu_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Common_Menu_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Common_Menu_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Common_Menu_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Common_Menu_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Common_Menu_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Theme_Common_Menu_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_a_Common_UserInfo_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_a_Common_Menu_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_a_Common_Menu_Controller(
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
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="Menu",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8Rfz4IbuFKr234cthOacYw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Menu_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Menu_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamo_IsDevEnvironment;
string outParamo_Environment;
bool outParamo_IsActiveDEV_HU13045;
bool outParamo_IsActiveDEV_HU13046;
bool outParamo_IsActiveDEV_HU13047;
bool outParamo_IsActiveDEV_HU13048;
(outParamo_IsDevEnvironment,outParamo_Environment,outParamo_IsActiveDEV_HU13045,outParamo_IsActiveDEV_HU13046,outParamo_IsActiveDEV_HU13047,outParamo_IsActiveDEV_HU13048) = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_IsDevEnvironment, outParamo_Environment, outParamo_IsActiveDEV_HU13045, outParamo_IsActiveDEV_HU13046, outParamo_IsActiveDEV_HU13047, outParamo_IsActiveDEV_HU13048);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserData")]
[RESTScreenServicesActionProperties(Name="GetUserData",Screen="Menu",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "uuUiR5AR0lklN6+o2w3qOw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Menu_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Menu_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamo_Region;
bool outParamo_IsCXP;
bool outParamo_CanSeeDistributionError;
(outParamo_Region,outParamo_IsCXP,outParamo_CanSeeDistributionError) = await model.DataActionGetUserData(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_Region, outParamo_IsCXP, outParamo_CanSeeDistributionError);
return output;


    }, cancellationToken);
}
}
