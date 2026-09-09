namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderMainDelete : VarsBag {
public long inParamId;
public lcvOrderMainDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>OrderMainDelete</code> that represents the Service Studio action
///  <code>OrderMainDelete</code> <p> Description: Encapsulates the Delete entity action, enabling logi
/// c to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionOrderMainDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvOrderMainDelete localVars = new lcvOrderMainDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderMainDelete", "65ce427d-ef89-4531-b747-b85bbacaaae8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderMainDelete", "65ce427d-ef89-4531-b747-b85bbacaaae8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteOrderMain
await ExtendedActions.DeleteOrderMain(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("ARXkepP9oESkQr415syRnw#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrderMainDelete {



}


}
