namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceApprovalLevelDelete : VarsBag {
public long inParamId;
public lcvInvoiceApprovalLevelDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>InvoiceApprovalLevelDelete</code> that represents the Service Studio action
///  <code>InvoiceApprovalLevelDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionInvoiceApprovalLevelDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvInvoiceApprovalLevelDelete localVars = new lcvInvoiceApprovalLevelDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceApprovalLevelDelete", "4d4c4e88-ace9-4267-be7e-ca9c7728cd4d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceApprovalLevelDelete", "4d4c4e88-ace9-4267-be7e-ca9c7728cd4d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteInvoiceApprovalLevel
await ExtendedActions.DeleteInvoiceApprovalLevel(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("j8ZT_STLN0+fd+E6AE4LIw#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceApprovalLevelDelete {



}


}
