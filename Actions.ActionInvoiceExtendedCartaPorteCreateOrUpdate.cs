namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedCartaPorteCreateOrUpdate : VarsBag {
public EN_9bd576a05df3846c52ce88a606aff414EntityRecord inParamSource;
public long inParamInvoiceId;
public long resCreateOrUpdateInvoiceExtendedCartaPorte_outParamId = 0L;

public lcvInvoiceExtendedCartaPorteCreateOrUpdate(EN_9bd576a05df3846c52ce88a606aff414EntityRecord inParamSource, long inParamInvoiceId) {
this.inParamSource = inParamSource;
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoInvoiceExtendedCartaPorteCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedCartaPorteCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedCartaPorteCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceExtendedCartaPorteCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedCartaPorteCreateOrUpdate(IRequestContext requestContext,EN_9bd576a05df3846c52ce88a606aff414EntityRecord inParamSource,long inParamInvoiceId,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedCartaPorteCreateOrUpdate result = new lcoInvoiceExtendedCartaPorteCreateOrUpdate();
lcvInvoiceExtendedCartaPorteCreateOrUpdate localVars = new lcvInvoiceExtendedCartaPorteCreateOrUpdate(inParamSource, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedCartaPorteCreateOrUpdate", "80779ccd-2e03-448f-ae06-50eedad0c497"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedCartaPorteCreateOrUpdate", "80779ccd-2e03-448f-ae06-50eedad0c497", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamInvoiceId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Source.Id = InvoiceId
localVars.inParamSource.ssId = localVars.inParamInvoiceId;
// CreateOrUpdateInvoiceExtendedCartaPorte
localVars.resCreateOrUpdateInvoiceExtendedCartaPorte_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedCartaPorte(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_79b8311427bcbe4ce4ecbe042bf03773)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedCartaPorte.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedCartaPorte_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("jKXkVE_bSEuly5lW4egssw#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedCartaPorteCreateOrUpdate {



}


}
