namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalCommentCreateOrUpdate : VarsBag {
public EN_c75b4bd59e1200fee3175175a6054340EntityRecord inParamSource;
public long resCreateOrUpdateProposalComment_outParamId = 0L;

public lcvProposalCommentCreateOrUpdate(EN_c75b4bd59e1200fee3175175a6054340EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalCommentCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalCommentCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalCommentCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalCommentCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionProposalCommentCreateOrUpdate(IRequestContext requestContext,EN_c75b4bd59e1200fee3175175a6054340EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalCommentCreateOrUpdate result = new lcoProposalCommentCreateOrUpdate();
lcvProposalCommentCreateOrUpdate localVars = new lcvProposalCommentCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalCommentCreateOrUpdate", "37b12aa8-f827-47b2-bcf0-ea447c8f0468"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalCommentCreateOrUpdate", "37b12aa8-f827-47b2-bcf0-ea447c8f0468", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateProposalComment
localVars.resCreateOrUpdateProposalComment_outParamId = await ExtendedActions.CreateOrUpdateProposalComment(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_cd5101cd31ffd8dc09aecaca6d77004a)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposalComment.Id
result.outParamId=localVars.resCreateOrUpdateProposalComment_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalCommentCreateOrUpdate {



}


}
