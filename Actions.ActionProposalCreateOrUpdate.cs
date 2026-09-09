namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalCreateOrUpdate : VarsBag {
public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord inParamSource;
public long resCreateOrUpdateProposal_outParamId = 0L;

public lcvProposalCreateOrUpdate(EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionProposalCreateOrUpdate(IRequestContext requestContext,EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalCreateOrUpdate result = new lcoProposalCreateOrUpdate();
lcvProposalCreateOrUpdate localVars = new lcvProposalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalCreateOrUpdate", "1c1038c3-910b-40d7-b379-3fde46e2a99d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalCreateOrUpdate", "1c1038c3-910b-40d7-b379-3fde46e2a99d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
} else {
// Source.LastUpdatedOn = CurrDateTime
localVars.inParamSource.ssLastUpdatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateProposal
localVars.resCreateOrUpdateProposal_outParamId = await ExtendedActions.CreateOrUpdateProposal(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_91adc4f46f8a0f51cacc4bc718d2ea35)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposal.Id
result.outParamId=localVars.resCreateOrUpdateProposal_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalCreateOrUpdate {



}


}
