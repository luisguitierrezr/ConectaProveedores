namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceCancelBulk : VarsBag {
public RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList;
public string inParami_Comment;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>o_CountSuccess</code> that represents the Service Studio Integer
///  <code>o_CountSuccess</code> <p>Description: </p>
/// </summary>
public int varLco_CountSuccess = 0;

/// <summary>
/// Variable <code>o_CountFailed</code> that represents the Service Studio Integer
///  <code>o_CountFailed</code> <p>Description: </p>
/// </summary>
public int varLco_CountFailed = 0;

public Actions.lcoInvoiceCancel resInvoiceCancel =  new Actions.lcoInvoiceCancel();
public lcvInvoiceCancelBulk(RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList, string inParami_Comment, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoInvoiceCancelBulk : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public lcoInvoiceCancelBulk() {
}
}
/// <summary>
/// Action <code>InvoiceCancelBulk</code> that represents the Service Studio action
///  <code>InvoiceCancelBulk</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)> ActionInvoiceCancelBulk(IRequestContext requestContext,RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList,string inParami_Comment,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
lcoInvoiceCancelBulk result = new lcoInvoiceCancelBulk();
lcvInvoiceCancelBulk localVars = new lcvInvoiceCancelBulk(inParami_InvoiceList, inParami_Comment, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceCancelBulk", "31465893-e728-4839-be5a-6ba034af27c0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceCancelBulk", "31465893-e728-4839-be5a-6ba034af27c0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// Foreach i_InvoiceList
localVars.inParami_InvoiceList.StartIteration();
try {while (!((localVars.inParami_InvoiceList.Eof))) {
// InvoiceCancel
localVars.resInvoiceCancel.outParamo_Output = await Actions.ActionInvoiceCancel(requestContext,localVars.inParami_InvoiceList.CurrentRec.ssInvoiceId,localVars.inParami_InvoiceList.CurrentRec.ssInvoiceApprovalLevelId,localVars.inParami_Comment,localVars.inParami_GetUserId,cancellationToken);

// IsSuccess
if((localVars.resInvoiceCancel.outParamo_Output.ssIsSuccess)) {
// o_CountSuccess = o_CountSuccess + 1
localVars.varLco_CountSuccess=(localVars.varLco_CountSuccess+1);
} else {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = If
result.outParamo_Output.ssMessage = (((result.outParamo_Output.ssMessage!="")) ? (((AppUtils.GetStringResource("Pp6Gbp2EqkCh81a6vUO8zQ#Value.378006108.1", "The cancellation of the following invoices failed:")+" ")+localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber)) : (((result.outParamo_Output.ssMessage+", ")+localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber)));

// o_CountFailed = o_CountFailed + 1
localVars.varLco_CountFailed=(localVars.varLco_CountFailed+1);
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamNotificationError.ssApprovalErrorList,new RC_1f579c47758735b50f415dd5b367a40b(){ ssError = localVars.resInvoiceCancel.outParamo_Output.ssMessage, ssNumber = localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber },cancellationToken);

}

// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

localVars.inParami_InvoiceList.Advance();
}

} finally {
localVars.inParami_InvoiceList.EndIteration();
}

// o_Output.Message = o_Output.Message + "."
result.outParamo_Output.ssMessage = (result.outParamo_Output.ssMessage+".");
// NotificationContent
// NotificationContent.NrOfRecordsAffected = i_InvoiceList.Length
result.outParamNotificationContent.ssNrOfRecordsAffected = localVars.inParami_InvoiceList.Length;

// NotificationContent.NrOfRecordsSuccessful = o_CountSuccess
result.outParamNotificationContent.ssNrOfRecordsSuccessful = localVars.varLco_CountSuccess;

// NotificationContent.NrOfRecordsUnsuccessful = o_CountFailed
result.outParamNotificationContent.ssNrOfRecordsUnsuccessful = localVars.varLco_CountFailed;

// NotificationContent.Title = "Bulk cancel"
result.outParamNotificationContent.ssTitle = AppUtils.GetStringResource("YdwnSXFrB02FBSrtjMsHYw#Value.1271199016.1", "Bulk cancel");
// NotificationError.Title = "Bulk cancel"
result.outParamNotificationError.ssTitle = AppUtils.GetStringResource("Y9rA6Tk890ummOS4hMN3Yw#Value.1271199016.1", "Bulk cancel");
} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// NotificationContent
// NotificationContent.NrOfRecordsAffected = i_InvoiceList.Length
result.outParamNotificationContent.ssNrOfRecordsAffected = localVars.inParami_InvoiceList.Length;

// NotificationContent.NrOfRecordsSuccessful = o_CountSuccess
result.outParamNotificationContent.ssNrOfRecordsSuccessful = localVars.varLco_CountSuccess;

// NotificationContent.NrOfRecordsUnsuccessful = o_CountFailed
result.outParamNotificationContent.ssNrOfRecordsUnsuccessful = localVars.varLco_CountFailed;

// NotificationContent.Title = "Bulk cancel"
result.outParamNotificationContent.ssTitle = AppUtils.GetStringResource("aCpaigncyEuBARWDVsyrHg#Value.1271199016.1", "Bulk cancel");
// NotificationError.Title = "Bulk cancel"
result.outParamNotificationError.ssTitle = AppUtils.GetStringResource("Z2jqZM6YOE2lFjzug4rpxQ#Value.1271199016.1", "Bulk cancel");
// o_Output.Message = o_Output.Message + "." + " " + "Due to a timeout, some invoices have not been canceled!"
result.outParamo_Output.ssMessage = (((result.outParamo_Output.ssMessage+".")+" ")+AppUtils.GetStringResource("MhcXdq1jEUWYf1zqUvzYeA#Value.1929278382.1", "Due to a timeout, some invoices have not been canceled!"));

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
outParamNotificationContent = result.outParamNotificationContent;
outParamNotificationError = result.outParamNotificationError;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamNotificationContent,outParamNotificationError);
}

public static class FuncActionInvoiceCancelBulk {



}


}
