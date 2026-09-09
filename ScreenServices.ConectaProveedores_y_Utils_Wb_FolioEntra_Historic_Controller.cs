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
[Route("screenservices/ConectaProveedores/y_Utils/Wb_FolioEntra_Historic")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller(
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
[Route("ScreenDataSetGetOrderMainById")]
[RESTScreenServicesActionProperties(Name="GetOrderMainById",Screen="Wb_FolioEntra_Historic",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderMainById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KywQen9CHYIRvv60scYolw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderMainById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderMainById_maxRecords = 50;
} else {
datasetGetOrderMainById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderMainById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderMainById_startIndex = 0;
} else {
datasetGetOrderMainById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderMainById_maxRecords < 1)) {
datasetGetOrderMainById_maxRecords = 1;
}

AggregateRecord<RL_339e5fbd74448809f3620bf1c8c54b9a> ds_output = new AggregateRecord<RL_339e5fbd74448809f3620bf1c8c54b9a>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderMainId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446>(ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderMainApprovalLevels")]
[RESTScreenServicesActionProperties(Name="GetOrderMainApprovalLevels",Screen="Wb_FolioEntra_Historic",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderMainApprovalLevels(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "eNSja1n6Bswwml8yz9TcWQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderMainApprovalLevels_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderMainApprovalLevels_maxRecords = 999999999;
} else {
datasetGetOrderMainApprovalLevels_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderMainApprovalLevels_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderMainApprovalLevels_startIndex = 0;
} else {
datasetGetOrderMainApprovalLevels_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderMainApprovalLevels_maxRecords < 1)) {
datasetGetOrderMainApprovalLevels_maxRecords = 1;
}

AggregateRecord<RL_e7b917e1824eb68e8cf92fc307d1415d> ds_output = new AggregateRecord<RL_e7b917e1824eb68e8cf92fc307d1415d>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel.datasetGetOrderMainApprovalLevels(requestContext,datasetGetOrderMainApprovalLevels_maxRecords,datasetGetOrderMainApprovalLevels_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.ScreenDataSetGetOrderMainById.List.CurrentRec.ssENOrderMain.ssOrderStatusId,model.inParami_OrderMainId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f>(ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetEntraUserManagerList")]
[RESTScreenServicesActionProperties(Name="GetEntraUserManagerList",Screen="Wb_FolioEntra_Historic",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetEntraUserManagerList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Bv69ti44rzc1f5xg1+PCbg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList;
outParamUserList = await model.DataActionGetEntraUserManagerList(requestContext,cancellationToken);

var output = RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserList);
return output;


    }, cancellationToken);
}
}
