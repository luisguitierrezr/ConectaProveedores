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
[Route("screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsPreviewIcons")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*GetRequisitionFiles*/"6dONWMH_kUW9Ti9X5sMIKA*CXoP1t5DnUKfd2O67suHuw", 
/*CheckFiles*/"6dONWMH_kUW9Ti9X5sMIKA*aha85Do5kE+aS5nAgkLvqg"});

    }

    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_Controller(
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
[Route("ScreenDataSetRequisitionFilesById")]
[RESTScreenServicesActionProperties(Name="RequisitionFilesById",Screen="Wb_RequisitionsPreviewIcons",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetRequisitionFilesById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "53h1wwY_frmIXfERFQzpoA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetRequisitionFilesById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetRequisitionFilesById_maxRecords = 1;
} else {
datasetRequisitionFilesById_maxRecords = inputs.MaxRecords.Value;
}

int datasetRequisitionFilesById_startIndex;
if((inputs.StartIndex == null)) {
datasetRequisitionFilesById_startIndex = 0;
} else {
datasetRequisitionFilesById_startIndex = inputs.StartIndex.Value;
}

if((datasetRequisitionFilesById_maxRecords < 1)) {
datasetRequisitionFilesById_maxRecords = 1;
}

AggregateRecord<RL_dcf9165e080aea63f7a9b95efcf09ef4> ds_output = new AggregateRecord<RL_dcf9165e080aea63f7a9b95efcf09ef4>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel.datasetRequisitionFilesById(requestContext,datasetRequisitionFilesById_maxRecords,datasetRequisitionFilesById_startIndex,IterationMultiplicity.Multiple,model.inParamRequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c>(ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionGetRequisitionFiles")]
[RESTScreenServicesActionProperties(Name="GetRequisitionFiles",Screen="Wb_RequisitionsPreviewIcons",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetRequisitionFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "uIKXJU1zGFJnswURU5zOTA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionGetRequisitionFiles_Model inputs = null;
Actions.lcoGetRequisitionFiles res =  new Actions.lcoGetRequisitionFiles();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionGetRequisitionFiles_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamBinaryZIP,res.outParamErrorMsg) = await Actions.ActionGetRequisitionFiles(requestContext,inputs.inParamRequisitionId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionGetRequisitionFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamBinaryZIP, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionCheckFiles")]
[RESTScreenServicesActionProperties(Name="CheckFiles",Screen="Wb_RequisitionsPreviewIcons",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionCheckFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7NkPYBX1SWRoow8xeWADmw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Model inputs = null;
Actions.lcoCheckFiles res =  new Actions.lcoCheckFiles();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamO_ErrorMessage = await Actions.ActionCheckFiles(requestContext,inputs.inParamRequisitionId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamO_ErrorMessage);
return output;


    }, cancellationToken);
}
}
