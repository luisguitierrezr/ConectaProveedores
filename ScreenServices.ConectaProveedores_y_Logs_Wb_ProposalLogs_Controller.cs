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
[Route("screenservices/ConectaProveedores/y_Logs/Wb_ProposalLogs")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
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



    static ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ExportProposalLog*/"6dONWMH_kUW9Ti9X5sMIKA*LI5_oJkHN0mJegOHlvpk0g", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*OutSystemsUI.DatePickerOpen*/"Kn_hixxDWEm4lMd7mIpycQ*cF6Lvs8h40Gf0c9ID_IYzg"});

    }

    public ConectaProveedores_y_Logs_Wb_ProposalLogs_Controller(
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
[Route("ScreenDataSetGetProposalLogsByProposalId")]
[RESTScreenServicesActionProperties(Name="GetProposalLogsByProposalId",Screen="Wb_ProposalLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalLogsByProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "w7p+EG6m1pCgVSHRuMg4Xw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalLogsByProposalId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalLogsByProposalId_maxRecords = model.varLcMaxRecords;
} else {
datasetGetProposalLogsByProposalId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalLogsByProposalId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalLogsByProposalId_startIndex = 0;
} else {
datasetGetProposalLogsByProposalId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalLogsByProposalId_maxRecords < 1)) {
datasetGetProposalLogsByProposalId_maxRecords = 1;
}

AggregateRecord<RL_f6f48bf2db0bc517dcae1aa52c83f316> ds_output = new AggregateRecord<RL_f6f48bf2db0bc517dcae1aa52c83f316>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel.datasetGetProposalLogsByProposalId(requestContext,datasetGetProposalLogsByProposalId_maxRecords,datasetGetProposalLogsByProposalId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ProposalId,model.inParami_ProposalLineId,model.varLcl_DateTimeVar,model.varLcl_UserName,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa>(ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetCountProposalLogs")]
[RESTScreenServicesActionProperties(Name="CountProposalLogs",Screen="Wb_ProposalLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetCountProposalLogs(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "IpLOb0OcKCRoe2H4ypn1uw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetCountProposalLogs_maxRecords;
if((inputs.MaxRecords == null)) {
datasetCountProposalLogs_maxRecords = 1;
} else {
datasetCountProposalLogs_maxRecords = inputs.MaxRecords.Value;
}

int datasetCountProposalLogs_startIndex;
if((inputs.StartIndex == null)) {
datasetCountProposalLogs_startIndex = 0;
} else {
datasetCountProposalLogs_startIndex = inputs.StartIndex.Value;
}

if((datasetCountProposalLogs_maxRecords < 1)) {
datasetCountProposalLogs_maxRecords = 1;
}

AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ds_output = new AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel.datasetCountProposalLogs(requestContext,datasetCountProposalLogs_maxRecords,datasetCountProposalLogs_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ProposalId,model.inParami_ProposalLineId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835>(ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetUsers")]
[RESTScreenServicesActionProperties(Name="GetUsers",Screen="Wb_ProposalLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUsers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "jmM4tFTbi1n+mJrsKmwiSg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUsers_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUsers_maxRecords = 50;
} else {
datasetGetUsers_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUsers_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUsers_startIndex = 0;
} else {
datasetGetUsers_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUsers_maxRecords < 1)) {
datasetGetUsers_maxRecords = 1;
}

AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2> ds_output = new AggregateRecord<RL_8e4276b7147c8295b1546570303ecba2>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_ProposalLogs_ScreenModel.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_ProposalId,model.inParami_ProposalLineId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930>(ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionExportProposalLog")]
[RESTScreenServicesActionProperties(Name="ExportProposalLog",Screen="Wb_ProposalLogs",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionExportProposalLog(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "lhR09pUZWgSZGLnt9VfJ_Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Model inputs = null;
Actions.lcoExportProposalLog res =  new Actions.lcoExportProposalLog();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_File = await Actions.ActionExportProposalLog(requestContext,inputs.inParami_ProposalId,inputs.inParami_ProposalLineId,cancellationToken);

var output = RESTConectaProveedores_y_Logs_Wb_ProposalLogs_ActionExportProposalLog_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File);
return output;


    }, cancellationToken);
}
}
