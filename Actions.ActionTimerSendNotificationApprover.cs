namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimerSendNotificationApprover : VarsBag {
public RL_31fac59bc456dc76c5f04eb2b106ef9e queryResGetUsersByRegionId_outParamList = new RL_31fac59bc456dc76c5f04eb2b106ef9e();
public long queryResGetUsersByRegionId_outParamCount = 0L;

public RL_404ae675a6afeae3589ddbd4650eae3a queryResGetCountByRoleIdAndRegionId_outParamList = new RL_404ae675a6afeae3589ddbd4650eae3a();
public long queryResGetCountByRoleIdAndRegionId_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public lcvTimerSendNotificationApprover() {
}
}
/// <summary>
/// Action <code>TimerSendNotificationApprover</code> that represents the Service Studio action
///  <code>TimerSendNotificationApprover</code> <p> Description: </p>
/// </summary>
public static async Task ActionTimerSendNotificationApprover(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimerSendNotificationApprover localVars = new lcvTimerSendNotificationApprover();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("TimerSendNotificationApprover", "b1d39e5f-a847-4666-a584-3c9b343ab573"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("TimerSendNotificationApprover", "b1d39e5f-a847-4666-a584-3c9b343ab573", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query QueryGetCountByRoleIdAndRegionId
cancellationToken.ThrowIfCancellationRequested();
int QueryGetCountByRoleIdAndRegionId_maxRecords = 0;
int QueryGetCountByRoleIdAndRegionId_startIndex = 0;(localVars.queryResGetCountByRoleIdAndRegionId_outParamList,localVars.queryResGetCountByRoleIdAndRegionId_outParamCount) = await FuncActionTimerSendNotificationApprover.QueryGetCountByRoleIdAndRegionId(requestContext,QueryGetCountByRoleIdAndRegionId_maxRecords,QueryGetCountByRoleIdAndRegionId_startIndex,IterationMultiplicity.Single,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId,cancellationToken);

// Foreach GetCountByRoleIdAndRegionId.List
localVars.queryResGetCountByRoleIdAndRegionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetCountByRoleIdAndRegionId_outParamList.Eof))) {
// Query QueryGetUsersByRegionId
cancellationToken.ThrowIfCancellationRequested();
int QueryGetUsersByRegionId_maxRecords = 0;
int QueryGetUsersByRegionId_startIndex = 0;(localVars.queryResGetUsersByRegionId_outParamList,localVars.queryResGetUsersByRegionId_outParamCount) = await FuncActionTimerSendNotificationApprover.QueryGetUsersByRegionId(requestContext,QueryGetUsersByRegionId_maxRecords,QueryGetUsersByRegionId_startIndex,IterationMultiplicity.Never,localVars.queryResGetCountByRoleIdAndRegionId_outParamList.CurrentRec.ssSTGetCountByRoleAndRegionId.ssRegionId,localVars.queryResGetCountByRoleIdAndRegionId_outParamList.CurrentRec.ssSTGetCountByRoleAndRegionId.ssApplicationRoleID,2,cancellationToken);

if((!((localVars.queryResGetUsersByRegionId_outParamList.CurrentRec.ssSTEmailsNotifString.ssValue=="")))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,new BasicTypeList<string>(),localVars.queryResGetUsersByRegionId_outParamList.CurrentRec.ssSTEmailsNotifString.ssUserIds,1,((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="DEV")) ? ("(DEV)") : ((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="QA")) ? ("(QA)") : (""))))+"Se le han asignado pagos del Proceso de “Comisiones y/o Arrendamientos”, para ser aprobadas."),(((("Se le han asignado"+" ")+Convert.ToString(localVars.queryResGetCountByRoleIdAndRegionId_outParamList.CurrentRec.ssSTGetCountByRoleAndRegionId.ssCount))+" ")+"líneas de propuesta para su aprobación."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.queryResGetUsersByRegionId_outParamList.CurrentRec.ssSTEmailsNotifString.ssValue,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ProposalLinesReminder", "d7dcfe1f-44d8-4502-a370-923f2523829f"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ProposalLinesReminder", "d7dcfe1f-44d8-4502-a370-923f2523829f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowb_CyA_Emails.b_CyA_Emails_ProposalLinesReminder>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , AppUtils.GetStringResource("g5XHRTevVEOKt_IzC4_00g#Value.824009785.1", "Conecta Proveedores"), Convert.ToString(localVars.queryResGetCountByRoleIdAndRegionId_outParamList.CurrentRec.ssSTGetCountByRoleAndRegionId.ssCount), ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetUsersByRegionId_outParamList.CurrentRec.ssSTEmailsNotifString.ssValue, "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.queryResGetUsersByRegionId_outParamList.CurrentRec.ssSTEmailsNotifString.ssValue)),
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

localVars.queryResGetCountByRoleIdAndRegionId_outParamList.Advance();
}

} finally {
localVars.queryResGetCountByRoleIdAndRegionId_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionTimerSendNotificationApprover {

// Query Function "GetUsersByRegionId" ymlLeJigf0SR8PQhWBUuyg of Action "TimerSendNotificationApprover"
public static async Task<(RL_31fac59bc456dc76c5f04eb2b106ef9e,long)> QueryGetUsersByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRegionId,long qpapApplicationRoleId,int qproRoleStatusIdActive,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("TimerSendNotificationApprover.GetUsersByRegionId", "784b69ca-a098-447f-91f0-f42158152eca");
using var queryActivity = activitySource.CreateSqlQueryActivity("TimerSendNotificationApprover.GetUsersByRegionId", "784b69ca-a098-447f-91f0-f42158152eca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityUserApplicationRole = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRole");
string entityUserApplicationRoleTemp = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRoleTemp");
sqlCmd.CreateParameter("@qproRoleStatusIdActive", DbType.Int32, qproRoleStatusIdActive);
sqlCmd.CreateParameter("@qpapApplicationRoleId", DbType.Int64, qpapApplicationRoleId);
sqlCmd.CreateParameter("@qpreRegionId", DbType.Int64, qpreRegionId);
string sql = "";
string advSql = "SELECT string_agg(DISTINCT u.Email, ',') AS Emails, string_agg(DISTINCT u.Id, ',') AS UserIds \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " u \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " uei \n  ON uei.Id = u.Id \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRole,"") + " uar \n  ON uar.UserId = u.Id \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRoleTemp,"") + " uart \n  ON uart.UserId = u.Id AND uart.RoleStatusId = @qproRoleStatusIdActive \nWHERE \n  COALESCE(uar.ApplicationRoleId, uart.ApplicationRoleId) = @qpapApplicationRoleId \n  AND uei.RegionId = @qpreRegionId;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_31fac59bc456dc76c5f04eb2b106ef9e outParamList = new RL_31fac59bc456dc76c5f04eb2b106ef9e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerSendNotificationApprover.GetUsersByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_31fac59bc456dc76c5f04eb2b106ef9e _tmp = new RL_31fac59bc456dc76c5f04eb2b106ef9e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerSendNotificationApprover.GetUsersByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_31fac59bc456dc76c5f04eb2b106ef9e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetUsersByRegionId in TimerSendNotificationApprover in ConectaProveedores (SELECT string_agg(DISTINCT u.Email, ',') AS Emails, string_agg(DISTINCT u.Id, ',') AS UserIds  FROM {User} u  LEFT JOIN {User_Extended_Internal} uei    ON uei.Id = u.Id  LEFT JOIN {UserApplicationRole} uar    ON uar.UserId = u.Id  LEFT JOIN {UserApplicationRoleTemp} uart    ON uart.UserId = u.Id AND uart.RoleStatusId = @RoleStatusIdActive  WHERE    COALESCE(uar.ApplicationRoleId, uart.ApplicationRoleId) = @ApplicationRoleId    AND uei.RegionId = @RegionId;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUsersByRegionId in TimerSendNotificationApprover in ConectaProveedores (SELECT string_agg(DISTINCT u.Email, ',') AS Emails, string_agg(DISTINCT u.Id, ',') AS UserIds  FROM {User} u  LEFT JOIN {User_Extended_Internal} uei    ON uei.Id = u.Id  LEFT JOIN {UserApplicationRole} uar    ON uar.UserId = u.Id  LEFT JOIN {UserApplicationRoleTemp} uart    ON uart.UserId = u.Id AND uart.RoleStatusId = @RoleStatusIdActive  WHERE    COALESCE(uar.ApplicationRoleId, uart.ApplicationRoleId) = @ApplicationRoleId    AND uei.RegionId = @RegionId;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUsersByRegionId in TimerSendNotificationApprover in ConectaProveedores (SELECT string_agg(DISTINCT u.Email, ',') AS Emails, string_agg(DISTINCT u.Id, ',') AS UserIds  FROM {User} u  LEFT JOIN {User_Extended_Internal} uei    ON uei.Id = u.Id  LEFT JOIN {UserApplicationRole} uar    ON uar.UserId = u.Id  LEFT JOIN {UserApplicationRoleTemp} uart    ON uart.UserId = u.Id AND uart.RoleStatusId = @RoleStatusIdActive  WHERE    COALESCE(uar.ApplicationRoleId, uart.ApplicationRoleId) = @ApplicationRoleId    AND uei.RegionId = @RegionId;): " + aqExcep.Message));
}
}
}

