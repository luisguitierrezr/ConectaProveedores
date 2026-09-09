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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/NewMassiveFolioSAE")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_LayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_MultiFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_d_Invoices_wb_AccSelect_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("j_FoliosSAE.NewMassiveFolioSAE"), ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckProveedorRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckFoliosRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotFoliosRoleException( "Folios role required");

    }


    static ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*FolioQMassUpload*/"6dONWMH_kUW9Ti9X5sMIKA*nLs6ShKwmUyP8uqG2z9C7A", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*FolioMassCreate*/"6dONWMH_kUW9Ti9X5sMIKA*1A8AXRG7AUOC0m0wk3JA5w", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*DowloadExcelTemplateFolioQ*/"6dONWMH_kUW9Ti9X5sMIKA*+QKt3+Iew0qNVFRAbQ+3fw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_Controller(
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
[Route("DataActionGetSupplierName")]
[RESTScreenServicesActionProperties(Name="GetSupplierName",Screen="NewMassiveFolioSAE",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSupplierName(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "LF7GgcFJOqCWLV1LroExSg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamSupplierName;
outParamSupplierName = await model.DataActionGetSupplierName(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamSupplierName);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="NewMassiveFolioSAE",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioMassCreate")]
[RESTScreenServicesActionProperties(Name="FolioMassCreate",Screen="NewMassiveFolioSAE",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioMassCreate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9UZJj9OlptFnrPFljMxvgQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Model inputs = null;
Actions.lcoFolioMassCreate res =  new Actions.lcoFolioMassCreate();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMsg = await Actions.ActionFolioMassCreate(requestContext,inputs.inParamFolioQList,inputs.inParamFilesList,inputs.inParamOrderAccConceptID,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioQMassUpload")]
[RESTScreenServicesActionProperties(Name="FolioQMassUpload",Screen="NewMassiveFolioSAE",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioQMassUpload(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "6QL8fT57pPcuUYumB9f+lg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioQMassUpload_Model inputs = null;
Actions.lcoFolioQMassUpload res =  new Actions.lcoFolioQMassUpload();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioQMassUpload_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamFolioQList,res.outParamNumberOfRecords,res.outParamNumberOfErros,res.outParamOrderNumber,res.outParamErrorMsg) = await Actions.ActionFolioQMassUpload(requestContext,inputs.inParamFilesList,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioQMassUpload_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamFolioQList, res.outParamNumberOfRecords, res.outParamNumberOfErros, res.outParamOrderNumber, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionDowloadExcelTemplateFolioQ")]
[RESTScreenServicesActionProperties(Name="DowloadExcelTemplateFolioQ",Screen="NewMassiveFolioSAE",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDowloadExcelTemplateFolioQ(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "TUnll4bAhaf_SIU88w9Ddw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        Actions.lcoDowloadExcelTemplateFolioQ res =  new Actions.lcoDowloadExcelTemplateFolioQ();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}


// 
res.outParamo_File = await Actions.ActionDowloadExcelTemplateFolioQ(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionDowloadExcelTemplateFolioQ_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_File);
return output;


    }, cancellationToken);
}
}
