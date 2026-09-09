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
[Route("screenservices/ConectaProveedores/e_Orders/OrdersApproved")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_Orders_OrdersApproved_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_Orders_OrdersApproved_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_Orders_OrdersApproved_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_Orders_OrdersApproved_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_Orders_OrdersApproved_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_Orders_OrdersApproved_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderApprovalPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("e_Orders.OrdersApproved"), ConectaProveedores_e_Orders_OrdersApproved_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckPedidosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotPedidosRoleException( "Pedidos role required");

    }


    static ConectaProveedores_e_Orders_OrdersApproved_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*ScreenTableDownloadOrderScreen*/"6dONWMH_kUW9Ti9X5sMIKA*zFV5jIFaYE6Q2XWu3BrcTw", 
/*e_Orders.OrdersApproved.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*HRNdnhLcCUSv8FAn9udL4w", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_e_Orders_OrdersApproved_Controller(
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
[Route("ScreenDataSetGetOrdersApprovedFull")]
[RESTScreenServicesActionProperties(Name="GetOrdersApprovedFull",Screen="OrdersApproved",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrdersApprovedFull(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "IDxY5U+S9Sl0XnIyqOZFdA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrdersApproved_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_OrdersApproved_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrdersApprovedFull_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrdersApprovedFull_maxRecords = 999999999;
} else {
datasetGetOrdersApprovedFull_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrdersApprovedFull_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrdersApprovedFull_startIndex = 0;
} else {
datasetGetOrdersApprovedFull_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrdersApprovedFull_maxRecords < 1)) {
datasetGetOrdersApprovedFull_maxRecords = 1;
}

AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> ds_output = new AggregateRecord<RL_e72491aae94589c6bfa425f20599b823>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_OrdersApproved_ScreenModel.datasetGetOrdersApprovedFull(requestContext,datasetGetOrdersApprovedFull_maxRecords,datasetGetOrdersApprovedFull_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssOrderApproved_Number,model.clientVariables.ssOrderApproved_SupplierId,BuiltInFunction.GetUserId (),model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c>(ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrdersApproved")]
[RESTScreenServicesActionProperties(Name="GetOrdersApproved",Screen="OrdersApproved",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrdersApproved(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "bAdNFilSh4B1b8Ti9Jv58Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrdersApproved_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_OrdersApproved_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrdersApproved_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrdersApproved_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetOrdersApproved_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrdersApproved_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrdersApproved_startIndex = model.varLcl_StartIndex;
} else {
datasetGetOrdersApproved_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrdersApproved_maxRecords < 1)) {
datasetGetOrdersApproved_maxRecords = 1;
}

AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> ds_output = new AggregateRecord<RL_e72491aae94589c6bfa425f20599b823>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_OrdersApproved_ScreenModel.datasetGetOrdersApproved(requestContext,datasetGetOrdersApproved_maxRecords,datasetGetOrdersApproved_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssOrderApproved_Number,model.clientVariables.ssOrderApproved_SupplierId,BuiltInFunction.GetUserId (),model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c>(ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="OrdersApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrdersApproved_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_e_Orders_OrdersApproved_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="OrdersApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrdersApproved_ActionGetSettings_Model inputs = null;
Actions.lcoGetSettings res =  new Actions.lcoGetSettings();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_e_Orders_OrdersApproved_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_e_Orders_OrdersApproved_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionScreenTableDownloadOrderScreen")]
[RESTScreenServicesActionProperties(Name="ScreenTableDownloadOrderScreen",Screen="OrdersApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionScreenTableDownloadOrderScreen(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Z+etOKPIMacWeT28jRj_oA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Model inputs = null;
Actions.lcoScreenTableDownloadOrderScreen res =  new Actions.lcoScreenTableDownloadOrderScreen();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_File,res.outParamo_StringListIds,res.outParamo_ErrorMsg) = await Actions.ActionScreenTableDownloadOrderScreen(requestContext,inputs.inParami_IsCSV,inputs.inParami_IsPDF,inputs.inParami_IsXLS,inputs.inParaml_OrderScreenTableStructure,cancellationToken);

var output = RESTConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File, res.outParamo_StringListIds, res.outParamo_ErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="OrdersApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_OrdersApproved_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_e_Orders_OrdersApproved_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionColumnTogglerPassColumn(requestContext,inputs.inParami_ColumnJSON,inputs.inParami_TableName,inputs.inParami_UserId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
