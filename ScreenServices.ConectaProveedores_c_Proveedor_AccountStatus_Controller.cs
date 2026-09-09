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
[Route("screenservices/ConectaProveedores/c_Proveedor/AccountStatus")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Proveedor_AccountStatus_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Proveedor_AccountStatus_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Proveedor_AccountStatus_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Proveedor_AccountStatus_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Proveedor_AccountStatus_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Proveedor_AccountStatus_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_a_Layouts_LayoutTopMenu_Controller.ProxyInstance, childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_Tooltip_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_DatePicker_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Adaptive_Columns3_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Tabs_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsHeaderItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_TabsContentItem_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfDebounce.ScreenServices.CloneOfDebounce_DebounceFlow_Debounce_Controller", "CloneOfDebounce", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Navigation_Pagination_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("c_Proveedor.AccountStatus"), ConectaProveedores_c_Proveedor_AccountStatus_Controller.CheckPermissionsAsync);
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
check = await ExtendedActions.CheckProveedorRole(requestContext,"",cancellationToken);
if(check) return;
}
throw new Ex_NotProveedorRoleException( "Proveedor role required");

    }


    static ConectaProveedores_c_Proveedor_AccountStatus_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*c_Proveedor.AccountStatus.ShowDataFiltered*/"6dONWMH_kUW9Ti9X5sMIKA*eLegFoSbxU2LcgtYWnDihg", 
