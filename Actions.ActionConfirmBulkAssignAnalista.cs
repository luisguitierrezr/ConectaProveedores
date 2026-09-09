namespace ssConectaProveedores;

public partial class Actions {
public class lcvConfirmBulkAssignAnalista : VarsBag {
public RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList;
public string inParami_UserId;
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

public Actions.lcoConfirmAssignAnalista resConfirmAssignAnalista =  new Actions.lcoConfirmAssignAnalista();
public lcvConfirmBulkAssignAnalista(RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoConfirmBulkAssignAnalista : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public lcoConfirmBulkAssignAnalista() {
}
}
/// <summary>
/// Action <code>ConfirmBulkAssignAnalista</code> that represents the Service Studio action
///  <code>ConfirmBulkAssignAnalista</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)> ActionConfirmBulkAssignAnalista(IRequestContext requestContext,RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList,string inParami_UserId,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
lcoConfirmBulkAssignAnalista result = new lcoConfirmBulkAssignAnalista();
lcvConfirmBulkAssignAnalista localVars = new lcvConfirmBulkAssignAnalista(inParami_InvoiceList, inParami_UserId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ConfirmBulkAssignAnalista", "02aa5f15-907c-4891-9d87-c898d660ad20"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ConfirmBulkAssignAnalista", "02aa5f15-907c-4891-9d87-c898d660ad20", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// Foreach i_InvoiceList
localVars.inParami_InvoiceList.StartIteration();
try {while (!((localVars.inParami_InvoiceList.Eof))) {
// ConfirmAssignAnalista
localVars.resConfirmAssignAnalista.outParamo_Output = await Actions.ActionConfirmAssignAnalista(requestContext,localVars.inParami_InvoiceList.CurrentRec.ssInvoiceId,localVars.inParami_InvoiceList.CurrentRec.ssInvoiceApprovalLevelId,localVars.inParami_UserId,localVars.inParami_GetUserId,cancellationToken);

// IsSuccess
if((localVars.resConfirmAssignAnalista.outParamo_Output.ssIsSuccess)) {
// o_CountSuccess = o_CountSuccess + 1
localVars.varLco_CountSuccess=(localVars.varLco_CountSuccess+1);
} else {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = If
result.outParamo_Output.ssMessage = (((result.outParamo_Output.ssMessage=="")) ? (((AppUtils.GetStringResource("fC_fx0FRSEmWykkItM+k9w#Value.1251770606.1", "The assigning of the following invoices failed:")+" ")+localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber)) : (((result.outParamo_Output.ssMessage+", ")+localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber)));

// o_CountFailed = o_CountFailed + 1
localVars.varLco_CountFailed=(localVars.varLco_CountFailed+1);
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamNotificationError.ssApprovalErrorList,new RC_1f579c47758735b50f415dd5b367a40b(){ ssError = localVars.resConfirmAssignAnalista.outParamo_Output.ssMessage, ssNumber = localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber },cancellationToken);

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

// NotificationContent.Title = "Bulk assign"
result.outParamNotificationContent.ssTitle = AppUtils.GetStringResource("THneZ2_7HkaM61wr05k0fA#Value.1230718877.1", "Bulk assign");
// NotificationError.Title = "Bulk assign"
result.outParamNotificationError.ssTitle = AppUtils.GetStringResource("hu8MSvo3oUGDX75ODlgXBA#Value.1230718877.1", "Bulk assign");
} //close CreateActionActivity using block
} // try

catch (CommunicationException ex) {
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

// NotificationContent.Title = "Bulk assign"
result.outParamNotificationContent.ssTitle = AppUtils.GetStringResource("uMX8EJfWL0We_TgGb3VCbA#Value.1230718877.1", "Bulk assign");
// NotificationError.Title = "Bulk assign"
result.outParamNotificationError.ssTitle = AppUtils.GetStringResource("HqaLqEhXk0Geqi3ygXmrYA#Value.1230718877.1", "Bulk assign");
// o_Output.Message = o_Output.Message + "." + " " + "Due to a timeout, some invoices have not been assigned!"
result.outParamo_Output.ssMessage = (((result.outParamo_Output.ssMessage+".")+" ")+AppUtils.GetStringResource("6TssfSCIWUmqrU78UUW4_w#Value.-1423699687.1", "Due to a timeout, some invoices have not been assigned!"));

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

public static class FuncActionConfirmBulkAssignAnalista {



}


}
