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
[Route("screenservices/ConectaProveedores/z_Testing/SpecialCharValidations")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_z_Testing_SpecialCharValidations_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_z_Testing_SpecialCharValidations_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_z_Testing_SpecialCharValidations_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_z_Testing_SpecialCharValidations_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_z_Testing_SpecialCharValidations_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_z_Testing_SpecialCharValidations_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Theme_Layouts_Layout_Top_Menu_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("z_Testing.SpecialCharValidations"), ConectaProveedores_z_Testing_SpecialCharValidations_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        {
bool check;
check = await ExtendedActions.CheckConectaProveedoresRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotConectaProveedoresRoleException( "ConectaProveedores role required");

    }


    static ConectaProveedores_z_Testing_SpecialCharValidations_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*CheckRegexValidation*/"6dONWMH_kUW9Ti9X5sMIKA*OdrA_v2ob0esZ70NCRe_kg", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_z_Testing_SpecialCharValidations_Controller(
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
[Route("ActionCheckRegexValidation")]
[RESTScreenServicesActionProperties(Name="CheckRegexValidation",Screen="SpecialCharValidations",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionCheckRegexValidation(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "gH5pZHiZ_VAmedz3i1hclw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Model inputs = null;
Actions.lcoCheckRegexValidation res =  new Actions.lcoCheckRegexValidation();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamValid = await Actions.ActionCheckRegexValidation(requestContext,inputs.inParamText,cancellationToken);

var output = RESTConectaProveedores_z_Testing_SpecialCharValidations_ActionCheckRegexValidation_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamValid);
return output;


    }, cancellationToken);
}
}
