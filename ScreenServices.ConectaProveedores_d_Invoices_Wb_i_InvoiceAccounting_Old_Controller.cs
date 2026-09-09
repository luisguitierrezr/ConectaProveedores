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
[Route("screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingSum_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Accordion_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingRetentions_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns3_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_PopupApprove_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GetCodeByTaxId*/"6dONWMH_kUW9Ti9X5sMIKA*DBSDBRdoXUexRFPeo7Q4iA", 
/*d_Invoices.Wb_i_InvoiceAccounting_Old.TogglePopupApproval*/"6dONWMH_kUW9Ti9X5sMIKA*SZlWEU7vsUq5htwIiJjhFw", 
/*d_Invoices.Wb_i_InvoiceAccounting_Old.OnClickEditField*/"6dONWMH_kUW9Ti9X5sMIKA*9zFYIw7kgEqd5Xzrkqk5+A", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*CheckUserSession*/"6dONWMH_kUW9Ti9X5sMIKA*HG8yg7rqxE2mIgBEqxL6Lg", 
/*GetPaymentMethodDescriptionById*/"6dONWMH_kUW9Ti9X5sMIKA*EC8SiDWgj02pS1zc6UJg+A", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*GetPaymentTermDescriptionById*/"6dONWMH_kUW9Ti9X5sMIKA*hvkoqLwAh0eGNZckYiz_kw", 
/*d_Invoices.Wb_i_InvoiceAccounting_Old.EditField*/"6dONWMH_kUW9Ti9X5sMIKA*LgdrvoR3h0uTsh2i5qAKAw", 
/*d_Invoices.Wb_i_InvoiceAccounting_Old.TogglePopupImport*/"6dONWMH_kUW9Ti9X5sMIKA*PHspy14p9kSfDjNRzCUUDw", 
/*OnSubmitAccounting*/"6dONWMH_kUW9Ti9X5sMIKA*m1aJ1lqS0U+QHrIppyqU4Q", 
/*InvoiceAccountingSave*/"6dONWMH_kUW9Ti9X5sMIKA*86ND6iu7Fk+NlHCttVmu9g", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_Controller(
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
[Route("ScreenDataSetGetCostCenters")]
[RESTScreenServicesActionProperties(Name="GetCostCenters",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCostCenters(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "PFgOcVYTyd2esKT4r8d2yg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCostCenters_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCostCenters_maxRecords = 999999999;
} else {
datasetGetCostCenters_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCostCenters_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCostCenters_startIndex = 0;
} else {
datasetGetCostCenters_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCostCenters_maxRecords < 1)) {
datasetGetCostCenters_maxRecords = 1;
}

AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ds_output = new AggregateRecord<RL_ec55ed22dae89075d036f3a863173164>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetCostCenters(requestContext,datasetGetCostCenters_maxRecords,datasetGetCostCenters_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d>(ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceRetentionsByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceRetentionsByInvoiceId",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceRetentionsByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XfJdJHOAa26JwHbaGS3tnQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceRetentionsByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceRetentionsByInvoiceId_maxRecords = 50;
} else {
datasetGetInvoiceRetentionsByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceRetentionsByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceRetentionsByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceRetentionsByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceRetentionsByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceRetentionsByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_9404dc36b913809894c7e4e44e8e1dd8> ds_output = new AggregateRecord<RL_9404dc36b913809894c7e4e44e8e1dd8>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetInvoiceRetentionsByInvoiceId(requestContext,datasetGetInvoiceRetentionsByInvoiceId_maxRecords,datasetGetInvoiceRetentionsByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782>(ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetTaxIndicators")]
[RESTScreenServicesActionProperties(Name="GetTaxIndicators",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetTaxIndicators(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "byk0b5sGlb4sLA6+QluOFg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetTaxIndicators_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetTaxIndicators_maxRecords = 50;
} else {
datasetGetTaxIndicators_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetTaxIndicators_startIndex;
if((inputs.StartIndex == null)) {
datasetGetTaxIndicators_startIndex = 0;
} else {
datasetGetTaxIndicators_startIndex = inputs.StartIndex.Value;
}

if((datasetGetTaxIndicators_maxRecords < 1)) {
datasetGetTaxIndicators_maxRecords = 1;
}

AggregateRecord<RL_bf188616de0f0f2f6ca06ba5dba27490> ds_output = new AggregateRecord<RL_bf188616de0f0f2f6ca06ba5dba27490>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetTaxIndicators(requestContext,datasetGetTaxIndicators_maxRecords,datasetGetTaxIndicators_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613>(ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceApproval")]
[RESTScreenServicesActionProperties(Name="GetInvoiceApproval",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceApproval(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wfk51u1BGH3d15JUu2Mqyw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetInvoiceApproval(requestContext,datasetGetInvoiceApproval_maxRecords,datasetGetInvoiceApproval_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),model.inParami_InvoiceId,cancellationToken);

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
[Route("ScreenDataSetGetPaymentMethods")]
[RESTScreenServicesActionProperties(Name="GetPaymentMethods",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentMethods(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "npZ34hlfwoGQJHz7xDdwVw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentMethods_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentMethods_maxRecords = 999999999;
} else {
datasetGetPaymentMethods_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetPaymentMethods_startIndex;
if((inputs.StartIndex == null)) {
datasetGetPaymentMethods_startIndex = 0;
} else {
datasetGetPaymentMethods_startIndex = inputs.StartIndex.Value;
}

if((datasetGetPaymentMethods_maxRecords < 1)) {
datasetGetPaymentMethods_maxRecords = 1;
}

AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ds_output = new AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetPaymentMethods(requestContext,datasetGetPaymentMethods_maxRecords,datasetGetPaymentMethods_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e>(ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetPaymentTerms")]
[RESTScreenServicesActionProperties(Name="GetPaymentTerms",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentTerms(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+6OhqwjTKpS9lXyr02rGqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentTerms_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentTerms_maxRecords = 999999999;
} else {
datasetGetPaymentTerms_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetPaymentTerms_startIndex;
if((inputs.StartIndex == null)) {
datasetGetPaymentTerms_startIndex = 0;
} else {
datasetGetPaymentTerms_startIndex = inputs.StartIndex.Value;
}

if((datasetGetPaymentTerms_maxRecords < 1)) {
datasetGetPaymentTerms_maxRecords = 1;
}

AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ds_output = new AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetPaymentTerms(requestContext,datasetGetPaymentTerms_maxRecords,datasetGetPaymentTerms_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a>(ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceExtendedById")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedById",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "RlRF4r4Wn6OQ7og9ZiLl4A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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

AggregateRecord<RL_a675a81d4063c2bba451ee57edc49e99> ds_output = new AggregateRecord<RL_a675a81d4063c2bba451ee57edc49e99>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetInvoiceExtendedById(requestContext,datasetGetInvoiceExtendedById_maxRecords,datasetGetInvoiceExtendedById_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873>(ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetAccountingAccountsServiceTypes")]
[RESTScreenServicesActionProperties(Name="GetAccountingAccountsServiceTypes",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAccountingAccountsServiceTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "t28k2Knts2Qv4GQe9TM9NA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAccountingAccountsServiceTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAccountingAccountsServiceTypes_maxRecords = 9999999;
} else {
datasetGetAccountingAccountsServiceTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetAccountingAccountsServiceTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetAccountingAccountsServiceTypes_startIndex = 0;
} else {
datasetGetAccountingAccountsServiceTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetAccountingAccountsServiceTypes_maxRecords < 1)) {
datasetGetAccountingAccountsServiceTypes_maxRecords = 1;
}

AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> ds_output = new AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetAccountingAccountsServiceTypes(requestContext,datasetGetAccountingAccountsServiceTypes_maxRecords,datasetGetAccountingAccountsServiceTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f52b5cefcfac404122195213ce1b53ba>(ssConectaProveedores.RestRecords.RESTRC_f52b5cefcfac404122195213ce1b53ba.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRegions")]
[RESTScreenServicesActionProperties(Name="GetRegions",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRegions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F9suSx2_X8+qIMY5h0gbYw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRegions_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRegions_maxRecords = 50;
} else {
datasetGetRegions_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRegions_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRegions_startIndex = 0;
} else {
datasetGetRegions_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRegions_maxRecords < 1)) {
datasetGetRegions_maxRecords = 1;
}

AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ds_output = new AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0>(ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceAccountingsByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceAccountingsByInvoiceId",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceAccountingsByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "BYgI+D2LOkASNVpBBm_Y6w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceAccountingsByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceAccountingsByInvoiceId_maxRecords = 1;
} else {
datasetGetInvoiceAccountingsByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceAccountingsByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceAccountingsByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceAccountingsByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceAccountingsByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceAccountingsByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_ccf70f600f06def33a14ca10a1120a68> ds_output = new AggregateRecord<RL_ccf70f600f06def33a14ca10a1120a68>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetInvoiceAccountingsByInvoiceId(requestContext,datasetGetInvoiceAccountingsByInvoiceId_maxRecords,datasetGetInvoiceAccountingsByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c398a83ea7d109886e6be693f6d07867>(ssConectaProveedores.RestRecords.RESTRC_c398a83ea7d109886e6be693f6d07867.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedMoreChargesByInvoiceId",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "sj7QdCKaGixjzJ+AOBxSkA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetInvoiceExtendedMoreChargesByInvoiceId(requestContext,datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords,datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

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
[Route("ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedTaxsByInvoiceId",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "BIHVJDSZJX4S+I40KWiYYg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 99999;
} else {
datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_948a214f011367826beec566f5df17e6> ds_output = new AggregateRecord<RL_948a214f011367826beec566f5df17e6>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.datasetGetInvoiceExtendedTaxsByInvoiceId(requestContext,datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords,datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f4d76e3d3fccb22411e2fbf1d069c4d1>(ssConectaProveedores.RestRecords.RESTRC_f4d76e3d3fccb22411e2fbf1d069c4d1.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetData")]
[RESTScreenServicesActionProperties(Name="GetData",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OLxw5EtdXIuJNpmz4QELpA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsAnticipoWithInv;
bool outParamIsLastLevel;
(outParamIsAnticipoWithInv,outParamIsLastLevel) = await model.DataActionGetData(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_DataActionGetData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsAnticipoWithInv, outParamIsLastLevel);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetInvoiceAccounting")]
[RESTScreenServicesActionProperties(Name="GetInvoiceAccounting",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetInvoiceAccounting(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Gzt7_4GEiBaZ5R9TiJhwyg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_c31399d0d7c776731653a069ba32283a outParamo_List;
long outParamo_InvoiceAccountingId;
(outParamo_List,outParamo_InvoiceAccountingId) = await model.DataActionGetInvoiceAccounting(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_DataActionGetInvoiceAccounting_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_List, outParamo_InvoiceAccountingId);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionCheckUserSession")]
[RESTScreenServicesActionProperties(Name="CheckUserSession",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.ServerAction)]
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

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionCheckUserSession_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamIsValidSession);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetPaymentMethodDescriptionById")]
[RESTScreenServicesActionProperties(Name="GetPaymentMethodDescriptionById",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetPaymentMethodDescriptionById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "5elxzoJFNIdUrB+k_rsXhA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetPaymentMethodDescriptionById_Model inputs = null;
Actions.lcoGetPaymentMethodDescriptionById res =  new Actions.lcoGetPaymentMethodDescriptionById();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetPaymentMethodDescriptionById_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamDesc = await Actions.ActionGetPaymentMethodDescriptionById(requestContext,inputs.inParamPaymentMethodsId,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetPaymentMethodDescriptionById_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamDesc);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionInvoiceAccountingSave")]
[RESTScreenServicesActionProperties(Name="InvoiceAccountingSave",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionInvoiceAccountingSave(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+OaYtBHOtgAjHh8Am0yN2A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionInvoiceAccountingSave_Model inputs = null;
Actions.lcoInvoiceAccountingSave res =  new Actions.lcoInvoiceAccountingSave();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionInvoiceAccountingSave_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionInvoiceAccountingSave(requestContext,inputs.inParami_InvoiceId,inputs.inParami_InvoiceAccounting,inputs.inParami_InvoiceAddendumList,inputs.inParami_InvoiceExtended,inputs.inParami_InvoiceAccountingServicesList,inputs.inParami_IsImport,inputs.inParami_InvoiceAccountingEntries,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionInvoiceAccountingSave_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetPaymentTermDescriptionById")]
[RESTScreenServicesActionProperties(Name="GetPaymentTermDescriptionById",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetPaymentTermDescriptionById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "cYRna9jhvR6EqfFFRbf+LQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetPaymentTermDescriptionById_Model inputs = null;
Actions.lcoGetPaymentTermDescriptionById res =  new Actions.lcoGetPaymentTermDescriptionById();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetPaymentTermDescriptionById_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamDesc = await Actions.ActionGetPaymentTermDescriptionById(requestContext,inputs.inParamPaymentTermsId,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetPaymentTermDescriptionById_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamDesc);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionOnSubmitAccounting")]
[RESTScreenServicesActionProperties(Name="OnSubmitAccounting",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionOnSubmitAccounting(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "5tCw0KuFXoRxdNCFWu06og", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionOnSubmitAccounting_Model inputs = null;
Actions.lcoOnSubmitAccounting res =  new Actions.lcoOnSubmitAccounting();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionOnSubmitAccounting_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Output,res.outParamIsToFinish) = await Actions.ActionOnSubmitAccounting(requestContext,inputs.inParami_InvoiceId,inputs.inParami_InvoiceApprovalLevelId,inputs.inParami_IsApprove,inputs.inParami_Comment,inputs.inParami_InvoiceAccounting,inputs.inParami_InvoiceAddendumList,inputs.inParami_InvoiceExtended,inputs.inParami_InvoiceAccountingServicesList,inputs.inParami_IsImport,inputs.inParami_InvoiceAccountingEntries,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionOnSubmitAccounting_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output, res.outParamIsToFinish);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetCodeByTaxId")]
[RESTScreenServicesActionProperties(Name="GetCodeByTaxId",Screen="Wb_i_InvoiceAccounting_Old",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetCodeByTaxId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Ty7QM+GgI+PN2Z+tGRad3Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetCodeByTaxId_Model inputs = null;
Actions.lcoGetCodeByTaxId res =  new Actions.lcoGetCodeByTaxId();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetCodeByTaxId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamCode = await Actions.ActionGetCodeByTaxId(requestContext,inputs.inParamTaxIndicatorId,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetCodeByTaxId_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamCode);
return output;


    }, cancellationToken);
}
}
