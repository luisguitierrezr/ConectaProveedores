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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_ReassignFolio")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_SupplierName_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ConfirmPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*FolioReassignGeneral*/"6dONWMH_kUW9Ti9X5sMIKA*h1+PlPvdBEiJDMeaGQZitw", 
/*j_FoliosSAE.Wb_ReassignFolio.Wb_ConfirmPopupClose*/"6dONWMH_kUW9Ti9X5sMIKA*YLga9EYie0SZKVDwc1Ktkw"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_Controller(
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
[Route("ScreenDataSetGetFolioApprovalLevelsByAssignedTo")]
[RESTScreenServicesActionProperties(Name="GetFolioApprovalLevelsByAssignedTo",Screen="Wb_ReassignFolio",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioApprovalLevelsByAssignedTo(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9TbeEhXx0NXYOqN1wsI+eg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioApprovalLevelsByAssignedTo_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioApprovalLevelsByAssignedTo_maxRecords = model.varLcMaxRecords;
} else {
datasetGetFolioApprovalLevelsByAssignedTo_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioApprovalLevelsByAssignedTo_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioApprovalLevelsByAssignedTo_startIndex = model.varLcStartIndex;
} else {
datasetGetFolioApprovalLevelsByAssignedTo_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioApprovalLevelsByAssignedTo_maxRecords < 1)) {
datasetGetFolioApprovalLevelsByAssignedTo_maxRecords = 1;
}

AggregateRecord<RL_c18f46fc1b14374364595e3e32a1c4d4> ds_output = new AggregateRecord<RL_c18f46fc1b14374364595e3e32a1c4d4>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel.datasetGetFolioApprovalLevelsByAssignedTo(requestContext,datasetGetFolioApprovalLevelsByAssignedTo_maxRecords,datasetGetFolioApprovalLevelsByAssignedTo_startIndex,IterationMultiplicity.Multiple,model.varLcGetUserApplicationRoles.outParamAppRoleListText,model.varLcGetUserApplicationRoles.outParamEntraRolesListText,(await Functions.ActionGetUserDepartmentId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.inParami_IsInvoiceApproval,model.varLcl_SourceUserId,model.varLcTableSort,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_6441282eac0a2260326cac952b2cda40>(ssConectaProveedores.RestRecords.RESTRC_6441282eac0a2260326cac952b2cda40.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="Wb_ReassignFolio",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Em4eq0ND_srkNxUcMKHmYA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamAppRoleListText;
string outParamEntraRolesListText;
(outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText) = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamAppRoleListText, outParamEntraRolesListText);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioReassignGeneral")]
[RESTScreenServicesActionProperties(Name="FolioReassignGeneral",Screen="Wb_ReassignFolio",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioReassignGeneral(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "FcUAb2GKO_hyEOoTOU+nRg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Model inputs = null;
Actions.lcoFolioReassignGeneral res =  new Actions.lcoFolioReassignGeneral();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_NotificationContent,res.outParamErrorMessage) = await Actions.ActionFolioReassignGeneral(requestContext,inputs.inParami_SourceUserId,inputs.inParami_TargetUserId,inputs.inParami_Motive,inputs.inParami_FolioApprovalLevelList,inputs.inParami_IsInvoiceApproval,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_NotificationContent, res.outParamErrorMessage);
return output;


    }, cancellationToken);
}
}
