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
[Route("screenservices/ConectaProveedores/y_Utils/Wb_SessionTimeout")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*SetClientTimeouts*/"6dONWMH_kUW9Ti9X5sMIKA*PRWPDzZzIk+W7U2j2Ny7PQ", 
/*GetClientTimeouts*/"6dONWMH_kUW9Ti9X5sMIKA*N3GII0KW+UGn+tjUBSvOVQ", 
/*y_Utils.Wb_SessionTimeout.InitTimer*/"6dONWMH_kUW9Ti9X5sMIKA*uUUbN7j8J0qnxOJReCkUDw", 
/*y_Utils.Wb_SessionTimeout.DoLogout*/"6dONWMH_kUW9Ti9X5sMIKA*gQwkgUFI4EGBu+iNolB2+Q", 
/*y_Utils.Wb_SessionTimeout.ClearInterval*/"6dONWMH_kUW9Ti9X5sMIKA*3zGRxUny3EqgYoTnfHx3Jw", 
/*y_Utils.Wb_SessionTimeout.Validate*/"6dONWMH_kUW9Ti9X5sMIKA*SfAP8zxGM0uKBV9Go6Yv8A", 
/*y_Utils.Wb_SessionTimeout.InitActivityListener*/"6dONWMH_kUW9Ti9X5sMIKA*jbeV+3aHCEy0SHJuRhftKw"});

    }

    public ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller(
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
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="Wb_SessionTimeout",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "fiyj3Po6FOjaVWkfVOcGrQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

DateTime outParamWarningTime;
DateTime outParamLogoutTime;
int outParamWarningMinutes;
int outParamLogoutMinutes;
(outParamWarningTime,outParamLogoutTime,outParamWarningMinutes,outParamLogoutMinutes) = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamWarningTime, outParamLogoutTime, outParamWarningMinutes, outParamLogoutMinutes);
return output;


    }, cancellationToken);
}
}
