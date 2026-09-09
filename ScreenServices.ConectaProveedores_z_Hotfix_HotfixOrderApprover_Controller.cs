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
[Route("screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Theme_Layouts_Layout_Top_Menu_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssDebounce.ScreenServices.Debounce_DebounceFlow_Debounce_Controller", "Debounce", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("z_Hotfix.HotfixOrderApprover"), ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckConectaProveedoresAdminRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotConectaProveedoresAdminRoleException( "ConectaProveedoresAdmin role required");

    }


    static ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HotfixOrderApproverReplaceAll*/"6dONWMH_kUW9Ti9X5sMIKA*UI_IUQvqtkeuo2Ceci93KQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*HotfixOrderApproverReplaceSingle*/"6dONWMH_kUW9Ti9X5sMIKA*ppaZ6Fl5ZEK1vGLc53V7xA", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_z_Hotfix_HotfixOrderApprover_Controller(
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
[Route("ScreenDataSetGetUserOriginal")]
[RESTScreenServicesActionProperties(Name="GetUserOriginal",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserOriginal(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7wD4ZijinpmjCfV+amlbLw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserOriginal_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserOriginal_maxRecords = 1;
} else {
datasetGetUserOriginal_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserOriginal_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserOriginal_startIndex = 0;
} else {
datasetGetUserOriginal_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserOriginal_maxRecords < 1)) {
datasetGetUserOriginal_maxRecords = 1;
}

AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> ds_output = new AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b>();
long count;
(ds_output.List,count) = await ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.datasetGetUserOriginal(requestContext,datasetGetUserOriginal_maxRecords,datasetGetUserOriginal_startIndex,IterationMultiplicity.Multiple,model.varLcUserOriginal,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363>(ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderStatuses")]
[RESTScreenServicesActionProperties(Name="GetOrderStatuses",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "JufeXrUSLyaU5dJZ+VE2aQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderStatuses_maxRecords = 50;
} else {
datasetGetOrderStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderStatuses_startIndex = 0;
} else {
datasetGetOrderStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderStatuses_maxRecords < 1)) {
datasetGetOrderStatuses_maxRecords = 1;
}

AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38> ds_output = new AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38>();
long count;
(ds_output.List,count) = await ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.datasetGetOrderStatuses(requestContext,datasetGetOrderStatuses_maxRecords,datasetGetOrderStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4>(ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoices")]
[RESTScreenServicesActionProperties(Name="GetInvoices",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OQ0oXv765XdDNIPSGbOeMw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoices_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoices_maxRecords = 99999;
} else {
datasetGetInvoices_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoices_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoices_startIndex = 0;
} else {
datasetGetInvoices_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoices_maxRecords < 1)) {
datasetGetInvoices_maxRecords = 1;
}

AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ds_output = new AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831>();
long count;
(ds_output.List,count) = await ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Multiple,model.varLcGetUserApplicationRolesAndMore.outParamAppRolesListText,model.varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,model.varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,model.varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,model.varLcUserOriginal,cancellationToken)),model.varLcUserOriginal,cancellationToken);

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
[Route("ScreenDataSetGetOrderApprovalLevelsByAssignedTo")]
[RESTScreenServicesActionProperties(Name="GetOrderApprovalLevelsByAssignedTo",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderApprovalLevelsByAssignedTo(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nlhaPPqpOL3bk5CMxJvZIw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderApprovalLevelsByAssignedTo_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderApprovalLevelsByAssignedTo_maxRecords = model.varLcMaxRecords;
} else {
datasetGetOrderApprovalLevelsByAssignedTo_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderApprovalLevelsByAssignedTo_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderApprovalLevelsByAssignedTo_startIndex = model.varLcStartIndex;
} else {
datasetGetOrderApprovalLevelsByAssignedTo_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderApprovalLevelsByAssignedTo_maxRecords < 1)) {
datasetGetOrderApprovalLevelsByAssignedTo_maxRecords = 1;
}

AggregateRecord<RL_6a0d508a138cc1e49e6d938f0b4069dd> ds_output = new AggregateRecord<RL_6a0d508a138cc1e49e6d938f0b4069dd>();
long count;
(ds_output.List,count) = await ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.datasetGetOrderApprovalLevelsByAssignedTo(requestContext,datasetGetOrderApprovalLevelsByAssignedTo_maxRecords,datasetGetOrderApprovalLevelsByAssignedTo_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetUserOriginal.List.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId,model.ScreenDataSetGetUserOriginal.List.CurrentRec.ssENUser_Extended_Internal.ssRegionId,model.varLcOrderNumberFilter,model.varLcOrderStatusId,model.varLcTableSort,model.varLcUserOriginal,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_a2ea85a9f362412e4b6f04be74bb4c8a>(ssConectaProveedores.RestRecords.RESTRC_a2ea85a9f362412e4b6f04be74bb4c8a.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetRequisitions")]
[RESTScreenServicesActionProperties(Name="GetRequisitions",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetRequisitions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "JmOSFYKQZSdqWwCVaAceiw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_f2eeb002682d9f8c7bb8a8168b7aea5f outParamList;
outParamList = await model.DataActionGetRequisitions(requestContext,cancellationToken);

var output = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetRequisitions_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRolesAndMore")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRolesAndMore",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRolesAndMore(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "M8hdTcy12h0pVIu_bhbMnQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamAppRolesListText;
bool outParamIsCorporativoCxP;
bool outParamo_CanUploadInvoices;
string outParamTelcelDirectionsListText;
long outParamCorporativoRegionId;
long outParamUserRegion;
(outParamUserRolesList,outParamAppRolesListText,outParamIsCorporativoCxP,outParamo_CanUploadInvoices,outParamTelcelDirectionsListText,outParamCorporativoRegionId,outParamUserRegion) = await model.DataActionGetUserApplicationRolesAndMore(requestContext,cancellationToken);

var output = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamAppRolesListText, outParamIsCorporativoCxP, outParamo_CanUploadInvoices, outParamTelcelDirectionsListText, outParamCorporativoRegionId, outParamUserRegion);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionHotfixOrderApproverReplaceAll")]
[RESTScreenServicesActionProperties(Name="HotfixOrderApproverReplaceAll",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionHotfixOrderApproverReplaceAll(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "jZbh4uW3FvWknlCGVw1VoA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Model inputs = null;
Actions.lcoHotfixOrderApproverReplaceAll res =  new Actions.lcoHotfixOrderApproverReplaceAll();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMessage = await Actions.ActionHotfixOrderApproverReplaceAll(requestContext,inputs.inParamUserOriginal,inputs.inParamUserSubstitute,inputs.inParamOrderNumberFilter,inputs.inParamOrderStatusId,cancellationToken);

var output = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionHotfixOrderApproverReplaceSingle")]
[RESTScreenServicesActionProperties(Name="HotfixOrderApproverReplaceSingle",Screen="HotfixOrderApprover",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionHotfixOrderApproverReplaceSingle(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "cWEvHEcp96tbVMQa_us4Tw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Model inputs = null;
Actions.lcoHotfixOrderApproverReplaceSingle res =  new Actions.lcoHotfixOrderApproverReplaceSingle();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMessage = await Actions.ActionHotfixOrderApproverReplaceSingle(requestContext,inputs.inParamUserOriginal,inputs.inParamUserSubstitute,inputs.inParamOrderApprovalLevelIdSelected,cancellationToken);

var output = RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}
}
