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
[Route("screenservices/ConectaProveedores/a_Main/DashboardAdmin")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Main_DashboardAdmin_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Main_DashboardAdmin_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Main_DashboardAdmin_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Main_DashboardAdmin_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Main_DashboardAdmin_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Main_DashboardAdmin_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_ColumnsSmallRight_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Numbers_ProgressBar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_a_Main_DashboardAdmin_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*DownloadFileWithProposalId*/"6dONWMH_kUW9Ti9X5sMIKA*SUV+lX3IY0mgTcRKKWUDLQ"});

    }

    public ConectaProveedores_a_Main_DashboardAdmin_Controller(
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
[Route("ScreenDataSetGetLast10Proposals")]
[RESTScreenServicesActionProperties(Name="GetLast10Proposals",Screen="DashboardAdmin",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetLast10Proposals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ena8FtIRAxR3dZUfm7RCXA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Main_DashboardAdmin_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetLast10Proposals_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetLast10Proposals_maxRecords = 10;
} else {
datasetGetLast10Proposals_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetLast10Proposals_startIndex;
if((inputs.StartIndex == null)) {
datasetGetLast10Proposals_startIndex = 0;
} else {
datasetGetLast10Proposals_startIndex = inputs.StartIndex.Value;
}

if((datasetGetLast10Proposals_maxRecords < 1)) {
datasetGetLast10Proposals_maxRecords = 1;
}

AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ds_output = new AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Main_DashboardAdmin_ScreenModel.datasetGetLast10Proposals(requestContext,datasetGetLast10Proposals_maxRecords,datasetGetLast10Proposals_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("DataActionGetErrorAPIProposals")]
[RESTScreenServicesActionProperties(Name="GetErrorAPIProposals",Screen="DashboardAdmin",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetErrorAPIProposals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "TVTRV1eK7MOq0Ec8MilS0Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Main_DashboardAdmin_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_496abaeba4975b81a1a9b391230e8099 outParamErrorAPIProposals;
outParamErrorAPIProposals = await model.DataActionGetErrorAPIProposals(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetErrorAPIProposals_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamErrorAPIProposals);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetActiveProposals")]
[RESTScreenServicesActionProperties(Name="GetActiveProposals",Screen="DashboardAdmin",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetActiveProposals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "J5OWxh51MADmoSpy6QxEBQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Main_DashboardAdmin_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_496abaeba4975b81a1a9b391230e8099 outParamActiveProposals;
int outParamo_TotalCount;
(outParamActiveProposals,outParamo_TotalCount) = await model.DataActionGetActiveProposals(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamActiveProposals, outParamo_TotalCount);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetProcessedProposals")]
[RESTScreenServicesActionProperties(Name="GetProcessedProposals",Screen="DashboardAdmin",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetProcessedProposals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "xmd7Exw7DQpssayMZE1oQA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Main_DashboardAdmin_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Main_DashboardAdmin_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_496abaeba4975b81a1a9b391230e8099 outParamProcessedProposals;
int outParamo_TotalCount;
(outParamProcessedProposals,outParamo_TotalCount) = await model.DataActionGetProcessedProposals(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamProcessedProposals, outParamo_TotalCount);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionDownloadFileWithProposalId")]
[RESTScreenServicesActionProperties(Name="DownloadFileWithProposalId",Screen="DashboardAdmin",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDownloadFileWithProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "orzRncjq6at+5OYp6Ib1PA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Main_DashboardAdmin_ActionDownloadFileWithProposalId_Model inputs = null;
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

try {inputs = RESTConectaProveedores_a_Main_DashboardAdmin_ActionDownloadFileWithProposalId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Filename,res.outParamo_BinaryData) = await Actions.ActionDownloadFileWithProposalId(requestContext,inputs.inParami_ProposalId,cancellationToken);

var output = RESTConectaProveedores_a_Main_DashboardAdmin_ActionDownloadFileWithProposalId_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Filename, res.outParamo_BinaryData);
return output;


    }, cancellationToken);
}
}
