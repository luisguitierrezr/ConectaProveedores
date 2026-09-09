namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalCreate : VarsBag {
public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord inParamSource;
public long resCreateProposal_outParamId = 0L;

public lcvProposalCreate(EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalCreate : VarsBag {
public long outParamId = 0L;

public lcoProposalCreate() {
}
}
/// <summary>
/// Action <code>ProposalCreate</code> that represents the Service Studio action
///  <code>ProposalCreate</code> <p> Description: Encapsulates the Create entity action, enabling logi
/// c to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionProposalCreate(IRequestContext requestContext,EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalCreate result = new lcoProposalCreate();
lcvProposalCreate localVars = new lcvProposalCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalCreate", "f57d12ab-b06b-4710-8246-1bde8c506be6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalCreate", "f57d12ab-b06b-4710-8246-1bde8c506be6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Set basic audit attributes
// Source.CreatedBy = If
localVars.inParamSource.ssCreatedBy = (((localVars.inParamSource.ssCreatedBy!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParamSource.ssCreatedBy) : (BuiltInFunction.GetUserId ()));

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
// CreateProposal
localVars.resCreateProposal_outParamId = await ExtendedActions.CreateProposal(requestContext,(((RC_91adc4f46f8a0f51cacc4bc718d2ea35)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateProposal.Id
result.outParamId=localVars.resCreateProposal_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalCreate {



}


}
