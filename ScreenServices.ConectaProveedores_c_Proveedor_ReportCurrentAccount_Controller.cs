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
[Route("screenservices/ConectaProveedores/c_Proveedor/ReportCurrentAccount")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssUltimatePDF.ScreenServices.UltimatePDF_PrintLayout_ScreenToPDF_Controller", "UltimatePDF", childControllers);
SafeAddChildController("ssUltimatePDF.ScreenServices.UltimatePDF_PrintLayout_PrintLayout_Controller", "UltimatePDF", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_Controller.ProxyInstance, childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                Permissions.AddAsyncCheckPermissions(new ScreenName("c_Proveedor.ReportCurrentAccount"), ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller.CheckPermissionsAsync);
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }


    public static async Task CheckPermissionsAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        return;

    }


    static ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*System_.SetCurrentLocale*/"uXCIR2Atc0+es3zYuZSnNw*RYFw8sBg3EmaGosPH65dzg", 
/*a_Common.OnException*/"6dONWMH_kUW9Ti9X5sMIKA*B4kRGvrnOEmQonA8ir4Pyg.#FlowExceptionHandler"});

    }

    public ConectaProveedores_c_Proveedor_ReportCurrentAccount_Controller(
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
[RESTScreenServicesActionProperties(Name="GetSupplierUserByUserId",Screen="ReportCurrentAccount",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetSupplierUserByUserId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "ZHm6glvv3a4RocMm8iuhpQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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

AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ds_output = new AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44>();
long count;
(ds_output.List,count) = await ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel.datasetGetSupplierUserByUserId(requestContext,datasetGetSupplierUserByUserId_maxRecords,datasetGetSupplierUserByUserId_startIndex,IterationMultiplicity.Multiple,model.inParamSupplierId,cancellationToken);

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
[Route("ScreenDataSetGetPaymentTerms")]
[RESTScreenServicesActionProperties(Name="GetPaymentTerms",Screen="ReportCurrentAccount",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetPaymentTerms(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "+6OhqwjTKpS9lXyr02rGqw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
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
(ds_output.List,count) = await ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel.datasetGetPaymentTerms(requestContext,datasetGetPaymentTerms_maxRecords,datasetGetPaymentTerms_startIndex,IterationMultiplicity.Multiple,cancellationToken);

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
[Route("DataActionGetSapData")]
[RESTScreenServicesActionProperties(Name="GetSapData",Screen="ReportCurrentAccount",Type=ScreenServicesActionType.DataAction)]
public async Task<ActionResult<Payload.ServiceResponse>> DataActionGetSapData(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "f4Ax0UdABchGTjINnLPsng", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel model = null;
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

try {model = RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

ST_382afa1d8361f400b6ea03403d75e294Structure outParamList;
decimal outParamTotalenmonedanacional;
decimal outParamImportetotaldefacturasmonedaextranjera;
decimal outParamTotalenmonedanacional2;
decimal outParamImportetotaldefacturasmonedaextranjera2;
(outParamList,outParamTotalenmonedanacional,outParamImportetotaldefacturasmonedaextranjera,outParamTotalenmonedanacional2,outParamImportetotaldefacturasmonedaextranjera2) = await model.DataActionGetSapData(requestContext,cancellationToken);

var output = RESTConectaProveedores_c_Proveedor_ReportCurrentAccount_DataActionGetSapData_Outputs.FromOutputs(this.BehaviorsConfiguration, outParamList, outParamTotalenmonedanacional, outParamImportetotaldefacturasmonedaextranjera, outParamTotalenmonedanacional2, outParamImportetotaldefacturasmonedaextranjera2);
return output;


    }, cancellationToken);
}
}
