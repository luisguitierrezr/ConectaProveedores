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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController(ConectaProveedores_y_Utils_Wb_TimelineUsersV2_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ConfirmPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SAECDetailMain_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_FolioLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("j_FoliosSAE.FolioSAE_Details"), ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckProveedorRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckFoliosRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckComissionesArrendamientosViewerRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotComissionesArrendamientosViewerRoleException( "ComissionesArrendamientosViewer role required");

    }


    static ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*FolioCancelFromProveedor*/"6dONWMH_kUW9Ti9X5sMIKA*B4J7GGQGQkudVYbyVaKU9g", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_Controller(
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
[Route("ScreenDataSetGetFolioItemsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioItemsByFolioId",Screen="FolioSAE_Details",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioItemsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ThsXqfcJ_cmZ3sfSw6f06A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.datasetGetFolioItemsByFolioId(requestContext,datasetGetFolioItemsByFolioId_maxRecords,datasetGetFolioItemsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParami_FolioId,model.varLcTableSort,cancellationToken);

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
[Route("ScreenDataSetGetFolioApprovalRejectReason")]
[RESTScreenServicesActionProperties(Name="GetFolioApprovalRejectReason",Screen="FolioSAE_Details",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioApprovalRejectReason(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "p6xYQLI8Jbh5uMewTpEvGQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioApprovalRejectReason_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioApprovalRejectReason_maxRecords = 1;
} else {
datasetGetFolioApprovalRejectReason_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioApprovalRejectReason_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioApprovalRejectReason_startIndex = 0;
} else {
datasetGetFolioApprovalRejectReason_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioApprovalRejectReason_maxRecords < 1)) {
datasetGetFolioApprovalRejectReason_maxRecords = 1;
}

AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564> ds_output = new AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.datasetGetFolioApprovalRejectReason(requestContext,datasetGetFolioApprovalRejectReason_maxRecords,datasetGetFolioApprovalRejectReason_startIndex,IterationMultiplicity.Multiple,model.inParami_FolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8>(ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioComments")]
[RESTScreenServicesActionProperties(Name="GetFolioComments",Screen="FolioSAE_Details",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioComments(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "HZbIcsZqIVN0tCEPa4xSRA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioComments_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioComments_maxRecords = 50;
} else {
datasetGetFolioComments_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioComments_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioComments_startIndex = 0;
} else {
datasetGetFolioComments_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioComments_maxRecords < 1)) {
datasetGetFolioComments_maxRecords = 1;
}

AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ds_output = new AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.datasetGetFolioComments(requestContext,datasetGetFolioComments_maxRecords,datasetGetFolioComments_startIndex,IterationMultiplicity.Multiple,model.inParami_FolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b>(ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFirstApproval")]
[RESTScreenServicesActionProperties(Name="GetFirstApproval",Screen="FolioSAE_Details",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFirstApproval(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "_x4itn6E8yku49J_fOy64w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFirstApproval_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFirstApproval_maxRecords = 1;
} else {
datasetGetFirstApproval_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFirstApproval_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFirstApproval_startIndex = 0;
} else {
datasetGetFirstApproval_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFirstApproval_maxRecords < 1)) {
datasetGetFirstApproval_maxRecords = 1;
}

AggregateRecord<RL_c4a88225f641d9bcf04728601a4668b7> ds_output = new AggregateRecord<RL_c4a88225f641d9bcf04728601a4668b7>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.datasetGetFirstApproval(requestContext,datasetGetFirstApproval_maxRecords,datasetGetFirstApproval_startIndex,IterationMultiplicity.Multiple,model.inParami_FolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d41d580f2f54d1ea8dfa839824757d81>(ssConectaProveedores.RestRecords.RESTRC_d41d580f2f54d1ea8dfa839824757d81.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioById")]
[RESTScreenServicesActionProperties(Name="GetFolioById",Screen="FolioSAE_Details",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OtyQqCIpnkhtLBbEQTqG0w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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

AggregateRecord<RL_a73c6a3c39840602048be2cd6d699c01> ds_output = new AggregateRecord<RL_a73c6a3c39840602048be2cd6d699c01>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckAlmacenRole(requestContext,"",cancellationToken)),(await Functions.ssCheckDesviacionesRole(requestContext,"",cancellationToken)),(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),model.varLcGetUserApplicationRoles.outParamEntraRolesListText,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),2,true,false,cancellationToken)),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),2,true,false,cancellationToken)),(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),model.inParami_FolioId,model.inParami_IsDirectReport,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_619a3314c0f5e7503d1faa5bd2f55a41>(ssConectaProveedores.RestRecords.RESTRC_619a3314c0f5e7503d1faa5bd2f55a41.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="FolioSAE_Details",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "12jnPC+mCW7cuQvB89HM9w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamAppRoleListText;
string outParamEntraRolesListText;
bool outParamIsActiveDEV_DisenoUI;
(outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText,outParamIsActiveDEV_DisenoUI) = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamAppRoleListText, outParamEntraRolesListText, outParamIsActiveDEV_DisenoUI);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetRejectComment")]
[RESTScreenServicesActionProperties(Name="GetRejectComment",Screen="FolioSAE_Details",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetRejectComment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "b8mnYvCwuA6ngz49zWpenQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamRejectCommentText;
outParamRejectCommentText = await model.DataActionGetRejectComment(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamRejectCommentText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetFolioApprovalDisplay")]
[RESTScreenServicesActionProperties(Name="GetFolioApprovalDisplay",Screen="FolioSAE_Details",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetFolioApprovalDisplay(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "APXHJE5apgYORbxfYEYNkw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_875afe918a46d044315dbe3410f1f2a7 outParamFolioApprovalDisplayList;
outParamFolioApprovalDisplayList = await model.DataActionGetFolioApprovalDisplay(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetFolioApprovalDisplay_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamFolioApprovalDisplayList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioCancelFromProveedor")]
[RESTScreenServicesActionProperties(Name="FolioCancelFromProveedor",Screen="FolioSAE_Details",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioCancelFromProveedor(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "C7nqxnK5J+DlTcCQ6Oj8ag", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Model inputs = null;
Actions.lcoFolioCancelFromProveedor res =  new Actions.lcoFolioCancelFromProveedor();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionFolioCancelFromProveedor(requestContext,inputs.inParami_FolioId,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionFolioCancelFromProveedor_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="FolioSAE_Details",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
