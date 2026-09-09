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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/NewFolioSAE")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("j_FoliosSAE.NewFolioSAE"), ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckFoliosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotFoliosRoleException( "Folios role required");

    }


    static ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_j_FoliosSAE_NewFolioSAE_Controller(
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
[RESTScreenServicesActionProperties(Name="GetCompanies",Screen="NewFolioSAE",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCompanies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dUlLiZXilCXZfHjYY_ZYJg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGerOrderByOrderNumber")]
[RESTScreenServicesActionProperties(Name="GerOrderByOrderNumber",Screen="NewFolioSAE",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGerOrderByOrderNumber(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "NhjoafPA4q7mcxB_zjErLw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGerOrderByOrderNumber_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGerOrderByOrderNumber_maxRecords = 1;
} else {
datasetGerOrderByOrderNumber_maxRecords = inputs.MaxRecords.Value;
}

int datasetGerOrderByOrderNumber_startIndex;
if((inputs.StartIndex == null)) {
datasetGerOrderByOrderNumber_startIndex = 0;
} else {
datasetGerOrderByOrderNumber_startIndex = inputs.StartIndex.Value;
}

if((datasetGerOrderByOrderNumber_maxRecords < 1)) {
datasetGerOrderByOrderNumber_maxRecords = 1;
}

AggregateRecord<RL_67e2db3b41beb37bb78f90d8e94803d5> ds_output = new AggregateRecord<RL_67e2db3b41beb37bb78f90d8e94803d5>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel.datasetGerOrderByOrderNumber(requestContext,datasetGerOrderByOrderNumber_maxRecords,datasetGerOrderByOrderNumber_startIndex,IterationMultiplicity.Multiple,model.varLcl_OrderIdNumberSelected,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577>(ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetOrderMainItems")]
[RESTScreenServicesActionProperties(Name="GetOrderMainItems",Screen="NewFolioSAE",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrderMainItems(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nMYKJY2YKAefA8NljSFLTw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_4e1292c876d12cf32f3c04367498157e outParamList;
outParamList = await model.DataActionGetOrderMainItems(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetOrders")]
[RESTScreenServicesActionProperties(Name="GetOrders",Screen="NewFolioSAE",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrders(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nztVnJ1rATlUhtCef4c5Yg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_ba76bc23b46b20e6625cad46f2aea8e4 outParamList;
int outParamCount;
(outParamList,outParamCount) = await model.DataActionGetOrders(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList, outParamCount);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetApplicantType")]
[RESTScreenServicesActionProperties(Name="GetApplicantType",Screen="NewFolioSAE",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetApplicantType(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "PBHdt_0fOIvYzJzwvoc4tQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int outParamApprovalProcessTypeId;
long outParamApplicantId;
(outParamApprovalProcessTypeId,outParamApplicantId) = await model.DataActionGetApplicantType(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamApprovalProcessTypeId, outParamApplicantId);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="NewFolioSAE",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewFolioSAE_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
