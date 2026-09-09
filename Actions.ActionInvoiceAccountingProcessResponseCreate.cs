namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcessResponseCreate : VarsBag {
public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord inParamSource;
public long resCreateInvoiceAccountingProcessResponse_outParamId = 0L;

public lcvInvoiceAccountingProcessResponseCreate(EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingProcessResponseCreate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingProcessResponseCreate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcessResponseCreate</code> that represents the Service Studio
///  action <code>InvoiceAccountingProcessResponseCreate</code> <p> Description: Encapsulates the Creat
/// e entity action, enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingProcessResponseCreate(IRequestContext requestContext,EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingProcessResponseCreate result = new lcoInvoiceAccountingProcessResponseCreate();
lcvInvoiceAccountingProcessResponseCreate localVars = new lcvInvoiceAccountingProcessResponseCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcessResponseCreate", "1932a58d-bda1-4406-8b1b-7c7d1b53a505"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcessResponseCreate", "1932a58d-bda1-4406-8b1b-7c7d1b53a505", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateInvoiceAccountingProcessResponse
localVars.resCreateInvoiceAccountingProcessResponse_outParamId = await ExtendedActions.CreateInvoiceAccountingProcessResponse(requestContext,(((RC_8d2c7f494e763d54feb138104c341adb)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateInvoiceAccountingProcessResponse.Id
result.outParamId=localVars.resCreateInvoiceAccountingProcessResponse_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingProcessResponseCreate {



}


}
