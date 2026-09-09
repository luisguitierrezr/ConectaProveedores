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
[Route("screenservices/ConectaProveedores/e_Orders/wb_OrderDetail_1Info")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        dbBinaryConfigs["6donwmh_kuw9ti9x5smika*c7laic7clk2ynbzzjjr8rg/importeddata"] = new BinaryContentUtils.DbBinaryConfig(ENOrdersImportRequestEntity.LocalViewName, TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id", 12, false);


        return dbBinaryConfigs;
    }



    static ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GetOrderPdfSAPFile*/"6dONWMH_kUW9Ti9X5sMIKA*MN8uBfz_9Uq4E0o4ha98Lw", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA"});

    }

    public ConectaProveedores_e_Orders_wb_OrderDetail_1Info_Controller(
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
[Route("ScreenDataSetGetOrderById")]
[RESTScreenServicesActionProperties(Name="GetOrderById",Screen="wb_OrderDetail_1Info",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "yhYHZyjDXjCURqQjSq8fAA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderById_maxRecords = 1;
} else {
datasetGetOrderById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderById_startIndex = 0;
} else {
datasetGetOrderById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderById_maxRecords < 1)) {
datasetGetOrderById_maxRecords = 1;
}

AggregateRecord<RL_1ded8df557cc19c3bf639ef70eaf909e> ds_output = new AggregateRecord<RL_1ded8df557cc19c3bf639ef70eaf909e>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Multiple,model.inParamOrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_7001c2850e85d9dc361469a649a88466>(ssConectaProveedores.RestRecords.RESTRC_7001c2850e85d9dc361469a649a88466.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetOrderMainItems")]
[RESTScreenServicesActionProperties(Name="GetOrderMainItems",Screen="wb_OrderDetail_1Info",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrderMainItems(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "46bVi+SzEoyeTKYRdFDSUw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_3e44f5588517fc49ab4a1e35f755766f outParamList;
int outParamCount;
(outParamList,outParamCount) = await model.DataActionGetOrderMainItems(requestContext,cancellationToken);

var output = RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList, outParamCount);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetOrderPdfSAPFile")]
[RESTScreenServicesActionProperties(Name="GetOrderPdfSAPFile",Screen="wb_OrderDetail_1Info",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetOrderPdfSAPFile(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Swo_qDPae1PTe+BzZ+GjUQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Model inputs = null;
Actions.lcoGetOrderPdfSAPFile res =  new Actions.lcoGetOrderPdfSAPFile();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamBinary = await Actions.ActionGetOrderPdfSAPFile(requestContext,inputs.inParamOrderNumber,cancellationToken);

var output = RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ActionGetOrderPdfSAPFile_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamBinary);
return output;


    }, cancellationToken);
}
}
