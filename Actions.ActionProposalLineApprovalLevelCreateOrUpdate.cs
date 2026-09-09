namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalLineApprovalLevelCreateOrUpdate : VarsBag {
public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord inParamSource;
public long resCreateOrUpdateProposalLineApprovalLevel_outParamId = 0L;

public lcvProposalLineApprovalLevelCreateOrUpdate(EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalLineApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalLineApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalLineApprovalLevelCreateOrUpdate</code> that represents the Service Studio
///  action <code>ProposalLineApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionProposalLineApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalLineApprovalLevelCreateOrUpdate result = new lcoProposalLineApprovalLevelCreateOrUpdate();
lcvProposalLineApprovalLevelCreateOrUpdate localVars = new lcvProposalLineApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalLineApprovalLevelCreateOrUpdate", "143894fb-e3f6-40d5-bfb6-339c8df8c51e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalLineApprovalLevelCreateOrUpdate", "143894fb-e3f6-40d5-bfb6-339c8df8c51e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateProposalLineApprovalLevel
localVars.resCreateOrUpdateProposalLineApprovalLevel_outParamId = await ExtendedActions.CreateOrUpdateProposalLineApprovalLevel(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_875fb45d4123a91fce83831f0f554d8e)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposalLineApprovalLevel.Id
result.outParamId=localVars.resCreateOrUpdateProposalLineApprovalLevel_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalLineApprovalLevelCreateOrUpdate {



}


}
