namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceApprovalLevelCreateOrUpdate : VarsBag {
public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceApprovalLevel_outParamId = 0L;

public lcvInvoiceApprovalLevelCreateOrUpdate(EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceApprovalLevelCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceApprovalLevelCreateOrUpdate result = new lcoInvoiceApprovalLevelCreateOrUpdate();
lcvInvoiceApprovalLevelCreateOrUpdate localVars = new lcvInvoiceApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceApprovalLevelCreateOrUpdate", "c8f6d7c1-00e8-4309-9cae-2d97660825f3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceApprovalLevelCreateOrUpdate", "c8f6d7c1-00e8-4309-9cae-2d97660825f3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateInvoiceApprovalLevel
localVars.resCreateOrUpdateInvoiceApprovalLevel_outParamId = await ExtendedActions.CreateOrUpdateInvoiceApprovalLevel(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_a542803a75b19356be8279fb269e55fb)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceApprovalLevel.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceApprovalLevel_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceApprovalLevelCreateOrUpdate {



}


}
