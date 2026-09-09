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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CalendarClear_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Notification_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("j_FoliosSAE.FoliosContabilizationSAPStatus"), ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller.CheckPermissionsAsync);
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
{
bool check;
check = await ExtendedActions.CheckPedidosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotPedidosRoleException( "Pedidos role required");

    }


    static ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.NotificationClose*/"Kn_hixxDWEm4lMd7mIpycQ*EqGGkzcn4EaYWWRgDiKrWg", 
/*Text.String_Join*/"d6CatvSs3Eu81Z3vgdfdzQ*mol2uGeor_qpVukfV87+Ng", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*System_.ListAny*/"uXCIR2Atc0+es3zYuZSnNw*qehi1YDm00iCdB5+VDfk+A", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*OutSystemsUI.NotificationOpen*/"Kn_hixxDWEm4lMd7mIpycQ*JNl7H0r9N0SbGP7u8NUGKw", 
/*j_FoliosSAE.FoliosContabilizationSAPStatus.ResetFilters*/"6dONWMH_kUW9Ti9X5sMIKA*aarfVwFVcUi60ulPEa1o0A", 
/*j_FoliosSAE.FoliosContabilizationSAPStatus.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*bIpFXtLcYUirvltiPKCHIw", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*GenerateReportSAPStatus*/"6dONWMH_kUW9Ti9X5sMIKA*It0pa9wDg0ijZA_KvYp05A", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*j_FoliosSAE.FoliosContabilizationSAPStatus.CheckAnyBulkApprovable*/"6dONWMH_kUW9Ti9X5sMIKA*osnSo9yiD06xvhfvh3n5rw", 
/*OutSystemsUI.DatePickerOpen*/"Kn_hixxDWEm4lMd7mIpycQ*cF6Lvs8h40Gf0c9ID_IYzg", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*InvoiceAccountingProcess_Create*/"6dONWMH_kUW9Ti9X5sMIKA*ZywL5PaNl0GlFFrAnjaDUg", 
/*j_FoliosSAE.FoliosContabilizationSAPStatus.GetTotals*/"6dONWMH_kUW9Ti9X5sMIKA*OO+87eeSJ06TjF7Q+EKIog", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_Controller(
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
[Route("ScreenDataSetGetSpecialApprovals")]
[RESTScreenServicesActionProperties(Name="GetSpecialApprovals",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSpecialApprovals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "vnJOYyFcujOLSxybVuL+qg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSpecialApprovals_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSpecialApprovals_maxRecords = 50;
} else {
datasetGetSpecialApprovals_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSpecialApprovals_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSpecialApprovals_startIndex = 0;
} else {
datasetGetSpecialApprovals_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSpecialApprovals_maxRecords < 1)) {
datasetGetSpecialApprovals_maxRecords = 1;
}

AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ds_output = new AggregateRecord<RL_0204de281fa136fb826199f876159fe4>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.datasetGetSpecialApprovals(requestContext,datasetGetSpecialApprovals_maxRecords,datasetGetSpecialApprovals_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5>(ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCurrencies")]
[RESTScreenServicesActionProperties(Name="GetCurrencies",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCurrencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f+VnB3EzqSeam1tAXE44KQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCurrencies_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCurrencies_maxRecords = 99999;
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.datasetGetCurrencies(requestContext,datasetGetCurrencies_maxRecords,datasetGetCurrencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetInvoicesSAP")]
[RESTScreenServicesActionProperties(Name="GetInvoicesSAP",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoicesSAP(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wb+YTFyqdZ1ldaUVlM0KPA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoicesSAP_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoicesSAP_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetInvoicesSAP_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoicesSAP_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoicesSAP_startIndex = model.varLcl_StartIndex;
} else {
datasetGetInvoicesSAP_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoicesSAP_maxRecords < 1)) {
datasetGetInvoicesSAP_maxRecords = 1;
}

AggregateRecord<RL_036b78d631cef153f668611e54d43e5d> ds_output = new AggregateRecord<RL_036b78d631cef153f668611e54d43e5d>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.datasetGetInvoicesSAP(requestContext,datasetGetInvoicesSAP_maxRecords,datasetGetInvoicesSAP_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssFolioContabilization_Filters_AccountingTypeId,model.clientVariables.ssFolioContabilization_Filters_AmountFrom,model.clientVariables.ssFolioContabilization_Filters_AmountTo,model.clientVariables.ssFolioContabilization_Filters_AssignedTo,model.clientVariables.ssFolioContabilization_Filters_BusinessValueCategory,model.clientVariables.ssFolioContabilization_Filters_BusinessValueSubCateg,model.clientVariables.ssFolioContabilization_Filters_CurrencyId,model.clientVariables.ssFolioContabilization_Filters_FolioCreatedOn,model.clientVariables.ssFolioContabilization_Filters_FolioNumber,model.clientVariables.ssFolioContabilization_Filters_FrequencyId,model.clientVariables.ssFolioContabilization_Filters_InvoiceCreatedOn,model.clientVariables.ssFolioContabilization_Filters_InvoiceName,model.clientVariables.ssFolioContabilization_Filters_InvoiceStatusId,model.clientVariables.ssFolioContabilization_Filters_OrderMainNumber,model.clientVariables.ssFolioContabilization_Filters_PaidOn,model.clientVariables.ssFolioContabilization_Filters_Period,model.clientVariables.ssFolioContabilization_Filters_Project,model.clientVariables.ssFolioContabilization_Filters_SpecialApprovalId,model.clientVariables.ssFolioContabilization_Filters_SupplierId,model.clientVariables.ssOffsetUtc,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d920d0aa189b36e12964653ae47b2e42>(ssConectaProveedores.RestRecords.RESTRC_d920d0aa189b36e12964653ae47b2e42.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFrequencies")]
[RESTScreenServicesActionProperties(Name="GetFrequencies",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFrequencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "AzjepyCQFApZH_95qbpcQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFrequencies_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFrequencies_maxRecords = 99999;
} else {
datasetGetFrequencies_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFrequencies_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFrequencies_startIndex = 0;
} else {
datasetGetFrequencies_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFrequencies_maxRecords < 1)) {
datasetGetFrequencies_maxRecords = 1;
}

AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ds_output = new AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.datasetGetFrequencies(requestContext,datasetGetFrequencies_maxRecords,datasetGetFrequencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf>(ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceStatus")]
[RESTScreenServicesActionProperties(Name="GetInvoiceStatus",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceStatus(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Fh6rbTuJ7IV8cHXu_VYJ2g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceStatus_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceStatus_maxRecords = 50;
} else {
datasetGetInvoiceStatus_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceStatus_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceStatus_startIndex = 0;
} else {
datasetGetInvoiceStatus_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceStatus_maxRecords < 1)) {
datasetGetInvoiceStatus_maxRecords = 1;
}

AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> ds_output = new AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.datasetGetInvoiceStatus(requestContext,datasetGetInvoiceStatus_maxRecords,datasetGetInvoiceStatus_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetAccountingDataTypes")]
[RESTScreenServicesActionProperties(Name="GetAccountingDataTypes",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAccountingDataTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "GSdIV_2QnHAjbJAYrKgrwA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAccountingDataTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAccountingDataTypes_maxRecords = 99999;
} else {
datasetGetAccountingDataTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetAccountingDataTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetAccountingDataTypes_startIndex = 0;
} else {
datasetGetAccountingDataTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetAccountingDataTypes_maxRecords < 1)) {
datasetGetAccountingDataTypes_maxRecords = 1;
}

AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ds_output = new AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel.datasetGetAccountingDataTypes(requestContext,datasetGetAccountingDataTypes_maxRecords,datasetGetAccountingDataTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c>(ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionColumnTogglerPassColumn(requestContext,inputs.inParami_ColumnJSON,inputs.inParami_TableName,inputs.inParami_UserId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionInvoiceAccountingProcess_Create")]
[RESTScreenServicesActionProperties(Name="InvoiceAccountingProcess_Create",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionInvoiceAccountingProcess_Create(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7ta6duQcTOb1HdUse50VXA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionInvoiceAccountingProcess_Create(requestContext,inputs.inParamInvoiceId,inputs.inParamComment,inputs.inParamIsFCP,inputs.inParamRequisitionId,inputs.inParamOffsetUtc,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGenerateReportSAPStatus")]
[RESTScreenServicesActionProperties(Name="GenerateReportSAPStatus",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGenerateReportSAPStatus(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+ea7XwZE17dLs2LVJTe93g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Model inputs = null;
Actions.lcoGenerateReportSAPStatus res =  new Actions.lcoGenerateReportSAPStatus();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamFile = await Actions.ActionGenerateReportSAPStatus(requestContext,inputs.inParami_OffsetUtc,inputs.inParami_SupplierId,inputs.inParami_InvoiceName,inputs.inParami_FolioNumber,inputs.inParami_InvoiceStatusId,inputs.inParami_OrderMainNumber,inputs.inParami_AssignedTo,inputs.inParami_Project,inputs.inParami_Period,inputs.inParami_FrequencyId,inputs.inParami_BusinessValueCategory,inputs.inParami_BusinessValueSubCateg,inputs.inParami_PaidOn,inputs.inParami_AmountFrom,inputs.inParami_AmountTo,inputs.inParami_CurrencyId,inputs.inParami_InvoiceCreatedOn,inputs.inParami_FolioCreatedOn,inputs.inParami_SpecialApprovalId,inputs.inParami_CFDITypeId,inputs.inParami_IsSelectAll,inputs.inParami_SelectedIds,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamFile);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionString_Join")]
[RESTScreenServicesActionProperties(Name="String_Join",Screen="FoliosContabilizationSAPStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionString_Join(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "lNvoEPPn2Douj1QaJi3ZCA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Model inputs = null;
string res_outParamText = "";
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamText = await Actions.ActionString_Join(requestContext,inputs.inParamList,inputs.inParamSeparator,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamText);
return output;


    }, cancellationToken);
}
}
