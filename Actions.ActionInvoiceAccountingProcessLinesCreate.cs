namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcessLinesCreate : VarsBag {
public EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord inParamSource;
public long resCreateInvoiceAccountingProcessLines_F43_outParamId = 0L;

public lcvInvoiceAccountingProcessLinesCreate(EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingProcessLinesCreate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingProcessLinesCreate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcessLinesCreate</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcessLinesCreate</code> <p> Description: Encapsulates the Create entit
/// y action, enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingProcessLinesCreate(IRequestContext requestContext,EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingProcessLinesCreate result = new lcoInvoiceAccountingProcessLinesCreate();
lcvInvoiceAccountingProcessLinesCreate localVars = new lcvInvoiceAccountingProcessLinesCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcessLinesCreate", "76e127aa-8d9f-4e3c-9eb9-5d92bd9cf559"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcessLinesCreate", "76e127aa-8d9f-4e3c-9eb9-5d92bd9cf559", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateInvoiceAccountingProcessLines_F43
localVars.resCreateInvoiceAccountingProcessLines_F43_outParamId = await ExtendedActions.CreateInvoiceAccountingProcessLines_F43(requestContext,(((RC_56dd61ddd73c9e3bf07414aa1c617494)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateInvoiceAccountingProcessLines_F43.Id
result.outParamId=localVars.resCreateInvoiceAccountingProcessLines_F43_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingProcessLinesCreate {



}


}
