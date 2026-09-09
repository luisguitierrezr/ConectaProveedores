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
[Route("screenservices/ConectaProveedores/a_Common/UserProfile_DEPRECATED")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_AnimatedLabel_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_ButtonLoading_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("a_Common.UserProfile_DEPRECATED"), ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckConectaProveedoresRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotConectaProveedoresRoleException( "ConectaProveedores role required");

    }


    static ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*a_Common.UserProfile_DEPRECATED.StopCountdown*/"6dONWMH_kUW9Ti9X5sMIKA*byuGAfCEHE6fdzYbf5+B1A", 
/*a_Common.UserProfile_DEPRECATED.UpdateCountdown*/"6dONWMH_kUW9Ti9X5sMIKA*XY7uU2trQ0uJk1+ZX+0WUg", 
/*System_.FinishUpdateEmail*/"uXCIR2Atc0+es3zYuZSnNw*C0BcjCYSeki80I3dyyzO9A", 
/*UpdateUser*/"6dONWMH_kUW9Ti9X5sMIKA*3jy2cDqoaUmQVVnt4mUcYg", 
/*a_Common.UserProfile_DEPRECATED.ValidateUserDetails*/"6dONWMH_kUW9Ti9X5sMIKA*C5yrjncIj0aRwo2gkhXTvg", 
/*SendChangeEmail*/"6dONWMH_kUW9Ti9X5sMIKA*NZTIv24YWUuUZuxKBpFTGA", 
/*a_Common.UserProfile_DEPRECATED.CheckIsButtonEnabled*/"6dONWMH_kUW9Ti9X5sMIKA*s27H1gfeA0qr9V+kP+EZQA", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_a_Common_UserProfile_DEPRECATED_Controller(
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
[Route("ScreenDataSetGetUserDetails")]
[RESTScreenServicesActionProperties(Name="GetUserDetails",Screen="UserProfile_DEPRECATED",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserDetails(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "IJ45LyA89cyA8bLeN6OBrg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserDetails_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserDetails_maxRecords = 1;
} else {
datasetGetUserDetails_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserDetails_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserDetails_startIndex = 0;
} else {
datasetGetUserDetails_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserDetails_maxRecords < 1)) {
datasetGetUserDetails_maxRecords = 1;
}

AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ds_output = new AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel.datasetGetUserDetails(requestContext,datasetGetUserDetails_maxRecords,datasetGetUserDetails_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79>(ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetApplicationRoles",Screen="UserProfile_DEPRECATED",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9RxWe9tzZBR5X1fAE4DMEw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetApplicationRoles_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetApplicationRoles_maxRecords = 1;
} else {
datasetGetApplicationRoles_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetApplicationRoles_startIndex;
if((inputs.StartIndex == null)) {
datasetGetApplicationRoles_startIndex = 0;
} else {
datasetGetApplicationRoles_startIndex = inputs.StartIndex.Value;
}

if((datasetGetApplicationRoles_maxRecords < 1)) {
datasetGetApplicationRoles_maxRecords = 1;
}

AggregateRecord<RL_6baa91071578818b75d38b8795012b73> ds_output = new AggregateRecord<RL_6baa91071578818b75d38b8795012b73>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Common_UserProfile_DEPRECATED_ScreenModel.datasetGetApplicationRoles(requestContext,datasetGetApplicationRoles_maxRecords,datasetGetApplicationRoles_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c2921a936d592680b8275006015423c4>(ssConectaProveedores.RestRecords.RESTRC_c2921a936d592680b8275006015423c4.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionUpdateUser")]
[RESTScreenServicesActionProperties(Name="UpdateUser",Screen="UserProfile_DEPRECATED",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUpdateUser(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Bowez_paTaTI1XpaenFzaw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionUpdateUser_Model inputs = null;
Actions.lcoUpdateUser res =  new Actions.lcoUpdateUser();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionUpdateUser_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamUpdateUserResult = await Actions.ActionUpdateUser(requestContext,inputs.inParamUserUpdateInfo,cancellationToken);

var output = RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionUpdateUser_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamUpdateUserResult);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionSendChangeEmail")]
[RESTScreenServicesActionProperties(Name="SendChangeEmail",Screen="UserProfile_DEPRECATED",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionSendChangeEmail(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "cVmxBPyjBA5_1lAbHjfpvA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionSendChangeEmail_Model inputs = null;
Actions.lcoSendChangeEmail res =  new Actions.lcoSendChangeEmail();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionSendChangeEmail_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamSuccess = await Actions.ActionSendChangeEmail(requestContext,inputs.inParamApplicationName,inputs.inParamCustomerEmail,cancellationToken);

var output = RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionSendChangeEmail_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamSuccess);
return output;


    }, cancellationToken);
}
}
