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
[Route("screenservices/ConectaProveedores/k_Deviations/UnsuccessfulEntries")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("k_Deviations.UnsuccessfulEntries"), ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckDesviacionesRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckFoliosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotFoliosRoleException( "Folios role required");

    }


    static ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*k_Deviations.UnsuccessfulEntries.ResetFilters*/"6dONWMH_kUW9Ti9X5sMIKA*olH1fP+eLEm8VHDnEoiU4g", 
/*k_Deviations.UnsuccessfulEntries.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*5bMCvs2sg0Cc5pgXhHPSvw", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_k_Deviations_UnsuccessfulEntries_Controller(
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
[Route("ScreenDataSetGetFolioStatus")]
[RESTScreenServicesActionProperties(Name="GetFolioStatus",Screen="UnsuccessfulEntries",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioStatus(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "xBnU5wAcTZo_8FO6VaKyzw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel model = null;
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

try {model = RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioStatus_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioStatus_maxRecords = 50;
} else {
datasetGetFolioStatus_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioStatus_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioStatus_startIndex = 0;
} else {
datasetGetFolioStatus_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioStatus_maxRecords < 1)) {
datasetGetFolioStatus_maxRecords = 1;
}

AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ds_output = new AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd>();
long count;
(ds_output.List,count) = await ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel.datasetGetFolioStatus(requestContext,datasetGetFolioStatus_maxRecords,datasetGetFolioStatus_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetData")]
[RESTScreenServicesActionProperties(Name="GetData",Screen="UnsuccessfulEntries",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "2By8IaZyj2yulYiWU59ivQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel model = null;
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

try {model = RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetData_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetData_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetData_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetData_startIndex;
if((inputs.StartIndex == null)) {
datasetGetData_startIndex = model.varLci_StartIndex;
} else {
datasetGetData_startIndex = inputs.StartIndex.Value;
}

if((datasetGetData_maxRecords < 1)) {
datasetGetData_maxRecords = 1;
}

AggregateRecord<RL_dee12d8d138188f23c97a0b0c9fde91b> ds_output = new AggregateRecord<RL_dee12d8d138188f23c97a0b0c9fde91b>();
long count;
(ds_output.List,count) = await ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel.datasetGetData(requestContext,datasetGetData_maxRecords,datasetGetData_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssUnsuccessfulEntries_FolioNumber,model.clientVariables.ssUnsuccessfulEntries_FolioStatus,model.clientVariables.ssUnsuccessfulEntries_OrderNumber,model.clientVariables.ssUnsuccessfulEntries_SAPError,model.clientVariables.ssUnsuccessfulEntries_SupplierId,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_4c9ca09958a3ee4cb990399bb84ebebd>(ssConectaProveedores.RestRecords.RESTRC_4c9ca09958a3ee4cb990399bb84ebebd.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="UnsuccessfulEntries",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="UnsuccessfulEntries",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="UnsuccessfulEntries",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
