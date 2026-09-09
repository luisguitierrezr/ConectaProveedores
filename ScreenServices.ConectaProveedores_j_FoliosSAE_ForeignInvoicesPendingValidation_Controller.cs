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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/ForeignInvoicesPendingValidation")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("j_FoliosSAE.ForeignInvoicesPendingValidation"), ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller.CheckPermissionsAsync);
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
throw new Ex_NotFoliosRoleException( "Folios role required");

    }


    static ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*j_FoliosSAE.ForeignInvoicesPendingValidation.ResetFilters*/"6dONWMH_kUW9Ti9X5sMIKA*kHTdUZyfqki4hypIQTrosA", 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ", 
/*j_FoliosSAE.ForeignInvoicesPendingValidation.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*Wcmi9pzCIU2HXo+uba5MAw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_Controller(
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
[Route("ScreenDataSetGetFolioStatuses")]
[RESTScreenServicesActionProperties(Name="GetFolioStatuses",Screen="ForeignInvoicesPendingValidation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YiEX4Y3lAA34ViBIgR_A4A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioStatuses_maxRecords = 50;
} else {
datasetGetFolioStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioStatuses_startIndex = 0;
} else {
datasetGetFolioStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioStatuses_maxRecords < 1)) {
datasetGetFolioStatuses_maxRecords = 1;
}

AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ds_output = new AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel.datasetGetFolioStatuses(requestContext,datasetGetFolioStatuses_maxRecords,datasetGetFolioStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetFolioApprovalLevelsByAssignedTo")]
[RESTScreenServicesActionProperties(Name="GetFolioApprovalLevelsByAssignedTo",Screen="ForeignInvoicesPendingValidation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioApprovalLevelsByAssignedTo(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "leBosr2SI2daqvw_Bx8S7w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioApprovalLevelsByAssignedTo_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioApprovalLevelsByAssignedTo_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetFolioApprovalLevelsByAssignedTo_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioApprovalLevelsByAssignedTo_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioApprovalLevelsByAssignedTo_startIndex = 0;
} else {
datasetGetFolioApprovalLevelsByAssignedTo_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioApprovalLevelsByAssignedTo_maxRecords < 1)) {
datasetGetFolioApprovalLevelsByAssignedTo_maxRecords = 1;
}

AggregateRecord<RL_13a8c992e2340d724ae09e59b85c1da0> ds_output = new AggregateRecord<RL_13a8c992e2340d724ae09e59b85c1da0>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel.datasetGetFolioApprovalLevelsByAssignedTo(requestContext,datasetGetFolioApprovalLevelsByAssignedTo_maxRecords,datasetGetFolioApprovalLevelsByAssignedTo_startIndex,IterationMultiplicity.Multiple,model.clientVariables.ssForeignInvoicesPendingValidation_StatusId,BuiltInFunction.GetUserId (),model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f71d1ebfeb3771da2f91490300d5ded2>(ssConectaProveedores.RestRecords.RESTRC_f71d1ebfeb3771da2f91490300d5ded2.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserData")]
[RESTScreenServicesActionProperties(Name="GetUserData",Screen="ForeignInvoicesPendingValidation",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "UKNY1DoOEenSfkY6Pstliw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamo_IsUserCxP;
outParamo_IsUserCxP = await model.DataActionGetUserData(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_DataActionGetUserData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_IsUserCxP);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="ForeignInvoicesPendingValidation",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="ForeignInvoicesPendingValidation",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionColumnTogglerPassColumn(requestContext,inputs.inParami_ColumnJSON,inputs.inParami_TableName,inputs.inParami_UserId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
