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
[Route("screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionInvoices")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*GetCanUploadInvoicesByRequisitionId*/"6dONWMH_kUW9Ti9X5sMIKA*urV5J5f3kkCHEnlaRQsHWQ", 
/*DownloadInvoiceFiles*/"6dONWMH_kUW9Ti9X5sMIKA*I_3dp_BZgEqOxDPJ10uA_w"});

    }

    public ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller(
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
[Route("ScreenDataSetGetInvoicesByRequisitionId")]
[RESTScreenServicesActionProperties(Name="GetInvoicesByRequisitionId",Screen="Wb_RequisitionInvoices",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoicesByRequisitionId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "W2jD2o2pW_REN+W8+0p1dQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoicesByRequisitionId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoicesByRequisitionId_maxRecords = 9999;
} else {
datasetGetInvoicesByRequisitionId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoicesByRequisitionId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoicesByRequisitionId_startIndex = 0;
} else {
datasetGetInvoicesByRequisitionId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoicesByRequisitionId_maxRecords < 1)) {
datasetGetInvoicesByRequisitionId_maxRecords = 1;
}

AggregateRecord<RL_9f948f770ba4600f86dd29332a1a7e00> ds_output = new AggregateRecord<RL_9f948f770ba4600f86dd29332a1a7e00>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel.datasetGetInvoicesByRequisitionId(requestContext,datasetGetInvoicesByRequisitionId_maxRecords,datasetGetInvoicesByRequisitionId_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),model.inParami_RequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29>(ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetRequisitionData")]
[RESTScreenServicesActionProperties(Name="GetRequisitionData",Screen="Wb_RequisitionInvoices",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetRequisitionData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "S5ocBl5hzIkAvHA6ft2QQA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamAdvWithoutInvoice;
bool outParamAllowMultiUpload;
bool outParamWasAdvWithoutInvoice;
long outParamCostCenterSAPId;
string outParamCurrencyId;
string outParamDivisionFI;
string outParamProject;
long outParamPaymentMethodsId;
long outParamPaymentTermsId;
string outParamSupplierNr;
decimal outParamTotalAmount;
(outParamAdvWithoutInvoice,outParamAllowMultiUpload,outParamWasAdvWithoutInvoice,outParamCostCenterSAPId,outParamCurrencyId,outParamDivisionFI,outParamProject,outParamPaymentMethodsId,outParamPaymentTermsId,outParamSupplierNr,outParamTotalAmount) = await model.DataActionGetRequisitionData(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamAdvWithoutInvoice, outParamAllowMultiUpload, outParamWasAdvWithoutInvoice, outParamCostCenterSAPId, outParamCurrencyId, outParamDivisionFI, outParamProject, outParamPaymentMethodsId, outParamPaymentTermsId, outParamSupplierNr, outParamTotalAmount);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionDownloadInvoiceFiles")]
[RESTScreenServicesActionProperties(Name="DownloadInvoiceFiles",Screen="Wb_RequisitionInvoices",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionDownloadInvoiceFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "q4fidEzmLEnK5H0av1aFqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Model inputs = null;
Actions.lcoDownloadInvoiceFiles res =  new Actions.lcoDownloadInvoiceFiles();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamBinaryZIP,res.outParamErrorMsg) = await Actions.ActionDownloadInvoiceFiles(requestContext,inputs.inParamInvoiceId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionDownloadInvoiceFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamBinaryZIP, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetCanUploadInvoicesByRequisitionId")]
[RESTScreenServicesActionProperties(Name="GetCanUploadInvoicesByRequisitionId",Screen="Wb_RequisitionInvoices",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetCanUploadInvoicesByRequisitionId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8VYjevsePtVrdv0jNlr2Zw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionGetCanUploadInvoicesByRequisitionId_Model inputs = null;
Actions.lcoGetCanUploadInvoicesByRequisitionId res =  new Actions.lcoGetCanUploadInvoicesByRequisitionId();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionGetCanUploadInvoicesByRequisitionId_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParami_CanUpload = await Actions.ActionGetCanUploadInvoicesByRequisitionId(requestContext,inputs.inParami_RequisitionId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionGetCanUploadInvoicesByRequisitionId_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParami_CanUpload);
return output;


    }, cancellationToken);
}
}
