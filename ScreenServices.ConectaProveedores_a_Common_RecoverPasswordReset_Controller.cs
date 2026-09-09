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
[Route("screenservices/ConectaProveedores/a_Common/RecoverPasswordReset")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Common_RecoverPasswordReset_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Common_RecoverPasswordReset_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Common_RecoverPasswordReset_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Common_RecoverPasswordReset_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Common_RecoverPasswordReset_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Common_RecoverPasswordReset_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_LayoutBlank_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_a_Common_PasswordPolicy_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_ButtonLoading_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("a_Common.RecoverPasswordReset"), ConectaProveedores_a_Common_RecoverPasswordReset_Controller.CheckPermissionsAsync);
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


    static ConectaProveedores_a_Common_RecoverPasswordReset_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.Logout*/"uXCIR2Atc0+es3zYuZSnNw*GjysQf3fT0uswPpDmpdWAQ", 
/*Grant*/"6dONWMH_kUW9Ti9X5sMIKA*G8k0PIl5bEep+6l39vHn7w", 
/*TelCelUsersManagement.ServiceUserManagementLogsCreate*/"EW68qyyQGUOHi50P7GQeYQ*04j5Eaqo_EGh3LQC1u_jig", 
/*SecurityAuth.CheckOldPassword*/"eiqzl1RRZEO7QhTR8NH5Yg*m_rsEEtIMEKgWpsA116ZSA", 
/*SecurityAuth.SavePassword*/"eiqzl1RRZEO7QhTR8NH5Yg*R7kghirsqkecjf6IS_5JLg", 
/*OutSystemsUI.ShowPassword*/"Kn_hixxDWEm4lMd7mIpycQ*hFfIuiqKAEKzplOB18zIwg", 
/*DoLogin*/"6dONWMH_kUW9Ti9X5sMIKA*oE5exNPdc06r_LpDr31atw", 
/*a_Common.RecoverPasswordReset.SetIsButtonEnabled*/"6dONWMH_kUW9Ti9X5sMIKA*Dw2_8GRlk0WVe9bktEcD7g", 
/*System_.FinishResetPassword*/"uXCIR2Atc0+es3zYuZSnNw*VS2aTEgec0q23Rl3cxc8hA", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_a_Common_RecoverPasswordReset_Controller(
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
[Route("DataActionGetSettingsEnviroment")]
[RESTScreenServicesActionProperties(Name="GetSettingsEnviroment",Screen="RecoverPasswordReset",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettingsEnviroment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "hz8SvQr3tsgaFFBBoTRz0Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsDevEnvironment;
string outParamEnvironment;
(outParamIsDevEnvironment,outParamEnvironment) = await model.DataActionGetSettingsEnviroment(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Common_RecoverPasswordReset_DataActionGetSettingsEnviroment_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsDevEnvironment, outParamEnvironment);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGrant")]
[RESTScreenServicesActionProperties(Name="Grant",Screen="RecoverPasswordReset",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGrant(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "glDztMTMAV8qGnd945xIuA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Common_RecoverPasswordReset_ActionGrant_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionGrant(requestContext,inputs.inParamEmail,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceUserManagementLogsCreate")]
[RESTScreenServicesActionProperties(Name="ServiceUserManagementLogsCreate",Screen="RecoverPasswordReset",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceUserManagementLogsCreate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XChAQnXYflYYarSITwmL4w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPIServiceUserManagementLogsCreate_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPIServiceUserManagementLogsCreate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamId = await ServiceAPIs.ServiceAPIServiceUserManagementLogsCreate(requestContext,inputs.inParamUserId,inputs.inParamMessage,inputs.inParamIpAddress,inputs.inParamScreen,cancellationToken);

var output = RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPIServiceUserManagementLogsCreate_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamId);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPICheckOldPassword")]
[RESTScreenServicesActionProperties(Name="CheckOldPassword",Screen="RecoverPasswordReset",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPICheckOldPassword(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "RqS1jmY6gGhONwLd9DsLcw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Model inputs = null;
bool res_outParamo_IsOld = false;
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

try {inputs = RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamo_IsOld = await ServiceAPIs.ServiceAPICheckOldPassword(requestContext,inputs.inParami_Password,inputs.inParami_Email,cancellationToken);

var output = RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPICheckOldPassword_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_IsOld);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPISavePassword")]
[RESTScreenServicesActionProperties(Name="SavePassword",Screen="RecoverPasswordReset",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPISavePassword(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "0yIpwxpi+zq5A2vTf0b5DA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPISavePassword_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Common_RecoverPasswordReset_ServiceAPISavePassword_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await ServiceAPIs.ServiceAPISavePassword(requestContext,inputs.inParami_Password,inputs.inParami_Email,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
