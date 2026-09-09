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
[Route("screenservices/ConectaProveedores/e_Orders/WB_OrderFinancialFiles")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderFilesPreview_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*e_Orders.WB_OrderFinancialFiles.ClosePopup*/"6dONWMH_kUW9Ti9X5sMIKA*6JeQwR3VnkaoyQdUVfSmNA"});

    }

    public ConectaProveedores_e_Orders_WB_OrderFinancialFiles_Controller(
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
[Route("ScreenDataSetGetOrderAccountingsByOrderId")]
[RESTScreenServicesActionProperties(Name="GetOrderAccountingsByOrderId",Screen="WB_OrderFinancialFiles",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderAccountingsByOrderId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Y4dCtZ1tnp3zYmUR2wf4nw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderAccountingsByOrderId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderAccountingsByOrderId_maxRecords = 999999999;
} else {
datasetGetOrderAccountingsByOrderId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderAccountingsByOrderId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderAccountingsByOrderId_startIndex = 0;
} else {
datasetGetOrderAccountingsByOrderId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderAccountingsByOrderId_maxRecords < 1)) {
datasetGetOrderAccountingsByOrderId_maxRecords = 1;
}

AggregateRecord<RL_e127e807f43523243e5e4b1203065583> ds_output = new AggregateRecord<RL_e127e807f43523243e5e4b1203065583>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel.datasetGetOrderAccountingsByOrderId(requestContext,datasetGetOrderAccountingsByOrderId_maxRecords,datasetGetOrderAccountingsByOrderId_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae>(ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderFileById")]
[RESTScreenServicesActionProperties(Name="GetOrderFileById",Screen="WB_OrderFinancialFiles",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderFileById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "I1lgGjcQaZOTtHAsQXqxcw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderFileById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderFileById_maxRecords = 50;
} else {
datasetGetOrderFileById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderFileById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderFileById_startIndex = 0;
} else {
datasetGetOrderFileById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderFileById_maxRecords < 1)) {
datasetGetOrderFileById_maxRecords = 1;
}

AggregateRecord<RL_924196580a3b015839b6fad505120f41> ds_output = new AggregateRecord<RL_924196580a3b015839b6fad505120f41>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel.datasetGetOrderFileById(requestContext,datasetGetOrderFileById_maxRecords,datasetGetOrderFileById_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032>(ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
