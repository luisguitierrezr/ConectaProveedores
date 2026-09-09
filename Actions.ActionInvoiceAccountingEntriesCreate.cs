namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingEntriesCreate : VarsBag {
public EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord inParamSource;
public long resCreateInvoiceAccountingEntries_outParamId = 0L;

public lcvInvoiceAccountingEntriesCreate(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceAccountingEntriesCreate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceAccountingEntriesCreate() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingEntriesCreate</code> that represents the Service Studio action
///  <code>InvoiceAccountingEntriesCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingEntriesCreate(IRequestContext requestContext,EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceAccountingEntriesCreate result = new lcoInvoiceAccountingEntriesCreate();
lcvInvoiceAccountingEntriesCreate localVars = new lcvInvoiceAccountingEntriesCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingEntriesCreate", "547ce195-c690-478b-a72e-6a14d02fc29f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingEntriesCreate", "547ce195-c690-478b-a72e-6a14d02fc29f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
// CreateInvoiceAccountingEntries
localVars.resCreateInvoiceAccountingEntries_outParamId = await ExtendedActions.CreateInvoiceAccountingEntries(requestContext,(((RC_85ff79276420f97ef98dc48e2b262e60)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateInvoiceAccountingEntries.Id
result.outParamId=localVars.resCreateInvoiceAccountingEntries_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceAccountingEntriesCreate {



}


}
