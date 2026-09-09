namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioApprovalDelete : VarsBag {
public long inParamId;
public lcvFolioApprovalDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>FolioApprovalDelete</code> that represents the Service Studio action
///  <code>FolioApprovalDelete</code> <p> Description: Encapsulates the Delete entity action, enablin
/// g logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionFolioApprovalDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvFolioApprovalDelete localVars = new lcvFolioApprovalDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioApprovalDelete", "42eb25b6-dc7d-4a1c-9920-a9b670317b73"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioApprovalDelete", "42eb25b6-dc7d-4a1c-9920-a9b670317b73", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteFolioApproval
await ExtendedActions.DeleteFolioApproval(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("VKbWCX1PM0Owa2Z7JtYE0w#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionFolioApprovalDelete {



}


}
