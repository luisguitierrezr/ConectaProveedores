namespace ssConectaProveedores;

public partial class Actions {
public class lcvCheckUserSession : VarsBag {
public bool resCheckUserSessionDONOTUSE_outParamIsValidSession = false;

public lcvCheckUserSession() {
}
}
public class lcoCheckUserSession : VarsBag {
public bool outParamIsValidSession = false;

public lcoCheckUserSession() {
}
}
/// <summary>
/// Action <code>CheckUserSession</code> that represents the Service Studio action
///  <code>CheckUserSession</code> <p> Description: Use for validate Guid Sessions.</p>
/// </summary>
public static async Task<bool> ActionCheckUserSession(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsValidSession = default;
lcoCheckUserSession result = new lcoCheckUserSession();
lcvCheckUserSession localVars = new lcvCheckUserSession();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CheckUserSession", "83326f1c-eaba-4dc4-a622-0044ab12fa2e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CheckUserSession", "83326f1c-eaba-4dc4-a622-0044ab12fa2e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CheckUserSessionDONOTUSE
localVars.resCheckUserSessionDONOTUSE_outParamIsValidSession = await Actions.ActionCheckUserSessionDONOTUSE(requestContext,cancellationToken);

// IsValidSession = CheckUserSessionDONOTUSE.IsValidSession
result.outParamIsValidSession=localVars.resCheckUserSessionDONOTUSE_outParamIsValidSession;
} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// RaiseError InvalidSession
throw new Ex_InvalidSessionUserException (ex.Message);

} // Catch
finally {
outParamIsValidSession = result.outParamIsValidSession;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamIsValidSession;
}

public static class FuncActionCheckUserSession {



}


}
