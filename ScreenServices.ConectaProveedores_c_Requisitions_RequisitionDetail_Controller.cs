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
[Route("screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Requisitions_RequisitionDetail_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Requisitions_RequisitionDetail_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Requisitions_RequisitionDetail_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Requisitions_RequisitionDetail_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Requisitions_RequisitionDetail_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Requisitions_RequisitionDetail_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_ColumnsSmallRight_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_Status_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns2_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns4_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskCurrency_Controller", "InputMasks", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_CustomFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DropdownSearch_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssInputMasks.ScreenServices.InputMasks_InputMaskReactFlow_MaskText_Controller", "InputMasks", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_SearchDropdown_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssBigUpload.ScreenServices.BigUpload_BigUpload_wb_BigUploadSingleFile_Controller", "BigUpload", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_MultiFileUpload_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tag_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Sidebar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_y_Logs_Wb_RequisitionLogs_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_SearchSupplier_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_y_Utils_Wb_ConfirmPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssAutoRefreshUtils.ScreenServices.AutoRefreshUtils_Widget_EventExtensibilityBlock_Controller", "AutoRefreshUtils", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Controller", "OutSystemsUI", childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("c_Requisitions.RequisitionDetail"), ConectaProveedores_c_Requisitions_RequisitionDetail_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        {
bool check;
check = await ExtendedActions.CheckRequisicionesRole(requestContext,"",cancellationToken);
if(check) return;
}
{
bool check;
check = await ExtendedActions.CheckProveedorRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotProveedorRoleException( "Proveedor role required");

    }


    static ConectaProveedores_c_Requisitions_RequisitionDetail_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*c_Requisitions.RequisitionDetail.ShowHideModifyPopup*/"6dONWMH_kUW9Ti9X5sMIKA*AeYHAMtwlUyEtPEowL7e_A", 
/*RequisitionCancel*/"6dONWMH_kUW9Ti9X5sMIKA*j1PxAZK4I0mdoS1oqGZvYw", 
/*c_Requisitions.RequisitionDetail.GetIsForSpecialWorkflow*/"6dONWMH_kUW9Ti9X5sMIKA*2vDPBfurO0CrbCdYV38R_A", 
/*c_Requisitions.RequisitionDetail.ListOfFiles*/"6dONWMH_kUW9Ti9X5sMIKA*3s+NB3r300GfzSrQN9w0jQ", 
/*c_Requisitions.RequisitionDetail.AddRecord*/"6dONWMH_kUW9Ti9X5sMIKA*6ae6DL+Wn0GQzgUIKCJeaA", 
/*OutSystemsUI.SidebarOpen*/"Kn_hixxDWEm4lMd7mIpycQ*PN7rZt6KuU6Ljraavd2k6g", 
/*c_Requisitions.RequisitionDetail.ApproveRequisitionAccounting*/"6dONWMH_kUW9Ti9X5sMIKA*U1wdET7_0ka+JuJBOQ6PDA", 
/*GetIsCorporativoCxPFromUAR*/"6dONWMH_kUW9Ti9X5sMIKA*n_jJESxJ7E2wFcjf4JleuQ", 
/*c_Requisitions.RequisitionDetail.ShowHideAssignFirstApproverPopup*/"6dONWMH_kUW9Ti9X5sMIKA*l5csH4faKE2nfICuZpULJQ", 
/*c_Requisitions.RequisitionDetail.Dropdown_ServiceTypeOnChange*/"6dONWMH_kUW9Ti9X5sMIKA*NtUBJ+EMM0q_a2aQxSGETA", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*c_Requisitions.RequisitionDetail.ApproveRequisition*/"6dONWMH_kUW9Ti9X5sMIKA*jMb2LkGq60qT5ozTX7jCuQ", 
/*c_Requisitions.RequisitionDetail.ClearFields*/"6dONWMH_kUW9Ti9X5sMIKA*23mRNEd0EESkeuyuUcupEQ", 
/*c_Requisitions.RequisitionDetail.GetIsShowAssignFirstApproverPopup*/"6dONWMH_kUW9Ti9X5sMIKA*LAxLNYeqwUC_40my4HKcuA", 
/*OutSystemsUI.SidebarClose*/"Kn_hixxDWEm4lMd7mIpycQ*3R4D2mxED0erTuoiqqO3EA", 
/*OutSystemsUI.DropdownNotValid*/"Kn_hixxDWEm4lMd7mIpycQ*Isqu3ObtRUGvjEzTJaoyOw", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*System_.ListAppendAll*/"uXCIR2Atc0+es3zYuZSnNw*kwLtz+2X90KNWlolguyx2g", 
/*GenerateReqName*/"6dONWMH_kUW9Ti9X5sMIKA*jq+KV2KWK0mQFOjXHydjgA", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*GetIsForSpecialWorkflow*/"6dONWMH_kUW9Ti9X5sMIKA*bJyDdNot+UyeVUDTNbKYoQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*c_Requisitions.RequisitionDetail.Validations*/"6dONWMH_kUW9Ti9X5sMIKA*NqlAhIF5nU+r5A5OBbI4VA", 
/*c_Requisitions.RequisitionDetail.ShowHideSelectReqRegion_Popup*/"6dONWMH_kUW9Ti9X5sMIKA*4ERghh0ZY0W1vLibknJpXg", 
/*SaveRequisition*/"6dONWMH_kUW9Ti9X5sMIKA*4qYSh9j2mU+T92wuEKYtjg", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*System_.ListRemove*/"uXCIR2Atc0+es3zYuZSnNw*EL4Omu7NdEeReePEObsNOg", 
/*c_Requisitions.RequisitionDetail.ShowHideCancelPopup*/"6dONWMH_kUW9Ti9X5sMIKA*wQKEmNanTEuqpqcIbpJd5A", 
/*GetIsShowAssignFirstApproverPopup*/"6dONWMH_kUW9Ti9X5sMIKA*Nosut+W6D0C2EfpP4I7WxA", 
/*SaveContractPendingInfo*/"6dONWMH_kUW9Ti9X5sMIKA*ou9Tv9G1_UeHQqFLWGeQKQ", 
/*OutSystemsUI.DatePickerOpen*/"Kn_hixxDWEm4lMd7mIpycQ*cF6Lvs8h40Gf0c9ID_IYzg", 
/*c_Requisitions.RequisitionDetail.RecalculateTotalAmount*/"6dONWMH_kUW9Ti9X5sMIKA*O0zg1ILqtUSmmxWMtUx4Jw", 
/*ApprovModifReq*/"6dONWMH_kUW9Ti9X5sMIKA*jGDF2ZR+dE6qAkGMDb0puw", 
/*ApproveRequisitionAccounting*/"6dONWMH_kUW9Ti9X5sMIKA*DPEv4yXFRk2dHHTP0fBL2A", 
/*OutSystemsUI.DropdownClearValidation*/"Kn_hixxDWEm4lMd7mIpycQ*r2LVGF0gTk2QJHL5f8jtvA", 
/*c_Requisitions.RequisitionDetail.ShowHideSpecialOrNormalWorkflowPopup*/"6dONWMH_kUW9Ti9X5sMIKA*Hvkl8TKt0UWTjVnZIX8Ftw", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*GetUserRegion*/"6dONWMH_kUW9Ti9X5sMIKA*GfYo_CRmik2P_adc_RCpsA", 
/*c_Requisitions.RequisitionDetail.Wb_CustomUploadOnFileChange*/"6dONWMH_kUW9Ti9X5sMIKA*Uqww_0eaNkCRnPgUU0DY9Q", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_c_Requisitions_RequisitionDetail_Controller(
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
[Route("ScreenDataSetGetFrequencies")]
[RESTScreenServicesActionProperties(Name="GetFrequencies",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetFrequencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "AzjepyCQFApZH_95qbpcQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetFrequencies(requestContext,datasetGetFrequencies_maxRecords,datasetGetFrequencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetUserById")]
[RESTScreenServicesActionProperties(Name="GetUserById",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetUserById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Lu5CdVoA_dZJHFmwxG6+Sg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetUserById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetUserById_maxRecords = 1;
} else {
datasetGetUserById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetUserById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetUserById_startIndex = 0;
} else {
datasetGetUserById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetUserById_maxRecords < 1)) {
datasetGetUserById_maxRecords = 1;
}

AggregateRecord<RL_52a3075ea09fce1b2b3cbeb7d74742be> ds_output = new AggregateRecord<RL_52a3075ea09fce1b2b3cbeb7d74742be>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssApplicantId,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba>(ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetPaymentTerms")]
[RESTScreenServicesActionProperties(Name="GetPaymentTerms",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentTerms(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+6OhqwjTKpS9lXyr02rGqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentTerms_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentTerms_maxRecords = 50;
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetPaymentTerms(requestContext,datasetGetPaymentTerms_maxRecords,datasetGetPaymentTerms_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetSpecialPostDeliveryAuthorizations")]
[RESTScreenServicesActionProperties(Name="GetSpecialPostDeliveryAuthorizations",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSpecialPostDeliveryAuthorizations(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "Y+TV7QGweLMoZLG_kLPK+w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetSpecialPostDeliveryAuthorizations(requestContext,datasetGetSpecialPostDeliveryAuthorizations_maxRecords,datasetGetSpecialPostDeliveryAuthorizations_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetPaymentWays")]
[RESTScreenServicesActionProperties(Name="GetPaymentWays",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentWays(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ksLZ9v9fiVInXkNX+iiybw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetPaymentWays(requestContext,datasetGetPaymentWays_maxRecords,datasetGetPaymentWays_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssPaymentWaysId,cancellationToken);

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
[Route("ScreenDataSetGetAdvancedPaymentTypes")]
[RESTScreenServicesActionProperties(Name="GetAdvancedPaymentTypes",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAdvancedPaymentTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "hqarK6sC984ovwvfeAzylg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAdvancedPaymentTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAdvancedPaymentTypes_maxRecords = 200;
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetAdvancedPaymentTypes(requestContext,datasetGetAdvancedPaymentTypes_maxRecords,datasetGetAdvancedPaymentTypes_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGetProjectAssetServices")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetServices",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetServices(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "FfqLkGjlF9nFE9ew73TmYg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProjectAssetServices_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProjectAssetServices_maxRecords = model.varLcProjectAssetMaxRecord;
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetProjectAssetServices(requestContext,datasetGetProjectAssetServices_maxRecords,datasetGetProjectAssetServices_startIndex,IterationMultiplicity.Multiple,model.varLcProjectAssetSearchText,cancellationToken);

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
[Route("ScreenDataSetGetInsuranceTypes")]
[RESTScreenServicesActionProperties(Name="GetInsuranceTypes",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInsuranceTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "0kLj6620Ezk+l1bssUC0yw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetInsuranceTypes(requestContext,datasetGetInsuranceTypes_maxRecords,datasetGetInsuranceTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetCostCenters")]
[RESTScreenServicesActionProperties(Name="GetCostCenters",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCostCenters(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+LM+H9dP71kdpAQW3pvlww", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetCostCenters(requestContext,datasetGetCostCenters_maxRecords,datasetGetCostCenters_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssCompanyId,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssRegionId,model.varLcl_PreviousSelectedCostCenter,cancellationToken);

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
[Route("ScreenDataSetGetDocumentTypeAnticipoKW")]
[RESTScreenServicesActionProperties(Name="GetDocumentTypeAnticipoKW",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetDocumentTypeAnticipoKW(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "p8X4c++qiQB+kEcnXAkbTQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetDocumentTypeAnticipoKW_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetDocumentTypeAnticipoKW_maxRecords = 1;
} else {
datasetGetDocumentTypeAnticipoKW_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetDocumentTypeAnticipoKW_startIndex;
if((inputs.StartIndex == null)) {
datasetGetDocumentTypeAnticipoKW_startIndex = 0;
} else {
datasetGetDocumentTypeAnticipoKW_startIndex = inputs.StartIndex.Value;
}

if((datasetGetDocumentTypeAnticipoKW_maxRecords < 1)) {
datasetGetDocumentTypeAnticipoKW_maxRecords = 1;
}

AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> ds_output = new AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetDocumentTypeAnticipoKW(requestContext,datasetGetDocumentTypeAnticipoKW_maxRecords,datasetGetDocumentTypeAnticipoKW_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668>(ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetAccountableGuide")]
[RESTScreenServicesActionProperties(Name="GetAccountableGuide",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAccountableGuide(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "NRpuHi6Fm6RJclIzkTLvog", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAccountableGuide_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAccountableGuide_maxRecords = 1;
} else {
datasetGetAccountableGuide_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetAccountableGuide_startIndex;
if((inputs.StartIndex == null)) {
datasetGetAccountableGuide_startIndex = 0;
} else {
datasetGetAccountableGuide_startIndex = inputs.StartIndex.Value;
}

if((datasetGetAccountableGuide_maxRecords < 1)) {
datasetGetAccountableGuide_maxRecords = 1;
}

AggregateRecord<RL_369f9983c2b36180025202f97bb71651> ds_output = new AggregateRecord<RL_369f9983c2b36180025202f97bb71651>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetAccountableGuide(requestContext,datasetGetAccountableGuide_maxRecords,datasetGetAccountableGuide_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssProjectAssetServiceId,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssSupplierId,model.varLcl_SelectedAccount,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7>(ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetAccountingAccountsServiceTypes")]
[RESTScreenServicesActionProperties(Name="GetAccountingAccountsServiceTypes",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAccountingAccountsServiceTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "RQnj2rC7UL6_VGnODKsX3w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAccountingAccountsServiceTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAccountingAccountsServiceTypes_maxRecords = 999999999;
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetAccountingAccountsServiceTypes(requestContext,datasetGetAccountingAccountsServiceTypes_maxRecords,datasetGetAccountingAccountsServiceTypes_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGetSupplierSocieties")]
[RESTScreenServicesActionProperties(Name="GetSupplierSocieties",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierSocieties(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "5ASageWvg9Etl4rMFBZd6w", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSupplierSocieties_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSupplierSocieties_maxRecords = 999999999;
} else {
datasetGetSupplierSocieties_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSupplierSocieties_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSupplierSocieties_startIndex = 0;
} else {
datasetGetSupplierSocieties_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSupplierSocieties_maxRecords < 1)) {
datasetGetSupplierSocieties_maxRecords = 1;
}

AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> ds_output = new AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetSupplierSocieties(requestContext,datasetGetSupplierSocieties_maxRecords,datasetGetSupplierSocieties_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssSupplierId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561>(ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProjectAssetByRequisition")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetByRequisition",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetByRequisition(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "0v2_wm9N5CpeSe5v0O_kFg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProjectAssetByRequisition_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProjectAssetByRequisition_maxRecords = 1;
} else {
datasetGetProjectAssetByRequisition_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProjectAssetByRequisition_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProjectAssetByRequisition_startIndex = 0;
} else {
datasetGetProjectAssetByRequisition_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProjectAssetByRequisition_maxRecords < 1)) {
datasetGetProjectAssetByRequisition_maxRecords = 1;
}

AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ds_output = new AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetProjectAssetByRequisition(requestContext,datasetGetProjectAssetByRequisition_maxRecords,datasetGetProjectAssetByRequisition_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssProjectAssetServiceId,cancellationToken);

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
[Route("ScreenDataSetGetCurrencies")]
[RESTScreenServicesActionProperties(Name="GetCurrencies",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCurrencies(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f+VnB3EzqSeam1tAXE44KQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetCurrencies(requestContext,datasetGetCurrencies_maxRecords,datasetGetCurrencies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetPaymentOptions")]
[RESTScreenServicesActionProperties(Name="GetPaymentOptions",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentOptions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "KbZTSZCiHg_XFOVlv16P7g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetPaymentOptions(requestContext,datasetGetPaymentOptions_maxRecords,datasetGetPaymentOptions_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssPaymentOptionsId,cancellationToken);

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
[Route("ScreenDataSetGetSustainabilities")]
[RESTScreenServicesActionProperties(Name="GetSustainabilities",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSustainabilities(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "h7Vr7Bphk+yLg4jqz0eqPw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSustainabilities_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSustainabilities_maxRecords = 50;
} else {
datasetGetSustainabilities_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSustainabilities_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSustainabilities_startIndex = 0;
} else {
datasetGetSustainabilities_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSustainabilities_maxRecords < 1)) {
datasetGetSustainabilities_maxRecords = 1;
}

AggregateRecord<RL_c861661ffef6a96c498651ed1efeee53> ds_output = new AggregateRecord<RL_c861661ffef6a96c498651ed1efeee53>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetSustainabilities(requestContext,datasetGetSustainabilities_maxRecords,datasetGetSustainabilities_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f>(ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetInvoiceUsages")]
[RESTScreenServicesActionProperties(Name="GetInvoiceUsages",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceUsages(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9K4ozixnDaUYQeFRQ9_iQQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetInvoiceUsages(requestContext,datasetGetInvoiceUsages_maxRecords,datasetGetInvoiceUsages_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetCostCenterSAPByRequisitionId")]
[RESTScreenServicesActionProperties(Name="GetCostCenterSAPByRequisitionId",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCostCenterSAPByRequisitionId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "egVcIAqcw3AuF356OfR6TQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCostCenterSAPByRequisitionId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCostCenterSAPByRequisitionId_maxRecords = 1;
} else {
datasetGetCostCenterSAPByRequisitionId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCostCenterSAPByRequisitionId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCostCenterSAPByRequisitionId_startIndex = 0;
} else {
datasetGetCostCenterSAPByRequisitionId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCostCenterSAPByRequisitionId_maxRecords < 1)) {
datasetGetCostCenterSAPByRequisitionId_maxRecords = 1;
}

AggregateRecord<RL_40d1dae5da886b385f88ea5c5c7574ca> ds_output = new AggregateRecord<RL_40d1dae5da886b385f88ea5c5c7574ca>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetCostCenterSAPByRequisitionId(requestContext,datasetGetCostCenterSAPByRequisitionId_maxRecords,datasetGetCostCenterSAPByRequisitionId_startIndex,IterationMultiplicity.Multiple,model.inParami_RequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_cc5b09a13023b24fea23c488b525369e>(ssConectaProveedores.RestRecords.RESTRC_cc5b09a13023b24fea23c488b525369e.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetProjectAssetServiceOtro")]
[RESTScreenServicesActionProperties(Name="GetProjectAssetServiceOtro",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProjectAssetServiceOtro(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "z8ETxh4PZYxYihpoWu9+nA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetProjectAssetServiceOtro(requestContext,datasetGetProjectAssetServiceOtro_maxRecords,datasetGetProjectAssetServiceOtro_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetPaymentWay99")]
[RESTScreenServicesActionProperties(Name="GetPaymentWay99",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentWay99(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "VbVapBl_e7phISAELyWS_A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetPaymentWay99_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetPaymentWay99_maxRecords = 1;
} else {
datasetGetPaymentWay99_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetPaymentWay99_startIndex;
if((inputs.StartIndex == null)) {
datasetGetPaymentWay99_startIndex = 0;
} else {
datasetGetPaymentWay99_startIndex = inputs.StartIndex.Value;
}

if((datasetGetPaymentWay99_maxRecords < 1)) {
datasetGetPaymentWay99_maxRecords = 1;
}

AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ds_output = new AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetPaymentWay99(requestContext,datasetGetPaymentWay99_maxRecords,datasetGetPaymentWay99_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[RESTScreenServicesActionProperties(Name="GetAccountingDataTypes",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetAccountingDataTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "oTqvoifuD3rqjmlGN6zMaQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetAccountingDataTypes_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetAccountingDataTypes_maxRecords = 200;
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetAccountingDataTypes(requestContext,datasetGetAccountingDataTypes_maxRecords,datasetGetAccountingDataTypes_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

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
[Route("ScreenDataSetGetServiceFormats")]
[RESTScreenServicesActionProperties(Name="GetServiceFormats",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetServiceFormats(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "M4kJHcj4X_mBfDg0VDbLPg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetServiceFormats_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetServiceFormats_maxRecords = 50;
} else {
datasetGetServiceFormats_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetServiceFormats_startIndex;
if((inputs.StartIndex == null)) {
datasetGetServiceFormats_startIndex = 0;
} else {
datasetGetServiceFormats_startIndex = inputs.StartIndex.Value;
}

if((datasetGetServiceFormats_maxRecords < 1)) {
datasetGetServiceFormats_maxRecords = 1;
}

AggregateRecord<RL_2ce058321dad3f60357fc3b3372ccb1e> ds_output = new AggregateRecord<RL_2ce058321dad3f60357fc3b3372ccb1e>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetServiceFormats(requestContext,datasetGetServiceFormats_maxRecords,datasetGetServiceFormats_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df>(ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetDistributions")]
[RESTScreenServicesActionProperties(Name="GetDistributions",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetDistributions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "uJgw9gaFXhq9IagWfEabsw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetDistributions_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetDistributions_maxRecords = 50;
} else {
datasetGetDistributions_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetDistributions_startIndex;
if((inputs.StartIndex == null)) {
datasetGetDistributions_startIndex = 0;
} else {
datasetGetDistributions_startIndex = inputs.StartIndex.Value;
}

if((datasetGetDistributions_maxRecords < 1)) {
datasetGetDistributions_maxRecords = 1;
}

AggregateRecord<RL_63e875add2b98c15e5030850edd3b2eb> ds_output = new AggregateRecord<RL_63e875add2b98c15e5030850edd3b2eb>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetDistributions(requestContext,datasetGetDistributions_maxRecords,datasetGetDistributions_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185>(ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetBusinessValueCategories")]
[RESTScreenServicesActionProperties(Name="GetBusinessValueCategories",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetBusinessValueCategories(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3K1jXP9IJF_nMwQ5zqcRyg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetBusinessValueCategories_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetBusinessValueCategories_maxRecords = 200;
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetBusinessValueCategories(requestContext,datasetGetBusinessValueCategories_maxRecords,datasetGetBusinessValueCategories_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetRequisitionServicesByRequisitionId")]
[RESTScreenServicesActionProperties(Name="GetRequisitionServicesByRequisitionId",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionServicesByRequisitionId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "v7fwvkjFtbFu2_BtuhfbSQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionServicesByRequisitionId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionServicesByRequisitionId_maxRecords = 50;
} else {
datasetGetRequisitionServicesByRequisitionId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionServicesByRequisitionId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionServicesByRequisitionId_startIndex = 0;
} else {
datasetGetRequisitionServicesByRequisitionId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionServicesByRequisitionId_maxRecords < 1)) {
datasetGetRequisitionServicesByRequisitionId_maxRecords = 1;
}

AggregateRecord<RL_b47d9310671b1b627f451a333bb8980a> ds_output = new AggregateRecord<RL_b47d9310671b1b627f451a333bb8980a>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetRequisitionServicesByRequisitionId(requestContext,datasetGetRequisitionServicesByRequisitionId_maxRecords,datasetGetRequisitionServicesByRequisitionId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_RequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6>(ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetBusinessValueSubcategoriesByCategoryId")]
[RESTScreenServicesActionProperties(Name="GetBusinessValueSubcategoriesByCategoryId",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OPm1pOj_KeAJWjXogYPfSQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetBusinessValueSubcategoriesByCategoryId(requestContext,datasetGetBusinessValueSubcategoriesByCategoryId_maxRecords,datasetGetBusinessValueSubcategoriesByCategoryId_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssBusinessValueCategoryId,cancellationToken);

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
[Route("ScreenDataSetGetEntraRole")]
[RESTScreenServicesActionProperties(Name="GetEntraRole",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetEntraRole(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7qyGTC_5OnA_VV8+D1QF6g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetEntraRole_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetEntraRole_maxRecords = 1;
} else {
datasetGetEntraRole_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetEntraRole_startIndex;
if((inputs.StartIndex == null)) {
datasetGetEntraRole_startIndex = 0;
} else {
datasetGetEntraRole_startIndex = inputs.StartIndex.Value;
}

if((datasetGetEntraRole_maxRecords < 1)) {
datasetGetEntraRole_maxRecords = 1;
}

AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ds_output = new AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetEntraRole(requestContext,datasetGetEntraRole_maxRecords,datasetGetEntraRole_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b>(ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRequisitionCostCentersByRequisitionId")]
[RESTScreenServicesActionProperties(Name="GetRequisitionCostCentersByRequisitionId",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionCostCentersByRequisitionId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "XxcC4JaQe14aT0KZ6nVfHA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionCostCentersByRequisitionId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionCostCentersByRequisitionId_maxRecords = 999999;
} else {
datasetGetRequisitionCostCentersByRequisitionId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionCostCentersByRequisitionId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionCostCentersByRequisitionId_startIndex = 0;
} else {
datasetGetRequisitionCostCentersByRequisitionId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionCostCentersByRequisitionId_maxRecords < 1)) {
datasetGetRequisitionCostCentersByRequisitionId_maxRecords = 1;
}

AggregateRecord<RL_a3213f63c9dee3312d82d37ec604d349> ds_output = new AggregateRecord<RL_a3213f63c9dee3312d82d37ec604d349>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetRequisitionCostCentersByRequisitionId(requestContext,datasetGetRequisitionCostCentersByRequisitionId_maxRecords,datasetGetRequisitionCostCentersByRequisitionId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.inParami_RequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02>(ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSupplierByRequisition")]
[RESTScreenServicesActionProperties(Name="GetSupplierByRequisition",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierByRequisition(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "H3U5Elt6W9ibSLwdPH1HvQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetSupplierByRequisition(requestContext,datasetGetSupplierByRequisition_maxRecords,datasetGetSupplierByRequisition_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssSupplierId,cancellationToken);

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
[Route("ScreenDataSetGetDocumentTypeKR")]
[RESTScreenServicesActionProperties(Name="GetDocumentTypeKR",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetDocumentTypeKR(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "VYLcnqZUXHgUsGI2Lwn0vQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetDocumentTypeKR_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetDocumentTypeKR_maxRecords = 1;
} else {
datasetGetDocumentTypeKR_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetDocumentTypeKR_startIndex;
if((inputs.StartIndex == null)) {
datasetGetDocumentTypeKR_startIndex = 0;
} else {
datasetGetDocumentTypeKR_startIndex = inputs.StartIndex.Value;
}

if((datasetGetDocumentTypeKR_maxRecords < 1)) {
datasetGetDocumentTypeKR_maxRecords = 1;
}

AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> ds_output = new AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetDocumentTypeKR(requestContext,datasetGetDocumentTypeKR_maxRecords,datasetGetDocumentTypeKR_startIndex,IterationMultiplicity.Multiple,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668>(ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSupplierDetailBySociety")]
[RESTScreenServicesActionProperties(Name="GetSupplierDetailBySociety",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierDetailBySociety(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "bNncmvAfcGecixzi0Z4SCQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSupplierDetailBySociety_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSupplierDetailBySociety_maxRecords = 1;
} else {
datasetGetSupplierDetailBySociety_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSupplierDetailBySociety_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSupplierDetailBySociety_startIndex = 0;
} else {
datasetGetSupplierDetailBySociety_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSupplierDetailBySociety_maxRecords < 1)) {
datasetGetSupplierDetailBySociety_maxRecords = 1;
}

AggregateRecord<RL_10b798eceef0c61e2eb85d7fd35e40d6> ds_output = new AggregateRecord<RL_10b798eceef0c61e2eb85d7fd35e40d6>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetSupplierDetailBySociety(requestContext,datasetGetSupplierDetailBySociety_maxRecords,datasetGetSupplierDetailBySociety_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssCompanyId,model.ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisition.ssSupplierId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684>(ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetRequisitionById")]
[RESTScreenServicesActionProperties(Name="GetRequisitionById",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRequisitionById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "vn3eWcmXpi4h1XT38BEXtw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetRequisitionById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetRequisitionById_maxRecords = 1;
} else {
datasetGetRequisitionById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetRequisitionById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetRequisitionById_startIndex = 0;
} else {
datasetGetRequisitionById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetRequisitionById_maxRecords < 1)) {
datasetGetRequisitionById_maxRecords = 1;
}

AggregateRecord<RL_db407242f011e8b84a110f6970108663> ds_output = new AggregateRecord<RL_db407242f011e8b84a110f6970108663>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),model.varLcGetUserApplicationRoles.outParamCanUploadInvoices,model.varLcGetUserApplicationRoles.outParamIsCorporativoCxP,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),3,false,true,cancellationToken)),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),3,false,true,cancellationToken)),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),3,true,false,cancellationToken)),(await Functions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),3,true,false,cancellationToken)),(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),model.inParami_RequisitionId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_db730a379abf48e3725f395a2176e12f>(ssConectaProveedores.RestRecords.RESTRC_db730a379abf48e3725f395a2176e12f.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetDepositTypes")]
[RESTScreenServicesActionProperties(Name="GetDepositTypes",Screen="RequisitionDetail",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetDepositTypes(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "xNMlgKuJEXDYt59dj4cBjw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.datasetGetDepositTypes(requestContext,datasetGetDepositTypes_maxRecords,datasetGetDepositTypes_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("DataActionGetRequisitionContractData")]
[RESTScreenServicesActionProperties(Name="GetRequisitionContractData",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetRequisitionContractData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "WBgpQ6OUgFPnH3xosJkMEw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractFile;
RL_7a479a555821b093171c5d3cd3382006 outParamo_AttachFilesList;
RL_7a479a555821b093171c5d3cd3382006 outParamo_ContractDepositList;
RL_7a479a555821b093171c5d3cd3382006 outParamo_ContractInsuranceList;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractAdvancePayment;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractPendingJustification;
(outParamo_ContractFile,outParamo_AttachFilesList,outParamo_ContractDepositList,outParamo_ContractInsuranceList,outParamo_ContractAdvancePayment,outParamo_ContractPendingJustification) = await model.DataActionGetRequisitionContractData(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionContractData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_ContractFile, outParamo_AttachFilesList, outParamo_ContractDepositList, outParamo_ContractInsuranceList, outParamo_ContractAdvancePayment, outParamo_ContractPendingJustification);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetShowSelectReqPopup")]
[RESTScreenServicesActionProperties(Name="GetShowSelectReqPopup",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetShowSelectReqPopup(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "fdlE3m1sueTKOTiLgX90jQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamIsCorporativo;
outParamIsCorporativo = await model.DataActionGetShowSelectReqPopup(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowSelectReqPopup_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamIsCorporativo);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetAdvWithoutInvoiceData")]
[RESTScreenServicesActionProperties(Name="GetAdvWithoutInvoiceData",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetAdvWithoutInvoiceData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "UZZytAEkoL_4U2gTS6zd1g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_AdvWithoutInvoice;
outParamo_AdvWithoutInvoice = await model.DataActionGetAdvWithoutInvoiceData(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAdvWithoutInvoiceData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_AdvWithoutInvoice);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetConfiguration")]
[RESTScreenServicesActionProperties(Name="GetConfiguration",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetConfiguration(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8byajVrg1APzv75RPoiseQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int outParamUploadContractDateLimit;
outParamUploadContractDateLimit = await model.DataActionGetConfiguration(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetConfiguration_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUploadContractDateLimit);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetAccountingData")]
[RESTScreenServicesActionProperties(Name="GetAccountingData",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetAccountingData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "3l9EW4D2qrCaBdpzAbvkww", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord outParamRequisitionAccounting;
RC_cdb29de40f41bea5403aac7edb2d6159 outParamo_Estim_Equal_Agreed;
RL_7c236018492d50b3625a5b0d981eb4eb outParamo_Remaining;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamExchangeRateEvidence;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamREPSE;
(outParamRequisitionAccounting,outParamo_Estim_Equal_Agreed,outParamo_Remaining,outParamExchangeRateEvidence,outParamREPSE) = await model.DataActionGetAccountingData(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAccountingData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamRequisitionAccounting, outParamo_Estim_Equal_Agreed, outParamo_Remaining, outParamExchangeRateEvidence, outParamREPSE);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetShowIsDonation")]
[RESTScreenServicesActionProperties(Name="GetShowIsDonation",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetShowIsDonation(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "aM_9sbl5NECc6IM67cP6KQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamo_Show;
outParamo_Show = await model.DataActionGetShowIsDonation(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_Show);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetSettings")]
[RESTScreenServicesActionProperties(Name="GetSettings",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSettings(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nwGBi8iduWl5+EjGVzenpA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

bool outParamo_IsActiveServiceTypeEXP1;
outParamo_IsActiveServiceTypeEXP1 = await model.DataActionGetSettings(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetSettings_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_IsActiveServiceTypeEXP1);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetRequisitionFiles")]
[RESTScreenServicesActionProperties(Name="GetRequisitionFiles",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetRequisitionFiles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "cqjMuq5xj+mTS2d7OPKW0Q", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_FinanceAuthorization;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ProofOfForeignResidence;
(outParamo_FinanceAuthorization,outParamo_ProofOfForeignResidence) = await model.DataActionGetRequisitionFiles(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionFiles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamo_FinanceAuthorization, outParamo_ProofOfForeignResidence);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetUserApplicationRoles")]
[RESTScreenServicesActionProperties(Name="GetUserApplicationRoles",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetUserApplicationRoles(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "LMoeEqUnWN1DWSkmmaKOUw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamListText;
bool outParamIsCorporativoCxP;
bool outParamCanUploadInvoices;
string outParamTelcelDirectionsListText;
bool outParamIsSegmentationCorporativo;
long outParamCorporativoRegionId;
(outParamUserRolesList,outParamListText,outParamIsCorporativoCxP,outParamCanUploadInvoices,outParamTelcelDirectionsListText,outParamIsSegmentationCorporativo,outParamCorporativoRegionId) = await model.DataActionGetUserApplicationRoles(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamUserRolesList, outParamListText, outParamIsCorporativoCxP, outParamCanUploadInvoices, outParamTelcelDirectionsListText, outParamIsSegmentationCorporativo, outParamCorporativoRegionId);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("DataActionGetPaymentMethodsBySupplierId")]
[RESTScreenServicesActionProperties(Name="GetPaymentMethodsBySupplierId",Screen="RequisitionDetail",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetPaymentMethodsBySupplierId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "kr7Jgm25OPydEuZYV6NPVA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

RL_58f754227b79b8198980a29045fa5b11 outParamList;
outParamList = await model.DataActionGetPaymentMethodsBySupplierId(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetIsForSpecialWorkflow")]
[RESTScreenServicesActionProperties(Name="GetIsForSpecialWorkflow",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetIsForSpecialWorkflow(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nyveEdaaGnRJsHq2FgEAQw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Model inputs = null;
Actions.lcoGetIsForSpecialWorkflow res =  new Actions.lcoGetIsForSpecialWorkflow();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamIsForSpecialWorkflow = await Actions.ActionGetIsForSpecialWorkflow(requestContext,inputs.inParamUserId,inputs.inParamIsDonation,inputs.inParamProcessTypeCode,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsForSpecialWorkflow_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamIsForSpecialWorkflow);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionApproveRequisitionAccounting")]
[RESTScreenServicesActionProperties(Name="ApproveRequisitionAccounting",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApproveRequisitionAccounting(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "OWWgmAXRbJoQaxVkmZo_EA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Model inputs = null;
Actions.lcoApproveRequisitionAccounting res =  new Actions.lcoApproveRequisitionAccounting();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionApproveRequisitionAccounting(requestContext,inputs.inParami_Requisition,inputs.inParami_RequisitionApprovalLevelId,inputs.inParamOffsetUtc,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApproveRequisitionAccounting_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionRequisitionCancel")]
[RESTScreenServicesActionProperties(Name="RequisitionCancel",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionRequisitionCancel(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "t_Cz8TUtEbxHcmD_3NS1BQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionRequisitionCancel_Model inputs = null;
Actions.lcoRequisitionCancel res =  new Actions.lcoRequisitionCancel();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionRequisitionCancel_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionRequisitionCancel(requestContext,inputs.inParami_RequisitionId,inputs.inParami_RequisitionApprovalLevelId,inputs.inParami_CancelReason,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionRequisitionCancel_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetIsCorporativoCxPFromUAR")]
[RESTScreenServicesActionProperties(Name="GetIsCorporativoCxPFromUAR",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetIsCorporativoCxPFromUAR(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7YjwFrGkIiE_47Mb_0MgLw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Model inputs = null;
Actions.lcoGetIsCorporativoCxPFromUAR res =  new Actions.lcoGetIsCorporativoCxPFromUAR();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_IsFromCorporativo = await Actions.ActionGetIsCorporativoCxPFromUAR(requestContext,inputs.inParami_ConceptId,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_IsFromCorporativo);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionApprovModifReq")]
[RESTScreenServicesActionProperties(Name="ApprovModifReq",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionApprovModifReq(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "edod8NCxISGEGK70q5rSdA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionApprovModifReq_Model inputs = null;
Actions.lcoApprovModifReq res =  new Actions.lcoApprovModifReq();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApprovModifReq_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionApprovModifReq(requestContext,inputs.inParami_RequisitionId,inputs.inParami_RequisitionApprovalLevelId,inputs.inParami_IsApprove,inputs.inParami_Comment,inputs.inParamOffsetUtc,inputs.inParami_GetUserId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionApprovModifReq_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGetIsShowAssignFirstApproverPopup")]
[RESTScreenServicesActionProperties(Name="GetIsShowAssignFirstApproverPopup",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGetIsShowAssignFirstApproverPopup(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "JGsXGIRYn8uOWvGvhG5tUA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsShowAssignFirstApproverPopup_Model inputs = null;
Actions.lcoGetIsShowAssignFirstApproverPopup res =  new Actions.lcoGetIsShowAssignFirstApproverPopup();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsShowAssignFirstApproverPopup_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamIsShow = await Actions.ActionGetIsShowAssignFirstApproverPopup(requestContext,inputs.inParamUserId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsShowAssignFirstApproverPopup_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamIsShow);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionSaveRequisition")]
[RESTScreenServicesActionProperties(Name="SaveRequisition",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionSaveRequisition(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "MDGWDzgVlPO4OgHad5sFUA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Model inputs = null;
Actions.lcoSaveRequisition res =  new Actions.lcoSaveRequisition();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
(res.outParamo_Output,res.outParamo_RequisitionId,res.outParamo_HasChangedStatus) = await Actions.ActionSaveRequisition(requestContext,inputs.inParami_Requisition,inputs.inParami_IsFinishCapture,inputs.inParami_IsNewVersion,inputs.inParami_CreateForUser,inputs.inParamApprovalProcessId,cancellationToken);

var output = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output, res.outParamo_RequisitionId, res.outParamo_HasChangedStatus);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionSaveContractPendingInfo")]
[RESTScreenServicesActionProperties(Name="SaveContractPendingInfo",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionSaveContractPendingInfo(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "8TJhVlKyY1M6AGLprL2y7A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveContractPendingInfo_Model inputs = null;
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

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveContractPendingInfo_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionSaveContractPendingInfo(requestContext,inputs.inParami_Requisition,inputs.inParami_RequisitionFileTypesStruct,inputs.inParami_OG_DateOfCommitment,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="RequisitionDetail",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Requisitions_RequisitionDetail_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}
}
