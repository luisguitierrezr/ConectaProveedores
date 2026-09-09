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
[Route("screenservices/ConectaProveedores/d_InvoiceAudit/Wb_InvoiceFilesAudit")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_s_Storage_wb_PreviewFile_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_s_Storage_wb_DownloadFile_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
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



    static ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*DownloadZipByStorageIdList*/"6dONWMH_kUW9Ti9X5sMIKA*GnzUlpRH+ECei_hskHUx9g", 
/*d_InvoiceAudit.Wb_InvoiceFilesAudit.DonwloadZIPFilesOnClick*/"6dONWMH_kUW9Ti9X5sMIKA*XeWE+OuD_UilcxeFyGfo4A"});

    }

    public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_Controller(
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
[Route("ScreenDataSetInvoiceFilesById")]
[RESTScreenServicesActionProperties(Name="InvoiceFilesById",Screen="Wb_InvoiceFilesAudit",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetInvoiceFilesById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wINXILRJICCSpMgDVsTB1g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetInvoiceFilesById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetInvoiceFilesById_maxRecords = 50;
} else {
datasetInvoiceFilesById_maxRecords = inputs.MaxRecords.Value;
}

int datasetInvoiceFilesById_startIndex;
if((inputs.StartIndex == null)) {
datasetInvoiceFilesById_startIndex = 0;
} else {
datasetInvoiceFilesById_startIndex = inputs.StartIndex.Value;
}

if((datasetInvoiceFilesById_maxRecords < 1)) {
datasetInvoiceFilesById_maxRecords = 1;
}

AggregateRecord<RL_a8a8885e97333843e8d61cbbac75c28c> ds_output = new AggregateRecord<RL_a8a8885e97333843e8d61cbbac75c28c>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel.datasetInvoiceFilesById(requestContext,datasetInvoiceFilesById_maxRecords,datasetInvoiceFilesById_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_eb0c76f6f640a3fe05b6e66cf112863f>(ssConectaProveedores.RestRecords.RESTRC_eb0c76f6f640a3fe05b6e66cf112863f.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionDownloadZipByStorageIdList")]
[RESTScreenServicesActionProperties(Name="DownloadZipByStorageIdList",Screen="Wb_InvoiceFilesAudit",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDownloadZipByStorageIdList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "_MlgTXx0PjIU+aZSBjJfmg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ActionDownloadZipByStorageIdList_Model inputs = null;
Actions.lcoDownloadZipByStorageIdList res =  new Actions.lcoDownloadZipByStorageIdList();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ActionDownloadZipByStorageIdList_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamBinaryZIP,res.outParamErrorMsg) = await Actions.ActionDownloadZipByStorageIdList(requestContext,inputs.inParamStorageIdList,cancellationToken);

var output = RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ActionDownloadZipByStorageIdList_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamBinaryZIP, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}
}
