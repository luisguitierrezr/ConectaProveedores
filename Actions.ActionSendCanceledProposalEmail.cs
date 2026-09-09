namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendCanceledProposalEmail : VarsBag {
public long inParami_ProposaId;
public string inParami_CanceledReason;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

/// <summary>
/// Variable <code>l_EmailNotificationCCText</code> that represents the Service Studio Text
///  <code>l_EmailNotificationCCText</code> <p>Description: Email list for notification CC</p>
/// </summary>
public string varLcl_EmailNotificationCCText = "";

/// <summary>
/// Variable <code>l_EmailNotificationToText</code> that represents the Service Studio Text
///  <code>l_EmailNotificationToText</code> <p>Description: Email list for notification CC</p>
/// </summary>
public string varLcl_EmailNotificationToText = "";

/// <summary>
/// Variable <code>UsersToNotify</code> that represents the Service Studio TextList
///  <code>UsersToNotify</code> <p>Description: </p>
/// </summary>
public BasicTypeList<string> varLcUsersToNotify = new BasicTypeList<string>();

public RL_82f8f815f9fb0b6e192e24e072fb8ae2 queryResGetUserExtendedInternalsByRegionId_outParamList = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
public long queryResGetUserExtendedInternalsByRegionId_outParamCount = 0L;

public RL_5d12cbdbc739013acbdd9f1aee86f8c2 queryResGetUsersByApplicationRole_outParamList = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
public long queryResGetUsersByApplicationRole_outParamCount = 0L;

public RL_9f9acf7f8fbbfb480a215bc421efa609 queryResGetProposalById_outParamList = new RL_9f9acf7f8fbbfb480a215bc421efa609();
public long queryResGetProposalById_outParamCount = 0L;

public ST_8509a484f6b6eac99c83feddd35d5004Structure resNewNotification_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public ST_8509a484f6b6eac99c83feddd35d5004Structure resUsersWithEmailActive_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public lcvSendCanceledProposalEmail(long inParami_ProposaId, string inParami_CanceledReason) {
this.inParami_ProposaId = inParami_ProposaId;
this.inParami_CanceledReason = inParami_CanceledReason;
}
}
/// <summary>
/// Action <code>SendCanceledProposalEmail</code> that represents the Service Studio action
///  <code>SendCanceledProposalEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendCanceledProposalEmail(IRequestContext requestContext,long inParami_ProposaId,string inParami_CanceledReason,CancellationToken cancellationToken) {
lcvSendCanceledProposalEmail localVars = new lcvSendCanceledProposalEmail(inParami_ProposaId, inParami_CanceledReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendCanceledProposalEmail", "2d6d5bd9-1903-4407-812c-076bcc2ec297"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendCanceledProposalEmail", "2d6d5bd9-1903-4407-812c-076bcc2ec297", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcl_EmailNotification,cancellationToken);

// Query datasetGetProposalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalById_maxRecords = 0;
int datasetGetProposalById_startIndex = 0;(localVars.queryResGetProposalById_outParamList,localVars.queryResGetProposalById_outParamCount) = await FuncActionSendCanceledProposalEmail.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Single,localVars.inParami_ProposaId,cancellationToken);

// Foreach GetProposalById.List
localVars.queryResGetProposalById_outParamList.StartIteration();
try {while (!((localVars.queryResGetProposalById_outParamList.Eof))) {
// Query datasetGetUserExtendedInternalsByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalsByRegionId_maxRecords = 0;
int datasetGetUserExtendedInternalsByRegionId_startIndex = 0;(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList,localVars.queryResGetUserExtendedInternalsByRegionId_outParamCount) = await FuncActionSendCanceledProposalEmail.datasetGetUserExtendedInternalsByRegionId(requestContext,datasetGetUserExtendedInternalsByRegionId_maxRecords,datasetGetUserExtendedInternalsByRegionId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssRegionId,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssApplicationRoleId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_7655e3fb0214830e441b4ca25cd396cb source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUserApplicationRole.ssUserId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetProposalById_outParamList.Advance();
}

} finally {
localVars.queryResGetProposalById_outParamList.EndIteration();
}

// Query datasetGetUsersByApplicationRole
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersByApplicationRole_maxRecords = 0;
int datasetGetUsersByApplicationRole_startIndex = 0;(localVars.queryResGetUsersByApplicationRole_outParamList,localVars.queryResGetUsersByApplicationRole_outParamCount) = await FuncActionSendCanceledProposalEmail.datasetGetUsersByApplicationRole(requestContext,datasetGetUsersByApplicationRole_maxRecords,datasetGetUsersByApplicationRole_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Foreach GetUsersByApplicationRole.List
localVars.queryResGetUsersByApplicationRole_outParamList.StartIteration();
try {while (!((localVars.queryResGetUsersByApplicationRole_outParamList.Eof))) {
// l_EmailNotificationCCText = l_EmailNotificationCCText + If + GetUsersByApplicationRole.List.Current.User.Email
localVars.varLcl_EmailNotificationCCText=((localVars.varLcl_EmailNotificationCCText+(((localVars.varLcl_EmailNotificationCCText=="")) ? ("") : (",")))+localVars.queryResGetUsersByApplicationRole_outParamList.CurrentRec.ssENUser.ssEmail);
localVars.queryResGetUsersByApplicationRole_outParamList.Advance();
}

} finally {
localVars.queryResGetUsersByApplicationRole_outParamList.EndIteration();
}

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// l_EmailNotificationToText = l_EmailNotificationToText + If + If
localVars.varLcl_EmailNotificationToText=((localVars.varLcl_EmailNotificationToText+(((localVars.varLcl_EmailNotificationToText=="")) ? ("") : (",")))+(((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))));
localVars.varLcl_EmailNotification.Advance();
}

} finally {
localVars.varLcl_EmailNotification.EndIteration();
}

