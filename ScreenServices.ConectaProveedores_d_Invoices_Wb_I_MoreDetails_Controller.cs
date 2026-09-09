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
[Route("screenservices/ConectaProveedores/d_Invoices/Wb_I_MoreDetails")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_d_Invoices_Wb_I_MoreDetails_Controller(
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
[Route("ScreenDataSetLatestInvoiceComment")]
[RESTScreenServicesActionProperties(Name="LatestInvoiceComment",Screen="Wb_I_MoreDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetLatestInvoiceComment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "De+Z4piZ8RdLAs5UlFkdlQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetLatestInvoiceComment_maxRecords;
if((inputs.MaxRecords == null)) {
datasetLatestInvoiceComment_maxRecords = 1;
} else {
datasetLatestInvoiceComment_maxRecords = inputs.MaxRecords.Value;
}

int datasetLatestInvoiceComment_startIndex;
if((inputs.StartIndex == null)) {
datasetLatestInvoiceComment_startIndex = 0;
} else {
datasetLatestInvoiceComment_startIndex = inputs.StartIndex.Value;
}

if((datasetLatestInvoiceComment_maxRecords < 1)) {
datasetLatestInvoiceComment_maxRecords = 1;
}

AggregateRecord<RL_2e7f130f9df070446bc2a9ac7dcde539> ds_output = new AggregateRecord<RL_2e7f130f9df070446bc2a9ac7dcde539>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel.datasetLatestInvoiceComment(requestContext,datasetLatestInvoiceComment_maxRecords,datasetLatestInvoiceComment_startIndex,IterationMultiplicity.Multiple,model.inParamInvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222>(ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetMoreDetails")]
[RESTScreenServicesActionProperties(Name="MoreDetails",Screen="Wb_I_MoreDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetMoreDetails(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "qRar0GMcMEn_c5LG560YZQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetMoreDetails_maxRecords;
if((inputs.MaxRecords == null)) {
datasetMoreDetails_maxRecords = model.clientVariables.ssMaxRecords;
} else {
datasetMoreDetails_maxRecords = inputs.MaxRecords.Value;
}

int datasetMoreDetails_startIndex;
if((inputs.StartIndex == null)) {
datasetMoreDetails_startIndex = 0;
} else {
datasetMoreDetails_startIndex = inputs.StartIndex.Value;
}

if((datasetMoreDetails_maxRecords < 1)) {
datasetMoreDetails_maxRecords = 1;
}

AggregateRecord<RL_555a5d0da2fe2f0e71754918f879d5c3> ds_output = new AggregateRecord<RL_555a5d0da2fe2f0e71754918f879d5c3>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel.datasetMoreDetails(requestContext,datasetMoreDetails_maxRecords,datasetMoreDetails_startIndex,IterationMultiplicity.Multiple,model.inParamInvoiceId,model.varLcTableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_b64650646295f01a3e7c46ac44009d3c>(ssConectaProveedores.RestRecords.RESTRC_b64650646295f01a3e7c46ac44009d3c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
