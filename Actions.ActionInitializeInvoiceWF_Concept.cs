namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitializeInvoiceWF_Concept : VarsBag {
public long inParami_InvoiceId;
public string inParami_CreateForUser;
public bool inParamIsRequisition;
public Actions.lcoInitInvWF resInitInvWF =  new Actions.lcoInitInvWF();
public lcvInitializeInvoiceWF_Concept(long inParami_InvoiceId, string inParami_CreateForUser, bool inParamIsRequisition) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_CreateForUser = inParami_CreateForUser;
this.inParamIsRequisition = inParamIsRequisition;
}
}
public class lcoInitializeInvoiceWF_Concept : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitializeInvoiceWF_Concept() {
}
}
/// <summary>
/// Action <code>InitializeInvoiceWF_Concept</code> that represents the Service Studio action
///  <code>InitializeInvoiceWF_Concept</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitializeInvoiceWF_Concept(IRequestContext requestContext,long inParami_InvoiceId,string inParami_CreateForUser,bool inParamIsRequisition,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitializeInvoiceWF_Concept result = new lcoInitializeInvoiceWF_Concept();
lcvInitializeInvoiceWF_Concept localVars = new lcvInitializeInvoiceWF_Concept(inParami_InvoiceId, inParami_CreateForUser, inParamIsRequisition);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitializeInvoiceWF_Concept", "f80d373a-adf5-41ab-a031-c9ab8ab5818a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitializeInvoiceWF_Concept", "f80d373a-adf5-41ab-a031-c9ab8ab5818a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((localVars.inParamIsRequisition)) {
// InitInvWF
localVars.resInitInvWF.outParamo_Output = await Actions.ActionInitInvWF(requestContext,localVars.inParami_InvoiceId,localVars.inParami_CreateForUser,cancellationToken);

// o_Output = InitInvWF.o_Output
result.outParamo_Output=localVars.resInitInvWF.outParamo_Output;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInitializeInvoiceWF_Concept {



}


}
