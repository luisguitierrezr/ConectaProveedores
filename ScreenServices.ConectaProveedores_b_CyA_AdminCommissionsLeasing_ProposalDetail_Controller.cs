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
[Route("screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_ColumnsSmallRight_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_TimelineStatus_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Sidebar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("b_CyA_AdminCommissionsLeasing.ProposalDetail"), ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller.CheckPermissionsAsync);
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
{
bool check;
check = await ExtendedActions.CheckComissionesArrendamientosAdminRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotComissionesArrendamientosAdminRoleException( "ComissionesArrendamientosAdmin role required");

    }


    static ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*b_CyA_AdminCommissionsLeasing.ProposalDetail.ShowHideCancelPopup*/"6dONWMH_kUW9Ti9X5sMIKA*tubDAtXeYk+5Y08vTGmnPQ", 
/*OutSystemsUI.SidebarOpen*/"Kn_hixxDWEm4lMd7mIpycQ*PN7rZt6KuU6Ljraavd2k6g", 
/*b_CyA_AdminCommissionsLeasing.ProposalDetail.ShowHideUnpaidPopup*/"6dONWMH_kUW9Ti9X5sMIKA*bqIqJR_MZkeYv0QiHh38ow", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*OutSystemsUI.SidebarClose*/"Kn_hixxDWEm4lMd7mIpycQ*3R4D2mxED0erTuoiqqO3EA", 
/*System_.ListSort*/"uXCIR2Atc0+es3zYuZSnNw*0Erbx8xR5USqNlBUb6zjiA", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*UndoReject*/"6dONWMH_kUW9Ti9X5sMIKA*1vQ8gp1VF0itXiDF3ecS5Q", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*DownloadFileWithProposalId*/"6dONWMH_kUW9Ti9X5sMIKA*SUV+lX3IY0mgTcRKKWUDLQ", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_Controller(
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
[Route("ScreenDataSetGetProposalById")]
[RESTScreenServicesActionProperties(Name="GetProposalById",Screen="ProposalDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Dno0SXwM7txWV1bQi9NwMQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalById_maxRecords = 1;
} else {
datasetGetProposalById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalById_startIndex = 0;
} else {
datasetGetProposalById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalById_maxRecords < 1)) {
datasetGetProposalById_maxRecords = 1;
}

AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ds_output = new AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckComissionesArrendamientosViewerRole(requestContext,"",cancellationToken)),(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.inParami_ProposalId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d>(ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProposalStatuses")]
[RESTScreenServicesActionProperties(Name="GetProposalStatuses",Screen="ProposalDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "h+LMXx9T8tdR9KmahOZB3Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalStatuses_maxRecords = 50;
} else {
datasetGetProposalStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalStatuses_startIndex = 0;
} else {
datasetGetProposalStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalStatuses_maxRecords < 1)) {
datasetGetProposalStatuses_maxRecords = 1;
}

AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ds_output = new AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.datasetGetProposalStatuses(requestContext,datasetGetProposalStatuses_maxRecords,datasetGetProposalStatuses_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetProposalById.List.CurrentRec.ssENProposalStatus.ssId,cancellationToken);

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
[Route("ScreenDataSetGetProposalApprovalLevels")]
[RESTScreenServicesActionProperties(Name="GetProposalApprovalLevels",Screen="ProposalDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalApprovalLevels(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KLrFdmWdGnl7pNfZ3U0xWA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalApprovalLevels_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalApprovalLevels_maxRecords = 50;
} else {
datasetGetProposalApprovalLevels_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalApprovalLevels_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalApprovalLevels_startIndex = 0;
} else {
datasetGetProposalApprovalLevels_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalApprovalLevels_maxRecords < 1)) {
datasetGetProposalApprovalLevels_maxRecords = 1;
}

AggregateRecord<RL_5c3f0f159a56c705e2e8b813bae3e604> ds_output = new AggregateRecord<RL_5c3f0f159a56c705e2e8b813bae3e604>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.datasetGetProposalApprovalLevels(requestContext,datasetGetProposalApprovalLevels_maxRecords,datasetGetProposalApprovalLevels_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ProposalId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f>(ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProposalLinesByProposalId")]
[RESTScreenServicesActionProperties(Name="GetProposalLinesByProposalId",Screen="ProposalDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalLinesByProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "87CeoiH8hRlNZ9uOX8XUjQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalLinesByProposalId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalLinesByProposalId_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetProposalLinesByProposalId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalLinesByProposalId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalLinesByProposalId_startIndex = model.varLcl_StartIndex;
} else {
datasetGetProposalLinesByProposalId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalLinesByProposalId_maxRecords < 1)) {
datasetGetProposalLinesByProposalId_maxRecords = 1;
}

AggregateRecord<RL_fdf11fa7a74406ff2a80f555d1ce34a5> ds_output = new AggregateRecord<RL_fdf11fa7a74406ff2a80f555d1ce34a5>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel.datasetGetProposalLinesByProposalId(requestContext,datasetGetProposalLinesByProposalId_maxRecords,datasetGetProposalLinesByProposalId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.ScreenDataSetGetProposalById.List.CurrentRec.ssENProposal.ssProposalStatusId,model.inParami_ProposalId,model.varLcl_ProposalApprovalLevelId,model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56>(ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionUndoReject")]
[RESTScreenServicesActionProperties(Name="UndoReject",Screen="ProposalDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUndoReject(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "yhzyg0BG5bRlpiWmv9lZyw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Model inputs = null;
Actions.lcoUndoReject res =  new Actions.lcoUndoReject();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_HasProposalChangedStatus = await Actions.ActionUndoReject(requestContext,inputs.inParami_ProposalId,inputs.inParami_ProposalLineApprovalLevelId,cancellationToken);

var output = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionUndoReject_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_HasProposalChangedStatus);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="ProposalDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="ProposalDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionDownloadFileWithProposalId")]
[RESTScreenServicesActionProperties(Name="DownloadFileWithProposalId",Screen="ProposalDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDownloadFileWithProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "orzRncjq6at+5OYp6Ib1PA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionDownloadFileWithProposalId_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionDownloadFileWithProposalId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Filename,res.outParamo_BinaryData) = await Actions.ActionDownloadFileWithProposalId(requestContext,inputs.inParami_ProposalId,cancellationToken);

var output = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionDownloadFileWithProposalId_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Filename, res.outParamo_BinaryData);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="ProposalDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}
}
