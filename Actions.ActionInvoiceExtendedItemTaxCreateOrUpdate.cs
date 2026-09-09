namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedItemTaxCreateOrUpdate : VarsBag {
public EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceExtendedItemTax_outParamId = 0L;

public lcvInvoiceExtendedItemTaxCreateOrUpdate(EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedItemTaxCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedItemTaxCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedItemTaxCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedItemTaxCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedItemTaxCreateOrUpdate(IRequestContext requestContext,EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedItemTaxCreateOrUpdate result = new lcoInvoiceExtendedItemTaxCreateOrUpdate();
lcvInvoiceExtendedItemTaxCreateOrUpdate localVars = new lcvInvoiceExtendedItemTaxCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedItemTaxCreateOrUpdate", "5d6d3a55-b757-41a1-8449-4265678a1937"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedItemTaxCreateOrUpdate", "5d6d3a55-b757-41a1-8449-4265678a1937", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateInvoiceExtendedItemTax
localVars.resCreateOrUpdateInvoiceExtendedItemTax_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedItemTax(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_e7b4e13946d568a48ef39b6a3bfce595)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedItemTax.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedItemTax_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedItemTaxCreateOrUpdate {



}


}
