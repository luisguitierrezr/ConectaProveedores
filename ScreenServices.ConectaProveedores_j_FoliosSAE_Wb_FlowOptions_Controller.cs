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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_FlowOptions")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.DropdownNotValid*/"Kn_hixxDWEm4lMd7mIpycQ*Isqu3ObtRUGvjEzTJaoyOw", 
/*OutSystemsUI.DropdownClearValidation*/"Kn_hixxDWEm4lMd7mIpycQ*r2LVGF0gTk2QJHL5f8jtvA"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_Controller(
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
[Route("DataActionGetApprovalProcesses")]
[RESTScreenServicesActionProperties(Name="GetApprovalProcesses",Screen="Wb_FlowOptions",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetApprovalProcesses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wI6dG0Lkf5DSzmdKBEpJuA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_ce09c545b541edeabab89435c34c64f0 outParamApprovalProcessesList;
outParamApprovalProcessesList = await model.DataActionGetApprovalProcesses(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamApprovalProcessesList);
return output;


    }, cancellationToken);
}
}
