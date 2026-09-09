namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedIssuerCreateOrUpdate : VarsBag {
public EN_1ca446167f1a5fee035306f622895668EntityRecord inParamSource;
public long inParamInvoiceId;
public long resCreateOrUpdateInvoiceExtendedIssuer_outParamId = 0L;

public lcvInvoiceExtendedIssuerCreateOrUpdate(EN_1ca446167f1a5fee035306f622895668EntityRecord inParamSource, long inParamInvoiceId) {
this.inParamSource = inParamSource;
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoInvoiceExtendedIssuerCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedIssuerCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedIssuerCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedIssuerCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedIssuerCreateOrUpdate(IRequestContext requestContext,EN_1ca446167f1a5fee035306f622895668EntityRecord inParamSource,long inParamInvoiceId,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedIssuerCreateOrUpdate result = new lcoInvoiceExtendedIssuerCreateOrUpdate();
lcvInvoiceExtendedIssuerCreateOrUpdate localVars = new lcvInvoiceExtendedIssuerCreateOrUpdate(inParamSource, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedIssuerCreateOrUpdate", "553b1b5c-3250-4a03-bf71-b2e2661b2504"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedIssuerCreateOrUpdate", "553b1b5c-3250-4a03-bf71-b2e2661b2504", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamInvoiceId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Source.Id = InvoiceId
localVars.inParamSource.ssId = localVars.inParamInvoiceId;
// CreateOrUpdateInvoiceExtendedIssuer
localVars.resCreateOrUpdateInvoiceExtendedIssuer_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedIssuer(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_bceddfb85670aa95e44aa049194f2b7c)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedIssuer.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedIssuer_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("bJD+KllAJk+BYNAOj72ZUA#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedIssuerCreateOrUpdate {



}


}
