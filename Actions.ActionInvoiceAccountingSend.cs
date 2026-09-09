namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingSend : VarsBag {
public long inParami_InvoiceId;
public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting;
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList;
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended;
public RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList;
public bool inParami_IsImport;
public RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries;
public Actions.lcoInvoiceAccountingSave resInvoiceAccountingSave =  new Actions.lcoInvoiceAccountingSave();
public lcvInvoiceAccountingSend(long inParami_InvoiceId, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting, RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList, EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended, RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList, bool inParami_IsImport, RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceAccounting = inParami_InvoiceAccounting;
this.inParami_InvoiceAddendumList = inParami_InvoiceAddendumList;
this.inParami_InvoiceExtended = inParami_InvoiceExtended;
this.inParami_InvoiceAccountingServicesList = inParami_InvoiceAccountingServicesList;
this.inParami_IsImport = inParami_IsImport;
this.inParami_InvoiceAccountingEntries = inParami_InvoiceAccountingEntries;
}
}
public class lcoInvoiceAccountingSend : VarsBag {
public string outParamErrorMsg = "";

public lcoInvoiceAccountingSend() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingSend</code> that represents the Service Studio action
///  <code>InvoiceAccountingSend</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionInvoiceAccountingSend(IRequestContext requestContext,long inParami_InvoiceId,EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting,RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList,EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended,RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList,bool inParami_IsImport,RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoInvoiceAccountingSend result = new lcoInvoiceAccountingSend();
lcvInvoiceAccountingSend localVars = new lcvInvoiceAccountingSend(inParami_InvoiceId, inParami_InvoiceAccounting, inParami_InvoiceAddendumList, inParami_InvoiceExtended, inParami_InvoiceAccountingServicesList, inParami_IsImport, inParami_InvoiceAccountingEntries);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingSend", "d611e01e-3b6f-4d89-8589-22359554edad"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingSend", "d611e01e-3b6f-4d89-8589-22359554edad", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// i_InvoiceAccounting.SubmissionBy = GetUserId
localVars.inParami_InvoiceAccounting.ssSubmissionBy = BuiltInFunction.GetUserId ();

// i_InvoiceAccounting.SubmissionOn = CurrDateTime
localVars.inParami_InvoiceAccounting.ssSubmissionOn = BuiltInFunction.CurrDateTime ();
// InvoiceAccountingSave
localVars.resInvoiceAccountingSave.outParamo_Output = await Actions.ActionInvoiceAccountingSave(requestContext,localVars.inParami_InvoiceId,localVars.inParami_InvoiceAccounting,localVars.inParami_InvoiceAddendumList,localVars.inParami_InvoiceExtended,localVars.inParami_InvoiceAccountingServicesList,localVars.inParami_IsImport,localVars.inParami_InvoiceAccountingEntries,cancellationToken);

// error?
if((!(localVars.resInvoiceAccountingSave.outParamo_Output.ssIsSuccess))) {
// ErrorMsg = InvoiceAccountingSave.o_Output.Message
result.outParamErrorMsg=localVars.resInvoiceAccountingSave.outParamo_Output.ssMessage;
}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionInvoiceAccountingSend {



}


}
