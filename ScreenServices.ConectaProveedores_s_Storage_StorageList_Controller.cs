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
[Route("screenservices/ConectaProveedores/s_Storage/StorageList")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_s_Storage_StorageList_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_s_Storage_StorageList_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_s_Storage_StorageList_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_s_Storage_StorageList_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_s_Storage_StorageList_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_s_Storage_StorageList_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_s_Storage_wb_PreviewFile_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_s_Storage_wb_DownloadFile_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("s_Storage.StorageList"), ConectaProveedores_s_Storage_StorageList_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        dbBinaryConfigs["p1c8u+qdeumxego1hljhsw*iowp8+lfqk2dh8eeqsezja/file"] = new BinaryContentUtils.DbBinaryConfig(ENStorageEntity.LocalViewName, TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@Storage, _EntityKeyConstants._TelcelStorageEntityKeys._StorageAttributeKeys.@File, "file") ?? "file", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@Storage, _EntityKeyConstants._TelcelStorageEntityKeys._StorageAttributeKeys.@Id, "id") ?? "id", 12, false);


        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        {
bool check;
check = await ExtendedActions.CheckConectaProveedoresAdminRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotConectaProveedoresAdminRoleException( "ConectaProveedoresAdmin role required");

    }


    static ConectaProveedores_s_Storage_StorageList_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*TelcelStorage.ServiceResendFailedFile*/"P1c8u+QdeUmxego1hLjHsw*TuVL_XsLDESo3U4J2Tnxbg", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_s_Storage_StorageList_Controller(
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
[Route("ScreenDataSetStorageList")]
[RESTScreenServicesActionProperties(Name="StorageList",Screen="StorageList",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetStorageList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8vrRdGuJOV4IIFm23wCMrQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_s_Storage_StorageList_ScreenModel model = null;
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

try {model = RESTConectaProveedores_s_Storage_StorageList_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetStorageList_maxRecords;
if((inputs.MaxRecords == null)) {
datasetStorageList_maxRecords = model.varLcMaxRecords;
} else {
datasetStorageList_maxRecords = inputs.MaxRecords.Value;
}

int datasetStorageList_startIndex;
if((inputs.StartIndex == null)) {
datasetStorageList_startIndex = model.varLcStartIndex;
} else {
datasetStorageList_startIndex = inputs.StartIndex.Value;
}

if((datasetStorageList_maxRecords < 1)) {
datasetStorageList_maxRecords = 1;
}

AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> ds_output = new AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b>();
long count;
(ds_output.List,count) = await ConectaProveedores_s_Storage_StorageList_ScreenModel.datasetStorageList(requestContext,datasetStorageList_maxRecords,datasetStorageList_startIndex,IterationMultiplicity.Multiple,model.varLcKeyword,model.varLcTableSort,cancellationToken);

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
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="StorageList",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_s_Storage_StorageList_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_s_Storage_StorageList_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceResendFailedFile")]
[RESTScreenServicesActionProperties(Name="ServiceResendFailedFile",Screen="StorageList",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceResendFailedFile(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "w7FMHtvNoghffd8K+BvcMg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Model inputs = null;
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

try {inputs = RESTConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await ServiceAPIs.ServiceAPIServiceResendFailedFile(requestContext,inputs.inParamStorageId,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
