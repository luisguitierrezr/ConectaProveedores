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
[Route("screenservices/ConectaProveedores/g_Reports/FoliosSAECReport")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_g_Reports_FoliosSAECReport_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_g_Reports_FoliosSAECReport_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_g_Reports_FoliosSAECReport_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_g_Reports_FoliosSAECReport_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_g_Reports_FoliosSAECReport_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_g_Reports_FoliosSAECReport_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CalendarClear_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("g_Reports.FoliosSAECReport"), ConectaProveedores_g_Reports_FoliosSAECReport_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckReportesRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotReportesRoleException( "Reportes role required");

    }


    static ConectaProveedores_g_Reports_FoliosSAECReport_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*g_Reports.FoliosSAECReport.ResetFilters*/"6dONWMH_kUW9Ti9X5sMIKA*p5nIGEsvwkCah2PA1tj6Qg", 
/*GenerateFolioSAECReport*/"6dONWMH_kUW9Ti9X5sMIKA*rNNLHA2f2Euc314G2ItOig", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*g_Reports.FoliosSAECReport.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*f7ZM4428QUCorJN7PME6AQ", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_g_Reports_FoliosSAECReport_Controller(
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
[Route("ScreenDataSetGetFolioStatuses")]
[RESTScreenServicesActionProperties(Name="GetFolioStatuses",Screen="FoliosSAECReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YiEX4Y3lAA34ViBIgR_A4A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioStatuses_maxRecords = 50;
} else {
datasetGetFolioStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioStatuses_startIndex = 0;
} else {
datasetGetFolioStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioStatuses_maxRecords < 1)) {
datasetGetFolioStatuses_maxRecords = 1;
}

AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ds_output = new AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.datasetGetFolioStatuses(requestContext,datasetGetFolioStatuses_maxRecords,datasetGetFolioStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetTelcelDirections")]
[RESTScreenServicesActionProperties(Name="GetTelcelDirections",Screen="FoliosSAECReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetTelcelDirections(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "FYAwP2s2APtNzU1Y4DBbfg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetTelcelDirections_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetTelcelDirections_maxRecords = 50;
} else {
datasetGetTelcelDirections_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetTelcelDirections_startIndex;
if((inputs.StartIndex == null)) {
datasetGetTelcelDirections_startIndex = 0;
} else {
datasetGetTelcelDirections_startIndex = inputs.StartIndex.Value;
}

if((datasetGetTelcelDirections_maxRecords < 1)) {
datasetGetTelcelDirections_maxRecords = 1;
}

AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838> ds_output = new AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.datasetGetTelcelDirections(requestContext,datasetGetTelcelDirections_maxRecords,datasetGetTelcelDirections_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5>(ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioSAECItems")]
[RESTScreenServicesActionProperties(Name="GetFolioSAECItems",Screen="FoliosSAECReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioSAECItems(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "tVSYsYIhpQ8bFJfPFSY5og", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioSAECItems_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioSAECItems_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetFolioSAECItems_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioSAECItems_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioSAECItems_startIndex = model.varLcStartIndex;
} else {
datasetGetFolioSAECItems_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioSAECItems_maxRecords < 1)) {
datasetGetFolioSAECItems_maxRecords = 1;
}

AggregateRecord<RL_ed90a45f2cc96d244d7fc28b114020f0> ds_output = new AggregateRecord<RL_ed90a45f2cc96d244d7fc28b114020f0>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.datasetGetFolioSAECItems(requestContext,datasetGetFolioSAECItems_maxRecords,datasetGetFolioSAECItems_startIndex,IterationMultiplicity.Multiple,model.clientVariables.ssOffsetUtc,model.clientVariables.ssReport60_Applicant,model.clientVariables.ssReport60_AreaId,model.clientVariables.ssReport60_EndDate,model.clientVariables.ssReport60_OrderNumber,model.clientVariables.ssReport60_RegionId,model.clientVariables.ssReport60_SociedadId,model.clientVariables.ssReport60_StartDate,model.clientVariables.ssReport60_StatusId,model.clientVariables.ssReport60_SupplierId,model.varLcGetUserApplicationRoles.outParamIsAllRegions,model.varLcGetUserApplicationRoles.outParamSupplierId,model.varLcGetUserApplicationRoles.outParamUserRegion,BuiltInFunction.GetUserId (),model.varLcIsToEmpty,model.varLcTableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_89c1eb236aae2b02b66345e2ec5e59e9>(ssConectaProveedores.RestRecords.RESTRC_89c1eb236aae2b02b66345e2ec5e59e9.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCompanies")]
[RESTScreenServicesActionProperties(Name="GetCompanies",Screen="FoliosSAECReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCompanies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Q7lNESXlNYNXerq8MHCjFA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCompanies_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCompanies_maxRecords = 99999;
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

AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ds_output = new AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1>(ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetApplicants")]
[RESTScreenServicesActionProperties(Name="GetApplicants",Screen="FoliosSAECReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApplicants(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "QGj5UPJMXgsrzLLjlFNWXQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetApplicants_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetApplicants_maxRecords = 99999;
} else {
datasetGetApplicants_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetApplicants_startIndex;
if((inputs.StartIndex == null)) {
datasetGetApplicants_startIndex = 0;
} else {
datasetGetApplicants_startIndex = inputs.StartIndex.Value;
}

if((datasetGetApplicants_maxRecords < 1)) {
datasetGetApplicants_maxRecords = 1;
}

AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b> ds_output = new AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.datasetGetApplicants(requestContext,datasetGetApplicants_maxRecords,datasetGetApplicants_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_9fd4d8d4a1a7da3e37ee97c8163946e6>(ssConectaProveedores.RestRecords.RESTRC_9fd4d8d4a1a7da3e37ee97c8163946e6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRegions")]
[RESTScreenServicesActionProperties(Name="GetRegions",Screen="FoliosSAECReport",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRegions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F9suSx2_X8+qIMY5h0gbYw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="FoliosSAECReport",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "JhHCXCHkNDUQfjeymf6xrg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

long outParamUserRegion;
long outParamSupplierId;
bool outParamIsAllRegions;
(outParamUserRegion,outParamSupplierId,outParamIsAllRegions) = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRegion, outParamSupplierId, outParamIsAllRegions);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="FoliosSAECReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGenerateFolioSAECReport")]
[RESTScreenServicesActionProperties(Name="GenerateFolioSAECReport",Screen="FoliosSAECReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGenerateFolioSAECReport(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "QM45R4LhCrP92QgOb7pLuw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Model inputs = null;
Actions.lcoGenerateFolioSAECReport res =  new Actions.lcoGenerateFolioSAECReport();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamFile = await Actions.ActionGenerateFolioSAECReport(requestContext,inputs.inParami_OffsetUtc,inputs.inParamIsToEmpty,inputs.inParamSupplierId,inputs.inParamUserRegion,inputs.inParamIsAllRegions,inputs.inParamReport60_OrderNumber,inputs.inParamReport60_SupplierId,inputs.inParamReport60_StartDate,inputs.inParamReport60_EndDate,inputs.inParamReport60_RegionId,inputs.inParamReport60_StatusId,inputs.inParamReport60_SociedadId,inputs.inParamReport60_Applicant,inputs.inParamReport60_AreaId,cancellationToken);

var output = RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamFile);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="FoliosSAECReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionColumnTogglerPassColumn(requestContext,inputs.inParami_ColumnJSON,inputs.inParami_TableName,inputs.inParami_UserId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="FoliosSAECReport",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_FoliosSAECReport_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}
}