// UsersWithEmailActive
localVars.resUsersWithEmailActive_outParamResponse = await ssConectaProveedores.CcNotifications.ActionUsersWithEmailActive(requestContext,new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure(){ ssliststring = localVars.varLcl_EmailNotificationToText, sscategoryclass = "cancellation" },cancellationToken);

// LogMessage
await ExtendedActions.LogMessage(requestContext,(((((("CANCEL PROPOSAL"+":")+"Original recipients: ")+localVars.varLcl_EmailNotificationToText)+"\r\n")+"Final:")+localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring),"Cancel proposal emails",cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("CanceledProposal2", "6eaebab7-379a-4f38-88e3-7b5e95dc793b"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("CanceledProposal2", "6eaebab7-379a-4f38-88e3-7b5e95dc793b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowb_CyA_Emails.b_CyA_Emails_CanceledProposal>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName, "", localVars.inParami_CanceledReason, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.varLcl_EmailNotificationToText, localVars.varLcl_EmailNotificationCCText, (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = ((localVars.resUsersWithEmailActive_outParamResponse.sssuccess) ? (localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring) : (localVars.varLcl_EmailNotificationToText)),
        From = "",
        Cc = localVars.varLcl_EmailNotificationCCText,
        Bcc = "",
        Subject = string.Empty,
        Headers = new List<string>(),
        Attachments = mappedAttachments,
        ExtraImagesToAppend = emailScreen.ImagesToEmbed()
    };

    await OutSystems.Application.Core.Email.EmailService.Instance.SendEmailAsync(message, sendEmailActivity, cancellationToken);
}
// Append_ADMIN_AREA_CENTRALIZACION
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUsersByApplicationRole_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_c77d66d9ff86c86854dcdb2c4c9f3219 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUserApplicationRole.ssUserId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcUsersToNotify,(await BasicTypeList<string>.ConvertAsync(localVars.varLcl_EmailNotification, new BasicTypeList<string>(), async (ST_12668886130225cd5b17c72a6562dd7cStructure source, string target, CancellationToken cancellationToken) => {
target = source.ssUserId;
return target;
}, cancellationToken)),cancellationToken);

// NewNotification
localVars.resNewNotification_outParamResponse = await ssConectaProveedores.CcNotifications.ActionNewNotification(requestContext,new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure(){ ssuserids = localVars.varLcUsersToNotify, sstitle = (((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="DEV")) ? ("(DEV)") : ((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="QA")) ? ("(QA)") : (""))))+"Comissiones Y Arrendamientos - Cancelación de la Propuesta ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName), sscontent = localVars.inParami_CanceledReason, sscategoryclass = "cancellation" },cancellationToken);

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

public static class FuncActionSendCanceledProposalEmail {

private static async Task<RC_7655e3fb0214830e441b4ca25cd396cb> datasetGetUserExtendedInternalsByRegionIdReadDbAsync(RC_7655e3fb0214830e441b4ca25cd396cb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalsByRegionId" xAu1BDo_90Kz23e4fgisEA of Action "SendCanceledProposalEmail"
public static async Task<(RL_82f8f815f9fb0b6e192e24e072fb8ae2,long)> datasetGetUserExtendedInternalsByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,long qpapUserApplicationRole_ApplicationRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendCanceledProposalEmail.GetUserExtendedInternalsByRegionId", "04b50bc4-3f3a-42f7-b3db-77b87e08ac10");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendCanceledProposalEmail.GetUserExtendedInternalsByRegionId", "04b50bc4-3f3a-42f7-b3db-77b87e08ac10", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.2VttLQMZB0SBLAdrzC7Clw/NodesNotShownInESpaceTree.xAu1BDo_90Kz23e4fgisEA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser27\".\"name\" o1, \"enuser27\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enuserapplicationrole3\".\"userid\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enuserextension15\".\"emailto\" o37");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal17\" Inner JOIN {User} \"enuser27\" ON (\"enuser_extended_internal17\".\"id\" = \"enuser27\".\"id\"))  Left JOIN {UserApplicationRole} \"enuserapplicationrole3\" ON (\"enuser27\".\"id\" = \"enuserapplicationrole3\".\"userid\"))  Left JOIN {UserExtension} \"enuserextension15\" ON (\"enuser27\".\"id\" = \"enuserextension15\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal17\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal17\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal17\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapUserApplicationRole_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enuserapplicationrole3\".\"applicationroleid\" = @qpapUserApplicationRole_ApplicationRoleId) AND (\"enuserapplicationrole3\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapUserApplicationRole_ApplicationRoleId", DbType.Int64, qpapUserApplicationRole_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enuserapplicationrole3\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole3\".\"rolestatusid\" = ");
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
RL_82f8f815f9fb0b6e192e24e072fb8ae2 outParamList = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendCanceledProposalEmail.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_82f8f815f9fb0b6e192e24e072fb8ae2 _tmp = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendCanceledProposalEmail.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_82f8f815f9fb0b6e192e24e072fb8ae2)_tmp;
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

