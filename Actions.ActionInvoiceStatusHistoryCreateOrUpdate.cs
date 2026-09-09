namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceStatusHistoryCreateOrUpdate : VarsBag {
public EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceStatusHistory_outParamId = 0L;

public lcvInvoiceStatusHistoryCreateOrUpdate(EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceStatusHistoryCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceStatusHistoryCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceStatusHistoryCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceStatusHistoryCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceStatusHistoryCreateOrUpdate(IRequestContext requestContext,EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceStatusHistoryCreateOrUpdate result = new lcoInvoiceStatusHistoryCreateOrUpdate();
lcvInvoiceStatusHistoryCreateOrUpdate localVars = new lcvInvoiceStatusHistoryCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceStatusHistoryCreateOrUpdate", "8c942f93-85d5-4982-b0bf-794ad7ab2057"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceStatusHistoryCreateOrUpdate", "8c942f93-85d5-4982-b0bf-794ad7ab2057", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateInvoiceStatusHistory
localVars.resCreateOrUpdateInvoiceStatusHistory_outParamId = await ExtendedActions.CreateOrUpdateInvoiceStatusHistory(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_a2551032116fa7acb5fb1896fd9acdf2)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceStatusHistory.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceStatusHistory_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceStatusHistoryCreateOrUpdate {



}


}
