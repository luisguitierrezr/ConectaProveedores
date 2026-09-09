namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedItemCreateOrUpdate : VarsBag {
public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceExtendedItem_outParamId = 0L;

public lcvInvoiceExtendedItemCreateOrUpdate(EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedItemCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedItemCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedItemCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedItemCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedItemCreateOrUpdate(IRequestContext requestContext,EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedItemCreateOrUpdate result = new lcoInvoiceExtendedItemCreateOrUpdate();
lcvInvoiceExtendedItemCreateOrUpdate localVars = new lcvInvoiceExtendedItemCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedItemCreateOrUpdate", "e612a67a-2ec7-4b22-930d-25c65251692f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedItemCreateOrUpdate", "e612a67a-2ec7-4b22-930d-25c65251692f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Source.Description = Substr
localVars.inParamSource.ssDescription = BuiltInFunction.SubstrSC (localVars.inParamSource.ssDescription, 0, 1000);
// CreateOrUpdateInvoiceExtendedItem
localVars.resCreateOrUpdateInvoiceExtendedItem_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedItem(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_7f2610cf0c5fadd86ba78c902c31effa)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedItem.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedItem_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedItemCreateOrUpdate {



}


}
