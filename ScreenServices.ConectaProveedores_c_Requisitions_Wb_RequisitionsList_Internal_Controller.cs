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
[Route("screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Search_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CalendarClear_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ConfirmPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_Controller.ProxyInstance, childControllers);
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



    static ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*RequisitionCancel*/"6dONWMH_kUW9Ti9X5sMIKA*j1PxAZK4I0mdoS1oqGZvYw", 
/*c_Requisitions.Wb_RequisitionsList_Internal.ShowHideCancelPopup*/"6dONWMH_kUW9Ti9X5sMIKA*Z7e+CfzrW0OVRVvJJdM9AQ", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*ScreenTableDownloadWbRequisitionsListInternal*/"6dONWMH_kUW9Ti9X5sMIKA*S+FXnpeeCEa_T+vJcWLJOg", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*c_Requisitions.Wb_RequisitionsList_Internal.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*GWpF8iNI+kaxfvUkClyNKw", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_Controller(
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
[Route("ScreenDataSetGetCompanies")]
[RESTScreenServicesActionProperties(Name="GetCompanies",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCompanies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dUlLiZXilCXZfHjYY_ZYJg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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

AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ds_output = new AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGetApprovalStatuses")]
[RESTScreenServicesActionProperties(Name="GetApprovalStatuses",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "SOfFGGF3iufQOk4hAyThKw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetApprovalStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetApprovalStatuses_maxRecords = 50;
} else {
datasetGetApprovalStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetApprovalStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetApprovalStatuses_startIndex = 0;
} else {
datasetGetApprovalStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetApprovalStatuses_maxRecords < 1)) {
datasetGetApprovalStatuses_maxRecords = 1;
}

AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ds_output = new AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.datasetGetApprovalStatuses(requestContext,datasetGetApprovalStatuses_maxRecords,datasetGetApprovalStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302>(ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRequisitionStatuses")]
[RESTScreenServicesActionProperties(Name="GetRequisitionStatuses",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "g2bACkjRlxCOdm4LTzpLVw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionStatuses_maxRecords = 50;
} else {
datasetGetRequisitionStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionStatuses_startIndex = 0;
} else {
datasetGetRequisitionStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionStatuses_maxRecords < 1)) {
datasetGetRequisitionStatuses_maxRecords = 1;
}

AggregateRecord<RL_7324330f004cfb528140f21030a5e90f> ds_output = new AggregateRecord<RL_7324330f004cfb528140f21030a5e90f>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.datasetGetRequisitionStatuses(requestContext,datasetGetRequisitionStatuses_maxRecords,datasetGetRequisitionStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b>(ssConectaProveedores.RestRecords.RESTRC_b0a85cd983a4f43fec20a9e94774104b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetEntraRole")]
[RESTScreenServicesActionProperties(Name="GetEntraRole",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetEntraRole(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7qyGTC_5OnA_VV8+D1QF6g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetEntraRole_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetEntraRole_maxRecords = 1;
} else {
datasetGetEntraRole_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetEntraRole_startIndex;
if((inputs.StartIndex == null)) {
datasetGetEntraRole_startIndex = 0;
} else {
datasetGetEntraRole_startIndex = inputs.StartIndex.Value;
}

if((datasetGetEntraRole_maxRecords < 1)) {
datasetGetEntraRole_maxRecords = 1;
}

AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ds_output = new AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.datasetGetEntraRole(requestContext,datasetGetEntraRole_maxRecords,datasetGetEntraRole_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b>(ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProjectAssetServices")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetServices",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetServices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "QmIftqTsNkC++1frUcNFQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProjectAssetServices_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProjectAssetServices_maxRecords = 9999;
} else {
datasetGetProjectAssetServices_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProjectAssetServices_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProjectAssetServices_startIndex = 0;
} else {
datasetGetProjectAssetServices_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProjectAssetServices_maxRecords < 1)) {
datasetGetProjectAssetServices_maxRecords = 1;
}

AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ds_output = new AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.datasetGetProjectAssetServices(requestContext,datasetGetProjectAssetServices_maxRecords,datasetGetProjectAssetServices_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e>(ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCostCenters")]
[RESTScreenServicesActionProperties(Name="GetCostCenters",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCostCenters(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "PFgOcVYTyd2esKT4r8d2yg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCostCenters_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCostCenters_maxRecords = 999999999;
} else {
datasetGetCostCenters_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCostCenters_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCostCenters_startIndex = 0;
} else {
datasetGetCostCenters_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCostCenters_maxRecords < 1)) {
datasetGetCostCenters_maxRecords = 1;
}

AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ds_output = new AggregateRecord<RL_ec55ed22dae89075d036f3a863173164>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.datasetGetCostCenters(requestContext,datasetGetCostCenters_maxRecords,datasetGetCostCenters_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d>(ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRolesAndMore")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRolesAndMore",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRolesAndMore(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "t1QByB8F7Ei1DwTyreXRnA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamAppRoleListText;
bool outParamIsCorporativoCxP;
bool outParamo_CanUploadInvoices;
string outParamTelcelDirectionsListText;
long outParamCorporativoRegionId;
long outParamUserRegion;
bool outParamIsActiveDEV_NewVersionScreenDownloads;
(outParamUserRolesList,outParamAppRoleListText,outParamIsCorporativoCxP,outParamo_CanUploadInvoices,outParamTelcelDirectionsListText,outParamCorporativoRegionId,outParamUserRegion,outParamIsActiveDEV_NewVersionScreenDownloads) = await model.DataActionGetUserApplicationRolesAndMore(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetUserApplicationRolesAndMore_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamAppRoleListText, outParamIsCorporativoCxP, outParamo_CanUploadInvoices, outParamTelcelDirectionsListText, outParamCorporativoRegionId, outParamUserRegion, outParamIsActiveDEV_NewVersionScreenDownloads);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetRequisitionsFull")]
[RESTScreenServicesActionProperties(Name="GetRequisitionsFull",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetRequisitionsFull(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "jehT3hUzo40RcVNSTeKXKQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_5cba7bdf2f2718a3daba441ead02b59b outParamList;
string outParamSortClause;
(outParamList,outParamSortClause) = await model.DataActionGetRequisitionsFull(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList, outParamSortClause);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetRequisitions")]
[RESTScreenServicesActionProperties(Name="GetRequisitions",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetRequisitions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "SJ6ohDw8WqLlz5yMQe5cLQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_00620735fb8e7105f7e39e5561e40930 outParamList;
int outParamTotalCount;
string outParamSortClause;
(outParamList,outParamTotalCount,outParamSortClause) = await model.DataActionGetRequisitions(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList, outParamTotalCount, outParamSortClause);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionColumnTogglerPassColumn(requestContext,inputs.inParami_ColumnJSON,inputs.inParami_TableName,inputs.inParami_UserId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionRequisitionCancel")]
[RESTScreenServicesActionProperties(Name="RequisitionCancel",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionRequisitionCancel(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "t_Cz8TUtEbxHcmD_3NS1BQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionRequisitionCancel_Model inputs = null;
Actions.lcoRequisitionCancel res =  new Actions.lcoRequisitionCancel();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionRequisitionCancel_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionRequisitionCancel(requestContext,inputs.inParami_RequisitionId,inputs.inParami_RequisitionApprovalLevelId,inputs.inParami_CancelReason,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionRequisitionCancel_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionScreenTableDownloadWbRequisitionsListInternal")]
[RESTScreenServicesActionProperties(Name="ScreenTableDownloadWbRequisitionsListInternal",Screen="Wb_RequisitionsList_Internal",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionScreenTableDownloadWbRequisitionsListInternal(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Z7ZqthqRTO4gO6E2yjKD8w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionScreenTableDownloadWbRequisitionsListInternal_Model inputs = null;
Actions.lcoScreenTableDownloadWbRequisitionsListInternal res =  new Actions.lcoScreenTableDownloadWbRequisitionsListInternal();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionScreenTableDownloadWbRequisitionsListInternal_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_File,res.outParamo_StringListIds,res.outParamo_StringListLevelIds,res.outParamo_ErrorMsg) = await Actions.ActionScreenTableDownloadWbRequisitionsListInternal(requestContext,inputs.inParami_IsCSV,inputs.inParami_IsPDF,inputs.inParami_IsXLS,inputs.inParami_RequisitionsListInternalTableListStructure,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_ActionScreenTableDownloadWbRequisitionsListInternal_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File, res.outParamo_StringListIds, res.outParamo_StringListLevelIds, res.outParamo_ErrorMsg);
return output;


    }, cancellationToken);
}
}
