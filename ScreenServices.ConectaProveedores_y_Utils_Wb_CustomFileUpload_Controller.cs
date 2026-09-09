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
[Route("screenservices/ConectaProveedores/y_Utils/Wb_CustomFileUpload")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*Base64ToBinary*/"6dONWMH_kUW9Ti9X5sMIKA*_fNZGfO6DUWDgS6nsO4fzA", 
/*TelcelStorage.ServiceStorageGetFile*/"P1c8u+QdeUmxego1hLjHsw*5VOP3rgq602qUSrwHm7IqA", 
/*y_Utils.Wb_CustomFileUpload.OnDrop*/"6dONWMH_kUW9Ti9X5sMIKA*fu2yL2k0FEW4I6F8kWQQyw", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*File_Validate*/"6dONWMH_kUW9Ti9X5sMIKA*Ujd8pWm6dE6rpqTaCzRS4A"});

    }

    public ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller(
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
[Route("ServiceAPIServiceStorageGetFile")]
[RESTScreenServicesActionProperties(Name="ServiceStorageGetFile",Screen="Wb_CustomFileUpload",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceStorageGetFile(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KQirY72iTSCacYF0YZ0tgQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Model inputs = null;
byte[] res_outParamo_File = new byte[] {};
string res_outParamo_filename = "";
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

try {inputs = RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res_outParamo_File,res_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,inputs.inParami_StorageId,cancellationToken);

var output = RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_File, res_outParamo_filename);
return output;


    }, cancellationToken);
}
}
