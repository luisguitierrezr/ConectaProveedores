namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceApproveBulk : VarsBag {
public RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList;
public string inParami_Comment;
public int inParamOffsetUtc;
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

public Actions.lcoApprovModifInv resApprovModifInv =  new Actions.lcoApprovModifInv();
public lcvInvoiceApproveBulk(RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoInvoiceApproveBulk : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public bool outParamIsFinish = false;

public lcoInvoiceApproveBulk() {
}
}
/// <summary>
/// Action <code>InvoiceApproveBulk</code> that represents the Service Studio action
///  <code>InvoiceApproveBulk</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure,bool)> ActionInvoiceApproveBulk(IRequestContext requestContext,RL_0bff49813ef08eecaf6190c2661eb115 inParami_InvoiceList,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
bool outParamIsFinish = default;
lcoInvoiceApproveBulk result = new lcoInvoiceApproveBulk();
lcvInvoiceApproveBulk localVars = new lcvInvoiceApproveBulk(inParami_InvoiceList, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceApproveBulk", "8a0af485-da74-464d-a6a5-505819453c49"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceApproveBulk", "8a0af485-da74-464d-a6a5-505819453c49", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// Foreach i_InvoiceList
localVars.inParami_InvoiceList.StartIteration();
try {while (!((localVars.inParami_InvoiceList.Eof))) {
// ApprovModifInv
(localVars.resApprovModifInv.outParamo_Output,localVars.resApprovModifInv.outParamIsFinish) = await Actions.ActionApprovModifInv(requestContext,localVars.inParami_InvoiceList.CurrentRec.ssInvoiceId,localVars.inParami_InvoiceList.CurrentRec.ssInvoiceApprovalLevelId,true,localVars.inParami_Comment,localVars.inParamOffsetUtc,localVars.inParami_GetUserId,cancellationToken);

// IsFinish = ApprovModifInv.IsFinish
result.outParamIsFinish=localVars.resApprovModifInv.outParamIsFinish;
// IsSuccess
if((localVars.resApprovModifInv.outParamo_Output.ssIsSuccess)) {
// o_CountSuccess = o_CountSuccess + 1
localVars.varLco_CountSuccess=(localVars.varLco_CountSuccess+1);
} else {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = If
result.outParamo_Output.ssMessage = (((result.outParamo_Output.ssMessage=="")) ? (((AppUtils.GetStringResource("8Z0seqlXuEu9LAfeEYahXQ#Value.-1159026916.1", "The approval of the following invoices failed:")+" ")+localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber)) : (((result.outParamo_Output.ssMessage+", ")+localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber)));

// o_CountFailed = o_CountFailed + 1
localVars.varLco_CountFailed=(localVars.varLco_CountFailed+1);
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamNotificationError.ssApprovalErrorList,new RC_1f579c47758735b50f415dd5b367a40b(){ ssError = localVars.resApprovModifInv.outParamo_Output.ssMessage, ssNumber = localVars.inParami_InvoiceList.CurrentRec.ssInvoiceNumber },cancellationToken);

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

// NotificationContent.Title = "Bulk approve"
result.outParamNotificationContent.ssTitle = AppUtils.GetStringResource("xowf0+k9p0Wkd1y4zczQ4w#Value.-590802337.1", "Bulk approve");
// NotificationError.Title = "Bulk approve"
result.outParamNotificationError.ssTitle = AppUtils.GetStringResource("k5OtZ99XdEeiLtq44Y+CvA#Value.-590802337.1", "Bulk approve");
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

// NotificationContent.Title = "Bulk approve"
result.outParamNotificationContent.ssTitle = AppUtils.GetStringResource("FBD0PyfTIkGx4iiYU_BzQg#Value.-590802337.1", "Bulk approve");
// NotificationError.Title = "Bulk approve"
result.outParamNotificationError.ssTitle = AppUtils.GetStringResource("iDCbbfQL8EitthMivvHvLg#Value.-590802337.1", "Bulk approve");
// o_Output.Message = o_Output.Message + "." + " " + "Due to a timeout, some invoices have not been approved!"
result.outParamo_Output.ssMessage = (((result.outParamo_Output.ssMessage+".")+" ")+AppUtils.GetStringResource("JcEIdVN6xU6jNXANXJfX1w#Value.-459418288.1", "Due to a timeout, some invoices have not been approved!"));

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
outParamNotificationContent = result.outParamNotificationContent;
outParamNotificationError = result.outParamNotificationError;
outParamIsFinish = result.outParamIsFinish;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamNotificationContent,outParamNotificationError,outParamIsFinish);
}

public static class FuncActionInvoiceApproveBulk {



}


}
