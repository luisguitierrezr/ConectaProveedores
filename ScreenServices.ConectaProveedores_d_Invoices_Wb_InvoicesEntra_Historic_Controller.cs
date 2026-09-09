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
[Route("screenservices/ConectaProveedores/d_Invoices/Wb_InvoicesEntra_Historic")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_Controller(
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
[Route("ScreenDataSetGetInvoicesApprovalLevels")]
[RESTScreenServicesActionProperties(Name="GetInvoicesApprovalLevels",Screen="Wb_InvoicesEntra_Historic",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoicesApprovalLevels(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "u+3GMQG4zHJSIWVQz44aLw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoicesApprovalLevels_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoicesApprovalLevels_maxRecords = 999999999;
} else {
datasetGetInvoicesApprovalLevels_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoicesApprovalLevels_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoicesApprovalLevels_startIndex = 0;
} else {
datasetGetInvoicesApprovalLevels_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoicesApprovalLevels_maxRecords < 1)) {
datasetGetInvoicesApprovalLevels_maxRecords = 1;
}

AggregateRecord<RL_68b561fd1c8e1947226d48378281e5a1> ds_output = new AggregateRecord<RL_68b561fd1c8e1947226d48378281e5a1>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel.datasetGetInvoicesApprovalLevels(requestContext,datasetGetInvoicesApprovalLevels_maxRecords,datasetGetInvoicesApprovalLevels_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.ScreenDataSetGetInvoiceById.List.CurrentRec.ssENInvoice.ssInvoiceStatusId,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9>(ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceById")]
[RESTScreenServicesActionProperties(Name="GetInvoiceById",Screen="Wb_InvoicesEntra_Historic",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nvgwwRhRZsQ5ac8MoJC+Zg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceById_maxRecords = 1;
} else {
datasetGetInvoiceById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceById_startIndex = 0;
} else {
datasetGetInvoiceById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceById_maxRecords < 1)) {
datasetGetInvoiceById_maxRecords = 1;
}

AggregateRecord<RL_41aa9995b50bccef3903021154e98b17> ds_output = new AggregateRecord<RL_41aa9995b50bccef3903021154e98b17>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a>(ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetEntraUserManagerList")]
[RESTScreenServicesActionProperties(Name="GetEntraUserManagerList",Screen="Wb_InvoicesEntra_Historic",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetEntraUserManagerList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Bv69ti44rzc1f5xg1+PCbg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList;
outParamUserList = await model.DataActionGetEntraUserManagerList(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetEntraUserManagerList_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSpecialApprovalLevels")]
[RESTScreenServicesActionProperties(Name="GetSpecialApprovalLevels",Screen="Wb_InvoicesEntra_Historic",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSpecialApprovalLevels(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KDobedCAcuKOY8GkVJNPLA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_875afe918a46d044315dbe3410f1f2a7 outParamApprovalList;
outParamApprovalList = await model.DataActionGetSpecialApprovalLevels(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetSpecialApprovalLevels_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamApprovalList);
return output;


    }, cancellationToken);
}
}