/*AuditCreateWrapper*/"6dONWMH_kUW9Ti9X5sMIKA*S0jtKfG3KkOVGGsZs_98+Q", 
/*ShowLoading*/"6dONWMH_kUW9Ti9X5sMIKA*SFqhTgBHTkO5R1tZlKplKQ", 
/*GenerateCurrentAccountPdf*/"6dONWMH_kUW9Ti9X5sMIKA*AIkOY4b0dEuAJ4GUqMg7oA", 
/*System_.ListAppend*/"uXCIR2Atc0+es3zYuZSnNw*HgJbqjfpgEuis8lbQzmhHQ", 
/*ExportProviderCurrentAccountExcel*/"6dONWMH_kUW9Ti9X5sMIKA*Fq8ObgCWgEmy7WX2znhnCQ", 
/*System_.ListFilter*/"uXCIR2Atc0+es3zYuZSnNw*UsE3UVlN9ki4bra457HhYA", 
/*GenerateCurrentAccountCSV*/"6dONWMH_kUW9Ti9X5sMIKA*NDl0g5A8hkqshFx4iEQofg", 
/*HideLoading*/"6dONWMH_kUW9Ti9X5sMIKA*TXlNjGjwckyPJ8Abp3j_LA", 
/*c_Proveedor.AccountStatus.ShowData*/"6dONWMH_kUW9Ti9X5sMIKA*uPMixueZM0Co05ID8B+YXA", 
/*System_.ListClear*/"uXCIR2Atc0+es3zYuZSnNw*veU0xTJwTE2X4au_He4_vw", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_c_Proveedor_AccountStatus_Controller(
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
[Route("ScreenDataSetGetSupplierUserByUserId")]
[RESTScreenServicesActionProperties(Name="GetSupplierUserByUserId",Screen="AccountStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierUserByUserId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "qf8IZArR62nE7JhJxPcuZw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSupplierUserByUserId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSupplierUserByUserId_maxRecords = 1;
} else {
datasetGetSupplierUserByUserId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSupplierUserByUserId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSupplierUserByUserId_startIndex = 0;
} else {
datasetGetSupplierUserByUserId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSupplierUserByUserId_maxRecords < 1)) {
datasetGetSupplierUserByUserId_maxRecords = 1;
}

AggregateRecord<RL_5859a4306a0de95c2b5c534d5cfa7150> ds_output = new AggregateRecord<RL_5859a4306a0de95c2b5c534d5cfa7150>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.datasetGetSupplierUserByUserId(requestContext,datasetGetSupplierUserByUserId_maxRecords,datasetGetSupplierUserByUserId_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4>(ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ScreenDataSetGetSupplierDetailsBySupplierId")]
[RESTScreenServicesActionProperties(Name="GetSupplierDetailsBySupplierId",Screen="AccountStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierDetailsBySupplierId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "gwaHwYI_e_5qCt_Z79NOaA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetSupplierDetailsBySupplierId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetSupplierDetailsBySupplierId_maxRecords = 999999999;
} else {
datasetGetSupplierDetailsBySupplierId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetSupplierDetailsBySupplierId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetSupplierDetailsBySupplierId_startIndex = 0;
} else {
datasetGetSupplierDetailsBySupplierId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetSupplierDetailsBySupplierId_maxRecords < 1)) {
datasetGetSupplierDetailsBySupplierId_maxRecords = 1;
}

AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> ds_output = new AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.datasetGetSupplierDetailsBySupplierId(requestContext,datasetGetSupplierDetailsBySupplierId_maxRecords,datasetGetSupplierDetailsBySupplierId_startIndex,IterationMultiplicity.Multiple,model.ScreenDataSetGetSupplierUserByUserId.List.CurrentRec.ssENSupplier.ssId,cancellationToken);

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
[Route("ScreenDataSetGetPaymentTerms")]
[RESTScreenServicesActionProperties(Name="GetPaymentTerms",Screen="AccountStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentTerms(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+6OhqwjTKpS9lXyr02rGqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.datasetGetPaymentTerms(requestContext,datasetGetPaymentTerms_maxRecords,datasetGetPaymentTerms_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("ScreenDataSetGetRegions")]
[RESTScreenServicesActionProperties(Name="GetRegions",Screen="AccountStatus",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetRegions(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "F9suSx2_X8+qIMY5h0gbYw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("DataActionGetSapData")]
[RESTScreenServicesActionProperties(Name="GetSapData",Screen="AccountStatus",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSapData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f4Ax0UdABchGTjINnLPsng", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_382afa1d8361f400b6ea03403d75e294Structure outParamList;
decimal outParamTotalenmonedanacional;
decimal outParamImportetotaldefacturasmonedaextranjera;
decimal outParamTotalenmonedanacional2;
decimal outParamImportetotaldefacturasmonedaextranjera2;
(outParamList,outParamTotalenmonedanacional,outParamImportetotaldefacturasmonedaextranjera,outParamTotalenmonedanacional2,outParamImportetotaldefacturasmonedaextranjera2) = await model.DataActionGetSapData(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList, outParamTotalenmonedanacional, outParamImportetotaldefacturasmonedaextranjera, outParamTotalenmonedanacional2, outParamImportetotaldefacturasmonedaextranjera2);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionAuditCreateWrapper")]
[RESTScreenServicesActionProperties(Name="AuditCreateWrapper",Screen="AccountStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAuditCreateWrapper(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "R9ncJjtM_dSZmMkM5XAN_g", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ActionAuditCreateWrapper_Model inputs = null;
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

try {inputs = RESTConectaProveedores_c_Proveedor_AccountStatus_ActionAuditCreateWrapper_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
await Actions.ActionAuditCreateWrapper(requestContext,inputs.inParamSource,cancellationToken);

var output = new Payload.EmptyDataPayload();
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGenerateCurrentAccountPdf")]
[RESTScreenServicesActionProperties(Name="GenerateCurrentAccountPdf",Screen="AccountStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGenerateCurrentAccountPdf(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "nMPxl6a3UHL2IVmoCk3jNw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Model inputs = null;
Actions.lcoGenerateCurrentAccountPdf res =  new Actions.lcoGenerateCurrentAccountPdf();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_file = await Actions.ActionGenerateCurrentAccountPdf(requestContext,inputs.inParamI_ACREEDOR,inputs.inParamI_ANTICIPOS_HIGH,inputs.inParamI_ANTICIPOS_LOW,inputs.inParamI_F_PARTABIE,inputs.inParamI_PCOMP_HIGH,inputs.inParamI_PCOMP_LOW,inputs.inParamI_REGION,inputs.inParamI_SOCIEDAD,cancellationToken);

var output = RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_file);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionExportProviderCurrentAccountExcel")]
[RESTScreenServicesActionProperties(Name="ExportProviderCurrentAccountExcel",Screen="AccountStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionExportProviderCurrentAccountExcel(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "6nGOehgd+Tf6ZazPgWZyug", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ActionExportProviderCurrentAccountExcel_Model inputs = null;
Actions.lcoExportProviderCurrentAccountExcel res =  new Actions.lcoExportProviderCurrentAccountExcel();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Proveedor_AccountStatus_ActionExportProviderCurrentAccountExcel_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamfile = await Actions.ActionExportProviderCurrentAccountExcel(requestContext,inputs.inParamResponse,cancellationToken);

var output = RESTConectaProveedores_c_Proveedor_AccountStatus_ActionExportProviderCurrentAccountExcel_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamfile);
return output;


    }, cancellationToken);
}[HttpPost]
[Route("ActionGenerateCurrentAccountCSV")]
[RESTScreenServicesActionProperties(Name="GenerateCurrentAccountCSV",Screen="AccountStatus",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionGenerateCurrentAccountCSV(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "eViix+lX6IHVNxOO94L_rg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountCSV_Model inputs = null;
Actions.lcoGenerateCurrentAccountCSV res =  new Actions.lcoGenerateCurrentAccountCSV();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountCSV_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamfile = await Actions.ActionGenerateCurrentAccountCSV(requestContext,inputs.inParamResponse,cancellationToken);

var output = RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountCSV_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamfile);
return output;


    }, cancellationToken);
}
}
