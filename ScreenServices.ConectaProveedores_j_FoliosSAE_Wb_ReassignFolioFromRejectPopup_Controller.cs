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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_ReassignFolioFromRejectPopup")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*FolioReassignFromReject*/"6dONWMH_kUW9Ti9X5sMIKA*NojZQWvdmkioFHx7BKeBYw", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller(
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
[Route("ScreenDataSetGetApprovalProcessTypes")]
[RESTScreenServicesActionProperties(Name="GetApprovalProcessTypes",Screen="Wb_ReassignFolioFromRejectPopup",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalProcessTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "WHEf6WnBa2d2sGKbjgyTUw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetApprovalProcessTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetApprovalProcessTypes_maxRecords = 50;
} else {
datasetGetApprovalProcessTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetApprovalProcessTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetApprovalProcessTypes_startIndex = 0;
} else {
datasetGetApprovalProcessTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetApprovalProcessTypes_maxRecords < 1)) {
datasetGetApprovalProcessTypes_maxRecords = 1;
}

AggregateRecord<RL_aa462092dd42df329d9d5474c2d56c53> ds_output = new AggregateRecord<RL_aa462092dd42df329d9d5474c2d56c53>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel.datasetGetApprovalProcessTypes(requestContext,datasetGetApprovalProcessTypes_maxRecords,datasetGetApprovalProcessTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc>(ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioReassignFromReject")]
[RESTScreenServicesActionProperties(Name="FolioReassignFromReject",Screen="Wb_ReassignFolioFromRejectPopup",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioReassignFromReject(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "IadkMh6CoRt6YkDweLS+Yg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Model inputs = null;
Actions.lcoFolioReassignFromReject res =  new Actions.lcoFolioReassignFromReject();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionFolioReassignFromReject(requestContext,inputs.inParami_FolioId,inputs.inParami_AssignUserId,inputs.inParami_AssignApprovalProcessId,inputs.inParami_Comment,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ActionFolioReassignFromReject_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}
}
