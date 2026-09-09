namespace ssConectaProveedores;

public partial class Actions {
public class lcvRejectInvoice : VarsBag {
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice;
public lcvRejectInvoice(EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice) {
this.inParamInvoice = inParamInvoice;
}
}
/// <summary>
/// Action <code>RejectInvoice</code> that represents the Service Studio action
///  <code>RejectInvoice</code> <p> Description: </p>
/// </summary>
public static async Task ActionRejectInvoice(IRequestContext requestContext,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice,CancellationToken cancellationToken) {
lcvRejectInvoice localVars = new lcvRejectInvoice(inParamInvoice);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RejectInvoice", "56ed8fd4-5d6b-4996-bb01-541d5e7f0f80"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RejectInvoice", "56ed8fd4-5d6b-4996-bb01-541d5e7f0f80", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Invoice.InvoiceStatusId = Rejected
localVars.inParamInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("rN7AdMIY8UCc6++CrM79jQ"))).ssId;
// UpdateInvoice
await ExtendedActions.UpdateInvoice(requestContext,localVars.inParamInvoice.ChangedAttributes,(((RC_04c5986b32c7822f033c933cf71b96bd)localVars.inParamInvoice)),cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRejectInvoice {



}


}
