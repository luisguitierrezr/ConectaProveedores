namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedSelloDigitalCreateOrUpdate : VarsBag {
public EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceExtendedSelloDigital_outParamId = 0L;

public lcvInvoiceExtendedSelloDigitalCreateOrUpdate(EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedSelloDigitalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedSelloDigitalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedSelloDigitalCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceExtendedSelloDigitalCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedSelloDigitalCreateOrUpdate(IRequestContext requestContext,EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedSelloDigitalCreateOrUpdate result = new lcoInvoiceExtendedSelloDigitalCreateOrUpdate();
lcvInvoiceExtendedSelloDigitalCreateOrUpdate localVars = new lcvInvoiceExtendedSelloDigitalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedSelloDigitalCreateOrUpdate", "e644e453-c500-4ec1-b1ff-30e04d46eda2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedSelloDigitalCreateOrUpdate", "e644e453-c500-4ec1-b1ff-30e04d46eda2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamSource.ssInvoiceId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// CreateOrUpdateInvoiceExtendedSelloDigital
localVars.resCreateOrUpdateInvoiceExtendedSelloDigital_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedSelloDigital(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_d5bae0a1e64415dc86dedbeae539158c)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedSelloDigital.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedSelloDigital_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("kC9ftS4qvkCQ1Ies89NHqQ#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedSelloDigitalCreateOrUpdate {



}


}
