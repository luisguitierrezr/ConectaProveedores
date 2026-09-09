namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalLineCreateOrUpdate : VarsBag {
public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord inParamSource;
public long resCreateOrUpdateProposalLine_outParamId = 0L;

public lcvProposalLineCreateOrUpdate(EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalLineCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalLineCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalLineCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalLineCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionProposalLineCreateOrUpdate(IRequestContext requestContext,EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalLineCreateOrUpdate result = new lcoProposalLineCreateOrUpdate();
lcvProposalLineCreateOrUpdate localVars = new lcvProposalLineCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalLineCreateOrUpdate", "8b693426-1d48-4afe-9a20-9190ad274bfe"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalLineCreateOrUpdate", "8b693426-1d48-4afe-9a20-9190ad274bfe", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateProposalLine
localVars.resCreateOrUpdateProposalLine_outParamId = await ExtendedActions.CreateOrUpdateProposalLine(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_cbff39127609a0f830b2d34948d1c019)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposalLine.Id
result.outParamId=localVars.resCreateOrUpdateProposalLine_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalLineCreateOrUpdate {



}


}
