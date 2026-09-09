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
[Route("screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceAssignFirstApprover")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_ButtonLoading_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*d_InvoicePopups.Wb_PopupInvoiceAssignFirstApprover.OnParametersChanged*/"6dONWMH_kUW9Ti9X5sMIKA*_eVUGQ_5dkeWM6ur8hGZhQ", 
/*ConfirmAssignFirstApprover*/"6dONWMH_kUW9Ti9X5sMIKA*UFz4ubxbe0+8tlHs5UI7rA"});

    }

    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_Controller(
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
[Route("ScreenDataSetGetUserById")]
[RESTScreenServicesActionProperties(Name="GetUserById",Screen="Wb_PopupInvoiceAssignFirstApprover",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "5MUCicGi7JYLp5_TVO295g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserById_maxRecords = 99999;
} else {
datasetGetUserById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserById_startIndex = 0;
} else {
datasetGetUserById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserById_maxRecords < 1)) {
datasetGetUserById_maxRecords = 1;
}

AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> ds_output = new AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ScreenModel.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserTelcelDirectionId(requestContext,"",cancellationToken)),((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363>(ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionConfirmAssignFirstApprover")]
[RESTScreenServicesActionProperties(Name="ConfirmAssignFirstApprover",Screen="Wb_PopupInvoiceAssignFirstApprover",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionConfirmAssignFirstApprover(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "54Xh55dSkC8qGijXLIHiXA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Model inputs = null;
Actions.lcoConfirmAssignFirstApprover res =  new Actions.lcoConfirmAssignFirstApprover();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionConfirmAssignFirstApprover(requestContext,inputs.inParami_InvoiceId,inputs.inParami_UserId,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignFirstApprover_ActionConfirmAssignFirstApprover_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}
}
