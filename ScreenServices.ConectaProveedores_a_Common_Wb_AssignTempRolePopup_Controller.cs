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
[Route("screenservices/ConectaProveedores/a_Common/Wb_AssignTempRolePopup")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*SecurityAuth.ServiceUserApplicationRoleTempAssign*/"eiqzl1RRZEO7QhTR8NH5Yg*oDlhMd0UUEeBog9vBqSeiw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA"});

    }

    public ConectaProveedores_a_Common_Wb_AssignTempRolePopup_Controller(
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
[Route("ScreenDataSetGetLoggedUserInfo")]
[RESTScreenServicesActionProperties(Name="GetLoggedUserInfo",Screen="Wb_AssignTempRolePopup",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetLoggedUserInfo(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3Y1EyNd3T2V0+MaATv_Lww", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetLoggedUserInfo_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetLoggedUserInfo_maxRecords = 1;
} else {
datasetGetLoggedUserInfo_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetLoggedUserInfo_startIndex;
if((inputs.StartIndex == null)) {
datasetGetLoggedUserInfo_startIndex = 0;
} else {
datasetGetLoggedUserInfo_startIndex = inputs.StartIndex.Value;
}

if((datasetGetLoggedUserInfo_maxRecords < 1)) {
datasetGetLoggedUserInfo_maxRecords = 1;
}

AggregateRecord<RL_edcb7e1d218607fc80645a6019e669d1> ds_output = new AggregateRecord<RL_edcb7e1d218607fc80645a6019e669d1>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel.datasetGetLoggedUserInfo(requestContext,datasetGetLoggedUserInfo_maxRecords,datasetGetLoggedUserInfo_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6>(ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetUsersFromSameRegion")]
[RESTScreenServicesActionProperties(Name="GetUsersFromSameRegion",Screen="Wb_AssignTempRolePopup",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUsersFromSameRegion(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "w+WPaosRoxS77CyV5KEhEQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUsersFromSameRegion_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUsersFromSameRegion_maxRecords = 99999;
} else {
datasetGetUsersFromSameRegion_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUsersFromSameRegion_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUsersFromSameRegion_startIndex = 0;
} else {
datasetGetUsersFromSameRegion_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUsersFromSameRegion_maxRecords < 1)) {
datasetGetUsersFromSameRegion_maxRecords = 1;
}

AggregateRecord<RL_752c66ffcb633a1081093541635464e7> ds_output = new AggregateRecord<RL_752c66ffcb633a1081093541635464e7>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel.datasetGetUsersFromSameRegion(requestContext,datasetGetUsersFromSameRegion_maxRecords,datasetGetUsersFromSameRegion_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetLoggedUserInfo.List.CurrentRec.ssENUser_Extended_Internal.ssRegionId,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9>(ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceUserApplicationRoleTempAssign")]
[RESTScreenServicesActionProperties(Name="ServiceUserApplicationRoleTempAssign",Screen="Wb_AssignTempRolePopup",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceUserApplicationRoleTempAssign(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XQvLVdv6EnEYP1aN3hc+cQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ServiceAPIServiceUserApplicationRoleTempAssign_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ServiceAPIServiceUserApplicationRoleTempAssign_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res_outParamId,res_outParamOutput) = await ServiceAPIs.ServiceAPIServiceUserApplicationRoleTempAssign(requestContext,inputs.inParamSource,inputs.inParamUserId,cancellationToken);

var output = RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ServiceAPIServiceUserApplicationRoleTempAssign_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamId, res_outParamOutput);
return output;


    }, cancellationToken);
}
}
