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
[Route("screenservices/ConectaProveedores/e_Orders/Wb_SearchSupplierForOrder")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_SupplierType_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.DropdownSetValue*/"Kn_hixxDWEm4lMd7mIpycQ*N7nA_0RvCk6uhvJk+jStNg", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA"});

    }

    public ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller(
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
[Route("ScreenDataSetGetSupplierById")]
[RESTScreenServicesActionProperties(Name="GetSupplierById",Screen="Wb_SearchSupplierForOrder",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "X9jcz5zHtrsjdT5MlBoFSA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSupplierById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSupplierById_maxRecords = 1;
} else {
datasetGetSupplierById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSupplierById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSupplierById_startIndex = 0;
} else {
datasetGetSupplierById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSupplierById_maxRecords < 1)) {
datasetGetSupplierById_maxRecords = 1;
}

AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ds_output = new AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Multiple,model.inParamSupplierId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e>(ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderById")]
[RESTScreenServicesActionProperties(Name="GetOrderById",Screen="Wb_SearchSupplierForOrder",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Ut3IZN7sg94QxjJoYRj6WQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderById_maxRecords = 50;
} else {
datasetGetOrderById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderById_startIndex = 0;
} else {
datasetGetOrderById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderById_maxRecords < 1)) {
datasetGetOrderById_maxRecords = 1;
}

AggregateRecord<RL_03c4be65764ae68c963db8500f2f1711> ds_output = new AggregateRecord<RL_03c4be65764ae68c963db8500f2f1711>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Multiple,model.inParamOrderMainId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a>(ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSuppliers")]
[RESTScreenServicesActionProperties(Name="GetSuppliers",Screen="Wb_SearchSupplierForOrder",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSuppliers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "MarLzvC0Ak57cuL9zvu4SQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSuppliers_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSuppliers_maxRecords = 999999999;
} else {
datasetGetSuppliers_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSuppliers_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSuppliers_startIndex = 0;
} else {
datasetGetSuppliers_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSuppliers_maxRecords < 1)) {
datasetGetSuppliers_maxRecords = 1;
}

AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ds_output = new AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel.datasetGetSuppliers(requestContext,datasetGetSuppliers_maxRecords,datasetGetSuppliers_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),model.ScreenDataSetGetOrderById.List.CurrentRec.ssENOrderMain.ssRegionId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e>(ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
