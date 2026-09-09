namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendSupplier2FA : VarsBag {
public string inParamApplicationName;
public string inParamCustomerEmail;
public string resServiceSetSupplierLoginCode_outParamCode = "";

public lcvSendSupplier2FA(string inParamApplicationName, string inParamCustomerEmail) {
this.inParamApplicationName = inParamApplicationName;
this.inParamCustomerEmail = inParamCustomerEmail;
}
}
/// <summary>
/// Action <code>SendSupplier2FA</code> that represents the Service Studio action
///  <code>SendSupplier2FA</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendSupplier2FA(IRequestContext requestContext,string inParamApplicationName,string inParamCustomerEmail,CancellationToken cancellationToken) {
lcvSendSupplier2FA localVars = new lcvSendSupplier2FA(inParamApplicationName, inParamCustomerEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendSupplier2FA", "ceeecfb8-3464-42fa-96b8-606acd054264"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendSupplier2FA", "ceeecfb8-3464-42fa-96b8-606acd054264", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ServiceSetSupplierLoginCode
localVars.resServiceSetSupplierLoginCode_outParamCode = await ServiceAPIs.ServiceAPIServiceSetSupplierLoginCode(requestContext,localVars.inParamCustomerEmail,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("Supplier2FA", "7bc4815f-c4c3-4850-b1fc-a8b45a836515"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("Supplier2FA", "7bc4815f-c4c3-4850-b1fc-a8b45a836515", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowa_Emails.a_Emails_Supplier2FA>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , localVars.inParamApplicationName, "", localVars.inParamCustomerEmail, localVars.resServiceSetSupplierLoginCode_outParamCode, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), cancellationToken),
        To = localVars.inParamCustomerEmail,
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

public static class FuncActionSendSupplier2FA {



}


}
