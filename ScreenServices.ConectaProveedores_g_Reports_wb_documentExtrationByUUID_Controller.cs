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
[Route("screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByUUID")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController(ConectaProveedores_g_Reports_Wb_PreviewFile_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_s_Storage_wb_DownloadFile_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        dbBinaryConfigs["p1c8u+qdeumxego1hljhsw*iowp8+lfqk2dh8eeqsezja/file"] = new BinaryContentUtils.DbBinaryConfig(ENStorageEntity.LocalViewName, TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@Storage, _EntityKeyConstants._TelcelStorageEntityKeys._StorageAttributeKeys.@File, "file") ?? "file", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@Storage, _EntityKeyConstants._TelcelStorageEntityKeys._StorageAttributeKeys.@Id, "id") ?? "id", 12, false);


        return dbBinaryConfigs;
    }



    static ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*TelcelStorage.ServiceGetDocumentsByListId*/"P1c8u+QdeUmxego1hLjHsw*P7EZ_SGoyUOsV0t7PhN36Q", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA"});

    }

    public ConectaProveedores_g_Reports_wb_documentExtrationByUUID_Controller(
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
[Route("ScreenDataSetGetInvoiceFiles")]
[RESTScreenServicesActionProperties(Name="GetInvoiceFiles",Screen="wb_documentExtrationByUUID",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "o27q1nWTu0DP3AkW0YtbuA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByUUID_ScreenModel model = null;
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

try {model = RESTConectaProveedores_g_Reports_wb_documentExtrationByUUID_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceFiles_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceFiles_maxRecords = model.varLcMaxRecords;
} else {
datasetGetInvoiceFiles_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceFiles_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceFiles_startIndex = model.varLcStartIndex;
} else {
datasetGetInvoiceFiles_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceFiles_maxRecords < 1)) {
datasetGetInvoiceFiles_maxRecords = 1;
}

AggregateRecord<RL_9cdf1789e965682ff9f78e76a5697073> ds_output = new AggregateRecord<RL_9cdf1789e965682ff9f78e76a5697073>();
long count;
(ds_output.List,count) = await ConectaProveedores_g_Reports_wb_documentExtrationByUUID_ScreenModel.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.varLcTableSort,model.varLcUUId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_cfb4b5cbc9f75e782e7f32736dbeac24>(ssConectaProveedores.RestRecords.RESTRC_cfb4b5cbc9f75e782e7f32736dbeac24.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceGetDocumentsByListId")]
[RESTScreenServicesActionProperties(Name="ServiceGetDocumentsByListId",Screen="wb_documentExtrationByUUID",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceGetDocumentsByListId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "B_km2SQBw90cnqn+1+_34g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByUUID_ServiceAPIServiceGetDocumentsByListId_Model inputs = null;
byte[] res_outParamBinaryZip = new byte[] {};
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

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByUUID_ServiceAPIServiceGetDocumentsByListId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamBinaryZip = await ServiceAPIs.ServiceAPIServiceGetDocumentsByListId(requestContext,inputs.inParamIdsList,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByUUID_ServiceAPIServiceGetDocumentsByListId_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamBinaryZip);
return output;


    }, cancellationToken);
}
}
