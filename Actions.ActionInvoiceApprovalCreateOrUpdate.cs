namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceApprovalCreateOrUpdate : VarsBag {
public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParamSource;
public long resCreateOrUpdateInvoiceApproval_outParamId = 0L;

public lcvInvoiceApprovalCreateOrUpdate(EN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceApprovalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceApprovalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceApprovalCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceApprovalCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceApprovalCreateOrUpdate(IRequestContext requestContext,EN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceApprovalCreateOrUpdate result = new lcoInvoiceApprovalCreateOrUpdate();
lcvInvoiceApprovalCreateOrUpdate localVars = new lcvInvoiceApprovalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceApprovalCreateOrUpdate", "28831449-e097-4767-91e8-2b91e17bdf10"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceApprovalCreateOrUpdate", "28831449-e097-4767-91e8-2b91e17bdf10", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateInvoiceApproval
localVars.resCreateOrUpdateInvoiceApproval_outParamId = await ExtendedActions.CreateOrUpdateInvoiceApproval(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_8ecd20e9afb5cd14c3f1aea1a6262374)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceApproval.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceApproval_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceApprovalCreateOrUpdate {



}


}
