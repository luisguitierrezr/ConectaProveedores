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
[Route("screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns3_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Accordion_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_AccordionItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_PopupApprove_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ApprovModifInv*/"6dONWMH_kUW9Ti9X5sMIKA*heTUNyFw0kqo9AMFrmGymg", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*CheckUserSession*/"6dONWMH_kUW9Ti9X5sMIKA*HG8yg7rqxE2mIgBEqxL6Lg", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA"});

    }

    public ConectaProveedores_d_Invoices_Wb_InvoiceDetails_Controller(
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
[Route("ScreenDataSetGetInvoiceExtendedMoreChargesTotal")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedMoreChargesTotal",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedMoreChargesTotal(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "HGJkmwF++S2EIDr+WjTKcQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceExtendedMoreChargesTotal_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceExtendedMoreChargesTotal_maxRecords = 1;
} else {
datasetGetInvoiceExtendedMoreChargesTotal_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceExtendedMoreChargesTotal_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceExtendedMoreChargesTotal_startIndex = 0;
} else {
datasetGetInvoiceExtendedMoreChargesTotal_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceExtendedMoreChargesTotal_maxRecords < 1)) {
datasetGetInvoiceExtendedMoreChargesTotal_maxRecords = 1;
}

AggregateRecord<RL_84dada5f12004775b86c894b55ae9596> ds_output = new AggregateRecord<RL_84dada5f12004775b86c894b55ae9596>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.datasetGetInvoiceExtendedMoreChargesTotal(requestContext,datasetGetInvoiceExtendedMoreChargesTotal_maxRecords,datasetGetInvoiceExtendedMoreChargesTotal_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_8675220d3fe960c67254ae28d587388e>(ssConectaProveedores.RestRecords.RESTRC_8675220d3fe960c67254ae28d587388e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedRelationsByInvoiceId",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dS4TkaC+YGMee8uX8+xFKA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords = 50;
} else {
datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_d07e089b14ae41d13cfd90c5313de016> ds_output = new AggregateRecord<RL_d07e089b14ae41d13cfd90c5313de016>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.datasetGetInvoiceExtendedRelationsByInvoiceId(requestContext,datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords,datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4>(ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceAccountingByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceAccountingByInvoiceId",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceAccountingByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "v08tXSwqYKWcO_F3bJx6dg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceAccountingByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceAccountingByInvoiceId_maxRecords = 1;
} else {
datasetGetInvoiceAccountingByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceAccountingByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceAccountingByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceAccountingByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceAccountingByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceAccountingByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_cc406982da8c42dd9f44909f6be7c1b9> ds_output = new AggregateRecord<RL_cc406982da8c42dd9f44909f6be7c1b9>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.datasetGetInvoiceAccountingByInvoiceId(requestContext,datasetGetInvoiceAccountingByInvoiceId_maxRecords,datasetGetInvoiceAccountingByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847>(ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceExtendedById")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedById",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "2WPE_5leaqHPkOwpzTcpUQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceExtendedById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceExtendedById_maxRecords = 1;
} else {
datasetGetInvoiceExtendedById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceExtendedById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceExtendedById_startIndex = 0;
} else {
datasetGetInvoiceExtendedById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceExtendedById_maxRecords < 1)) {
datasetGetInvoiceExtendedById_maxRecords = 1;
}

AggregateRecord<RL_ec81b8a47286cf2b9fe9bbf727e9ade3> ds_output = new AggregateRecord<RL_ec81b8a47286cf2b9fe9bbf727e9ade3>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.datasetGetInvoiceExtendedById(requestContext,datasetGetInvoiceExtendedById_maxRecords,datasetGetInvoiceExtendedById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2c7478516bbd3eed6a35183496a9f500>(ssConectaProveedores.RestRecords.RESTRC_2c7478516bbd3eed6a35183496a9f500.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedMoreChargesByInvoiceId",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "sj7QdCKaGixjzJ+AOBxSkA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = 50;
} else {
datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> ds_output = new AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.datasetGetInvoiceExtendedMoreChargesByInvoiceId(requestContext,datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords,datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168>(ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceApproval")]
[RESTScreenServicesActionProperties(Name="GetInvoiceApproval",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceApproval(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wfk51u1BGH3d15JUu2Mqyw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceApproval_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceApproval_maxRecords = 1;
} else {
datasetGetInvoiceApproval_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceApproval_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceApproval_startIndex = 0;
} else {
datasetGetInvoiceApproval_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceApproval_maxRecords < 1)) {
datasetGetInvoiceApproval_maxRecords = 1;
}

AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> ds_output = new AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel.datasetGetInvoiceApproval(requestContext,datasetGetInvoiceApproval_maxRecords,datasetGetInvoiceApproval_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_eac76b624d2264108f6fbeb95d9d43ba>(ssConectaProveedores.RestRecords.RESTRC_eac76b624d2264108f6fbeb95d9d43ba.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionApprovModifInv")]
[RESTScreenServicesActionProperties(Name="ApprovModifInv",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApprovModifInv(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "hgVLsCjSSwJ57Oio+PKM9g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionApprovModifInv_Model inputs = null;
Actions.lcoApprovModifInv res =  new Actions.lcoApprovModifInv();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionApprovModifInv_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Output,res.outParamIsFinish) = await Actions.ActionApprovModifInv(requestContext,inputs.inParami_InvoiceId,inputs.inParami_InvoiceApprovalLevelId,inputs.inParami_IsApprove,inputs.inParami_Comment,inputs.inParamOffsetUtc,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionApprovModifInv_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output, res.outParamIsFinish);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionCheckUserSession")]
[RESTScreenServicesActionProperties(Name="CheckUserSession",Screen="Wb_InvoiceDetails",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionCheckUserSession(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "r6LGmAV4qXUN0IKWGjbASA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        Actions.lcoCheckUserSession res =  new Actions.lcoCheckUserSession();CheckPermissionsIndex.CheckPermissionsAsync check;
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
res.outParamIsValidSession = await Actions.ActionCheckUserSession(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ActionCheckUserSession_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamIsValidSession);
return output;


    }, cancellationToken);
}
}
