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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Submenu_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_PopupApprove_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ConfirmPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_k_Deviations_Wb_CompleteEntry_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_CancelFolioPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_Controller.ProxyInstance, childControllers);
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



    static ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*j_FoliosSAE.Wb_FolioActions.ApproveRejectFolio*/"6dONWMH_kUW9Ti9X5sMIKA*AocpE9OV1UKnRkDqH9ooww", 
/*j_FoliosSAE.Wb_FolioActions.EvidenceRequestFolio*/"6dONWMH_kUW9Ti9X5sMIKA*RZaTFnNNh0CaJ0AWoj2Tpw", 
/*ApprovRejectFolio*/"6dONWMH_kUW9Ti9X5sMIKA*aXEDKzKy_U688DJ6Wq5z5g", 
/*FolioResendEntry*/"6dONWMH_kUW9Ti9X5sMIKA*Q+RtQ0_fokmh1TOp9qIs9Q", 
/*j_FoliosSAE.Wb_FolioActions.CommentFolio*/"6dONWMH_kUW9Ti9X5sMIKA*W7GxS84EoUyBIMChZlt0wA", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*j_FoliosSAE.Wb_FolioActions.ResendEntryFolio*/"6dONWMH_kUW9Ti9X5sMIKA*vEFZU9ezMEqF+2tsnK7KfA", 
/*OutSystemsUI.SubmenuClose*/"Kn_hixxDWEm4lMd7mIpycQ*pZoGL7rcFk+2JW+vKUQyfA", 
/*j_FoliosSAE.Wb_FolioActions.CancelFolio*/"6dONWMH_kUW9Ti9X5sMIKA*X5huby3RkkiOII00S07Z5Q", 
/*FolioComment*/"6dONWMH_kUW9Ti9X5sMIKA*yay1iV5rTEy7G5+lMh+zZA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*FolioCancelFromApprover*/"6dONWMH_kUW9Ti9X5sMIKA*6ogNoA+BwkyfA7IQsxiBdQ", 
/*FolioEvidenceRequest*/"6dONWMH_kUW9Ti9X5sMIKA*6dGk0gEZRkWxpYn_HRhUPg", 
/*FolioCancelFromAlmacen*/"6dONWMH_kUW9Ti9X5sMIKA*q2fU+z7vvkaBdExy+FNA7g"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_Controller(
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
[Route("ScreenDataSetGetFolioApprovalLevelById")]
[RESTScreenServicesActionProperties(Name="GetFolioApprovalLevelById",Screen="Wb_FolioActions",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioApprovalLevelById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "lF8JS11150jvsCDoN4i47g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioApprovalLevelById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioApprovalLevelById_maxRecords = 1;
} else {
datasetGetFolioApprovalLevelById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioApprovalLevelById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioApprovalLevelById_startIndex = 0;
} else {
datasetGetFolioApprovalLevelById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioApprovalLevelById_maxRecords < 1)) {
datasetGetFolioApprovalLevelById_maxRecords = 1;
}

AggregateRecord<RL_eed3c87ea3369e022265db9ef075a8c7> ds_output = new AggregateRecord<RL_eed3c87ea3369e022265db9ef075a8c7>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel.datasetGetFolioApprovalLevelById(requestContext,datasetGetFolioApprovalLevelById_maxRecords,datasetGetFolioApprovalLevelById_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckDesviacionesRole(requestContext,"",cancellationToken)),(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),model.varLcGetUserApplicationRoles.outParamEntraRolesListText,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),2,true,false,cancellationToken)),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),2,true,false,cancellationToken)),(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),model.inParami_FolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_e278706027049cb67d7e751f6d362f51>(ssConectaProveedores.RestRecords.RESTRC_e278706027049cb67d7e751f6d362f51.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetFolioTypeDA")]
[RESTScreenServicesActionProperties(Name="GetFolioTypeDA",Screen="Wb_FolioActions",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetFolioTypeDA(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "pVuYOEMQMtrZvtnPx4Y7mw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamo_ShowOptions;
bool outParamo_IsActiveDEV_HU13045;
(outParamo_ShowOptions,outParamo_IsActiveDEV_HU13045) = await model.DataActionGetFolioTypeDA(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_ShowOptions, outParamo_IsActiveDEV_HU13045);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserInfo")]
[RESTScreenServicesActionProperties(Name="GetUserInfo",Screen="Wb_FolioActions",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserInfo(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "BWQfTfvpsgByzN7d7Xpo3A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsAllowedCancelFolio;
bool outParamIsAllowedReassign;
(outParamIsAllowedCancelFolio,outParamIsAllowedReassign) = await model.DataActionGetUserInfo(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsAllowedCancelFolio, outParamIsAllowedReassign);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="Wb_FolioActions",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Em4eq0ND_srkNxUcMKHmYA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamAppRoleListText;
string outParamEntraRolesListText;
(outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText) = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamAppRoleListText, outParamEntraRolesListText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionApprovRejectFolio")]
[RESTScreenServicesActionProperties(Name="ApprovRejectFolio",Screen="Wb_FolioActions",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApprovRejectFolio(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3lMt9PSpF_QXCgb0Q9x67w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Model inputs = null;
Actions.lcoApprovRejectFolio res =  new Actions.lcoApprovRejectFolio();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionApprovRejectFolio(requestContext,inputs.inParami_FolioId,inputs.inParami_FolioApprovalLevelId,inputs.inParami_IsApprove,inputs.inParami_Comment,inputs.inParamOffsetUtc,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionApprovRejectFolio_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioEvidenceRequest")]
[RESTScreenServicesActionProperties(Name="FolioEvidenceRequest",Screen="Wb_FolioActions",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioEvidenceRequest(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9AgLlP1GuLrYTvF7YC2zyQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioEvidenceRequest_Model inputs = null;
Actions.lcoFolioEvidenceRequest res =  new Actions.lcoFolioEvidenceRequest();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioEvidenceRequest_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionFolioEvidenceRequest(requestContext,inputs.inParami_FolioId,inputs.inParami_FolioApprovalLevelId,inputs.inParami_Comment,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioEvidenceRequest_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioComment")]
[RESTScreenServicesActionProperties(Name="FolioComment",Screen="Wb_FolioActions",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioComment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "BYpQxJkd7IP+1fF9sSUsoQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioComment_Model inputs = null;
Actions.lcoFolioComment res =  new Actions.lcoFolioComment();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioComment_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionFolioComment(requestContext,inputs.inParami_FolioId,inputs.inParami_FolioApprovalLevelId,inputs.inParami_Comment,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioComment_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioResendEntry")]
[RESTScreenServicesActionProperties(Name="FolioResendEntry",Screen="Wb_FolioActions",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioResendEntry(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Uvyersp6iOL1ZWrsJ+RR0A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Model inputs = null;
Actions.lcoFolioResendEntry res =  new Actions.lcoFolioResendEntry();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionFolioResendEntry(requestContext,inputs.inParami_FolioId,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioResendEntry_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioCancelFromApprover")]
[RESTScreenServicesActionProperties(Name="FolioCancelFromApprover",Screen="Wb_FolioActions",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioCancelFromApprover(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "aq_w99nG9UUaC__cmsK4LA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromApprover_Model inputs = null;
Actions.lcoFolioCancelFromApprover res =  new Actions.lcoFolioCancelFromApprover();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromApprover_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionFolioCancelFromApprover(requestContext,inputs.inParami_FolioId,inputs.inParami_FolioApprovalLevelId,inputs.inParami_CancelReason,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromApprover_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioCancelFromAlmacen")]
[RESTScreenServicesActionProperties(Name="FolioCancelFromAlmacen",Screen="Wb_FolioActions",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioCancelFromAlmacen(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "_5HCI8sqPhlNg+JpFviiuw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Model inputs = null;
Actions.lcoFolioCancelFromAlmacen res =  new Actions.lcoFolioCancelFromAlmacen();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionFolioCancelFromAlmacen(requestContext,inputs.inParami_FolioId,inputs.inParami_CancelReason,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ActionFolioCancelFromAlmacen_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}
}
