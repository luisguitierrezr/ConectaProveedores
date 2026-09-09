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
[Route("screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/Wb_RejectedCommentTooltip")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller.GetDbBinaryConfigs(); }
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



    static ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_Controller(
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
[Route("ScreenDataSetGetCommentsByProposalLineApprovalLevelId")]
[RESTScreenServicesActionProperties(Name="GetCommentsByProposalLineApprovalLevelId",Screen="Wb_RejectedCommentTooltip",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCommentsByProposalLineApprovalLevelId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7D4InDkXSHdVlqrdjfMgBw", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCommentsByProposalLineApprovalLevelId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCommentsByProposalLineApprovalLevelId_maxRecords = 1;
} else {
datasetGetCommentsByProposalLineApprovalLevelId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCommentsByProposalLineApprovalLevelId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCommentsByProposalLineApprovalLevelId_startIndex = 0;
} else {
datasetGetCommentsByProposalLineApprovalLevelId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCommentsByProposalLineApprovalLevelId_maxRecords < 1)) {
datasetGetCommentsByProposalLineApprovalLevelId_maxRecords = 1;
}

AggregateRecord<RL_b1eac7b235569839fbbc9e410d978a26> ds_output = new AggregateRecord<RL_b1eac7b235569839fbbc9e410d978a26>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel.datasetGetCommentsByProposalLineApprovalLevelId(requestContext,datasetGetCommentsByProposalLineApprovalLevelId_maxRecords,datasetGetCommentsByProposalLineApprovalLevelId_startIndex,IterationMultiplicity.Multiple,model.inParami_ProposalLineApprovalLevelId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c>(ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
