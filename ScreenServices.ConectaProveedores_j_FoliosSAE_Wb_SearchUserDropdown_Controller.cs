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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_SearchUserDropdown")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Advanced_DropdownServerSide_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Advanced_DropdownServerSideItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller(
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
[Route("ScreenDataSetGetUserById")]
[RESTScreenServicesActionProperties(Name="GetUserById",Screen="Wb_SearchUserDropdown",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Va4im9w3O8J6O2V4NmI_0w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserById_maxRecords = 1;
} else {
datasetGetUserById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserById_startIndex = 0;
} else {
datasetGetUserById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserById_maxRecords < 1)) {
datasetGetUserById_maxRecords = 1;
}

AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ds_output = new AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_UserId,cancellationToken);

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
[Route("ScreenDataSetGetUsers")]
[RESTScreenServicesActionProperties(Name="GetUsers",Screen="Wb_SearchUserDropdown",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUsers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "t2fqeF5CGVGoHASF55LTcQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUsers_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUsers_maxRecords = model.varLcl_UserMaxRecord;
} else {
datasetGetUsers_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUsers_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUsers_startIndex = 0;
} else {
datasetGetUsers_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUsers_maxRecords < 1)) {
datasetGetUsers_maxRecords = 1;
}

AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096> ds_output = new AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.varLcl_UserSearchText,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_77956dae907db5f208e8a848dc366336>(ssConectaProveedores.RestRecords.RESTRC_77956dae907db5f208e8a848dc366336.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
