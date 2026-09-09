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
[Route("screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Sidebar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury"), ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckTesoreriaRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotTesoreriaRoleException( "Tesoreria role required");

    }


    static ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.SidebarOpen*/"Kn_hixxDWEm4lMd7mIpycQ*PN7rZt6KuU6Ljraavd2k6g", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.ShowHideUnpaidPopup*/"6dONWMH_kUW9Ti9X5sMIKA*Uh5fLA5skU2itkjJuRu+gA", 
/*PayMultipleProposalLine*/"6dONWMH_kUW9Ti9X5sMIKA*zlMmP7FmEEuo12KGgM3kHg", 
/*OutSystemsUI.SidebarClose*/"Kn_hixxDWEm4lMd7mIpycQ*3R4D2mxED0erTuoiqqO3EA", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*ClaimProposalTreasury*/"6dONWMH_kUW9Ti9X5sMIKA*CckRZUMoL0CZ2wtOEqcEAw", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*PayUnpaySingleProposalLine*/"6dONWMH_kUW9Ti9X5sMIKA*LnXFhCXlHkmYDokV0jzIwA", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*DownloadFileWithProposalId*/"6dONWMH_kUW9Ti9X5sMIKA*SUV+lX3IY0mgTcRKKWUDLQ", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.ShowHideUnpayPaymentPopup*/"6dONWMH_kUW9Ti9X5sMIKA*0VPR7NlMv0abQNCnmWLL0w", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_Controller(
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
[Route("ScreenDataSetGetApprovalStatuses")]
[RESTScreenServicesActionProperties(Name="GetApprovalStatuses",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "SOfFGGF3iufQOk4hAyThKw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel.datasetGetApprovalStatuses(requestContext,datasetGetApprovalStatuses_maxRecords,datasetGetApprovalStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetProposalLinesByProposalId")]
[RESTScreenServicesActionProperties(Name="GetProposalLinesByProposalId",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalLinesByProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "o5BbsSc7WXgh_lqLaAJ3_w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
datasetGetProposalLinesByProposalId_startIndex = model.varLcStartIndex;
} else {
datasetGetProposalLinesByProposalId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalLinesByProposalId_maxRecords < 1)) {
datasetGetProposalLinesByProposalId_maxRecords = 1;
}

AggregateRecord<RL_db80b9f839f0b93373297ec2051fc003> ds_output = new AggregateRecord<RL_db80b9f839f0b93373297ec2051fc003>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel.datasetGetProposalLinesByProposalId(requestContext,datasetGetProposalLinesByProposalId_maxRecords,datasetGetProposalLinesByProposalId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ProposalId,model.varLcl_PaymentStatus,model.varLcTableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6>(ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProposalById")]
[RESTScreenServicesActionProperties(Name="GetProposalById",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "W2z1emK4zPon+dOcI9RdSw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ProposalId,cancellationToken);

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
[Route("ActionDownloadFileWithProposalId")]
[RESTScreenServicesActionProperties(Name="DownloadFileWithProposalId",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDownloadFileWithProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "orzRncjq6at+5OYp6Ib1PA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionDownloadFileWithProposalId_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionDownloadFileWithProposalId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Filename,res.outParamo_BinaryData) = await Actions.ActionDownloadFileWithProposalId(requestContext,inputs.inParami_ProposalId,cancellationToken);

var output = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionDownloadFileWithProposalId_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Filename, res.outParamo_BinaryData);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionPayMultipleProposalLine")]
[RESTScreenServicesActionProperties(Name="PayMultipleProposalLine",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionPayMultipleProposalLine(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "TI7cuKtSxBcQXdsgwIjhaw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayMultipleProposalLine_Model inputs = null;
Actions.lcoPayMultipleProposalLine res =  new Actions.lcoPayMultipleProposalLine();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayMultipleProposalLine_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_HasProposalChangedStatus = await Actions.ActionPayMultipleProposalLine(requestContext,inputs.inParami_ProposalLinelIdList,cancellationToken);

var output = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayMultipleProposalLine_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_HasProposalChangedStatus);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionPayUnpaySingleProposalLine")]
[RESTScreenServicesActionProperties(Name="PayUnpaySingleProposalLine",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionPayUnpaySingleProposalLine(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "NUg35lY6yeqQ7J6gbZnlBg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Model inputs = null;
Actions.lcoPayUnpaySingleProposalLine res =  new Actions.lcoPayUnpaySingleProposalLine();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_HasProposalChangedStatus,res.outParamo_Output) = await Actions.ActionPayUnpaySingleProposalLine(requestContext,inputs.inParami_ProposalLineId,inputs.inParami_IsPay,inputs.inParami_Comment,inputs.inParami_Binary,inputs.inParami_Filename,cancellationToken);

var output = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionPayUnpaySingleProposalLine_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_HasProposalChangedStatus, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionClaimProposalTreasury")]
[RESTScreenServicesActionProperties(Name="ClaimProposalTreasury",Screen="ProposalDetailTreasury",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionClaimProposalTreasury(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "DsiygcVP6w+YIuPZ+KtsGA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Model inputs = null;
Actions.lcoClaimProposalTreasury res =  new Actions.lcoClaimProposalTreasury();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_IsSuccess = await Actions.ActionClaimProposalTreasury(requestContext,inputs.inParami_ProposalId,inputs.inParami_UserId,cancellationToken);

var output = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ActionClaimProposalTreasury_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_IsSuccess);
return output;


    }, cancellationToken);
}
}
