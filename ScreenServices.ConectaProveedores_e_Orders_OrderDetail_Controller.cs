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
[Route("screenservices/ConectaProveedores/e_Orders/OrderDetail")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_Orders_OrderDetail_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_Orders_OrderDetail_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_Orders_OrderDetail_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_Orders_OrderDetail_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_Orders_OrderDetail_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_Orders_OrderDetail_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_ColumnsSmallRight_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Sidebar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_OrderLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderReject_Popup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("e_Orders.OrderDetail"), ConectaProveedores_e_Orders_OrderDetail_Controller.CheckPermissionsAsync);
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
{
bool check;
check = await ExtendedActions.CheckPedidosRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckRequisicionesRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckProveedorRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotProveedorRoleException( "Proveedor role required");

    }


    static ConectaProveedores_e_Orders_OrderDetail_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.SidebarOpen*/"Kn_hixxDWEm4lMd7mIpycQ*PN7rZt6KuU6Ljraavd2k6g", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*OutSystemsUI.SidebarClose*/"Kn_hixxDWEm4lMd7mIpycQ*3R4D2mxED0erTuoiqqO3EA", 
/*System_.LogMessage*/"uXCIR2Atc0+es3zYuZSnNw*EWISjHhbK0SKTfwvctEO8g", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_e_Orders_OrderDetail_Controller(
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
[Route("ScreenDataSetGetRejectComment")]
[RESTScreenServicesActionProperties(Name="GetRejectComment",Screen="OrderDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRejectComment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "kSrfER1EWt2N4ouy+vFO3w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrderDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRejectComment_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRejectComment_maxRecords = 1;
} else {
datasetGetRejectComment_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRejectComment_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRejectComment_startIndex = 0;
} else {
datasetGetRejectComment_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRejectComment_maxRecords < 1)) {
datasetGetRejectComment_maxRecords = 1;
}

AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ds_output = new AggregateRecord<RL_17d8289ea48572225dc9530a5725652a>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_OrderDetail_ScreenModel.datasetGetRejectComment(requestContext,datasetGetRejectComment_maxRecords,datasetGetRejectComment_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6>(ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrdersByContractNumber")]
[RESTScreenServicesActionProperties(Name="GetOrdersByContractNumber",Screen="OrderDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrdersByContractNumber(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9IY714ivHHJPGA70NCBs5g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrderDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrdersByContractNumber_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrdersByContractNumber_maxRecords = 50;
} else {
datasetGetOrdersByContractNumber_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrdersByContractNumber_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrdersByContractNumber_startIndex = 0;
} else {
datasetGetOrdersByContractNumber_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrdersByContractNumber_maxRecords < 1)) {
datasetGetOrdersByContractNumber_maxRecords = 1;
}

AggregateRecord<RL_9129a40e214c2e67892c6ae5dfbfb7b5> ds_output = new AggregateRecord<RL_9129a40e214c2e67892c6ae5dfbfb7b5>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_OrderDetail_ScreenModel.datasetGetOrdersByContractNumber(requestContext,datasetGetOrdersByContractNumber_maxRecords,datasetGetOrdersByContractNumber_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetOrderMainById.List.CurrentRec.ssENOrderDetail.ssContractNumber,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b>(ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderMainById")]
[RESTScreenServicesActionProperties(Name="GetOrderMainById",Screen="OrderDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderMainById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "VGBFEm0efhCiTwokxCmF0Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrderDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderMainById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderMainById_maxRecords = 1;
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

AggregateRecord<RL_4f9bb0401ba1a9d16c01e66cc4639c20> ds_output = new AggregateRecord<RL_4f9bb0401ba1a9d16c01e66cc4639c20>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_OrderDetail_ScreenModel.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionGetIsCxP_RequestErrorDistribution(requestContext,cancellationToken)),(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2>(ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="OrderDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "bC78gmCKDDEz1pDpYZrGcw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrderDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamo_IsActiveDEV_HU13008_Complement;
outParamo_IsActiveDEV_HU13008_Complement = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_e_Orders_OrderDetail_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_IsActiveDEV_HU13008_Complement);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="OrderDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrderDetail_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_e_Orders_OrderDetail_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
