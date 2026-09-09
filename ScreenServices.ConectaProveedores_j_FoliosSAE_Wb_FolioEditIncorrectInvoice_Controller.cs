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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*j_FoliosSAE.Wb_FolioEditIncorrectInvoice.InitialValidate*/"6dONWMH_kUW9Ti9X5sMIKA*SnPuUQ_tNUmYcApUy9Hmqw", 
/*j_FoliosSAE.Wb_FolioEditIncorrectInvoice.UpdateFolioOnClick*/"6dONWMH_kUW9Ti9X5sMIKA*lr+xUg9FTE+g8Bpeqp0hNw", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*FolioInvoiceUpdate*/"6dONWMH_kUW9Ti9X5sMIKA*aZklfVsXmUm4ZEICLqOgIg", 
/*j_FoliosSAE.Wb_FolioEditIncorrectInvoice.ValidateDatesInvoiceQttPEP*/"6dONWMH_kUW9Ti9X5sMIKA*Xnw2gF2Vd0WKxv8L5O1YAQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*FolioUpdate*/"6dONWMH_kUW9Ti9X5sMIKA*q5UkjxzxfkeJ+O_iSqG+ow", 
/*j_FoliosSAE.Wb_FolioEditIncorrectInvoice.ValidateFinal*/"6dONWMH_kUW9Ti9X5sMIKA*yj_ByTe8DE+NHe3PyqDvFA", 
/*TelcelIntegrations.Call_ZMXMIMMF_VISUALIZAR_SAL_ANT*/"W2g2vJ1htkyBZ_pD4Lqsqw*pd7fPYx2bkipi8u_Iiz_ig", 
/*GetAllAvailableQuantity*/"6dONWMH_kUW9Ti9X5sMIKA*cUAT2O4_LkurTXV4wQaAWg", 
/*j_FoliosSAE.Wb_FolioEditIncorrectInvoice.CalcInvoiceAmount*/"6dONWMH_kUW9Ti9X5sMIKA*dcdc3yqXvkKO7TpImdgLkQ", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*j_FoliosSAE.Wb_FolioEditIncorrectInvoice.ValidateFiles*/"6dONWMH_kUW9Ti9X5sMIKA*hOa1+hcGnkyJjMZefTeORQ"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_Controller(
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
[Route("ScreenDataSetGetFolioApprovalRejectReason")]
[RESTScreenServicesActionProperties(Name="GetFolioApprovalRejectReason",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioApprovalRejectReason(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "p6xYQLI8Jbh5uMewTpEvGQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioApprovalRejectReason_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioApprovalRejectReason_maxRecords = 1;
} else {
datasetGetFolioApprovalRejectReason_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioApprovalRejectReason_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioApprovalRejectReason_startIndex = 0;
} else {
datasetGetFolioApprovalRejectReason_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioApprovalRejectReason_maxRecords < 1)) {
datasetGetFolioApprovalRejectReason_maxRecords = 1;
}

AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564> ds_output = new AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.datasetGetFolioApprovalRejectReason(requestContext,datasetGetFolioApprovalRejectReason_maxRecords,datasetGetFolioApprovalRejectReason_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8>(ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioById")]
[RESTScreenServicesActionProperties(Name="GetFolioById",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F1H1N5xIqblJLJM64VeI+w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioById_maxRecords = 1;
} else {
datasetGetFolioById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioById_startIndex = 0;
} else {
datasetGetFolioById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioById_maxRecords < 1)) {
datasetGetFolioById_maxRecords = 1;
}

AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ds_output = new AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526>(ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioCommentsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioCommentsByFolioId",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioCommentsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "s3ajRFHrpTi7XECBOWhi2g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioCommentsByFolioId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioCommentsByFolioId_maxRecords = 1;
} else {
datasetGetFolioCommentsByFolioId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioCommentsByFolioId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioCommentsByFolioId_startIndex = 0;
} else {
datasetGetFolioCommentsByFolioId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioCommentsByFolioId_maxRecords < 1)) {
datasetGetFolioCommentsByFolioId_maxRecords = 1;
}

AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> ds_output = new AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.datasetGetFolioCommentsByFolioId(requestContext,datasetGetFolioCommentsByFolioId_maxRecords,datasetGetFolioCommentsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6>(ssConectaProveedores.RestRecords.RESTRC_03baaf9011c29c7810216c701048afb6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioItemsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioItemsByFolioId",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioItemsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3hWkR5MZcJ0XElZpxxi9+Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioItemsByFolioId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioItemsByFolioId_maxRecords = 999999999;
} else {
datasetGetFolioItemsByFolioId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioItemsByFolioId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioItemsByFolioId_startIndex = 0;
} else {
datasetGetFolioItemsByFolioId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioItemsByFolioId_maxRecords < 1)) {
datasetGetFolioItemsByFolioId_maxRecords = 1;
}

AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ds_output = new AggregateRecord<RL_a968cf9f63475dc9358672149b11245a>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.datasetGetFolioItemsByFolioId(requestContext,datasetGetFolioItemsByFolioId_maxRecords,datasetGetFolioItemsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2>(ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderDetail")]
[RESTScreenServicesActionProperties(Name="GetOrderDetail",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderDetail(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "lpqE3qzMg4wpZUViVv4nAQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderDetail_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderDetail_maxRecords = 999999999;
} else {
datasetGetOrderDetail_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderDetail_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderDetail_startIndex = 0;
} else {
datasetGetOrderDetail_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderDetail_maxRecords < 1)) {
datasetGetOrderDetail_maxRecords = 1;
}

AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ds_output = new AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.datasetGetOrderDetail(requestContext,datasetGetOrderDetail_maxRecords,datasetGetOrderDetail_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9>(ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioObservationsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioObservationsByFolioId",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioObservationsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "C87c9qyenMu1E4Gz29W+6A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioObservationsByFolioId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioObservationsByFolioId_maxRecords = 50;
} else {
datasetGetFolioObservationsByFolioId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioObservationsByFolioId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioObservationsByFolioId_startIndex = 0;
} else {
datasetGetFolioObservationsByFolioId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioObservationsByFolioId_maxRecords < 1)) {
datasetGetFolioObservationsByFolioId_maxRecords = 1;
}

AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ds_output = new AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.datasetGetFolioObservationsByFolioId(requestContext,datasetGetFolioObservationsByFolioId_maxRecords,datasetGetFolioObservationsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b>(ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8PNYPHATyRPMvPRoRC3kYg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsActiveAmountValidation;
bool outParamIsForceForeigner;
decimal outParamo_ForeignCurrencyMargin;
decimal outParamo_NationalCurrencyMargin;
bool outParamo_IsActiveDEV_HU13008_Complement;
bool outParamo_IsActiveDEV_HU13046;
(outParamIsActiveAmountValidation,outParamIsForceForeigner,outParamo_ForeignCurrencyMargin,outParamo_NationalCurrencyMargin,outParamo_IsActiveDEV_HU13008_Complement,outParamo_IsActiveDEV_HU13046) = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsActiveAmountValidation, outParamIsForceForeigner, outParamo_ForeignCurrencyMargin, outParamo_NationalCurrencyMargin, outParamo_IsActiveDEV_HU13008_Complement, outParamo_IsActiveDEV_HU13046);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetFolioFiles")]
[RESTScreenServicesActionProperties(Name="GetFolioFiles",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetFolioFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "eMmOE7OnWf6aMnPicbq0+Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceMainFiles;
outParamInvoiceMainFiles = await model.DataActionGetFolioFiles(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetFolioFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamInvoiceMainFiles);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetOrderMainItems")]
[RESTScreenServicesActionProperties(Name="GetOrderMainItems",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrderMainItems(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nMYKJY2YKAefA8NljSFLTw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_4e1292c876d12cf32f3c04367498157e outParamList;
outParamList = await model.DataActionGetOrderMainItems(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetOrderMainItems_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSummary")]
[RESTScreenServicesActionProperties(Name="GetSummary",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSummary(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8Zn+WqR+1XoWIyMin1R8Vw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RC_0b2176705fa164c9531eb643caf0e9d4 outParamo_SummaryRec;
outParamo_SummaryRec = await model.DataActionGetSummary(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetSummary_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_SummaryRec);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT")]
[RESTScreenServicesActionProperties(Name="Call_ZMXMIMMF_VISUALIZAR_SAL_ANT",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "mEDBUNKMySFTPNFDy4Vl+Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Model inputs = null;
ST_cbb2055cf19f871ed882642269bd43ceStructure res_outParamResponse = new ST_cbb2055cf19f871ed882642269bd43ceStructure();
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT(requestContext,inputs.inParamRequest,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamResponse);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioInvoiceUpdate")]
[RESTScreenServicesActionProperties(Name="FolioInvoiceUpdate",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioInvoiceUpdate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "mC9Jp8dzEl_Uf25KbKknwA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioInvoiceUpdate_Model inputs = null;
Actions.lcoFolioInvoiceUpdate res =  new Actions.lcoFolioInvoiceUpdate();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioInvoiceUpdate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamErrorMsg,res.outParamo_FolioName,res.outParamIsMissingCreditNote) = await Actions.ActionFolioInvoiceUpdate(requestContext,inputs.inParami_FolioId,inputs.inParami_Comments,inputs.inParamFilesListExtra,inputs.inParamFilesList,inputs.inParamCreditNoteFilesList,inputs.inParamInvoiceToCreate,inputs.inParamInvoiceForeignToCreate,inputs.inParamImportAnticipo,inputs.inParamOffsetUtc,inputs.inParami_UpdateComment,inputs.inParami_HaveNewFiles,inputs.inParami_NewFileNamesUploaded,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioInvoiceUpdate_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMsg, res.outParamo_FolioName, res.outParamIsMissingCreditNote);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioUpdate")]
[RESTScreenServicesActionProperties(Name="FolioUpdate",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioUpdate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Ij3zNtckafeTs_J8EUnUiQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioUpdate_Model inputs = null;
Actions.lcoFolioUpdate res =  new Actions.lcoFolioUpdate();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioUpdate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_FolioName,res.outParamErrorMsg) = await Actions.ActionFolioUpdate(requestContext,inputs.inParamFolioID,inputs.inParamI_SelectedLines,inputs.inParamI_OrderMainId,inputs.inParamI_Comments,inputs.inParamFilesListExtra,inputs.inParamFilesList,inputs.inParamApprovalProcessTypeId,inputs.inParamConstructionData,inputs.inParami_SummaryRec,inputs.inParamInvoiceToCreate,inputs.inParamInvoiceForeignToCreate,inputs.inParamCreditNoteFilesList,inputs.inParamImportAnticipo,inputs.inParami_UpdateComment,inputs.inParami_HaveNewFiles,inputs.inParami_NewFileNamesUploaded,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioUpdate_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_FolioName, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetAllAvailableQuantity")]
[RESTScreenServicesActionProperties(Name="GetAllAvailableQuantity",Screen="Wb_FolioEditIncorrectInvoice",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetAllAvailableQuantity(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "P4fB3c4JvQ+qBOZ0I70ViA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionGetAllAvailableQuantity_Model inputs = null;
Actions.lcoGetAllAvailableQuantity res =  new Actions.lcoGetAllAvailableQuantity();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionGetAllAvailableQuantity_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamLocalSelectedLines = await Actions.ActionGetAllAvailableQuantity(requestContext,inputs.inParamGetFolioItemsByFolioId_List,inputs.inParamFolioIdToExclude,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionGetAllAvailableQuantity_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamLocalSelectedLines);
return output;


    }, cancellationToken);
}
}
