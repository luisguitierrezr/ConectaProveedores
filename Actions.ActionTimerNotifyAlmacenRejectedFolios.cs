namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimerNotifyAlmacenRejectedFolios : VarsBag {
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_c31de23e3d152f2b2321aea18f795545 resServiceApplicationRoles_GetLst_Wrapper_outParamRoleslList = new RL_c31de23e3d152f2b2321aea18f795545();
public int resServiceApplicationRoles_GetLst_Wrapper_outParamTotalRoles = 0;

public RL_c22ca0e0dff4c8c0d1575277d6d892be resServiceApplicationRoles_GetUsers_Wrapper_outParamUsersList = new RL_c22ca0e0dff4c8c0d1575277d6d892be();

public RL_11e68f59508e412eaf5b78801dd06b0e queryResGetFoliosSAE_outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
public long queryResGetFoliosSAE_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public lcvTimerNotifyAlmacenRejectedFolios() {
}
}
/// <summary>
/// Action <code>TimerNotifyAlmacenRejectedFolios</code> that represents the Service Studio action
///  <code>TimerNotifyAlmacenRejectedFolios</code> <p> Description: </p>
/// </summary>
public static async Task ActionTimerNotifyAlmacenRejectedFolios(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimerNotifyAlmacenRejectedFolios localVars = new lcvTimerNotifyAlmacenRejectedFolios();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("TimerNotifyAlmacenRejectedFolios", "5992b96b-8855-4430-b7a2-81aeeb0971ad"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("TimerNotifyAlmacenRejectedFolios", "5992b96b-8855-4430-b7a2-81aeeb0971ad", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13045]))))) {
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

// Query datasetGetFoliosSAE
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosSAE_maxRecords = 1;
if (datasetGetFoliosSAE_maxRecords < 1) datasetGetFoliosSAE_maxRecords = 1;
int datasetGetFoliosSAE_startIndex = 0;(localVars.queryResGetFoliosSAE_outParamList,localVars.queryResGetFoliosSAE_outParamCount) = await FuncActionTimerNotifyAlmacenRejectedFolios.datasetGetFoliosSAE(requestContext,datasetGetFoliosSAE_maxRecords,datasetGetFoliosSAE_startIndex,IterationMultiplicity.Never,cancellationToken);

if(((localVars.queryResGetFoliosSAE_outParamList.CurrentRec.ssCount>Convert.ToInt64(0)))) {
// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ReassignRejectedFolios", "46abdd5d-87af-42ec-ac56-c06333fab860"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ReassignRejectedFolios", "46abdd5d-87af-42ec-ac56-c06333fab860", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_ReassignRejectedFolios>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.queryResGetFoliosSAE_outParamList.CurrentRec.ssCount, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionTimerNotifyAlmacenRejectedFolios {

// Query Function "GetFoliosSAE" sGEY4u9LYE6Y4iwW0Et2NA of Action "TimerNotifyAlmacenRejectedFolios"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerNotifyAlmacenRejectedFolios.GetFoliosSAE", "e21861b0-4bef-4e60-98e2-2c16d04b7634");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerNotifyAlmacenRejectedFolios.GetFoliosSAE", "e21861b0-4bef-4e60-98e2-2c16d04b7634", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.a7mSWVWIMES3ooGu6wlxrQ/NodesNotShownInESpaceTree.sGEY4u9LYE6Y4iwW0Et2NA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enfolio15\".\"id\") \"count\"");
fromBuilder.Append(" FROM (({Folio} \"enfolio15\" Inner JOIN {FolioApproval} \"enfolioapproval9\" ON (\"enfolio15\".\"id\" = \"enfolioapproval9\".\"folioid\"))  Inner JOIN {FolioApprovalLevel} \"enfolioapprovallevel8\" ON ((\"enfolioapproval9\".\"id\" = \"enfolioapprovallevel8\".\"folioapprovalid\") AND (\"enfolioapprovallevel8\".\"rejectreason\" <> ''))) ");
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
RL_11e68f59508e412eaf5b78801dd06b0e outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerNotifyAlmacenRejectedFolios.GetFoliosSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_11e68f59508e412eaf5b78801dd06b0e _tmp = new RL_11e68f59508e412eaf5b78801dd06b0e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerNotifyAlmacenRejectedFolios.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_11e68f59508e412eaf5b78801dd06b0e)_tmp;
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
