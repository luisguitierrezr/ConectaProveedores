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
[Route("screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsHistory")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller.GetDbBinaryConfigs(); }
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



    static ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ExportInvoiceLogs*/"6dONWMH_kUW9Ti9X5sMIKA*4zqkfh8kt0GQsC7zauSggg", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*OutSystemsUI.DatePickerOpen*/"Kn_hixxDWEm4lMd7mIpycQ*cF6Lvs8h40Gf0c9ID_IYzg"});

    }

    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_Controller(
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
[Route("ScreenDataSetCountInvoiceLogs")]
[RESTScreenServicesActionProperties(Name="CountInvoiceLogs",Screen="Wb_InvoiceDetailsHistory",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetCountInvoiceLogs(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "FlVUhC2n3Z6ozIPySkkw4w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetCountInvoiceLogs_maxRecords;
if((inputs.MaxRecords == null)) {
datasetCountInvoiceLogs_maxRecords = 300;
} else {
datasetCountInvoiceLogs_maxRecords = inputs.MaxRecords.Value;
}

int datasetCountInvoiceLogs_startIndex;
if((inputs.StartIndex == null)) {
datasetCountInvoiceLogs_startIndex = 0;
} else {
datasetCountInvoiceLogs_startIndex = inputs.StartIndex.Value;
}

if((datasetCountInvoiceLogs_maxRecords < 1)) {
datasetCountInvoiceLogs_maxRecords = 1;
}

AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e> ds_output = new AggregateRecord<RL_11e68f59508e412eaf5b78801dd06b0e>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel.datasetCountInvoiceLogs(requestContext,datasetCountInvoiceLogs_maxRecords,datasetCountInvoiceLogs_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_InvoiceId,cancellationToken);

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
[RESTScreenServicesActionProperties(Name="GetUsers",Screen="Wb_InvoiceDetailsHistory",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUsers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "NjQ4OcV9dc13vZkixlCu_w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.inParami_InvoiceId,cancellationToken);

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
[Route("ScreenDataSetGetInvoiceLogsByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceLogsByInvoiceId",Screen="Wb_InvoiceDetailsHistory",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceLogsByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "UNYe+L8kx5Wv_y9smJKW4w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceLogsByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceLogsByInvoiceId_maxRecords = model.varLcMaxRecords;
} else {
datasetGetInvoiceLogsByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceLogsByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceLogsByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceLogsByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceLogsByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceLogsByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_8623462923ce4f5fca06be3fb804a6be> ds_output = new AggregateRecord<RL_8623462923ce4f5fca06be3fb804a6be>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ScreenModel.datasetGetInvoiceLogsByInvoiceId(requestContext,datasetGetInvoiceLogsByInvoiceId_maxRecords,datasetGetInvoiceLogsByInvoiceId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_InvoiceId,model.varLcl_DateTimeVar,model.varLcl_UserName,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec>(ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionExportInvoiceLogs")]
[RESTScreenServicesActionProperties(Name="ExportInvoiceLogs",Screen="Wb_InvoiceDetailsHistory",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionExportInvoiceLogs(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "kFNSmIpdbIyWbdU4LC59XA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Model inputs = null;
Actions.lcoExportInvoiceLogs res =  new Actions.lcoExportInvoiceLogs();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_File = await Actions.ActionExportInvoiceLogs(requestContext,inputs.inParami_InvoiceId,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_ActionExportInvoiceLogs_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File);
return output;


    }, cancellationToken);
}
}
