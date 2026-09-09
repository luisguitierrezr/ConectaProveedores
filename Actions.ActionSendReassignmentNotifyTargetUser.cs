namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendReassignmentNotifyTargetUser : VarsBag {
public RC_34272dae45b4de5e1332f46c6e8700b9 inParaml_TargetUserAUUser;
public string inParaml_ReqInvListReassigned;
public string inParami_CreatedByUsername;
public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public lcvSendReassignmentNotifyTargetUser(RC_34272dae45b4de5e1332f46c6e8700b9 inParaml_TargetUserAUUser, string inParaml_ReqInvListReassigned, string inParami_CreatedByUsername) {
this.inParaml_TargetUserAUUser = inParaml_TargetUserAUUser;
this.inParaml_ReqInvListReassigned = inParaml_ReqInvListReassigned;
this.inParami_CreatedByUsername = inParami_CreatedByUsername;
}
}
/// <summary>
/// Action <code>SendReassignmentNotifyTargetUser</code> that represents the Service Studio action
///  <code>SendReassignmentNotifyTargetUser</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendReassignmentNotifyTargetUser(IRequestContext requestContext,RC_34272dae45b4de5e1332f46c6e8700b9 inParaml_TargetUserAUUser,string inParaml_ReqInvListReassigned,string inParami_CreatedByUsername,CancellationToken cancellationToken) {
lcvSendReassignmentNotifyTargetUser localVars = new lcvSendReassignmentNotifyTargetUser(inParaml_TargetUserAUUser, inParaml_ReqInvListReassigned, inParami_CreatedByUsername);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendReassignmentNotifyTargetUser", "875b0412-a51e-4781-95d4-8f2fc810bf08"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendReassignmentNotifyTargetUser", "875b0412-a51e-4781-95d4-8f2fc810bf08", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.inParaml_TargetUserAUUser.ssENUser.ssId })),"",1,"Reasignaciones - Nueva reasignación",localVars.inParaml_ReqInvListReassigned,cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.inParaml_TargetUserAUUser.ssENUser.ssEmail,1,cancellationToken);

if(((localVars.resMatchRecipientEmails.outParamResult!=""))) {
using (AppHealthProvider.CreateSendEmailMetric("ReassignmentNotifyTargetUser", "987577dd-fca6-4052-a1a3-3f6a1f537eb9"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ReassignmentNotifyTargetUser", "987577dd-fca6-4052-a1a3-3f6a1f537eb9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowa_Emails.a_Emails_ReassignmentNotifyTargetUser>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , BuiltInFunction.GetAppName (), localVars.inParaml_TargetUserAUUser.ssENUser.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.inParami_CreatedByUsername, localVars.inParaml_ReqInvListReassigned, localVars.inParaml_TargetUserAUUser.ssENUser.ssName, localVars.inParaml_TargetUserAUUser.ssENUser.ssEmail, cancellationToken),
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

public static class FuncActionSendReassignmentNotifyTargetUser {



}


}
