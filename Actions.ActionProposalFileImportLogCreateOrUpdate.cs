namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalFileImportLogCreateOrUpdate : VarsBag {
public EN_57456f779b1d12573357da68381e59ceEntityRecord inParamSource;
public long resCreateOrUpdateFileImportLog_outParamId = 0L;

public lcvProposalFileImportLogCreateOrUpdate(EN_57456f779b1d12573357da68381e59ceEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalFileImportLogCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalFileImportLogCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalFileImportLogCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalFileImportLogCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionProposalFileImportLogCreateOrUpdate(IRequestContext requestContext,EN_57456f779b1d12573357da68381e59ceEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalFileImportLogCreateOrUpdate result = new lcoProposalFileImportLogCreateOrUpdate();
lcvProposalFileImportLogCreateOrUpdate localVars = new lcvProposalFileImportLogCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalFileImportLogCreateOrUpdate", "d6439891-a866-41f0-aeec-b827d95642e1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalFileImportLogCreateOrUpdate", "d6439891-a866-41f0-aeec-b827d95642e1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateFileImportLog
localVars.resCreateOrUpdateFileImportLog_outParamId = await ExtendedActions.CreateOrUpdateFileImportLog(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_1d614602032ba1d6426327cab15c1a37)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFileImportLog.Id
result.outParamId=localVars.resCreateOrUpdateFileImportLog_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalFileImportLogCreateOrUpdate {



}


}
