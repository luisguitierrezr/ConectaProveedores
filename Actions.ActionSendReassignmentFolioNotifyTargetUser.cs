namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendReassignmentFolioNotifyTargetUser : VarsBag {
public RC_34272dae45b4de5e1332f46c6e8700b9 inParami_TargetUserAUUser;
public string inParami_FolioListReassigned;
public string inParami_CreatedByUsername;
public string inParami_Motive;
public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public lcvSendReassignmentFolioNotifyTargetUser(RC_34272dae45b4de5e1332f46c6e8700b9 inParami_TargetUserAUUser, string inParami_FolioListReassigned, string inParami_CreatedByUsername, string inParami_Motive) {
this.inParami_TargetUserAUUser = inParami_TargetUserAUUser;
this.inParami_FolioListReassigned = inParami_FolioListReassigned;
this.inParami_CreatedByUsername = inParami_CreatedByUsername;
this.inParami_Motive = inParami_Motive;
}
}
/// <summary>
/// Action <code>SendReassignmentFolioNotifyTargetUser</code> that represents the Service Studio action
///  <code>SendReassignmentFolioNotifyTargetUser</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendReassignmentFolioNotifyTargetUser(IRequestContext requestContext,RC_34272dae45b4de5e1332f46c6e8700b9 inParami_TargetUserAUUser,string inParami_FolioListReassigned,string inParami_CreatedByUsername,string inParami_Motive,CancellationToken cancellationToken) {
lcvSendReassignmentFolioNotifyTargetUser localVars = new lcvSendReassignmentFolioNotifyTargetUser(inParami_TargetUserAUUser, inParami_FolioListReassigned, inParami_CreatedByUsername, inParami_Motive);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendReassignmentFolioNotifyTargetUser", "aa9f36b8-fa6a-4c8c-a886-b10e4a326077"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendReassignmentFolioNotifyTargetUser", "aa9f36b8-fa6a-4c8c-a886-b10e4a326077", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.inParami_TargetUserAUUser.ssENUser.ssId })),"",1,"Reasignaciones - Nueva reasignación",localVars.inParami_FolioListReassigned,cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.inParami_TargetUserAUUser.ssENUser.ssEmail,1,cancellationToken);

if(((localVars.resMatchRecipientEmails.outParamResult!=""))) {
using (AppHealthProvider.CreateSendEmailMetric("ReassignmentFolioNotifyTargetUser", "2d885fda-7506-4d5c-a98c-98459f6d0e56"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ReassignmentFolioNotifyTargetUser", "2d885fda-7506-4d5c-a98c-98459f6d0e56", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_ReassignmentFolioNotifyTargetUser>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , BuiltInFunction.GetAppName (), localVars.inParami_TargetUserAUUser.ssENUser.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.inParami_CreatedByUsername, localVars.inParami_FolioListReassigned, localVars.inParami_TargetUserAUUser.ssENUser.ssName, localVars.inParami_TargetUserAUUser.ssENUser.ssEmail, localVars.inParami_Motive, cancellationToken),
        To = localVars.resMatchRecipientEmails.outParamResult,
        From = "",
        Cc = "",
        Bcc = "",
        Subject = string.Empty,
        Headers = new List<string>(),
        Attachments = mappedAttachments,
        ExtraImagesToAppend = emailScreen.ImagesToEmbed()
    };

    await OutSystems.Application.Core.Email.EmailService.Instance.SendEmailAsync(message, sendEmailActivity, cancellationToken);
}
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

goto RETURN_STATEMENT;

} // Catch
finally {
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSendReassignmentFolioNotifyTargetUser {



}


}
