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
[Route("screenservices/ConectaProveedores/m_Manuals/ManualDetailView")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_m_Manuals_ManualDetailView_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_m_Manuals_ManualDetailView_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_m_Manuals_ManualDetailView_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_m_Manuals_ManualDetailView_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_m_Manuals_ManualDetailView_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_m_Manuals_ManualDetailView_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_Video_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssCloneOfPDFViewerODC.ScreenServices.CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_Controller", "CloneOfPDFViewerODC", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        dbBinaryConfigs["z+hr3img9k6c__dgh+2obw*pxgafsf0ceybjicgxrwpqq/file"] = new BinaryContentUtils.DbBinaryConfig(ENManualFileEntity.LocalViewName, TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, _EntityKeyConstants._OrganizationEntityKeys._ManualFileAttributeKeys.@File, "file") ?? "file", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, _EntityKeyConstants._OrganizationEntityKeys._ManualFileAttributeKeys.@Id, "id") ?? "id", 12, false);


        return dbBinaryConfigs;
    }



    static ConectaProveedores_m_Manuals_ManualDetailView_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_m_Manuals_ManualDetailView_Controller(
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
[Route("ScreenDataSetGetManualById")]
[RESTScreenServicesActionProperties(Name="GetManualById",Screen="ManualDetailView",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetManualById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "e4NI1jksALw1fjh_5b5NSA", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel model = null;
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

try {model = RESTConectaProveedores_m_Manuals_ManualDetailView_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetManualById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetManualById_maxRecords = 50;
} else {
datasetGetManualById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetManualById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetManualById_startIndex = 0;
} else {
datasetGetManualById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetManualById_maxRecords < 1)) {
datasetGetManualById_maxRecords = 1;
}

AggregateRecord<RL_d2939f0caa78f2bcae0d5522f32cf37b> ds_output = new AggregateRecord<RL_d2939f0caa78f2bcae0d5522f32cf37b>();
long count;
(ds_output.List,count) = await ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel.datasetGetManualById(requestContext,datasetGetManualById_maxRecords,datasetGetManualById_startIndex,IterationMultiplicity.Multiple,model.inParami_ManualId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
config.BinariesUsed.Add("z+Hr3img9k6c__DgH+2OBw*VDGRDQQiqkqTlAP6HdCOlA");
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_367437e31e499bf19d13607cb372e4f5>(ssConectaProveedores.RestRecords.RESTRC_367437e31e499bf19d13607cb372e4f5.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
