namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendDailyNotificationsEmail : VarsBag {
/// <summary>
/// Variable <code>l_UserIdList</code> that represents the Service Studio UserIdentifierList
///  <code>l_UserIdList</code> <p>Description: Email list for notification</p>
/// </summary>
public BasicTypeList<string> varLcl_UserIdList = new BasicTypeList<string>();

/// <summary>
/// Variable <code>l_EmailNotificationList</code> that represents the Service Studio
///  EmailNotificationList <code>l_EmailNotificationList</code> <p>Description: Email list fo
/// r notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotificationList = new RL_39507255c499d96d2e7021755eecd9e1();

public lcvSendDailyNotificationsEmail() {
}
}
/// <summary>
/// Action <code>SendDailyNotificationsEmail</code> that represents the Service Studio action
///  <code>SendDailyNotificationsEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendDailyNotificationsEmail(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvSendDailyNotificationsEmail localVars = new lcvSendDailyNotificationsEmail();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendDailyNotificationsEmail", "33df59ca-99e5-46b4-8e17-fa9d72ab36d7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendDailyNotificationsEmail", "33df59ca-99e5-46b4-8e17-fa9d72ab36d7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_SendNotifsEXP4]))))) {
using (AppHealthProvider.CreateSendEmailMetric("GlobalActivityEmailNotification3", "cdc91858-a9b6-4e8c-b13b-55d5b9a6758c"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("GlobalActivityEmailNotification3", "cdc91858-a9b6-4e8c-b13b-55d5b9a6758c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowa_Emails.a_Emails_GlobalActivityEmailNotification>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), cancellationToken),
        To = "andre.monteiro@osquay.com",
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

public static class FuncActionSendDailyNotificationsEmail {



}


}
