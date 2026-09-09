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
[Route("screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsChat")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_Separator_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Content_UserAvatar_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*AddComment*/"6dONWMH_kUW9Ti9X5sMIKA*P73pUK3vAkm3N4si6l27EA"});

    }

    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_Controller(
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
[Route("ScreenDataSetGetInvoiceCommentsByInvoiceId")]
[RESTScreenServicesActionProperties(Name="GetInvoiceCommentsByInvoiceId",Screen="Wb_InvoiceDetailsChat",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetInvoiceCommentsByInvoiceId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "cxf70vYAHTvZ4iB9hYC1gw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel model = null;
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

try {model = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetInvoiceCommentsByInvoiceId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetInvoiceCommentsByInvoiceId_maxRecords = model.varLcl_MaxRecords;
} else {
datasetGetInvoiceCommentsByInvoiceId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetInvoiceCommentsByInvoiceId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetInvoiceCommentsByInvoiceId_startIndex = 0;
} else {
datasetGetInvoiceCommentsByInvoiceId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetInvoiceCommentsByInvoiceId_maxRecords < 1)) {
datasetGetInvoiceCommentsByInvoiceId_maxRecords = 1;
}

AggregateRecord<RL_2b8298c99eec97081abcd9d7211953b5> ds_output = new AggregateRecord<RL_2b8298c99eec97081abcd9d7211953b5>();
long count;
(ds_output.List,count) = await ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ScreenModel.datasetGetInvoiceCommentsByInvoiceId(requestContext,datasetGetInvoiceCommentsByInvoiceId_maxRecords,datasetGetInvoiceCommentsByInvoiceId_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),model.inParami_InvoiceId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac>(ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}[HttpPost]
[Route("ActionAddComment")]
[RESTScreenServicesActionProperties(Name="AddComment",Screen="Wb_InvoiceDetailsChat",Type=ScreenServicesActionType.ServerAction)]
public async Task<ActionResult<Payload.ServiceResponse>> ActionAddComment(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "szhCwpdNyjZU166N3EQtMw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ActionAddComment_Model inputs = null;
Actions.lcoAddComment res =  new Actions.lcoAddComment();CheckPermissionsIndex.CheckPermissionsAsync check;
if(Permissions.TryGetAsyncCheckPermissions(ScreenName.AnyScreen, out check)) {
await check(requestContext, cancellationToken);
} else {
if(Permissions.TryGetAsyncCheckPermissions(new ScreenName(screenName), out check)) {
await check(requestContext, cancellationToken);
} else {
throw new InvalidOperationException("No role validation found");
}

}

try {inputs = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ActionAddComment_Inputs.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}


// 
res.outParamo_Output = await Actions.ActionAddComment(requestContext,inputs.inParami_InvoiceComment,cancellationToken);

var output = RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_ActionAddComment_Outputs.FromOutputs(this.BehaviorsConfiguration, res.outParamo_Output);
return output;


    }, cancellationToken);
}
}
