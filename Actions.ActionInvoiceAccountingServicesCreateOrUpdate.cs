namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingServicesCreateOrUpdate : VarsBag {
public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceAccountingServices_outParamId = 0L;

public lcvInvoiceAccountingServicesCreateOrUpdate(EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingServicesCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingServicesCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingServicesCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceAccountingServicesCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingServicesCreateOrUpdate(IRequestContext requestContext,EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingServicesCreateOrUpdate result = new lcoInvoiceAccountingServicesCreateOrUpdate();
lcvInvoiceAccountingServicesCreateOrUpdate localVars = new lcvInvoiceAccountingServicesCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingServicesCreateOrUpdate", "0e879b16-240d-430c-b96a-95e75ed8512e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingServicesCreateOrUpdate", "0e879b16-240d-430c-b96a-95e75ed8512e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateInvoiceAccountingServices
localVars.resCreateOrUpdateInvoiceAccountingServices_outParamId = await ExtendedActions.CreateOrUpdateInvoiceAccountingServices(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_5a609a7b7b622cde2859ca506690f8db)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceAccountingServices.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceAccountingServices_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingServicesCreateOrUpdate {



}


}
