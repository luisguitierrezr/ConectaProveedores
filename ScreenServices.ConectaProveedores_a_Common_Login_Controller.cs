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
[Route("screenservices/ConectaProveedores/a_Common/Login")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Common_Login_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Common_Login_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Common_Login_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Common_Login_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Common_Login_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Common_Login_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Theme_Layouts_Layout_Blank_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_ButtonLoading_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("a_Common.Login"), ConectaProveedores_a_Common_Login_Controller.CheckPermissionsAsync);
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


    static ConectaProveedores_a_Common_Login_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.Logout*/"uXCIR2Atc0+es3zYuZSnNw*GjysQf3fT0uswPpDmpdWAQ", 
/*OutSystemsUI.DEPRECATED_ShowPassword*/"Kn_hixxDWEm4lMd7mIpycQ*IPzU9ikG0ESQIuRuOj5wDw", 
/*SecurityAuth.ServiceSupplierCodeValidate*/"eiqzl1RRZEO7QhTR8NH5Yg*QB21asMVD0a47eUYerK31w", 
/*Grant*/"6dONWMH_kUW9Ti9X5sMIKA*G8k0PIl5bEep+6l39vHn7w", 
/*TelCelUsersManagement.ServiceUserManagementLogsCreate*/"EW68qyyQGUOHi50P7GQeYQ*04j5Eaqo_EGh3LQC1u_jig", 
/*Organization.ServiceCheckSupplierUserEmail*/"z+Hr3img9k6c__DgH+2OBw*7oWaVUVwP0CgZw7hlfnt_Q", 
/*GetUserEntraRoleName*/"6dONWMH_kUW9Ti9X5sMIKA*iUUoTFVgE0C5bmO+pHECNg", 
/*Organization.GetUserPreferences*/"z+Hr3img9k6c__DgH+2OBw*_Gq5QxvGzk+8_Rwq0awBeA", 
/*a_Common.Login.LoginOnClick*/"6dONWMH_kUW9Ti9X5sMIKA*uvgKT8OJukKy88JyDR8d0w", 
/*TelCelUsersManagement.ServiceGetUserExtensionExternalEmail*/"EW68qyyQGUOHi50P7GQeYQ*X1E4iYqIKUCIrM5AERIvaw", 
/*a_Common.Login.CloseOnClick*/"6dONWMH_kUW9Ti9X5sMIKA*A2l_Z0CcG0m1NZwLE7YWzg", 
/*Organization.ServiceUserProviderSetLastLoginDate*/"z+Hr3img9k6c__DgH+2OBw*yexIsfc1yUC65qz50+q5aw", 
/*OutSystemsUI.FeedbackMessageClose*/"Kn_hixxDWEm4lMd7mIpycQ*vy1eQyrsuUan5_Z_P27S8A", 
/*SecurityAuth.CheckLastPassword*/"eiqzl1RRZEO7QhTR8NH5Yg*HcMvXZ59BkyK9g8WktSbEA", 
/*DoLogin*/"6dONWMH_kUW9Ti9X5sMIKA*oE5exNPdc06r_LpDr31atw", 
/*CheckUser*/"6dONWMH_kUW9Ti9X5sMIKA*pBFxyirlnUG215u8kt862g", 
/*SendSupplier2FA*/"6dONWMH_kUW9Ti9X5sMIKA*uM_uzmQ0+kKWuGBqzQVCZA", 
/*a_Common.Login.LoginOnClickSupplier*/"6dONWMH_kUW9Ti9X5sMIKA*YWie42VKck2FzflBBcsaXA", 
/*SecurityAuthLib.CreateUserSession*/"eP2ml4_Ud0y0bpDXITqEnw*0_6vdN9oQES240lMGlSz_A", 
/*LoginEntra*/"6dONWMH_kUW9Ti9X5sMIKA*lnRs9wS+PUmDBNYxGiLjWw", 
/*ConectaProveedores.CheckConectaProveedoresRole*/"6dONWMH_kUW9Ti9X5sMIKA*OWsqqzAfIE+gac9dGLB29A.#CheckRoleClientSide", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_a_Common_Login_Controller(
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
[Route("ScreenDataSetGetUserExtendedInternals")]
[RESTScreenServicesActionProperties(Name="GetUserExtendedInternals",Screen="Login",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserExtendedInternals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "2gJwDJC7TUW9b8fQ49TzjA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ScreenModel model = null;
AggregateInputsRecord inputs = null;
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

try {model = RESTConectaProveedores_a_Common_Login_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserExtendedInternals_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserExtendedInternals_maxRecords = 9999;
} else {
datasetGetUserExtendedInternals_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserExtendedInternals_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserExtendedInternals_startIndex = 0;
} else {
datasetGetUserExtendedInternals_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserExtendedInternals_maxRecords < 1)) {
datasetGetUserExtendedInternals_maxRecords = 1;
}

AggregateRecord<RL_e8fb9c349f962da0bba19bd202a05712> ds_output = new AggregateRecord<RL_e8fb9c349f962da0bba19bd202a05712>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Common_Login_ScreenModel.datasetGetUserExtendedInternals(requestContext,datasetGetUserExtendedInternals_maxRecords,datasetGetUserExtendedInternals_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_82a9276cec67a3d539884db9fd67d1e2>(ssConectaProveedores.RestRecords.RESTRC_82a9276cec67a3d539884db9fd67d1e2.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGet2FA")]
[RESTScreenServicesActionProperties(Name="Get2FA",Screen="Login",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGet2FA(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "jk_5PkWUPegoSaenv3zNzA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Login_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamISactive;
outParamISactive = await model.DataActionGet2FA(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamISactive);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSettingsEnviroment")]
[RESTScreenServicesActionProperties(Name="GetSettingsEnviroment",Screen="Login",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettingsEnviroment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "hz8SvQr3tsgaFFBBoTRz0Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Login_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsDevEnvironment;
string outParamEnvironment;
(outParamIsDevEnvironment,outParamEnvironment) = await model.DataActionGetSettingsEnviroment(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_DataActionGetSettingsEnviroment_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsDevEnvironment, outParamEnvironment);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIGetUserPreferences")]
[RESTScreenServicesActionProperties(Name="GetUserPreferences",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIGetUserPreferences(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Cc2tNL38BidpqfxXxbgY9w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Model inputs = null;
int res_outParamo_TableLinesCount = 0;
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

try {inputs = RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamo_TableLinesCount = await ServiceAPIs.ServiceAPIGetUserPreferences(requestContext,inputs.inParami_UserId,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ServiceAPIGetUserPreferences_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_TableLinesCount);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceUserManagementLogsCreate")]
[RESTScreenServicesActionProperties(Name="ServiceUserManagementLogsCreate",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceUserManagementLogsCreate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XChAQnXYflYYarSITwmL4w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamId = await ServiceAPIs.ServiceAPIServiceUserManagementLogsCreate(requestContext,inputs.inParamUserId,inputs.inParamMessage,inputs.inParamIpAddress,inputs.inParamScreen,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserManagementLogsCreate_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamId);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceGetUserExtensionExternalEmail")]
[RESTScreenServicesActionProperties(Name="ServiceGetUserExtensionExternalEmail",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceGetUserExtensionExternalEmail(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "gRSH8_dmhspoWc8dntuPzw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Model inputs = null;
string res_outParamo_ExternalEmail = "";
string res_outParamo_RegionToBeAssigned = "";
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

try {inputs = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res_outParamo_ExternalEmail,res_outParamo_RegionToBeAssigned) = await ServiceAPIs.ServiceAPIServiceGetUserExtensionExternalEmail(requestContext,inputs.inParami_UserEmail,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceGetUserExtensionExternalEmail_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_ExternalEmail, res_outParamo_RegionToBeAssigned);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionLoginEntra")]
[RESTScreenServicesActionProperties(Name="LoginEntra",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionLoginEntra(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "tH4G7kWZ0zgPfBw+hfkmqA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ActionLoginEntra_Model inputs = null;
Actions.lcoLoginEntra res =  new Actions.lcoLoginEntra();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Message,res.outParamo_IsSuccess) = await Actions.ActionLoginEntra(requestContext,inputs.inParami_UserEmailTelcel,inputs.inParami_NewRegion,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ActionLoginEntra_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Message, res.outParamo_IsSuccess);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetUserEntraRoleName")]
[RESTScreenServicesActionProperties(Name="GetUserEntraRoleName",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetUserEntraRoleName(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nxWX9o8d65Sx2hoAD8f0yw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Model inputs = null;
Actions.lcoGetUserEntraRoleName res =  new Actions.lcoGetUserEntraRoleName();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ActionGetUserEntraRoleName_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_EntraRoleName);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionCheckUser")]
[RESTScreenServicesActionProperties(Name="CheckUser",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionCheckUser(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+VrU2ayQha_Oe9kCueJMNw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ActionCheckUser_Model inputs = null;
Actions.lcoCheckUser res =  new Actions.lcoCheckUser();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_a_Common_Login_ActionCheckUser_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Role,res.outParamo_Success,res.outParamo_UserId) = await Actions.ActionCheckUser(requestContext,inputs.inParami_UserEmail,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ActionCheckUser_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Role, res.outParamo_Success, res.outParamo_UserId);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGrant")]
[RESTScreenServicesActionProperties(Name="Grant",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGrant(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "glDztMTMAV8qGnd945xIuA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ActionGrant_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Common_Login_ActionGrant_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionGrant(requestContext,inputs.inParamEmail,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPICheckLastPassword")]
[RESTScreenServicesActionProperties(Name="CheckLastPassword",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPICheckLastPassword(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "jf+3bBdlztldhCzGf+FDZw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ServiceAPICheckLastPassword_Model inputs = null;
bool res_outParamo_IsCorrect = false;
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

try {inputs = RESTConectaProveedores_a_Common_Login_ServiceAPICheckLastPassword_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamo_IsCorrect = await ServiceAPIs.ServiceAPICheckLastPassword(requestContext,inputs.inParami_Password,inputs.inParami_Email,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ServiceAPICheckLastPassword_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_IsCorrect);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionSendSupplier2FA")]
[RESTScreenServicesActionProperties(Name="SendSupplier2FA",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionSendSupplier2FA(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "W0tZnbLm7kaW9YCdrRsIPg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ActionSendSupplier2FA_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Common_Login_ActionSendSupplier2FA_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionSendSupplier2FA(requestContext,inputs.inParamApplicationName,inputs.inParamCustomerEmail,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceCheckSupplierUserEmail")]
[RESTScreenServicesActionProperties(Name="ServiceCheckSupplierUserEmail",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceCheckSupplierUserEmail(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ANHLcDZHxZyuiD7lAoTjqA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Model inputs = null;
bool res_outParamo_NotExists = false;
bool res_outParamo_NotActive = false;
bool res_outParamo_IsDeleted = false;
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

try {inputs = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res_outParamo_NotExists,res_outParamo_NotActive,res_outParamo_IsDeleted) = await ServiceAPIs.ServiceAPIServiceCheckSupplierUserEmail(requestContext,inputs.inParami_Email,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceCheckSupplierUserEmail_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_NotExists, res_outParamo_NotActive, res_outParamo_IsDeleted);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionCreateUserSession")]
[RESTScreenServicesActionProperties(Name="CreateUserSession",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionCreateUserSession(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "VwGvvsTlztK4t6++f72tAQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
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


// 
await Actions.ActionCreateUserSession(requestContext,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceUserProviderSetLastLoginDate")]
[RESTScreenServicesActionProperties(Name="ServiceUserProviderSetLastLoginDate",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceUserProviderSetLastLoginDate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ht1xhJgb29Mf01kvZ_DBXA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Model inputs = null;
ST_b1b6df219277397c7c2be747d587880aStructure res_outParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();
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

try {inputs = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamo_Return = await ServiceAPIs.ServiceAPIServiceUserProviderSetLastLoginDate(requestContext,inputs.inParami_userId,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_Return);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceSupplierCodeValidate")]
[RESTScreenServicesActionProperties(Name="ServiceSupplierCodeValidate",Screen="Login",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceSupplierCodeValidate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3eGWCHH164ynb4f7H6Q3eg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Model inputs = null;
bool res_outParamIsValid = false;
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

try {inputs = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamIsValid = await ServiceAPIs.ServiceAPIServiceSupplierCodeValidate(requestContext,inputs.inParamUserEmail,inputs.inParamCode,cancellationToken);

var output = RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamIsValid);
return output;


    }, cancellationToken);
}
}
