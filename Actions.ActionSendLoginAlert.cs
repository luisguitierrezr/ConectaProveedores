namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendLoginAlert : VarsBag {
public string inParamUsername;
public string inParamEnvironment;
public string resGetIP_outParamClientIP = "";
public string resGetIP_outParamAdditionalIP = "";

public lcvSendLoginAlert(string inParamUsername, string inParamEnvironment) {
this.inParamUsername = inParamUsername;
this.inParamEnvironment = inParamEnvironment;
}
}
/// <summary>
/// Action <code>SendLoginAlert</code> that represents the Service Studio action
///  <code>SendLoginAlert</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendLoginAlert(IRequestContext requestContext,string inParamUsername,string inParamEnvironment,CancellationToken cancellationToken) {
lcvSendLoginAlert localVars = new lcvSendLoginAlert(inParamUsername, inParamEnvironment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendLoginAlert", "795eb1a6-8c8e-4c1b-8092-78f715eb12b7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendLoginAlert", "795eb1a6-8c8e-4c1b-8092-78f715eb12b7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetIP
(localVars.resGetIP_outParamClientIP,localVars.resGetIP_outParamAdditionalIP) = await Actions.ActionGetIP(requestContext,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("LoginAlert", "8941e89d-48d7-4f1d-a3cc-f05bb21bd94d"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("LoginAlert", "8941e89d-48d7-4f1d-a3cc-f05bb21bd94d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowb_CyA_Emails.b_CyA_Emails_LoginAlert>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta proveedores", localVars.inParamEnvironment, localVars.inParamUsername, localVars.resGetIP_outParamClientIP, (localVars.inParamEnvironment=="PROD"), ((((string)AppUtils.SiteProperties[SitePropertiesModel.spLoginAlertEmailList]))), ((((string)AppUtils.SiteProperties[SitePropertiesModel.spLoginAlertEmailList]))), cancellationToken),
        To = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spLoginAlertEmailList]))),
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
} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSendLoginAlert {



}


}
