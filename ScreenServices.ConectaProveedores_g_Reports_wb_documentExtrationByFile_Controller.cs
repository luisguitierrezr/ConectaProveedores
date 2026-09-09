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
[Route("screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController(ConectaProveedores_g_Reports_Wb_PreviewFile_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_s_Storage_wb_DownloadFile_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*DownloadDocument*/"6dONWMH_kUW9Ti9X5sMIKA*6VXgA+nhtUCDrAzEhax8Dg", 
/*FindByDateRanges*/"6dONWMH_kUW9Ti9X5sMIKA*bef4BWW2lk6fDhScur9FfA", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*FindByUUID*/"6dONWMH_kUW9Ti9X5sMIKA*cnNGV1hhvUO1paMXcIQyBg", 
/*TelcelStorage.ServiceGetDocumentsByListId*/"P1c8u+QdeUmxego1hLjHsw*P7EZ_SGoyUOsV0t7PhN36Q", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*FindByAccount*/"6dONWMH_kUW9Ti9X5sMIKA*imHeteBv3km2+D01k4AgCw", 
/*FindBySupplier*/"6dONWMH_kUW9Ti9X5sMIKA*3eSzttawIEG8vqcQMBUolA", 
/*FindByPeriod*/"6dONWMH_kUW9Ti9X5sMIKA*uCJIvE2gR0aDB0cl8b1LGA"});

    }

    public ConectaProveedores_g_Reports_wb_documentExtrationByFile_Controller(
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
[Route("ActionFindBySupplier")]
[RESTScreenServicesActionProperties(Name="FindBySupplier",Screen="wb_documentExtrationByFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFindBySupplier(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wLf5C86IyLvlN4paF8qkdQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindBySupplier_Model inputs = null;
Actions.lcoFindBySupplier res =  new Actions.lcoFindBySupplier();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindBySupplier_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamList,res.outParamreturn) = await Actions.ActionFindBySupplier(requestContext,inputs.inParamfile,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindBySupplier_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamList, res.outParamreturn);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFindByAccount")]
[RESTScreenServicesActionProperties(Name="FindByAccount",Screen="wb_documentExtrationByFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFindByAccount(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7U8Powbyk+8PkcWxr3ez2Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByAccount_Model inputs = null;
Actions.lcoFindByAccount res =  new Actions.lcoFindByAccount();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByAccount_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamList,res.outParamreturn) = await Actions.ActionFindByAccount(requestContext,inputs.inParamfile,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByAccount_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamList, res.outParamreturn);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFindByPeriod")]
[RESTScreenServicesActionProperties(Name="FindByPeriod",Screen="wb_documentExtrationByFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFindByPeriod(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "VVFcyfSrkN2dTNXtshQnRw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByPeriod_Model inputs = null;
Actions.lcoFindByPeriod res =  new Actions.lcoFindByPeriod();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByPeriod_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamList,res.outParamreturn) = await Actions.ActionFindByPeriod(requestContext,inputs.inParamfile,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByPeriod_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamList, res.outParamreturn);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFindByUUID")]
[RESTScreenServicesActionProperties(Name="FindByUUID",Screen="wb_documentExtrationByFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFindByUUID(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "T4d_eazlsKJX44gnqpagnA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByUUID_Model inputs = null;
Actions.lcoFindByUUID res =  new Actions.lcoFindByUUID();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByUUID_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamList,res.outParamreturn) = await Actions.ActionFindByUUID(requestContext,inputs.inParamfile,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByUUID_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamList, res.outParamreturn);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFindByDateRanges")]
[RESTScreenServicesActionProperties(Name="FindByDateRanges",Screen="wb_documentExtrationByFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFindByDateRanges(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "zvqu7ScuqJhNORyIIVqVdQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Model inputs = null;
Actions.lcoFindByDateRanges res =  new Actions.lcoFindByDateRanges();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamList,res.outParamreturn) = await Actions.ActionFindByDateRanges(requestContext,inputs.inParamfile,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamList, res.outParamreturn);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceGetDocumentsByListId")]
[RESTScreenServicesActionProperties(Name="ServiceGetDocumentsByListId",Screen="wb_documentExtrationByFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceGetDocumentsByListId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "B_km2SQBw90cnqn+1+_34g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByFile_ServiceAPIServiceGetDocumentsByListId_Model inputs = null;
byte[] res_outParamBinaryZip = new byte[] {};
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

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ServiceAPIServiceGetDocumentsByListId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamBinaryZip = await ServiceAPIs.ServiceAPIServiceGetDocumentsByListId(requestContext,inputs.inParamIdsList,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ServiceAPIServiceGetDocumentsByListId_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamBinaryZip);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionDownloadDocument")]
[RESTScreenServicesActionProperties(Name="DownloadDocument",Screen="wb_documentExtrationByFile",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDownloadDocument(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ODSQMjQA_euNhJ6jbgFiJg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Model inputs = null;
Actions.lcoDownloadDocument res =  new Actions.lcoDownloadDocument();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_file,res.outParamo_filename) = await Actions.ActionDownloadDocument(requestContext,inputs.inParami_Type,cancellationToken);

var output = RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_file, res.outParamo_filename);
return output;


    }, cancellationToken);
}
}
