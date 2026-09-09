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
[Route("screenservices/ConectaProveedores/e_OrdersRequestFiles/Wb_UploadOrderContractDocuments")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*UploadOrderContractDocument*/"6dONWMH_kUW9Ti9X5sMIKA*3GO7lxkUDEWVtoYyIgfnEg"});

    }

    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_Controller(
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
[Route("ScreenDataSetGetOrderContractFileById")]
[RESTScreenServicesActionProperties(Name="GetOrderContractFileById",Screen="Wb_UploadOrderContractDocuments",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderContractFileById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dzap3svqJ5o8fxLWTxf4uQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderContractFileById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderContractFileById_maxRecords = 50;
} else {
datasetGetOrderContractFileById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderContractFileById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderContractFileById_startIndex = 0;
} else {
datasetGetOrderContractFileById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderContractFileById_maxRecords < 1)) {
datasetGetOrderContractFileById_maxRecords = 1;
}

AggregateRecord<RL_978260cdc25ae86bbfc7a02b4fbbd8c3> ds_output = new AggregateRecord<RL_978260cdc25ae86bbfc7a02b4fbbd8c3>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel.datasetGetOrderContractFileById(requestContext,datasetGetOrderContractFileById_maxRecords,datasetGetOrderContractFileById_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderContractFile,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70>(ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionUploadOrderContractDocument")]
[RESTScreenServicesActionProperties(Name="UploadOrderContractDocument",Screen="Wb_UploadOrderContractDocuments",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUploadOrderContractDocument(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Yg8c5fJGtlbueC43057GiA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ActionUploadOrderContractDocument_Model inputs = null;
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

try {inputs = RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ActionUploadOrderContractDocument_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionUploadOrderContractDocument(requestContext,inputs.inParami_OrderRequestFileId,inputs.inParami_OrderContractFile,inputs.inParami_OrderMainId,inputs.inParami_InvoiceForeign,inputs.inParami_File,inputs.inParami_FilesList,inputs.inParamOffsetUtc,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
