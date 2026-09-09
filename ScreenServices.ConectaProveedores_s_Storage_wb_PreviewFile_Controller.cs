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
[Route("screenservices/ConectaProveedores/s_Storage/wb_PreviewFile")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_s_Storage_wb_PreviewFile_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_s_Storage_wb_PreviewFile_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_s_Storage_wb_PreviewFile_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_s_Storage_wb_PreviewFile_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_s_Storage_wb_PreviewFile_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_s_Storage_wb_PreviewFile_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfPDFViewerODC.ScreenServices.CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_Controller", "CloneOfPDFViewerODC", childControllers);
SafeAddChildController("ssXMLPrettify.ScreenServices.XMLPrettify_XMLPrettify_XMLPrettify_Controller", "XMLPrettify", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
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



    static ConectaProveedores_s_Storage_wb_PreviewFile_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*SetClientTimeouts*/"6dONWMH_kUW9Ti9X5sMIKA*PRWPDzZzIk+W7U2j2Ny7PQ", 
/*s_Storage.wb_PreviewFile.OnChunkProcessed*/"6dONWMH_kUW9Ti9X5sMIKA*GgEoGhkO7UaQpGzr+1+Czg", 
/*GetFileDataFromBase64*/"6dONWMH_kUW9Ti9X5sMIKA*yQsKRx8WGUKQ3aizL4Lhng", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*s_Storage.wb_PreviewFile.StartFileDownload*/"6dONWMH_kUW9Ti9X5sMIKA*UWCZZXbdqEaH1CTppOJ60g", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*s_Storage.wb_PreviewFile.OnChunkError*/"6dONWMH_kUW9Ti9X5sMIKA*cM9WjNOfs0C4SkbqwrYc4w", 
/*s_Storage.wb_PreviewFile.ProcessNextFileChunk*/"6dONWMH_kUW9Ti9X5sMIKA*eSkuw2FuGE6Ech6jMLRc0Q", 
/*GetFileChunk*/"6dONWMH_kUW9Ti9X5sMIKA*13jKyj2XnUCd+cBCoSv3SQ", 
/*s_Storage.wb_PreviewFile.FinalizeFileDownload*/"6dONWMH_kUW9Ti9X5sMIKA*+W9n4EkhnU2517iOYaNVKA"});

    }

    public ConectaProveedores_s_Storage_wb_PreviewFile_Controller(
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
[Route("ScreenDataSetGetStorageById")]
[RESTScreenServicesActionProperties(Name="GetStorageById",Screen="wb_PreviewFile",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetStorageById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7Jh2qQxG4ohWYg3hZh5BdA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel model = null;
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

try {model = RESTConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetStorageById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetStorageById_maxRecords = 1;
} else {
datasetGetStorageById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetStorageById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetStorageById_startIndex = 0;
} else {
datasetGetStorageById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetStorageById_maxRecords < 1)) {
datasetGetStorageById_maxRecords = 1;
}

AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> ds_output = new AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b>();
long count;
(ds_output.List,count) = await ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel.datasetGetStorageById(requestContext,datasetGetStorageById_maxRecords,datasetGetStorageById_startIndex,IterationMultiplicity.Multiple,model.inParami_StorageId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514>(ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionGetFileDataFromBase64")]
[RESTScreenServicesActionProperties(Name="GetFileDataFromBase64",Screen="wb_PreviewFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetFileDataFromBase64(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "_a2rg8BFQDXbgQnzciHk4g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Model inputs = null;
Actions.lcoGetFileDataFromBase64 res =  new Actions.lcoGetFileDataFromBase64();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Binary,res.outParamo_xml) = await Actions.ActionGetFileDataFromBase64(requestContext,inputs.inParami_Base64,inputs.inParami_Filename,cancellationToken);

var output = RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Binary, res.outParamo_xml);
return output;


    }, cancellationToken);
}
}
