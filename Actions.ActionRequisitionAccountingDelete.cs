namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccountingDelete : VarsBag {
public long inParamId;
public lcvRequisitionAccountingDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>RequisitionAccountingDelete</code> that represents the Service Studio action
///  <code>RequisitionAccountingDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionRequisitionAccountingDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvRequisitionAccountingDelete localVars = new lcvRequisitionAccountingDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccountingDelete", "9c6a8c3c-92a6-45a3-a4fb-8533cce7f574"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccountingDelete", "9c6a8c3c-92a6-45a3-a4fb-8533cce7f574", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteRequisitionAccounting
await ExtendedActions.DeleteRequisitionAccounting(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("yjmzBPlnYU2t_6VoRTWoFw#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRequisitionAccountingDelete {



}


}
