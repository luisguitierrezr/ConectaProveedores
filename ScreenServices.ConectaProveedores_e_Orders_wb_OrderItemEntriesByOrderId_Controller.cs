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
[Route("screenservices/ConectaProveedores/e_Orders/wb_OrderItemEntriesByOrderId")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_Controller(
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
[Route("ScreenDataSetGetOrderItemEntriesByOrderMainItemid")]
[RESTScreenServicesActionProperties(Name="GetOrderItemEntriesByOrderMainItemid",Screen="wb_OrderItemEntriesByOrderId",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderItemEntriesByOrderMainItemid(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "RFG+FrGRuw4CzfQImE5PhQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderItemEntriesByOrderMainItemid_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderItemEntriesByOrderMainItemid_maxRecords = model.varLcMaxRecords;
} else {
datasetGetOrderItemEntriesByOrderMainItemid_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderItemEntriesByOrderMainItemid_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderItemEntriesByOrderMainItemid_startIndex = model.varLcStartIndex;
} else {
datasetGetOrderItemEntriesByOrderMainItemid_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderItemEntriesByOrderMainItemid_maxRecords < 1)) {
datasetGetOrderItemEntriesByOrderMainItemid_maxRecords = 1;
}

AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> ds_output = new AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel.datasetGetOrderItemEntriesByOrderMainItemid(requestContext,datasetGetOrderItemEntriesByOrderMainItemid_maxRecords,datasetGetOrderItemEntriesByOrderMainItemid_startIndex,IterationMultiplicity.Multiple,model.inParamOrderMainId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb>(ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
