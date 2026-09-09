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
[Route("screenservices/ConectaProveedores/a_Reassignments/Wb_ReassignmentForm")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
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



    static ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*OutSystemsUI.DropdownClear*/"Kn_hixxDWEm4lMd7mIpycQ*6sUJiKYcdUiNxgj9D4oOpw", 
/*OutSystemsUI.DropdownClose*/"Kn_hixxDWEm4lMd7mIpycQ*pl2C8krULU6spXH8YJQoEA", 
/*OutSystemsUI.DropdownNotValid*/"Kn_hixxDWEm4lMd7mIpycQ*Isqu3ObtRUGvjEzTJaoyOw", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListIndexOf*/"uXCIR2Atc0+es3zYuZSnNw*ll06di6ktkmBKbRlJZEmZw", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*Reassign*/"6dONWMH_kUW9Ti9X5sMIKA*3HBWkl6OWEiIc5I6uQXD9g", 
/*OutSystemsUI.DropdownClearValidation*/"Kn_hixxDWEm4lMd7mIpycQ*r2LVGF0gTk2QJHL5f8jtvA", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_Controller(
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
[Route("ScreenDataSetGetSourceUserByEntraId")]
[RESTScreenServicesActionProperties(Name="GetSourceUserByEntraId",Screen="Wb_ReassignmentForm",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSourceUserByEntraId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "_eEoaK3hjpQQwQeweC9GrQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSourceUserByEntraId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSourceUserByEntraId_maxRecords = 1;
} else {
datasetGetSourceUserByEntraId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSourceUserByEntraId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSourceUserByEntraId_startIndex = 0;
} else {
datasetGetSourceUserByEntraId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSourceUserByEntraId_maxRecords < 1)) {
datasetGetSourceUserByEntraId_maxRecords = 1;
}

AggregateRecord<RL_3a99147a5a14669e8ced82dd9eebacf0> ds_output = new AggregateRecord<RL_3a99147a5a14669e8ced82dd9eebacf0>();
long count;
(ds_output.List,count) = await ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel.datasetGetSourceUserByEntraId(requestContext,datasetGetSourceUserByEntraId_maxRecords,datasetGetSourceUserByEntraId_startIndex,IterationMultiplicity.Multiple,model.varLcl_SourceUserEntraId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_6783422774b4547f1160d86529102520>(ssConectaProveedores.RestRecords.RESTRC_6783422774b4547f1160d86529102520.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSourceUserContent")]
[RESTScreenServicesActionProperties(Name="GetSourceUserContent",Screen="Wb_ReassignmentForm",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSourceUserContent(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Vm9Q1MPOI8X7NXDdEKOSjA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_6f013a7f2ef00b964b6e71f1ec07b189 outParamReqList;
RL_8c69b09c6d811e27e13cdf810a622fb2 outParamInvList;
(outParamReqList,outParamInvList) = await model.DataActionGetSourceUserContent(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamReqList, outParamInvList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUsersTarget")]
[RESTScreenServicesActionProperties(Name="GetUsersTarget",Screen="Wb_ReassignmentForm",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUsersTarget(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "YeJIvyFT8kQy8RlPocF2bA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_144725d7e52a72fc566c148009197c7e outParamo_UserTargetListAU;
outParamo_UserTargetListAU = await model.DataActionGetUsersTarget(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersTarget_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_UserTargetListAU);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUsersSource")]
[RESTScreenServicesActionProperties(Name="GetUsersSource",Screen="Wb_ReassignmentForm",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUsersSource(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "V2AkkDVJnc1CWzkqTLI_Hg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel model = null;
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

try {model = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_33aa275c739b8b537ec846fb1cac5907 outParamo_DirectReportsList;
bool outParamo_HasError;
(outParamo_DirectReportsList,outParamo_HasError) = await model.DataActionGetUsersSource(requestContext,cancellationToken);

var output = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_DirectReportsList, outParamo_HasError);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionReassign")]
[RESTScreenServicesActionProperties(Name="Reassign",Screen="Wb_ReassignmentForm",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionReassign(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KEJJgTOVAyxU3ze3Zh_U5w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Model inputs = null;
Actions.lcoReassign res =  new Actions.lcoReassign();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_NotificationContent,res.outParamo_Output) = await Actions.ActionReassign(requestContext,inputs.inParamInvList,inputs.inParamReqList,inputs.inParami_TargetUserAUEntraId,inputs.inParami_Reason,inputs.inParami_SourceUserId,cancellationToken);

var output = RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_NotificationContent, res.outParamo_Output);
return output;


    }, cancellationToken);
}
}
