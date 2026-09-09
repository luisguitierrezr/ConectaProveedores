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
[Route("screenservices/ConectaProveedores/z_TableDownloadsPDF/TableDownloadOrderPDF")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssUltimatePDF.ScreenServices.UltimatePDF_PrintLayout_ScreenToPDF_Controller", "UltimatePDF", childControllers);
SafeAddChildController("ssUltimatePDF.ScreenServices.UltimatePDF_PrintLayout_PrintLayout_Controller", "UltimatePDF", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("z_TableDownloadsPDF.TableDownloadOrderPDF"), ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        return;

    }


    static ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.SetCurrentLocale*/"uXCIR2Atc0+es3zYuZSnNw*RYFw8sBg3EmaGosPH65dzg", 
/*Text.String_Split*/"d6CatvSs3Eu81Z3vgdfdzQ*psMFbiUYiF7iuHuy50Xjkg", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_Controller(
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
[Route("DataActionGetOrders")]
[RESTScreenServicesActionProperties(Name="GetOrders",Screen="TableDownloadOrderPDF",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrders(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "k53IPI7cVYcEiuwxUQocBw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel model = null;
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

try {model = RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_68002bbb4e227fd5533d460e5a56bbd4 outParamList;
outParamList = await model.DataActionGetOrders(requestContext,cancellationToken);

var output = RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionString_Split")]
[RESTScreenServicesActionProperties(Name="String_Split",Screen="TableDownloadOrderPDF",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionString_Split(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KCCQ2PmqBTFATtdp2LjyhQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ActionString_Split_Model inputs = null;
RLTextRecordList res_outParamList = new RLTextRecordList();
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

try {inputs = RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ActionString_Split_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamList = await Actions.ActionString_Split(requestContext,inputs.inParamText,inputs.inParamDelimiters,cancellationToken);

var output = RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ActionString_Split_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamList);
return output;


    }, cancellationToken);
}
}
