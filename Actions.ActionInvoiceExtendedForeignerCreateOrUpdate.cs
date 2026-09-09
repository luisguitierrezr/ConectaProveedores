namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedForeignerCreateOrUpdate : VarsBag {
public EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceExtendedForeigner_outParamId = 0L;

public lcvInvoiceExtendedForeignerCreateOrUpdate(EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceExtendedForeignerCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceExtendedForeignerCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceExtendedForeignerCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceExtendedForeignerCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceExtendedForeignerCreateOrUpdate(IRequestContext requestContext,EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceExtendedForeignerCreateOrUpdate result = new lcoInvoiceExtendedForeignerCreateOrUpdate();
lcvInvoiceExtendedForeignerCreateOrUpdate localVars = new lcvInvoiceExtendedForeignerCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedForeignerCreateOrUpdate", "6ff06292-25b4-45c0-ae6f-83159f570ffb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedForeignerCreateOrUpdate", "6ff06292-25b4-45c0-ae6f-83159f570ffb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamSource.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// CreateOrUpdateInvoiceExtendedForeigner
localVars.resCreateOrUpdateInvoiceExtendedForeigner_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedForeigner(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_decbed55750bb4030b04e46c0306e56b)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceExtendedForeigner.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceExtendedForeigner_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException ("Identifier is mandatory");

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceExtendedForeignerCreateOrUpdate {



}


}
