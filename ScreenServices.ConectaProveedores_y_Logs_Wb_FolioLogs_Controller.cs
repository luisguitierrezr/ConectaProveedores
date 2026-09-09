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
[Route("screenservices/ConectaProveedores/y_Logs/Wb_FolioLogs")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_y_Logs_Wb_FolioLogs_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_y_Logs_Wb_FolioLogs_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_y_Logs_Wb_FolioLogs_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_y_Logs_Wb_FolioLogs_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_y_Logs_Wb_FolioLogs_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_y_Logs_Wb_FolioLogs_Controller.GetDbBinaryConfigs(); }
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



    static ConectaProveedores_y_Logs_Wb_FolioLogs_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ExportFolioSAElLog*/"6dONWMH_kUW9Ti9X5sMIKA*6oA1g2rKs0CUPppi875M1Q", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*OutSystemsUI.DatePickerOpen*/"Kn_hixxDWEm4lMd7mIpycQ*cF6Lvs8h40Gf0c9ID_IYzg"});

    }

    public ConectaProveedores_y_Logs_Wb_FolioLogs_Controller(
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
[Route("ScreenDataSetGetUsers")]
[RESTScreenServicesActionProperties(Name="GetUsers",Screen="Wb_FolioLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUsers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7qn+Vl+aAoZsnifb83U++g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_FolioId,cancellationToken);

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
[Route("ScreenDataSetGetFolioLogsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioLogsByFolioId",Screen="Wb_FolioLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioLogsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+6lTQP4yT+FkQleF+GlcYg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioLogsByFolioId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioLogsByFolioId_maxRecords = model.varLcMaxRecords;
} else {
datasetGetFolioLogsByFolioId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioLogsByFolioId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioLogsByFolioId_startIndex = 0;
} else {
datasetGetFolioLogsByFolioId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioLogsByFolioId_maxRecords < 1)) {
datasetGetFolioLogsByFolioId_maxRecords = 1;
}

AggregateRecord<RL_4f2c6ead1defc6a22d01e9202d23be15> ds_output = new AggregateRecord<RL_4f2c6ead1defc6a22d01e9202d23be15>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel.datasetGetFolioLogsByFolioId(requestContext,datasetGetFolioLogsByFolioId_maxRecords,datasetGetFolioLogsByFolioId_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_FolioId,model.varLcl_DateTimeVar,model.varLcl_UserName,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7>(ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetCountFolioLogs")]
[RESTScreenServicesActionProperties(Name="CountFolioLogs",Screen="Wb_FolioLogs",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetCountFolioLogs(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OXa6h77GWEXQJ38Np0xP7Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel model = null;
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

try {model = RESTConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetCountFolioLogs_maxRecords;
if((inputs.MaxRecords == null)) {
datasetCountFolioLogs_maxRecords = 1;
} else {
datasetCountFolioLogs_maxRecords = inputs.MaxRecords.Value;
}

int datasetCountFolioLogs_startIndex;
if((inputs.StartIndex == null)) {
datasetCountFolioLogs_startIndex = 0;
} else {
datasetCountFolioLogs_startIndex = inputs.StartIndex.Value;
}

if((datasetCountFolioLogs_maxRecords < 1)) {
datasetCountFolioLogs_maxRecords = 1;
}

AggregateRecord<RL_9801bd776ff900c0406cf35f97fa0b26> ds_output = new AggregateRecord<RL_9801bd776ff900c0406cf35f97fa0b26>();
long count;
(ds_output.List,count) = await ConectaProveedores_y_Logs_Wb_FolioLogs_ScreenModel.datasetCountFolioLogs(requestContext,datasetCountFolioLogs_maxRecords,datasetCountFolioLogs_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb>(ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionExportFolioSAElLog")]
[RESTScreenServicesActionProperties(Name="ExportFolioSAElLog",Screen="Wb_FolioLogs",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionExportFolioSAElLog(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "c9gfnZS+DDPD_HUSffzWfw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Model inputs = null;
Actions.lcoExportFolioSAElLog res =  new Actions.lcoExportFolioSAElLog();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_File,res.outParamo_FileName) = await Actions.ActionExportFolioSAElLog(requestContext,inputs.inParami_FolioId,cancellationToken);

var output = RESTConectaProveedores_y_Logs_Wb_FolioLogs_ActionExportFolioSAElLog_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File, res.outParamo_FileName);
return output;


    }, cancellationToken);
}
}
