namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderApprovalDelete : VarsBag {
public long inParamId;
public lcvOrderApprovalDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>OrderApprovalDelete</code> that represents the Service Studio action
///  <code>OrderApprovalDelete</code> <p> Description: Encapsulates the Delete entity action, enablin
/// g logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionOrderApprovalDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvOrderApprovalDelete localVars = new lcvOrderApprovalDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderApprovalDelete", "351a0454-0f4d-49f3-9d9b-29a94d122415"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderApprovalDelete", "351a0454-0f4d-49f3-9d9b-29a94d122415", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteOrderApproval
await ExtendedActions.DeleteOrderApproval(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("zNGI+QeoPEegGcnYN0B+zg#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrderApprovalDelete {



}


}
