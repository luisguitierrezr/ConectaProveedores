namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderRequestFileApprovalDelete : VarsBag {
public long inParamId;
public lcvOrderRequestFileApprovalDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>OrderRequestFileApprovalDelete</code> that represents the Service Studio action
///  <code>OrderRequestFileApprovalDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionOrderRequestFileApprovalDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvOrderRequestFileApprovalDelete localVars = new lcvOrderRequestFileApprovalDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderRequestFileApprovalDelete", "6c81d579-2e84-4df7-b203-651f1beb7d27"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderRequestFileApprovalDelete", "6c81d579-2e84-4df7-b203-651f1beb7d27", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteOrderRequestFileApproval
await ExtendedActions.DeleteOrderRequestFileApproval(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("Ur8fDHQB8kOvB6AG1WNkOw#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrderRequestFileApprovalDelete {



}


}
