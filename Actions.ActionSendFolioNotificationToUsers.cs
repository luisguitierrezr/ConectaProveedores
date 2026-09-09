namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendFolioNotificationToUsers : VarsBag {
public RLUserList inParamUsers;
public string inParamInvoiceNumber;
public string inParamFolioNumber;
public bool inParamIsInvoiceCancel;
public string inParamReason;
public bool inParamIsEntryCancel;
/// <summary>
/// Variable <code>TempUsers</code> that represents the Service Studio EmailRecordList
///  <code>TempUsers</code> <p>Description: </p>
/// </summary>
public RL_9e2b74ef9afd45546e5941a720a69c18 varLcTempUsers = new RL_9e2b74ef9afd45546e5941a720a69c18();

public ST_8509a484f6b6eac99c83feddd35d5004Structure resUsersWithEmailActive_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public string resString_Join_outParamText = "";

public lcvSendFolioNotificationToUsers(RLUserList inParamUsers, string inParamInvoiceNumber, string inParamFolioNumber, bool inParamIsInvoiceCancel, string inParamReason, bool inParamIsEntryCancel) {
this.inParamUsers = inParamUsers;
this.inParamInvoiceNumber = inParamInvoiceNumber;
this.inParamFolioNumber = inParamFolioNumber;
this.inParamIsInvoiceCancel = inParamIsInvoiceCancel;
this.inParamReason = inParamReason;
this.inParamIsEntryCancel = inParamIsEntryCancel;
}
}
/// <summary>
/// Action <code>SendFolioNotificationToUsers</code> that represents the Service Studio action
///  <code>SendFolioNotificationToUsers</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendFolioNotificationToUsers(IRequestContext requestContext,RLUserList inParamUsers,string inParamInvoiceNumber,string inParamFolioNumber,bool inParamIsInvoiceCancel,string inParamReason,bool inParamIsEntryCancel,CancellationToken cancellationToken) {
lcvSendFolioNotificationToUsers localVars = new lcvSendFolioNotificationToUsers(inParamUsers, inParamInvoiceNumber, inParamFolioNumber, inParamIsInvoiceCancel, inParamReason, inParamIsEntryCancel);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendFolioNotificationToUsers", "a8796e5e-499e-4cda-9909-1e443da9194b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendFolioNotificationToUsers", "a8796e5e-499e-4cda-9909-1e443da9194b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcTempUsers,(await RL_9e2b74ef9afd45546e5941a720a69c18.ConvertAsync(localVars.inParamUsers, new RL_9e2b74ef9afd45546e5941a720a69c18(), async (ENUserEntityRecord source, RC_d95f07a9b902c9473d3a2501fb475225 target, CancellationToken cancellationToken) => {
target.ssEmail = source.ssEmail;
return target;
}, cancellationToken)),cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcTempUsers, new RLTextRecordList(), async (RC_d95f07a9b902c9473d3a2501fb475225 source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssEmail;
return target;
}, cancellationToken)),",",cancellationToken);

// UsersWithEmailActive
localVars.resUsersWithEmailActive_outParamResponse = await ssConectaProveedores.CcNotifications.ActionUsersWithEmailActive(requestContext,new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure(){ ssliststring = localVars.resString_Join_outParamText, sscategoryclass = "cancellation" },cancellationToken);

// InAppNotification
await Actions.ActionInAppNotification(requestContext,new BasicTypeList<string>(),localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring,2,AppUtils.GetStringResource("iHtC+duhtEygl64i3RAtgg#Value.-803759100.1", "Folio Cancelation"),(((((("La entrada correspondiente al folio número "+localVars.inParamFolioNumber)+" ha sido cancelada.")+"\r\n")+(((localVars.inParamInvoiceNumber!="")) ? ((((("La factura número "+localVars.inParamInvoiceNumber)+" ha sido ")+((localVars.inParamIsInvoiceCancel) ? ("cancelada") : ("rechazada")))+".")) : ("")))+"\r\n")+(((localVars.inParamFolioNumber!="")) ? ((("El folio número SAEC"+localVars.inParamFolioNumber)+" ha sido cancelado.")) : (""))),cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("PreApprovalCanceledFolio", "42c14894-f9ee-4b40-8204-e7cf77480c67"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("PreApprovalCanceledFolio", "42c14894-f9ee-4b40-8204-e7cf77480c67", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_PreApprovalCanceledFolio>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , AppUtils.GetStringResource("x+0uRkF5TkmeAjyNeLQPYg#Value.-803759100.1", "Folio Cancelation"), localVars.inParamInvoiceNumber, localVars.inParamFolioNumber, localVars.inParamIsInvoiceCancel, "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.inParamReason, localVars.inParamIsEntryCancel, cancellationToken),
        To = localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring,
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

public static class FuncActionSendFolioNotificationToUsers {



}


}
