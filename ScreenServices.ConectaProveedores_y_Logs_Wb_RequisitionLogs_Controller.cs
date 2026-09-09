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
[Route("screenservices/ConectaProveedores/y_Logs/Wb_RequisitionLogs")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller.GetDbBinaryConfigs(); }
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



    static ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ExportRequisitionLog*/"6dONWMH_kUW9Ti9X5sMIKA*IFnVEKl6TkOVF_Qa29MIfg", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*OutSystemsUI.DatePickerOpen*/"Kn_hixxDWEm4lMd7mIpycQ*cF6Lvs8h40Gf0c9ID_IYzg"});

    }

    public ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller(
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
[Route("ScreenDataSetGetRequisitionLogsByRequisitionId")]
[RESTScreenServicesActionProperties(Name="GetRequisitionLogsByRequisitionId",Screen="Wb_RequisitionLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionLogsByRequisitionId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CXFJhRM1WJ2ERE9jRqx1Jg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionLogsByRequisitionId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionLogsByRequisitionId_maxRecords = model.varLcMaxRecords;
} else {
datasetGetRequisitionLogsByRequisitionId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionLogsByRequisitionId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionLogsByRequisitionId_startIndex = 0;
} else {
datasetGetRequisitionLogsByRequisitionId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionLogsByRequisitionId_maxRecords < 1)) {
datasetGetRequisitionLogsByRequisitionId_maxRecords = 1;
}

AggregateRecord<RL_229a538de0ea5acc5992a93132dd8a21> ds_output = new AggregateRecord<RL_229a538de0ea5acc5992a93132dd8a21>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel.datasetGetRequisitionLogsByRequisitionId(requestContext,datasetGetRequisitionLogsByRequisitionId_maxRecords,datasetGetRequisitionLogsByRequisitionId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_RequisitionId,model.varLcl_DateTimeVar,model.varLcl_UserName,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692>(ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetCountRequisitionLogs")]
[RESTScreenServicesActionProperties(Name="CountRequisitionLogs",Screen="Wb_RequisitionLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetCountRequisitionLogs(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CMEFWk5DLDhuLtp9eeDmEw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetCountRequisitionLogs_maxRecords;
if((inputs.MaxRecords == null)) {
datasetCountRequisitionLogs_maxRecords = 300;
} else {
datasetCountRequisitionLogs_maxRecords = inputs.MaxRecords.Value;
}

int datasetCountRequisitionLogs_startIndex;
if((inputs.StartIndex == null)) {
datasetCountRequisitionLogs_startIndex = 0;
} else {
datasetCountRequisitionLogs_startIndex = inputs.StartIndex.Value;
}

if((datasetCountRequisitionLogs_maxRecords < 1)) {
datasetCountRequisitionLogs_maxRecords = 1;
}

AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ds_output = new AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel.datasetCountRequisitionLogs(requestContext,datasetCountRequisitionLogs_maxRecords,datasetCountRequisitionLogs_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_RequisitionId,cancellationToken);

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
[RESTScreenServicesActionProperties(Name="GetUsers",Screen="Wb_RequisitionLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUsers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "NkXTOQa_zPJBLW1BS3vpPA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_RequisitionLogs_ScreenModel.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_RequisitionId,cancellationToken);

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
[Route("ActionExportRequisitionLog")]
[RESTScreenServicesActionProperties(Name="ExportRequisitionLog",Screen="Wb_RequisitionLogs",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionExportRequisitionLog(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "qjoHyfG_bBGPMSiWer0nfw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Model inputs = null;
Actions.lcoExportRequisitionLog res =  new Actions.lcoExportRequisitionLog();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_File = await Actions.ActionExportRequisitionLog(requestContext,inputs.inParami_RequisitionId,cancellationToken);

var output = RESTConectaProveedores_y_Logs_Wb_RequisitionLogs_ActionExportRequisitionLog_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File);
return output;


    }, cancellationToken);
}
}
