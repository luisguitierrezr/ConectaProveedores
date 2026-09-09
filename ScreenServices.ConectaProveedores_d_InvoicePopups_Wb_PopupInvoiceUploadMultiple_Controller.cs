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
[Route("screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadMultiple")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_y_Utils_Wb_MultiFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
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



    static ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*UploadInvoiceFilesMultiple*/"6dONWMH_kUW9Ti9X5sMIKA*4Td0Rg_wNUmlOPSXl3gfCQ", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*ValidateZIPInvoices*/"6dONWMH_kUW9Ti9X5sMIKA*O7Qt9IVHKkqDvkNtA5oIvQ"});

    }

    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_Controller(
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
[Route("DataActionGetInvoicesByRequisitionOrFolio")]
[RESTScreenServicesActionProperties(Name="GetInvoicesByRequisitionOrFolio",Screen="Wb_PopupInvoiceUploadMultiple",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetInvoicesByRequisitionOrFolio(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+5mzVrZaW0x1hOwVdK+6iQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_ff28012de5324af3e81e5ace09ecb1f0 outParamInvoicesList;
outParamInvoicesList = await model.DataActionGetInvoicesByRequisitionOrFolio(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetInvoicesByRequisitionOrFolio_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamInvoicesList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSupplier")]
[RESTScreenServicesActionProperties(Name="GetSupplier",Screen="Wb_PopupInvoiceUploadMultiple",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSupplier(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "1iS_e72X9zgr0D2tjUCYKQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamExpedicionFiscal;
bool outParamIsNational;
string outParamName;
string outParamRFC;
string outParamSociety;
(outParamExpedicionFiscal,outParamIsNational,outParamName,outParamRFC,outParamSociety) = await model.DataActionGetSupplier(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamExpedicionFiscal, outParamIsNational, outParamName, outParamRFC, outParamSociety);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionValidateZIPInvoices")]
[RESTScreenServicesActionProperties(Name="ValidateZIPInvoices",Screen="Wb_PopupInvoiceUploadMultiple",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionValidateZIPInvoices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "H_Veye90wmWbWmS8rwLNrw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ActionValidateZIPInvoices_Model inputs = null;
Actions.lcoValidateZIPInvoices res =  new Actions.lcoValidateZIPInvoices();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ActionValidateZIPInvoices_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamMultiUploadInvoiceFileStruct = await Actions.ActionValidateZIPInvoices(requestContext,inputs.inParami_File,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ActionValidateZIPInvoices_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamMultiUploadInvoiceFileStruct);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionUploadInvoiceFilesMultiple")]
[RESTScreenServicesActionProperties(Name="UploadInvoiceFilesMultiple",Screen="Wb_PopupInvoiceUploadMultiple",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUploadInvoiceFilesMultiple(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+dvOmjQ2E0nvA84QUnSsRQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ActionUploadInvoiceFilesMultiple_Model inputs = null;
Actions.lcoUploadInvoiceFilesMultiple res =  new Actions.lcoUploadInvoiceFilesMultiple();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ActionUploadInvoiceFilesMultiple_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamError_MultiUploadInvoiceFileStructList = await Actions.ActionUploadInvoiceFilesMultiple(requestContext,inputs.inParamInvoiceId,inputs.inParamRequisitionId,inputs.inParamOrderMainId,inputs.inParamFolioId,inputs.inParamMultiUploadInvoiceFileStructList,inputs.inParamIsStartApproval,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_ActionUploadInvoiceFilesMultiple_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamError_MultiUploadInvoiceFileStructList);
return output;


    }, cancellationToken);
}
}
