namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalStatusHistoryCreateOrUpdate : VarsBag {
public EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord inParamSource;
public long resCreateOrUpdateProposalStatusHistory_outParamId = 0L;

public lcvProposalStatusHistoryCreateOrUpdate(EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalStatusHistoryCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalStatusHistoryCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalStatusHistoryCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalStatusHistoryCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionProposalStatusHistoryCreateOrUpdate(IRequestContext requestContext,EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalStatusHistoryCreateOrUpdate result = new lcoProposalStatusHistoryCreateOrUpdate();
lcvProposalStatusHistoryCreateOrUpdate localVars = new lcvProposalStatusHistoryCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalStatusHistoryCreateOrUpdate", "bf37bc80-6849-43bc-8bcc-cf99bd358207"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalStatusHistoryCreateOrUpdate", "bf37bc80-6849-43bc-8bcc-cf99bd358207", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateProposalStatusHistory
localVars.resCreateOrUpdateProposalStatusHistory_outParamId = await ExtendedActions.CreateOrUpdateProposalStatusHistory(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_e6d370b8387bb43d90dc90a766ecdf20)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateProposalStatusHistory.Id
result.outParamId=localVars.resCreateOrUpdateProposalStatusHistory_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalStatusHistoryCreateOrUpdate {



}


}
