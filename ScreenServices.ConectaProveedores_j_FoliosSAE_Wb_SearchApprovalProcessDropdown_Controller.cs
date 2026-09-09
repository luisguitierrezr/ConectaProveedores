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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_SearchApprovalProcessDropdown")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller.GetDbBinaryConfigs(); }
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



    static ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller(
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
[Route("ScreenDataSetGetApprovalProcesss")]
[RESTScreenServicesActionProperties(Name="GetApprovalProcesss",Screen="Wb_SearchApprovalProcessDropdown",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalProcesss(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "_zbsLFjo0_6mQ+Cscy829w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetApprovalProcesss_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetApprovalProcesss_maxRecords = model.varLcl_ApprovalProcessMaxRecord;
} else {
datasetGetApprovalProcesss_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetApprovalProcesss_startIndex;
if((inputs.StartIndex == null)) {
datasetGetApprovalProcesss_startIndex = 0;
} else {
datasetGetApprovalProcesss_startIndex = inputs.StartIndex.Value;
}

if((datasetGetApprovalProcesss_maxRecords < 1)) {
datasetGetApprovalProcesss_maxRecords = 1;
}

AggregateRecord<RL_5c614a706e3e33b4caf55ba997e805be> ds_output = new AggregateRecord<RL_5c614a706e3e33b4caf55ba997e805be>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel.datasetGetApprovalProcesss(requestContext,datasetGetApprovalProcesss_maxRecords,datasetGetApprovalProcesss_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ApprovalProcessTypeId,model.varLcl_ApprovalProcessSearchText,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32>(ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetApprovalProcessById")]
[RESTScreenServicesActionProperties(Name="GetApprovalProcessById",Screen="Wb_SearchApprovalProcessDropdown",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalProcessById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "uq0uFK678oUmoLD891KCdw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetApprovalProcessById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetApprovalProcessById_maxRecords = 1;
} else {
datasetGetApprovalProcessById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetApprovalProcessById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetApprovalProcessById_startIndex = 0;
} else {
datasetGetApprovalProcessById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetApprovalProcessById_maxRecords < 1)) {
datasetGetApprovalProcessById_maxRecords = 1;
}

AggregateRecord<RL_5e0ca6ca9da3af4b1d8149758c39c2cf> ds_output = new AggregateRecord<RL_5e0ca6ca9da3af4b1d8149758c39c2cf>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ApprovalProcessId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af>(ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
