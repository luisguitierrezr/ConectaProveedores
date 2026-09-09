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
[Route("screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_MultiFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns3_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns4_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_wb_OrderDetail_3Attachments_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_e_Orders_Wb_OrderReject_Popup_Controller.ProxyInstance, childControllers);
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



    static ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*e_Orders.Wb_OrderDetailPaymentInformation.Validations*/"6dONWMH_kUW9Ti9X5sMIKA*5shiHY55Jk6aREk7eqXUEg", 
/*SaveContractFile*/"6dONWMH_kUW9Ti9X5sMIKA*4hMrOsMoIkODZZX2qZQcIw", 
/*OutSystemsUI.DropdownNotValid*/"Kn_hixxDWEm4lMd7mIpycQ*Isqu3ObtRUGvjEzTJaoyOw", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*GetIsUserCxP*/"6dONWMH_kUW9Ti9X5sMIKA*IviWftf+vkGDITMy7m7xGQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*e_Orders.Wb_OrderDetailPaymentInformation.ListOfFiles*/"6dONWMH_kUW9Ti9X5sMIKA*pRYEtyX9IE64DS5XlkWyBQ", 
/*SaveOrderDetail*/"6dONWMH_kUW9Ti9X5sMIKA*zfeEurDo2EWr_zUi2MIeFw", 
/*e_Orders.Wb_OrderDetailPaymentInformation.AddRecord*/"6dONWMH_kUW9Ti9X5sMIKA*Aa8n3Dd9_UG_wxLpnlkVeA", 
/*OutSystemsUI.DropdownClearValidation*/"Kn_hixxDWEm4lMd7mIpycQ*r2LVGF0gTk2QJHL5f8jtvA", 
/*ApprovRejectOrder*/"6dONWMH_kUW9Ti9X5sMIKA*t3ky9yXnk0Cw1rXhtDDSUQ", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*e_Orders.Wb_OrderDetailPaymentInformation.ClearFields*/"6dONWMH_kUW9Ti9X5sMIKA*4xqe_Ahl5kG5z+ZX5fJmNw"});

    }

    public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_Controller(
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
[Route("ScreenDataSetGetInsuranceTypes")]
[RESTScreenServicesActionProperties(Name="GetInsuranceTypes",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInsuranceTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "0kLj6620Ezk+l1bssUC0yw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInsuranceTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInsuranceTypes_maxRecords = 50;
} else {
datasetGetInsuranceTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInsuranceTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInsuranceTypes_startIndex = 0;
} else {
datasetGetInsuranceTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInsuranceTypes_maxRecords < 1)) {
datasetGetInsuranceTypes_maxRecords = 1;
}

AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> ds_output = new AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetInsuranceTypes(requestContext,datasetGetInsuranceTypes_maxRecords,datasetGetInsuranceTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a>(ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetDepositTypes")]
[RESTScreenServicesActionProperties(Name="GetDepositTypes",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetDepositTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "xNMlgKuJEXDYt59dj4cBjw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetDepositTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetDepositTypes_maxRecords = 50;
} else {
datasetGetDepositTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetDepositTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetDepositTypes_startIndex = 0;
} else {
datasetGetDepositTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetDepositTypes_maxRecords < 1)) {
datasetGetDepositTypes_maxRecords = 1;
}

AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> ds_output = new AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetDepositTypes(requestContext,datasetGetDepositTypes_maxRecords,datasetGetDepositTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7>(ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetPaymentWays")]
[RESTScreenServicesActionProperties(Name="GetPaymentWays",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentWays(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ksLZ9v9fiVInXkNX+iiybw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentWays_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentWays_maxRecords = 99999;
} else {
datasetGetPaymentWays_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetPaymentWays_startIndex;
if((inputs.StartIndex == null)) {
datasetGetPaymentWays_startIndex = 0;
} else {
datasetGetPaymentWays_startIndex = inputs.StartIndex.Value;
}

if((datasetGetPaymentWays_maxRecords < 1)) {
datasetGetPaymentWays_maxRecords = 1;
}

AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ds_output = new AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetPaymentWays(requestContext,datasetGetPaymentWays_maxRecords,datasetGetPaymentWays_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetOrderMainById.List.CurrentRec.ssENOrderDetail.ssPaymentWaysId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8>(ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetAccountingDataTypes")]
[RESTScreenServicesActionProperties(Name="GetAccountingDataTypes",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAccountingDataTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "GSdIV_2QnHAjbJAYrKgrwA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAccountingDataTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAccountingDataTypes_maxRecords = 50;
} else {
datasetGetAccountingDataTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetAccountingDataTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetAccountingDataTypes_startIndex = 0;
} else {
datasetGetAccountingDataTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetAccountingDataTypes_maxRecords < 1)) {
datasetGetAccountingDataTypes_maxRecords = 1;
}

AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ds_output = new AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetAccountingDataTypes(requestContext,datasetGetAccountingDataTypes_maxRecords,datasetGetAccountingDataTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c>(ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetBusinessValueCategories")]
[RESTScreenServicesActionProperties(Name="GetBusinessValueCategories",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetBusinessValueCategories(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3K1jXP9IJF_nMwQ5zqcRyg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetBusinessValueCategories_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetBusinessValueCategories_maxRecords = 50;
} else {
datasetGetBusinessValueCategories_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetBusinessValueCategories_startIndex;
if((inputs.StartIndex == null)) {
datasetGetBusinessValueCategories_startIndex = 0;
} else {
datasetGetBusinessValueCategories_startIndex = inputs.StartIndex.Value;
}

if((datasetGetBusinessValueCategories_maxRecords < 1)) {
datasetGetBusinessValueCategories_maxRecords = 1;
}

AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> ds_output = new AggregateRecord<RL_901339470d357e86e0df985d0e6489f6>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetBusinessValueCategories(requestContext,datasetGetBusinessValueCategories_maxRecords,datasetGetBusinessValueCategories_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261>(ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderMainItemsByOrderMainId")]
[RESTScreenServicesActionProperties(Name="GetOrderMainItemsByOrderMainId",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderMainItemsByOrderMainId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "AG6iWE4JO8TzLOOrh0+jgA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderMainItemsByOrderMainId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderMainItemsByOrderMainId_maxRecords = 999999999;
} else {
datasetGetOrderMainItemsByOrderMainId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderMainItemsByOrderMainId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderMainItemsByOrderMainId_startIndex = 0;
} else {
datasetGetOrderMainItemsByOrderMainId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderMainItemsByOrderMainId_maxRecords < 1)) {
datasetGetOrderMainItemsByOrderMainId_maxRecords = 1;
}

AggregateRecord<RL_663d4acde686fb13f7cb44965555ab7f> ds_output = new AggregateRecord<RL_663d4acde686fb13f7cb44965555ab7f>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetOrderMainItemsByOrderMainId(requestContext,datasetGetOrderMainItemsByOrderMainId_maxRecords,datasetGetOrderMainItemsByOrderMainId_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64>(ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetAdvancedPaymentTypes")]
[RESTScreenServicesActionProperties(Name="GetAdvancedPaymentTypes",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAdvancedPaymentTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "hoLIYf+Dyd+VynjpRubgCg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAdvancedPaymentTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAdvancedPaymentTypes_maxRecords = 50;
} else {
datasetGetAdvancedPaymentTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetAdvancedPaymentTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetAdvancedPaymentTypes_startIndex = 0;
} else {
datasetGetAdvancedPaymentTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetAdvancedPaymentTypes_maxRecords < 1)) {
datasetGetAdvancedPaymentTypes_maxRecords = 1;
}

AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> ds_output = new AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetAdvancedPaymentTypes(requestContext,datasetGetAdvancedPaymentTypes_maxRecords,datasetGetAdvancedPaymentTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62>(ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetBusinessValueSubcategoriesByCategoryId")]
[RESTScreenServicesActionProperties(Name="GetBusinessValueSubcategoriesByCategoryId",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OPm1pOj_KeAJWjXogYPfSQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetBusinessValueSubcategoriesByCategoryId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetBusinessValueSubcategoriesByCategoryId_maxRecords = 50;
} else {
datasetGetBusinessValueSubcategoriesByCategoryId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetBusinessValueSubcategoriesByCategoryId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetBusinessValueSubcategoriesByCategoryId_startIndex = 0;
} else {
datasetGetBusinessValueSubcategoriesByCategoryId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetBusinessValueSubcategoriesByCategoryId_maxRecords < 1)) {
datasetGetBusinessValueSubcategoriesByCategoryId_maxRecords = 1;
}

AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> ds_output = new AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetBusinessValueSubcategoriesByCategoryId(requestContext,datasetGetBusinessValueSubcategoriesByCategoryId_maxRecords,datasetGetBusinessValueSubcategoriesByCategoryId_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetOrderMainById.List.CurrentRec.ssENOrderDetail.ssBusinessValueCategoryId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84>(ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceUsages")]
[RESTScreenServicesActionProperties(Name="GetInvoiceUsages",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceUsages(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9K4ozixnDaUYQeFRQ9_iQQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceUsages_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceUsages_maxRecords = 50;
} else {
datasetGetInvoiceUsages_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceUsages_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceUsages_startIndex = 0;
} else {
datasetGetInvoiceUsages_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceUsages_maxRecords < 1)) {
datasetGetInvoiceUsages_maxRecords = 1;
}

AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> ds_output = new AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetInvoiceUsages(requestContext,datasetGetInvoiceUsages_maxRecords,datasetGetInvoiceUsages_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2512cd3cc7f986e36b4d5edf290d4383>(ssConectaProveedores.RestRecords.RESTRC_2512cd3cc7f986e36b4d5edf290d4383.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetFrequencies")]
[RESTScreenServicesActionProperties(Name="GetFrequencies",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFrequencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "AzjepyCQFApZH_95qbpcQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetFrequencies_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetFrequencies_maxRecords = 50;
} else {
datasetGetFrequencies_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetFrequencies_startIndex;
if((inputs.StartIndex == null)) {
datasetGetFrequencies_startIndex = 0;
} else {
datasetGetFrequencies_startIndex = inputs.StartIndex.Value;
}

if((datasetGetFrequencies_maxRecords < 1)) {
datasetGetFrequencies_maxRecords = 1;
}

AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ds_output = new AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetFrequencies(requestContext,datasetGetFrequencies_maxRecords,datasetGetFrequencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf>(ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProjectAssetServices")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetServices",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetServices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "QmIftqTsNkC++1frUcNFQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProjectAssetServices_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProjectAssetServices_maxRecords = 999999;
} else {
datasetGetProjectAssetServices_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProjectAssetServices_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProjectAssetServices_startIndex = 0;
} else {
datasetGetProjectAssetServices_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProjectAssetServices_maxRecords < 1)) {
datasetGetProjectAssetServices_maxRecords = 1;
}

AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ds_output = new AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetProjectAssetServices(requestContext,datasetGetProjectAssetServices_maxRecords,datasetGetProjectAssetServices_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e>(ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRejectComment")]
[RESTScreenServicesActionProperties(Name="GetRejectComment",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRejectComment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "kSrfER1EWt2N4ouy+vFO3w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRejectComment_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRejectComment_maxRecords = 1;
} else {
datasetGetRejectComment_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRejectComment_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRejectComment_startIndex = 0;
} else {
datasetGetRejectComment_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRejectComment_maxRecords < 1)) {
datasetGetRejectComment_maxRecords = 1;
}

AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ds_output = new AggregateRecord<RL_17d8289ea48572225dc9530a5725652a>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetRejectComment(requestContext,datasetGetRejectComment_maxRecords,datasetGetRejectComment_startIndex,IterationMultiplicity.Multiple,model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6>(ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSupplierByRequisition")]
[RESTScreenServicesActionProperties(Name="GetSupplierByRequisition",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierByRequisition(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "H3U5Elt6W9ibSLwdPH1HvQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSupplierByRequisition_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSupplierByRequisition_maxRecords = 1;
} else {
datasetGetSupplierByRequisition_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSupplierByRequisition_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSupplierByRequisition_startIndex = 0;
} else {
datasetGetSupplierByRequisition_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSupplierByRequisition_maxRecords < 1)) {
datasetGetSupplierByRequisition_maxRecords = 1;
}

AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ds_output = new AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetSupplierByRequisition(requestContext,datasetGetSupplierByRequisition_maxRecords,datasetGetSupplierByRequisition_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetOrderMainById.List.CurrentRec.ssENOrderDetail.ssContractSupplier,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce>(ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSpecialApprovals")]
[RESTScreenServicesActionProperties(Name="GetSpecialApprovals",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSpecialApprovals(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "vnJOYyFcujOLSxybVuL+qg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSpecialApprovals_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSpecialApprovals_maxRecords = 50;
} else {
datasetGetSpecialApprovals_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSpecialApprovals_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSpecialApprovals_startIndex = 0;
} else {
datasetGetSpecialApprovals_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSpecialApprovals_maxRecords < 1)) {
datasetGetSpecialApprovals_maxRecords = 1;
}

AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ds_output = new AggregateRecord<RL_0204de281fa136fb826199f876159fe4>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetSpecialApprovals(requestContext,datasetGetSpecialApprovals_maxRecords,datasetGetSpecialApprovals_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5>(ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetPaymentTerms")]
[RESTScreenServicesActionProperties(Name="GetPaymentTerms",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentTerms(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+6OhqwjTKpS9lXyr02rGqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentTerms_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentTerms_maxRecords = 99999;
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
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetPaymentTerms(requestContext,datasetGetPaymentTerms_maxRecords,datasetGetPaymentTerms_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetPaymentMethods")]
[RESTScreenServicesActionProperties(Name="GetPaymentMethods",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentMethods(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "npZ34hlfwoGQJHz7xDdwVw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentMethods_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentMethods_maxRecords = 99999;
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
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetPaymentMethods(requestContext,datasetGetPaymentMethods_maxRecords,datasetGetPaymentMethods_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetOrderRetentionTypes")]
[RESTScreenServicesActionProperties(Name="GetOrderRetentionTypes",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderRetentionTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "iW+O1+oPx3_XDEqe18dTPQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderRetentionTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderRetentionTypes_maxRecords = 50;
} else {
datasetGetOrderRetentionTypes_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderRetentionTypes_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderRetentionTypes_startIndex = 0;
} else {
datasetGetOrderRetentionTypes_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderRetentionTypes_maxRecords < 1)) {
datasetGetOrderRetentionTypes_maxRecords = 1;
}

AggregateRecord<RL_d6a865b9451603b2b07820fedb283c87> ds_output = new AggregateRecord<RL_d6a865b9451603b2b07820fedb283c87>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetOrderRetentionTypes(requestContext,datasetGetOrderRetentionTypes_maxRecords,datasetGetOrderRetentionTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42>(ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetCurrencies")]
[RESTScreenServicesActionProperties(Name="GetCurrencies",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCurrencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f+VnB3EzqSeam1tAXE44KQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCurrencies_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCurrencies_maxRecords = 50;
} else {
datasetGetCurrencies_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCurrencies_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCurrencies_startIndex = 0;
} else {
datasetGetCurrencies_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCurrencies_maxRecords < 1)) {
datasetGetCurrencies_maxRecords = 1;
}

AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ds_output = new AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetCurrencies(requestContext,datasetGetCurrencies_maxRecords,datasetGetCurrencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e>(ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetOrderMainById")]
[RESTScreenServicesActionProperties(Name="GetOrderMainById",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetOrderMainById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "13fYgXR65HFVmrZ2ywJoHw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetOrderMainById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetOrderMainById_maxRecords = 1;
} else {
datasetGetOrderMainById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetOrderMainById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetOrderMainById_startIndex = 0;
} else {
datasetGetOrderMainById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetOrderMainById_maxRecords < 1)) {
datasetGetOrderMainById_maxRecords = 1;
}

AggregateRecord<RL_c5285652b7692ee7ff416f77dcd1fe1c> ds_output = new AggregateRecord<RL_c5285652b7692ee7ff416f77dcd1fe1c>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionGetIsCxP_RequestErrorDistribution(requestContext,cancellationToken)),(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),model.inParami_OrderId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_655f10514459daf453e41f31c05184fc>(ssConectaProveedores.RestRecords.RESTRC_655f10514459daf453e41f31c05184fc.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSpecialPostDeliveryAuthorizations")]
[RESTScreenServicesActionProperties(Name="GetSpecialPostDeliveryAuthorizations",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSpecialPostDeliveryAuthorizations(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Y+TV7QGweLMoZLG_kLPK+w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSpecialPostDeliveryAuthorizations_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSpecialPostDeliveryAuthorizations_maxRecords = 50;
} else {
datasetGetSpecialPostDeliveryAuthorizations_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSpecialPostDeliveryAuthorizations_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSpecialPostDeliveryAuthorizations_startIndex = 0;
} else {
datasetGetSpecialPostDeliveryAuthorizations_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSpecialPostDeliveryAuthorizations_maxRecords < 1)) {
datasetGetSpecialPostDeliveryAuthorizations_maxRecords = 1;
}

AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> ds_output = new AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetSpecialPostDeliveryAuthorizations(requestContext,datasetGetSpecialPostDeliveryAuthorizations_maxRecords,datasetGetSpecialPostDeliveryAuthorizations_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb>(ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProjectAssetServiceOtro")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetServiceOtro",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetServiceOtro(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "z8ETxh4PZYxYihpoWu9+nA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProjectAssetServiceOtro_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProjectAssetServiceOtro_maxRecords = 1;
} else {
datasetGetProjectAssetServiceOtro_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProjectAssetServiceOtro_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProjectAssetServiceOtro_startIndex = 0;
} else {
datasetGetProjectAssetServiceOtro_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProjectAssetServiceOtro_maxRecords < 1)) {
datasetGetProjectAssetServiceOtro_maxRecords = 1;
}

AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ds_output = new AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetProjectAssetServiceOtro(requestContext,datasetGetProjectAssetServiceOtro_maxRecords,datasetGetProjectAssetServiceOtro_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e>(ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetContractStatuses")]
[RESTScreenServicesActionProperties(Name="GetContractStatuses",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetContractStatuses(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "dl5W+NgcsOF6re7ASrOsKA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetContractStatuses_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetContractStatuses_maxRecords = 20;
} else {
datasetGetContractStatuses_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetContractStatuses_startIndex;
if((inputs.StartIndex == null)) {
datasetGetContractStatuses_startIndex = 0;
} else {
datasetGetContractStatuses_startIndex = inputs.StartIndex.Value;
}

if((datasetGetContractStatuses_maxRecords < 1)) {
datasetGetContractStatuses_maxRecords = 1;
}

AggregateRecord<RL_b597b6c7f7b0a874a3717792e87892bb> ds_output = new AggregateRecord<RL_b597b6c7f7b0a874a3717792e87892bb>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetContractStatuses(requestContext,datasetGetContractStatuses_maxRecords,datasetGetContractStatuses_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333>(ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSuppliers")]
[RESTScreenServicesActionProperties(Name="GetSuppliers",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSuppliers(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "MarLzvC0Ak57cuL9zvu4SQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSuppliers_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSuppliers_maxRecords = 999999999;
} else {
datasetGetSuppliers_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSuppliers_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSuppliers_startIndex = 0;
} else {
datasetGetSuppliers_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSuppliers_maxRecords < 1)) {
datasetGetSuppliers_maxRecords = 1;
}

AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ds_output = new AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetSuppliers(requestContext,datasetGetSuppliers_maxRecords,datasetGetSuppliers_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),model.ScreenDataSetGetOrderMainById.List.CurrentRec.ssENOrderMain.ssRegionId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e>(ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetPaymentOptions")]
[RESTScreenServicesActionProperties(Name="GetPaymentOptions",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentOptions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KbZTSZCiHg_XFOVlv16P7g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentOptions_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentOptions_maxRecords = 9999;
} else {
datasetGetPaymentOptions_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetPaymentOptions_startIndex;
if((inputs.StartIndex == null)) {
datasetGetPaymentOptions_startIndex = 0;
} else {
datasetGetPaymentOptions_startIndex = inputs.StartIndex.Value;
}

if((datasetGetPaymentOptions_maxRecords < 1)) {
datasetGetPaymentOptions_maxRecords = 1;
}

AggregateRecord<RL_251acb2daece433ee402c9709ec88356> ds_output = new AggregateRecord<RL_251acb2daece433ee402c9709ec88356>();
long count;
(ds_output.List,count) = await ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.datasetGetPaymentOptions(requestContext,datasetGetPaymentOptions_maxRecords,datasetGetPaymentOptions_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetOrderMainById.List.CurrentRec.ssENOrderDetail.ssPaymentOptionsId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2813028c34d1b3ce080a3e2c9febe797>(ssConectaProveedores.RestRecords.RESTRC_2813028c34d1b3ce080a3e2c9febe797.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetPaymentTermSpecial")]
[RESTScreenServicesActionProperties(Name="GetPaymentTermSpecial",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetPaymentTermSpecial(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "LgvHliYK+IN211qCoIq_3w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

long outParamId;
bool outParamIsActive;
(outParamId,outParamIsActive) = await model.DataActionGetPaymentTermSpecial(requestContext,cancellationToken);

var output = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetPaymentTermSpecial_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamId, outParamIsActive);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetOrderContractData")]
[RESTScreenServicesActionProperties(Name="GetOrderContractData",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrderContractData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "uLSW9dgaKiYPwp0+6Wa8ug", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractFile;
RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_AttachFilesList;
RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_ContractDepositList;
RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_ContractInsuranceList;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractAdvancePayment;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractPendingJustification;
(outParamo_ContractFile,outParamo_AttachFilesList,outParamo_ContractDepositList,outParamo_ContractInsuranceList,outParamo_ContractAdvancePayment,outParamo_ContractPendingJustification) = await model.DataActionGetOrderContractData(requestContext,cancellationToken);

var output = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderContractData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_ContractFile, outParamo_AttachFilesList, outParamo_ContractDepositList, outParamo_ContractInsuranceList, outParamo_ContractAdvancePayment, outParamo_ContractPendingJustification);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetOrderFilesList")]
[RESTScreenServicesActionProperties(Name="GetOrderFilesList",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetOrderFilesList(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "iwVgKLM44h5Mf9QfrdV7Rg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_FinanceAuthorization;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ProofOfForeignResidence;
(outParamo_FinanceAuthorization,outParamo_ProofOfForeignResidence) = await model.DataActionGetOrderFilesList(requestContext,cancellationToken);

var output = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderFilesList_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_FinanceAuthorization, outParamo_ProofOfForeignResidence);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetAccountingData")]
[RESTScreenServicesActionProperties(Name="GetAccountingData",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetAccountingData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Zd_MWC__YbLGroLDgfQTbw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = null;
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

try {model = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord outParamOrderAccounting;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ExchangeRateEvidence;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Estim_Equal_Agreed;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_CreditNote;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Voucher;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Finiquito;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Anticipo;
(outParamOrderAccounting,outParamo_ExchangeRateEvidence,outParamo_Estim_Equal_Agreed,outParamo_CreditNote,outParamo_Voucher,outParamo_Finiquito,outParamo_Anticipo) = await model.DataActionGetAccountingData(requestContext,cancellationToken);

var output = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetAccountingData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamOrderAccounting, outParamo_ExchangeRateEvidence, outParamo_Estim_Equal_Agreed, outParamo_CreditNote, outParamo_Voucher, outParamo_Finiquito, outParamo_Anticipo);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionApprovRejectOrder")]
[RESTScreenServicesActionProperties(Name="ApprovRejectOrder",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApprovRejectOrder(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XUq3ADSWmTtz946jlce+mA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionApprovRejectOrder_Model inputs = null;
Actions.lcoApprovRejectOrder res =  new Actions.lcoApprovRejectOrder();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionApprovRejectOrder_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionApprovRejectOrder(requestContext,inputs.inParami_OrderId,inputs.inParami_OrderApprovalLevelId,inputs.inParami_IsApprove,inputs.inParami_Reason,cancellationToken);

var output = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionApprovRejectOrder_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetIsUserCxP")]
[RESTScreenServicesActionProperties(Name="GetIsUserCxP",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetIsUserCxP(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "fta9NfmxtZhlAN71d2CU6w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        Actions.lcoGetIsUserCxP res =  new Actions.lcoGetIsUserCxP();CheckPermissionsIndex.CheckPermissionsAsync check;
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
res.outParamo_Value = await Actions.ActionGetIsUserCxP(requestContext,cancellationToken);

var output = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionGetIsUserCxP_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Value);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionSaveOrderDetail")]
[RESTScreenServicesActionProperties(Name="SaveOrderDetail",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionSaveOrderDetail(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8bUUYXRDhmNPVkKX04isBA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionSaveOrderDetail_Model inputs = null;
Actions.lcoSaveOrderDetail res =  new Actions.lcoSaveOrderDetail();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionSaveOrderDetail_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamErrorMsg = await Actions.ActionSaveOrderDetail(requestContext,inputs.inParamOrderMain,inputs.inParamOrderDetail,inputs.inParamOrderMainItemList,inputs.inParamOrderFiles,inputs.inParamOrderAccounting,inputs.inParamOrderAccConcept_EstimEqualAg,inputs.inParamOrderAccConcept_CreditNote,inputs.inParamOrderAccConcept_Voucher,inputs.inParamOrderAccConcept_Finiquito,inputs.inParamOrderAccConcept_Anticipo,inputs.inParamOrderRequestFiles,inputs.inParamIsFinish,cancellationToken);

var output = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionSaveOrderDetail_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamErrorMsg);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionSaveContractFile")]
[RESTScreenServicesActionProperties(Name="SaveContractFile",Screen="Wb_OrderDetailPaymentInformation",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionSaveContractFile(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Z8yqXl5OlSHTHLD8JQVLAQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionSaveContractFile_Model inputs = null;
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

try {inputs = RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ActionSaveContractFile_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionSaveContractFile(requestContext,inputs.inParami_OrderId,inputs.inParami_ContractFile,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
