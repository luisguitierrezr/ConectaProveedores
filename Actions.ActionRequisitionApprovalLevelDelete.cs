namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionApprovalLevelDelete : VarsBag {
public long inParamId;
public lcvRequisitionApprovalLevelDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>RequisitionApprovalLevelDelete</code> that represents the Service Studio action
///  <code>RequisitionApprovalLevelDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionRequisitionApprovalLevelDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvRequisitionApprovalLevelDelete localVars = new lcvRequisitionApprovalLevelDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionApprovalLevelDelete", "527cec57-1642-4e69-a2b7-26c83162c8b5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionApprovalLevelDelete", "527cec57-1642-4e69-a2b7-26c83162c8b5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteRequisitionApprovalLevel
await ExtendedActions.DeleteRequisitionApprovalLevel(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("XzNbNTT9kEWtrx71XQK8iQ#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRequisitionApprovalLevelDelete {



}


}
