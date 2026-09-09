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
[Route("screenservices/ConectaProveedores/s_Storage/wb_DownloadAllFolioFilesByInvoiceId")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller.GetDbBinaryConfigs(); }
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



    static ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*SetClientTimeouts*/"6dONWMH_kUW9Ti9X5sMIKA*PRWPDzZzIk+W7U2j2Ny7PQ", 
/*s_Storage.wb_DownloadAllFolioFilesByInvoiceId.StartFileDownloadZIp*/"6dONWMH_kUW9Ti9X5sMIKA*VNVHI5LUH069IQ30ZwlTQw", 
/*s_Storage.wb_DownloadAllFolioFilesByInvoiceId.ProcessNextFileChunkZip*/"6dONWMH_kUW9Ti9X5sMIKA*evolTej3LUyEct2qTXycwA", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*s_Storage.wb_DownloadAllFolioFilesByInvoiceId.StartProcessZip*/"6dONWMH_kUW9Ti9X5sMIKA*XcJ7bu8FS0WBGtl7crlWnw", 
/*s_Storage.wb_DownloadAllFolioFilesByInvoiceId.OnChunkError*/"6dONWMH_kUW9Ti9X5sMIKA*VASDuqr12U+6sYt9feXMOw", 
/*s_Storage.wb_DownloadAllFolioFilesByInvoiceId.EndProcessZip*/"6dONWMH_kUW9Ti9X5sMIKA*V10HxEN3Pk+W9+YAGI6WRA", 
/*GetFileChunk*/"6dONWMH_kUW9Ti9X5sMIKA*13jKyj2XnUCd+cBCoSv3SQ"});

    }

    public ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_Controller(
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
[Route("ScreenDataSetGetInvoicesByFolioId")]
[RESTScreenServicesActionProperties(Name="GetInvoicesByFolioId",Screen="wb_DownloadAllFolioFilesByInvoiceId",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoicesByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "y5QPV5Ic3yThxUESK5zfMQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel model = null;
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

try {model = RESTConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoicesByFolioId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoicesByFolioId_maxRecords = 999999999;
} else {
datasetGetInvoicesByFolioId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoicesByFolioId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoicesByFolioId_startIndex = 0;
} else {
datasetGetInvoicesByFolioId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoicesByFolioId_maxRecords < 1)) {
datasetGetInvoicesByFolioId_maxRecords = 1;
}

AggregateRecord<RL_9d61cc7501a4784be77b036c540a3e93> ds_output = new AggregateRecord<RL_9d61cc7501a4784be77b036c540a3e93>();
long count;
(ds_output.List,count) = await ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParamInvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5>(ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioFilesByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioFilesByFolioId",Screen="wb_DownloadAllFolioFilesByInvoiceId",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioFilesByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OwTXOH0FmnNlTPXOU1f5NA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel model = null;
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

try {model = RESTConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioFilesByFolioId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioFilesByFolioId_maxRecords = 999999999;
} else {
datasetGetFolioFilesByFolioId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioFilesByFolioId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioFilesByFolioId_startIndex = 0;
} else {
datasetGetFolioFilesByFolioId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioFilesByFolioId_maxRecords < 1)) {
datasetGetFolioFilesByFolioId_maxRecords = 1;
}

AggregateRecord<RL_599a55f2ca551e3817b27381ea3fcd80> ds_output = new AggregateRecord<RL_599a55f2ca551e3817b27381ea3fcd80>();
long count;
(ds_output.List,count) = await ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetInvoicesByFolioId.List.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e>(ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
