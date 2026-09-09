namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedMoreChargeCreateOrUpdate : VarsBag {
public EN_a9440c310249b67518f0615139b4c690EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceExtendedMoreCharges_outParamId = 0L;

public lcvInvoiceExtendedMoreChargeCreateOrUpdate(EN_a9440c310249b67518f0615139b4c690EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedMoreChargeCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedMoreChargeCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedMoreChargeCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceExtendedMoreChargeCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedMoreChargeCreateOrUpdate(IRequestContext requestContext,EN_a9440c310249b67518f0615139b4c690EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedMoreChargeCreateOrUpdate result = new lcoInvoiceExtendedMoreChargeCreateOrUpdate();
lcvInvoiceExtendedMoreChargeCreateOrUpdate localVars = new lcvInvoiceExtendedMoreChargeCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedMoreChargeCreateOrUpdate", "61d96c74-7f84-4e05-86e5-88ae2adbdaa4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedMoreChargeCreateOrUpdate", "61d96c74-7f84-4e05-86e5-88ae2adbdaa4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateInvoiceExtendedMoreCharges
localVars.resCreateOrUpdateInvoiceExtendedMoreCharges_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedMoreCharges(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_152a5bcdbf970bfba2a0da40766a2168)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedMoreCharges.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedMoreCharges_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedMoreChargeCreateOrUpdate {



}


}
