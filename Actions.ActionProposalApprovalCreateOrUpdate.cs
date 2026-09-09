namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalApprovalCreateOrUpdate : VarsBag {
public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord inParamSource;
public long resCreateOrUpdateProposalApproval_outParamId = 0L;

public lcvProposalApprovalCreateOrUpdate(EN_5464a383ceb6bec564e8dfa03f011357EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalApprovalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalApprovalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalApprovalCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalApprovalCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionProposalApprovalCreateOrUpdate(IRequestContext requestContext,EN_5464a383ceb6bec564e8dfa03f011357EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalApprovalCreateOrUpdate result = new lcoProposalApprovalCreateOrUpdate();
lcvProposalApprovalCreateOrUpdate localVars = new lcvProposalApprovalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalApprovalCreateOrUpdate", "535d3d1d-698a-4ea6-88d6-5749078888ec"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalApprovalCreateOrUpdate", "535d3d1d-698a-4ea6-88d6-5749078888ec", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateProposalApproval
localVars.resCreateOrUpdateProposalApproval_outParamId = await ExtendedActions.CreateOrUpdateProposalApproval(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_1e5bc1d6d010761f865e3a0774f1c819)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposalApproval.Id
result.outParamId=localVars.resCreateOrUpdateProposalApproval_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalApprovalCreateOrUpdate {



}


}
