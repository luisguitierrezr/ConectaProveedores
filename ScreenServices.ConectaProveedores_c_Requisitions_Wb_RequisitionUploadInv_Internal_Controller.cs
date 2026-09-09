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
[Route("screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionUploadInv_Internal")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Search_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssColumOrganizerLib.ScreenServices.ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_Controller", "ColumOrganizerLib", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ColumnTogglerPassColumn*/"6dONWMH_kUW9Ti9X5sMIKA*ATNHaNXDeE2mUnzjhMTL1w", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*c_Requisitions.Wb_RequisitionUploadInv_Internal.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*ontus7NusEaajAlAPNK0dQ", 
/*GetSettings*/"6dONWMH_kUW9Ti9X5sMIKA*CZIOz72jd0ahSQb57CZRSQ"});

    }

    public ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_Controller(
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
[Route("ScreenDataSetGetProjectAssetServices")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetServices",Screen="Wb_RequisitionUploadInv_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetServices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "QmIftqTsNkC++1frUcNFQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProjectAssetServices_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProjectAssetServices_maxRecords = 50;
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel.datasetGetProjectAssetServices(requestContext,datasetGetProjectAssetServices_maxRecords,datasetGetProjectAssetServices_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetRequisitionsForUpload")]
[RESTScreenServicesActionProperties(Name="GetRequisitionsForUpload",Screen="Wb_RequisitionUploadInv_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionsForUpload(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "1ceECdIrYAzCq82jp7gAPQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionsForUpload_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionsForUpload_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetRequisitionsForUpload_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionsForUpload_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionsForUpload_startIndex = model.varLcl_StartIndex;
} else {
datasetGetRequisitionsForUpload_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionsForUpload_maxRecords < 1)) {
datasetGetRequisitionsForUpload_maxRecords = 1;
}

AggregateRecord<RL_39c5627b3bb44cc40b890ccd9b2786b2> ds_output = new AggregateRecord<RL_39c5627b3bb44cc40b890ccd9b2786b2>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel.datasetGetRequisitionsForUpload(requestContext,datasetGetRequisitionsForUpload_maxRecords,datasetGetRequisitionsForUpload_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.clientVariables.ssRequisitions_AmountFrom,model.clientVariables.ssRequisitions_AmountTo,model.clientVariables.ssRequisitions_CompanyId,model.clientVariables.ssRequisitions_CostCenterId,model.clientVariables.ssRequisitions_ProjectId,model.clientVariables.ssRequisitions_ProveedorFilter_UploadDateFrom,model.clientVariables.ssRequisitions_ProveedorFilter_UploadDateTo,model.clientVariables.ssRequisitions_RegionId,model.clientVariables.ssRequisitions_RequisitionSearch,model.varLcGetApprovalProcessIds2.outParamo_ApprovalProcessIds,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcl_TableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d>(ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCompanies")]
[RESTScreenServicesActionProperties(Name="GetCompanies",Screen="Wb_RequisitionUploadInv_Internal",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCompanies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dUlLiZXilCXZfHjYY_ZYJg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("DataActionGetApprovalProcessIds2")]
[RESTScreenServicesActionProperties(Name="GetApprovalProcessIds2",Screen="Wb_RequisitionUploadInv_Internal",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetApprovalProcessIds2(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "J3HdnFtqJ75YA0ktpUGprQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamo_ApprovalProcessIds;
outParamo_ApprovalProcessIds = await model.DataActionGetApprovalProcessIds2(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_DataActionGetApprovalProcessIds2_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_ApprovalProcessIds);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionColumnTogglerPassColumn")]
[RESTScreenServicesActionProperties(Name="ColumnTogglerPassColumn",Screen="Wb_RequisitionUploadInv_Internal",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionColumnTogglerPassColumn(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CdBjpqOzG3k0+Q1AYbtdhg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ActionColumnTogglerPassColumn_Model inputs = null;
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

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ActionColumnTogglerPassColumn_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
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
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="Wb_RequisitionUploadInv_Internal",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YMh+L1Z1H9xV5gLNPZiIAg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ActionGetSettings_Model inputs = null;
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

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ActionGetSettings_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamOutSettingsText = await Actions.ActionGetSettings(requestContext,inputs.inParamTableName,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamOutSettingsText);
return output;


    }, cancellationToken);
}
}
