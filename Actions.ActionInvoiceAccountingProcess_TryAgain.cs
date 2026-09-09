namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcess_TryAgain : VarsBag {
public long inParamInvoiceId;
public string inParamInvoiceName;
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess;
public string inParamMsg;
public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public Actions.lcoInvoiceLogAdd resInvoiceLogAddApprove =  new Actions.lcoInvoiceLogAdd();
public lcvInvoiceAccountingProcess_TryAgain(long inParamInvoiceId, string inParamInvoiceName, EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess, string inParamMsg) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceName = inParamInvoiceName;
this.inParamInvoiceAccountingProcess = inParamInvoiceAccountingProcess;
this.inParamMsg = inParamMsg;
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcess_TryAgain</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcess_TryAgain</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvoiceAccountingProcess_TryAgain(IRequestContext requestContext,long inParamInvoiceId,string inParamInvoiceName,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess,string inParamMsg,CancellationToken cancellationToken) {
lcvInvoiceAccountingProcess_TryAgain localVars = new lcvInvoiceAccountingProcess_TryAgain(inParamInvoiceId, inParamInvoiceName, inParamInvoiceAccountingProcess, inParamMsg);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcess_TryAgain", "22c065ad-e6c4-4267-9cc2-406ef47a2834"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcess_TryAgain", "22c065ad-e6c4-4267-9cc2-406ef47a2834", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// InvoiceAccountingProcessCreateOrUpdate
localVars.resInvoiceAccountingProcessCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingProcessCreateOrUpdate(requestContext,localVars.inParamInvoiceAccountingProcess,cancellationToken);

// InvoiceLogAddApprove
localVars.resInvoiceLogAddApprove.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParamInvoiceId, ssMessage = (((((((((AppUtils.GetStringResource("xarq4QRl+U2MndgP_G7P3g#Value.-670115059.1", "Invoice")+" ")+localVars.inParamInvoiceName)+" ")+AppUtils.GetStringResource("xarq4QRl+U2MndgP_G7P3g#Value.-1097999538.1", "failed to start contabilization"))+"#")+Convert.ToString((localVars.inParamInvoiceAccountingProcess.ssNextTry-1)))+(((localVars.inParamMsg!="")) ? ((": "+localVars.inParamMsg)) : ("")))+" - ")+AppUtils.GetStringResource("xarq4QRl+U2MndgP_G7P3g#Value.-1006243020.1", "retrying.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssIsError = true },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceAccountingProcess_TryAgain {



}


}
