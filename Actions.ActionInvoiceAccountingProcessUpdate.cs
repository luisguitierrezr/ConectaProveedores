namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcessUpdate : VarsBag {
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource;
public lcvInvoiceAccountingProcessUpdate(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingProcessUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingProcessUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcessUpdate</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcessUpdate</code> <p> Description: Encapsulates the Update entity action
/// , enabling logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingProcessUpdate(IRequestContext requestContext,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingProcessUpdate result = new lcoInvoiceAccountingProcessUpdate();
lcvInvoiceAccountingProcessUpdate localVars = new lcvInvoiceAccountingProcessUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcessUpdate", "11a93394-a39a-40bb-876d-8016a8dd85fc"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcessUpdate", "11a93394-a39a-40bb-876d-8016a8dd85fc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamSource.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// UpdateInvoiceAccountingProcess
await ExtendedActions.UpdateInvoiceAccountingProcess(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_d01c9a070ebc097e32a128e1b4125cc2)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = Source.Id
result.outParamId=localVars.inParamSource.ssId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("M7_Nql_BM0is15xDbGOYdQ#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingProcessUpdate {



}


}
