namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcessCreateOrUpdate : VarsBag {
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource;
public long resCreateOrUpdateInvoiceAccountingProcess_outParamId = 0L;

public lcvInvoiceAccountingProcessCreateOrUpdate(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingProcessCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingProcessCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcessCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceAccountingProcessCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingProcessCreateOrUpdate(IRequestContext requestContext,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingProcessCreateOrUpdate result = new lcoInvoiceAccountingProcessCreateOrUpdate();
lcvInvoiceAccountingProcessCreateOrUpdate localVars = new lcvInvoiceAccountingProcessCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcessCreateOrUpdate", "0bc75158-5831-448a-a8b3-8be6207680a7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcessCreateOrUpdate", "0bc75158-5831-448a-a8b3-8be6207680a7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateInvoiceAccountingProcess
localVars.resCreateOrUpdateInvoiceAccountingProcess_outParamId = await ExtendedActions.CreateOrUpdateInvoiceAccountingProcess(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_d01c9a070ebc097e32a128e1b4125cc2)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceAccountingProcess.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceAccountingProcess_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingProcessCreateOrUpdate {



}


}
