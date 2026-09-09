namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioApproveBulk : VarsBag {
public RL_79ea8920a52237936a05ba9320d22c38 inParami_FolioList;
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

public Actions.lcoApprovRejectFolio resApprovRejectFolio =  new Actions.lcoApprovRejectFolio();
public lcvFolioApproveBulk(RL_79ea8920a52237936a05ba9320d22c38 inParami_FolioList, string inParami_Comment, int inParamOffsetUtc, string inParami_GetUserId) {
this.inParami_FolioList = inParami_FolioList;
this.inParami_Comment = inParami_Comment;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoFolioApproveBulk : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = new ST_6ac87b97c676cd17082ba2063283d4baStructure();

public ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();

public lcoFolioApproveBulk() {
}
}
/// <summary>
/// Action <code>FolioApproveBulk</code> that represents the Service Studio action
///  <code>FolioApproveBulk</code> <p> Description: Action to approve Folios in bulk.</p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_6ac87b97c676cd17082ba2063283d4baStructure,ST_bb4ffb4d3263f72e713312025a0e6fc7Structure)> ActionFolioApproveBulk(IRequestContext requestContext,RL_79ea8920a52237936a05ba9320d22c38 inParami_FolioList,string inParami_Comment,int inParamOffsetUtc,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_6ac87b97c676cd17082ba2063283d4baStructure outParamNotificationContent = default;
ST_bb4ffb4d3263f72e713312025a0e6fc7Structure outParamNotificationError = default;
lcoFolioApproveBulk result = new lcoFolioApproveBulk();
lcvFolioApproveBulk localVars = new lcvFolioApproveBulk(inParami_FolioList, inParami_Comment, inParamOffsetUtc, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioApproveBulk", "6751cf5e-a7d9-44c1-b463-4b1d8141b10e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioApproveBulk", "6751cf5e-a7d9-44c1-b463-4b1d8141b10e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// Foreach i_FolioList
localVars.inParami_FolioList.StartIteration();
try {while (!((localVars.inParami_FolioList.Eof))) {
// ApprovRejectFolio
localVars.resApprovRejectFolio.outParamo_Output = await Actions.ActionApprovRejectFolio(requestContext,localVars.inParami_FolioList.CurrentRec.ssFolioId,localVars.inParami_FolioList.CurrentRec.ssFolioApprovalLevelId,true,localVars.inParami_Comment,localVars.inParamOffsetUtc,localVars.inParami_GetUserId,cancellationToken);

// IsSuccess
if((localVars.resApprovRejectFolio.outParamo_Output.ssIsSuccess)) {
// o_CountSuccess = o_CountSuccess + 1
localVars.varLco_CountSuccess=(localVars.varLco_CountSuccess+1);
// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

} else {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = If
result.outParamo_Output.ssMessage = (((result.outParamo_Output.ssMessage=="")) ? (((AppUtils.GetStringResource("JfxYWYiU30OEMZnSiiBnRA#Value.-1159026916.1", "The approval of the following invoices failed:")+" ")+localVars.inParami_FolioList.CurrentRec.ssFolioNumber)) : (((result.outParamo_Output.ssMessage+", ")+localVars.inParami_FolioList.CurrentRec.ssFolioNumber)));

// o_CountFailed = o_CountFailed + 1
localVars.varLco_CountFailed=(localVars.varLco_CountFailed+1);
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamNotificationError.ssApprovalErrorList,new RC_1f579c47758735b50f415dd5b367a40b(){ ssError = localVars.resApprovRejectFolio.outParamo_Output.ssMessage, ssNumber = localVars.inParami_FolioList.CurrentRec.ssFolioNumber },cancellationToken);

}

localVars.inParami_FolioList.Advance();
}

} finally {
localVars.inParami_FolioList.EndIteration();
}

// o_Output.Message = o_Output.Message + "."
result.outParamo_Output.ssMessage = (result.outParamo_Output.ssMessage+".");
// NotificationContent
// NotificationContent.NrOfRecordsAffected = i_FolioList.Length
result.outParamNotificationContent.ssNrOfRecordsAffected = localVars.inParami_FolioList.Length;

// NotificationContent.NrOfRecordsSuccessful = o_CountSuccess
result.outParamNotificationContent.ssNrOfRecordsSuccessful = localVars.varLco_CountSuccess;

// NotificationContent.NrOfRecordsUnsuccessful = o_CountFailed
result.outParamNotificationContent.ssNrOfRecordsUnsuccessful = localVars.varLco_CountFailed;

// NotificationContent.Title = "Bulk approve"
result.outParamNotificationContent.ssTitle = AppUtils.GetStringResource("UzFqfCWqv0itwUrBJpwR6g#Value.-590802337.1", "Bulk approve");
// NotificationError.Title = "Bulk approve"
result.outParamNotificationError.ssTitle = AppUtils.GetStringResource("2rud6B18CkatsBhG39BfkQ#Value.-590802337.1", "Bulk approve");
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamNotificationContent = result.outParamNotificationContent;
outParamNotificationError = result.outParamNotificationError;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamNotificationContent,outParamNotificationError);
}

public static class FuncActionFolioApproveBulk {



}


}