// Query Function "GetCountByRoleIdAndRegionId" a2nbw7jaTECmJaz0JuczyA of Action "TimerSendNotificationApprover"
public static async Task<(RL_404ae675a6afeae3589ddbd4650eae3a,long)> QueryGetCountByRoleIdAndRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpapApprovalStatusInApproval,int qpprProposalStatusCanceled,int qpprProposalStatusErrorAPI,int qpprProposalStatusRejected,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("TimerSendNotificationApprover.GetCountByRoleIdAndRegionId", "c3db696b-dab8-404c-a625-acf426e733c8");
using var queryActivity = activitySource.CreateSqlQueryActivity("TimerSendNotificationApprover.GetCountByRoleIdAndRegionId", "c3db696b-dab8-404c-a625-acf426e733c8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposalLineApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalLineApprovalLevel");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
sqlCmd.CreateParameter("@qpapApprovalStatusInApproval", DbType.Int32, qpapApprovalStatusInApproval);
sqlCmd.CreateParameter("@qpprProposalStatusCanceled", DbType.Int32, qpprProposalStatusCanceled);
sqlCmd.CreateParameter("@qpprProposalStatusErrorAPI", DbType.Int32, qpprProposalStatusErrorAPI);
sqlCmd.CreateParameter("@qpprProposalStatusRejected", DbType.Int32, qpprProposalStatusRejected);
string sql = "";
string advSql = "SELECT \n  COUNT( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"id\"") + ")                          AS LineApprovalLevelCount, \n   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"applicationroleid\"") + "                  AS ApplicationRoleId, \n   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + "                                            AS RegionId \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + "  \n    ON   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " = @qpapApprovalStatusInApproval \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusCanceled \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusErrorAPI \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusRejected \nGROUP BY \n   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"applicationroleid\"") + ", \n   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + ";";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_404ae675a6afeae3589ddbd4650eae3a outParamList = new RL_404ae675a6afeae3589ddbd4650eae3a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerSendNotificationApprover.GetCountByRoleIdAndRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_404ae675a6afeae3589ddbd4650eae3a _tmp = new RL_404ae675a6afeae3589ddbd4650eae3a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerSendNotificationApprover.GetCountByRoleIdAndRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_404ae675a6afeae3589ddbd4650eae3a)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetCountByRoleIdAndRegionId in TimerSendNotificationApprover in ConectaProveedores (SELECT    COUNT({ProposalLineApprovalLevel}.[Id])                          AS LineApprovalLevelCount,    {ProposalLineApprovalLevel}.[ApplicationRoleId]                  AS ApplicationRoleId,    {Proposal}.[RegionId]                                            AS RegionId  FROM {ProposalLineApprovalLevel}  LEFT JOIN {ProposalLine}       ON  {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  LEFT JOIN {Proposal}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  WHERE {ProposalLineApprovalLevel}.[ApprovalStatusId] = @ApprovalStatusInApproval      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusErrorAPI      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusRejected  GROUP BY    {ProposalLineApprovalLevel}.[ApplicationRoleId],    {Proposal}.[RegionId];): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetCountByRoleIdAndRegionId in TimerSendNotificationApprover in ConectaProveedores (SELECT    COUNT({ProposalLineApprovalLevel}.[Id])                          AS LineApprovalLevelCount,    {ProposalLineApprovalLevel}.[ApplicationRoleId]                  AS ApplicationRoleId,    {Proposal}.[RegionId]                                            AS RegionId  FROM {ProposalLineApprovalLevel}  LEFT JOIN {ProposalLine}       ON  {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  LEFT JOIN {Proposal}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  WHERE {ProposalLineApprovalLevel}.[ApprovalStatusId] = @ApprovalStatusInApproval      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusErrorAPI      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusRejected  GROUP BY    {ProposalLineApprovalLevel}.[ApplicationRoleId],    {Proposal}.[RegionId];): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetCountByRoleIdAndRegionId in TimerSendNotificationApprover in ConectaProveedores (SELECT    COUNT({ProposalLineApprovalLevel}.[Id])                          AS LineApprovalLevelCount,    {ProposalLineApprovalLevel}.[ApplicationRoleId]                  AS ApplicationRoleId,    {Proposal}.[RegionId]                                            AS RegionId  FROM {ProposalLineApprovalLevel}  LEFT JOIN {ProposalLine}       ON  {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  LEFT JOIN {Proposal}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  WHERE {ProposalLineApprovalLevel}.[ApprovalStatusId] = @ApprovalStatusInApproval      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusErrorAPI      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusRejected  GROUP BY    {ProposalLineApprovalLevel}.[ApplicationRoleId],    {Proposal}.[RegionId];): " + aqExcep.Message));
}
}
}



}


}
