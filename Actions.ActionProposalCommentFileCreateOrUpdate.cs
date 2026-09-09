namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalCommentFileCreateOrUpdate : VarsBag {
public EN_7db82b55fc996c1dcfda575a9310d307EntityRecord inParamSource;
public long resCreateOrUpdateProposalCommentFile_outParamId = 0L;

public lcvProposalCommentFileCreateOrUpdate(EN_7db82b55fc996c1dcfda575a9310d307EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalCommentFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalCommentFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalCommentFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalCommentFileCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionProposalCommentFileCreateOrUpdate(IRequestContext requestContext,EN_7db82b55fc996c1dcfda575a9310d307EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalCommentFileCreateOrUpdate result = new lcoProposalCommentFileCreateOrUpdate();
lcvProposalCommentFileCreateOrUpdate localVars = new lcvProposalCommentFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalCommentFileCreateOrUpdate", "71145fab-00f9-43c1-b3a0-ad7092b2ad74"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalCommentFileCreateOrUpdate", "71145fab-00f9-43c1-b3a0-ad7092b2ad74", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateProposalCommentFile
localVars.resCreateOrUpdateProposalCommentFile_outParamId = await ExtendedActions.CreateOrUpdateProposalCommentFile(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_1fc482b76911051ba177b5ef645edd69)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposalCommentFile.Id
result.outParamId=localVars.resCreateOrUpdateProposalCommentFile_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalCommentFileCreateOrUpdate {



}


}
