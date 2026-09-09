namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceUpdate : VarsBag {
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource;
public lcvInvoiceUpdate(EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceUpdate</code> that represents the Service Studio action
///  <code>InvoiceUpdate</code> <p> Description: Encapsulates the Update entity action, enabling logi
/// c to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceUpdate(IRequestContext requestContext,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceUpdate result = new lcoInvoiceUpdate();
lcvInvoiceUpdate localVars = new lcvInvoiceUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceUpdate", "4b5e21de-2dda-4daf-a2fa-fafe4528870f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceUpdate", "4b5e21de-2dda-4daf-a2fa-fafe4528870f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamSource.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();

// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();
// UpdateInvoice
await ExtendedActions.UpdateInvoice(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_04c5986b32c7822f033c933cf71b96bd)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = Source.Id
result.outParamId=localVars.inParamSource.ssId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("uhs6rmBMTU+BA9I1rHxBbg#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceUpdate {



}


}
