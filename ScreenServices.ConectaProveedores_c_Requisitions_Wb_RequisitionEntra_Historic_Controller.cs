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
[Route("screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionEntra_Historic")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller(
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
[Route("ScreenDataSetGetRequisitionsApprovalLevels")]
[RESTScreenServicesActionProperties(Name="GetRequisitionsApprovalLevels",Screen="Wb_RequisitionEntra_Historic",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionsApprovalLevels(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "TRiDTkETrHn5bIRs9xKYHA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionsApprovalLevels_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionsApprovalLevels_maxRecords = 999999999;
} else {
datasetGetRequisitionsApprovalLevels_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionsApprovalLevels_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionsApprovalLevels_startIndex = 0;
} else {
datasetGetRequisitionsApprovalLevels_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionsApprovalLevels_maxRecords < 1)) {
datasetGetRequisitionsApprovalLevels_maxRecords = 1;
}

AggregateRecord<RL_7c4c6843d8ddca100085fd31262966c6> ds_output = new AggregateRecord<RL_7c4c6843d8ddca100085fd31262966c6>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel.datasetGetRequisitionsApprovalLevels(requestContext,datasetGetRequisitionsApprovalLevels_maxRecords,datasetGetRequisitionsApprovalLevels_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssRequisitionStatusId,model.inParami_RequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_8b89674084a8b334109c261c1cd156c4>(ssConectaProveedores.RestRecords.RESTRC_8b89674084a8b334109c261c1cd156c4.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRequisitionById")]
[RESTScreenServicesActionProperties(Name="GetRequisitionById",Screen="Wb_RequisitionEntra_Historic",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Wps_Uy8dcqRFQPd75rqROg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionById_maxRecords = 1;
} else {
datasetGetRequisitionById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionById_startIndex = 0;
} else {
datasetGetRequisitionById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionById_maxRecords < 1)) {
datasetGetRequisitionById_maxRecords = 1;
}

AggregateRecord<RL_72dedb526963c58e79ee56edd8352664> ds_output = new AggregateRecord<RL_72dedb526963c58e79ee56edd8352664>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Multiple,model.inParami_RequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8>(ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetEntraUserManagerList")]
[RESTScreenServicesActionProperties(Name="GetEntraUserManagerList",Screen="Wb_RequisitionEntra_Historic",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetEntraUserManagerList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Bv69ti44rzc1f5xg1+PCbg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList;
outParamUserList = await model.DataActionGetEntraUserManagerList(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetEntraUserManagerList_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSpecialApprovalLevels")]
[RESTScreenServicesActionProperties(Name="GetSpecialApprovalLevels",Screen="Wb_RequisitionEntra_Historic",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSpecialApprovalLevels(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KDobedCAcuKOY8GkVJNPLA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_875afe918a46d044315dbe3410f1f2a7 outParamApprovalList;
outParamApprovalList = await model.DataActionGetSpecialApprovalLevels(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetSpecialApprovalLevels_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamApprovalList);
return output;


    }, cancellationToken);
}
}
