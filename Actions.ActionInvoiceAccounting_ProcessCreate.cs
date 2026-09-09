namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccounting_ProcessCreate : VarsBag {
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource;
public long resCreateInvoiceAccountingProcess_outParamId = 0L;

public lcvInvoiceAccounting_ProcessCreate(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccounting_ProcessCreate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccounting_ProcessCreate() {
}
}
/// <summary>
/// Action <code>InvoiceAccounting_ProcessCreate</code> that represents the Service Studio action
///  <code>InvoiceAccounting_ProcessCreate</code> <p> Description: Encapsulates the Create entit
/// y action, enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccounting_ProcessCreate(IRequestContext requestContext,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccounting_ProcessCreate result = new lcoInvoiceAccounting_ProcessCreate();
lcvInvoiceAccounting_ProcessCreate localVars = new lcvInvoiceAccounting_ProcessCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccounting_ProcessCreate", "26a6d83f-44ea-4296-85ba-78a72696ee8e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccounting_ProcessCreate", "26a6d83f-44ea-4296-85ba-78a72696ee8e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateInvoiceAccountingProcess
localVars.resCreateInvoiceAccountingProcess_outParamId = await ExtendedActions.CreateInvoiceAccountingProcess(requestContext,(((RC_d01c9a070ebc097e32a128e1b4125cc2)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateInvoiceAccountingProcess.Id
result.outParamId=localVars.resCreateInvoiceAccountingProcess_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccounting_ProcessCreate {



}


}
