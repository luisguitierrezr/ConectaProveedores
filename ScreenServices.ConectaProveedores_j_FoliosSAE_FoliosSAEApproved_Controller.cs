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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEApproved")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Search_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CalendarClear_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("j_FoliosSAE.FoliosSAEApproved"), ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckFoliosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotFoliosRoleException( "Folios role required");

    }


    static ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*j_FoliosSAE.FoliosSAEApproved.ResetFilters*/"6dONWMH_kUW9Ti9X5sMIKA*RsHQCIPe0Um+gkDmyYlbbA", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*ScreenTableDownloadFoliosSAEScreen*/"6dONWMH_kUW9Ti9X5sMIKA*idZaWOJmX0OdjFWCRK1cVg", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*j_FoliosSAE.FoliosSAEApproved.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*ydpP1zNsRU+ZYulL9l8g1A", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_Controller(
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
[Route("ScreenDataSetGetFoliosSAE")]
[RESTScreenServicesActionProperties(Name="GetFoliosSAE",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFoliosSAE(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "mCZIJZ1INy0kA6yPHqYnfg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFoliosSAE_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFoliosSAE_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetFoliosSAE_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFoliosSAE_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFoliosSAE_startIndex = model.varLcl_StartIndex;
} else {
datasetGetFoliosSAE_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFoliosSAE_maxRecords < 1)) {
datasetGetFoliosSAE_maxRecords = 1;
}

AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ds_output = new AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.datasetGetFoliosSAE(requestContext,datasetGetFoliosSAE_maxRecords,datasetGetFoliosSAE_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssFolioApproved_CreatedOnDate,model.clientVariables.ssFolioApproved_CreatedToDate,model.clientVariables.ssFolioApproved_FolioNumber,model.clientVariables.ssFolioApproved_OrderNumber,model.clientVariables.ssFolioApproved_RegionId,model.clientVariables.ssFolioApproved_StatusId,model.clientVariables.ssFolioApproved_SupplierId,model.clientVariables.ssOffsetUtc,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),model.varLcGetUserApplicationRoles.outParamAppRoleListText,model.varLcGetUserApplicationRoles.outParamEntraRolesListText,(await Functions.ActionGetUserDepartmentId(requestContext,"",cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d>(ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFoliosSAEFull")]
[RESTScreenServicesActionProperties(Name="GetFoliosSAEFull",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFoliosSAEFull(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F_v_vAc1C0gKEjOPFgV0Iw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFoliosSAEFull_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFoliosSAEFull_maxRecords = 999999999;
} else {
datasetGetFoliosSAEFull_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFoliosSAEFull_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFoliosSAEFull_startIndex = 0;
} else {
datasetGetFoliosSAEFull_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFoliosSAEFull_maxRecords < 1)) {
datasetGetFoliosSAEFull_maxRecords = 1;
}

AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f> ds_output = new AggregateRecord<RL_c2883fff640d266ea46702d7f4b1c10f>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.datasetGetFoliosSAEFull(requestContext,datasetGetFoliosSAEFull_maxRecords,datasetGetFoliosSAEFull_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssFolioApproved_CreatedOnDate,model.clientVariables.ssFolioApproved_CreatedToDate,model.clientVariables.ssFolioApproved_FolioNumber,model.clientVariables.ssFolioApproved_OrderNumber,model.clientVariables.ssFolioApproved_RegionId,model.clientVariables.ssFolioApproved_StatusId,model.clientVariables.ssFolioApproved_SupplierId,model.clientVariables.ssOffsetUtc,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),model.varLcGetUserApplicationRoles.outParamAppRoleListText,model.varLcGetUserApplicationRoles.outParamEntraRolesListText,(await Functions.ActionGetUserDepartmentId(requestContext,"",cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d>(ssConectaProveedores.RestRecords.RESTRC_d7d7e269eeb924718adc0d2a0b1d922d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRegions")]
[RESTScreenServicesActionProperties(Name="GetRegions",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRegions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "SJnDYtRnLWQGCXlJCfY6FA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRegions_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRegions_maxRecords = 999999999;
} else {
datasetGetRegions_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRegions_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRegions_startIndex = 0;
} else {
datasetGetRegions_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRegions_maxRecords < 1)) {
datasetGetRegions_maxRecords = 1;
}

AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516> ds_output = new AggregateRecord<RL_07bd6e6f32ae098d324b78b5f3777516>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c>(ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioStatus")]
[RESTScreenServicesActionProperties(Name="GetFolioStatus",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioStatus(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "xBnU5wAcTZo_8FO6VaKyzw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioStatus_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioStatus_maxRecords = 999999999;
} else {
datasetGetFolioStatus_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioStatus_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioStatus_startIndex = 0;
} else {
datasetGetFolioStatus_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioStatus_maxRecords < 1)) {
datasetGetFolioStatus_maxRecords = 1;
}

AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ds_output = new AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.datasetGetFolioStatus(requestContext,datasetGetFolioStatus_maxRecords,datasetGetFolioStatus_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2>(ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "haCDyNX9C_GaQ3CKvLwB8A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamAppRoleListText;
string outParamEntraRolesListText;
bool outParamCanBulkApprove;
bool outParamIsActiveDEV_NewVersionScreenDownloads;
(outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText,outParamCanBulkApprove,outParamIsActiveDEV_NewVersionScreenDownloads) = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamAppRoleListText, outParamEntraRolesListText, outParamCanBulkApprove, outParamIsActiveDEV_NewVersionScreenDownloads);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionScreenTableDownloadFoliosSAEScreen")]
[RESTScreenServicesActionProperties(Name="ScreenTableDownloadFoliosSAEScreen",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionScreenTableDownloadFoliosSAEScreen(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "LVjcGOv1UoUSO9O1l3vMbw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Model inputs = null;
Actions.lcoScreenTableDownloadFoliosSAEScreen res =  new Actions.lcoScreenTableDownloadFoliosSAEScreen();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_File,res.outParamo_StringListIds,res.outParamo_ErrorMsg) = await Actions.ActionScreenTableDownloadFoliosSAEScreen(requestContext,inputs.inParami_IsCSV,inputs.inParami_IsPDF,inputs.inParami_IsXLS,inputs.inParami_FolioScreenTableStructure,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File, res.outParamo_StringListIds, res.outParamo_ErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="FoliosSAEApproved",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
