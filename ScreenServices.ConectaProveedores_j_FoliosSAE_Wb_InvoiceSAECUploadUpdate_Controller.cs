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
[Route("screenservices/ConectaProveedores/j_FoliosSAE/Wb_InvoiceSAECUploadUpdate")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_y_Utils_Wb_AnticipoImport_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_MultiFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
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



    static ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.ValidationCreditNotes*/"6dONWMH_kUW9Ti9X5sMIKA*qbb9MNQJ70mcWI4_hCSpIQ", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*Invoice_OCR*/"6dONWMH_kUW9Ti9X5sMIKA*6HW9fx8ujkOqT2mME8Q2Gg", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*OutSystemsUI.DatePickerClear*/"Kn_hixxDWEm4lMd7mIpycQ*XA9N6xrQKUGTrhIKHbqebw", 
/*j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.ValidationMainXMLPdf*/"6dONWMH_kUW9Ti9X5sMIKA*a8k4pZF+WUCV6DRPfY2kvA", 
/*j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.TogglePopupForeigner*/"6dONWMH_kUW9Ti9X5sMIKA*YOy6vk+qlUyJcawDcAUzig", 
/*UploadInvoiceFiles*/"6dONWMH_kUW9Ti9X5sMIKA*w9K5woMBwUS_pY93pBuY0g", 
/*OutSystemsUI.DatePickerClose*/"Kn_hixxDWEm4lMd7mIpycQ*Ng5_r9LHuEShqJ_OLWbntg", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw"});

    }

    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_Controller(
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
[Route("ScreenDataSetGetInvoiceFiles")]
[RESTScreenServicesActionProperties(Name="GetInvoiceFiles",Screen="Wb_InvoiceSAECUploadUpdate",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "b3oEJAZW2rITZfWrfkdw6g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceFiles_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceFiles_maxRecords = 999999999;
} else {
datasetGetInvoiceFiles_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceFiles_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceFiles_startIndex = 0;
} else {
datasetGetInvoiceFiles_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceFiles_maxRecords < 1)) {
datasetGetInvoiceFiles_maxRecords = 1;
}

AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ds_output = new AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Multiple,model.inParamFolioId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1>(ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCreditNoteInvoiceFiles")]
[RESTScreenServicesActionProperties(Name="GetCreditNoteInvoiceFiles",Screen="Wb_InvoiceSAECUploadUpdate",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCreditNoteInvoiceFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "wSiP5hTcflX0Ts6ryHi2wQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCreditNoteInvoiceFiles_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCreditNoteInvoiceFiles_maxRecords = 50;
} else {
datasetGetCreditNoteInvoiceFiles_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCreditNoteInvoiceFiles_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCreditNoteInvoiceFiles_startIndex = 0;
} else {
datasetGetCreditNoteInvoiceFiles_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCreditNoteInvoiceFiles_maxRecords < 1)) {
datasetGetCreditNoteInvoiceFiles_maxRecords = 1;
}

AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ds_output = new AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0>();
long count;
(ds_output.List,count) = await ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel.datasetGetCreditNoteInvoiceFiles(requestContext,datasetGetCreditNoteInvoiceFiles_maxRecords,datasetGetCreditNoteInvoiceFiles_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetInvoiceFiles.List.CurrentRec.ssENInvoice.ssCreditNoteInvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1>(ssConectaProveedores.RestRecords.RESTRC_2b77a78552d1dad3876c3ebd8f5c8ec1.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSupplier")]
[RESTScreenServicesActionProperties(Name="GetSupplier",Screen="Wb_InvoiceSAECUploadUpdate",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSupplier(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "p9ppP8VM7Passk7i7b1W8A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel model = null;
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

try {model = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

string outParamExpedicionFiscal;
string outParamName;
string outParamRFC;
string outParamSociety;
string outParamSupplierNr;
bool outParamIsNational;
bool outParamIsActiveDEV_TK395;
(outParamExpedicionFiscal,outParamName,outParamRFC,outParamSociety,outParamSupplierNr,outParamIsNational,outParamIsActiveDEV_TK395) = await model.DataActionGetSupplier(requestContext,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamExpedicionFiscal, outParamName, outParamRFC, outParamSociety, outParamSupplierNr, outParamIsNational, outParamIsActiveDEV_TK395);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionUploadInvoiceFiles")]
[RESTScreenServicesActionProperties(Name="UploadInvoiceFiles",Screen="Wb_InvoiceSAECUploadUpdate",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionUploadInvoiceFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "N89602WQuvEMIeUa+aj8jw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionUploadInvoiceFiles_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionUploadInvoiceFiles_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamErrorMsg,res.outParamo_Invoice,res.outParamo_InvoiceExtended,res.outParamClaveProdServ,res.outParamTipoComprobante,res.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles(requestContext,inputs.inParamInvoiceId,inputs.inParamRequisitionId,inputs.inParamOrderMainId,inputs.inParamFolioId,inputs.inParamFilesList,inputs.inParamExtraFilesList,inputs.inParamIgnoreCreation,inputs.inParamInvoiceForeign,inputs.inParamInvoicesSum,inputs.inParamIsModify,inputs.inParamIsStartApproval,inputs.inParamAccountingDataTypeId,inputs.inParamOrderAccConceptsID,inputs.inParamImportAnticipo,inputs.inParamCreditNoteInvoiceId,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionUploadInvoiceFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMsg, res.outParamo_Invoice, res.outParamo_InvoiceExtended, res.outParamClaveProdServ, res.outParamTipoComprobante, res.outParamIsMissingCreditNote);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionInvoice_OCR")]
[RESTScreenServicesActionProperties(Name="Invoice_OCR",Screen="Wb_InvoiceSAECUploadUpdate",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionInvoice_OCR(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "l1Z7Ht+TQvOx9ZV7WJjjKA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionInvoice_OCR_Model inputs = null;
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

try {inputs = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionInvoice_OCR_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamExtractTextOrOcr2,res.outParamExtractForeignInvoiceDataForUs2) = await Actions.ActionInvoice_OCR(requestContext,inputs.inParamPDFBinaryData,cancellationToken);

var output = RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ActionInvoice_OCR_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamExtractTextOrOcr2, res.outParamExtractForeignInvoiceDataForUs2);
return output;


    }, cancellationToken);
}
}
