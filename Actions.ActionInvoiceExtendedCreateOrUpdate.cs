namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedCreateOrUpdate : VarsBag {
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource;
public long inParamInvoiceId;
public long resCreateOrUpdateInvoiceExtended_outParamId = 0L;

public lcvInvoiceExtendedCreateOrUpdate(EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource, long inParamInvoiceId) {
this.inParamSource = inParamSource;
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoInvoiceExtendedCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedCreateOrUpdate(IRequestContext requestContext,EN_f81a3d226103fd013068b8763798067aEntityRecord inParamSource,long inParamInvoiceId,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedCreateOrUpdate result = new lcoInvoiceExtendedCreateOrUpdate();
lcvInvoiceExtendedCreateOrUpdate localVars = new lcvInvoiceExtendedCreateOrUpdate(inParamSource, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedCreateOrUpdate", "7e2ba1a3-1b6f-4910-b081-63a55d7a6e5a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedCreateOrUpdate", "7e2ba1a3-1b6f-4910-b081-63a55d7a6e5a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Source.Id = InvoiceId
localVars.inParamSource.ssId = localVars.inParamInvoiceId;
// CreateOrUpdateInvoiceExtended
localVars.resCreateOrUpdateInvoiceExtended_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtended(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_fbe3f1050ad4f34fa0e0a15f88a56873)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtended.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtended_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedCreateOrUpdate {



}


}
