namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalDelete : VarsBag {
public long inParamId;
public lcvProposalDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>ProposalDelete</code> that represents the Service Studio action
///  <code>ProposalDelete</code> <p> Description: Encapsulates the Delete entity action, enabling logi
/// c to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionProposalDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvProposalDelete localVars = new lcvProposalDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalDelete", "4a13168a-331d-460b-8cef-35077673be46"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalDelete", "4a13168a-331d-460b-8cef-35077673be46", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteProposal
await ExtendedActions.DeleteProposal(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException ("Identifier is mandatory");

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionProposalDelete {



}


}
