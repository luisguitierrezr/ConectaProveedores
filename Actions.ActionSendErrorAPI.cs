namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendErrorAPI : VarsBag {
public string inParami_FileName;
public RL_21421685308149cb9c93dd790730a8ac inParami_ErrorList;
/// <summary>
/// Variable <code>l_EmailNotificationToText</code> that represents the Service Studio Text
///  <code>l_EmailNotificationToText</code> <p>Description: Email list for notification CC</p>
/// </summary>
public string varLcl_EmailNotificationToText = "";

/// <summary>
/// Variable <code>Users</code> that represents the Service Studio TextList <code>Users</code>
///  <p>Description: </p>
/// </summary>
public BasicTypeList<string> varLcUsers = new BasicTypeList<string>();

public RL_e636b7622ac541c8d20e097062759f2f queryResGetUserExtendedInternals_outParamList = new RL_e636b7622ac541c8d20e097062759f2f();
public long queryResGetUserExtendedInternals_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public lcvSendErrorAPI(string inParami_FileName, RL_21421685308149cb9c93dd790730a8ac inParami_ErrorList) {
this.inParami_FileName = inParami_FileName;
this.inParami_ErrorList = inParami_ErrorList;
}
}
/// <summary>
/// Action <code>SendErrorAPI</code> that represents the Service Studio action
///  <code>SendErrorAPI</code> <p> Description: Wrapper to send Email when file gives error in API</p>
/// </summary>
public static async Task ActionSendErrorAPI(IRequestContext requestContext,string inParami_FileName,RL_21421685308149cb9c93dd790730a8ac inParami_ErrorList,CancellationToken cancellationToken) {
lcvSendErrorAPI localVars = new lcvSendErrorAPI(inParami_FileName, inParami_ErrorList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendErrorAPI", "dccd9d41-9865-48a6-8442-6e633e36da1a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendErrorAPI", "dccd9d41-9865-48a6-8442-6e633e36da1a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternals
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternals_maxRecords = 0;
int datasetGetUserExtendedInternals_startIndex = 0;(localVars.queryResGetUserExtendedInternals_outParamList,localVars.queryResGetUserExtendedInternals_outParamCount) = await FuncActionSendErrorAPI.datasetGetUserExtendedInternals(requestContext,datasetGetUserExtendedInternals_maxRecords,datasetGetUserExtendedInternals_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetUserExtendedInternals.List
localVars.queryResGetUserExtendedInternals_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserExtendedInternals_outParamList.Eof))) {
// l_EmailNotificationToText = l_EmailNotificationToText + If + If
localVars.varLcl_EmailNotificationToText=((localVars.varLcl_EmailNotificationToText+(((localVars.varLcl_EmailNotificationToText=="")) ? ("") : (",")))+(((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUser.ssEmail) : ((((localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUser.ssEmail)))));
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcUsers,localVars.queryResGetUserExtendedInternals_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

localVars.queryResGetUserExtendedInternals_outParamList.Advance();
}

} finally {
localVars.queryResGetUserExtendedInternals_outParamList.EndIteration();
}

// InAppNotification
await Actions.ActionInAppNotification(requestContext,localVars.varLcUsers,"",2,((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="DEV")) ? ("(DEV)") : ((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="QA")) ? ("(QA)") : (""))))+"Comissiones Y Arrendamientos - ERROR API"),"Ocurrió un error durante la importación automática del archivo, por lo que será necesario realizar la importación de forma manual.",cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotificationToText,2,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ErrorAPI2", "1cd16dfe-2fb6-4b39-afb4-f97426e13f55"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ErrorAPI2", "1cd16dfe-2fb6-4b39-afb4-f97426e13f55", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowb_CyA_Emails.b_CyA_Emails_ErrorAPI>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.inParami_FileName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.varLcl_EmailNotificationToText, "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), localVars.inParami_ErrorList, cancellationToken),
        To = (((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.varLcl_EmailNotificationToText)),
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

// RaiseError SendingEmail
throw new Ex_SendingEmailUserException ("Error al enviar la notificación.");

} // Catch
finally {
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSendErrorAPI {

private static async Task<RC_9f188ad01e9c8bcb23bbc90643260885> datasetGetUserExtendedInternalsReadDbAsync(RC_9f188ad01e9c8bcb23bbc90643260885 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternals" 1i4ynUiyCkeUBtdmayKcug of Action "SendErrorAPI"
public static async Task<(RL_e636b7622ac541c8d20e097062759f2f,long)> datasetGetUserExtendedInternals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendErrorAPI.GetUserExtendedInternals", "9d322ed6-b248-470a-9406-d7666b229cba");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendErrorAPI.GetUserExtendedInternals", "9d322ed6-b248-470a-9406-d7666b229cba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.QZ3N3GWYpkiEQm5jPjbaGg/NodesNotShownInESpaceTree.1i4ynUiyCkeUBtdmayKcug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser122\".\"id\" o7, NULL o8, \"enuser122\".\"email\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"enuserextension55\".\"emailto\" o44");
fromBuilder.Append(" FROM (((({User_Extended_Internal} \"enuser_extended_internal72\" Inner JOIN {User} \"enuser122\" ON (\"enuser_extended_internal72\".\"id\" = \"enuser122\".\"id\"))  Left JOIN {UserApplicationRole} \"enuserapplicationrole16\" ON (\"enuser122\".\"id\" = \"enuserapplicationrole16\".\"userid\"))  Inner JOIN {ApplicationRole} \"enapplicationrole34\" ON (\"enuserapplicationrole16\".\"applicationroleid\" = \"enapplicationrole34\".\"id\"))  Left JOIN {UserExtension} \"enuserextension55\" ON (\"enuser122\".\"id\" = \"enuserextension55\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enapplicationrole34\".\"code\" = 'ADMIN_AREA_CENTRALIZACION')");
orderByBuilder.Append(" ORDER BY \"enuser122\".\"name\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_e636b7622ac541c8d20e097062759f2f outParamList = new RL_e636b7622ac541c8d20e097062759f2f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendErrorAPI.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e636b7622ac541c8d20e097062759f2f _tmp = new RL_e636b7622ac541c8d20e097062759f2f();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendErrorAPI.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e636b7622ac541c8d20e097062759f2f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
