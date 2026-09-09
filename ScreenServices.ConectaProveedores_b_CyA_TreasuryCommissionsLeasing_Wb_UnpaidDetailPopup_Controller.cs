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
[Route("screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/Wb_UnpaidDetailPopup")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller.GetDbBinaryConfigs(); }
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

                SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Utilities_AlignCenter_Controller", "OutSystemsUI", childControllers);
SafeAddChildController("ssOutSystemsUI.ScreenServices.OutSystemsUI_Interaction_InputWithIcon_Controller", "OutSystemsUI", childControllers);
SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        dbBinaryConfigs["6donwmh_kuw9ti9x5smika*v_spztbxxeiuejkfhujirq/binary"] = new BinaryContentUtils.DbBinaryConfig(ENProposalCommentFileEntity.LocalViewName, TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id", 12, false);


        return dbBinaryConfigs;
    }



    static ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY});

    }

    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_Controller(
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
[Route("ScreenDataSetGetProposalLineById")]
[RESTScreenServicesActionProperties(Name="GetProposalLineById",Screen="Wb_UnpaidDetailPopup",Type=ScreenServicesActionType.Aggregate)]
public async Task<ActionResult<Payload.ServiceResponse>> ScreenDataSetGetProposalLineById(CancellationToken cancellationToken) {
    using Stream input = HttpContext.Request.Body;
    return await EndpointAsync(input, "7epvnNT72n4wV1HEtOtEXQ", async (screenName, screenModel, inputParameters, clientVariables, cancellationToken) => {
        ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel model = null;
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

try {model = RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel.FromJSON(screenModel, clientVariables, this.JsonSerializer).ToModel();
inputs = RESTAggregateInputsRecord.FromJSON(inputParameters, this.JsonSerializer).ToModel();
} catch (Exception ex) {
throw RestExposeErrorsHelper.BadRequest("Failed to parse JSON request content.", ex);
}

int datasetGetProposalLineById_maxRecords;
if((inputs.MaxRecords == null)) {
datasetGetProposalLineById_maxRecords = 1;
} else {
datasetGetProposalLineById_maxRecords = inputs.MaxRecords.Value;
}

int datasetGetProposalLineById_startIndex;
if((inputs.StartIndex == null)) {
datasetGetProposalLineById_startIndex = 0;
} else {
datasetGetProposalLineById_startIndex = inputs.StartIndex.Value;
}

if((datasetGetProposalLineById_maxRecords < 1)) {
datasetGetProposalLineById_maxRecords = 1;
}

AggregateRecord<RL_64d6c39a28702aee27a7d75c307bc2c1> ds_output = new AggregateRecord<RL_64d6c39a28702aee27a7d75c307bc2c1>();
long count;
(ds_output.List,count) = await ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel.datasetGetProposalLineById(requestContext,datasetGetProposalLineById_maxRecords,datasetGetProposalLineById_startIndex,IterationMultiplicity.Multiple,model.inParami_ProposalLineId,cancellationToken);

ds_output.Count = count;
IBehaviorsConfiguration config = ((IBehaviorsConfiguration)this.BehaviorsConfiguration.Clone());
config.OptimizeBinaries = true;
config.BinariesUsed.Add("6dONWMH_kUW9Ti9X5sMIKA*VvUncA+Bh0+FahupO+IR8w");
var output = ds_output.ToJS((l) => {
return l.ToRestList<ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758>(ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758.FromStructureDelegate(config));
}
);
return output;

    }, cancellationToken);
}
}
