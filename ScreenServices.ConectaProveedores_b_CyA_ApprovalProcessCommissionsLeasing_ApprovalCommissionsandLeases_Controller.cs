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
[Route("screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController(ConectaProveedores_y_Utils_Wb_Sum_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Search_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CalendarClear_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_RejectApprovalPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Sidebar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases"), ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckComissionesArrendamientosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotComissionesArrendamientosRoleException( "ComissionesArrendamientos role required");

    }


    static ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.SidebarOpen*/"Kn_hixxDWEm4lMd7mIpycQ*PN7rZt6KuU6Ljraavd2k6g", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*OutSystemsUI.SidebarClose*/"Kn_hixxDWEm4lMd7mIpycQ*3R4D2mxED0erTuoiqqO3EA", 
/*b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*KXXBQSFuE0OjR8f88azi6g", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*ApproveRejectSingleProposalLineApprovalLevel*/"6dONWMH_kUW9Ti9X5sMIKA*1SLTyyQLkE66qvNQs6td3g", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*ApproveMultipleProposalLineApprovalLevel*/"6dONWMH_kUW9Ti9X5sMIKA*tcg+6fNALEKhEmbB+2q6Rw", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_Controller(
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
[Route("ScreenDataSetGetProposalLines")]
[RESTScreenServicesActionProperties(Name="GetProposalLines",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalLines(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "_I_MxuZmwY8LvMO+T53C6A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalLines_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalLines_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetProposalLines_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalLines_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalLines_startIndex = model.varLcl_StartIndex;
} else {
datasetGetProposalLines_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalLines_maxRecords < 1)) {
datasetGetProposalLines_maxRecords = 1;
}

AggregateRecord<RL_529b8c0e645b1a53088b78c48fb2a9be> ds_output = new AggregateRecord<RL_529b8c0e645b1a53088b78c48fb2a9be>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.datasetGetProposalLines(requestContext,datasetGetProposalLines_maxRecords,datasetGetProposalLines_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssCommision_Leases_AmountMLFrom,model.clientVariables.ssCommision_Leases_AmountMLTo,model.clientVariables.ssCommision_Leases_ApprovalStatusId,model.clientVariables.ssCommision_Leases_AssignedTo,model.clientVariables.ssCommision_Leases_BankId,model.clientVariables.ssCommision_Leases_CompanyId,model.clientVariables.ssCommision_Leases_PaymentDate,model.clientVariables.ssCommision_Leases_ProposalSearch,model.clientVariables.ssCommision_Leases_RegionId,model.clientVariables.ssCommision_Leases_SupplierId,model.clientVariables.ssCommision_Leases_TypeId,model.clientVariables.ssCommision_Leases_UploadDate,model.clientVariables.ssOffsetUtc,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcl_ApplicationRoleIdForAggregate,model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_406ede22ed9cba3b6b03435d73fe20b6>(ssConectaProveedores.RestRecords.RESTRC_406ede22ed9cba3b6b03435d73fe20b6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOperators")]
[RESTScreenServicesActionProperties(Name="GetOperators",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOperators(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "FLVfBwjABjz9rC3dLNwU+w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.datasetGetOperators(requestContext,datasetGetOperators_maxRecords,datasetGetOperators_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGetBanks")]
[RESTScreenServicesActionProperties(Name="GetBanks",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetBanks(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7ybLE4e_O0XTjUbXrZeJEA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.datasetGetBanks(requestContext,datasetGetBanks_maxRecords,datasetGetBanks_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGetProposalLinesSum")]
[RESTScreenServicesActionProperties(Name="GetProposalLinesSum",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalLinesSum(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "fIz18otbbTNDZDakOkLJ1A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalLinesSum_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalLinesSum_maxRecords = 1;
} else {
datasetGetProposalLinesSum_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalLinesSum_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalLinesSum_startIndex = 0;
} else {
datasetGetProposalLinesSum_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalLinesSum_maxRecords < 1)) {
datasetGetProposalLinesSum_maxRecords = 1;
}

AggregateRecord<RL_8af3ce06aba4cbfdf62ee5d0bb265fe6> ds_output = new AggregateRecord<RL_8af3ce06aba4cbfdf62ee5d0bb265fe6>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.datasetGetProposalLinesSum(requestContext,datasetGetProposalLinesSum_maxRecords,datasetGetProposalLinesSum_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssCommision_Leases_AmountMLFrom,model.clientVariables.ssCommision_Leases_AmountMLTo,model.clientVariables.ssCommision_Leases_ApprovalStatusId,model.clientVariables.ssCommision_Leases_AssignedTo,model.clientVariables.ssCommision_Leases_BankId,model.clientVariables.ssCommision_Leases_CompanyId,model.clientVariables.ssCommision_Leases_PaymentDate,model.clientVariables.ssCommision_Leases_ProposalSearch,model.clientVariables.ssCommision_Leases_RegionId,model.clientVariables.ssCommision_Leases_SupplierId,model.clientVariables.ssCommision_Leases_TypeId,model.clientVariables.ssCommision_Leases_UploadDate,model.clientVariables.ssOffsetUtc,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcl_ApplicationRoleIdForAggregate,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b>(ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProposalType")]
[RESTScreenServicesActionProperties(Name="GetProposalType",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalType(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "LLI8FEO94RAUN2o6yCTqqg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalType_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalType_maxRecords = 50;
} else {
datasetGetProposalType_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalType_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalType_startIndex = 0;
} else {
datasetGetProposalType_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalType_maxRecords < 1)) {
datasetGetProposalType_maxRecords = 1;
}

AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ds_output = new AggregateRecord<RL_75c16c4807d1a3963546d53942756918>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.datasetGetProposalType(requestContext,datasetGetProposalType_maxRecords,datasetGetProposalType_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGetCompanies")]
[RESTScreenServicesActionProperties(Name="GetCompanies",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCompanies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dUlLiZXilCXZfHjYY_ZYJg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[RESTScreenServicesActionProperties(Name="GetApprovalStatuses",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "g+CnQprbRRjyfmXNHj7_5Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.datasetGetApprovalStatuses(requestContext,datasetGetApprovalStatuses_maxRecords,datasetGetApprovalStatuses_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KJN0iiF+6VDNj5WLLyNy+Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_da93b3cf8542f5b831efc106e94ee7e2 outParamUserRolesList;
outParamUserRolesList = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionApproveRejectSingleProposalLineApprovalLevel")]
[RESTScreenServicesActionProperties(Name="ApproveRejectSingleProposalLineApprovalLevel",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApproveRejectSingleProposalLineApprovalLevel(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "oV5RW64HGgfchjl2JqmJ0Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionApproveRejectSingleProposalLineApprovalLevel_Model inputs = null;
Actions.lcoApproveRejectSingleProposalLineApprovalLevel res =  new Actions.lcoApproveRejectSingleProposalLineApprovalLevel();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionApproveRejectSingleProposalLineApprovalLevel_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionApproveRejectSingleProposalLineApprovalLevel(requestContext,inputs.inParami_ProposalId,inputs.inParami_ProposalLineApprovalLevelId,inputs.inParami_IsReject,inputs.inParami_Comment,cancellationToken);

var output = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionApproveRejectSingleProposalLineApprovalLevel_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionApproveMultipleProposalLineApprovalLevel")]
[RESTScreenServicesActionProperties(Name="ApproveMultipleProposalLineApprovalLevel",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApproveMultipleProposalLineApprovalLevel(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "WvM+wke2_eYgXC0TSkx0uQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionApproveMultipleProposalLineApprovalLevel_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionApproveMultipleProposalLineApprovalLevel_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionApproveMultipleProposalLineApprovalLevel(requestContext,inputs.inParami_ProposalLineApprovalLevelIdList,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="ApprovalCommissionsandLeases",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
