namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedTaxCreateOrUpdate : VarsBag {
public EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceExtendedTax_outParamId = 0L;

public lcvInvoiceExtendedTaxCreateOrUpdate(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedTaxCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedTaxCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedTaxCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedTaxCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedTaxCreateOrUpdate(IRequestContext requestContext,EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedTaxCreateOrUpdate result = new lcoInvoiceExtendedTaxCreateOrUpdate();
lcvInvoiceExtendedTaxCreateOrUpdate localVars = new lcvInvoiceExtendedTaxCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedTaxCreateOrUpdate", "af2faa0f-79ee-4ab1-8754-cee8081e537e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedTaxCreateOrUpdate", "af2faa0f-79ee-4ab1-8754-cee8081e537e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateInvoiceExtendedTax
localVars.resCreateOrUpdateInvoiceExtendedTax_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedTax(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_965912af30c7fbb7316f17bf8e331782)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedTax.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedTax_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedTaxCreateOrUpdate {



}


}
