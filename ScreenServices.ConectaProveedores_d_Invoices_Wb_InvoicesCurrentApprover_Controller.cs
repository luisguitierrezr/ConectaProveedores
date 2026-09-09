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
[Route("screenservices/ConectaProveedores/d_Invoices/Wb_InvoicesCurrentApprover")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssTelcel_Theme.ScreenServices.Telcel_Theme_Utils_Wb_ShortText_Controller", "Telcel_Theme", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_Controller(
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
[Route("ScreenDataSetGetInvoiceApprovalsCurrentApprover")]
[RESTScreenServicesActionProperties(Name="GetInvoiceApprovalsCurrentApprover",Screen="Wb_InvoicesCurrentApprover",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceApprovalsCurrentApprover(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "zDGPQZ_1TOdQi77LZ0PT7A", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceApprovalsCurrentApprover_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceApprovalsCurrentApprover_maxRecords = 1;
} else {
datasetGetInvoiceApprovalsCurrentApprover_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceApprovalsCurrentApprover_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceApprovalsCurrentApprover_startIndex = 0;
} else {
datasetGetInvoiceApprovalsCurrentApprover_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceApprovalsCurrentApprover_maxRecords < 1)) {
datasetGetInvoiceApprovalsCurrentApprover_maxRecords = 1;
}

AggregateRecord<RL_bed92cf49c584b7d4ab2b8923c043fa1> ds_output = new AggregateRecord<RL_bed92cf49c584b7d4ab2b8923c043fa1>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel.datasetGetInvoiceApprovalsCurrentApprover(requestContext,datasetGetInvoiceApprovalsCurrentApprover_maxRecords,datasetGetInvoiceApprovalsCurrentApprover_startIndex,IterationMultiplicity.Multiple,model.inParamInvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d>(ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
