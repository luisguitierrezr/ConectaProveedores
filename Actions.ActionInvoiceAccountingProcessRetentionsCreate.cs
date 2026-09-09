namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcessRetentionsCreate : VarsBag {
public EN_b5a4fdb73161852bf014862cdc591a06EntityRecord inParamSource;
public long resCreateInvoiceAccountingProcessRetentions_outParamId = 0L;

public lcvInvoiceAccountingProcessRetentionsCreate(EN_b5a4fdb73161852bf014862cdc591a06EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingProcessRetentionsCreate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingProcessRetentionsCreate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcessRetentionsCreate</code> that represents the Service Studio
///  action <code>InvoiceAccountingProcessRetentionsCreate</code> <p> Description: Encapsulates th
/// e Create entity action, enabling logic to run consistently before and after a record is
///  created.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingProcessRetentionsCreate(IRequestContext requestContext,EN_b5a4fdb73161852bf014862cdc591a06EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingProcessRetentionsCreate result = new lcoInvoiceAccountingProcessRetentionsCreate();
lcvInvoiceAccountingProcessRetentionsCreate localVars = new lcvInvoiceAccountingProcessRetentionsCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcessRetentionsCreate", "90b943cb-0c9d-48a7-b16d-d3e8ee9ff4cf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcessRetentionsCreate", "90b943cb-0c9d-48a7-b16d-d3e8ee9ff4cf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateInvoiceAccountingProcessRetentions
localVars.resCreateInvoiceAccountingProcessRetentions_outParamId = await ExtendedActions.CreateInvoiceAccountingProcessRetentions(requestContext,(((RC_572bb5931fdd9ca097b2d3800101c49b)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateInvoiceAccountingProcessRetentions.Id
result.outParamId=localVars.resCreateInvoiceAccountingProcessRetentions_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingProcessRetentionsCreate {



}


}
