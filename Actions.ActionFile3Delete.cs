namespace ssConectaProveedores;

public partial class Actions {
public class lcvFile3Delete : VarsBag {
public long inParamId;
public lcvFile3Delete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>File3Delete</code> that represents the Service Studio action <code>File3Delete</code>
///  <p> Description: Encapsulates the Delete entity action, enabling logic to run consistently befor
/// e and after a record is deleted.</p>
/// </summary>
public static async Task ActionFile3Delete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvFile3Delete localVars = new lcvFile3Delete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("File3Delete", "20cf2f5e-5b6a-474b-825a-e8ddbb685cd5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("File3Delete", "20cf2f5e-5b6a-474b-825a-e8ddbb685cd5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteFile3
await ExtendedActions.DeleteFile3(requestContext,localVars.inParamId,cancellationToken);

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

public static class FuncActionFile3Delete {



}


}
