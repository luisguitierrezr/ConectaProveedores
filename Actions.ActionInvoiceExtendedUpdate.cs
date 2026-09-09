namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedUpdate : VarsBag {
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource;
public lcvInvoiceExtendedUpdate(EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedUpdate</code> <p> Description: Encapsulates the Update entity action, enablin
/// g logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedUpdate(IRequestContext requestContext,EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedUpdate result = new lcoInvoiceExtendedUpdate();
lcvInvoiceExtendedUpdate localVars = new lcvInvoiceExtendedUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedUpdate", "40c069a5-a0fe-450f-b0c2-c4dd0258a5ac"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedUpdate", "40c069a5-a0fe-450f-b0c2-c4dd0258a5ac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamSource.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// UpdateInvoiceExtended
await ExtendedActions.UpdateInvoiceExtended(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_fbe3f1050ad4f34fa0e0a15f88a56873)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = Source.Id
result.outParamId=localVars.inParamSource.ssId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException ("Identifier is mandatory");

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedUpdate {



}


}
