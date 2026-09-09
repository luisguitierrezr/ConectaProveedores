namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedRelationCreateOrUpdate : VarsBag {
public EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord inParamSource;
public long resCreateOrUpdateInvoiceExtendedRelations_outParamId = 0L;

public lcvInvoiceExtendedRelationCreateOrUpdate(EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedRelationCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedRelationCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedRelationCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedRelationCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedRelationCreateOrUpdate(IRequestContext requestContext,EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedRelationCreateOrUpdate result = new lcoInvoiceExtendedRelationCreateOrUpdate();
lcvInvoiceExtendedRelationCreateOrUpdate localVars = new lcvInvoiceExtendedRelationCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedRelationCreateOrUpdate", "905c0614-d3c8-493e-ac21-8d210123c543"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedRelationCreateOrUpdate", "905c0614-d3c8-493e-ac21-8d210123c543", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateInvoiceExtendedRelations
localVars.resCreateOrUpdateInvoiceExtendedRelations_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedRelations(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_759c053ad9cffaec26c59da8e40042d4)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedRelations.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedRelations_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedRelationCreateOrUpdate {



}


}
