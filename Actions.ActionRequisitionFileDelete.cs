namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionFileDelete : VarsBag {
public long inParamId;
public lcvRequisitionFileDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>RequisitionFileDelete</code> that represents the Service Studio action
///  <code>RequisitionFileDelete</code> <p> Description: Encapsulates the Delete entity action, enablin
/// g logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionRequisitionFileDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvRequisitionFileDelete localVars = new lcvRequisitionFileDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionFileDelete", "eb8a491f-a37c-4d49-9002-ddf03d8a3315"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionFileDelete", "eb8a491f-a37c-4d49-9002-ddf03d8a3315", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteRequisitionFile2
await ExtendedActions.DeleteRequisitionFile2(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("dLMYhbAL8U2a3_P8rg9IMA#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRequisitionFileDelete {



}


}
