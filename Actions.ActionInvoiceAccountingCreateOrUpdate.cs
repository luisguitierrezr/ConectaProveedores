namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingCreateOrUpdate : VarsBag {
public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceAccounting_outParamId = 0L;

public lcvInvoiceAccountingCreateOrUpdate(EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceAccountingCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingCreateOrUpdate(IRequestContext requestContext,EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingCreateOrUpdate result = new lcoInvoiceAccountingCreateOrUpdate();
lcvInvoiceAccountingCreateOrUpdate localVars = new lcvInvoiceAccountingCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingCreateOrUpdate", "e61c3c82-33d9-4e42-ab07-1aeb23b1cde5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingCreateOrUpdate", "e61c3c82-33d9-4e42-ab07-1aeb23b1cde5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Source.FreeText = Substr
localVars.inParamSource.ssFreeText = BuiltInFunction.SubstrSC (localVars.inParamSource.ssFreeText, 0, 1000);
// CreateOrUpdateInvoiceAccounting
localVars.resCreateOrUpdateInvoiceAccounting_outParamId = await ExtendedActions.CreateOrUpdateInvoiceAccounting(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_c398a83ea7d109886e6be693f6d07867)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceAccounting.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceAccounting_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingCreateOrUpdate {



}


}
