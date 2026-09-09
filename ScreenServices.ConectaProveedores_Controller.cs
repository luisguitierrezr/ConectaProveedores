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
[Route("screenservices/ConectaProveedores")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_Controller.GetDbBinaryConfigs(); }
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

                
                InitPermissionIndexes(Permissions, childControllers);
                Permissions.AddAsyncAnonymousCheckPermission(ScreenName.AnyScreen, new String[] { 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler" });
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        
        return dbBinaryConfigs;
    }



    static ConectaProveedores_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* GenerateReqName */"6dONWMH_kUW9Ti9X5sMIKA*jq+KV2KWK0mQFOjXHydjgA", new String[] { 
/*GenerateReqName*/"6dONWMH_kUW9Ti9X5sMIKA*7WuhkoA+OkC0bKiD5hD4mg"});
Permissions.AddPermissionPropagationPath(/* IsListValid */"6dONWMH_kUW9Ti9X5sMIKA*ZuXse6dFR0iq6XH7XGDQmA", new String[] { 
/*System_.ListAny*/"uXCIR2Atc0+es3zYuZSnNw*qehi1YDm00iCdB5+VDfk+A"});
Permissions.AddPermissionPropagationPath(/* File_Validate */"6dONWMH_kUW9Ti9X5sMIKA*Ujd8pWm6dE6rpqTaCzRS4A", new String[] { 
/*ValidateFileSize*/"6dONWMH_kUW9Ti9X5sMIKA*P_Z51v60NUSyVPYMVHOeiw", 
/*ValidateFileType*/"6dONWMH_kUW9Ti9X5sMIKA*FzGx3gA8RE24dlhjN8_9Wg"});
Permissions.AddPermissionPropagationPath(/* DoLogin */"6dONWMH_kUW9Ti9X5sMIKA*oE5exNPdc06r_LpDr31atw", new String[] { 
/*System_.Login*/"uXCIR2Atc0+es3zYuZSnNw*KZ98R8U2qUK5ED5dcMdCfg", 
/*SendLoginAlert*/"6dONWMH_kUW9Ti9X5sMIKA*prFeeY6MG0yAknj3FesStw"});
Permissions.AddPermissionPropagationPath(/* GetFileChunk */"6dONWMH_kUW9Ti9X5sMIKA*13jKyj2XnUCd+cBCoSv3SQ", new String[] { 
/*TelcelStorage.ServiceStorageGetFileByParts*/"P1c8u+QdeUmxego1hLjHsw*Cd7kTlnu6EOQahLzG81C1A"});
Permissions.AddPermissionPropagationPath(/* GetUserRegion */"6dONWMH_kUW9Ti9X5sMIKA*GfYo_CRmik2P_adc_RCpsA", new String[] { 
/*GetUserRegionId*/"6dONWMH_kUW9Ti9X5sMIKA*+8thEyCBDUuEi6cAWg9RGw"});
Permissions.AddPermissionPropagationPath(/* a_Common.OnException */"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler", new String[] { 
/*System_.Logout*/"uXCIR2Atc0+es3zYuZSnNw*GjysQf3fT0uswPpDmpdWAQ", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA"});

    }

    public ConectaProveedores_Controller(
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
[Route("ActionGenerateReqName")]
[RESTScreenServicesActionProperties(Name="GenerateReqName",Screen="ConectaProveedores",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGenerateReqName(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "cRTbA+D73Mh15dOFKbk6xg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_ActionGenerateReqName_Model inputs = null;
Actions.lcoGenerateReqName res =  new Actions.lcoGenerateReqName();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, "6dONWMH_kUW9Ti9X5sMIKA*7WuhkoA+OkC0bKiD5hD4mg", out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), "6dONWMH_kUW9Ti9X5sMIKA*7WuhkoA+OkC0bKiD5hD4mg", out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_ActionGenerateReqName_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Name,res.outParamo_Counter) = await Actions.ActionGenerateReqName(requestContext,inputs.inParami_RegionId,cancellationToken);

var output = RESTConectaProveedores_ActionGenerateReqName_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Name, res.outParamo_Counter);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionSendLoginAlert")]
[RESTScreenServicesActionProperties(Name="SendLoginAlert",Screen="ConectaProveedores",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionSendLoginAlert(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "01EvpqiB+5Vj8CbesQdDGw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_ActionSendLoginAlert_Model inputs = null;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, "6dONWMH_kUW9Ti9X5sMIKA*prFeeY6MG0yAknj3FesStw", out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), "6dONWMH_kUW9Ti9X5sMIKA*prFeeY6MG0yAknj3FesStw", out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_ActionSendLoginAlert_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionSendLoginAlert(requestContext,inputs.inParamUsername,inputs.inParamEnvironment,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPIServiceStorageGetFileByParts")]
[RESTScreenServicesActionProperties(Name="ServiceStorageGetFileByParts",Screen="ConectaProveedores",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPIServiceStorageGetFileByParts(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Vp6_dh1Cmm3j52pTGr+pBQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Model inputs = null;
byte[] res_outParamo_File = new byte[] {};
string res_outParamo_filename = "";
string res_outParamo_fileInText = "";
bool res_outParamIsBinary = false;
CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, "P1c8u+QdeUmxego1hLjHsw*Cd7kTlnu6EOQahLzG81C1A", out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), "P1c8u+QdeUmxego1hLjHsw*Cd7kTlnu6EOQahLzG81C1A", out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res_outParamo_File,res_outParamo_filename,res_outParamo_fileInText,res_outParamIsBinary) = await ServiceAPIs.ServiceAPIServiceStorageGetFileByParts(requestContext,inputs.inParami_StorageId,inputs.inParami_ChunkNumber,inputs.inParami_TotalChunks,inputs.inParami_Guid,cancellationToken);

var output = RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamo_File, res_outParamo_filename, res_outParamo_fileInText, res_outParamIsBinary);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetUserRegionId")]
[RESTScreenServicesActionProperties(Name="GetUserRegionId",Screen="ConectaProveedores",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetUserRegionId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "eZ_gO_yW0xiFjgXIIvaL_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_ActionGetUserRegionId_Model inputs = null;
Actions.lcoGetUserRegionId res =  new Actions.lcoGetUserRegionId();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, "6dONWMH_kUW9Ti9X5sMIKA*+8thEyCBDUuEi6cAWg9RGw", out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), "6dONWMH_kUW9Ti9X5sMIKA*+8thEyCBDUuEi6cAWg9RGw", out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_ActionGetUserRegionId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_ActionGetUserRegionId_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_RegionId);
return output;


    }, cancellationToken);
}
}
