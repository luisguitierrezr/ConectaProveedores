namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalFileExtendedCreateOrUpdate : VarsBag {
public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord inParamSource;
public long resCreateOrUpdateFileExtended_outParamId = 0L;

public lcvProposalFileExtendedCreateOrUpdate(EN_dcebdd8ba305133f41b1e1804925997fEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalFileExtendedCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalFileExtendedCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalFileExtendedCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalFileExtendedCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionProposalFileExtendedCreateOrUpdate(IRequestContext requestContext,EN_dcebdd8ba305133f41b1e1804925997fEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalFileExtendedCreateOrUpdate result = new lcoProposalFileExtendedCreateOrUpdate();
lcvProposalFileExtendedCreateOrUpdate localVars = new lcvProposalFileExtendedCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalFileExtendedCreateOrUpdate", "606808cf-b44f-4e16-b648-60151d6236c9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalFileExtendedCreateOrUpdate", "606808cf-b44f-4e16-b648-60151d6236c9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamSource.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// CreateOrUpdateFileExtended
localVars.resCreateOrUpdateFileExtended_outParamId = await ExtendedActions.CreateOrUpdateFileExtended(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_6e3ea28d2c552bc2cc129f42297e5982)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFileExtended.Id
result.outParamId=localVars.resCreateOrUpdateFileExtended_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("1wP3w+tYck2+g7xNCh_c5A#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalFileExtendedCreateOrUpdate {



}


}
