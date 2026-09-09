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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreate")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns3_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssBigUpload.ScreenServices.BigUpload_BigUpload_wb_BigUploadMultipleFiles_Controller", "BigUpload", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_ScrollableArea_Controller", "OutSystemsUI", childControllers);
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



    static ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*j_FoliosSAE.Wb_FolioCreate.CustomUploadOnFileChangeBigFile*/"6dONWMH_kUW9Ti9X5sMIKA*cuKiOsvOTES5zVLoAiiw2A", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*FolioCreate*/"6dONWMH_kUW9Ti9X5sMIKA*e+aHUv+bdkiHQO_gQdv0zw", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*j_FoliosSAE.Wb_FolioCreate.ValidateDatesInvoiceQttPEP*/"6dONWMH_kUW9Ti9X5sMIKA*n4YMg1DS1UCxvTf2e0bG7g", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*j_FoliosSAE.Wb_FolioCreate.ValidateFinal*/"6dONWMH_kUW9Ti9X5sMIKA*xhXHt6VOUEy2OSZYFpfaiA", 
/*j_FoliosSAE.Wb_FolioCreate.CalcInvoiceAmount*/"6dONWMH_kUW9Ti9X5sMIKA*GhSsuZy7vUq3lHbPB2IWbQ", 
/*j_FoliosSAE.Wb_FolioCreate.ValidateFiles*/"6dONWMH_kUW9Ti9X5sMIKA*y9Otw7wDh0+iiVeZgDaHOQ", 
/*TelcelIntegrations.Call_ZMXMIMMF_VISUALIZAR_SAL_ANT*/"W2g2vJ1htkyBZ_pD4Lqsqw*pd7fPYx2bkipi8u_Iiz_ig", 
/*j_FoliosSAE.Wb_FolioCreate.Prorate*/"6dONWMH_kUW9Ti9X5sMIKA*aD_29bTa9EmDfRFOgOWKrw", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_Controller(
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
[Route("ScreenDataSetGetOrderDetail")]
[RESTScreenServicesActionProperties(Name="GetOrderDetail",Screen="Wb_FolioCreate",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderDetail(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "lpqE3qzMg4wpZUViVv4nAQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel.datasetGetOrderDetail(requestContext,datasetGetOrderDetail_maxRecords,datasetGetOrderDetail_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

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
[Route("DataActionGetFirstApproverList")]
[RESTScreenServicesActionProperties(Name="GetFirstApproverList",Screen="Wb_FolioCreate",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetFirstApproverList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+VmVnA2J3Jf85rcr_WAwdQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_648f5b7a91b58d2f6ade938e7f17a9f2 outParamFirstApproverList;
outParamFirstApproverList = await model.DataActionGetFirstApproverList(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetFirstApproverList_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamFirstApproverList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="Wb_FolioCreate",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "qX8IZemszpVC7R9L8iHOqQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsActiveAmountValidation;
bool outParamIsForceForeigner;
decimal outParamo_ForeignCurrencyMargin;
decimal outParamo_NationalCurrencyMargin;
bool outParamo_IsActiveDEV_HU13008_Complement;
(outParamIsActiveAmountValidation,outParamIsForceForeigner,outParamo_ForeignCurrencyMargin,outParamo_NationalCurrencyMargin,outParamo_IsActiveDEV_HU13008_Complement) = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsActiveAmountValidation, outParamIsForceForeigner, outParamo_ForeignCurrencyMargin, outParamo_NationalCurrencyMargin, outParamo_IsActiveDEV_HU13008_Complement);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSummary")]
[RESTScreenServicesActionProperties(Name="GetSummary",Screen="Wb_FolioCreate",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSummary(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8Zn+WqR+1XoWIyMin1R8Vw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RC_0b2176705fa164c9531eb643caf0e9d4 outParamo_SummaryRec;
outParamo_SummaryRec = await model.DataActionGetSummary(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSummary_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_SummaryRec);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT")]
[RESTScreenServicesActionProperties(Name="Call_ZMXMIMMF_VISUALIZAR_SAL_ANT",Screen="Wb_FolioCreate",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "mEDBUNKMySFTPNFDy4Vl+Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT(requestContext,inputs.inParamRequest,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Outputs.FromOutputs(this.BehaviorsConfiguration, res_outParamResponse);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionFolioCreate")]
[RESTScreenServicesActionProperties(Name="FolioCreate",Screen="Wb_FolioCreate",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionFolioCreate(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "4xnZBg4JdXDVujLeNhLc5A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ActionFolioCreate_Model inputs = null;
Actions.lcoFolioCreate res =  new Actions.lcoFolioCreate();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ActionFolioCreate_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_FolioName,res.outParamErrorMsg) = await Actions.ActionFolioCreate(requestContext,inputs.inParamI_SelectedLines,inputs.inParamI_OrderMainId,inputs.inParamI_FirstApprovalId,inputs.inParamI_Comments,inputs.inParamInvoiceExtended,inputs.inParamFilesListExtra,inputs.inParamFilesList,inputs.inParamInvoiceId,inputs.inParamInvoiceForeignToCreate,inputs.inParamApprovalProcessTypeId,inputs.inParamConstructionData,inputs.inParamApprovalProcessId,inputs.inParami_SummaryRec,inputs.inParami_IsMassCreate,inputs.inParami_MinuteSelected,inputs.inParami_OrderAccConceptID,inputs.inParamCreditNoteFilesList,inputs.inParamImportAnticipo,inputs.inParamIsNational,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ActionFolioCreate_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_FolioName, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}
}