private static async Task<RC_c77d66d9ff86c86854dcdb2c4c9f3219> datasetGetUsersByApplicationRoleReadDbAsync(RC_c77d66d9ff86c86854dcdb2c4c9f3219 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetUsersByApplicationRole" Qf74CWkbvECwdcnWKi0dYw of Action "SendCanceledProposalEmail"
public static async Task<(RL_5d12cbdbc739013acbdd9f1aee86f8c2,long)> datasetGetUsersByApplicationRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendCanceledProposalEmail.GetUsersByApplicationRole", "09f8fe41-1b69-40bc-b075-c9d62a2d1d63");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendCanceledProposalEmail.GetUsersByApplicationRole", "09f8fe41-1b69-40bc-b075-c9d62a2d1d63", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.2VttLQMZB0SBLAdrzC7Clw/NodesNotShownInESpaceTree.Qf74CWkbvECwdcnWKi0dYw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enuser28\".\"name\" o8, \"enuser28\".\"email\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enuserapplicationrole4\".\"userid\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM ((({UserApplicationRole} \"enuserapplicationrole4\" Left JOIN {ApplicationRole} \"enapplicationrole4\" ON (\"enuserapplicationrole4\".\"applicationroleid\" = \"enapplicationrole4\".\"id\"))  Left JOIN {User} \"enuser28\" ON (\"enuserapplicationrole4\".\"userid\" = \"enuser28\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal18\" ON (\"enuser28\".\"id\" = \"enuser_extended_internal18\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enapplicationrole4\".\"code\" = 'ADMIN_AREA_CENTRALIZACION')");
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
RL_5d12cbdbc739013acbdd9f1aee86f8c2 outParamList = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersByApplicationRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendCanceledProposalEmail.GetUsersByApplicationRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d12cbdbc739013acbdd9f1aee86f8c2 _tmp = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersByApplicationRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendCanceledProposalEmail.GetUsersByApplicationRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d12cbdbc739013acbdd9f1aee86f8c2)_tmp;
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

private static async Task<RC_921fd9090c7367c088e0777ee6e3ef28> datasetGetProposalByIdReadDbAsync(RC_921fd9090c7367c088e0777ee6e3ef28 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetProposalById" twQoHG0mjkGKVc91P_Sz2w of Action "SendCanceledProposalEmail"
public static async Task<(RL_9f9acf7f8fbbfb480a215bc421efa609,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendCanceledProposalEmail.GetProposalById", "1c2804b7-266d-418e-8a55-cf753ff4b3db");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendCanceledProposalEmail.GetProposalById", "1c2804b7-266d-418e-8a55-cf753ff4b3db", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.2VttLQMZB0SBLAdrzC7Clw/NodesNotShownInESpaceTree.twQoHG0mjkGKVc91P_Sz2w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enproposal\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enproposal\".\"regionid\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enproposalapprovallevel\".\"applicationroleid\" o29, NULL o30, NULL o31, NULL o32");
fromBuilder.Append(" FROM (({Proposal} \"enproposal\" Left JOIN {ProposalApproval} \"enproposalapproval\" ON (\"enproposal\".\"id\" = \"enproposalapproval\".\"proposalid\"))  Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel\" ON (\"enproposalapproval\".\"id\" = \"enproposalapprovallevel\".\"proposalapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal\".\"id\" = @qpprProposal_Id) AND (\"enproposal\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enproposal\".\"name\" ASC ");
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
RL_9f9acf7f8fbbfb480a215bc421efa609 outParamList = new RL_9f9acf7f8fbbfb480a215bc421efa609();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendCanceledProposalEmail.GetProposalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9f9acf7f8fbbfb480a215bc421efa609 _tmp = new RL_9f9acf7f8fbbfb480a215bc421efa609();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendCanceledProposalEmail.GetProposalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9f9acf7f8fbbfb480a215bc421efa609)_tmp;
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
