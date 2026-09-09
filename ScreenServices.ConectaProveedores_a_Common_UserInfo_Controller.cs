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
[Route("screenservices/ConectaProveedores/a_Common/UserInfo")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Common_UserInfo_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Common_UserInfo_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Common_UserInfo_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Common_UserInfo_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Common_UserInfo_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Common_UserInfo_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_UserAvatar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SessionTimeout_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_a_Common_UserInfo_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.Logout*/"uXCIR2Atc0+es3zYuZSnNw*GjysQf3fT0uswPpDmpdWAQ", 
/*TelCelUsersManagement.ServiceUserManagementLogsCreate*/"EW68qyyQGUOHi50P7GQeYQ*04j5Eaqo_EGh3LQC1u_jig", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.GetExternalLogoutURL*/"uXCIR2Atc0+es3zYuZSnNw*tlK9xXyBaEKdm30r_nIo_g", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*a_Common.UserInfo.GetUsernameAndPhoto*/"6dONWMH_kUW9Ti9X5sMIKA*2lCAx7TQ4EG0ptLXfqV7nw", 
/*System_.GetUserProfile*/"uXCIR2Atc0+es3zYuZSnNw*7_TXpJo5lEKKtM8UN2mf4w"});

    }

    public ConectaProveedores_a_Common_UserInfo_Controller(
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
[Route("ServiceAPIServiceUserManagementLogsCreate")]
[RESTScreenServicesActionProperties(Name="ServiceUserManagementLogsCreate",Screen="UserInfo",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceUserManagementLogsCreate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XChAQnXYflYYarSITwmL4w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_UserInfo_ServiceAPIServiceUserManagementLogsCreate_Model inputs = null;
long res_outParamId = 0L;
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

try {inputs = RESTConectaProveedores_a_Common_UserInfo_ServiceAPIServiceUserManagementLogsCreate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamId = await ServiceAPIs.ServiceAPIServiceUserManagementLogsCreate(requestContext,inputs.inParamUserId,inputs.inParamMessage,inputs.inParamIpAddress,inputs.inParamScreen,cancellationToken);

var output = RESTConectaProveedores_a_Common_UserInfo_ServiceAPIServiceUserManagementLogsCreate_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamId);
return output;


    }, cancellationToken);
}
}
