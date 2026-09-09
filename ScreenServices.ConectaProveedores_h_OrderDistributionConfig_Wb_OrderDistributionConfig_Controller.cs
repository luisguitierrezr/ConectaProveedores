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
[Route("screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_OrderDistributionConfig")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_CustomPagination_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SetTableRecord_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_GetAuditList_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ConfirmPopup_Controller.ProxyInstance, childControllers);
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



    static ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*h_OrderDistributionConfig.Wb_OrderDistributionConfig.TogglePopupConfirmation*/"6dONWMH_kUW9Ti9X5sMIKA*Tn4nRxMvEk6rDeUmmG8urA", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*OrdersDistribution_Assignment*/"6dONWMH_kUW9Ti9X5sMIKA*MNXGfyTz_U6+1omm0vCWMA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*h_OrderDistributionConfig.Wb_OrderDistributionConfig.RefreshList*/"6dONWMH_kUW9Ti9X5sMIKA*YwA5svceL0CY2baCZbuBGQ", 
/*OutSystemsUI.DatePickerOpen*/"Kn_hixxDWEm4lMd7mIpycQ*cF6Lvs8h40Gf0c9ID_IYzg"});

    }

    public ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_Controller(
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
[Route("ScreenDataSetGetOrderDistributionConfig")]
[RESTScreenServicesActionProperties(Name="GetOrderDistributionConfig",Screen="Wb_OrderDistributionConfig",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderDistributionConfig(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3dBGiIBwfmo1x2fFgjC47w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel model = null;
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

try {model = RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderDistributionConfig_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderDistributionConfig_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetGetOrderDistributionConfig_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderDistributionConfig_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderDistributionConfig_startIndex = model.varLcl_StartIndex;
} else {
datasetGetOrderDistributionConfig_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderDistributionConfig_maxRecords < 1)) {
datasetGetOrderDistributionConfig_maxRecords = 1;
}

AggregateRecord<RL_fad66e2f0a5803b0832cea3f3e9146e2> ds_output = new AggregateRecord<RL_fad66e2f0a5803b0832cea3f3e9146e2>();
long count;
(ds_output.List,count) = await ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel.datasetGetOrderDistributionConfig(requestContext,datasetGetOrderDistributionConfig_maxRecords,datasetGetOrderDistributionConfig_startIndex,IterationMultiplicity.Multiple,model.clientVariables.ssOrderDistributionConfig_Applicant,model.clientVariables.ssOrderDistributionConfig_ApplicantDescription,model.clientVariables.ssOrderDistributionConfig_Direction,model.clientVariables.ssOrderDistributionConfig_Division,model.clientVariables.ssOrderDistributionConfig_Role,model.inParami_OrderId,model.varLcl_TableSort,model.varLcl_TabNumber,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad>(ssConectaProveedores.RestRecords.RESTRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRegions")]
[RESTScreenServicesActionProperties(Name="GetRegions",Screen="Wb_OrderDistributionConfig",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRegions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F9suSx2_X8+qIMY5h0gbYw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel model = null;
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

try {model = RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRegions_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRegions_maxRecords = 9999999;
} else {
datasetGetRegions_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRegions_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRegions_startIndex = 0;
} else {
datasetGetRegions_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRegions_maxRecords < 1)) {
datasetGetRegions_maxRecords = 1;
}

AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ds_output = new AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0>();
long count;
(ds_output.List,count) = await ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0>(ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetOrderMainDataOnInput")]
[RESTScreenServicesActionProperties(Name="GetOrderMainDataOnInput",Screen="Wb_OrderDistributionConfig",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrderMainDataOnInput(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "MmvKChJ+B6EcyDwhnEWisQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel model = null;
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

try {model = RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure outParamOutFilters;
bool outParamIsOrderRejected;
(outParamOutFilters,outParamIsOrderRejected) = await model.DataActionGetOrderMainDataOnInput(requestContext,cancellationToken);

var output = RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_DataActionGetOrderMainDataOnInput_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamOutFilters, outParamIsOrderRejected);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionOrdersDistribution_Assignment")]
[RESTScreenServicesActionProperties(Name="OrdersDistribution_Assignment",Screen="Wb_OrderDistributionConfig",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionOrdersDistribution_Assignment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "BbFlnstVCn+Iyp_+kPEmww", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Model inputs = null;
Actions.lcoOrdersDistribution_Assignment res =  new Actions.lcoOrdersDistribution_Assignment();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamResult,res.outParamPositionFirstContactId) = await Actions.ActionOrdersDistribution_Assignment(requestContext,inputs.inParamOrderDistributionConfigId,inputs.inParamOrderMainId,inputs.inParamSendEmails,inputs.inParamUpdateOrder,cancellationToken);

var output = RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ActionOrdersDistribution_Assignment_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamResult, res.outParamPositionFirstContactId);
return output;


    }, cancellationToken);
}
}
