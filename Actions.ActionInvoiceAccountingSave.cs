namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingSave : VarsBag {
public long inParami_InvoiceId;
public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting;
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList;
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended;
public RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList;
public bool inParami_IsImport;
public RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries;
public Actions.lcoInvoiceAccountingCreateOrUpdate resInvoiceAccountingCreateOrUpdate =  new Actions.lcoInvoiceAccountingCreateOrUpdate();
public Actions.lcoInvoiceExtendedCreateOrUpdate resInvoiceExtendedCreateOrUpdate =  new Actions.lcoInvoiceExtendedCreateOrUpdate();
public Actions.lcoInvoiceAccountingServicesSave resInvoiceAccountingServicesSave =  new Actions.lcoInvoiceAccountingServicesSave();
public lcvInvoiceAccountingSave(long inParami_InvoiceId, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting, RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList, EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended, RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList, bool inParami_IsImport, RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceAccounting = inParami_InvoiceAccounting;
this.inParami_InvoiceAddendumList = inParami_InvoiceAddendumList;
this.inParami_InvoiceExtended = inParami_InvoiceExtended;
this.inParami_InvoiceAccountingServicesList = inParami_InvoiceAccountingServicesList;
this.inParami_IsImport = inParami_IsImport;
this.inParami_InvoiceAccountingEntries = inParami_InvoiceAccountingEntries;
}
}
public class lcoInvoiceAccountingSave : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInvoiceAccountingSave() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingSave</code> that represents the Service Studio action
///  <code>InvoiceAccountingSave</code> <p> Description: Action to Save Invoice Accounting.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInvoiceAccountingSave(IRequestContext requestContext,long inParami_InvoiceId,EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting,RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList,EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended,RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList,bool inParami_IsImport,RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInvoiceAccountingSave result = new lcoInvoiceAccountingSave();
lcvInvoiceAccountingSave localVars = new lcvInvoiceAccountingSave(inParami_InvoiceId, inParami_InvoiceAccounting, inParami_InvoiceAddendumList, inParami_InvoiceExtended, inParami_InvoiceAccountingServicesList, inParami_IsImport, inParami_InvoiceAccountingEntries);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingSave", "ea43a3f3-bb2b-4f16-8d94-70adb559aef6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingSave", "ea43a3f3-bb2b-4f16-8d94-70adb559aef6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// InvoiceExtendedCreateOrUpdate
localVars.resInvoiceExtendedCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedCreateOrUpdate(requestContext,localVars.inParami_InvoiceExtended,localVars.inParami_InvoiceId,cancellationToken);

// InvoiceAccountingCreateOrUpdate
localVars.resInvoiceAccountingCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingCreateOrUpdate(requestContext,localVars.inParami_InvoiceAccounting,cancellationToken);

// InvoiceAccountingServicesSave
localVars.resInvoiceAccountingServicesSave.outParamo_Output = await Actions.ActionInvoiceAccountingServicesSave(requestContext,localVars.inParami_InvoiceAccountingServicesList,localVars.inParami_InvoiceAccounting.ssId,cancellationToken);

// Is Import?
if((localVars.inParami_IsImport)) {
// InvoiceAccountingSaveImport
await Actions.ActionInvoiceAccountingSaveImport(requestContext,localVars.inParami_InvoiceAccountingEntries,localVars.inParami_InvoiceId,cancellationToken);

}

// HasAddendum?
if(((!localVars.inParami_InvoiceAddendumList.Empty))) {
// InvoiceExtendedMoreChargesCreateOrUpdate
await Actions.ActionInvoiceExtendedMoreChargesCreateOrUpdate(requestContext,localVars.inParami_InvoiceAddendumList,localVars.inParami_InvoiceId,cancellationToken);

}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInvoiceAccountingSave {



}


}
