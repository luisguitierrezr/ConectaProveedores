namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimerSendNotificationTreasury : VarsBag {
public RL_4fa77389273008bca2f5b798260e9dfd queryResGetUsers_outParamList = new RL_4fa77389273008bca2f5b798260e9dfd();
public long queryResGetUsers_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_5c521606738167349ee06b331bd15dfd queryResGetCount_outParamList = new RL_5c521606738167349ee06b331bd15dfd();
public long queryResGetCount_outParamCount = 0L;

public lcvTimerSendNotificationTreasury() {
}
}
/// <summary>
/// Action <code>TimerSendNotificationTreasury</code> that represents the Service Studio action
///  <code>TimerSendNotificationTreasury</code> <p> Description: </p>
/// </summary>
public static async Task ActionTimerSendNotificationTreasury(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimerSendNotificationTreasury localVars = new lcvTimerSendNotificationTreasury();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("TimerSendNotificationTreasury", "337a8abf-4df7-4cf8-9314-46b11b90755b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("TimerSendNotificationTreasury", "337a8abf-4df7-4cf8-9314-46b11b90755b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetUsers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsers_maxRecords = 0;
int datasetGetUsers_startIndex = 0;(localVars.queryResGetUsers_outParamList,localVars.queryResGetUsers_outParamCount) = await FuncActionTimerSendNotificationTreasury.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetUsers.List
localVars.queryResGetUsers_outParamList.StartIteration();
try {while (!((localVars.queryResGetUsers_outParamList.Eof))) {
// Query QueryGetCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetCount_maxRecords = 0;
int QueryGetCount_startIndex = 0;(localVars.queryResGetCount_outParamList,localVars.queryResGetCount_outParamCount) = await FuncActionTimerSendNotificationTreasury.QueryGetCount(requestContext,QueryGetCount_maxRecords,QueryGetCount_startIndex,IterationMultiplicity.Never,localVars.queryResGetUsers_outParamList.CurrentRec.ssENUser.ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId,cancellationToken);

if((!(((localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssApprovedCount==0)&&(localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssBeingPaidCount==0))))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.queryResGetUsers_outParamList.CurrentRec.ssENUser.ssId })),"",1,((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="DEV")) ? ("(DEV)") : ((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="QA")) ? ("(QA)") : (""))))+"Se le han asignado pagos del Proceso de “Comisiones y/o Arrendamientos”, para ser pagas."),((((localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssBeingPaidCount!=0)&&(localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssApprovedCount!=0))) ? ((((((((((("Tienes"+" ")+Convert.ToString(localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssBeingPaidCount))+" ")+"propuestas que actualmente se están pagando")+" ")+"y")+" ")+Convert.ToString(localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssApprovedCount))+" ")+"propuestas actualmente aprobadas que requieren su atención.")) : ((((localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssBeingPaidCount!=0)) ? ((((("Tienes"+" ")+Convert.ToString(localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssBeingPaidCount))+" ")+"propuestas que actualmente se están pagando y requieren su atención.")) : ((((localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssApprovedCount!=0)) ? ((((("Tienes"+" ")+Convert.ToString(localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssApprovedCount))+" ")+"propuestas actualmente aprobadas que requieren su atención.")) : ("")))))),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.queryResGetUsers_outParamList.CurrentRec.ssENUser.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("TreasuryReminder", "1cf36ced-1639-48ac-94fb-9b3fc39564aa"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("TreasuryReminder", "1cf36ced-1639-48ac-94fb-9b3fc39564aa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowb_CyA_Emails.b_CyA_Emails_TreasuryReminder>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , AppUtils.GetStringResource("3_VAPw_P9U6rJ116MoVv5w#Value.824009785.1", "Conecta Proveedores"), Convert.ToString(localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssApprovedCount), ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssBeingPaidCount, localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssApprovedNames, localVars.queryResGetCount_outParamList.CurrentRec.ssSTEmailNotifTesoraria.ssBeingPaidNames, localVars.queryResGetUsers_outParamList.CurrentRec.ssENUser.ssName, localVars.queryResGetUsers_outParamList.CurrentRec.ssENUser.ssEmail, "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.queryResGetUsers_outParamList.CurrentRec.ssENUser.ssEmail)),
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

localVars.queryResGetUsers_outParamList.Advance();
}

} finally {
localVars.queryResGetUsers_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionTimerSendNotificationTreasury {

private static async Task<RC_79713d00f72f3f42333169ab2740c159> datasetGetUsersReadDbAsync(RC_79713d00f72f3f42333169ab2740c159 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetUsers" DXmmMxYBkkeblg7O0x+qkQ of Action "TimerSendNotificationTreasury"
public static async Task<(RL_4fa77389273008bca2f5b798260e9dfd,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerSendNotificationTreasury.GetUsers", "33a6790d-0116-4792-9b96-0eced31faa91");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerSendNotificationTreasury.GetUsers", "33a6790d-0116-4792-9b96-0eced31faa91", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.v4p6M_dN+EyTFEaxG5B1Ww/NodesNotShownInESpaceTree.DXmmMxYBkkeblg7O0x+qkQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser33\".\"id\" o7, \"enuser33\".\"name\" o8, \"enuser33\".\"email\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21");
fromBuilder.Append(" FROM (({User} \"enuser33\" Left JOIN {UserApplicationRole} \"enuserapplicationrole6\" ON (\"enuser33\".\"id\" = \"enuserapplicationrole6\".\"userid\"))  Left JOIN {ApplicationRole} \"enapplicationrole5\" ON (\"enuserapplicationrole6\".\"applicationroleid\" = \"enapplicationrole5\".\"id\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper(\"enapplicationrole5\".\"name\")) collate \"default\") like caseaccent_normalize('TESORERIA' collate \"default\")) AND (\"enuserapplicationrole6\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")");
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
RL_4fa77389273008bca2f5b798260e9dfd outParamList = new RL_4fa77389273008bca2f5b798260e9dfd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerSendNotificationTreasury.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4fa77389273008bca2f5b798260e9dfd _tmp = new RL_4fa77389273008bca2f5b798260e9dfd();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerSendNotificationTreasury.GetUsers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4fa77389273008bca2f5b798260e9dfd)_tmp;
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

// Query Function "GetCount" 5M4o968Q2UWoISHrjmxMxw of Action "TimerSendNotificationTreasury"
public static async Task<(RL_5c521606738167349ee06b331bd15dfd,long)> QueryGetCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,int qpprProposalStatusApproved,int qpprProposalStatusBeingPaid,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("TimerSendNotificationTreasury.GetCount", "f728cee4-10af-45d9-a821-21eb8e6c4cc7");
using var queryActivity = activitySource.CreateSqlQueryActivity("TimerSendNotificationTreasury.GetCount", "f728cee4-10af-45d9-a821-21eb8e6c4cc7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
sqlCmd.CreateParameter("@qpprProposalStatusApproved", DbType.Int32, qpprProposalStatusApproved);
sqlCmd.CreateParameter("@qpusUserId", DbType.String, qpusUserId);
sqlCmd.CreateParameter("@qpprProposalStatusBeingPaid", DbType.Int32, qpprProposalStatusBeingPaid);
string sql = "";
string advSql = "SELECT \n  COUNT(*) FILTER ( \n    WHERE p.ProposalStatusId = @qpprProposalStatusApproved \n      AND (p.AssignedToId IS NULL OR p.AssignedToId = @qpusUserId) \n  ) AS ApprovedCount, \n \n  STRING_AGG(p.Name, ', ') FILTER ( \n    WHERE p.ProposalStatusId = @qpprProposalStatusApproved \n      AND (p.AssignedToId IS NULL OR p.AssignedToId = @qpusUserId) \n  ) AS ApprovedNames, \n \n  COUNT(*) FILTER ( \n    WHERE p.ProposalStatusId = @qpprProposalStatusBeingPaid \n      AND p.AssignedToId = @qpusUserId \n  ) AS BeingPaidCount, \n \n  STRING_AGG(p.Name, ', ') FILTER ( \n    WHERE p.ProposalStatusId = @qpprProposalStatusBeingPaid \n      AND p.AssignedToId = @qpusUserId \n  ) AS BeingPaidNames \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_5c521606738167349ee06b331bd15dfd outParamList = new RL_5c521606738167349ee06b331bd15dfd();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerSendNotificationTreasury.GetCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c521606738167349ee06b331bd15dfd _tmp = new RL_5c521606738167349ee06b331bd15dfd();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerSendNotificationTreasury.GetCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c521606738167349ee06b331bd15dfd)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetCount in TimerSendNotificationTreasury in ConectaProveedores (SELECT    COUNT(*) FILTER (      WHERE p.ProposalStatusId = @ProposalStatusApproved        AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)    ) AS ApprovedCount,      STRING_AGG(p.Name, ', ') FILTER (      WHERE p.ProposalStatusId = @ProposalStatusApproved        AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)    ) AS ApprovedNames,      COUNT(*) FILTER (      WHERE p.ProposalStatusId = @ProposalStatusBeingPaid        AND p.AssignedToId = @UserId    ) AS BeingPaidCount,      STRING_AGG(p.Name, ', ') FILTER (      WHERE p.ProposalStatusId = @ProposalStatusBeingPaid        AND p.AssignedToId = @UserId    ) AS BeingPaidNames  FROM {Proposal} p;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetCount in TimerSendNotificationTreasury in ConectaProveedores (SELECT    COUNT(*) FILTER (      WHERE p.ProposalStatusId = @ProposalStatusApproved        AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)    ) AS ApprovedCount,      STRING_AGG(p.Name, ', ') FILTER (      WHERE p.ProposalStatusId = @ProposalStatusApproved        AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)    ) AS ApprovedNames,      COUNT(*) FILTER (      WHERE p.ProposalStatusId = @ProposalStatusBeingPaid        AND p.AssignedToId = @UserId    ) AS BeingPaidCount,      STRING_AGG(p.Name, ', ') FILTER (      WHERE p.ProposalStatusId = @ProposalStatusBeingPaid        AND p.AssignedToId = @UserId    ) AS BeingPaidNames  FROM {Proposal} p;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetCount in TimerSendNotificationTreasury in ConectaProveedores (SELECT    COUNT(*) FILTER (      WHERE p.ProposalStatusId = @ProposalStatusApproved        AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)    ) AS ApprovedCount,      STRING_AGG(p.Name, ', ') FILTER (      WHERE p.ProposalStatusId = @ProposalStatusApproved        AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)    ) AS ApprovedNames,      COUNT(*) FILTER (      WHERE p.ProposalStatusId = @ProposalStatusBeingPaid        AND p.AssignedToId = @UserId    ) AS BeingPaidCount,      STRING_AGG(p.Name, ', ') FILTER (      WHERE p.ProposalStatusId = @ProposalStatusBeingPaid        AND p.AssignedToId = @UserId    ) AS BeingPaidNames  FROM {Proposal} p;): " + aqExcep.Message));
}
}
}



}


}
