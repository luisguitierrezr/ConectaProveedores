namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalApprovalLevelCreateOrUpdate : VarsBag {
public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord inParamSource;
public long resCreateOrUpdateProposalApprovalLevel_outParamId = 0L;

public lcvProposalApprovalLevelCreateOrUpdate(EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalApprovalLevelCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionProposalApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalApprovalLevelCreateOrUpdate result = new lcoProposalApprovalLevelCreateOrUpdate();
lcvProposalApprovalLevelCreateOrUpdate localVars = new lcvProposalApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalApprovalLevelCreateOrUpdate", "6471d86c-9790-47d6-9e92-3779f61c7474"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalApprovalLevelCreateOrUpdate", "6471d86c-9790-47d6-9e92-3779f61c7474", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateProposalApprovalLevel
localVars.resCreateOrUpdateProposalApprovalLevel_outParamId = await ExtendedActions.CreateOrUpdateProposalApprovalLevel(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_55929a788bcf79c72354fc49160acc0c)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposalApprovalLevel.Id
result.outParamId=localVars.resCreateOrUpdateProposalApprovalLevel_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalApprovalLevelCreateOrUpdate {



}


}
