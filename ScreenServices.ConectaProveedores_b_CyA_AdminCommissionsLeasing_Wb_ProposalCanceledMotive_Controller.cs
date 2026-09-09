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
[Route("screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/Wb_ProposalCanceledMotive")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_Controller(
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
[Route("ScreenDataSetGetCommentsByProposalId")]
[RESTScreenServicesActionProperties(Name="GetCommentsByProposalId",Screen="Wb_ProposalCanceledMotive",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCommentsByProposalId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "uo4y_of95_VWYOPSnnPJMg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCommentsByProposalId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCommentsByProposalId_maxRecords = 50;
} else {
datasetGetCommentsByProposalId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCommentsByProposalId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCommentsByProposalId_startIndex = 0;
} else {
datasetGetCommentsByProposalId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCommentsByProposalId_maxRecords < 1)) {
datasetGetCommentsByProposalId_maxRecords = 1;
}

AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> ds_output = new AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel.datasetGetCommentsByProposalId(requestContext,datasetGetCommentsByProposalId_maxRecords,datasetGetCommentsByProposalId_startIndex,IterationMultiplicity.Multiple,model.inParami_ProposalId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a>(ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
