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
[Route("screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/Wb_UnpaidCommentTooltip")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller.GetDbBinaryConfigs(); }
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



    static ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_Controller(
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
[Route("ScreenDataSetGetCommentsByProposalLineId")]
[RESTScreenServicesActionProperties(Name="GetCommentsByProposalLineId",Screen="Wb_UnpaidCommentTooltip",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetCommentsByProposalLineId(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "9GXvH4NrY_R36Fkx5s3lmg", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetCommentsByProposalLineId_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetCommentsByProposalLineId_maxRecords = 1;
} else {
datasetGetCommentsByProposalLineId_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetCommentsByProposalLineId_startIndex;
if((inputs.StartIndex == null)) {
datasetGetCommentsByProposalLineId_startIndex = 0;
} else {
datasetGetCommentsByProposalLineId_startIndex = inputs.StartIndex.Value;
}

if((datasetGetCommentsByProposalLineId_maxRecords < 1)) {
datasetGetCommentsByProposalLineId_maxRecords = 1;
}

AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> ds_output = new AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel.datasetGetCommentsByProposalLineId(requestContext,datasetGetCommentsByProposalLineId_maxRecords,datasetGetCommentsByProposalLineId_startIndex,IterationMultiplicity.Multiple,model.inParami_ProposalLineId,cancellationToken);

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
