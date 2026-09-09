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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_ColumnsSmallRight_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_FolioLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_ButtonLoading_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("j_FoliosSAE.PreApprovalFolioDetail"), ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller.CheckPermissionsAsync);
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
{
bool check;
check = await ExtendedActions.CheckFoliosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotFoliosRoleException( "Folios role required");

    }


    static ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*CancelFolio*/"6dONWMH_kUW9Ti9X5sMIKA*_vBXQrbcFEe77kFsgmTx4Q", 
/*j_FoliosSAE.PreApprovalFolioDetail.TogglePopup*/"6dONWMH_kUW9Ti9X5sMIKA*yFOkZG4p+EiGbPUaVKYNxA", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_Controller(
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
[Route("ScreenDataSetGetFolioById")]
[RESTScreenServicesActionProperties(Name="GetFolioById",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "RJfNj93mpUtUsFcG33deXw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioById_maxRecords = 1;
} else {
datasetGetFolioById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioById_startIndex = 0;
} else {
datasetGetFolioById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioById_maxRecords < 1)) {
datasetGetFolioById_maxRecords = 1;
}

AggregateRecord<RL_906cfbdbf8c03778600b870bd5d6309b> ds_output = new AggregateRecord<RL_906cfbdbf8c03778600b870bd5d6309b>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_FolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28>(ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderMains")]
[RESTScreenServicesActionProperties(Name="GetOrderMains",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderMains(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9wptoqGyIhY+bk7oZFsLCw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderMains_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderMains_maxRecords = 50;
} else {
datasetGetOrderMains_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderMains_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderMains_startIndex = 0;
} else {
datasetGetOrderMains_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderMains_maxRecords < 1)) {
datasetGetOrderMains_maxRecords = 1;
}

AggregateRecord<RL_1751b6fc487a87e5015dd52d099b7396> ds_output = new AggregateRecord<RL_1751b6fc487a87e5015dd52d099b7396>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.datasetGetOrderMains(requestContext,datasetGetOrderMains_maxRecords,datasetGetOrderMains_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_8e32b78ccc2e260e65e10c5d6c59046d>(ssConectaProveedores.RestRecords.RESTRC_8e32b78ccc2e260e65e10c5d6c59046d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSuppliers")]
[RESTScreenServicesActionProperties(Name="GetSuppliers",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSuppliers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XUfoK88vdt8Q9S49yI+Wbw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSuppliers_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSuppliers_maxRecords = 50;
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

AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ds_output = new AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.datasetGetSuppliers(requestContext,datasetGetSuppliers_maxRecords,datasetGetSuppliers_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce>(ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioApprovalLevels")]
[RESTScreenServicesActionProperties(Name="GetFolioApprovalLevels",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioApprovalLevels(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XYhIFg1h4Qtmrh1PGjUCYQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioApprovalLevels_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioApprovalLevels_maxRecords = 50;
} else {
datasetGetFolioApprovalLevels_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioApprovalLevels_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioApprovalLevels_startIndex = 0;
} else {
datasetGetFolioApprovalLevels_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioApprovalLevels_maxRecords < 1)) {
datasetGetFolioApprovalLevels_maxRecords = 1;
}

AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de> ds_output = new AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.datasetGetFolioApprovalLevels(requestContext,datasetGetFolioApprovalLevels_maxRecords,datasetGetFolioApprovalLevels_startIndex,IterationMultiplicity.Multiple,model.inParami_FolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_e40e190961051a83f0f95a5985af6cdd>(ssConectaProveedores.RestRecords.RESTRC_e40e190961051a83f0f95a5985af6cdd.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioItemsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioItemsByFolioId",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioItemsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CAtxS2ERBBGr3FuUSoX4qw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioItemsByFolioId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioItemsByFolioId_maxRecords = model.varLcMaxRecords;
} else {
datasetGetFolioItemsByFolioId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioItemsByFolioId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioItemsByFolioId_startIndex = model.varLcStartIndex;
} else {
datasetGetFolioItemsByFolioId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioItemsByFolioId_maxRecords < 1)) {
datasetGetFolioItemsByFolioId_maxRecords = 1;
}

AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ds_output = new AggregateRecord<RL_a968cf9f63475dc9358672149b11245a>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.datasetGetFolioItemsByFolioId(requestContext,datasetGetFolioItemsByFolioId_maxRecords,datasetGetFolioItemsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParami_FolioId,model.varLcTableSort,model.varLcTableSort2,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2>(ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCurrencies")]
[RESTScreenServicesActionProperties(Name="GetCurrencies",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCurrencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f+VnB3EzqSeam1tAXE44KQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCurrencies_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCurrencies_maxRecords = 50;
} else {
datasetGetCurrencies_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCurrencies_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCurrencies_startIndex = 0;
} else {
datasetGetCurrencies_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCurrencies_maxRecords < 1)) {
datasetGetCurrencies_maxRecords = 1;
}

AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ds_output = new AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.datasetGetCurrencies(requestContext,datasetGetCurrencies_maxRecords,datasetGetCurrencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e>(ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCompanies")]
[RESTScreenServicesActionProperties(Name="GetCompanies",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCompanies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "fuNZkB7C5QmfKr5yUIVg3g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCompanies_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCompanies_maxRecords = 50;
} else {
datasetGetCompanies_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCompanies_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCompanies_startIndex = 0;
} else {
datasetGetCompanies_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCompanies_maxRecords < 1)) {
datasetGetCompanies_maxRecords = 1;
}

AggregateRecord<RL_1409548829f9518cbebb0e467312ef87> ds_output = new AggregateRecord<RL_1409548829f9518cbebb0e467312ef87>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383>(ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserData")]
[RESTScreenServicesActionProperties(Name="GetUserData",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "u9rDSDiupqS30ElVXCLf9Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamo_Region;
bool outParamo_IsCXP;
(outParamo_Region,outParamo_IsCXP) = await model.DataActionGetUserData(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_Region, outParamo_IsCXP);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionCancelFolio")]
[RESTScreenServicesActionProperties(Name="CancelFolio",Screen="PreApprovalFolioDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionCancelFolio(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "WRNZNDPipRwzS2RSrvOwwQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ActionCancelFolio_Model inputs = null;
Actions.lcoCancelFolio res =  new Actions.lcoCancelFolio();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ActionCancelFolio_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMsg = await Actions.ActionCancelFolio(requestContext,inputs.inParamObject,inputs.inParamFolioReject,inputs.inParamFolioApprovalLevels_List,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ActionCancelFolio_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}
}
