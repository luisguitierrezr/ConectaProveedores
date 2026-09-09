namespace ssConectaProveedores;

public partial class Actions {
public class lcvEventSendFolioIncorrectAssignment : VarsBag {
public long inParami_FolioId;
public string inParami_RejectMotive;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_c31de23e3d152f2b2321aea18f795545 resServiceApplicationRoles_GetLst_Wrapper_outParamRoleslList = new RL_c31de23e3d152f2b2321aea18f795545();
public int resServiceApplicationRoles_GetLst_Wrapper_outParamTotalRoles = 0;

public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioSAE_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioSAE_outParamCount = 0L;

public RL_c22ca0e0dff4c8c0d1575277d6d892be resServiceApplicationRoles_GetUsers_Wrapper_outParamUsersList = new RL_c22ca0e0dff4c8c0d1575277d6d892be();

public lcvEventSendFolioIncorrectAssignment(long inParami_FolioId, string inParami_RejectMotive) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_RejectMotive = inParami_RejectMotive;
}
}
/// <summary>
/// Action <code>EventSendFolioIncorrectAssignment</code> that represents the Service Studio action
///  <code>EventSendFolioIncorrectAssignment</code> <p> Description: </p>
/// </summary>
public static async Task ActionEventSendFolioIncorrectAssignment(IRequestContext requestContext,long inParami_FolioId,string inParami_RejectMotive,CancellationToken cancellationToken) {
lcvEventSendFolioIncorrectAssignment localVars = new lcvEventSendFolioIncorrectAssignment(inParami_FolioId, inParami_RejectMotive);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EventSendFolioIncorrectAssignment", "4a2908b7-b1fb-4f4d-a4d0-7f9b7ab4e597"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EventSendFolioIncorrectAssignment", "4a2908b7-b1fb-4f4d-a4d0-7f9b7ab4e597", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ServiceApplicationRoles_GetLst_Wrapper
(localVars.resServiceApplicationRoles_GetLst_Wrapper_outParamRoleslList,localVars.resServiceApplicationRoles_GetLst_Wrapper_outParamTotalRoles) = await ServiceAPIs.ServiceAPIServiceApplicationRoles_GetLst_Wrapper(requestContext,"","",((((string)AppUtils.SiteProperties[SitePropertiesModel.spODC_EnvironmentKey]))),"Almacen","",1,0,cancellationToken);

// Empty?
if((localVars.resServiceApplicationRoles_GetLst_Wrapper_outParamRoleslList.Empty)) {
// LogMessage
await ExtendedActions.LogMessage(requestContext,"Almacen role in the environment not found.","ServiceApplicationRoles_GetLst_Wrapper",cancellationToken);

} else {
// ServiceApplicationRoles_GetUsers_Wrapper
localVars.resServiceApplicationRoles_GetUsers_Wrapper_outParamUsersList = await ServiceAPIs.ServiceAPIServiceApplicationRoles_GetUsers_Wrapper(requestContext,localVars.resServiceApplicationRoles_GetLst_Wrapper_outParamRoleslList.CurrentRec.ssKey,0,0,cancellationToken);

// Empty?
if((localVars.resServiceApplicationRoles_GetUsers_Wrapper_outParamUsersList.Empty)) {
// LogMessage2
await ExtendedActions.LogMessage(requestContext,"No users with Almacen role in the environment found.","ServiceApplicationRoles_GetUsers_Wrapper",cancellationToken);

} else {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.resServiceApplicationRoles_GetUsers_Wrapper_outParamUsersList, new RL_39507255c499d96d2e7021755eecd9e1(), async (ST_3d98fcbf952bf72084dad4104cc8c43fStructure source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = BuiltInFunction.NullTextIdentifier ();
target.ssEmail = source.ssEmail;
target.ssName = source.ssName;
target.ssEmailTo = "";
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetFolioSAE
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioSAE_maxRecords = 1;
if (datasetGetFolioSAE_maxRecords < 1) datasetGetFolioSAE_maxRecords = 1;
int datasetGetFolioSAE_startIndex = 0;(localVars.queryResGetFolioSAE_outParamList,localVars.queryResGetFolioSAE_outParamCount) = await FuncActionEventSendFolioIncorrectAssignment.datasetGetFolioSAE(requestContext,datasetGetFolioSAE_maxRecords,datasetGetFolioSAE_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FolioIncorrectAssignment", "d4a998dd-e246-4baa-8e7e-27af5b692728"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FolioIncorrectAssignment", "d4a998dd-e246-4baa-8e7e-27af5b692728", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_FolioIncorrectAssignment>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetFolioSAE_outParamList.CurrentRec.ssENFolio.ssFolioNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.inParami_RejectMotive, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? ((((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail))) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))),
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
localVars.varLcl_EmailNotification.Advance();
}

} finally {
localVars.varLcl_EmailNotification.EndIteration();
}

}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionEventSendFolioIncorrectAssignment {

// Query Function "GetFolioSAE" Sbuj2xCgjEmKe_GciDu_oQ of Action "EventSendFolioIncorrectAssignment"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventSendFolioIncorrectAssignment.GetFolioSAE", "dba3bb49-a010-498c-8a7b-f19c883bbfa1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventSendFolioIncorrectAssignment.GetFolioSAE", "dba3bb49-a010-498c-8a7b-f19c883bbfa1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
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
selectBuilder.Append("/* /UserActions.twgpSvuxTU+k0H+berTllw/NodesNotShownInESpaceTree.Sbuj2xCgjEmKe_GciDu_oQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio13\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio13\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio13\".\"id\" = @qpfoId) AND (\"enfolio13\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio13\".\"id\" IS NULL)");
}
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventSendFolioIncorrectAssignment.GetFolioSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventSendFolioIncorrectAssignment.GetFolioSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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
