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
[Route("screenservices/ConectaProveedores/e_OrdersRequestFiles/Wb_UploadComplementFile")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*UploadDocumentOrderByProvider*/"6dONWMH_kUW9Ti9X5sMIKA*pXJrihcSKkOjeB7b02OjDw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA"});

    }

    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_Controller(
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
[Route("ActionUploadDocumentOrderByProvider")]
[RESTScreenServicesActionProperties(Name="UploadDocumentOrderByProvider",Screen="Wb_UploadComplementFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUploadDocumentOrderByProvider(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "V9aS3b8q1DPn7uSzjgz86A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_ActionUploadDocumentOrderByProvider_Model inputs = null;
Actions.lcoUploadDocumentOrderByProvider res =  new Actions.lcoUploadDocumentOrderByProvider();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_ActionUploadDocumentOrderByProvider_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamInvoiceId,res.outParamStorageId) = await Actions.ActionUploadDocumentOrderByProvider(requestContext,inputs.inParami_RequestFileId,inputs.inParami_OrderMainId,inputs.inParamI_FilesList,inputs.inParami_FilesListExtra,inputs.inParami_InvoiceForeign,inputs.inParami_OrderAccConceptsId,inputs.inParami_CreateRequestFile,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_ActionUploadDocumentOrderByProvider_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamInvoiceId, res.outParamStorageId);
return output;


    }, cancellationToken);
}
}
