namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionApprovalDelete : VarsBag {
public long inParamId;
public lcvRequisitionApprovalDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>RequisitionApprovalDelete</code> that represents the Service Studio action
///  <code>RequisitionApprovalDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionRequisitionApprovalDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvRequisitionApprovalDelete localVars = new lcvRequisitionApprovalDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionApprovalDelete", "d9e1dcaa-4ce0-4112-aacf-3539fb24b809"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionApprovalDelete", "d9e1dcaa-4ce0-4112-aacf-3539fb24b809", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteRequisitionApproval
await ExtendedActions.DeleteRequisitionApproval(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("5wvV3Vg2IkKq5fv+w6_zzg#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRequisitionApprovalDelete {



}


}
