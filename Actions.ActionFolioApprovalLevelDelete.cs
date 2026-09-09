namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioApprovalLevelDelete : VarsBag {
public long inParamId;
public lcvFolioApprovalLevelDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>FolioApprovalLevelDelete</code> that represents the Service Studio action
///  <code>FolioApprovalLevelDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionFolioApprovalLevelDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvFolioApprovalLevelDelete localVars = new lcvFolioApprovalLevelDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioApprovalLevelDelete", "d5ca746d-31a1-40bd-8e2c-a319858c3bb0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioApprovalLevelDelete", "d5ca746d-31a1-40bd-8e2c-a319858c3bb0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteFolioApprovalLevel
await ExtendedActions.DeleteFolioApprovalLevel(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("L2HKow+gnkWXiIBKzTwrzw#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionFolioApprovalLevelDelete {



}


}
