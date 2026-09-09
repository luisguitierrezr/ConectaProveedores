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
[Route("screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CalendarClear_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("g_Reports.SupplierInvoicesReport"), ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckTelcelUserAuditorRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckProveedorRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotProveedorRoleException( "Proveedor role required");

    }


    static ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*GenerateInvoicesReport48_Invoices2*/"6dONWMH_kUW9Ti9X5sMIKA*XSQqK1OghkaE24+39rUEpg", 
/*GenerateInvoicesReport48*/"6dONWMH_kUW9Ti9X5sMIKA*2naGSygyOkyak40umvdcTA", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*g_Reports.SupplierInvoicesReport.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*nuPNr8I4U0GQVwjicrJF+g", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*g_Reports.SupplierInvoicesReport.ResetFilters*/"6dONWMH_kUW9Ti9X5sMIKA*TJ0q6+PPGUe3Wk30PBda2g", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_g_Reports_SupplierInvoicesReport_Controller(
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
[Route("ScreenDataSetGetInvoiceStatuses")]
[RESTScreenServicesActionProperties(Name="GetInvoiceStatuses",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "utvzQMvCRKj9zqcwJYu94w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceStatuses_maxRecords = 50;
} else {
datasetGetInvoiceStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceStatuses_startIndex = 0;
} else {
datasetGetInvoiceStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceStatuses_maxRecords < 1)) {
datasetGetInvoiceStatuses_maxRecords = 1;
}

AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> ds_output = new AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.datasetGetInvoiceStatuses(requestContext,datasetGetInvoiceStatuses_maxRecords,datasetGetInvoiceStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940>(ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSuppliers")]
[RESTScreenServicesActionProperties(Name="GetSuppliers",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSuppliers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "sWvarXmO8jieuqPjhkj3Ew", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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

AggregateRecord<RL_1543a4f2af6703945e350e1348a6aecf> ds_output = new AggregateRecord<RL_1543a4f2af6703945e350e1348a6aecf>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.datasetGetSuppliers(requestContext,datasetGetSuppliers_maxRecords,datasetGetSuppliers_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668>(ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoices")]
[RESTScreenServicesActionProperties(Name="GetInvoices",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "GycdLIWKrbHxQBK5VfeGJw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoices_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoices_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetInvoices_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoices_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoices_startIndex = model.varLcStartIndex;
} else {
datasetGetInvoices_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoices_maxRecords < 1)) {
datasetGetInvoices_maxRecords = 1;
}

AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> ds_output = new AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssInvReport48_DateFrom,model.clientVariables.ssInvReport48_DateTo,model.clientVariables.ssInvReport48_InvoiceName,model.clientVariables.ssInvReport48_InvoiceStatusId,model.clientVariables.ssInvReport48_RegionId,model.clientVariables.ssInvReport48_SupplierId,model.clientVariables.ssOffsetUtc,model.varLcIsToEmpty,model.varLcTableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8>(ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRegions")]
[RESTScreenServicesActionProperties(Name="GetRegions",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRegions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F9suSx2_X8+qIMY5h0gbYw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRegions_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRegions_maxRecords = 99999;
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

AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ds_output = new AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0>(ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoicesAllRecords")]
[RESTScreenServicesActionProperties(Name="GetInvoicesAllRecords",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoicesAllRecords(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "N4whkgnaq5ijtZatINlt_w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoicesAllRecords_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoicesAllRecords_maxRecords = 999999999;
} else {
datasetGetInvoicesAllRecords_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoicesAllRecords_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoicesAllRecords_startIndex = 0;
} else {
datasetGetInvoicesAllRecords_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoicesAllRecords_maxRecords < 1)) {
datasetGetInvoicesAllRecords_maxRecords = 1;
}

AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> ds_output = new AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.datasetGetInvoicesAllRecords(requestContext,datasetGetInvoicesAllRecords_maxRecords,datasetGetInvoicesAllRecords_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssInvReport48_DateFrom,model.clientVariables.ssInvReport48_DateTo,model.clientVariables.ssInvReport48_InvoiceName,model.clientVariables.ssInvReport48_InvoiceStatusId,model.clientVariables.ssInvReport48_RegionId,model.clientVariables.ssInvReport48_SupplierId,model.clientVariables.ssOffsetUtc,model.varLcIsToEmpty,model.varLcTableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8>(ssConectaProveedores.RestRecords.RESTRC_d69e4e199c0b5f039f18c7b39fbe84d8.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "jsI1PCbvcpcN_+fOwgD4_w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamo_IsActiveDEV_C01;
outParamo_IsActiveDEV_C01 = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_IsActiveDEV_C01);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "gJTBMXdb0W8I4iB5LAw6xA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
bool outParamIsAuditor;
long outParamSupplierId;
long outParamUserRegion;
bool outParamIsAllRegions;
(outParamUserRolesList,outParamIsAuditor,outParamSupplierId,outParamUserRegion,outParamIsAllRegions) = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamIsAuditor, outParamSupplierId, outParamUserRegion, outParamIsAllRegions);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionColumnTogglerPassColumn(requestContext,inputs.inParami_ColumnJSON,inputs.inParami_TableName,inputs.inParami_UserId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGenerateInvoicesReport48")]
[RESTScreenServicesActionProperties(Name="GenerateInvoicesReport48",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGenerateInvoicesReport48(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "S+GMHOnsO+k+AtoNnCeSdw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Model inputs = null;
Actions.lcoGenerateInvoicesReport48 res =  new Actions.lcoGenerateInvoicesReport48();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamFile = await Actions.ActionGenerateInvoicesReport48(requestContext,inputs.inParamFilters,inputs.inParami_OffsetUtc,cancellationToken);

var output = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamFile);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGenerateInvoicesReport48_Invoices2")]
[RESTScreenServicesActionProperties(Name="GenerateInvoicesReport48_Invoices2",Screen="SupplierInvoicesReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGenerateInvoicesReport48_Invoices2(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "zbaL4N0oEk1d1s23EWr3Kw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Model inputs = null;
Actions.lcoGenerateInvoicesReport48_Invoices2 res =  new Actions.lcoGenerateInvoicesReport48_Invoices2();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamFile = await Actions.ActionGenerateInvoicesReport48_Invoices2(requestContext,inputs.inParami_OffsetUtc,inputs.inParamInvoiceIdList,cancellationToken);

var output = RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamFile);
return output;


    }, cancellationToken);
}
}
