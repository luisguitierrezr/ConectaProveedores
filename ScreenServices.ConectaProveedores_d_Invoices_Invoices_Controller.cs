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
[Route("screenservices/ConectaProveedores/d_Invoices/Invoices")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Invoices_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Invoices_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Invoices_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Invoices_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Invoices_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Invoices_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierNameWithRFC_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssExpandableTableRow.ScreenServices.ExpandableTableRow_UIFlow_ExpandableTableRow_Controller", "ExpandableTableRow", childControllers);
SafeAddChildController(ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkCancel_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkApprove_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_PopupApprove_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkComment_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_z_TableDownloadsPDF_Wb_DownloadsFloat_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Notification_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("d_Invoices.Invoices"), ConectaProveedores_d_Invoices_Invoices_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckRequisicionesRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotRequisicionesRoleException( "Requisiciones role required");

    }


    static ConectaProveedores_d_Invoices_Invoices_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ApprovModifInv*/"6dONWMH_kUW9Ti9X5sMIKA*heTUNyFw0kqo9AMFrmGymg", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*OutSystemsUI.NotificationOpen*/"Kn_hixxDWEm4lMd7mIpycQ*JNl7H0r9N0SbGP7u8NUGKw", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*d_Invoices.Invoices.ResetFilters*/"6dONWMH_kUW9Ti9X5sMIKA*rtIXdu5TuEaMhP47uxB5Cg", 
/*ScreenTableDownloadInvoiceScreen*/"6dONWMH_kUW9Ti9X5sMIKA*C1KvgiF7p0+wSf2uaNzLEA", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*d_Invoices.Invoices.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*BwLh9fO6Wke5BDYDkepdcw", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_d_Invoices_Invoices_Controller(
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
[Route("ScreenDataSetGetInvoices")]
[RESTScreenServicesActionProperties(Name="GetInvoices",Screen="Invoices",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "NgXFwJZS4b6jnn+qF0GnoA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
datasetGetInvoices_startIndex = model.varLcl_StartIndex;
} else {
datasetGetInvoices_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoices_maxRecords < 1)) {
datasetGetInvoices_maxRecords = 1;
}

AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ds_output = new AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Invoices_ScreenModel.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssInvoice_ApprovalStatusId,model.clientVariables.ssInvoice_CompanyId,model.clientVariables.ssInvoice_InvoiceName,model.clientVariables.ssInvoice_ProjectId,model.clientVariables.ssInvoice_RequisitionName,model.clientVariables.ssInvoice_SupplierId,model.clientVariables.ssInvoice_UploadDateFrom,model.clientVariables.ssInvoice_UploadDateTo,model.clientVariables.ssOffsetUtc,model.varLcGetUserApplicationRolesAndMore.outParamAppRolesListText,model.varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,model.varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,model.varLcGetUserApplicationRolesAndMore.outParamUserRegion,BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcl_TableSort,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469>(ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetApprovalStatuses")]
[RESTScreenServicesActionProperties(Name="GetApprovalStatuses",Screen="Invoices",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "SOfFGGF3iufQOk4hAyThKw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Invoices_ScreenModel.datasetGetApprovalStatuses(requestContext,datasetGetApprovalStatuses_maxRecords,datasetGetApprovalStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetProjectAssetServices")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetServices",Screen="Invoices",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetServices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "QmIftqTsNkC++1frUcNFQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProjectAssetServices_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProjectAssetServices_maxRecords = 99999;
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
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Invoices_ScreenModel.datasetGetProjectAssetServices(requestContext,datasetGetProjectAssetServices_maxRecords,datasetGetProjectAssetServices_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetInvoicesFull")]
[RESTScreenServicesActionProperties(Name="GetInvoicesFull",Screen="Invoices",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoicesFull(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "P0otaSD7FShPJJx0NwiiNw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoicesFull_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoicesFull_maxRecords = 999999999;
} else {
datasetGetInvoicesFull_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoicesFull_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoicesFull_startIndex = 0;
} else {
datasetGetInvoicesFull_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoicesFull_maxRecords < 1)) {
datasetGetInvoicesFull_maxRecords = 1;
}

AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ds_output = new AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Invoices_ScreenModel.datasetGetInvoicesFull(requestContext,datasetGetInvoicesFull_maxRecords,datasetGetInvoicesFull_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssInvoice_ApprovalStatusId,model.clientVariables.ssInvoice_CompanyId,model.clientVariables.ssInvoice_InvoiceName,model.clientVariables.ssInvoice_ProjectId,model.clientVariables.ssInvoice_RequisitionName,model.clientVariables.ssInvoice_SupplierId,model.clientVariables.ssInvoice_UploadDateFrom,model.clientVariables.ssInvoice_UploadDateTo,model.clientVariables.ssOffsetUtc,model.varLcGetUserApplicationRolesAndMore.outParamAppRolesListText,model.varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,model.varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,model.varLcGetUserApplicationRolesAndMore.outParamUserRegion,BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcl_TableSort,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469>(ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetEntraRole")]
[RESTScreenServicesActionProperties(Name="GetEntraRole",Screen="Invoices",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetEntraRole(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7qyGTC_5OnA_VV8+D1QF6g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Invoices_ScreenModel.datasetGetEntraRole(requestContext,datasetGetEntraRole_maxRecords,datasetGetEntraRole_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

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
[Route("ScreenDataSetGetCompanies")]
[RESTScreenServicesActionProperties(Name="GetCompanies",Screen="Invoices",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCompanies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dUlLiZXilCXZfHjYY_ZYJg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Invoices_ScreenModel.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("DataActionGetInvoiceCountToAssign")]
[RESTScreenServicesActionProperties(Name="GetInvoiceCountToAssign",Screen="Invoices",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetInvoiceCountToAssign(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "rbFeSEFFBjUoT2kUgut5mA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsShowInfoMsg;
outParamIsShowInfoMsg = await model.DataActionGetInvoiceCountToAssign(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Invoices_DataActionGetInvoiceCountToAssign_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsShowInfoMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRolesAndMore")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRolesAndMore",Screen="Invoices",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRolesAndMore(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "uGs6UYA2x3hwvJTZO3la7g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Invoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
bool outParamIsCorporativoCxP;
string outParamAppRolesListText;
string outParamTelcelDirectionsListText;
bool outParamIsSupervisor;
bool outParamIsAnalistaCxP;
bool outParamIsJefeCxP;
long outParamCorporativoRegionId;
string outParamTelcelDirectionsListTextForQuery;
long outParamUserRegion;
bool outParamIsActiveDEV_NewVersionScreenDownloads;
(outParamUserRolesList,outParamIsCorporativoCxP,outParamAppRolesListText,outParamTelcelDirectionsListText,outParamIsSupervisor,outParamIsAnalistaCxP,outParamIsJefeCxP,outParamCorporativoRegionId,outParamTelcelDirectionsListTextForQuery,outParamUserRegion,outParamIsActiveDEV_NewVersionScreenDownloads) = await model.DataActionGetUserApplicationRolesAndMore(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Invoices_DataActionGetUserApplicationRolesAndMore_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamIsCorporativoCxP, outParamAppRolesListText, outParamTelcelDirectionsListText, outParamIsSupervisor, outParamIsAnalistaCxP, outParamIsJefeCxP, outParamCorporativoRegionId, outParamTelcelDirectionsListTextForQuery, outParamUserRegion, outParamIsActiveDEV_NewVersionScreenDownloads);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionScreenTableDownloadInvoiceScreen")]
[RESTScreenServicesActionProperties(Name="ScreenTableDownloadInvoiceScreen",Screen="Invoices",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionScreenTableDownloadInvoiceScreen(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "DpRGvDMJvL69zi+8w_DTrQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Model inputs = null;
Actions.lcoScreenTableDownloadInvoiceScreen res =  new Actions.lcoScreenTableDownloadInvoiceScreen();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_File,res.outParamo_StringListIds,res.outParamo_StringListLevelIds,res.outParamo_ErrorMsg) = await Actions.ActionScreenTableDownloadInvoiceScreen(requestContext,inputs.inParami_IsCSV,inputs.inParami_IsPDF,inputs.inParami_IsXLS,inputs.inParami_InvoicesScreenTableStructure,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File, res.outParamo_StringListIds, res.outParamo_StringListLevelIds, res.outParamo_ErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionApprovModifInv")]
[RESTScreenServicesActionProperties(Name="ApprovModifInv",Screen="Invoices",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApprovModifInv(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "hgVLsCjSSwJ57Oio+PKM9g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Model inputs = null;
Actions.lcoApprovModifInv res =  new Actions.lcoApprovModifInv();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Output,res.outParamIsFinish) = await Actions.ActionApprovModifInv(requestContext,inputs.inParami_InvoiceId,inputs.inParami_InvoiceApprovalLevelId,inputs.inParami_IsApprove,inputs.inParami_Comment,inputs.inParamOffsetUtc,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Invoices_ActionApprovModifInv_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output, res.outParamIsFinish);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="Invoices",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_d_Invoices_Invoices_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Invoices_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="Invoices",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_d_Invoices_Invoices_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionColumnTogglerPassColumn(requestContext,inputs.inParami_ColumnJSON,inputs.inParami_TableName,inputs.inParami_UserId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="Invoices",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Invoices_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_d_Invoices_Invoices_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
