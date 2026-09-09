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
[Route("screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadBigFiles")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_y_Utils_Wb_MultiFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssBigUpload.ScreenServices.BigUpload_BigUpload_wb_BigUploadMultipleFiles_Controller", "BigUpload", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_ButtonLoading_Controller", "OutSystemsUI", childControllers);
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



    static ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.CustomUploadOnFileChangeBigFile*/"6dONWMH_kUW9Ti9X5sMIKA*ql1sdO_SCEmTX4ZlbcgDjQ", 
/*Invoice_OCR*/"6dONWMH_kUW9Ti9X5sMIKA*6HW9fx8ujkOqT2mME8Q2Gg", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.ValidationMainXMLPdf*/"6dONWMH_kUW9Ti9X5sMIKA*u9Tejpkl_Eu6FOCDlKq1fg", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*UploadInvoiceFiles*/"6dONWMH_kUW9Ti9X5sMIKA*w9K5woMBwUS_pY93pBuY0g", 
/*OutSystemsUI.DatePickerUpdateDate*/"Kn_hixxDWEm4lMd7mIpycQ*+YdSuBd5Eku5etGjhba8kw", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg"});

    }

    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller(
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
[Route("ScreenDataSetGetInvoiceFilesByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceFilesByInvoiceId",Screen="Wb_PopupInvoiceUploadBigFiles",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceFilesByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "1JqQEdM1RKGps9HKUhRXsg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceFilesByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceFilesByInvoiceId_maxRecords = 50;
} else {
datasetGetInvoiceFilesByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceFilesByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceFilesByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceFilesByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceFilesByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceFilesByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_00a03f803f0d49826089181417370afb> ds_output = new AggregateRecord<RL_00a03f803f0d49826089181417370afb>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Multiple,model.inParamInvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_18990af86f7169e92b712b468e13b947>(ssConectaProveedores.RestRecords.RESTRC_18990af86f7169e92b712b468e13b947.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceExtendedForeignerById")]
[RESTScreenServicesActionProperties(Name="GetInvoiceExtendedForeignerById",Screen="Wb_PopupInvoiceUploadBigFiles",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceExtendedForeignerById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ekq5PyVYF_WhScHqLpMxWw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceExtendedForeignerById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceExtendedForeignerById_maxRecords = 1;
} else {
datasetGetInvoiceExtendedForeignerById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceExtendedForeignerById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceExtendedForeignerById_startIndex = 0;
} else {
datasetGetInvoiceExtendedForeignerById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceExtendedForeignerById_maxRecords < 1)) {
datasetGetInvoiceExtendedForeignerById_maxRecords = 1;
}

AggregateRecord<RL_5198a019df57be180483639cd138aad4> ds_output = new AggregateRecord<RL_5198a019df57be180483639cd138aad4>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel.datasetGetInvoiceExtendedForeignerById(requestContext,datasetGetInvoiceExtendedForeignerById_maxRecords,datasetGetInvoiceExtendedForeignerById_startIndex,IterationMultiplicity.Multiple,model.inParamInvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b>(ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetInvoicesByRequisitionOrFolio")]
[RESTScreenServicesActionProperties(Name="GetInvoicesByRequisitionOrFolio",Screen="Wb_PopupInvoiceUploadBigFiles",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetInvoicesByRequisitionOrFolio(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "VuADNACJ3oYtFrJeKCow8Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_2d16aaaf46aa59a96936af8c3c3547a0 outParamInvoicesList;
decimal outParamInvoicesSum;
(outParamInvoicesList,outParamInvoicesSum) = await model.DataActionGetInvoicesByRequisitionOrFolio(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamInvoicesList, outParamInvoicesSum);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSupplier")]
[RESTScreenServicesActionProperties(Name="GetSupplier",Screen="Wb_PopupInvoiceUploadBigFiles",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSupplier(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wqJxT+WzW4R2feMDGrfWXw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamExpedicionFiscal;
bool outParamIsNational;
string outParamName;
string outParamRFC;
string outParamSociety;
bool outParamIsActiveDEV_TK395;
(outParamExpedicionFiscal,outParamIsNational,outParamName,outParamRFC,outParamSociety,outParamIsActiveDEV_TK395) = await model.DataActionGetSupplier(requestContext,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetSupplier_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamExpedicionFiscal, outParamIsNational, outParamName, outParamRFC, outParamSociety, outParamIsActiveDEV_TK395);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionInvoice_OCR")]
[RESTScreenServicesActionProperties(Name="Invoice_OCR",Screen="Wb_PopupInvoiceUploadBigFiles",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionInvoice_OCR(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "l1Z7Ht+TQvOx9ZV7WJjjKA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Model inputs = null;
Actions.lcoInvoice_OCR res =  new Actions.lcoInvoice_OCR();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamExtractTextOrOcr2,res.outParamExtractForeignInvoiceDataForUs2) = await Actions.ActionInvoice_OCR(requestContext,inputs.inParamPDFBinaryData,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionInvoice_OCR_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamExtractTextOrOcr2, res.outParamExtractForeignInvoiceDataForUs2);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionUploadInvoiceFiles")]
[RESTScreenServicesActionProperties(Name="UploadInvoiceFiles",Screen="Wb_PopupInvoiceUploadBigFiles",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUploadInvoiceFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "N89602WQuvEMIeUa+aj8jw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionUploadInvoiceFiles_Model inputs = null;
Actions.lcoUploadInvoiceFiles res =  new Actions.lcoUploadInvoiceFiles();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionUploadInvoiceFiles_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamErrorMsg,res.outParamo_Invoice,res.outParamo_InvoiceExtended,res.outParamClaveProdServ,res.outParamTipoComprobante,res.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles(requestContext,inputs.inParamInvoiceId,inputs.inParamRequisitionId,inputs.inParamOrderMainId,inputs.inParamFolioId,inputs.inParamFilesList,inputs.inParamExtraFilesList,inputs.inParamIgnoreCreation,inputs.inParamInvoiceForeign,inputs.inParamInvoicesSum,inputs.inParamIsModify,inputs.inParamIsStartApproval,inputs.inParamAccountingDataTypeId,inputs.inParamOrderAccConceptsID,inputs.inParamImportAnticipo,inputs.inParamCreditNoteInvoiceId,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ActionUploadInvoiceFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMsg, res.outParamo_Invoice, res.outParamo_InvoiceExtended, res.outParamClaveProdServ, res.outParamTipoComprobante, res.outParamIsMissingCreditNote);
return output;


    }, cancellationToken);
}
}
