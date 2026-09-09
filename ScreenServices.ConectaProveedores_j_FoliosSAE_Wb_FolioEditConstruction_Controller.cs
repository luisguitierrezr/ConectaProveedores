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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller.GetDbBinaryConfigs(); }
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
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
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



    static ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*j_FoliosSAE.Wb_FolioEditConstruction.ValidateNewFiles*/"6dONWMH_kUW9Ti9X5sMIKA*tNteLMA+cE+rhFxN0YSuuw", 
/*j_FoliosSAE.Wb_FolioEditConstruction.InitialValidate*/"6dONWMH_kUW9Ti9X5sMIKA*otbRMVG6TEu+8wNBHGQRMA", 
/*j_FoliosSAE.Wb_FolioEditConstruction.ValidateFinal*/"6dONWMH_kUW9Ti9X5sMIKA*9fCeNGDZ1UGAXShKOJD+6w", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*j_FoliosSAE.Wb_FolioEditConstruction.Prorate*/"6dONWMH_kUW9Ti9X5sMIKA*r8fFe9GsHUeF5Gs3zTpJ4A", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*FolioUpdate*/"6dONWMH_kUW9Ti9X5sMIKA*q5UkjxzxfkeJ+O_iSqG+ow", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*j_FoliosSAE.Wb_FolioEditConstruction.CalcInvoiceAmount*/"6dONWMH_kUW9Ti9X5sMIKA*nX0dpqLCVUGOlX6A5uij4w", 
/*j_FoliosSAE.Wb_FolioEditConstruction.ValidateDatesInvoiceQttPEP*/"6dONWMH_kUW9Ti9X5sMIKA*OQETqQcyS0udGosvxY_TBA", 
/*GetAllAvailableQuantity*/"6dONWMH_kUW9Ti9X5sMIKA*cUAT2O4_LkurTXV4wQaAWg", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_Controller(
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
[Route("ScreenDataSetGetFolioCommentsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioCommentsByFolioId",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioCommentsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "s3ajRFHrpTi7XECBOWhi2g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.datasetGetFolioCommentsByFolioId(requestContext,datasetGetFolioCommentsByFolioId_maxRecords,datasetGetFolioCommentsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

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
[Route("ScreenDataSetGetFolioObservationsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioObservationsByFolioId",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioObservationsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "C87c9qyenMu1E4Gz29W+6A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.datasetGetFolioObservationsByFolioId(requestContext,datasetGetFolioObservationsByFolioId_maxRecords,datasetGetFolioObservationsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

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
[Route("ScreenDataSetGetOrderDetail")]
[RESTScreenServicesActionProperties(Name="GetOrderDetail",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderDetail(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "lpqE3qzMg4wpZUViVv4nAQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.datasetGetOrderDetail(requestContext,datasetGetOrderDetail_maxRecords,datasetGetOrderDetail_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

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
[Route("ScreenDataSetGetApprovalList")]
[RESTScreenServicesActionProperties(Name="GetApprovalList",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetApprovalList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "CWF6QlHhyibTL8RCKRx_rA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetApprovalList_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetApprovalList_maxRecords = 999999999;
} else {
datasetGetApprovalList_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetApprovalList_startIndex;
if((inputs.StartIndex == null)) {
datasetGetApprovalList_startIndex = 0;
} else {
datasetGetApprovalList_startIndex = inputs.StartIndex.Value;
}

if((datasetGetApprovalList_maxRecords < 1)) {
datasetGetApprovalList_maxRecords = 1;
}

AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> ds_output = new AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.datasetGetApprovalList(requestContext,datasetGetApprovalList_maxRecords,datasetGetApprovalList_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetOrderDetail.List.CurrentRec.ssENOrderMain.ssTelcelDirectionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259>(ssConectaProveedores.RestRecords.RESTRC_79a64780c4264a7ff3588d1347b5f259.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioExtendedById")]
[RESTScreenServicesActionProperties(Name="GetFolioExtendedById",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioExtendedById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "vkikiwe+v8n4xIKFXajsnQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFolioExtendedById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFolioExtendedById_maxRecords = 1;
} else {
datasetGetFolioExtendedById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFolioExtendedById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFolioExtendedById_startIndex = 0;
} else {
datasetGetFolioExtendedById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFolioExtendedById_maxRecords < 1)) {
datasetGetFolioExtendedById_maxRecords = 1;
}

AggregateRecord<RL_abf5dc59037dde79c92447e12cf9bfc9> ds_output = new AggregateRecord<RL_abf5dc59037dde79c92447e12cf9bfc9>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.datasetGetFolioExtendedById(requestContext,datasetGetFolioExtendedById_maxRecords,datasetGetFolioExtendedById_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5>(ssConectaProveedores.RestRecords.RESTRC_ad92b2c217228db10c71baf90a615ea5.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFolioItemsByFolioId")]
[RESTScreenServicesActionProperties(Name="GetFolioItemsByFolioId",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioItemsByFolioId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3hWkR5MZcJ0XElZpxxi9+Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.datasetGetFolioItemsByFolioId(requestContext,datasetGetFolioItemsByFolioId_maxRecords,datasetGetFolioItemsByFolioId_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

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
[Route("ScreenDataSetGetFolioById")]
[RESTScreenServicesActionProperties(Name="GetFolioById",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFolioById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F1H1N5xIqblJLJM64VeI+w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

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
[Route("DataActionGetOrderMainItems")]
[RESTScreenServicesActionProperties(Name="GetOrderMainItems",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrderMainItems(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nMYKJY2YKAefA8NljSFLTw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_4e1292c876d12cf32f3c04367498157e outParamList;
outParamList = await model.DataActionGetOrderMainItems(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetOrderMainItems_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetMinutes")]
[RESTScreenServicesActionProperties(Name="GetMinutes",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetMinutes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "PnK76lq1cA_f5rDsb9jnjw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_a579a1a05eaaba551100ea61f4cb3f6b outParamKeyValueList;
outParamKeyValueList = await model.DataActionGetMinutes(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutes_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamKeyValueList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSummary")]
[RESTScreenServicesActionProperties(Name="GetSummary",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSummary(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8Zn+WqR+1XoWIyMin1R8Vw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RC_0b2176705fa164c9531eb643caf0e9d4 outParamo_SummaryRec;
outParamo_SummaryRec = await model.DataActionGetSummary(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetSummary_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_SummaryRec);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetMinutesDocuments")]
[RESTScreenServicesActionProperties(Name="GetMinutesDocuments",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetMinutesDocuments(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "PCd2xGFaG8pOj11S2TQsoQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_9fb5c5e988576f6c521a9ef779213183 outParamList;
RL_1501ee54ff868a67eff67465502ee3d9 outParamFilesList2;
(outParamList,outParamFilesList2) = await model.DataActionGetMinutesDocuments(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList, outParamFilesList2);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioUpdate")]
[RESTScreenServicesActionProperties(Name="FolioUpdate",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioUpdate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Ij3zNtckafeTs_J8EUnUiQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_FolioName,res.outParamErrorMsg) = await Actions.ActionFolioUpdate(requestContext,inputs.inParamFolioID,inputs.inParamI_SelectedLines,inputs.inParamI_OrderMainId,inputs.inParamI_Comments,inputs.inParamFilesListExtra,inputs.inParamFilesList,inputs.inParamApprovalProcessTypeId,inputs.inParamConstructionData,inputs.inParami_SummaryRec,inputs.inParamInvoiceToCreate,inputs.inParamInvoiceForeignToCreate,inputs.inParamCreditNoteFilesList,inputs.inParamImportAnticipo,inputs.inParami_UpdateComment,inputs.inParami_HaveNewFiles,inputs.inParami_NewFileNamesUploaded,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionFolioUpdate_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_FolioName, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetAllAvailableQuantity")]
[RESTScreenServicesActionProperties(Name="GetAllAvailableQuantity",Screen="Wb_FolioEditConstruction",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetAllAvailableQuantity(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "P4fB3c4JvQ+qBOZ0I70ViA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionGetAllAvailableQuantity_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionGetAllAvailableQuantity_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamLocalSelectedLines = await Actions.ActionGetAllAvailableQuantity(requestContext,inputs.inParamGetFolioItemsByFolioId_List,inputs.inParamFolioIdToExclude,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ActionGetAllAvailableQuantity_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamLocalSelectedLines);
return output;


    }, cancellationToken);
}
}
