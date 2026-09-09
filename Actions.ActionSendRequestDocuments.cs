namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendRequestDocuments : VarsBag {
public string inParamDestination;
public string inParamApplicationName;
public string inParamDocuments;
public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public lcvSendRequestDocuments(string inParamDestination, string inParamApplicationName, string inParamDocuments) {
this.inParamDestination = inParamDestination;
this.inParamApplicationName = inParamApplicationName;
this.inParamDocuments = inParamDocuments;
}
}
/// <summary>
/// Action <code>SendRequestDocuments</code> that represents the Service Studio action
///  <code>SendRequestDocuments</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendRequestDocuments(IRequestContext requestContext,string inParamDestination,string inParamApplicationName,string inParamDocuments,CancellationToken cancellationToken) {
lcvSendRequestDocuments localVars = new lcvSendRequestDocuments(inParamDestination, inParamApplicationName, inParamDocuments);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendRequestDocuments", "6ace03d3-51aa-43e4-ad09-afe1c9b26906"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendRequestDocuments", "6ace03d3-51aa-43e4-ad09-afe1c9b26906", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.inParamDestination,1,cancellationToken);

if(((localVars.resMatchRecipientEmails.outParamResult!=""))) {
using (AppHealthProvider.CreateSendEmailMetric("RequestDocuments", "854957cf-28c5-4fab-8d5f-25d2a1754741"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("RequestDocuments", "854957cf-28c5-4fab-8d5f-25d2a1754741", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowa_Emails.a_Emails_RequestDocuments>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , localVars.inParamApplicationName, localVars.inParamDocuments, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), "", localVars.inParamDestination, cancellationToken),
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

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSendRequestDocuments {



}


}
