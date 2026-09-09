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
[Route("screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_PositionContact")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*CreatePositionContacts*/"6dONWMH_kUW9Ti9X5sMIKA*zfU_dfinkEWe_OezDJiRTg"});

    }

    public ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_Controller(
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
[Route("ScreenDataSetGetAllPositionContacts")]
[RESTScreenServicesActionProperties(Name="GetAllPositionContacts",Screen="Wb_PositionContact",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAllPositionContacts(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wpfNTrafz_bGDojN_KNHRw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel model = null;
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

try {model = RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAllPositionContacts_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAllPositionContacts_maxRecords = 999999;
} else {
datasetGetAllPositionContacts_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetAllPositionContacts_startIndex;
if((inputs.StartIndex == null)) {
datasetGetAllPositionContacts_startIndex = 0;
} else {
datasetGetAllPositionContacts_startIndex = inputs.StartIndex.Value;
}

if((datasetGetAllPositionContacts_maxRecords < 1)) {
datasetGetAllPositionContacts_maxRecords = 1;
}

AggregateRecord<RL_084ec93001d810170970c8007b50b58f> ds_output = new AggregateRecord<RL_084ec93001d810170970c8007b50b58f>();
long count;
(ds_output.List,count) = await ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel.datasetGetAllPositionContacts(requestContext,datasetGetAllPositionContacts_maxRecords,datasetGetAllPositionContacts_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d>(ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetPositionContactsById")]
[RESTScreenServicesActionProperties(Name="GetPositionContactsById",Screen="Wb_PositionContact",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPositionContactsById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ju+y4xm25OCvD52om7KlDA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel model = null;
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

try {model = RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPositionContactsById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPositionContactsById_maxRecords = 1;
} else {
datasetGetPositionContactsById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetPositionContactsById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetPositionContactsById_startIndex = 0;
} else {
datasetGetPositionContactsById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetPositionContactsById_maxRecords < 1)) {
datasetGetPositionContactsById_maxRecords = 1;
}

AggregateRecord<RL_084ec93001d810170970c8007b50b58f> ds_output = new AggregateRecord<RL_084ec93001d810170970c8007b50b58f>();
long count;
(ds_output.List,count) = await ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel.datasetGetPositionContactsById(requestContext,datasetGetPositionContactsById_maxRecords,datasetGetPositionContactsById_startIndex,IterationMultiplicity.Multiple,model.inParamPositionContactId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d>(ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionCreatePositionContacts")]
[RESTScreenServicesActionProperties(Name="CreatePositionContacts",Screen="Wb_PositionContact",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionCreatePositionContacts(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "5peYN2H8ZxpuwbQ0PpepfA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ActionCreatePositionContacts_Model inputs = null;
Actions.lcoCreatePositionContacts res =  new Actions.lcoCreatePositionContacts();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ActionCreatePositionContacts_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamLastPositionContractId = await Actions.ActionCreatePositionContacts(requestContext,inputs.inParamPositionContactList,cancellationToken);

var output = RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ActionCreatePositionContacts_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamLastPositionContractId);
return output;


    }, cancellationToken);
}
}
