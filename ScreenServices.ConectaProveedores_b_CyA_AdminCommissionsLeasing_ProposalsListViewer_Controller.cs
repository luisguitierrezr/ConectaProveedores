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
[Route("screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CalendarClear_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssAutoRefreshUtils.ScreenServices.AutoRefreshUtils_Widget_EventExtensibilityBlock_Controller", "AutoRefreshUtils", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("b_CyA_AdminCommissionsLeasing.ProposalsListViewer"), ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckComissionesArrendamientosViewerRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotComissionesArrendamientosViewerRoleException( "ComissionesArrendamientosViewer role required");

    }


    static ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*DownloadFileWithProposalId*/"6dONWMH_kUW9Ti9X5sMIKA*SUV+lX3IY0mgTcRKKWUDLQ", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*b_CyA_AdminCommissionsLeasing.ProposalsListViewer.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*0m3rwkRVx0abLWMQNOlcOQ", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_Controller(
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
[Route("ScreenDataSetGetCurrencies")]
[RESTScreenServicesActionProperties(Name="GetCurrencies",Screen="ProposalsListViewer",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCurrencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f+VnB3EzqSeam1tAXE44KQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.datasetGetCurrencies(requestContext,datasetGetCurrencies_maxRecords,datasetGetCurrencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetOperators")]
[RESTScreenServicesActionProperties(Name="GetOperators",Screen="ProposalsListViewer",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOperators(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "FLVfBwjABjz9rC3dLNwU+w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOperators_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOperators_maxRecords = 50;
} else {
datasetGetOperators_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOperators_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOperators_startIndex = 0;
} else {
datasetGetOperators_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOperators_maxRecords < 1)) {
datasetGetOperators_maxRecords = 1;
}

AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ds_output = new AggregateRecord<RL_f03e17396f660361b67a45f0e1101893>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.datasetGetOperators(requestContext,datasetGetOperators_maxRecords,datasetGetOperators_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965>(ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProposalStatus")]
[RESTScreenServicesActionProperties(Name="GetProposalStatus",Screen="ProposalsListViewer",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalStatus(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "fHnB7KKekLnAKr0PQushoA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalStatus_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalStatus_maxRecords = 50;
} else {
datasetGetProposalStatus_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalStatus_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalStatus_startIndex = 0;
} else {
datasetGetProposalStatus_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalStatus_maxRecords < 1)) {
datasetGetProposalStatus_maxRecords = 1;
}

AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ds_output = new AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.datasetGetProposalStatus(requestContext,datasetGetProposalStatus_maxRecords,datasetGetProposalStatus_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2>(ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetBanks")]
[RESTScreenServicesActionProperties(Name="GetBanks",Screen="ProposalsListViewer",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetBanks(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7ybLE4e_O0XTjUbXrZeJEA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetBanks_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetBanks_maxRecords = 50;
} else {
datasetGetBanks_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetBanks_startIndex;
if((inputs.StartIndex == null)) {
datasetGetBanks_startIndex = 0;
} else {
datasetGetBanks_startIndex = inputs.StartIndex.Value;
}

if((datasetGetBanks_maxRecords < 1)) {
datasetGetBanks_maxRecords = 1;
}

AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ds_output = new AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.datasetGetBanks(requestContext,datasetGetBanks_maxRecords,datasetGetBanks_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a>(ssConectaProveedores.RestRecords.RESTRC_df806ed45594b8c12dc41d845973c44a.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProposalTypes")]
[RESTScreenServicesActionProperties(Name="GetProposalTypes",Screen="ProposalsListViewer",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "qrypbYK+KS+7H1Kl+dChmQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalTypes_maxRecords = 50;
} else {
datasetGetProposalTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalTypes_startIndex = 0;
} else {
datasetGetProposalTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalTypes_maxRecords < 1)) {
datasetGetProposalTypes_maxRecords = 1;
}

AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ds_output = new AggregateRecord<RL_75c16c4807d1a3963546d53942756918>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.datasetGetProposalTypes(requestContext,datasetGetProposalTypes_maxRecords,datasetGetProposalTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef>(ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProposals")]
[RESTScreenServicesActionProperties(Name="GetProposals",Screen="ProposalsListViewer",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "yaoIQycJJBm6o8RJ79Iu6A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposals_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposals_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetProposals_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposals_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposals_startIndex = model.varLcl_StartIndex;
} else {
datasetGetProposals_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposals_maxRecords < 1)) {
datasetGetProposals_maxRecords = 1;
}

AggregateRecord<RL_8ba5b56e8055656db873b3771bf59d3c> ds_output = new AggregateRecord<RL_8ba5b56e8055656db873b3771bf59d3c>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.datasetGetProposals(requestContext,datasetGetProposals_maxRecords,datasetGetProposals_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssProposals_AmountMLFrom,model.clientVariables.ssProposals_AmountMLTo,model.clientVariables.ssProposals_Bank,model.clientVariables.ssProposals_Currency,model.clientVariables.ssProposals_PaymentDateFrom,model.clientVariables.ssProposals_PaymentDateTo,model.clientVariables.ssProposals_ProposalSearch,model.clientVariables.ssProposals_Status,model.clientVariables.ssProposals_Type,model.clientVariables.ssProposals_UploadType,BuiltInFunction.GetUserId (),model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_ce0b7a0d9784faac9b31d2f092421318>(ssConectaProveedores.RestRecords.RESTRC_ce0b7a0d9784faac9b31d2f092421318.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUploadType")]
[RESTScreenServicesActionProperties(Name="GetUploadType",Screen="ProposalsListViewer",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUploadType(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "kRch7b3NNnE8jBcf8fUWTQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_a579a1a05eaaba551100ea61f4cb3f6b outParamList;
outParamList = await model.DataActionGetUploadType(requestContext,cancellationToken);

var output = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionDownloadFileWithProposalId")]
[RESTScreenServicesActionProperties(Name="DownloadFileWithProposalId",Screen="ProposalsListViewer",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDownloadFileWithProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "orzRncjq6at+5OYp6Ib1PA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionDownloadFileWithProposalId_Model inputs = null;
Actions.lcoDownloadFileWithProposalId res =  new Actions.lcoDownloadFileWithProposalId();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionDownloadFileWithProposalId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Filename,res.outParamo_BinaryData) = await Actions.ActionDownloadFileWithProposalId(requestContext,inputs.inParami_ProposalId,cancellationToken);

var output = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionDownloadFileWithProposalId_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Filename, res.outParamo_BinaryData);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="ProposalsListViewer",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="ProposalsListViewer",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="ProposalsListViewer",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}
}
