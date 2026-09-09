namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedReceiverCreateOrUpdate : VarsBag {
public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord inParamSource;
public long inParamInvoiceId;
public long resCreateOrUpdateInvoiceExtendedReceiver_outParamId = 0L;

public lcvInvoiceExtendedReceiverCreateOrUpdate(EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord inParamSource, long inParamInvoiceId) {
this.inParamSource = inParamSource;
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoInvoiceExtendedReceiverCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedReceiverCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedReceiverCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedReceiverCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedReceiverCreateOrUpdate(IRequestContext requestContext,EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord inParamSource,long inParamInvoiceId,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedReceiverCreateOrUpdate result = new lcoInvoiceExtendedReceiverCreateOrUpdate();
lcvInvoiceExtendedReceiverCreateOrUpdate localVars = new lcvInvoiceExtendedReceiverCreateOrUpdate(inParamSource, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedReceiverCreateOrUpdate", "4cca32e4-eaac-4d9f-b82b-a22522ab8d49"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedReceiverCreateOrUpdate", "4cca32e4-eaac-4d9f-b82b-a22522ab8d49", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamInvoiceId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Source.Id = InvoiceId
localVars.inParamSource.ssId = localVars.inParamInvoiceId;
// CreateOrUpdateInvoiceExtendedReceiver
localVars.resCreateOrUpdateInvoiceExtendedReceiver_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedReceiver(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_466f18b870f78193989904128fc2d15c)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedReceiver.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedReceiver_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("GlwyAlDdbU614rmBbNTxBQ#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedReceiverCreateOrUpdate {



}


}
