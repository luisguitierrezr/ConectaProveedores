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
[Route("screenservices/ConectaProveedores/a_Common/Wb_TempRoleAssignments")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_ListItemContent_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ConfirmPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*a_Common.Wb_TempRoleAssignments.ShowHideConfirmPopup*/"6dONWMH_kUW9Ti9X5sMIKA*hyxIKAstu0CUk8kXBceoXg", 
/*a_Common.Wb_TempRoleAssignments.ShowHideShowAssignTempRolePopup*/"6dONWMH_kUW9Ti9X5sMIKA*dn5xl8zKJEKeFW6Jq5dSjQ", 
/*SecurityAuth.ServiceUserApplicationRoleTempRevoke*/"eiqzl1RRZEO7QhTR8NH5Yg*J__8EJ7dnE+3ONqHyQdZmg"});

    }

    public ConectaProveedores_a_Common_Wb_TempRoleAssignments_Controller(
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
[Route("ScreenDataSetGetUserApplicationRoleTempsByUserId")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoleTempsByUserId",Screen="Wb_TempRoleAssignments",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserApplicationRoleTempsByUserId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9OWUt54ngKqlYpSl8CxZXw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserApplicationRoleTempsByUserId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserApplicationRoleTempsByUserId_maxRecords = model.varLcl_MaxRecordsAssigned;
} else {
datasetGetUserApplicationRoleTempsByUserId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserApplicationRoleTempsByUserId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserApplicationRoleTempsByUserId_startIndex = model.varLcl_StartIndexAssigned;
} else {
datasetGetUserApplicationRoleTempsByUserId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserApplicationRoleTempsByUserId_maxRecords < 1)) {
datasetGetUserApplicationRoleTempsByUserId_maxRecords = 1;
}

AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> ds_output = new AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel.datasetGetUserApplicationRoleTempsByUserId(requestContext,datasetGetUserApplicationRoleTempsByUserId_maxRecords,datasetGetUserApplicationRoleTempsByUserId_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca>(ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetUserApplicationRoleTempsByAssignedBy")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoleTempsByAssignedBy",Screen="Wb_TempRoleAssignments",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserApplicationRoleTempsByAssignedBy(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "MKMU03LLht8oKYsxgwXUIg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserApplicationRoleTempsByAssignedBy_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserApplicationRoleTempsByAssignedBy_maxRecords = model.varLcl_MaxRecords;
} else {
datasetGetUserApplicationRoleTempsByAssignedBy_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserApplicationRoleTempsByAssignedBy_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserApplicationRoleTempsByAssignedBy_startIndex = model.varLcl_StartIndex;
} else {
datasetGetUserApplicationRoleTempsByAssignedBy_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserApplicationRoleTempsByAssignedBy_maxRecords < 1)) {
datasetGetUserApplicationRoleTempsByAssignedBy_maxRecords = 1;
}

AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> ds_output = new AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel.datasetGetUserApplicationRoleTempsByAssignedBy(requestContext,datasetGetUserApplicationRoleTempsByAssignedBy_maxRecords,datasetGetUserApplicationRoleTempsByAssignedBy_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca>(ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceUserApplicationRoleTempRevoke")]
[RESTScreenServicesActionProperties(Name="ServiceUserApplicationRoleTempRevoke",Screen="Wb_TempRoleAssignments",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceUserApplicationRoleTempRevoke(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "oGRxmLjmaDt2TDUkhHTUqg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Wb_TempRoleAssignments_ServiceAPIServiceUserApplicationRoleTempRevoke_Model inputs = null;
long res_outParamId = 0L;
ST_346a76e47f982dbf41625f8a893affccStructure res_outParamOutput = new ST_346a76e47f982dbf41625f8a893affccStructure();
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

try {inputs = RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ServiceAPIServiceUserApplicationRoleTempRevoke_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res_outParamId,res_outParamOutput) = await ServiceAPIs.ServiceAPIServiceUserApplicationRoleTempRevoke(requestContext,inputs.inParamSource,cancellationToken);

var output = RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ServiceAPIServiceUserApplicationRoleTempRevoke_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamId, res_outParamOutput);
return output;


    }, cancellationToken);
}
}
